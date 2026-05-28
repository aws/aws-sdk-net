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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
        private string _appId;
        private string _authorizationSignature;
        private string _basicAuthToken;
        private long? _requestExpiry;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The Privy app ID for the privy-app-id header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationSignature. 
        /// <para>
        /// Base64-encoded ECDSA P-256 authorization signature (only present when includeAuthorizationSignature
        /// is true).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8192)]
        public string AuthorizationSignature
        {
            get { return this._authorizationSignature; }
            set { this._authorizationSignature = value; }
        }

        // Check to see if AuthorizationSignature property is set
        internal bool IsSetAuthorizationSignature()
        {
            return this._authorizationSignature != null;
        }

        /// <summary>
        /// Gets and sets the property BasicAuthToken. 
        /// <para>
        /// Base64-encoded Basic Auth token (appId:appSecret) for the Authorization header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=8192)]
        public string BasicAuthToken
        {
            get { return this._basicAuthToken; }
            set { this._basicAuthToken = value; }
        }

        // Check to see if BasicAuthToken property is set
        internal bool IsSetBasicAuthToken()
        {
            return this._basicAuthToken != null;
        }

        /// <summary>
        /// Gets and sets the property RequestExpiry. 
        /// <para>
        /// Unix timestamp in milliseconds when the authorization signature expires.
        /// </para>
        /// </summary>
        public long? RequestExpiry
        {
            get { return this._requestExpiry; }
            set { this._requestExpiry = value; }
        }

        // Check to see if RequestExpiry property is set
        internal bool IsSetRequestExpiry()
        {
            return this._requestExpiry.HasValue; 
        }

    }
}