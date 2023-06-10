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
        private readonly Dictionary<string, string> _namespaceTocs = new Dictionary<string, string>(); 

        private const string TocFilesFolderName = "_tocfiles";
        private const string TocFilenameSuffix = ".toc.json";

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
            var sb = new StringBuilder();
            var jsonWriter = new JsonWriter(sb);

            jsonWriter.WriteObjectStart();
            WriteNamespaceToc(jsonWriter, nameSpace, sdkAssemblyWrapper);
            jsonWriter.WriteObjectEnd();

            var nsTocContents = sb.ToString();
            if (_namespaceTocs.ContainsKey(nameSpace))
                _namespaceTocs[nameSpace] = nsTocContents;
            else
                _namespaceTocs.Add(nameSpace, nsTocContents);

            PersistNamespaceToc(nameSpace);
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

        /// <summary>
        /// Loads the toc snippet file for the specified namespace, adding it to the managed
        /// collection for later collation into the overall toc file.
        /// </summary>
        //void LoadNamespaceToc(string nameSpace)
        //{
        //    var filePath = Path.Combine(Options.ComputedContentFolder, tocFilesFolderName);
        //    if (!Directory.Exists(filePath))
        //        return;

        //    var tocFile = Path.Combine(filePath, nameSpace + extensionPattern);
        //    if (File.Exists(tocFile))
        //    {
        //        using (var reader = File.OpenText(tocFile))
        //        {
        //            var tocContent = reader.ReadToEnd();
        //            _namespaceTocs.Add(nameSpace, tocContent);
        //        }
        //    }
        //}

        void WriteNamespaceToc(JsonWriter writer, string ns, AssemblyWrapper sdkAssemblyWrapper)
        {
            var tocId = ns.Replace(".", "_");

            var nsFilePath = Path.Combine("./" + Options.ContentSubFolderName,
                                          GenerationManifest.OutputSubFolderFromNamespace(ns),
                                          FilenameGenerator.GenerateNamespaceFilename(ns)).Replace('\\', '/');

            writer.WritePropertyName(ns);
            writer.WriteObjectStart();

            writer.WritePropertyName(TocIdFieldName);
            writer.Write(tocId);

            writer.WritePropertyName(TocHrefFieldName);
            writer.Write(nsFilePath);

            writer.WritePropertyName(TocNodesFieldName);
            writer.WriteObjectStart();

            foreach (var type in sdkAssemblyWrapper.GetTypesForNamespace(ns).OrderBy(x => x.Name))
            {
                var filePath = Path.Combine("./" + Options.ContentSubFolderName,
                                            GenerationManifest.OutputSubFolderFromNamespace(type.Namespace),
                                            FilenameGenerator.GenerateFilename(type)).Replace('\\', '/');

                writer.WritePropertyName(type.GetDisplayName(false));
                writer.WriteObjectStart();
                writer.WritePropertyName(TocIdFieldName);
                writer.Write(type.GetDisplayName(true).Replace(".", "_"));

                writer.WritePropertyName(TocHrefFieldName);
                writer.Write(filePath);
                writer.WriteObjectEnd();
            }

            writer.WriteObjectEnd();

            writer.WriteObjectEnd();
        }

        /// <summary>
        /// Persists a toc snippet file, in json format, from the managed collection.
        /// </summary>
        void PersistNamespaceToc(string nameSpace)
        {
            var tocFilesSubfolder = Path.Combine(Options.ComputedContentFolder, TocFilesFolderName);
            if (!Directory.Exists(tocFilesSubfolder))
                Directory.CreateDirectory(tocFilesSubfolder);

            var filePath = Path.Combine(tocFilesSubfolder, nameSpace + TocFilenameSuffix);
            using (var writer = File.CreateText(filePath))
            {
                writer.Write(_namespaceTocs[nameSpace]);                    
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
            foreach (var ns in _namespaceTocs.Keys.OrderBy(x => x))
            {
                var nsJson = JsonMapper.ToObject(new JsonReader(_namespaceTocs[ns]));

                var nsName = nsJson.PropertyNames.First();
                var nsData = nsJson[0];
                var nsId = (string) nsData["id"];
                var nsFilePath = (string)nsData["href"];

                writer.Write(@"<li class=""nav"" id=""{0}"">
                                <button type = ""button"" aria-label=""{2} child nodes"" aria-expanded=""false""></button>
                                <a class=""nav"" href=""{1}"" target=""contentpane"" id=""{2}-parentnode"">{2}</a>",
                             nsId,
                             nsFilePath,
                             nsName);
                writer.Write("<ul role=\"region\" aria-labelledby=\"{0}\"/>",nsName);

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
