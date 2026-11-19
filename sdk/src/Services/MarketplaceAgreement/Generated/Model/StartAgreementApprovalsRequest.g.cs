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
    /// Container for the parameters to the StartAgreementApprovals operation. Allows buyers
    /// (acceptors) to start the approvals that their organization requires for an agreement
    /// request. You start one agreement approval for each approval plan that you specify.
    /// Use <c>GetAgreementRequestApprovalPlans</c> to retrieve the approval plans of the
    /// agreement request. Once the agreement approvals start, the agreement request transitions
    /// to <c>PENDING_APPROVAL</c> status.
    /// </summary>
    public partial class StartAgreementApprovalsRequest : AmazonMarketplaceAgreementRequest
    {
        /// <summary>
        /// Gets and sets the property AgreementRequestId. 
        /// <para>
        /// The unique identifier of the agreement request to start approvals for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgreementRequestId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementRequestId property is set.
        /// </summary>
        internal bool IsSetAgreementRequestId() => this.AgreementRequestId != null;

        /// <summary>
        /// Gets and sets the property PlanInputs. 
        /// <para>
        /// The approval plans to start agreement approvals for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<AgreementApprovalPlanInput> PlanInputs { get; set; } = AWSConfigs.InitializeCollections ? new List<AgreementApprovalPlanInput>() : null;

        /// <summary>
        /// Checks to see if the PlanInputs property is set.
        /// </summary>
        internal bool IsSetPlanInputs() => this.PlanInputs != null && (this.PlanInputs.Count > 0 || !AWSConfigs.InitializeCollections);

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
