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
    /// Embedded Crypto wallet instrument details
    /// </summary>
    public partial class EmbeddedCryptoWallet
    {
        private List<LinkedAccount> _linkedAccounts = AWSConfigs.InitializeCollections ? new List<LinkedAccount>() : null;
        private CryptoWalletNetwork _network;
        private string _redirectUrl;
        private string _walletAddress;

        /// <summary>
        /// Gets and sets the property LinkedAccounts. 
        /// <para>
        /// List of linkedAccounts linked to this wallet. Each linkedAccount represents a way
        /// the end user can authenticate to this wallet. Can be empty when adding a new linkedAccount
        /// to an existing wallet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<LinkedAccount> LinkedAccounts
        {
            get { return this._linkedAccounts; }
            set { this._linkedAccounts = value; }
        }

        // Check to see if LinkedAccounts property is set
        internal bool IsSetLinkedAccounts()
        {
            return this._linkedAccounts != null && (this._linkedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network for this embedded crypto wallet. Supported networks: ETHEREUM,
        /// SOLANA
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CryptoWalletNetwork Network
        {
            get { return this._network; }
            set { this._network = value; }
        }

        // Check to see if Network property is set
        internal bool IsSetNetwork()
        {
            return this._network != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// URL for the end user to complete a provider-specific action (e.g., wallet linking,
        /// onboarding). Returned by the payment connector during instrument creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RedirectUrl
        {
            get { return this._redirectUrl; }
            set { this._redirectUrl = value; }
        }

        // Check to see if RedirectUrl property is set
        internal bool IsSetRedirectUrl()
        {
            return this._redirectUrl != null;
        }

        /// <summary>
        /// Gets and sets the property WalletAddress. 
        /// <para>
        /// The wallet address on the specified blockchain network.
        /// </para>
        /// </summary>
        public string WalletAddress
        {
            get { return this._walletAddress; }
            set { this._walletAddress = value; }
        }

        // Check to see if WalletAddress property is set
        internal bool IsSetWalletAddress()
        {
            return this._walletAddress != null;
        }

    }
}