using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml.Linq;

namespace SDKDocGenerator.Writers
{
    public abstract class MemberWriter : BaseWriter
    {
        readonly MemberInfoWrapper _info;

        protected MemberWriter(GenerationManifest artifacts, FrameworkVersion version, MemberInfoWrapper info)
            : base(artifacts, version)
        {
            this._info = info;
        }

        protected abstract string GetSyntax();

        protected override void WriteContent(TextWriter writer)
        {
            AddSummaryDocumentation(writer);
            AddNamespace(writer, this._info.DeclaringType.Namespace, this._info.DeclaringType.ManifestModuleName);

            base.AddSyntax(writer, GetSyntax());

            AddParameters(writer);
            AddReturn(writer);

            AddExceptions(writer);

            AddRemarksDocumentation(writer);
            AddExamples(writer);
            AddVersionInformation(writer, this._info);
        }

        protected virtual void AddParameters(TextWriter writer)
        {

        }

        protected virtual void AddReturn(TextWriter writer)
        {
        }

        protected virtual void AddExceptions(TextWriter writer)
        {
            var ndoc = GetSummaryDocumentation();
            if (ndoc == null)
                return;

            var elements = ndoc.XPathSelectElements("exception");
            if (!elements.Any())
                return;

            var headers = new List<TableColumnHeader>
            {
                new TableColumnHeader {Title = "Exception", CssClass = "nameColumn"},
                new TableColumnHeader {Title = "Condition", CssClass = "descriptionColumn"}
            };

            AddMemberTableSectionHeader(writer, "Exceptions", headers);

            foreach (var element in elements)
            {
                var crossReferencedType = GetCrossReferenceTypeName(element);
                if (string.IsNullOrEmpty(crossReferencedType))
                    continue;

                string condition = element.Value;

                AddException(writer, crossReferencedType, condition);
            }

            AddMemberTableSectionClosing(writer);
        }

        void AddException(TextWriter writer, string typeName, string condition)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            WriteCrossReferenceTagReplacement(writer, typeName);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine(condition);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        protected override string GetTOCID()
        {
            // Have to probe to form up namespace qualified name, as some generic
            // definitions do not have 'FullName' available. This will likely need
            // extending over time.
            var name = this._info.DeclaringType.FullName ?? this._info.DeclaringType.GenericTypeName;

            return name.Replace('.', '_');
        }

    }
}
