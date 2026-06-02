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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Result of a report generation attempt.
    /// </summary>
    public partial class ReportGenerationResult
    {
        private string _assessmentId;
        private DateTime? _createdAt;
        private ReportOutput _reportOutput;
        private ReportType _reportType;
        private string _serviceArn;
        private ReportGenerationStatus _status;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// Present for FAILURE_MODE reports.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the report was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportOutput. 
        /// <para>
        /// Present when status is SUCCEEDED or FAILED.
        /// </para>
        /// </summary>
        public ReportOutput ReportOutput
        {
            get { return this._reportOutput; }
            set { this._reportOutput = value; }
        }

        // Check to see if ReportOutput property is set
        internal bool IsSetReportOutput()
        {
            return this._reportOutput != null;
        }

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// The type of the generated report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportType ReportType
        {
            get { return this._reportType; }
            set { this._reportType = value; }
        }

        // Check to see if ReportType property is set
        internal bool IsSetReportType()
        {
            return this._reportType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The service this report was generated for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the report generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportGenerationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}