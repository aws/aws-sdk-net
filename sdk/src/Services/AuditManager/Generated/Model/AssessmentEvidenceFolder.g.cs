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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The folder where Audit Manager stores evidence for an assessment.
    /// </summary>
    public partial class AssessmentEvidenceFolder
    {
        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property AssessmentReportSelectionCount. 
        /// <para>
        ///  The total count of evidence that's included in the assessment report. 
        /// </para>
        /// </summary>
        public int? AssessmentReportSelectionCount { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentReportSelectionCount property is set.
        /// </summary>
        internal bool IsSetAssessmentReportSelectionCount() => this.AssessmentReportSelectionCount.HasValue;

        /// <summary>
        /// Gets and sets the property Author. 
        /// <para>
        ///  The name of the user who created the evidence folder. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Author { get; set; }

        /// <summary>
        /// Checks to see if the Author property is set.
        /// </summary>
        internal bool IsSetAuthor() => this.Author != null;

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        ///  The unique identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ControlId { get; set; }

        /// <summary>
        /// Checks to see if the ControlId property is set.
        /// </summary>
        internal bool IsSetControlId() => this.ControlId != null;

        /// <summary>
        /// Gets and sets the property ControlName. 
        /// <para>
        ///  The name of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string ControlName { get; set; }

        /// <summary>
        /// Checks to see if the ControlName property is set.
        /// </summary>
        internal bool IsSetControlName() => this.ControlName != null;

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string ControlSetId { get; set; }

        /// <summary>
        /// Checks to see if the ControlSetId property is set.
        /// </summary>
        internal bool IsSetControlSetId() => this.ControlSetId != null;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The Amazon Web Services service that the evidence was collected from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        ///  The date when the first evidence was added to the evidence folder. 
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceAwsServiceSourceCount. 
        /// <para>
        ///  The total number of Amazon Web Services resources that were assessed to generate
        /// the evidence. 
        /// </para>
        /// </summary>
        public int? EvidenceAwsServiceSourceCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceAwsServiceSourceCount property is set.
        /// </summary>
        internal bool IsSetEvidenceAwsServiceSourceCount() => this.EvidenceAwsServiceSourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceByTypeComplianceCheckCount. 
        /// <para>
        ///  The number of evidence that falls under the compliance check category. This evidence
        /// is collected from Config or Security Hub CSPM. 
        /// </para>
        /// </summary>
        public int? EvidenceByTypeComplianceCheckCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceByTypeComplianceCheckCount property is set.
        /// </summary>
        internal bool IsSetEvidenceByTypeComplianceCheckCount() => this.EvidenceByTypeComplianceCheckCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceByTypeComplianceCheckIssuesCount. 
        /// <para>
        ///  The total number of issues that were reported directly from Security Hub CSPM, Config,
        /// or both. 
        /// </para>
        /// </summary>
        public int? EvidenceByTypeComplianceCheckIssuesCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceByTypeComplianceCheckIssuesCount property is set.
        /// </summary>
        internal bool IsSetEvidenceByTypeComplianceCheckIssuesCount() => this.EvidenceByTypeComplianceCheckIssuesCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceByTypeConfigurationDataCount. 
        /// <para>
        ///  The number of evidence that falls under the configuration data category. This evidence
        /// is collected from configuration snapshots of other Amazon Web Services services such
        /// as Amazon EC2, Amazon S3, or IAM. 
        /// </para>
        /// </summary>
        public int? EvidenceByTypeConfigurationDataCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceByTypeConfigurationDataCount property is set.
        /// </summary>
        internal bool IsSetEvidenceByTypeConfigurationDataCount() => this.EvidenceByTypeConfigurationDataCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceByTypeManualCount. 
        /// <para>
        ///  The number of evidence that falls under the manual category. This evidence is imported
        /// manually. 
        /// </para>
        /// </summary>
        public int? EvidenceByTypeManualCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceByTypeManualCount property is set.
        /// </summary>
        internal bool IsSetEvidenceByTypeManualCount() => this.EvidenceByTypeManualCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceByTypeUserActivityCount. 
        /// <para>
        ///  The number of evidence that falls under the user activity category. This evidence
        /// is collected from CloudTrail logs. 
        /// </para>
        /// </summary>
        public int? EvidenceByTypeUserActivityCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceByTypeUserActivityCount property is set.
        /// </summary>
        internal bool IsSetEvidenceByTypeUserActivityCount() => this.EvidenceByTypeUserActivityCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceResourcesIncludedCount. 
        /// <para>
        ///  The amount of evidence that's included in the evidence folder. 
        /// </para>
        /// </summary>
        public int? EvidenceResourcesIncludedCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceResourcesIncludedCount property is set.
        /// </summary>
        internal bool IsSetEvidenceResourcesIncludedCount() => this.EvidenceResourcesIncludedCount.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier for the folder that the evidence is stored in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the evidence folder. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TotalEvidence. 
        /// <para>
        ///  The total amount of evidence in the evidence folder. 
        /// </para>
        /// </summary>
        public int? TotalEvidence { get; set; }

        /// <summary>
        /// Checks to see if the TotalEvidence property is set.
        /// </summary>
        internal bool IsSetTotalEvidence() => this.TotalEvidence.HasValue;
    }
}
