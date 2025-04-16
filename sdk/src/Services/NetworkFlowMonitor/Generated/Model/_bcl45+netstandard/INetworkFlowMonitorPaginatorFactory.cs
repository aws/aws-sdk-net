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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Paginators for the NetworkFlowMonitor service
    ///</summary>
    public interface INetworkFlowMonitorPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetQueryResultsMonitorTopContributors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetQueryResultsMonitorTopContributorsPaginator GetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request);

        /// <summary>
        /// Paginator for GetQueryResultsWorkloadInsightsTopContributors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetQueryResultsWorkloadInsightsTopContributorsPaginator GetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request);

        /// <summary>
        /// Paginator for GetQueryResultsWorkloadInsightsTopContributorsData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetQueryResultsWorkloadInsightsTopContributorsDataPaginator GetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request);

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitorsPaginator ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Paginator for ListScopes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListScopesPaginator ListScopes(ListScopesRequest request);
    }
}