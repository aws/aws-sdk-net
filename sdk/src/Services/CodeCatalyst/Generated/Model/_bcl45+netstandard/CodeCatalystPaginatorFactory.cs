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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Paginators for the CodeCatalyst service
    ///</summary>
    public class CodeCatalystPaginatorFactory : ICodeCatalystPaginatorFactory
    {
        private readonly IAmazonCodeCatalyst client;

        internal CodeCatalystPaginatorFactory(IAmazonCodeCatalyst client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccessTokens operation
        ///</summary>
        public IListAccessTokensPaginator ListAccessTokens(ListAccessTokensRequest request) 
        {
            return new ListAccessTokensPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevEnvironments operation
        ///</summary>
        public IListDevEnvironmentsPaginator ListDevEnvironments(ListDevEnvironmentsRequest request) 
        {
            return new ListDevEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventLogs operation
        ///</summary>
        public IListEventLogsPaginator ListEventLogs(ListEventLogsRequest request) 
        {
            return new ListEventLogsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSourceRepositories operation
        ///</summary>
        public IListSourceRepositoriesPaginator ListSourceRepositories(ListSourceRepositoriesRequest request) 
        {
            return new ListSourceRepositoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSourceRepositoryBranches operation
        ///</summary>
        public IListSourceRepositoryBranchesPaginator ListSourceRepositoryBranches(ListSourceRepositoryBranchesRequest request) 
        {
            return new ListSourceRepositoryBranchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSpaces operation
        ///</summary>
        public IListSpacesPaginator ListSpaces(ListSpacesRequest request) 
        {
            return new ListSpacesPaginator(this.client, request);
        }
    }
}