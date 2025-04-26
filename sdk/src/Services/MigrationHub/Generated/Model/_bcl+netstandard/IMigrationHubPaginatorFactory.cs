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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationStatesPaginator ListApplicationStates(ListApplicationStatesRequest request);

        /// <summary>
        /// Paginator for ListCreatedArtifacts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCreatedArtifactsPaginator ListCreatedArtifacts(ListCreatedArtifactsRequest request);

        /// <summary>
        /// Paginator for ListDiscoveredResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDiscoveredResourcesPaginator ListDiscoveredResources(ListDiscoveredResourcesRequest request);

        /// <summary>
        /// Paginator for ListMigrationTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMigrationTasksPaginator ListMigrationTasks(ListMigrationTasksRequest request);

        /// <summary>
        /// Paginator for ListMigrationTaskUpdates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMigrationTaskUpdatesPaginator ListMigrationTaskUpdates(ListMigrationTaskUpdatesRequest request);

        /// <summary>
        /// Paginator for ListProgressUpdateStreams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProgressUpdateStreamsPaginator ListProgressUpdateStreams(ListProgressUpdateStreamsRequest request);

        /// <summary>
        /// Paginator for ListSourceResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSourceResourcesPaginator ListSourceResources(ListSourceResourcesRequest request);
    }
}