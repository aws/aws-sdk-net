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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents a security finding discovered during a pentest job. A finding contains
    /// details about a vulnerability, including its risk level, confidence, and remediation
    /// status.
    /// </summary>
    public partial class Finding
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space associated with the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AlignmentRationale. 
        /// <para>
        /// The rationale provided by the alignment agent explaining how the finding was adjusted
        /// based on customer preferences.
        /// </para>
        /// </summary>
        public string AlignmentRationale { get; set; }

        /// <summary>
        /// Checks to see if the AlignmentRationale property is set.
        /// </summary>
        internal bool IsSetAlignmentRationale() => this.AlignmentRationale != null;

        /// <summary>
        /// Gets and sets the property AttackScript. 
        /// <para>
        /// The attack script used to reproduce the finding.
        /// </para>
        /// </summary>
        public string AttackScript { get; set; }

        /// <summary>
        /// Checks to see if the AttackScript property is set.
        /// </summary>
        internal bool IsSetAttackScript() => this.AttackScript != null;

        /// <summary>
        /// Gets and sets the property CodeLocations. 
        /// <para>
        /// The file locations involved in the vulnerability, as reported by the code scanner.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeLocation> CodeLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeLocation>() : null;

        /// <summary>
        /// Checks to see if the CodeLocations property is set.
        /// </summary>
        internal bool IsSetCodeLocations() => this.CodeLocations != null && (this.CodeLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CodeRemediationTask. 
        /// <para>
        /// The code remediation task associated with the finding, if code remediation was initiated.
        /// </para>
        /// </summary>
        public CodeRemediationTask CodeRemediationTask { get; set; }

        /// <summary>
        /// Checks to see if the CodeRemediationTask property is set.
        /// </summary>
        internal bool IsSetCodeRemediationTask() => this.CodeRemediationTask != null;

        /// <summary>
        /// Gets and sets the property CodeReviewId. 
        /// <para>
        /// The unique identifier of the code review associated with the finding.
        /// </para>
        /// </summary>
        public string CodeReviewId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewId property is set.
        /// </summary>
        internal bool IsSetCodeReviewId() => this.CodeReviewId != null;

        /// <summary>
        /// Gets and sets the property CodeReviewJobId. 
        /// <para>
        /// The unique identifier of the code review job that produced the finding.
        /// </para>
        /// </summary>
        public string CodeReviewJobId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewJobId property is set.
        /// </summary>
        internal bool IsSetCodeReviewJobId() => this.CodeReviewJobId != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level of the finding. Valid values include FALSE_POSITIVE, UNCONFIRMED,
        /// LOW, MEDIUM, and HIGH.
        /// </para>
        /// </summary>
        public ConfidenceLevel Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the finding was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerNote. 
        /// <para>
        /// A customer-provided note on the finding.
        /// </para>
        /// </summary>
        public string CustomerNote { get; set; }

        /// <summary>
        /// Checks to see if the CustomerNote property is set.
        /// </summary>
        internal bool IsSetCustomerNote() => this.CustomerNote != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the finding.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The unique identifier of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The identifier of the entity that last updated the finding.
        /// </para>
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the finding.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OriginalFindingId. 
        /// <para>
        /// The identifier of the original finding that this revalidation finding was produced
        /// from.
        /// </para>
        /// </summary>
        public string OriginalFindingId { get; set; }

        /// <summary>
        /// Checks to see if the OriginalFindingId property is set.
        /// </summary>
        internal bool IsSetOriginalFindingId() => this.OriginalFindingId != null;

        /// <summary>
        /// Gets and sets the property PentestId. 
        /// <para>
        /// The unique identifier of the pentest associated with the finding.
        /// </para>
        /// </summary>
        public string PentestId { get; set; }

        /// <summary>
        /// Checks to see if the PentestId property is set.
        /// </summary>
        internal bool IsSetPentestId() => this.PentestId != null;

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// The unique identifier of the pentest job that produced the finding.
        /// </para>
        /// </summary>
        public string PentestJobId { get; set; }

        /// <summary>
        /// Checks to see if the PentestJobId property is set.
        /// </summary>
        internal bool IsSetPentestJobId() => this.PentestJobId != null;

        /// <summary>
        /// Gets and sets the property Reasoning. 
        /// <para>
        /// The reasoning behind the finding, explaining why it was identified as a vulnerability.
        /// </para>
        /// </summary>
        public string Reasoning { get; set; }

        /// <summary>
        /// Checks to see if the Reasoning property is set.
        /// </summary>
        internal bool IsSetReasoning() => this.Reasoning != null;

        /// <summary>
        /// Gets and sets the property RevalidationJobIds. 
        /// <para>
        /// The list of pentest job identifiers for revalidation jobs that retested this finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RevalidationJobIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RevalidationJobIds property is set.
        /// </summary>
        internal bool IsSetRevalidationJobIds() => this.RevalidationJobIds != null && (this.RevalidationJobIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The risk level of the finding. Valid values include UNKNOWN, INFORMATIONAL, LOW, MEDIUM,
        /// HIGH, and CRITICAL.
        /// </para>
        /// </summary>
        public RiskLevel RiskLevel { get; set; }

        /// <summary>
        /// Checks to see if the RiskLevel property is set.
        /// </summary>
        internal bool IsSetRiskLevel() => this.RiskLevel != null;

        /// <summary>
        /// Gets and sets the property RiskScore. 
        /// <para>
        /// The numerical risk score of the finding.
        /// </para>
        /// </summary>
        public string RiskScore { get; set; }

        /// <summary>
        /// Checks to see if the RiskScore property is set.
        /// </summary>
        internal bool IsSetRiskScore() => this.RiskScore != null;

        /// <summary>
        /// Gets and sets the property RiskType. 
        /// <para>
        /// The type of security risk identified by the finding.
        /// </para>
        /// </summary>
        public string RiskType { get; set; }

        /// <summary>
        /// Checks to see if the RiskType property is set.
        /// </summary>
        internal bool IsSetRiskType() => this.RiskType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the finding. Valid values include ACTIVE, RESOLVED, ACCEPTED,
        /// and FALSE_POSITIVE.
        /// </para>
        /// </summary>
        public FindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the task that produced the finding.
        /// </para>
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the finding was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The simulated validation status of the finding. Valid values are NOT_VALIDATED, VALIDATING,
        /// CONFIRMED, NOT_REPRODUCED, and VALIDATION_FAILED.
        /// </para>
        /// </summary>
        public ValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;

        /// <summary>
        /// Gets and sets the property VerificationScript. 
        /// <para>
        /// The verification script metadata for reproducing the finding, including download URL,
        /// instructions, and required environment variables.
        /// </para>
        /// </summary>
        public VerificationScript VerificationScript { get; set; }

        /// <summary>
        /// Checks to see if the VerificationScript property is set.
        /// </summary>
        internal bool IsSetVerificationScript() => this.VerificationScript != null;
    }
}
