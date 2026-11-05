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
    /// A summary of a finding returned in list responses. Shares FindingLifecycleFields with
    /// the read operations so the list and get projections cannot drift. Carries a lean content
    /// subset -- fetch the finding for its full contents.
    /// </summary>
    public partial class FindingSummary
    {
        /// <summary>
        /// Gets and sets the property Category. The producer's vulnerability category.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CompletedAt. When processing finished, whether by creating
        /// an issue or discarding. Absent while the finding is still in flight.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the finding was ingested.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedIssueId. The issue Continuum created from this finding.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CreatedIssueId { get; set; }

        /// <summary>
        /// Checks to see if the CreatedIssueId property is set.
        /// </summary>
        internal bool IsSetCreatedIssueId() => this.CreatedIssueId != null;

        /// <summary>
        /// Gets and sets the property DiscardReason. Why the finding was not escalated. Present
        /// only when status is DISCARDED.
        /// </summary>
        public FindingDiscardReason DiscardReason { get; set; }

        /// <summary>
        /// Checks to see if the DiscardReason property is set.
        /// </summary>
        internal bool IsSetDiscardReason() => this.DiscardReason != null;

        /// <summary>
        /// Gets and sets the property DiscardReasoning. Customer-facing explanation accompanying
        /// `discardReason`.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DiscardReasoning { get; set; }

        /// <summary>
        /// Checks to see if the DiscardReasoning property is set.
        /// </summary>
        internal bool IsSetDiscardReasoning() => this.DiscardReasoning != null;

        /// <summary>
        /// Gets and sets the property DuplicateOfIssueId. The existing issue this finding duplicates.
        /// Present only for the DUPLICATE_OF_* discard reasons.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DuplicateOfIssueId { get; set; }

        /// <summary>
        /// Checks to see if the DuplicateOfIssueId property is set.
        /// </summary>
        internal bool IsSetDuplicateOfIssueId() => this.DuplicateOfIssueId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. The environment that owns the finding.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property FilePath. The file the finding is about, when it has a
        /// code location.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property FindingArn. The ARN of the finding.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string FindingArn { get; set; }

        /// <summary>
        /// Checks to see if the FindingArn property is set.
        /// </summary>
        internal bool IsSetFindingArn() => this.FindingArn != null;

        /// <summary>
        /// Gets and sets the property FindingId. The unique identifier of the finding.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property ReportedAt. When the producer reported the finding -- its
        /// own clock, which is not Continuum's ingestion time. `createdAt` is when Continuum
        /// accepted it; these are genuinely different instants and a reader usually wants this
        /// one. For CreateCodeFinding, this is the submitted OCSF document's own top-level `time`.
        /// For findings Continuum's scanner produces, it is the finding's own creation time.
        /// Continuum does not validate it for plausibility: a producer's value is echoed as given,
        /// so a `timestamp` here asserts the unit and format, not that the instant is genuine.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ReportedAt { get; set; }

        /// <summary>
        /// Checks to see if the ReportedAt property is set.
        /// </summary>
        internal bool IsSetReportedAt() => this.ReportedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ScanRunId. The scan that produced the finding, when it
        /// came from one. For a finding Continuum's scanner produced, this is the Continuum scan
        /// run (see GetCodeScan). For a finding submitted with CreateCodeFinding, it is the OCSF
        /// document's `metadata.correlation_uid`, when that value is a valid ScanRunId. Absent
        /// when the finding did not come from a scan.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ScanRunId { get; set; }

        /// <summary>
        /// Checks to see if the ScanRunId property is set.
        /// </summary>
        internal bool IsSetScanRunId() => this.ScanRunId != null;

        /// <summary>
        /// Gets and sets the property Severity. The finding's severity.
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingSeverityId Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Source. The system that produced the finding.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceFindingId. The producer's own identifier for the
        /// finding.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SourceFindingId { get; set; }

        /// <summary>
        /// Checks to see if the SourceFindingId property is set.
        /// </summary>
        internal bool IsSetSourceFindingId() => this.SourceFindingId != null;

        /// <summary>
        /// Gets and sets the property Status. The current lifecycle status of the finding.
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. Human-readable context about the current
        /// status.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StatusUpdatedAt. The timestamp when the status last transitioned.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StatusUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the StatusUpdatedAt property is set.
        /// </summary>
        internal bool IsSetStatusUpdatedAt() => this.StatusUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Title. The producer's title for the finding.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. What kind of finding this is.
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
