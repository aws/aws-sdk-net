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
    /// VENDOR-SPECIFIC TOKEN RESPONSE CONFIGURATION - Output
    /// </summary>
    public partial class PaymentTokenResponseOutput
    {
        private CoinbaseCdpTokenResponseOutput _coinbaseCdpTokenResponse;
        private StripePrivyTokenResponseOutput _stripePrivyTokenResponse;

        /// <summary>
        /// Gets and sets the property CoinbaseCdpTokenResponse.
        /// </summary>
        public CoinbaseCdpTokenResponseOutput CoinbaseCdpTokenResponse
        {
            get { return this._coinbaseCdpTokenResponse; }
            set { this._coinbaseCdpTokenResponse = value; }
        }

        // Check to see if CoinbaseCdpTokenResponse property is set
        internal bool IsSetCoinbaseCdpTokenResponse()
        {
            return this._coinbaseCdpTokenResponse != null;
        }

        /// <summary>
        /// Gets and sets the property StripePrivyTokenResponse.
        /// </summary>
        public StripePrivyTokenResponseOutput StripePrivyTokenResponse
        {
            get { return this._stripePrivyTokenResponse; }
            set { this._stripePrivyTokenResponse = value; }
        }

        // Check to see if StripePrivyTokenResponse property is set
        internal bool IsSetStripePrivyTokenResponse()
        {
            return this._stripePrivyTokenResponse != null;
        }

    }
}