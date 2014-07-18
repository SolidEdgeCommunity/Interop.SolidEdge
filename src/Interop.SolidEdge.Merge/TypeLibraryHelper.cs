using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Interop.SolidEdge.Merge
{
    abstract class TypeLibraryHelper
    {
        [DllImport("oleaut32.dll", CharSet = CharSet.Unicode)]
        static extern int LoadTypeLib(string szFile, out ITypeLib typeLib);

        [DllImport("oleaut32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        static extern ITypeLib LoadRegTypeLib(ref Guid rguid, int wVerMajor, int wVerMinor, int lcid);

        #region Hidden types

        public static string[] GetInteropAssembliesHiddenTypes(FileInfo[] interopDLLs)
        {
            List<string> list = new List<string>();

            foreach (FileInfo interopDLL in interopDLLs)
            {
                Assembly assembly = Assembly.ReflectionOnlyLoadFrom(interopDLL.FullName);
                list.AddRange(GetInteropAssemblyHiddenTypes(assembly));
            }

            return list.ToArray();
        }

        public static string[] GetInteropAssemblyHiddenTypes(Assembly interopAssembly)
        {
            List<string> list = new List<string>();

            try
            {
                if (interopAssembly.ReflectionOnly)
                {
                    var a = interopAssembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(ImportedFromTypeLibAttribute)));
                    var b = interopAssembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(GuidAttribute)));
                    var c = interopAssembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(TypeLibVersionAttribute)));

                    if (a != null)
                    {
                        Guid guid = Guid.Parse(String.Format("{0}", b.ConstructorArguments[0].Value));
                        int wVerMajor = (int)c.ConstructorArguments[0].Value;
                        int wVerMinor = (int)c.ConstructorArguments[1].Value;

                        list.AddRange(GetHiddenTypes(guid, wVerMajor, wVerMinor, 0));
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list.ToArray();
        }

        public static string[] GetHiddenTypes(string tlbPath)
        {
            ITypeLib typeLib = null;
            Marshal.ThrowExceptionForHR(LoadTypeLib(tlbPath, out typeLib));

            return GetHiddenTypes(typeLib);
        }

        public static string[] GetHiddenTypes(Guid guid, int wVerMajor, int wVerMinor, int lcid)
        {
            ITypeLib typeLib = null;
            typeLib = LoadRegTypeLib(ref guid, wVerMajor, wVerMinor, lcid);

            return GetHiddenTypes(typeLib);
        }

        public static string[] GetHiddenTypes(ITypeLib typeLib)
        {
            List<string> list = new List<string>();

            string strLibName = null;
            string strLibDocString = null;
            int dwLibHelpContext = 0;
            string strLibHelpFile = null;

            typeLib.GetDocumentation(-1, out strLibName, out strLibDocString, out dwLibHelpContext, out strLibHelpFile);

            int count = typeLib.GetTypeInfoCount();
            for (int i = 0; i < count; i++)
            {
                ITypeInfo typeInfo = null;
                typeLib.GetTypeInfo(i, out typeInfo);

                IntPtr pTypeAttr = IntPtr.Zero;

                typeInfo.GetTypeAttr(out pTypeAttr);
                System.Runtime.InteropServices.ComTypes.TYPEATTR typeAttr = (System.Runtime.InteropServices.ComTypes.TYPEATTR)Marshal.PtrToStructure(pTypeAttr, typeof(System.Runtime.InteropServices.ComTypes.TYPEATTR));

                // Check for hidden flag.
                if ((typeAttr.wTypeFlags & System.Runtime.InteropServices.ComTypes.TYPEFLAGS.TYPEFLAG_FHIDDEN) == System.Runtime.InteropServices.ComTypes.TYPEFLAGS.TYPEFLAG_FHIDDEN)
                {
                    string strTypeName = null;
                    string strTypeDocString = null;
                    int dwTypeHelpContext = 0;
                    string strTypeHelpFile = null;

                    typeInfo.GetDocumentation(-1, out strTypeName, out strTypeDocString, out dwTypeHelpContext, out strTypeHelpFile);

                    list.Add(String.Format("{0}.{1}", strLibName, strTypeName));
                }

                typeInfo.ReleaseTypeAttr(pTypeAttr);

            }

            return list.ToArray();
        }

        #endregion

        #region Help strings

        public static Dictionary<string, string> GetInteropAssembliesHelpStrings(FileInfo[] interopDLLs)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            foreach (FileInfo interopDLL in interopDLLs)
            {
                try
                {
                    Assembly interopAssembly = Assembly.ReflectionOnlyLoadFrom(interopDLL.FullName);

                    var a = interopAssembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(ImportedFromTypeLibAttribute)));
                    var b = interopAssembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(GuidAttribute)));
                    var c = interopAssembly.CustomAttributes.FirstOrDefault(x => x.AttributeType.Equals(typeof(TypeLibVersionAttribute)));

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
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return dictionary;
        }

        #endregion
    }
}
