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
    /// The monetization configuration for a web ACL or rule group. Specifies the payment
    /// settlement options (self-managed crypto wallets in <c>CryptoConfig</c>, a connected
    /// account in <c>ConnectedAccountConfigs</c>, or both) and the currency mode for artificial
    /// intelligence (AI) bot monetization. You must provide this configuration when any rule
    /// in the web ACL or rule group uses the <c>Monetize</c> action.
    /// </summary>
    public partial class MonetizationConfig
    {
        /// <summary>
        /// Gets and sets the property ConnectedAccountConfigs. 
        /// <para>
        /// The connected account configurations for settling AI bot payments through a connected
        /// account with a supported third-party payment provider (Stripe), as an alternative
        /// to the self-managed wallets in <c>CryptoConfig</c>. You can provide <c>CryptoConfig</c>,
        /// <c>ConnectedAccountConfigs</c>, or both; however, a given blockchain network (chain)
        /// can be used by only one of them. Currently supports exactly one connected account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<ConnectedAccountConfig> ConnectedAccountConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectedAccountConfig>() : null;

        /// <summary>
        /// Checks to see if the ConnectedAccountConfigs property is set.
        /// </summary>
        internal bool IsSetConnectedAccountConfigs() => this.ConnectedAccountConfigs != null && (this.ConnectedAccountConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CryptoConfig. 
        /// <para>
        /// The cryptocurrency payment configuration, including the blockchain networks and wallet
        /// addresses where you receive payments.
        /// </para>
        /// </summary>
        public CryptoConfig CryptoConfig { get; set; }

        /// <summary>
        /// Checks to see if the CryptoConfig property is set.
        /// </summary>
        internal bool IsSetCryptoConfig() => this.CryptoConfig != null;

        /// <summary>
        /// Gets and sets the property CurrencyMode. 
        /// <para>
        /// Specifies whether the configuration uses real or test currency. If not specified,
        /// defaults to <c>REAL</c>. Connected account configurations support production settlement
        /// only; <c>TEST</c> is not supported when <c>ConnectedAccountConfigs</c> is present.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REAL</c> - Settle payments in USDC on production blockchain networks (Base, Solana).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEST</c> - Settle on testnet networks (Base Sepolia, Solana Devnet) with tokens
        /// that have no monetary value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CurrencyMode CurrencyMode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyMode property is set.
        /// </summary>
        internal bool IsSetCurrencyMode() => this.CurrencyMode != null;
    }
}
