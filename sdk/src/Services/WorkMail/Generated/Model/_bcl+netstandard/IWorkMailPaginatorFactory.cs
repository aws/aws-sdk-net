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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListAvailabilityConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAvailabilityConfigurationsPaginator ListAvailabilityConfigurations(ListAvailabilityConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListGroupMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroupMembersPaginator ListGroupMembers(ListGroupMembersRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListGroupsForEntity operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroupsForEntityPaginator ListGroupsForEntity(ListGroupsForEntityRequest request);

        /// <summary>
        /// Paginator for ListImpersonationRoles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImpersonationRolesPaginator ListImpersonationRoles(ListImpersonationRolesRequest request);

        /// <summary>
        /// Paginator for ListMailboxExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMailboxExportJobsPaginator ListMailboxExportJobs(ListMailboxExportJobsRequest request);

        /// <summary>
        /// Paginator for ListMailboxPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMailboxPermissionsPaginator ListMailboxPermissions(ListMailboxPermissionsRequest request);

        /// <summary>
        /// Paginator for ListMailDomains operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMailDomainsPaginator ListMailDomains(ListMailDomainsRequest request);

        /// <summary>
        /// Paginator for ListMobileDeviceAccessOverrides operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMobileDeviceAccessOverridesPaginator ListMobileDeviceAccessOverrides(ListMobileDeviceAccessOverridesRequest request);

        /// <summary>
        /// Paginator for ListOrganizations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationsPaginator ListOrganizations(ListOrganizationsRequest request);

        /// <summary>
        /// Paginator for ListPersonalAccessTokens operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPersonalAccessTokensPaginator ListPersonalAccessTokens(ListPersonalAccessTokensRequest request);

        /// <summary>
        /// Paginator for ListResourceDelegates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceDelegatesPaginator ListResourceDelegates(ListResourceDelegatesRequest request);

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourcesPaginator ListResources(ListResourcesRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUsersPaginator ListUsers(ListUsersRequest request);
    }
}