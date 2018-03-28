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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Interface for accessing IdentityManagementService
    ///
    /// AWS Identity and Access Management 
    /// <para>
    /// AWS Identity and Access Management (IAM) is a web service that you can use to manage
    /// users and user permissions under your AWS account. This guide provides descriptions
    /// of IAM actions that you can call programmatically. For general information about IAM,
    /// see <a href="http://aws.amazon.com/iam/">AWS Identity and Access Management (IAM)</a>.
    /// For the user guide for IAM, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/">Using
    /// IAM</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to IAM and AWS. For example, the SDKs
    /// take care of tasks such as cryptographically signing requests (see below), managing
    /// errors, and retrying requests automatically. For information about the AWS SDKs, including
    /// how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a> page. 
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to IAM. However,
    /// you can also use the IAM Query API to make direct calls to the IAM web service. To
    /// learn more about the IAM Query API, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in the <i>Using IAM</i> guide. IAM supports GET and POST requests
    /// for all actions. That is, the API does not require you to use GET for some actions
    /// and POST for others. However, GET requests are subject to the limitation size of a
    /// URL. Therefore, for operations that require larger sizes, use a POST request. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed using an access key ID and a secret access key. We strongly
    /// recommend that you do not use your AWS account access key ID and secret access key
    /// for everyday work with IAM. You can use the access key ID and secret access key for
    /// an IAM user or you can use the AWS Security Token Service to generate temporary security
    /// credentials and use those to sign requests.
    /// </para>
    ///  
    /// <para>
    /// To sign requests, we recommend that you use <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>. If you have an existing application that uses Signature Version 2,
    /// you do not have to update it to use Signature Version 4. However, some operations
    /// now require Signature Version 4. The documentation for operations that require version
    /// 4 indicate this requirement. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a>. This topic provides general information about the types
    /// of credentials used for accessing AWS. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html">IAM
    /// Best Practices</a>. This topic presents a list of suggestions for using the IAM service
    /// to help secure your AWS resources. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a>. This set of topics walk you through the process of signing a
    /// request using an access key ID and secret access key. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonIdentityManagementService : IAmazonService, IDisposable
    {
                
        #region  AddClientIDToOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the AddClientIDToOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        Task<AddClientIDToOpenIDConnectProviderResponse> AddClientIDToOpenIDConnectProviderAsync(AddClientIDToOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddRoleToInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        Task<AddRoleToInstanceProfileResponse> AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddUserToGroup


        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        Task<AttachGroupPolicyResponse> AttachGroupPolicyAsync(AttachGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        Task<AttachRolePolicyResponse> AttachRolePolicyAsync(AttachRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        Task<AttachUserPolicyResponse> AttachUserPolicyAsync(AttachUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangePassword


        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccessKey


        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified
        /// user. The default status for new keys is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. Because this operation works for access
        /// keys under the AWS account, you can use this operation to manage AWS account root
        /// user credentials. This is true even if the AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        ///  For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To ensure the security of your AWS account, the secret access key is accessible only
        /// during key and user creation. You must save the key (for example, in a text file)
        /// if you want to be able to access it again. If a secret key is lost, you can delete
        /// the access keys for the associated user and then create new keys.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        Task<CreateAccessKeyResponse> CreateAccessKeyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccountAlias


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        Task<CreateAccountAliasResponse> CreateAccountAliasAsync(CreateAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        Task<CreateOpenIDConnectProviderResponse> CreateOpenIDConnectProviderAsync(CreateOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRole


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        Task<CreateSAMLProviderResponse> CreateSAMLProviderAsync(CreateSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateServiceLinkedRole


        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLinkedRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceLinkedRole">REST API Reference for CreateServiceLinkedRole Operation</seealso>
        Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceSpecificCredential">REST API Reference for CreateServiceSpecificCredential Operation</seealso>
        Task<CreateServiceSpecificCredentialResponse> CreateServiceSpecificCredentialAsync(CreateServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUser


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVirtualMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeactivateMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        Task<DeactivateMFADeviceResponse> DeactivateMFADeviceAsync(DeactivateMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessKey


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccountAlias


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccountPasswordPolicy


        /// <summary>
        /// Deletes the password policy for the AWS account. There are no parameters.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        Task<DeleteGroupPolicyResponse> DeleteGroupPolicyAsync(DeleteGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        Task<DeleteOpenIDConnectProviderResponse> DeleteOpenIDConnectProviderAsync(DeleteOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRole


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        Task<DeleteRolePolicyResponse> DeleteRolePolicyAsync(DeleteRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        Task<DeleteSAMLProviderResponse> DeleteSAMLProviderAsync(DeleteSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceLinkedRole


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        Task<DeleteServiceSpecificCredentialResponse> DeleteServiceSpecificCredentialAsync(DeleteServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        Task<DeleteSigningCertificateResponse> DeleteSigningCertificateAsync(DeleteSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        Task<DeleteSSHPublicKeyResponse> DeleteSSHPublicKeyAsync(DeleteSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUser


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        Task<DeleteUserPolicyResponse> DeleteUserPolicyAsync(DeleteUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVirtualMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        Task<DetachGroupPolicyResponse> DetachGroupPolicyAsync(DetachGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        Task<DetachRolePolicyResponse> DetachRolePolicyAsync(DetachRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        Task<DetachUserPolicyResponse> DetachUserPolicyAsync(DetachUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        Task<EnableMFADeviceResponse> EnableMFADeviceAsync(EnableMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateCredentialReport


        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(GenerateCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessKeyLastUsed


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountAuthorizationDetails


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        Task<GetAccountAuthorizationDetailsResponse> GetAccountAuthorizationDetailsAsync(GetAccountAuthorizationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountPasswordPolicy


        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountSummary


        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the AWS account.
        /// 
        ///  
        /// <para>
        ///  For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        Task<GetAccountSummaryResponse> GetAccountSummaryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        Task<GetAccountSummaryResponse> GetAccountSummaryAsync(GetAccountSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContextKeysForCustomPolicy


        /// <summary>
        /// Gets a list of all of the context keys referenced in the input policies. The policies
        /// are supplied as a list of one or more strings. To get the context keys from policies
        /// associated with an IAM user, group, or role, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. Context keys can be evaluated by testing
        /// against a value specified in an IAM policy. Use <code>GetContextKeysForCustomPolicy</code>
        /// to understand what key names and values you must supply when you call <a>SimulateCustomPolicy</a>.
        /// Note that all parameters are shown in unencoded form here for clarity but must be
        /// URL encoded to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="policyInputList">A list of policies for which you want the list of context keys referenced in those policies. Each document is specified as a string containing the complete, valid JSON text of an IAM policy. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (\u0020) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through \u00FF) </li> <li> The special characters tab (\u0009), line feed (\u000A), and carriage return (\u000D) </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(GetContextKeysForCustomPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContextKeysForPrincipalPolicy


        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. Context keys can be evaluated by testing
        /// against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a> to understand
        /// what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. Context keys can be evaluated by testing
        /// against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a> to understand
        /// what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
        /// <param name="policyInputList">An optional list of additional policies for which you want the list of context keys that are referenced. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (\u0020) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through \u00FF) </li> <li> The special characters tab (\u0009), line feed (\u000A), and carriage return (\u000D) </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(GetContextKeysForPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCredentialReport


        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        Task<GetCredentialReportResponse> GetCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        Task<GetCredentialReportResponse> GetCredentialReportAsync(GetCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        Task<GetGroupPolicyResponse> GetGroupPolicyAsync(GetGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        Task<GetInstanceProfileResponse> GetInstanceProfileAsync(GetInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        Task<GetOpenIDConnectProviderResponse> GetOpenIDConnectProviderAsync(GetOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRole


        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        Task<GetRolePolicyResponse> GetRolePolicyAsync(GetRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        Task<GetSAMLProviderResponse> GetSAMLProviderAsync(GetSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        Task<GetServerCertificateResponse> GetServerCertificateAsync(GetServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceLinkedRoleDeletionStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLinkedRoleDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLinkedRoleDeletionStatus">REST API Reference for GetServiceLinkedRoleDeletionStatus Operation</seealso>
        Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatusAsync(GetServiceLinkedRoleDeletionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        Task<GetSSHPublicKeyResponse> GetSSHPublicKeyAsync(GetSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUser


        /// <summary>
        /// Retrieves information about the specified IAM user, including the user's creation
        /// date, path, unique ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID used to sign the request to this API.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        Task<GetUserResponse> GetUserAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        Task<GetUserPolicyResponse> GetUserPolicyAsync(GetUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessKeys


        /// <summary>
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there are none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this operation works
        /// for access keys under the AWS account, you can use this operation to manage AWS account
        /// root user credentials even if the AWS account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// To ensure the security of your AWS account, the secret access key is accessible only
        /// during key and user creation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        Task<ListAccessKeysResponse> ListAccessKeysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccountAliases


        /// <summary>
        /// Lists the account alias associated with the AWS account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        Task<ListAccountAliasesResponse> ListAccountAliasesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        Task<ListAccountAliasesResponse> ListAccountAliasesAsync(ListAccountAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttachedGroupPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        Task<ListAttachedGroupPoliciesResponse> ListAttachedGroupPoliciesAsync(ListAttachedGroupPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttachedRolePolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        Task<ListAttachedRolePoliciesResponse> ListAttachedRolePoliciesAsync(ListAttachedRolePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttachedUserPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        Task<ListAttachedUserPoliciesResponse> ListAttachedUserPoliciesAsync(ListAttachedUserPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEntitiesForPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroupPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        Task<ListGroupPoliciesResponse> ListGroupPoliciesAsync(ListGroupPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroups


        /// <summary>
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroupsForUser


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInstanceProfiles


        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(ListInstanceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInstanceProfilesForRole


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        Task<ListInstanceProfilesForRoleResponse> ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMFADevices


        /// <summary>
        /// Lists the MFA devices for an IAM user. If the request includes a IAM user name, then
        /// this operation lists all the MFA devices associated with the specified user. If you
        /// do not specify a user name, IAM determines the user name implicitly based on the AWS
        /// access key ID signing the request for this API.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        Task<ListMFADevicesResponse> ListMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        Task<ListMFADevicesResponse> ListMFADevicesAsync(ListMFADevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOpenIDConnectProviders


        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        Task<ListOpenIDConnectProvidersResponse> ListOpenIDConnectProvidersAsync(ListOpenIDConnectProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicies


        /// <summary>
        /// Lists all the managed policies that are available in your AWS account, including your
        /// own customer-defined managed policies and all AWS managed policies.
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <code>OnlyAttached</code>,
        /// <code>Scope</code>, and <code>PathPrefix</code> parameters. For example, to list only
        /// the customer managed policies in your AWS account, set <code>Scope</code> to <code>Local</code>.
        /// To list only AWS managed policies, set <code>Scope</code> to <code>AWS</code>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicyVersions


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRolePolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        Task<ListRolePoliciesResponse> ListRolePoliciesAsync(ListRolePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoles


        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        Task<ListRolesResponse> ListRolesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSAMLProviders


        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(ListSAMLProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServerCertificates


        /// <summary>
        /// Lists the server certificates stored in IAM that have the specified path prefix. If
        /// none exist, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        Task<ListServerCertificatesResponse> ListServerCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        Task<ListServerCertificatesResponse> ListServerCertificatesAsync(ListServerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceSpecificCredentials


        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceSpecificCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServiceSpecificCredentials">REST API Reference for ListServiceSpecificCredentials Operation</seealso>
        Task<ListServiceSpecificCredentialsResponse> ListServiceSpecificCredentialsAsync(ListServiceSpecificCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSigningCertificates


        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If there are none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request for this API. Because this
        /// operation works for access keys under the AWS account, you can use this operation
        /// to manage AWS account root user credentials even if the AWS account has no associated
        /// users.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(ListSigningCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSSHPublicKeys


        /// <summary>
        /// Initiates the asynchronous execution of the ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        Task<ListSSHPublicKeysResponse> ListSSHPublicKeysAsync(ListSSHPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        Task<ListUserPoliciesResponse> ListUserPoliciesAsync(ListUserPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers


        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the operation returns all users in the AWS account. If there are none, the operation
        /// returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualMFADevices


        /// <summary>
        /// Lists the virtual MFA devices defined in the AWS account by assignment status. If
        /// you do not specify an assignment status, the operation returns a list of all virtual
        /// MFA devices. Assignment status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        Task<PutGroupPolicyResponse> PutGroupPolicyAsync(PutGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        Task<PutRolePolicyResponse> PutRolePolicyAsync(PutRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        Task<PutUserPolicyResponse> PutUserPolicyAsync(PutUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveClientIDFromOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        Task<RemoveClientIDFromOpenIDConnectProviderResponse> RemoveClientIDFromOpenIDConnectProviderAsync(RemoveClientIDFromOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveRoleFromInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        Task<RemoveRoleFromInstanceProfileResponse> RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveUserFromGroup


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the ResetServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        Task<ResetServiceSpecificCredentialResponse> ResetServiceSpecificCredentialAsync(ResetServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResyncMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        Task<ResyncMFADeviceResponse> ResyncMFADeviceAsync(ResyncMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetDefaultPolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SimulateCustomPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        Task<SimulateCustomPolicyResponse> SimulateCustomPolicyAsync(SimulateCustomPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SimulatePrincipalPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        Task<SimulatePrincipalPolicyResponse> SimulatePrincipalPolicyAsync(SimulatePrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccessKey


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountPasswordPolicy


        /// <summary>
        /// Updates the password policy settings for the AWS account.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This operation does not support partial updates. No parameters are required, but if
        /// you do not specify a parameter, that parameter's value reverts to its default value.
        /// See the <b>Request Parameters</b> section for each parameter's default value. Also
        /// note that some parameters do not allow the default parameter to be explicitly set.
        /// Instead, to invoke the default value, do not include that parameter when you invoke
        /// the operation.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        ///  For more information about using a password policy, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAssumeRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateOpenIDConnectProviderThumbprint


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        Task<UpdateOpenIDConnectProviderThumbprintResponse> UpdateOpenIDConnectProviderThumbprintAsync(UpdateOpenIDConnectProviderThumbprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRole


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoleDescription


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoleDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        Task<UpdateRoleDescriptionResponse> UpdateRoleDescriptionAsync(UpdateRoleDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        Task<UpdateSAMLProviderResponse> UpdateSAMLProviderAsync(UpdateSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        Task<UpdateServerCertificateResponse> UpdateServerCertificateAsync(UpdateServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        Task<UpdateServiceSpecificCredentialResponse> UpdateServiceSpecificCredentialAsync(UpdateServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        Task<UpdateSigningCertificateResponse> UpdateSigningCertificateAsync(UpdateSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        Task<UpdateSSHPublicKeyResponse> UpdateSSHPublicKeyAsync(UpdateSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUser


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        Task<UploadSigningCertificateResponse> UploadSigningCertificateAsync(UploadSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        Task<UploadSSHPublicKeyResponse> UploadSSHPublicKeyAsync(UploadSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}