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
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        void AddClientIDToOpenIDConnectProviderAsync(AddClientIDToOpenIDConnectProviderRequest request, AmazonServiceCallback<AddClientIDToOpenIDConnectProviderRequest, AddClientIDToOpenIDConnectProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AddRoleToInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        void AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest request, AmazonServiceCallback<AddRoleToInstanceProfileRequest, AddRoleToInstanceProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AddUserToGroup


        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        void AddUserToGroupAsync(AddUserToGroupRequest request, AmazonServiceCallback<AddUserToGroupRequest, AddUserToGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AttachGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        void AttachGroupPolicyAsync(AttachGroupPolicyRequest request, AmazonServiceCallback<AttachGroupPolicyRequest, AttachGroupPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AttachRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        void AttachRolePolicyAsync(AttachRolePolicyRequest request, AmazonServiceCallback<AttachRolePolicyRequest, AttachRolePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AttachUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        void AttachUserPolicyAsync(AttachUserPolicyRequest request, AmazonServiceCallback<AttachUserPolicyRequest, AttachUserPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ChangePassword


        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        void ChangePasswordAsync(ChangePasswordRequest request, AmazonServiceCallback<ChangePasswordRequest, ChangePasswordResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateAccessKey


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        void CreateAccessKeyAsync(CreateAccessKeyRequest request, AmazonServiceCallback<CreateAccessKeyRequest, CreateAccessKeyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateAccountAlias


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        void CreateAccountAliasAsync(CreateAccountAliasRequest request, AmazonServiceCallback<CreateAccountAliasRequest, CreateAccountAliasResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        void CreateGroupAsync(CreateGroupRequest request, AmazonServiceCallback<CreateGroupRequest, CreateGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        void CreateInstanceProfileAsync(CreateInstanceProfileRequest request, AmazonServiceCallback<CreateInstanceProfileRequest, CreateInstanceProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        void CreateLoginProfileAsync(CreateLoginProfileRequest request, AmazonServiceCallback<CreateLoginProfileRequest, CreateLoginProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        void CreateOpenIDConnectProviderAsync(CreateOpenIDConnectProviderRequest request, AmazonServiceCallback<CreateOpenIDConnectProviderRequest, CreateOpenIDConnectProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        void CreatePolicyAsync(CreatePolicyRequest request, AmazonServiceCallback<CreatePolicyRequest, CreatePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreatePolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        void CreatePolicyVersionAsync(CreatePolicyVersionRequest request, AmazonServiceCallback<CreatePolicyVersionRequest, CreatePolicyVersionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateRole


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        void CreateRoleAsync(CreateRoleRequest request, AmazonServiceCallback<CreateRoleRequest, CreateRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        void CreateSAMLProviderAsync(CreateSAMLProviderRequest request, AmazonServiceCallback<CreateSAMLProviderRequest, CreateSAMLProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateServiceLinkedRole


        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLinkedRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceLinkedRole">REST API Reference for CreateServiceLinkedRole Operation</seealso>
        void CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request, AmazonServiceCallback<CreateServiceLinkedRoleRequest, CreateServiceLinkedRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceSpecificCredential">REST API Reference for CreateServiceSpecificCredential Operation</seealso>
        void CreateServiceSpecificCredentialAsync(CreateServiceSpecificCredentialRequest request, AmazonServiceCallback<CreateServiceSpecificCredentialRequest, CreateServiceSpecificCredentialResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        void CreateUserAsync(CreateUserRequest request, AmazonServiceCallback<CreateUserRequest, CreateUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateVirtualMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        void CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request, AmazonServiceCallback<CreateVirtualMFADeviceRequest, CreateVirtualMFADeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeactivateMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        void DeactivateMFADeviceAsync(DeactivateMFADeviceRequest request, AmazonServiceCallback<DeactivateMFADeviceRequest, DeactivateMFADeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteAccessKey


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        void DeleteAccessKeyAsync(DeleteAccessKeyRequest request, AmazonServiceCallback<DeleteAccessKeyRequest, DeleteAccessKeyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteAccountAlias


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        void DeleteAccountAliasAsync(DeleteAccountAliasRequest request, AmazonServiceCallback<DeleteAccountAliasRequest, DeleteAccountAliasResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteAccountPasswordPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        void DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest request, AmazonServiceCallback<DeleteAccountPasswordPolicyRequest, DeleteAccountPasswordPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        void DeleteGroupAsync(DeleteGroupRequest request, AmazonServiceCallback<DeleteGroupRequest, DeleteGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        void DeleteGroupPolicyAsync(DeleteGroupPolicyRequest request, AmazonServiceCallback<DeleteGroupPolicyRequest, DeleteGroupPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        void DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, AmazonServiceCallback<DeleteInstanceProfileRequest, DeleteInstanceProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        void DeleteLoginProfileAsync(DeleteLoginProfileRequest request, AmazonServiceCallback<DeleteLoginProfileRequest, DeleteLoginProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        void DeleteOpenIDConnectProviderAsync(DeleteOpenIDConnectProviderRequest request, AmazonServiceCallback<DeleteOpenIDConnectProviderRequest, DeleteOpenIDConnectProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        void DeletePolicyAsync(DeletePolicyRequest request, AmazonServiceCallback<DeletePolicyRequest, DeletePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeletePolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        void DeletePolicyVersionAsync(DeletePolicyVersionRequest request, AmazonServiceCallback<DeletePolicyVersionRequest, DeletePolicyVersionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteRole


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        void DeleteRoleAsync(DeleteRoleRequest request, AmazonServiceCallback<DeleteRoleRequest, DeleteRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        void DeleteRolePolicyAsync(DeleteRolePolicyRequest request, AmazonServiceCallback<DeleteRolePolicyRequest, DeleteRolePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        void DeleteSAMLProviderAsync(DeleteSAMLProviderRequest request, AmazonServiceCallback<DeleteSAMLProviderRequest, DeleteSAMLProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        void DeleteServerCertificateAsync(DeleteServerCertificateRequest request, AmazonServiceCallback<DeleteServerCertificateRequest, DeleteServerCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteServiceLinkedRole


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        void DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, AmazonServiceCallback<DeleteServiceLinkedRoleRequest, DeleteServiceLinkedRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        void DeleteServiceSpecificCredentialAsync(DeleteServiceSpecificCredentialRequest request, AmazonServiceCallback<DeleteServiceSpecificCredentialRequest, DeleteServiceSpecificCredentialResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        void DeleteSigningCertificateAsync(DeleteSigningCertificateRequest request, AmazonServiceCallback<DeleteSigningCertificateRequest, DeleteSigningCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        void DeleteSSHPublicKeyAsync(DeleteSSHPublicKeyRequest request, AmazonServiceCallback<DeleteSSHPublicKeyRequest, DeleteSSHPublicKeyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        void DeleteUserAsync(DeleteUserRequest request, AmazonServiceCallback<DeleteUserRequest, DeleteUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        void DeleteUserPolicyAsync(DeleteUserPolicyRequest request, AmazonServiceCallback<DeleteUserPolicyRequest, DeleteUserPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteVirtualMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        void DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request, AmazonServiceCallback<DeleteVirtualMFADeviceRequest, DeleteVirtualMFADeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DetachGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        void DetachGroupPolicyAsync(DetachGroupPolicyRequest request, AmazonServiceCallback<DetachGroupPolicyRequest, DetachGroupPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DetachRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        void DetachRolePolicyAsync(DetachRolePolicyRequest request, AmazonServiceCallback<DetachRolePolicyRequest, DetachRolePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DetachUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        void DetachUserPolicyAsync(DetachUserPolicyRequest request, AmazonServiceCallback<DetachUserPolicyRequest, DetachUserPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  EnableMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        void EnableMFADeviceAsync(EnableMFADeviceRequest request, AmazonServiceCallback<EnableMFADeviceRequest, EnableMFADeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GenerateCredentialReport


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        void GenerateCredentialReportAsync(GenerateCredentialReportRequest request, AmazonServiceCallback<GenerateCredentialReportRequest, GenerateCredentialReportResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetAccessKeyLastUsed


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        void GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request, AmazonServiceCallback<GetAccessKeyLastUsedRequest, GetAccessKeyLastUsedResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetAccountAuthorizationDetails


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        void GetAccountAuthorizationDetailsAsync(GetAccountAuthorizationDetailsRequest request, AmazonServiceCallback<GetAccountAuthorizationDetailsRequest, GetAccountAuthorizationDetailsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetAccountPasswordPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        void GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, AmazonServiceCallback<GetAccountPasswordPolicyRequest, GetAccountPasswordPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetAccountSummary


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        void GetAccountSummaryAsync(GetAccountSummaryRequest request, AmazonServiceCallback<GetAccountSummaryRequest, GetAccountSummaryResponse> callback, AsyncOptions options = null);


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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        void GetContextKeysForCustomPolicyAsync(List<string> policyInputList,  AmazonServiceCallback<GetContextKeysForCustomPolicyRequest, GetContextKeysForCustomPolicyResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        void GetContextKeysForCustomPolicyAsync(GetContextKeysForCustomPolicyRequest request, AmazonServiceCallback<GetContextKeysForCustomPolicyRequest, GetContextKeysForCustomPolicyResponse> callback, AsyncOptions options = null);


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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
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
        void GetContextKeysForPrincipalPolicyAsync(string policySourceArn,  AmazonServiceCallback<GetContextKeysForPrincipalPolicyRequest, GetContextKeysForPrincipalPolicyResponse> callback, AsyncOptions options = null);

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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
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
        void GetContextKeysForPrincipalPolicyAsync(string policySourceArn, List<string> policyInputList,  AmazonServiceCallback<GetContextKeysForPrincipalPolicyRequest, GetContextKeysForPrincipalPolicyResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        void GetContextKeysForPrincipalPolicyAsync(GetContextKeysForPrincipalPolicyRequest request, AmazonServiceCallback<GetContextKeysForPrincipalPolicyRequest, GetContextKeysForPrincipalPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetCredentialReport


        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        void GetCredentialReportAsync(GetCredentialReportRequest request, AmazonServiceCallback<GetCredentialReportRequest, GetCredentialReportResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        void GetGroupAsync(GetGroupRequest request, AmazonServiceCallback<GetGroupRequest, GetGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        void GetGroupPolicyAsync(GetGroupPolicyRequest request, AmazonServiceCallback<GetGroupPolicyRequest, GetGroupPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        void GetInstanceProfileAsync(GetInstanceProfileRequest request, AmazonServiceCallback<GetInstanceProfileRequest, GetInstanceProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        void GetLoginProfileAsync(GetLoginProfileRequest request, AmazonServiceCallback<GetLoginProfileRequest, GetLoginProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        void GetOpenIDConnectProviderAsync(GetOpenIDConnectProviderRequest request, AmazonServiceCallback<GetOpenIDConnectProviderRequest, GetOpenIDConnectProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        void GetPolicyAsync(GetPolicyRequest request, AmazonServiceCallback<GetPolicyRequest, GetPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetPolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        void GetPolicyVersionAsync(GetPolicyVersionRequest request, AmazonServiceCallback<GetPolicyVersionRequest, GetPolicyVersionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetRole


        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        void GetRoleAsync(GetRoleRequest request, AmazonServiceCallback<GetRoleRequest, GetRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        void GetRolePolicyAsync(GetRolePolicyRequest request, AmazonServiceCallback<GetRolePolicyRequest, GetRolePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        void GetSAMLProviderAsync(GetSAMLProviderRequest request, AmazonServiceCallback<GetSAMLProviderRequest, GetSAMLProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        void GetServerCertificateAsync(GetServerCertificateRequest request, AmazonServiceCallback<GetServerCertificateRequest, GetServerCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetServiceLinkedRoleDeletionStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLinkedRoleDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLinkedRoleDeletionStatus">REST API Reference for GetServiceLinkedRoleDeletionStatus Operation</seealso>
        void GetServiceLinkedRoleDeletionStatusAsync(GetServiceLinkedRoleDeletionStatusRequest request, AmazonServiceCallback<GetServiceLinkedRoleDeletionStatusRequest, GetServiceLinkedRoleDeletionStatusResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        void GetSSHPublicKeyAsync(GetSSHPublicKeyRequest request, AmazonServiceCallback<GetSSHPublicKeyRequest, GetSSHPublicKeyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetUser


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        void GetUserAsync(GetUserRequest request, AmazonServiceCallback<GetUserRequest, GetUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        void GetUserPolicyAsync(GetUserPolicyRequest request, AmazonServiceCallback<GetUserPolicyRequest, GetUserPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListAccessKeys


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        void ListAccessKeysAsync(ListAccessKeysRequest request, AmazonServiceCallback<ListAccessKeysRequest, ListAccessKeysResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListAccountAliases


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        void ListAccountAliasesAsync(ListAccountAliasesRequest request, AmazonServiceCallback<ListAccountAliasesRequest, ListAccountAliasesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListAttachedGroupPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        void ListAttachedGroupPoliciesAsync(ListAttachedGroupPoliciesRequest request, AmazonServiceCallback<ListAttachedGroupPoliciesRequest, ListAttachedGroupPoliciesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListAttachedRolePolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        void ListAttachedRolePoliciesAsync(ListAttachedRolePoliciesRequest request, AmazonServiceCallback<ListAttachedRolePoliciesRequest, ListAttachedRolePoliciesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListAttachedUserPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        void ListAttachedUserPoliciesAsync(ListAttachedUserPoliciesRequest request, AmazonServiceCallback<ListAttachedUserPoliciesRequest, ListAttachedUserPoliciesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListEntitiesForPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        void ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest request, AmazonServiceCallback<ListEntitiesForPolicyRequest, ListEntitiesForPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListGroupPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        void ListGroupPoliciesAsync(ListGroupPoliciesRequest request, AmazonServiceCallback<ListGroupPoliciesRequest, ListGroupPoliciesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        void ListGroupsAsync(ListGroupsRequest request, AmazonServiceCallback<ListGroupsRequest, ListGroupsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListGroupsForUser


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        void ListGroupsForUserAsync(ListGroupsForUserRequest request, AmazonServiceCallback<ListGroupsForUserRequest, ListGroupsForUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListInstanceProfiles


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        void ListInstanceProfilesAsync(ListInstanceProfilesRequest request, AmazonServiceCallback<ListInstanceProfilesRequest, ListInstanceProfilesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListInstanceProfilesForRole


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        void ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest request, AmazonServiceCallback<ListInstanceProfilesForRoleRequest, ListInstanceProfilesForRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListMFADevices


        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        void ListMFADevicesAsync(ListMFADevicesRequest request, AmazonServiceCallback<ListMFADevicesRequest, ListMFADevicesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListOpenIDConnectProviders


        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        void ListOpenIDConnectProvidersAsync(ListOpenIDConnectProvidersRequest request, AmazonServiceCallback<ListOpenIDConnectProvidersRequest, ListOpenIDConnectProvidersResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        void ListPoliciesAsync(ListPoliciesRequest request, AmazonServiceCallback<ListPoliciesRequest, ListPoliciesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListPolicyVersions


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        void ListPolicyVersionsAsync(ListPolicyVersionsRequest request, AmazonServiceCallback<ListPolicyVersionsRequest, ListPolicyVersionsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListRolePolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        void ListRolePoliciesAsync(ListRolePoliciesRequest request, AmazonServiceCallback<ListRolePoliciesRequest, ListRolePoliciesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListRoles


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        void ListRolesAsync(ListRolesRequest request, AmazonServiceCallback<ListRolesRequest, ListRolesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListSAMLProviders


        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        void ListSAMLProvidersAsync(ListSAMLProvidersRequest request, AmazonServiceCallback<ListSAMLProvidersRequest, ListSAMLProvidersResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListServerCertificates


        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        void ListServerCertificatesAsync(ListServerCertificatesRequest request, AmazonServiceCallback<ListServerCertificatesRequest, ListServerCertificatesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListServiceSpecificCredentials


        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceSpecificCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServiceSpecificCredentials">REST API Reference for ListServiceSpecificCredentials Operation</seealso>
        void ListServiceSpecificCredentialsAsync(ListServiceSpecificCredentialsRequest request, AmazonServiceCallback<ListServiceSpecificCredentialsRequest, ListServiceSpecificCredentialsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListSigningCertificates


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        void ListSigningCertificatesAsync(ListSigningCertificatesRequest request, AmazonServiceCallback<ListSigningCertificatesRequest, ListSigningCertificatesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListSSHPublicKeys


        /// <summary>
        /// Initiates the asynchronous execution of the ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        void ListSSHPublicKeysAsync(ListSSHPublicKeysRequest request, AmazonServiceCallback<ListSSHPublicKeysRequest, ListSSHPublicKeysResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListUserPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        void ListUserPoliciesAsync(ListUserPoliciesRequest request, AmazonServiceCallback<ListUserPoliciesRequest, ListUserPoliciesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        void ListUsersAsync(ListUsersRequest request, AmazonServiceCallback<ListUsersRequest, ListUsersResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListVirtualMFADevices


        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        void ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request, AmazonServiceCallback<ListVirtualMFADevicesRequest, ListVirtualMFADevicesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  PutGroupPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        void PutGroupPolicyAsync(PutGroupPolicyRequest request, AmazonServiceCallback<PutGroupPolicyRequest, PutGroupPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  PutRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        void PutRolePolicyAsync(PutRolePolicyRequest request, AmazonServiceCallback<PutRolePolicyRequest, PutRolePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  PutUserPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        void PutUserPolicyAsync(PutUserPolicyRequest request, AmazonServiceCallback<PutUserPolicyRequest, PutUserPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  RemoveClientIDFromOpenIDConnectProvider


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        void RemoveClientIDFromOpenIDConnectProviderAsync(RemoveClientIDFromOpenIDConnectProviderRequest request, AmazonServiceCallback<RemoveClientIDFromOpenIDConnectProviderRequest, RemoveClientIDFromOpenIDConnectProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  RemoveRoleFromInstanceProfile


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        void RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest request, AmazonServiceCallback<RemoveRoleFromInstanceProfileRequest, RemoveRoleFromInstanceProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  RemoveUserFromGroup


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        void RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request, AmazonServiceCallback<RemoveUserFromGroupRequest, RemoveUserFromGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ResetServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the ResetServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        void ResetServiceSpecificCredentialAsync(ResetServiceSpecificCredentialRequest request, AmazonServiceCallback<ResetServiceSpecificCredentialRequest, ResetServiceSpecificCredentialResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ResyncMFADevice


        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        void ResyncMFADeviceAsync(ResyncMFADeviceRequest request, AmazonServiceCallback<ResyncMFADeviceRequest, ResyncMFADeviceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SetDefaultPolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        void SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, AmazonServiceCallback<SetDefaultPolicyVersionRequest, SetDefaultPolicyVersionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SimulateCustomPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        void SimulateCustomPolicyAsync(SimulateCustomPolicyRequest request, AmazonServiceCallback<SimulateCustomPolicyRequest, SimulateCustomPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SimulatePrincipalPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        void SimulatePrincipalPolicyAsync(SimulatePrincipalPolicyRequest request, AmazonServiceCallback<SimulatePrincipalPolicyRequest, SimulatePrincipalPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateAccessKey


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        void UpdateAccessKeyAsync(UpdateAccessKeyRequest request, AmazonServiceCallback<UpdateAccessKeyRequest, UpdateAccessKeyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateAccountPasswordPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        void UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, AmazonServiceCallback<UpdateAccountPasswordPolicyRequest, UpdateAccountPasswordPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateAssumeRolePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        void UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest request, AmazonServiceCallback<UpdateAssumeRolePolicyRequest, UpdateAssumeRolePolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        void UpdateGroupAsync(UpdateGroupRequest request, AmazonServiceCallback<UpdateGroupRequest, UpdateGroupResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateLoginProfile


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        void UpdateLoginProfileAsync(UpdateLoginProfileRequest request, AmazonServiceCallback<UpdateLoginProfileRequest, UpdateLoginProfileResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateOpenIDConnectProviderThumbprint


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        void UpdateOpenIDConnectProviderThumbprintAsync(UpdateOpenIDConnectProviderThumbprintRequest request, AmazonServiceCallback<UpdateOpenIDConnectProviderThumbprintRequest, UpdateOpenIDConnectProviderThumbprintResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateRole


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        void UpdateRoleAsync(UpdateRoleRequest request, AmazonServiceCallback<UpdateRoleRequest, UpdateRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateRoleDescription


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoleDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        void UpdateRoleDescriptionAsync(UpdateRoleDescriptionRequest request, AmazonServiceCallback<UpdateRoleDescriptionRequest, UpdateRoleDescriptionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateSAMLProvider


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        void UpdateSAMLProviderAsync(UpdateSAMLProviderRequest request, AmazonServiceCallback<UpdateSAMLProviderRequest, UpdateSAMLProviderResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        void UpdateServerCertificateAsync(UpdateServerCertificateRequest request, AmazonServiceCallback<UpdateServerCertificateRequest, UpdateServerCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateServiceSpecificCredential


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        void UpdateServiceSpecificCredentialAsync(UpdateServiceSpecificCredentialRequest request, AmazonServiceCallback<UpdateServiceSpecificCredentialRequest, UpdateServiceSpecificCredentialResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        void UpdateSigningCertificateAsync(UpdateSigningCertificateRequest request, AmazonServiceCallback<UpdateSigningCertificateRequest, UpdateSigningCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        void UpdateSSHPublicKeyAsync(UpdateSSHPublicKeyRequest request, AmazonServiceCallback<UpdateSSHPublicKeyRequest, UpdateSSHPublicKeyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        void UpdateUserAsync(UpdateUserRequest request, AmazonServiceCallback<UpdateUserRequest, UpdateUserResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UploadServerCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        void UploadServerCertificateAsync(UploadServerCertificateRequest request, AmazonServiceCallback<UploadServerCertificateRequest, UploadServerCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UploadSigningCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        void UploadSigningCertificateAsync(UploadSigningCertificateRequest request, AmazonServiceCallback<UploadSigningCertificateRequest, UploadSigningCertificateResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UploadSSHPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        void UploadSSHPublicKeyAsync(UploadSSHPublicKeyRequest request, AmazonServiceCallback<UploadSSHPublicKeyRequest, UploadSSHPublicKeyResponse> callback, AsyncOptions options = null);


        #endregion
        
    }
}