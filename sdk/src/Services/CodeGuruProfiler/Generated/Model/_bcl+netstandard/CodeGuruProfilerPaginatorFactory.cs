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
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Paginators for the CodeGuruProfiler service
    ///</summary>
    public class CodeGuruProfilerPaginatorFactory : ICodeGuruProfilerPaginatorFactory
    {
        private readonly IAmazonCodeGuruProfiler client;

        internal CodeGuruProfilerPaginatorFactory(IAmazonCodeGuruProfiler client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetFindingsReportAccountSummary operation
        ///</summary>
        public IGetFindingsReportAccountSummaryPaginator GetFindingsReportAccountSummary(GetFindingsReportAccountSummaryRequest request) 
        {
            return new GetFindingsReportAccountSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindingsReports operation
        ///</summary>
        public IListFindingsReportsPaginator ListFindingsReports(ListFindingsReportsRequest request) 
        {
            return new ListFindingsReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfileTimes operation
        ///</summary>
        public IListProfileTimesPaginator ListProfileTimes(ListProfileTimesRequest request) 
        {
            return new ListProfileTimesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfilingGroups operation
        ///</summary>
        public IListProfilingGroupsPaginator ListProfilingGroups(ListProfilingGroupsRequest request) 
        {
            return new ListProfilingGroupsPaginator(this.client, request);
        }
    }
}