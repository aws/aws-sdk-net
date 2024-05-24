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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Paginators for the ManagedGrafana service
    ///</summary>
    public class ManagedGrafanaPaginatorFactory : IManagedGrafanaPaginatorFactory
    {
        private readonly IAmazonManagedGrafana client;

        internal ManagedGrafanaPaginatorFactory(IAmazonManagedGrafana client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        public IListPermissionsPaginator ListPermissions(ListPermissionsRequest request) 
        {
            return new ListPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVersions operation
        ///</summary>
        public IListVersionsPaginator ListVersions(ListVersionsRequest request) 
        {
            return new ListVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkspaces operation
        ///</summary>
        public IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request) 
        {
            return new ListWorkspacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkspaceServiceAccounts operation
        ///</summary>
        public IListWorkspaceServiceAccountsPaginator ListWorkspaceServiceAccounts(ListWorkspaceServiceAccountsRequest request) 
        {
            return new ListWorkspaceServiceAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkspaceServiceAccountTokens operation
        ///</summary>
        public IListWorkspaceServiceAccountTokensPaginator ListWorkspaceServiceAccountTokens(ListWorkspaceServiceAccountTokensRequest request) 
        {
            return new ListWorkspaceServiceAccountTokensPaginator(this.client, request);
        }
    }
}