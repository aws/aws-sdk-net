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

#pragma warning disable CS0612,CS0618
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
        /// Paginator for DescribeOrganizationResourceCollectionHealth operation
        ///</summary>
        public IDescribeOrganizationResourceCollectionHealthPaginator DescribeOrganizationResourceCollectionHealth(DescribeOrganizationResourceCollectionHealthRequest request) 
        {
            return new DescribeOrganizationResourceCollectionHealthPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeResourceCollectionHealth operation
        ///</summary>
        public IDescribeResourceCollectionHealthPaginator DescribeResourceCollectionHealth(DescribeResourceCollectionHealthRequest request) 
        {
            return new DescribeResourceCollectionHealthPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCostEstimation operation
        ///</summary>
        public IGetCostEstimationPaginator GetCostEstimation(GetCostEstimationRequest request) 
        {
            return new GetCostEstimationPaginator(this.client, request);
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
        /// Paginator for ListAnomalousLogGroups operation
        ///</summary>
        public IListAnomalousLogGroupsPaginator ListAnomalousLogGroups(ListAnomalousLogGroupsRequest request) 
        {
            return new ListAnomalousLogGroupsPaginator(this.client, request);
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
        /// Paginator for ListMonitoredResources operation
        ///</summary>
        public IListMonitoredResourcesPaginator ListMonitoredResources(ListMonitoredResourcesRequest request) 
        {
            return new ListMonitoredResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotificationChannels operation
        ///</summary>
        public IListNotificationChannelsPaginator ListNotificationChannels(ListNotificationChannelsRequest request) 
        {
            return new ListNotificationChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationInsights operation
        ///</summary>
        public IListOrganizationInsightsPaginator ListOrganizationInsights(ListOrganizationInsightsRequest request) 
        {
            return new ListOrganizationInsightsPaginator(this.client, request);
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

        /// <summary>
        /// Paginator for SearchOrganizationInsights operation
        ///</summary>
        public ISearchOrganizationInsightsPaginator SearchOrganizationInsights(SearchOrganizationInsightsRequest request) 
        {
            return new SearchOrganizationInsightsPaginator(this.client, request);
        }
    }
}