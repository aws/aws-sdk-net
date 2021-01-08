﻿using Json.LitJson;
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
        public const string PatternKey = "pattern";
        public const string ErrorKey = "error";
        public const string ErrorCodeKey = "code";
        public const string EventStreamKey = "eventstream";
        public const string DeprecatedKey = "deprecated";
        public const string DeprecatedMessageKey = "deprecatedMessage";
        public const string TimestampFormatKey = "timestampFormat";        

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
                        map.Add(new Member(this.model, this, p, p, shapeModifier.InjectedPropertyData(p)));
                    }
                }

                if (this.model.Customizations.RetainOriginalMemberOrdering)
                    return map;
                else
                    return map.OrderBy(x => x.PropertyName).ToList();
                
            }
        }

        /// <summary>
        /// Finds all structure shapes under the current shape that contain no members
        /// </summary>
        public IList<Shape> FindStructureShapesWithoutMembers()
        {
            List<Shape> foundShapes = new List<Shape>();            
            HashSet<string> processedShapes = new HashSet<string>();
            Queue<Shape> shapes = new Queue<Shape>();
            shapes.Enqueue(this);
            
            while(shapes.Count > 0)
            {
                var current = shapes.Dequeue();
                var marshallName = current.IsList ? current.ListMarshallName ?? "member" : current.MarshallName;
                if (processedShapes.Contains(marshallName))
                {
                    continue;
                }

                processedShapes.Add(marshallName);
                
                if (this != current && current.Members.Count == 0)
                {
                    foundShapes.Add(current);
                    continue;
                }
                
                foreach (var child in current.Members.Where(m => m.IsStructure || m.IsList))
                {
                    var shape = child.Shape.IsList ? child.Shape.ListShape : child.Shape;
                    if(!shape.IsStructure && !shape.IsList)
                    {
                        continue;
                    }
                    
                    shapes.Enqueue(shape);
                }
            }

            return foundShapes;
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

        public bool IsEventStream
        {
            get
            {
                var isEventStream = data[EventStreamKey];
                if (isEventStream != null && isEventStream.IsBoolean)
                {
                    return (bool) isEventStream;
                }

                return false;
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
        public bool IsDateTime
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
        /// Determines if the shape's json has a streaming attribute
        /// </summary>
        public bool IsStreaming
        {
            get
            {
                var streamingNode = this.data[StreamingKey];
                if (streamingNode == null)
                    return false;

                return bool.Parse(streamingNode.ToString());
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
                if (message == null)
                    throw new Exception(string.Format("The 'message' property of the 'deprecated' trait is missing for shape {0}.\nFor example: \"ShapeName\":{{ ... \"members\":{{ ... }}, \"deprecated\":true, \"deprecatedMessage\":\"This type is deprecated\"}}", this._name));

                return message;
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
            if (this.IsDateTime)
            {
                var timestampFormat = GetTimestampFormat(marshallLocation);
                return "StringUtils.FromDateTimeTo" + timestampFormat;
            }
            else
            {
                return "StringUtils.From" + this.GetPrimitiveType();
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
            if (requiredList != null && requiredList.IsArray)
            {
                foreach (var name in requiredList)
                {
                    if (string.Equals(name.ToString(), fieldName))
                        return true;
                }
            }
            return false;
        }
    }
}
