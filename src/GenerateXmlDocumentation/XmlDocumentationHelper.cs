using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GenerateXmlDocumentation
{
    abstract class XmlDocumentationHelper
    {
        static Dictionary<string, string> _helpStringDictionary = new Dictionary<string, string>();

        public static void BuildForAssembly(Assembly assembly, Dictionary<string, string> helpStringDictionary)
        {
            if (helpStringDictionary != null)
            {
                _helpStringDictionary = helpStringDictionary;
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(Path.ChangeExtension(assembly.Location, ".xml"), settings))
            {
                writer.WriteStartElement("doc");
                writer.WriteStartElement("assembly");
                writer.WriteElementString("name", assembly.GetName().Name);
                writer.WriteEndElement(); // </assembly>

                WriteMembers(writer, assembly.GetTypes());

                writer.WriteEndElement(); // </doc>
            }
        }

        static void WriteMembers(XmlWriter writer, Type[] types)
        {
            writer.WriteStartElement("members");

            foreach (Type type in types)
            {
                WriteMember(writer, type);

                MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                foreach (MethodInfo method in methods)
                {
                    WriteMember(writer, method);
                }

                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    WriteMember(writer, property);
                }
            }

            writer.WriteEndElement(); // </members>
        }

        static void WriteMember(XmlWriter writer, Type type)
        {
            if (_helpStringDictionary.ContainsKey(type.FullName))
            {
                string memberName = String.Format("T:{0}", type.FullName);
                string summary = _helpStringDictionary[type.FullName];

                if (summary != null)
                {
                    summary = summary.Trim();

                    if (!String.IsNullOrEmpty(summary))
                    {
                        writer.WriteStartElement("member");
                        writer.WriteAttributeString("name", memberName);
                        writer.WriteStartElement("summary");
                        writer.WriteString(summary);
                        writer.WriteEndElement(); //<summary>
                        writer.WriteEndElement(); //<member>
                    }
                }
            }
        }

        static void WriteMember(XmlWriter writer, MethodInfo method)
        {
            if (method.IsSpecialName) return;

            string key = String.Format("{0}.{1}", method.DeclaringType.FullName, method.Name);

            if (_helpStringDictionary.ContainsKey(key))
            {
                string memberName = String.Format("M:{0}(", key);
                string summary = _helpStringDictionary[key];

                if (summary != null)
                {
                    summary = summary.Trim();

                    if (!String.IsNullOrEmpty(summary))
                    {
                        ParameterInfo[] parameters = method.GetParameters();

                        if (parameters.Length > 0)
                        {
                            foreach (ParameterInfo parameter in parameters)
                            {
                                memberName = String.Format("{0}{1},", memberName, parameter.ParameterType.FullName);
                            }

                            memberName = memberName.Substring(0, memberName.Length - 1);
                        }

                        memberName += ")";

                        memberName = memberName.Replace("&", "@");

                        if (!String.IsNullOrEmpty(summary))
                        {
                            writer.WriteStartElement("member");
                            writer.WriteAttributeString("name", memberName);
                            writer.WriteStartElement("summary");
                            writer.WriteString(summary);
                            writer.WriteEndElement(); //<summary>
                            writer.WriteEndElement(); //<member>
                        }
                    }
                }
            }
        }

        static void WriteMember(XmlWriter writer, PropertyInfo property)
        {
            if (property.IsSpecialName) return;

            string key = String.Format("{0}.{1}", property.DeclaringType.FullName, property.Name);

            if (_helpStringDictionary.ContainsKey(key))
            {
                string memberName = String.Format("P:{0}", key);
                string summary = _helpStringDictionary[key];

                if (summary != null)
                {
                    summary = summary.Trim();

                    if (!String.IsNullOrEmpty(summary))
                    {

                        ParameterInfo[] parameters = property.GetIndexParameters();

                        if (parameters.Length > 0)
                        {
                            memberName += "(";
                            foreach (ParameterInfo parameter in parameters)
                            {
                                memberName = String.Format("{0}{1},", memberName, parameter.ParameterType.FullName);
                            }

                            memberName = memberName.Substring(0, memberName.Length - 1);
                            memberName += ")";
                        }

                        memberName = memberName.Replace("&", "@");

                        if (!String.IsNullOrEmpty(summary))
                        {
                            writer.WriteStartElement("member");
                            writer.WriteAttributeString("name", memberName);
                            writer.WriteStartElement("summary");
                            writer.WriteString(summary);
                            writer.WriteEndElement(); //<summary>
                            writer.WriteEndElement(); //<member>
                        }
                    }
                }
            }
        }
    }
}
