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
    /// AWS Identity and Access Management (IAM) is a web service for securely controlling
    /// access to AWS services. With IAM, you can centrally manage users, security credentials
    /// such as access keys, and permissions that control which AWS resources users and applications
    /// can access. For more information about IAM, see <a href="http://aws.amazon.com/iam/">AWS
    /// Identity and Access Management (IAM)</a> and the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/">AWS
    /// Identity and Access Management User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonIdentityManagementServiceClient : AmazonServiceClient, IAmazonIdentityManagementService
    {
        private static IServiceMetadata serviceMetadata = new AmazonIdentityManagementServiceMetadata();
        private IIdentityManagementPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIdentityManagementPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IdentityManagementPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

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


        /// <summary>
        /// Adds a new client ID (also known as audience) to the list of client IDs already registered
        /// for the specified IAM OpenID Connect (OIDC) provider resource.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you add an existing
        /// client ID to the provider.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the AddClientIDToOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        public virtual AddClientIDToOpenIDConnectProviderResponse AddClientIDToOpenIDConnectProvider(AddClientIDToOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddClientIDToOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<AddClientIDToOpenIDConnectProviderResponse>(request, options);
        }


        /// <summary>
        /// Adds a new client ID (also known as audience) to the list of client IDs already registered
        /// for the specified IAM OpenID Connect (OIDC) provider resource.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you add an existing
        /// client ID to the provider.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddClientIDToOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Adds the specified IAM role to the specified instance profile. An instance profile
        /// can contain only one role. (The number and size of IAM resources in an AWS account
        /// are limited. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.) You can remove the existing role
        /// and then add a different role to an instance profile. You must then wait for the change
        /// to appear across all of AWS because of <a href="https://en.wikipedia.org/wiki/Eventual_consistency">eventual
        /// consistency</a>. To force the change, you must <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DisassociateIamInstanceProfile.html">disassociate
        /// the instance profile</a> and then <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_AssociateIamInstanceProfile.html">associate
        /// the instance profile</a>, or you can stop your instance and then restart it.
        /// 
        ///  <note> 
        /// <para>
        /// The caller of this API must be granted the <code>PassRole</code> permission on the
        /// IAM role by a permissions policy.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For more information about instance profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the AddRoleToInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        public virtual AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AddRoleToInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Adds the specified IAM role to the specified instance profile. An instance profile
        /// can contain only one role. (The number and size of IAM resources in an AWS account
        /// are limited. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.) You can remove the existing role
        /// and then add a different role to an instance profile. You must then wait for the change
        /// to appear across all of AWS because of <a href="https://en.wikipedia.org/wiki/Eventual_consistency">eventual
        /// consistency</a>. To force the change, you must <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DisassociateIamInstanceProfile.html">disassociate
        /// the instance profile</a> and then <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_AssociateIamInstanceProfile.html">associate
        /// the instance profile</a>, or you can stop your instance and then restart it.
        /// 
        ///  <note> 
        /// <para>
        /// The caller of this API must be granted the <code>PassRole</code> permission on the
        /// IAM role by a permissions policy.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For more information about instance profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddRoleToInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Adds the specified user to the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup service method.</param>
        /// 
        /// <returns>The response from the AddUserToGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        public virtual AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AddUserToGroupResponse>(request, options);
        }


        /// <summary>
        /// Adds the specified user to the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddUserToGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Attaches the specified managed policy to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// You use this API to attach a managed policy to a group. To embed an inline policy
        /// in a group, use <a>PutGroupPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        public virtual AttachGroupPolicyResponse AttachGroupPolicy(AttachGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachGroupPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches the specified managed policy to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// You use this API to attach a managed policy to a group. To embed an inline policy
        /// in a group, use <a>PutGroupPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Attaches the specified managed policy to the specified IAM role. When you attach a
        /// managed policy to a role, the managed policy becomes part of the role's permission
        /// (access) policy.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use a managed policy as the role's trust policy. The role's trust policy
        /// is created at the same time as the role, using <a>CreateRole</a>. You can update a
        /// role's trust policy using <a>UpdateAssumeRolePolicy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Use this API to attach a <i>managed</i> policy to a role. To embed an inline policy
        /// in a role, use <a>PutRolePolicy</a>. For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy service method.</param>
        /// 
        /// <returns>The response from the AttachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        public virtual AttachRolePolicyResponse AttachRolePolicy(AttachRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<AttachRolePolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches the specified managed policy to the specified IAM role. When you attach a
        /// managed policy to a role, the managed policy becomes part of the role's permission
        /// (access) policy.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use a managed policy as the role's trust policy. The role's trust policy
        /// is created at the same time as the role, using <a>CreateRole</a>. You can update a
        /// role's trust policy using <a>UpdateAssumeRolePolicy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Use this API to attach a <i>managed</i> policy to a role. To embed an inline policy
        /// in a role, use <a>PutRolePolicy</a>. For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Attaches the specified managed policy to the specified user.
        /// 
        ///  
        /// <para>
        /// You use this API to attach a <i>managed</i> policy to a user. To embed an inline policy
        /// in a user, use <a>PutUserPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        public virtual AttachUserPolicyResponse AttachUserPolicy(AttachUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachUserPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches the specified managed policy to the specified user.
        /// 
        ///  
        /// <para>
        /// You use this API to attach a <i>managed</i> policy to a user. To embed an inline policy
        /// in a user, use <a>PutUserPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Changes the password of the IAM user who is calling this operation. The AWS account
        /// root user password is not affected by this operation.
        /// 
        ///  
        /// <para>
        /// To change the password for a different user, see <a>UpdateLoginProfile</a>. For more
        /// information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidUserTypeException">
        /// The request was rejected because the type of user for the transaction was incorrect.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        public virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordResponse>(request, options);
        }


        /// <summary>
        /// Changes the password of the IAM user who is calling this operation. The AWS account
        /// root user password is not affected by this operation.
        /// 
        ///  
        /// <para>
        /// To change the password for a different user, see <a>UpdateLoginProfile</a>. For more
        /// information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidUserTypeException">
        /// The request was rejected because the type of user for the transaction was incorrect.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
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
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        public virtual CreateAccessKeyResponse CreateAccessKey()
        {
            return CreateAccessKey(new CreateAccessKeyRequest());
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
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey service method.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        public virtual CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request)
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
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
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
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates an alias for your AWS account. For information about using an AWS account
        /// alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        public virtual CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAccountAliasResponse>(request, options);
        }


        /// <summary>
        /// Creates an alias for your AWS account. For information about using an AWS account
        /// alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates a new group.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a new group.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates a new instance profile. For information about instance profiles, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates a new instance profile. For information about instance profiles, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates a password for the specified user, giving the user the ability to access
        /// AWS services through the AWS Management Console. For more information about managing
        /// passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        public virtual CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<CreateLoginProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates a password for the specified user, giving the user the ability to access
        /// AWS services through the AWS Management Console. For more information about managing
        /// passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates an IAM entity to describe an identity provider (IdP) that supports <a href="http://openid.net/connect/">OpenID
        /// Connect (OIDC)</a>.
        /// 
        ///  
        /// <para>
        /// The OIDC provider that you create with this operation can be used as a principal in
        /// a role's trust policy. Such a policy establishes a trust relationship between AWS
        /// and the OIDC provider.
        /// </para>
        ///  
        /// <para>
        /// When you create the IAM OIDC provider, you specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The URL of the OIDC identity provider (IdP) to trust
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list of client IDs (also known as audiences) that identify the application or applications
        /// that are allowed to authenticate using the OIDC provider
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list of thumbprints of one or more server certificates that the IdP uses
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You get all of this information from the OIDC IdP that you want to use to access AWS.
        /// </para>
        ///  <note> 
        /// <para>
        /// The trust for the OIDC provider is derived from the IAM provider that this operation
        /// creates. Therefore, it is best to limit access to the <a>CreateOpenIDConnectProvider</a>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the CreateOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        public virtual CreateOpenIDConnectProviderResponse CreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<CreateOpenIDConnectProviderResponse>(request, options);
        }


        /// <summary>
        /// Creates an IAM entity to describe an identity provider (IdP) that supports <a href="http://openid.net/connect/">OpenID
        /// Connect (OIDC)</a>.
        /// 
        ///  
        /// <para>
        /// The OIDC provider that you create with this operation can be used as a principal in
        /// a role's trust policy. Such a policy establishes a trust relationship between AWS
        /// and the OIDC provider.
        /// </para>
        ///  
        /// <para>
        /// When you create the IAM OIDC provider, you specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The URL of the OIDC identity provider (IdP) to trust
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list of client IDs (also known as audiences) that identify the application or applications
        /// that are allowed to authenticate using the OIDC provider
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list of thumbprints of one or more server certificates that the IdP uses
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You get all of this information from the OIDC IdP that you want to use to access AWS.
        /// </para>
        ///  <note> 
        /// <para>
        /// The trust for the OIDC provider is derived from the IAM provider that this operation
        /// creates. Therefore, it is best to limit access to the <a>CreateOpenIDConnectProvider</a>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates a new managed policy for your AWS account.
        /// 
        ///  
        /// <para>
        /// This operation creates a policy version with a version identifier of <code>v1</code>
        /// and sets v1 as the policy's default version. For more information about policy versions,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies in general, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates a new managed policy for your AWS account.
        /// 
        ///  
        /// <para>
        /// This operation creates a policy version with a version identifier of <code>v1</code>
        /// and sets v1 as the policy's default version. For more information about policy versions,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies in general, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates a new version of the specified managed policy. To update a managed policy,
        /// you create a new policy version. A managed policy can have up to five versions. If
        /// the policy has five versions, you must delete an existing version using <a>DeletePolicyVersion</a>
        /// before you create a new version.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the version that is in effect for the IAM users, groups, and roles to which
        /// the policy is attached.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a new version of the specified managed policy. To update a managed policy,
        /// you create a new policy version. A managed policy can have up to five versions. If
        /// the policy has five versions, you must delete an existing version using <a>DeletePolicyVersion</a>
        /// before you create a new version.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the version that is in effect for the IAM users, groups, and roles to which
        /// the policy is attached.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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


        /// <summary>
        /// Creates a new role for your AWS account. For more information about roles, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">IAM
        /// Roles</a>. The number and size of IAM resources in an AWS account are limited. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRole service method.</param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        public virtual CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return Invoke<CreateRoleResponse>(request, options);
        }


        /// <summary>
        /// Creates a new role for your AWS account. For more information about roles, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">IAM
        /// Roles</a>. The number and size of IAM resources in an AWS account are limited. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates an IAM resource that describes an identity provider (IdP) that supports SAML
        /// 2.0.
        /// 
        ///  
        /// <para>
        /// The SAML provider resource that you create with this operation can be used as a principal
        /// in an IAM role's trust policy. Such a policy can enable federated users who sign in
        /// using the SAML IdP to assume the role. You can create an IAM role that supports Web-based
        /// single sign-on (SSO) to the AWS Management Console or one that supports API access
        /// to AWS.
        /// </para>
        ///  
        /// <para>
        /// When you create the SAML provider resource, you upload a SAML metadata document that
        /// you get from your IdP. That document includes the issuer's name, expiration information,
        /// and keys that can be used to validate the SAML authentication response (assertions)
        /// that the IdP sends. You must generate the metadata document using the identity management
        /// software that is used as your organization's IdP.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-saml.html">Enabling
        /// SAML 2.0 Federated Users to Access the AWS Management Console</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the CreateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        public virtual CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<CreateSAMLProviderResponse>(request, options);
        }


        /// <summary>
        /// Creates an IAM resource that describes an identity provider (IdP) that supports SAML
        /// 2.0.
        /// 
        ///  
        /// <para>
        /// The SAML provider resource that you create with this operation can be used as a principal
        /// in an IAM role's trust policy. Such a policy can enable federated users who sign in
        /// using the SAML IdP to assume the role. You can create an IAM role that supports Web-based
        /// single sign-on (SSO) to the AWS Management Console or one that supports API access
        /// to AWS.
        /// </para>
        ///  
        /// <para>
        /// When you create the SAML provider resource, you upload a SAML metadata document that
        /// you get from your IdP. That document includes the issuer's name, expiration information,
        /// and keys that can be used to validate the SAML authentication response (assertions)
        /// that the IdP sends. You must generate the metadata document using the identity management
        /// software that is used as your organization's IdP.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-saml.html">Enabling
        /// SAML 2.0 Federated Users to Access the AWS Management Console</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates an IAM role that is linked to a specific AWS service. The service controls
        /// the attached policies and when the role can be deleted. This helps ensure that the
        /// service is not broken by an unexpectedly changed or deleted role, which could put
        /// your AWS resources into an unknown state. Allowing the service to control the role
        /// helps improve service stability and proper cleanup when a service and its role are
        /// no longer needed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">Using
        /// Service-Linked Roles</a> in the <i>IAM User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// To attach a policy to this service-linked role, you must make the request using the
        /// AWS service that depends on this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLinkedRole service method.</param>
        /// 
        /// <returns>The response from the CreateServiceLinkedRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceLinkedRole">REST API Reference for CreateServiceLinkedRole Operation</seealso>
        public virtual CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceLinkedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceLinkedRoleResponseUnmarshaller.Instance;

            return Invoke<CreateServiceLinkedRoleResponse>(request, options);
        }


        /// <summary>
        /// Creates an IAM role that is linked to a specific AWS service. The service controls
        /// the attached policies and when the role can be deleted. This helps ensure that the
        /// service is not broken by an unexpectedly changed or deleted role, which could put
        /// your AWS resources into an unknown state. Allowing the service to control the role
        /// helps improve service stability and proper cleanup when a service and its role are
        /// no longer needed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">Using
        /// Service-Linked Roles</a> in the <i>IAM User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// To attach a policy to this service-linked role, you must make the request using the
        /// AWS service that depends on this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLinkedRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceLinkedRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Generates a set of credentials consisting of a user name and password that can be
        /// used to access the service specified in the request. These credentials are generated
        /// by IAM, and can be used only for the specified service. 
        /// 
        ///  
        /// <para>
        /// You can have a maximum of two sets of service-specific credentials for each supported
        /// service per user.
        /// </para>
        ///  
        /// <para>
        /// The only supported service at this time is AWS CodeCommit.
        /// </para>
        ///  
        /// <para>
        /// You can reset the password to a new service-generated value by calling <a>ResetServiceSpecificCredential</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-specific credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_ssh-keys.html">Using
        /// IAM with AWS CodeCommit: Git Credentials, SSH Keys, and AWS Access Keys</a> in the
        /// <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the CreateServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceNotSupportedException">
        /// The specified service does not support service-specific credentials.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceSpecificCredential">REST API Reference for CreateServiceSpecificCredential Operation</seealso>
        public virtual CreateServiceSpecificCredentialResponse CreateServiceSpecificCredential(CreateServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<CreateServiceSpecificCredentialResponse>(request, options);
        }


        /// <summary>
        /// Generates a set of credentials consisting of a user name and password that can be
        /// used to access the service specified in the request. These credentials are generated
        /// by IAM, and can be used only for the specified service. 
        /// 
        ///  
        /// <para>
        /// You can have a maximum of two sets of service-specific credentials for each supported
        /// service per user.
        /// </para>
        ///  
        /// <para>
        /// The only supported service at this time is AWS CodeCommit.
        /// </para>
        ///  
        /// <para>
        /// You can reset the password to a new service-generated value by calling <a>ResetServiceSpecificCredential</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-specific credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_ssh-keys.html">Using
        /// IAM with AWS CodeCommit: Git Credentials, SSH Keys, and AWS Access Keys</a> in the
        /// <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceNotSupportedException">
        /// The specified service does not support service-specific credentials.
        /// </exception>
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


        /// <summary>
        /// Creates a new IAM user for your AWS account.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }


        /// <summary>
        /// Creates a new IAM user for your AWS account.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
        /// use <a>EnableMFADevice</a> to attach the MFA device to an IAM user. For more information
        /// about creating and working with virtual MFA devices, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a Virtual MFA Device</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The seed information contained in the QR code and the Base32 string should be treated
        /// like any other secret access information. In other words, protect the seed information
        /// as you would your AWS access keys or your passwords. After you provision your virtual
        /// device, you should ensure that the information is destroyed following secure procedures.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        public virtual CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVirtualMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualMFADeviceResponse>(request, options);
        }


        /// <summary>
        /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
        /// use <a>EnableMFADevice</a> to attach the MFA device to an IAM user. For more information
        /// about creating and working with virtual MFA devices, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a Virtual MFA Device</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The seed information contained in the QR code and the Base32 string should be treated
        /// like any other secret access information. In other words, protect the seed information
        /// as you would your AWS access keys or your passwords. After you provision your virtual
        /// device, you should ensure that the information is destroyed following secure procedures.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deactivates the specified MFA device and removes it from association with the user
        /// name for which it was originally enabled.
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Enabling
        /// a Virtual Multi-factor Authentication (MFA) Device</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        public virtual DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivateMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeactivateMFADeviceResponse>(request, options);
        }


        /// <summary>
        /// Deactivates the specified MFA device and removes it from association with the user
        /// name for which it was originally enabled.
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Enabling
        /// a Virtual Multi-factor Authentication (MFA) Device</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the access key pair associated with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. This operation works for access keys under
        /// the AWS account. Consequently, you can use this operation to manage AWS account root
        /// user credentials even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        public virtual DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessKeyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the access key pair associated with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. This operation works for access keys under
        /// the AWS account. Consequently, you can use this operation to manage AWS account root
        /// user credentials even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified AWS account alias. For information about using an AWS account
        /// alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        public virtual DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAliasResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified AWS account alias. For information about using an AWS account
        /// alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the password policy for the AWS account. There are no parameters.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        public virtual DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy()
        {
            return DeleteAccountPasswordPolicy(new DeleteAccountPasswordPolicyRequest());
        }


        /// <summary>
        /// Deletes the password policy for the AWS account. There are no parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        public virtual DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request)
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
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// Deletes the password policy for the AWS account. There are no parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified IAM group. The group must not contain any users or have any
        /// attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified IAM group. The group must not contain any users or have any
        /// attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To detach a managed policy
        /// from a group, use <a>DetachGroupPolicy</a>. For more information about policies, refer
        /// to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        public virtual DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To detach a managed policy
        /// from a group, use <a>DetachGroupPolicy</a>. For more information about policies, refer
        /// to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified instance profile. The instance profile must not have an associated
        /// role.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the instance
        /// profile you are about to delete. Deleting a role or instance profile that is associated
        /// with a running instance will break any applications running on the instance.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about instance profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified instance profile. The instance profile must not have an associated
        /// role.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the instance
        /// profile you are about to delete. Deleting a role or instance profile that is associated
        /// with a running instance will break any applications running on the instance.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about instance profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the password for the specified IAM user, which terminates the user's ability
        /// to access AWS services through the AWS Management Console.
        /// 
        ///  <important> 
        /// <para>
        ///  Deleting a user's password does not prevent a user from accessing AWS through the
        /// command line interface or the API. To prevent all user access, you must also either
        /// make any access keys inactive or delete them. For more information about making keys
        /// inactive or deleting them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        public virtual DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteLoginProfileResponse>(request, options);
        }


        /// <summary>
        /// Deletes the password for the specified IAM user, which terminates the user's ability
        /// to access AWS services through the AWS Management Console.
        /// 
        ///  <important> 
        /// <para>
        ///  Deleting a user's password does not prevent a user from accessing AWS through the
        /// command line interface or the API. To prevent all user access, you must also either
        /// make any access keys inactive or delete them. For more information about making keys
        /// inactive or deleting them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes an OpenID Connect identity provider (IdP) resource object in IAM.
        /// 
        ///  
        /// <para>
        /// Deleting an IAM OIDC provider resource does not update any roles that reference the
        /// provider as a principal in their trust policies. Any attempt to assume a role that
        /// references a deleted provider fails.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you call the
        /// operation for a provider that does not exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        public virtual DeleteOpenIDConnectProviderResponse DeleteOpenIDConnectProvider(DeleteOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteOpenIDConnectProviderResponse>(request, options);
        }


        /// <summary>
        /// Deletes an OpenID Connect identity provider (IdP) resource object in IAM.
        /// 
        ///  
        /// <para>
        /// Deleting an IAM OIDC provider resource does not update any roles that reference the
        /// provider as a principal in their trust policies. Any attempt to assume a role that
        /// references a deleted provider fails.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you call the
        /// operation for a provider that does not exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified managed policy.
        /// 
        ///  
        /// <para>
        /// Before you can delete a managed policy, you must first detach the policy from all
        /// users, groups, and roles that it is attached to. In addition, you must delete all
        /// the policy's versions. The following steps describe the process for deleting a managed
        /// policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Detach the policy from all users, groups, and roles that the policy is attached to,
        /// using the <a>DetachUserPolicy</a>, <a>DetachGroupPolicy</a>, or <a>DetachRolePolicy</a>
        /// API operations. To list all the users, groups, and roles that a policy is attached
        /// to, use <a>ListEntitiesForPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete all versions of the policy using <a>DeletePolicyVersion</a>. To list the policy's
        /// versions, use <a>ListPolicyVersions</a>. You cannot use <a>DeletePolicyVersion</a>
        /// to delete the version that is marked as the default version. You delete the policy's
        /// default version in the next step of the process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the policy (this automatically deletes the policy's default version) using
        /// this API.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified managed policy.
        /// 
        ///  
        /// <para>
        /// Before you can delete a managed policy, you must first detach the policy from all
        /// users, groups, and roles that it is attached to. In addition, you must delete all
        /// the policy's versions. The following steps describe the process for deleting a managed
        /// policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Detach the policy from all users, groups, and roles that the policy is attached to,
        /// using the <a>DetachUserPolicy</a>, <a>DetachGroupPolicy</a>, or <a>DetachRolePolicy</a>
        /// API operations. To list all the users, groups, and roles that a policy is attached
        /// to, use <a>ListEntitiesForPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete all versions of the policy using <a>DeletePolicyVersion</a>. To list the policy's
        /// versions, use <a>ListPolicyVersions</a>. You cannot use <a>DeletePolicyVersion</a>
        /// to delete the version that is marked as the default version. You delete the policy's
        /// default version in the next step of the process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the policy (this automatically deletes the policy's default version) using
        /// this API.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified version from the specified managed policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete the default version from a policy using this API. To delete the
        /// default version from a policy, use <a>DeletePolicy</a>. To find out which version
        /// of a policy is marked as the default version, use <a>ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about versions for managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        public virtual DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified version from the specified managed policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete the default version from a policy using this API. To delete the
        /// default version from a policy, use <a>DeletePolicy</a>. To find out which version
        /// of a policy is marked as the default version, use <a>ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about versions for managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified role. The role must not have any policies attached. For more
        /// information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the role you
        /// are about to delete. Deleting a role or instance profile that is associated with a
        /// running instance will break any applications running on the instance.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole service method.</param>
        /// 
        /// <returns>The response from the DeleteRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        public virtual DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified role. The role must not have any policies attached. For more
        /// information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the role you
        /// are about to delete. Deleting a role or instance profile that is associated with a
        /// running instance will break any applications running on the instance.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Deletes the permissions boundary for the specified IAM role. 
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the permissions boundary for a role might increase its permissions. For example,
        /// it might allow anyone who assumes the role to perform all the actions granted in its
        /// permissions policies. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the DeleteRolePermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        public virtual DeleteRolePermissionsBoundaryResponse DeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRolePermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRolePermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<DeleteRolePermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Deletes the permissions boundary for the specified IAM role. 
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the permissions boundary for a role might increase its permissions. For example,
        /// it might allow anyone who assumes the role to perform all the actions granted in its
        /// permissions policies. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePermissionsBoundary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRolePermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To detach a managed policy from
        /// a role, use <a>DetachRolePolicy</a>. For more information about policies, refer to
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        public virtual DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRolePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To detach a managed policy from
        /// a role, use <a>DetachRolePolicy</a>. For more information about policies, refer to
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Deletes a SAML provider resource in IAM.
        /// 
        ///  
        /// <para>
        /// Deleting the provider resource from IAM does not update any roles that reference the
        /// SAML provider resource's ARN as a principal in their trust policies. Any attempt to
        /// assume a role that references a non-existent provider resource ARN fails.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        public virtual DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteSAMLProviderResponse>(request, options);
        }


        /// <summary>
        /// Deletes a SAML provider resource in IAM.
        /// 
        ///  
        /// <para>
        /// Deleting the provider resource from IAM does not update any roles that reference the
        /// SAML provider resource's ARN as a principal in their trust policies. Any attempt to
        /// assume a role that references a non-existent provider resource ARN fails.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified server certificate.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        ///  <important> 
        /// <para>
        ///  If you are using a server certificate with Elastic Load Balancing, deleting the certificate
        /// could have implications for your application. If Elastic Load Balancing doesn't detect
        /// the deletion of bound certificates, it may continue to use the certificates. This
        /// could cause Elastic Load Balancing to stop accepting traffic. We recommend that you
        /// remove the reference to the certificate from Elastic Load Balancing before using this
        /// command to delete the certificate. For more information, go to <a href="https://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html">DeleteLoadBalancerListeners</a>
        /// in the <i>Elastic Load Balancing API Reference</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        public virtual DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteServerCertificateResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified server certificate.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        ///  <important> 
        /// <para>
        ///  If you are using a server certificate with Elastic Load Balancing, deleting the certificate
        /// could have implications for your application. If Elastic Load Balancing doesn't detect
        /// the deletion of bound certificates, it may continue to use the certificates. This
        /// could cause Elastic Load Balancing to stop accepting traffic. We recommend that you
        /// remove the reference to the certificate from Elastic Load Balancing before using this
        /// command to delete the certificate. For more information, go to <a href="https://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html">DeleteLoadBalancerListeners</a>
        /// in the <i>Elastic Load Balancing API Reference</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Submits a service-linked role deletion request and returns a <code>DeletionTaskId</code>,
        /// which you can use to check the status of the deletion. Before you call this operation,
        /// confirm that the role has no active sessions and that any resources used by the role
        /// in the linked service are deleted. If you call this operation more than once for the
        /// same service-linked role and an earlier deletion task is not complete, then the <code>DeletionTaskId</code>
        /// of the earlier request is returned.
        /// 
        ///  
        /// <para>
        /// If you submit a deletion request for a service-linked role whose linked service is
        /// still accessing a resource, then the deletion task fails. If it fails, the <a>GetServiceLinkedRoleDeletionStatus</a>
        /// API operation returns the reason for the failure, usually including the resources
        /// that must be deleted. To delete the service-linked role, you must first remove those
        /// resources from the linked service and then submit the deletion request again. Resources
        /// are specific to the service that is linked to the role. For more information about
        /// removing resources from a service, see the <a href="http://docs.aws.amazon.com/">AWS
        /// documentation</a> for your service.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-linked roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html#iam-term-service-linked-role">Roles
        /// Terms and Concepts: AWS Service-Linked Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceLinkedRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        public virtual DeleteServiceLinkedRoleResponse DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceLinkedRoleResponse>(request, options);
        }


        /// <summary>
        /// Submits a service-linked role deletion request and returns a <code>DeletionTaskId</code>,
        /// which you can use to check the status of the deletion. Before you call this operation,
        /// confirm that the role has no active sessions and that any resources used by the role
        /// in the linked service are deleted. If you call this operation more than once for the
        /// same service-linked role and an earlier deletion task is not complete, then the <code>DeletionTaskId</code>
        /// of the earlier request is returned.
        /// 
        ///  
        /// <para>
        /// If you submit a deletion request for a service-linked role whose linked service is
        /// still accessing a resource, then the deletion task fails. If it fails, the <a>GetServiceLinkedRoleDeletionStatus</a>
        /// API operation returns the reason for the failure, usually including the resources
        /// that must be deleted. To delete the service-linked role, you must first remove those
        /// resources from the linked service and then submit the deletion request again. Resources
        /// are specific to the service that is linked to the role. For more information about
        /// removing resources from a service, see the <a href="http://docs.aws.amazon.com/">AWS
        /// documentation</a> for your service.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-linked roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html#iam-term-service-linked-role">Roles
        /// Terms and Concepts: AWS Service-Linked Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceLinkedRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified service-specific credential.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        public virtual DeleteServiceSpecificCredentialResponse DeleteServiceSpecificCredential(DeleteServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceSpecificCredentialResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified service-specific credential.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Deletes a signing certificate associated with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. This operation works for access keys under
        /// the AWS account. Consequently, you can use this operation to manage AWS account root
        /// user credentials even if the AWS account has no associated IAM users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        public virtual DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteSigningCertificateResponse>(request, options);
        }


        /// <summary>
        /// Deletes a signing certificate associated with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. This operation works for access keys under
        /// the AWS account. Consequently, you can use this operation to manage AWS account root
        /// user credentials even if the AWS account has no associated IAM users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified SSH public key.
        /// 
        ///  
        /// <para>
        /// The SSH public key deleted by this operation is used only for authenticating the associated
        /// IAM user to an AWS CodeCommit repository. For more information about using SSH keys
        /// to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the DeleteSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        public virtual DeleteSSHPublicKeyResponse DeleteSSHPublicKey(DeleteSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteSSHPublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified SSH public key.
        /// 
        ///  
        /// <para>
        /// The SSH public key deleted by this operation is used only for authenticating the associated
        /// IAM user to an AWS CodeCommit repository. For more information about using SSH keys
        /// to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified IAM user. Unlike the AWS Management Console, when you delete
        /// a user programmatically, you must delete the items attached to the user manually,
        /// or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_deleting_cli">Deleting
        /// an IAM User</a>. Before attempting to delete a user, remove the following items:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Password (<a>DeleteLoginProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Access keys (<a>DeleteAccessKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signing certificate (<a>DeleteSigningCertificate</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSH public key (<a>DeleteSSHPublicKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Git credentials (<a>DeleteServiceSpecificCredential</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-factor authentication (MFA) device (<a>DeactivateMFADevice</a>, <a>DeleteVirtualMFADevice</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inline policies (<a>DeleteUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a>DetachUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Group memberships (<a>RemoveUserFromGroup</a>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified IAM user. Unlike the AWS Management Console, when you delete
        /// a user programmatically, you must delete the items attached to the user manually,
        /// or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_deleting_cli">Deleting
        /// an IAM User</a>. Before attempting to delete a user, remove the following items:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Password (<a>DeleteLoginProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Access keys (<a>DeleteAccessKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signing certificate (<a>DeleteSigningCertificate</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSH public key (<a>DeleteSSHPublicKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Git credentials (<a>DeleteServiceSpecificCredential</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-factor authentication (MFA) device (<a>DeactivateMFADevice</a>, <a>DeleteVirtualMFADevice</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inline policies (<a>DeleteUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a>DetachUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Group memberships (<a>RemoveUserFromGroup</a>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the permissions boundary for the specified IAM user.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the permissions boundary for a user might increase its permissions by allowing
        /// the user to perform all the actions granted in its permissions policies. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPermissionsBoundary">REST API Reference for DeleteUserPermissionsBoundary Operation</seealso>
        public virtual DeleteUserPermissionsBoundaryResponse DeleteUserPermissionsBoundary(DeleteUserPermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Deletes the permissions boundary for the specified IAM user.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the permissions boundary for a user might increase its permissions by allowing
        /// the user to perform all the actions granted in its permissions policies. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPermissionsBoundary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserPermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To detach a managed policy from
        /// a user, use <a>DetachUserPolicy</a>. For more information about policies, refer to
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        public virtual DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To detach a managed policy from
        /// a user, use <a>DetachUserPolicy</a>. For more information about policies, refer to
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        ///  <note> 
        /// <para>
        ///  You must deactivate a user's virtual MFA device before you can delete it. For information
        /// about deactivating MFA devices, see <a>DeactivateMFADevice</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        public virtual DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualMFADeviceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        ///  <note> 
        /// <para>
        ///  You must deactivate a user's virtual MFA device before you can delete it. For information
        /// about deactivating MFA devices, see <a>DeactivateMFADevice</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Removes the specified managed policy from the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteGroupPolicy</a> API. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        public virtual DetachGroupPolicyResponse DetachGroupPolicy(DetachGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachGroupPolicyResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified managed policy from the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteGroupPolicy</a> API. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Removes the specified managed policy from the specified role.
        /// 
        ///  
        /// <para>
        /// A role can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteRolePolicy</a> API. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DetachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        public virtual DetachRolePolicyResponse DetachRolePolicy(DetachRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DetachRolePolicyResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified managed policy from the specified role.
        /// 
        ///  
        /// <para>
        /// A role can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteRolePolicy</a> API. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Removes the specified managed policy from the specified user.
        /// 
        ///  
        /// <para>
        /// A user can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteUserPolicy</a> API. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        public virtual DetachUserPolicyResponse DetachUserPolicy(DetachUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachUserPolicyResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified managed policy from the specified user.
        /// 
        ///  
        /// <para>
        /// A user can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteUserPolicy</a> API. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Enables the specified MFA device and associates it with the specified IAM user. When
        /// enabled, the MFA device is required for every subsequent login by the IAM user associated
        /// with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        public virtual EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return Invoke<EnableMFADeviceResponse>(request, options);
        }


        /// <summary>
        /// Enables the specified MFA device and associates it with the specified IAM user. When
        /// enabled, the MFA device is required for every subsequent login by the IAM user associated
        /// with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        public virtual GenerateCredentialReportResponse GenerateCredentialReport()
        {
            return GenerateCredentialReport(new GenerateCredentialReportRequest());
        }


        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        public virtual GenerateCredentialReportResponse GenerateCredentialReport(GenerateCredentialReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GenerateCredentialReportResponse>(request, options);
        }


        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        public virtual Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(GenerateCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateCredentialReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateOrganizationsAccessReport


        /// <summary>
        /// Generates a report for service last accessed data for AWS Organizations. You can generate
        /// a report for any entities (organization root, organizational unit, or account) or
        /// policies in your organization.
        /// 
        ///  
        /// <para>
        /// To call this operation, you must be signed in using your AWS Organizations master
        /// account credentials. You can use your long-term IAM user or root user credentials,
        /// or temporary credentials from assuming an IAM role. SCPs must be enabled for your
        /// organization root. You must have the required IAM and AWS Organizations permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Refining
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can generate a service last accessed data report for entities by specifying only
        /// the entity's path. This data includes a list of services that are allowed by any service
        /// control policies (SCPs) that apply to the entity.
        /// </para>
        ///  
        /// <para>
        /// You can generate a service last accessed data report for a policy by specifying an
        /// entity's path and an optional AWS Organizations policy ID. This data includes a list
        /// of services that are allowed by the specified SCP.
        /// </para>
        ///  
        /// <para>
        /// For each service in both report types, the data includes the most recent account activity
        /// that the policy allows to account principals in the entity or the entity's children.
        /// For important information about the data, reporting period, permissions required,
        /// troubleshooting, and supported Regions see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data includes all attempts to access AWS, not just the successful ones. This includes
        /// all attempts that were made using the AWS Management Console, the AWS API through
        /// any of the SDKs, or any of the command line tools. An unexpected entry in the service
        /// last accessed data does not mean that an account has been compromised, because the
        /// request might have been denied. Refer to your CloudTrail logs as the authoritative
        /// source for information about all API calls and whether they were successful or denied
        /// access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
        /// IAM Events with CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// This operation returns a <code>JobId</code>. Use this parameter in the <code> <a>GetOrganizationsAccessReport</a>
        /// </code> operation to check the status of the report generation. To check the status
        /// of this request, use the <code>JobId</code> parameter in the <code> <a>GetOrganizationsAccessReport</a>
        /// </code> operation and test the <code>JobStatus</code> response parameter. When the
        /// job is complete, you can retrieve the report.
        /// </para>
        ///  
        /// <para>
        /// To generate a service last accessed data report for entities, specify an entity path
        /// without specifying the optional AWS Organizations policy ID. The type of entity that
        /// you specify determines the data returned in the report.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> – When you specify the organizations root as the entity, the resulting
        /// report lists all of the services allowed by SCPs that are attached to your root. For
        /// each service, the report includes data for all accounts in your organization except
        /// the master account, because the master account is not limited by SCPs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OU</b> – When you specify an organizational unit (OU) as the entity, the resulting
        /// report lists all of the services allowed by SCPs that are attached to the OU and its
        /// parents. For each service, the report includes data for all accounts in the OU or
        /// its children. This data excludes the master account, because the master account is
        /// not limited by SCPs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Master account</b> – When you specify the master account, the resulting report
        /// lists all AWS services, because the master account is not limited by SCPs. For each
        /// service, the report includes data for only the master account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> – When you specify another account as the entity, the resulting report
        /// lists all of the services allowed by SCPs that are attached to the account and its
        /// parents. For each service, the report includes data for only the specified account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To generate a service last accessed data report for policies, specify an entity path
        /// and the optional AWS Organizations policy ID. The type of entity that you specify
        /// determines the data returned for each service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> – When you specify the root entity and a policy ID, the resulting report
        /// lists all of the services that are allowed by the specified SCP. For each service,
        /// the report includes data for all accounts in your organization to which the SCP applies.
        /// This data excludes the master account, because the master account is not limited by
        /// SCPs. If the SCP is not attached to any entities in the organization, then the report
        /// will return a list of services with no data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OU</b> – When you specify an OU entity and a policy ID, the resulting report lists
        /// all of the services that are allowed by the specified SCP. For each service, the report
        /// includes data for all accounts in the OU or its children to which the SCP applies.
        /// This means that other accounts outside the OU that are affected by the SCP might not
        /// be included in the data. This data excludes the master account, because the master
        /// account is not limited by SCPs. If the SCP is not attached to the OU or one of its
        /// children, the report will return a list of services with no data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Master account</b> – When you specify the master account, the resulting report
        /// lists all AWS services, because the master account is not limited by SCPs. If you
        /// specify a policy ID in the CLI or API, the policy is ignored. For each service, the
        /// report includes data for only the master account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> – When you specify another account entity and a policy ID, the resulting
        /// report lists all of the services that are allowed by the specified SCP. For each service,
        /// the report includes data for only the specified account. This means that other accounts
        /// in the organization that are affected by the SCP might not be included in the data.
        /// If the SCP is not attached to the account, the report will return a list of services
        /// with no data.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a principal could access a service. These other policy types include identity-based
        /// policies, resource-based policies, access control lists, IAM permissions boundaries,
        /// and STS assume role policies. It only applies SCP logic. For more about the evaluation
        /// of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about service last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Policy Scope by Viewing User Activity</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateOrganizationsAccessReport service method.</param>
        /// 
        /// <returns>The response from the GenerateOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ReportGenerationLimitExceededException">
        /// The request failed because the maximum number of concurrent requests for this account
        /// are already running.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateOrganizationsAccessReport">REST API Reference for GenerateOrganizationsAccessReport Operation</seealso>
        public virtual GenerateOrganizationsAccessReportResponse GenerateOrganizationsAccessReport(GenerateOrganizationsAccessReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateOrganizationsAccessReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateOrganizationsAccessReportResponseUnmarshaller.Instance;

            return Invoke<GenerateOrganizationsAccessReportResponse>(request, options);
        }


        /// <summary>
        /// Generates a report for service last accessed data for AWS Organizations. You can generate
        /// a report for any entities (organization root, organizational unit, or account) or
        /// policies in your organization.
        /// 
        ///  
        /// <para>
        /// To call this operation, you must be signed in using your AWS Organizations master
        /// account credentials. You can use your long-term IAM user or root user credentials,
        /// or temporary credentials from assuming an IAM role. SCPs must be enabled for your
        /// organization root. You must have the required IAM and AWS Organizations permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Refining
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can generate a service last accessed data report for entities by specifying only
        /// the entity's path. This data includes a list of services that are allowed by any service
        /// control policies (SCPs) that apply to the entity.
        /// </para>
        ///  
        /// <para>
        /// You can generate a service last accessed data report for a policy by specifying an
        /// entity's path and an optional AWS Organizations policy ID. This data includes a list
        /// of services that are allowed by the specified SCP.
        /// </para>
        ///  
        /// <para>
        /// For each service in both report types, the data includes the most recent account activity
        /// that the policy allows to account principals in the entity or the entity's children.
        /// For important information about the data, reporting period, permissions required,
        /// troubleshooting, and supported Regions see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data includes all attempts to access AWS, not just the successful ones. This includes
        /// all attempts that were made using the AWS Management Console, the AWS API through
        /// any of the SDKs, or any of the command line tools. An unexpected entry in the service
        /// last accessed data does not mean that an account has been compromised, because the
        /// request might have been denied. Refer to your CloudTrail logs as the authoritative
        /// source for information about all API calls and whether they were successful or denied
        /// access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
        /// IAM Events with CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// This operation returns a <code>JobId</code>. Use this parameter in the <code> <a>GetOrganizationsAccessReport</a>
        /// </code> operation to check the status of the report generation. To check the status
        /// of this request, use the <code>JobId</code> parameter in the <code> <a>GetOrganizationsAccessReport</a>
        /// </code> operation and test the <code>JobStatus</code> response parameter. When the
        /// job is complete, you can retrieve the report.
        /// </para>
        ///  
        /// <para>
        /// To generate a service last accessed data report for entities, specify an entity path
        /// without specifying the optional AWS Organizations policy ID. The type of entity that
        /// you specify determines the data returned in the report.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> – When you specify the organizations root as the entity, the resulting
        /// report lists all of the services allowed by SCPs that are attached to your root. For
        /// each service, the report includes data for all accounts in your organization except
        /// the master account, because the master account is not limited by SCPs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OU</b> – When you specify an organizational unit (OU) as the entity, the resulting
        /// report lists all of the services allowed by SCPs that are attached to the OU and its
        /// parents. For each service, the report includes data for all accounts in the OU or
        /// its children. This data excludes the master account, because the master account is
        /// not limited by SCPs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Master account</b> – When you specify the master account, the resulting report
        /// lists all AWS services, because the master account is not limited by SCPs. For each
        /// service, the report includes data for only the master account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> – When you specify another account as the entity, the resulting report
        /// lists all of the services allowed by SCPs that are attached to the account and its
        /// parents. For each service, the report includes data for only the specified account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To generate a service last accessed data report for policies, specify an entity path
        /// and the optional AWS Organizations policy ID. The type of entity that you specify
        /// determines the data returned for each service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> – When you specify the root entity and a policy ID, the resulting report
        /// lists all of the services that are allowed by the specified SCP. For each service,
        /// the report includes data for all accounts in your organization to which the SCP applies.
        /// This data excludes the master account, because the master account is not limited by
        /// SCPs. If the SCP is not attached to any entities in the organization, then the report
        /// will return a list of services with no data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OU</b> – When you specify an OU entity and a policy ID, the resulting report lists
        /// all of the services that are allowed by the specified SCP. For each service, the report
        /// includes data for all accounts in the OU or its children to which the SCP applies.
        /// This means that other accounts outside the OU that are affected by the SCP might not
        /// be included in the data. This data excludes the master account, because the master
        /// account is not limited by SCPs. If the SCP is not attached to the OU or one of its
        /// children, the report will return a list of services with no data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Master account</b> – When you specify the master account, the resulting report
        /// lists all AWS services, because the master account is not limited by SCPs. If you
        /// specify a policy ID in the CLI or API, the policy is ignored. For each service, the
        /// report includes data for only the master account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> – When you specify another account entity and a policy ID, the resulting
        /// report lists all of the services that are allowed by the specified SCP. For each service,
        /// the report includes data for only the specified account. This means that other accounts
        /// in the organization that are affected by the SCP might not be included in the data.
        /// If the SCP is not attached to the account, the report will return a list of services
        /// with no data.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a principal could access a service. These other policy types include identity-based
        /// policies, resource-based policies, access control lists, IAM permissions boundaries,
        /// and STS assume role policies. It only applies SCP logic. For more about the evaluation
        /// of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about service last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Policy Scope by Viewing User Activity</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateOrganizationsAccessReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ReportGenerationLimitExceededException">
        /// The request failed because the maximum number of concurrent requests for this account
        /// are already running.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateOrganizationsAccessReport">REST API Reference for GenerateOrganizationsAccessReport Operation</seealso>
        public virtual Task<GenerateOrganizationsAccessReportResponse> GenerateOrganizationsAccessReportAsync(GenerateOrganizationsAccessReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateOrganizationsAccessReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateOrganizationsAccessReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateOrganizationsAccessReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateServiceLastAccessedDetails


        /// <summary>
        /// Generates a report that includes details about when an IAM resource (user, group,
        /// role, or policy) was last used in an attempt to access AWS services. Recent activity
        /// usually appears within four hours. IAM reports activity for the last 365 days, or
        /// less if your Region began supporting this feature within the last year. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
        /// Where Data Is Tracked</a>.
        /// 
        ///  <important> 
        /// <para>
        /// The service last accessed data includes all attempts to access an AWS API, not just
        /// the successful ones. This includes all attempts that were made using the AWS Management
        /// Console, the AWS API through any of the SDKs, or any of the command line tools. An
        /// unexpected entry in the service last accessed data does not mean that your account
        /// has been compromised, because the request might have been denied. Refer to your CloudTrail
        /// logs as the authoritative source for information about all API calls and whether they
        /// were successful or denied access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
        /// IAM Events with CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The <code>GenerateServiceLastAccessedDetails</code> operation returns a <code>JobId</code>.
        /// Use this parameter in the following operations to retrieve the following details from
        /// your report: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetServiceLastAccessedDetails</a> – Use this operation for users, groups, roles,
        /// or policies to list every AWS service that the resource could access using permissions
        /// policies. For each service, the response includes information about the most recent
        /// access attempt.
        /// </para>
        ///  
        /// <para>
        /// The <code>JobId</code> returned by <code>GenerateServiceLastAccessedDetail</code>
        /// must be used by the same role within a session, or by the same user when used to call
        /// <code>GetServiceLastAccessedDetail</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetServiceLastAccessedDetailsWithEntities</a> – Use this operation for groups
        /// and policies to list information about the associated entities (users or roles) that
        /// attempted to access a specific AWS service. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To check the status of the <code>GenerateServiceLastAccessedDetails</code> request,
        /// use the <code>JobId</code> parameter in the same operations and test the <code>JobStatus</code>
        /// response parameter.
        /// </para>
        ///  
        /// <para>
        /// For additional information about the permissions policies that allow an identity (user,
        /// group, or role) to access specific services, use the <a>ListPoliciesGrantingServiceAccess</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a resource could access a service. These other policy types include resource-based
        /// policies, access control lists, AWS Organizations policies, IAM permissions boundaries,
        /// and AWS STS assume role policies. It only applies permissions policy logic. For more
        /// about the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateServiceLastAccessedDetails service method.</param>
        /// 
        /// <returns>The response from the GenerateServiceLastAccessedDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateServiceLastAccessedDetails">REST API Reference for GenerateServiceLastAccessedDetails Operation</seealso>
        public virtual GenerateServiceLastAccessedDetailsResponse GenerateServiceLastAccessedDetails(GenerateServiceLastAccessedDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateServiceLastAccessedDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateServiceLastAccessedDetailsResponseUnmarshaller.Instance;

            return Invoke<GenerateServiceLastAccessedDetailsResponse>(request, options);
        }


        /// <summary>
        /// Generates a report that includes details about when an IAM resource (user, group,
        /// role, or policy) was last used in an attempt to access AWS services. Recent activity
        /// usually appears within four hours. IAM reports activity for the last 365 days, or
        /// less if your Region began supporting this feature within the last year. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
        /// Where Data Is Tracked</a>.
        /// 
        ///  <important> 
        /// <para>
        /// The service last accessed data includes all attempts to access an AWS API, not just
        /// the successful ones. This includes all attempts that were made using the AWS Management
        /// Console, the AWS API through any of the SDKs, or any of the command line tools. An
        /// unexpected entry in the service last accessed data does not mean that your account
        /// has been compromised, because the request might have been denied. Refer to your CloudTrail
        /// logs as the authoritative source for information about all API calls and whether they
        /// were successful or denied access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
        /// IAM Events with CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The <code>GenerateServiceLastAccessedDetails</code> operation returns a <code>JobId</code>.
        /// Use this parameter in the following operations to retrieve the following details from
        /// your report: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetServiceLastAccessedDetails</a> – Use this operation for users, groups, roles,
        /// or policies to list every AWS service that the resource could access using permissions
        /// policies. For each service, the response includes information about the most recent
        /// access attempt.
        /// </para>
        ///  
        /// <para>
        /// The <code>JobId</code> returned by <code>GenerateServiceLastAccessedDetail</code>
        /// must be used by the same role within a session, or by the same user when used to call
        /// <code>GetServiceLastAccessedDetail</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetServiceLastAccessedDetailsWithEntities</a> – Use this operation for groups
        /// and policies to list information about the associated entities (users or roles) that
        /// attempted to access a specific AWS service. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To check the status of the <code>GenerateServiceLastAccessedDetails</code> request,
        /// use the <code>JobId</code> parameter in the same operations and test the <code>JobStatus</code>
        /// response parameter.
        /// </para>
        ///  
        /// <para>
        /// For additional information about the permissions policies that allow an identity (user,
        /// group, or role) to access specific services, use the <a>ListPoliciesGrantingServiceAccess</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a resource could access a service. These other policy types include resource-based
        /// policies, access control lists, AWS Organizations policies, IAM permissions boundaries,
        /// and AWS STS assume role policies. It only applies permissions policy logic. For more
        /// about the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateServiceLastAccessedDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateServiceLastAccessedDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Retrieves information about when the specified access key was last used. The information
        /// includes the date and time of last use, along with the AWS service and Region that
        /// were specified in the last request made with that key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed service method.</param>
        /// 
        /// <returns>The response from the GetAccessKeyLastUsed service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        public virtual GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessKeyLastUsedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;

            return Invoke<GetAccessKeyLastUsedResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about when the specified access key was last used. The information
        /// includes the date and time of last use, along with the AWS service and Region that
        /// were specified in the last request made with that key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessKeyLastUsed service method, as returned by IdentityManagementService.</returns>
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


        /// <summary>
        /// Retrieves information about all IAM users, groups, roles, and policies in your AWS
        /// account, including their relationships to one another. Use this API to obtain a snapshot
        /// of the configuration of IAM permissions (users, groups, roles, and policies) in your
        /// account.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally filter the results using the <code>Filter</code> parameter. You
        /// can paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails service method.</param>
        /// 
        /// <returns>The response from the GetAccountAuthorizationDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        public virtual GetAccountAuthorizationDetailsResponse GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountAuthorizationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetAccountAuthorizationDetailsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about all IAM users, groups, roles, and policies in your AWS
        /// account, including their relationships to one another. Use this API to obtain a snapshot
        /// of the configuration of IAM permissions (users, groups, roles, and policies) in your
        /// account.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally filter the results using the <code>Filter</code> parameter. You
        /// can paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountAuthorizationDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a>.
        /// </summary>
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
        public virtual GetAccountPasswordPolicyResponse GetAccountPasswordPolicy()
        {
            return GetAccountPasswordPolicy(new GetAccountPasswordPolicyRequest());
        }


        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method.</param>
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
        public virtual GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAccountPasswordPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
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
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method.</param>
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
        public virtual Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccountPasswordPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSummary


        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the AWS account.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        public virtual GetAccountSummaryResponse GetAccountSummary()
        {
            return GetAccountSummary(new GetAccountSummaryRequest());
        }


        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the AWS account.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary service method.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        public virtual GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request)
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
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
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
        /// Retrieves information about IAM entity usage and IAM quotas in the AWS account.
        /// 
        ///  
        /// <para>
        /// The number and size of IAM resources in an AWS account are limited. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS Quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// <param name="policyInputList">A list of policies for which you want the list of context keys referenced in those policies. Each document is specified as a string containing the complete, valid JSON text of an IAM policy. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        public virtual GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(List<string> policyInputList)
        {
            var request = new GetContextKeysForCustomPolicyRequest();
            request.PolicyInputList = policyInputList;
            return GetContextKeysForCustomPolicy(request);
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
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        public virtual GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(GetContextKeysForCustomPolicyRequest request)
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
        /// <param name="policyInputList">A list of policies for which you want the list of context keys referenced in those policies. Each document is specified as a string containing the complete, valid JSON text of an IAM policy. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
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
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy service method.</param>
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
        public virtual Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(GetContextKeysForCustomPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContextKeysForCustomPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetContextKeysForCustomPolicyResponse>(request, options, cancellationToken);
        }

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
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
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
        public virtual GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(string policySourceArn)
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            return GetContextKeysForPrincipalPolicy(request);
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
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
        /// <param name="policyInputList">An optional list of additional policies for which you want the list of context keys that are referenced. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
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
        public virtual GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(string policySourceArn, List<string> policyInputList)
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            request.PolicyInputList = policyInputList;
            return GetContextKeysForPrincipalPolicy(request);
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
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy service method.</param>
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
        public virtual GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(GetContextKeysForPrincipalPolicyRequest request)
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
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
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
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
        /// <param name="policyInputList">An optional list of additional policies for which you want the list of context keys that are referenced. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
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
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy service method.</param>
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
        public virtual Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(GetContextKeysForPrincipalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContextKeysForPrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetContextKeysForPrincipalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCredentialReport


        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
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
        public virtual GetCredentialReportResponse GetCredentialReport()
        {
            return GetCredentialReport(new GetCredentialReportRequest());
        }


        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
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
        public virtual GetCredentialReportResponse GetCredentialReport(GetCredentialReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GetCredentialReportResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
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
        /// about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
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
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
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
        public virtual Task<GetCredentialReportResponse> GetCredentialReportAsync(GetCredentialReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCredentialReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns a list of IAM users that are in the specified IAM group. You can paginate
        /// the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of IAM users that are in the specified IAM group. You can paginate
        /// the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM group can also have managed policies attached to it. To retrieve a managed
        /// policy document that is attached to a group, use <a>GetPolicy</a> to determine the
        /// policy's default version, then use <a>GetPolicyVersion</a> to retrieve the policy
        /// document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        public virtual GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetGroupPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM group can also have managed policies attached to it. To retrieve a managed
        /// policy document that is attached to a group, use <a>GetPolicy</a> to determine the
        /// policy's default version, then use <a>GetPolicyVersion</a> to retrieve the policy
        /// document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's path, GUID, ARN, and role. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        public virtual GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's path, GUID, ARN, and role. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves the user name and password-creation date for the specified IAM user. If
        /// the user has not been assigned a password, the operation returns a 404 (<code>NoSuchEntity</code>)
        /// error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile service method.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        public virtual GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return Invoke<GetLoginProfileResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the user name and password-creation date for the specified IAM user. If
        /// the user has not been assigned a password, the operation returns a 404 (<code>NoSuchEntity</code>)
        /// error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Returns information about the specified OpenID Connect (OIDC) provider resource object
        /// in IAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the GetOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        public virtual GetOpenIDConnectProviderResponse GetOpenIDConnectProvider(GetOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<GetOpenIDConnectProviderResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified OpenID Connect (OIDC) provider resource object
        /// in IAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        public virtual Task<GetOpenIDConnectProviderResponse> GetOpenIDConnectProviderAsync(GetOpenIDConnectProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOpenIDConnectProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOrganizationsAccessReport


        /// <summary>
        /// Retrieves the service last accessed data report for AWS Organizations that was previously
        /// generated using the <code> <a>GenerateOrganizationsAccessReport</a> </code> operation.
        /// This operation retrieves the status of your report job and the report contents.
        /// 
        ///  
        /// <para>
        /// Depending on the parameters that you passed when you generated the report, the data
        /// returned could include different information. For details, see <a>GenerateOrganizationsAccessReport</a>.
        /// </para>
        ///  
        /// <para>
        /// To call this operation, you must be signed in to the master account in your organization.
        /// SCPs must be enabled for your organization root. You must have permissions to perform
        /// this operation. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Refining
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For each service that principals in an account (root users, IAM users, or IAM roles)
        /// could access using SCPs, the operation returns details about the most recent access
        /// attempt. If there was no attempt, the service is listed without details about the
        /// most recent attempt to access the service. If the operation fails, it returns the
        /// reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// By default, the list is sorted by service namespace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationsAccessReport service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOrganizationsAccessReport">REST API Reference for GetOrganizationsAccessReport Operation</seealso>
        public virtual GetOrganizationsAccessReportResponse GetOrganizationsAccessReport(GetOrganizationsAccessReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationsAccessReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationsAccessReportResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationsAccessReportResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the service last accessed data report for AWS Organizations that was previously
        /// generated using the <code> <a>GenerateOrganizationsAccessReport</a> </code> operation.
        /// This operation retrieves the status of your report job and the report contents.
        /// 
        ///  
        /// <para>
        /// Depending on the parameters that you passed when you generated the report, the data
        /// returned could include different information. For details, see <a>GenerateOrganizationsAccessReport</a>.
        /// </para>
        ///  
        /// <para>
        /// To call this operation, you must be signed in to the master account in your organization.
        /// SCPs must be enabled for your organization root. You must have permissions to perform
        /// this operation. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Refining
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For each service that principals in an account (root users, IAM users, or IAM roles)
        /// could access using SCPs, the operation returns details about the most recent access
        /// attempt. If there was no attempt, the service is listed without details about the
        /// most recent attempt to access the service. If the operation fails, it returns the
        /// reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// By default, the list is sorted by service namespace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationsAccessReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOrganizationsAccessReport">REST API Reference for GetOrganizationsAccessReport Operation</seealso>
        public virtual Task<GetOrganizationsAccessReportResponse> GetOrganizationsAccessReportAsync(GetOrganizationsAccessReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationsAccessReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationsAccessReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOrganizationsAccessReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves information about the specified managed policy, including the policy's default
        /// version and the total number of IAM users, groups, and roles to which the policy is
        /// attached. To retrieve the list of the specific users, groups, and roles that the policy
        /// is attached to, use the <a>ListEntitiesForPolicy</a> API. This API returns metadata
        /// about the policy. To retrieve the actual policy document for a specific version of
        /// the policy, use <a>GetPolicyVersion</a>.
        /// 
        ///  
        /// <para>
        /// This API retrieves information about managed policies. To retrieve information about
        /// an inline policy that is embedded with an IAM user, group, or role, use the <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified managed policy, including the policy's default
        /// version and the total number of IAM users, groups, and roles to which the policy is
        /// attached. To retrieve the list of the specific users, groups, and roles that the policy
        /// is attached to, use the <a>ListEntitiesForPolicy</a> API. This API returns metadata
        /// about the policy. To retrieve the actual policy document for a specific version of
        /// the policy, use <a>GetPolicyVersion</a>.
        /// 
        ///  
        /// <para>
        /// This API retrieves information about managed policies. To retrieve information about
        /// an inline policy that is embedded with an IAM user, group, or role, use the <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves information about the specified version of the specified managed policy,
        /// including the policy document.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// To list the available versions for a policy, use <a>ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// This API retrieves information about managed policies. To retrieve information about
        /// an inline policy that is embedded in a user, group, or role, use the <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API.
        /// </para>
        ///  
        /// <para>
        /// For more information about the types of policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<GetPolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified version of the specified managed policy,
        /// including the policy document.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// To list the available versions for a policy, use <a>ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// This API retrieves information about managed policies. To retrieve information about
        /// an inline policy that is embedded in a user, group, or role, use the <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API.
        /// </para>
        ///  
        /// <para>
        /// For more information about the types of policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the role's trust policy that grants permission to assume the role. For more information
        /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRole service method.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        public virtual GetRoleResponse GetRole(GetRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoleResponseUnmarshaller.Instance;

            return Invoke<GetRoleResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the role's trust policy that grants permission to assume the role. For more information
        /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded with the specified
        /// IAM role.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM role can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a role, use <a>GetPolicy</a> to determine the policy's
        /// default version, then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy service method.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        public virtual GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return Invoke<GetRolePolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded with the specified
        /// IAM role.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM role can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a role, use <a>GetPolicy</a> to determine the policy's
        /// default version, then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Returns the SAML provider metadocument that was uploaded when the IAM SAML provider
        /// resource object was created or updated.
        /// 
        ///  <note> 
        /// <para>
        /// This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        public virtual GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<GetSAMLProviderResponse>(request, options);
        }


        /// <summary>
        /// Returns the SAML provider metadocument that was uploaded when the IAM SAML provider
        /// resource object was created or updated.
        /// 
        ///  <note> 
        /// <para>
        /// This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves information about the specified server certificate stored in IAM.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic includes a list
        /// of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate service method.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        public virtual GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return Invoke<GetServerCertificateResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified server certificate stored in IAM.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic includes a list
        /// of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves a service last accessed report that was created using the <code>GenerateServiceLastAccessedDetails</code>
        /// operation. You can use the <code>JobId</code> parameter in <code>GetServiceLastAccessedDetails</code>
        /// to retrieve the status of your report job. When the report is complete, you can retrieve
        /// the generated report. The report includes a list of AWS services that the resource
        /// (user, group, role, or managed policy) can access.
        /// 
        ///  <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a resource could access a service. These other policy types include resource-based
        /// policies, access control lists, AWS Organizations policies, IAM permissions boundaries,
        /// and AWS STS assume role policies. It only applies permissions policy logic. For more
        /// about the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For each service that the resource could access using permissions policies, the operation
        /// returns details about the most recent access attempt. If there was no attempt, the
        /// service is listed without details about the most recent attempt to access the service.
        /// If the operation fails, the <code>GetServiceLastAccessedDetails</code> operation returns
        /// the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetServiceLastAccessedDetails</code> operation returns a list of services.
        /// This list includes the number of entities that have attempted to access the service
        /// and the date and time of the last attempt. It also returns the ARN of the following
        /// entity, depending on the resource ARN that you used to generate the report:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>User</b> – Returns the user ARN that you used to generate the report
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b> – Returns the ARN of the group member (user) that last attempted to
        /// access the service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Role</b> – Returns the role ARN that you used to generate the report
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy</b> – Returns the ARN of the user or role that last used the policy to
        /// attempt to access the service
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, the list is sorted by service namespace.
        /// </para>
        ///  
        /// <para>
        /// If you specified <code>ACTION_LEVEL</code> granularity when you generated the report,
        /// this operation returns service and action last accessed data. This includes the most
        /// recent access attempt for each tracked action within a service. Otherwise, this operation
        /// returns only service data.
        /// </para>
        ///  
        /// <para>
        /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetails service method.</param>
        /// 
        /// <returns>The response from the GetServiceLastAccessedDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetails">REST API Reference for GetServiceLastAccessedDetails Operation</seealso>
        public virtual GetServiceLastAccessedDetailsResponse GetServiceLastAccessedDetails(GetServiceLastAccessedDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLastAccessedDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLastAccessedDetailsResponseUnmarshaller.Instance;

            return Invoke<GetServiceLastAccessedDetailsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a service last accessed report that was created using the <code>GenerateServiceLastAccessedDetails</code>
        /// operation. You can use the <code>JobId</code> parameter in <code>GetServiceLastAccessedDetails</code>
        /// to retrieve the status of your report job. When the report is complete, you can retrieve
        /// the generated report. The report includes a list of AWS services that the resource
        /// (user, group, role, or managed policy) can access.
        /// 
        ///  <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a resource could access a service. These other policy types include resource-based
        /// policies, access control lists, AWS Organizations policies, IAM permissions boundaries,
        /// and AWS STS assume role policies. It only applies permissions policy logic. For more
        /// about the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For each service that the resource could access using permissions policies, the operation
        /// returns details about the most recent access attempt. If there was no attempt, the
        /// service is listed without details about the most recent attempt to access the service.
        /// If the operation fails, the <code>GetServiceLastAccessedDetails</code> operation returns
        /// the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetServiceLastAccessedDetails</code> operation returns a list of services.
        /// This list includes the number of entities that have attempted to access the service
        /// and the date and time of the last attempt. It also returns the ARN of the following
        /// entity, depending on the resource ARN that you used to generate the report:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>User</b> – Returns the user ARN that you used to generate the report
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b> – Returns the ARN of the group member (user) that last attempted to
        /// access the service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Role</b> – Returns the role ARN that you used to generate the report
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy</b> – Returns the ARN of the user or role that last used the policy to
        /// attempt to access the service
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, the list is sorted by service namespace.
        /// </para>
        ///  
        /// <para>
        /// If you specified <code>ACTION_LEVEL</code> granularity when you generated the report,
        /// this operation returns service and action last accessed data. This includes the most
        /// recent access attempt for each tracked action within a service. Otherwise, this operation
        /// returns only service data.
        /// </para>
        ///  
        /// <para>
        /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceLastAccessedDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// After you generate a group or policy report using the <code>GenerateServiceLastAccessedDetails</code>
        /// operation, you can use the <code>JobId</code> parameter in <code>GetServiceLastAccessedDetailsWithEntities</code>.
        /// This operation retrieves the status of your report job and a list of entities that
        /// could have used group or policy permissions to access the specified service.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Group</b> – For a group report, this operation returns a list of users in the
        /// group that could have used the group’s policies in an attempt to access the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy</b> – For a policy report, this operation returns a list of entities (users
        /// or roles) that could have used the policy in an attempt to access the service.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also use this operation for user or role reports to retrieve details about
        /// those entities.
        /// </para>
        ///  
        /// <para>
        /// If the operation fails, the <code>GetServiceLastAccessedDetailsWithEntities</code>
        /// operation returns the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// By default, the list of associated entities is sorted by date, with the most recent
        /// access listed first.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetailsWithEntities service method.</param>
        /// 
        /// <returns>The response from the GetServiceLastAccessedDetailsWithEntities service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetailsWithEntities">REST API Reference for GetServiceLastAccessedDetailsWithEntities Operation</seealso>
        public virtual GetServiceLastAccessedDetailsWithEntitiesResponse GetServiceLastAccessedDetailsWithEntities(GetServiceLastAccessedDetailsWithEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLastAccessedDetailsWithEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLastAccessedDetailsWithEntitiesResponseUnmarshaller.Instance;

            return Invoke<GetServiceLastAccessedDetailsWithEntitiesResponse>(request, options);
        }


        /// <summary>
        /// After you generate a group or policy report using the <code>GenerateServiceLastAccessedDetails</code>
        /// operation, you can use the <code>JobId</code> parameter in <code>GetServiceLastAccessedDetailsWithEntities</code>.
        /// This operation retrieves the status of your report job and a list of entities that
        /// could have used group or policy permissions to access the specified service.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Group</b> – For a group report, this operation returns a list of users in the
        /// group that could have used the group’s policies in an attempt to access the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy</b> – For a policy report, this operation returns a list of entities (users
        /// or roles) that could have used the policy in an attempt to access the service.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also use this operation for user or role reports to retrieve details about
        /// those entities.
        /// </para>
        ///  
        /// <para>
        /// If the operation fails, the <code>GetServiceLastAccessedDetailsWithEntities</code>
        /// operation returns the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// By default, the list of associated entities is sorted by date, with the most recent
        /// access listed first.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetailsWithEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceLastAccessedDetailsWithEntities service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Retrieves the status of your service-linked role deletion. After you use the <a>DeleteServiceLinkedRole</a>
        /// API operation to submit a service-linked role for deletion, you can use the <code>DeletionTaskId</code>
        /// parameter in <code>GetServiceLinkedRoleDeletionStatus</code> to check the status of
        /// the deletion. If the deletion fails, this operation returns the reason that it failed,
        /// if that information is returned by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus service method.</param>
        /// 
        /// <returns>The response from the GetServiceLinkedRoleDeletionStatus service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLinkedRoleDeletionStatus">REST API Reference for GetServiceLinkedRoleDeletionStatus Operation</seealso>
        public virtual GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceLinkedRoleDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLinkedRoleDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<GetServiceLinkedRoleDeletionStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status of your service-linked role deletion. After you use the <a>DeleteServiceLinkedRole</a>
        /// API operation to submit a service-linked role for deletion, you can use the <code>DeletionTaskId</code>
        /// parameter in <code>GetServiceLinkedRoleDeletionStatus</code> to check the status of
        /// the deletion. If the deletion fails, this operation returns the reason that it failed,
        /// if that information is returned by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceLinkedRoleDeletionStatus service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves the specified SSH public key, including metadata about the key.
        /// 
        ///  
        /// <para>
        /// The SSH public key retrieved by this operation is used only for authenticating the
        /// associated IAM user to an AWS CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the GetSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        public virtual GetSSHPublicKeyResponse GetSSHPublicKey(GetSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetSSHPublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified SSH public key, including metadata about the key.
        /// 
        ///  
        /// <para>
        /// The SSH public key retrieved by this operation is used only for authenticating the
        /// associated IAM user to an AWS CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
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
        public virtual GetUserResponse GetUser()
        {
            return GetUser(new GetUserRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
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
        public virtual GetUserResponse GetUser(GetUserRequest request)
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
        /// Retrieves information about the specified IAM user, including the user's creation
        /// date, path, unique ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID used to sign the request to this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
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
        public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserPolicy


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// user.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM user can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a user, use <a>GetPolicy</a> to determine the policy's
        /// default version. Then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        public virtual GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return Invoke<GetUserPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// user.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM user can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a user, use <a>GetPolicy</a> to determine the policy's
        /// default version. Then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        public virtual ListAccessKeysResponse ListAccessKeys()
        {
            return ListAccessKeys(new ListAccessKeysRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
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
        public virtual ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
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
        public virtual Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessKeysResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountAliases


        /// <summary>
        /// Lists the account alias associated with the AWS account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        public virtual ListAccountAliasesResponse ListAccountAliases()
        {
            return ListAccountAliases(new ListAccountAliasesRequest());
        }


        /// <summary>
        /// Lists the account alias associated with the AWS account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases service method.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        public virtual ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAccountAliasesResponse>(request, options);
        }


        /// <summary>
        /// Lists the account alias associated with the AWS account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
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
        /// Lists the account alias associated with the AWS account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have inline policies embedded with it. To list the inline policies
        /// for a group, use the <a>ListGroupPolicies</a> API. For information about policies,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        public virtual ListAttachedGroupPoliciesResponse ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedGroupPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedGroupPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have inline policies embedded with it. To list the inline policies
        /// for a group, use the <a>ListGroupPolicies</a> API. For information about policies,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachedGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have inline policies embedded with it. To list the inline policies
        /// for a role, use the <a>ListRolePolicies</a> API. For information about policies, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified role (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        public virtual ListAttachedRolePoliciesResponse ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedRolePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedRolePoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have inline policies embedded with it. To list the inline policies
        /// for a role, use the <a>ListRolePolicies</a> API. For information about policies, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified role (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachedRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have inline policies embedded with it. To list the inline policies
        /// for a user, use the <a>ListUserPolicies</a> API. For information about policies, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        public virtual ListAttachedUserPoliciesResponse ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedUserPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedUserPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have inline policies embedded with it. To list the inline policies
        /// for a user, use the <a>ListUserPolicies</a> API. For information about policies, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachedUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists all IAM users, groups, and roles that the specified managed policy is attached
        /// to.
        /// 
        ///  
        /// <para>
        /// You can use the optional <code>EntityFilter</code> parameter to limit the results
        /// to a particular type of entity (users, groups, or roles). For example, to list only
        /// the roles that are attached to the specified policy, set <code>EntityFilter</code>
        /// to <code>Role</code>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy service method.</param>
        /// 
        /// <returns>The response from the ListEntitiesForPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        public virtual ListEntitiesForPolicyResponse ListEntitiesForPolicy(ListEntitiesForPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesForPolicyResponse>(request, options);
        }


        /// <summary>
        /// Lists all IAM users, groups, and roles that the specified managed policy is attached
        /// to.
        /// 
        ///  
        /// <para>
        /// You can use the optional <code>EntityFilter</code> parameter to limit the results
        /// to a particular type of entity (users, groups, or roles). For example, to list only
        /// the roles that are attached to the specified policy, set <code>EntityFilter</code>
        /// to <code>Role</code>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitiesForPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have managed policies attached to it. To list the managed policies
        /// that are attached to a group, use <a>ListAttachedGroupPolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified group, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        public virtual ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListGroupPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have managed policies attached to it. To list the managed policies
        /// that are attached to a group, use <a>ListAttachedGroupPolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified group, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups()
        {
            return ListGroups(new ListGroupsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
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
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the IAM groups that the specified IAM user belongs to.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser service method.</param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        public virtual ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<ListGroupsForUserResponse>(request, options);
        }


        /// <summary>
        /// Lists the IAM groups that the specified IAM user belongs to.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual ListInstanceProfilesResponse ListInstanceProfiles()
        {
            return ListInstanceProfiles(new ListInstanceProfilesRequest());
        }


        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesResponse>(request, options);
        }


        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
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
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the instance profiles that have the specified associated IAM role. If there
        /// are none, the operation returns an empty list. For more information about instance
        /// profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        public virtual ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceProfilesForRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesForRoleResponse>(request, options);
        }


        /// <summary>
        /// Lists the instance profiles that have the specified associated IAM role. If there
        /// are none, the operation returns an empty list. For more information about instance
        /// profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        public virtual ListMFADevicesResponse ListMFADevices()
        {
            return ListMFADevices(new ListMFADevicesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices service method.</param>
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
        public virtual ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices service method.</param>
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
        public virtual Task<ListMFADevicesResponse> ListMFADevicesAsync(ListMFADevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMFADevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMFADevicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMFADevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpenIDConnectProviders


        /// <summary>
        /// Lists information about the IAM OpenID Connect (OIDC) provider resource objects defined
        /// in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders service method.</param>
        /// 
        /// <returns>The response from the ListOpenIDConnectProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        public virtual ListOpenIDConnectProvidersResponse ListOpenIDConnectProviders(ListOpenIDConnectProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpenIDConnectProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;

            return Invoke<ListOpenIDConnectProvidersResponse>(request, options);
        }


        /// <summary>
        /// Lists information about the IAM OpenID Connect (OIDC) provider resource objects defined
        /// in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpenIDConnectProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies()
        {
            return ListPolicies(new ListPoliciesRequest());
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
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
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
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Retrieves a list of policies that the IAM identity (user, group, or role) can use
        /// to access each specified service.
        /// 
        ///  <note> 
        /// <para>
        /// This operation does not use other policy types when determining whether a resource
        /// could access a service. These other policy types include resource-based policies,
        /// access control lists, AWS Organizations policies, IAM permissions boundaries, and
        /// AWS STS assume role policies. It only applies permissions policy logic. For more about
        /// the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of policies returned by the operation depends on the ARN of the identity
        /// that you provide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>User</b> – The list of policies includes the managed and inline policies that
        /// are attached to the user directly. The list also includes any additional managed and
        /// inline policies that are attached to the group to which the user belongs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b> – The list of policies includes only the managed and inline policies
        /// that are attached to the group directly. Policies that are attached to the group’s
        /// user are not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Role</b> – The list of policies includes only the managed and inline policies
        /// that are attached to the role.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For each managed policy, this operation returns the ARN and policy name. For each
        /// inline policy, it returns the policy name and the entity to which it is attached.
        /// Inline policies do not have an ARN. For more information about these policy types,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Policies that are attached to users and roles as permissions boundaries are not returned.
        /// To view which managed policy is currently used to set the permissions boundary for
        /// a user or role, use the <a>GetUser</a> or <a>GetRole</a> operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesGrantingServiceAccess service method.</param>
        /// 
        /// <returns>The response from the ListPoliciesGrantingServiceAccess service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPoliciesGrantingServiceAccess">REST API Reference for ListPoliciesGrantingServiceAccess Operation</seealso>
        public virtual ListPoliciesGrantingServiceAccessResponse ListPoliciesGrantingServiceAccess(ListPoliciesGrantingServiceAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesGrantingServiceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesGrantingServiceAccessResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesGrantingServiceAccessResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of policies that the IAM identity (user, group, or role) can use
        /// to access each specified service.
        /// 
        ///  <note> 
        /// <para>
        /// This operation does not use other policy types when determining whether a resource
        /// could access a service. These other policy types include resource-based policies,
        /// access control lists, AWS Organizations policies, IAM permissions boundaries, and
        /// AWS STS assume role policies. It only applies permissions policy logic. For more about
        /// the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of policies returned by the operation depends on the ARN of the identity
        /// that you provide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>User</b> – The list of policies includes the managed and inline policies that
        /// are attached to the user directly. The list also includes any additional managed and
        /// inline policies that are attached to the group to which the user belongs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b> – The list of policies includes only the managed and inline policies
        /// that are attached to the group directly. Policies that are attached to the group’s
        /// user are not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Role</b> – The list of policies includes only the managed and inline policies
        /// that are attached to the role.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For each managed policy, this operation returns the ARN and policy name. For each
        /// inline policy, it returns the policy name and the entity to which it is attached.
        /// Inline policies do not have an ARN. For more information about these policy types,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Policies that are attached to users and roles as permissions boundaries are not returned.
        /// To view which managed policy is currently used to set the permissions boundary for
        /// a user or role, use the <a>GetUser</a> or <a>GetRole</a> operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesGrantingServiceAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPoliciesGrantingServiceAccess service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Lists information about the versions of the specified managed policy, including the
        /// version that is currently set as the policy's default version.
        /// 
        ///  
        /// <para>
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyVersionsResponse>(request, options);
        }


        /// <summary>
        /// Lists information about the versions of the specified managed policy, including the
        /// version that is currently set as the policy's default version.
        /// 
        ///  
        /// <para>
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have managed policies attached to it. To list the managed policies
        /// that are attached to a role, use <a>ListAttachedRolePolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified role, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        public virtual ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRolePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListRolePoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have managed policies attached to it. To list the managed policies
        /// that are attached to a role, use <a>ListAttachedRolePolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified role, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        public virtual ListRolesResponse ListRoles()
        {
            return ListRoles(new ListRolesRequest());
        }


        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        public virtual ListRolesResponse ListRoles(ListRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRolesResponseUnmarshaller.Instance;

            return Invoke<ListRolesResponse>(request, options);
        }


        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
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
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the tags that are attached to the specified role. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleTags service method.</param>
        /// 
        /// <returns>The response from the ListRoleTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoleTags">REST API Reference for ListRoleTags Operation</seealso>
        public virtual ListRoleTagsResponse ListRoleTags(ListRoleTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleTagsResponseUnmarshaller.Instance;

            return Invoke<ListRoleTagsResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags that are attached to the specified role. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoleTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        public virtual ListSAMLProvidersResponse ListSAMLProviders()
        {
            return ListSAMLProviders(new ListSAMLProvidersRequest());
        }


        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        public virtual ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request)
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
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
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
        /// Lists the SAML provider resource objects defined in IAM in the account.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        public virtual ListServerCertificatesResponse ListServerCertificates()
        {
            return ListServerCertificates(new ListServerCertificatesRequest());
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
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates service method.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        public virtual ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request)
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
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
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
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Returns information about the service-specific credentials associated with the specified
        /// IAM user. If none exists, the operation returns an empty list. The service-specific
        /// credentials returned by this operation are used only for authenticating the IAM user
        /// to a specific service. For more information about using service-specific credentials
        /// to authenticate to an AWS service, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-gc.html">Set
        /// Up service-specific credentials</a> in the AWS CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials service method.</param>
        /// 
        /// <returns>The response from the ListServiceSpecificCredentials service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceNotSupportedException">
        /// The specified service does not support service-specific credentials.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServiceSpecificCredentials">REST API Reference for ListServiceSpecificCredentials Operation</seealso>
        public virtual ListServiceSpecificCredentialsResponse ListServiceSpecificCredentials(ListServiceSpecificCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceSpecificCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceSpecificCredentialsResponseUnmarshaller.Instance;

            return Invoke<ListServiceSpecificCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the service-specific credentials associated with the specified
        /// IAM user. If none exists, the operation returns an empty list. The service-specific
        /// credentials returned by this operation are used only for authenticating the IAM user
        /// to a specific service. For more information about using service-specific credentials
        /// to authenticate to an AWS service, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-gc.html">Set
        /// Up service-specific credentials</a> in the AWS CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceSpecificCredentials service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceNotSupportedException">
        /// The specified service does not support service-specific credentials.
        /// </exception>
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


        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
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
        public virtual ListSigningCertificatesResponse ListSigningCertificates()
        {
            return ListSigningCertificates(new ListSigningCertificatesRequest());
        }


        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
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
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates service method.</param>
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
        public virtual ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListSigningCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
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
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
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
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates service method.</param>
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
        public virtual Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(ListSigningCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSigningCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSSHPublicKeys


        /// <summary>
        /// Returns information about the SSH public keys associated with the specified IAM user.
        /// If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// The SSH public keys returned by this operation are used only for authenticating the
        /// IAM user to an AWS CodeCommit repository. For more information about using SSH keys
        /// to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListSSHPublicKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        public virtual ListSSHPublicKeysResponse ListSSHPublicKeys(ListSSHPublicKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSSHPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListSSHPublicKeysResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the SSH public keys associated with the specified IAM user.
        /// If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// The SSH public keys returned by this operation are used only for authenticating the
        /// IAM user to an AWS CodeCommit repository. For more information about using SSH keys
        /// to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSSHPublicKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Lists the names of the inline policies embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have managed policies attached to it. To list the managed policies
        /// that are attached to a user, use <a>ListAttachedUserPolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified user, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        public virtual ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListUserPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists the names of the inline policies embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have managed policies attached to it. To list the managed policies
        /// that are attached to a user, use <a>ListAttachedUserPolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified user, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers()
        {
            return ListUsers(new ListUsersRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Lists the tags that are attached to the specified user. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserTags service method.</param>
        /// 
        /// <returns>The response from the ListUserTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserTags">REST API Reference for ListUserTags Operation</seealso>
        public virtual ListUserTagsResponse ListUserTags(ListUserTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserTagsResponseUnmarshaller.Instance;

            return Invoke<ListUserTagsResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags that are attached to the specified user. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        public virtual ListVirtualMFADevicesResponse ListVirtualMFADevices()
        {
            return ListVirtualMFADevices(new ListVirtualMFADevicesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        public virtual ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
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


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To attach a managed policy to
        /// a group, use <a>AttachGroupPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed in
        /// a group, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutGroupPolicy</code>. For general information about using the Query API with
        /// IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        public virtual PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutGroupPolicyResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To attach a managed policy to
        /// a group, use <a>AttachGroupPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed in
        /// a group, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutGroupPolicy</code>. For general information about using the Query API with
        /// IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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


        /// <summary>
        /// Adds or updates the policy that is specified as the IAM role's permissions boundary.
        /// You can use an AWS managed policy or a customer managed policy to set the boundary
        /// for a role. Use the boundary to control the maximum permissions that the role can
        /// have. Setting a permissions boundary is an advanced feature that can affect the permissions
        /// for the role.
        /// 
        ///  
        /// <para>
        /// You cannot set the boundary for a service-linked role. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Policies used as permissions boundaries do not provide permissions. You must also
        /// attach a permissions policy to the role. To learn how the effective permissions for
        /// a role are evaluated, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
        /// JSON Policy Evaluation Logic</a> in the IAM User Guide. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the PutRolePermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        public virtual PutRolePermissionsBoundaryResponse PutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRolePermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRolePermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<PutRolePermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates the policy that is specified as the IAM role's permissions boundary.
        /// You can use an AWS managed policy or a customer managed policy to set the boundary
        /// for a role. Use the boundary to control the maximum permissions that the role can
        /// have. Setting a permissions boundary is an advanced feature that can affect the permissions
        /// for the role.
        /// 
        ///  
        /// <para>
        /// You cannot set the boundary for a service-linked role. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Policies used as permissions boundaries do not provide permissions. You must also
        /// attach a permissions policy to the role. To learn how the effective permissions for
        /// a role are evaluated, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
        /// JSON Policy Evaluation Logic</a> in the IAM User Guide. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePermissionsBoundary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRolePermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// When you embed an inline policy in a role, the inline policy is used as part of the
        /// role's access (permissions) policy. The role's trust policy is created at the same
        /// time as the role, using <a>CreateRole</a>. You can update a role's trust policy using
        /// <a>UpdateAssumeRolePolicy</a>. For more information about IAM roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>.
        /// </para>
        ///  
        /// <para>
        /// A role can also have a managed policy attached to it. To attach a managed policy to
        /// a role, use <a>AttachRolePolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed with
        /// a role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutRolePolicy</code>. For general information about using the Query API with
        /// IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// 
        /// <returns>The response from the PutRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        public virtual PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return Invoke<PutRolePolicyResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// When you embed an inline policy in a role, the inline policy is used as part of the
        /// role's access (permissions) policy. The role's trust policy is created at the same
        /// time as the role, using <a>CreateRole</a>. You can update a role's trust policy using
        /// <a>UpdateAssumeRolePolicy</a>. For more information about IAM roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>.
        /// </para>
        ///  
        /// <para>
        /// A role can also have a managed policy attached to it. To attach a managed policy to
        /// a role, use <a>AttachRolePolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed with
        /// a role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutRolePolicy</code>. For general information about using the Query API with
        /// IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Adds or updates the policy that is specified as the IAM user's permissions boundary.
        /// You can use an AWS managed policy or a customer managed policy to set the boundary
        /// for a user. Use the boundary to control the maximum permissions that the user can
        /// have. Setting a permissions boundary is an advanced feature that can affect the permissions
        /// for the user.
        /// 
        ///  <important> 
        /// <para>
        /// Policies that are used as permissions boundaries do not provide permissions. You must
        /// also attach a permissions policy to the user. To learn how the effective permissions
        /// for a user are evaluated, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
        /// JSON Policy Evaluation Logic</a> in the IAM User Guide. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the PutUserPermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPermissionsBoundary">REST API Reference for PutUserPermissionsBoundary Operation</seealso>
        public virtual PutUserPermissionsBoundaryResponse PutUserPermissionsBoundary(PutUserPermissionsBoundaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserPermissionsBoundaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserPermissionsBoundaryResponseUnmarshaller.Instance;

            return Invoke<PutUserPermissionsBoundaryResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates the policy that is specified as the IAM user's permissions boundary.
        /// You can use an AWS managed policy or a customer managed policy to set the boundary
        /// for a user. Use the boundary to control the maximum permissions that the user can
        /// have. Setting a permissions boundary is an advanced feature that can affect the permissions
        /// for the user.
        /// 
        ///  <important> 
        /// <para>
        /// Policies that are used as permissions boundaries do not provide permissions. You must
        /// also attach a permissions policy to the user. To learn how the effective permissions
        /// for a user are evaluated, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
        /// JSON Policy Evaluation Logic</a> in the IAM User Guide. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPermissionsBoundary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutUserPermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because AWS service role policies can only be attached to the service-linked
        /// role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have a managed policy attached to it. To attach a managed policy
        /// to a user, use <a>AttachUserPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed in
        /// a user, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutUserPolicy</code>. For general information about using the Query API with
        /// IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// 
        /// <returns>The response from the PutUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        public virtual PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUserPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return Invoke<PutUserPolicyResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have a managed policy attached to it. To attach a managed policy
        /// to a user, use <a>AttachUserPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed in
        /// a user, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutUserPolicy</code>. For general information about using the Query API with
        /// IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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


        /// <summary>
        /// Removes the specified client ID (also known as audience) from the list of client IDs
        /// registered for the specified IAM OpenID Connect (OIDC) provider resource object.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you try to remove
        /// a client ID that does not exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the RemoveClientIDFromOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        public virtual RemoveClientIDFromOpenIDConnectProviderResponse RemoveClientIDFromOpenIDConnectProvider(RemoveClientIDFromOpenIDConnectProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveClientIDFromOpenIDConnectProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<RemoveClientIDFromOpenIDConnectProviderResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified client ID (also known as audience) from the list of client IDs
        /// registered for the specified IAM OpenID Connect (OIDC) provider resource object.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you try to remove
        /// a client ID that does not exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveClientIDFromOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Removes the specified IAM role from the specified EC2 instance profile.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the role you
        /// are about to remove from the instance profile. Removing a role from an instance profile
        /// that is associated with a running instance might break any applications running on
        /// the instance.
        /// </para>
        ///  </important> 
        /// <para>
        ///  For more information about IAM roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For more information about instance profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        public virtual RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified IAM role from the specified EC2 instance profile.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the role you
        /// are about to remove from the instance profile. Removing a role from an instance profile
        /// that is associated with a running instance might break any applications running on
        /// the instance.
        /// </para>
        ///  </important> 
        /// <para>
        ///  For more information about IAM roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For more information about instance profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveRoleFromInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Removes the specified user from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveUserFromGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        public virtual RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveUserFromGroupResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified user from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveUserFromGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Resets the password for a service-specific credential. The new password is AWS generated
        /// and cryptographically strong. It cannot be configured by the user. Resetting the password
        /// immediately invalidates the previous password associated with this user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the ResetServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        public virtual ResetServiceSpecificCredentialResponse ResetServiceSpecificCredential(ResetServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<ResetServiceSpecificCredentialResponse>(request, options);
        }


        /// <summary>
        /// Resets the password for a service-specific credential. The new password is AWS generated
        /// and cryptographically strong. It cannot be configured by the user. Resetting the password
        /// immediately invalidates the previous password associated with this user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Synchronizes the specified MFA device with its IAM resource object on the AWS servers.
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a Virtual MFA Device</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice service method.</param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        public virtual ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResyncMFADeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return Invoke<ResyncMFADeviceResponse>(request, options);
        }


        /// <summary>
        /// Synchronizes the specified MFA device with its IAM resource object on the AWS servers.
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, go to <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a Virtual MFA Device</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version.
        /// 
        ///  
        /// <para>
        /// This operation affects all users, groups, and roles that the policy is attached to.
        /// To list the users, groups, and roles that the policy is attached to, use the <a>ListEntitiesForPolicy</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<SetDefaultPolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version.
        /// 
        ///  
        /// <para>
        /// This operation affects all users, groups, and roles that the policy is attached to.
        /// To list the users, groups, and roles that the policy is attached to, use the <a>ListEntitiesForPolicy</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetDefaultPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetSecurityTokenServicePreferences


        /// <summary>
        /// Sets the specified version of the global endpoint token as the token version used
        /// for the AWS account.
        /// 
        ///  
        /// <para>
        /// By default, AWS Security Token Service (STS) is available as a global service, and
        /// all STS requests go to a single endpoint at <code>https://sts.amazonaws.com</code>.
        /// AWS recommends using Regional STS endpoints to reduce latency, build in redundancy,
        /// and increase session token availability. For information about Regional endpoints
        /// for STS, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#sts_region">AWS
        /// Regions and Endpoints</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// If you make an STS call to the global endpoint, the resulting session tokens might
        /// be valid in some Regions but not others. It depends on the version that is set in
        /// this operation. Version 1 tokens are valid only in AWS Regions that are available
        /// by default. These tokens do not work in manually enabled Regions, such as Asia Pacific
        /// (Hong Kong). Version 2 tokens are valid in all Regions. However, version 2 tokens
        /// are longer and might affect systems where you temporarily store tokens. For information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To view the current session token version, see the <code>GlobalEndpointTokenVersion</code>
        /// entry in the response of the <a>GetAccountSummary</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityTokenServicePreferences service method.</param>
        /// 
        /// <returns>The response from the SetSecurityTokenServicePreferences service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetSecurityTokenServicePreferences">REST API Reference for SetSecurityTokenServicePreferences Operation</seealso>
        public virtual SetSecurityTokenServicePreferencesResponse SetSecurityTokenServicePreferences(SetSecurityTokenServicePreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSecurityTokenServicePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSecurityTokenServicePreferencesResponseUnmarshaller.Instance;

            return Invoke<SetSecurityTokenServicePreferencesResponse>(request, options);
        }


        /// <summary>
        /// Sets the specified version of the global endpoint token as the token version used
        /// for the AWS account.
        /// 
        ///  
        /// <para>
        /// By default, AWS Security Token Service (STS) is available as a global service, and
        /// all STS requests go to a single endpoint at <code>https://sts.amazonaws.com</code>.
        /// AWS recommends using Regional STS endpoints to reduce latency, build in redundancy,
        /// and increase session token availability. For information about Regional endpoints
        /// for STS, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#sts_region">AWS
        /// Regions and Endpoints</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// If you make an STS call to the global endpoint, the resulting session tokens might
        /// be valid in some Regions but not others. It depends on the version that is set in
        /// this operation. Version 1 tokens are valid only in AWS Regions that are available
        /// by default. These tokens do not work in manually enabled Regions, such as Asia Pacific
        /// (Hong Kong). Version 2 tokens are valid in all Regions. However, version 2 tokens
        /// are longer and might affect systems where you temporarily store tokens. For information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To view the current session token version, see the <code>GlobalEndpointTokenVersion</code>
        /// entry in the response of the <a>GetAccountSummary</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityTokenServicePreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSecurityTokenServicePreferences service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetSecurityTokenServicePreferences">REST API Reference for SetSecurityTokenServicePreferences Operation</seealso>
        public virtual Task<SetSecurityTokenServicePreferencesResponse> SetSecurityTokenServicePreferencesAsync(SetSecurityTokenServicePreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSecurityTokenServicePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSecurityTokenServicePreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetSecurityTokenServicePreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SimulateCustomPolicy


        /// <summary>
        /// Simulate how a set of IAM policies and optionally a resource-based policy works with
        /// a list of API operations and AWS resources to determine the policies' effective permissions.
        /// The policies are provided as strings.
        /// 
        ///  
        /// <para>
        /// The simulation does not perform the API operations; it only checks the authorization
        /// to determine if the simulated policies allow or deny the operations.
        /// </para>
        ///  
        /// <para>
        /// If you want to simulate existing policies that are attached to an IAM user, group,
        /// or role, use <a>SimulatePrincipalPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables that are maintained by AWS and its services and which provide
        /// details about the context of an API query request. You can use the <code>Condition</code>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a>GetContextKeysForCustomPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use <code>MaxItems</code> and <code>Marker</code> parameters
        /// to paginate the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy service method.</param>
        /// 
        /// <returns>The response from the SimulateCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detailed message indicates the source of the failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        public virtual SimulateCustomPolicyResponse SimulateCustomPolicy(SimulateCustomPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SimulateCustomPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulateCustomPolicyResponse>(request, options);
        }


        /// <summary>
        /// Simulate how a set of IAM policies and optionally a resource-based policy works with
        /// a list of API operations and AWS resources to determine the policies' effective permissions.
        /// The policies are provided as strings.
        /// 
        ///  
        /// <para>
        /// The simulation does not perform the API operations; it only checks the authorization
        /// to determine if the simulated policies allow or deny the operations.
        /// </para>
        ///  
        /// <para>
        /// If you want to simulate existing policies that are attached to an IAM user, group,
        /// or role, use <a>SimulatePrincipalPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables that are maintained by AWS and its services and which provide
        /// details about the context of an API query request. You can use the <code>Condition</code>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a>GetContextKeysForCustomPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use <code>MaxItems</code> and <code>Marker</code> parameters
        /// to paginate the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimulateCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detailed message indicates the source of the failure.
        /// </exception>
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


        /// <summary>
        /// Simulate how a set of IAM policies attached to an IAM entity works with a list of
        /// API operations and AWS resources to determine the policies' effective permissions.
        /// The entity can be an IAM user, group, or role. If you specify a user, then the simulation
        /// also includes all of the policies that are attached to groups that the user belongs
        /// to.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies specified as
        /// strings to include in the simulation. If you want to simulate only policies specified
        /// as strings, use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// You can also optionally include one resource-based policy to be evaluated with each
        /// of the resources included in the simulation.
        /// </para>
        ///  
        /// <para>
        /// The simulation does not perform the API operations; it only checks the authorization
        /// to determine if the simulated policies allow or deny the operations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. You can use the <code>Condition</code>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use the <code>MaxItems</code> and <code>Marker</code>
        /// parameters to paginate the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the SimulatePrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detailed message indicates the source of the failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        public virtual SimulatePrincipalPolicyResponse SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SimulatePrincipalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulatePrincipalPolicyResponse>(request, options);
        }


        /// <summary>
        /// Simulate how a set of IAM policies attached to an IAM entity works with a list of
        /// API operations and AWS resources to determine the policies' effective permissions.
        /// The entity can be an IAM user, group, or role. If you specify a user, then the simulation
        /// also includes all of the policies that are attached to groups that the user belongs
        /// to.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies specified as
        /// strings to include in the simulation. If you want to simulate only policies specified
        /// as strings, use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// You can also optionally include one resource-based policy to be evaluated with each
        /// of the resources included in the simulation.
        /// </para>
        ///  
        /// <para>
        /// The simulation does not perform the API operations; it only checks the authorization
        /// to determine if the simulated policies allow or deny the operations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. You can use the <code>Condition</code>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use the <code>MaxItems</code> and <code>Marker</code>
        /// parameters to paginate the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimulatePrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detailed message indicates the source of the failure.
        /// </exception>
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


        /// <summary>
        /// Adds one or more tags to an IAM role. The role can be a regular role or a service-linked
        /// role. If a tag with the same key name already exists, then that tag is overwritten
        /// with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Reference tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM user or role that has a specified
        /// tag attached. You can also restrict access to only those resources that have a certain
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// Access Using IAM Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
        /// which AWS resources.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// Make sure that you have no invalid tags and that you do not exceed the allowed number
        /// of tags per role. In either case, the entire request fails and <i>no</i> tags are
        /// added to the role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS always interprets the tag <code>Value</code> as a single string. If you need to
        /// store an array, you can store comma-separated values in the string. However, you must
        /// interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagRole service method.</param>
        /// 
        /// <returns>The response from the TagRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagRole">REST API Reference for TagRole Operation</seealso>
        public virtual TagRoleResponse TagRole(TagRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagRoleResponseUnmarshaller.Instance;

            return Invoke<TagRoleResponse>(request, options);
        }


        /// <summary>
        /// Adds one or more tags to an IAM role. The role can be a regular role or a service-linked
        /// role. If a tag with the same key name already exists, then that tag is overwritten
        /// with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Reference tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM user or role that has a specified
        /// tag attached. You can also restrict access to only those resources that have a certain
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// Access Using IAM Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
        /// which AWS resources.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// Make sure that you have no invalid tags and that you do not exceed the allowed number
        /// of tags per role. In either case, the entire request fails and <i>no</i> tags are
        /// added to the role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS always interprets the tag <code>Value</code> as a single string. If you need to
        /// store an array, you can store comma-separated values in the string. However, you must
        /// interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Adds one or more tags to an IAM user. If a tag with the same key name already exists,
        /// then that tag is overwritten with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Reference tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM requesting user or to a role that
        /// has a specified tag attached. You can also restrict access to only those resources
        /// that have a certain tag attached. For examples of policies that show how to use tags
        /// to control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// Access Using IAM Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
        /// which AWS resources.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// Make sure that you have no invalid tags and that you do not exceed the allowed number
        /// of tags per role. In either case, the entire request fails and <i>no</i> tags are
        /// added to the role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS always interprets the tag <code>Value</code> as a single string. If you need to
        /// store an array, you can store comma-separated values in the string. However, you must
        /// interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagUser service method.</param>
        /// 
        /// <returns>The response from the TagUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagUser">REST API Reference for TagUser Operation</seealso>
        public virtual TagUserResponse TagUser(TagUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagUserResponseUnmarshaller.Instance;

            return Invoke<TagUserResponse>(request, options);
        }


        /// <summary>
        /// Adds one or more tags to an IAM user. If a tag with the same key name already exists,
        /// then that tag is overwritten with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Reference tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM requesting user or to a role that
        /// has a specified tag attached. You can also restrict access to only those resources
        /// that have a certain tag attached. For examples of policies that show how to use tags
        /// to control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// Access Using IAM Tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
        /// which AWS resources.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// Make sure that you have no invalid tags and that you do not exceed the allowed number
        /// of tags per role. In either case, the entire request fails and <i>no</i> tags are
        /// added to the role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS always interprets the tag <code>Value</code> as a single string. If you need to
        /// store an array, you can store comma-separated values in the string. However, you must
        /// interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM Identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Removes the specified tags from the role. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagRole service method.</param>
        /// 
        /// <returns>The response from the UntagRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagRole">REST API Reference for UntagRole Operation</seealso>
        public virtual UntagRoleResponse UntagRole(UntagRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagRoleResponseUnmarshaller.Instance;

            return Invoke<UntagRoleResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the role. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Removes the specified tags from the user. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagUser service method.</param>
        /// 
        /// <returns>The response from the UntagUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagUser">REST API Reference for UntagUser Operation</seealso>
        public virtual UntagUserResponse UntagUser(UntagUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagUserResponseUnmarshaller.Instance;

            return Invoke<UntagUserResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the user. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// Identities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This operation can be used to disable a user's key as part of a key rotation workflow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about rotating keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html">Managing
        /// Keys and Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        public virtual UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessKeyResponse>(request, options);
        }


        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This operation can be used to disable a user's key as part of a key rotation workflow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about rotating keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html">Managing
        /// Keys and Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        ///  For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        public virtual UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy()
        {
            return UpdateAccountPasswordPolicy(new UpdateAccountPasswordPolicyRequest());
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
        ///  For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        public virtual UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request)
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
        ///  For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
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
        /// AWS account limitations. The error message describes the limit exceeded.
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
        ///  For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        public virtual Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountPasswordPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAccountPasswordPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssumeRolePolicy


        /// <summary>
        /// Updates the policy that grants an IAM entity permission to assume a role. This is
        /// typically referred to as the "role trust policy". For more information about roles,
        /// go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAssumeRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        public virtual UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssumeRolePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAssumeRolePolicyResponse>(request, options);
        }


        /// <summary>
        /// Updates the policy that grants an IAM entity permission to assume a role. This is
        /// typically referred to as the "role trust policy". For more information about roles,
        /// go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssumeRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
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
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Updates the name and/or the path of the specified IAM group.
        /// 
        ///  <important> 
        /// <para>
        ///  You should understand the implications of changing a group's path or name. For more
        /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
        /// Users and Groups</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// The person making the request (the principal), must have permission to change the
        /// role group with the old name and the new name. For example, to change the group named
        /// <code>Managers</code> to <code>MGRs</code>, the principal must have a policy that
        /// allows them to update both groups. If the principal has permission to update the <code>Managers</code>
        /// group, but not the <code>MGRs</code> group, then the update fails. For more information
        /// about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }


        /// <summary>
        /// Updates the name and/or the path of the specified IAM group.
        /// 
        ///  <important> 
        /// <para>
        ///  You should understand the implications of changing a group's path or name. For more
        /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
        /// Users and Groups</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// The person making the request (the principal), must have permission to change the
        /// role group with the old name and the new name. For example, to change the group named
        /// <code>Managers</code> to <code>MGRs</code>, the principal must have a policy that
        /// allows them to update both groups. If the principal has permission to update the <code>Managers</code>
        /// group, but not the <code>MGRs</code> group, then the update fails. For more information
        /// about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Changes the password for the specified IAM user.
        /// 
        ///  
        /// <para>
        /// IAM users can change their own passwords by calling <a>ChangePassword</a>. For more
        /// information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        public virtual UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoginProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateLoginProfileResponse>(request, options);
        }


        /// <summary>
        /// Changes the password for the specified IAM user.
        /// 
        ///  
        /// <para>
        /// IAM users can change their own passwords by calling <a>ChangePassword</a>. For more
        /// information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Replaces the existing list of server certificate thumbprints associated with an OpenID
        /// Connect (OIDC) provider resource object with a new list of thumbprints.
        /// 
        ///  
        /// <para>
        /// The list that you pass with this operation completely replaces the existing list of
        /// thumbprints. (The lists are not merged.)
        /// </para>
        ///  
        /// <para>
        /// Typically, you need to update a thumbprint only when the identity provider's certificate
        /// changes, which occurs rarely. However, if the provider's certificate <i>does</i> change,
        /// any attempt to assume an IAM role that specifies the OIDC provider as a principal
        /// fails until the certificate thumbprint is updated.
        /// </para>
        ///  <note> 
        /// <para>
        /// Trust for the OIDC provider is derived from the provider's certificate and is validated
        /// by the thumbprint. Therefore, it is best to limit access to the <code>UpdateOpenIDConnectProviderThumbprint</code>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint service method.</param>
        /// 
        /// <returns>The response from the UpdateOpenIDConnectProviderThumbprint service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        public virtual UpdateOpenIDConnectProviderThumbprintResponse UpdateOpenIDConnectProviderThumbprint(UpdateOpenIDConnectProviderThumbprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpenIDConnectProviderThumbprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;

            return Invoke<UpdateOpenIDConnectProviderThumbprintResponse>(request, options);
        }


        /// <summary>
        /// Replaces the existing list of server certificate thumbprints associated with an OpenID
        /// Connect (OIDC) provider resource object with a new list of thumbprints.
        /// 
        ///  
        /// <para>
        /// The list that you pass with this operation completely replaces the existing list of
        /// thumbprints. (The lists are not merged.)
        /// </para>
        ///  
        /// <para>
        /// Typically, you need to update a thumbprint only when the identity provider's certificate
        /// changes, which occurs rarely. However, if the provider's certificate <i>does</i> change,
        /// any attempt to assume an IAM role that specifies the OIDC provider as a principal
        /// fails until the certificate thumbprint is updated.
        /// </para>
        ///  <note> 
        /// <para>
        /// Trust for the OIDC provider is derived from the provider's certificate and is validated
        /// by the thumbprint. Therefore, it is best to limit access to the <code>UpdateOpenIDConnectProviderThumbprint</code>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOpenIDConnectProviderThumbprint service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Updates the description or maximum session duration setting of a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole service method.</param>
        /// 
        /// <returns>The response from the UpdateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        public virtual UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleResponseUnmarshaller.Instance;

            return Invoke<UpdateRoleResponse>(request, options);
        }


        /// <summary>
        /// Updates the description or maximum session duration setting of a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Use <a>UpdateRole</a> instead.
        /// 
        ///  
        /// <para>
        /// Modifies only the description of a role. This operation performs the same function
        /// as the <code>Description</code> parameter in the <code>UpdateRole</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateRoleDescription service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        public virtual UpdateRoleDescriptionResponse UpdateRoleDescription(UpdateRoleDescriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateRoleDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Use <a>UpdateRole</a> instead.
        /// 
        ///  
        /// <para>
        /// Modifies only the description of a role. This operation performs the same function
        /// as the <code>Description</code> parameter in the <code>UpdateRole</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoleDescription service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
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


        /// <summary>
        /// Updates the metadata document for an existing SAML provider resource object.
        /// 
        ///  <note> 
        /// <para>
        /// This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        public virtual UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSAMLProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateSAMLProviderResponse>(request, options);
        }


        /// <summary>
        /// Updates the metadata document for an existing SAML provider resource object.
        /// 
        ///  <note> 
        /// <para>
        /// This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Updates the name and/or the path of the specified server certificate stored in IAM.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        ///  <important> 
        /// <para>
        /// You should understand the implications of changing a server certificate's path or
        /// name. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs_manage.html#RenamingServerCerts">Renaming
        /// a Server Certificate</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// The person making the request (the principal), must have permission to change the
        /// server certificate with the old name and the new name. For example, to change the
        /// certificate named <code>ProductionCert</code> to <code>ProdCert</code>, the principal
        /// must have a policy that allows them to update both certificates. If the principal
        /// has permission to update the <code>ProductionCert</code> group, but not the <code>ProdCert</code>
        /// certificate, then the update fails. For more information about permissions, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access Management</a>
        /// in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        public virtual UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateServerCertificateResponse>(request, options);
        }


        /// <summary>
        /// Updates the name and/or the path of the specified server certificate stored in IAM.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        ///  <important> 
        /// <para>
        /// You should understand the implications of changing a server certificate's path or
        /// name. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs_manage.html#RenamingServerCerts">Renaming
        /// a Server Certificate</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// The person making the request (the principal), must have permission to change the
        /// server certificate with the old name and the new name. For example, to change the
        /// certificate named <code>ProductionCert</code> to <code>ProdCert</code>, the principal
        /// must have a policy that allows them to update both certificates. If the principal
        /// has permission to update the <code>ProductionCert</code> group, but not the <code>ProdCert</code>
        /// certificate, then the update fails. For more information about permissions, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access Management</a>
        /// in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Sets the status of a service-specific credential to <code>Active</code> or <code>Inactive</code>.
        /// Service-specific credentials that are inactive cannot be used for authentication to
        /// the service. This operation can be used to disable a user's service-specific credential
        /// as part of a credential rotation work flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        public virtual UpdateServiceSpecificCredentialResponse UpdateServiceSpecificCredential(UpdateServiceSpecificCredentialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSpecificCredentialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSpecificCredentialResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSpecificCredentialResponse>(request, options);
        }


        /// <summary>
        /// Sets the status of a service-specific credential to <code>Active</code> or <code>Inactive</code>.
        /// Service-specific credentials that are inactive cannot be used for authentication to
        /// the service. This operation can be used to disable a user's service-specific credential
        /// as part of a credential rotation work flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Changes the status of the specified user signing certificate from active to disabled,
        /// or vice versa. This operation can be used to disable an IAM user's signing certificate
        /// as part of a certificate rotation work flow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        public virtual UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateSigningCertificateResponse>(request, options);
        }


        /// <summary>
        /// Changes the status of the specified user signing certificate from active to disabled,
        /// or vice versa. This operation can be used to disable an IAM user's signing certificate
        /// as part of a certificate rotation work flow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Sets the status of an IAM user's SSH public key to active or inactive. SSH public
        /// keys that are inactive cannot be used for authentication. This operation can be used
        /// to disable a user's SSH public key as part of a key rotation work flow.
        /// 
        ///  
        /// <para>
        /// The SSH public key affected by this operation is used only for authenticating the
        /// associated IAM user to an AWS CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the UpdateSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        public virtual UpdateSSHPublicKeyResponse UpdateSSHPublicKey(UpdateSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateSSHPublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Sets the status of an IAM user's SSH public key to active or inactive. SSH public
        /// keys that are inactive cannot be used for authentication. This operation can be used
        /// to disable a user's SSH public key as part of a key rotation work flow.
        /// 
        ///  
        /// <para>
        /// The SSH public key affected by this operation is used only for authenticating the
        /// associated IAM user to an AWS CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
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


        /// <summary>
        /// Updates the name and/or the path of the specified IAM user.
        /// 
        ///  <important> 
        /// <para>
        ///  You should understand the implications of changing an IAM user's path or name. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_renaming">Renaming
        /// an IAM User</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_groups_manage_rename.html">Renaming
        /// an IAM Group</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  To change a user name, the requester must have appropriate permissions on both the
        /// source object and the target object. For example, to change Bob to Robert, the entity
        /// making the request must have permission on Bob and Robert, or must have permission
        /// on all (*). For more information about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html">Permissions
        /// and Policies</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }


        /// <summary>
        /// Updates the name and/or the path of the specified IAM user.
        /// 
        ///  <important> 
        /// <para>
        ///  You should understand the implications of changing an IAM user's path or name. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_renaming">Renaming
        /// an IAM User</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_groups_manage_rename.html">Renaming
        /// an IAM Group</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  To change a user name, the requester must have appropriate permissions on both the
        /// source object and the target object. For example, to change Bob to Robert, the entity
        /// making the request must have permission on Bob and Robert, or must have permission
        /// on all (*). For more information about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html">Permissions
        /// and Policies</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Uploads a server certificate entity for the AWS account. The server certificate entity
        /// includes a public key certificate, a private key, and an optional certificate chain,
        /// which should all be PEM-encoded.
        /// 
        ///  
        /// <para>
        /// We recommend that you use <a href="https://docs.aws.amazon.com/acm/">AWS Certificate
        /// Manager</a> to provision, manage, and deploy your server certificates. With ACM you
        /// can request a certificate, deploy it to AWS resources, and let ACM handle certificate
        /// renewals for you. Certificates provided by ACM are free. For more information about
        /// using ACM, see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">AWS
        /// Certificate Manager User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic includes a list
        /// of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        ///  
        /// <para>
        /// For information about the number of server certificates you can upload, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-limits.html">Limitations
        /// on IAM Entities and Objects</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of the public key certificate, private key, and the certificate chain
        /// can be large, you should use POST rather than GET when calling <code>UploadServerCertificate</code>.
        /// For information about setting up signatures and authorization through the API, go
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
        /// about using the Query API with IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/programming.html">Calling
        /// the API by Making HTTP Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.KeyPairMismatchException">
        /// The request was rejected because the public key certificate and the private key do
        /// not match.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        public virtual UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadServerCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadServerCertificateResponse>(request, options);
        }


        /// <summary>
        /// Uploads a server certificate entity for the AWS account. The server certificate entity
        /// includes a public key certificate, a private key, and an optional certificate chain,
        /// which should all be PEM-encoded.
        /// 
        ///  
        /// <para>
        /// We recommend that you use <a href="https://docs.aws.amazon.com/acm/">AWS Certificate
        /// Manager</a> to provision, manage, and deploy your server certificates. With ACM you
        /// can request a certificate, deploy it to AWS resources, and let ACM handle certificate
        /// renewals for you. Certificates provided by ACM are free. For more information about
        /// using ACM, see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">AWS
        /// Certificate Manager User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic includes a list
        /// of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        ///  
        /// <para>
        /// For information about the number of server certificates you can upload, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-limits.html">Limitations
        /// on IAM Entities and Objects</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of the public key certificate, private key, and the certificate chain
        /// can be large, you should use POST rather than GET when calling <code>UploadServerCertificate</code>.
        /// For information about setting up signatures and authorization through the API, go
        /// to <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
        /// about using the Query API with IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/programming.html">Calling
        /// the API by Making HTTP Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.KeyPairMismatchException">
        /// The request was rejected because the public key certificate and the private key do
        /// not match.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Uploads an X.509 signing certificate and associates it with the specified IAM user.
        /// Some AWS services use X.509 signing certificates to validate requests that are signed
        /// with a corresponding private key. When you upload the certificate, its default status
        /// is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the IAM user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of an X.509 certificate can be large, you should use POST rather
        /// than GET when calling <code>UploadSigningCertificate</code>. For information about
        /// setting up signatures and authorization through the API, go to <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
        /// about using the Query API with IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateCertificateException">
        /// The request was rejected because the same certificate is associated with an IAM user
        /// in the account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidCertificateException">
        /// The request was rejected because the certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        public virtual UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadSigningCertificateResponse>(request, options);
        }


        /// <summary>
        /// Uploads an X.509 signing certificate and associates it with the specified IAM user.
        /// Some AWS services use X.509 signing certificates to validate requests that are signed
        /// with a corresponding private key. When you upload the certificate, its default status
        /// is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the IAM user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of an X.509 certificate can be large, you should use POST rather
        /// than GET when calling <code>UploadSigningCertificate</code>. For information about
        /// setting up signatures and authorization through the API, go to <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
        /// about using the Query API with IAM, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateCertificateException">
        /// The request was rejected because the same certificate is associated with an IAM user
        /// in the account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidCertificateException">
        /// The request was rejected because the certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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


        /// <summary>
        /// Uploads an SSH public key and associates it with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// The SSH public key uploaded by this operation can be used only for authenticating
        /// the associated IAM user to an AWS CodeCommit repository. For more information about
        /// using SSH keys to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the UploadSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateSSHPublicKeyException">
        /// The request was rejected because the SSH public key is already associated with the
        /// specified IAM user.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidPublicKeyException">
        /// The request was rejected because the public key is malformed or otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        public virtual UploadSSHPublicKeyResponse UploadSSHPublicKey(UploadSSHPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadSSHPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UploadSSHPublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Uploads an SSH public key and associates it with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// The SSH public key uploaded by this operation can be used only for authenticating
        /// the associated IAM user to an AWS CodeCommit repository. For more information about
        /// using SSH keys to authenticate to an AWS CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateSSHPublicKeyException">
        /// The request was rejected because the SSH public key is already associated with the
        /// specified IAM user.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidPublicKeyException">
        /// The request was rejected because the public key is malformed or otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limitations. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
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