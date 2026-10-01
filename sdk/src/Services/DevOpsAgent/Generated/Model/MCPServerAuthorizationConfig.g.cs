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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Authorization configuration options for MCP server, supporting OAuth, API key, bearer
    /// token, and authorization discovery methods.
    /// </summary>
    public partial class MCPServerAuthorizationConfig
    {
        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// MCP server configuration with API key authentication.
        /// </para>
        /// </summary>
        public MCPServerAPIKeyConfig ApiKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKey property is set.
        /// </summary>
        internal bool IsSetApiKey() => this.ApiKey != null;

        /// <summary>
        /// Gets and sets the property AuthorizationDiscovery. 
        /// <para>
        /// MCP server authorization discovery configuration.
        /// </para>
        /// </summary>
        public MCPServerAuthorizationDiscoveryConfig AuthorizationDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationDiscovery property is set.
        /// </summary>
        internal bool IsSetAuthorizationDiscovery() => this.AuthorizationDiscovery != null;

        /// <summary>
        /// Gets and sets the property BearerToken. 
        /// <para>
        /// MCP server configuration with Bearer token (RFC 6750).
        /// </para>
        /// </summary>
        public MCPServerBearerTokenConfig BearerToken { get; set; }

        /// <summary>
        /// Checks to see if the BearerToken property is set.
        /// </summary>
        internal bool IsSetBearerToken() => this.BearerToken != null;

        /// <summary>
        /// Gets and sets the property OAuth3LO. 
        /// <para>
        /// MCP server configuration with OAuth 3LO.
        /// </para>
        /// </summary>
        public MCPServerOAuth3LOConfig OAuth3LO { get; set; }

        /// <summary>
        /// Checks to see if the OAuth3LO property is set.
        /// </summary>
        internal bool IsSetOAuth3LO() => this.OAuth3LO != null;

        /// <summary>
        /// Gets and sets the property OAuthClientCredentials. 
        /// <para>
        /// MCP server configuration with OAuth client credentials.
        /// </para>
        /// </summary>
        public MCPServerOAuthClientCredentialsConfig OAuthClientCredentials { get; set; }

        /// <summary>
        /// Checks to see if the OAuthClientCredentials property is set.
        /// </summary>
        internal bool IsSetOAuthClientCredentials() => this.OAuthClientCredentials != null;
    }
}
