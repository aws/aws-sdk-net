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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Paginators for the CodeCatalyst service
    ///</summary>
    public interface ICodeCatalystPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccessTokens operation
        ///</summary>
        IListAccessTokensPaginator ListAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Paginator for ListDevEnvironments operation
        ///</summary>
        IListDevEnvironmentsPaginator ListDevEnvironments(ListDevEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListEventLogs operation
        ///</summary>
        IListEventLogsPaginator ListEventLogs(ListEventLogsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListSourceRepositories operation
        ///</summary>
        IListSourceRepositoriesPaginator ListSourceRepositories(ListSourceRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListSourceRepositoryBranches operation
        ///</summary>
        IListSourceRepositoryBranchesPaginator ListSourceRepositoryBranches(ListSourceRepositoryBranchesRequest request);

        /// <summary>
        /// Paginator for ListSpaces operation
        ///</summary>
        IListSpacesPaginator ListSpaces(ListSpacesRequest request);
    }
}