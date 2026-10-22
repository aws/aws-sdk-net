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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// A summary of an issue returned in list responses.
    /// </summary>
    public partial class IssueSummary
    {
        /// <summary>
        /// Gets and sets the property Confidence. The likelihood that this issue is a true positive,
        /// expressed as a percentage (0-100).
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the issue was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IssueArn. The ARN of the issue.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string IssueArn { get; set; }

        /// <summary>
        /// Checks to see if the IssueArn property is set.
        /// </summary>
        internal bool IsSetIssueArn() => this.IssueArn != null;

        /// <summary>
        /// Gets and sets the property IssueId. The unique identifier of the issue.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string IssueId { get; set; }

        /// <summary>
        /// Checks to see if the IssueId property is set.
        /// </summary>
        internal bool IsSetIssueId() => this.IssueId != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the issue.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Phase. The part of the workflow the issue is in. Present
        /// when status is IN_PROGRESS, and when status is FAILED and the failing phase is known.
        /// </summary>
        public IssuePhase Phase { get; set; }

        /// <summary>
        /// Checks to see if the Phase property is set.
        /// </summary>
        internal bool IsSetPhase() => this.Phase != null;

        /// <summary>
        /// Gets and sets the property Severity. Scanner-derived severity assigned to the issue.
        /// </summary>
        public IssueSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. The current lifecycle status of the issue.
        /// </summary>
        [AWSProperty(Required = true)]
        public IssueStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. Customer-facing explanation of statusReason.
        /// Present only when status is FAILED.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StatusReason. Why the issue failed. Present only when status
        /// is FAILED.
        /// </summary>
        public IssueStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StatusUpdatedAt. The timestamp when the status or phase
        /// last changed.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StatusUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the StatusUpdatedAt property is set.
        /// </summary>
        internal bool IsSetStatusUpdatedAt() => this.StatusUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The timestamp when any field of the issue last
        /// changed. Advances on every mutation (including score-only updates that do not transition
        /// status), so it is greater than or equal to statusUpdatedAt.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
