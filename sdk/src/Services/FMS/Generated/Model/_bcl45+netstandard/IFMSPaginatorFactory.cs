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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Paginators for the FMS service
    ///</summary>
    public interface IFMSPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAdminAccountsForOrganization operation
        ///</summary>
        IListAdminAccountsForOrganizationPaginator ListAdminAccountsForOrganization(ListAdminAccountsForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListAdminsManagingAccount operation
        ///</summary>
        IListAdminsManagingAccountPaginator ListAdminsManagingAccount(ListAdminsManagingAccountRequest request);

        /// <summary>
        /// Paginator for ListAppsLists operation
        ///</summary>
        IListAppsListsPaginator ListAppsLists(ListAppsListsRequest request);

        /// <summary>
        /// Paginator for ListComplianceStatus operation
        ///</summary>
        IListComplianceStatusPaginator ListComplianceStatus(ListComplianceStatusRequest request);

        /// <summary>
        /// Paginator for ListMemberAccounts operation
        ///</summary>
        IListMemberAccountsPaginator ListMemberAccounts(ListMemberAccountsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListProtocolsLists operation
        ///</summary>
        IListProtocolsListsPaginator ListProtocolsLists(ListProtocolsListsRequest request);

        /// <summary>
        /// Paginator for ListThirdPartyFirewallFirewallPolicies operation
        ///</summary>
        IListThirdPartyFirewallFirewallPoliciesPaginator ListThirdPartyFirewallFirewallPolicies(ListThirdPartyFirewallFirewallPoliciesRequest request);
    }
}