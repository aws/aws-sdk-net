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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetServerDetailsPaginator GetServerDetails(GetServerDetailsRequest request);

        /// <summary>
        /// Paginator for ListAnalyzableServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnalyzableServersPaginator ListAnalyzableServers(ListAnalyzableServersRequest request);

        /// <summary>
        /// Paginator for ListApplicationComponents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationComponentsPaginator ListApplicationComponents(ListApplicationComponentsRequest request);

        /// <summary>
        /// Paginator for ListCollectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCollectorsPaginator ListCollectors(ListCollectorsRequest request);

        /// <summary>
        /// Paginator for ListImportFileTask operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportFileTaskPaginator ListImportFileTask(ListImportFileTaskRequest request);

        /// <summary>
        /// Paginator for ListServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListServersPaginator ListServers(ListServersRequest request);
    }
}