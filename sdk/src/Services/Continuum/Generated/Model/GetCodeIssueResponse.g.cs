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
    /// This is the response object from the GetCodeIssue operation.
    /// </summary>
    public partial class GetCodeIssueResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property EvidenceAvailability. Whether the issue has any attached
        /// evidence (formerly 'artifacts': tool output, remediation proposals, patches). NONE
        /// = no evidence; AVAILABLE = at least one evidence item exists. Computed at read time.
        /// </summary>
        public IssueEvidenceAvailability EvidenceAvailability { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceAvailability property is set.
        /// </summary>
        internal bool IsSetEvidenceAvailability() => this.EvidenceAvailability != null;

        /// <summary>
        /// Gets and sets the property FindingIds. The findings that motivated this issue. Bare
        /// identifiers only -- a caller authorized for GetCodeIssue is not necessarily authorized
        /// to read finding detail; call GetCodeFinding for that. Every referenced finding is
        /// included regardless of origin (both CustomerUploaded and ContinuumScanner).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> FindingIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingIds property is set.
        /// </summary>
        internal bool IsSetFindingIds() => this.FindingIds != null && (this.FindingIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property PatchDelivery. Customer delivery of the issue's patches,
        /// summarized from its PATCH artifacts at read time. Absent when no patch has a destination
        /// delivery.
        /// </summary>
        public IssuePatchDelivery PatchDelivery { get; set; }

        /// <summary>
        /// Checks to see if the PatchDelivery property is set.
        /// </summary>
        internal bool IsSetPatchDelivery() => this.PatchDelivery != null;

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
        /// Gets and sets the property Severity. Current severity: the FindingSeverity seed at
        /// create, overwritten by the authoritative severity that prioritization assigns after
        /// validation.
        /// </summary>
        public IssueSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property SeverityReasoning. The justification for the current severity.
        /// Always leads with a customer-facing basis clause synthesized from how the severity
        /// was determined (e.g. "Severity from finding.", "Severity from Continuum system.");
        /// when prioritization has run, its own reasoning follows. Issues created before the
        /// basis clause was introduced return their original reasoning without it.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string SeverityReasoning { get; set; }

        /// <summary>
        /// Checks to see if the SeverityReasoning property is set.
        /// </summary>
        internal bool IsSetSeverityReasoning() => this.SeverityReasoning != null;

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
        /// Gets and sets the property Summary. The remediation completion summary, when the green
        /// stage has run.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property Synopsis. A free-form synopsis of the issue.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string Synopsis { get; set; }

        /// <summary>
        /// Checks to see if the Synopsis property is set.
        /// </summary>
        internal bool IsSetSynopsis() => this.Synopsis != null;

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
