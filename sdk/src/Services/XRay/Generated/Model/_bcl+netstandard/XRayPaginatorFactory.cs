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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Paginators for the XRay service
    ///</summary>
    public class XRayPaginatorFactory : IXRayPaginatorFactory
    {
        private readonly IAmazonXRay client;

        internal XRayPaginatorFactory(IAmazonXRay client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for BatchGetTraces operation
        ///</summary>
        public IBatchGetTracesPaginator BatchGetTraces(BatchGetTracesRequest request) 
        {
            return new BatchGetTracesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetGroups operation
        ///</summary>
        public IGetGroupsPaginator GetGroups(GetGroupsRequest request) 
        {
            return new GetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetInsightEvents operation
        ///</summary>
        public IGetInsightEventsPaginator GetInsightEvents(GetInsightEventsRequest request) 
        {
            return new GetInsightEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetInsightSummaries operation
        ///</summary>
        public IGetInsightSummariesPaginator GetInsightSummaries(GetInsightSummariesRequest request) 
        {
            return new GetInsightSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSamplingRules operation
        ///</summary>
        public IGetSamplingRulesPaginator GetSamplingRules(GetSamplingRulesRequest request) 
        {
            return new GetSamplingRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSamplingStatisticSummaries operation
        ///</summary>
        public IGetSamplingStatisticSummariesPaginator GetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request) 
        {
            return new GetSamplingStatisticSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetServiceGraph operation
        ///</summary>
        public IGetServiceGraphPaginator GetServiceGraph(GetServiceGraphRequest request) 
        {
            return new GetServiceGraphPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTimeSeriesServiceStatistics operation
        ///</summary>
        public IGetTimeSeriesServiceStatisticsPaginator GetTimeSeriesServiceStatistics(GetTimeSeriesServiceStatisticsRequest request) 
        {
            return new GetTimeSeriesServiceStatisticsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTraceGraph operation
        ///</summary>
        public IGetTraceGraphPaginator GetTraceGraph(GetTraceGraphRequest request) 
        {
            return new GetTraceGraphPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTraceSummaries operation
        ///</summary>
        public IGetTraceSummariesPaginator GetTraceSummaries(GetTraceSummariesRequest request) 
        {
            return new GetTraceSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourcePolicies operation
        ///</summary>
        public IListResourcePoliciesPaginator ListResourcePolicies(ListResourcePoliciesRequest request) 
        {
            return new ListResourcePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}