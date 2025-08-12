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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Paginators for the Organizations service
    ///</summary>
    public class OrganizationsPaginatorFactory : IOrganizationsPaginatorFactory
    {
        private readonly IAmazonOrganizations client;

        internal OrganizationsPaginatorFactory(IAmazonOrganizations client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccounts operation
        ///</summary>
        public IListAccountsPaginator ListAccounts(ListAccountsRequest request) 
        {
            return new ListAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountsForParent operation
        ///</summary>
        public IListAccountsForParentPaginator ListAccountsForParent(ListAccountsForParentRequest request) 
        {
            return new ListAccountsForParentPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountsWithInvalidEffectivePolicy operation
        ///</summary>
        public IListAccountsWithInvalidEffectivePolicyPaginator ListAccountsWithInvalidEffectivePolicy(ListAccountsWithInvalidEffectivePolicyRequest request) 
        {
            return new ListAccountsWithInvalidEffectivePolicyPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAWSServiceAccessForOrganization operation
        ///</summary>
        public IListAWSServiceAccessForOrganizationPaginator ListAWSServiceAccessForOrganization(ListAWSServiceAccessForOrganizationRequest request) 
        {
            return new ListAWSServiceAccessForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChildren operation
        ///</summary>
        public IListChildrenPaginator ListChildren(ListChildrenRequest request) 
        {
            return new ListChildrenPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCreateAccountStatus operation
        ///</summary>
        public IListCreateAccountStatusPaginator ListCreateAccountStatus(ListCreateAccountStatusRequest request) 
        {
            return new ListCreateAccountStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDelegatedAdministrators operation
        ///</summary>
        public IListDelegatedAdministratorsPaginator ListDelegatedAdministrators(ListDelegatedAdministratorsRequest request) 
        {
            return new ListDelegatedAdministratorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDelegatedServicesForAccount operation
        ///</summary>
        public IListDelegatedServicesForAccountPaginator ListDelegatedServicesForAccount(ListDelegatedServicesForAccountRequest request) 
        {
            return new ListDelegatedServicesForAccountPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEffectivePolicyValidationErrors operation
        ///</summary>
        public IListEffectivePolicyValidationErrorsPaginator ListEffectivePolicyValidationErrors(ListEffectivePolicyValidationErrorsRequest request) 
        {
            return new ListEffectivePolicyValidationErrorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHandshakesForAccount operation
        ///</summary>
        public IListHandshakesForAccountPaginator ListHandshakesForAccount(ListHandshakesForAccountRequest request) 
        {
            return new ListHandshakesForAccountPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHandshakesForOrganization operation
        ///</summary>
        public IListHandshakesForOrganizationPaginator ListHandshakesForOrganization(ListHandshakesForOrganizationRequest request) 
        {
            return new ListHandshakesForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationalUnitsForParent operation
        ///</summary>
        public IListOrganizationalUnitsForParentPaginator ListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request) 
        {
            return new ListOrganizationalUnitsForParentPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListParents operation
        ///</summary>
        public IListParentsPaginator ListParents(ListParentsRequest request) 
        {
            return new ListParentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPoliciesForTarget operation
        ///</summary>
        public IListPoliciesForTargetPaginator ListPoliciesForTarget(ListPoliciesForTargetRequest request) 
        {
            return new ListPoliciesForTargetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoots operation
        ///</summary>
        public IListRootsPaginator ListRoots(ListRootsRequest request) 
        {
            return new ListRootsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetsForPolicy operation
        ///</summary>
        public IListTargetsForPolicyPaginator ListTargetsForPolicy(ListTargetsForPolicyRequest request) 
        {
            return new ListTargetsForPolicyPaginator(this.client, request);
        }
    }
}