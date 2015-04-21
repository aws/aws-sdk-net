using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Json;
using Json.LitJson;

namespace SDKDocGenerator.Writers
{
    public class TOCWriter : BaseTemplateWriter
    {
        private readonly IList<GenerationManifest> _manifests;
        private readonly Dictionary<string, string> _namespaceTocs = new Dictionary<string, string>(); 
        private readonly Dictionary<string, AssemblyWrapper> _generatedNamespaces = new Dictionary<string, AssemblyWrapper>();

        private const string tocFilesFolderName = "_tocfiles";
        
        private const string tocIdFieldName = "id";
        private const string tocHrefFieldName = "href";
        private const string tocNodesFieldName = "nodes";

        public TOCWriter(GeneratorOptions options, IList<GenerationManifest> manifests)
            : base(options)
        {
            _manifests = manifests;
        }

        protected override string GetTemplateName()
        {
            return "TOC.html";
        }

        protected override string ReplaceTokens(string templateBody)
        {
            // collate the set of namespaces fom the manifests we've been
            // given
            foreach (var m in _manifests)
            {
                var namespaces = m.AssemblyWrapper.GetNamespaces();
                foreach (var n in namespaces)
                {
                    if (!_generatedNamespaces.ContainsKey(n))
                        _generatedNamespaces.Add(n, m.AssemblyWrapper);
                }
            }

            LoadExistingNamespaceTocs();
            UpdateNamespaceTocs();
            PersistNamespaceTocs();

            var tocContent = TransformNamespaceTocsToHtml();

            var finalBody = templateBody.Replace("{TOC}", tocContent);
            return finalBody;
        }

        /// <summary>
        /// Scans the ./items/_tocfiles folder in the output content and loads all existing
        /// toc files (*.toc.json) into the _namespaceTocs collection, indexed
        /// by namespace (the first part of the filename).
        /// </summary>
        void LoadExistingNamespaceTocs()
        {
            const string extensionPattern = ".toc.json";

            var filePath = Path.Combine(Options.ComputedContentFolder, tocFilesFolderName);
            if (!Directory.Exists(filePath))
                return;

            var tocs = Directory.GetFiles(filePath, "*" + extensionPattern);
            foreach (var t in tocs)
            {
                // we expect the major portion of the filename to be the namespace
                // we'll be keying off
                var filename = Path.GetFileName(t);
                var ns = filename.Substring(0, filename.Length - extensionPattern.Length);
                using (var reader = File.OpenText(t))
                {
                    var tocContent = reader.ReadToEnd();
                    _namespaceTocs.Add(ns, tocContent);
                }
            }
        }

        /// <summary>
        /// Constructs the per-root-namespace json files for the services that were generated.
        /// These will be added to the _namespaceTocs collection, either extending it or
        /// overwriting an existing entry if we're updating a service.
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
        void UpdateNamespaceTocs()
        {
            foreach (var ns in _generatedNamespaces.Keys)
            {
                var sb = new StringBuilder();
                var jsonWriter = new JsonWriter(sb);

                jsonWriter.WriteObjectStart();
                WriteNamespaceToc(jsonWriter, ns);
                jsonWriter.WriteObjectEnd();

                var nsTocContents = sb.ToString();
                if (_namespaceTocs.ContainsKey(ns))
                    _namespaceTocs[ns] = nsTocContents;
                else
                    _namespaceTocs.Add(ns, nsTocContents);
            }
        }

        void WriteNamespaceToc(JsonWriter writer, string ns)
        {
            var assemblyWrapper = _generatedNamespaces[ns];
            var tocId = ns.Replace(".", "_");

            var nsFilePath = Path.Combine("./" + Options.ContentSubFolderName,
                                          GenerationManifest.OutputSubFolderFromNamespace(ns),
                                          FilenameGenerator.GenerateNamespaceFilename(ns)).Replace('\\', '/');

            writer.WritePropertyName(ns);
            writer.WriteObjectStart();

            writer.WritePropertyName("id");
            writer.Write(tocId);

            writer.WritePropertyName("href");
            writer.Write(nsFilePath);

            writer.WritePropertyName("nodes");
            writer.WriteObjectStart();

            foreach (var type in assemblyWrapper.GetTypesForNamespace(ns).OrderBy(x => x.Name))
            {
                var filePath = Path.Combine("./" + Options.ContentSubFolderName,
                                            GenerationManifest.OutputSubFolderFromNamespace(type.Namespace),
                                            FilenameGenerator.GenerateFilename(type)).Replace('\\', '/');

                writer.WritePropertyName(type.GetDisplayName(false));
                writer.WriteObjectStart();
                writer.WritePropertyName("id");
                writer.Write(type.GetDisplayName(true).Replace(".", "_"));

                writer.WritePropertyName("href");
                writer.Write(filePath);
                writer.WriteObjectEnd();
            }

            writer.WriteObjectEnd();

            writer.WriteObjectEnd();
        }

        /// <summary>
        /// Writes each namespace toc, in json format, to files inside the ./items
        /// folder of the output so they are available for the next run.
        /// </summary>
        void PersistNamespaceTocs()
        {
            var tocFilesSubfolder = Path.Combine(Options.ComputedContentFolder, tocFilesFolderName);
            if (!Directory.Exists(tocFilesSubfolder))
                Directory.CreateDirectory(tocFilesSubfolder);

            foreach (var ns in _namespaceTocs.Keys)
            {
                var filePath = Path.Combine(tocFilesSubfolder, ns + ".toc.json");
                using (var writer = File.CreateText(filePath))
                {
                    writer.Write(_namespaceTocs[ns]);                    
                }
            }            
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
            foreach (var ns in _generatedNamespaces.Keys.OrderBy(x => x))
            {
                var nsJson = JsonMapper.ToObject(new JsonReader(_namespaceTocs[ns]));

                var nsName = nsJson.PropertyNames.First();
                var nsData = nsJson[0];
                var nsId = (string) nsData["id"];
                var nsFilePath = (string)nsData["href"];

                writer.Write("<li class=\"nav\" id=\"{0}\"><a class=\"nav\" href=\"{1}\" target=\"contentpane\">{2}</a>",
                             nsId,
                             nsFilePath,
                             nsName);
                writer.Write("<ul>");

                var nsNodes = nsData["nodes"];
                foreach (var p in nsNodes.PropertyNames)
                {
                    var nodeObj = nsNodes[p];
                    writer.Write("<li class=\"nav leaf\" id=\"{0}\"><a class=\"nav leaf\" href=\"{1}\" target=\"contentpane\">{2}</a></li>",
                                 nodeObj["id"],
                                 nodeObj["href"],
                                 p);
                } 

                writer.Write("</ul></li>");
            }
            writer.Write("</ul>");

            return writer.ToString();
        }
    }
}
