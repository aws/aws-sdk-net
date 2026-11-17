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
    /// The decision of an approver who is identified by an email address.
    /// </summary>
    public partial class EmailApproverOutcome
    {
        /// <summary>
        /// Gets and sets the property ApproverOutcomeId. 
        /// <para>
        /// The unique identifier of this approver in the agreement approval. An administrator
        /// of the buyer's AWS organization passes it as <c>approverOutcomeIdToOverride</c> to
        /// decide on the approver's behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ApproverOutcomeId { get; set; }

        /// <summary>
        /// Checks to see if the ApproverOutcomeId property is set.
        /// </summary>
        internal bool IsSetApproverOutcomeId() => this.ApproverOutcomeId != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the approver.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the approver.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// The note that the approver provided with the decision.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

        /// <summary>
        /// Gets and sets the property OverriddenBy. 
        /// <para>
        /// The identity that decided on the approver's behalf. This field is empty unless an
        /// administrator of the buyer's AWS organization decided for the approver.
        /// </para>
        /// </summary>
        public CallerIdentity OverriddenBy { get; set; }

        /// <summary>
        /// Checks to see if the OverriddenBy property is set.
        /// </summary>
        internal bool IsSetOverriddenBy() => this.OverriddenBy != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrders. 
        /// <para>
        /// The purchase order references that the approver provided with the decision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 86)]
        public List<AgreementApprovalPurchaseOrder> PurchaseOrders { get; set; } = AWSConfigs.InitializeCollections ? new List<AgreementApprovalPurchaseOrder>() : null;

        /// <summary>
        /// Checks to see if the PurchaseOrders property is set.
        /// </summary>
        internal bool IsSetPurchaseOrders() => this.PurchaseOrders != null && (this.PurchaseOrders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The decision status of the approver. Possible values include <c>QUEUED</c>, <c>PENDING_APPROVAL</c>,
        /// <c>APPROVED</c>, <c>REJECTED</c>, <c>EXPIRED</c>, and <c>SKIPPED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApproverOutcomeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the decision was last updated.
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
