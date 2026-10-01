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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Paginators for the CodeCatalyst service
    /// </summary>
    public interface ICodeCatalystPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccessTokens operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessTokensPaginator ListAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Paginator for ListDevEnvironmentSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDevEnvironmentSessionsPaginator ListDevEnvironmentSessions(ListDevEnvironmentSessionsRequest request);

        /// <summary>
        /// Paginator for ListDevEnvironments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDevEnvironmentsPaginator ListDevEnvironments(ListDevEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListEventLogs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventLogsPaginator ListEventLogs(ListEventLogsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListSourceRepositories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSourceRepositoriesPaginator ListSourceRepositories(ListSourceRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListSourceRepositoryBranches operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSourceRepositoryBranchesPaginator ListSourceRepositoryBranches(ListSourceRepositoryBranchesRequest request);

        /// <summary>
        /// Paginator for ListSpaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListSpacesPaginator ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Paginator for ListWorkflowRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkflowRunsPaginator ListWorkflowRuns(ListWorkflowRunsRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);
    }
}
