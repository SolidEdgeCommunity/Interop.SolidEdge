using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interop.SolidEdge.Merge
{
    abstract class ILHelper
    {
        public static void ModifyILForNET20(string ilPath)
        {
            List<string> list = new List<string>();
            string[] lines = File.ReadAllLines(ilPath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (line.StartsWith(".assembly extern mscorlib"))
                {
                    list.Add(line);
                    do
                    {
                        line = lines[++i];

                        if (line.Trim().StartsWith(".ver"))
                        {
                            line = "  .ver 2:0:0:0";
                        }

                        list.Add(line);
                    } while (!line.Contains(".ver"));
                }
                else if (line.Contains("TargetFrameworkAttribute"))
                {
                    do
                    {
                        line = lines[++i];
                    } while (!line.Contains(')'));
                }
                else
                {
                    list.Add(line);
                }
            }

            File.WriteAllLines(ilPath, list.ToArray());
        }

        public static ILClassDeclaration[] GetAllILClassDeclarations(string ilPath)
        {
            List<ILClassDeclaration> classDeclarationList = new List<ILClassDeclaration>();

            ILClassDeclaration classDeclaration = null;

            string[] lines = File.ReadAllLines(ilPath);

            List<string> referencedAssemblyNames = new List<string>();

            foreach (string line in lines)
            {
                if (line.StartsWith(".assembly extern"))
                {
                    string referencedAssemblyName = line.Substring(line.LastIndexOf(' ') + 1);
                    if (referencedAssemblyName.StartsWith("Interop.", StringComparison.OrdinalIgnoreCase))
                    {
                        referencedAssemblyNames.Add(referencedAssemblyName);
                    }
                }

                if (line.StartsWith(".class"))
                {
                    classDeclaration = new ILClassDeclaration(ilPath);
                    classDeclaration.Lines.Add(line);
                }
                else if (line.StartsWith("}"))
                {
                    if (classDeclaration != null)
                    {
                        classDeclaration.Lines.Add(line);
                        classDeclarationList.Add(classDeclaration);
                        classDeclaration = null;
                    }
                }
                else
                {
                    if (classDeclaration != null)
                    {
                        classDeclaration.Lines.Add(line);
                    }
                }
            }

            RemoveReferencedInteropAssemblies(classDeclarationList.ToArray(), referencedAssemblyNames.ToArray());

            return classDeclarationList.ToArray();
        }

        static void RemoveReferencedInteropAssemblies(ILClassDeclaration[] classDeclarations, string[] referencedAssemblyNames)
        {
            foreach (string referencedAssemblyName in referencedAssemblyNames)
            {
                string token = String.Format("[{0}]", referencedAssemblyName);

                foreach (ILClassDeclaration classDeclaration in classDeclarations)
                {
                    for (int i = 0; i < classDeclaration.Lines.Count; i++)
                    {
                        if (classDeclaration.Lines[i].Contains(token))
                        {
                            classDeclaration.Lines[i] = classDeclaration.Lines[i].Replace(token, String.Empty);
                        }
                    }
                }
            }
        }

        public static void RemoveInteropAssemblyReferences(ILClassDeclaration[] classDeclarations)
        {
            foreach (ILClassDeclaration classDeclaration in classDeclarations)
            {
            }
        }
    }
}
