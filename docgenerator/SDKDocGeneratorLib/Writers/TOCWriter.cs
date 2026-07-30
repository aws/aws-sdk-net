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

        // Local-search member index. Types and namespaces are already searchable from
        // toc.json (the sidebar loads it), so this index covers only members. The
        // client (search-worker.js) fetches it once in the background.
        //   kind: 1=method 2=property 3=field 4=event 5=enum-member (constructors excluded).
        // Built from the same per-namespace pass that builds toc.json (generation is
        // sequential, so a plain accumulator is safe). Only members DECLARED on a type
        // are indexed — inherited members appear on many pages and would bloat the
        // index with duplicates; users still find them on their declaring type.
        // Note: members are enumerated on the primary platform (same source as toc.json),
        // so platform-exclusive method pages may not be represented in search.
        // CONTRACT: these codes are mirrored by KIND_TABLE in resources/search.js
        // (which maps each to its display group, icon, and sort rank). Add a kind in
        // both places or the client will fall back to a generic icon/group.
        private const int KindMethod = 1;
        private const int KindProperty = 2;
        private const int KindField = 3;
        private const int KindEvent = 4;
        private const int KindEnumMember = 5;

        private struct MemberEntry
        {
            public string Folder;   // items/<Folder>/ — service output sub-folder
            public string Name;     // short searchable identifier (e.g. "PutObject")
            public int Kind;
            public string File;     // page file relative to items/<Folder>/, incl. any #anchor
            public string Type;     // declaring type display name, shown as dimmed context
        }

        private readonly List<MemberEntry> _searchEntries = new List<MemberEntry>();

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
            {
                // Namespace already processed: replace its TOC (last write wins) and do NOT
                // re-collect search entries. _searchEntries is a plain append-only list, so
                // re-collecting would duplicate every member of this namespace in the index
                // (whereas the TOC is keyed and de-duplicates). Guard both together.
                _namespaceTocs[nameSpace] = nsTocContents;
            }
            else
            {
                _namespaceTocs.Add(nameSpace, nsTocContents);
                CollectSearchEntries(nameSpace, sdkAssemblyWrapper);
            }
        }

        /// <summary>
        /// Collects the members of every type in the namespace into the local-search
        /// index. Hrefs are built with the same OutputSubFolderFromNamespace +
        /// FilenameGenerator calls ClassWriter uses, so search links match the pages
        /// that are actually emitted: methods/events have their own page; properties,
        /// fields and enum members are rows on the type page, linked via an #anchor.
        /// </summary>
        void CollectSearchEntries(string nameSpace, AssemblyWrapper sdkAssemblyWrapper)
        {
            foreach (var type in sdkAssemblyWrapper.GetTypesForNamespace(nameSpace))
            {
                var folder = GenerationManifest.OutputSubFolderFromNamespace(type.Namespace);
                var typeName = type.GetDisplayName(false);

                if (type.IsEnum)
                {
                    var typeFile = FilenameGenerator.GenerateFilename(type);
                    foreach (var enumName in type.GetEnumNames())
                    {
                        AddSearchEntry(folder, enumName, KindEnumMember,
                            typeFile + "#" + FilenameGenerator.EnumMemberAnchor(enumName), typeName);
                    }
                    continue;
                }

                // Methods and events have their own pages (M_*.html / E_*.html).
                foreach (var info in type.GetMethodsToDocument())
                {
                    if (!IsDeclaredOn(info.DeclaringType, type))
                        continue;
                    AddSearchEntry(folder, info.Name, KindMethod, FilenameGenerator.GenerateFilename(info), typeName);
                }
                foreach (var info in type.GetEvents())
                {
                    if (!IsDeclaredOn(info.DeclaringType, type))
                        continue;
                    AddSearchEntry(folder, info.Name, KindEvent, FilenameGenerator.GenerateFilename(info), typeName);
                }

                // Properties and fields are rows on the type page; link via #anchor.
                var typePageFile = FilenameGenerator.GenerateFilename(type);
                foreach (var info in type.GetProperties())
                {
                    if (!IsDeclaredOn(info.DeclaringType, type))
                        continue;
                    AddSearchEntry(folder, info.Name, KindProperty,
                        typePageFile + "#" + FilenameGenerator.PropertyAnchor(info.Name), typeName);
                }
                foreach (var info in type.GetFields())
                {
                    if (!IsDeclaredOn(info.DeclaringType, type))
                        continue;
                    AddSearchEntry(folder, info.Name, KindField,
                        typePageFile + "#" + FilenameGenerator.FieldAnchor(info.Name), typeName);
                }
            }
        }

        // A member is "declared" on the page's type when its declaring type matches;
        // inherited members render on the page but are indexed under their own type.
        static bool IsDeclaredOn(TypeWrapper declaringType, TypeWrapper pageType)
        {
            return declaringType != null && string.Equals(declaringType.FullName, pageType.FullName);
        }

        void AddSearchEntry(string folder, string name, int kind, string file, string type)
        {
            _searchEntries.Add(new MemberEntry
            {
                Folder = folder,
                Name = name,
                Kind = kind,
                File = file,
                Type = type
            });
        }

        protected override string GetTemplateName()
        {
            return "TOC.html";
        }

        /// <summary>
        /// Writes the legacy TOC.html (kept as a no-script / SEO fallback) and, in
        /// addition, emits toc.json at the doc-set root. app.js fetches toc.json once
        /// and hydrates the persistent sidebar from it, so the full navigation tree no
        /// longer has to be inlined into every generated page.
        /// </summary>
        public override void Write()
        {
            base.Write();
            WriteTocJson();
            WriteSearchIndexJson();
        }

        /// <summary>
        /// Serializes the collected namespace TOCs into the shape app.js expects:
        /// { "namespaces": [ { name, id, href, nodes: [ { name, id, href } ] } ] }.
        /// Hrefs are made root-relative (leading "./" stripped) so the client can
        /// resolve them against the page's data-root at any folder depth.
        /// </summary>
        void WriteTocJson()
        {
            var namespaces = new List<object>();

            foreach (var ns in _namespaceTocs.Keys.OrderBy(x => x))
            {
                var nsJson = JsonMapper.ToObject(new JsonReader(_namespaceTocs[ns]));
                var nsName = nsJson.PropertyNames.First();
                var nsData = nsJson[0];

                var nodes = new List<object>();
                var nsNodes = nsData["nodes"];
                foreach (var p in nsNodes.PropertyNames)
                {
                    var nodeObj = nsNodes[p];
                    nodes.Add(new
                    {
                        name = p,
                        id = (string)nodeObj["id"],
                        href = NormalizeHref((string)nodeObj["href"])
                    });
                }

                namespaces.Add(new
                {
                    name = nsName,
                    // Service-folder grouping key (e.g. "S3", "Runtime", "Util"),
                    // so app.js can group related namespaces under one service.
                    service = GenerationManifest.OutputSubFolderFromNamespace(nsName),
                    id = (string)nsData["id"],
                    href = NormalizeHref((string)nsData["href"]),
                    nodes
                });
            }

            var payload = new { namespaces };
            var json = System.Text.Json.JsonSerializer.Serialize(payload);

            var outputPath = Path.Combine(Options.OutputFolder, "toc.json");
            File.WriteAllText(outputPath, json);
        }

        static string NormalizeHref(string href)
        {
            if (string.IsNullOrEmpty(href))
                return href;
            if (href.StartsWith("./"))
                return href.Substring(2);
            return href;
        }

        /// <summary>
        /// Serializes the collected member entries into a compact search-index.json at
        /// the doc-set root. The folder names are factored into a lookup table and each
        /// entry is a positional array to keep the file small across the full SDK:
        ///   { "v":1, "base":"items", "f":[ "S3", … ], "i":[ [folderIdx, name, kind, file, type], … ] }
        /// app.js reconstructs each href as &lt;base&gt;/&lt;f[folderIdx]&gt;/&lt;file&gt;. "base" is the
        /// configurable content sub-folder (<see cref="GeneratorOptions.ContentSubFolderName"/>,
        /// usually "items"), emitted here so the client doesn't hard-code it.
        /// </summary>
        void WriteSearchIndexJson()
        {
            // Build the folder lookup table (stable, de-duplicated, ordered by first use).
            var folderIndex = new Dictionary<string, int>(StringComparer.Ordinal);
            var folders = new List<string>();

            var items = new List<object[]>(_searchEntries.Count);
            foreach (var e in _searchEntries)
            {
                int fi;
                if (!folderIndex.TryGetValue(e.Folder, out fi))
                {
                    fi = folders.Count;
                    folderIndex[e.Folder] = fi;
                    folders.Add(e.Folder);
                }
                items.Add(new object[] { fi, e.Name, e.Kind, e.File, e.Type });
            }

            var payload = new { v = 1, @base = Options.ContentSubFolderName, f = folders, i = items };
            var json = System.Text.Json.JsonSerializer.Serialize(payload);

            var outputPath = Path.Combine(Options.OutputFolder, "search-index.json");
            File.WriteAllText(outputPath, json);
        }

        protected override string ReplaceTokens(string templateBody)
        {
            var tocContent = TransformNamespaceTocsToHtml();

            var finalBody = templateBody.Replace("{TOC}", tocContent);
            return finalBody;
        }

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
                // The id MUST equal the type page's runtime data-tocid so app.js can
                // sync/highlight the active node. The page sets data-tocid from
                // ClassWriter.GetTOCID() = FullName.Replace('.','_'), then
                // FilenameGenerator.Escape (backtick -> "&#96;"). The browser HTML-decodes
                // the attribute, so at runtime it reads back as FullName.Replace('.','_')
                // with a literal backtick. toc.json is JSON (no HTML decoding), so we write
                // the unescaped form here — escaping it would leave a literal "&#96;" that
                // never matches the decoded attribute. (GetDisplayName(true) diverges for
                // generic types — no namespace prefix, encoded "<>" — which broke sync.)
                writer.Write(type.FullName.Replace('.', '_'));

                writer.WritePropertyName(TocHrefFieldName);
                writer.Write(filePath);
                writer.WriteObjectEnd();
            }

            writer.WriteObjectEnd();

            writer.WriteObjectEnd();
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
                                <a class=""nav"" href=""{1}"" id=""{0}-parentnode"">{2}</a>",
                             nsId,
                             nsFilePath,
                             nsName);
                // aria-labelledby must reference the anchor's actual id (nsId-parentnode);
                // using nsName here previously dangled (no element has that id), leaving the
                // region unnamed. <ul> is not void, so no self-closing slash.
                writer.Write("<ul role=\"region\" aria-labelledby=\"{0}-parentnode\">", nsId);

                var nsNodes = nsData["nodes"];
                foreach (var p in nsNodes.PropertyNames)
                {
                    var nodeObj = nsNodes[p];
                    writer.Write("<li class=\"nav leaf\" id=\"{0}\"><a class=\"nav leaf\" href=\"{1}\">{2}</a></li>",
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
