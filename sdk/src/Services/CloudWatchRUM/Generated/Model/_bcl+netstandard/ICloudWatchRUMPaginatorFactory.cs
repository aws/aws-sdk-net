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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Paginators for the CloudWatchRUM service
    ///</summary>
    public interface ICloudWatchRUMPaginatorFactory
    {

        /// <summary>
        /// Paginator for BatchGetRumMetricDefinitions operation
        ///</summary>
        IBatchGetRumMetricDefinitionsPaginator BatchGetRumMetricDefinitions(BatchGetRumMetricDefinitionsRequest request);

        /// <summary>
        /// Paginator for GetAppMonitorData operation
        ///</summary>
        IGetAppMonitorDataPaginator GetAppMonitorData(GetAppMonitorDataRequest request);

        /// <summary>
        /// Paginator for ListAppMonitors operation
        ///</summary>
        IListAppMonitorsPaginator ListAppMonitors(ListAppMonitorsRequest request);

        /// <summary>
        /// Paginator for ListRumMetricsDestinations operation
        ///</summary>
        IListRumMetricsDestinationsPaginator ListRumMetricsDestinations(ListRumMetricsDestinationsRequest request);
    }
}