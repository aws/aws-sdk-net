#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Paginators for the XRay service
    ///</summary>
    public interface IXRayPaginatorFactory
    {

        /// <summary>
        /// Paginator for BatchGetTraces operation
        ///</summary>
        IBatchGetTracesPaginator BatchGetTraces(BatchGetTracesRequest request);

        /// <summary>
        /// Paginator for GetGroups operation
        ///</summary>
        IGetGroupsPaginator GetGroups(GetGroupsRequest request);

        /// <summary>
        /// Paginator for GetInsightEvents operation
        ///</summary>
        IGetInsightEventsPaginator GetInsightEvents(GetInsightEventsRequest request);

        /// <summary>
        /// Paginator for GetInsightSummaries operation
        ///</summary>
        IGetInsightSummariesPaginator GetInsightSummaries(GetInsightSummariesRequest request);

        /// <summary>
        /// Paginator for GetSamplingRules operation
        ///</summary>
        IGetSamplingRulesPaginator GetSamplingRules(GetSamplingRulesRequest request);

        /// <summary>
        /// Paginator for GetSamplingStatisticSummaries operation
        ///</summary>
        IGetSamplingStatisticSummariesPaginator GetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request);

        /// <summary>
        /// Paginator for GetServiceGraph operation
        ///</summary>
        IGetServiceGraphPaginator GetServiceGraph(GetServiceGraphRequest request);

        /// <summary>
        /// Paginator for GetTimeSeriesServiceStatistics operation
        ///</summary>
        IGetTimeSeriesServiceStatisticsPaginator GetTimeSeriesServiceStatistics(GetTimeSeriesServiceStatisticsRequest request);

        /// <summary>
        /// Paginator for GetTraceGraph operation
        ///</summary>
        IGetTraceGraphPaginator GetTraceGraph(GetTraceGraphRequest request);

        /// <summary>
        /// Paginator for GetTraceSummaries operation
        ///</summary>
        IGetTraceSummariesPaginator GetTraceSummaries(GetTraceSummariesRequest request);
    }
}
#endif