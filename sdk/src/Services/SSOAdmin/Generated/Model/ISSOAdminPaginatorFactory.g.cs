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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Paginators for the SSOAdmin service
    /// </summary>
    public interface ISSOAdminPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccountAssignmentCreationStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountAssignmentCreationStatusPaginator ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request);

        /// <summary>
        /// Paginator for ListAccountAssignmentDeletionStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountAssignmentDeletionStatusPaginator ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request);

        /// <summary>
        /// Paginator for ListAccountAssignments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountAssignmentsPaginator ListAccountAssignments(ListAccountAssignmentsRequest request);

        /// <summary>
        /// Paginator for ListAccountAssignmentsForPrincipal operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountAssignmentsForPrincipalPaginator ListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest request);

        /// <summary>
        /// Paginator for ListAccountsForProvisionedPermissionSet operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountsForProvisionedPermissionSetPaginator ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request);

        /// <summary>
        /// Paginator for ListApplicationAccessScopes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationAccessScopesPaginator ListApplicationAccessScopes(ListApplicationAccessScopesRequest request);

        /// <summary>
        /// Paginator for ListApplicationAssignments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationAssignmentsPaginator ListApplicationAssignments(ListApplicationAssignmentsRequest request);

        /// <summary>
        /// Paginator for ListApplicationAssignmentsForPrincipal operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationAssignmentsForPrincipalPaginator ListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest request);

        /// <summary>
        /// Paginator for ListApplicationAuthenticationMethods operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListApplicationAuthenticationMethodsPaginator ListApplicationAuthenticationMethods(ListApplicationAuthenticationMethodsRequest request);

        /// <summary>
        /// Paginator for ListApplicationGrants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListApplicationGrantsPaginator ListApplicationGrants(ListApplicationGrantsRequest request);

        /// <summary>
        /// Paginator for ListApplicationProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationProvidersPaginator ListApplicationProviders(ListApplicationProvidersRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListCustomerManagedPolicyReferencesInPermissionSet operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCustomerManagedPolicyReferencesInPermissionSetPaginator ListCustomerManagedPolicyReferencesInPermissionSet(ListCustomerManagedPolicyReferencesInPermissionSetRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListManagedPoliciesInPermissionSet operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedPoliciesInPermissionSetPaginator ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request);

        /// <summary>
        /// Paginator for ListPermissionSetProvisioningStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPermissionSetProvisioningStatusPaginator ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request);

        /// <summary>
        /// Paginator for ListPermissionSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPermissionSetsPaginator ListPermissionSets(ListPermissionSetsRequest request);

        /// <summary>
        /// Paginator for ListPermissionSetsProvisionedToAccount operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPermissionSetsProvisionedToAccountPaginator ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request);

        /// <summary>
        /// Paginator for ListRegions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRegionsPaginator ListRegions(ListRegionsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListTrustedTokenIssuers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrustedTokenIssuersPaginator ListTrustedTokenIssuers(ListTrustedTokenIssuersRequest request);
    }
}
