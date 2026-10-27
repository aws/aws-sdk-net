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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Container for the parameters to the ListAgreementCancellationRequests operation. Lists
    /// agreement cancellation requests available to you as a seller or buyer. Both sellers
    /// (proposers) and buyers (acceptors) can use this operation to find cancellation requests
    /// by specifying their party type and applying optional filters. <note> <para> <c>PartyType</c>
    /// is a required parameter. A <c>ValidationException</c> is returned if <c>PartyType</c>
    /// is not provided. </para> </note>
    /// </summary>
    public partial class ListAgreementCancellationRequestsRequest : AmazonMarketplaceAgreementRequest
    {
        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// An optional parameter to filter cancellation requests for a specific agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property AgreementType. 
        /// <para>
        /// An optional parameter to filter cancellation requests by agreement type (e.g., <c>PurchaseAgreement</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementType { get; set; }

        /// <summary>
        /// Checks to see if the AgreementType property is set.
        /// </summary>
        internal bool IsSetAgreementType() => this.AgreementType != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// An optional parameter to filter cancellation requests by catalog (e.g., <c>AWSMarketplace</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of cancellation requests to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start pagination.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PartyType. 
        /// <para>
        /// The party type for the cancellation requests. Required parameter. Use <c>Proposer</c>
        /// to list cancellation requests where you are the seller, or <c>Acceptor</c> to list
        /// cancellation requests where you are the buyer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string PartyType { get; set; }

        /// <summary>
        /// Checks to see if the PartyType property is set.
        /// </summary>
        internal bool IsSetPartyType() => this.PartyType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An optional parameter to filter cancellation requests by status.
        /// </para>
        /// </summary>
        public AgreementCancellationRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
