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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Paginators for the SSOAdmin service
    ///</summary>
    public class SSOAdminPaginatorFactory : ISSOAdminPaginatorFactory
    {
        private readonly IAmazonSSOAdmin client;

        internal SSOAdminPaginatorFactory(IAmazonSSOAdmin client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccountAssignmentCreationStatus operation
        ///</summary>
        public IListAccountAssignmentCreationStatusPaginator ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request) 
        {
            return new ListAccountAssignmentCreationStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountAssignmentDeletionStatus operation
        ///</summary>
        public IListAccountAssignmentDeletionStatusPaginator ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request) 
        {
            return new ListAccountAssignmentDeletionStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountAssignments operation
        ///</summary>
        public IListAccountAssignmentsPaginator ListAccountAssignments(ListAccountAssignmentsRequest request) 
        {
            return new ListAccountAssignmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountsForProvisionedPermissionSet operation
        ///</summary>
        public IListAccountsForProvisionedPermissionSetPaginator ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request) 
        {
            return new ListAccountsForProvisionedPermissionSetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        public IListInstancesPaginator ListInstances(ListInstancesRequest request) 
        {
            return new ListInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedPoliciesInPermissionSet operation
        ///</summary>
        public IListManagedPoliciesInPermissionSetPaginator ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request) 
        {
            return new ListManagedPoliciesInPermissionSetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPermissionSetProvisioningStatus operation
        ///</summary>
        public IListPermissionSetProvisioningStatusPaginator ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request) 
        {
            return new ListPermissionSetProvisioningStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPermissionSets operation
        ///</summary>
        public IListPermissionSetsPaginator ListPermissionSets(ListPermissionSetsRequest request) 
        {
            return new ListPermissionSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPermissionSetsProvisionedToAccount operation
        ///</summary>
        public IListPermissionSetsProvisionedToAccountPaginator ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request) 
        {
            return new ListPermissionSetsProvisionedToAccountPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}