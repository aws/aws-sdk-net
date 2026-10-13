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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the GetAssessmentReport operation. Produces an assessment
    /// report that includes detailed and comprehensive results of a specified assessment
    /// run.
    /// </summary>
    public partial class GetAssessmentReportRequest : AmazonInspectorRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentRunArn. 
        /// <para>
        /// The ARN that specifies the assessment run for which you want to generate a report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string AssessmentRunArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentRunArn property is set.
        /// </summary>
        internal bool IsSetAssessmentRunArn() => this.AssessmentRunArn != null;

        /// <summary>
        /// Gets and sets the property ReportFileFormat. 
        /// <para>
        /// Specifies the file format (html or pdf) of the assessment report that you want to
        /// generate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportFileFormat ReportFileFormat { get; set; }

        /// <summary>
        /// Checks to see if the ReportFileFormat property is set.
        /// </summary>
        internal bool IsSetReportFileFormat() => this.ReportFileFormat != null;

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// Specifies the type of the assessment report that you want to generate. There are two
        /// types of assessment reports: a finding report and a full report. For more information,
        /// see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_reports.html">Assessment
        /// Reports</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportType ReportType { get; set; }

        /// <summary>
        /// Checks to see if the ReportType property is set.
        /// </summary>
        internal bool IsSetReportType() => this.ReportType != null;
    }
}
