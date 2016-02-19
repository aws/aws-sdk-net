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
            // true when this is an Async method and the unity version is present
            this._unityVersionOfAsyncExists = NDocUtilities.FindDocumentationUnityAsync(Artifacts.NDocForPlatform("unity"), methodInfo) != null;
            // refer to asynchronous versions if the synchronous version doesn't exist but the async version does
            this._referAsyncAlternativeUnity = (NDocUtilities.FindDocumentationUnityAsyncAlternative(Artifacts.NDocForPlatform("unity"), methodInfo) != null) &&
                (Artifacts.NDocForPlatform("unity") != null) &&
                (NDocUtilities.FindDocumentation(Artifacts.NDocForPlatform("unity"), methodInfo) == null);
            this._referAsyncAlternativePCL = (NDocUtilities.FindDocumentationPCLAsyncAlternative(Artifacts.NDocForPlatform("pcl"), methodInfo) != null) &&
                (Artifacts.NDocForPlatform("pcl") != null) &&
                (NDocUtilities.FindDocumentation(Artifacts.NDocForPlatform("pcl"), methodInfo) == null);
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
                const string net35PatternNote = " For .NET 3.5 the operation is implemented as a pair of methods using the standard naming convention of "
                                                + "<b>Begin</b><i>{0}</i> and <b>End</b><i>{0}</i>.";
                const string unityPatternNote = " For Unity the operation does not take <i>CancellationToken</i> as a parameter, and instead takes"
                                              + " <i>AmazonServiceCallback&lt;{0}Request, {0}Response&gt;</i> and <i>AsyncOptions</i> as additional parameters.";
                const string patternNote = "<div class=\"noteblock\"><div class=\"noteheader\">Note:</div>"
                                           + "<p>This is an asynchronous operation using the standard naming convention for .NET 4.5 or higher."
                                           + "{0}{1}</p></div>";

                var name = this._methodInfo.Name.Substring(0, this._methodInfo.Name.Length - 5);
                writer.WriteLine(patternNote, string.Format(net35PatternNote, name), this._unityVersionOfAsyncExists ? string.Format(unityPatternNote, name) : string.Empty);
            }

            if (this._referAsyncAlternativeUnity || this._referAsyncAlternativePCL)
            {
                string platforms = string.Empty;
                if (this._referAsyncAlternativeUnity && this._referAsyncAlternativePCL)
                {
                    platforms = "PCL and Unity";
                }
                else if (this._referAsyncAlternativeUnity)
                {
                    platforms = "Unity";
                }
                else
                {
                    platforms = "PCL";
                }
                const string syncPatternNote =
                    "<div class=\"noteblock\"><div class=\"noteheader\">Note:</div>"
                    + "<p> For {0} this operation is only available in asynchronous form. Please refer to <i>{1}</i><b>Async</b>.</p></div>";

                writer.WriteLine(syncPatternNote, platforms, _methodInfo.Name);
            }
        }
    }
}
