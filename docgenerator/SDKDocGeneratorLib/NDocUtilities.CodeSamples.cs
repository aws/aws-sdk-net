using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace SDKDocGenerator
{
    public static partial class NDocUtilities
    {
        public static void PreprocessCodeBlocksToPreTags(GeneratorOptions options, XDocument doc)
        {
            var nodesToRemove = new List<XElement>();
            var codeNodes = doc.XPathSelectElements("//code");
            foreach (var codeNode in codeNodes)
            {
                string processedCodeSample = null;
                var xattribute = codeNode.Attributes().FirstOrDefault(x => x.Name.LocalName == "source");
                if (xattribute != null)
                {
                    var sourceRelativePath = xattribute.Value;

                    xattribute = codeNode.Attributes().FirstOrDefault(x => x.Name.LocalName == "region");
                    if (xattribute == null)
                        continue;
                    var regionName = xattribute.Value;

                    var samplePath = FindSampleCodePath(options.CodeSamplesRootFolder, sourceRelativePath);
                    if (samplePath == null)
                    {
                        Console.Error.WriteLine("Error finding sample path for {0}", sourceRelativePath);
                        continue;
                    }

                    var content = File.ReadAllText(samplePath);

                    var startPos = content.IndexOf("#region " + regionName);
                    if (startPos == -1)
                    {
                        Console.Error.WriteLine("Error finding region for {0}", regionName);
                        continue;
                    }
                    startPos = content.IndexOf('\n', startPos);
                    var endPos = content.IndexOf("#endregion", startPos);

                    var sampleCode = content.Substring(startPos, endPos - startPos);
                    processedCodeSample = HttpUtility.HtmlEncode(sampleCode);
                }
                else
                {
                    processedCodeSample = HttpUtility.HtmlEncode(codeNode.Value);
                }

                if (processedCodeSample != null && processedCodeSample.IndexOf('\n') > -1)
                {

                    processedCodeSample = LeftJustifyCodeBlocks(processedCodeSample);
                    var preElement = new XElement("pre", processedCodeSample);
                    preElement.SetAttributeValue("class", "brush: csharp");

                    codeNode.AddAfterSelf(preElement);
                    nodesToRemove.Add(codeNode);

                    string title = null;
                    xattribute = codeNode.Attributes().FirstOrDefault(x => x.Name.LocalName == "title");
                    if (xattribute != null)
                        title = xattribute.Value;

                    if (title != null)
                    {
                        var titleElement = new XElement("h4", title);
                        titleElement.SetAttributeValue("class", "csharp-code-sample-title");
                        preElement.AddBeforeSelf(titleElement);
                    }
                }
            }

            nodesToRemove.ForEach(x => x.Remove());
        }

        private static string FindSampleCodePath(string codeSampleRootDirectory, string relativePath)
        {
            if (string.IsNullOrEmpty(codeSampleRootDirectory))
                return null;

            var fullPath = Path.Combine(codeSampleRootDirectory, relativePath);
            return !File.Exists(fullPath) ? null : fullPath;
        }

        private static string LeftJustifyCodeBlocks(string codeBlock)
        {
            // Switch tabs to 4 spaces
            var block = new StringBuilder(codeBlock).Replace("\t", new string(' ', 4)).ToString();

            // Find the nearest indent location
            var nearestIndent = int.MaxValue;
            using (var reader = new StringReader(block))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int indent = FindFirstNoWhitePosition(line);
                    if (indent != -1 && indent < nearestIndent)
                        nearestIndent = indent;
                }
            }

            // Substring all lines with content to the indent location;
            var reformattedBuilder = new StringBuilder();
            using (var reader = new StringReader(block))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        reformattedBuilder.AppendLine(line);
                    else
                    {
                        var trimedLine = line.Substring(nearestIndent);
                        reformattedBuilder.AppendLine(trimedLine);
                    }
                }
            }

            return reformattedBuilder.ToString();
        }

        private static int FindFirstNoWhitePosition(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return -1;
            for (int space = 0; space < line.Length; space++)
            {
                if (!Char.IsWhiteSpace(line[space]))
                    return space;
            }
            return -1;
        }

        // The code-sample ".extra.xml" content is platform-independent, so the parsed examples map is
        // identical across a service's 4 platform docs. Building it once per service (instead of once
        // per platform) avoids re-reading + re-parsing those sample files 4x. Value is null when the
        // service has no sample files.
        private static readonly ConcurrentDictionary<string, IDictionary<string, string>> _exampleMapCache =
            new ConcurrentDictionary<string, IDictionary<string, string>>(StringComparer.Ordinal);

        public static XDocument LoadAssemblyDocumentationWithSamples(string filePath, string samplesDir, string serviceName)
        {
            var examplesMap = GetExamplesMap(samplesDir, serviceName);

            // Parse the (potentially multi-MB) SDK XML exactly once. The previous implementation parsed
            // it into an XmlDocument, mutated it, then re-parsed the whole DOM into an XDocument via an
            // XmlNodeReader - i.e. two full XML object models per file. We now load straight into an
            // XDocument and merge samples in place, halving the parse cost on the doc-load critical path.
            var sdkDoc = XDocument.Load(filePath, LoadOptions.PreserveWhitespace);

            if (examplesMap != null && examplesMap.Count > 0)
            {
                Trace.WriteLine(String.Format("Merging {0} code samples into {1}", serviceName, filePath));
                ProcessExtraDoc(sdkDoc, examplesMap);
            }

            return sdkDoc;
        }

        /// <summary>
        /// Returns the (cached) member-spec -&gt; example-content map for a service, or null if the
        /// service has no code-sample files. The map is platform-independent and built once per service.
        /// </summary>
        private static IDictionary<string, string> GetExamplesMap(string samplesDir, string serviceName)
        {
            if (string.IsNullOrEmpty(samplesDir))
                return null;

            return _exampleMapCache.GetOrAdd(serviceName, svc =>
            {
                var extraDocNodes = new List<XmlNode>();
                foreach (var pattern in new[] { ".extra.xml", ".GeneratedSamples.extra.xml" })
                {
                    var extraFile = Path.Combine(samplesDir, DOC_SAMPLES_SUBFOLDER, svc + pattern);
                    if (File.Exists(extraFile))
                    {
                        var extraDoc = new XmlDocument();
                        extraDoc.Load(extraFile);
                        foreach (XmlNode node in extraDoc.SelectNodes("docs/doc"))
                        {
                            extraDocNodes.Add(node);
                        }
                    }
                }

                return extraDocNodes.Any() ? BuildExamplesMap(extraDocNodes) : null;
            });
        }

        private static IDictionary<string, string> BuildExamplesMap(List<XmlNode> docNodes)
        {
            Trace.WriteLine(String.Format("Found {0} extra doc nodes", docNodes.Count), "verbose");
            var map = new Dictionary<string, string>(StringComparer.Ordinal);

            foreach (var docNode in docNodes)
            {
                var members = docNode.SelectNodes("members/member");
                foreach (XmlNode memberNode in members)
                {
                    var nameAttribute = memberNode.Attributes["name"];
                    if (null == nameAttribute)
                        throw new InvalidDataException("unable to retrieve 'name' attribute for member node.");

                    var memberSpec = nameAttribute.Value;
                    var exampleNode = docNode.SelectSingleNode("value/example");
                    var content = exampleNode.InnerXml;

                    if (map.ContainsKey(memberSpec))
                        map[memberSpec] += content;
                    else
                        map[memberSpec] = content;
                }
            }

            return map;
        }

        private static void ProcessExtraDoc(XDocument sdkDocument, IDictionary<string, string> examplesMap)
        {
            foreach (var memberSpec in examplesMap.Keys)
            {
                var docNode = sdkDocument.XPathSelectElement(string.Format("doc/members/member[@name='{0}']", memberSpec));
                if (docNode == null)
                {
                    Trace.WriteLine(String.Format("** member name not found, skipping: {0}", memberSpec), "verbose");
                    continue;
                }

                // The sample content is an XML fragment (the InnerXml of an <example> element). Wrap it
                // so it parses, then transplant its child nodes. This mirrors the old XmlDocument
                // InnerXml assignment: replace the existing <example> body, or append a new <example>.
                var parsedExample = XElement.Parse("<example>" + examplesMap[memberSpec] + "</example>", LoadOptions.PreserveWhitespace);

                var existingExample = docNode.Element("example");
                if (existingExample != null)
                {
                    existingExample.ReplaceNodes(parsedExample.Nodes());
                }
                else
                {
                    docNode.Add(parsedExample);
                }

                Trace.WriteLine(string.Format("Successfully updated SDK XML for member {0}", memberSpec), "verbose");
            }
        }
    }
}
