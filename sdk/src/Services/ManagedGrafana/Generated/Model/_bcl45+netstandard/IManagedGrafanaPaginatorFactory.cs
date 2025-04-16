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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Paginators for the ManagedGrafana service
    ///</summary>
    public interface IManagedGrafanaPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPermissionsPaginator ListPermissions(ListPermissionsRequest request);

        /// <summary>
        /// Paginator for ListVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVersionsPaginator ListVersions(ListVersionsRequest request);

        /// <summary>
        /// Paginator for ListWorkspaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request);

        /// <summary>
        /// Paginator for ListWorkspaceServiceAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkspaceServiceAccountsPaginator ListWorkspaceServiceAccounts(ListWorkspaceServiceAccountsRequest request);

        /// <summary>
        /// Paginator for ListWorkspaceServiceAccountTokens operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkspaceServiceAccountTokensPaginator ListWorkspaceServiceAccountTokens(ListWorkspaceServiceAccountTokensRequest request);
    }
}