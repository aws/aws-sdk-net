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
    /// Contains details for an approver.
    /// </summary>
    public partial class GetApprovalTeamResponseApprover
    {
        /// <summary>
        /// Gets and sets the property ApproverId. 
        /// <para>
        /// ID for the approver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApproverId { get; set; }

        /// <summary>
        /// Checks to see if the ApproverId property is set.
        /// </summary>
        internal bool IsSetApproverId() => this.ApproverId != null;

        /// <summary>
        /// Gets and sets the property LastActivity. 
        /// <para>
        /// Last Activity performed by the approver.
        /// </para>
        /// </summary>
        public ApproverLastActivity LastActivity { get; set; }

        /// <summary>
        /// Checks to see if the LastActivity property is set.
        /// </summary>
        internal bool IsSetLastActivity() => this.LastActivity != null;

        /// <summary>
        /// Gets and sets the property LastActivityTime. 
        /// <para>
        /// Timestamp when the approver last responded to an operation or invitation request.
        /// </para>
        /// </summary>
        public DateTime? LastActivityTime { get; set; }

        /// <summary>
        /// Checks to see if the LastActivityTime property is set.
        /// </summary>
        internal bool IsSetLastActivityTime() => this.LastActivityTime.HasValue;

        /// <summary>
        /// Gets and sets the property MfaMethods. 
        /// <para>
        /// Multi-factor authentication configuration for the approver
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<MfaMethod> MfaMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<MfaMethod>() : null;

        /// <summary>
        /// Checks to see if the MfaMethods property is set.
        /// </summary>
        internal bool IsSetMfaMethods() => this.MfaMethods != null && (this.MfaMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingBaselineSessionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the pending baseline session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PendingBaselineSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the PendingBaselineSessionArn property is set.
        /// </summary>
        internal bool IsSetPendingBaselineSessionArn() => this.PendingBaselineSessionArn != null;

        /// <summary>
        /// Gets and sets the property PrimaryIdentityId. 
        /// <para>
        /// ID for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PrimaryIdentityId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryIdentityId property is set.
        /// </summary>
        internal bool IsSetPrimaryIdentityId() => this.PrimaryIdentityId != null;

        /// <summary>
        /// Gets and sets the property PrimaryIdentitySourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the identity source. The identity source manages the
        /// user authentication for approvers.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string PrimaryIdentitySourceArn { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryIdentitySourceArn property is set.
        /// </summary>
        internal bool IsSetPrimaryIdentitySourceArn() => this.PrimaryIdentitySourceArn != null;

        /// <summary>
        /// Gets and sets the property PrimaryIdentityStatus. 
        /// <para>
        /// Status for the identity source. For example, if an approver has accepted a team invitation
        /// with a user authentication method managed by the identity source.
        /// </para>
        /// </summary>
        public IdentityStatus PrimaryIdentityStatus { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryIdentityStatus property is set.
        /// </summary>
        internal bool IsSetPrimaryIdentityStatus() => this.PrimaryIdentityStatus != null;

        /// <summary>
        /// Gets and sets the property ResponseTime. 
        /// <para>
        /// Timestamp when the approver responded to an approval team invitation.
        /// </para>
        /// </summary>
        public DateTime? ResponseTime { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTime property is set.
        /// </summary>
        internal bool IsSetResponseTime() => this.ResponseTime.HasValue;
    }
}
