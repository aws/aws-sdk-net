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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccountsPaginator ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Paginator for ListAccountsForParent operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccountsForParentPaginator ListAccountsForParent(ListAccountsForParentRequest request);

        /// <summary>
        /// Paginator for ListAccountsWithInvalidEffectivePolicy operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccountsWithInvalidEffectivePolicyPaginator ListAccountsWithInvalidEffectivePolicy(ListAccountsWithInvalidEffectivePolicyRequest request);

        /// <summary>
        /// Paginator for ListAWSServiceAccessForOrganization operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAWSServiceAccessForOrganizationPaginator ListAWSServiceAccessForOrganization(ListAWSServiceAccessForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListChildren operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListChildrenPaginator ListChildren(ListChildrenRequest request);

        /// <summary>
        /// Paginator for ListCreateAccountStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCreateAccountStatusPaginator ListCreateAccountStatus(ListCreateAccountStatusRequest request);

        /// <summary>
        /// Paginator for ListDelegatedAdministrators operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDelegatedAdministratorsPaginator ListDelegatedAdministrators(ListDelegatedAdministratorsRequest request);

        /// <summary>
        /// Paginator for ListDelegatedServicesForAccount operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDelegatedServicesForAccountPaginator ListDelegatedServicesForAccount(ListDelegatedServicesForAccountRequest request);

        /// <summary>
        /// Paginator for ListEffectivePolicyValidationErrors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEffectivePolicyValidationErrorsPaginator ListEffectivePolicyValidationErrors(ListEffectivePolicyValidationErrorsRequest request);

        /// <summary>
        /// Paginator for ListHandshakesForAccount operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHandshakesForAccountPaginator ListHandshakesForAccount(ListHandshakesForAccountRequest request);

        /// <summary>
        /// Paginator for ListHandshakesForOrganization operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHandshakesForOrganizationPaginator ListHandshakesForOrganization(ListHandshakesForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListOrganizationalUnitsForParent operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationalUnitsForParentPaginator ListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request);

        /// <summary>
        /// Paginator for ListParents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListParentsPaginator ListParents(ListParentsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPoliciesForTarget operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPoliciesForTargetPaginator ListPoliciesForTarget(ListPoliciesForTargetRequest request);

        /// <summary>
        /// Paginator for ListRoots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRootsPaginator ListRoots(ListRootsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTargetsForPolicy operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTargetsForPolicyPaginator ListTargetsForPolicy(ListTargetsForPolicyRequest request);
    }
}