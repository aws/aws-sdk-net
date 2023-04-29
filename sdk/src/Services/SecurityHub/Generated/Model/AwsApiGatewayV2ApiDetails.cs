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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about a version 2 API in Amazon API Gateway.
    /// </summary>
    public partial class AwsApiGatewayV2ApiDetails
    {
        private string _apiEndpoint;
        private string _apiId;
        private string _apiKeySelectionExpression;
        private AwsCorsConfiguration _corsConfiguration;
        private string _createdDate;
        private string _description;
        private string _name;
        private string _protocolType;
        private string _routeSelectionExpression;
        private string _version;

        /// <summary>
        /// Gets and sets the property ApiEndpoint. 
        /// <para>
        /// The URI of the API. 
        /// </para>
        ///  
        /// <para>
        /// Uses the format <code> <i>&lt;api-id&gt;</i>.execute-api.<i>&lt;region&gt;</i>.amazonaws.com</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The stage name is typically appended to the URI to form a complete path to a deployed
        /// API stage.
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
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The identifier of the API.
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
        /// An API key selection expression. Supported only for WebSocket APIs. 
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
        /// A cross-origin resource sharing (CORS) configuration. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public AwsCorsConfiguration CorsConfiguration
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
        /// Indicates when the API was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the API.
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
        /// The API protocol for the API.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>WEBSOCKET</code> | <code>HTTP</code> 
        /// </para>
        /// </summary>
        public string ProtocolType
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
        /// The route selection expression for the API.
        /// </para>
        ///  
        /// <para>
        /// For HTTP APIs, must be <code>${request.method} ${request.path}</code>. This is the
        /// default value for HTTP APIs.
        /// </para>
        ///  
        /// <para>
        /// For WebSocket APIs, there is no default value.
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version identifier for the API.
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