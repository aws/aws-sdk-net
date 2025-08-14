using Json.LitJson;
using System;
using System.Linq;
using System.Text;
using System.Globalization;
using ServiceClientGenerator.Endpoints;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Members are properties are parts of a shape, they are used to identify sub shapes that the parent shape owns
    /// </summary>
    public class Member : BaseModel
    {
        public const string EventInputStreamSuffix = "Publisher";

        public const string Locationkey = "location";
        public const string MemberKey = "member";
        public const string FlattenedKey = "flattened";
        public const string JsonValueKey = "jsonvalue";
        public const string DeprecatedKey = "deprecated";
        public const string RequiredKey = "required";
        public const string DeprecatedMessageKey = "deprecatedMessage";
        public const string HostLabelKey = "hostLabel";
        public const string EventPayloadKey = "eventpayload";
        public const string EventHeaderKey = "eventheader";
        public const string XmlAttributeKey = "xmlAttribute";
        private const string UnhandledTypeDecimalErrorMessage = "Unhandled type 'decimal' : using .net's decimal type for modeled decimal type may result in loss of data.  decimal type members should explicitly opt-in via shape customization.";

        private readonly string _name;
        private string _newType;
        readonly string _defaultMarshallName;


        public Member(ServiceModel model, Shape owningShape, string name, string defaultMarshallName, CustomizationsModel.PropertyInjector propertyInjector)
            : base(model, propertyInjector.Data)
        {
            this.OwningShape = owningShape;
            _name = name;
            _defaultMarshallName = defaultMarshallName;
            this.PropertyModifier = null;
            this.PropertyInjector = propertyInjector;
        }
        
        public Member(ServiceModel model, Shape owningShape, JsonData originalMember, string name, string defaultMarshallName, CustomizationsModel.PropertyInjector propertyInjector)
                        : base(model, propertyInjector.Data)
        {
            this.OwningShape = owningShape;
            this.OriginalMember = originalMember;
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

        /// <summary>
        /// If a member is excluded and injected with another member. The OriginalMember represents the JsonData of the original excluded member.
        /// </summary>
        public JsonData OriginalMember { get; protected set; }

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
        /// The name of the member with the first character lower and begins with an underscore: _nameHere.
        /// It includes the backward compatibility suffix if required.
        /// </summary>
        public string VariableName
        {
            get
            {
                var name = BaseVariableName;
                if (IsEventInputStream)
                {
                    name += EventInputStreamSuffix;
                }
                return name;
            }
        }

        /// <summary>
        /// When a member is a event the unaltered member name is used as the event type sent over the wire.
        /// </summary>
        public string EventTypeName
        {
            get { return _name; }
        }

        /// <summary>
        /// The name of the member with the first character lower and begins with an underscore: _nameHere.
        /// This doesn't include the backward compatibility suffix.
        /// </summary>
        private string BaseVariableName
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
        /// Uses the custom name instead if it exists.
        /// </summary>
        public string PropertyName
        {
            get
            {
                var name = BasePropertyName;
                if (IsEventInputStream)
                {
                    name += EventInputStreamSuffix;
                }
                return name;
            }
        }

        /// <summary>
        /// The name of the member as the first character upper: NameHere
        /// Uses the custom name instead if it exists.
        /// This doesn't include the backwards compatibility suffix.
        /// </summary>
        public string BasePropertyName
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

                return _name.ToUpperFirstCharacter();
            }
        }

        /// <summary>
        /// The name of the marshaller
        /// </summary>
        public string MarshallName
        {
            get
            {
                // For Json11 and Json10 protocols the name of the member is always the MarshallName because these protocols don't support
                // the JsonName trait. See https://smithy.io/2.0/aws/protocols/aws-json-1_0-protocol.html#supported-traits.
                if (string.Equals(this.model.Protocol, "json", StringComparison.Ordinal))
                {
                    // if a shape modifier exists, do not change the marshall name
                    if (this.model.Customizations.GetShapeModifier(this.OwningShape.Name) != null)
                        return LocationName ?? _defaultMarshallName;
                    return this.ModeledName;
                }
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

        private string _locationName;
        /// <summary>
        /// The name of the location
        /// </summary>
        public string LocationName
        {
            get
            {
                if (_locationName != null)
                {
                    return _locationName;
                }
                else
                {
                    // first check if there is a customization overriding
                    if (this.model.Customizations.OverrideDataType(this.OwningShape.Name, this.ModeledName) != null && this.model.Customizations.OverrideDataType(this.OwningShape.Name, this.ModeledName).AlternateLocationName != null)
                            return this.model.Customizations.OverrideDataType(this.OwningShape.Name, this.ModeledName).AlternateLocationName;
                    if (ModelShape != null && !string.IsNullOrEmpty(ModelShape.LocationName) && ModelShape.IsFlattened)
                    {
                        _locationName = ModelShape.LocationName;
                        return _locationName;
                    }
                    else
                    {
                        // if list, lookup member/metadata/xmlName
                        // otherwise, lookup metadata/xmlName
                        var source = this.OriginalMember != null ? this.OriginalMember : data;
                        if (IsList)
                        {
                            var member = data[MemberKey];
                            if (member != null)
                                source = member;
                        }

                        var locationName = source[ServiceModel.LocationNameKey];
                        if (locationName == null)
                        {
                            _locationName = null;
                            return null;
                        }
                        _locationName = locationName.ToString();
                        return _locationName;
                    }

                }

            }
        }

        public bool IsEndpointDiscoveryId
        {
            get
            {
                return (bool)(this.data[ServiceModel.EndpointDiscoveryIdKey] ?? false);
            }
        }

        /// <summary>
        /// Determines if this member is a base64 encoded json in the header of the request/response
        /// Note: In the future this may also include members that are not in a header.  For now the generator assumes
        /// that if IsJsonValue is true then IsInHeader is also true.
        /// </summary>
        public bool IsJsonValue
        {
            get
            {
                var jsonValueData = data[JsonValueKey];
                return jsonValueData == null ? false : (bool)jsonValueData;
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
                var flattenedMember = data[FlattenedKey];
                var dataTypeOverride = this.model.Customizations.OverrideDataType(this.OwningShape.Name, this.ModeledName);

                if (dataTypeOverride != null && dataTypeOverride.IsFlattened)
                    return true;

                if (metadata == null && flattenedMember == null)
                {
                    return false;
                }
                var flattened = metadata?[FlattenedKey] ?? flattenedMember;
                if (flattened == null || !flattened.IsBoolean)
                {
                    return false;
                }
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
        /// The hostLabel of the shape
        /// </summary>
        public bool IsHostLabel
        {
            get
            {
                if (data[HostLabelKey] != null)
                {
                    return (bool)data[HostLabelKey];
                }

                // Default to false (not a hostLabel) if hostLabel is not specified.
                return false;
            }
        }

        /// <summary>
        /// If present, use instead of MarshallLocationName
        /// </summary>
        public string MarshallQueryName
        {
            get
            {
                return data[ServiceModel.QueryNameKey] == null ? string.Empty : (string)data[ServiceModel.QueryNameKey];
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
                         .Replace("<code>", "<c>")
                         .Replace("</code>", "</c>")
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
                         .Replace("<code>", "<c>")
                         .Replace("</code>", "</c>")
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
        private string DetermineType(JsonData extendedData, bool treatEnumsAsString, bool useNullable = true)
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

            var documentTrait = memberShape[Shape.DocumentKey];
            if (documentTrait?.IsBoolean == true && (bool)documentTrait)
                return "Amazon.Runtime.Documents.Document";

            if (typeNode == null)
                throw new Exception("Type is missing for shape " + extendsNode.ToString());

            var nullable = useNullable || UseNullable ? "?" : "";

            switch (typeNode.ToString())
            {
                case "string":
                    if (!treatEnumsAsString && memberShape["enum"] != null)
                    {
                        return (renameShape ?? extendsNode.ToString()).ToUpperFirstCharacter();
                    }
                    return "string";
                case "blob":
                    if (this.Shape.IsStreaming)
                        return "Stream";
                    return "MemoryStream";
                case "boolean":
                    return $"bool{nullable}";
                case "double":
                    return $"double{nullable}";
                case "float":
                    return $"float{nullable}";
                case "integer":
                    return $"int{nullable}";
                case "long":
                    return $"long{nullable}";
                case "timestamp":
                    return $"DateTime{nullable}";
                case "structure":
                    var typeName = emitAsShapeName ?? renameShape ?? extendsNode.ToString();
                    if (IsEventInputStream)
                    {
                        typeName += EventInputStreamSuffix;
                    }
                    return typeName;
                case "map":
                    bool overrideMapTreatEnumsAsString = this.model.Customizations.OverrideTreatEnumsAsString(this.Extends) ?? true;
                    var keyType = DetermineType(memberShape["key"], overrideMapTreatEnumsAsString, false);
                    var valueType = DetermineType(memberShape["value"], overrideMapTreatEnumsAsString, false);
                    return string.Format("Dictionary<{0}, {1}>", keyType, valueType);
                case "list":
                    bool overrideListTreatEnumsAsString = this.model.Customizations.OverrideTreatEnumsAsString(this.Extends) ?? true;
                    var listType = DetermineType(memberShape["member"], overrideListTreatEnumsAsString, false);
                    return string.Format("List<{0}>", listType);

                case "decimal":
                    throw new Exception(UnhandledTypeDecimalErrorMessage);

                default:
                    throw new Exception("Unknown type " + typeNode.ToString());
            }
        }

        /// <summary>
        /// True if the shape the member is pointing to is an event stream on a request object.
        /// </summary>
        public bool IsEventInputStream
        {
            get
            {
                if (this.ModelShape.IsEventStream && this.model.Operations.FirstOrDefault(x => string.Equals(this.OwningShape.Name, x.RequestStructure?.Name)) != null)
                {
                    return true;
                }

                return false;
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
        string GetTypeUnmarshallerName(JsonData extendedData, bool useNullable = true)
        {
            // Check to see if customizations is overriding.
            var overrideType = this.model.Customizations.OverrideDataType(OwningShape.Name, this._name);
            if (overrideType != null)
                return overrideType.Unmarshaller;

            var extendsNode = extendedData[ServiceModel.ShapeKey];
            if (extendsNode == null)
                throw new Exception("Missing extends for member " + this._name);

            var memberShape = this.model.DocumentRoot[ServiceModel.ShapesKey][extendsNode.ToString()];

            var document = memberShape[Shape.DocumentKey];
            if (document?.IsBoolean == true && (bool)document)
                return "Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller";

            var typeNode = memberShape[Shape.TypeKey];
            if (typeNode == null)
                throw new Exception("Type is missing for shape " + extendsNode.ToString());

            var nullable = useNullable || UseNullable ? "Nullable" : "";

            var primitiveUnmarshallerPrefix = "";
            if (this.model.Type == ServiceType.Cbor)
                primitiveUnmarshallerPrefix = "Cbor";

            switch (typeNode.ToString())
            {
                case "string":
                    return $"{primitiveUnmarshallerPrefix}StringUnmarshaller";
                case "blob":
                    return $"{primitiveUnmarshallerPrefix}MemoryStreamUnmarshaller";
                case "boolean":
                    return $"{primitiveUnmarshallerPrefix}{nullable}BoolUnmarshaller";
                case "double":
                    return $"{primitiveUnmarshallerPrefix}{nullable}DoubleUnmarshaller";
                case "float":
                    return $"{primitiveUnmarshallerPrefix}{nullable}FloatUnmarshaller";
                case "integer":
                    return $"{primitiveUnmarshallerPrefix}{nullable}IntUnmarshaller";
                case "long":
                    return $"{primitiveUnmarshallerPrefix}{nullable}LongUnmarshaller";
                case "timestamp":
                    return $"{primitiveUnmarshallerPrefix}{nullable}DateTimeUnmarshaller";
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
                    var keyType = DetermineType(memberShape[Shape.KeyKey], true, useNullable);
                    var keyTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.KeyKey], useNullable);
                    var valueType = DetermineType(memberShape[Shape.ValueKey], true, useNullable);
                    var valueTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.ValueKey], useNullable);
                    if (this.model.Type == ServiceType.Json || this.model.Type == ServiceType.Rest_Json)
                        return string.Format("JsonDictionaryUnmarshaller<{0}, {1}, {2}, {3}>",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller);
                    else if (this.model.Type == ServiceType.Query || this.model.Type == ServiceType.Rest_Xml)
                        return string.Format("XmlDictionaryUnmarshaller<{0}, {1}, {2}, {3}>",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller);
                    else if (this.model.Type == ServiceType.Cbor)
                        return string.Format("CborDictionaryUnmarshaller<{0}, {1}, {2}, {3}>",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller);
                    else
                        throw new Exception("Unknown protocol type");
                case "list":
                    var listType = DetermineType(memberShape[Member.MemberKey], true, useNullable);
                    var listTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Member.MemberKey], useNullable);
                    if (this.model.Type == ServiceType.Json || this.model.Type == ServiceType.Rest_Json)
                        return string.Format("JsonListUnmarshaller<{0},{1}>",listType, listTypeUnmarshaller);
                    else if (this.model.Type == ServiceType.Rest_Xml || this.model.Type == ServiceType.Query)
                        return string.Format("XmlListUnmarshaller<{0}, {1}>",
                        listType, listTypeUnmarshaller);
                    else if (this.model.Type == ServiceType.Cbor)
                        return string.Format("CborListUnmarshaller<{0}, {1}>",
                        listType, listTypeUnmarshaller);
                    else
                    {
                        throw new Exception("Unknown protocol type");
                    }
                case "decimal":
                    throw new Exception(UnhandledTypeDecimalErrorMessage);

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
            return this.DetermineTypeUnmarshallerInstantiate(this.data, string.Empty);
        }

        /// <summary>
        /// This returns the code that instantiates an unmarshaller. It will be called recursively for maps and 
        /// lists to handle the generic declarations.
        /// </summary>
        /// <param name="extendedData"></param>
        /// <returns></returns>
        public string DetermineTypeUnmarshallerInstantiate(JsonData extendedData, string parentTypeNode, bool useNullable = true)
        {
            var extendsNode = extendedData[ServiceModel.ShapeKey];
            if (extendsNode == null)
                throw new Exception("Missing extends for member " + this._name);

            JsonData memberShape = null;
            var substituteType = this.model.Customizations.GetSubstituteShapeName(extendsNode.ToString());
            var renameShape = this.model.Customizations.GetOverrideShapeName(extendsNode.ToString());
            memberShape = substituteType != null
                ? this.model.DocumentRoot[ServiceModel.ShapesKey][substituteType]
                : this.model.DocumentRoot[ServiceModel.ShapesKey][extendsNode.ToString()];

            var document = memberShape[Shape.DocumentKey];
            if (document?.IsBoolean == true && (bool) document)
                return "Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance";

            var typeNode = memberShape[Shape.TypeKey];
            if (typeNode == null)
                throw new Exception("Type is missing for shape " + extendsNode);

            var nullable = useNullable || UseNullable ? "Nullable" : "";

            var primitiveUnmarshallerPrefix = "";
            if (typeNode.ToString() != "structure" && typeNode.ToString() != "map" && typeNode.ToString() != "list")
            {
                if (this.model.Type == ServiceType.Cbor)
                    primitiveUnmarshallerPrefix = "Cbor";
            }

            // Check to see if customizations is overriding.
            var overrideType = this.model.Customizations.OverrideDataType(OwningShape.Name, this._name);
            if (overrideType != null && !string.IsNullOrEmpty(overrideType.Unmarshaller))
            {
                return $"{primitiveUnmarshallerPrefix}{overrideType.Unmarshaller}.Instance";
            }

            switch (typeNode.ToString())
            {
                case "string":
                    return $"{primitiveUnmarshallerPrefix}StringUnmarshaller.Instance";
                case "blob":
                    return $"{primitiveUnmarshallerPrefix}MemoryStreamUnmarshaller.Instance";
                case "boolean":
                    return $"{primitiveUnmarshallerPrefix}{nullable}BoolUnmarshaller.Instance";
                case "double":
                    return $"{primitiveUnmarshallerPrefix}{nullable}DoubleUnmarshaller.Instance";
                case "float":
                    return $"{primitiveUnmarshallerPrefix}{nullable}FloatUnmarshaller.Instance";
                case "integer":
                    return $"{primitiveUnmarshallerPrefix}{nullable}IntUnmarshaller.Instance";
                case "long":
                    return $"{primitiveUnmarshallerPrefix}{nullable}LongUnmarshaller.Instance";
                case "timestamp":
                    return $"{primitiveUnmarshallerPrefix}{nullable}DateTimeUnmarshaller.Instance";
                case "structure":
                    return (renameShape ?? extendsNode) + "Unmarshaller.Instance";
                case "map":
                    var keyType = DetermineType(memberShape[Shape.KeyKey], true);
                    var keyTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.KeyKey]);
                    var keyLocationName = memberShape[Shape.KeyKey][ServiceModel.LocationNameKey] == null ? "key" : memberShape[Shape.KeyKey][ServiceModel.LocationNameKey].ToString();
                    var keyTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.KeyKey], typeNode.ToString());

                    var valueType = DetermineType(memberShape[Shape.ValueKey], true, false);
                    var valueTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.ValueKey], false);
                    var valueLocationName = memberShape[Shape.ValueKey][ServiceModel.LocationNameKey] == null ? "value" : memberShape[Shape.ValueKey][ServiceModel.LocationNameKey].ToString();
                    var valueTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.ValueKey], typeNode.ToString(), false);

                    //Direct sub maps can not be flattened. If the parent was a map then force the sub map to not be flat.
                    var isFlat = IsFlattened;
                    if (parentTypeNode == "map")
                    {
                        isFlat = false;
                    }

                    if (this.model.Type == ServiceType.Json || this.model.Type == ServiceType.Rest_Json)
                        return string.Format("new JsonDictionaryUnmarshaller<{0}, {1}, {2}, {3}>(StringUnmarshaller.Instance, {5})",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate);
                    else if (this.model.Type == ServiceType.Cbor)
                        return string.Format("new CborDictionaryUnmarshaller<{0}, {1}, {2}, {3}>(CborStringUnmarshaller.Instance, {5})",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate);
                    else if (this.model.Type == ServiceType.Rest_Xml && !isFlat)
                        return string.Format("new XmlDictionaryUnmarshaller<{0}, {1}, {2}, {3}>(StringUnmarshaller.Instance, {5}, \"{6}\", \"{7}\")",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate, keyLocationName, valueLocationName);
                    else
                        return string.Format("new XmlKeyValueUnmarshaller<{0}, {1}, {2}, {3}>(StringUnmarshaller.Instance, {5}, \"{6}\", \"{7}\")",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate, keyLocationName, valueLocationName);
                case "list":
                    var listType = DetermineType(memberShape[Shape.MemberKey], true, false);
                    var listTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.MemberKey], false);
                    var listTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.MemberKey], typeNode.ToString(), false);

                    if (this.model.Type == ServiceType.Json || this.model.Type == ServiceType.Rest_Json)
                        return string.Format("new JsonListUnmarshaller<{0}, {1}>({2})",
                            listType, listTypeUnmarshaller, listTypeUnmarshallerInstantiate);
                    else if (this.model.Type == ServiceType.Cbor)
                        return string.Format("new CborListUnmarshaller<{0}, {1}>({2})",
                            listType, listTypeUnmarshaller, listTypeUnmarshallerInstantiate);
                    else if ((this.model.Type == ServiceType.Query || this.model.Type == ServiceType.Rest_Xml) && $"{listTypeUnmarshaller}.Instance" != listTypeUnmarshallerInstantiate)
                        return $"new {listTypeUnmarshaller}({listTypeUnmarshallerInstantiate})";
                    else
                        return listTypeUnmarshallerInstantiate;

                case "decimal":
                    throw new Exception(UnhandledTypeDecimalErrorMessage);

                default:
                    throw new Exception("Unknown type " + typeNode.ToString());
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
                        var shape = this.model.FindShape((string)substituteData[CustomizationsModel.EmitAsShapeKey]);
                        emittingShapeType = shape.Type;
                    }
                }
                return emittingShapeType != null
                ? Shape.NullableTypes.Contains(emittingShapeType, StringComparer.Ordinal)
                : this.Shape.IsNullable;
            }
        }

        /// <summary>
        /// Determines if the operation is Idempotent.
        /// </summary>
        public bool IsIdempotent
        {
            get
            {
                var source = data[ServiceModel.IdempotencyTokenKey];
                if (source != null && source.IsBoolean)
                    return (bool)source;
                return false;
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
        /// Determines if the member has requiresLength from the shape in the json model
        /// </summary>
        public bool RequiresLength
        {
            get
            {
                return this.Shape.RequiresLength;
            }
        }

        /// <summary>
        /// Determines if the member is a document from the shape in the json model
        /// </summary>
        public bool IsDocument
        {
            get
            {
                return this.Shape.IsDocument;
            }
        }
        public bool IsException
        {
            get
            {
                return this.Shape.IsException;
            }
        }

        /// <summary>
        /// Determines if the member is deprecated
        /// </summary>
        public bool IsDeprecated
        {
            get
            {
                if (data[DeprecatedKey] != null && data[DeprecatedKey].IsBoolean)
                    return (bool)data[DeprecatedKey];

                return false;
            }
        }

        /// <summary>
        /// Determines if the member is required
        /// </summary>
        public bool IsRequired
        {
            get
            {
                return OwningShape.IsFieldRequired(ModeledName);
            }
        }

        public bool IsXmlAttribute
        {
            get
            {
                if (data[XmlAttributeKey] != null && data[XmlAttributeKey].IsBoolean)
                    return (bool)data[XmlAttributeKey];
                return false;
            }
        }

        /// <summary>
        /// Returns the deprecation message specified in the model or in the customization file.
        /// </summary>
        public string DeprecationMessage
        {
            get
            {
                string message = this.model.Customizations.GetPropertyModifier(this.OwningShape.Name, this._name)?.DeprecationMessage ??
                                 this.data[DeprecatedMessageKey].CastToString();
                if (message == null)
                {
                    var shapeModifier = this.model.Customizations.GetShapeModifier(this.OwningShape.Name);
                    if (shapeModifier != null && shapeModifier.PropertyModifier(this._name) != null)
                    {
                        var propertyModifier = shapeModifier.PropertyModifier(this._name);
                        message = propertyModifier.DeprecationMessage;
                    }
                }
                // TODO: Fill in s3 deprecation messages
                if (message == null)
                    throw new Exception(string.Format("The 'message' property of the 'deprecated' trait is missing for member {0}.{1}.\nFor example: \"MemberName\":{{ ... \"deprecated\":true, \"deprecatedMessage\":\"This property is deprecated, use XXX instead.\"}}", this.OwningShape.Name, this._name));

                return message ?? "";
            }
        }

        public bool IsExcluded
        {
            get { return this.model.Customizations.IsExcludedProperty(this.BasePropertyName, this.OwningShape.Name); }
        }
        /// <summary>
        /// Determines if the member is an event payload type
        /// </summary>
        public bool IsEventPayload
        {
            get
            {
                if (data[EventPayloadKey] != null && data[EventPayloadKey].IsBoolean)
                    return (bool)data[EventPayloadKey];
                return false;
            }
        }
        /// <summary>
        /// Determines if a member is an event header type
        /// </summary>
        public bool IsEventHeader
        {
            get
            {
                if (data[EventHeaderKey] != null && data[EventHeaderKey].IsBoolean)
                    return (bool)data[EventHeaderKey];
                return false;
            }
        }

        /// <summary>
        /// Determines if the member is a type that needs to be instantiated, such as a list or map
        /// </summary>
        public bool IsCollection
        {
            get 
            {
                if (this.model.Customizations.OverrideDataType(OwningShape.Name, this._name) != null && (this.model.Customizations.OverrideDataType(OwningShape.Name, this._name).DataType.Contains("List<") || this.model.Customizations.OverrideDataType(OwningShape.Name, this._name).DataType.Contains("Dictionary<")))
                {
                    return true;
                }
                return this.IsMap || this.IsList; 
            }
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
                return Shape.CreateShape(this.model, this.Extends, memberShape);
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

                return Shape.CreateShape(this.model, this.Extends, memberShape);
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
        /// TimestampFormat that may be specified on a member or a shape.
        /// </summary>
        public TimestampFormat TimestampFormat
        {
            get
            {
                if (!this.IsTimeStamp)
                {
                    throw new InvalidOperationException(string.Format(
                        CultureInfo.InvariantCulture,
                        "Property TimestampFormat is not valid for member {0} of type {1}.",
                        this.ModeledName, this.DetermineType()));
                }

                var resolvedTimestampFormat = data.GetTimestampFormat();
                if (resolvedTimestampFormat == TimestampFormat.None)
                {
                    // Fallback to shape's TimestampFormat if not specified at member level
                    // Fallback to marshall location/protocol rules if not specified at shape level
                    resolvedTimestampFormat = this.Shape.GetTimestampFormat(this.MarshallLocation);
                }
                return resolvedTimestampFormat;
            }
        }

        /// <summary>
        /// Returns if the member's type is timestamp.
        /// </summary>
        public bool IsTimeStamp
        {
            get
            {
                return this.DetermineType().Equals("DateTime?", StringComparison.InvariantCulture);
            }
        }

        /// <summary>
        /// Returns the marshaller method to use in the generated marshaller code for a
        /// member of primitive type.
        /// </summary>
        public string PrimitiveMarshaller
        {
            get
            {
                if (this.IsTimeStamp)
                {
                    string formatAppend = string.Empty;
                    if (this.TimestampFormat == TimestampFormat.ISO8601)
                    {
                        formatAppend = "WithOptionalMs";
                    }
                    return $"StringUtils.FromDateTimeTo{this.TimestampFormat}{formatAppend}";
                }
                else
                {
                    return $"StringUtils.From{this.GetPrimitiveType()}";
                }

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

        internal static TimestampFormat GetDefaultTimestampFormat(MarshallLocation marshallLocation, ServiceType serviceType)
        {
            // Rules used to default the format if timestampFormat is not specified.
            // 1. All timestamp values serialized in HTTP headers are formatted using rfc822 by default.
            // 2. All timestamp values serialized in uri and query strings are formatted using iso8601 by default.
            if (marshallLocation == MarshallLocation.Header || marshallLocation == MarshallLocation.Headers)
            {
                return TimestampFormat.RFC822;
            }
            else if (marshallLocation == MarshallLocation.QueryString || marshallLocation == MarshallLocation.Uri)
            {
                return TimestampFormat.ISO8601;
            }
            else
            {
                // Return protocol defaults if marshall location is not header, querystring, or Uri.
                // The default timestamp formats per protocol for structured payload shapes are as follows. 
                //     rest-json: unixTimestamp
                //     jsonrpc: unixTimestamp
                //     rest-xml: iso8601
                //     query: iso8601
                //     ec2: iso8601
                switch (serviceType)
                {
                    case ServiceType.Rest_Json:
                        return TimestampFormat.UnixTimestamp;
                    case ServiceType.Json:
                        return TimestampFormat.UnixTimestamp;
                    case ServiceType.Query:
                        return TimestampFormat.ISO8601;
                    case ServiceType.Rest_Xml:
                        return TimestampFormat.ISO8601;
                    case ServiceType.Cbor:
                        return TimestampFormat.UnixTimestamp;

                    default:
                        throw new InvalidOperationException(
                            "Encountered unknown model type (protocol): " + serviceType);
                }
            }
        }

        /// <summary>
        /// Gets request member context parameter, used to drive endpoint resolution
        /// </summary>
        public ContextParameter ContextParameter
        {
            get
            {
                JsonData parameter;
                parameter = this.OriginalMember == null ? data.SafeGet("contextParam") : this.OriginalMember.SafeGet("contextParam");
                return parameter == null ? null : new ContextParameter { name = parameter.SafeGetString("name") };
            }
        }

        public bool HasPredicateListUnmarshaller
        {
            get
            {
                if (this.model.Customizations.GetShapeModifier(this.OwningShape.Name) != null)
                {
                    var modifier = this.model.Customizations.GetShapeModifier(this.OwningShape.Name);
                    if (modifier.PredicateListUnmarshallers.Keys.Count > 0 && modifier.PredicateListUnmarshallers.TryGetValue(this.ModeledName, out _))
                    {
                        return true;
                    }
                }
                return false;
            }

        }
    }
}
