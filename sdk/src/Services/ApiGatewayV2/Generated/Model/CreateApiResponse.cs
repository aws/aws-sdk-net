/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the CreateApi operation.
    /// </summary>
    public partial class CreateApiResponse : AmazonWebServiceResponse
    {
        private string _apiEndpoint;
        private bool? _apiGatewayManaged;
        private string _apiId;
        private string _apiKeySelectionExpression;
        private Cors _corsConfiguration;
        private DateTime? _createdDate;
        private string _description;
        private bool? _disableExecuteApiEndpoint;
        private bool? _disableSchemaValidation;
        private List<string> _importInfo = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IpAddressType _ipAddressType;
        private string _name;
        private ProtocolType _protocolType;
        private string _routeSelectionExpression;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _version;
        private List<string> _warnings = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ApiEndpoint. 
        /// <para>
        /// The URI of the API, of the form {api-id}.execute-api.{region}.amazonaws.com. The stage
        /// name is typically appended to this URI to form a complete path to a deployed API stage.
        /// </para>
        /// </summary>
        public string ApiEndpoint
        {
            get { return this._apiEndpoint; }
            set { this._apiEndpoint = value; }
        }

        // Check to see if ApiEndpoint property is set
        internal bool IsSetApiEndpoint()
        {
            return this._apiEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ApiGatewayManaged. 
        /// <para>
        /// Specifies whether an API is managed by API Gateway. You can't update or delete a managed
        /// API by using API Gateway. A managed API can be deleted only through the tooling or
        /// service that created it.
        /// </para>
        /// </summary>
        public bool? ApiGatewayManaged
        {
            get { return this._apiGatewayManaged; }
            set { this._apiGatewayManaged = value; }
        }

        // Check to see if ApiGatewayManaged property is set
        internal bool IsSetApiGatewayManaged()
        {
            return this._apiGatewayManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeySelectionExpression. 
        /// <para>
        /// An API key selection expression. Supported only for WebSocket APIs. See <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-apikey-selection-expressions">API
        /// Key Selection Expressions</a>.
        /// </para>
        /// </summary>
        public string ApiKeySelectionExpression
        {
            get { return this._apiKeySelectionExpression; }
            set { this._apiKeySelectionExpression = value; }
        }

        // Check to see if ApiKeySelectionExpression property is set
        internal bool IsSetApiKeySelectionExpression()
        {
            return this._apiKeySelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property CorsConfiguration. 
        /// <para>
        /// A CORS configuration. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public Cors CorsConfiguration
        {
            get { return this._corsConfiguration; }
            set { this._corsConfiguration = value; }
        }

        // Check to see if CorsConfiguration property is set
        internal bool IsSetCorsConfiguration()
        {
            return this._corsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the API was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the API.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisableExecuteApiEndpoint. 
        /// <para>
        /// Specifies whether clients can invoke your API by using the default execute-api endpoint.
        /// By default, clients can invoke your API with the default https://{api_id}.execute-api.{region}.amazonaws.com
        /// endpoint. To require that clients use a custom domain name to invoke your API, disable
        /// the default endpoint.
        /// </para>
        /// </summary>
        public bool? DisableExecuteApiEndpoint
        {
            get { return this._disableExecuteApiEndpoint; }
            set { this._disableExecuteApiEndpoint = value; }
        }

        // Check to see if DisableExecuteApiEndpoint property is set
        internal bool IsSetDisableExecuteApiEndpoint()
        {
            return this._disableExecuteApiEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisableSchemaValidation. 
        /// <para>
        /// Avoid validating models when creating a deployment. Supported only for WebSocket APIs.
        /// </para>
        /// </summary>
        public bool? DisableSchemaValidation
        {
            get { return this._disableSchemaValidation; }
            set { this._disableSchemaValidation = value; }
        }

        // Check to see if DisableSchemaValidation property is set
        internal bool IsSetDisableSchemaValidation()
        {
            return this._disableSchemaValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportInfo. 
        /// <para>
        /// The validation information during API import. This may include particular properties
        /// of your OpenAPI definition which are ignored during import. Supported only for HTTP
        /// APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImportInfo
        {
            get { return this._importInfo; }
            set { this._importInfo = value; }
        }

        // Check to see if ImportInfo property is set
        internal bool IsSetImportInfo()
        {
            return this._importInfo != null && (this._importInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address types that can invoke the API.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The API protocol.
        /// </para>
        /// </summary>
        public ProtocolType ProtocolType
        {
            get { return this._protocolType; }
            set { this._protocolType = value; }
        }

        // Check to see if ProtocolType property is set
        internal bool IsSetProtocolType()
        {
            return this._protocolType != null;
        }

        /// <summary>
        /// Gets and sets the property RouteSelectionExpression. 
        /// <para>
        /// The route selection expression for the API. For HTTP APIs, the routeSelectionExpression
        /// must be ${request.method} ${request.path}. If not provided, this will be the default
        /// for HTTP APIs. This property is required for WebSocket APIs.
        /// </para>
        /// </summary>
        public string RouteSelectionExpression
        {
            get { return this._routeSelectionExpression; }
            set { this._routeSelectionExpression = value; }
        }

        // Check to see if RouteSelectionExpression property is set
        internal bool IsSetRouteSelectionExpression()
        {
            return this._routeSelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of tags associated with the API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A version identifier for the API.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// The warning messages reported when failonwarnings is turned on during API import.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}