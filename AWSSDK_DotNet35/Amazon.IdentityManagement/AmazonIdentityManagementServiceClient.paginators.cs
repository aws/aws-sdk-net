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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime.Internal;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement
{
    public partial class AmazonIdentityManagementServiceClient
    {

        #region GetGroupEnumerator

        /// <summary>
        /// Initiates paginated execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;User&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<User> GetGroupEnumerator(GetGroupRequest request)
        {
            return Paginator.Paginate<User, GetGroupRequest, GetGroupResponse>(request, this.GetGroup);
        }
      
        #endregion

        #region ListAccessKeysEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;AccessKeyMetadata&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<AccessKeyMetadata> ListAccessKeysEnumerator(ListAccessKeysRequest request)
        {
            return Paginator.Paginate<AccessKeyMetadata, ListAccessKeysRequest, ListAccessKeysResponse>(request, this.ListAccessKeys);
        }
      
        #endregion

        #region ListAccountAliasesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<string> ListAccountAliasesEnumerator(ListAccountAliasesRequest request)
        {
            return Paginator.Paginate<string, ListAccountAliasesRequest, ListAccountAliasesResponse>(request, this.ListAccountAliases);
        }
      
        #endregion

        #region ListGroupPoliciesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<string> ListGroupPoliciesEnumerator(ListGroupPoliciesRequest request)
        {
            return Paginator.Paginate<string, ListGroupPoliciesRequest, ListGroupPoliciesResponse>(request, this.ListGroupPolicies);
        }
      
        #endregion

        #region ListGroupsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Group&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Group> ListGroupsEnumerator(ListGroupsRequest request)
        {
            return Paginator.Paginate<Group, ListGroupsRequest, ListGroupsResponse>(request, this.ListGroups);
        }
      
        #endregion

        #region ListGroupsForUserEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Group&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Group> ListGroupsForUserEnumerator(ListGroupsForUserRequest request)
        {
            return Paginator.Paginate<Group, ListGroupsForUserRequest, ListGroupsForUserResponse>(request, this.ListGroupsForUser);
        }
      
        #endregion

        #region ListInstanceProfilesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;InstanceProfile&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<InstanceProfile> ListInstanceProfilesEnumerator(ListInstanceProfilesRequest request)
        {
            return Paginator.Paginate<InstanceProfile, ListInstanceProfilesRequest, ListInstanceProfilesResponse>(request, this.ListInstanceProfiles);
        }
      
        #endregion

        #region ListInstanceProfilesForRoleEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;InstanceProfile&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<InstanceProfile> ListInstanceProfilesForRoleEnumerator(ListInstanceProfilesForRoleRequest request)
        {
            return Paginator.Paginate<InstanceProfile, ListInstanceProfilesForRoleRequest, ListInstanceProfilesForRoleResponse>(request, this.ListInstanceProfilesForRole);
        }
      
        #endregion

        #region ListMFADevicesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;MFADevice&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<MFADevice> ListMFADevicesEnumerator(ListMFADevicesRequest request)
        {
            return Paginator.Paginate<MFADevice, ListMFADevicesRequest, ListMFADevicesResponse>(request, this.ListMFADevices);
        }
      
        #endregion

        #region ListRolePoliciesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<string> ListRolePoliciesEnumerator(ListRolePoliciesRequest request)
        {
            return Paginator.Paginate<string, ListRolePoliciesRequest, ListRolePoliciesResponse>(request, this.ListRolePolicies);
        }
      
        #endregion

        #region ListRolesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Role&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Role> ListRolesEnumerator(ListRolesRequest request)
        {
            return Paginator.Paginate<Role, ListRolesRequest, ListRolesResponse>(request, this.ListRoles);
        }
      
        #endregion

        #region ListServerCertificatesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;ServerCertificateMetadata&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<ServerCertificateMetadata> ListServerCertificatesEnumerator(ListServerCertificatesRequest request)
        {
            return Paginator.Paginate<ServerCertificateMetadata, ListServerCertificatesRequest, ListServerCertificatesResponse>(request, this.ListServerCertificates);
        }
      
        #endregion

        #region ListSigningCertificatesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;SigningCertificate&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<SigningCertificate> ListSigningCertificatesEnumerator(ListSigningCertificatesRequest request)
        {
            return Paginator.Paginate<SigningCertificate, ListSigningCertificatesRequest, ListSigningCertificatesResponse>(request, this.ListSigningCertificates);
        }
      
        #endregion

        #region ListUserPoliciesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<string> ListUserPoliciesEnumerator(ListUserPoliciesRequest request)
        {
            return Paginator.Paginate<string, ListUserPoliciesRequest, ListUserPoliciesResponse>(request, this.ListUserPolicies);
        }
      
        #endregion

        #region ListUsersEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;User&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<User> ListUsersEnumerator(ListUsersRequest request)
        {
            return Paginator.Paginate<User, ListUsersRequest, ListUsersResponse>(request, this.ListUsers);
        }
      
        #endregion

        #region ListVirtualMFADevicesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;VirtualMFADevice&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<VirtualMFADevice> ListVirtualMFADevicesEnumerator(ListVirtualMFADevicesRequest request)
        {
            return Paginator.Paginate<VirtualMFADevice, ListVirtualMFADevicesRequest, ListVirtualMFADevicesResponse>(request, this.ListVirtualMFADevices);
        }
      
        #endregion

 
    }

    public partial interface IAmazonIdentityManagementService
    {
        #region GetGroupEnumerator

        /// <summary>
        /// Initiates paginated execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;User&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<User> GetGroupEnumerator(GetGroupRequest request);
      
        #endregion

        #region ListAccessKeysEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;AccessKeyMetadata&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<AccessKeyMetadata> ListAccessKeysEnumerator(ListAccessKeysRequest request);
      
        #endregion

        #region ListAccountAliasesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<string> ListAccountAliasesEnumerator(ListAccountAliasesRequest request);
      
        #endregion

        #region ListGroupPoliciesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<string> ListGroupPoliciesEnumerator(ListGroupPoliciesRequest request);
      
        #endregion

        #region ListGroupsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Group&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Group> ListGroupsEnumerator(ListGroupsRequest request);
      
        #endregion

        #region ListGroupsForUserEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Group&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Group> ListGroupsForUserEnumerator(ListGroupsForUserRequest request);
      
        #endregion

        #region ListInstanceProfilesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;InstanceProfile&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<InstanceProfile> ListInstanceProfilesEnumerator(ListInstanceProfilesRequest request);
      
        #endregion

        #region ListInstanceProfilesForRoleEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;InstanceProfile&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<InstanceProfile> ListInstanceProfilesForRoleEnumerator(ListInstanceProfilesForRoleRequest request);
      
        #endregion

        #region ListMFADevicesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;MFADevice&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<MFADevice> ListMFADevicesEnumerator(ListMFADevicesRequest request);
      
        #endregion

        #region ListRolePoliciesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<string> ListRolePoliciesEnumerator(ListRolePoliciesRequest request);
      
        #endregion

        #region ListRolesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Role&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Role> ListRolesEnumerator(ListRolesRequest request);
      
        #endregion

        #region ListServerCertificatesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;ServerCertificateMetadata&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<ServerCertificateMetadata> ListServerCertificatesEnumerator(ListServerCertificatesRequest request);
      
        #endregion

        #region ListSigningCertificatesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;SigningCertificate&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<SigningCertificate> ListSigningCertificatesEnumerator(ListSigningCertificatesRequest request);
      
        #endregion

        #region ListUserPoliciesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;string&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<string> ListUserPoliciesEnumerator(ListUserPoliciesRequest request);
      
        #endregion

        #region ListUsersEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;User&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<User> ListUsersEnumerator(ListUsersRequest request);
      
        #endregion

        #region ListVirtualMFADevicesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;VirtualMFADevice&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<VirtualMFADevice> ListVirtualMFADevicesEnumerator(ListVirtualMFADevicesRequest request);
      
        #endregion

 
    }
}