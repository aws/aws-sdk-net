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

using System.Web;

namespace SDKDocGenerator
{
    public static class NDocUtilities
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

        private static readonly Dictionary<string, string> NdocToHtmlElementMapping = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "summary", "p" },
            { "para", "p" },
            { "see", "a" },
            { "paramref", "code" }
        };

        #region manage ndoc instances
        // The reason we cache the doc data on the side instead of directly referencing doc instances from
        // the type information is becasue we are loading the assemblies for reflection in a separate app domain.

        private static IDictionary<string, IDictionary<string, XElement>> _ndocCache = new Dictionary<string, IDictionary<string, XElement>>();

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
                _ndocCache.Add(docId, CreateNDocTable(platformSpecificNdocFile, serviceName, options));
            }
        }

        public static void UnloadDocumentation(string serviceName, string platform)
        {
            var docId = GenerateDocId(serviceName, platform);
            _ndocCache.Remove(docId);
        }

        public static IDictionary<string, XElement> GetDocumentationInstance(string serviceName, string platform)
        {
            return GetDocumentationInstance(GenerateDocId(serviceName, platform));
        }

        public static IDictionary<string, XElement> GetDocumentationInstance(string docId)
        {
            IDictionary<string, XElement> doc = null;
            if (_ndocCache.TryGetValue(docId, out doc))
            {
                return doc;
            }
            return null;
        }
        
        private static IDictionary<string, XElement> CreateNDocTable(string filePath, string serviceName, GeneratorOptions options)
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
        }
        #endregion


        public static XElement FindDocumentation(AbstractWrapper wrapper, AbstractTypeProvider typeProvider)
        {
            var ndoc = GetDocumentationInstance(wrapper.DocId);
            return FindDocumentation(ndoc, wrapper, typeProvider);
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, AbstractWrapper wrapper, AbstractTypeProvider typeProvider)
        {
            if (ndoc == null)
                return null;

            if (wrapper is TypeWrapper)
                return FindDocumentation(ndoc, (TypeWrapper)wrapper, typeProvider);
            if (wrapper is PropertyInfoWrapper)
                return FindDocumentation(ndoc, (PropertyInfoWrapper)wrapper, typeProvider);
            if (wrapper is MethodInfoWrapper)
                return FindDocumentation(ndoc, (MethodInfoWrapper)wrapper, typeProvider);
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

        public static XElement FindFieldDocumentation(TypeWrapper type, string fieldName)
        {
            var ndoc = GetDocumentationInstance(type.DocId);
            return FindFieldDocumentation(ndoc, type, fieldName);
        }

        public static XElement FindFieldDocumentation(IDictionary<string, XElement> ndoc, TypeWrapper type, string fieldName)
        {
            var signature = string.Format("F:{0}.{1}", type.FullName, fieldName);
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            return element;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, TypeWrapper type, AbstractTypeProvider typeProvider)
        {
            var signature = "T:" + type.FullName;
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            // Follow a plain <inheritdoc/> by searching the base type and interfaces.
            var inheritdocElement = element.XPathSelectElement("inheritdoc");
            if (inheritdocElement == null)
                return element;

            if (inheritdocElement.Attribute(crefAttributeName) != null)
            {
                return FindCrefDocumentation(ndoc, typeProvider, inheritdocElement);
            }

            if (type.BaseType.FullName != "System.Object") // we never expect to inherit class-level docs from here
            {
                var baseTypeDocs = FindDocumentation(ndoc, type.BaseType, typeProvider);

                if (baseTypeDocs != null)
                {
                    return ExtractPathDocumentation(inheritdocElement, baseTypeDocs);
                }
            }

            foreach (var baseInterface in type.GetInterfaces())
            {
                var interfaceDocs = FindDocumentation(ndoc, baseInterface, typeProvider);

                if (interfaceDocs != null)
                {
                    return ExtractPathDocumentation(inheritdocElement, interfaceDocs);
                }
            }

            return element;
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, PropertyInfoWrapper info, AbstractTypeProvider typeProvider)
        {
            var type = info.DeclaringType;
            var signature = string.Format("P:{0}.{1}", type.FullName, info.Name);
            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            // Follow a plain <inheritdoc/> by searching the base type and interfaces.
            var inheritdocElement = element.XPathSelectElement("inheritdoc");
            if (inheritdocElement == null)
                return element;

            if (inheritdocElement.Attribute(crefAttributeName) != null)
            {
                return FindCrefDocumentation(ndoc, typeProvider, inheritdocElement);
            }

            var baseTypeMatchingProperties = info.DeclaringType.BaseType.GetProperties().Where(property => property.Name.Equals(info.Name, StringComparison.OrdinalIgnoreCase));

            if (baseTypeMatchingProperties.Count() == 1)
                return ExtractPathDocumentation(inheritdocElement, FindDocumentation(ndoc, baseTypeMatchingProperties.First(), typeProvider));

            foreach (var baseInterface in info.DeclaringType.GetInterfaces())
            {
                var interfaceMatchingProperties = baseInterface.GetProperties().Where(property => property.Name.Equals(info.Name, StringComparison.OrdinalIgnoreCase));

                if (interfaceMatchingProperties.Count() == 1)
                    return ExtractPathDocumentation(inheritdocElement, FindDocumentation(ndoc, interfaceMatchingProperties.First(), typeProvider));
            }

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

        public static string DetermineNDocNameLookupSignature(MethodInfo info, string docId)
        {
            return DetermineNDocNameLookupSignature(new MethodInfoWrapper(info, docId));
        }

        public static string DetermineNDocNameLookupSignature(MethodInfoWrapper info)
        {
            var type = info.DeclaringType;
            var fullName = type.FullName ?? type.Namespace + "." + type.Name;
            var typeGenericParameters = type.GetGenericArguments();
            var parameters = new StringBuilder();
            foreach (var param in info.GetParameters())
            {
                if (parameters.Length > 0)
                    parameters.Append(",");
                DetermineParameterName(param.ParameterType, parameters, typeGenericParameters);
                if (param.IsOut)
                {
                    parameters.Append("@");
                }
            }

            var genericTag = "";
            if (info.IsGenericMethod)
            {
                genericTag = "``" + info.GetGenericArguments().Length;
            }

            var signature = parameters.Length > 0
                ? string.Format("M:{0}.{1}{2}({3})", fullName, info.Name, genericTag, parameters)
                : string.Format("M:{0}.{1}{2}", fullName, info.Name, genericTag);

            return signature;
        }

        private static void DetermineParameterName(TypeWrapper parameterTypeInfo, StringBuilder parameters, IList<TypeWrapper> typeGenericParameters)
        {
            if (parameterTypeInfo.IsGenericParameter)
            {
                var typeGenericParameterIndex = typeGenericParameters.IndexOf(parameterTypeInfo);
                var isClassGenericParameter = typeGenericParameterIndex >= 0;

                if (isClassGenericParameter)
                    parameters.AppendFormat("`{0}", typeGenericParameterIndex);
                else
                    parameters.AppendFormat("``{0}", 0);
            }
            else if (parameterTypeInfo.IsGenericType)
            {
                parameters
                    .Append(parameterTypeInfo.GenericTypeName)
                    .Append("{");
                IList<TypeWrapper> args = parameterTypeInfo.GenericTypeArguments();

                for (var i = 0; i < args.Count; i++)
                {
                    if (i != 0)
                    {
                        parameters.Append(",");
                    }
                    DetermineParameterName(args[i], parameters, typeGenericParameters);
                }
                parameters.Append("}");

            }
            else
            {
                parameters.Append(parameterTypeInfo.FullName);
            }
        }

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, MethodInfoWrapper info, AbstractTypeProvider typeProvider)
        {
            var signature = DetermineNDocNameLookupSignature(info);

            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            // Follow a plain < inheritdoc /> by searching the base type and interfaces.
            var inheritdocElement = element.XPathSelectElement("inheritdoc");
            if (inheritdocElement == null)
                return element;

            if (inheritdocElement.Attribute(crefAttributeName) != null)
            {
                return FindCrefDocumentation(ndoc, typeProvider, inheritdocElement);
            }

            var baseTypeMatchingMethods = info.DeclaringType.BaseType.GetMethodsToDocument().Where(method => method.FullName.Equals(info.FullName, StringComparison.OrdinalIgnoreCase));
                
            if (baseTypeMatchingMethods.Count() == 1)
                return ExtractPathDocumentation(inheritdocElement, FindDocumentation(ndoc, baseTypeMatchingMethods.First(), typeProvider));

            foreach (var baseInterface in info.DeclaringType.GetInterfaces())
            {
                var interfaceMatchingMethods = baseInterface.GetMethodsToDocument().Where(method => method.FullName.Equals(info.FullName, StringComparison.OrdinalIgnoreCase));

                if (interfaceMatchingMethods.Count() == 1)
                    return ExtractPathDocumentation(inheritdocElement, FindDocumentation(ndoc, interfaceMatchingMethods.First(), typeProvider));
            }

            return element;
        }                

        public static XElement FindDocumentation(IDictionary<string, XElement> ndoc, ConstructorInfoWrapper info)
        {
            var type = info.DeclaringType;
            var parameters = new StringBuilder();
            var typeGenericParameters = type.GetGenericArguments();
            foreach (var param in info.GetParameters())
            {
                if (parameters.Length > 0)
                    parameters.Append(",");
                DetermineParameterName(param.ParameterType, parameters, typeGenericParameters);
                if (param.IsOut)
                {
                    parameters.Append("@");
                }
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

        /// <summary>
        /// Finds the Async version of the specified non async method info.
        /// </summary>
        /// <param name="ndoc"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public static XElement FindDocumentationAsync(IDictionary<string, XElement> ndoc, MethodInfoWrapper info, AbstractTypeProvider typeProvider)
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

            // Async methods have this additional parameter
            parameters.Append("System.Threading.CancellationToken");

            var signature = parameters.Length > 0
                ? string.Format("M:{0}.{1}({2})", type.FullName, info.Name + "Async", parameters)
                : string.Format("M:{0}.{1}", type.FullName, info.Name + "Async");

            XElement element;
            if (!ndoc.TryGetValue(signature, out element))
                return null;

            // Follow a plain < inheritdoc /> by searching the base type and interfaces.
            var inheritdocElement = element.XPathSelectElement("inheritdoc");
            if (inheritdocElement == null)
                return element;

            if (inheritdocElement.Attribute(crefAttributeName) != null)
            {
                return FindCrefDocumentation(ndoc, typeProvider, inheritdocElement);
            }

            var baseTypeMatchingMethods = info.DeclaringType.BaseType.GetMethodsToDocument().Where(method => method.FullName.Equals(info.FullName, StringComparison.OrdinalIgnoreCase));

            if (baseTypeMatchingMethods.Count() == 1)
                return ExtractPathDocumentation(inheritdocElement, FindDocumentation(ndoc, baseTypeMatchingMethods.First(), typeProvider));

            foreach (var baseInterface in info.DeclaringType.GetInterfaces())
            {
                var interfaceMatchingMethods = baseInterface.GetMethodsToDocument().Where(method => method.FullName.Equals(info.FullName, StringComparison.OrdinalIgnoreCase));

                if (interfaceMatchingMethods.Count() == 1)
                    return ExtractPathDocumentation(inheritdocElement, FindDocumentation(ndoc, interfaceMatchingMethods.First(), typeProvider));
            }

            return element;
        }

        public static string TransformDocumentationToHTML(XElement element, string rootNodeName, AbstractTypeProvider typeProvider, FrameworkVersion version)
        {
            if (element == null)
                return string.Empty;

            var rootNode = element.XPathSelectElement(rootNodeName);
            if (rootNode == null)       return string.Empty;
            
            if (rootNodeName.Equals("seealso", StringComparison.OrdinalIgnoreCase))
                return SeeAlsoElementToHTML(rootNode, typeProvider, version);
            else
                return DocBlobToHTML(rootNode, typeProvider, version);
        }

        private static XElement FindCrefDocumentation(IDictionary<string, XElement> ndoc, AbstractTypeProvider typeProvider, XElement inheritdocElement)
        {
            var crefValue = inheritdocElement.Attribute(crefAttributeName)?.Value;
            if (crefValue == null)
                return inheritdocElement;

            var attributParts = crefValue.Split(':');
            if (attributParts.Length != 2)
                return inheritdocElement;

            var attributePart = attributParts[1];
            var targetType = typeProvider.GetType(attributePart);

            XElement targetDocs = null;

            if (targetType == null) // the cref attribute is pointing to a method or a property
            {
                if (attributePart.LastIndexOf('.') < 0)
                    return inheritdocElement;

                var typeName = attributePart.Substring(0, attributePart.LastIndexOf('.'));
                targetType = typeProvider.GetType(typeName);

                if (targetType == null)
                    return inheritdocElement;

                var typeMemberName = attributePart.Substring(attributePart.LastIndexOf('.') + 1);

                var matchingMethods = targetType.GetMethodsToDocument().Where(method => method.FullName.Equals(attributePart, StringComparison.OrdinalIgnoreCase));
                var matchingProperties = targetType.GetProperties().Where(property => property.Name.Equals(typeMemberName, StringComparison.OrdinalIgnoreCase));

                if (matchingMethods.Count() == 1)
                    targetDocs = FindDocumentation(ndoc, matchingMethods.First(), typeProvider);
                else if (matchingProperties.Count() == 1)
                    targetDocs = FindDocumentation(ndoc, matchingProperties.First(), typeProvider);
                else 
                    return inheritdocElement;
            }
            else
            {
                targetDocs = FindDocumentation(ndoc, targetType, typeProvider);
            }

            if (targetDocs != null)
            {
                return ExtractPathDocumentation(inheritdocElement, targetDocs);
            }

            return inheritdocElement;
        }

        private static XElement ExtractPathDocumentation(XElement inheritdocElement, XElement docElement)
        {
            if (inheritdocElement.Attribute(pathAttributeName) == null)
                return docElement;

            var pathValue = inheritdocElement.Attribute(pathAttributeName).Value;

            var targetPathDocs = docElement.XPathSelectElement(pathValue);

            if (targetPathDocs != null) 
            {
                var docElementCopy = new XElement(docElement);
                docElementCopy.RemoveNodes();

                // Wrap the targetPathDocs in summary tag to be picked up by the html transformer.
                docElementCopy.Add(new XElement("summary", targetPathDocs));

                return docElementCopy;
            }

            return docElement;
        }

        private static string SeeAlsoElementToHTML(XElement rootNode, AbstractTypeProvider typeProvider, FrameworkVersion version)
        {
            var reader = rootNode.CreateReader();
            reader.MoveToContent();
            var innerXml = reader.ReadInnerXml();
            string content = "";

            var href = rootNode.Attribute("href");
            if (href != null)
            {
                content += string.Format(@"<div><a href=""{0}"" target=""_parent"" rel=""noopener noreferrer"">{1}</a></div>", href.Value, innerXml);
            }

            var cref = rootNode.Attribute(crefAttributeName);
            if (cref != null)
            {
                content += BaseWriter.CreateCrossReferenceTagReplacement(typeProvider, cref.Value, version);
            }

            return content;
        }

        private static string DocBlobToHTML(XElement rootNode, AbstractTypeProvider typeProvider, FrameworkVersion version)
        {
            using (var textWriter = new StringWriter())
            {
                var writerSettings = new XmlWriterSettings { OmitXmlDeclaration = true };
                using (var writer = XmlWriter.Create(textWriter, writerSettings))
                {
                    var reader = rootNode.CreateReader();
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                // handle self-closing element, like <a />
                                // this must be read before any other reading is done
                                var selfClosingElement = reader.IsEmptyElement;

                                // element name substitution, if necessary
                                string elementName;
                                if (!NdocToHtmlElementMapping.TryGetValue(reader.LocalName, out elementName))
                                    elementName = reader.LocalName;

                                // some elements can't be empty, use this variable for that
                                string emptyElementContents = null;

                                // start element
                                writer.WriteStartElement(elementName);

                                // copy over attributes
                                if (reader.HasAttributes)
                                {
                                    var isAbsoluteLink = false;
                                    var hasTarget = false;

                                    for (int i = 0; i < reader.AttributeCount; i++)
                                    {
                                        reader.MoveToAttribute(i);
                                        var attributeName = reader.Name;
                                        var attributeValue = reader.Value;

                                        var isCref = string.Equals(attributeName, crefAttributeName, StringComparison.Ordinal);
                                        var isHref = string.Equals(attributeName, hrefAttributeName, StringComparison.Ordinal);
                                        var isName = string.Equals(attributeName, nameAttributeName, StringComparison.Ordinal);
                                        var isTarget = string.Equals(attributeName, targetAttributeName, StringComparison.Ordinal);

                                        var writeAttribute = true;

                                        if (isCref)
                                        {
                                            // replace cref with href
                                            attributeName = hrefAttributeName;

                                            // extract type name from cref value for emptyElementContents
                                            var crefParts = attributeValue.Split(':');
                                            if (crefParts.Length != 2)
                                                throw new InvalidOperationException();
                                            var typeName = crefParts[1];
                                            var targetType = typeProvider.GetType(typeName);
                                            if (targetType == null)
                                            {
                                                emptyElementContents = typeName;
                                                //If the type cannot be found do not render out the href attribute.
                                                //This will make it so things such as properties which we do not have
                                                //specific doc pages for do not render as a broken link but we can still
                                                //use the crefs in the code correctly.
                                                writeAttribute = false;
                                            }
                                            else
                                                emptyElementContents = targetType.CreateReferenceHtml(fullTypeName: true);
                                        }
                                        else if (isHref)
                                        {
                                            // extract href value for emptyElementContents
                                            emptyElementContents = attributeValue;

                                            if (attributeValue.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                                                attributeValue.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                                            {
                                                isAbsoluteLink = true;
                                            }
                                        }
                                        else if (isName)
                                        {
                                            emptyElementContents = attributeValue;
                                        }
                                        else if (isTarget)
                                        {
                                            hasTarget = true;
                                        }

                                        if (writeAttribute)
                                        {
                                            writer.WriteAttributeString(attributeName, attributeValue);
                                        }
                                    }

                                    if (elementName == "a" && isAbsoluteLink && !hasTarget)
                                    {
                                        //Add a target=\"_blank\" to allow the absolute link to break out
                                        //of the frame.
                                        writer.WriteAttributeString(targetAttributeName, "_blank");
                                    }
                                }

                                // if this is a self-closing element, close it
                                if (selfClosingElement)
                                {
                                    // write empty element contents, if any
                                    if (!string.IsNullOrEmpty(emptyElementContents))
                                    {
                                        writer.WriteRaw(emptyElementContents);
                                    }

                                    // close element now
                                    writer.WriteEndElement();
                                }

                                break;
                            case XmlNodeType.EndElement:
                                writer.WriteEndElement();
                                break;
                            case XmlNodeType.Text:
                                writer.WriteRaw(reader.Value);
                                break;
                            default:
                                throw new InvalidOperationException();
                        }
                    }
                }

                return textWriter.ToString();
            }
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

        public static XDocument LoadAssemblyDocumentationWithSamples(string filePath, string samplesDir, string serviceName)
        {
            if (!string.IsNullOrEmpty(samplesDir))
            {
                var extraDocNodes = new List<XmlNode>();
                foreach (var pattern in new[] { ".extra.xml", ".GeneratedSamples.extra.xml" })
                {
                    var extraFile = Path.Combine(samplesDir, DOC_SAMPLES_SUBFOLDER, serviceName + pattern);
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
