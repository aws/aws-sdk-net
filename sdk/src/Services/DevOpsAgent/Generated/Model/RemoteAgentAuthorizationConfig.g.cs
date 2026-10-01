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
    /// Authorization configuration for remote A2A agents with token-based auth (API key,
    /// OAuth, bearer token).
    /// </summary>
    public partial class RemoteAgentAuthorizationConfig
    {
        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// Remote agent configuration with API key authentication.
        /// </para>
        /// </summary>
        public RemoteAgentAPIKeyConfig ApiKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKey property is set.
        /// </summary>
        internal bool IsSetApiKey() => this.ApiKey != null;

        /// <summary>
        /// Gets and sets the property BearerToken. 
        /// <para>
        /// Remote agent configuration with Bearer token (RFC 6750).
        /// </para>
        /// </summary>
        public RemoteAgentBearerTokenConfig BearerToken { get; set; }

        /// <summary>
        /// Checks to see if the BearerToken property is set.
        /// </summary>
        internal bool IsSetBearerToken() => this.BearerToken != null;

        /// <summary>
        /// Gets and sets the property OAuthClientCredentials. 
        /// <para>
        /// Remote agent configuration with OAuth client credentials.
        /// </para>
        /// </summary>
        public RemoteAgentOAuthClientCredentialsConfig OAuthClientCredentials { get; set; }

        /// <summary>
        /// Checks to see if the OAuthClientCredentials property is set.
        /// </summary>
        internal bool IsSetOAuthClientCredentials() => this.OAuthClientCredentials != null;
    }
}
