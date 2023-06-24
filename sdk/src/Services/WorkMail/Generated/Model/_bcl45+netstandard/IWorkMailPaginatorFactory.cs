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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Paginators for the WorkMail service
    ///</summary>
    public interface IWorkMailPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListAvailabilityConfigurations operation
        ///</summary>
        IListAvailabilityConfigurationsPaginator ListAvailabilityConfigurations(ListAvailabilityConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListGroupMembers operation
        ///</summary>
        IListGroupMembersPaginator ListGroupMembers(ListGroupMembersRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListImpersonationRoles operation
        ///</summary>
        IListImpersonationRolesPaginator ListImpersonationRoles(ListImpersonationRolesRequest request);

        /// <summary>
        /// Paginator for ListMailboxExportJobs operation
        ///</summary>
        IListMailboxExportJobsPaginator ListMailboxExportJobs(ListMailboxExportJobsRequest request);

        /// <summary>
        /// Paginator for ListMailboxPermissions operation
        ///</summary>
        IListMailboxPermissionsPaginator ListMailboxPermissions(ListMailboxPermissionsRequest request);

        /// <summary>
        /// Paginator for ListMailDomains operation
        ///</summary>
        IListMailDomainsPaginator ListMailDomains(ListMailDomainsRequest request);

        /// <summary>
        /// Paginator for ListMobileDeviceAccessOverrides operation
        ///</summary>
        IListMobileDeviceAccessOverridesPaginator ListMobileDeviceAccessOverrides(ListMobileDeviceAccessOverridesRequest request);

        /// <summary>
        /// Paginator for ListOrganizations operation
        ///</summary>
        IListOrganizationsPaginator ListOrganizations(ListOrganizationsRequest request);

        /// <summary>
        /// Paginator for ListResourceDelegates operation
        ///</summary>
        IListResourceDelegatesPaginator ListResourceDelegates(ListResourceDelegatesRequest request);

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        IListResourcesPaginator ListResources(ListResourcesRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);
    }
}