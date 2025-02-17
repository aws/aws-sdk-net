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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Paginators for the WorkMail service
    ///</summary>
    public class WorkMailPaginatorFactory : IWorkMailPaginatorFactory
    {
        private readonly IAmazonWorkMail client;

        internal WorkMailPaginatorFactory(IAmazonWorkMail client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        public IListAliasesPaginator ListAliases(ListAliasesRequest request) 
        {
            return new ListAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAvailabilityConfigurations operation
        ///</summary>
        public IListAvailabilityConfigurationsPaginator ListAvailabilityConfigurations(ListAvailabilityConfigurationsRequest request) 
        {
            return new ListAvailabilityConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupMembers operation
        ///</summary>
        public IListGroupMembersPaginator ListGroupMembers(ListGroupMembersRequest request) 
        {
            return new ListGroupMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupsForEntity operation
        ///</summary>
        public IListGroupsForEntityPaginator ListGroupsForEntity(ListGroupsForEntityRequest request) 
        {
            return new ListGroupsForEntityPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImpersonationRoles operation
        ///</summary>
        public IListImpersonationRolesPaginator ListImpersonationRoles(ListImpersonationRolesRequest request) 
        {
            return new ListImpersonationRolesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMailboxExportJobs operation
        ///</summary>
        public IListMailboxExportJobsPaginator ListMailboxExportJobs(ListMailboxExportJobsRequest request) 
        {
            return new ListMailboxExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMailboxPermissions operation
        ///</summary>
        public IListMailboxPermissionsPaginator ListMailboxPermissions(ListMailboxPermissionsRequest request) 
        {
            return new ListMailboxPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMailDomains operation
        ///</summary>
        public IListMailDomainsPaginator ListMailDomains(ListMailDomainsRequest request) 
        {
            return new ListMailDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMobileDeviceAccessOverrides operation
        ///</summary>
        public IListMobileDeviceAccessOverridesPaginator ListMobileDeviceAccessOverrides(ListMobileDeviceAccessOverridesRequest request) 
        {
            return new ListMobileDeviceAccessOverridesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizations operation
        ///</summary>
        public IListOrganizationsPaginator ListOrganizations(ListOrganizationsRequest request) 
        {
            return new ListOrganizationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPersonalAccessTokens operation
        ///</summary>
        public IListPersonalAccessTokensPaginator ListPersonalAccessTokens(ListPersonalAccessTokensRequest request) 
        {
            return new ListPersonalAccessTokensPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceDelegates operation
        ///</summary>
        public IListResourceDelegatesPaginator ListResourceDelegates(ListResourceDelegatesRequest request) 
        {
            return new ListResourceDelegatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        public IListResourcesPaginator ListResources(ListResourcesRequest request) 
        {
            return new ListResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }
    }
}