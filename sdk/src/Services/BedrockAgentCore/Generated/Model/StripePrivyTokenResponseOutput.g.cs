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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Stripe Privy token response containing appId, basicAuthToken, and optionally authorizationSignature.
    /// </summary>
    public partial class StripePrivyTokenResponseOutput
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The Privy app ID for the privy-app-id header.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property AuthorizationSignature. 
        /// <para>
        /// Base64-encoded ECDSA P-256 authorization signature (only present when includeAuthorizationSignature
        /// is true).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8192)]
        public string AuthorizationSignature { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationSignature property is set.
        /// </summary>
        internal bool IsSetAuthorizationSignature() => this.AuthorizationSignature != null;

        /// <summary>
        /// Gets and sets the property BasicAuthToken. 
        /// <para>
        /// Base64-encoded Basic Auth token (appId:appSecret) for the Authorization header.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 8192)]
        public string BasicAuthToken { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthToken property is set.
        /// </summary>
        internal bool IsSetBasicAuthToken() => this.BasicAuthToken != null;

        /// <summary>
        /// Gets and sets the property RequestExpiry. 
        /// <para>
        /// Unix timestamp in milliseconds when the authorization signature expires.
        /// </para>
        /// </summary>
        public long? RequestExpiry { get; set; }

        /// <summary>
        /// Checks to see if the RequestExpiry property is set.
        /// </summary>
        internal bool IsSetRequestExpiry() => this.RequestExpiry.HasValue;
    }
}
