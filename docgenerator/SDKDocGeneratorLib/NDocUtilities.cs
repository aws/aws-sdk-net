using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml.Linq;

using SDKDocGenerator.Writers;
using System.Xml;
using System.Diagnostics;

namespace SDKDocGenerator
{
    public static class NDocUtilities
    {
        public const string MSDN_TYPE_URL_PATTERN = "http://msdn.microsoft.com/en-us/library/{0}.aspx";
        public const string DOC_SAMPLES_SUBFOLDER = "AWSSDKDocSamples";

        public const string crossReferenceOpeningTagText = "<see"; // <see> and <seealso> tags
        public const string crossReferenceClosingTagText = "/>";

        // inner attribute of a cross reference tag we're interested in
        public const string innerCrefAttributeText = "cref=\"";
        public const string innerHrefAttributeText = "href=\"";

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, AbstractWrapper wrapper)
        {
            if (ndoc == null)
                return null;

            if (wrapper is TypeWrapper)
                return FindDocumentation(ndoc, (TypeWrapper)wrapper);
            if (wrapper is PropertyInfoWrapper)
                return FindDocumentation(ndoc, (PropertyInfoWrapper)wrapper);
            if (wrapper is MethodInfoWrapper)
                return FindDocumentation(ndoc, (MethodInfoWrapper)wrapper);
            if (wrapper is ConstructorInfoWrapper)
                return FindDocumentation(ndoc, (ConstructorInfoWrapper)wrapper);
            if (wrapper is FieldInfoWrapper)
                return FindDocumentation(ndoc, (FieldInfoWrapper)wrapper);

            return null;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, FieldInfoWrapper info)
        {
            var signature = string.Format("F:{0}.{1}", info.DeclaringType.FullName, info.Name);
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static XElement FindFieldDocumentation(IDictionary<string, XElement> ndoc, TypeWrapper type, string fieldName)
        {
            var signature = string.Format("F:{0}.{1}", type.FullName, fieldName);
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, TypeWrapper type)
        {
            var signature = "T:" + type.FullName;
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, PropertyInfoWrapper info)
        {
            var type = info.DeclaringType;
            var signature = string.Format("P:{0}.{1}", type.FullName, info.Name);
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, EventInfoWrapper info)
        {
            var type = info.DeclaringType;
            var signature = string.Format("E:{0}.{1}", type.FullName, info.Name);
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, MethodInfoWrapper info)
        {
            var type = info.DeclaringType;
            var parameters = new StringBuilder();
            foreach (var param in info.GetParameters())
            {
                if (parameters.Length > 0)
                    parameters.Append(",");
                if (param.ParameterType.IsGenericType)
                {
                    parameters
                        .Append(param.ParameterType.GenericTypeName)
                        .Append("{")
                        .Append(string.Join(",", param.ParameterType.GenericTypeArguments().Select(a => a.FullName)))
                        .Append("}");
                }
                else
                {
                    parameters.Append(param.ParameterType.FullName);
                    if (param.IsOut)
                        parameters.Append("@");
                }
            }

            var signature = parameters.Length > 0 
                ? string.Format("M:{0}.{1}({2})", type.FullName, info.Name, parameters) 
                : string.Format("M:{0}.{1}", type.FullName, info.Name);

            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, ConstructorInfoWrapper info)
        {
            var type = info.DeclaringType;
            var parameters = new StringBuilder();
            foreach (var param in info.GetParameters())
            {
                if (parameters.Length > 0)
                    parameters.Append(",");
                parameters.Append(param.ParameterType.FullName);
            }

            var formattedParmaters = parameters.Length > 0 
                ? string.Format("({0})", parameters) 
                : parameters.ToString();

            var signature = string.Format("M:{0}.#ctor{1}", type.FullName, formattedParmaters);

            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static string FindParameterDocumentation(XElement ndoc, string name)
        {
            if (ndoc == null)
                return string.Empty;

            var node = ndoc.XPathSelectElement(string.Format("./param[@name = '{0}']", name));
            if (node == null)
                return string.Empty;

            return node.Value;
        }

        public static string FindReturnDocumentation(XElement ndoc)
        {
            if (ndoc == null)
                return string.Empty;

            var node = ndoc.XPathSelectElement("returns");
            if (node == null)
                return string.Empty;

            return node.Value;
        }

        public static string TransformDocumentationToHTML(XElement element, string rootNodeName, AssemblyWrapper assemblyWrapper, FrameworkVersion version)
        {
            if (element == null)
                return string.Empty;

            var rootNode = element.XPathSelectElement(rootNodeName);
            if (rootNode == null)
                return string.Empty;

            //var crossRefTags = new[] { "see", "seealso" };
            //foreach (var crossRefTag in crossRefTags)
            //{
            //    var crossRefs = rootNode.Descendants(crossRefTag);
            //    if (crossRefs.Any())
            //    {
            //        foreach (var crossRef in crossRefs)
            //        {
            //            var typeName = BaseWriter.GetCrossReferenceTypeName(crossRef);

            //            string target;
            //            var url = BaseWriter.CrossReferenceTypeToUrl(assemblyWrapper, typeName, version, out target);

            //            var href = url != null ? string.Format("<a href=\"{0}\" {2}>{1}</a>", url, typeName, target) : typeName;
            //            crossRef.ReplaceWith(href);
            //        }
            //    }
            //}

            var reader = rootNode.CreateReader();
            reader.MoveToContent();
            var innerXml = reader.ReadInnerXml();

            var innerText = innerXml;
            innerText = innerText.Replace("<summary>", "<p>");
            innerText = innerText.Replace("</summary>", "</p>");
            innerText = innerText.Replace("<para>", "<p>");
            innerText = innerText.Replace("</para>", "</p>");
            //innerText = innerText.Replace("<code", "<pre class=\"code-sample\">");
            //innerText = innerText.Replace("</code>", "</pre>");

            // scan for <see> and <seealso> cross-reference tags and replace with <a> links with the
            // content - which // can be a cref indication to a typename, or a href.
            var scanIndex = innerText.IndexOf(crossReferenceOpeningTagText, StringComparison.Ordinal);
            while (scanIndex >= 0)
            {
                var attrStart = innerText.IndexOf(innerCrefAttributeText, scanIndex, StringComparison.Ordinal);
                if (attrStart >= 0)
                {
                    int crossRefTagEndIndex;
                    var cref = ExtractCrefAttributeContent(innerText, attrStart, out crossRefTagEndIndex);
                    var replacement = BaseWriter.CreateCrossReferenceTagReplacement(assemblyWrapper, cref, version);

                    var oldCrossRefTag = innerText.Substring(scanIndex, crossRefTagEndIndex - scanIndex);
                    innerText = innerText.Replace(oldCrossRefTag, replacement);

                    scanIndex += replacement.Length;
                }
                else
                {
                    attrStart = innerText.IndexOf(innerHrefAttributeText, scanIndex, StringComparison.Ordinal);
                    if (attrStart >= 0)
                    {
                        int crossRefTagEndIndex;
                        var url = ExtractHrefAttributeContent(innerText, attrStart, out crossRefTagEndIndex);
                        var replacement = string.Format("<a href=\"{0}\">{0}</a>", url);

                        var oldCrossRefTag = innerText.Substring(scanIndex, crossRefTagEndIndex - scanIndex);
                        innerText = innerText.Replace(oldCrossRefTag, replacement);

                        scanIndex += replacement.Length;
                    }
                    else
                        scanIndex++;
                }

                scanIndex = innerText.IndexOf(crossReferenceOpeningTagText, scanIndex, StringComparison.Ordinal);                
            }

            return innerText;
        }

        static string ExtractCrefAttributeContent(string nodeText, int crefAttrStart, out int crossRefTagEndIndex)
        {
            var attrTargetStart = crefAttrStart + innerCrefAttributeText.Length;

            var crefTargetEnd = nodeText.IndexOf('"', attrTargetStart);
            crossRefTagEndIndex = nodeText.IndexOf(crossReferenceClosingTagText, crefTargetEnd, StringComparison.Ordinal) 
                                    + crossReferenceClosingTagText.Length;

            var cref = nodeText.Substring(attrTargetStart, crefTargetEnd - attrTargetStart);
            if (cref.Length > 2 && cref[1] == ':')
                cref = cref.Substring(2);

            return cref;
        }

        static string ExtractHrefAttributeContent(string nodeText, int hrefAttrStart, out int crossRefTagEndIndex)
        {
            var attrTargetStart = hrefAttrStart + innerHrefAttributeText.Length;

            var crefTargetEnd = nodeText.IndexOf('"', attrTargetStart);
            crossRefTagEndIndex = nodeText.IndexOf(crossReferenceClosingTagText, crefTargetEnd, StringComparison.Ordinal)
                                    + crossReferenceClosingTagText.Length;

            return nodeText.Substring(attrTargetStart, crefTargetEnd - attrTargetStart);
        }

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

                    processedCodeSample = content.Substring(startPos, endPos - startPos);
                }
                else
                {
                    processedCodeSample = codeNode.Value;
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
            codeBlock = codeBlock.Replace("\t", new string(' ', 4));

            // Find the nearest indent location
            var nearestIndent = int.MaxValue;
            using (var reader = new StringReader(codeBlock))
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
            using (var reader = new StringReader(codeBlock))
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

        public static XDocument LoadAssemblyDocumentationWithSamples(string filePath, string samplesDir, string serviceName)
        {
            if (!string.IsNullOrEmpty(samplesDir))
            {
                var extraDocNodes = new List<XmlNode>(); 
                foreach (var pattern in new [] {".extra.xml", "GeneratedSamples.extra.xml"})
                {
                    var extraFile = Path.Combine(samplesDir, DOC_SAMPLES_SUBFOLDER, serviceName + pattern);
                    if (File.Exists(extraFile))
                    {
                        var extraDoc = new XmlDocument();
                        extraDoc.Load(extraFile);
                        foreach(XmlNode node in extraDoc.SelectNodes("docs/doc"))
                        {
                            extraDocNodes.Add(node);
                        }
                    }
                }

                if (extraDocNodes.Any())
                {
                    Trace.WriteLine(String.Format("Merging {0} code samples into {1}", serviceName, filePath));

                    var sdkDoc = new XmlDocument();
                    sdkDoc.Load(filePath);

                    //ProcessReferences(sdkDoc, extraDoc, extraFile);
                    ProcessExtraDoc(sdkDoc, extraDocNodes);

                    return XDocument.Load(new XmlNodeReader(sdkDoc), LoadOptions.PreserveWhitespace);
                }
            }

            return XDocument.Load(filePath, LoadOptions.PreserveWhitespace);
        }

        //private static void ProcessReferences(XmlDocument sdkDocument, List<XmlNode> refNodes, string ExtraXml)
        //{
        //    //var refNodes = extraDoc.SelectNodes("docs/ref");
            
        //    Trace.WriteLine(String.Format("Found {0} ref nodes", refNodes.Count), "verbose");
        //    foreach (XmlNode refNode in refNodes)
        //    {
        //        var refAttribute = refNode.Attributes["src"];
        //        if (refAttribute == null) throw new InvalidDataException("Unable to retrieve 'src' attribute for ref node");

        //        string refSrc = refAttribute.Value;
        //        Trace.WriteLine(String.Format("Referencing XML from {0}", refSrc), "verbose");
        //        if (!Path.IsPathRooted(refSrc))
        //        {
        //            refSrc = Path.Combine(Path.GetDirectoryName(ExtraXml), refSrc);
        //        }

        //        Trace.WriteLine(String.Format("Loading referenced Extra XML from {0}", refSrc), "verbose");
        //        XmlDocument refExtraDoc = new XmlDocument();
        //        refExtraDoc.Load(refSrc);
        //        var docNodes = refExtraDoc.SelectNodes("docs/doc");
        //        ProcessExtraDoc(sdkDocument, docNodes);
        //    }
        //}

        private static void ProcessExtraDoc(XmlDocument sdkDocument, List<XmlNode> docNodes)
        {
            //var docNodes = extraDoc.SelectNodes("docs/doc");
            Trace.WriteLine(String.Format("Found {0} extra doc nodes", docNodes.Count), "verbose");
            foreach (XmlNode docNode in docNodes)
            {
                var valueNode = docNode.SelectSingleNode("value");
                string extraXml = valueNode.InnerXml;
                extraXml = extraXml == null ? string.Empty : extraXml.Trim();
                if (string.IsNullOrEmpty(extraXml)) throw new InvalidDataException("Extra XML is empty");

                var memberNodes = docNode.SelectNodes("members/member");
                Trace.WriteLine(String.Format("Found {0} member nodes", memberNodes.Count), "verbose");
                foreach (XmlNode memberNode in memberNodes)
                {
                    var attribute = memberNode.Attributes["name"];
                    if (attribute == null) throw new InvalidDataException("Unable to retrieve 'name' attribute for member node");
                    string memberName = attribute.Value;

                    XmlNode node = sdkDocument.SelectSingleNode(string.Format("doc/members/member[@name='{0}']", memberName));
                    if (node == null)
                    {
                        Trace.WriteLine(String.Format("** member name not found, skipping: {0}", memberName), "verbose");
                        continue;
                    }

                    string sdkXml = node.InnerXml;
                    sdkXml += extraXml;
                    node.InnerXml = sdkXml;

                    Trace.WriteLine(String.Format("Successfully updated SDK XML for member {0}", memberName), "verbose");
                }
            }
        }
    }
}
