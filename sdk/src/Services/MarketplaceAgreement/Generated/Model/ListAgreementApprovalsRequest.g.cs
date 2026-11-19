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
    /// Container for the parameters to the ListAgreementApprovals operation. Lists agreement
    /// approvals available to you as a buyer. Use <c>REQUESTER</c> as the <c>partyType</c>
    /// to list the agreement approvals that your account started. Use <c>AWS_ORGANIZATION_ADMIN</c>
    /// to list the agreement approvals in your AWS organization, if your account is the management
    /// account or a delegated administrator of the organization. You can filter the results
    /// by agreement request, approval type, and status.
    /// </summary>
    public partial class ListAgreementApprovalsRequest : AmazonMarketplaceAgreementRequest
    {
        /// <summary>
        /// Gets and sets the property AgreementRequestId. 
        /// <para>
        /// An optional parameter to filter agreement approvals for a specific agreement request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementRequestId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementRequestId property is set.
        /// </summary>
        internal bool IsSetAgreementRequestId() => this.AgreementRequestId != null;

        /// <summary>
        /// Gets and sets the property ApprovalType. 
        /// <para>
        /// An optional parameter to filter agreement approvals by type. The only valid value
        /// is <c>BUYER_AGREEMENT_APPROVAL</c>.
        /// </para>
        /// </summary>
        public AgreementApprovalType ApprovalType { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalType property is set.
        /// </summary>
        internal bool IsSetApprovalType() => this.ApprovalType != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// An optional parameter to filter agreement approvals by catalog (for example, <c>AWSMarketplace</c>).
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
        /// The maximum number of agreement approvals to return in a single response (1-50). Default
        /// is 20.
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
        /// The party type for the agreement approvals. Required parameter. Use <c>REQUESTER</c>
        /// to list agreement approvals for agreement requests that you created, or <c>AWS_ORGANIZATION_ADMIN</c>
        /// to list agreement approvals as an AWS Organizations administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgreementApprovalPartyType PartyType { get; set; }

        /// <summary>
        /// Checks to see if the PartyType property is set.
        /// </summary>
        internal bool IsSetPartyType() => this.PartyType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An optional parameter to filter agreement approvals by status. Valid values include
        /// <c>PENDING_APPROVAL</c>, <c>APPROVED</c>, <c>REJECTED</c>, <c>EXPIRED</c>, and <c>CANCELLED</c>.
        /// If you don't specify a status, agreement approvals of all statuses are returned.
        /// </para>
        /// </summary>
        public AgreementApprovalStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
