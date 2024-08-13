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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Paginators for the IdentityManagement service
    ///</summary>
    public class IdentityManagementPaginatorFactory : IIdentityManagementPaginatorFactory
    {
        private readonly IAmazonIdentityManagementService client;

        internal IdentityManagementPaginatorFactory(IAmazonIdentityManagementService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetAccountAuthorizationDetails operation
        ///</summary>
        public IGetAccountAuthorizationDetailsPaginator GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request) 
        {
            return new GetAccountAuthorizationDetailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetGroup operation
        ///</summary>
        public IGetGroupPaginator GetGroup(GetGroupRequest request) 
        {
            return new GetGroupPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessKeys operation
        ///</summary>
        public IListAccessKeysPaginator ListAccessKeys(ListAccessKeysRequest request) 
        {
            return new ListAccessKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccountAliases operation
        ///</summary>
        public IListAccountAliasesPaginator ListAccountAliases(ListAccountAliasesRequest request) 
        {
            return new ListAccountAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttachedGroupPolicies operation
        ///</summary>
        public IListAttachedGroupPoliciesPaginator ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request) 
        {
            return new ListAttachedGroupPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttachedRolePolicies operation
        ///</summary>
        public IListAttachedRolePoliciesPaginator ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request) 
        {
            return new ListAttachedRolePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttachedUserPolicies operation
        ///</summary>
        public IListAttachedUserPoliciesPaginator ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request) 
        {
            return new ListAttachedUserPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntitiesForPolicy operation
        ///</summary>
        public IListEntitiesForPolicyPaginator ListEntitiesForPolicy(ListEntitiesForPolicyRequest request) 
        {
            return new ListEntitiesForPolicyPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupPolicies operation
        ///</summary>
        public IListGroupPoliciesPaginator ListGroupPolicies(ListGroupPoliciesRequest request) 
        {
            return new ListGroupPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupsForUser operation
        ///</summary>
        public IListGroupsForUserPaginator ListGroupsForUser(ListGroupsForUserRequest request) 
        {
            return new ListGroupsForUserPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceProfiles operation
        ///</summary>
        public IListInstanceProfilesPaginator ListInstanceProfiles(ListInstanceProfilesRequest request) 
        {
            return new ListInstanceProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceProfilesForRole operation
        ///</summary>
        public IListInstanceProfilesForRolePaginator ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request) 
        {
            return new ListInstanceProfilesForRolePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceProfileTags operation
        ///</summary>
        public IListInstanceProfileTagsPaginator ListInstanceProfileTags(ListInstanceProfileTagsRequest request) 
        {
            return new ListInstanceProfileTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMFADevices operation
        ///</summary>
        public IListMFADevicesPaginator ListMFADevices(ListMFADevicesRequest request) 
        {
            return new ListMFADevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMFADeviceTags operation
        ///</summary>
        public IListMFADeviceTagsPaginator ListMFADeviceTags(ListMFADeviceTagsRequest request) 
        {
            return new ListMFADeviceTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOpenIDConnectProviderTags operation
        ///</summary>
        public IListOpenIDConnectProviderTagsPaginator ListOpenIDConnectProviderTags(ListOpenIDConnectProviderTagsRequest request) 
        {
            return new ListOpenIDConnectProviderTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyTags operation
        ///</summary>
        public IListPolicyTagsPaginator ListPolicyTags(ListPolicyTagsRequest request) 
        {
            return new ListPolicyTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyVersions operation
        ///</summary>
        public IListPolicyVersionsPaginator ListPolicyVersions(ListPolicyVersionsRequest request) 
        {
            return new ListPolicyVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRolePolicies operation
        ///</summary>
        public IListRolePoliciesPaginator ListRolePolicies(ListRolePoliciesRequest request) 
        {
            return new ListRolePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoles operation
        ///</summary>
        public IListRolesPaginator ListRoles(ListRolesRequest request) 
        {
            return new ListRolesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoleTags operation
        ///</summary>
        public IListRoleTagsPaginator ListRoleTags(ListRoleTagsRequest request) 
        {
            return new ListRoleTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSAMLProviderTags operation
        ///</summary>
        public IListSAMLProviderTagsPaginator ListSAMLProviderTags(ListSAMLProviderTagsRequest request) 
        {
            return new ListSAMLProviderTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServerCertificates operation
        ///</summary>
        public IListServerCertificatesPaginator ListServerCertificates(ListServerCertificatesRequest request) 
        {
            return new ListServerCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServerCertificateTags operation
        ///</summary>
        public IListServerCertificateTagsPaginator ListServerCertificateTags(ListServerCertificateTagsRequest request) 
        {
            return new ListServerCertificateTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSigningCertificates operation
        ///</summary>
        public IListSigningCertificatesPaginator ListSigningCertificates(ListSigningCertificatesRequest request) 
        {
            return new ListSigningCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSSHPublicKeys operation
        ///</summary>
        public IListSSHPublicKeysPaginator ListSSHPublicKeys(ListSSHPublicKeysRequest request) 
        {
            return new ListSSHPublicKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserPolicies operation
        ///</summary>
        public IListUserPoliciesPaginator ListUserPolicies(ListUserPoliciesRequest request) 
        {
            return new ListUserPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserTags operation
        ///</summary>
        public IListUserTagsPaginator ListUserTags(ListUserTagsRequest request) 
        {
            return new ListUserTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVirtualMFADevices operation
        ///</summary>
        public IListVirtualMFADevicesPaginator ListVirtualMFADevices(ListVirtualMFADevicesRequest request) 
        {
            return new ListVirtualMFADevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SimulateCustomPolicy operation
        ///</summary>
        public ISimulateCustomPolicyPaginator SimulateCustomPolicy(SimulateCustomPolicyRequest request) 
        {
            return new SimulateCustomPolicyPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SimulatePrincipalPolicy operation
        ///</summary>
        public ISimulatePrincipalPolicyPaginator SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request) 
        {
            return new SimulatePrincipalPolicyPaginator(this.client, request);
        }
    }
}