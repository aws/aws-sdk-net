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

        /// <summary>
        /// The namespace for the xml
        /// </summary>
        public string XmlNamespace
        {
            get
            {
                return data[ServiceModel.XmlNamespaceKey] == null ? string.Empty :
                    (string)data[ServiceModel.XmlNamespaceKey][ServiceModel.XmlNamespaceUriKey];

                //var node = this.data[ServiceModel.XmlNamespaceKey];
                //if (node == null)
                //    return string.Empty;

                //return node.ToString();
            }
        }
    }

    #endregion

    #region ExceptionModel

    /// <summary>
    /// The model that represents exceptions for the service
    /// </summary>
    public class ExceptionModel
    {
        public const string ErrorKey = "error";
        public const string CodeKey = "code";

        readonly JsonData _data;
        readonly string _name;
        readonly string _documentation;
        readonly Shape _structure;

        /// <summary>
        /// Creates a model that represents an exception in the service processed in the response
        /// </summary>
        /// <param name="data">The json data that contains information about the exception found in the model</param>
        /// <param name="name">The name of the exception</param>
        /// <param name="documentation">The documentation for the exception found in the service model json</param>
        /// <param name="structure">The shape that represents the exception</param>
        public ExceptionModel(JsonData data, string name, string documentation, Shape structure)
        {
            this._data = data;
            this._name = name;
            this._documentation = documentation;
            this._structure = structure;
        }

        /// <summary>
        /// Returns the name of the exception with the word Exception appended to the end, removes the word fault from the end if it's there
        /// </summary>
        public string Name
        {
            get
            {
                if (this._name.EndsWith("Exception"))
                    return this._name;

                if (this._name.EndsWith("Fault"))
                    return this._name.Substring(0, this._name.LastIndexOf("Fault")) + "Exception";

                return this._name + "Exception";
            }
        }

        /// <summary>
        /// The error code for the exception, returns the name if one is not specified in the json model.
        /// We first check in any referenced structure, then fall back to the exception shape to discover
        /// the code.
        /// </summary>
        public string Code
        {
            get
            {
                if (Structure != null && Structure.HasErrorCode)
                    return Structure.ErrorCode;

                var error = _data[ErrorKey];
                if (error == null) return this._name;
                var code = error[CodeKey];
                if (code == null) return this._name;
                return code.ToString();
            }
        }

        /// <summary>
        /// The documentation for the exception
        /// </summary>
        public string Documentation
        {
            get { return this._documentation; }
        }

        /// <summary>
        /// The shape of the exception from the json
        /// </summary>
        public Shape Structure
        {
            get
            {
                return this._structure;
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
                ? ServiceModel.CapitalizeFirstChar(overrideName)
                : ServiceModel.CapitalizeFirstChar(_modelName);
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
                '-', '/', '.', ' ',':'
            };

            public string CustomPropertyName { get; set; }

            /// <summary>
            /// Then name of the entry to be used by the generator to represnet the entry in the code
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
