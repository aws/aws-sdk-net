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
    /// StripePrivy token request parameters
    /// </summary>
    public partial class StripePrivyTokenRequestInput
    {
        private bool? _includeAuthorizationSignature;
        private string _requestBody;
        private string _requestHost;
        private string _requestPath;

        /// <summary>
        /// Gets and sets the property IncludeAuthorizationSignature. 
        /// <para>
        /// Set to true to generate privy-authorization-signature
        /// </para>
        /// </summary>
        public bool? IncludeAuthorizationSignature
        {
            get { return this._includeAuthorizationSignature; }
            set { this._includeAuthorizationSignature = value; }
        }

        // Check to see if IncludeAuthorizationSignature property is set
        internal bool IsSetIncludeAuthorizationSignature()
        {
            return this._includeAuthorizationSignature.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// Request body JSON for the Privy API call
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=16384)]
        public string RequestBody
        {
            get { return this._requestBody; }
            set { this._requestBody = value; }
        }

        // Check to see if RequestBody property is set
        internal bool IsSetRequestBody()
        {
            return this._requestBody != null;
        }

        /// <summary>
        /// Gets and sets the property RequestHost. 
        /// <para>
        /// Optional - defaults to &quot;api.privy.io&quot;
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RequestHost
        {
            get { return this._requestHost; }
            set { this._requestHost = value; }
        }

        // Check to see if RequestHost property is set
        internal bool IsSetRequestHost()
        {
            return this._requestHost != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPath. 
        /// <para>
        /// The path of the Stripe Privy API request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RequestPath
        {
            get { return this._requestPath; }
            set { this._requestPath = value; }
        }

        // Check to see if RequestPath property is set
        internal bool IsSetRequestPath()
        {
            return this._requestPath != null;
        }

    }
}