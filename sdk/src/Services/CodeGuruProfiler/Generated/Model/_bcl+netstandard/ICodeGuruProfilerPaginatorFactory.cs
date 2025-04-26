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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Paginators for the CodeGuruProfiler service
    ///</summary>
    public interface ICodeGuruProfilerPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetFindingsReportAccountSummary operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFindingsReportAccountSummaryPaginator GetFindingsReportAccountSummary(GetFindingsReportAccountSummaryRequest request);

        /// <summary>
        /// Paginator for ListFindingsReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingsReportsPaginator ListFindingsReports(ListFindingsReportsRequest request);

        /// <summary>
        /// Paginator for ListProfileTimes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProfileTimesPaginator ListProfileTimes(ListProfileTimesRequest request);

        /// <summary>
        /// Paginator for ListProfilingGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProfilingGroupsPaginator ListProfilingGroups(ListProfilingGroupsRequest request);
    }
}