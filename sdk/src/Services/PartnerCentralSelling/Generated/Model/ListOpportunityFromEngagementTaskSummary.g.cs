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
    /// Provides a summary of a task related to creating an opportunity from an engagement.
    /// This structure contains key information about the task's status, associated identifiers,
    /// and any failure details for opportunity creation processes.
    /// </summary>
    public partial class ListOpportunityFromEngagementTaskSummary
    {
        /// <summary>
        /// Gets and sets the property ContextId. 
        /// <para>
        /// The unique identifier of the engagement context associated with the opportunity creation
        /// task. This links the task to specific contextual information within the engagement.
        /// </para>
        /// </summary>
        public string ContextId { get; set; }

        /// <summary>
        /// Checks to see if the ContextId property is set.
        /// </summary>
        internal bool IsSetContextId() => this.ContextId != null;

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The unique identifier of the engagement from which the opportunity is being created.
        /// This field helps track the source of the opportunity creation task.
        /// </para>
        /// </summary>
        public string EngagementId { get; set; }

        /// <summary>
        /// Checks to see if the EngagementId property is set.
        /// </summary>
        internal bool IsSetEngagementId() => this.EngagementId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A detailed message providing additional information about the task, especially useful
        /// in case of failures. This field may contain error details or other relevant information
        /// about the task's execution.
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
        /// The unique identifier of the opportunity created as a result of the task. This field
        /// is populated when the task is completed successfully.
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
        /// A code indicating the specific reason for a task failure. This field is populated
        /// when the task status is FAILED and provides a categorized reason for the failure.
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
        /// The identifier of the resource snapshot job associated with this task, if a snapshot
        /// was created as part of the opportunity creation process.
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
        /// The timestamp indicating when the task was initiated, in RFC 3339 format.
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
        /// The Amazon Resource Name (ARN) that uniquely identifies the task within AWS. This
        /// ARN can be used for referencing the task in other AWS services or APIs.
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
        /// The unique identifier of the task for creating an opportunity from an engagement.
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
        /// The current status of the task. Valid values are COMPLETE, INPROGRESS, or FAILED.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}
