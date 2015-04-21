using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDocGenerator.Writers
{
    public class NamespaceWriter : BaseWriter
    {
        readonly string _namespaceName;
        readonly AssemblyWrapper _assemblyWrapper;

        public NamespaceWriter(GenerationManifest artifacts, FrameworkVersion version, string namespaceName)
            : base(artifacts, version)
        {
            this._namespaceName = namespaceName;
            this._assemblyWrapper = artifacts.AssemblyWrapper;
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateNamespaceFilename(this._namespaceName);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_namespaceName);
        }

        protected override string GetTitle()
        {
            return string.Format("{0} {1}", GetMemberName(), GetMemberType());
        }

        protected override string GetMemberName()
        {
            return this._namespaceName;
        }

        protected override string GetMemberType()
        {
            return "Namespace";
        }

        protected override void WriteContent(System.IO.TextWriter writer)
        {
            AddClasses(writer);
            AddStructures(writer);
            AddInterfaces(writer);
            AddEnums(writer);
        }

        protected override System.Xml.Linq.XElement GetSummaryDocumentation()
        {
            return null;
        }

        void AddClasses(TextWriter writer)
        {
            var constructors = this._assemblyWrapper.GetTypesForNamespace(this._namespaceName).Where(x => x.IsPublic && x.IsClass);
            if (!constructors.Any())
                return;

            AddMemberTableSectionHeader(writer, "Classes");
            foreach (var info in constructors.OrderBy(x => x.Name))
            {
                AddRow(writer, info, "class");
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddStructures(TextWriter writer)
        {
            var constructors = this._assemblyWrapper.GetTypesForNamespace(this._namespaceName).Where(x => x.IsPublic && x.IsStructure);
            if (!constructors.Any())
                return;

            AddMemberTableSectionHeader(writer, "Structures");
            foreach (var info in constructors.OrderBy(x => x.Name))
            {
                AddRow(writer, info, "struct");
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddInterfaces(TextWriter writer)
        {
            var constructors = this._assemblyWrapper.GetTypesForNamespace(this._namespaceName).Where(x => x.IsPublic && x.IsInterface);
            if (!constructors.Any())
                return;

            AddMemberTableSectionHeader(writer, "Interfaces");
            foreach (var info in constructors.OrderBy(x => x.Name))
            {
                AddRow(writer, info, "interface");
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddEnums(TextWriter writer)
        {
            var constructors = this._assemblyWrapper.GetTypesForNamespace(this._namespaceName).Where(x => x.IsPublic && x.IsEnum);
            if (!constructors.Any())
                return;

            AddMemberTableSectionHeader(writer, "Enums");
            foreach (var info in constructors.OrderBy(x => x.Name))
            {
                AddRow(writer, info, "enum");
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddRow(TextWriter writer, TypeWrapper info, string cssImageClass)
        {
            writer.WriteLine("<tr>");

                // funky but works
                var imageClassDisplayName = string.Format("{0}{1}", cssImageClass.Substring(0, 1).ToUpper(), cssImageClass.Substring(1));

                writer.WriteLine("<td>");
                writer.WriteLine("<img class=\"{0}\" src=\"{2}/resources/blank.gif\" title=\"{1}\" alt=\"{1}\"/>", cssImageClass, imageClassDisplayName, RootRelativePath);
                writer.WriteLine("</td>");

                writer.WriteLine("<td>");
                    writer.WriteLine("<a href=\"./{0}\">{1}</a>", FilenameGenerator.GenerateFilename(info), info.GetDisplayName(false));
                writer.WriteLine("</td>");

                writer.WriteLine("<td>");

                    var docs = NDocUtilities.FindDocumentation(this._currentNDoc, info);
                    var html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.AssemblyWrapper, this._version);

                    writer.WriteLine(html);
                writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        protected override string GetTOCID()
        {
            return this._namespaceName.Replace('.', '_');
        }
    }
}
