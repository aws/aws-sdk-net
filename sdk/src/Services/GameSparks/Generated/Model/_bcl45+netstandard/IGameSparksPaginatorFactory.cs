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

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Paginators for the GameSparks service
    ///</summary>
    public interface IGameSparksPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListExtensions operation
        ///</summary>
        IListExtensionsPaginator ListExtensions(ListExtensionsRequest request);

        /// <summary>
        /// Paginator for ListExtensionVersions operation
        ///</summary>
        IListExtensionVersionsPaginator ListExtensionVersions(ListExtensionVersionsRequest request);

        /// <summary>
        /// Paginator for ListGames operation
        ///</summary>
        IListGamesPaginator ListGames(ListGamesRequest request);

        /// <summary>
        /// Paginator for ListGeneratedCodeJobs operation
        ///</summary>
        IListGeneratedCodeJobsPaginator ListGeneratedCodeJobs(ListGeneratedCodeJobsRequest request);

        /// <summary>
        /// Paginator for ListSnapshots operation
        ///</summary>
        IListSnapshotsPaginator ListSnapshots(ListSnapshotsRequest request);

        /// <summary>
        /// Paginator for ListStageDeployments operation
        ///</summary>
        IListStageDeploymentsPaginator ListStageDeployments(ListStageDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListStages operation
        ///</summary>
        IListStagesPaginator ListStages(ListStagesRequest request);
    }
}