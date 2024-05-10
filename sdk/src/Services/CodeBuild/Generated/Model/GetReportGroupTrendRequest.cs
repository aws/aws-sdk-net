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
    /// Container for the parameters to the GetReportGroupTrend operation.
    /// Analyzes and accumulates test report values for the specified test reports.
    /// </summary>
    public partial class GetReportGroupTrendRequest : AmazonCodeBuildRequest
    {
        private int? _numOfReports;
        private string _reportGroupArn;
        private ReportGroupTrendFieldType _trendField;

        /// <summary>
        /// Gets and sets the property NumOfReports. 
        /// <para>
        /// The number of reports to analyze. This operation always retrieves the most recent
        /// reports.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is omitted, the most recent 100 reports are analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? NumOfReports
        {
            get { return this._numOfReports; }
            set { this._numOfReports = value; }
        }

        // Check to see if NumOfReports property is set
        internal bool IsSetNumOfReports()
        {
            return this._numOfReports.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportGroupArn. 
        /// <para>
        /// The ARN of the report group that contains the reports to analyze.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property TrendField. 
        /// <para>
        /// The test report value to accumulate. This must be one of the following values:
        /// </para>
        ///  <dl> <dt>Test reports:</dt> <dd> <dl> <dt>DURATION</dt> <dd> 
        /// <para>
        /// Accumulate the test run times for the specified reports.
        /// </para>
        ///  </dd> <dt>PASS_RATE</dt> <dd> 
        /// <para>
        /// Accumulate the percentage of tests that passed for the specified test reports.
        /// </para>
        ///  </dd> <dt>TOTAL</dt> <dd> 
        /// <para>
        /// Accumulate the total number of tests for the specified test reports.
        /// </para>
        ///  </dd> </dl> </dd> </dl> <dl> <dt>Code coverage reports:</dt> <dd> <dl> <dt>BRANCH_COVERAGE</dt>
        /// <dd> 
        /// <para>
        /// Accumulate the branch coverage percentages for the specified test reports.
        /// </para>
        ///  </dd> <dt>BRANCHES_COVERED</dt> <dd> 
        /// <para>
        /// Accumulate the branches covered values for the specified test reports.
        /// </para>
        ///  </dd> <dt>BRANCHES_MISSED</dt> <dd> 
        /// <para>
        /// Accumulate the branches missed values for the specified test reports.
        /// </para>
        ///  </dd> <dt>LINE_COVERAGE</dt> <dd> 
        /// <para>
        /// Accumulate the line coverage percentages for the specified test reports.
        /// </para>
        ///  </dd> <dt>LINES_COVERED</dt> <dd> 
        /// <para>
        /// Accumulate the lines covered values for the specified test reports.
        /// </para>
        ///  </dd> <dt>LINES_MISSED</dt> <dd> 
        /// <para>
        /// Accumulate the lines not covered values for the specified test reports.
        /// </para>
        ///  </dd> </dl> </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportGroupTrendFieldType TrendField
        {
            get { return this._trendField; }
            set { this._trendField = value; }
        }

        // Check to see if TrendField property is set
        internal bool IsSetTrendField()
        {
            return this._trendField != null;
        }

    }
}