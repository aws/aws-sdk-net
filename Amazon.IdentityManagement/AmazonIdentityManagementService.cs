/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Interface for accessing AmazonIdentityManagementService.
    ///  
    ///  AWS Identity and Access Management <para>This is the Amazon Web Services (AWS) Identity and Access Management (IAM) API Reference. This
    /// guide provides descriptions of the IAM API as well as links to related content in the guide, Using IAM.</para> <para>IAM is a web service
    /// that enables AWS customers to manage users and user permissions under their AWS account. For more information about this product go to AWS
    /// Identity and Access Management (IAM). For specific information about setting up signatures and authorization through the API, go to Making
    /// Query Requests in <i>Using AWS Identity and Access Management</i> .</para> <para>If you're new to AWS and need additional technical
    /// information about a specific AWS product, you can find the product's technical documentation at http://aws.amazon.com/documentation/.</para>
    /// <para>We will refer to Amazon AWS Identity and Access Management using the abbreviated form IAM. All copyrights and legal protections still
    /// apply.</para>
    /// </summary>
    public interface AmazonIdentityManagementService : IDisposable
    {
        

         /// <summary>
         /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listGroupsRequest">Container for the necessary parameters to execute the ListGroups service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListGroupsResponse ListGroups(ListGroupsRequest listGroupsRequest); 

         /// <summary>
         /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListGroupsResponse ListGroups();

         /// <summary>
         /// <para>Deletes the access key associated with the specified user.</para> <para>If you do not specify a user name, IAM determines the user
         /// name implicitly based on the AWS Access Key ID signing the request. Because this action works for access keys under the AWS account, you can
         /// use this API to manage root credentials even if the AWS account has no associated users.</para>
         /// </summary>
         /// 
         /// <param name="deleteAccessKeyRequest">Container for the necessary parameters to execute the DeleteAccessKey service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest); 

         /// <summary>
         /// <para>Deletes the specified AWS account alias. For information about using an AWS account alias, see Using an Alias for Your AWS Account ID
         /// in <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <param name="deleteAccountAliasRequest">Container for the necessary parameters to execute the DeleteAccountAlias service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest deleteAccountAliasRequest); 

         /// <summary>
         /// <para>Deletes a virtual MFA device.</para> <para><b>NOTE:</b>You must deactivate a user's virtual MFA device before you can delete it. For
         /// information about deactivating MFA devices, see DeactivateMFADevice.</para>
         /// </summary>
         /// 
         /// <param name="deleteVirtualMFADeviceRequest">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="DeleteConflictException"/>
        DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest deleteVirtualMFADeviceRequest); 

         /// <summary>
         /// <para>Deletes the specified policy associated with the specified user.</para>
         /// </summary>
         /// 
         /// <param name="deleteUserPolicyRequest">Container for the necessary parameters to execute the DeleteUserPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest deleteUserPolicyRequest); 

         /// <summary>
         /// <para>Adds (or updates) a policy document associated with the specified user. For information about policies, refer to Overview of Policies
         /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
         /// with a user, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
         /// documents can be large, you should use POST rather than GET when calling PutUserPolicy. For more information, see Making Query Requests in
         /// Using AWS Identity and Access Management.</para>
         /// </summary>
         /// 
         /// <param name="putUserPolicyRequest">Container for the necessary parameters to execute the PutUserPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="MalformedPolicyDocumentException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest putUserPolicyRequest); 

         /// <summary>
         /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
         /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listServerCertificatesRequest">Container for the necessary parameters to execute the ListServerCertificates service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest listServerCertificatesRequest); 

         /// <summary>
         /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
         /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListServerCertificatesResponse ListServerCertificates();

         /// <summary>
         /// <para>Retrieves the specified policy document for the specified user. The returned policy is URL-encoded according to RFC 3986. For more
         /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html.</para>
         /// </summary>
         /// 
         /// <param name="getUserPolicyRequest">Container for the necessary parameters to execute the GetUserPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetUserPolicy service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest getUserPolicyRequest); 

         /// <summary>
         /// <para>Updates the name and/or the path of the specified server certificate.</para> <para><b>IMPORTANT:</b> You should understand the
         /// implications of changing a server certificate's path or name. For more information, see Managing Server Certificates in Using AWS Identity
         /// and Access Management. </para> <para><b>NOTE:</b>To change a server certificate name the requester must have appropriate permissions on both
         /// the source object and the target object. For example, to change the name from ProductionCert to ProdCert, the entity making the request
         /// must have permission on ProductionCert and ProdCert, or must have permission on all (*). For more information about permissions, see
         /// Permissions and Policies. </para>
         /// </summary>
         /// 
         /// <param name="updateServerCertificateRequest">Container for the necessary parameters to execute the UpdateServerCertificate service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest updateServerCertificateRequest); 

         /// <summary>
         /// <para>Updates the name and/or the path of the specified user.</para> <para><b>IMPORTANT:</b> You should understand the implications of
         /// changing a user's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
         /// <para><b>NOTE:</b>To change a user name the requester must have appropriate permissions on both the source object and the target object.
         /// For example, to change Bob to Robert, the entity making the request must have permission on Bob and Robert, or must have permission on all
         /// (*). For more information about permissions, see Permissions and Policies. </para>
         /// </summary>
         /// 
         /// <param name="updateUserRequest">Container for the necessary parameters to execute the UpdateUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest); 

         /// <summary>
         /// <para>Changes the status of the specified signing certificate from active to disabled, or vice versa. This action can be used to disable a
         /// user's signing certificate as part of a certificate rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the
         /// UserName is determined implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under
         /// the AWS account, this API can be used to manage root credentials even if the AWS account has no associated users.</para> <para>For
         /// information about rotating certificates, see Managing Keys and Certificates in <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <param name="updateSigningCertificateRequest">Container for the necessary parameters to execute the UpdateSigningCertificate service method
         ///           on AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest updateSigningCertificateRequest); 

         /// <summary>
         /// <para>Deletes the specified policy that is associated with the specified group.</para>
         /// </summary>
         /// 
         /// <param name="deleteGroupPolicyRequest">Container for the necessary parameters to execute the DeleteGroupPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest deleteGroupPolicyRequest); 

         /// <summary>
         /// <para>Updates the name and/or the path of the specified group.</para> <para><b>IMPORTANT:</b> You should understand the implications of
         /// changing a group's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
         /// <para><b>NOTE:</b>To change a group name the requester must have appropriate permissions on both the source object and the target object.
         /// For example, to change Managers to MGRs, the entity making the request must have permission on Managers and MGRs, or must have permission on
         /// all (*). For more information about permissions, see Permissions and Policies. </para>
         /// </summary>
         /// 
         /// <param name="updateGroupRequest">Container for the necessary parameters to execute the UpdateGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest updateGroupRequest); 

         /// <summary>
         /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
         /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listUsersRequest">Container for the necessary parameters to execute the ListUsers service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListUsersResponse ListUsers(ListUsersRequest listUsersRequest); 

         /// <summary>
         /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
         /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListUsersResponse ListUsers();

         /// <summary>
         /// <para>Creates a new user for your AWS account.</para> <para>For information about limitations on the number of users you can create, see
         /// Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <param name="createUserRequest">Container for the necessary parameters to execute the CreateUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateUser service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        CreateUserResponse CreateUser(CreateUserRequest createUserRequest); 

         /// <summary>
         /// <para>Enables the specified MFA device and associates it with the specified user name. When enabled, the MFA device is required for every
         /// subsequent login by the user name associated with the device.</para>
         /// </summary>
         /// 
         /// <param name="enableMFADeviceRequest">Container for the necessary parameters to execute the EnableMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="InvalidAuthenticationCodeException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest enableMFADeviceRequest); 

         /// <summary>
         /// <para>Retrieves the login profile for the specified user.</para>
         /// </summary>
         /// 
         /// <param name="getLoginProfileRequest">Container for the necessary parameters to execute the GetLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest getLoginProfileRequest); 

         /// <summary>
         /// <para>Uploads a server certificate entity for the AWS account. The server certificate entity includes a public key certificate, a private
         /// key, and an optional certificate chain, which should all be PEM-encoded.</para> <para>For information about the number of server
         /// certificates you can upload, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
         /// <para><b>NOTE:</b>Because the body of the public key certificate, private key, and the certificate chain can be large, you should use POST
         /// rather than GET when calling UploadServerCertificate. For more information, see Making Query Requests in Using AWS Identity and Access
         /// Management.</para>
         /// </summary>
         /// 
         /// <param name="uploadServerCertificateRequest">Container for the necessary parameters to execute the UploadServerCertificate service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the UploadServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="KeyPairMismatchException"/>
         /// <exception cref="MalformedCertificateException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest uploadServerCertificateRequest); 

         /// <summary>
         /// <para>Creates a new group.</para> <para>For information about the number of groups you can create, see Limitations on IAM Entities in
         /// <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <param name="createGroupRequest">Container for the necessary parameters to execute the CreateGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateGroup service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest); 

         /// <summary>
         /// <para>This action creates an alias for your AWS account. For information about using an AWS account alias, see Using an Alias for Your AWS
         /// Account ID in <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <param name="createAccountAliasRequest">Container for the necessary parameters to execute the CreateAccountAlias service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityAlreadyExistsException"/>
        CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest createAccountAliasRequest); 

         /// <summary>
         /// <para>Deletes the specified user. The user must not belong to any groups, have any keys or signing certificates, or have any attached
         /// policies.</para>
         /// </summary>
         /// 
         /// <param name="deleteUserRequest">Container for the necessary parameters to execute the DeleteUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="DeleteConflictException"/>
        DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest); 

         /// <summary>
         /// <para>Deactivates the specified MFA device and removes it from association with the user name for which it was originally enabled.</para>
         /// </summary>
         /// 
         /// <param name="deactivateMFADeviceRequest">Container for the necessary parameters to execute the DeactivateMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
        DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest deactivateMFADeviceRequest); 

         /// <summary>
         /// <para>Removes the specified user from the specified group.</para>
         /// </summary>
         /// 
         /// <param name="removeUserFromGroupRequest">Container for the necessary parameters to execute the RemoveUserFromGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest removeUserFromGroupRequest); 

         /// <summary>
         /// <para>Deletes the specified server certificate.</para> <para><b>IMPORTANT:</b>If you are using a server certificate with Elastic Load
         /// Balancing, deleting the certificate could have implications for your application. If Elastic Load Balancing doesn't detect the deletion of
         /// bound certificates, it may continue to use the certificates. This could cause Elastic Load Balancing to stop accepting traffic. We
         /// recommend that you remove the reference to the certificate from Elastic Load Balancing before using this command to delete the certificate.
         /// For more information, go to DeleteLoadBalancerListeners in the Elastic Load Balancing API Reference.</para>
         /// </summary>
         /// 
         /// <param name="deleteServerCertificateRequest">Container for the necessary parameters to execute the DeleteServerCertificate service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="DeleteConflictException"/>
        DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest deleteServerCertificateRequest); 

         /// <summary>
         /// <para>Creates a new AWS Secret Access Key and corresponding AWS Access Key ID for the specified user. The default status for new keys is
         /// <c>Active</c> .</para> <para>If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID
         /// signing the request. Because this action works for access keys under the AWS account, you can use this API to manage root credentials even
         /// if the AWS account has no associated users.</para> <para>For information about limits on the number of keys you can create, see Limitations
         /// on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>To ensure the security of your AWS
         /// account, the Secret Access Key is accessible only during key and user creation. You must save the key (for example, in a text file) if you
         /// want to be able to access it again. If a secret key is lost, you can delete the access keys for the associated user and then create new
         /// keys.</para>
         /// </summary>
         /// 
         /// <param name="createAccessKeyRequest">Container for the necessary parameters to execute the CreateAccessKey service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest createAccessKeyRequest); 

         /// <summary>
         /// <para>Creates a new AWS Secret Access Key and corresponding AWS Access Key ID for the specified user. The default status for new keys is
         /// <c>Active</c> .</para> <para>If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID
         /// signing the request. Because this action works for access keys under the AWS account, you can use this API to manage root credentials even
         /// if the AWS account has no associated users.</para> <para>For information about limits on the number of keys you can create, see Limitations
         /// on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>To ensure the security of your AWS
         /// account, the Secret Access Key is accessible only during key and user creation. You must save the key (for example, in a text file) if you
         /// want to be able to access it again. If a secret key is lost, you can delete the access keys for the associated user and then create new
         /// keys.</para>
         /// </summary>
         /// 
         /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        CreateAccessKeyResponse CreateAccessKey();

         /// <summary>
         /// <para>Retrieves information about the specified user, including the user's path, GUID, and ARN.</para> <para>If you do not specify a user
         /// name, IAM determines the user name implicitly based on the AWS Access Key ID signing the request.</para>
         /// </summary>
         /// 
         /// <param name="getUserRequest">Container for the necessary parameters to execute the GetUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        GetUserResponse GetUser(GetUserRequest getUserRequest); 

         /// <summary>
         /// <para>Retrieves information about the specified user, including the user's path, GUID, and ARN.</para> <para>If you do not specify a user
         /// name, IAM determines the user name implicitly based on the AWS Access Key ID signing the request.</para>
         /// </summary>
         /// 
         /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        GetUserResponse GetUser();

         /// <summary>
         /// <para>Synchronizes the specified MFA device with AWS servers.</para>
         /// </summary>
         /// 
         /// <param name="resyncMFADeviceRequest">Container for the necessary parameters to execute the ResyncMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="InvalidAuthenticationCodeException"/>
        ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest resyncMFADeviceRequest); 

         /// <summary>
         /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
         /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID signing the
         /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listMFADevicesRequest">Container for the necessary parameters to execute the ListMFADevices service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest listMFADevicesRequest); 

         /// <summary>
         /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
         /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID signing the
         /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListMFADevicesResponse ListMFADevices();

         /// <summary>
         /// <para>Creates a new virtual MFA device for the AWS account. After creating the virtual MFA, use EnableMFADevice to attach the MFA device to
         /// an IAM user. For more information about creating and working with virtual MFA devices, go to Using a Virtual MFA Device in <i>Using AWS
         /// Identity and Access Management</i> .</para> <para>For information about limits on the number of MFA devices you can create, see Limitations
         /// on Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>The seed information contained in the QR code
         /// and the Base32 string should be treated like any other secret access information, such as your AWS access keys or your passwords. After you
         /// provision your virtual device, you should ensure that the information is destroyed following secure procedures.</para>
         /// </summary>
         /// 
         /// <param name="createVirtualMFADeviceRequest">Container for the necessary parameters to execute the CreateVirtualMFADevice service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateVirtualMFADevice service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest); 

         /// <summary>
         /// <para>Changes the status of the specified access key from Active to Inactive, or vice versa. This action can be used to disable a user's key
         /// as part of a key rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based
         /// on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to
         /// manage root credentials even if the AWS account has no associated users.</para> <para>For information about rotating keys, see Managing Keys
         /// and Certificates in <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <param name="updateAccessKeyRequest">Container for the necessary parameters to execute the UpdateAccessKey service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest updateAccessKeyRequest); 

         /// <summary>
         /// <para>Adds the specified user to the specified group.</para>
         /// </summary>
         /// 
         /// <param name="addUserToGroupRequest">Container for the necessary parameters to execute the AddUserToGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest addUserToGroupRequest); 

         /// <summary>
         /// <para>Returns a list of users that are in the specified group. You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
         /// parameters.</para>
         /// </summary>
         /// 
         /// <param name="getGroupRequest">Container for the necessary parameters to execute the GetGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetGroup service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        GetGroupResponse GetGroup(GetGroupRequest getGroupRequest); 

         /// <summary>
         /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see Using an Alias for Your
         /// AWS Account ID in <i>Using AWS Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listAccountAliasesRequest">Container for the necessary parameters to execute the ListAccountAliases service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest listAccountAliasesRequest); 

         /// <summary>
         /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see Using an Alias for Your
         /// AWS Account ID in <i>Using AWS Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListAccountAliasesResponse ListAccountAliases();

         /// <summary>
         /// <para>Deletes the specified group. The group must not contain any users or have any attached policies.</para>
         /// </summary>
         /// 
         /// <param name="deleteGroupRequest">Container for the necessary parameters to execute the DeleteGroup service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="DeleteConflictException"/>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest); 

         /// <summary>
         /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
         /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
         /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
         /// implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this
         /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
         /// </summary>
         /// 
         /// <param name="listSigningCertificatesRequest">Container for the necessary parameters to execute the ListSigningCertificates service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest listSigningCertificatesRequest); 

         /// <summary>
         /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
         /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
         /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
         /// implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this
         /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListSigningCertificatesResponse ListSigningCertificates();

         /// <summary>
         /// <para>Uploads an X.509 signing certificate and associates it with the specified user. Some AWS services use X.509 signing certificates to
         /// validate requests that are signed with a corresponding private key. When you upload the certificate, its default status is <c>Active</c>
         /// .</para> <para>If the <c>UserName</c> field is not specified, the user name is determined implicitly based on the AWS Access Key ID used to
         /// sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root credentials even if
         /// the AWS account has no associated users.</para> <para><b>NOTE:</b>Because the body of a X.509 certificate can be large, you should use POST
         /// rather than GET when calling UploadSigningCertificate. For more information, see Making Query Requests in Using AWS Identity and Access
         /// Management.</para>
         /// </summary>
         /// 
         /// <param name="uploadSigningCertificateRequest">Container for the necessary parameters to execute the UploadSigningCertificate service method
         ///           on AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the UploadSigningCertificate service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="DuplicateCertificateException"/>
         /// <exception cref="InvalidCertificateException"/>
         /// <exception cref="MalformedCertificateException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest uploadSigningCertificateRequest); 

         /// <summary>
         /// <para>Updates the login profile for the specified user. Use this API to change the user's password.</para>
         /// </summary>
         /// 
         /// <param name="updateLoginProfileRequest">Container for the necessary parameters to execute the UpdateLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
        UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest updateLoginProfileRequest); 

         /// <summary>
         /// <para>Deletes the login profile for the specified user, which terminates the user's ability to access AWS services through the IAM login
         /// page.</para> <para><b>IMPORTANT:</b>Deleting a user's login profile does not prevent a user from accessing IAM through the command line
         /// interface or the API. To prevent all user access you must also either make the access key inactive or delete it. For more information
         /// about making keys inactive or deleting them, see UpdateAccessKey and DeleteAccessKey. </para>
         /// </summary>
         /// 
         /// <param name="deleteLoginProfileRequest">Container for the necessary parameters to execute the DeleteLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="EntityTemporarilyUnmodifiableException"/>
         /// <exception cref="NoSuchEntityException"/>
        DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest deleteLoginProfileRequest); 

         /// <summary>
         /// <para>Retrieves information about the specified server certificate.</para>
         /// </summary>
         /// 
         /// <param name="getServerCertificateRequest">Container for the necessary parameters to execute the GetServerCertificate service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest getServerCertificateRequest); 

         /// <summary>
         /// <para>Adds (or updates) a policy document associated with the specified group. For information about policies, refer to Overview of Policies
         /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
         /// with a group, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
         /// documents can be large, you should use POST rather than GET when calling PutGroupPolicy. For more information, see Making Query Requests in
         /// Using AWS Identity and Access Management.</para>
         /// </summary>
         /// 
         /// <param name="putGroupPolicyRequest">Container for the necessary parameters to execute the PutGroupPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="MalformedPolicyDocumentException"/>
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="LimitExceededException"/>
        PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest putGroupPolicyRequest); 

         /// <summary>
         /// <para>Deletes the specified signing certificate associated with the specified user.</para> <para>If you do not specify a user name, IAM
         /// determines the user name implicitly based on the AWS Access Key ID signing the request. Because this action works for access keys under the
         /// AWS account, you can use this API to manage root credentials even if the AWS account has no associated users.</para>
         /// </summary>
         /// 
         /// <param name="deleteSigningCertificateRequest">Container for the necessary parameters to execute the DeleteSigningCertificate service method
         ///           on AmazonIdentityManagementService.</param>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest deleteSigningCertificateRequest); 

         /// <summary>
         /// <para>Lists the names of the policies associated with the specified user. If there are none, the action returns an empty list.</para>
         /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listUserPoliciesRequest">Container for the necessary parameters to execute the ListUserPolicies service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListUserPolicies service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest listUserPoliciesRequest); 

         /// <summary>
         /// <para>Returns information about the Access Key IDs associated with the specified user. If there are none, the action returns an empty
         /// list.</para> <para>Although each user is limited to a small number of keys, you can still paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based on the AWS
         /// Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root
         /// credentials even if the AWS account has no associated users.</para> <para><b>NOTE:</b>To ensure the security of your AWS account, the secret
         /// access key is accessible only during key and user creation.</para>
         /// </summary>
         /// 
         /// <param name="listAccessKeysRequest">Container for the necessary parameters to execute the ListAccessKeys service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest listAccessKeysRequest); 

         /// <summary>
         /// <para>Returns information about the Access Key IDs associated with the specified user. If there are none, the action returns an empty
         /// list.</para> <para>Although each user is limited to a small number of keys, you can still paginate the results using the <c>MaxItems</c> and
         /// <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based on the AWS
         /// Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root
         /// credentials even if the AWS account has no associated users.</para> <para><b>NOTE:</b>To ensure the security of your AWS account, the secret
         /// access key is accessible only during key and user creation.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListAccessKeysResponse ListAccessKeys();

         /// <summary>
         /// <para>Lists the groups the specified user belongs to.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
         /// parameters.</para>
         /// </summary>
         /// 
         /// <param name="listGroupsForUserRequest">Container for the necessary parameters to execute the ListGroupsForUser service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListGroupsForUser service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest listGroupsForUserRequest); 

         /// <summary>
         /// <para>Retrieves the specified policy document for the specified group. The returned policy is URL-encoded according to RFC 3986. For more
         /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html.</para>
         /// </summary>
         /// 
         /// <param name="getGroupPolicyRequest">Container for the necessary parameters to execute the GetGroupPolicy service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetGroupPolicy service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest getGroupPolicyRequest); 

         /// <summary>
         /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
         /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
         /// 
         /// <c>Unassigned</c> , or <c>Any</c> .
         /// </para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listVirtualMFADevicesRequest">Container for the necessary parameters to execute the ListVirtualMFADevices service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest); 

         /// <summary>
         /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
         /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
         /// 
         /// <c>Unassigned</c> , or <c>Any</c> .
         /// </para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        ListVirtualMFADevicesResponse ListVirtualMFADevices();

         /// <summary>
         /// <para>Lists the names of the policies associated with the specified group. If there are none, the action returns an empty list.</para>
         /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
         /// </summary>
         /// 
         /// <param name="listGroupPoliciesRequest">Container for the necessary parameters to execute the ListGroupPolicies service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the ListGroupPolicies service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
        ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest listGroupPoliciesRequest); 

         /// <summary>
         /// <para>Creates a login profile for the specified user, giving the user the ability to access AWS services such as the AWS Management Console.
         /// For more information about login profiles, see Creating or Deleting a User Login Profile in <i>Using AWS Identity and Access Management</i>
         /// .</para>
         /// </summary>
         /// 
         /// <param name="createLoginProfileRequest">Container for the necessary parameters to execute the CreateLoginProfile service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the CreateLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
         /// <exception cref="NoSuchEntityException"/>
         /// <exception cref="EntityAlreadyExistsException"/>
        CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest createLoginProfileRequest); 

         /// <summary>
         /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
         /// entities, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <param name="getAccountSummaryRequest">Container for the necessary parameters to execute the GetAccountSummary service method on
         ///           AmazonIdentityManagementService.</param>
         /// 
         /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest getAccountSummaryRequest); 

         /// <summary>
         /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
         /// entities, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
         /// </summary>
         /// 
         /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
         /// 
        GetAccountSummaryResponse GetAccountSummary();
    }
}
    
