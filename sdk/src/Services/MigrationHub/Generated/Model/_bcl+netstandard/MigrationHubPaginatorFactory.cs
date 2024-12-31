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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Paginators for the MigrationHub service
    ///</summary>
    public class MigrationHubPaginatorFactory : IMigrationHubPaginatorFactory
    {
        private readonly IAmazonMigrationHub client;

        internal MigrationHubPaginatorFactory(IAmazonMigrationHub client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplicationStates operation
        ///</summary>
        public IListApplicationStatesPaginator ListApplicationStates(ListApplicationStatesRequest request) 
        {
            return new ListApplicationStatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCreatedArtifacts operation
        ///</summary>
        public IListCreatedArtifactsPaginator ListCreatedArtifacts(ListCreatedArtifactsRequest request) 
        {
            return new ListCreatedArtifactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDiscoveredResources operation
        ///</summary>
        public IListDiscoveredResourcesPaginator ListDiscoveredResources(ListDiscoveredResourcesRequest request) 
        {
            return new ListDiscoveredResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMigrationTasks operation
        ///</summary>
        public IListMigrationTasksPaginator ListMigrationTasks(ListMigrationTasksRequest request) 
        {
            return new ListMigrationTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMigrationTaskUpdates operation
        ///</summary>
        public IListMigrationTaskUpdatesPaginator ListMigrationTaskUpdates(ListMigrationTaskUpdatesRequest request) 
        {
            return new ListMigrationTaskUpdatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProgressUpdateStreams operation
        ///</summary>
        public IListProgressUpdateStreamsPaginator ListProgressUpdateStreams(ListProgressUpdateStreamsRequest request) 
        {
            return new ListProgressUpdateStreamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSourceResources operation
        ///</summary>
        public IListSourceResourcesPaginator ListSourceResources(ListSourceResourcesRequest request) 
        {
            return new ListSourceResourcesPaginator(this.client, request);
        }
    }
}