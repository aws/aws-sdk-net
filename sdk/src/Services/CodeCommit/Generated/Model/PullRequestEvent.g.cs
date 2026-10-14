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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a pull request event.
    /// </summary>
    public partial class PullRequestEvent
    {
        /// <summary>
        /// Gets and sets the property ActorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user whose actions resulted in the event. Examples
        /// include updating the pull request with more commits or changing the status of a pull
        /// request.
        /// </para>
        /// </summary>
        public string ActorArn { get; set; }

        /// <summary>
        /// Checks to see if the ActorArn property is set.
        /// </summary>
        internal bool IsSetActorArn() => this.ActorArn != null;

        /// <summary>
        /// Gets and sets the property ApprovalRuleEventMetadata. 
        /// <para>
        /// Information about a pull request event.
        /// </para>
        /// </summary>
        public ApprovalRuleEventMetadata ApprovalRuleEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleEventMetadata property is set.
        /// </summary>
        internal bool IsSetApprovalRuleEventMetadata() => this.ApprovalRuleEventMetadata != null;

        /// <summary>
        /// Gets and sets the property ApprovalRuleOverriddenEventMetadata. 
        /// <para>
        /// Information about an approval rule override event for a pull request.
        /// </para>
        /// </summary>
        public ApprovalRuleOverriddenEventMetadata ApprovalRuleOverriddenEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleOverriddenEventMetadata property is set.
        /// </summary>
        internal bool IsSetApprovalRuleOverriddenEventMetadata() => this.ApprovalRuleOverriddenEventMetadata != null;

        /// <summary>
        /// Gets and sets the property ApprovalStateChangedEventMetadata. 
        /// <para>
        /// Information about an approval state change for a pull request.
        /// </para>
        /// </summary>
        public ApprovalStateChangedEventMetadata ApprovalStateChangedEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalStateChangedEventMetadata property is set.
        /// </summary>
        internal bool IsSetApprovalStateChangedEventMetadata() => this.ApprovalStateChangedEventMetadata != null;

        /// <summary>
        /// Gets and sets the property EventDate. 
        /// <para>
        /// The day and time of the pull request event, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Checks to see if the EventDate property is set.
        /// </summary>
        internal bool IsSetEventDate() => this.EventDate.HasValue;

        /// <summary>
        /// Gets and sets the property PullRequestCreatedEventMetadata. 
        /// <para>
        /// Information about the source and destination branches for the pull request.
        /// </para>
        /// </summary>
        public PullRequestCreatedEventMetadata PullRequestCreatedEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestCreatedEventMetadata property is set.
        /// </summary>
        internal bool IsSetPullRequestCreatedEventMetadata() => this.PullRequestCreatedEventMetadata != null;

        /// <summary>
        /// Gets and sets the property PullRequestEventType. 
        /// <para>
        /// The type of the pull request event (for example, a status change event (PULL_REQUEST_STATUS_CHANGED)
        /// or update event (PULL_REQUEST_SOURCE_REFERENCE_UPDATED)).
        /// </para>
        /// </summary>
        public PullRequestEventType PullRequestEventType { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestEventType property is set.
        /// </summary>
        internal bool IsSetPullRequestEventType() => this.PullRequestEventType != null;

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request.
        /// </para>
        /// </summary>
        public string PullRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestId property is set.
        /// </summary>
        internal bool IsSetPullRequestId() => this.PullRequestId != null;

        /// <summary>
        /// Gets and sets the property PullRequestMergedStateChangedEventMetadata. 
        /// <para>
        /// Information about the change in mergability state for the pull request event.
        /// </para>
        /// </summary>
        public PullRequestMergedStateChangedEventMetadata PullRequestMergedStateChangedEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestMergedStateChangedEventMetadata property is set.
        /// </summary>
        internal bool IsSetPullRequestMergedStateChangedEventMetadata() => this.PullRequestMergedStateChangedEventMetadata != null;

        /// <summary>
        /// Gets and sets the property PullRequestSourceReferenceUpdatedEventMetadata. 
        /// <para>
        /// Information about the updated source branch for the pull request event. 
        /// </para>
        /// </summary>
        public PullRequestSourceReferenceUpdatedEventMetadata PullRequestSourceReferenceUpdatedEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestSourceReferenceUpdatedEventMetadata property is set.
        /// </summary>
        internal bool IsSetPullRequestSourceReferenceUpdatedEventMetadata() => this.PullRequestSourceReferenceUpdatedEventMetadata != null;

        /// <summary>
        /// Gets and sets the property PullRequestStatusChangedEventMetadata. 
        /// <para>
        /// Information about the change in status for the pull request event.
        /// </para>
        /// </summary>
        public PullRequestStatusChangedEventMetadata PullRequestStatusChangedEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestStatusChangedEventMetadata property is set.
        /// </summary>
        internal bool IsSetPullRequestStatusChangedEventMetadata() => this.PullRequestStatusChangedEventMetadata != null;
    }
}
