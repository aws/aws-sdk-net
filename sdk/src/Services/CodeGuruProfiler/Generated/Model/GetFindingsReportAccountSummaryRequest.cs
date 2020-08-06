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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingsReportAccountSummary operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_FindingsReportSummary.html">
    /// <code>FindingsReportSummary</code> </a> objects that contain analysis results for
    /// all profiling groups in your AWS account.
    /// </summary>
    public partial class GetFindingsReportAccountSummaryRequest : AmazonCodeGuruProfilerRequest
    {
        private bool? _dailyReportsOnly;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DailyReportsOnly. 
        /// <para>
        /// A <code>Boolean</code> value indicating whether to only return reports from daily
        /// profiles. If set to <code>True</code>, only analysis data from daily profiles is returned.
        /// If set to <code>False</code>, analysis data is returned from smaller time windows
        /// (for example, one hour).
        /// </para>
        /// </summary>
        public bool DailyReportsOnly
        {
            get { return this._dailyReportsOnly.GetValueOrDefault(); }
            set { this._dailyReportsOnly = value; }
        }

        // Check to see if DailyReportsOnly property is set
        internal bool IsSetDailyReportsOnly()
        {
            return this._dailyReportsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <code> GetFindingsReportAccountSummary</code>
        /// in paginated output. When this parameter is used, <code>GetFindingsReportAccountSummary</code>
        /// only returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>GetFindingsReportAccountSummary</code> request with the returned <code>nextToken</code>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>GetFindingsReportAccountSummary</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

    }
}