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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Paginators for the NetworkFlowMonitor service
    ///</summary>
    public class NetworkFlowMonitorPaginatorFactory : INetworkFlowMonitorPaginatorFactory
    {
        private readonly IAmazonNetworkFlowMonitor client;

        internal NetworkFlowMonitorPaginatorFactory(IAmazonNetworkFlowMonitor client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetQueryResultsMonitorTopContributors operation
        ///</summary>
        public IGetQueryResultsMonitorTopContributorsPaginator GetQueryResultsMonitorTopContributors(GetQueryResultsMonitorTopContributorsRequest request) 
        {
            return new GetQueryResultsMonitorTopContributorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetQueryResultsWorkloadInsightsTopContributors operation
        ///</summary>
        public IGetQueryResultsWorkloadInsightsTopContributorsPaginator GetQueryResultsWorkloadInsightsTopContributors(GetQueryResultsWorkloadInsightsTopContributorsRequest request) 
        {
            return new GetQueryResultsWorkloadInsightsTopContributorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetQueryResultsWorkloadInsightsTopContributorsData operation
        ///</summary>
        public IGetQueryResultsWorkloadInsightsTopContributorsDataPaginator GetQueryResultsWorkloadInsightsTopContributorsData(GetQueryResultsWorkloadInsightsTopContributorsDataRequest request) 
        {
            return new GetQueryResultsWorkloadInsightsTopContributorsDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        public IListMonitorsPaginator ListMonitors(ListMonitorsRequest request) 
        {
            return new ListMonitorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScopes operation
        ///</summary>
        public IListScopesPaginator ListScopes(ListScopesRequest request) 
        {
            return new ListScopesPaginator(this.client, request);
        }
    }
}