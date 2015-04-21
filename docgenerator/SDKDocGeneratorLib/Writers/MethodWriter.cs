using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.XPath;
using System.Xml.Linq;

using SDKDocGenerator.Syntax;

namespace SDKDocGenerator.Writers
{
    public class MethodWriter : MethodBaseWriter
    {
        readonly MethodInfoWrapper _methodInfo;

        public MethodWriter(GenerationManifest artifacts, FrameworkVersion version, MethodInfoWrapper methodInfo)
            : base(artifacts, version, methodInfo)
        {
            this._methodInfo = methodInfo;
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateFilename(this._methodInfo);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_methodInfo.DeclaringType.Namespace);
        }

        protected override string GetTitle()
        {
            var par = FormatParameters(this._methodInfo.GetParameters());
            if (string.IsNullOrEmpty(par))
                return string.Format("{0}.{1} {2}", this._methodInfo.DeclaringType.GetDisplayName(false), this._methodInfo.Name, GetMemberType());

            return string.Format("{0}.{1} {2} ({3})", this._methodInfo.DeclaringType.GetDisplayName(false), 
                                                      this._methodInfo.Name, GetMemberType(), par);
        }

        protected override string GetMemberName()
        {
            var par = FormatParameters(this._methodInfo.GetParameters());
            if (string.IsNullOrEmpty(par))
                return string.Format("{0}.{1}", this._methodInfo.DeclaringType.GetDisplayName(false), this._methodInfo.Name);

            return string.Format("{0}.{1} ({2})", this._methodInfo.DeclaringType.GetDisplayName(false), this._methodInfo.Name, par);
        }

        protected override string GetMemberType()
        {
            return "Method";
        }

        protected override XElement GetSummaryDocumentation()
        {
            var element = NDocUtilities.FindDocumentation(this._currentNDoc, this._methodInfo);
            return element;
        }

        protected override string GetSyntax()
        {
            return new CSharpSyntaxGenerator(this._version).GenerateSyntax(this._methodInfo);
        }

        protected override void AddReturn(System.IO.TextWriter writer)
        {
            var returnType = this._methodInfo.ReturnType;
            if (returnType == null || returnType.FullName == "System.Void")
                return;


            writer.WriteLine("<div class=\"sectionbody\">");
                writer.WriteLine("<div class=\"returnType\">");
                    writer.WriteLine("<strong class=\"subHeading\">Return Value</strong><br />");
                writer.WriteLine("</div>");

                string url, target;
                returnType.GetHelpURL(this._version, out url, out target);

                if (url == null)
                    writer.WriteLine("<div class=\"returnTypeName\">Type: {0}</div>", returnType.GetDisplayName(false));
                else
                    writer.WriteLine("<div class=\"returnTypeName\">Type: <a href=\"{0}\" {2}>{1}</a></div>", url, returnType.GetDisplayName(false), target);

                var ndoc = GetSummaryDocumentation();
                if (ndoc != null)
                {
                    var returnDoc = NDocUtilities.FindReturnDocumentation(ndoc);
                    if (returnDoc != null)
                    {
                        writer.WriteLine("<div class=\"returnTypeDoc\">{0}</div>", returnDoc);
                    }
                }

            writer.WriteLine("</div>");
        }

        protected override void AddSummaryNotes(TextWriter writer)
        {
            if (this._methodInfo.Name.EndsWith("Async", StringComparison.Ordinal))
            {
                const string net35PatternNote = "<div class=\"noteblock\"><div class=\"noteheader\">Note:</div>" +
                                                "<p>This is an asynchronous operation using the standard naming convention for .NET 4.5 or higher. "
                                                + "For .NET 3.5 the operation is implemented as a pair of methods using the standard naming convention of "
                                                + "<b>Begin</b><i>{0}</i> and <b>End</b><i>{0}</i>.</p></div>";

                var name = this._methodInfo.Name.Substring(0, this._methodInfo.Name.Length - 5);
                writer.WriteLine(net35PatternNote, name);
            }
        }
    }
}
