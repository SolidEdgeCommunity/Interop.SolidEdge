using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Interop.SolidEdge.Merge
{
    class Program
    {
        static ILog _log = LogManager.GetLogger(typeof(Program));
        static FileInfo _targetPath;
        static DirectoryInfo _targetDir;
        static DirectoryInfo _mergeTargetDir;
        static string _ildasmPath;
        static string _ilasmPath;
        static FileInfo _destinationIL;
        static FileInfo _destinationRES;
        static FileInfo _destinationDLL;
        //static FileInfo _destinationLOG;
        static Assembly _interopAssembly;

        static void Main(string[] args)
        {
            // args[0] should be $(TargetPath)
            if (args.Length == 1)
            {
                _targetPath = new FileInfo(args[0]);

                if (_targetPath.Exists)
                {
                    _targetDir = _targetPath.Directory;
                    _interopAssembly = Assembly.ReflectionOnlyLoadFrom(_targetPath.FullName);

                    ConfigureEnvironment();
                    DoMerge();
                }
                else
                {
                    Console.WriteLine("$(TargetPath) {0} does not exist", args[0]);
                }
            }
        }

        static void ConfigureEnvironment()
        {
            Environment.CurrentDirectory = _targetDir.FullName;
            log4net.GlobalContext.Properties["LogName"] = Path.Combine(_targetDir.FullName, "Interop.SolidEdge.Merge.log");
            XmlConfigurator.Configure();

            _ildasmPath = ConfigurationManager.AppSettings["ILDASM_EXE_PATH"];

            if (_interopAssembly.ImageRuntimeVersion.Equals("v2.0.50727"))
            {
                _mergeTargetDir = _targetDir.CreateSubdirectory("net20");
                _ilasmPath = ConfigurationManager.AppSettings["ILASM_EXE_PATH_NET20"];
            }
            else if (_interopAssembly.ImageRuntimeVersion.Equals("v4.0.30319"))
            {
                _mergeTargetDir = _targetDir.CreateSubdirectory("net40");
                _ilasmPath = ConfigurationManager.AppSettings["ILASM_EXE_PATH_NET40"];
            }

            _destinationIL = new FileInfo(Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.il"));
            _destinationRES = new FileInfo(Path.Combine(_mergeTargetDir.FullName, Path.ChangeExtension(_targetPath.Name, ".res")));
            _destinationDLL = new FileInfo(Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.dll"));
            //_destinationLOG = new FileInfo(Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.log"));
        }

        static void DoMerge()
        {
            FileInfo[] interopDLLs = _targetDir.GetFiles("Interop.*.dll", SearchOption.TopDirectoryOnly);
            FileInfo[] interopILs = null;

            Cleanup("Interop.*.il");
            Cleanup("Interop.*.res");
            //Cleanup("Interop.*.log");

            List<string> hiddenTypes = new List<string>();
            hiddenTypes.AddRange(TypeLibraryHelper.GetInteropAssembliesHiddenTypes(interopDLLs));

            // We're only interested in hidden types that are named with a leading '_'.
            hiddenTypes.RemoveAll(x => !x.Contains("._"));

            Dictionary<string, string> helpStringDictionary = TypeLibraryHelper.GetInteropAssembliesHelpStrings(interopDLLs);

            interopILs = ExtractInteropIL(interopDLLs);
            CombineIL(interopILs, hiddenTypes.ToArray());
            ModifyIL();
            FileInfo interopDLL = CompileIL();

            BuildXmlDocumentation(interopDLL, helpStringDictionary);

        }

        static void Cleanup(string searchPattern)
        {
            FileInfo[] files = _mergeTargetDir.GetFiles(searchPattern, SearchOption.TopDirectoryOnly);
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
        }

        static FileInfo[] ExtractInteropIL(FileInfo[] interopDLLs)
        {
            List<FileInfo> interopILs = new List<FileInfo>();

            foreach (FileInfo interopDll in interopDLLs)
            {
                FileInfo interopIL = new FileInfo(Path.Combine(_mergeTargetDir.FullName, Path.ChangeExtension(interopDll.Name, ".il")));

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = _ildasmPath;
                psi.Arguments = String.Format("{0} /output:{1}", interopDll.FullName, interopIL.FullName);
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;

                Console.WriteLine("Extracting {0}.", interopIL.Name);

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                }

                interopILs.Add(interopIL);
            }

            return interopILs.ToArray();
        }

        static void CombineIL(FileInfo[] interopILs, string[] hiddenTypes)
        {
            List<ILClassDeclaration> classDeclarationList = new List<ILClassDeclaration>();

            // Exclude Interop.SolidEdge.il.
            var filteredInteropILs = interopILs.Where(x => !x.Name.Equals("Interop.SolidEdge.il"));

            foreach (FileInfo interopIL in filteredInteropILs)
            {
                classDeclarationList.AddRange(ILHelper.GetAllILClassDeclarations(interopIL.FullName));
            }

            List<string> outLines = new List<string>();

            outLines.Add(String.Empty);

            foreach (ILClassDeclaration classDeclaration in classDeclarationList)
            {
                if (!hiddenTypes.Contains(classDeclaration.FullName))
                {
                    outLines.AddRange(classDeclaration.Lines);
                    outLines.Add(String.Empty);
                }
                else
                {
                    //Console.WriteLine("Excluded {0} because it is hidden.", classDeclaration.FullName);
                    _log.InfoFormat("Excluded {0} because it is hidden.", classDeclaration.FullName);
                }
            }

            var outInteropIL = Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.il");

            File.AppendAllLines(outInteropIL, outLines.ToArray());
        }

        static void ModifyIL()
        {
            string _SolidEdgeFramework_Application_Definition = ".class interface public abstract auto ansi import SolidEdgeFramework.Application";
            string _SolidEdgeFramework_ApplicationCoClassAttribute = "  .custom instance void [mscorlib]System.Runtime.InteropServices.CoClassAttribute::.ctor(class [mscorlib]System.Type) = ( 01 00 23 53 6F 6C 69 64 45 64 67 65 46 72 61 6D 65 77 6F 72 6B 2E 41 70 70 6C 69 63 61 74 69 6F 6E 43 6C 61 73 73 00 00 )";

            var outInteropIL = Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.il");

            List<string> ilLines = new List<string>(File.ReadAllLines(outInteropIL));

            int index = ilLines.FindIndex(x => x.Equals(_SolidEdgeFramework_Application_Definition));

            if (index > 0)
            {
                index += 2;
                ilLines.Insert(index, _SolidEdgeFramework_ApplicationCoClassAttribute);
            }
            else
            {
                // If we get here, we did not find the SolidEdgeFramework.Application definition.
                System.Diagnostics.Debugger.Break();
            }

            File.WriteAllLines(outInteropIL, ilLines.ToArray());
        }

        //static FileInfo CompileIL20()
        //{
        //    FileInfo destinationIL = new FileInfo(Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.il"));
        //    FileInfo destinationRES = new FileInfo(Path.Combine(_mergeTargetDir.FullName, Path.ChangeExtension(_targetPath.Name, ".res")));
        //    FileInfo destinationDLL = new FileInfo(Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.dll"));
        //    FileInfo destinationLOG = new FileInfo(Path.Combine(_mergeTargetDir.FullName, "Interop.SolidEdge.log"));

        //    ILHelper.ModifyILForNET20(destinationIL.FullName);

        //    ProcessStartInfo psi = new ProcessStartInfo();
        //    psi.WorkingDirectory = _mergeTargetDir.FullName;
        //    psi.FileName = _ilasmPath20;
        //    psi.Arguments = String.Format("{0} /dll /resource:{1} /output:{2}", destinationIL.FullName, destinationRES.FullName, destinationDLL.FullName);
        //    psi.UseShellExecute = false;
        //    psi.RedirectStandardOutput = true;

        //    Console.WriteLine("Compiling {0}.", destinationIL.Name);

        //    using (Process process = Process.Start(psi))
        //    {
        //        string output = process.StandardOutput.ReadToEnd();
        //        process.WaitForExit();
        //        File.WriteAllText(destinationLOG.FullName, output);
        //    }

        //    return destinationDLL;
        //}

        static FileInfo CompileIL()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.WorkingDirectory = _mergeTargetDir.FullName;
            psi.FileName = _ilasmPath;
            psi.Arguments = String.Format("{0} /dll /resource:{1} /output:{2}", _destinationIL.FullName, _destinationRES.FullName, _destinationDLL.FullName);
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;

            Console.WriteLine("Compiling {0}.", _destinationIL.Name);

            _log.InfoFormat("Executing {0} {1}", psi.FileName, psi.Arguments);

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                //File.WriteAllText(_destinationLOG.FullName, output);
                _log.Info(output);
            }

            return _destinationDLL;
        }

        static void BuildXmlDocumentation(FileInfo interopDLL, Dictionary<string, string> helpStringDictionary)
        {
            Assembly assembly = Assembly.LoadFrom(interopDLL.FullName);
            XmlDocumentationHelper.BuildForAssembly(assembly, helpStringDictionary);
        }
    }
}
