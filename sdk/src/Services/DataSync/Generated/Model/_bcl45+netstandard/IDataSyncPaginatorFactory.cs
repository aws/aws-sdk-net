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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Paginators for the DataSync service
    ///</summary>
    public interface IDataSyncPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeStorageSystemResourceMetrics operation
        ///</summary>
        IDescribeStorageSystemResourceMetricsPaginator DescribeStorageSystemResourceMetrics(DescribeStorageSystemResourceMetricsRequest request);

        /// <summary>
        /// Paginator for DescribeStorageSystemResources operation
        ///</summary>
        IDescribeStorageSystemResourcesPaginator DescribeStorageSystemResources(DescribeStorageSystemResourcesRequest request);

        /// <summary>
        /// Paginator for ListAgents operation
        ///</summary>
        IListAgentsPaginator ListAgents(ListAgentsRequest request);

        /// <summary>
        /// Paginator for ListDiscoveryJobs operation
        ///</summary>
        IListDiscoveryJobsPaginator ListDiscoveryJobs(ListDiscoveryJobsRequest request);

        /// <summary>
        /// Paginator for ListLocations operation
        ///</summary>
        IListLocationsPaginator ListLocations(ListLocationsRequest request);

        /// <summary>
        /// Paginator for ListStorageSystems operation
        ///</summary>
        IListStorageSystemsPaginator ListStorageSystems(ListStorageSystemsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTaskExecutions operation
        ///</summary>
        IListTaskExecutionsPaginator ListTaskExecutions(ListTaskExecutionsRequest request);

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        IListTasksPaginator ListTasks(ListTasksRequest request);
    }
}