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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Paginators for the Organizations service
    /// </summary>
    public interface IOrganizationsPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAWSServiceAccessForOrganization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAWSServiceAccessForOrganizationPaginator ListAWSServiceAccessForOrganization(ListAWSServiceAccessForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListAccounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountsPaginator ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Paginator for ListAccountsForParent operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountsForParentPaginator ListAccountsForParent(ListAccountsForParentRequest request);

        /// <summary>
        /// Paginator for ListAccountsWithInvalidEffectivePolicy operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountsWithInvalidEffectivePolicyPaginator ListAccountsWithInvalidEffectivePolicy(ListAccountsWithInvalidEffectivePolicyRequest request);

        /// <summary>
        /// Paginator for ListChildren operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChildrenPaginator ListChildren(ListChildrenRequest request);

        /// <summary>
        /// Paginator for ListCreateAccountStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCreateAccountStatusPaginator ListCreateAccountStatus(ListCreateAccountStatusRequest request);

        /// <summary>
        /// Paginator for ListDelegatedAdministrators operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDelegatedAdministratorsPaginator ListDelegatedAdministrators(ListDelegatedAdministratorsRequest request);

        /// <summary>
        /// Paginator for ListDelegatedServicesForAccount operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDelegatedServicesForAccountPaginator ListDelegatedServicesForAccount(ListDelegatedServicesForAccountRequest request);

        /// <summary>
        /// Paginator for ListEffectivePolicyValidationErrors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEffectivePolicyValidationErrorsPaginator ListEffectivePolicyValidationErrors(ListEffectivePolicyValidationErrorsRequest request);

        /// <summary>
        /// Paginator for ListHandshakesForAccount operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHandshakesForAccountPaginator ListHandshakesForAccount(ListHandshakesForAccountRequest request);

        /// <summary>
        /// Paginator for ListHandshakesForOrganization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHandshakesForOrganizationPaginator ListHandshakesForOrganization(ListHandshakesForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListOrganizationalUnitsForParent operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOrganizationalUnitsForParentPaginator ListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request);

        /// <summary>
        /// Paginator for ListParents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListParentsPaginator ListParents(ListParentsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPoliciesForTarget operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPoliciesForTargetPaginator ListPoliciesForTarget(ListPoliciesForTargetRequest request);

        /// <summary>
        /// Paginator for ListRoots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRootsPaginator ListRoots(ListRootsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTargetsForPolicy operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTargetsForPolicyPaginator ListTargetsForPolicy(ListTargetsForPolicyRequest request);
    }
}
