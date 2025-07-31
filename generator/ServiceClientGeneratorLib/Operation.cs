using Json.LitJson;
using ServiceClientGenerator.Endpoints;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// An object that represents the operations for a service api
    /// </summary>
    public class Operation : BaseModel
    {
        /// <summary>
        /// The name of the operation as found in the json model
        /// </summary>
        readonly string name;

        private OperationPaginatorConfig _operationPaginatorConfig;

        /// <summary>
        /// Constructs on operation from a service model, operation name, and the json model
        /// </summary>
        /// <param name="model">The model of the service the operation belongs to</param>
        /// <param name="name">The name of the operation</param>
        /// <param name="data">The json data from the model file</param>
        public Operation(ServiceModel model, string name, JsonData data)
            : base(model, data)
        {
            this.model = model;
            this.name = name;
            this.data = data;
        }

        /// <summary>
        /// Constructs on operation from a service model, operation name, the json model, and the json paginators
        /// </summary>
        /// <param name="model">The model of the service the operation belongs to</param>
        /// <param name="name">The name of the operation</param>
        /// <param name="data">The json data from the model file</param>
        /// <param name="paginatorData">The json data from the paginators file</param>
        public Operation(ServiceModel model, string name, JsonData data, JsonData paginatorData)
            : this(model, name, data)
        {
            if (paginatorData[ServiceModel.OutputTokenKey] != null && paginatorData[ServiceModel.InputTokenKey] != null)
            {
                _operationPaginatorConfig = new OperationPaginatorConfig(this, name, paginatorData);
            }
        }

        /// <summary>
        /// The name of the operation determined by checking if there are any customizations for a change of the name
        /// then using the provided name if there isn't a custom name.
        /// </summary>
        public string Name
        {
            get
            {
                var modifiers = this.model.Customizations.GetOperationModifiers(ShapeName);
                if (modifiers != null && !string.IsNullOrEmpty(modifiers.Name))
                    return modifiers.Name;

                return ShapeName;
            }
        }
        /// <summary>
        /// Returns the raw shape name without customization
        /// </summary>
        public string ShapeName
        {
            get
            {
                return this.name;
            }
        }

        public override string Documentation
        {
            get
            {
                var modifiers = this.model.Customizations.GetOperationModifiers(this.name);
                if (modifiers != null && !string.IsNullOrEmpty(modifiers.Documentation))
                    return modifiers.Documentation;
                return base.Documentation;
            }
        }

        /// <summary>
        /// Determines if the operation is Deprecated.
        /// </summary>
        public bool IsDeprecated
        {
            get
            {
                if (data[ServiceModel.DeprecatedKey] != null && data[ServiceModel.DeprecatedKey].IsBoolean)
                    return (bool)data[ServiceModel.DeprecatedKey];

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
                string message = this.model.Customizations.GetOperationModifiers(this.name)?.DeprecatedMessage ??
                                 data[ServiceModel.DeprecatedMessageKey].CastToString();
                // TODO: Fill in missing deprecation messages
                if (message == null)
                    throw new Exception(string.Format("The 'message' property of the 'deprecated' trait is missing for operation {0}.\nFor example: \"OperationName\":{{\"name\":\"OperationName\", ... \"deprecated\":true, \"deprecatedMessage\":\"This operation is deprecated\"}}", this.name));          

                return message;
            }
        }

        /// <summary>
        /// Determines if a checksum needs to be sent in the Content-MD5 header.
        /// Checks both the older "httpChecksumRequired" property as well as the newer
        /// "httpChecksum.requestChecksumRequired" property
        /// </summary>
        public bool HttpChecksumRequired
        {
            get
            {
                // if a rename happened, look for the original operation in the model
                if (this.model.DocumentRoot["operations"][this.Name] != null && this.model.DocumentRoot["operations"][this.Name]["httpChecksum"] != null && this.model.DocumentRoot["operations"][this.Name]["httpChecksum"]["requestChecksumRequired"] != null)
                {
                    return true;
                }
                if (data[ServiceModel.HttpChecksumRequiredKey] != null && data[ServiceModel.HttpChecksumRequiredKey].IsBoolean)
                {
                    if ((bool)data[ServiceModel.HttpChecksumRequiredKey])
                    {
                        return true;
                    }
                }

                if (ChecksumConfiguration != null && ChecksumConfiguration.RequestChecksumRequired)
                {
                    return true;
                }
                    

                return false;
            }
        }

        /// <summary>
        /// Request and response flexible checksum configuration, read from the "httpChecksum" object
        /// </summary>
        public ChecksumConfiguration ChecksumConfiguration
        {
            get
            {
                if (this.model.DocumentRoot["operations"][this.Name] != null && this.model.DocumentRoot["operations"][this.Name][ServiceModel.HttpChecksumKey] != null)
                {
                    return new ChecksumConfiguration(this.model.DocumentRoot["operations"][this.Name][ServiceModel.HttpChecksumKey]);
                }
                if (data[ServiceModel.HttpChecksumKey] != null)
                    return new ChecksumConfiguration(data[ServiceModel.HttpChecksumKey]);

                return null;
            }
        }

        /// <summary>
        /// Determines if compression trait is available and if so, <see cref="RequestCompressionConfiguration"/> object
        /// is instantiated and returned using the data inside the compression trait
        /// </summary>
        public RequestCompressionConfiguration CompressionAlgorithmEncodings
        {
            get
            {
                var requestCompressionJsonData = data[ServiceModel.RequestCompressionKey];
                if (requestCompressionJsonData != null)
                {
                    var payload = this.RequestPayloadMember;
                    return new RequestCompressionConfiguration(requestCompressionJsonData, payload);
                }

                return null;
            }
        }

        /// <summary>
        /// Determines whether this operation's marshaller needs to call the checksum
        /// handling in Core. This means it either requires a MD5 checksum and/or supports
        /// flexible checksums.
        /// </summary>
        public bool RequiresChecksumDuringMarshalling
        {
            get
            {
                if (HttpChecksumRequired)
                {
                    return true;
                }

                if (!string.IsNullOrEmpty(ChecksumConfiguration?.RequestAlgorithmMember))
                {
                    return true;
                }

                return false;
            }
        }
        /// <summary>
        /// Determines if the operation is customized to be only internally accessible.
        /// </summary>
        public bool IsInternal
        {
            get
            {
                var modifiers = this.model.Customizations.GetOperationModifiers(this.name);
                if (modifiers != null)
                    return modifiers.IsInternal;

                return false;
            }
        }

        /// <summary>
        /// Determines if the operation is to be excluded from generation
        /// </summary>
        public bool IsExcluded
        {
            get
            {
                var modifiers = this.model.Customizations.GetOperationModifiers(this.name);
                if (modifiers != null)
                    return modifiers.IsExcluded;

                return false;
            }
        }

        // set if we need to 'demote' the response output members into a shape hosted
        // within a result class that doesn't exist in the service model. As an example
        // EC2's DescribeImageAttribute outputs a response with multiple members. We take
        // those and put them into an ImageAttribute shape that is referenced by the
        // DescribeImageAttributeResult class (which doesn't exist in EC2's model).
        public bool UseWrappingResult
        {
            get
            {
                var modifiers = this.model.Customizations.GetOperationModifiers(this.name);
                if (modifiers != null)
                    return modifiers.UseWrappingResult;

                return false;
            }
        }

        /// <summary>
        /// Allows the operation to return an empty result when the operation is modeled to return body result structure.
        /// </summary>
        public bool AllowEmptyResult
        {
            get
            {
                var modifiers = this.model.Customizations.GetOperationModifiers(this.name);
                if (modifiers != null)
                    return modifiers.AllowEmptyResult;

                return false;
            }
        }

        /// <summary>
        /// Determines if the operation pagination should end when the response equal to the request token
        /// </summary>
        public bool StopPaginationOnSameToken
        {
            get
            {
                var modifiers = this.model.Customizations.GetOperationModifiers(this.name);
                if (modifiers != null)
                    return modifiers.StopPaginationOnSameToken;

                return false;
            }
        }

        public bool WrapsResultShape(string shapeName)
        {
            var modifiers = this.model.Customizations.GetOperationModifiers(this.name);
            if (modifiers != null && modifiers.UseWrappingResult)
            {
                var wrappedShape = modifiers.WrappedResultShape;
                return (!string.IsNullOrEmpty(wrappedShape) &&
                        wrappedShape.Equals(shapeName, StringComparison.Ordinal));
            }

            return false;
        }

        /// <summary>
        /// If the operation uses a payload member, return that member so that it can be generated for the operation as well.
        /// Payloads are place holders in the json models. They are represented as another shape and contain the actual necessary attributes.
        /// </summary>
        public Member RequestPayloadMember
        {
            get
            {
                if (this.RequestStructure != null)
                {
                    var payload = this.RequestStructure.PayloadMemberName;
                    // check to see if the payload member has been overridden by another member defined in the service customizations
                    // file. For example, the payload member could've been included in the "exclude" array and another member
                    // could've been injected.
                    // For example:
                    //        "RestoreObjectRequest": {
                    //          "exclude": ["RestoreRequest"],
                    //          "inject": [
                    //          {
                    //            "Days": {
                    //                "shape": "Days",
                    //            "originalMember": "RestoreRequest"
                    //            }
                    //          }
                    //      ]
                    //  },
                    // The payload is "RestoreRequest" but it has been excluded via a customization. so we check for 
                    // that scenario here. 
                    if (this.model.Customizations.ShapeModifiers.TryGetValue(this.RequestStructure.Name, out var customization) && customization.IsExcludedProperty(payload))
                    {
                        foreach (var injectedProperty in customization.InjectedPropertyNames)
                        {
                            var propertyInjector = customization.InjectedPropertyData(injectedProperty);
                            if (string.Equals(propertyInjector.Data[CustomizationsModel.OriginalMemberKey].ToString(), payload, StringComparison.OrdinalIgnoreCase))
                            {
                                payload = injectedProperty;
                                break;
                            }
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(payload))
                    {
                        return this.RequestStructure.Members.Single(m =>
                            (m.HasModifier && m.MarshallName.Equals(payload, StringComparison.InvariantCultureIgnoreCase))
                            || (!m.HasModifier && m.ModeledName.Equals(payload, StringComparison.InvariantCultureIgnoreCase)));
                    }
                }

                return null;
            }
        }

        private IList<Member> _requestPayloadFlattenMembers;

        /// <summary>
        /// Contains the list of members of the flattened RequestPayloadMember if the RequestPayloadMember
        /// has been flattened
        /// </summary>
        public IList<Member> RequestPayloadFlattenMembers
        {
            get
            {
                if (_requestPayloadFlattenMembers == null)
                {
                    IList<Member> map = new List<Member>();
                    if (this.model.Customizations.FlattenShapes(this.RequestStructure.Name).Contains(this.RequestPayloadMember.ModeledName))
                    {
                        JsonData flattenMemberShape = this.model.DocumentRoot[ServiceModel.ShapesKey][this.data[Shape.MembersKey][this.RequestPayloadMember.ModeledName][ServiceModel.ShapeKey].ToString()];
                        foreach (KeyValuePair<string, JsonData> kvp in flattenMemberShape[Shape.MembersKey])
                        {
                            if (this.model.Customizations.IsExcludedProperty(kvp.Key, this.Name))
                                continue;
                            map.Add(new Member(this.model, this.RequestPayloadMember.Shape, kvp.Key, kvp.Key, kvp.Value, null));
                        }
                        _requestPayloadFlattenMembers = map;
                    }
                }
                return _requestPayloadFlattenMembers;
            }
        }

        /// <summary>
        /// The response payload member, null if one does not exist.
        /// </summary>
        public Member ResponsePayloadMember
        {
            get
            {
                if (this.ResponseStructure != null)
                {
                    var payload = this.ResponseStructure.PayloadMemberName;
                    // check to see if the payload member has been overridden by another member defined in the service customizations
                    // file. For example, the payload member could've been included in the "exclude" array and another member
                    // could've been injected or the member could've been renamed
                    if (this.model.Customizations.ShapeModifiers.ContainsKey(this.ResponseStructure.Name))
                    {
                        var customization = this.model.Customizations.ShapeModifiers[this.ResponseStructure.Name];
                        if (customization.IsExcludedProperty(payload))
                        {
                            foreach (var injectedProperty in customization.InjectedPropertyNames)
                            {
                                var propertyInjector = customization.InjectedPropertyData(injectedProperty);
                                if (string.Equals(propertyInjector.Data[CustomizationsModel.OriginalMemberKey].ToString(), payload, StringComparison.OrdinalIgnoreCase))
                                {
                                    payload = injectedProperty;
                                    break;
                                }

                            }
                        }
                        
                    }
                    // has the payload's property been modified via an "emitPropertyName" customization?
                    if (payload != null && this.model.Customizations.GetPropertyModifier(this.ResponseStructure.Name, payload) != null)
                    {
                        var propertyModifier = this.model.Customizations.GetPropertyModifier(this.ResponseStructure.Name, payload);
                        payload = propertyModifier.EmitName;
                    }
                    if (!string.IsNullOrWhiteSpace(payload))
                    {
                        return this.ResponseStructure.Members.Single(m => m.ModeledName.Equals(payload, StringComparison.InvariantCultureIgnoreCase));
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// Gets the namespace of the payload for an XML object
        /// </summary>
        public new string XmlNamespace
        {
            get
            {
                if (this.RequestPayloadMember != null)
                {
                    return !string.IsNullOrEmpty(RequestPayloadMember.XmlNamespace) 
                        ? RequestPayloadMember.XmlNamespace
                        : RequestPayloadMember.Shape.XmlNamespace;
                }
                return !string.IsNullOrEmpty(this.Input.XmlNamespace)
                    ? this.Input.XmlNamespace 
                    : RequestStructure.XmlNamespace;
            }
        }

        /// <summary>
        /// Gets the namespace prefix of the payload for an XML object
        /// </summary>
        public new string XmlNamespacePrefix
        {
            get
            {
                if (this.RequestPayloadMember != null)
                {
                    return !string.IsNullOrEmpty(RequestPayloadMember.XmlNamespacePrefix)
                        ? RequestPayloadMember.XmlNamespacePrefix
                        : RequestPayloadMember.Shape.XmlNamespacePrefix;
                }
                return !string.IsNullOrEmpty(this.Input.XmlNamespacePrefix)
                    ? this.Input.XmlNamespacePrefix
                    : RequestStructure.XmlNamespacePrefix;
            }
        }

        /// <summary>
        /// A list of the members that are in the request header, empty if none
        /// </summary>
        public IList<Member> RequestHeaderMembers
        {
            get
            {
                return this.RequestStructure == null ?
                    new List<Member>() :
                    this.RequestStructure.Members.Where(
                        m => m.MarshallLocation == MarshallLocation.Header || m.MarshallLocation == MarshallLocation.Headers).ToList();
            }
        }

        /// <summary>
        /// A list of members that are in the response header, empty if none
        /// </summary>
        public IList<Member> ResponseHeaderMembers
        {
            get
            {
                return this.ResponseStructure == null ?
                    new List<Member>() :
                    this.ResponseStructure.Members.Where(
                        m => m.MarshallLocation == MarshallLocation.Header || m.MarshallLocation == MarshallLocation.Headers).ToList();
            }
        }

        /// <summary>
        /// A member that is defined by the status code of the response, null if none
        /// </summary>
        public Member ResponseStatusCodeMember
        {
            get
            {
                return this.ResponseStructure == null ?
                    null :
                    this.ResponseStructure.Members.SingleOrDefault(
                        m => m.MarshallLocation == MarshallLocation.StatusCode);
            }
        }

        /// <summary>
        /// A member in the response that is sent as a stream, null if none
        /// </summary>
        public Member ResponseStreamingMember
        {
            get
            {
                return this.ResponseStructure == null ?
                    null :
                    this.ResponseStructure.Members.SingleOrDefault(m => m.Shape.IsStreaming);
            }
        }

        /// <summary>
        /// A member in the response streams events from the service to the SDK consumer.
        /// </summary>
        public Member ResponseEventStreamingMember
        {
            get
            {
                return this.ResponseStructure == null ?
                    null :
                    this.ResponseStructure.Members.SingleOrDefault(m => m.Shape.IsEventStream);
            }
        }

        /// <summary>
        /// Members that are part of the URI for the request, empty if none
        /// </summary>
        public IList<Member> RequestUriMembers
        {
            get
            {
                return this.RequestStructure == null ?
                    new List<Member>() :
                    this.RequestStructure.Members.Where(
                        m => m.MarshallLocation == MarshallLocation.Uri).ToList();
            }
        }

        /// <summary>
        /// List of members that are part of the QueryString, empty if none
        /// </summary>
        public IList<Member> RequestQueryStringMembers
        {
            get
            {
                return this.RequestStructure == null ?
                    new List<Member>() :
                    this.RequestStructure.Members.Where(
                        m => m.MarshallLocation == MarshallLocation.QueryString).ToList();
            }
        }

        /// <summary>
        /// A member in the request that is sent as a stream, null if none
        /// </summary>
        public Member RequestStreamingMember
        {
            get
            {
                return this.RequestStructure == null ?
                    null :
                    this.RequestStructure.Members.SingleOrDefault(m => m.Shape.IsStreaming);
            }
        }

        /// <summary>
        /// A member in the request that is used to stream events to the service.
        /// </summary>
        public Member RequestEventStreamingMember
        {
            get
            {
                return this.RequestStructure == null ?
                    null :
                    this.RequestStructure.Members.SingleOrDefault(m => m.Shape.IsEventStream);
            }
        }

        /// <summary>
        /// Members who are part of the request's body
        /// </summary>
        public IList<Member> RequestBodyMembers
        {
            get
            {
                if (this.RequestStructure == null)
                    return new List<Member>();

                var payloadName = this.RequestStructure.PayloadMemberName;
                return this.RequestStructure.Members.Where(
                    m =>
                        m.MarshallLocation == MarshallLocation.Body &&
                        !string.Equals(m.MarshallName, payloadName, StringComparison.Ordinal)).ToList();
            }
        }
        
        
        /// <summary>
        /// Members who are part of the response's body
        /// </summary>
        public IList<Member> ResponseBodyMembers
        {
            get
            {
                if (this.ResponseStructure == null)
                    return new List<Member>();

                var payloadName = this.ResponseStructure.PayloadMemberName;
                if (this.InputOutputIsSameShape && string.Equals(model.Protocol,"rest-xml",StringComparison.OrdinalIgnoreCase))
                {
                    return this.ResponseStructure.Members.Where(
                        m =>
                            m.MarshallLocation == MarshallLocation.Body || m.MarshallLocation == MarshallLocation.Uri || m.MarshallLocation == MarshallLocation.QueryString &&
                            !string.Equals(m.MarshallName, payloadName, StringComparison.Ordinal)).ToList();
                }
                return this.ResponseStructure.Members.Where(
                    m =>
                        m.MarshallLocation == MarshallLocation.Body &&
                        !string.Equals(m.MarshallName, payloadName, StringComparison.Ordinal)).ToList();
            }
        }


        /// <summary>
        /// List of members that are decorated with a hostLabel value equal to true
        /// </summary>
        public IEnumerable<Member> RequestHostPrefixMembers
        {
            get
            {
                return this.RequestStructure == null ?
                    new List<Member>() :
                    this.RequestStructure.Members.Where(m => m.IsHostLabel);
            }
        }

        /// <summary>
        /// Determines if any of the ResponseStructure (Output) shapes are marked with "eventstream":true.
        /// </summary>
        public bool IsEventStreamOutput => ResponseStructure?.Members?.Any(
                                               member => member.Shape?.IsEventStream ?? false)
                                           ?? false;

        /// <summary>
        /// Determines if any of the RequestStructure (Input) shapes are marked with "eventstream":true.
        /// </summary>
        public bool IsEventStreamInput => RequestStructure?.Members?.Any(
                                               member => member.Shape?.IsEventStream ?? false)
                                           ?? false;

        /// <summary>
        /// Determines if both the RequestStructure (Input) and ResponseStructure (Output) shapes contain shapes 
        /// marked with "eventstream":true. When true, the operation is a bi-directional event stream operation
        /// which requires H2 support when "protocolSettings":{"h2":"eventstreams"}, "protocolSettings":{"h2":"optional"},
        /// or "protocolSettings":{"h2":"required"} is modeled for the service.
        /// </summary>
        public bool IsEventStreamBidi
        {
            get
            {
                return IsEventStreamInput && IsEventStreamOutput;
            }
        }

        /// <summary>
        /// Determines if the request structure will have members in the header
        /// </summary>
        public bool RequestHasHeaderMembers
        {
            get
            {
                return (this.RequestHeaderMembers.Count > 0);
            }
        }

        /// <summary>
        /// Determines if the request structure will have members in the body
        /// </summary>
        public bool RequestHasBodyMembers
        {
            get
            {
                // Has any members which are marshalled as part of the request body
                return (this.RequestBodyMembers.Count > 0);
            }
        }

        /// <summary>
        /// Determines if the request structure has uri members
        /// </summary>
        public bool RequestHasUriMembers
        {
            get
            {
                return (this.RequestUriMembers.Count > 0);
            }
        }

        /// <summary>
        /// Determines if the request structure has query string members
        /// </summary>
        public bool RequestHasQueryStringMembers
        {
            get
            {
                // Has any members which are marshalled as part of the request body
                return this.RequestStructure != null &&
                    this.RequestStructure.Members.Any(m => m.MarshallLocation == MarshallLocation.QueryString);
            }
        }

        /// <summary>
        /// Determines if the response structure will have members in the body
        /// </summary>
        public bool ResponseHasBodyMembers
        {
            get
            {
                // Has any members which are marshalled as part of the response body
                return (this.ResponseBodyMembers.Count > 0);
            }
        }

        /// <summary>
        /// Determines if the response structure will have members in the header
        /// </summary>
        public bool ResponseHasHeaderMembers
        {
            get
            {
                return (this.ResponseHeaderMembers.Count > 0);
            }
        }

        /// <summary>
        /// Use query string if there are body members or a streamed member
        /// </summary>
        public bool UseQueryString
        {
            get
            {
                return this.RequestStructure != null &&
                    this.RequestStructure.Members.Any(m => m.MarshallLocation == MarshallLocation.QueryString);
            }
        }

        /// <summary>
        /// The input of the operation, a shape for a request structure
        /// </summary>
        public OperationInput Input
        {
            get
            {
                JsonData inputNode = this.data[ServiceModel.InputKey];
                if (inputNode == null)
                    return null;

                return new OperationInput(this.model, inputNode);
            }
        }

        public OperationAuthType? AuthType
        {
            get
            {
                return OperationAuthTypeParser.Parse(this.data[ServiceModel.AuthTypeKey]);
            }
        }

        /// <summary>
        /// The method of the operation (i.e. POST, GET, ...)
        /// </summary>
        public string HttpMethod
        {
            get
            {
                JsonData httpNode = this.data[ServiceModel.HttpKey];
                if (httpNode == null)
                    return string.Empty;

                JsonData methodNode = httpNode[ServiceModel.MethodKey];
                if (methodNode == null)
                    return string.Empty;

                return methodNode.ToString();
            }
        }

        /// <summary>
        /// The endpoint hostPrefix of the operation
        /// </summary>
        public string EndpointHostPrefix
        {
            get
            {
                JsonData endpointNode = this.data[ServiceModel.EndpointKey];
                if (endpointNode == null)
                    return string.Empty;
                                
                return endpointNode[ServiceModel.HostPrefixKey]?.ToString() ?? string.Empty;
            }
        }

        /// <summary>
        /// The endpointoperation flag marking if this is the operation to use for endpoint discovery.
        /// </summary>
        public bool IsEndpointOperation
        {
            get
            {
                return (bool)(this.data[ServiceModel.EndpointOperationKey] ?? false);
            }
        }

        /// <summary>
        /// The endpointdiscovery flag specifying if this operation is to use endpoint discovery.
        /// </summary>
        public bool EndpointDiscoveryEnabled
        {
            get
            {
                return this.data[ServiceModel.EndpointDiscoveryKey] != null ? true : false;
            }
        }

        /// <summary>
        /// The endpointdiscovery required flag specifying if this operation is required use endpoint discovery.
        /// </summary>
        public bool IsEndpointDiscoveryRequired
        {
            get
            {
                JsonData endpointDiscovery = this.data[ServiceModel.EndpointDiscoveryKey];
                if (endpointDiscovery == null)
                    return false;

                JsonData required = endpointDiscovery[ServiceModel.RequiredKey];
                if (required == null)
                    return false;

                if (required.IsBoolean)
                    return (bool)(required ?? false);
                return Convert.ToBoolean((string)required);
            }
        }

        /// <summary>
        /// Members that are marked with the "endpointdiscoveryid" = true trait
        /// </summary>
        public IList<Member> RequestEndpointDiscoveryIdMembers
        {
            get
            {
                if (this.RequestStructure == null)
                    return new List<Member>();
                                
                return this.RequestStructure.Members.Where(m => m.IsEndpointDiscoveryId && m.GetPrimitiveType() == "String").ToList();
            }
        }
                
        /// <summary>
        /// Determines if the structure has any members that are marked with the "endpointdiscoveryid" = true trait
        /// </summary>
        public bool RequestHasEndpointDiscoveryIdMembers
        {
            get
            {
                return (this.RequestEndpointDiscoveryIdMembers.Count > 0);
            }
        }

        /// <summary>
        /// Determines if there is an Operation member for the operation with the request structure marked with "endpointoperation" = true.
        /// </summary>
        public bool RequestHasOperationEndpointOperationMember
        {
            get
            {
                if (this.RequestStructure == null)
                    return false;

                return this.RequestStructure.Members.FirstOrDefault(m => m.PropertyName == "Operation") != null;
            }
        }

        /// <summary>
        /// Determines if there is an Identifiers member for the operation with the request structure marked with "endpointoperation" = true.
        /// </summary>
        public bool RequestHasIdentifiersEndpointOperationMember
        {
            get
            {
                if (this.RequestStructure == null)
                    return false;

                return this.RequestStructure.Members.FirstOrDefault(m => m.PropertyName == "Operation") != null;
            }
        }

        /// <summary>
        /// Returns the Request URI without any query parameters.
        /// </summary>
        public string RequestUri
        {
            get
            {
                return this.RequestUriRaw.Split(new char[] { '?' }, 2)[0];
            }
        }

        /// <summary>
        /// Returns the static query parameters which are specified in the RequestUri itself.
        /// Example : Cloud Search Domain's Search operation (/2013-01-01/search?format=sdk&pretty=true).
        /// </summary>
        public Dictionary<string, string> StaticQueryParameters
        {
            get
            {
                var queryParams = new Dictionary<string, string>();
                var segments = this.RequestUriRaw.Split(new char[] { '?' }, 2);
                if (segments.Count() > 1)
                {
                    var staticQueryParams = segments[1];
                    foreach (string s in staticQueryParams.Split('&', ';'))
                    {
                        string[] nameValuePair = s.Split(new char[] { '=' }, 2);
                        if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0)
                        {
                            queryParams.Add(nameValuePair[0], nameValuePair[1]);
                        }
                        else
                        {
                            queryParams.Add(nameValuePair[0], null);
                        }
                    }
                }

                return queryParams;
            }
        }

        private string RequestUriRaw
        {
            get
            {
                JsonData httpNode = this.data[ServiceModel.HttpKey];
                if (httpNode == null)
                    return string.Empty;

                JsonData requestUri = httpNode[ServiceModel.RequestUriKey];
                if (requestUri == null)
                    return string.Empty;

                return requestUri.ToString();
            }
        }

        /// <summary>
        /// The parent xml node for the response data coming back from the service.
        /// </summary>
        public string ResultWrapper
        {
            get
            {
                JsonData output = this.data[ServiceModel.OutputKey];
                if (output == null)
                    return string.Empty;

                JsonData wrapper = output[ServiceModel.ResultWrapperKey];
                if (wrapper == null)
                    return string.Empty;

                return wrapper.ToString();
            }
        }

        /// <summary>
        /// The list of errors that the service returns which will be turned into exceptions.
        /// </summary>
        public IList<ExceptionShape> Exceptions
        {
            get
            {
                var hashSet = new HashSet<ExceptionShape>();
                var errors = this.data[ServiceModel.ErrorsKey];
                if (errors != null && errors.IsArray)
                {
                    foreach (JsonData error in errors)
                    {
                        var extendsNode = error[ServiceModel.ShapeKey];
                        if (extendsNode == null)
                            continue;
                        var structure = this.model.FindShape(extendsNode.ToString());
                        hashSet.Add((ExceptionShape)structure);
                    }
                }

                return hashSet.OrderBy(x => x.Name).ToList();
            }
        }

        /// <summary>
        /// The structure of the request for the operation as a shape, used to generate the request object
        /// </summary>
        public Shape RequestStructure
        {
            get
            {
                var inputNode = this.data[ServiceModel.InputKey];
                if (inputNode == null)
                    return null;

                var structure = this.model.FindShape(inputNode[ServiceModel.ShapeKey].ToString());
                return structure;
            }
        }

        /// <summary>
        /// The shape of the response for the operation as a shape, used to generate the response object
        /// </summary>
        public Shape ResponseStructure
        {
            get
            {
                var outputNode = this.data[ServiceModel.OutputKey];
                if (outputNode == null)
                    return null;

                var structure = this.model.FindShape(outputNode[ServiceModel.ShapeKey].ToString());
                return structure;
            }
        }

        public bool InputOutputIsSameShape
        {
            get
            {
                // Only one can be true. If one of the input or output is not defined then the operation
                // uses the same shape for the input and output.
                if (this.data[ServiceModel.InputKey] == null ^ this.data[ServiceModel.OutputKey] == null)
                {
                    return true;
                }
                else if (this.RequestStructure == this.ResponseStructure)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// For Set to true when the service model specifies a shape that should be wrapped in a response. 
        /// ElastiCache CreateCacheCluster is an example of this.
        /// </summary>
        public bool IsResponseWrapped
        {
            get
            {
                var outputNode = this.data[ServiceModel.OutputKey];
                if (outputNode == null)
                    return false;

                var wrappedNode = outputNode[ServiceModel.WrapperKey];
                if (wrappedNode == null)
                    return false;

                return bool.Parse(wrappedNode.ToString());
            }
        }

        public IList<Example> Examples
        {
            get
            {
                var list = new List<Example>();
                var data = this.model.Customizations.GetExamples(this.name);
                foreach(JsonData example in data)
                {
                    list.Add(new Example(this.model, this.name, example));
                }
                return list;
            }
        }

        public bool HasExamples
        {
            get
            {
                return this.model.Customizations.GetExamples(this.Name).Count > 0;
            }
        }

        /// <summary>
        /// Determines if a given member should be treated as a greedy path, meaning
        /// that the resource path contains {MEMBER_NAME+} instead of simply {MEMBER_NAME}.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public string GetUriResourcePathTarget(Member member,out bool isGreedy)
        {
            var greedyPathResourcePathIdentifier = "{" + member.MarshallLocationName + "+}";
            var simplePathResourcePathIdentifier = "{" + member.MarshallLocationName + "}";
            isGreedy = this.RequestUri.IndexOf(greedyPathResourcePathIdentifier, StringComparison.Ordinal) >= 0;
            var isSimple = this.RequestUri.IndexOf(simplePathResourcePathIdentifier, StringComparison.Ordinal) >= 0;

            if (isGreedy && isSimple)
                throw new Exception(string.Format("Unexpected behavior/model, member {1} of operation {0} is both a simple and a greedy parameter", this.Name, member.PropertyName));
            else if (!isGreedy && !isSimple)
                throw new Exception(string.Format("Unexpected behavior/model, member {1} of operation {0} is neither a simple nor a greedy parameter", this.Name, member.PropertyName));
            else if (isGreedy)
                return greedyPathResourcePathIdentifier;
            else
                return simplePathResourcePathIdentifier;
        }

        /// <summary>
        /// Represents the operation as a string
        /// </summary>
        /// <returns>The name of the operation, customized if specified</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Returns any operation modifiers that have been set for this operation.
        /// </summary>
        public CustomizationsModel.OperationModifiers OperationModifiers
        {
            get { return this.model.Customizations.GetOperationModifiers(this.Name); }
        }

        public string RestAPIDocUrl
        {
            get {
                string serviceId = this.model.ServiceUid;
                if (!string.IsNullOrEmpty(serviceId))
                {
                    return string.Format(@"http://docs.aws.amazon.com/goto/WebAPI/{0}/{1}", serviceId, ShapeName);
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Paginators for an operation
        /// </summary>
        public OperationPaginatorConfig Paginators { get { return this._operationPaginatorConfig; } }

        /// <summary>
        /// Whether or not this operation has properly configured
        /// paginators based on provided json configuration
        /// </summary>
        public bool UnsupportedPaginatorConfig { get; set; }

        private static ConcurrentDictionary<string, bool> _checkedService = new ConcurrentDictionary<string, bool>();

        /// <summary>
        /// Gets list of static context parameters, used on operation to drive endpoint resolution
        /// </summary>
        public List<StaticContextParameter> StaticContextParameters
        {
            get
            {
                var result = new List<StaticContextParameter>();
                var parameters = data.SafeGet("staticContextParams");
                if (parameters != null)
                {
                    foreach (var param in parameters.GetMap())
                    {
                        result.Add(new StaticContextParameter
                        {
                            name = param.Key,
                            value = param.Value["value"]
                        });
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// Gets list of operation context parameters, used on operation to drive endpoint resolution
        /// </summary>
        public List<OperationContextParameter> OperationContextParameters
        {
            get
            {
                var result = new List<OperationContextParameter>();
                var parameters = data.SafeGet("operationContextParams");
                if (parameters != null)
                {
                    foreach (var param in parameters.GetMap())
                    {
                        result.Add(new OperationContextParameter
                        {
                            name = param.Key,
                            path = param.Value["path"].CastToString()
                        });
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// Determines if the payload shouldn't be signed.
        /// </summary>
        public bool UnsignedPayload
        {
            get
            {
                if (data[ServiceModel.UnsignedPayloadKey] != null && data[ServiceModel.UnsignedPayloadKey].IsBoolean)
                    return (bool)data[ServiceModel.UnsignedPayloadKey];

                return false;
            }
        }
        /// <summary>
        /// List of authentication schemes supported by this operation.
        /// </summary>
        public IEnumerable<string> AuthSchemes
        {
            get
            {
                var schemes = this.data[ServiceModel.AuthSchemeKey];
                if (schemes != null && schemes.IsArray)
                {
                    return schemes.Cast<JsonData>().Select(x => x.ToString());
                }

                // Not all service models have been updated to include the auth key yet, so we'll check
                // the auth type property as a fallback.
                if (AuthType != null && AuthType == OperationAuthType.None)
                {
                    return new List<string> { AuthenticationScheme.NoAuth };
                }

                return null;
            }
        }
    }
}
