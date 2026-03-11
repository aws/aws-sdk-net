using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Shapes are used to model structures and member types. If they are a structure the shape 
    /// defines what members it has and what shape those members are. It also defines which of those
    /// members are required. If it is not a structure then it is used to specify the type of the member and its properties.
    /// </summary>
    public class Shape : BaseModel
    {
        public const string ValueKey = "value";
        public const string KeyKey = "key";
        public const string MemberKey = "member";
        public const string MembersKey = "members";
        public const string PayloadKey = "payload";
        public const string ExceptionKey = "exception";
        public const string RetryableKey = "retryable";
        public const string ThrottlingKey = "throttling";
        public const string RequiresLengthKey = "requiresLength";
        public const string StreamingKey = "streaming";
        public const string TypeKey = "type";
        public const string FlattenedKey = "flattened";
        public const string RequiredKey = "required";
        public const string MinKey = "min";
        public const string MaxKey = "max";
        public const string SensitiveKey = "sensitive";
        public const string PatternKey = "pattern";
        public const string ErrorKey = "error";
        public const string ErrorCodeKey = "code";
        public const string EventStreamKey = "eventstream";
        public const string DeprecatedKey = "deprecated";
        public const string DeprecatedMessageKey = "deprecatedMessage";
        public const string TimestampFormatKey = "timestampFormat";
        public const string DocumentKey = "document";
        public const string EventKey = "event";
        public const string EventPayloadKey = "eventpayload";
        public const string EventHeaderKey = "eventheader";

        public static readonly HashSet<string> NullableTypes = new HashSet<string> {
            "bool",
            "boolean",
            "decimal",
            "double",
            "DateTime",
            "float",
            "timestamp",
            "int",
            "integer",
            "long",
        };

        public static readonly Dictionary<string, string> PrimitiveTypeNames = new Dictionary<string, string>
        {
            { "blob",       "MemoryStream" },
            { "boolean",    "Bool" },
            { "decimal",    "Decimal" },
            { "double",     "Double" },
            { "float",      "Float" },
            { "integer",    "Int" },
            { "long",       "Long" },
            { "string",     "String" },
            { "timestamp",  "DateTime"},
        };

        private readonly string _name;

        public static Shape CreateShape(ServiceModel model, string name, JsonData data)
        {
            var exception = data[ExceptionKey];
            if (exception != null && exception.IsBoolean)
            {
                return new ExceptionShape(model, name, data);
            }
            return new Shape(model, name, data);
        }

        /// <summary>
        /// Creates a shape with a reference to the model it's a part of, its name, and the json data of the shape pulled from the model.
        /// Shapes are used to model structures and member types. If they are a structure the shape 
        /// defines what members it has and what shape those members are. It also defines which of those
        /// members are required. If it is not a structure then it is used to specify the type of the member and its properties.
        /// </summary>
        /// <param name="model">The model that contains the shape</param>
        /// <param name="name">The name of the shape</param>
        /// <param name="data">The json object of the shape, pulled form the model json</param>
        protected Shape(ServiceModel model, string name, JsonData data)
            : base(model, data)
        {
            this._name = name.ToUpperFirstCharacter();
            var nameOverride = this.model.Customizations.GetOverrideShapeName(this._name);
            if (nameOverride != null)
                this._name = nameOverride;
        }

        /// <summary>
        /// The name of the shape found in the model json
        /// </summary>
        public virtual string Name
        {
            get { return this._name; }
        }

        /// <summary>
        /// Checks if an object is a Shape and has the same name as this shape
        /// </summary>
        /// <param name="obj">The object to compare to</param>
        /// <returns>If the object is a shape and has the same name of this shape</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Shape))
                return false;
            return string.Equals(this.Name, ((Shape)obj).Name);
        }

        /// <summary>
        /// The hashcode of the shape is the hashcode of the name
        /// </summary>
        /// <returns>The hashcode of the shape retrieved from the name</returns>
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        /// <summary>
        /// String representation of the shape found by the name
        /// </summary>
        /// <returns>The name of the shape as a string</returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// If the structure is a map, returns the Value shape. Otherwise returns null.
        /// </summary>
        public Shape ValueShape
        {
            get
            {
                var valueNode = this.data[ValueKey];
                if (valueNode == null)
                    return null;

                var extendsNode = valueNode[ServiceModel.ShapeKey];
                if (extendsNode == null)
                    return null;

                return this.model.FindShape(extendsNode.ToString());
            }
        }

        /// <summary>
        /// The marshall name used for the value part of a dictionary.
        /// </summary>
        public string ValueMarshallName
        {
            get
            {
                var keyNode = this.data[ValueKey];
                if (keyNode == null || keyNode[ServiceModel.LocationNameKey] == null)
                    return "value";

                return keyNode[ServiceModel.LocationNameKey].ToString();
            }
        }

        /// <summary>
        /// If the structure is a map, returns the Key shape. Otherwise returns null.
        /// </summary>
        public Shape KeyShape
        {
            get
            {
                var valueNode = this.data[KeyKey];
                if (valueNode == null)
                    return null;

                var extendsNode = valueNode[ServiceModel.ShapeKey];
                if (extendsNode == null)
                    return null;

                return this.model.FindShape(extendsNode.ToString());
            }
        }
        /// <summary>
        /// Gets the map's key node's xmlnamespace.
        /// </summary>
        public string KeyShapeXmlNamespace
        {
            /*
            "type": "map",
            "key": {
                "shape": "String",
                "locationName": "K",
                "xmlNamespace": "https://the-key.example.com"
            },
             */
            get
            {
                if (!this.IsMap)
                {
                    return null;
                }
                var keyNode = this.data[KeyKey];
                if (keyNode == null || keyNode[ServiceModel.XmlNamespaceKey] == null)
                    return "";
                return (string)keyNode[ServiceModel.XmlNamespaceKey];
            }
        }
        /// <summary>
        /// Gets the map's value node's xmlnamespace
        /// </summary>
        public string ValueShapeXmlNamespace
        {
            get
            {
                if (!this.IsMap) 
                {
                    return null; 
                }
                var valueNode = this.data[ValueKey];
                if (valueNode == null || valueNode[ServiceModel.XmlNamespaceKey] == null)
                    return "";
                return (string)valueNode[ServiceModel.XmlNamespaceKey];
            }
        }
        /// <summary>
        /// The marshall name used for the key part of a dictionary.
        /// </summary>
        public string KeyMarshallName
        {
            get
            {
                var keyNode = this.data[KeyKey];
                if (keyNode == null || keyNode[ServiceModel.LocationNameKey] == null)
                    return "key";

                return keyNode[ServiceModel.LocationNameKey].ToString();
            }
        }

        /// <summary>
        /// If the structure is a list it returns the shape contained into the list otherwise null.
        /// This returns the list shape recognizing any shape substitution in effect via customizations.
        /// </summary>
        public Shape ListShape
        {
            get
            {
                var shapeName = LookupListShapeName(true);
                return !string.IsNullOrEmpty(shapeName) ? this.model.FindShape(shapeName) : null;
            }
        }

        /// <summary>
        /// If the structure is a list it returns the shape contained into the list otherwise null.
        /// This returns the original list shape from the model, ignoring any shape substitution in 
        /// effect via customizations.
        /// </summary>
        public Shape ModelListShape
        {
            get
            {
                var shapeName = LookupListShapeName(false);
                return !string.IsNullOrEmpty(shapeName) ? this.model.FindShape(shapeName) : null;
            }
        }

        /// <summary>
        /// Returns the name of a shape declared to be used by a list type, optionally allowing
        /// for substitution.
        /// </summary>
        /// <param name="allowSubstitution"></param>
        /// <returns></returns>
        private string LookupListShapeName(bool allowSubstitution)
        {
            var valueNode = this.data[MemberKey];
            if (valueNode == null)
                return null;

            var extendsNode = valueNode[ServiceModel.ShapeKey];
            if (extendsNode == null)
                return null;

            var shapeName = extendsNode.ToString();
            if (allowSubstitution)
            {
                var substituteShape = this.model.Customizations.GetSubstituteShapeName(shapeName);
                if (substituteShape != null)
                    shapeName = substituteShape;
            }

            return shapeName;
        }

        /// <summary>
        /// The marshall name for the list elements
        /// </summary>
        public string ListMarshallName
        {
            get
            {
                var keyNode = this.data[MemberKey];
                if (keyNode == null || keyNode[ServiceModel.LocationNameKey] == null)
                    return null;

                return keyNode[ServiceModel.LocationNameKey].ToString();
            }
        }

        /// <summary>
        /// The name of the member that should be the payload of a request or is the payload of a response.
        /// </summary>
        public string PayloadMemberName
        {
            get
            {
                var payloadNode = this.data[PayloadKey];
                if (payloadNode == null)
                    return null;

                return payloadNode.ToString();
            }
        }

        /// <summary>
        /// Members of the shape, defined by another shape
        /// </summary>
        public virtual IList<Member> Members
        {
            get
            {
                IList<Member> map = new List<Member>();
                JsonData members = this.data[MembersKey];
                if (members != null)
                {
                    foreach (var member in this.model.Customizations.FlattenShapes(this.Name))
                    {
                        // grab the shape key of the member we want to flatten
                        JsonData flattenMemberShape = this.model.DocumentRoot[ServiceModel.ShapesKey][this.data[MembersKey][member][ServiceModel.ShapeKey].ToString()];
                        foreach (KeyValuePair<string, JsonData> kvp in flattenMemberShape[MembersKey])
                        {
                            if (this.model.Customizations.IsExcludedProperty(kvp.Key, this.Name))
                                continue;
                            map.Add(new Member(this.model, this, kvp.Key, kvp.Key, kvp.Value, null));
                        }
                    }

                    foreach (KeyValuePair<string, JsonData> kvp in members)
                    {
                        // filter out excluded members and perform any property
                        // renames at this stage to make downstream generation
                        // simpler
                        if (this.model.Customizations.IsExcludedProperty(kvp.Key, this.Name))
                            continue;

                        var propertyModifier = this.model.Customizations.GetPropertyModifier(this.Name, kvp.Key);
                        string propertyName;
                        if (propertyModifier != null && propertyModifier.EmitName != null)
                            propertyName = propertyModifier.EmitName;
                        else
                            propertyName = kvp.Key;
                        map.Add(new Member(this.model, this, propertyName, kvp.Key, kvp.Value, propertyModifier));
                    }
                }

                var shapeModifier = this.model.Customizations.GetShapeModifier(this.Name);
                if (shapeModifier != null)
                {
                    var injectedProperties = shapeModifier.InjectedPropertyNames;
                    foreach (var p in injectedProperties)
                    {
                        var injectedPropertyData = shapeModifier.InjectedPropertyData(p);
                        JsonData originalMember;
                        //if the injected member is actually a shape from outside the current shape then grab that jsonData from the "shapes" object
                        if (injectedPropertyData.OriginalMemberIsOutsideContainingShape)
                        {
                            if (injectedPropertyData.Data["outsideOriginalMember"] != null)
                            {
                                string[] shapePath = injectedPropertyData.Data["outsideOriginalMember"].ToString().Split(',');
                                string requestResponseShape = shapePath[0];
                                string memberShape = shapePath[1];
                                var shapeData = this.model.DocumentRoot["shapes"][requestResponseShape]["members"][memberShape];
                                map.Add(new Member(this.model, this, p, p, shapeData, null));
                            }
                        }
                        // if a modeled property was excluded and replaced by an injected property, then we want to store a copy
                        // of the original property's JSON so we can access data such as the context params.
                        else if (injectedPropertyData.Data[CustomizationsModel.OriginalMemberKey] != null)
                        {
                            var shapeData = this.model.FindShape(this.Name).data;
                            originalMember = shapeData["members"][injectedPropertyData.Data[CustomizationsModel.OriginalMemberKey].ToString()];
                            map.Add(new Member(this.model, this, originalMember, p, p, shapeModifier.InjectedPropertyData(p)));
                        }
                        else
                        {
                            map.Add(new Member(this.model, this, p, p, shapeModifier.InjectedPropertyData(p)));
                        }

                    }
                }

                if (this.model.Customizations.RetainOriginalMemberOrdering)
                    return map;
                else
                    return map.OrderBy(x => x.PropertyName).ToList();

            }
        }

        /// <summary>
        /// Find the member that is marked as payload
        /// </summary>
        public Member PayloadMember
        {
            get
            {
                return Members.SingleOrDefault<Member>(m => string.Equals(m.ModeledName, PayloadMemberName
                    , StringComparison.InvariantCultureIgnoreCase));
            }
        }

        /// <summary>
        /// If this shape is a primitive type this returns true so that the request can show if the member has been set or not
        /// </summary>
        public bool IsNullable
        {
            get
            {
                return NullableTypes.Contains(this.Type);
            }
        }

        /// <summary>
        /// Determines if the shape's type is a string
        /// </summary>
        public bool IsString
        {
            get { return this.Type == "string"; }
        }

        /// <summary>
        /// Determines if the shape's type is a timestamp
        /// </summary>
        public bool IsTimeStamp
        {
            get { return this.Type == "timestamp"; }
        }

        /// <summary>
        /// Determines if the shape's type is a integer
        /// </summary>
        public bool IsInt
        {
            get { return this.Type == "integer"; }
        }

        /// <summary>
        /// Determines if the shape's type is a long
        /// </summary>
        public bool IsLong
        {
            get { return this.Type == "long"; }
        }

        /// <summary>
        /// Determines if the shape's type is a float
        /// </summary>
        public bool IsFloat
        {
            get { return this.Type == "float"; }
        }

        /// <summary>
        /// Determines if the shape's type is a double
        /// </summary>
        public bool IsDouble
        {
            get { return this.Type == "double"; }
        }

        /// <summary>
        /// Determines if the shape's type is a boolean
        /// </summary>
        public bool IsBoolean
        {
            get { return this.Type == "boolean"; }
        }

        /// <summary>
        /// Determines if the shape's type is a map
        /// </summary>
        public bool IsMap
        {
            get
            {
                return this.Type == "map";
            }
        }

        /// <summary>
        /// Determines if the shape's type is a list
        /// </summary>
        public bool IsList
        {
            get
            {
                return this.Type == "list";
            }
        }

        /// <summary>
        /// Determines if the shape's type is a string and enum is set in the json
        /// </summary>
        public bool IsEnum
        {
            get
            {
                return this.Type == "string" && this.data["enum"] != null;
            }
        }

        /// <summary>
        /// Determines if the shape's type is a structure
        /// </summary>
        public bool IsStructure
        {
            get
            {
                return this.Type == "structure";
            }
        }

        /// <summary>
        /// Determines if the shape's type is a blob
        /// </summary>
        public bool IsMemoryStream
        {
            get
            {
                return this.Type == "blob";
            }
        }

        /// <summary>
        /// Determines if the shape's json has a requiresLength attribute
        /// </summary>
        public bool RequiresLength
        {
            get
            {
                return (bool)(this.data[RequiresLengthKey] ?? false);
            }
        }

        /// <summary>
        /// Determines if the shape has the Document trait.
        /// <para />
        /// From the Spec:
        /// 1. Structures marked with the document trait MUST NOT contain members.
        /// 2. Document Types can not be used as an input, output, or error shape of an operation.
        /// 3. IDocument types cannot function as unions, errors, event streams, or events.  A Structure that has a Document trait can not also have 
        ///    exception, fault, union, event, or eventstream traits.
        /// <para />
        /// NOTE: Restrictions are NOT enforced at this property.  This will always return true if the document trait is present, even if the shape is not in a valid configuration. 
        /// </summary> 
        public bool IsDocument
        {
            get
            {
                var documentNode = this.data[DocumentKey];
                if (documentNode == null)
                    return false;

                return bool.Parse(documentNode.ToString());
            }
        }


        public bool Sensitive
        {
            get
            {
                var sensitiveNode = data[SensitiveKey];
                if (sensitiveNode == null)
                    return false;

                return bool.Parse(sensitiveNode.ToString());
            }
        }

        public long? Min
        {
            get
            {
                var value = data[MinKey];

                if(value != null)
                {
                    long min;
                    if (!long.TryParse(value.ToString(), out min))
                    {
                        Console.WriteLine("Generator does not support non-integer values for Min.");
                        return null;
                    }
                    return min;
                }

                return null;
            }
        }

        public long? Max
        {
            get
            {
                var value = data[MaxKey];
                if (value != null)
                {
                    long max;
                    if (!long.TryParse(value.ToString(), out max))
                    {
                        Console.WriteLine("Generator does not support non-integer values for Max.");
                        return null;
                    }
                    return max;
                }

                return null;
            }
        }

        public string Pattern
        {
            get
            {
                var value = data[PatternKey];
                if (value == null) return null;
                return value.ToString();
            }
        }

        /// <summary>
        /// Determines the type of the shape from the type attribute
        /// </summary>
        public string Type
        {
            get
            {
                var typeNode = this.data[TypeKey];
                if (typeNode == null)
                    throw new Exception("Type is missing for shape " + this.Name);

                return typeNode.ToString();
            }
        }

        public bool HasErrorCode
        {
            get
            {
                var errorNode = this.data[ErrorKey];
                if (errorNode != null)
                    return errorNode[ErrorCodeKey] != null;

                return false;
            }
        }

        public string ErrorCode
        {
            get
            {
                if (!HasErrorCode)
                    return null;
                var errorNode = this.data[ErrorKey];
                return errorNode[ErrorCodeKey].ToString();
            }
        }

        /// <summary>
        /// Determines if the shape json has a flattened attribute
        /// </summary>
        public bool IsFlattened
        {
            get
            {
                var flattened = data[FlattenedKey];
                if (flattened == null || !flattened.IsBoolean) return false;
                return (bool)flattened;
            }
        }

        /// <summary>
        /// The name of the marshaller. The locationName if it's set, the shapes name otherwise.
        /// </summary>
        public string MarshallName
        {
            get
            {
                return LocationName ?? this._name;
            }
        }

        /// <summary>
        /// Looks if there is a locationName for the shape, null otherwise
        /// </summary>
        public string LocationName
        {
            get
            {
                // if list, lookup member/metadata/xmlName
                // otherwise, lookup metadata/xmlName
                var source = data;
                if (IsList)
                {
                    source = data[MemberKey];
                    if (source == null) return null;
                }

                var locationName = source[ServiceModel.LocationNameKey];
                if (locationName == null) return null;
                return locationName.ToString();
            }
        }

        public bool IsPrimitiveType
        {
            get
            {
                return PrimitiveTypeNames.ContainsKey(this.Type);
            }
        }

        public string GetPrimitiveType()
        {
            string type;
            if (!PrimitiveTypeNames.TryGetValue(this.Type, out type))
            {
                throw new Exception("Shape is not a primitive type: " + this.Type);
            }
            return type;
        }

        /// <summary>
        /// The member names listed in the shape's json required attribute
        /// </summary>
        public IEnumerable<string> RequiredMembers
        {
            get
            {
                var req = new List<string>();

                var required = data[RequiredKey];
                if (required == null || !required.IsArray) return req;
                req.AddRange(from object item in required select item.ToString());
                req.Sort();
                return req;
            }
        }

        /// <summary>
        /// Determines if the shape is Deprecated.
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
        /// Returns the deprecation message specified in the model or in the customization file.
        /// </summary>
        public string DeprecationMessage
        {
            get
            {
                string message = this.model.Customizations.GetShapeModifier(this._name)?.DeprecationMessage ??
                                 data[DeprecatedMessageKey].CastToString();
                // TODO: Fill in missing deprecated messages for S3
                if (message == null)
                    throw new Exception(string.Format("The 'message' property of the 'deprecated' trait is missing for shape {0}.\nFor example: \"ShapeName\":{{ ... \"members\":{{ ... }}, \"deprecated\":true, \"deprecatedMessage\":\"This type is deprecated\"}}", this._name));

                return message ?? "";
            }
        }

        /// <summary>
        /// If the shape is a request or response type, strips off the suffix
        /// to yield the parent operation. Null is returned if the shape is a
        /// regular model shape.
        /// </summary>
        public string RelatedOperationName
        {
            get
            {
                const string RequestSuffix = "Request";
                const string ResponseSuffix = "Response";
                const string ResultSuffix = "Result";

                var len = Name.Length;
                if (Name.EndsWith(RequestSuffix, StringComparison.Ordinal))
                    return Name.Substring(0, len - RequestSuffix.Length);

                if (Name.EndsWith(ResponseSuffix, StringComparison.Ordinal))
                    return Name.Substring(0, len - ResponseSuffix.Length);

                if (Name.EndsWith(ResultSuffix, StringComparison.Ordinal))
                    return Name.Substring(0, len - ResultSuffix.Length);

                return null;
            }
        }

        /// <summary>
        /// Returns the marshaller method to use in the generated marshaller code for a
        /// shape of primitive type. This is used while marshalling lists and maps.
        /// </summary>
        public string PrimitiveMarshaller(MarshallLocation marshallLocation)
        {
            if (this.IsTimeStamp)
            {
                var timestampFormat = GetTimestampFormat(marshallLocation);
                string formatAppend = string.Empty;
                if(timestampFormat == TimestampFormat.ISO8601)
                {
                    formatAppend = "WithOptionalMs";
                }
                return $"StringUtils.FromDateTimeTo{timestampFormat}{formatAppend}";
            }
            else
            {
                return $"StringUtils.From{this.GetPrimitiveType()}";
            }
        }

        /// <summary>
        /// Timestamp format for the shape.
        /// </summary>
        public TimestampFormat GetTimestampFormat(MarshallLocation marshallLocation)
        {
            var timestampFormat = data.GetTimestampFormat();
            if (timestampFormat == TimestampFormat.None)
            {
                timestampFormat = Member.GetDefaultTimestampFormat(marshallLocation, this.model.Type);
            }
            return timestampFormat;
        }

        public bool IsFieldRequired(string fieldName)
        {
            var requiredList = data[RequiredKey];
            var customizations = this.model.Customizations.GetShapeModifier(this.Name);
            if (requiredList != null && requiredList.IsArray)
            {
                foreach (var name in requiredList)
                {
                    var namestr = name.ToString();
                    if (string.Equals(namestr, fieldName))
                        return true;
                    // check for "*" override (bucketName). S3 only
                    if (this.model.Customizations.TryGetPropertyModifier("*", "Bucket", out var _))
                    {
                        if (namestr == "Bucket" && fieldName == "BucketName") return true;
                    }
                    if (customizations != null && customizations.PropertyModifier(namestr) != null)
                    {
                        var propertyModifier = customizations.PropertyModifier(namestr);
                        // if the original member name is part of required list and we overrode that with a different property name via "emit from member name"
                        // then it should still have the required attribute
                        if (propertyModifier.EmitName != null && propertyModifier.EmitName.Equals(fieldName) && propertyModifier.OriginalPropertyName.Equals(namestr))
                            return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Returns true if the structure contains the event trait,
        /// not to be confused with the EventStream structure shape
        /// </summary>
        public bool IsEvent
        {
            get
            {
                return this.data.PropertyNames.Contains(EventKey);
            }
        }
        public bool IsException
        {
            get
            {
                var exceptionNode = data[ExceptionKey];
                if (exceptionNode == null)
                {
                    return false;
                }
                return (bool)exceptionNode;
            }
        }

        /// <summary>
        /// Unbound Event members are members of an event which are not marked with the eventHeader or EventPayload trait.
        /// </summary>
        /// <returns>Returns the list of members who are not marked with the event header or eventPayload trait</returns>
        public List<Member> GetUnboundEventMembers()
        {
            if (Members == null)
                return new List<Member>();
            return Members.Where(m => !m.IsEventPayload && !m.IsEventHeader).ToList();

        }

        /// <summary>
        /// A structure with an implicit payload is one where there is no eventPayload
        /// trait marked on one of the members.
        /// </summary>
        /// <returns>True if the number of members marked without eventPayload or EventHeader is greater than 0. False otherwise</returns>
        public bool HasImplicitEventPayloadMembers()
        {
            return IsEvent && GetUnboundEventMembers().Count > 0;
        }

        /// <summary>
        /// An explicity payload member must have the "eventpayload" trait and can be the only
        /// member marked as such. 
        /// </summary>
        /// <returns>The member marked with the "eventpayload" trait. Null if none found</returns>
        public Member GetExplicitEventPayloadMember()
        {
            if (Members == null)
            {
                return null;
            }
            return Members.Where(m => m.IsEventPayload).FirstOrDefault();
        }

        /// <summary>
        /// If all members of an event are marked with eventheader then there is no event payload
        /// </summary>
        /// <returns>True if the structure contains only eventHeaders. False otherwise</returns>
        public bool HasNoEventPayload()
        {
            return Members == null || Members.All(m => m.IsEventHeader);
        }

        public override string Documentation
        {
            get
            {
                var docNode = data[ServiceModel.DocumentationKey];

                if (this.model.Customizations.ShapeModifiers.TryGetValue(this.Name, out var modifier))
                {
                    foreach (var doc in modifier.ShapeDocumentation)
                    {
                        docNode += (string)doc + " ";
                    }
                }
                if (docNode == null)
                    return string.Empty;
                return docNode.ToString();
            }
        }
    }
}
