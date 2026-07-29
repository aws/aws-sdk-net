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
    /// Authorization configuration for remote A2A agents with token-based auth (API key,
    /// OAuth, bearer token).
    /// </summary>
    public partial class RemoteAgentAuthorizationConfig
    {
        private RemoteAgentAPIKeyConfig _apiKey;
        private RemoteAgentBearerTokenConfig _bearerToken;
        private RemoteAgentOAuthClientCredentialsConfig _oAuthClientCredentials;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// Remote agent configuration with API key authentication.
        /// </para>
        /// </summary>
        public RemoteAgentAPIKeyConfig ApiKey
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
        /// Gets and sets the property BearerToken. 
        /// <para>
        /// Remote agent configuration with Bearer token (RFC 6750).
        /// </para>
        /// </summary>
        public RemoteAgentBearerTokenConfig BearerToken
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
        /// Gets and sets the property OAuthClientCredentials. 
        /// <para>
        /// Remote agent configuration with OAuth client credentials.
        /// </para>
        /// </summary>
        public RemoteAgentOAuthClientCredentialsConfig OAuthClientCredentials
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