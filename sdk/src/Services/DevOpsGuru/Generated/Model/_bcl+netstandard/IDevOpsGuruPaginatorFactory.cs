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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Paginators for the DevOpsGuru service
    ///</summary>
    public interface IDevOpsGuruPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeOrganizationResourceCollectionHealth operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeOrganizationResourceCollectionHealthPaginator DescribeOrganizationResourceCollectionHealth(DescribeOrganizationResourceCollectionHealthRequest request);

        /// <summary>
        /// Paginator for DescribeResourceCollectionHealth operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeResourceCollectionHealthPaginator DescribeResourceCollectionHealth(DescribeResourceCollectionHealthRequest request);

        /// <summary>
        /// Paginator for GetCostEstimation operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IGetCostEstimationPaginator GetCostEstimation(GetCostEstimationRequest request);

        /// <summary>
        /// Paginator for GetResourceCollection operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IGetResourceCollectionPaginator GetResourceCollection(GetResourceCollectionRequest request);

        /// <summary>
        /// Paginator for ListAnomaliesForInsight operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnomaliesForInsightPaginator ListAnomaliesForInsight(ListAnomaliesForInsightRequest request);

        /// <summary>
        /// Paginator for ListAnomalousLogGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnomalousLogGroupsPaginator ListAnomalousLogGroups(ListAnomalousLogGroupsRequest request);

        /// <summary>
        /// Paginator for ListEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventsPaginator ListEvents(ListEventsRequest request);

        /// <summary>
        /// Paginator for ListInsights operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInsightsPaginator ListInsights(ListInsightsRequest request);

        /// <summary>
        /// Paginator for ListMonitoredResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitoredResourcesPaginator ListMonitoredResources(ListMonitoredResourcesRequest request);

        /// <summary>
        /// Paginator for ListNotificationChannels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListNotificationChannelsPaginator ListNotificationChannels(ListNotificationChannelsRequest request);

        /// <summary>
        /// Paginator for ListOrganizationInsights operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationInsightsPaginator ListOrganizationInsights(ListOrganizationInsightsRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Paginator for SearchInsights operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchInsightsPaginator SearchInsights(SearchInsightsRequest request);

        /// <summary>
        /// Paginator for SearchOrganizationInsights operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchOrganizationInsightsPaginator SearchOrganizationInsights(SearchOrganizationInsightsRequest request);
    }
}