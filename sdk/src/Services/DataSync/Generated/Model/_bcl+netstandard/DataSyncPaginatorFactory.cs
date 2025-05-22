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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Paginators for the DataSync service
    ///</summary>
    public class DataSyncPaginatorFactory : IDataSyncPaginatorFactory
    {
        private readonly IAmazonDataSync client;

        internal DataSyncPaginatorFactory(IAmazonDataSync client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAgents operation
        ///</summary>
        public IListAgentsPaginator ListAgents(ListAgentsRequest request) 
        {
            return new ListAgentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLocations operation
        ///</summary>
        public IListLocationsPaginator ListLocations(ListLocationsRequest request) 
        {
            return new ListLocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTaskExecutions operation
        ///</summary>
        public IListTaskExecutionsPaginator ListTaskExecutions(ListTaskExecutionsRequest request) 
        {
            return new ListTaskExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        public IListTasksPaginator ListTasks(ListTasksRequest request) 
        {
            return new ListTasksPaginator(this.client, request);
        }
    }
}