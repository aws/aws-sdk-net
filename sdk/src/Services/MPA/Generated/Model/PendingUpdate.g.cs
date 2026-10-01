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

namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for the pending updates for an approval team, if applicable.
    /// </summary>
    public partial class PendingUpdate
    {
        /// <summary>
        /// Gets and sets the property ApprovalStrategy. 
        /// <para>
        /// An <c>ApprovalStrategyResponse</c> object. Contains details for how the team grants
        /// approval.
        /// </para>
        /// </summary>
        public ApprovalStrategyResponse ApprovalStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalStrategy property is set.
        /// </summary>
        internal bool IsSetApprovalStrategy() => this.ApprovalStrategy != null;

        /// <summary>
        /// Gets and sets the property Approvers. 
        /// <para>
        /// An array of <c>GetApprovalTeamResponseApprover </c> objects. Contains details for
        /// the approvers in the team.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<GetApprovalTeamResponseApprover> Approvers { get; set; } = AWSConfigs.InitializeCollections ? new List<GetApprovalTeamResponseApprover>() : null;

        /// <summary>
        /// Checks to see if the Approvers property is set.
        /// </summary>
        internal bool IsSetApprovers() => this.Approvers != null && (this.Approvers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NumberOfApprovers. 
        /// <para>
        /// Total number of approvers in the team.
        /// </para>
        /// </summary>
        public int? NumberOfApprovers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfApprovers property is set.
        /// </summary>
        internal bool IsSetNumberOfApprovers() => this.NumberOfApprovers.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
        /// health</a> in the <i>Multi-party approval User Guide</i>.
        /// </para>
        /// </summary>
        public ApprovalTeamStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Status code for the update. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
        /// health</a> in the <i>Multi-party approval User Guide</i>.
        /// </para>
        /// </summary>
        public ApprovalTeamStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Message describing the status for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdateInitiationTime. 
        /// <para>
        /// Timestamp when the update request was initiated.
        /// </para>
        /// </summary>
        public DateTime? UpdateInitiationTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateInitiationTime property is set.
        /// </summary>
        internal bool IsSetUpdateInitiationTime() => this.UpdateInitiationTime.HasValue;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
