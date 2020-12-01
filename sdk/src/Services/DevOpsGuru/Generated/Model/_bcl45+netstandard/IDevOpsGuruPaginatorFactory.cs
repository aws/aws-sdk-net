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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Paginators for the DevOpsGuru service
    ///</summary>
    public interface IDevOpsGuruPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeResourceCollectionHealth operation
        ///</summary>
        IDescribeResourceCollectionHealthPaginator DescribeResourceCollectionHealth(DescribeResourceCollectionHealthRequest request);

        /// <summary>
        /// Paginator for GetResourceCollection operation
        ///</summary>
        IGetResourceCollectionPaginator GetResourceCollection(GetResourceCollectionRequest request);

        /// <summary>
        /// Paginator for ListAnomaliesForInsight operation
        ///</summary>
        IListAnomaliesForInsightPaginator ListAnomaliesForInsight(ListAnomaliesForInsightRequest request);

        /// <summary>
        /// Paginator for ListEvents operation
        ///</summary>
        IListEventsPaginator ListEvents(ListEventsRequest request);

        /// <summary>
        /// Paginator for ListInsights operation
        ///</summary>
        IListInsightsPaginator ListInsights(ListInsightsRequest request);

        /// <summary>
        /// Paginator for ListNotificationChannels operation
        ///</summary>
        IListNotificationChannelsPaginator ListNotificationChannels(ListNotificationChannelsRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Paginator for SearchInsights operation
        ///</summary>
        ISearchInsightsPaginator SearchInsights(SearchInsightsRequest request);
    }
}
#endif