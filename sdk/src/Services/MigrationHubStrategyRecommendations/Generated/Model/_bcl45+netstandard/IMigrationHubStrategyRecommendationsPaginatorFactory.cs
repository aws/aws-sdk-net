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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Paginators for the MigrationHubStrategyRecommendations service
    ///</summary>
    public interface IMigrationHubStrategyRecommendationsPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetServerDetails operation
        ///</summary>
        IGetServerDetailsPaginator GetServerDetails(GetServerDetailsRequest request);

        /// <summary>
        /// Paginator for ListApplicationComponents operation
        ///</summary>
        IListApplicationComponentsPaginator ListApplicationComponents(ListApplicationComponentsRequest request);

        /// <summary>
        /// Paginator for ListCollectors operation
        ///</summary>
        IListCollectorsPaginator ListCollectors(ListCollectorsRequest request);

        /// <summary>
        /// Paginator for ListImportFileTask operation
        ///</summary>
        IListImportFileTaskPaginator ListImportFileTask(ListImportFileTaskRequest request);

        /// <summary>
        /// Paginator for ListServers operation
        ///</summary>
        IListServersPaginator ListServers(ListServersRequest request);
    }
}