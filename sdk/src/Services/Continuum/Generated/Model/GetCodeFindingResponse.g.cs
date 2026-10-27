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
    /// This is the response object from the GetCodeFinding operation.
    /// </summary>
    public partial class GetCodeFindingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AffectedPackages. Packages implicated by the finding.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<AffectedPackage> AffectedPackages { get; set; } = AWSConfigs.InitializeCollections ? new List<AffectedPackage>() : null;

        /// <summary>
        /// Checks to see if the AffectedPackages property is set.
        /// </summary>
        internal bool IsSetAffectedPackages() => this.AffectedPackages != null && (this.AffectedPackages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Category. The producer's vulnerability category. Not a
        /// stable filter key across finding types -- see FindingCategory.
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
        /// Gets and sets the property CveId. The CVE this finding reports, for software-composition
        /// findings. Both code types can carry one: a customer document supplies it under vulnerabilities[].cve,
        /// and Continuum's scanner reports CVEs for dependency-manifest findings.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CveId { get; set; }

        /// <summary>
        /// Checks to see if the CveId property is set.
        /// </summary>
        internal bool IsSetCveId() => this.CveId != null;

        /// <summary>
        /// Gets and sets the property CvssBaseScore. The CVSS base score accompanying `cveId`,
        /// when the producer supplies one, from 0.0 to 10.0. Not computed by Continuum. The range
        /// is enforced server-side, not by a @range trait -- the smithy-rs server SDK does not
        /// support range constraints on double shapes (smithy-rs#2007).
        /// </summary>
        public double? CvssBaseScore { get; set; }

        /// <summary>
        /// Checks to see if the CvssBaseScore property is set.
        /// </summary>
        internal bool IsSetCvssBaseScore() => this.CvssBaseScore.HasValue;

        /// <summary>
        /// Gets and sets the property CweIds. CWE identifiers classifying the finding.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public List<string> CweIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CweIds property is set.
        /// </summary>
        internal bool IsSetCweIds() => this.CweIds != null && (this.CweIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DetailedDescription. The full analysis.
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string DetailedDescription { get; set; }

        /// <summary>
        /// Checks to see if the DetailedDescription property is set.
        /// </summary>
        internal bool IsSetDetailedDescription() => this.DetailedDescription != null;

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
        /// Gets and sets the property EndLine. The last line of the affected range, from the
        /// document's affected_code[].end_line.
        /// </summary>
        public int? EndLine { get; set; }

        /// <summary>
        /// Checks to see if the EndLine property is set.
        /// </summary>
        internal bool IsSetEndLine() => this.EndLine.HasValue;

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
        /// Gets and sets the property FilePath. The file the finding is about.
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
        /// Gets and sets the property FindingTypes. The producer's own classification of the
        /// finding (finding_info.types).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> FindingTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingTypes property is set.
        /// </summary>
        internal bool IsSetFindingTypes() => this.FindingTypes != null && (this.FindingTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirstSeenAt. When the producer first observed the finding
        /// (finding_info.first_seen_time). The producer's own clock, not Continuum's.
        /// </summary>
        public DateTime? FirstSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstSeenAt property is set.
        /// </summary>
        internal bool IsSetFirstSeenAt() => this.FirstSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property LineNumber. The 1-indexed line the finding is about. Bounds
        /// are enforced server-side rather than by a constraint trait: a numeric constraint generates
        /// a distinct newtype per enclosing structure, so the same concept would not share a
        /// type across the create input and the read output.
        /// </summary>
        public int? LineNumber { get; set; }

        /// <summary>
        /// Checks to see if the LineNumber property is set.
        /// </summary>
        internal bool IsSetLineNumber() => this.LineNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Mitigation. How to fix the finding.
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Mitigation { get; set; }

        /// <summary>
        /// Checks to see if the Mitigation property is set.
        /// </summary>
        internal bool IsSetMitigation() => this.Mitigation != null;

        /// <summary>
        /// Gets and sets the property MitreTechniques. MITRE ATT&amp;CK technique identifiers,
        /// from the document's finding_info.attacks[].technique.uid.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> MitreTechniques { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MitreTechniques property is set.
        /// </summary>
        internal bool IsSetMitreTechniques() => this.MitreTechniques != null && (this.MitreTechniques.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OcsfClass. The OCSF class the document declared. Determines
        /// whether `posture` is populated.
        /// </summary>
        public FindingOcsfClass OcsfClass { get; set; }

        /// <summary>
        /// Checks to see if the OcsfClass property is set.
        /// </summary>
        internal bool IsSetOcsfClass() => this.OcsfClass != null;

        /// <summary>
        /// Gets and sets the property OcsfSchemaVersion. The OCSF schema version the producer
        /// wrote against (metadata.version).
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string OcsfSchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the OcsfSchemaVersion property is set.
        /// </summary>
        internal bool IsSetOcsfSchemaVersion() => this.OcsfSchemaVersion != null;

        /// <summary>
        /// Gets and sets the property OwaspCategory. The OWASP Top 10 category, when the producer
        /// supplies one.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string OwaspCategory { get; set; }

        /// <summary>
        /// Checks to see if the OwaspCategory property is set.
        /// </summary>
        internal bool IsSetOwaspCategory() => this.OwaspCategory != null;

        /// <summary>
        /// Gets and sets the property Posture. The compliance posture, for an Application Security
        /// Posture Finding. Absent for a vulnerability finding.
        /// </summary>
        public FindingPosture Posture { get; set; }

        /// <summary>
        /// Checks to see if the Posture property is set.
        /// </summary>
        internal bool IsSetPosture() => this.Posture != null;

        /// <summary>
        /// Gets and sets the property ProductName. The producing product and vendor (metadata.product).
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ProductVendorName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ProductVendorName { get; set; }

        /// <summary>
        /// Checks to see if the ProductVendorName property is set.
        /// </summary>
        internal bool IsSetProductVendorName() => this.ProductVendorName != null;

        /// <summary>
        /// Gets and sets the property ProductVersion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProductVersion property is set.
        /// </summary>
        internal bool IsSetProductVersion() => this.ProductVersion != null;

        /// <summary>
        /// Gets and sets the property RelevantInputs. User-controlled inputs that reach the vulnerability.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> RelevantInputs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RelevantInputs property is set.
        /// </summary>
        internal bool IsSetRelevantInputs() => this.RelevantInputs != null && (this.RelevantInputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemediationReferences. Remediation references, from the
        /// document's vulnerabilities[].remediation.references.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> RemediationReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemediationReferences property is set.
        /// </summary>
        internal bool IsSetRemediationReferences() => this.RemediationReferences != null && (this.RemediationReferences.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Resources. Resources the document named (resources[]).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<FindingResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property SourceStatus. The producer's own status for the finding,
        /// and the enum value behind it. Distinct from `status`, which is Continuum's lifecycle
        /// state -- a producer may call a finding "New" while Continuum has it SUBMITTED.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SourceStatus { get; set; }

        /// <summary>
        /// Checks to see if the SourceStatus property is set.
        /// </summary>
        internal bool IsSetSourceStatus() => this.SourceStatus != null;

        /// <summary>
        /// Gets and sets the property SourceStatusId. The producer's numeric enum value for `sourceStatus`.
        /// </summary>
        public int? SourceStatusId { get; set; }

        /// <summary>
        /// Checks to see if the SourceStatusId property is set.
        /// </summary>
        internal bool IsSetSourceStatusId() => this.SourceStatusId.HasValue;

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
        /// Gets and sets the property StepsToReproduce. Steps to reproduce or exploit the finding.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> StepsToReproduce { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StepsToReproduce property is set.
        /// </summary>
        internal bool IsSetStepsToReproduce() => this.StepsToReproduce != null && (this.StepsToReproduce.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubCategory. A more specific classification within `category`.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SubCategory { get; set; }

        /// <summary>
        /// Checks to see if the SubCategory property is set.
        /// </summary>
        internal bool IsSetSubCategory() => this.SubCategory != null;

        /// <summary>
        /// Gets and sets the property Summary. A one-paragraph description.
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

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
        /// Gets and sets the property Type. What kind of finding this is. Determines which of
        /// the type-specific members below are populated.
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Validation. The validator's assessment. Absent when no
        /// validation ran.
        /// </summary>
        public FindingValidation Validation { get; set; }

        /// <summary>
        /// Checks to see if the Validation property is set.
        /// </summary>
        internal bool IsSetValidation() => this.Validation != null;

        /// <summary>
        /// Gets and sets the property Vulnerabilities. Every vulnerability the document reported.
        /// A document may report several; the flat `cveId`/`cvssBaseScore`/`filePath`/`lineNumber`
        /// members above carry the first one's identity so a caller that only needs "what and
        /// where" does not have to walk this list.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<FindingVulnerability> Vulnerabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingVulnerability>() : null;

        /// <summary>
        /// Checks to see if the Vulnerabilities property is set.
        /// </summary>
        internal bool IsSetVulnerabilities() => this.Vulnerabilities != null && (this.Vulnerabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VulnerableCode. The vulnerable code fragment.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string VulnerableCode { get; set; }

        /// <summary>
        /// Checks to see if the VulnerableCode property is set.
        /// </summary>
        internal bool IsSetVulnerableCode() => this.VulnerableCode != null;
    }
}
