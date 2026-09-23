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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Paginators for the NetworkSecurityManager service
    ///</summary>
    public class NetworkSecurityManagerPaginatorFactory : INetworkSecurityManagerPaginatorFactory
    {
        private readonly IAmazonNetworkSecurityManager client;

        internal NetworkSecurityManagerPaginatorFactory(IAmazonNetworkSecurityManager client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAdminAccounts operation
        ///</summary>
        public IListAdminAccountsPaginator ListAdminAccounts(ListAdminAccountsRequest request) 
        {
            return new ListAdminAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAggregateResourceSynchronizationStatuses operation
        ///</summary>
        public IListAggregateResourceSynchronizationStatusesPaginator ListAggregateResourceSynchronizationStatuses(ListAggregateResourceSynchronizationStatusesRequest request) 
        {
            return new ListAggregateResourceSynchronizationStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        public IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request) 
        {
            return new ListDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeploymentSnapshots operation
        ///</summary>
        public IListDeploymentSnapshotsPaginator ListDeploymentSnapshots(ListDeploymentSnapshotsRequest request) 
        {
            return new ListDeploymentSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicySnapshots operation
        ///</summary>
        public IListPolicySnapshotsPaginator ListPolicySnapshots(ListPolicySnapshotsRequest request) 
        {
            return new ListPolicySnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceAssociations operation
        ///</summary>
        public IListResourceAssociationsPaginator ListResourceAssociations(ListResourceAssociationsRequest request) 
        {
            return new ListResourceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceSynchronizationStatuses operation
        ///</summary>
        public IListResourceSynchronizationStatusesPaginator ListResourceSynchronizationStatuses(ListResourceSynchronizationStatusesRequest request) 
        {
            return new ListResourceSynchronizationStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        public IListRulesPaginator ListRules(ListRulesRequest request) 
        {
            return new ListRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRuleSnapshots operation
        ///</summary>
        public IListRuleSnapshotsPaginator ListRuleSnapshots(ListRuleSnapshotsRequest request) 
        {
            return new ListRuleSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScopes operation
        ///</summary>
        public IListScopesPaginator ListScopes(ListScopesRequest request) 
        {
            return new ListScopesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScopeSnapshots operation
        ///</summary>
        public IListScopeSnapshotsPaginator ListScopeSnapshots(ListScopeSnapshotsRequest request) 
        {
            return new ListScopeSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        public IListTemplatesPaginator ListTemplates(ListTemplatesRequest request) 
        {
            return new ListTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateSnapshots operation
        ///</summary>
        public IListTemplateSnapshotsPaginator ListTemplateSnapshots(ListTemplateSnapshotsRequest request) 
        {
            return new ListTemplateSnapshotsPaginator(this.client, request);
        }
    }
}