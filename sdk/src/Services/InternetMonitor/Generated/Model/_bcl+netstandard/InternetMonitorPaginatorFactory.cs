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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Paginators for the InternetMonitor service
    ///</summary>
    public class InternetMonitorPaginatorFactory : IInternetMonitorPaginatorFactory
    {
        private readonly IAmazonInternetMonitor client;

        internal InternetMonitorPaginatorFactory(IAmazonInternetMonitor client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetQueryResults operation
        ///</summary>
        public IGetQueryResultsPaginator GetQueryResults(GetQueryResultsRequest request) 
        {
            return new GetQueryResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHealthEvents operation
        ///</summary>
        public IListHealthEventsPaginator ListHealthEvents(ListHealthEventsRequest request) 
        {
            return new ListHealthEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInternetEvents operation
        ///</summary>
        public IListInternetEventsPaginator ListInternetEvents(ListInternetEventsRequest request) 
        {
            return new ListInternetEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        public IListMonitorsPaginator ListMonitors(ListMonitorsRequest request) 
        {
            return new ListMonitorsPaginator(this.client, request);
        }
    }
}