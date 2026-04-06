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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Container for the parameters to the ListAgreementPaymentRequests operation.
    /// Lists payment requests available to you as a seller or buyer. Both sellers (proposers)
    /// and buyers (acceptors) can use this operation to find payment requests by specifying
    /// their party type and applying optional parameters.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>PartyType</c> is a required parameter. A <c>ValidationException</c> is returned
    /// if <c>PartyType</c> is not provided. Pagination is supported through <c>maxResults</c>
    /// (1-50, default 50) and <c>nextToken</c> parameters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListAgreementPaymentRequestsRequest : AmazonMarketplaceAgreementRequest
    {
        private string _agreementId;
        private string _agreementType;
        private string _catalog;
        private int? _maxResults;
        private string _nextToken;
        private string _partyType;
        private PaymentRequestStatus _status;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// An optional parameter to list payment requests for a specific agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementType. 
        /// <para>
        /// An optional parameter to list payment requests by agreement type (e.g., <c>PurchaseAgreement</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementType
        {
            get { return this._agreementType; }
            set { this._agreementType = value; }
        }

        // Check to see if AgreementType property is set
        internal bool IsSetAgreementType()
        {
            return this._agreementType != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// An optional parameter to list payment requests by catalog (e.g., <c>AWSMarketplace</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of payment requests to return in a single response (1-50). Default
        /// is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start pagination. Use the <c>nextToken</c> value from
        /// a previous response to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PartyType. 
        /// <para>
        /// The party type for the payment requests. Required parameter. Use <c>Proposer</c> to
        /// list payment requests where you are the seller, or <c>Acceptor</c> to list payment
        /// requests where you are the buyer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string PartyType
        {
            get { return this._partyType; }
            set { this._partyType = value; }
        }

        // Check to see if PartyType property is set
        internal bool IsSetPartyType()
        {
            return this._partyType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An optional parameter to list payment requests by status. Valid values include <c>VALIDATING</c>,
        /// <c>VALIDATION_FAILED</c>, <c>PENDING_APPROVAL</c>, <c>APPROVED</c>, <c>REJECTED</c>,
        /// and <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public PaymentRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}