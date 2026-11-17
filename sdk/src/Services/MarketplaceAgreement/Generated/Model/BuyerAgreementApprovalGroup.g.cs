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
    /// A group of approvers, the number of approvals the group requires, and the decision
    /// of each approver.
    /// </summary>
    public partial class BuyerAgreementApprovalGroup
    {
        /// <summary>
        /// Gets and sets the property ApprovalCriteria. 
        /// <para>
        /// The number of approvers in the group who must approve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BuyerAgreementApprovalCriteria ApprovalCriteria { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalCriteria property is set.
        /// </summary>
        internal bool IsSetApprovalCriteria() => this.ApprovalCriteria != null;

        /// <summary>
        /// Gets and sets the property Approvers. 
        /// <para>
        /// The approvers in the group and the decision of each one.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<ApproverOutcome> Approvers { get; set; } = AWSConfigs.InitializeCollections ? new List<ApproverOutcome>() : null;

        /// <summary>
        /// Checks to see if the Approvers property is set.
        /// </summary>
        internal bool IsSetApprovers() => this.Approvers != null && (this.Approvers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
