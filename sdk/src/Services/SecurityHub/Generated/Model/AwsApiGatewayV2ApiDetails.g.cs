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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about a version 2 API in Amazon API Gateway.
    /// </summary>
    public partial class AwsApiGatewayV2ApiDetails
    {
        /// <summary>
        /// Gets and sets the property ApiEndpoint. 
        /// <para>
        /// The URI of the API. 
        /// </para>
        ///  
        /// <para>
        /// Uses the format <c> <i>&lt;api-id&gt;</i>.execute-api.<i>&lt;region&gt;</i>.amazonaws.com</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The stage name is typically appended to the URI to form a complete path to a deployed
        /// API stage.
        /// </para>
        /// </summary>
        public string ApiEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ApiEndpoint property is set.
        /// </summary>
        internal bool IsSetApiEndpoint() => this.ApiEndpoint != null;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The identifier of the API.
        /// </para>
        /// </summary>
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property ApiKeySelectionExpression. 
        /// <para>
        /// An API key selection expression. Supported only for WebSocket APIs. 
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
        /// A cross-origin resource sharing (CORS) configuration. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public AwsCorsConfiguration CorsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CorsConfiguration property is set.
        /// </summary>
        internal bool IsSetCorsConfiguration() => this.CorsConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Indicates when the API was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the API.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The API protocol for the API.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>WEBSOCKET</c> | <c>HTTP</c> 
        /// </para>
        /// </summary>
        public string ProtocolType { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolType property is set.
        /// </summary>
        internal bool IsSetProtocolType() => this.ProtocolType != null;

        /// <summary>
        /// Gets and sets the property RouteSelectionExpression. 
        /// <para>
        /// The route selection expression for the API.
        /// </para>
        ///  
        /// <para>
        /// For HTTP APIs, must be <c>${request.method} ${request.path}</c>. This is the default
        /// value for HTTP APIs.
        /// </para>
        ///  
        /// <para>
        /// For WebSocket APIs, there is no default value.
        /// </para>
        /// </summary>
        public string RouteSelectionExpression { get; set; }

        /// <summary>
        /// Checks to see if the RouteSelectionExpression property is set.
        /// </summary>
        internal bool IsSetRouteSelectionExpression() => this.RouteSelectionExpression != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version identifier for the API.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
