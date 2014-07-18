using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GenerateInteropDocumentation
{
    class Program
    {
        [DllImport("oleaut32.dll", CharSet = CharSet.Unicode)]
        static extern int LoadTypeLib(string szFile, out ITypeLib typeLib);

        [DllImport("oleaut32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        static extern ITypeLib LoadRegTypeLib(ref Guid rguid, int wVerMajor, int wVerMinor, int lcid);

        static FileInfo _targetPath;
        static DirectoryInfo _targetDir;

        static int Main(string[] args)
        {
            try
            {
                // args[0] should be $(TargetPath)
                if (args.Length == 1)
                {
                    _targetPath = new FileInfo(args[0]);

                    if (_targetPath.Exists)
                    {
                        _targetDir = _targetPath.Directory;

                        foreach (FileInfo fileInfo in _targetDir.EnumerateFiles("Interop.*.dll", SearchOption.TopDirectoryOnly))
                        {
                            Console.WriteLine("Building documentation for {0}.", fileInfo.FullName);
                            if (fileInfo.Name.Equals(_targetPath.Name, StringComparison.OrdinalIgnoreCase))
                            {
                                // Skip Interop.SolidEdge.dll.
                                continue;
                            }

                            var interopAssembly = Assembly.LoadFrom(fileInfo.FullName);
                            GenerateDocumentation(interopAssembly);
                        }

                        return 0;
                    }
                    else
                    {
                        throw new System.Exception(String.Format("$(TargetPath) {0} does not exist", args[0]));
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return -1;
        }

        static void GenerateDocumentation(Assembly assembly)
        {
            var dictionary = GetHelpStrings(assembly);
            XmlDocumentationHelper.BuildForAssembly(assembly, dictionary);
        }

        public static Dictionary<string, string> GetHelpStrings(Assembly assembly)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            var a = assembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(ImportedFromTypeLibAttribute)));
            var b = assembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(GuidAttribute)));
            var c = assembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(TypeLibVersionAttribute)));

            if (a != null)
            {
                Guid guid = Guid.Parse(String.Format("{0}", b.ConstructorArguments[0].Value));
                int wVerMajor = (int)c.ConstructorArguments[0].Value;
                int wVerMinor = (int)c.ConstructorArguments[1].Value;

                ITypeLib typeLib = null;
                typeLib = LoadRegTypeLib(ref guid, wVerMajor, wVerMinor, 0);

                string strLibName = null;
                string strLibDocString = null;
                int dwLibHelpContext = 0;
                string strLibHelpFile = null;

                typeLib.GetDocumentation(-1, out strLibName, out strLibDocString, out dwLibHelpContext, out strLibHelpFile);

                int count = typeLib.GetTypeInfoCount();

                // Loop through types.
                for (int i = 0; i < count; i++)
                {
                    ITypeInfo typeInfo = null;
                    typeLib.GetTypeInfo(i, out typeInfo);

                    IntPtr pTypeAttr = IntPtr.Zero;

                    typeInfo.GetTypeAttr(out pTypeAttr);
                    System.Runtime.InteropServices.ComTypes.TYPEATTR typeAttr = (System.Runtime.InteropServices.ComTypes.TYPEATTR)Marshal.PtrToStructure(pTypeAttr, typeof(System.Runtime.InteropServices.ComTypes.TYPEATTR));

                    // Skip type if it is hidden.
                    if (typeAttr.wTypeFlags.HasFlag(System.Runtime.InteropServices.ComTypes.TYPEFLAGS.TYPEFLAG_FHIDDEN) == true)
                    {
                        continue;
                    }

                    string strTypeName = null;
                    string strTypeDocString = null;
                    int dwTypeHelpContext = 0;
                    string strTypeHelpFile = null;

                    typeInfo.GetDocumentation(-1, out strTypeName, out strTypeDocString, out dwTypeHelpContext, out strTypeHelpFile);

                    string typeKey = String.Format("{0}.{1}", strLibName, strTypeName);
                    dictionary.Add(typeKey, strTypeDocString);

                    for (int j = 0; j < typeAttr.cFuncs; j++)
                    {
                        IntPtr pFuncDesc = IntPtr.Zero;
                        typeInfo.GetFuncDesc(j, out pFuncDesc);

                        System.Runtime.InteropServices.ComTypes.FUNCDESC funcDesc = (System.Runtime.InteropServices.ComTypes.FUNCDESC)Marshal.PtrToStructure(pFuncDesc, typeof(System.Runtime.InteropServices.ComTypes.FUNCDESC));

                        string strMemberName = null;
                        string strMemberDocString = null;
                        int dwMemberHelpContext = 0;
                        string strMemberHelpFile = null;

                        typeInfo.GetDocumentation(funcDesc.memid, out strMemberName, out strMemberDocString, out dwMemberHelpContext, out strMemberHelpFile);

                        string memberKey = String.Format("{0}.{1}", typeKey, strMemberName);

                        if (!dictionary.ContainsKey(memberKey))
                        {
                            dictionary.Add(memberKey, strMemberDocString);
                        }

                        typeInfo.ReleaseFuncDesc(pFuncDesc);
                    }

                    typeInfo.ReleaseTypeAttr(pTypeAttr);

                }
            }

            return dictionary;
        }
    }
}
