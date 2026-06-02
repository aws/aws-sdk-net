using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace SDKDocGenerator
{
    /// <summary>
    /// Helpers for loading, looking up, and HTML-rendering the SDK's NDoc (XML) documentation.
    ///
    /// This class is split across several files by responsibility (all <c>partial</c>):
    ///   NDocUtilities.cs              - doc cache + load (this file)
    ///   NDocUtilities.Lookup.cs       - FindDocumentation* member lookups + inheritdoc resolution
    ///   NDocUtilities.Signatures.cs   - NDoc member-signature generation
    ///   NDocUtilities.HtmlTransform.cs- XML doc -> HTML rendering
    ///   NDocUtilities.CodeSamples.cs  - merging code-sample (.extra.xml) content into the doc XML
    /// </summary>
    public static partial class NDocUtilities
    {
        public const string MSDN_TYPE_URL_PATTERN = "https://msdn.microsoft.com/en-us/library/{0}.aspx";
        public const string DOC_SAMPLES_SUBFOLDER = "AWSSDKDocSamples";

        public const string crossReferenceOpeningTagText = "<see"; // <see> and <seealso> tags
        public const string crossReferenceClosingTagText = "/>";

        public const string crefAttributeName = "cref";
        public const string hrefAttributeName = "href";
        public const string nameAttributeName = "name";
        public const string targetAttributeName = "target";
        public const string pathAttributeName = "path";

        // inner attribute of a cross reference tag we're interested in
        public static readonly string innerCrefAttributeText = crefAttributeName + "=\"";
        public static readonly string innerHrefAttributeText = hrefAttributeName + "=\"";

        #region manage ndoc instances
        // The reason we cache the doc data on the side instead of directly referencing doc instances from
        // the type information is becasue we are loading the assemblies for reflection in a separate app domain.

        // ConcurrentDictionary so documentation can be loaded/looked up safely when services
        // are generated in parallel. Each (service, platform) docId is unique, so concurrent
        // LoadDocumentation calls populate distinct keys.
        private static readonly ConcurrentDictionary<string, IDictionary<string, XElement>> _ndocCache = new ConcurrentDictionary<string, IDictionary<string, XElement>>();

        public static string GenerateDocId(string serviceName, string platform)
        {
            // platform can be null; in which case we just use an empty string to construct the id.
            return string.Format("{0}:{1}", serviceName, platform == null ? "" : platform);
        }

        public static void LoadDocumentation(string assemblyName, string serviceName, string platform, GeneratorOptions options)
        {
            var ndocFilename = assemblyName + ".xml";
            var platformSpecificNdocFile = Path.Combine(options.SDKAssembliesRoot, platform, ndocFilename);
            if (File.Exists(platformSpecificNdocFile))
            {
                var docId = GenerateDocId(serviceName, platform);
                // De-duplication guard: LoadDocumentation may be called multiple times for
                // the same (service, platform) pair (e.g., during Generate() and again during
                // GenerateExclusivePagesFromMap()). Each docId is unique per service+platform,
                // so this only prevents redundant re-parsing of the same XML file.
                _ndocCache.GetOrAdd(docId, _ => CreateNDocTable(platformSpecificNdocFile, serviceName, options));
            }
        }

        public static void UnloadDocumentation(string serviceName, string platform)
        {
            var docId = GenerateDocId(serviceName, platform);
            _ndocCache.TryRemove(docId, out _);
        }

        public static IDictionary<string, XElement> GetDocumentationInstance(string serviceName, string platform)
        {
            return GetDocumentationInstance(GenerateDocId(serviceName, platform));
        }

        public static IDictionary<string, XElement> GetDocumentationInstance(string docId)
        {
            if (_ndocCache.TryGetValue(docId, out var doc))
            {
                return doc;
            }
            return null;
        }

        private static IDictionary<string, XElement> CreateNDocTable(string filePath, string serviceName, GeneratorOptions options)
        {
            return GenProfiler.Measure(GenProfiler.XmlDocParse, () =>
            {
                var dict = new Dictionary<string, XElement>();
                var document = LoadAssemblyDocumentationWithSamples(filePath, options.CodeSamplesRootFolder, serviceName);
                PreprocessCodeBlocksToPreTags(options, document);

                foreach (var element in document.XPathSelectElements("//members/member"))
                {
                    var xattribute = element.Attributes().FirstOrDefault(x => x.Name.LocalName == "name");
                    if (xattribute == null)
                        continue;

                    dict[xattribute.Value] = element;
                }

                return dict;
            });
        }
        #endregion
    }
}
