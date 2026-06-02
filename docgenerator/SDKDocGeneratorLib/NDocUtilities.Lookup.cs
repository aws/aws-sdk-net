using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;

namespace SDKDocGenerator
{
    public static partial class NDocUtilities
    {
        public static XElement FindDocumentation(AbstractWrapper wrapper, AbstractTypeProvider typeProvider)
        {
            return GenProfiler.Measure(GenProfiler.DocLookup, () =>
            {
                var ndoc = GetDocumentationInstance(wrapper.DocId);
                return FindDocumentation(ndoc, wrapper, typeProvider);
            });
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
            var signature = DetermineConstructorSignature(info);

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
    }
}
