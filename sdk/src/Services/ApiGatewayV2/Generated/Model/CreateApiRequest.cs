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
    /// Container for the parameters to the CreateApi operation.
    /// Creates an Api resource.
    /// </summary>
    public partial class CreateApiRequest : AmazonApiGatewayV2Request
    {
        private string _apiKeySelectionExpression;
        private Cors _corsConfiguration;
        private string _credentialsArn;
        private string _description;
        private bool? _disableExecuteApiEndpoint;
        private bool? _disableSchemaValidation;
        private IpAddressType _ipAddressType;
        private string _name;
        private ProtocolType _protocolType;
        private string _routeKey;
        private string _routeSelectionExpression;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _target;
        private string _version;

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
        /// A CORS configuration. Supported only for HTTP APIs. See <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-cors.html">Configuring
        /// CORS</a> for more information.
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
        /// Gets and sets the property CredentialsArn. 
        /// <para>
        /// This property is part of quick create. It specifies the credentials required for the
        /// integration, if any. For a Lambda integration, three options are available. To specify
        /// an IAM Role for API Gateway to assume, use the role's Amazon Resource Name (ARN).
        /// To require that the caller's identity be passed through from the request, specify
        /// arn:aws:iam::*:user/*. To use resource-based permissions on supported AWS services,
        /// specify null. Currently, this property is not used for HTTP integrations. Supported
        /// only for HTTP APIs.
        /// </para>
        /// </summary>
        public string CredentialsArn
        {
            get { return this._credentialsArn; }
            set { this._credentialsArn = value; }
        }

        // Check to see if CredentialsArn property is set
        internal bool IsSetCredentialsArn()
        {
            return this._credentialsArn != null;
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RouteKey. 
        /// <para>
        /// This property is part of quick create. If you don't specify a routeKey, a default
        /// route of $default is created. The $default route acts as a catch-all for any request
        /// made to your API, for a particular stage. The $default route key can't be modified.
        /// You can add routes after creating the API, and you can update the route keys of additional
        /// routes. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public string RouteKey
        {
            get { return this._routeKey; }
            set { this._routeKey = value; }
        }

        // Check to see if RouteKey property is set
        internal bool IsSetRouteKey()
        {
            return this._routeKey != null;
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
        /// The collection of tags. Each tag element is associated with a given resource.
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
        /// Gets and sets the property Target. 
        /// <para>
        /// This property is part of quick create. Quick create produces an API with an integration,
        /// a default catch-all route, and a default stage which is configured to automatically
        /// deploy changes. For HTTP integrations, specify a fully qualified URL. For Lambda integrations,
        /// specify a function ARN. The type of the integration will be HTTP_PROXY or AWS_PROXY,
        /// respectively. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
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

    }
}