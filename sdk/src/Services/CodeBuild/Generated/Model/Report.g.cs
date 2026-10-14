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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the results from running a series of test cases during the run of
    /// a build project. The test cases are specified in the buildspec for the build project
    /// using one or more paths to the test case files. You can specify any type of tests
    /// you want, such as unit tests, integration tests, and functional tests.
    /// </summary>
    public partial class Report
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the report run. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CodeCoverageSummary. 
        /// <para>
        /// A <c>CodeCoverageReportSummary</c> object that contains a code coverage summary for
        /// this report.
        /// </para>
        /// </summary>
        public CodeCoverageReportSummary CodeCoverageSummary { get; set; }

        /// <summary>
        /// Checks to see if the CodeCoverageSummary property is set.
        /// </summary>
        internal bool IsSetCodeCoverageSummary() => this.CodeCoverageSummary != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        ///  The date and time this report run occurred. 
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        ///  The ARN of the build run that generated this report. 
        /// </para>
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property Expired. 
        /// <para>
        ///  The date and time a report expires. A report expires 30 days after it is created.
        /// An expired report is not available to view in CodeBuild. 
        /// </para>
        /// </summary>
        public DateTime? Expired { get; set; }

        /// <summary>
        /// Checks to see if the Expired property is set.
        /// </summary>
        internal bool IsSetExpired() => this.Expired.HasValue;

        /// <summary>
        /// Gets and sets the property ExportConfig. 
        /// <para>
        ///  Information about where the raw data used to generate this report was exported. 
        /// </para>
        /// </summary>
        public ReportExportConfig ExportConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExportConfig property is set.
        /// </summary>
        internal bool IsSetExportConfig() => this.ExportConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the report that was run. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReportGroupArn. 
        /// <para>
        ///  The ARN of the report group associated with this report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ReportGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ReportGroupArn property is set.
        /// </summary>
        internal bool IsSetReportGroupArn() => this.ReportGroupArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of this report. 
        /// </para>
        /// </summary>
        public ReportStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestSummary. 
        /// <para>
        ///  A <c>TestReportSummary</c> object that contains information about this test report.
        /// 
        /// </para>
        /// </summary>
        public TestReportSummary TestSummary { get; set; }

        /// <summary>
        /// Checks to see if the TestSummary property is set.
        /// </summary>
        internal bool IsSetTestSummary() => this.TestSummary != null;

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        ///  A boolean that specifies if this report run is truncated. The list of test cases
        /// is truncated after the maximum number of test cases is reached. 
        /// </para>
        /// </summary>
        public bool? Truncated { get; set; }

        /// <summary>
        /// Checks to see if the Truncated property is set.
        /// </summary>
        internal bool IsSetTruncated() => this.Truncated.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the report that was run.
        /// </para>
        ///  <dl> <dt>CODE_COVERAGE</dt> <dd> 
        /// <para>
        /// A code coverage report.
        /// </para>
        ///  </dd> <dt>TEST</dt> <dd> 
        /// <para>
        /// A test report.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReportType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
