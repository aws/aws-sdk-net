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
    /// Container for the parameters to the UpdateApi operation.
    /// Updates an Api resource.
    /// </summary>
    public partial class UpdateApiRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _apiKeySelectionExpression;
        private Cors _corsConfiguration;
        private string _credentialsArn;
        private string _description;
        private bool? _disableExecuteApiEndpoint;
        private bool? _disableSchemaValidation;
        private IpAddressType _ipAddressType;
        private string _name;
        private string _routeKey;
        private string _routeSelectionExpression;
        private string _target;
        private string _version;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CredentialsArn. 
        /// <para>
        /// This property is part of quick create. It specifies the credentials required for the
        /// integration, if any. For a Lambda integration, three options are available. To specify
        /// an IAM Role for API Gateway to assume, use the role's Amazon Resource Name (ARN).
        /// To require that the caller's identity be passed through from the request, specify
        /// arn:aws:iam::*:user/*. To use resource-based permissions on supported AWS services,
        /// don't specify this parameter. Currently, this property is not used for HTTP integrations.
        /// If provided, this value replaces the credentials associated with the quick create
        /// integration. Supported only for HTTP APIs.
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
        /// The IP address types that can invoke your API or domain name.
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
        /// Gets and sets the property RouteKey. 
        /// <para>
        /// This property is part of quick create. If not specified, the route created using quick
        /// create is kept. Otherwise, this value replaces the route key of the quick create route.
        /// Additional routes may still be added after the API is updated. Supported only for
        /// HTTP APIs.
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
        /// Gets and sets the property Target. 
        /// <para>
        /// This property is part of quick create. For HTTP integrations, specify a fully qualified
        /// URL. For Lambda integrations, specify a function ARN. The type of the integration
        /// will be HTTP_PROXY or AWS_PROXY, respectively. The value provided updates the integration
        /// URI and integration type. You can update a quick-created target, but you can't remove
        /// it from an API. Supported only for HTTP APIs.
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