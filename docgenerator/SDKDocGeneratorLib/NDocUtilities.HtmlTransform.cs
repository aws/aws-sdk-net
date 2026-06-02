using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

using SDKDocGenerator.Writers;

namespace SDKDocGenerator
{
    public static partial class NDocUtilities
    {
        private static readonly Dictionary<string, string> NdocToHtmlElementMapping = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "summary", "p" },
            { "para", "p" },
            { "see", "a" },
            { "paramref", "code" },
            { "important", "div" },
            { "note", "div" },
            { "item", "li" },
            { "term", "span" },
            { "description", "span" }
        };

        private static readonly Dictionary<string, string> NdocToHtmlClassMapping = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "important", "noteblock noteblock-warning" },
            { "note", "noteblock" }
        };

        public static string TransformDocumentationToHTML(XElement element, string rootNodeName, AbstractTypeProvider typeProvider, FrameworkVersion version)
        {
            if (element == null)
                return string.Empty;

            return GenProfiler.Measure(GenProfiler.DocToHtml, () =>
            {
                var rootNode = element.XPathSelectElement(rootNodeName);
                if (rootNode == null) return string.Empty;

                if (rootNodeName.Equals("seealso", StringComparison.OrdinalIgnoreCase))
                    return SeeAlsoElementToHTML(rootNode, typeProvider, version);
                else
                    return DocBlobToHTML(rootNode, typeProvider, version);
            });
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
                                var originalLocalName = reader.LocalName;

                                // element name substitution, if necessary
                                string elementName;
                                var isList = originalLocalName == "list";
                                if (isList)
                                {
                                    // <list type="bullet"> → <ul>, <list type="number"> → <ol>
                                    var listType = reader.GetAttribute("type");
                                    elementName = (listType == "number") ? "ol" : "ul";
                                }
                                else if (!NdocToHtmlElementMapping.TryGetValue(originalLocalName, out elementName))
                                    elementName = originalLocalName;

                                // some elements can't be empty, use this variable for that
                                string emptyElementContents = null;

                                // start element
                                writer.WriteStartElement(elementName);

                                // Add CSS class if the original element has a class mapping
                                string cssClass;
                                if (NdocToHtmlClassMapping.TryGetValue(originalLocalName, out cssClass))
                                {
                                    writer.WriteAttributeString("class", cssClass);
                                }

                                // copy over attributes (skip for list elements — type attribute already consumed)
                                if (reader.HasAttributes && !isList)
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
    }
}
