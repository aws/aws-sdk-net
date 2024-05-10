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
    /// Container for the parameters to the DeleteAssessmentReport operation.
    /// Deletes an assessment report in Audit Manager. 
    /// 
    ///  
    /// <para>
    /// When you run the <c>DeleteAssessmentReport</c> operation, Audit Manager attempts to
    /// delete the following data:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// The specified assessment report that’s stored in your S3 bucket
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The associated metadata that’s stored in Audit Manager
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If Audit Manager can’t access the assessment report in your S3 bucket, the report
    /// isn’t deleted. In this event, the <c>DeleteAssessmentReport</c> operation doesn’t
    /// fail. Instead, it proceeds to delete the associated metadata only. You must then delete
    /// the assessment report from the S3 bucket yourself. 
    /// </para>
    ///  
    /// <para>
    /// This scenario happens when Audit Manager receives a <c>403 (Forbidden)</c> or <c>404
    /// (Not Found)</c> error from Amazon S3. To avoid this, make sure that your S3 bucket
    /// is available, and that you configured the correct permissions for Audit Manager to
    /// delete resources in your S3 bucket. For an example permissions policy that you can
    /// use, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/security_iam_id-based-policy-examples.html#full-administrator-access-assessment-report-destination">Assessment
    /// report destination permissions</a> in the <i>Audit Manager User Guide</i>. For information
    /// about the issues that could cause a <c>403 (Forbidden)</c> or <c>404 (Not Found</c>)
    /// error from Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
    /// of Error Codes</a> in the <i>Amazon Simple Storage Service API Reference</i>. 
    /// </para>
    /// </summary>
    public partial class DeleteAssessmentReportRequest : AmazonAuditManagerRequest
    {
        private string _assessmentId;
        private string _assessmentReportId;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The unique identifier for the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property AssessmentReportId. 
        /// <para>
        ///  The unique identifier for the assessment report. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssessmentReportId
        {
            get { return this._assessmentReportId; }
            set { this._assessmentReportId = value; }
        }

        // Check to see if AssessmentReportId property is set
        internal bool IsSetAssessmentReportId()
        {
            return this._assessmentReportId != null;
        }

    }
}