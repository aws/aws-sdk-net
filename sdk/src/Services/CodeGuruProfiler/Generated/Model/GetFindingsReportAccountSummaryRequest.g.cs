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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingsReportAccountSummary operation. Returns
    /// a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_FindingsReportSummary.html">
    /// <c>FindingsReportSummary</c> </a> objects that contain analysis results for all profiling
    /// groups in your AWS account.
    /// </summary>
    public partial class GetFindingsReportAccountSummaryRequest : AmazonCodeGuruProfilerRequest
    {
        /// <summary>
        /// Gets and sets the property DailyReportsOnly. 
        /// <para>
        /// A <c>Boolean</c> value indicating whether to only return reports from daily profiles.
        /// If set to <c>True</c>, only analysis data from daily profiles is returned. If set
        /// to <c>False</c>, analysis data is returned from smaller time windows (for example,
        /// one hour).
        /// </para>
        /// </summary>
        public bool? DailyReportsOnly { get; set; }

        /// <summary>
        /// Checks to see if the DailyReportsOnly property is set.
        /// </summary>
        internal bool IsSetDailyReportsOnly() => this.DailyReportsOnly.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <c> GetFindingsReportAccountSummary</c>
        /// in paginated output. When this parameter is used, <c>GetFindingsReportAccountSummary</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>GetFindingsReportAccountSummary</c> request with the returned <c>nextToken</c>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated <c>GetFindingsReportAccountSummary</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
