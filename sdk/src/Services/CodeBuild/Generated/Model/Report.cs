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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
        private string _arn;
        private CodeCoverageReportSummary _codeCoverageSummary;
        private DateTime? _created;
        private string _executionId;
        private DateTime? _expired;
        private ReportExportConfig _exportConfig;
        private string _name;
        private string _reportGroupArn;
        private ReportStatusType _status;
        private TestReportSummary _testSummary;
        private bool? _truncated;
        private ReportType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the report run. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CodeCoverageSummary. 
        /// <para>
        /// A <c>CodeCoverageReportSummary</c> object that contains a code coverage summary for
        /// this report.
        /// </para>
        /// </summary>
        public CodeCoverageReportSummary CodeCoverageSummary
        {
            get { return this._codeCoverageSummary; }
            set { this._codeCoverageSummary = value; }
        }

        // Check to see if CodeCoverageSummary property is set
        internal bool IsSetCodeCoverageSummary()
        {
            return this._codeCoverageSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        ///  The date and time this report run occurred. 
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        ///  The ARN of the build run that generated this report. 
        /// </para>
        /// </summary>
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property Expired. 
        /// <para>
        ///  The date and time a report expires. A report expires 30 days after it is created.
        /// An expired report is not available to view in CodeBuild. 
        /// </para>
        /// </summary>
        public DateTime? Expired
        {
            get { return this._expired; }
            set { this._expired = value; }
        }

        // Check to see if Expired property is set
        internal bool IsSetExpired()
        {
            return this._expired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportConfig. 
        /// <para>
        ///  Information about where the raw data used to generate this report was exported. 
        /// </para>
        /// </summary>
        public ReportExportConfig ExportConfig
        {
            get { return this._exportConfig; }
            set { this._exportConfig = value; }
        }

        // Check to see if ExportConfig property is set
        internal bool IsSetExportConfig()
        {
            return this._exportConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the report that was run. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ReportGroupArn. 
        /// <para>
        ///  The ARN of the report group associated with this report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ReportGroupArn
        {
            get { return this._reportGroupArn; }
            set { this._reportGroupArn = value; }
        }

        // Check to see if ReportGroupArn property is set
        internal bool IsSetReportGroupArn()
        {
            return this._reportGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of this report. 
        /// </para>
        /// </summary>
        public ReportStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TestSummary. 
        /// <para>
        ///  A <c>TestReportSummary</c> object that contains information about this test report.
        /// 
        /// </para>
        /// </summary>
        public TestReportSummary TestSummary
        {
            get { return this._testSummary; }
            set { this._testSummary = value; }
        }

        // Check to see if TestSummary property is set
        internal bool IsSetTestSummary()
        {
            return this._testSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        ///  A boolean that specifies if this report run is truncated. The list of test cases
        /// is truncated after the maximum number of test cases is reached. 
        /// </para>
        /// </summary>
        public bool? Truncated
        {
            get { return this._truncated; }
            set { this._truncated = value; }
        }

        // Check to see if Truncated property is set
        internal bool IsSetTruncated()
        {
            return this._truncated.HasValue; 
        }

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
        public ReportType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}