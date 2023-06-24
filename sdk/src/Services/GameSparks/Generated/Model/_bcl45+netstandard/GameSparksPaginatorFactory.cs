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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Paginators for the GameSparks service
    ///</summary>
    public class GameSparksPaginatorFactory : IGameSparksPaginatorFactory
    {
        private readonly IAmazonGameSparks client;

        internal GameSparksPaginatorFactory(IAmazonGameSparks client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListExtensions operation
        ///</summary>
        public IListExtensionsPaginator ListExtensions(ListExtensionsRequest request) 
        {
            return new ListExtensionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExtensionVersions operation
        ///</summary>
        public IListExtensionVersionsPaginator ListExtensionVersions(ListExtensionVersionsRequest request) 
        {
            return new ListExtensionVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGames operation
        ///</summary>
        public IListGamesPaginator ListGames(ListGamesRequest request) 
        {
            return new ListGamesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGeneratedCodeJobs operation
        ///</summary>
        public IListGeneratedCodeJobsPaginator ListGeneratedCodeJobs(ListGeneratedCodeJobsRequest request) 
        {
            return new ListGeneratedCodeJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSnapshots operation
        ///</summary>
        public IListSnapshotsPaginator ListSnapshots(ListSnapshotsRequest request) 
        {
            return new ListSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStageDeployments operation
        ///</summary>
        public IListStageDeploymentsPaginator ListStageDeployments(ListStageDeploymentsRequest request) 
        {
            return new ListStageDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStages operation
        ///</summary>
        public IListStagesPaginator ListStages(ListStagesRequest request) 
        {
            return new ListStagesPaginator(this.client, request);
        }
    }
}