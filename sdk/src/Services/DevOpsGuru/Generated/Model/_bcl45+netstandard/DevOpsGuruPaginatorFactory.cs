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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Paginators for the DevOpsGuru service
    ///</summary>
    public class DevOpsGuruPaginatorFactory : IDevOpsGuruPaginatorFactory
    {
        private readonly IAmazonDevOpsGuru client;

        internal DevOpsGuruPaginatorFactory(IAmazonDevOpsGuru client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeResourceCollectionHealth operation
        ///</summary>
        public IDescribeResourceCollectionHealthPaginator DescribeResourceCollectionHealth(DescribeResourceCollectionHealthRequest request) 
        {
            return new DescribeResourceCollectionHealthPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourceCollection operation
        ///</summary>
        public IGetResourceCollectionPaginator GetResourceCollection(GetResourceCollectionRequest request) 
        {
            return new GetResourceCollectionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnomaliesForInsight operation
        ///</summary>
        public IListAnomaliesForInsightPaginator ListAnomaliesForInsight(ListAnomaliesForInsightRequest request) 
        {
            return new ListAnomaliesForInsightPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEvents operation
        ///</summary>
        public IListEventsPaginator ListEvents(ListEventsRequest request) 
        {
            return new ListEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInsights operation
        ///</summary>
        public IListInsightsPaginator ListInsights(ListInsightsRequest request) 
        {
            return new ListInsightsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotificationChannels operation
        ///</summary>
        public IListNotificationChannelsPaginator ListNotificationChannels(ListNotificationChannelsRequest request) 
        {
            return new ListNotificationChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        public IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request) 
        {
            return new ListRecommendationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchInsights operation
        ///</summary>
        public ISearchInsightsPaginator SearchInsights(SearchInsightsRequest request) 
        {
            return new SearchInsightsPaginator(this.client, request);
        }
    }
}
#endif