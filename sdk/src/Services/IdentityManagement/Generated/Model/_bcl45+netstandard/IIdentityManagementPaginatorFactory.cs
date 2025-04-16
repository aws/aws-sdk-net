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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IGetAccountAuthorizationDetailsPaginator GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request);

        /// <summary>
        /// Paginator for GetGroup operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IGetGroupPaginator GetGroup(GetGroupRequest request);

        /// <summary>
        /// Paginator for ListAccessKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListAccessKeysPaginator ListAccessKeys(ListAccessKeysRequest request);

        /// <summary>
        /// Paginator for ListAccountAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListAccountAliasesPaginator ListAccountAliases(ListAccountAliasesRequest request);

        /// <summary>
        /// Paginator for ListAttachedGroupPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListAttachedGroupPoliciesPaginator ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAttachedRolePolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListAttachedRolePoliciesPaginator ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request);

        /// <summary>
        /// Paginator for ListAttachedUserPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListAttachedUserPoliciesPaginator ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request);

        /// <summary>
        /// Paginator for ListEntitiesForPolicy operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListEntitiesForPolicyPaginator ListEntitiesForPolicy(ListEntitiesForPolicyRequest request);

        /// <summary>
        /// Paginator for ListGroupPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListGroupPoliciesPaginator ListGroupPolicies(ListGroupPoliciesRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListGroupsForUser operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListGroupsForUserPaginator ListGroupsForUser(ListGroupsForUserRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListInstanceProfilesPaginator ListInstanceProfiles(ListInstanceProfilesRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfilesForRole operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListInstanceProfilesForRolePaginator ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request);

        /// <summary>
        /// Paginator for ListInstanceProfileTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListInstanceProfileTagsPaginator ListInstanceProfileTags(ListInstanceProfileTagsRequest request);

        /// <summary>
        /// Paginator for ListMFADevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListMFADevicesPaginator ListMFADevices(ListMFADevicesRequest request);

        /// <summary>
        /// Paginator for ListMFADeviceTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListMFADeviceTagsPaginator ListMFADeviceTags(ListMFADeviceTagsRequest request);

        /// <summary>
        /// Paginator for ListOpenIDConnectProviderTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListOpenIDConnectProviderTagsPaginator ListOpenIDConnectProviderTags(ListOpenIDConnectProviderTagsRequest request);

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListPoliciesPaginator ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Paginator for ListPolicyTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListPolicyTagsPaginator ListPolicyTags(ListPolicyTagsRequest request);

        /// <summary>
        /// Paginator for ListPolicyVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListPolicyVersionsPaginator ListPolicyVersions(ListPolicyVersionsRequest request);

        /// <summary>
        /// Paginator for ListRolePolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListRolePoliciesPaginator ListRolePolicies(ListRolePoliciesRequest request);

        /// <summary>
        /// Paginator for ListRoles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListRolesPaginator ListRoles(ListRolesRequest request);

        /// <summary>
        /// Paginator for ListRoleTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListRoleTagsPaginator ListRoleTags(ListRoleTagsRequest request);

        /// <summary>
        /// Paginator for ListSAMLProviderTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListSAMLProviderTagsPaginator ListSAMLProviderTags(ListSAMLProviderTagsRequest request);

        /// <summary>
        /// Paginator for ListServerCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListServerCertificatesPaginator ListServerCertificates(ListServerCertificatesRequest request);

        /// <summary>
        /// Paginator for ListServerCertificateTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListServerCertificateTagsPaginator ListServerCertificateTags(ListServerCertificateTagsRequest request);

        /// <summary>
        /// Paginator for ListSigningCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListSigningCertificatesPaginator ListSigningCertificates(ListSigningCertificatesRequest request);

        /// <summary>
        /// Paginator for ListSSHPublicKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListSSHPublicKeysPaginator ListSSHPublicKeys(ListSSHPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListUserPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListUserPoliciesPaginator ListUserPolicies(ListUserPoliciesRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListUserTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListUserTagsPaginator ListUserTags(ListUserTagsRequest request);

        /// <summary>
        /// Paginator for ListVirtualMFADevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        IListVirtualMFADevicesPaginator ListVirtualMFADevices(ListVirtualMFADevicesRequest request);

        /// <summary>
        /// Paginator for SimulateCustomPolicy operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        ISimulateCustomPolicyPaginator SimulateCustomPolicy(SimulateCustomPolicyRequest request);

        /// <summary>
        /// Paginator for SimulatePrincipalPolicy operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "Marker" }
        )]
        ISimulatePrincipalPolicyPaginator SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request);
    }
}