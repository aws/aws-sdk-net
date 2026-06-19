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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
        private string _amount;
        private string _contentPath;
        private Currency _currency;
        private string _intent;
        private string _network;
        private string _organization;
        private string _payerAddress;
        private string _requestId;
        private DateTime? _requestTimestamp;
        private string _sourceCategory;
        private string _sourceName;
        private SettlementStatus _status;
        private DateTime? _timestamp;
        private string _transactionId;
        private bool? _verified;
        private string _walletAddress;
        private string _webAclArn;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The payment amount in the specified currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the property ContentPath. 
        /// <para>
        /// The content path that was accessed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContentPath
        {
            get { return this._contentPath; }
            set { this._contentPath = value; }
        }

        // Check to see if ContentPath property is set
        internal bool IsSetContentPath()
        {
            return this._contentPath != null;
        }

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency of the payment amount.
        /// </para>
        /// </summary>
        public Currency Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The declared intent of the AI bot request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network on which the settlement occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Network
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
        /// Gets and sets the property Organization. 
        /// <para>
        /// The organization associated with the AI bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Organization
        {
            get { return this._organization; }
            set { this._organization = value; }
        }

        // Check to see if Organization property is set
        internal bool IsSetOrganization()
        {
            return this._organization != null;
        }

        /// <summary>
        /// Gets and sets the property PayerAddress. 
        /// <para>
        /// The blockchain wallet address of the paying AI agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PayerAddress
        {
            get { return this._payerAddress; }
            set { this._payerAddress = value; }
        }

        // Check to see if PayerAddress property is set
        internal bool IsSetPayerAddress()
        {
            return this._payerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The WAF request ID associated with this settlement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestTimestamp. 
        /// <para>
        /// The timestamp of the original web request.
        /// </para>
        /// </summary>
        public DateTime? RequestTimestamp
        {
            get { return this._requestTimestamp; }
            set { this._requestTimestamp = value; }
        }

        // Check to see if RequestTimestamp property is set
        internal bool IsSetRequestTimestamp()
        {
            return this._requestTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceCategory. 
        /// <para>
        /// The category of the AI bot source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SourceCategory
        {
            get { return this._sourceCategory; }
            set { this._sourceCategory = value; }
        }

        // Check to see if SourceCategory property is set
        internal bool IsSetSourceCategory()
        {
            return this._sourceCategory != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the AI bot that made the payment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

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
        [AWSProperty(Required=true)]
        public SettlementStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp when the settlement was recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The blockchain transaction identifier. You can use this to verify the transaction
        /// on a blockchain explorer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        /// Whether the AI bot's identity was verified.
        /// </para>
        /// </summary>
        public bool? Verified
        {
            get { return this._verified; }
            set { this._verified = value; }
        }

        // Check to see if Verified property is set
        internal bool IsSetVerified()
        {
            return this._verified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WalletAddress. 
        /// <para>
        /// Your receiving wallet address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The ARN of the web ACL that processed the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string WebAclArn
        {
            get { return this._webAclArn; }
            set { this._webAclArn = value; }
        }

        // Check to see if WebAclArn property is set
        internal bool IsSetWebAclArn()
        {
            return this._webAclArn != null;
        }

    }
}