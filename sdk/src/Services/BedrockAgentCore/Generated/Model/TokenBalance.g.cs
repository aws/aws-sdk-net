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
    /// A single token balance entry.
    /// </summary>
    public partial class TokenBalance
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// Raw balance in the smallest denomination (e.g., USDC base units where 1 USDC = 1000000).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property Chain. 
        /// <para>
        /// The specific blockchain chain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BlockchainChainId Chain { get; set; }

        /// <summary>
        /// Checks to see if the Chain property is set.
        /// </summary>
        internal bool IsSetChain() => this.Chain != null;

        /// <summary>
        /// Gets and sets the property Decimals. 
        /// <para>
        /// Number of decimal places for the token (e.g., 6 for USDC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Decimals { get; set; }

        /// <summary>
        /// Checks to see if the Decimals property is set.
        /// </summary>
        internal bool IsSetDecimals() => this.Decimals.HasValue;

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network family (ETHEREUM or SOLANA).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CryptoWalletNetwork Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The supported token for this balance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstrumentBalanceToken Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;
    }
}
