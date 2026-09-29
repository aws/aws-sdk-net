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
    /// Embedded crypto wallet instrument details.
    /// </summary>
    public partial class EmbeddedCryptoWallet
    {
        /// <summary>
        /// Gets and sets the property LinkedAccounts. 
        /// <para>
        /// List of linked accounts linked to this wallet. Each represents a way the end user
        /// can authenticate to this wallet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 1)]
        public List<LinkedAccount> LinkedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<LinkedAccount>() : null;

        /// <summary>
        /// Checks to see if the LinkedAccounts property is set.
        /// </summary>
        internal bool IsSetLinkedAccounts() => this.LinkedAccounts != null && (this.LinkedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network for this embedded crypto wallet. Supported networks: ETHEREUM,
        /// SOLANA.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CryptoWalletNetwork Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// URL for the end user to complete a provider-specific action such as wallet linking
        /// or onboarding.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUrl property is set.
        /// </summary>
        internal bool IsSetRedirectUrl() => this.RedirectUrl != null;

        /// <summary>
        /// Gets and sets the property WalletAddress. 
        /// <para>
        /// The wallet address on the specified blockchain network.
        /// </para>
        /// </summary>
        public string WalletAddress { get; set; }

        /// <summary>
        /// Checks to see if the WalletAddress property is set.
        /// </summary>
        internal bool IsSetWalletAddress() => this.WalletAddress != null;
    }
}
