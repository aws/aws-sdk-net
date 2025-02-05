using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    #region BaseModel

    /// <summary>
    /// Used to outline the basics of any model for the service
    /// They have a service model, json data, and documentation
    /// </summary>
    public abstract class BaseModel
    {
        public ServiceModel model { get; protected set; }
        public JsonData data { get; protected set; }

        protected BaseModel(ServiceModel model, JsonData data)
        {
            this.model = model;
            this.data = data;
        }

        public virtual string Documentation
        {
            get
            {
                var docNode = data[ServiceModel.DocumentationKey];
                if (docNode == null)
                    return string.Empty;
                return docNode.ToString();
            }
        }

        /// <summary>
        /// If defined, specifies the namespace uri for the xml constructed
        /// </summary>
        public string XmlNamespace
        {
            get
            {
                var namespaceData = data[ServiceModel.XmlNamespaceKey];
                if (namespaceData == null)
                {
                    return string.Empty;
                }

                //"xmlNamespace": {
                //    "prefix": "baz",
                //    "uri": "http://foo.com"
                //}                
                if (namespaceData.IsObject)
                {
                    return namespaceData[ServiceModel.XmlNamespaceUriKey]?.ToString() ?? string.Empty;
                }

                //"xmlNamespace": "http://foo.com"
                return (string)namespaceData;
            }
        }

        /// <summary>
        /// Determines if the given node has "streaming": true which can be applied to a shape
        /// or a member.
        /// </summary>
        public bool IsStreaming
        {
            get
            {
                var streamingNode = this.data[Shape.StreamingKey];
                if (streamingNode == null)
                    return false;

                return bool.Parse(streamingNode.ToString());
            }
        }

        /// <summary>
        /// Determines if the given node has "eventstream": true which can be applied to a shape
        /// or a member.
        /// </summary>
        public bool IsEventStream
        {
            get
            {
                var isEventStream = data[Shape.EventStreamKey];
                if (isEventStream != null && isEventStream.IsBoolean)
                {
                    return (bool)isEventStream;
                }

                return false;
            }
        }

        /// <summary>
        /// If defined, specifies the namespace prefix the xml constructed
        /// </summary>
        public string XmlNamespacePrefix
        {
            get
            {
                var namespaceData = data[ServiceModel.XmlNamespaceKey];
                if (namespaceData == null)
                {
                    return string.Empty;
                }

                //"xmlNamespace": {
                //    "prefix": "baz",
                //    "uri": "http://foo.com"
                //}                
                if (namespaceData.IsObject)
                {
                    return namespaceData[ServiceModel.XmlNamespacePrefixKey]?.ToString() ?? string.Empty;
                }

                return string.Empty;
            }
        }
    }

    #endregion

    #region OperationInput

    /// <summary>
    /// For some operations the xmlnamespace and locations are specified on the 
    /// operation:input. E.g. Route53 ChangeResourceRecordSets.
    /// </summary>
    public class OperationInput : BaseModel
    {
        /// <summary>
        /// Creates an operation input through the BaseModel
        /// </summary>
        /// <param name="model">The model of the service</param>
        /// <param name="data">The model as a jsonData object</param>
        public OperationInput(ServiceModel model, JsonData data)
            : base(model, data)
        {
        }

        /// <summary>
        /// The name of the location
        /// </summary>
        public string LocationName
        {
            get
            {
                var node = this.data[ServiceModel.LocationNameKey];
                if (node == null)
                    return string.Empty;

                return node.ToString();
            }
        }
    }

    #endregion


    #region Enumeration

    /// <summary>
    /// Used to create the enumeration class for a service
    /// </summary>
    public class Enumeration
    {
        public const string EnumKey = "enum";

        ServiceModel model;
        readonly string _modelName;
        readonly string _outputName;
        readonly JsonData _data;

        /// <summary>
        /// Creates an enumeration that can model parts of the enumeration for the service
        /// </summary>
        /// <param name="model">The service model that is using the enumartion</param>
        /// <param name="name">The name of the enumeration</param>
        /// <param name="data">The json data for the enumartion object</param>
        public Enumeration(ServiceModel model, string name, JsonData data)
        {
            this.model = model;
            _modelName = name;
            _data = data;

            var overrideName = model.Customizations.GetOverrideShapeName(_modelName);
            _outputName = !string.IsNullOrEmpty(overrideName) 
                ? overrideName.ToUpperFirstCharacter()
                : _modelName.ToUpperFirstCharacter();
        }

        /// <summary>
        /// The name of the enumeration as encoded in the original model.
        /// </summary>
        public string ModelName
        {
            get { return this._modelName; }
        }

        /// <summary>
        /// The emitted name of the enumeration. If no customization is
        /// applied to the shape, this is the same as ModelName.
        /// </summary>
        public string Name
        {
            get { return _outputName; }
        }

        private string Customize(string typeName, string propertyName)
        {
            var custom = this.model.Customizations.GetPropertyModifier(typeName, propertyName);
            if (custom != null)
                return custom.EmitName;

            return propertyName;
        }

        /// <summary>
        /// A list of all the values for the Enumeration found in the json model
        /// </summary>
        public IEnumerable<EnumEntry> EnumerationValues
        {
            get
            {
                var enumValues = this._data[EnumKey];

                var list = (from object value in enumValues
                            select new EnumEntry(value.ToString())).ToList();

                foreach(var item in list)
                {
                    var custom = this.model.Customizations.GetPropertyModifier(this.ModelName, item.MarshallName);
                    if (custom != null)
                        item.CustomPropertyName = custom.EmitName;
                }

                return list.OrderBy(x => x.PropertyName).ToList();
            }
        }

        #region EnumEntry

        /// <summary>
        /// An enum entry is used to represent a value in the enumeration
        /// </summary>
        public class EnumEntry
        {
            /// <summary>
            /// Creates an enumentry that represents a value of the enumeration that contains this object
            /// </summary>
            /// <param name="name"></param>
            public EnumEntry(string name)
            {
                this.MarshallName = name;
            }

            /// <summary>
            /// The name of the marshaller for the EnumEntry
            /// </summary>
            public string MarshallName
            {
                get;
                private set;
            }

            private static readonly char[] CapitalizingSeparators =
            {
                 '–', '-','/', '.', ' ', ':', ',', '+', '&', '*'
            };

            public string CustomPropertyName { get; set; }

            /// <summary>
            /// Then name of the entry to be used by the generator to represent the entry in the code
            /// </summary>
            public string PropertyName
            {
                get
                {
                    if (this.CustomPropertyName != null)
                        return this.CustomPropertyName;
                    var sb = new StringBuilder();
                    var tokens = this.MarshallName.Split(CapitalizingSeparators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var token in tokens)
                    {
                        var upperChar = token[0].ToString().ToUpper();
                        sb.Append(upperChar);
                        if (token.Length > 1)
                        {
                            var remainingName = token.Substring(1);
                            sb.Append(remainingName);
                        }
                    }

                    var result = sb
                        .Replace("(", "")
                        .Replace(")", "")
                        .ToString();
                    return result;
                }
            }
        }

        #endregion
    }

    #endregion
}
