#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Paginators for the MigrationHub service
    ///</summary>
    public interface IMigrationHubPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplicationStates operation
        ///</summary>
        IListApplicationStatesPaginator ListApplicationStates(ListApplicationStatesRequest request);

        /// <summary>
        /// Paginator for ListCreatedArtifacts operation
        ///</summary>
        IListCreatedArtifactsPaginator ListCreatedArtifacts(ListCreatedArtifactsRequest request);

        /// <summary>
        /// Paginator for ListDiscoveredResources operation
        ///</summary>
        IListDiscoveredResourcesPaginator ListDiscoveredResources(ListDiscoveredResourcesRequest request);

        /// <summary>
        /// Paginator for ListMigrationTasks operation
        ///</summary>
        IListMigrationTasksPaginator ListMigrationTasks(ListMigrationTasksRequest request);

        /// <summary>
        /// Paginator for ListProgressUpdateStreams operation
        ///</summary>
        IListProgressUpdateStreamsPaginator ListProgressUpdateStreams(ListProgressUpdateStreamsRequest request);
    }
}
#endif