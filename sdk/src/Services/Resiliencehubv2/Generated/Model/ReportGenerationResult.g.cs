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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Result of a report generation attempt.
    /// </summary>
    public partial class ReportGenerationResult
    {
        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// Present for FAILURE_MODE reports.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the report was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ReportOutput. 
        /// <para>
        /// Present when status is SUCCEEDED or FAILED.
        /// </para>
        /// </summary>
        public ReportOutput ReportOutput { get; set; }

        /// <summary>
        /// Checks to see if the ReportOutput property is set.
        /// </summary>
        internal bool IsSetReportOutput() => this.ReportOutput != null;

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// The type of the generated report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportType ReportType { get; set; }

        /// <summary>
        /// Checks to see if the ReportType property is set.
        /// </summary>
        internal bool IsSetReportType() => this.ReportType != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The service this report was generated for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the report generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportGenerationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestRunId.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TestRunId { get; set; }

        /// <summary>
        /// Checks to see if the TestRunId property is set.
        /// </summary>
        internal bool IsSetTestRunId() => this.TestRunId != null;

        /// <summary>
        /// Gets and sets the property TestTemplateArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string TestTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TestTemplateArn property is set.
        /// </summary>
        internal bool IsSetTestTemplateArn() => this.TestTemplateArn != null;
    }
}
