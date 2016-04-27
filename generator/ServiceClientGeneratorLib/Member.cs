using System.Reflection;
using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Members are properties are parts of a shape, they are used to identify sub shapes that the parent shape owns
    /// </summary>
    public class Member : BaseModel
    {
        public const string Locationkey = "location";
        public const string MemberKey = "member";
        public const string FlattenedKey = "flattened";

        private readonly string _name;
        private string _newType;
        readonly string _defaultMarshallName;

        readonly string[] _nullableTypes =
        {
            "long",
            "integer",
            "float",
            "double",
            "DateTime",
            "boolean",
            "timestamp",
            "int",
            "bool"
        };

        public Member(ServiceModel model, Shape owningShape, string name, string defaultMarshallName, CustomizationsModel.PropertyInjector propertyInjector)
            : base(model, propertyInjector.Data)
        {
            this.OwningShape = owningShape;
            _name = name;
            _defaultMarshallName = defaultMarshallName;
            this.PropertyModifier = null;
            this.PropertyInjector = propertyInjector;
        }

        public Member(ServiceModel model, Shape owningShape, string name, string defaultMarshallName, JsonData data, CustomizationsModel.PropertyModifier propertyModifier)
            : base(model, data)
        {
            this.OwningShape = owningShape;
            _name = name;
            _defaultMarshallName = defaultMarshallName;
            this.PropertyModifier = propertyModifier;
            this.PropertyInjector = null;
        }

        public Shape OwningShape { get; protected set; }

        // injected members are not subject to renaming, exclusion etc
        public bool IsInjected
        {
            get { return PropertyInjector != null; }
        }

        public bool HasModifier
        {
            get { return PropertyModifier != null; }
        }

        public CustomizationsModel.PropertyModifier PropertyModifier { get; protected set; }
        public CustomizationsModel.PropertyInjector PropertyInjector { get; protected set; }

        /// <summary>
        /// The access modifier of the property. Defaults to public if not set in the customization.
        /// </summary>
        public string AccessModifier
        {
            get
            {
                if (!this.HasModifier)
                    return "public";

                return this.PropertyModifier.AccessModifier;
            }
        }

        /// <summary>
        /// The name of the member with the first character lower and begins with an underscore: _nameHere
        /// </summary>
        public string VariableName
        {
            get
            {
                string memberName = null;

                // Follow any property renaming for this member for consistent viewing
                if (!IsInjected)
                {
                    var propertyModifier = this.model.Customizations.GetPropertyModifier(OwningShape.Name, this._name);
                    if (propertyModifier != null)
                        memberName = propertyModifier.EmitName;
                }

                if (string.IsNullOrEmpty(memberName))
                    memberName = this._name;

                return memberName.ToClassMemberCase();
            }
        }

        /// <summary>
        /// The name of the member with the first character lower: nameHere
        /// </summary>
        public string ArgumentName
        {
            get
            {
                // ignoring any property renaming when used as an argument at this time
                return GeneratorHelpers.CamelCaseParam(this._name);
            }
        }

        /// <summary>
        /// Used for getting any custom changes to the member such as changing the type from a string to a DateTime etc.
        /// </summary>
        public CustomizationsModel.DataTypeOverride OverrideDataType
        {
            get
            {
                // not applicable to injected properties, since we assume they are
                // configured to match what must be produced
                if (IsInjected)
                    return null;

                var overrideType = this.model.Customizations.OverrideDataType(OwningShape.Name, this._name);
                return overrideType;
            }
        }

        /// <summary>
        /// Determines if the member is customized to specifically use a nullable type
        /// </summary>
        public bool UseNullable
        {
            get
            {
                return this.model.Customizations.UseNullable(OwningShape.Name, this._name);
            }
        }

        /// <summary>
        /// Determines if the member is customized to emit an Is[Name]Set property.
        /// </summary>
        public bool EmitIsSetProperties
        {
            get
            {
                return this.model.Customizations.EmitIsSetProperties(OwningShape.Name, this._name);
            }
        }

        /// <summary>
        /// The name of the member as the first character upper: NameHere
        /// Uses the custom name instead if it exists
        /// </summary>
        public string PropertyName
        {
            get
            {
                if (!IsInjected)
                {
                    // Check to see if customizations is overriding the name specified in the model for the property.
                    var propertyModifier = this.model.Customizations.GetPropertyModifier(OwningShape.Name, this._name);
                    if (propertyModifier != null)
                    {
                        var overrideName = propertyModifier.EmitName;
                        if (!string.IsNullOrEmpty(overrideName))
                            return overrideName;
                    }
                }

                string txt = this._name[0].ToString().ToUpper();
                if (this._name.Length > 1)
                    txt += this._name.Substring(1);
                return txt;
            }
        }

        /// <summary>
        /// The name of the marshaller
        /// </summary>
        public string MarshallName
        {
            get
            {
                return LocationName ?? _defaultMarshallName;
            }
        }

        /// <summary>
        /// Determines if this member resides in the head of the request/response
        /// </summary>
        public bool IsInHeader
        {
            get
            {
                var locationData = data[Locationkey];
                var location = locationData == null ? null : locationData.ToString();
                return !string.IsNullOrEmpty(location) &&
                       string.Equals(location, "header", StringComparison.Ordinal);
            }
        }

        /// <summary>
        /// The name of the location
        /// </summary>
        public string LocationName
        {
            get
            {
                if (ModelShape != null && !string.IsNullOrEmpty(ModelShape.LocationName) && ModelShape.IsFlattened)
                    return ModelShape.LocationName;

                // if list, lookup member/metadata/xmlName
                // otherwise, lookup metadata/xmlName
                var source = data;
                if (IsList)
                {
                    var member = data[MemberKey];
                    if (member != null)
                        source = member;
                }

                var locationName = source[ServiceModel.LocationNameKey];
                if (locationName == null) return null;
                return locationName.ToString();
            }
        }

        /// <summary>
        /// If defined, specifies the namespace for the xml constructed
        /// </summary>
        public string XmlNamespace
        {
            get
            {
                return data[ServiceModel.XmlNamespaceKey] == null ? string.Empty :
                    (string)data[ServiceModel.XmlNamespaceKey][ServiceModel.XmlNamespaceUriKey];
            }
        }

        /// <summary>
        /// Determines if the member is flattened for the marshaller/unmarshaller
        /// </summary>
        public bool IsFlattened
        {
            get
            {
                var metadata = data[ServiceModel.MetadataKey];
                if (metadata == null) return false;
                var flattened = metadata[FlattenedKey];
                if (flattened == null || !flattened.IsBoolean) return false;
                return (bool)flattened;
            }
        }

        /// <summary>
        /// The location of the marshaller
        /// </summary>
        public MarshallLocation MarshallLocation
        {
            get
            {
                if (data[Locationkey] != null)
                {
                    var location = (string)data[Locationkey];
                    MarshallLocation value;
                    if (!Enum.TryParse<MarshallLocation>(location, true, out value))
                    {
                        throw new Exception("Unknown MarshallLocation " + location);
                    }
                    return value;
                }

                // Default to Body if location is not specified.
                return MarshallLocation.Body;
            }
        }

        /// <summary>
        /// The name of the location for the marshaller
        /// </summary>
        public string MarshallLocationName
        {
            get
            {
                return data[ServiceModel.LocationNameKey] == null ? string.Empty : (string)data[ServiceModel.LocationNameKey];
            }
        }

        public string GetParamDocumentationForOperation(string operationName)
        {
            if (this.Documentation.Equals(string.Empty))
            {
                return "A property of " + operationName + "Request used to execute the " + operationName + " service method.";
            }
            else
            {
                var sb = new StringBuilder(this.Documentation);
                return sb.Replace("<p>", string.Empty)
                         .Replace("</p>", string.Empty)
                         .Replace("\n", string.Empty)
                         .Replace("    ", " ")
                         .ToString();
            }
        }

        public string GetParamDocumentationForConstructor(string className)
        {
            if (this.Documentation.Equals(string.Empty))
            {
                return "Sets the " + className + " " + this.PropertyName + " property";
            }
            else
            {
                var sb = new StringBuilder(this.Documentation);
                return sb.Replace("<p>", string.Empty)
                         .Replace("</p>", string.Empty)
                         .Replace("\n", string.Empty)
                         .Replace("    ", " ")
                         .ToString();
            }
        }

        /// <summary>
        /// Used to get the proper type of the member so that it can be used in the generator for proper code
        /// </summary>
        /// <returns>The proper name of the type for the member</returns>
        public string DetermineType()
        {
            return DetermineType(this.data, false);
        }

        /// <summary>
        /// Determines the type of the member based on customizations, if it isn't custom then it pulls 
        /// from the full json model to get the shape of this member
        /// </summary>
        /// <param name="extendedData">The json data from the parent shape model</param>
        /// <param name="treatEnumsAsString">If true all any found enum type will be returned as a string</param>
        /// <returns></returns>
        private string DetermineType(JsonData extendedData, bool treatEnumsAsString)
        {
            JsonData typeNode = null;
            // Check to see if customizations is overriding - first by simple type remap
            // and then via more extensive customization. If we are handed a collection
            // shape to begin with, this check is whether the collection shape, not the
            // collected type, is remapped.
            /*var remapAsShapeName = this.model.Customizations.GetSubstituteShapeName(this.Shape.Name);
            if (remapAsShapeName != null)
            {
                var remappedShape = this.model.FindShape(remapAsShapeName);
                if (remappedShape == null)
                    throw new Exception(string.Format("Found shape remap from {0} to {1} but no such shape in model!",
                                                      this.Shape.Name, remapAsShapeName));
                if (remappedShape.IsStructure)
                    return remapAsShapeName;

                switch (remappedShape.Type)
                {
                    case "boolean":
                        return "bool";
                    case "integer":
                        return "int";
                    case "timestamp":
                        return "DateTime";
                    default:
                        return remappedShape.Type;
                }
            }*/

            var overrideType = this.model.Customizations.OverrideDataType(OwningShape.Name, this._name);
            if (overrideType != null)
            {
                this._newType = overrideType.DataType;
                return overrideType.DataType;
            }

            var extendsNode = extendedData[ServiceModel.ShapeKey];
            if (extendsNode == null)
                throw new Exception("Missing extends for member " + this._name);

            JsonData memberShape = null;
            // if this shape is a collection, has the collected type been remapped?
            var emitAsShapeName = this.model.Customizations.GetSubstituteShapeName(extendsNode.ToString());
            var renameShape = this.model.Customizations.GetOverrideShapeName(extendsNode.ToString());
            if (emitAsShapeName == null)
            {
                memberShape = this.model.DocumentRoot[ServiceModel.ShapesKey][extendsNode.ToString()];
                typeNode = memberShape[Shape.TypeKey];
            }
            else
            {
                // we only handle remap to one level at present
                memberShape = this.model.DocumentRoot[ServiceModel.ShapesKey][emitAsShapeName];
                typeNode = memberShape[Shape.TypeKey];
            }

            if (typeNode == null)
                throw new Exception("Type is missing for shape " + extendsNode.ToString());

            switch (typeNode.ToString())
            {
                case "string":
                    if (!treatEnumsAsString && memberShape["enum"] != null)
                    {
                        return ServiceModel.CapitalizeFirstChar(extendsNode.ToString());
                    }
                    return "string";
                case "blob":
                    if (this.IsStreaming)
                        return "Stream";
                    return "MemoryStream";
                case "boolean":
                    return "bool";
                case "double":
                    return "double";
                case "float":
                    return "float";
                case "integer":
                    return "int";
                case "long":
                    return "long";
                case "timestamp":
                    return "DateTime";
                case "structure":
                    return emitAsShapeName ?? renameShape ?? extendsNode.ToString();
                case "map":
                    var keyType = DetermineType(memberShape["key"], true);
                    var valueType = DetermineType(memberShape["value"], true);
                    return string.Format("Dictionary<{0}, {1}>", keyType, valueType);
                case "list":
                    var listType = DetermineType(memberShape["member"], true);
                    return string.Format("List<{0}>", listType);

                default:
                    throw new Exception("Unknown type " + typeNode.ToString());
            }
        }

        /// <summary>
        /// Returns the type of the marshaller if it is customized, null otherwise
        /// </summary>
        public string CustomMarshallerTransformation
        {
            get
            {
                // Check to see if customizations is overriding.
                var overrideType = this.model.Customizations.OverrideDataType(OwningShape.Name, this._name);
                if (overrideType != null)
                    return overrideType.Marshaller;

                return null;
            }
        }

        /// <summary>
        /// This method gets the name of an unmarshaller for a type. It is used from within DetermineTypeUnmarshallerInstantiate 
        /// to get the types for the generic declarations of maps and lists.
        /// </summary>
        /// <param name="extendedData">The data for the member defined in the shape</param>
        /// <returns></returns>
        string GetTypeUnmarshallerName(JsonData extendedData)
        {
            // Check to see if customizations is overriding.
            var overrideType = this.model.Customizations.OverrideDataType(OwningShape.Name, this._name);
            if (overrideType != null)
                return overrideType.Unmarshaller;

            var extendsNode = extendedData[ServiceModel.ShapeKey];
            if (extendsNode == null)
                throw new Exception("Missing extends for member " + this._name);

            var memberShape = this.model.DocumentRoot[ServiceModel.ShapesKey][extendsNode.ToString()];
            var typeNode = memberShape[Shape.TypeKey];
            if (typeNode == null)
                throw new Exception("Type is missing for shape " + extendsNode.ToString());

            switch (typeNode.ToString())
            {
                case "string":
                    return "StringUnmarshaller";
                case "blob":
                    return "MemoryStreamUnmarshaller";
                case "boolean":
                    return "BoolUnmarshaller";
                case "double":
                    return "DoubleUnmarshaller";
                case "float":
                    return "FloatUnmarshaller";
                case "integer":
                    return "IntUnmarshaller";
                case "long":
                    return "LongUnmarshaller";
                case "timestamp":
                    return "DateTimeUnmarshaller";
                case "structure":
                    var shapeName = extendsNode.ToString();
                    var renamedShape = this.model.Customizations.GetOverrideShapeName(shapeName);
                    var substitutedShape = this.model.Customizations.GetSubstituteShapeName(shapeName);
                    if (!string.IsNullOrWhiteSpace(renamedShape))
                    {
                        shapeName = renamedShape;
                    }
                    else if(!string.IsNullOrWhiteSpace(substitutedShape))
                    {
                        shapeName = substitutedShape;
                    }
                    return shapeName + "Unmarshaller";
                case "map":
                    var keyType = DetermineType(memberShape[Shape.KeyKey], true);
                    var keyTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.KeyKey]);
                    var valueType = DetermineType(memberShape[Shape.ValueKey], true);
                    var valueTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.ValueKey]);

                    return string.Format("DictionaryUnmarshaller<{0}, {1}, {2}, {3}>",
                        keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller);
                case "list":
                    var listType = DetermineType(memberShape[Member.MemberKey], true);
                    var listTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Member.MemberKey]);

                    return string.Format("ListUnmarshaller<{0}, {1}>",
                        listType, listTypeUnmarshaller);

                default:
                    throw new Exception("Unknown type " + typeNode.ToString());
            }
        }

        /// <summary>
        /// Determines the type of the unmarshaller for the member
        /// </summary>
        /// <returns>A string that can be used as a proper name for the unmarshaller</returns>
        public string DetermineTypeUnmarshallerInstantiate()
        {
            return this.DetermineTypeUnmarshallerInstantiate(this.data);
        }

        /// <summary>
        /// This returns the code that instantiates an unmarshaller. It will be called recursively for maps and 
        /// lists to handle the generic declarations.
        /// </summary>
        /// <param name="extendedData"></param>
        /// <returns></returns>
        public string DetermineTypeUnmarshallerInstantiate(JsonData extendedData)
        {
            // Check to see if customizations is overriding.
            var overrideType = this.model.Customizations.OverrideDataType(OwningShape.Name, this._name);
            if (overrideType != null && !string.IsNullOrEmpty(overrideType.Unmarshaller))
                return overrideType.Unmarshaller + ".Instance";

            var extendsNode = extendedData[ServiceModel.ShapeKey];
            if (extendsNode == null)
                throw new Exception("Missing extends for member " + this._name);

            JsonData memberShape = null;
            var substituteType = this.model.Customizations.GetSubstituteShapeName(extendsNode.ToString());
            var renameShape = this.model.Customizations.GetOverrideShapeName(extendsNode.ToString());
            memberShape = substituteType != null
                ? this.model.DocumentRoot[ServiceModel.ShapesKey][substituteType]
                : this.model.DocumentRoot[ServiceModel.ShapesKey][extendsNode.ToString()];

            var typeNode = memberShape[Shape.TypeKey];
            if (typeNode == null)
                throw new Exception("Type is missing for shape " + extendsNode);

            switch (typeNode.ToString())
            {
                case "string":
                    return "StringUnmarshaller.Instance";
                case "blob":
                    return "MemoryStreamUnmarshaller.Instance";
                case "boolean":
                    return "BoolUnmarshaller.Instance";
                case "double":
                    return "DoubleUnmarshaller.Instance";
                case "float":
                    return "FloatUnmarshaller.Instance";
                case "integer":
                    return "IntUnmarshaller.Instance";
                case "long":
                    return "LongUnmarshaller.Instance";
                case "timestamp":
                    return "DateTimeUnmarshaller.Instance";
                case "structure":
                    return (renameShape ?? extendsNode) + "Unmarshaller.Instance";
                case "map":
                    var keyType = DetermineType(memberShape[Shape.KeyKey], true);
                    var keyTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.KeyKey]);
                    var keyTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.KeyKey]);

                    var valueType = DetermineType(memberShape[Shape.ValueKey], true);
                    var valueTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.ValueKey]);
                    var valueTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.ValueKey]);

                    if (this.model.Type == ServiceType.Json || this.model.Type == ServiceType.Rest_Json)
                        return string.Format("new DictionaryUnmarshaller<{0}, {1}, {2}, {3}>(StringUnmarshaller.Instance, {5})",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate);
                    else
                        return string.Format("new KeyValueUnmarshaller<{0}, {1}, {2}, {3}>(StringUnmarshaller.Instance, {5})",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate);
                case "list":
                    var listType = DetermineType(memberShape[Shape.MemberKey], true);
                    var listTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.MemberKey]);
                    var listTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.MemberKey]);

                    if (this.model.Type == ServiceType.Json || this.model.Type == ServiceType.Rest_Json)
                        return string.Format("new ListUnmarshaller<{0}, {1}>({2})",
                            listType, listTypeUnmarshaller, listTypeUnmarshallerInstantiate);
                    else
                        return listTypeUnmarshallerInstantiate;

                default:
                    throw new Exception("Unknown type " + typeNode.ToString());
            }
        }

        public string GetSerializationInfoMethodName()
        {
            var simpleTypeName = DetermineType();

            switch (simpleTypeName)
            {
                case "string":
                case "boolean":
                case "double":
                    return "Get" + ServiceModel.CapitalizeFirstChar(simpleTypeName);
                case "float":
                    return "GetSingle";
                case "integer":
                    return "GetInt32";
                case "long":
                    return "GetInt64";

                default:
                    throw new Exception("Unknown serialization type " + simpleTypeName);
            }
        }

        public string GetPrimitiveType()
        {
            return this.Shape.GetPrimitiveType();
        }

        /// <summary>
        /// Determines if they type of the member is a primitive that needs to be nullable. 
        /// If the shape is customized it uses the newtype to determine if it is nullable.
        /// </summary>
        public bool IsNullable
        {
            get
            {
                var emittingShapeType = this._newType; // set if we have a full override declaration
                if (emittingShapeType == null)
                {
                    // maybe a simple substitution?
                    var substituteData = this.model.Customizations.GetSubstituteShapeData(this.ModelShape.Name);
                    if (substituteData != null && substituteData[CustomizationsModel.EmitAsShapeKey] != null)
                    {
                        var shape = this.model.FindShape((string) substituteData[CustomizationsModel.EmitAsShapeKey]);
                        emittingShapeType = shape.Type;
                    }
                }

                return emittingShapeType != null
                    ? _nullableTypes.Contains(emittingShapeType, StringComparer.Ordinal) 
                    : this.Shape.IsNullable;
            }
        }

        /// <summary>
        /// Determines if the member is a map from the shape in the json model
        /// </summary>
        public bool IsMap
        {
            get
            {
                return this.Shape.IsMap;
            }
        }

        /// <summary>
        /// Determines if the member is a list from the shape in the json model
        /// </summary>
        public bool IsList
        {
            get
            {
                return this.Shape.IsList;
            }
        }

        /// <summary>
        /// Determines if the member is a structure from the shape in the json model
        /// </summary>
        public bool IsStructure
        {
            get
            {

                return this.Shape.IsStructure;
            }
        }

        /// <summary>
        /// Determines if the member is a memorystream from the shape in the json model
        /// </summary>
        public bool IsMemoryStream
        {
            get
            {
                return this.Shape.IsMemoryStream;
            }
        }

        /// <summary>
        /// Determines if the member is a stream from the shape in the json model
        /// </summary>
        public bool IsStreaming
        {
            get
            {
                return this.Shape.IsStreaming;
            }
        }

        public bool IsExcluded
        {
            get { return this.model.Customizations.IsExcludedProperty(this.PropertyName, this.OwningShape.Name); }
        }


        /// <summary>
        /// Determines if the member is a type that needs to be instantiated, such as a list or map
        /// </summary>
        public bool ShouldInstantiate
        {
            get { return this.IsMap || this.IsList; }
        }

        /// <summary>
        /// Gets the name of the shape that the member extends so that info about the member can be retrieved
        /// </summary>
        string Extends
        {
            get
            {
                var extendsNode = this.data[ServiceModel.ShapeKey];
                if (extendsNode == null)
                    throw new Exception("Missing extends for member " + this._name);
                return extendsNode.ToString();
            }
        }

        // Returns the original model shape
        public Shape ModelShape
        {
            get
            {
                var memberShape = this.model.DocumentRoot[ServiceModel.ShapesKey][this.Extends];
                return new Shape(this.model, this.Extends, memberShape);
            }
        }

        // Returns the Shape, potentially overriden by substitution, that we want to 
        // deal with
        public Shape Shape
        {
            get
            {
                JsonData memberShape = null;
                var substituteType = this.model.Customizations.GetSubstituteShapeName(this.Extends);
                memberShape = substituteType != null
                    ? this.model.DocumentRoot[ServiceModel.ShapesKey][substituteType]
                    : this.model.DocumentRoot[ServiceModel.ShapesKey][this.Extends];

                if (memberShape == null)
                    throw new Exception("Type is missing for shape " + this.Extends);

                return new Shape(this.model, this.Extends, memberShape);
            }
        }

        /// <summary>
        /// Returns the name of this member as it appears in the model
        /// </summary>
        public string ModeledName
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// Creates a representation of the member as a string using the member name
        /// </summary>
        /// <returns>The member name as a string</returns>
        public override string ToString()
        {
            return this._name;
        }
    }
}
