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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Paginators for the MigrationHubStrategyRecommendations service
    ///</summary>
    public class MigrationHubStrategyRecommendationsPaginatorFactory : IMigrationHubStrategyRecommendationsPaginatorFactory
    {
        private readonly IAmazonMigrationHubStrategyRecommendations client;

        internal MigrationHubStrategyRecommendationsPaginatorFactory(IAmazonMigrationHubStrategyRecommendations client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetServerDetails operation
        ///</summary>
        public IGetServerDetailsPaginator GetServerDetails(GetServerDetailsRequest request) 
        {
            return new GetServerDetailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnalyzableServers operation
        ///</summary>
        public IListAnalyzableServersPaginator ListAnalyzableServers(ListAnalyzableServersRequest request) 
        {
            return new ListAnalyzableServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplicationComponents operation
        ///</summary>
        public IListApplicationComponentsPaginator ListApplicationComponents(ListApplicationComponentsRequest request) 
        {
            return new ListApplicationComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCollectors operation
        ///</summary>
        public IListCollectorsPaginator ListCollectors(ListCollectorsRequest request) 
        {
            return new ListCollectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImportFileTask operation
        ///</summary>
        public IListImportFileTaskPaginator ListImportFileTask(ListImportFileTaskRequest request) 
        {
            return new ListImportFileTaskPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServers operation
        ///</summary>
        public IListServersPaginator ListServers(ListServersRequest request) 
        {
            return new ListServersPaginator(this.client, request);
        }
    }
}