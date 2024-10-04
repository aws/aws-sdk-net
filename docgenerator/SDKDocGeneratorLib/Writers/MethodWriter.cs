using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Text.RegularExpressions;

using SDKDocGenerator.Syntax;

namespace SDKDocGenerator.Writers
{
    public class MethodWriter : MethodBaseWriter
    {
        readonly MethodInfoWrapper _methodInfo;
        readonly bool _isFakeAsync;
        readonly bool _hasAsyncVersion;

        public MethodWriter(GenerationManifest artifacts, FrameworkVersion version, MethodInfoWrapper methodInfo)
            : base(artifacts, version, methodInfo)
        {
            this._methodInfo = methodInfo;
            
            this._isFakeAsync = this._methodInfo.FullName == "Amazon.Lambda.Model.InvokeAsyncResponse InvokeAsync(Amazon.Lambda.Model.InvokeAsyncRequest)";

            if (_isFakeAsync || !this._methodInfo.Name.EndsWith("Async", StringComparison.Ordinal))
            {
                //This is not an Async method. Lookup if an Async version exists for .NET Core.                
                this._hasAsyncVersion = NDocUtilities.FindDocumentationAsync(Artifacts.NDocForPlatform("netcoreapp3.1"), methodInfo, TypeProvider) != null;
            }                
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
            var element = NDocUtilities.FindDocumentation(this._methodInfo, TypeProvider);
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
                    writer.WriteLine("<h3><strong class=\"subHeading\">Return Value</strong></h3><br />");
                writer.WriteLine("</div>");

                writer.WriteLine("<div class=\"returnTypeName\">Type: {0}</div>", returnType.CreateReferenceHtml(fullTypeName: false));

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


            if (!this._isFakeAsync && this._methodInfo.Name.EndsWith("Async", StringComparison.Ordinal))
            {
                const string netFrameworkPatternNote = "<div class=\"noteblock\"><div class=\"noteheader\">Note:</div>"
                                           + "<p>This is an asynchronous operation using the standard naming convention for .NET 4.7.2 or higher."
                                           + "</p></div>";

                var name = this._methodInfo.Name.Substring(0, this._methodInfo.Name.Length - 5);
                writer.WriteLine(netFrameworkPatternNote);
            }                 
            else if (this._hasAsyncVersion)
            {
                const string platforms = ".NET Core";
                const string syncPatternNote =
                    "<div class=\"noteblock\"><div class=\"noteheader\">Note:</div>"
                    + "<p> For {0} this operation is only available in asynchronous form. Please refer to <i>{1}</i><b>Async</b>.</p></div>";

                writer.WriteLine(syncPatternNote, platforms, _methodInfo.Name);
            }       
        }


        private bool ShouldEmitRewriteRule
        {
            get
            {
                // This check is mostly to keep the generator from emitting multiple rewrite rules for the same shape.
                // i.e. we don't want a rewrite rule for bcl472, and netstandard. We only emit rules for bcl472
                //      we don't want to emit rules for both Async and Sync. We only emit rules for Async.
                return (this._version == FrameworkVersion.DotNet472 &&
                        !this._methodInfo.Name.EndsWith("Async", StringComparison.Ordinal) &&
                        this._methodInfo.DeclaringType.IsClass &&
                        !this._methodInfo.DeclaringType.IsAbstract);
            }
        }

        private IEnumerable<string> GetSeeAlsoLinks()
        {
            var element = GetSummaryDocumentation();
            if (element != null)
            {
                var seeAlsoList = element.XPathSelectElements("seealso");
                if (seeAlsoList != null)
                {
                    return seeAlsoList.Select(e => e.Attribute("href") != null ? e.Attribute("href").Value.ToString() : null)
                                    .Where(s => s != null)
                                    .ToList();
                }
            }
            return null;
        }
        protected override void WriteContent(TextWriter writer)
        {
            base.WriteContent(writer);

            if (ShouldEmitRewriteRule)
            {
                var links = GetSeeAlsoLinks();
                if (links != null)
                {
                    foreach(var link in links)
                    {
                        string serviceId;
                        string shape;

                        if (SDKDocRedirectWriter.ExtractServiceIDAndShapeFromUrl(link, out serviceId, out shape))
                        {
                            string docPath = string.Format("{0}{1}/{2}",
                                                            SDKDocRedirectWriter.DocPathPrefix,
                                                            GenerateFilepath(),
                                                            GenerateFilename().Replace('\\', '/'));
                            SDKDocRedirectWriter.AddRule(serviceId, shape, docPath);
                            break;
                        }
                    }
                }
            }
        }
    }
}
