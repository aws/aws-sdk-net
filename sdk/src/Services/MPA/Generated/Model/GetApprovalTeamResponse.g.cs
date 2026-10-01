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
    /// This is the response object from the GetApprovalTeam operation.
    /// </summary>
    public partial class GetApprovalTeamResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Timestamp when the team was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// Timestamp when the team was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the approval team.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        /// Gets and sets the property PendingUpdate. 
        /// <para>
        /// A <c>PendingUpdate</c> object. Contains details for the pending updates for the team,
        /// if applicable.
        /// </para>
        /// </summary>
        public PendingUpdate PendingUpdate { get; set; }

        /// <summary>
        /// Checks to see if the PendingUpdate property is set.
        /// </summary>
        internal bool IsSetPendingUpdate() => this.PendingUpdate != null;

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// An array of <c>PolicyReference</c> objects. Contains a list of policies that define
        /// the permissions for team resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<PolicyReference> Policies { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyReference>() : null;

        /// <summary>
        /// Checks to see if the Policies property is set.
        /// </summary>
        internal bool IsSetPolicies() => this.Policies != null && (this.Policies.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Status code for the approval team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
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
        /// Gets and sets the property UpdateSessionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string UpdateSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSessionArn property is set.
        /// </summary>
        internal bool IsSetUpdateSessionArn() => this.UpdateSessionArn != null;

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
