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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Paginators for the IdentityManagement service
    ///</summary>
    public interface IIdentityManagementPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetAccountAuthorizationDetails operation
        ///</summary>
        IGetAccountAuthorizationDetailsPaginator GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request);

        /// <summary>
        /// Paginator for GetGroup operation
        ///</summary>
        IGetGroupPaginator GetGroup(GetGroupRequest request);

        /// <summary>
        /// Paginator for ListAccessKeys operation
        ///</summary>
        IListAccessKeysPaginator ListAccessKeys(ListAccessKeysRequest request);

        /// <summary>
        /// Paginator for ListAccountAliases operation
        ///</summary>
        IListAccountAliasesPaginator ListAccountAliases(ListAccountAliasesRequest request);

        /// <summary>
        /// Paginator for ListAttachedGroupPolicies operation
        ///</summary>
        IListAttachedGroupPoliciesPaginator ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAttachedRolePolicies operation
        ///</summary>
        IListAttachedRolePoliciesPaginator ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request);

        /// <summary>
        /// Paginator for ListAttachedUserPolicies operation
        ///</summary>
        IListAttachedUserPoliciesPaginator ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request);

        /// <summary>
        /// Paginator for ListEntitiesForPolicy operation
        ///</summary>
        IListEntitiesForPolicyPaginator ListEntitiesForPolicy(ListEntitiesForPolicyRequest request);

        /// <summary>
        /// Paginator for ListGroupPolicies operation
        ///</summary>
        IListGroupPoliciesPaginator ListGroupPolicies(ListGroupPoliciesRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListGroupsForUser operation
        ///</summary>
        IListGroupsForUserPaginator ListGroupsForUser(ListGroupsForUserRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfiles operation
        ///</summary>
        IListInstanceProfilesPaginator ListInstanceProfiles(ListInstanceProfilesRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfilesForRole operation
        ///</summary>
        IListInstanceProfilesForRolePaginator ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfileTags operation
        ///</summary>
        IListInstanceProfileTagsPaginator ListInstanceProfileTags(ListInstanceProfileTagsRequest request);

        /// <summary>
        /// Paginator for ListMFADevices operation
        ///</summary>
        IListMFADevicesPaginator ListMFADevices(ListMFADevicesRequest request);

        /// <summary>
        /// Paginator for ListMFADeviceTags operation
        ///</summary>
        IListMFADeviceTagsPaginator ListMFADeviceTags(ListMFADeviceTagsRequest request);

        /// <summary>
        /// Paginator for ListOpenIDConnectProviderTags operation
        ///</summary>
        IListOpenIDConnectProviderTagsPaginator ListOpenIDConnectProviderTags(ListOpenIDConnectProviderTagsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyTags operation
        ///</summary>
        IListPolicyTagsPaginator ListPolicyTags(ListPolicyTagsRequest request);

        /// <summary>
        /// Paginator for ListPolicyVersions operation
        ///</summary>
        IListPolicyVersionsPaginator ListPolicyVersions(ListPolicyVersionsRequest request);

        /// <summary>
        /// Paginator for ListRolePolicies operation
        ///</summary>
        IListRolePoliciesPaginator ListRolePolicies(ListRolePoliciesRequest request);

        /// <summary>
        /// Paginator for ListRoles operation
        ///</summary>
        IListRolesPaginator ListRoles(ListRolesRequest request);

        /// <summary>
        /// Paginator for ListRoleTags operation
        ///</summary>
        IListRoleTagsPaginator ListRoleTags(ListRoleTagsRequest request);

        /// <summary>
        /// Paginator for ListSAMLProviderTags operation
        ///</summary>
        IListSAMLProviderTagsPaginator ListSAMLProviderTags(ListSAMLProviderTagsRequest request);

        /// <summary>
        /// Paginator for ListServerCertificates operation
        ///</summary>
        IListServerCertificatesPaginator ListServerCertificates(ListServerCertificatesRequest request);

        /// <summary>
        /// Paginator for ListServerCertificateTags operation
        ///</summary>
        IListServerCertificateTagsPaginator ListServerCertificateTags(ListServerCertificateTagsRequest request);

        /// <summary>
        /// Paginator for ListSigningCertificates operation
        ///</summary>
        IListSigningCertificatesPaginator ListSigningCertificates(ListSigningCertificatesRequest request);

        /// <summary>
        /// Paginator for ListSSHPublicKeys operation
        ///</summary>
        IListSSHPublicKeysPaginator ListSSHPublicKeys(ListSSHPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListUserPolicies operation
        ///</summary>
        IListUserPoliciesPaginator ListUserPolicies(ListUserPoliciesRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListUserTags operation
        ///</summary>
        IListUserTagsPaginator ListUserTags(ListUserTagsRequest request);

        /// <summary>
        /// Paginator for ListVirtualMFADevices operation
        ///</summary>
        IListVirtualMFADevicesPaginator ListVirtualMFADevices(ListVirtualMFADevicesRequest request);

        /// <summary>
        /// Paginator for SimulateCustomPolicy operation
        ///</summary>
        ISimulateCustomPolicyPaginator SimulateCustomPolicy(SimulateCustomPolicyRequest request);

        /// <summary>
        /// Paginator for SimulatePrincipalPolicy operation
        ///</summary>
        ISimulatePrincipalPolicyPaginator SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request);
    }
}