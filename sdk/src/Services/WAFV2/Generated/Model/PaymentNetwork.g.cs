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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A blockchain payment network configuration for receiving AI bot monetization payments.
    /// Specifies the blockchain chain, your wallet address on that chain, and the price per
    /// request.
    /// </summary>
    public partial class PaymentNetwork
    {
        /// <summary>
        /// Gets and sets the property Chain. 
        /// <para>
        /// The blockchain network for receiving payments. Production networks: <c>BASE</c> (Base
        /// mainnet), <c>SOLANA</c> (Solana mainnet). Test networks: <c>BASE_SEPOLIA</c> (Base
        /// Sepolia testnet), <c>SOLANA_DEVNET</c> (Solana Devnet).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BlockchainChain Chain { get; set; }

        /// <summary>
        /// Checks to see if the Chain property is set.
        /// </summary>
        internal bool IsSetChain() => this.Chain != null;

        /// <summary>
        /// Gets and sets the property Prices. 
        /// <para>
        /// The price configuration for this payment network. Currently supports a single price
        /// entry in USDC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<Price> Prices { get; set; } = AWSConfigs.InitializeCollections ? new List<Price>() : null;

        /// <summary>
        /// Checks to see if the Prices property is set.
        /// </summary>
        internal bool IsSetPrices() => this.Prices != null && (this.Prices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WalletAddress. 
        /// <para>
        /// Your wallet address on the specified blockchain where payments are sent. For EVM chains
        /// (Base, Base Sepolia), provide a valid Ethereum address (42 characters including 0x
        /// prefix). For Solana chains, provide a valid Base58-encoded public key (32-44 characters).
        /// </para>
        ///  
        /// <para>
        /// For EVM addresses, WAF performs EIP-55 checksum validation for typo detection when
        /// the address uses a mix of lower and upper case letters. You can bypass this validation
        /// by providing the address in all lowercase or all uppercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 26, Max = 44)]
        public string WalletAddress { get; set; }

        /// <summary>
        /// Checks to see if the WalletAddress property is set.
        /// </summary>
        internal bool IsSetWalletAddress() => this.WalletAddress != null;
    }
}
