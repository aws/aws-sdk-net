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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// OAuth2-specific authorization data, including the authorization URL and user identifier
    /// for the authorization session.
    /// </summary>
    public partial class OAuth2AuthorizationData
    {
        /// <summary>
        /// Gets and sets the property AuthorizationUrl. 
        /// <para>
        /// The URL to initiate the authorization process. This URL is provided when the OAuth2
        /// access token requires user authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationUrl property is set.
        /// </summary>
        internal bool IsSetAuthorizationUrl() => this.AuthorizationUrl != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user identifier associated with the OAuth2 authorization session that is defined
        /// by AgentCore Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
