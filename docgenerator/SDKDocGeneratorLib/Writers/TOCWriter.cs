using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SDKDocGenerator.Writers
{
    public class TOCWriter : BaseTemplateWriter
    {
        private readonly Dictionary<string, string> _namespaceTocs = new Dictionary<string, string>();
        // A single TOCWriter instance is shared across all manifests and BuildNamespaceToc may be
        // called concurrently when services are generated in parallel. This guards the shared
        // _namespaceTocs collection and the per-namespace file persistence. Write() runs after all
        // generation completes, and TransformNamespaceTocsToHtml orders by namespace, so the
        // emitted TOC is identical regardless of the order namespaces were processed.
        private readonly object _tocLock = new object();

        private const string TocIdFieldName = "id";
        private const string TocHrefFieldName = "href";
        private const string TocNodesFieldName = "nodes";

        public TOCWriter(GeneratorOptions options)
            : base(options)
        {
        }

        /// <summary>
        /// Creates or updates a per-namespace json file during generation of docs for types in that
        /// namespace. These will be added to the _namespaceTocs collection to be collated into
        /// one single master toc at the end of processing of all namespaces.
        /// </summary>
        /// <example>
        /// An partial and annotated example of what one data file looks like for the
        /// 'Amazon' namespace:
        /// {
        ///     "Amazon" :                              // this is used as the display name of the root for the entries
        ///     {
        ///         "id" : "Amazon",                    // the unique id assigned to the li element
        ///         "href" : "./items/Amazon/N_.html",  // the target of the link
        ///         "nodes": {                          // collection of child nodes for the namespace
        ///             "AWSConfigs" : {                                // display name for child node
        ///                 "id" : "Amazon_AWSConfigs",                 // the unique li id
        ///                 "href" : "./items/Amazon/TAWSConfigs.html"  // the target of the link
        ///             },
        ///             "LoggingOptions" : {
        ///                 "id" : "Amazon_LoggingOptions",
        ///                 "href" : "./items/Amazon\TLoggingOptions.html"
        ///             },
        ///             ...
        ///         }
        ///     }
        /// }
        /// </example>
        public void BuildNamespaceToc(string nameSpace, AssemblyWrapper sdkAssemblyWrapper)
        {
            string nsTocContents;
            using (var stream = new MemoryStream())
            {
                using (var jsonWriter = new Utf8JsonWriter(stream))
                {
                    jsonWriter.WriteStartObject();
                    WriteNamespaceToc(jsonWriter, nameSpace, sdkAssemblyWrapper);
                    jsonWriter.WriteEndObject();
                }
                nsTocContents = Encoding.UTF8.GetString(stream.ToArray());
            }

            lock (_tocLock)
            {
                _namespaceTocs[nameSpace] = nsTocContents;
            }
        }

        protected override string GetTemplateName()
        {
            return "TOC.html";
        }

        protected override string ReplaceTokens(string templateBody)
        {
            var tocContent = TransformNamespaceTocsToHtml();

            var finalBody = templateBody.Replace("{TOC}", tocContent);
            return finalBody;
        }

        void WriteNamespaceToc(Utf8JsonWriter writer, string ns, AssemblyWrapper sdkAssemblyWrapper)
        {
            var tocId = ns.Replace(".", "_");

            var nsFilePath = Path.Combine("./" + Options.ContentSubFolderName,
                                          GenerationManifest.OutputSubFolderFromNamespace(ns),
                                          FilenameGenerator.GenerateNamespaceFilename(ns)).Replace('\\', '/');

            writer.WriteStartObject(ns);

            writer.WriteString(TocIdFieldName, tocId);
            writer.WriteString(TocHrefFieldName, nsFilePath);

            writer.WriteStartObject(TocNodesFieldName);

            foreach (var type in sdkAssemblyWrapper.GetTypesForNamespace(ns).OrderBy(x => x.Name))
            {
                var filePath = Path.Combine("./" + Options.ContentSubFolderName,
                                            GenerationManifest.OutputSubFolderFromNamespace(type.Namespace),
                                            FilenameGenerator.GenerateFilename(type)).Replace('\\', '/');

                writer.WriteStartObject(type.GetDisplayName(false));
                writer.WriteString(TocIdFieldName, type.GetDisplayName(true).Replace(".", "_"));
                writer.WriteString(TocHrefFieldName, filePath);
                writer.WriteEndObject();
            }

            writer.WriteEndObject();

            writer.WriteEndObject();
        }

        /// <summary>
        /// Emit the set of namespace files encapsulated in json to a TOC based around
        /// unordered lists, returning the html for inclusion on the page.
        /// </summary>
        /// <returns></returns>
        string TransformNamespaceTocsToHtml()
        {
            var writer = new StringWriter();
            writer.Write("<ul class=\"awstoc\">");
            foreach (var ns in _namespaceTocs.Keys.OrderBy(x => x))
            {
                var nsJson = (JsonObject)JsonNode.Parse(_namespaceTocs[ns]);

                var nsProperty = nsJson.First();
                var nsName = nsProperty.Key;
                var nsData = (JsonObject)nsProperty.Value;
                var nsId = (string)nsData["id"];
                var nsFilePath = (string)nsData["href"];

                writer.Write(@"<li class=""nav"" id=""{0}"">
                                <button type = ""button"" aria-label=""{2} child nodes"" aria-expanded=""false""></button>
                                <a class=""nav"" href=""{1}"" target=""contentpane"" id=""{2}-parentnode"">{2}</a>",
                             nsId,
                             nsFilePath,
                             nsName);
                writer.Write("<ul role=\"region\" aria-labelledby=\"{0}\"/>",nsName);

                var nsNodes = (JsonObject)nsData["nodes"];
                foreach (var node in nsNodes)
                {
                    var p = node.Key;
                    var nodeObj = (JsonObject)node.Value;
                    writer.Write("<li class=\"nav leaf\" id=\"{0}\"><a class=\"nav leaf\" href=\"{1}\" target=\"contentpane\">{2}</a></li>",
                                 (string)nodeObj["id"],
                                 (string)nodeObj["href"],
                                 p);
                }

                writer.Write("</ul></li>");
            }
            writer.Write("</ul>");

            return writer.ToString();
        }
    }
}
