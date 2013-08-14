/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Threading.Tasks;

using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Interface for accessing AmazonIdentityManagementService.
    /// 
    /// AWS Identity and Access Management <para>This guide provides descriptions of the Identity and Access Management (IAM) API as well as links
    /// to related content in the guide, Using IAM.</para> <para>IAM is a web service that enables AWS customers to manage users and user
    /// permissions under their AWS account. For more information about this product go to AWS Identity and Access Management (IAM). For information
    /// about setting up signatures and authorization through the API, go to Signing AWS API Requests in the <i>AWS General Reference</i> . For
    /// general information about using the Query API with IAM, go to Making Query Requests in <i>Using IAM</i> .</para> <para>If you're new to AWS
    /// and need additional technical information about a specific AWS product, you can find the product's technical documentation at
    /// http://aws.amazon.com/documentation/.</para>
    /// </summary>
	public partial interface IAmazonIdentityManagementService : IDisposable
    {
 

        /// <summary>
        /// <para>Adds the specified role to the specified instance profile. For more information about roles, go to Working with Roles. For more
        /// information about instance profiles, go to About Instance Profiles.</para>
        /// </summary>
        /// 
        /// <param name="addRoleToInstanceProfileRequest">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method
        /// on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.AddRoleToInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddRoleToInstanceProfileResponse> AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Adds the specified user to the specified group.</para>
        /// </summary>
        /// 
        /// <param name="addUserToGroupRequest">Container for the necessary parameters to execute the AddUserToGroup service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
		AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.AddUserToGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Changes the password of the IAM user calling <c>ChangePassword</c> . The root account password is not affected by this action. For
        /// information about modifying passwords, see Managing Passwords.</para>
        /// </summary>
        /// 
        /// <param name="changePasswordRequest">Container for the necessary parameters to execute the ChangePassword service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidUserTypeException" />
		ChangePasswordResponse ChangePassword(ChangePasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ChangePassword"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
		CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
		CreateAccessKeyResponse CreateAccessKey();
 

        /// <summary>
        /// <para>This action creates an alias for your AWS account. For information about using an AWS account alias, see Using an Alias for Your AWS
        /// Account ID in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createAccountAliasRequest">Container for the necessary parameters to execute the CreateAccountAlias service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateAccountAliasResponse> CreateAccountAliasAsync(CreateAccountAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new group.</para> <para>For information about the number of groups you can create, see Limitations on IAM Entities in
        /// <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createGroupRequest">Container for the necessary parameters to execute the CreateGroup service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new instance profile. For information about instance profiles, go to About Instance Profiles.</para> <para>For information
        /// about the number of instance profiles you can create, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="createInstanceProfileRequest">Container for the necessary parameters to execute the CreateInstanceProfile service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a password for the specified user, giving the user the ability to access AWS services through the AWS Management Console. For
        /// more information about managing passwords, see Managing Passwords in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLoginProfileRequest">Container for the necessary parameters to execute the CreateLoginProfile service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.PasswordPolicyViolationException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new role for your AWS account. For more information about roles, go to Working with Roles. For information about limitations
        /// on role names and the number of roles you can create, go to Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i>
        /// .</para> <para>The policy grants permission to an EC2 instance to assume the role. The policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html. Currently, only EC2 instances can assume roles.</para>
        /// </summary>
        /// 
        /// <param name="createRoleRequest">Container for the necessary parameters to execute the CreateRole service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		CreateRoleResponse CreateRole(CreateRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateRole"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new user for your AWS account.</para> <para>For information about limitations on the number of users you can create, see
        /// Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createUserRequest">Container for the necessary parameters to execute the CreateUser service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateUser"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deactivates the specified MFA device and removes it from association with the user name for which it was originally enabled.</para>
        /// </summary>
        /// 
        /// <param name="deactivateMFADeviceRequest">Container for the necessary parameters to execute the DeactivateMFADevice service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeactivateMFADevice"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeactivateMFADeviceResponse> DeactivateMFADeviceAsync(DeactivateMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the access key associated with the specified user.</para> <para>If you do not specify a user name, IAM determines the user
        /// name implicitly based on the AWS Access Key ID signing the request. Because this action works for access keys under the AWS account, you can
        /// use this API to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="deleteAccessKeyRequest">Container for the necessary parameters to execute the DeleteAccessKey service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccessKey"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified AWS account alias. For information about using an AWS account alias, see Using an Alias for Your AWS Account ID
        /// in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteAccountAliasRequest">Container for the necessary parameters to execute the DeleteAccountAlias service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the password policy for the AWS account.</para>
        /// </summary>
        /// 
        /// <param name="deleteAccountPasswordPolicyRequest">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service
        /// method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the password policy for the AWS account.</para>
        /// </summary>
        /// 
        /// <param name="deleteAccountPasswordPolicyRequest">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service
        /// method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy();
 

        /// <summary>
        /// <para>Deletes the specified group. The group must not contain any users or have any attached policies.</para>
        /// </summary>
        /// 
        /// <param name="deleteGroupRequest">Container for the necessary parameters to execute the DeleteGroup service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException" />
		DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified policy that is associated with the specified group.</para>
        /// </summary>
        /// 
        /// <param name="deleteGroupPolicyRequest">Container for the necessary parameters to execute the DeleteGroupPolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteGroupPolicyResponse> DeleteGroupPolicyAsync(DeleteGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified instance profile. The instance profile must not have an associated role.</para> <para><b>IMPORTANT:</b>Make sure
        /// you do not have any Amazon EC2 instances running with the instance profile you are about to delete. Deleting a role or instance profile that
        /// is associated with a running instance will break any applications running on the instance.</para> <para>For more information about instance
        /// profiles, go to About Instance Profiles.</para>
        /// </summary>
        /// 
        /// <param name="deleteInstanceProfileRequest">Container for the necessary parameters to execute the DeleteInstanceProfile service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException" />
		DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the password for the specified user, which terminates the user's ability to access AWS services through the AWS Management
        /// Console.</para> <para><b>IMPORTANT:</b>Deleting a user's password does not prevent a user from accessing IAM through the command line
        /// interface or the API. To prevent all user access you must also either make the access key inactive or delete it. For more information
        /// about making keys inactive or deleting them, see UpdateAccessKey and DeleteAccessKey. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoginProfileRequest">Container for the necessary parameters to execute the DeleteLoginProfile service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified role. The role must not have any policies attached. For more information about roles, go to Working with
        /// Roles.</para> <para><b>IMPORTANT:</b>Make sure you do not have any Amazon EC2 instances running with the role you are about to delete.
        /// Deleting a role or instance profile that is associated with a running instance will break any applications running on the instance.</para>
        /// </summary>
        /// 
        /// <param name="deleteRoleRequest">Container for the necessary parameters to execute the DeleteRole service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException" />
		DeleteRoleResponse DeleteRole(DeleteRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteRole"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified policy associated with the specified role.</para>
        /// </summary>
        /// 
        /// <param name="deleteRolePolicyRequest">Container for the necessary parameters to execute the DeleteRolePolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteRolePolicyResponse> DeleteRolePolicyAsync(DeleteRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified server certificate.</para> <para><b>IMPORTANT:</b>If you are using a server certificate with Elastic Load
        /// Balancing, deleting the certificate could have implications for your application. If Elastic Load Balancing doesn't detect the deletion of
        /// bound certificates, it may continue to use the certificates. This could cause Elastic Load Balancing to stop accepting traffic. We
        /// recommend that you remove the reference to the certificate from Elastic Load Balancing before using this command to delete the certificate.
        /// For more information, go to DeleteLoadBalancerListeners in the Elastic Load Balancing API Reference.</para>
        /// </summary>
        /// 
        /// <param name="deleteServerCertificateRequest">Container for the necessary parameters to execute the DeleteServerCertificate service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException" />
		DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified signing certificate associated with the specified user.</para> <para>If you do not specify a user name, IAM
        /// determines the user name implicitly based on the AWS Access Key ID signing the request. Because this action works for access keys under the
        /// AWS account, you can use this API to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="deleteSigningCertificateRequest">Container for the necessary parameters to execute the DeleteSigningCertificate service method
        /// on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSigningCertificateResponse> DeleteSigningCertificateAsync(DeleteSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified user. The user must not belong to any groups, have any keys or signing certificates, or have any attached
        /// policies.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserRequest">Container for the necessary parameters to execute the DeleteUser service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException" />
		DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteUser"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified policy associated with the specified user.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserPolicyRequest">Container for the necessary parameters to execute the DeleteUserPolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteUserPolicyResponse> DeleteUserPolicyAsync(DeleteUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes a virtual MFA device.</para> <para><b>NOTE:</b>You must deactivate a user's virtual MFA device before you can delete it. For
        /// information about deactivating MFA devices, see DeactivateMFADevice.</para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualMFADeviceRequest">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException" />
		DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Enables the specified MFA device and associates it with the specified user name. When enabled, the MFA device is required for every
        /// subsequent login by the user name associated with the device.</para>
        /// </summary>
        /// 
        /// <param name="enableMFADeviceRequest">Container for the necessary parameters to execute the EnableMFADevice service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.EnableMFADevice"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EnableMFADeviceResponse> EnableMFADeviceAsync(EnableMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Retrieves the password policy for the AWS account. For more information about using a password policy, go to Managing an IAM Password
        /// Policy.</para>
        /// </summary>
        /// 
        /// <param name="getAccountPasswordPolicyRequest">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method
        /// on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetAccountPasswordPolicyResponse GetAccountPasswordPolicy();
 

        /// <summary>
        /// <para>Retrieves the password policy for the AWS account. For more information about using a password policy, go to Managing an IAM Password
        /// Policy.</para>
        /// </summary>
        /// 
        /// <param name="getAccountPasswordPolicyRequest">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method
        /// on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
        /// entities, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="getAccountSummaryRequest">Container for the necessary parameters to execute the GetAccountSummary service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
		GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetAccountSummary"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetAccountSummaryResponse> GetAccountSummaryAsync(GetAccountSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
        /// entities, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="getAccountSummaryRequest">Container for the necessary parameters to execute the GetAccountSummary service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
		GetAccountSummaryResponse GetAccountSummary();
 

        /// <summary>
        /// <para>Returns a list of users that are in the specified group. You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="getGroupRequest">Container for the necessary parameters to execute the GetGroup service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified group. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="getGroupPolicyRequest">Container for the necessary parameters to execute the GetGroupPolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetGroupPolicyResponse> GetGroupPolicyAsync(GetGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves information about the specified instance profile, including the instance profile's path, GUID, ARN, and role. For more
        /// information about instance profiles, go to About Instance Profiles. For more information about ARNs, go to ARNs.</para>
        /// </summary>
        /// 
        /// <param name="getInstanceProfileRequest">Container for the necessary parameters to execute the GetInstanceProfile service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetInstanceProfileResponse> GetInstanceProfileAsync(GetInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves the user name and password create date for the specified user.</para>
        /// </summary>
        /// 
        /// <param name="getLoginProfileRequest">Container for the necessary parameters to execute the GetLoginProfile service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves information about the specified role, including the role's path, GUID, ARN, and the policy granting permission to EC2 to
        /// assume the role. For more information about ARNs, go to ARNs. For more information about roles, go to Working with Roles.</para> <para>The
        /// returned policy is URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="getRoleRequest">Container for the necessary parameters to execute the GetRole service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetRoleResponse GetRole(GetRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetRole"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified role. For more information about roles, go to Working with Roles.</para>
        /// <para>The returned policy is URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="getRolePolicyRequest">Container for the necessary parameters to execute the GetRolePolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetRolePolicyResponse> GetRolePolicyAsync(GetRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves information about the specified server certificate.</para>
        /// </summary>
        /// 
        /// <param name="getServerCertificateRequest">Container for the necessary parameters to execute the GetServerCertificate service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetServerCertificateResponse> GetServerCertificateAsync(GetServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves information about the specified user, including the user's path, GUID, and ARN.</para> <para>If you do not specify a user
        /// name, IAM determines the user name implicitly based on the AWS Access Key ID signing the request.</para>
        /// </summary>
        /// 
        /// <param name="getUserRequest">Container for the necessary parameters to execute the GetUser service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetUserResponse GetUser(GetUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetUser"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Retrieves information about the specified user, including the user's path, GUID, and ARN.</para> <para>If you do not specify a user
        /// name, IAM determines the user name implicitly based on the AWS Access Key ID signing the request.</para>
        /// </summary>
        /// 
        /// <param name="getUserRequest">Container for the necessary parameters to execute the GetUser service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetUserResponse GetUser();
 

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified user. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="getUserPolicyRequest">Container for the necessary parameters to execute the GetUserPolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetUserPolicyResponse> GetUserPolicyAsync(GetUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListAccessKeys"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListAccessKeysResponse ListAccessKeys();
 

        /// <summary>
        /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see Using an Alias for Your
        /// AWS Account ID in <i>Using AWS Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listAccountAliasesRequest">Container for the necessary parameters to execute the ListAccountAliases service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
		ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListAccountAliases"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListAccountAliasesResponse> ListAccountAliasesAsync(ListAccountAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see Using an Alias for Your
        /// AWS Account ID in <i>Using AWS Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listAccountAliasesRequest">Container for the necessary parameters to execute the ListAccountAliases service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
		ListAccountAliasesResponse ListAccountAliases();
 

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified group. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupPoliciesRequest">Container for the necessary parameters to execute the ListGroupPolicies service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroupPolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListGroupPoliciesResponse> ListGroupPoliciesAsync(ListGroupPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupsRequest">Container for the necessary parameters to execute the ListGroups service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
		ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupsRequest">Container for the necessary parameters to execute the ListGroups service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
		ListGroupsResponse ListGroups();
 

        /// <summary>
        /// <para>Lists the groups the specified user belongs to.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupsForUserRequest">Container for the necessary parameters to execute the ListGroupsForUser service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroupsForUser"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Lists the instance profiles that have the specified path prefix. If there are none, the action returns an empty list. For more
        /// information about instance profiles, go to About Instance Profiles.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesRequest">Container for the necessary parameters to execute the ListInstanceProfiles service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by AmazonIdentityManagementService.</returns>
		ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListInstanceProfiles"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(ListInstanceProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the instance profiles that have the specified path prefix. If there are none, the action returns an empty list. For more
        /// information about instance profiles, go to About Instance Profiles.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesRequest">Container for the necessary parameters to execute the ListInstanceProfiles service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by AmazonIdentityManagementService.</returns>
		ListInstanceProfilesResponse ListInstanceProfiles();
 

        /// <summary>
        /// <para>Lists the instance profiles that have the specified associated role. If there are none, the action returns an empty list. For more
        /// information about instance profiles, go to About Instance Profiles.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesForRoleRequest">Container for the necessary parameters to execute the ListInstanceProfilesForRole service
        /// method on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListInstanceProfilesForRole"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListInstanceProfilesForRoleResponse> ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
        /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID signing the
        /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listMFADevicesRequest">Container for the necessary parameters to execute the ListMFADevices service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListMFADevices"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListMFADevicesResponse> ListMFADevicesAsync(ListMFADevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
        /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS Access Key ID signing the
        /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listMFADevicesRequest">Container for the necessary parameters to execute the ListMFADevices service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListMFADevicesResponse ListMFADevices();
 

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified role. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listRolePoliciesRequest">Container for the necessary parameters to execute the ListRolePolicies service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListRolePolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListRolePoliciesResponse> ListRolePoliciesAsync(ListRolePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Lists the roles that have the specified path prefix. If there are none, the action returns an empty list. For more information about
        /// roles, go to Working with Roles.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// <para>The returned policy is URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="listRolesRequest">Container for the necessary parameters to execute the ListRoles service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by AmazonIdentityManagementService.</returns>
		ListRolesResponse ListRoles(ListRolesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListRoles"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the roles that have the specified path prefix. If there are none, the action returns an empty list. For more information about
        /// roles, go to Working with Roles.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// <para>The returned policy is URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// http://www.faqs.org/rfcs/rfc3986.html.</para>
        /// </summary>
        /// 
        /// <param name="listRolesRequest">Container for the necessary parameters to execute the ListRoles service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by AmazonIdentityManagementService.</returns>
		ListRolesResponse ListRoles();
 

        /// <summary>
        /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listServerCertificatesRequest">Container for the necessary parameters to execute the ListServerCertificates service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
		ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListServerCertificates"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListServerCertificatesResponse> ListServerCertificatesAsync(ListServerCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listServerCertificatesRequest">Container for the necessary parameters to execute the ListServerCertificates service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
		ListServerCertificatesResponse ListServerCertificates();
 

        /// <summary>
        /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
        /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
        /// implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this
        /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="listSigningCertificatesRequest">Container for the necessary parameters to execute the ListSigningCertificates service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListSigningCertificates"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(ListSigningCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
        /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
        /// implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this
        /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="listSigningCertificatesRequest">Container for the necessary parameters to execute the ListSigningCertificates service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListSigningCertificatesResponse ListSigningCertificates();
 

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified user. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listUserPoliciesRequest">Container for the necessary parameters to execute the ListUserPolicies service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListUserPolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListUserPoliciesResponse> ListUserPoliciesAsync(ListUserPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listUsersRequest">Container for the necessary parameters to execute the ListUsers service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
		ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListUsers"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listUsersRequest">Container for the necessary parameters to execute the ListUsers service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
		ListUsersResponse ListUsers();
 

        /// <summary>
        /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
        /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
        /// 
        /// <c>Unassigned</c> , or <c>Any</c> .
        /// </para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listVirtualMFADevicesRequest">Container for the necessary parameters to execute the ListVirtualMFADevices service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
		ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListVirtualMFADevices"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
        /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
        /// 
        /// <c>Unassigned</c> , or <c>Any</c> .
        /// </para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listVirtualMFADevicesRequest">Container for the necessary parameters to execute the ListVirtualMFADevices service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
		ListVirtualMFADevicesResponse ListVirtualMFADevices();
 

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified group. For information about policies, refer to Overview of Policies
        /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
        /// with a group, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
        /// documents can be large, you should use POST rather than GET when calling PutGroupPolicy. For information about setting up signatures and
        /// authorization through the API, go to Signing AWS API Requests in the AWS General Reference. For general information about using the Query
        /// API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putGroupPolicyRequest">Container for the necessary parameters to execute the PutGroupPolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
		PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutGroupPolicyResponse> PutGroupPolicyAsync(PutGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified role. For information about policies, go to Overview of Policies in
        /// <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the policies you can associate with a role,
        /// see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy documents can
        /// be large, you should use POST rather than GET when calling PutRolePolicy. For information about setting up signatures and authorization
        /// through the API, go to Signing AWS API Requests in the AWS General Reference. For general information about using the Query API with IAM, go
        /// to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putRolePolicyRequest">Container for the necessary parameters to execute the PutRolePolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
		PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutRolePolicyResponse> PutRolePolicyAsync(PutRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified user. For information about policies, refer to Overview of Policies
        /// in <i>Using AWS Identity and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate
        /// with a user, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy
        /// documents can be large, you should use POST rather than GET when calling PutUserPolicy. For information about setting up signatures and
        /// authorization through the API, go to Signing AWS API Requests in the AWS General Reference. For general information about using the Query
        /// API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putUserPolicyRequest">Container for the necessary parameters to execute the PutUserPolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
		PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutUserPolicyResponse> PutUserPolicyAsync(PutUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Removes the specified role from the specified instance profile.</para> <para><b>IMPORTANT:</b>Make sure you do not have any Amazon EC2
        /// instances running with the role you are about to remove from the instance profile. Removing a role from an instance profile that is
        /// associated with a running instance will break any applications running on the instance.</para> <para>For more information about roles, go to
        /// Working with Roles. For more information about instance profiles, go to About Instance Profiles.</para>
        /// </summary>
        /// 
        /// <param name="removeRoleFromInstanceProfileRequest">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile
        /// service method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.RemoveRoleFromInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RemoveRoleFromInstanceProfileResponse> RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Removes the specified user from the specified group.</para>
        /// </summary>
        /// 
        /// <param name="removeUserFromGroupRequest">Container for the necessary parameters to execute the RemoveUserFromGroup service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.RemoveUserFromGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Synchronizes the specified MFA device with AWS servers.</para>
        /// </summary>
        /// 
        /// <param name="resyncMFADeviceRequest">Container for the necessary parameters to execute the ResyncMFADevice service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException" />
		ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ResyncMFADevice"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResyncMFADeviceResponse> ResyncMFADeviceAsync(ResyncMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Changes the status of the specified access key from Active to Inactive, or vice versa. This action can be used to disable a user's key
        /// as part of a key rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based
        /// on the AWS Access Key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to
        /// manage root credentials even if the AWS account has no associated users.</para> <para>For information about rotating keys, see Managing Keys
        /// and Certificates in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateAccessKeyRequest">Container for the necessary parameters to execute the UpdateAccessKey service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Updates the password policy settings for the account. For more information about using a password policy, go to Managing an IAM
        /// Password Policy.</para>
        /// </summary>
        /// 
        /// <param name="updateAccountPasswordPolicyRequest">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service
        /// method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Updates the password policy settings for the account. For more information about using a password policy, go to Managing an IAM
        /// Password Policy.</para>
        /// </summary>
        /// 
        /// <param name="updateAccountPasswordPolicyRequest">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service
        /// method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy();
 

        /// <summary>
        /// <para>Updates the policy that grants an entity permission to assume a role. Currently, only an Amazon EC2 instance can assume a role. For
        /// more information about roles, go to Working with Roles.</para>
        /// </summary>
        /// 
        /// <param name="updateAssumeRolePolicyRequest">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAssumeRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Updates the name and/or the path of the specified group.</para> <para><b>IMPORTANT:</b> You should understand the implications of
        /// changing a group's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
        /// <para><b>NOTE:</b>To change a group name the requester must have appropriate permissions on both the source object and the target object.
        /// For example, to change Managers to MGRs, the entity making the request must have permission on Managers and MGRs, or must have permission on
        /// all (*). For more information about permissions, see Permissions and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateGroupRequest">Container for the necessary parameters to execute the UpdateGroup service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Changes the password for the specified user.</para>
        /// </summary>
        /// 
        /// <param name="updateLoginProfileRequest">Container for the necessary parameters to execute the UpdateLoginProfile service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.PasswordPolicyViolationException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateServerCertificateResponse> UpdateServerCertificateAsync(UpdateServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Changes the status of the specified signing certificate from active to disabled, or vice versa. This action can be used to disable a
        /// user's signing certificate as part of a certificate rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the
        /// UserName is determined implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under
        /// the AWS account, this API can be used to manage root credentials even if the AWS account has no associated users.</para> <para>For
        /// information about rotating certificates, see Managing Keys and Certificates in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateSigningCertificateRequest">Container for the necessary parameters to execute the UpdateSigningCertificate service method
        /// on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
		UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateSigningCertificateResponse> UpdateSigningCertificateAsync(UpdateSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Updates the name and/or the path of the specified user.</para> <para><b>IMPORTANT:</b> You should understand the implications of
        /// changing a user's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
        /// <para><b>NOTE:</b>To change a user name the requester must have appropriate permissions on both the source object and the target object.
        /// For example, to change Bob to Robert, the entity making the request must have permission on Bob and Robert, or must have permission on all
        /// (*). For more information about permissions, see Permissions and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateUserRequest">Container for the necessary parameters to execute the UpdateUser service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateUser"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Uploads a server certificate entity for the AWS account. The server certificate entity includes a public key certificate, a private
        /// key, and an optional certificate chain, which should all be PEM-encoded.</para> <para>For information about the number of server
        /// certificates you can upload, see Limitations on IAM Entities in <i>Using AWS Identity and Access Management</i> .</para>
        /// <para><b>NOTE:</b>Because the body of the public key certificate, private key, and the certificate chain can be large, you should use POST
        /// rather than GET when calling UploadServerCertificate. For information about setting up signatures and authorization through the API, go to
        /// Signing AWS API Requests in the AWS General Reference. For general information about using the Query API with IAM, go to Making Query
        /// Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="uploadServerCertificateRequest">Container for the necessary parameters to execute the UploadServerCertificate service method on
        /// AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.KeyPairMismatchException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedCertificateException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UploadServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Uploads an X.509 signing certificate and associates it with the specified user. Some AWS services use X.509 signing certificates to
        /// validate requests that are signed with a corresponding private key. When you upload the certificate, its default status is <c>Active</c>
        /// .</para> <para>If the <c>UserName</c> field is not specified, the user name is determined implicitly based on the AWS Access Key ID used to
        /// sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root credentials even if
        /// the AWS account has no associated users.</para> <para><b>NOTE:</b>Because the body of a X.509 certificate can be large, you should use POST
        /// rather than GET when calling UploadSigningCertificate. For information about setting up signatures and authorization through the API, go to
        /// Signing AWS API Requests in the AWS General Reference. For general information about using the Query API with IAM, go to Making Query
        /// Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="uploadSigningCertificateRequest">Container for the necessary parameters to execute the UploadSigningCertificate service method
        /// on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="T:Amazon.IdentityManagement.Model.DuplicateCertificateException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidCertificateException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedCertificateException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException" />
		UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UploadSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UploadSigningCertificateResponse> UploadSigningCertificateAsync(UploadSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
