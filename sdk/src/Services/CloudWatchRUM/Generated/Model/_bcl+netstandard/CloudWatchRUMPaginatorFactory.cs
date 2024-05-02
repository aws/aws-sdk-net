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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Paginators for the CloudWatchRUM service
    ///</summary>
    public class CloudWatchRUMPaginatorFactory : ICloudWatchRUMPaginatorFactory
    {
        private readonly IAmazonCloudWatchRUM client;

        internal CloudWatchRUMPaginatorFactory(IAmazonCloudWatchRUM client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for BatchGetRumMetricDefinitions operation
        ///</summary>
        public IBatchGetRumMetricDefinitionsPaginator BatchGetRumMetricDefinitions(BatchGetRumMetricDefinitionsRequest request) 
        {
            return new BatchGetRumMetricDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAppMonitorData operation
        ///</summary>
        public IGetAppMonitorDataPaginator GetAppMonitorData(GetAppMonitorDataRequest request) 
        {
            return new GetAppMonitorDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppMonitors operation
        ///</summary>
        public IListAppMonitorsPaginator ListAppMonitors(ListAppMonitorsRequest request) 
        {
            return new ListAppMonitorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRumMetricsDestinations operation
        ///</summary>
        public IListRumMetricsDestinationsPaginator ListRumMetricsDestinations(ListRumMetricsDestinationsRequest request) 
        {
            return new ListRumMetricsDestinationsPaginator(this.client, request);
        }
    }
}