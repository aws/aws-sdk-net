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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Specifies a subset of fields associated with tasks related to accepting an engagement
    /// invitation.
    /// </summary>
    public partial class ListEngagementByAcceptingInvitationTaskSummary
    {
        /// <summary>
        /// Gets and sets the property EngagementInvitationId. 
        /// <para>
        ///  The unique identifier of the engagement invitation that was accepted. 
        /// </para>
        /// </summary>
        public string EngagementInvitationId { get; set; }

        /// <summary>
        /// Checks to see if the EngagementInvitationId property is set.
        /// </summary>
        internal bool IsSetEngagementInvitationId() => this.EngagementInvitationId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  Detailed message describing the failure and possible recovery steps. 
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OpportunityId. 
        /// <para>
        ///  Unique identifier of opportunity that was created. 
        /// </para>
        /// </summary>
        public string OpportunityId { get; set; }

        /// <summary>
        /// Checks to see if the OpportunityId property is set.
        /// </summary>
        internal bool IsSetOpportunityId() => this.OpportunityId != null;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        ///  A code pointing to the specific reason for the failure. 
        /// </para>
        /// </summary>
        public ReasonCode ReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the ReasonCode property is set.
        /// </summary>
        internal bool IsSetReasonCode() => this.ReasonCode != null;

        /// <summary>
        /// Gets and sets the property ResourceSnapshotJobId. 
        /// <para>
        ///  Unique identifier of the resource snapshot job that was created. 
        /// </para>
        /// </summary>
        public string ResourceSnapshotJobId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSnapshotJobId property is set.
        /// </summary>
        internal bool IsSetResourceSnapshotJobId() => this.ResourceSnapshotJobId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  Task start timestamp. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that uniquely identifies the task. 
        /// </para>
        /// </summary>
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  Unique identifier of the task. 
        /// </para>
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        ///  Status of the task. 
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}
