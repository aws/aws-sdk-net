using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Json.LitJson;
using System.Globalization;
using ServiceClientGenerator.Endpoints;

namespace ServiceClientGenerator
{
    /// <summary>
    /// The service model represents the information of a service found through the manifest, model, and customization file.
    /// It is used to get any information necessary to generate the clients, operations, and structures of a service.
    /// </summary>
    public class ServiceModel
    {
        // metadata properties
        public const string MetadataKey = "metadata";
        public const string ApiVersionKey = "apiVersion";
        public const string EndpointPrefixKey = "endpointPrefix";
        public const string JsonVersionKey = "jsonVersion";
        public const string ProtocolKey = "protocol";
        public const string ProtocolSettingsKey = "protocolSettings";
        public const string ProtocolSettingsH2Key = "h2";
        public const string ServiceFullNameKey = "serviceFullName";
        public const string SignatureVersionKey = "signatureVersion";
        public const string TargetPrefixKey = "targetPrefix";
        public const string UidKey = "uid";
        public const string ServiceAbbreviationKey = "serviceAbbreviation";
        public const string SigningNameKey = "signingName";
        public const string ServiceIdKey = "serviceId";
        public const string AWSQueryCompatibleKey = "awsQueryCompatible";

        // operations
        public const string OperationsKey = "operations";
        public const string HttpKey = "http";
        public const string MethodKey = "method";
        public const string RequestUriKey = "requestUri";
        public const string InputKey = "input";
        public const string OutputKey = "output";
        public const string ErrorsKey = "errors";
        public const string ResultWrapperKey = "resultWrapper";
        public const string AuthTypeKey = "authtype";
        public const string EndpointKey = "endpoint";
        public const string HostPrefixKey = "hostPrefix";
        public const string EndpointOperationKey = "endpointoperation";
        public const string EndpointDiscoveryKey = "endpointdiscovery";
        public const string RequiredKey = "required";
        public const string HttpChecksumRequiredKey = "httpChecksumRequired";
        public const string HttpChecksumKey = "httpChecksum";
        public const string RequestChecksumRequiredKey = "requestChecksumRequired";
        public const string RequestAlgorithmMemberKey = "requestAlgorithmMember";
        public const string RequestValidationModeMemberKey = "requestValidationModeMember";
        public const string ResponseAlgorithmsKey = "responseAlgorithms";

        // shapes
        public const string ShapesKey = "shapes";
        public const string ShapeKey = "shape";
        public const string IdempotencyTokenKey = "idempotencyToken";
        public const string DeprecatedKey = "deprecated";
        public const string DeprecatedMessageKey = "deprecatedMessage";
        public const string WrapperKey = "wrapper";
        public const string LocationNameKey = "locationName";
        public const string QueryNameKey = "queryName";
        public const string XmlNamespaceUriKey = "uri";
        public const string XmlNamespaceKey = "xmlNamespace";
        public const string EndpointDiscoveryIdKey = "endpointdiscoveryid";

        // pagination
        public const string PaginationKey = "pagination";
        public const string ResultKeyKey = "result_key";
        public const string InputTokenKey = "input_token";
        public const string OutputTokenKey = "output_token";
        public const string LimitKeyKey = "limit_key";
        public const string MoreResultsKey = "more_results";

        // documentation
        public const string DocumentationKey = "documentation";

        // client context params
        public const string ClientContextParams = "clientContextParams";

        /// <summary>
        /// This model contains information about customizations needed during the generation process
        /// </summary>
        readonly CustomizationsModel _customizationModel;

        /// <summary>
        /// The information found as a property at the top of the model structure which contains information on how to generate the service
        /// </summary>
        JsonData _metadata;

        /// <summary>
        /// This is the entire model document for the service processed as a json object
        /// </summary>
        internal JsonData DocumentRoot;

        /// <summary>
        /// This is the paginators for the service processed as a json object
        /// </summary>
        internal JsonData PaginatorsRoot;

        /// <summary>
        /// Used for unit testing, creates a service model from a TextReader so that the generation can be checked
        /// </summary>
        /// <param name="serviceModelReader">The reader to get the model information from</param>
        /// <param name="customizationReader">The reader to get any customizations for the service from</param>
        public ServiceModel(TextReader serviceModelReader, TextReader customizationReader)
        {
            InitializeServiceModel(serviceModelReader);
            this._customizationModel = new CustomizationsModel(customizationReader);
        }

        /// <summary>
        /// Used by the generator to create a model for the service being generated
        /// </summary>
        /// <param name="serviceModelPath">Path to the file containing the model of the service</param>
        /// <param name="customizationModelPath">Path to the customizations file for the service</param>
        public ServiceModel(string serviceModelPath, string customizationModelPath)
        {
            using (var reader = new StreamReader(serviceModelPath))
                InitializeServiceModel(reader);

            this._customizationModel = new CustomizationsModel(customizationModelPath);
        }

        /// <summary>
        /// Used by the generator to create a model for the service being generated
        /// </summary>
        /// <param name="serviceModelPath">Path to the file containing the model of the service</param>
        /// <param name="customizationModelPath">Path to the customizations file for the service</param>
        /// /// <param name="servicePaginatorsPath">Path to the customizations file for the service</param>
        public ServiceModel(string serviceModelPath, string customizationModelPath, string servicePaginatorsPath)
        {
            using (var reader = new StreamReader(serviceModelPath))
            {
                InitializeServiceModel(reader);
            }
            if (File.Exists(servicePaginatorsPath))
            {
                using (var reader = new StreamReader(servicePaginatorsPath))
                    InitializePaginators(reader);
            }
            this._customizationModel = new CustomizationsModel(customizationModelPath);
        }

        /// <summary>
        /// Sets the base json info no matter how the model was constructed
        /// </summary>
        /// <param name="reader">The reader to pull the model json from</param>
        private void InitializeServiceModel(TextReader reader)
        {
            this.DocumentRoot = JsonMapper.ToObject(reader);
            this._metadata = this.DocumentRoot[MetadataKey];
        }

        /// <summary>
        /// Sets the base json info no matter how the model was constructed
        /// </summary>
        /// <param name="reader">The reader to pull the model json from</param>
        private void InitializePaginators(TextReader reader)
        {
            this.PaginatorsRoot = JsonMapper.ToObject(reader);
        }

        /// <summary>
        /// Indicates that this service was converted from query to json 1.0
        /// and may be sending AWSQuery compatible error code data in header.
        /// </summary>
        public bool IsAwsQueryCompatible
        {
            get
            {
                return this._metadata.PropertyNames.Contains(AWSQueryCompatibleKey);
            }
        }

        /// <summary>
        /// Whether or not this service has paginators available
        /// for any operation
        /// </summary>
        public bool HasPaginators { get; private set; } = false;

        /// <summary>
        /// The customization model for the service
        /// </summary>
        public CustomizationsModel Customizations
        {
            get { return this._customizationModel; }
        }

        public ServiceModel ParentModel { get; set; }

        /// <summary>
        /// Provides the targetPrefix if it is set in the metadata.
        /// Target prefix is defined so that the target can be set in the header of the request
        /// </summary>
        public string TargetPrefix
        {
            get { return this._metadata[TargetPrefixKey] == null ? "" : this._metadata[TargetPrefixKey].ToString(); }
        }

        /// <summary>
        /// The json version as defined in the metadata, used to determine the content type header
        /// </summary>
        public string JsonVersion
        {
            get
            {
                var version = this._metadata[JsonVersionKey] == null ? "" : this._metadata[JsonVersionKey].ToString();
                if (version == "1")
                    version = "1.0";
                return version;
            }
        }

        /// <summary>
        /// Unique Service ID.  For models without this entry, this may return null;
        /// </summary>
        public string ServiceUid
        {
            get
            {
                return this._metadata[UidKey] == null ? null : this._metadata[UidKey].ToString();
            }
        }

        /// <summary>
        /// Used to determine the signer version to use, important in generating signatures for the client
        /// </summary>
        public string SignatureVersion
        {
            get
            {
                var version = this._metadata[SignatureVersionKey] == null ? "" : this._metadata[SignatureVersionKey].ToString();
                return version;
            }
        }

        /// <summary>
        /// Determines what service type the model uses, found in the metadata
        /// </summary>
        public ServiceType Type
        {
            get
            {
                var serviceType = Protocol;
                if (serviceType.Equals("rest-xml", StringComparison.InvariantCulture))
                {
                    serviceType = "rest_xml";
                }
                else if (serviceType.Equals("rest-json", StringComparison.InvariantCulture))
                {
                    serviceType = "rest_json";
                }
                else if (serviceType.Equals("ec2", StringComparison.InvariantCulture))
                {
                    serviceType = "query";
                }

                ServiceType value;
                if (!Enum.TryParse<ServiceType>(serviceType, true, out value))
                {
                    throw new Exception("Unknown service type: " + serviceType);
                }

                return value;
            }
        }

        public string Protocol
        {
            get { return this._metadata[ProtocolKey] == null ? "" : this._metadata[ProtocolKey].ToString(); }
        }

        public JsonData ProtocolSettings => _metadata[ProtocolSettingsKey];

        public H2SupportDegree H2Support => Enum.TryParse<H2SupportDegree>(ProtocolSettings?[ProtocolSettingsH2Key]?.ToString(), true, out var specifiedH2Degree)
            ? specifiedH2Degree 
            : H2SupportDegree.None;

        public bool IsEC2Protocol
        {
            get { return Protocol.Equals("ec2", StringComparison.OrdinalIgnoreCase); }    
        }

        /// <summary>
        /// The information about the service found as the value for the documentation property of the json model
        /// </summary>
        public string Documentation
        {
            get
            {
                var docNode = this.DocumentRoot[DocumentationKey];
                if (docNode == null)
                    return string.Empty;
                return docNode.ToString();
            }

        }

        /// <summary>
        /// Returns the abbreviation name of a service
        /// </summary>
        public string ServiceAbbreviation
        {
            get { return Utils.JsonDataToString(this._metadata[ServiceAbbreviationKey]); }
        }

        /// <summary>
        /// Returns the public name of a service
        /// </summary>
        public string ServiceFullName
        {
            get { return Utils.JsonDataToString(this._metadata[ServiceFullNameKey]); }
        }

        /// <summary>
        /// Returns the endpoint prefix of a service
        /// </summary>
        public string EndpointPrefix
        {
            get { return Utils.JsonDataToString(this._metadata[EndpointPrefixKey]); }
        }

        /// <summary>
        /// Returns the signing name of a service
        /// </summary>
        public string SigningName
        {
            get { return Utils.JsonDataToString(this._metadata[SigningNameKey]); }
        }

        /// <summary>
        /// Returns the Service Id of a service
        /// </summary>
        public string ServiceId
        {
            get
            {
                return Utils.JsonDataToString(this._metadata[ServiceIdKey]);
            }
        }

        /// <summary>
        /// Gets the operation information based on the name of the operation
        /// </summary>
        /// <param name="name">The name of the operation that information is needed for</param>
        /// <returns>An Operation object that contains details about the operation requested</returns>
        public Operation FindOperation(string name)
        {
            return this.Operations.FirstOrDefault(x => x.Name == name);
        }

        /// <summary>
        /// Gets the operation marked endpointoperation if one exists
        /// </summary>        
        /// <returns>An Operation object that contains details about the operation requested</returns>
        public Operation FindEndpointOperation()
        {
            return this.Operations.FirstOrDefault(x => x.IsEndpointOperation);
        }

        /// <summary>
        /// The operations available through the service api found in the model.
        /// These operation objects contain the necessary information to construct the required operation structures for the API
        /// </summary>
        public List<Operation> Operations
        {
            get
            {
                var list = new List<Operation>();
                foreach (KeyValuePair<string, JsonData> kvp in DocumentRoot[OperationsKey])
                {
                    Operation operation;
                    if (this.PaginatorsRoot != null && this.PaginatorsRoot[PaginationKey][kvp.Key] != null)
                    {
                        operation = new Operation(this, kvp.Key,
                            kvp.Value, this.PaginatorsRoot[PaginationKey][kvp.Key]);
                        if (operation.Paginators != null && !operation.UnsupportedPaginatorConfig)
                        {
                            this.HasPaginators = true;
                        }
                    } 
                    else
                    {
                        operation = new Operation(this, kvp.Key, kvp.Value);
                    }
                    if (operation.IsExcluded)
                    {
                        ExcludedOperations.Add(operation.Name);
                    }
                    // Event Streams are not supported (yet)
                    else if (H2Support == H2SupportDegree.EventStream && operation.IsEventStreamOutput)
                    {
                        ExcludedOperations.Add(operation.Name);
                    }
                    else
                    {
                        list.Add(operation);
                    }
                }
                return list.OrderBy(x => x.Name).ToList();
            }
        }

        public IDictionary<string, string> OperationsNameMapping
        {
            get
            {
                var mapping = new Dictionary<string, string>();
                foreach (KeyValuePair<string, JsonData> kvp in DocumentRoot[OperationsKey])
                {
                    var operation = new Operation(this, kvp.Key, kvp.Value);
                    if (operation.ShapeName != operation.Name)
                    {
                        mapping.Add(operation.Name, operation.ShapeName);
                    }
                }
                return mapping;
            }
        }

        public IEnumerable<ExceptionShape> Exceptions
        {
            get
            {
                var exceptions = new List<ExceptionShape>();
                foreach (var operation in this.Operations)
                {
                    foreach (var exception in operation.Exceptions)
                    {
                        if (exceptions.All(e => !e.Name.Equals(exception.Name)))
                            exceptions.Add(exception);
                    }
                }
                
                return exceptions;
            }
        }

        readonly HashSet<string> _excludedOperations = new HashSet<string>();

        public HashSet<string> ExcludedOperations
        {
            get { return _excludedOperations; }
        }

        /// <summary>
        /// Returns all the shapes that are of type structure.
        /// </summary>
        public IEnumerable<Shape> Structures
        {
            get
            {
                var list = new List<Shape>();
                foreach (KeyValuePair<string, JsonData> kvp in DocumentRoot[ShapesKey])
                {
                    var type = kvp.Value["type"];
                    if (type != null && type.ToString() == "structure")
                        list.Add(Shape.CreateShape(this, kvp.Key, kvp.Value));
                }
                return list.OrderBy(x => x.Name).ToList();
            }
        }

        /// <summary>
        /// Returns all the shapes.
        /// </summary>
        public IEnumerable<Shape> Shapes
        {
            get
            {
                var list = new List<Shape>();
                foreach (KeyValuePair<string, JsonData> kvp in DocumentRoot[ShapesKey])
                {
                    list.Add(Shape.CreateShape(this, kvp.Key, kvp.Value));
                }
                return list.OrderBy(x => x.Name).ToList();
            }
        }

        /// <summary>
        /// Returns list of enums defined in the service model.
        /// </summary>
        /// <param name="includeParentEnums">Includes enums from current service model, which are also
        /// defined in the parent model.</param>
        /// <returns></returns>
        public IEnumerable<Enumeration> Enumerations(bool includeParentEnums)
        {
            var list = new List<Enumeration>();
            foreach (KeyValuePair<string, JsonData> kvp in DocumentRoot[ShapesKey])
            {
                var type = kvp.Value["type"];
                if (type != null && type.ToString() == "string" && kvp.Value["enum"] != null)
                    list.Add(new Enumeration(this, kvp.Key, kvp.Value));
            }
            list = list.OrderBy(x => x.Name).ToList();

            if (includeParentEnums || this.ParentModel == null)
            {
                return list;
            }
            else
            {
                // Remove enums already defined in the parent model                
                return list.Where(e => ParentModel.Enumerations(true).All(en => !e.ModelName.Equals(en.ModelName)));
            }         
        }

        /// <summary>
        /// Search the model for shape.
        /// </summary>
        /// <param name="name">The name of the shape to search for</param>
        /// <returns>A shape object with information about the shape that was searched for</returns>
        public Shape FindShape(string name)
        {
            var shapes = this.DocumentRoot[ShapesKey];
            var shape = shapes[name];

            return Shape.CreateShape(this, name, shape);
        }

        /// <summary>
        /// Gets list of client context parameters, 
        /// used to extend client config with new properties and drive endpoint resolution
        /// </summary>
        public List<ClientContextParameter> ClientContextParameters
        {
            get
            {
                var result = new List<ClientContextParameter>();
                var parameters = DocumentRoot.SafeGet(ClientContextParams);
                if (parameters == null)
                {
                    return result;
                }

                foreach(var param in parameters.GetMap())
                {
                    // Skip S3/S3 Control-specific parameters as we already
                    // have custom definitions for them in client config.
                    if ((ServiceId == "S3" || ServiceId == "S3 Control") && (
                        param.Key == "UseArnRegion" ||
                        param.Key == "DisableMultiRegionAccessPoints" ||
                        param.Key == "Accelerate" ||
                        param.Key == "ForcePathStyle"))
                    {
                        continue;
                    }

                    result.Add(new ClientContextParameter 
                    { 
                        name = param.Key, 
                        documentation = param.Value.SafeGetString("documentation"), 
                        type = param.Value.SafeGetString("type") 
                    });
                }
                return result;
            }
        }

        /// <summary>
        /// A value retrieved from the json model that is included in service requests
        /// </summary>
        public string APIVersion
        {
            get { return this.DocumentRoot[MetadataKey][ApiVersionKey].ToString(); }
        }

        /// <summary>
        /// The service model represented as a string
        /// </summary>
        /// <returns>Format: targetPrefix - APIVersion</returns>
        public override string ToString()
        {
            return string.Format("{0} - {1}", TargetPrefix, APIVersion);
        }
    }
}
