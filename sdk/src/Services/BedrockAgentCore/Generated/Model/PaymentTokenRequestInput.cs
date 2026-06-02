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
    /// Vendor-specific token request configuration.
    /// </summary>
    public partial class PaymentTokenRequestInput
    {
        private CoinbaseCdpTokenRequestInput _coinbaseCdpTokenRequest;
        private StripePrivyTokenRequestInput _stripePrivyTokenRequest;

        /// <summary>
        /// Gets and sets the property CoinbaseCdpTokenRequest. 
        /// <para>
        /// The Coinbase CDP token request.
        /// </para>
        /// </summary>
        public CoinbaseCdpTokenRequestInput CoinbaseCdpTokenRequest
        {
            get { return this._coinbaseCdpTokenRequest; }
            set { this._coinbaseCdpTokenRequest = value; }
        }

        // Check to see if CoinbaseCdpTokenRequest property is set
        internal bool IsSetCoinbaseCdpTokenRequest()
        {
            return this._coinbaseCdpTokenRequest != null;
        }

        /// <summary>
        /// Gets and sets the property StripePrivyTokenRequest. 
        /// <para>
        /// The Stripe Privy token request.
        /// </para>
        /// </summary>
        public StripePrivyTokenRequestInput StripePrivyTokenRequest
        {
            get { return this._stripePrivyTokenRequest; }
            set { this._stripePrivyTokenRequest = value; }
        }

        // Check to see if StripePrivyTokenRequest property is set
        internal bool IsSetStripePrivyTokenRequest()
        {
            return this._stripePrivyTokenRequest != null;
        }

    }
}