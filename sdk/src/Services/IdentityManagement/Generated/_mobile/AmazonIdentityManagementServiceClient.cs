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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Implementation for accessing IdentityManagementService
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
    ///  <note>AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to IAM and AWS. For example, the SDKs
    /// take care of tasks such as cryptographically signing requests (see below), managing
    /// errors, and retrying requests automatically. For information about the AWS SDKs, including
    /// how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a> page. </note> 
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
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a>. This topic provides general information about the types
    /// of credentials used for accessing AWS. </li> <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html">IAM
    /// Best Practices</a>. This topic presents a list of suggestions for using the IAM service
    /// to help secure your AWS resources. </li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a>. This set of topics walk you through the process of signing a
    /// request using an access key ID and secret access key. </li> </ul>
    /// </summary>
    public partial class AmazonIdentityManagementServiceClient : AmazonServiceClient, IAmazonIdentityManagementService
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIdentityManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials and an
        /// AmazonIdentityManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, AmazonIdentityManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIdentityManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIdentityManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddClientIDToOpenIDConnectProvider

        internal AddClientIDToOpenIDConnectProviderResponse AddClientIDToOpenIDConnectProvider(AddClientIDToOpenIDConnectProviderRequest request)
        {
            var marshaller = new AddClientIDToOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<AddClientIDToOpenIDConnectProviderRequest,AddClientIDToOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddClientIDToOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddClientIDToOpenIDConnectProviderResponse> AddClientIDToOpenIDConnectProviderAsync(AddClientIDToOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddClientIDToOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<AddClientIDToOpenIDConnectProviderRequest,AddClientIDToOpenIDConnectProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddRoleToInstanceProfile

        internal AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request)
        {
            var marshaller = new AddRoleToInstanceProfileRequestMarshaller();
            var unmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AddRoleToInstanceProfileRequest,AddRoleToInstanceProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddRoleToInstanceProfileResponse> AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddRoleToInstanceProfileRequestMarshaller();
            var unmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AddRoleToInstanceProfileRequest,AddRoleToInstanceProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddUserToGroup

        internal AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request)
        {
            var marshaller = new AddUserToGroupRequestMarshaller();
            var unmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AddUserToGroupRequest,AddUserToGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddUserToGroupRequestMarshaller();
            var unmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AddUserToGroupRequest,AddUserToGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachGroupPolicy

        internal AttachGroupPolicyResponse AttachGroupPolicy(AttachGroupPolicyRequest request)
        {
            var marshaller = new AttachGroupPolicyRequestMarshaller();
            var unmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachGroupPolicyRequest,AttachGroupPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachGroupPolicyResponse> AttachGroupPolicyAsync(AttachGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachGroupPolicyRequestMarshaller();
            var unmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachGroupPolicyRequest,AttachGroupPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachRolePolicy

        internal AttachRolePolicyResponse AttachRolePolicy(AttachRolePolicyRequest request)
        {
            var marshaller = new AttachRolePolicyRequestMarshaller();
            var unmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<AttachRolePolicyRequest,AttachRolePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachRolePolicyResponse> AttachRolePolicyAsync(AttachRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachRolePolicyRequestMarshaller();
            var unmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachRolePolicyRequest,AttachRolePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachUserPolicy

        internal AttachUserPolicyResponse AttachUserPolicy(AttachUserPolicyRequest request)
        {
            var marshaller = new AttachUserPolicyRequestMarshaller();
            var unmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachUserPolicyRequest,AttachUserPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachUserPolicyResponse> AttachUserPolicyAsync(AttachUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachUserPolicyRequestMarshaller();
            var unmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachUserPolicyRequest,AttachUserPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangePassword

        internal ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var marshaller = new ChangePasswordRequestMarshaller();
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordRequest,ChangePasswordResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangePasswordRequestMarshaller();
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ChangePasswordRequest,ChangePasswordResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessKey

        internal CreateAccessKeyResponse CreateAccessKey()
        {
            return CreateAccessKey(new CreateAccessKeyRequest());
        }
        internal CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request)
        {
            var marshaller = new CreateAccessKeyRequestMarshaller();
            var unmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;

            return Invoke<CreateAccessKeyRequest,CreateAccessKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified
        /// user. The default status for new keys is <code>Active</code>. 
        /// 
        ///  
        /// <para>
        ///  If you do not specify a user name, IAM determines the user name implicitly based
        /// on the AWS access key ID signing the request. Because this action works for access
        /// keys under the AWS account, you can use this action to manage root credentials even
        /// if the AWS account has no associated users. 
        /// </para>
        ///  
        /// <para>
        ///  For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  <important> To ensure the security of your AWS account, the secret access key is
        /// accessible only during key and user creation. You must save the key (for example,
        /// in a text file) if you want to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the associated user and then create new keys. </important>
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
        public Task<CreateAccessKeyResponse> CreateAccessKeyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateAccessKeyAsync(new CreateAccessKeyRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAccessKeyRequestMarshaller();
            var unmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccessKeyRequest,CreateAccessKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAccountAlias

        internal CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request)
        {
            var marshaller = new CreateAccountAliasRequestMarshaller();
            var unmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAccountAliasRequest,CreateAccountAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAccountAliasResponse> CreateAccountAliasAsync(CreateAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAccountAliasRequestMarshaller();
            var unmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountAliasRequest,CreateAccountAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var marshaller = new CreateGroupRequestMarshaller();
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupRequest,CreateGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGroupRequestMarshaller();
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupRequest,CreateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceProfile

        internal CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var marshaller = new CreateInstanceProfileRequestMarshaller();
            var unmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileRequest,CreateInstanceProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceProfileRequestMarshaller();
            var unmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceProfileRequest,CreateInstanceProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoginProfile

        internal CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request)
        {
            var marshaller = new CreateLoginProfileRequestMarshaller();
            var unmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<CreateLoginProfileRequest,CreateLoginProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoginProfileRequestMarshaller();
            var unmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoginProfileRequest,CreateLoginProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateOpenIDConnectProvider

        internal CreateOpenIDConnectProviderResponse CreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request)
        {
            var marshaller = new CreateOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<CreateOpenIDConnectProviderRequest,CreateOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateOpenIDConnectProviderResponse> CreateOpenIDConnectProviderAsync(CreateOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOpenIDConnectProviderRequest,CreateOpenIDConnectProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicy

        internal CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var marshaller = new CreatePolicyRequestMarshaller();
            var unmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyRequest,CreatePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePolicyRequestMarshaller();
            var unmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyRequest,CreatePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicyVersion

        internal CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
        {
            var marshaller = new CreatePolicyVersionRequestMarshaller();
            var unmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyVersionRequest,CreatePolicyVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePolicyVersionRequestMarshaller();
            var unmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyVersionRequest,CreatePolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRole

        internal CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            var marshaller = new CreateRoleRequestMarshaller();
            var unmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return Invoke<CreateRoleRequest,CreateRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRoleRequestMarshaller();
            var unmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoleRequest,CreateRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSAMLProvider

        internal CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request)
        {
            var marshaller = new CreateSAMLProviderRequestMarshaller();
            var unmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<CreateSAMLProviderRequest,CreateSAMLProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateSAMLProviderResponse> CreateSAMLProviderAsync(CreateSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSAMLProviderRequestMarshaller();
            var unmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSAMLProviderRequest,CreateSAMLProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var marshaller = new CreateUserRequestMarshaller();
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserRequest,CreateUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateUserRequestMarshaller();
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserRequest,CreateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVirtualMFADevice

        internal CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request)
        {
            var marshaller = new CreateVirtualMFADeviceRequestMarshaller();
            var unmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualMFADeviceRequest,CreateVirtualMFADeviceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVirtualMFADeviceRequestMarshaller();
            var unmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVirtualMFADeviceRequest,CreateVirtualMFADeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeactivateMFADevice

        internal DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request)
        {
            var marshaller = new DeactivateMFADeviceRequestMarshaller();
            var unmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeactivateMFADeviceRequest,DeactivateMFADeviceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeactivateMFADeviceResponse> DeactivateMFADeviceAsync(DeactivateMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeactivateMFADeviceRequestMarshaller();
            var unmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateMFADeviceRequest,DeactivateMFADeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessKey

        internal DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request)
        {
            var marshaller = new DeleteAccessKeyRequestMarshaller();
            var unmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessKeyRequest,DeleteAccessKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAccessKeyRequestMarshaller();
            var unmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessKeyRequest,DeleteAccessKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountAlias

        internal DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request)
        {
            var marshaller = new DeleteAccountAliasRequestMarshaller();
            var unmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAliasRequest,DeleteAccountAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAccountAliasRequestMarshaller();
            var unmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountAliasRequest,DeleteAccountAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountPasswordPolicy

        internal DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy()
        {
            return DeleteAccountPasswordPolicy(new DeleteAccountPasswordPolicyRequest());
        }
        internal DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request)
        {
            var marshaller = new DeleteAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountPasswordPolicyRequest,DeleteAccountPasswordPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the password policy for the AWS account.
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
        public Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteAccountPasswordPolicyAsync(new DeleteAccountPasswordPolicyRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountPasswordPolicyRequest,DeleteAccountPasswordPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var marshaller = new DeleteGroupRequestMarshaller();
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteGroupRequestMarshaller();
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroupPolicy

        internal DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request)
        {
            var marshaller = new DeleteGroupPolicyRequestMarshaller();
            var unmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupPolicyRequest,DeleteGroupPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteGroupPolicyResponse> DeleteGroupPolicyAsync(DeleteGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteGroupPolicyRequestMarshaller();
            var unmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupPolicyRequest,DeleteGroupPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstanceProfile

        internal DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            var marshaller = new DeleteInstanceProfileRequestMarshaller();
            var unmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileRequest,DeleteInstanceProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInstanceProfileRequestMarshaller();
            var unmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceProfileRequest,DeleteInstanceProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoginProfile

        internal DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request)
        {
            var marshaller = new DeleteLoginProfileRequestMarshaller();
            var unmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteLoginProfileRequest,DeleteLoginProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoginProfileRequestMarshaller();
            var unmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoginProfileRequest,DeleteLoginProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteOpenIDConnectProvider

        internal DeleteOpenIDConnectProviderResponse DeleteOpenIDConnectProvider(DeleteOpenIDConnectProviderRequest request)
        {
            var marshaller = new DeleteOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteOpenIDConnectProviderRequest,DeleteOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteOpenIDConnectProviderResponse> DeleteOpenIDConnectProviderAsync(DeleteOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOpenIDConnectProviderRequest,DeleteOpenIDConnectProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicyVersion

        internal DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
        {
            var marshaller = new DeletePolicyVersionRequestMarshaller();
            var unmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyVersionRequest,DeletePolicyVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePolicyVersionRequestMarshaller();
            var unmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyVersionRequest,DeletePolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRole

        internal DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            var marshaller = new DeleteRoleRequestMarshaller();
            var unmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleRequest,DeleteRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRoleRequestMarshaller();
            var unmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoleRequest,DeleteRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRolePolicy

        internal DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request)
        {
            var marshaller = new DeleteRolePolicyRequestMarshaller();
            var unmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRolePolicyRequest,DeleteRolePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRolePolicyResponse> DeleteRolePolicyAsync(DeleteRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRolePolicyRequestMarshaller();
            var unmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRolePolicyRequest,DeleteRolePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSAMLProvider

        internal DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request)
        {
            var marshaller = new DeleteSAMLProviderRequestMarshaller();
            var unmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteSAMLProviderRequest,DeleteSAMLProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSAMLProviderResponse> DeleteSAMLProviderAsync(DeleteSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSAMLProviderRequestMarshaller();
            var unmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSAMLProviderRequest,DeleteSAMLProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteServerCertificate

        internal DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            var marshaller = new DeleteServerCertificateRequestMarshaller();
            var unmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteServerCertificateRequest,DeleteServerCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteServerCertificateRequestMarshaller();
            var unmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerCertificateRequest,DeleteServerCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSigningCertificate

        internal DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request)
        {
            var marshaller = new DeleteSigningCertificateRequestMarshaller();
            var unmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteSigningCertificateRequest,DeleteSigningCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSigningCertificateResponse> DeleteSigningCertificateAsync(DeleteSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSigningCertificateRequestMarshaller();
            var unmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSigningCertificateRequest,DeleteSigningCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSSHPublicKey

        internal DeleteSSHPublicKeyResponse DeleteSSHPublicKey(DeleteSSHPublicKeyRequest request)
        {
            var marshaller = new DeleteSSHPublicKeyRequestMarshaller();
            var unmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteSSHPublicKeyRequest,DeleteSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSSHPublicKeyResponse> DeleteSSHPublicKeyAsync(DeleteSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSSHPublicKeyRequestMarshaller();
            var unmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSSHPublicKeyRequest,DeleteSSHPublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserRequest,DeleteUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserPolicy

        internal DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request)
        {
            var marshaller = new DeleteUserPolicyRequestMarshaller();
            var unmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPolicyRequest,DeleteUserPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteUserPolicyResponse> DeleteUserPolicyAsync(DeleteUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteUserPolicyRequestMarshaller();
            var unmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserPolicyRequest,DeleteUserPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualMFADevice

        internal DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            var marshaller = new DeleteVirtualMFADeviceRequestMarshaller();
            var unmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualMFADeviceRequest,DeleteVirtualMFADeviceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVirtualMFADeviceRequestMarshaller();
            var unmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVirtualMFADeviceRequest,DeleteVirtualMFADeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachGroupPolicy

        internal DetachGroupPolicyResponse DetachGroupPolicy(DetachGroupPolicyRequest request)
        {
            var marshaller = new DetachGroupPolicyRequestMarshaller();
            var unmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachGroupPolicyRequest,DetachGroupPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachGroupPolicyResponse> DetachGroupPolicyAsync(DetachGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachGroupPolicyRequestMarshaller();
            var unmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachGroupPolicyRequest,DetachGroupPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachRolePolicy

        internal DetachRolePolicyResponse DetachRolePolicy(DetachRolePolicyRequest request)
        {
            var marshaller = new DetachRolePolicyRequestMarshaller();
            var unmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DetachRolePolicyRequest,DetachRolePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachRolePolicyResponse> DetachRolePolicyAsync(DetachRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachRolePolicyRequestMarshaller();
            var unmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachRolePolicyRequest,DetachRolePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachUserPolicy

        internal DetachUserPolicyResponse DetachUserPolicy(DetachUserPolicyRequest request)
        {
            var marshaller = new DetachUserPolicyRequestMarshaller();
            var unmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachUserPolicyRequest,DetachUserPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachUserPolicyResponse> DetachUserPolicyAsync(DetachUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachUserPolicyRequestMarshaller();
            var unmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachUserPolicyRequest,DetachUserPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableMFADevice

        internal EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request)
        {
            var marshaller = new EnableMFADeviceRequestMarshaller();
            var unmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return Invoke<EnableMFADeviceRequest,EnableMFADeviceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableMFADeviceResponse> EnableMFADeviceAsync(EnableMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableMFADeviceRequestMarshaller();
            var unmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<EnableMFADeviceRequest,EnableMFADeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateCredentialReport

        internal GenerateCredentialReportResponse GenerateCredentialReport()
        {
            return GenerateCredentialReport(new GenerateCredentialReportRequest());
        }
        internal GenerateCredentialReportResponse GenerateCredentialReport(GenerateCredentialReportRequest request)
        {
            var marshaller = new GenerateCredentialReportRequestMarshaller();
            var unmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GenerateCredentialReportRequest,GenerateCredentialReportResponse>(request, marshaller, unmarshaller);
        }


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
        public Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GenerateCredentialReportAsync(new GenerateCredentialReportRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(GenerateCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateCredentialReportRequestMarshaller();
            var unmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateCredentialReportRequest,GenerateCredentialReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccessKeyLastUsed

        internal GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request)
        {
            var marshaller = new GetAccessKeyLastUsedRequestMarshaller();
            var unmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;

            return Invoke<GetAccessKeyLastUsedRequest,GetAccessKeyLastUsedResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAccessKeyLastUsedRequestMarshaller();
            var unmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessKeyLastUsedRequest,GetAccessKeyLastUsedResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccountAuthorizationDetails

        internal GetAccountAuthorizationDetailsResponse GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request)
        {
            var marshaller = new GetAccountAuthorizationDetailsRequestMarshaller();
            var unmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetAccountAuthorizationDetailsRequest,GetAccountAuthorizationDetailsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAccountAuthorizationDetailsResponse> GetAccountAuthorizationDetailsAsync(GetAccountAuthorizationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAccountAuthorizationDetailsRequestMarshaller();
            var unmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountAuthorizationDetailsRequest,GetAccountAuthorizationDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccountPasswordPolicy

        internal GetAccountPasswordPolicyResponse GetAccountPasswordPolicy()
        {
            return GetAccountPasswordPolicy(new GetAccountPasswordPolicyRequest());
        }
        internal GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request)
        {
            var marshaller = new GetAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAccountPasswordPolicyRequest,GetAccountPasswordPolicyResponse>(request, marshaller, unmarshaller);
        }


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
        public Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetAccountPasswordPolicyAsync(new GetAccountPasswordPolicyRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountPasswordPolicyRequest,GetAccountPasswordPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSummary

        internal GetAccountSummaryResponse GetAccountSummary()
        {
            return GetAccountSummary(new GetAccountSummaryRequest());
        }
        internal GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request)
        {
            var marshaller = new GetAccountSummaryRequestMarshaller();
            var unmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;

            return Invoke<GetAccountSummaryRequest,GetAccountSummaryResponse>(request, marshaller, unmarshaller);
        }


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
        public Task<GetAccountSummaryResponse> GetAccountSummaryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetAccountSummaryAsync(new GetAccountSummaryRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAccountSummaryResponse> GetAccountSummaryAsync(GetAccountSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAccountSummaryRequestMarshaller();
            var unmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSummaryRequest,GetAccountSummaryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetContextKeysForCustomPolicy

        internal GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(GetContextKeysForCustomPolicyRequest request)
        {
            var marshaller = new GetContextKeysForCustomPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContextKeysForCustomPolicyRequest,GetContextKeysForCustomPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in the input policies. The policies are supplied as a list of one or more strings.
        /// To get the context keys from policies associated with an IAM user, group, or role,
        /// use <a>GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForCustomPolicy to understand what key
        /// names and values you must supply when you call <a>SimulateCustomPolicy</a>. Note that
        /// all parameters are shown in unencoded form here for clarity, but must be URL encoded
        /// to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="policyInputList">A list of policies for which you want list of context keys used in <code>Condition</code> elements.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        public Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetContextKeysForCustomPolicyRequest();
            request.PolicyInputList = policyInputList;
            return GetContextKeysForCustomPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(GetContextKeysForCustomPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetContextKeysForCustomPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContextKeysForCustomPolicyRequest,GetContextKeysForCustomPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetContextKeysForPrincipalPolicy

        internal GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(GetContextKeysForPrincipalPolicyRequest request)
        {
            var marshaller = new GetContextKeysForPrincipalPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContextKeysForPrincipalPolicyRequest,GetContextKeysForPrincipalPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in all of the IAM policies attached to the specified IAM entity. The entity can be
        /// an IAM user, group, or role. If you specify a user, then the request also includes
        /// all of the policies attached to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include only a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForPrincipalPolicy to understand what
        /// key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies attached to the user as well as to all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request.</param>
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
        public Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            return GetContextKeysForPrincipalPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in all of the IAM policies attached to the specified IAM entity. The entity can be
        /// an IAM user, group, or role. If you specify a user, then the request also includes
        /// all of the policies attached to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include only a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForPrincipalPolicy to understand what
        /// key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies attached to the user as well as to all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request.</param>
        /// <param name="policyInputList">A optional list of additional policies for which you want list of context keys used in <code>Condition</code> elements.</param>
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
        public Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            request.PolicyInputList = policyInputList;
            return GetContextKeysForPrincipalPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(GetContextKeysForPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetContextKeysForPrincipalPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContextKeysForPrincipalPolicyRequest,GetContextKeysForPrincipalPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCredentialReport

        internal GetCredentialReportResponse GetCredentialReport()
        {
            return GetCredentialReport(new GetCredentialReportRequest());
        }
        internal GetCredentialReportResponse GetCredentialReport(GetCredentialReportRequest request)
        {
            var marshaller = new GetCredentialReportRequestMarshaller();
            var unmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GetCredentialReportRequest,GetCredentialReportResponse>(request, marshaller, unmarshaller);
        }


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
        public Task<GetCredentialReportResponse> GetCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetCredentialReportAsync(new GetCredentialReportRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetCredentialReportResponse> GetCredentialReportAsync(GetCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCredentialReportRequestMarshaller();
            var unmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetCredentialReportRequest,GetCredentialReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var marshaller = new GetGroupRequestMarshaller();
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupRequest,GetGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGroupRequestMarshaller();
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupRequest,GetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroupPolicy

        internal GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request)
        {
            var marshaller = new GetGroupPolicyRequestMarshaller();
            var unmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetGroupPolicyRequest,GetGroupPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetGroupPolicyResponse> GetGroupPolicyAsync(GetGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGroupPolicyRequestMarshaller();
            var unmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupPolicyRequest,GetGroupPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceProfile

        internal GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request)
        {
            var marshaller = new GetInstanceProfileRequestMarshaller();
            var unmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInstanceProfileRequest,GetInstanceProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetInstanceProfileResponse> GetInstanceProfileAsync(GetInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetInstanceProfileRequestMarshaller();
            var unmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceProfileRequest,GetInstanceProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLoginProfile

        internal GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request)
        {
            var marshaller = new GetLoginProfileRequestMarshaller();
            var unmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return Invoke<GetLoginProfileRequest,GetLoginProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetLoginProfileRequestMarshaller();
            var unmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoginProfileRequest,GetLoginProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetOpenIDConnectProvider

        internal GetOpenIDConnectProviderResponse GetOpenIDConnectProvider(GetOpenIDConnectProviderRequest request)
        {
            var marshaller = new GetOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<GetOpenIDConnectProviderRequest,GetOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetOpenIDConnectProviderResponse> GetOpenIDConnectProviderAsync(GetOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpenIDConnectProviderRequest,GetOpenIDConnectProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy

        internal GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var marshaller = new GetPolicyRequestMarshaller();
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyRequest,GetPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPolicyRequestMarshaller();
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyRequest,GetPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPolicyVersion

        internal GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            var marshaller = new GetPolicyVersionRequestMarshaller();
            var unmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<GetPolicyVersionRequest,GetPolicyVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPolicyVersionRequestMarshaller();
            var unmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyVersionRequest,GetPolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRole

        internal GetRoleResponse GetRole(GetRoleRequest request)
        {
            var marshaller = new GetRoleRequestMarshaller();
            var unmarshaller = GetRoleResponseUnmarshaller.Instance;

            return Invoke<GetRoleRequest,GetRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRoleRequestMarshaller();
            var unmarshaller = GetRoleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoleRequest,GetRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRolePolicy

        internal GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request)
        {
            var marshaller = new GetRolePolicyRequestMarshaller();
            var unmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return Invoke<GetRolePolicyRequest,GetRolePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetRolePolicyResponse> GetRolePolicyAsync(GetRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRolePolicyRequestMarshaller();
            var unmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetRolePolicyRequest,GetRolePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSAMLProvider

        internal GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request)
        {
            var marshaller = new GetSAMLProviderRequestMarshaller();
            var unmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<GetSAMLProviderRequest,GetSAMLProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetSAMLProviderResponse> GetSAMLProviderAsync(GetSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSAMLProviderRequestMarshaller();
            var unmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<GetSAMLProviderRequest,GetSAMLProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetServerCertificate

        internal GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request)
        {
            var marshaller = new GetServerCertificateRequestMarshaller();
            var unmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return Invoke<GetServerCertificateRequest,GetServerCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetServerCertificateResponse> GetServerCertificateAsync(GetServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetServerCertificateRequestMarshaller();
            var unmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetServerCertificateRequest,GetServerCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSSHPublicKey

        internal GetSSHPublicKeyResponse GetSSHPublicKey(GetSSHPublicKeyRequest request)
        {
            var marshaller = new GetSSHPublicKeyRequestMarshaller();
            var unmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetSSHPublicKeyRequest,GetSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetSSHPublicKeyResponse> GetSSHPublicKeyAsync(GetSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSSHPublicKeyRequestMarshaller();
            var unmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetSSHPublicKeyRequest,GetSSHPublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUser

        internal GetUserResponse GetUser()
        {
            return GetUser(new GetUserRequest());
        }
        internal GetUserResponse GetUser(GetUserRequest request)
        {
            var marshaller = new GetUserRequestMarshaller();
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserRequest,GetUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves information about the specified user, including the user's creation date,
        /// path, unique ID, and ARN. 
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID used to sign the request. 
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
        public Task<GetUserResponse> GetUserAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetUserAsync(new GetUserRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetUserRequestMarshaller();
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserRequest,GetUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUserPolicy

        internal GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request)
        {
            var marshaller = new GetUserPolicyRequestMarshaller();
            var unmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return Invoke<GetUserPolicyRequest,GetUserPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetUserPolicyResponse> GetUserPolicyAsync(GetUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetUserPolicyRequestMarshaller();
            var unmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserPolicyRequest,GetUserPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAccessKeys

        internal ListAccessKeysResponse ListAccessKeys()
        {
            return ListAccessKeys(new ListAccessKeysRequest());
        }
        internal ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request)
        {
            var marshaller = new ListAccessKeysRequestMarshaller();
            var unmarshaller = ListAccessKeysResponseUnmarshaller.Instance;

            return Invoke<ListAccessKeysRequest,ListAccessKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about the access key IDs associated with the specified user. If
        /// there are none, the action returns an empty list. 
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters. 
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        ///  <note>To ensure the security of your AWS account, the secret access key is accessible
        /// only during key and user creation. </note>
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
        public Task<ListAccessKeysResponse> ListAccessKeysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListAccessKeysAsync(new ListAccessKeysRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAccessKeysRequestMarshaller();
            var unmarshaller = ListAccessKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessKeysRequest,ListAccessKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAccountAliases

        internal ListAccountAliasesResponse ListAccountAliases()
        {
            return ListAccountAliases(new ListAccountAliasesRequest());
        }
        internal ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request)
        {
            var marshaller = new ListAccountAliasesRequestMarshaller();
            var unmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAccountAliasesRequest,ListAccountAliasesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the account aliases associated with the account. For information about using
        /// an AWS account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>. 
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
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public Task<ListAccountAliasesResponse> ListAccountAliasesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListAccountAliasesAsync(new ListAccountAliasesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAccountAliasesResponse> ListAccountAliasesAsync(ListAccountAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAccountAliasesRequestMarshaller();
            var unmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountAliasesRequest,ListAccountAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedGroupPolicies

        internal ListAttachedGroupPoliciesResponse ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request)
        {
            var marshaller = new ListAttachedGroupPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedGroupPoliciesRequest,ListAttachedGroupPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAttachedGroupPoliciesResponse> ListAttachedGroupPoliciesAsync(ListAttachedGroupPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAttachedGroupPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedGroupPoliciesRequest,ListAttachedGroupPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedRolePolicies

        internal ListAttachedRolePoliciesResponse ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request)
        {
            var marshaller = new ListAttachedRolePoliciesRequestMarshaller();
            var unmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedRolePoliciesRequest,ListAttachedRolePoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAttachedRolePoliciesResponse> ListAttachedRolePoliciesAsync(ListAttachedRolePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAttachedRolePoliciesRequestMarshaller();
            var unmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedRolePoliciesRequest,ListAttachedRolePoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedUserPolicies

        internal ListAttachedUserPoliciesResponse ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request)
        {
            var marshaller = new ListAttachedUserPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedUserPoliciesRequest,ListAttachedUserPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAttachedUserPoliciesResponse> ListAttachedUserPoliciesAsync(ListAttachedUserPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAttachedUserPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedUserPoliciesRequest,ListAttachedUserPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEntitiesForPolicy

        internal ListEntitiesForPolicyResponse ListEntitiesForPolicy(ListEntitiesForPolicyRequest request)
        {
            var marshaller = new ListEntitiesForPolicyRequestMarshaller();
            var unmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesForPolicyRequest,ListEntitiesForPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEntitiesForPolicyRequestMarshaller();
            var unmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitiesForPolicyRequest,ListEntitiesForPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroupPolicies

        internal ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request)
        {
            var marshaller = new ListGroupPoliciesRequestMarshaller();
            var unmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListGroupPoliciesRequest,ListGroupPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListGroupPoliciesResponse> ListGroupPoliciesAsync(ListGroupPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGroupPoliciesRequestMarshaller();
            var unmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupPoliciesRequest,ListGroupPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal ListGroupsResponse ListGroups()
        {
            return ListGroups(new ListGroupsRequest());
        }
        internal ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var marshaller = new ListGroupsRequestMarshaller();
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsRequest,ListGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the groups that have the specified path prefix.
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
        public Task<ListGroupsResponse> ListGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListGroupsAsync(new ListGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGroupsRequestMarshaller();
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsRequest,ListGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGroupsForUser

        internal ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            var marshaller = new ListGroupsForUserRequestMarshaller();
            var unmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<ListGroupsForUserRequest,ListGroupsForUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGroupsForUserRequestMarshaller();
            var unmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsForUserRequest,ListGroupsForUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceProfiles

        internal ListInstanceProfilesResponse ListInstanceProfiles()
        {
            return ListInstanceProfiles(new ListInstanceProfilesRequest());
        }
        internal ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request)
        {
            var marshaller = new ListInstanceProfilesRequestMarshaller();
            var unmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesRequest,ListInstanceProfilesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the action returns an empty list. For more information about instance profiles, go
        /// to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
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
        public Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListInstanceProfilesAsync(new ListInstanceProfilesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(ListInstanceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInstanceProfilesRequestMarshaller();
            var unmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceProfilesRequest,ListInstanceProfilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceProfilesForRole

        internal ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request)
        {
            var marshaller = new ListInstanceProfilesForRoleRequestMarshaller();
            var unmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesForRoleRequest,ListInstanceProfilesForRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListInstanceProfilesForRoleResponse> ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListInstanceProfilesForRoleRequestMarshaller();
            var unmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceProfilesForRoleRequest,ListInstanceProfilesForRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMFADevices

        internal ListMFADevicesResponse ListMFADevices()
        {
            return ListMFADevices(new ListMFADevicesRequest());
        }
        internal ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request)
        {
            var marshaller = new ListMFADevicesRequestMarshaller();
            var unmarshaller = ListMFADevicesResponseUnmarshaller.Instance;

            return Invoke<ListMFADevicesRequest,ListMFADevicesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the MFA devices. If the request includes the user name, then this action lists
        /// all the MFA devices associated with the specified user name. If you do not specify
        /// a user name, IAM determines the user name implicitly based on the AWS access key ID
        /// signing the request. 
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
        public Task<ListMFADevicesResponse> ListMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListMFADevicesAsync(new ListMFADevicesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListMFADevicesResponse> ListMFADevicesAsync(ListMFADevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMFADevicesRequestMarshaller();
            var unmarshaller = ListMFADevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMFADevicesRequest,ListMFADevicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOpenIDConnectProviders

        internal ListOpenIDConnectProvidersResponse ListOpenIDConnectProviders(ListOpenIDConnectProvidersRequest request)
        {
            var marshaller = new ListOpenIDConnectProvidersRequestMarshaller();
            var unmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;

            return Invoke<ListOpenIDConnectProvidersRequest,ListOpenIDConnectProvidersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListOpenIDConnectProvidersResponse> ListOpenIDConnectProvidersAsync(ListOpenIDConnectProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListOpenIDConnectProvidersRequestMarshaller();
            var unmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListOpenIDConnectProvidersRequest,ListOpenIDConnectProvidersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies

        internal ListPoliciesResponse ListPolicies()
        {
            return ListPolicies(new ListPoliciesRequest());
        }
        internal ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var marshaller = new ListPoliciesRequestMarshaller();
            var unmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesRequest,ListPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists all the managed policies that are available to your account, including your
        /// own customer managed policies and all AWS managed policies. 
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
        /// For more information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        public Task<ListPoliciesResponse> ListPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListPoliciesAsync(new ListPoliciesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPoliciesRequestMarshaller();
            var unmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesRequest,ListPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyVersions

        internal ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            var marshaller = new ListPolicyVersionsRequestMarshaller();
            var unmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyVersionsRequest,ListPolicyVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPolicyVersionsRequestMarshaller();
            var unmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyVersionsRequest,ListPolicyVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRolePolicies

        internal ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request)
        {
            var marshaller = new ListRolePoliciesRequestMarshaller();
            var unmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListRolePoliciesRequest,ListRolePoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListRolePoliciesResponse> ListRolePoliciesAsync(ListRolePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRolePoliciesRequestMarshaller();
            var unmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRolePoliciesRequest,ListRolePoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRoles

        internal ListRolesResponse ListRoles()
        {
            return ListRoles(new ListRolesRequest());
        }
        internal ListRolesResponse ListRoles(ListRolesRequest request)
        {
            var marshaller = new ListRolesRequestMarshaller();
            var unmarshaller = ListRolesResponseUnmarshaller.Instance;

            return Invoke<ListRolesRequest,ListRolesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the roles that have the specified path prefix. If there are none, the action
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
        public Task<ListRolesResponse> ListRolesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListRolesAsync(new ListRolesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRolesRequestMarshaller();
            var unmarshaller = ListRolesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRolesRequest,ListRolesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSAMLProviders

        internal ListSAMLProvidersResponse ListSAMLProviders()
        {
            return ListSAMLProviders(new ListSAMLProvidersRequest());
        }
        internal ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request)
        {
            var marshaller = new ListSAMLProvidersRequestMarshaller();
            var unmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;

            return Invoke<ListSAMLProvidersRequest,ListSAMLProvidersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the SAML providers in the account.
        /// 
        ///  <note> This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>. </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListSAMLProvidersAsync(new ListSAMLProvidersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(ListSAMLProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSAMLProvidersRequestMarshaller();
            var unmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListSAMLProvidersRequest,ListSAMLProvidersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListServerCertificates

        internal ListServerCertificatesResponse ListServerCertificates()
        {
            return ListServerCertificates(new ListServerCertificatesRequest());
        }
        internal ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request)
        {
            var marshaller = new ListServerCertificatesRequestMarshaller();
            var unmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListServerCertificatesRequest,ListServerCertificatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the server certificates that have the specified path prefix. If none exist,
        /// the action returns an empty list. 
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
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public Task<ListServerCertificatesResponse> ListServerCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListServerCertificatesAsync(new ListServerCertificatesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListServerCertificatesResponse> ListServerCertificatesAsync(ListServerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListServerCertificatesRequestMarshaller();
            var unmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServerCertificatesRequest,ListServerCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSigningCertificates

        internal ListSigningCertificatesResponse ListSigningCertificates()
        {
            return ListSigningCertificates(new ListSigningCertificatesRequest());
        }
        internal ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request)
        {
            var marshaller = new ListSigningCertificatesRequestMarshaller();
            var unmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListSigningCertificatesRequest,ListSigningCertificatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about the signing certificates associated with the specified user.
        /// If there are none, the action returns an empty list. 
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
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
        public Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListSigningCertificatesAsync(new ListSigningCertificatesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(ListSigningCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSigningCertificatesRequestMarshaller();
            var unmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSigningCertificatesRequest,ListSigningCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSSHPublicKeys

        internal ListSSHPublicKeysResponse ListSSHPublicKeys(ListSSHPublicKeysRequest request)
        {
            var marshaller = new ListSSHPublicKeysRequestMarshaller();
            var unmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListSSHPublicKeysRequest,ListSSHPublicKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListSSHPublicKeysResponse> ListSSHPublicKeysAsync(ListSSHPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSSHPublicKeysRequestMarshaller();
            var unmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListSSHPublicKeysRequest,ListSSHPublicKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUserPolicies

        internal ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request)
        {
            var marshaller = new ListUserPoliciesRequestMarshaller();
            var unmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListUserPoliciesRequest,ListUserPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListUserPoliciesResponse> ListUserPoliciesAsync(ListUserPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListUserPoliciesRequestMarshaller();
            var unmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserPoliciesRequest,ListUserPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal ListUsersResponse ListUsers()
        {
            return ListUsers(new ListUsersRequest());
        }
        internal ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var marshaller = new ListUsersRequestMarshaller();
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the action returns all users in the AWS account. If there are none, the action returns
        /// an empty list. 
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
        public Task<ListUsersResponse> ListUsersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListUsersAsync(new ListUsersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListUsersRequestMarshaller();
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersRequest,ListUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVirtualMFADevices

        internal ListVirtualMFADevicesResponse ListVirtualMFADevices()
        {
            return ListVirtualMFADevices(new ListVirtualMFADevicesRequest());
        }
        internal ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request)
        {
            var marshaller = new ListVirtualMFADevicesRequestMarshaller();
            var unmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;

            return Invoke<ListVirtualMFADevicesRequest,ListVirtualMFADevicesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the virtual MFA devices under the AWS account by assignment status. If you do
        /// not specify an assignment status, the action returns a list of all virtual MFA devices.
        /// Assignment status can be <code>Assigned</code>, <code>Unassigned</code>, or <code>Any</code>.
        /// 
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
        public Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListVirtualMFADevicesAsync(new ListVirtualMFADevicesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVirtualMFADevicesRequestMarshaller();
            var unmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVirtualMFADevicesRequest,ListVirtualMFADevicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutGroupPolicy

        internal PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request)
        {
            var marshaller = new PutGroupPolicyRequestMarshaller();
            var unmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutGroupPolicyRequest,PutGroupPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutGroupPolicyResponse> PutGroupPolicyAsync(PutGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutGroupPolicyRequestMarshaller();
            var unmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutGroupPolicyRequest,PutGroupPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutRolePolicy

        internal PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request)
        {
            var marshaller = new PutRolePolicyRequestMarshaller();
            var unmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return Invoke<PutRolePolicyRequest,PutRolePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutRolePolicyResponse> PutRolePolicyAsync(PutRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutRolePolicyRequestMarshaller();
            var unmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutRolePolicyRequest,PutRolePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutUserPolicy

        internal PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request)
        {
            var marshaller = new PutUserPolicyRequestMarshaller();
            var unmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return Invoke<PutUserPolicyRequest,PutUserPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutUserPolicyResponse> PutUserPolicyAsync(PutUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutUserPolicyRequestMarshaller();
            var unmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutUserPolicyRequest,PutUserPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveClientIDFromOpenIDConnectProvider

        internal RemoveClientIDFromOpenIDConnectProviderResponse RemoveClientIDFromOpenIDConnectProvider(RemoveClientIDFromOpenIDConnectProviderRequest request)
        {
            var marshaller = new RemoveClientIDFromOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<RemoveClientIDFromOpenIDConnectProviderRequest,RemoveClientIDFromOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveClientIDFromOpenIDConnectProviderResponse> RemoveClientIDFromOpenIDConnectProviderAsync(RemoveClientIDFromOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveClientIDFromOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveClientIDFromOpenIDConnectProviderRequest,RemoveClientIDFromOpenIDConnectProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveRoleFromInstanceProfile

        internal RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request)
        {
            var marshaller = new RemoveRoleFromInstanceProfileRequestMarshaller();
            var unmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromInstanceProfileRequest,RemoveRoleFromInstanceProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveRoleFromInstanceProfileResponse> RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveRoleFromInstanceProfileRequestMarshaller();
            var unmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveRoleFromInstanceProfileRequest,RemoveRoleFromInstanceProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveUserFromGroup

        internal RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            var marshaller = new RemoveUserFromGroupRequestMarshaller();
            var unmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveUserFromGroupRequest,RemoveUserFromGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveUserFromGroupRequestMarshaller();
            var unmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveUserFromGroupRequest,RemoveUserFromGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResyncMFADevice

        internal ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request)
        {
            var marshaller = new ResyncMFADeviceRequestMarshaller();
            var unmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return Invoke<ResyncMFADeviceRequest,ResyncMFADeviceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResyncMFADeviceResponse> ResyncMFADeviceAsync(ResyncMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResyncMFADeviceRequestMarshaller();
            var unmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<ResyncMFADeviceRequest,ResyncMFADeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetDefaultPolicyVersion

        internal SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
        {
            var marshaller = new SetDefaultPolicyVersionRequestMarshaller();
            var unmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<SetDefaultPolicyVersionRequest,SetDefaultPolicyVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetDefaultPolicyVersionRequestMarshaller();
            var unmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultPolicyVersionRequest,SetDefaultPolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SimulateCustomPolicy

        internal SimulateCustomPolicyResponse SimulateCustomPolicy(SimulateCustomPolicyRequest request)
        {
            var marshaller = new SimulateCustomPolicyRequestMarshaller();
            var unmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulateCustomPolicyRequest,SimulateCustomPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SimulateCustomPolicyResponse> SimulateCustomPolicyAsync(SimulateCustomPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SimulateCustomPolicyRequestMarshaller();
            var unmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SimulateCustomPolicyRequest,SimulateCustomPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SimulatePrincipalPolicy

        internal SimulatePrincipalPolicyResponse SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request)
        {
            var marshaller = new SimulatePrincipalPolicyRequestMarshaller();
            var unmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulatePrincipalPolicyRequest,SimulatePrincipalPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SimulatePrincipalPolicyResponse> SimulatePrincipalPolicyAsync(SimulatePrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SimulatePrincipalPolicyRequestMarshaller();
            var unmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SimulatePrincipalPolicyRequest,SimulatePrincipalPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccessKey

        internal UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request)
        {
            var marshaller = new UpdateAccessKeyRequestMarshaller();
            var unmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessKeyRequest,UpdateAccessKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAccessKeyRequestMarshaller();
            var unmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccessKeyRequest,UpdateAccessKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountPasswordPolicy

        internal UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy()
        {
            return UpdateAccountPasswordPolicy(new UpdateAccountPasswordPolicyRequest());
        }
        internal UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request)
        {
            var marshaller = new UpdateAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountPasswordPolicyRequest,UpdateAccountPasswordPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates the password policy settings for the AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action does not support partial updates. No parameters are required, but if you
        /// do not specify a parameter, that parameter's value reverts to its default value. See
        /// the <b>Request Parameters</b> section for each parameter's default value. 
        /// </para>
        ///  </note> 
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
        public Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return UpdateAccountPasswordPolicyAsync(new UpdateAccountPasswordPolicyRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountPasswordPolicyRequest,UpdateAccountPasswordPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssumeRolePolicy

        internal UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request)
        {
            var marshaller = new UpdateAssumeRolePolicyRequestMarshaller();
            var unmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAssumeRolePolicyRequest,UpdateAssumeRolePolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAssumeRolePolicyRequestMarshaller();
            var unmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssumeRolePolicyRequest,UpdateAssumeRolePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var marshaller = new UpdateGroupRequestMarshaller();
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateGroupRequestMarshaller();
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLoginProfile

        internal UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request)
        {
            var marshaller = new UpdateLoginProfileRequestMarshaller();
            var unmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateLoginProfileRequest,UpdateLoginProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateLoginProfileRequestMarshaller();
            var unmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoginProfileRequest,UpdateLoginProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateOpenIDConnectProviderThumbprint

        internal UpdateOpenIDConnectProviderThumbprintResponse UpdateOpenIDConnectProviderThumbprint(UpdateOpenIDConnectProviderThumbprintRequest request)
        {
            var marshaller = new UpdateOpenIDConnectProviderThumbprintRequestMarshaller();
            var unmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;

            return Invoke<UpdateOpenIDConnectProviderThumbprintRequest,UpdateOpenIDConnectProviderThumbprintResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateOpenIDConnectProviderThumbprintResponse> UpdateOpenIDConnectProviderThumbprintAsync(UpdateOpenIDConnectProviderThumbprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateOpenIDConnectProviderThumbprintRequestMarshaller();
            var unmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOpenIDConnectProviderThumbprintRequest,UpdateOpenIDConnectProviderThumbprintResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSAMLProvider

        internal UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request)
        {
            var marshaller = new UpdateSAMLProviderRequestMarshaller();
            var unmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateSAMLProviderRequest,UpdateSAMLProviderResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateSAMLProviderResponse> UpdateSAMLProviderAsync(UpdateSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSAMLProviderRequestMarshaller();
            var unmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSAMLProviderRequest,UpdateSAMLProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateServerCertificate

        internal UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request)
        {
            var marshaller = new UpdateServerCertificateRequestMarshaller();
            var unmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateServerCertificateRequest,UpdateServerCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateServerCertificateResponse> UpdateServerCertificateAsync(UpdateServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServerCertificateRequestMarshaller();
            var unmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerCertificateRequest,UpdateServerCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSigningCertificate

        internal UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request)
        {
            var marshaller = new UpdateSigningCertificateRequestMarshaller();
            var unmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateSigningCertificateRequest,UpdateSigningCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateSigningCertificateResponse> UpdateSigningCertificateAsync(UpdateSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSigningCertificateRequestMarshaller();
            var unmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSigningCertificateRequest,UpdateSigningCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSSHPublicKey

        internal UpdateSSHPublicKeyResponse UpdateSSHPublicKey(UpdateSSHPublicKeyRequest request)
        {
            var marshaller = new UpdateSSHPublicKeyRequestMarshaller();
            var unmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateSSHPublicKeyRequest,UpdateSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateSSHPublicKeyResponse> UpdateSSHPublicKeyAsync(UpdateSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateSSHPublicKeyRequestMarshaller();
            var unmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSSHPublicKeyRequest,UpdateSSHPublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var marshaller = new UpdateUserRequestMarshaller();
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserRequest,UpdateUserResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateUserRequestMarshaller();
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserRequest,UpdateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadServerCertificate

        internal UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            var marshaller = new UploadServerCertificateRequestMarshaller();
            var unmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadServerCertificateRequest,UploadServerCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadServerCertificateRequestMarshaller();
            var unmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UploadServerCertificateRequest,UploadServerCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadSigningCertificate

        internal UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request)
        {
            var marshaller = new UploadSigningCertificateRequestMarshaller();
            var unmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadSigningCertificateRequest,UploadSigningCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadSigningCertificateResponse> UploadSigningCertificateAsync(UploadSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadSigningCertificateRequestMarshaller();
            var unmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UploadSigningCertificateRequest,UploadSigningCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadSSHPublicKey

        internal UploadSSHPublicKeyResponse UploadSSHPublicKey(UploadSSHPublicKeyRequest request)
        {
            var marshaller = new UploadSSHPublicKeyRequestMarshaller();
            var unmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UploadSSHPublicKeyRequest,UploadSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadSSHPublicKeyResponse> UploadSSHPublicKeyAsync(UploadSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadSSHPublicKeyRequestMarshaller();
            var unmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UploadSSHPublicKeyRequest,UploadSSHPublicKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}