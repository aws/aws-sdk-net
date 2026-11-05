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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateApi operation. Updates an Api resource.
    /// </summary>
    public partial class UpdateApiRequest : AmazonApiGatewayV2Request
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property ApiKeySelectionExpression. 
        /// <para>
        /// An API key selection expression. Supported only for WebSocket APIs. See <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-apikey-selection-expressions">API
        /// Key Selection Expressions</a>.
        /// </para>
        /// </summary>
        public string ApiKeySelectionExpression { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySelectionExpression property is set.
        /// </summary>
        internal bool IsSetApiKeySelectionExpression() => this.ApiKeySelectionExpression != null;

        /// <summary>
        /// Gets and sets the property CorsConfiguration. 
        /// <para>
        /// A CORS configuration. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public Cors CorsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CorsConfiguration property is set.
        /// </summary>
        internal bool IsSetCorsConfiguration() => this.CorsConfiguration != null;

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
        public string CredentialsArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsArn property is set.
        /// </summary>
        internal bool IsSetCredentialsArn() => this.CredentialsArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the API.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisableExecuteApiEndpoint. 
        /// <para>
        /// Specifies whether clients can invoke your API by using the default execute-api endpoint.
        /// By default, clients can invoke your API with the default https://{api_id}.execute-api.{region}.amazonaws.com
        /// endpoint. To require that clients use a custom domain name to invoke your API, disable
        /// the default endpoint.
        /// </para>
        /// </summary>
        public bool? DisableExecuteApiEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DisableExecuteApiEndpoint property is set.
        /// </summary>
        internal bool IsSetDisableExecuteApiEndpoint() => this.DisableExecuteApiEndpoint.HasValue;

        /// <summary>
        /// Gets and sets the property DisableSchemaValidation. 
        /// <para>
        /// Avoid validating models when creating a deployment. Supported only for WebSocket APIs.
        /// </para>
        /// </summary>
        public bool? DisableSchemaValidation { get; set; }

        /// <summary>
        /// Checks to see if the DisableSchemaValidation property is set.
        /// </summary>
        internal bool IsSetDisableSchemaValidation() => this.DisableSchemaValidation.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address types that can invoke your API or domain name.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the API.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RouteKey. 
        /// <para>
        /// This property is part of quick create. If not specified, the route created using quick
        /// create is kept. Otherwise, this value replaces the route key of the quick create route.
        /// Additional routes may still be added after the API is updated. Supported only for
        /// HTTP APIs.
        /// </para>
        /// </summary>
        public string RouteKey { get; set; }

        /// <summary>
        /// Checks to see if the RouteKey property is set.
        /// </summary>
        internal bool IsSetRouteKey() => this.RouteKey != null;

        /// <summary>
        /// Gets and sets the property RouteSelectionExpression. 
        /// <para>
        /// The route selection expression for the API. For HTTP APIs, the routeSelectionExpression
        /// must be ${request.method} ${request.path}. If not provided, this will be the default
        /// for HTTP APIs. This property is required for WebSocket APIs.
        /// </para>
        /// </summary>
        public string RouteSelectionExpression { get; set; }

        /// <summary>
        /// Checks to see if the RouteSelectionExpression property is set.
        /// </summary>
        internal bool IsSetRouteSelectionExpression() => this.RouteSelectionExpression != null;

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
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A version identifier for the API.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
