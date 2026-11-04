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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Paginators for the IdentityManagement service
    /// </summary>
    public interface IIdentityManagementPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetAccountAuthorizationDetails operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IGetAccountAuthorizationDetailsPaginator GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request);

        /// <summary>
        /// Paginator for GetGroup operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IGetGroupPaginator GetGroup(GetGroupRequest request);

        /// <summary>
        /// Paginator for ListAccessKeys operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListAccessKeysPaginator ListAccessKeys(ListAccessKeysRequest request);

        /// <summary>
        /// Paginator for ListAccountAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListAccountAliasesPaginator ListAccountAliases(ListAccountAliasesRequest request);

        /// <summary>
        /// Paginator for ListAttachedGroupPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListAttachedGroupPoliciesPaginator ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAttachedRolePolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListAttachedRolePoliciesPaginator ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request);

        /// <summary>
        /// Paginator for ListAttachedUserPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListAttachedUserPoliciesPaginator ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request);

        /// <summary>
        /// Paginator for ListEntitiesForPolicy operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListEntitiesForPolicyPaginator ListEntitiesForPolicy(ListEntitiesForPolicyRequest request);

        /// <summary>
        /// Paginator for ListGroupPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListGroupPoliciesPaginator ListGroupPolicies(ListGroupPoliciesRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListGroupsForUser operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListGroupsForUserPaginator ListGroupsForUser(ListGroupsForUserRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfileTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListInstanceProfileTagsPaginator ListInstanceProfileTags(ListInstanceProfileTagsRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListInstanceProfilesPaginator ListInstanceProfiles(ListInstanceProfilesRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfilesForRole operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListInstanceProfilesForRolePaginator ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request);

        /// <summary>
        /// Paginator for ListMFADeviceTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListMFADeviceTagsPaginator ListMFADeviceTags(ListMFADeviceTagsRequest request);

        /// <summary>
        /// Paginator for ListMFADevices operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListMFADevicesPaginator ListMFADevices(ListMFADevicesRequest request);

        /// <summary>
        /// Paginator for ListOpenIDConnectProviderTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListOpenIDConnectProviderTagsPaginator ListOpenIDConnectProviderTags(ListOpenIDConnectProviderTagsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListPolicyTagsPaginator ListPolicyTags(ListPolicyTagsRequest request);

        /// <summary>
        /// Paginator for ListPolicyVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListPolicyVersionsPaginator ListPolicyVersions(ListPolicyVersionsRequest request);

        /// <summary>
        /// Paginator for ListRolePolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListRolePoliciesPaginator ListRolePolicies(ListRolePoliciesRequest request);

        /// <summary>
        /// Paginator for ListRoleTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListRoleTagsPaginator ListRoleTags(ListRoleTagsRequest request);

        /// <summary>
        /// Paginator for ListRoles operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListRolesPaginator ListRoles(ListRolesRequest request);

        /// <summary>
        /// Paginator for ListSAMLProviderTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListSAMLProviderTagsPaginator ListSAMLProviderTags(ListSAMLProviderTagsRequest request);

        /// <summary>
        /// Paginator for ListSSHPublicKeys operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListSSHPublicKeysPaginator ListSSHPublicKeys(ListSSHPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListServerCertificateTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListServerCertificateTagsPaginator ListServerCertificateTags(ListServerCertificateTagsRequest request);

        /// <summary>
        /// Paginator for ListServerCertificates operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListServerCertificatesPaginator ListServerCertificates(ListServerCertificatesRequest request);

        /// <summary>
        /// Paginator for ListSigningCertificates operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListSigningCertificatesPaginator ListSigningCertificates(ListSigningCertificatesRequest request);

        /// <summary>
        /// Paginator for ListUserPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListUserPoliciesPaginator ListUserPolicies(ListUserPoliciesRequest request);

        /// <summary>
        /// Paginator for ListUserTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListUserTagsPaginator ListUserTags(ListUserTagsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListVirtualMFADevices operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        IListVirtualMFADevicesPaginator ListVirtualMFADevices(ListVirtualMFADevicesRequest request);

        /// <summary>
        /// Paginator for SimulateCustomPolicy operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        ISimulateCustomPolicyPaginator SimulateCustomPolicy(SimulateCustomPolicyRequest request);

        /// <summary>
        /// Paginator for SimulatePrincipalPolicy operation
        /// </summary>
        [AWSPaginator(InputToken = ["Marker"], LimitKey = "MaxItems", OutputToken = ["Marker"])]
        ISimulatePrincipalPolicyPaginator SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request);
    }
}
