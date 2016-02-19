using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using SDKDocGenerator.Syntax;

namespace SDKDocGenerator.Writers
{
    public class ClassWriter : BaseWriter
    {
        readonly TypeWrapper _versionType;

        public ClassWriter(GenerationManifest artifacts, FrameworkVersion version, TypeWrapper versionType)
            : base(artifacts, version)
        {
            _versionType = versionType;
            _version = version;
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateFilename(this._versionType);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_versionType.Namespace);
        }

        protected override string GetTitle()
        {
            return string.Format("{0} {1}", GetMemberName(), GetMemberType());
        }

        protected override string GetMemberName()
        {
            return this._versionType.GetDisplayName(false);
        }

        protected override string GetMemberType()
        {
            if (this._versionType.IsInterface)
                return "Interface";

            if (this._versionType.IsStructure)
                return "Structure";

            if (this._versionType.IsEnum)
                return "Enumeration";

            return "Class";
        }

        protected override void WriteContent(TextWriter writer)
        {
            AddSummaryDocumentation(writer);
            AddInheritanceHierarchy(writer);
            AddNamespace(writer, this._versionType.Namespace, this._versionType.ManifestModuleName);

            AddSyntax(writer);

            writer.WriteLine("<p>The {0} type exposes the following members</p>", this._versionType.GetDisplayName(false));

            if (this._versionType.IsEnum)
            {
                AddEnumMembers(writer);
            }
            else
            {
                AddConstructors(writer);
                AddProperties(writer);
                AddMethods(writer);
                AddEvents(writer);
                AddFields(writer);
                AddExamples(writer);
            }

            AddRemarksDocumentation(writer);
            AddVersionInformation(writer, this._versionType);
        }

        protected override XElement GetSummaryDocumentation()
        {
            var element = NDocUtilities.FindDocumentation(this._currentNDoc, this._versionType);
            return element;
        }

        private void AddInheritanceHierarchy(TextWriter writer)
        {
            IList<TypeWrapper> types = new List<TypeWrapper>();

            var current = this._versionType;
            while (current != null)
            {
                types.Add(current);
                current = current.BaseType;
            }

            AddSectionHeader(writer, "Inheritance Hierarchy");

            int level = 0;
            foreach (var type in types.Reverse())
            {
                for (int i = 0; i < level * 2; i++)
                {
                    writer.Write("&nbsp;");
                }

                if (type.FullName == this._versionType.FullName)
                    writer.WriteLine("{0}.{1}", type.Namespace, type.GetDisplayName(false));
                else
                {
                    string url, target;
                    type.GetHelpURL(this._version, out url, out target);
                    if (url == null)
                        writer.WriteLine(type.FullName);
                    else
                        writer.WriteLine("<a href=\"{0}\" {1}>{2}.{3}</a>", url, target, type.Namespace, type.GetDisplayName(false));
                }

                writer.WriteLine("<br />");

                ++level;
            }

            AddSectionClosing(writer);
        }

        void AddConstructors(TextWriter writer)
        {
            var constructors = this._versionType.GetConstructors().Where(x => x.IsPublic);
            if (!constructors.Any())
                return;
            AddMemberTableSectionHeader(writer, "Constructors");
            foreach (var info in constructors.OrderBy(x => x.Name))
            {
                AddConstructor(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddConstructor(TextWriter writer, ConstructorInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"publicMethod\" src=\"{0}/resources/blank.gif\" title=\"Public Method\" alt=\"Public Method\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Method\" alt=\"Static Method\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            var filename = FilenameGenerator.GenerateFilename(info);
            var parameters = FormatParameters(info.GetParameters());
            var hrefLink = string.Format("<a href=\"./{0}\">{1}({2})</a>", filename, info.DeclaringType.Name, parameters);
            writer.WriteLine(hrefLink);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            var docs = NDocUtilities.FindDocumentation(this._currentNDoc, info);
            var html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", this.Artifacts.AssemblyWrapper, this._version);

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        void AddProperties(TextWriter writer)
        {
            var properties = this._versionType.GetProperties().Where(x => x.IsPublic);
            if (!properties.Any())
                return;

            AddMemberTableSectionHeader(writer, "Properties", PropertiesTableColumnHeaders);
            foreach (var info in properties.OrderBy(x => x.Name))
            {
                AddProperty(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }


        void AddProperty(TextWriter writer, PropertyInfoWrapper propertyInfo)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"publicProperty\" src=\"{0}/resources/blank.gif\" title=\"Public Property\" alt=\"Public Property\"/>", RootRelativePath);
            if (propertyInfo.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Property\" alt=\"Static Property\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine(propertyInfo.Name);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.Write(ConstructTypeInfoLinkContent(propertyInfo.PropertyType));
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            if (_versionType.Namespace != propertyInfo.DeclaringType.Namespace)
            {
                html = string.Format("Inherited from {0}.{1}.", propertyInfo.DeclaringType.Namespace, propertyInfo.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(this._currentNDoc, propertyInfo);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.AssemblyWrapper, this._version);
            }

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        void AddMethods(TextWriter writer)
        {
            var methods = this._versionType.GetMethodsToDocument();
            if (!methods.Any())
                return;
            AddMemberTableSectionHeader(writer, "Methods");

            const string net35PatternNote = "<div class=\"noteblock\"><div class=\"noteheader\">Note:</div>" +
                                            "<p>Asynchronous operations (methods ending with <i>Async</i>) in the table below are for .NET 4.5 or higher. "
                                            + "For .NET 3.5 the SDK follows the standard naming convention of <b>Begin</b><i>MethodName</i> and <b>End</b><i>MethodName</i> to "
                                            + "indicate asynchronous operations - these method pairs are not shown in the table below.</p></div>";

            writer.WriteLine(net35PatternNote);
            foreach (var info in methods.OrderBy(x => x.Name))
            {
                AddMethod(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddMethod(TextWriter writer, MethodInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"publicMethod\" src=\"{0}/resources/blank.gif\" title=\"Public Method\" alt=\"Public Method\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Method\" alt=\"Static Method\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine("<a href=\"{0}/items/{1}/{2}\">{3}({4})</a>",
                RootRelativePath,
                GenerationManifest.OutputSubFolderFromNamespace(info.DeclaringType.Namespace),
                FilenameGenerator.GenerateFilename(info),
                info.Name,
                FormatParameters(info.GetParameters()));
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            if (_versionType.Namespace != info.DeclaringType.Namespace)
            {
                html = string.Format("Inherited from {0}.{1}.", info.DeclaringType.Namespace, info.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(this._currentNDoc, info);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.AssemblyWrapper, this._version);
            }
            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        void AddFields(TextWriter writer)
        {
            var fields = this._versionType.GetFields();
            if (!fields.Any())
                return;

            AddMemberTableSectionHeader(writer, "Fields", FieldTableColumnHeaders);
            foreach (var info in fields.OrderBy(x => x.Name))
            {
                AddField(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddField(TextWriter writer, FieldInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"field\" src=\"{0}/resources/blank.gif\" title=\"Field\" alt=\"Field\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Field\" alt=\"Static Field\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>{0}</td>", info.Name);

            writer.WriteLine("<td>");
            writer.Write(ConstructTypeInfoLinkContent(info.FieldType));
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            if (_versionType.Namespace != info.DeclaringType.Namespace)
            {
                html = string.Format("Inherited from {0}.{1}.", info.DeclaringType.Namespace, info.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(this._currentNDoc, info);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.AssemblyWrapper, this._version);
            }

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        void AddEvents(TextWriter writer)
        {
            var fields = this._versionType.GetEvents();
            if (!fields.Any())
                return;
            AddMemberTableSectionHeader(writer, "Events");
            foreach (var info in fields.OrderBy(x => x.Name))
            {
                AddEvent(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddEvent(TextWriter writer, EventInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"event\" src=\"{0}/resources/blank.gif\" title=\"Event\" alt=\"Event\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Event\" alt=\"Static Event\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine("<a href=\"{0}/items/{1}/{2}\">{3}</a>",
                RootRelativePath,
                GenerationManifest.OutputSubFolderFromNamespace(info.DeclaringType.Namespace),
                FilenameGenerator.GenerateFilename(info),
                info.Name);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            if (_versionType.Namespace != info.DeclaringType.Namespace)
            {
                html = string.Format("Inherited from {0}.{1}.", info.DeclaringType.Namespace, info.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(this._currentNDoc, info);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.AssemblyWrapper, this._version);
            }

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        public void AddEnumMembers(TextWriter writer)
        {
            var enumNames = this._versionType.GetEnumNames();
            if (!enumNames.Any())
                return;

            AddMemberTableSectionHeader(writer, "Members");
            foreach (var name in enumNames.OrderBy(x => x))
            {
                AddEnumMember(writer, name);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddEnumMember(TextWriter writer, string enumName)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"field\" src=\"{0}/resources/blank.gif\" title=\"Enum\" alt=\"Enum\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine(enumName);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            var docs = NDocUtilities.FindFieldDocumentation(this._currentNDoc, this._versionType, enumName);
            var html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.AssemblyWrapper, this._version);

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        /// <summary>
        /// Constructs href markup, enclosed in a span, to the page containing the details of the 
        /// specified type (this can be external to AWS documentation) as well as in another service.
        /// </summary>
        /// <param name="typeWrapper"></param>
        string ConstructTypeInfoLinkContent(TypeWrapper typeWrapper)
        {
            var sb = new StringBuilder("<span>");
            sb.Append(PropertyWriter.EmitTypeLinkMarkup(typeWrapper, _version));
            if (typeWrapper.IsGenericType)
            {
                sb.Append(PropertyWriter.ProcessGenericParameterTypes(typeWrapper.GenericTypeArguments(), _version));
            }
            sb.Append("</span>");

            return sb.ToString();
        }

        protected void AddSyntax(TextWriter writer)
        {
            var csharpSyntax = new CSharpSyntaxGenerator(this._version).GenerateSyntax(this._versionType);
            base.AddSyntax(writer, csharpSyntax);
        }

        protected override string GetTOCID()
        {
            return this._versionType.FullName.Replace('.', '_');
        }

    }
}
