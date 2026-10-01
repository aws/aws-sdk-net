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
    /// Coinbase CDP token request parameters.
    /// </summary>
    public partial class CoinbaseCdpTokenRequestInput
    {
        /// <summary>
        /// Gets and sets the property IncludeWalletAuthToken. 
        /// <para>
        /// Set to true for wallet write operations (requires walletSecret configured).
        /// </para>
        /// </summary>
        public bool? IncludeWalletAuthToken { get; set; }

        /// <summary>
        /// Checks to see if the IncludeWalletAuthToken property is set.
        /// </summary>
        internal bool IsSetIncludeWalletAuthToken() => this.IncludeWalletAuthToken.HasValue;

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// Request body JSON — used to generate wallet auth JWT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string RequestBody { get; set; }

        /// <summary>
        /// Checks to see if the RequestBody property is set.
        /// </summary>
        internal bool IsSetRequestBody() => this.RequestBody != null;

        /// <summary>
        /// Gets and sets the property RequestHost. 
        /// <para>
        /// The host for the payment API request. Defaults to "api.cdp.coinbase.com".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RequestHost { get; set; }

        /// <summary>
        /// Checks to see if the RequestHost property is set.
        /// </summary>
        internal bool IsSetRequestHost() => this.RequestHost != null;

        /// <summary>
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// The HTTP method for the payment API request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentHttpMethodType RequestMethod { get; set; }

        /// <summary>
        /// Checks to see if the RequestMethod property is set.
        /// </summary>
        internal bool IsSetRequestMethod() => this.RequestMethod != null;

        /// <summary>
        /// Gets and sets the property RequestPath. 
        /// <para>
        /// The path of the payment API request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RequestPath { get; set; }

        /// <summary>
        /// Checks to see if the RequestPath property is set.
        /// </summary>
        internal bool IsSetRequestPath() => this.RequestPath != null;
    }
}
