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
using System.Net;

using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Model.Internal.MarshallTransformations;
using Amazon.IdentityManagement.Internal;
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
    public partial class AmazonIdentityManagementServiceClient : AmazonServiceClient, IAmazonIdentityManagementService
    {
        private static IServiceMetadata serviceMetadata = new AmazonIdentityManagementServiceMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonIdentityManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(AmazonIdentityManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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

        internal virtual AddClientIDToOpenIDConnectProviderResponse AddClientIDToOpenIDConnectProvider(AddClientIDToOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddClientIDToOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<AddClientIDToOpenIDConnectProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        public virtual Task<AddClientIDToOpenIDConnectProviderResponse> AddClientIDToOpenIDConnectProviderAsync(AddClientIDToOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddClientIDToOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<AddClientIDToOpenIDConnectProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddRoleToInstanceProfile

        internal virtual AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AddRoleToInstanceProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        public virtual Task<AddRoleToInstanceProfileResponse> AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AddRoleToInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddUserToGroup

        internal virtual AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AddUserToGroupResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        public virtual Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AddUserToGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachGroupPolicy

        internal virtual AttachGroupPolicyResponse AttachGroupPolicy(AttachGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachGroupPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        public virtual Task<AttachGroupPolicyResponse> AttachGroupPolicyAsync(AttachGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachRolePolicy

        internal virtual AttachRolePolicyResponse AttachRolePolicy(AttachRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<AttachRolePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        public virtual Task<AttachRolePolicyResponse> AttachRolePolicyAsync(AttachRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachRolePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachUserPolicy

        internal virtual AttachUserPolicyResponse AttachUserPolicy(AttachUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachUserPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        public virtual Task<AttachUserPolicyResponse> AttachUserPolicyAsync(AttachUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachUserPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChangePassword

        internal virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        public virtual Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ChangePasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessKey

        internal virtual CreateAccessKeyResponse CreateAccessKey()
        {
            return CreateAccessKey(new CreateAccessKeyRequest());
        }
        internal virtual CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;

            return Invoke<CreateAccessKeyResponse>(request, options);
        }


        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified
        /// user. The default status for new keys is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. This operation works for access keys under
        /// the AWS account. Consequently, you can use this operation to manage AWS account root
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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        public virtual Task<CreateAccessKeyResponse> CreateAccessKeyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        public virtual Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccessKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccountAlias

        internal virtual CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAccountAliasResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        public virtual Task<CreateAccountAliasResponse> CreateAccountAliasAsync(CreateAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceProfile

        internal virtual CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoginProfile

        internal virtual CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<CreateLoginProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        public virtual Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoginProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOpenIDConnectProvider

        internal virtual CreateOpenIDConnectProviderResponse CreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<CreateOpenIDConnectProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        public virtual Task<CreateOpenIDConnectProviderResponse> CreateOpenIDConnectProviderAsync(CreateOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOpenIDConnectProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicy

        internal virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicyVersion

        internal virtual CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyVersionResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRole

        internal virtual CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return Invoke<CreateRoleResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        public virtual Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSAMLProvider

        internal virtual CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<CreateSAMLProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        public virtual Task<CreateSAMLProviderResponse> CreateSAMLProviderAsync(CreateSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSAMLProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceLinkedRole

        internal virtual CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceLinkedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceLinkedRoleResponseUnmarshaller.Instance;

            return Invoke<CreateServiceLinkedRoleResponse>(request, options);
        }


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
        public virtual Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceLinkedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceLinkedRoleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceLinkedRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceSpecificCredential

        internal virtual CreateServiceSpecificCredentialResponse CreateServiceSpecificCredential(CreateServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<CreateServiceSpecificCredentialResponse>(request, options);
        }


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
        public virtual Task<CreateServiceSpecificCredentialResponse> CreateServiceSpecificCredentialAsync(CreateServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceSpecificCredentialResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceSpecificCredentialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVirtualMFADevice

        internal virtual CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVirtualMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualMFADeviceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        public virtual Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVirtualMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVirtualMFADeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeactivateMFADevice

        internal virtual DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeactivateMFADeviceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        public virtual Task<DeactivateMFADeviceResponse> DeactivateMFADeviceAsync(DeactivateMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateMFADeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessKey

        internal virtual DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessKeyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        public virtual Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountAlias

        internal virtual DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAliasResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        public virtual Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountPasswordPolicy

        internal virtual DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy()
        {
            return DeleteAccountPasswordPolicy(new DeleteAccountPasswordPolicyRequest());
        }
        internal virtual DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountPasswordPolicyResponse>(request, options);
        }


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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        public virtual Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        public virtual Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountPasswordPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroupPolicy

        internal virtual DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        public virtual Task<DeleteGroupPolicyResponse> DeleteGroupPolicyAsync(DeleteGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstanceProfile

        internal virtual DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoginProfile

        internal virtual DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteLoginProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        public virtual Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoginProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOpenIDConnectProvider

        internal virtual DeleteOpenIDConnectProviderResponse DeleteOpenIDConnectProvider(DeleteOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteOpenIDConnectProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        public virtual Task<DeleteOpenIDConnectProviderResponse> DeleteOpenIDConnectProviderAsync(DeleteOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOpenIDConnectProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicyVersion

        internal virtual DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyVersionResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        public virtual Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRole

        internal virtual DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        public virtual Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRolePermissionsBoundary

        internal virtual DeleteRolePermissionsBoundaryResponse DeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRolePermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRolePermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<DeleteRolePermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePermissionsBoundary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        public virtual Task<DeleteRolePermissionsBoundaryResponse> DeleteRolePermissionsBoundaryAsync(DeleteRolePermissionsBoundaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRolePermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRolePermissionsBoundaryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRolePermissionsBoundaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRolePolicy

        internal virtual DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRolePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        public virtual Task<DeleteRolePolicyResponse> DeleteRolePolicyAsync(DeleteRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRolePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSAMLProvider

        internal virtual DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteSAMLProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        public virtual Task<DeleteSAMLProviderResponse> DeleteSAMLProviderAsync(DeleteSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSAMLProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServerCertificate

        internal virtual DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteServerCertificateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        public virtual Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceLinkedRole

        internal virtual DeleteServiceLinkedRoleResponse DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceLinkedRoleResponse>(request, options);
        }


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
        public virtual Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceLinkedRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceSpecificCredential

        internal virtual DeleteServiceSpecificCredentialResponse DeleteServiceSpecificCredential(DeleteServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceSpecificCredentialResponse>(request, options);
        }


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
        public virtual Task<DeleteServiceSpecificCredentialResponse> DeleteServiceSpecificCredentialAsync(DeleteServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceSpecificCredentialResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceSpecificCredentialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSigningCertificate

        internal virtual DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteSigningCertificateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        public virtual Task<DeleteSigningCertificateResponse> DeleteSigningCertificateAsync(DeleteSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSigningCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSSHPublicKey

        internal virtual DeleteSSHPublicKeyResponse DeleteSSHPublicKey(DeleteSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteSSHPublicKeyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        public virtual Task<DeleteSSHPublicKeyResponse> DeleteSSHPublicKeyAsync(DeleteSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSSHPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserPermissionsBoundary

        internal virtual DeleteUserPermissionsBoundaryResponse DeleteUserPermissionsBoundary(DeleteUserPermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPermissionsBoundary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPermissionsBoundary">REST API Reference for DeleteUserPermissionsBoundary Operation</seealso>
        public virtual Task<DeleteUserPermissionsBoundaryResponse> DeleteUserPermissionsBoundaryAsync(DeleteUserPermissionsBoundaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPermissionsBoundaryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserPermissionsBoundaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUserPolicy

        internal virtual DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        public virtual Task<DeleteUserPolicyResponse> DeleteUserPolicyAsync(DeleteUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualMFADevice

        internal virtual DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualMFADeviceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        public virtual Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVirtualMFADeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachGroupPolicy

        internal virtual DetachGroupPolicyResponse DetachGroupPolicy(DetachGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachGroupPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        public virtual Task<DetachGroupPolicyResponse> DetachGroupPolicyAsync(DetachGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachRolePolicy

        internal virtual DetachRolePolicyResponse DetachRolePolicy(DetachRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DetachRolePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        public virtual Task<DetachRolePolicyResponse> DetachRolePolicyAsync(DetachRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachRolePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachUserPolicy

        internal virtual DetachUserPolicyResponse DetachUserPolicy(DetachUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachUserPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        public virtual Task<DetachUserPolicyResponse> DetachUserPolicyAsync(DetachUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachUserPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableMFADevice

        internal virtual EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return Invoke<EnableMFADeviceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        public virtual Task<EnableMFADeviceResponse> EnableMFADeviceAsync(EnableMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<EnableMFADeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateCredentialReport

        internal virtual GenerateCredentialReportResponse GenerateCredentialReport()
        {
            return GenerateCredentialReport(new GenerateCredentialReportRequest());
        }
        internal virtual GenerateCredentialReportResponse GenerateCredentialReport(GenerateCredentialReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GenerateCredentialReportResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        public virtual Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        public virtual Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(GenerateCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateCredentialReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateServiceLastAccessedDetails

        internal virtual GenerateServiceLastAccessedDetailsResponse GenerateServiceLastAccessedDetails(GenerateServiceLastAccessedDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateServiceLastAccessedDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateServiceLastAccessedDetailsResponseUnmarshaller.Instance;

            return Invoke<GenerateServiceLastAccessedDetailsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateServiceLastAccessedDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateServiceLastAccessedDetails">REST API Reference for GenerateServiceLastAccessedDetails Operation</seealso>
        public virtual Task<GenerateServiceLastAccessedDetailsResponse> GenerateServiceLastAccessedDetailsAsync(GenerateServiceLastAccessedDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateServiceLastAccessedDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateServiceLastAccessedDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateServiceLastAccessedDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessKeyLastUsed

        internal virtual GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessKeyLastUsedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;

            return Invoke<GetAccessKeyLastUsedResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        public virtual Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessKeyLastUsedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessKeyLastUsedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountAuthorizationDetails

        internal virtual GetAccountAuthorizationDetailsResponse GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountAuthorizationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetAccountAuthorizationDetailsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        public virtual Task<GetAccountAuthorizationDetailsResponse> GetAccountAuthorizationDetailsAsync(GetAccountAuthorizationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountAuthorizationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountAuthorizationDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountPasswordPolicy

        internal virtual GetAccountPasswordPolicyResponse GetAccountPasswordPolicy()
        {
            return GetAccountPasswordPolicy(new GetAccountPasswordPolicyRequest());
        }
        internal virtual GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAccountPasswordPolicyResponse>(request, options);
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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        public virtual Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        public virtual Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountPasswordPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSummary

        internal virtual GetAccountSummaryResponse GetAccountSummary()
        {
            return GetAccountSummary(new GetAccountSummaryRequest());
        }
        internal virtual GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;

            return Invoke<GetAccountSummaryResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        public virtual Task<GetAccountSummaryResponse> GetAccountSummaryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        public virtual Task<GetAccountSummaryResponse> GetAccountSummaryAsync(GetAccountSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContextKeysForCustomPolicy

        internal virtual GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(GetContextKeysForCustomPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContextKeysForCustomPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContextKeysForCustomPolicyResponse>(request, options);
        }


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
        public virtual Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        public virtual Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(GetContextKeysForCustomPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContextKeysForCustomPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContextKeysForCustomPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContextKeysForPrincipalPolicy

        internal virtual GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(GetContextKeysForPrincipalPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContextKeysForPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContextKeysForPrincipalPolicyResponse>(request, options);
        }


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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        public virtual Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            return GetContextKeysForPrincipalPolicyAsync(request, cancellationToken);
        }


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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        public virtual Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        public virtual Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(GetContextKeysForPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContextKeysForPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetContextKeysForPrincipalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCredentialReport

        internal virtual GetCredentialReportResponse GetCredentialReport()
        {
            return GetCredentialReport(new GetCredentialReportRequest());
        }
        internal virtual GetCredentialReportResponse GetCredentialReport(GetCredentialReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GetCredentialReportResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        public virtual Task<GetCredentialReportResponse> GetCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        public virtual Task<GetCredentialReportResponse> GetCredentialReportAsync(GetCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetCredentialReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroupPolicy

        internal virtual GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetGroupPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        public virtual Task<GetGroupPolicyResponse> GetGroupPolicyAsync(GetGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceProfile

        internal virtual GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInstanceProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        public virtual Task<GetInstanceProfileResponse> GetInstanceProfileAsync(GetInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoginProfile

        internal virtual GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return Invoke<GetLoginProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        public virtual Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoginProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpenIDConnectProvider

        internal virtual GetOpenIDConnectProviderResponse GetOpenIDConnectProvider(GetOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<GetOpenIDConnectProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        public virtual Task<GetOpenIDConnectProviderResponse> GetOpenIDConnectProviderAsync(GetOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpenIDConnectProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy

        internal virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicyVersion

        internal virtual GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<GetPolicyVersionResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRole

        internal virtual GetRoleResponse GetRole(GetRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleResponseUnmarshaller.Instance;

            return Invoke<GetRoleResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        public virtual Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRolePolicy

        internal virtual GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return Invoke<GetRolePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        public virtual Task<GetRolePolicyResponse> GetRolePolicyAsync(GetRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetRolePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSAMLProvider

        internal virtual GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<GetSAMLProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        public virtual Task<GetSAMLProviderResponse> GetSAMLProviderAsync(GetSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<GetSAMLProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServerCertificate

        internal virtual GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return Invoke<GetServerCertificateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        public virtual Task<GetServerCertificateResponse> GetServerCertificateAsync(GetServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetServerCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceLastAccessedDetails

        internal virtual GetServiceLastAccessedDetailsResponse GetServiceLastAccessedDetails(GetServiceLastAccessedDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLastAccessedDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLastAccessedDetailsResponseUnmarshaller.Instance;

            return Invoke<GetServiceLastAccessedDetailsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetails">REST API Reference for GetServiceLastAccessedDetails Operation</seealso>
        public virtual Task<GetServiceLastAccessedDetailsResponse> GetServiceLastAccessedDetailsAsync(GetServiceLastAccessedDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLastAccessedDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLastAccessedDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceLastAccessedDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceLastAccessedDetailsWithEntities

        internal virtual GetServiceLastAccessedDetailsWithEntitiesResponse GetServiceLastAccessedDetailsWithEntities(GetServiceLastAccessedDetailsWithEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLastAccessedDetailsWithEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLastAccessedDetailsWithEntitiesResponseUnmarshaller.Instance;

            return Invoke<GetServiceLastAccessedDetailsWithEntitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLastAccessedDetailsWithEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetailsWithEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetailsWithEntities">REST API Reference for GetServiceLastAccessedDetailsWithEntities Operation</seealso>
        public virtual Task<GetServiceLastAccessedDetailsWithEntitiesResponse> GetServiceLastAccessedDetailsWithEntitiesAsync(GetServiceLastAccessedDetailsWithEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLastAccessedDetailsWithEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLastAccessedDetailsWithEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceLastAccessedDetailsWithEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceLinkedRoleDeletionStatus

        internal virtual GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLinkedRoleDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLinkedRoleDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<GetServiceLinkedRoleDeletionStatusResponse>(request, options);
        }


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
        public virtual Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatusAsync(GetServiceLinkedRoleDeletionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLinkedRoleDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLinkedRoleDeletionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceLinkedRoleDeletionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSSHPublicKey

        internal virtual GetSSHPublicKeyResponse GetSSHPublicKey(GetSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetSSHPublicKeyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        public virtual Task<GetSSHPublicKeyResponse> GetSSHPublicKeyAsync(GetSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetSSHPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUser

        internal virtual GetUserResponse GetUser()
        {
            return GetUser(new GetUserRequest());
        }
        internal virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
        }


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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual Task<GetUserResponse> GetUserAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserPolicy

        internal virtual GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return Invoke<GetUserPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        public virtual Task<GetUserPolicyResponse> GetUserPolicyAsync(GetUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessKeys

        internal virtual ListAccessKeysResponse ListAccessKeys()
        {
            return ListAccessKeys(new ListAccessKeysRequest());
        }
        internal virtual ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessKeysResponseUnmarshaller.Instance;

            return Invoke<ListAccessKeysResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there is none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        public virtual Task<ListAccessKeysResponse> ListAccessKeysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        public virtual Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountAliases

        internal virtual ListAccountAliasesResponse ListAccountAliases()
        {
            return ListAccountAliases(new ListAccountAliasesRequest());
        }
        internal virtual ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAccountAliasesResponse>(request, options);
        }


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
        public virtual Task<ListAccountAliasesResponse> ListAccountAliasesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        public virtual Task<ListAccountAliasesResponse> ListAccountAliasesAsync(ListAccountAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedGroupPolicies

        internal virtual ListAttachedGroupPoliciesResponse ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedGroupPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedGroupPoliciesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        public virtual Task<ListAttachedGroupPoliciesResponse> ListAttachedGroupPoliciesAsync(ListAttachedGroupPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedGroupPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedGroupPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedRolePolicies

        internal virtual ListAttachedRolePoliciesResponse ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedRolePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedRolePoliciesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        public virtual Task<ListAttachedRolePoliciesResponse> ListAttachedRolePoliciesAsync(ListAttachedRolePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedRolePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedRolePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedUserPolicies

        internal virtual ListAttachedUserPoliciesResponse ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedUserPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedUserPoliciesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        public virtual Task<ListAttachedUserPoliciesResponse> ListAttachedUserPoliciesAsync(ListAttachedUserPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedUserPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedUserPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntitiesForPolicy

        internal virtual ListEntitiesForPolicyResponse ListEntitiesForPolicy(ListEntitiesForPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesForPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        public virtual Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitiesForPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroupPolicies

        internal virtual ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListGroupPoliciesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        public virtual Task<ListGroupPoliciesResponse> ListGroupPoliciesAsync(ListGroupPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups()
        {
            return ListGroups(new ListGroupsRequest());
        }
        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }


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
        public virtual Task<ListGroupsResponse> ListGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroupsForUser

        internal virtual ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<ListGroupsForUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        public virtual Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsForUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceProfiles

        internal virtual ListInstanceProfilesResponse ListInstanceProfiles()
        {
            return ListInstanceProfiles(new ListInstanceProfilesRequest());
        }
        internal virtual ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesResponse>(request, options);
        }


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
        public virtual Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(ListInstanceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceProfilesForRole

        internal virtual ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesForRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesForRoleResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        public virtual Task<ListInstanceProfilesForRoleResponse> ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesForRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceProfilesForRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMFADevices

        internal virtual ListMFADevicesResponse ListMFADevices()
        {
            return ListMFADevices(new ListMFADevicesRequest());
        }
        internal virtual ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMFADevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMFADevicesResponseUnmarshaller.Instance;

            return Invoke<ListMFADevicesResponse>(request, options);
        }


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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        public virtual Task<ListMFADevicesResponse> ListMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        public virtual Task<ListMFADevicesResponse> ListMFADevicesAsync(ListMFADevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMFADevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMFADevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMFADevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpenIDConnectProviders

        internal virtual ListOpenIDConnectProvidersResponse ListOpenIDConnectProviders(ListOpenIDConnectProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpenIDConnectProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;

            return Invoke<ListOpenIDConnectProvidersResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        public virtual Task<ListOpenIDConnectProvidersResponse> ListOpenIDConnectProvidersAsync(ListOpenIDConnectProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpenIDConnectProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListOpenIDConnectProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies

        internal virtual ListPoliciesResponse ListPolicies()
        {
            return ListPolicies(new ListPoliciesRequest());
        }
        internal virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }


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
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPoliciesGrantingServiceAccess

        internal virtual ListPoliciesGrantingServiceAccessResponse ListPoliciesGrantingServiceAccess(ListPoliciesGrantingServiceAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesGrantingServiceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesGrantingServiceAccessResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesGrantingServiceAccessResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPoliciesGrantingServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesGrantingServiceAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPoliciesGrantingServiceAccess">REST API Reference for ListPoliciesGrantingServiceAccess Operation</seealso>
        public virtual Task<ListPoliciesGrantingServiceAccessResponse> ListPoliciesGrantingServiceAccessAsync(ListPoliciesGrantingServiceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesGrantingServiceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesGrantingServiceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesGrantingServiceAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyVersions

        internal virtual ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyVersionsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRolePolicies

        internal virtual ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRolePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListRolePoliciesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        public virtual Task<ListRolePoliciesResponse> ListRolePoliciesAsync(ListRolePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRolePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRolePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRoles

        internal virtual ListRolesResponse ListRoles()
        {
            return ListRoles(new ListRolesRequest());
        }
        internal virtual ListRolesResponse ListRoles(ListRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolesResponseUnmarshaller.Instance;

            return Invoke<ListRolesResponse>(request, options);
        }


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
        public virtual Task<ListRolesResponse> ListRolesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        public virtual Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRolesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRoleTags

        internal virtual ListRoleTagsResponse ListRoleTags(ListRoleTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleTagsResponseUnmarshaller.Instance;

            return Invoke<ListRoleTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoleTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoleTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoleTags">REST API Reference for ListRoleTags Operation</seealso>
        public virtual Task<ListRoleTagsResponse> ListRoleTagsAsync(ListRoleTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRoleTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSAMLProviders

        internal virtual ListSAMLProvidersResponse ListSAMLProviders()
        {
            return ListSAMLProviders(new ListSAMLProvidersRequest());
        }
        internal virtual ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSAMLProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;

            return Invoke<ListSAMLProvidersResponse>(request, options);
        }


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
        public virtual Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        public virtual Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(ListSAMLProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSAMLProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListSAMLProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServerCertificates

        internal virtual ListServerCertificatesResponse ListServerCertificates()
        {
            return ListServerCertificates(new ListServerCertificatesRequest());
        }
        internal virtual ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListServerCertificatesResponse>(request, options);
        }


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
        public virtual Task<ListServerCertificatesResponse> ListServerCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        public virtual Task<ListServerCertificatesResponse> ListServerCertificatesAsync(ListServerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServerCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceSpecificCredentials

        internal virtual ListServiceSpecificCredentialsResponse ListServiceSpecificCredentials(ListServiceSpecificCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceSpecificCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceSpecificCredentialsResponseUnmarshaller.Instance;

            return Invoke<ListServiceSpecificCredentialsResponse>(request, options);
        }


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
        public virtual Task<ListServiceSpecificCredentialsResponse> ListServiceSpecificCredentialsAsync(ListServiceSpecificCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceSpecificCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceSpecificCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceSpecificCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSigningCertificates

        internal virtual ListSigningCertificatesResponse ListSigningCertificates()
        {
            return ListSigningCertificates(new ListSigningCertificatesRequest());
        }
        internal virtual ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListSigningCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If there none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request for this API. This operation
        /// works for access keys under the AWS account. Consequently, you can use this operation
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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        public virtual Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        public virtual Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(ListSigningCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSigningCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSSHPublicKeys

        internal virtual ListSSHPublicKeysResponse ListSSHPublicKeys(ListSSHPublicKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSSHPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListSSHPublicKeysResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        public virtual Task<ListSSHPublicKeysResponse> ListSSHPublicKeysAsync(ListSSHPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSSHPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListSSHPublicKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserPolicies

        internal virtual ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListUserPoliciesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        public virtual Task<ListUserPoliciesResponse> ListUserPoliciesAsync(ListUserPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers()
        {
            return ListUsers(new ListUsersRequest());
        }
        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }


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
        public virtual Task<ListUsersResponse> ListUsersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserTags

        internal virtual ListUserTagsResponse ListUserTags(ListUserTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserTagsResponseUnmarshaller.Instance;

            return Invoke<ListUserTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserTags">REST API Reference for ListUserTags Operation</seealso>
        public virtual Task<ListUserTagsResponse> ListUserTagsAsync(ListUserTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVirtualMFADevices

        internal virtual ListVirtualMFADevicesResponse ListVirtualMFADevices()
        {
            return ListVirtualMFADevices(new ListVirtualMFADevicesRequest());
        }
        internal virtual ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualMFADevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;

            return Invoke<ListVirtualMFADevicesResponse>(request, options);
        }


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
        public virtual Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        public virtual Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualMFADevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVirtualMFADevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutGroupPolicy

        internal virtual PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutGroupPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        public virtual Task<PutGroupPolicyResponse> PutGroupPolicyAsync(PutGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRolePermissionsBoundary

        internal virtual PutRolePermissionsBoundaryResponse PutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRolePermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRolePermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<PutRolePermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePermissionsBoundary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        public virtual Task<PutRolePermissionsBoundaryResponse> PutRolePermissionsBoundaryAsync(PutRolePermissionsBoundaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRolePermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRolePermissionsBoundaryResponseUnmarshaller.Instance;

            return InvokeAsync<PutRolePermissionsBoundaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRolePolicy

        internal virtual PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return Invoke<PutRolePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        public virtual Task<PutRolePolicyResponse> PutRolePolicyAsync(PutRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutRolePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutUserPermissionsBoundary

        internal virtual PutUserPermissionsBoundaryResponse PutUserPermissionsBoundary(PutUserPermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserPermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserPermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<PutUserPermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPermissionsBoundary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPermissionsBoundary">REST API Reference for PutUserPermissionsBoundary Operation</seealso>
        public virtual Task<PutUserPermissionsBoundaryResponse> PutUserPermissionsBoundaryAsync(PutUserPermissionsBoundaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserPermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserPermissionsBoundaryResponseUnmarshaller.Instance;

            return InvokeAsync<PutUserPermissionsBoundaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutUserPolicy

        internal virtual PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return Invoke<PutUserPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        public virtual Task<PutUserPolicyResponse> PutUserPolicyAsync(PutUserPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutUserPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveClientIDFromOpenIDConnectProvider

        internal virtual RemoveClientIDFromOpenIDConnectProviderResponse RemoveClientIDFromOpenIDConnectProvider(RemoveClientIDFromOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveClientIDFromOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<RemoveClientIDFromOpenIDConnectProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        public virtual Task<RemoveClientIDFromOpenIDConnectProviderResponse> RemoveClientIDFromOpenIDConnectProviderAsync(RemoveClientIDFromOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveClientIDFromOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveClientIDFromOpenIDConnectProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveRoleFromInstanceProfile

        internal virtual RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromInstanceProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        public virtual Task<RemoveRoleFromInstanceProfileResponse> RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveRoleFromInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveUserFromGroup

        internal virtual RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveUserFromGroupResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        public virtual Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveUserFromGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetServiceSpecificCredential

        internal virtual ResetServiceSpecificCredentialResponse ResetServiceSpecificCredential(ResetServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<ResetServiceSpecificCredentialResponse>(request, options);
        }


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
        public virtual Task<ResetServiceSpecificCredentialResponse> ResetServiceSpecificCredentialAsync(ResetServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetServiceSpecificCredentialResponseUnmarshaller.Instance;

            return InvokeAsync<ResetServiceSpecificCredentialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResyncMFADevice

        internal virtual ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResyncMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return Invoke<ResyncMFADeviceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        public virtual Task<ResyncMFADeviceResponse> ResyncMFADeviceAsync(ResyncMFADeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResyncMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return InvokeAsync<ResyncMFADeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDefaultPolicyVersion

        internal virtual SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<SetDefaultPolicyVersionResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SimulateCustomPolicy

        internal virtual SimulateCustomPolicyResponse SimulateCustomPolicy(SimulateCustomPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SimulateCustomPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulateCustomPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        public virtual Task<SimulateCustomPolicyResponse> SimulateCustomPolicyAsync(SimulateCustomPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SimulateCustomPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SimulateCustomPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SimulatePrincipalPolicy

        internal virtual SimulatePrincipalPolicyResponse SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SimulatePrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulatePrincipalPolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        public virtual Task<SimulatePrincipalPolicyResponse> SimulatePrincipalPolicyAsync(SimulatePrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SimulatePrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SimulatePrincipalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagRole

        internal virtual TagRoleResponse TagRole(TagRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagRoleResponseUnmarshaller.Instance;

            return Invoke<TagRoleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagRole">REST API Reference for TagRole Operation</seealso>
        public virtual Task<TagRoleResponse> TagRoleAsync(TagRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagRoleResponseUnmarshaller.Instance;

            return InvokeAsync<TagRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagUser

        internal virtual TagUserResponse TagUser(TagUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagUserResponseUnmarshaller.Instance;

            return Invoke<TagUserResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagUser">REST API Reference for TagUser Operation</seealso>
        public virtual Task<TagUserResponse> TagUserAsync(TagUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagUserResponseUnmarshaller.Instance;

            return InvokeAsync<TagUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagRole

        internal virtual UntagRoleResponse UntagRole(UntagRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagRoleResponseUnmarshaller.Instance;

            return Invoke<UntagRoleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagRole">REST API Reference for UntagRole Operation</seealso>
        public virtual Task<UntagRoleResponse> UntagRoleAsync(UntagRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagRoleResponseUnmarshaller.Instance;

            return InvokeAsync<UntagRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagUser

        internal virtual UntagUserResponse UntagUser(UntagUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagUserResponseUnmarshaller.Instance;

            return Invoke<UntagUserResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagUser">REST API Reference for UntagUser Operation</seealso>
        public virtual Task<UntagUserResponse> UntagUserAsync(UntagUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagUserResponseUnmarshaller.Instance;

            return InvokeAsync<UntagUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccessKey

        internal virtual UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessKeyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        public virtual Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccessKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountPasswordPolicy

        internal virtual UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy()
        {
            return UpdateAccountPasswordPolicy(new UpdateAccountPasswordPolicyRequest());
        }
        internal virtual UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountPasswordPolicyResponse>(request, options);
        }


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
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        public virtual Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        public virtual Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountPasswordPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssumeRolePolicy

        internal virtual UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssumeRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAssumeRolePolicyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        public virtual Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssumeRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssumeRolePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLoginProfile

        internal virtual UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateLoginProfileResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        public virtual Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoginProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOpenIDConnectProviderThumbprint

        internal virtual UpdateOpenIDConnectProviderThumbprintResponse UpdateOpenIDConnectProviderThumbprint(UpdateOpenIDConnectProviderThumbprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpenIDConnectProviderThumbprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;

            return Invoke<UpdateOpenIDConnectProviderThumbprintResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        public virtual Task<UpdateOpenIDConnectProviderThumbprintResponse> UpdateOpenIDConnectProviderThumbprintAsync(UpdateOpenIDConnectProviderThumbprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpenIDConnectProviderThumbprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOpenIDConnectProviderThumbprintResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRole

        internal virtual UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleResponseUnmarshaller.Instance;

            return Invoke<UpdateRoleResponse>(request, options);
        }


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
        public virtual Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoleDescription

        internal virtual UpdateRoleDescriptionResponse UpdateRoleDescription(UpdateRoleDescriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateRoleDescriptionResponse>(request, options);
        }


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
        public virtual Task<UpdateRoleDescriptionResponse> UpdateRoleDescriptionAsync(UpdateRoleDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoleDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSAMLProvider

        internal virtual UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateSAMLProviderResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        public virtual Task<UpdateSAMLProviderResponse> UpdateSAMLProviderAsync(UpdateSAMLProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSAMLProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServerCertificate

        internal virtual UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateServerCertificateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        public virtual Task<UpdateServerCertificateResponse> UpdateServerCertificateAsync(UpdateServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceSpecificCredential

        internal virtual UpdateServiceSpecificCredentialResponse UpdateServiceSpecificCredential(UpdateServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSpecificCredentialResponse>(request, options);
        }


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
        public virtual Task<UpdateServiceSpecificCredentialResponse> UpdateServiceSpecificCredentialAsync(UpdateServiceSpecificCredentialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSpecificCredentialResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceSpecificCredentialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSigningCertificate

        internal virtual UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateSigningCertificateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        public virtual Task<UpdateSigningCertificateResponse> UpdateSigningCertificateAsync(UpdateSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSigningCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSSHPublicKey

        internal virtual UpdateSSHPublicKeyResponse UpdateSSHPublicKey(UpdateSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateSSHPublicKeyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        public virtual Task<UpdateSSHPublicKeyResponse> UpdateSSHPublicKeyAsync(UpdateSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSSHPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadServerCertificate

        internal virtual UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadServerCertificateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        public virtual Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UploadServerCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadSigningCertificate

        internal virtual UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadSigningCertificateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        public virtual Task<UploadSigningCertificateResponse> UploadSigningCertificateAsync(UploadSigningCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UploadSigningCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadSSHPublicKey

        internal virtual UploadSSHPublicKeyResponse UploadSSHPublicKey(UploadSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UploadSSHPublicKeyResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        public virtual Task<UploadSSHPublicKeyResponse> UploadSSHPublicKeyAsync(UploadSSHPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UploadSSHPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}