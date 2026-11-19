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
    /// A connected account configuration for AI bot monetization. Specifies the connected
    /// account that payments settle to and the per-network pricing. Settlement through a
    /// connected account is an alternative to the self-managed wallets in <c>CryptoConfig</c>;
    /// wallet addresses are managed for the connected account rather than configured by you.
    /// If the referenced connected account is not active or not enabled for crypto settlement,
    /// the <c>CreateWebACL</c>, <c>UpdateWebACL</c>, <c>CreateRuleGroup</c>, or <c>UpdateRuleGroup</c>
    /// request that includes it is rejected. Specifically, a request that references the
    /// account is rejected with <c>WAFInvalidOperationException</c> if the account or its
    /// crypto settlement capability isn't active, <c>WAFNonexistentItemException</c> if the
    /// ARN no longer exists, <c>AccessDeniedException</c> if you don't have <c>payments:GetConnectedAccount</c>,
    /// or <c>WAFInvalidParameterException</c> if the ARN is invalid or the partition is unsupported.
    /// Connected accounts are available only in the commercial Amazon Web Services partition.
    /// </summary>
    public partial class ConnectedAccountConfig
    {
        /// <summary>
        /// Gets and sets the property ConnectedAccountArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connected account that payments settle to. You
        /// obtain this ARN from Payment preferences > Connected accounts in the Amazon Web Services
        /// Billing and Cost Management console. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-connected-accounts.html">Managing
        /// connected accounts</a>. The connected account must be active and enabled for crypto
        /// settlement; otherwise the request is rejected. To use a connected account, you must
        /// have the <c>payments:GetConnectedAccount</c> permission on this ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 56, Max = 140)]
        public string ConnectedAccountArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedAccountArn property is set.
        /// </summary>
        internal bool IsSetConnectedAccountArn() => this.ConnectedAccountArn != null;

        /// <summary>
        /// Gets and sets the property PaymentNetworks. 
        /// <para>
        /// The per-network configurations for the connected account. You can specify 1 to 2 networks.
        /// Each entry specifies a blockchain network and the price for each request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<ConnectedAccountChainConfig> PaymentNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectedAccountChainConfig>() : null;

        /// <summary>
        /// Checks to see if the PaymentNetworks property is set.
        /// </summary>
        internal bool IsSetPaymentNetworks() => this.PaymentNetworks != null && (this.PaymentNetworks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
