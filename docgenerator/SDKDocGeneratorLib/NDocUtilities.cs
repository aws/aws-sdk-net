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
using System.Text.RegularExpressions;

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

        /// <summary>
        /// For methods that end in "Async", checks for the method with a similar signature, but following the Unity Async pattern.
        /// </summary>
        /// <param name="ndoc"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public static XElement FindDocumentationUnityAsync(IDictionary<string, XElement> ndoc, MethodInfoWrapper info)
        {
            if (ndoc == null)
                return null;
            var type = info.DeclaringType;
            var parameters = new StringBuilder();

            if (!info.Name.EndsWith("Async", StringComparison.Ordinal))
                return null;

            foreach (var param in info.GetParameters())
            {
                if (parameters.Length > 0)
                    parameters.Append(",");

                // Unity parameters for Async methods exclude CancellationToken
                if (param.ParameterType.FullName == "System.Threading.CancellationToken")
                    break;

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

            var typeNameSplit = type.FullName.Split('.');
            var modelLocation = string.Join(".", typeNameSplit.Take(typeNameSplit.Length - 1));
            Match match = Regex.Match(info.Name, @"(.*)Async");
            string operationName = match.Success ? match.Groups[1].Value : string.Empty;

            if (modelLocation == string.Empty || operationName == string.Empty)
                return null;

            List<string> possibleParameters = new List<string>();

            // Unity Async methods have these additional parameters
            var parametersPossibility = new StringBuilder(parameters.ToString());
            parametersPossibility.Append("Amazon.Runtime.AmazonServiceCallback")
                .Append("{")
                .Append(modelLocation)
                .Append(".Model.")
                .Append(operationName)
                .Append("Request,")
                .Append(modelLocation)
                .Append(".Model.")
                .Append(operationName)
                .Append("Response},Amazon.Runtime.AsyncOptions");
            possibleParameters.Add(parametersPossibility.ToString());

            // a few Unity async methods lack the callback parameter
            parametersPossibility = new StringBuilder(parameters.ToString());
            parametersPossibility.Append("Amazon.Runtime.AsyncOptions");
            possibleParameters.Add(parametersPossibility.ToString());

            // DynamoDB High Level has its own callback
            parametersPossibility = new StringBuilder(parameters.ToString());
            parametersPossibility.Append("Amazon.DynamoDBv2.AmazonDynamoDBCallback,Amazon.Runtime.AsyncOptions");
            possibleParameters.Add(parametersPossibility.ToString());

            // CognitoSyncManager has its own callback, and does not follow a generic pattern that
            // can be infered by the net45 operation type/method info.
            parametersPossibility = new StringBuilder(parameters.ToString());
            parametersPossibility.Append("Amazon.CognitoSync.SyncManager.AmazonCognitoSyncCallback{System.Collections.Generic.List{Amazon.CognitoSync.SyncManager.DatasetMetadata}},Amazon.Runtime.AsyncOptions");
            possibleParameters.Add(parametersPossibility.ToString());

            foreach (string p in possibleParameters)
            {
                var signature = p.Length > 0
                ? string.Format("M:{0}.{1}({2})", type.FullName, info.Name, p)
                : string.Format("M:{0}.{1}", type.FullName, info.Name);

                XElement element;
                if (ndoc.TryGetValue(signature, out element))
                    return element;
            }
            return null;
        }

        /// <summary>
        /// For methods that DO NOT end in "Async", checks for the Async version of the method with
        /// a similar signature, following the Unity Async pattern.
        /// </summary>
        /// <param name="ndoc"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public static XElement FindDocumentationUnityAsyncAlternative(IDictionary<string, XElement> ndoc, MethodInfoWrapper info)
        {
            if (ndoc == null)
                return null;
            var type = info.DeclaringType;
            if (type.FullName == null)
                return null;
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

            if (parameters.Length > 0)
                parameters.Append(",");

            var typeNameSplit = type.FullName.Split('.');
            var modelLocation = string.Join(".", typeNameSplit.Take(typeNameSplit.Length - 1));

            if (modelLocation == string.Empty)
                return null;

            List<string> possibleParameters = new List<string>();

            // Unity Async methods generally have these additional parameters
            var parametersPossibility = new StringBuilder(parameters.ToString());
            parametersPossibility.Append("Amazon.Runtime.AmazonServiceCallback")
                .Append("{")
                .Append(modelLocation)
                .Append(".Model.")
                .Append(info.Name)
                .Append("Request,")
                .Append(modelLocation)
                .Append(".Model.")
                .Append(info.Name)
                .Append("Response},Amazon.Runtime.AsyncOptions");
            possibleParameters.Add(parametersPossibility.ToString());

            // a few Unity async methods lack the callback parameter
            parametersPossibility = new StringBuilder(parameters.ToString());
            parametersPossibility.Append("Amazon.Runtime.AsyncOptions");
            possibleParameters.Add(parametersPossibility.ToString());

            // DynamoDB High Level has its own callback
            parametersPossibility = new StringBuilder(parameters.ToString());
            parametersPossibility.Append("Amazon.DynamoDBv2.AmazonDynamoDBCallback,Amazon.Runtime.AsyncOptions");
            possibleParameters.Add(parametersPossibility.ToString());

            foreach (string p in possibleParameters)
            {
                var signature = p.Length > 0
                    ? string.Format("M:{0}.{1}({2})", type.FullName, info.Name + "Async", p)
                    : string.Format("M:{0}.{1}", type.FullName, info.Name + "Async");

                XElement element;
                if (ndoc.TryGetValue(signature, out element))
                    return element;
            }
            return null;
        }

        /// <summary>
        /// For methods that DO NOT end in "Async", checks for the Async version of the method with
        /// a similar signature, following the PCL/.Net45 Async pattern.
        /// </summary>
        /// <param name="ndoc"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public static XElement FindDocumentationPCLAsyncAlternative(IDictionary<string, XElement> ndoc, MethodInfoWrapper info)
        {
            if (ndoc == null)
                return null;
            var type = info.DeclaringType;
            if (type.FullName == null)
                return null;
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

            if (parameters.Length > 0)
                parameters.Append(",");

            // PCL Async methods have this additional parameter
            parameters.Append("System.Threading.CancellationToken");

            var signature = parameters.Length > 0
                ? string.Format("M:{0}.{1}({2})", type.FullName, info.Name + "Async", parameters)
                : string.Format("M:{0}.{1}", type.FullName, info.Name + "Async");

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
                foreach (var pattern in new [] {".extra.xml", ".GeneratedSamples.extra.xml"})
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

                    var examplesMap = BuildExamplesMap(extraDocNodes);
                    ProcessExtraDoc(sdkDoc, examplesMap);

                    return XDocument.Load(new XmlNodeReader(sdkDoc), LoadOptions.PreserveWhitespace);
                }
            }

            return XDocument.Load(filePath, LoadOptions.PreserveWhitespace);
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
            
        private static void ProcessExtraDoc(XmlDocument sdkDocument, IDictionary<string, string> examplesMap)
        {
            foreach (var memberSpec in examplesMap.Keys)
            {
                var docNode = sdkDocument.SelectSingleNode(string.Format("doc/members/member[@name='{0}']", memberSpec));
                if (null == docNode)
                {
                    Trace.WriteLine(String.Format("** member name not found, skipping: {0}", memberSpec), "verbose");
                    continue;
                }

                XmlNode sdkExampleNode = docNode.SelectSingleNode("example");
                if (null != sdkExampleNode)
                {
                    sdkExampleNode.InnerXml = examplesMap[memberSpec];
                }
                else
                {
                    string sdkXml = docNode.InnerXml;
                    sdkXml += String.Format("<example>{0}</example>", examplesMap[memberSpec]);
                    docNode.InnerXml = sdkXml;
                }

                Trace.WriteLine(string.Format("Successfully updated SDK XML for member {0}", memberSpec), "verbose");
            }
        }
    }
}
