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
    /// Summary view of an agreement approval.
    /// </summary>
    public partial class AgreementApprovalSummary
    {
        /// <summary>
        /// Gets and sets the property AgreementApprovalId. 
        /// <para>
        /// The unique identifier of the agreement approval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementApprovalId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementApprovalId property is set.
        /// </summary>
        internal bool IsSetAgreementApprovalId() => this.AgreementApprovalId != null;

        /// <summary>
        /// Gets and sets the property AgreementRequestId. 
        /// <para>
        /// The unique identifier of the agreement request that the agreement approval is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementRequestId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementRequestId property is set.
        /// </summary>
        internal bool IsSetAgreementRequestId() => this.AgreementRequestId != null;

        /// <summary>
        /// Gets and sets the property ApprovalNeededBy. 
        /// <para>
        /// The date and time by which the agreement approval must be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ApprovalNeededBy { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalNeededBy property is set.
        /// </summary>
        internal bool IsSetApprovalNeededBy() => this.ApprovalNeededBy.HasValue;

        /// <summary>
        /// Gets and sets the property ApprovalType. 
        /// <para>
        /// The type of the agreement approval. The only value is <c>BUYER_AGREEMENT_APPROVAL</c>,
        /// an approval that the buyer's organization requires before the agreement request can
        /// be accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgreementApprovalType ApprovalType { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalType property is set.
        /// </summary>
        internal bool IsSetApprovalType() => this.ApprovalType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the agreement approval was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time when the agreement approval expires if it isn't approved or rejected.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the agreement approval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time when approvers could start acting on the agreement approval.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the agreement approval. Possible values include <c>PENDING_APPROVAL</c>,
        /// <c>APPROVED</c>, <c>REJECTED</c>, <c>EXPIRED</c>, and <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgreementApprovalStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the agreement approval was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
