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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The folder in which AWS Audit Manager stores evidence for an assessment.
    /// </summary>
    public partial class AssessmentEvidenceFolder
    {
        private string _assessmentId;
        private int? _assessmentReportSelectionCount;
        private string _author;
        private string _controlId;
        private string _controlName;
        private string _controlSetId;
        private string _dataSource;
        private DateTime? _date;
        private int? _evidenceAwsServiceSourceCount;
        private int? _evidenceByTypeComplianceCheckCount;
        private int? _evidenceByTypeComplianceCheckIssuesCount;
        private int? _evidenceByTypeConfigurationDataCount;
        private int? _evidenceByTypeManualCount;
        private int? _evidenceByTypeUserActivityCount;
        private int? _evidenceResourcesIncludedCount;
        private string _id;
        private string _name;
        private int? _totalEvidence;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the specified assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentReportSelectionCount. 
        /// <para>
        ///  The total count of evidence included in the assessment report. 
        /// </para>
        /// </summary>
        public int AssessmentReportSelectionCount
        {
            get { return this._assessmentReportSelectionCount.GetValueOrDefault(); }
            set { this._assessmentReportSelectionCount = value; }
        }

        // Check to see if AssessmentReportSelectionCount property is set
        internal bool IsSetAssessmentReportSelectionCount()
        {
            return this._assessmentReportSelectionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Author. 
        /// <para>
        ///  The name of the user who created the evidence folder. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Author
        {
            get { return this._author; }
            set { this._author = value; }
        }

        // Check to see if Author property is set
        internal bool IsSetAuthor()
        {
            return this._author != null;
        }

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        ///  The unique identifier for the specified control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
        }

        /// <summary>
        /// Gets and sets the property ControlName. 
        /// <para>
        ///  The name of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ControlName
        {
            get { return this._controlName; }
            set { this._controlName = value; }
        }

        // Check to see if ControlName property is set
        internal bool IsSetControlName()
        {
            return this._controlName != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ControlSetId
        {
            get { return this._controlSetId; }
            set { this._controlSetId = value; }
        }

        // Check to see if ControlSetId property is set
        internal bool IsSetControlSetId()
        {
            return this._controlSetId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The AWS service from which the evidence was collected. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        ///  The date when the first evidence was added to the evidence folder. 
        /// </para>
        /// </summary>
        public DateTime Date
        {
            get { return this._date.GetValueOrDefault(); }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceAwsServiceSourceCount. 
        /// <para>
        ///  The total number of AWS resources assessed to generate the evidence. 
        /// </para>
        /// </summary>
        public int EvidenceAwsServiceSourceCount
        {
            get { return this._evidenceAwsServiceSourceCount.GetValueOrDefault(); }
            set { this._evidenceAwsServiceSourceCount = value; }
        }

        // Check to see if EvidenceAwsServiceSourceCount property is set
        internal bool IsSetEvidenceAwsServiceSourceCount()
        {
            return this._evidenceAwsServiceSourceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceByTypeComplianceCheckCount. 
        /// <para>
        ///  The number of evidence that falls under the compliance check category. This evidence
        /// is collected from AWS Config or AWS Security Hub. 
        /// </para>
        /// </summary>
        public int EvidenceByTypeComplianceCheckCount
        {
            get { return this._evidenceByTypeComplianceCheckCount.GetValueOrDefault(); }
            set { this._evidenceByTypeComplianceCheckCount = value; }
        }

        // Check to see if EvidenceByTypeComplianceCheckCount property is set
        internal bool IsSetEvidenceByTypeComplianceCheckCount()
        {
            return this._evidenceByTypeComplianceCheckCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceByTypeComplianceCheckIssuesCount. 
        /// <para>
        ///  The total number of issues that were reported directly from AWS Security Hub, AWS
        /// Config, or both. 
        /// </para>
        /// </summary>
        public int EvidenceByTypeComplianceCheckIssuesCount
        {
            get { return this._evidenceByTypeComplianceCheckIssuesCount.GetValueOrDefault(); }
            set { this._evidenceByTypeComplianceCheckIssuesCount = value; }
        }

        // Check to see if EvidenceByTypeComplianceCheckIssuesCount property is set
        internal bool IsSetEvidenceByTypeComplianceCheckIssuesCount()
        {
            return this._evidenceByTypeComplianceCheckIssuesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceByTypeConfigurationDataCount. 
        /// <para>
        ///  The number of evidence that falls under the configuration data category. This evidence
        /// is collected from configuration snapshots of other AWS services such as Amazon EC2,
        /// Amazon S3, or IAM. 
        /// </para>
        /// </summary>
        public int EvidenceByTypeConfigurationDataCount
        {
            get { return this._evidenceByTypeConfigurationDataCount.GetValueOrDefault(); }
            set { this._evidenceByTypeConfigurationDataCount = value; }
        }

        // Check to see if EvidenceByTypeConfigurationDataCount property is set
        internal bool IsSetEvidenceByTypeConfigurationDataCount()
        {
            return this._evidenceByTypeConfigurationDataCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceByTypeManualCount. 
        /// <para>
        ///  The number of evidence that falls under the manual category. This evidence is imported
        /// manually. 
        /// </para>
        /// </summary>
        public int EvidenceByTypeManualCount
        {
            get { return this._evidenceByTypeManualCount.GetValueOrDefault(); }
            set { this._evidenceByTypeManualCount = value; }
        }

        // Check to see if EvidenceByTypeManualCount property is set
        internal bool IsSetEvidenceByTypeManualCount()
        {
            return this._evidenceByTypeManualCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceByTypeUserActivityCount. 
        /// <para>
        ///  The number of evidence that falls under the user activity category. This evidence
        /// is collected from AWS CloudTrail logs. 
        /// </para>
        /// </summary>
        public int EvidenceByTypeUserActivityCount
        {
            get { return this._evidenceByTypeUserActivityCount.GetValueOrDefault(); }
            set { this._evidenceByTypeUserActivityCount = value; }
        }

        // Check to see if EvidenceByTypeUserActivityCount property is set
        internal bool IsSetEvidenceByTypeUserActivityCount()
        {
            return this._evidenceByTypeUserActivityCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvidenceResourcesIncludedCount. 
        /// <para>
        ///  The amount of evidence included in the evidence folder. 
        /// </para>
        /// </summary>
        public int EvidenceResourcesIncludedCount
        {
            get { return this._evidenceResourcesIncludedCount.GetValueOrDefault(); }
            set { this._evidenceResourcesIncludedCount = value; }
        }

        // Check to see if EvidenceResourcesIncludedCount property is set
        internal bool IsSetEvidenceResourcesIncludedCount()
        {
            return this._evidenceResourcesIncludedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier for the folder in which evidence is stored. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the specified evidence folder. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TotalEvidence. 
        /// <para>
        ///  The total amount of evidence in the evidence folder. 
        /// </para>
        /// </summary>
        public int TotalEvidence
        {
            get { return this._totalEvidence.GetValueOrDefault(); }
            set { this._totalEvidence = value; }
        }

        // Check to see if TotalEvidence property is set
        internal bool IsSetTotalEvidence()
        {
            return this._totalEvidence.HasValue; 
        }

    }
}