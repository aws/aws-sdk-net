#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Paginators for the Organizations service
    ///</summary>
    public interface IOrganizationsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccounts operation
        ///</summary>
        IListAccountsPaginator ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Paginator for ListAccountsForParent operation
        ///</summary>
        IListAccountsForParentPaginator ListAccountsForParent(ListAccountsForParentRequest request);

        /// <summary>
        /// Paginator for ListAWSServiceAccessForOrganization operation
        ///</summary>
        IListAWSServiceAccessForOrganizationPaginator ListAWSServiceAccessForOrganization(ListAWSServiceAccessForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListChildren operation
        ///</summary>
        IListChildrenPaginator ListChildren(ListChildrenRequest request);

        /// <summary>
        /// Paginator for ListCreateAccountStatus operation
        ///</summary>
        IListCreateAccountStatusPaginator ListCreateAccountStatus(ListCreateAccountStatusRequest request);

        /// <summary>
        /// Paginator for ListDelegatedAdministrators operation
        ///</summary>
        IListDelegatedAdministratorsPaginator ListDelegatedAdministrators(ListDelegatedAdministratorsRequest request);

        /// <summary>
        /// Paginator for ListDelegatedServicesForAccount operation
        ///</summary>
        IListDelegatedServicesForAccountPaginator ListDelegatedServicesForAccount(ListDelegatedServicesForAccountRequest request);

        /// <summary>
        /// Paginator for ListHandshakesForAccount operation
        ///</summary>
        IListHandshakesForAccountPaginator ListHandshakesForAccount(ListHandshakesForAccountRequest request);

        /// <summary>
        /// Paginator for ListHandshakesForOrganization operation
        ///</summary>
        IListHandshakesForOrganizationPaginator ListHandshakesForOrganization(ListHandshakesForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListOrganizationalUnitsForParent operation
        ///</summary>
        IListOrganizationalUnitsForParentPaginator ListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request);

        /// <summary>
        /// Paginator for ListParents operation
        ///</summary>
        IListParentsPaginator ListParents(ListParentsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPoliciesForTarget operation
        ///</summary>
        IListPoliciesForTargetPaginator ListPoliciesForTarget(ListPoliciesForTargetRequest request);

        /// <summary>
        /// Paginator for ListRoots operation
        ///</summary>
        IListRootsPaginator ListRoots(ListRootsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTargetsForPolicy operation
        ///</summary>
        IListTargetsForPolicyPaginator ListTargetsForPolicy(ListTargetsForPolicyRequest request);
    }
}
#endif