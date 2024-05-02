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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A summary of the latest analytics data for a specific active assessment.
    /// 
    ///  
    /// <para>
    /// This summary is a snapshot of the data that was collected on the <c>lastUpdated</c>
    /// date. It’s important to understand that the totals in <c>InsightsByAssessment</c>
    /// are daily counts based on this date — they aren’t a total sum to date. 
    /// </para>
    ///  
    /// <para>
    /// The <c>InsightsByAssessment</c> data is eventually consistent. This means that when
    /// you read data from <c>InsightsByAssessment</c>, the response might not instantly reflect
    /// the results of a recently completed write or update operation. If you repeat your
    /// read request after a few hours, the response returns the latest data.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you delete an assessment or change its status to inactive, <c>InsightsByAssessment</c>
    /// includes data for that assessment as follows.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Inactive assessments</b> - If Audit Manager collected evidence for your assessment
    /// before you changed it inactive, that evidence is included in the <c>InsightsByAssessment</c>
    /// counts for that day.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Deleted assessments</b> - If Audit Manager collected evidence for your assessment
    /// before you deleted it, that evidence isn't included in the <c>InsightsByAssessment</c>
    /// counts for that day.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class InsightsByAssessment
    {
        private int? _assessmentControlsCountByNoncompliantEvidence;
        private int? _compliantEvidenceCount;
        private int? _inconclusiveEvidenceCount;
        private DateTime? _lastUpdated;
        private int? _noncompliantEvidenceCount;
        private int? _totalAssessmentControlsCount;

        /// <summary>
        /// Gets and sets the property AssessmentControlsCountByNoncompliantEvidence. 
        /// <para>
        /// The number of assessment controls that collected non-compliant evidence on the <c>lastUpdated</c>
        /// date. 
        /// </para>
        /// </summary>
        public int? AssessmentControlsCountByNoncompliantEvidence
        {
            get { return this._assessmentControlsCountByNoncompliantEvidence; }
            set { this._assessmentControlsCountByNoncompliantEvidence = value; }
        }

        // Check to see if AssessmentControlsCountByNoncompliantEvidence property is set
        internal bool IsSetAssessmentControlsCountByNoncompliantEvidence()
        {
            return this._assessmentControlsCountByNoncompliantEvidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantEvidenceCount. 
        /// <para>
        /// The number of compliance check evidence that Audit Manager classified as compliant.
        /// This includes evidence that was collected from Security Hub with a <i>Pass</i> ruling,
        /// or collected from Config with a <i>Compliant</i> ruling. 
        /// </para>
        /// </summary>
        public int? CompliantEvidenceCount
        {
            get { return this._compliantEvidenceCount; }
            set { this._compliantEvidenceCount = value; }
        }

        // Check to see if CompliantEvidenceCount property is set
        internal bool IsSetCompliantEvidenceCount()
        {
            return this._compliantEvidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InconclusiveEvidenceCount. 
        /// <para>
        /// The amount of evidence without a compliance check ruling. Evidence is inconclusive
        /// if the associated control uses Security Hub or Config as a data source and you didn't
        /// enable those services. This is also the case if a control uses a data source that
        /// doesn’t support compliance checks (for example, manual evidence, API calls, or CloudTrail).
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If evidence has a compliance check status of <i>not applicable</i>, it's classified
        /// as <i>inconclusive</i> in <c>InsightsByAssessment</c> data.
        /// </para>
        ///  </note>
        /// </summary>
        public int? InconclusiveEvidenceCount
        {
            get { return this._inconclusiveEvidenceCount; }
            set { this._inconclusiveEvidenceCount = value; }
        }

        // Check to see if InconclusiveEvidenceCount property is set
        internal bool IsSetInconclusiveEvidenceCount()
        {
            return this._inconclusiveEvidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time when the assessment insights were last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoncompliantEvidenceCount. 
        /// <para>
        /// The number of compliance check evidence that Audit Manager classified as non-compliant.
        /// This includes evidence that was collected from Security Hub with a <i>Fail</i> ruling,
        /// or collected from Config with a <i>Non-compliant</i> ruling. 
        /// </para>
        /// </summary>
        public int? NoncompliantEvidenceCount
        {
            get { return this._noncompliantEvidenceCount; }
            set { this._noncompliantEvidenceCount = value; }
        }

        // Check to see if NoncompliantEvidenceCount property is set
        internal bool IsSetNoncompliantEvidenceCount()
        {
            return this._noncompliantEvidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalAssessmentControlsCount. 
        /// <para>
        /// The total number of controls in the assessment. 
        /// </para>
        /// </summary>
        public int? TotalAssessmentControlsCount
        {
            get { return this._totalAssessmentControlsCount; }
            set { this._totalAssessmentControlsCount = value; }
        }

        // Check to see if TotalAssessmentControlsCount property is set
        internal bool IsSetTotalAssessmentControlsCount()
        {
            return this._totalAssessmentControlsCount.HasValue; 
        }

    }
}