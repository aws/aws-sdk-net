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
    /// The approval decision for an agreement approval.
    /// </summary>
    public partial class BuyerAgreementApprovalApproverInput
    {
        /// <summary>
        /// Gets and sets the property AgreementApprovalId. 
        /// <para>
        /// The unique identifier of the agreement approval to approve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementApprovalId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementApprovalId property is set.
        /// </summary>
        internal bool IsSetAgreementApprovalId() => this.AgreementApprovalId != null;

        /// <summary>
        /// Gets and sets the property ApproverOutcomeIdToOverride. 
        /// <para>
        /// The <c>approverOutcomeId</c> of the approver to decide on behalf of. You must be the
        /// management account or a delegated administrator of your AWS organization to set this
        /// field. Use <c>GetAgreementApproval</c> to retrieve the <c>approverOutcomeId</c> of
        /// each approver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ApproverOutcomeIdToOverride { get; set; }

        /// <summary>
        /// Checks to see if the ApproverOutcomeIdToOverride property is set.
        /// </summary>
        internal bool IsSetApproverOutcomeIdToOverride() => this.ApproverOutcomeIdToOverride != null;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// An optional note that explains the decision (1-1000 characters).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrders. 
        /// <para>
        /// An optional list of purchase order references to associate with charges on the agreement
        /// request.
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
    }
}
