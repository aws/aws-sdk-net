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
    /// This is the response object from the StartEngagementByAcceptingInvitationTask operation.
    /// </summary>
    public partial class StartEngagementByAcceptingInvitationTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EngagementInvitationId. 
        /// <para>
        /// Returns the identifier of the engagement invitation that was accepted and used to
        /// create the opportunity.
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
        /// If the task fails, this field contains a detailed message describing the failure and
        /// possible recovery steps.
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
        /// Returns the original opportunity identifier passed in the request. This is the unique
        /// identifier for the opportunity.
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
        /// Indicates the reason for task failure using an enumerated code.
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
        /// The identifier of the Resource Snapshot Job created as part of this task.
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
        /// The timestamp indicating when the task was initiated. The format follows RFC 3339
        /// section 5.6.
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
        /// The Amazon Resource Name (ARN) of the task, used for tracking and managing the task
        /// within AWS.
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
        /// The unique identifier of the task, used to track the task’s progress.
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
        /// Indicates the current status of the task.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}
