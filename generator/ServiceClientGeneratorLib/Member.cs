using System.Reflection;
using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ServiceClientGenerator.Endpoints;

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
        public const string JsonValueKey = "jsonvalue";
        public const string DeprecatedKey = "deprecated";
        public const string RequiredKey = "required";
        public const string DeprecatedMessageKey = "deprecatedMessage";
        public const string HostLabelKey = "hostLabel";
        public const string EventPayloadKey = "eventpayload";
        public const string EventHeaderKey = "eventheader";
        public const string XmlAttributeKey = "xmlAttribute";
        private const string UnhandledTypeDecimalErrorMessage = "Unhandled type 'decimal' : using .net's decimal type for modeled decimal type may result in loss of data.  decimal type members should explicitly opt-in via shape customization.";

        private const string BackwardsCompatibleDateTimePropertySuffix = "Utc";

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
                if (IsBackwardsCompatibleDateTimeProperty)
                    return BaseVariableName + BackwardsCompatibleDateTimePropertySuffix;
                return BaseVariableName;
            }
        }

        /// <summary>
        /// The name of the property's backing to be used in backwards compatibility property names
        /// </summary>
        public string BackwardCompatibilityVariableName
        {
            get
            {
                if (IsBackwardsCompatibleDateTimeProperty)
                    return BaseVariableName;
                throw new Exception("Property " + BasePropertyName + " is not marked as requiring backward compatibility");
            }
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
        /// It includes the backward compatibility suffix if required.
        /// </summary>
        public string PropertyName
        {
            get
            {
                if (IsBackwardsCompatibleDateTimeProperty)
                    return BasePropertyName + BackwardsCompatibleDateTimePropertySuffix;
                return BasePropertyName;
            }
        }

        /// <summary>
        /// The name of the member to be used in backwards compatibility property names
        /// </summary>
        public string BackwardCompatibilityPropertyName
        {
            get
            {
                if (IsBackwardsCompatibleDateTimeProperty)
                    return BasePropertyName;
                throw new Exception("Property " + BasePropertyName + " is not marked as requiring backward compatibility");
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

                // Rename ErrorType exception properties to avoid hiding AmazonServiceException.ErrorType inherited member.
                if (OwningShape.IsException && _name.ToUpperFirstCharacter() == "ErrorType")
                    return "RequestErrorType";

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

            var documentTrait = memberShape[Shape.DocumentKey];
            if (documentTrait?.IsBoolean == true && (bool)documentTrait)
                return "Amazon.Runtime.Documents.Document";

            if (typeNode == null)
                throw new Exception("Type is missing for shape " + extendsNode.ToString());

            var nullable = UseNullable ? "?" : "";

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
                    return "double";
                case "float":
                    return "float";
                case "integer":
                    return $"int{nullable}";
                case "long":
                    return "long";
                case "timestamp":
                    return $"DateTime{nullable}";
                case "structure":
                    return emitAsShapeName ?? renameShape ?? extendsNode.ToString();
                case "map":
                    var keyType = DetermineType(memberShape["key"], true);
                    var valueType = DetermineType(memberShape["value"], true);
                    return string.Format("Dictionary<{0}, {1}>", keyType, valueType);
                case "list":
                    var listType = DetermineType(memberShape["member"], true);
                    return string.Format("List<{0}>", listType);

                case "decimal":
                    throw new Exception(UnhandledTypeDecimalErrorMessage);

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

            var document = memberShape[Shape.DocumentKey];
            if (document?.IsBoolean == true && (bool)document)
                return "Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller";

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
                    if(UseNullable)
                    {
                        return "NullableBoolUnmarshaller";
                    }
                    return "BoolUnmarshaller";
                case "double":
                    return "DoubleUnmarshaller";
                case "float":
                    return "FloatUnmarshaller";
                case "integer":
                    if (UseNullable)
                    {
                        return "NullableIntUnmarshaller";
                    }
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
        public string DetermineTypeUnmarshallerInstantiate(JsonData extendedData, string parentTypeNode)
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

            var document = memberShape[Shape.DocumentKey];
            if (document?.IsBoolean == true && (bool) document)
                return "Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance";

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
                    if (UseNullable)
                    {
                        return "NullableBoolUnmarshaller.Instance";
                    }
                    return "BoolUnmarshaller.Instance";
                case "double":
                    return "DoubleUnmarshaller.Instance";
                case "float":
                    return "FloatUnmarshaller.Instance";
                case "integer":
                    if (this.UseNullable)
                    {
                        return "NullableIntUnmarshaller.Instance";
                    }
                    return "IntUnmarshaller.Instance";
                case "long":
                    return "LongUnmarshaller.Instance";
                case "timestamp":
                    if (this.UseNullable)
                    {
                        return "NullableDateTimeUnmarshaller.Instance";
                    }
                    return "DateTimeUnmarshaller.Instance";
                case "structure":
                    return (renameShape ?? extendsNode) + "Unmarshaller.Instance";
                case "map":
                    var keyType = DetermineType(memberShape[Shape.KeyKey], true);
                    var keyTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.KeyKey]);
                    var keyTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.KeyKey], typeNode.ToString());

                    var valueType = DetermineType(memberShape[Shape.ValueKey], true);
                    var valueTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.ValueKey]);
                    var valueTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.ValueKey], typeNode.ToString());

                    //Direct sub maps can not be flattened. If the parent was a map then force the sub map to not be flat.
                    var isFlat = IsFlattened;
                    if (parentTypeNode == "map")
                    {
                        isFlat = false;
                    }

                    if (this.model.Type == ServiceType.Json 
                        || this.model.Type == ServiceType.Rest_Json 
                        || (this.model.Type == ServiceType.Rest_Xml && !isFlat))
                        return string.Format("new DictionaryUnmarshaller<{0}, {1}, {2}, {3}>(StringUnmarshaller.Instance, {5})",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate);
                    else
                        return string.Format("new KeyValueUnmarshaller<{0}, {1}, {2}, {3}>(StringUnmarshaller.Instance, {5})",
                            keyType, valueType, keyTypeUnmarshaller, valueTypeUnmarshaller, keyTypeUnmarshallerInstantiate, valueTypeUnmarshallerInstantiate);
                case "list":
                    var listType = DetermineType(memberShape[Shape.MemberKey], true);
                    var listTypeUnmarshaller = GetTypeUnmarshallerName(memberShape[Shape.MemberKey]);
                    var listTypeUnmarshallerInstantiate = DetermineTypeUnmarshallerInstantiate(memberShape[Shape.MemberKey], typeNode.ToString());

                    if (this.model.Type == ServiceType.Json || this.model.Type == ServiceType.Rest_Json)
                        return string.Format("new ListUnmarshaller<{0}, {1}>({2})",
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
                    throw new Exception(string.Format("The 'message' property of the 'deprecated' trait is missing for member {0}.{1}.\nFor example: \"MemberName\":{{ ... \"deprecated\":true, \"deprecatedMessage\":\"This property is deprecated, use XXX instead.\"}}", this.OwningShape.Name, this._name));

                return message;
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
        public bool IsBackwardsCompatibleDateTimeProperty
        {
            get { return this.model.Customizations.IsBackwardsCompatibleDateTimeProperty(this.BasePropertyName, this.OwningShape.Name); }
        }

        /// <summary>
        /// Determines if the member is a type that needs to be instantiated, such as a list or map
        /// </summary>
        public bool IsCollection
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
                if (!this.IsDateTime)
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
        public bool IsDateTime
        {
            get
            {
                return this.DetermineType().Equals("DateTime", StringComparison.InvariantCulture);
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
                if (this.IsDateTime)
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
    }
}
