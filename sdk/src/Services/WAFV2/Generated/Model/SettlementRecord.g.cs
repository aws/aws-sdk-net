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
    /// A single settlement transaction record for AI bot monetization. Contains details about
    /// the payment including timestamp, amount, status, and the parties involved.
    /// </summary>
    public partial class SettlementRecord
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The payment amount in the specified currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property ContentPath. 
        /// <para>
        /// The content path that was accessed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContentPath { get; set; }

        /// <summary>
        /// Checks to see if the ContentPath property is set.
        /// </summary>
        internal bool IsSetContentPath() => this.ContentPath != null;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency of the payment amount.
        /// </para>
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The declared intent of the AI bot request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Intent { get; set; }

        /// <summary>
        /// Checks to see if the Intent property is set.
        /// </summary>
        internal bool IsSetIntent() => this.Intent != null;

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network on which the settlement occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The organization associated with the AI bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property PayerAddress. 
        /// <para>
        /// The blockchain wallet address of the paying AI agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PayerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PayerAddress property is set.
        /// </summary>
        internal bool IsSetPayerAddress() => this.PayerAddress != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The WAF request ID associated with this settlement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property RequestTimestamp. 
        /// <para>
        /// The timestamp of the original web request.
        /// </para>
        /// </summary>
        public DateTime? RequestTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RequestTimestamp property is set.
        /// </summary>
        internal bool IsSetRequestTimestamp() => this.RequestTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SourceCategory. 
        /// <para>
        /// The category of the AI bot source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// Checks to see if the SourceCategory property is set.
        /// </summary>
        internal bool IsSetSourceCategory() => this.SourceCategory != null;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the AI bot that made the payment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the settlement. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SETTLED</c> - The payment was successfully settled on the blockchain and the transfer
        /// from the payer's wallet to the publisher's wallet is confirmed. The <c>TransactionId</c>
        /// field contains the on-chain transaction hash. Content is served to the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - The blockchain transaction has been submitted but not yet confirmed
        /// on-chain. This is a transient state that automatically resolves to either <c>SETTLED</c>
        /// or <c>FAILED</c>. No action is required. While pending, content is not served and
        /// the API returns a 402 response. Clients can retry the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The payment settlement was attempted but failed. Possible causes
        /// include insufficient funds, an expired payment authorization, or a reverted blockchain
        /// transaction. The <c>failureReason</c> field contains a machine-readable error code.
        /// Content is not served.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE_ERROR</c> - Settlement could not be completed due to an internal service
        /// issue or an issue with the payment network. Content is not served. The client's payment
        /// authorization remains valid and the request can be retried.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIPPED_ORIGIN_ERROR</c> - The origin returned a non-2xx response, so settlement
        /// was intentionally skipped. The client is not charged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUPLICATE</c> - A prior request with the same payment payload has already been
        /// settled. This status typically appears when a previous attempt timed out but the payment
        /// was ultimately processed. The client is not charged again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SettlementStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp when the settlement was recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The blockchain transaction identifier. You can use this to verify the transaction
        /// on a blockchain explorer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        /// Whether the AI bot's identity was verified.
        /// </para>
        /// </summary>
        public bool? Verified { get; set; }

        /// <summary>
        /// Checks to see if the Verified property is set.
        /// </summary>
        internal bool IsSetVerified() => this.Verified.HasValue;

        /// <summary>
        /// Gets and sets the property WalletAddress. 
        /// <para>
        /// Your receiving wallet address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string WalletAddress { get; set; }

        /// <summary>
        /// Checks to see if the WalletAddress property is set.
        /// </summary>
        internal bool IsSetWalletAddress() => this.WalletAddress != null;

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The ARN of the web ACL that processed the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;
    }
}
