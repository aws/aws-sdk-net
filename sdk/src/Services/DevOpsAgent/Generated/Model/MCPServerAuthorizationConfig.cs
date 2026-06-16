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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Authorization configuration options for MCP server, supporting OAuth, API key, bearer
    /// token, and authorization discovery methods.
    /// </summary>
    public partial class MCPServerAuthorizationConfig
    {
        private MCPServerAPIKeyConfig _apiKey;
        private MCPServerAuthorizationDiscoveryConfig _authorizationDiscovery;
        private MCPServerBearerTokenConfig _bearerToken;
        private MCPServerOAuth3LOConfig _oAuth3LO;
        private MCPServerOAuthClientCredentialsConfig _oAuthClientCredentials;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// MCP server configuration with API key authentication.
        /// </para>
        /// </summary>
        public MCPServerAPIKeyConfig ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationDiscovery. 
        /// <para>
        /// MCP server authorization discovery configuration.
        /// </para>
        /// </summary>
        public MCPServerAuthorizationDiscoveryConfig AuthorizationDiscovery
        {
            get { return this._authorizationDiscovery; }
            set { this._authorizationDiscovery = value; }
        }

        // Check to see if AuthorizationDiscovery property is set
        internal bool IsSetAuthorizationDiscovery()
        {
            return this._authorizationDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property BearerToken. 
        /// <para>
        /// MCP server configuration with Bearer token (RFC 6750).
        /// </para>
        /// </summary>
        public MCPServerBearerTokenConfig BearerToken
        {
            get { return this._bearerToken; }
            set { this._bearerToken = value; }
        }

        // Check to see if BearerToken property is set
        internal bool IsSetBearerToken()
        {
            return this._bearerToken != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth3LO. 
        /// <para>
        /// MCP server configuration with OAuth 3LO.
        /// </para>
        /// </summary>
        public MCPServerOAuth3LOConfig OAuth3LO
        {
            get { return this._oAuth3LO; }
            set { this._oAuth3LO = value; }
        }

        // Check to see if OAuth3LO property is set
        internal bool IsSetOAuth3LO()
        {
            return this._oAuth3LO != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthClientCredentials. 
        /// <para>
        /// MCP server configuration with OAuth client credentials.
        /// </para>
        /// </summary>
        public MCPServerOAuthClientCredentialsConfig OAuthClientCredentials
        {
            get { return this._oAuthClientCredentials; }
            set { this._oAuthClientCredentials = value; }
        }

        // Check to see if OAuthClientCredentials property is set
        internal bool IsSetOAuthClientCredentials()
        {
            return this._oAuthClientCredentials != null;
        }

    }
}