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
    /// Container for the parameters to the DescribeCodeCoverages operation.
    /// Retrieves one or more code coverage reports.
    /// </summary>
    public partial class DescribeCodeCoveragesRequest : AmazonCodeBuildRequest
    {
        private double? _maxLineCoveragePercentage;
        private int? _maxResults;
        private double? _minLineCoveragePercentage;
        private string _nextToken;
        private string _reportArn;
        private ReportCodeCoverageSortByType _sortBy;
        private SortOrderType _sortOrder;

        /// <summary>
        /// Gets and sets the property MaxLineCoveragePercentage. 
        /// <para>
        /// The maximum line coverage percentage to report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? MaxLineCoveragePercentage
        {
            get { return this._maxLineCoveragePercentage; }
            set { this._maxLineCoveragePercentage = value; }
        }

        // Check to see if MaxLineCoveragePercentage property is set
        internal bool IsSetMaxLineCoveragePercentage()
        {
            return this._maxLineCoveragePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinLineCoveragePercentage. 
        /// <para>
        /// The minimum line coverage percentage to report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? MinLineCoveragePercentage
        {
            get { return this._minLineCoveragePercentage; }
            set { this._minLineCoveragePercentage = value; }
        }

        // Check to see if MinLineCoveragePercentage property is set
        internal bool IsSetMinLineCoveragePercentage()
        {
            return this._minLineCoveragePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous call to <c>DescribeCodeCoverages</c>.
        /// This specifies the next item to return. To return the beginning of the list, exclude
        /// this parameter.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReportArn. 
        /// <para>
        ///  The ARN of the report for which test cases are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ReportArn
        {
            get { return this._reportArn; }
            set { this._reportArn = value; }
        }

        // Check to see if ReportArn property is set
        internal bool IsSetReportArn()
        {
            return this._reportArn != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies how the results are sorted. Possible values are:
        /// </para>
        ///  <dl> <dt>FILE_PATH</dt> <dd> 
        /// <para>
        /// The results are sorted by file path.
        /// </para>
        ///  </dd> <dt>LINE_COVERAGE_PERCENTAGE</dt> <dd> 
        /// <para>
        /// The results are sorted by the percentage of lines that are covered.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReportCodeCoverageSortByType SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies if the results are sorted in ascending or descending order.
        /// </para>
        /// </summary>
        public SortOrderType SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}