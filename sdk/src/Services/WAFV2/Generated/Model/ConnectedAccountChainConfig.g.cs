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
    /// A per-network configuration for a connected account, specifying the blockchain network
    /// and the price per request. Unlike <c>PaymentNetwork</c>, you do not provide a wallet
    /// address; the receiving address is managed for the connected account.
    /// </summary>
    public partial class ConnectedAccountChainConfig
    {
        /// <summary>
        /// Gets and sets the property Chain. 
        /// <para>
        /// The blockchain network for receiving payments through the connected account. Test
        /// networks are not supported for connected accounts.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BASE</c> - Base mainnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SOLANA</c> - Solana mainnet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectedAccountChain Chain { get; set; }

        /// <summary>
        /// Checks to see if the Chain property is set.
        /// </summary>
        internal bool IsSetChain() => this.Chain != null;

        /// <summary>
        /// Gets and sets the property Prices. 
        /// <para>
        /// The price configuration for this network. Currently supports a single price entry
        /// in USDC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<ConnectedAccountPrice> Prices { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectedAccountPrice>() : null;

        /// <summary>
        /// Checks to see if the Prices property is set.
        /// </summary>
        internal bool IsSetPrices() => this.Prices != null && (this.Prices.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
