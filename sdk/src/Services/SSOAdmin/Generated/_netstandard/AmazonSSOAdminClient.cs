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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SSOAdmin.Model;
using Amazon.SSOAdmin.Model.Internal.MarshallTransformations;
using Amazon.SSOAdmin.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SSOAdmin
{
    /// <summary>
    /// <para>Implementation for accessing SSOAdmin</para>
    ///
    /// IAM Identity Center (successor to Single Sign-On) helps you securely create, or connect,
    /// your workforce identities and manage their access centrally across Amazon Web Services
    /// accounts and applications. IAM Identity Center is the recommended approach for workforce
    /// authentication and authorization in Amazon Web Services, for organizations of any
    /// size and type.
    /// 
    ///  <note> 
    /// <para>
    /// IAM Identity Center uses the <c>sso</c> and <c>identitystore</c> API namespaces.
    /// </para>
    ///  </note> 
    /// <para>
    /// This reference guide provides information on single sign-on operations which could
    /// be used for access management of Amazon Web Services accounts. For information about
    /// IAM Identity Center features, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">IAM
    /// Identity Center User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Many operations in the IAM Identity Center APIs rely on identifiers for users and
    /// groups, known as principals. For more information about how to work with principals
    /// and principal IDs in IAM Identity Center, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/welcome.html">Identity
    /// Store API Reference</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Web Services provides SDKs that consist of libraries and sample code for various
    /// programming languages and platforms (Java, Ruby, .Net, iOS, Android, and more). The
    /// SDKs provide a convenient way to create programmatic access to IAM Identity Center
    /// and other Amazon Web Services services. For more information about the Amazon Web
    /// Services SDKs, including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonSSOAdminClient : AmazonServiceClient, IAmazonSSOAdmin
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSOAdminMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSSOAdminClient with the credentials loaded from the application's
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
        public AmazonSSOAdminClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSOAdminConfig()) { }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with the credentials loaded from the application's
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
        public AmazonSSOAdminClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSOAdminConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSOAdminClient Configuration Object</param>
        public AmazonSSOAdminClient(AmazonSSOAdminConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSOAdminClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSOAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOAdminClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSOAdminConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Credentials and an
        /// AmazonSSOAdminClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSOAdminClient Configuration Object</param>
        public AmazonSSOAdminClient(AWSCredentials credentials, AmazonSSOAdminConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSOAdminClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSOAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOAdminClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSOAdminConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSOAdminClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSOAdminClient Configuration Object</param>
        public AmazonSSOAdminClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSOAdminConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSOAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSOAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSOAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSOAdminConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSOAdminClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSOAdminClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSOAdminClient Configuration Object</param>
        public AmazonSSOAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSOAdminConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISSOAdminPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISSOAdminPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SSOAdminPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSOAdminEndpointResolver());
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


        #region  AttachCustomerManagedPolicyReferenceToPermissionSet

        internal virtual AttachCustomerManagedPolicyReferenceToPermissionSetResponse AttachCustomerManagedPolicyReferenceToPermissionSet(AttachCustomerManagedPolicyReferenceToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<AttachCustomerManagedPolicyReferenceToPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Attaches the specified customer managed policy to the specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachCustomerManagedPolicyReferenceToPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachCustomerManagedPolicyReferenceToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachCustomerManagedPolicyReferenceToPermissionSet">REST API Reference for AttachCustomerManagedPolicyReferenceToPermissionSet Operation</seealso>
        public virtual Task<AttachCustomerManagedPolicyReferenceToPermissionSetResponse> AttachCustomerManagedPolicyReferenceToPermissionSetAsync(AttachCustomerManagedPolicyReferenceToPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<AttachCustomerManagedPolicyReferenceToPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachManagedPolicyToPermissionSet

        internal virtual AttachManagedPolicyToPermissionSetResponse AttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachManagedPolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachManagedPolicyToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<AttachManagedPolicyToPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Attaches an Amazon Web Services managed policy ARN to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <c> <a>ProvisionPermissionSet</a> </c> after this operation. Calling
        /// <c>ProvisionPermissionSet</c> applies the corresponding IAM policy updates to all
        /// assigned accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachManagedPolicyToPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachManagedPolicyToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachManagedPolicyToPermissionSet">REST API Reference for AttachManagedPolicyToPermissionSet Operation</seealso>
        public virtual Task<AttachManagedPolicyToPermissionSetResponse> AttachManagedPolicyToPermissionSetAsync(AttachManagedPolicyToPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachManagedPolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachManagedPolicyToPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<AttachManagedPolicyToPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccountAssignment

        internal virtual CreateAccountAssignmentResponse CreateAccountAssignment(CreateAccountAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAssignmentResponseUnmarshaller.Instance;

            return Invoke<CreateAccountAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Assigns access to a principal for a specified Amazon Web Services account using a
        /// specified permission set.
        /// 
        ///  <note> 
        /// <para>
        /// The term <i>principal</i> here refers to a user or group that is defined in IAM Identity
        /// Center.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// As part of a successful <c>CreateAccountAssignment</c> call, the specified permission
        /// set will automatically be provisioned to the account in the form of an IAM policy.
        /// That policy is attached to the IAM role created in IAM Identity Center. If the permission
        /// set is subsequently updated, the corresponding IAM policies attached to roles in your
        /// accounts will not be updated automatically. In this case, you must call <c> <a>ProvisionPermissionSet</a>
        /// </c> to make these updates.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  After a successful response, call <c>DescribeAccountAssignmentCreationStatus</c>
        /// to describe the status of an assignment creation request. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateAccountAssignment">REST API Reference for CreateAccountAssignment Operation</seealso>
        public virtual Task<CreateAccountAssignmentResponse> CreateAccountAssignmentAsync(CreateAccountAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates an application in IAM Identity Center for the given application provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationAssignment

        internal virtual CreateApplicationAssignmentResponse CreateApplicationAssignment(CreateApplicationAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationAssignmentResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Grant application access to a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplicationAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplicationAssignment">REST API Reference for CreateApplicationAssignment Operation</seealso>
        public virtual Task<CreateApplicationAssignmentResponse> CreateApplicationAssignmentAsync(CreateApplicationAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstance

        internal virtual CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates an instance of IAM Identity Center for a standalone Amazon Web Services account
        /// that is not managed by Organizations or a member Amazon Web Services account in an
        /// organization. You can create only one instance per account and across all Amazon Web
        /// Services Regions.
        /// 
        ///  
        /// <para>
        /// The CreateInstance request is rejected if the following apply: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The instance is created within the organization management account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An instance already exists in the same account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceAccessControlAttributeConfiguration

        internal virtual CreateInstanceAccessControlAttributeConfigurationResponse CreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Enables the attributes-based access control (ABAC) feature for the specified IAM Identity
        /// Center instance. You can also specify new attributes to add to your ABAC configuration
        /// during the enabling process. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// After a successful response, call <c>DescribeInstanceAccessControlAttributeConfiguration</c>
        /// to validate that <c>InstanceAccessControlAttributeConfiguration</c> was created.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstanceAccessControlAttributeConfiguration">REST API Reference for CreateInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual Task<CreateInstanceAccessControlAttributeConfigurationResponse> CreateInstanceAccessControlAttributeConfigurationAsync(CreateInstanceAccessControlAttributeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceAccessControlAttributeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePermissionSet

        internal virtual CreatePermissionSetResponse CreatePermissionSet(CreatePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionSetResponseUnmarshaller.Instance;

            return Invoke<CreatePermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Creates a permission set within a specified IAM Identity Center instance.
        /// 
        ///  <note> 
        /// <para>
        /// To grant users and groups access to Amazon Web Services account resources, use <c>
        /// <a>CreateAccountAssignment</a> </c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreatePermissionSet">REST API Reference for CreatePermissionSet Operation</seealso>
        public virtual Task<CreatePermissionSetResponse> CreatePermissionSetAsync(CreatePermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrustedTokenIssuer

        internal virtual CreateTrustedTokenIssuerResponse CreateTrustedTokenIssuer(CreateTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<CreateTrustedTokenIssuerResponse>(request, options);
        }



        /// <summary>
        /// Creates a connection to a trusted token issuer in an instance of IAM Identity Center.
        /// A trusted token issuer enables trusted identity propagation to be used with applications
        /// that authenticate outside of Amazon Web Services.
        /// 
        ///  
        /// <para>
        /// This trusted token issuer describes an external identity provider (IdP) that can generate
        /// claims or assertions in the form of access tokens for a user. Applications enabled
        /// for IAM Identity Center can use these tokens for authentication. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustedTokenIssuer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateTrustedTokenIssuer">REST API Reference for CreateTrustedTokenIssuer Operation</seealso>
        public virtual Task<CreateTrustedTokenIssuerResponse> CreateTrustedTokenIssuerAsync(CreateTrustedTokenIssuerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrustedTokenIssuerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccountAssignment

        internal virtual DeleteAccountAssignmentResponse DeleteAccountAssignment(DeleteAccountAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a principal's access from a specified Amazon Web Services account using a
        /// specified permission set.
        /// 
        ///  <note> 
        /// <para>
        /// After a successful response, call <c>DescribeAccountAssignmentDeletionStatus</c> to
        /// describe the status of an assignment deletion request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteAccountAssignment">REST API Reference for DeleteAccountAssignment Operation</seealso>
        public virtual Task<DeleteAccountAssignmentResponse> DeleteAccountAssignmentAsync(DeleteAccountAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the association with the application. The connected service resource still
        /// exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationAccessScope

        internal virtual DeleteApplicationAccessScopeResponse DeleteApplicationAccessScope(DeleteApplicationAccessScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAccessScopeResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationAccessScopeResponse>(request, options);
        }



        /// <summary>
        /// Deletes an IAM Identity Center access scope from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAccessScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationAccessScope service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAccessScope">REST API Reference for DeleteApplicationAccessScope Operation</seealso>
        public virtual Task<DeleteApplicationAccessScopeResponse> DeleteApplicationAccessScopeAsync(DeleteApplicationAccessScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAccessScopeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationAccessScopeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationAssignment

        internal virtual DeleteApplicationAssignmentResponse DeleteApplicationAssignment(DeleteApplicationAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Revoke application access to an application by deleting application assignments for
        /// a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAssignment">REST API Reference for DeleteApplicationAssignment Operation</seealso>
        public virtual Task<DeleteApplicationAssignmentResponse> DeleteApplicationAssignmentAsync(DeleteApplicationAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationAuthenticationMethod

        internal virtual DeleteApplicationAuthenticationMethodResponse DeleteApplicationAuthenticationMethod(DeleteApplicationAuthenticationMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationAuthenticationMethodResponse>(request, options);
        }



        /// <summary>
        /// Deletes an authentication method from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAuthenticationMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationAuthenticationMethod service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAuthenticationMethod">REST API Reference for DeleteApplicationAuthenticationMethod Operation</seealso>
        public virtual Task<DeleteApplicationAuthenticationMethodResponse> DeleteApplicationAuthenticationMethodAsync(DeleteApplicationAuthenticationMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationAuthenticationMethodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationGrant

        internal virtual DeleteApplicationGrantResponse DeleteApplicationGrant(DeleteApplicationGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationGrantResponse>(request, options);
        }



        /// <summary>
        /// Deletes a grant from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationGrant service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationGrant">REST API Reference for DeleteApplicationGrant Operation</seealso>
        public virtual Task<DeleteApplicationGrantResponse> DeleteApplicationGrantAsync(DeleteApplicationGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationGrantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInlinePolicyFromPermissionSet

        internal virtual DeleteInlinePolicyFromPermissionSetResponse DeleteInlinePolicyFromPermissionSet(DeleteInlinePolicyFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInlinePolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInlinePolicyFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DeleteInlinePolicyFromPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes the inline policy from a specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInlinePolicyFromPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInlinePolicyFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInlinePolicyFromPermissionSet">REST API Reference for DeleteInlinePolicyFromPermissionSet Operation</seealso>
        public virtual Task<DeleteInlinePolicyFromPermissionSetResponse> DeleteInlinePolicyFromPermissionSetAsync(DeleteInlinePolicyFromPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInlinePolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInlinePolicyFromPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInlinePolicyFromPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstance

        internal virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
        }



        /// <summary>
        /// Deletes the instance of IAM Identity Center. Only the account that owns the instance
        /// can call this API. Neither the delegated administrator nor member account can delete
        /// the organization instance, but those roles can delete their own instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstanceAccessControlAttributeConfiguration

        internal virtual DeleteInstanceAccessControlAttributeConfigurationResponse DeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Disables the attributes-based access control (ABAC) feature for the specified IAM
        /// Identity Center instance and deletes all of the attribute mappings that have been
        /// configured. Once deleted, any attributes that are received from an identity source
        /// and any custom attributes you have previously configured will not be passed. For more
        /// information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstanceAccessControlAttributeConfiguration">REST API Reference for DeleteInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual Task<DeleteInstanceAccessControlAttributeConfigurationResponse> DeleteInstanceAccessControlAttributeConfigurationAsync(DeleteInstanceAccessControlAttributeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceAccessControlAttributeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePermissionsBoundaryFromPermissionSet

        internal virtual DeletePermissionsBoundaryFromPermissionSetResponse DeletePermissionsBoundaryFromPermissionSet(DeletePermissionsBoundaryFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionsBoundaryFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionsBoundaryFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionsBoundaryFromPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes the permissions boundary from a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionsBoundaryFromPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermissionsBoundaryFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionsBoundaryFromPermissionSet">REST API Reference for DeletePermissionsBoundaryFromPermissionSet Operation</seealso>
        public virtual Task<DeletePermissionsBoundaryFromPermissionSetResponse> DeletePermissionsBoundaryFromPermissionSetAsync(DeletePermissionsBoundaryFromPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionsBoundaryFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionsBoundaryFromPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePermissionsBoundaryFromPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePermissionSet

        internal virtual DeletePermissionSetResponse DeletePermissionSet(DeletePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionSetResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionSet">REST API Reference for DeletePermissionSet Operation</seealso>
        public virtual Task<DeletePermissionSetResponse> DeletePermissionSetAsync(DeletePermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrustedTokenIssuer

        internal virtual DeleteTrustedTokenIssuerResponse DeleteTrustedTokenIssuer(DeleteTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustedTokenIssuerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a trusted token issuer configuration from an instance of IAM Identity Center.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting this trusted token issuer configuration will cause users to lose access to
        /// any applications that are configured to use the trusted token issuer.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustedTokenIssuer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteTrustedTokenIssuer">REST API Reference for DeleteTrustedTokenIssuer Operation</seealso>
        public virtual Task<DeleteTrustedTokenIssuerResponse> DeleteTrustedTokenIssuerAsync(DeleteTrustedTokenIssuerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustedTokenIssuerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrustedTokenIssuerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAssignmentCreationStatus

        internal virtual DescribeAccountAssignmentCreationStatusResponse DescribeAccountAssignmentCreationStatus(DescribeAccountAssignmentCreationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAssignmentCreationStatusResponse>(request, options);
        }



        /// <summary>
        /// Describes the status of the assignment creation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentCreationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAssignmentCreationStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentCreationStatus">REST API Reference for DescribeAccountAssignmentCreationStatus Operation</seealso>
        public virtual Task<DescribeAccountAssignmentCreationStatusResponse> DescribeAccountAssignmentCreationStatusAsync(DescribeAccountAssignmentCreationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAssignmentCreationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAssignmentDeletionStatus

        internal virtual DescribeAccountAssignmentDeletionStatusResponse DescribeAccountAssignmentDeletionStatus(DescribeAccountAssignmentDeletionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAssignmentDeletionStatusResponse>(request, options);
        }



        /// <summary>
        /// Describes the status of the assignment deletion request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAssignmentDeletionStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentDeletionStatus">REST API Reference for DescribeAccountAssignmentDeletionStatus Operation</seealso>
        public virtual Task<DescribeAccountAssignmentDeletionStatusResponse> DescribeAccountAssignmentDeletionStatusAsync(DescribeAccountAssignmentDeletionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAssignmentDeletionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplication

        internal virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of an application associated with an instance of IAM Identity
        /// Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationAssignment

        internal virtual DescribeApplicationAssignmentResponse DescribeApplicationAssignment(DescribeApplicationAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationAssignmentResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a direct assignment of a user or group to an application. If the user doesn’t
        /// have a direct assignment to the application, the user may still have access to the
        /// application through a group. Therefore, don’t use this API to test access to an application
        /// for a user. Instead use <a>ListApplicationAssignmentsForPrincipal</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationAssignment">REST API Reference for DescribeApplicationAssignment Operation</seealso>
        public virtual Task<DescribeApplicationAssignmentResponse> DescribeApplicationAssignmentAsync(DescribeApplicationAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationAssignmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationProvider

        internal virtual DescribeApplicationProviderResponse DescribeApplicationProvider(DescribeApplicationProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationProviderResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationProviderResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about a provider that can be used to connect an Amazon Web Services
        /// managed application or customer managed application to IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationProvider service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationProvider">REST API Reference for DescribeApplicationProvider Operation</seealso>
        public virtual Task<DescribeApplicationProviderResponse> DescribeApplicationProviderAsync(DescribeApplicationProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstance

        internal virtual DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceResponse>(request, options);
        }



        /// <summary>
        /// Returns the details of an instance of IAM Identity Center. The status can be one of
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The instance is in the process of being created. When
        /// the instance is ready for use, DescribeInstance returns the status of <c>ACTIVE</c>.
        /// While the instance is in the <c>CREATE_IN_PROGRESS</c> state, you can call only DescribeInstance
        /// and DeleteInstance operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_IN_PROGRESS</c> - The instance is being deleted. Returns <c>AccessDeniedException</c>
        /// after the delete operation completes. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The instance is active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        public virtual Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAccessControlAttributeConfiguration

        internal virtual DescribeInstanceAccessControlAttributeConfigurationResponse DescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of IAM Identity Center identity store attributes that have been configured
        /// to work with attributes-based access control (ABAC) for the specified IAM Identity
        /// Center instance. This will not return attributes configured and sent by an external
        /// identity provider. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstanceAccessControlAttributeConfiguration">REST API Reference for DescribeInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual Task<DescribeInstanceAccessControlAttributeConfigurationResponse> DescribeInstanceAccessControlAttributeConfigurationAsync(DescribeInstanceAccessControlAttributeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAccessControlAttributeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePermissionSet

        internal virtual DescribePermissionSetResponse DescribePermissionSet(DescribePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetResponseUnmarshaller.Instance;

            return Invoke<DescribePermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSet">REST API Reference for DescribePermissionSet Operation</seealso>
        public virtual Task<DescribePermissionSetResponse> DescribePermissionSetAsync(DescribePermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePermissionSetProvisioningStatus

        internal virtual DescribePermissionSetProvisioningStatusResponse DescribePermissionSetProvisioningStatus(DescribePermissionSetProvisioningStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return Invoke<DescribePermissionSetProvisioningStatusResponse>(request, options);
        }



        /// <summary>
        /// Describes the status for the given permission set provisioning request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSetProvisioningStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePermissionSetProvisioningStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSetProvisioningStatus">REST API Reference for DescribePermissionSetProvisioningStatus Operation</seealso>
        public virtual Task<DescribePermissionSetProvisioningStatusResponse> DescribePermissionSetProvisioningStatusAsync(DescribePermissionSetProvisioningStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePermissionSetProvisioningStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrustedTokenIssuer

        internal virtual DescribeTrustedTokenIssuerResponse DescribeTrustedTokenIssuer(DescribeTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustedTokenIssuerResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about a trusted token issuer configuration stored in an instance
        /// of IAM Identity Center. Details include the name of the trusted token issuer, the
        /// issuer URL, and the path of the source attribute and the destination attribute for
        /// a trusted token issuer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedTokenIssuer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeTrustedTokenIssuer">REST API Reference for DescribeTrustedTokenIssuer Operation</seealso>
        public virtual Task<DescribeTrustedTokenIssuerResponse> DescribeTrustedTokenIssuerAsync(DescribeTrustedTokenIssuerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustedTokenIssuerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustedTokenIssuerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachCustomerManagedPolicyReferenceFromPermissionSet

        internal virtual DetachCustomerManagedPolicyReferenceFromPermissionSetResponse DetachCustomerManagedPolicyReferenceFromPermissionSet(DetachCustomerManagedPolicyReferenceFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DetachCustomerManagedPolicyReferenceFromPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Detaches the specified customer managed policy from the specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachCustomerManagedPolicyReferenceFromPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachCustomerManagedPolicyReferenceFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachCustomerManagedPolicyReferenceFromPermissionSet">REST API Reference for DetachCustomerManagedPolicyReferenceFromPermissionSet Operation</seealso>
        public virtual Task<DetachCustomerManagedPolicyReferenceFromPermissionSetResponse> DetachCustomerManagedPolicyReferenceFromPermissionSetAsync(DetachCustomerManagedPolicyReferenceFromPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<DetachCustomerManagedPolicyReferenceFromPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachManagedPolicyFromPermissionSet

        internal virtual DetachManagedPolicyFromPermissionSetResponse DetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachManagedPolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachManagedPolicyFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DetachManagedPolicyFromPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Detaches the attached Amazon Web Services managed policy ARN from the specified permission
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachManagedPolicyFromPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachManagedPolicyFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachManagedPolicyFromPermissionSet">REST API Reference for DetachManagedPolicyFromPermissionSet Operation</seealso>
        public virtual Task<DetachManagedPolicyFromPermissionSetResponse> DetachManagedPolicyFromPermissionSetAsync(DetachManagedPolicyFromPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachManagedPolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachManagedPolicyFromPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<DetachManagedPolicyFromPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationAccessScope

        internal virtual GetApplicationAccessScopeResponse GetApplicationAccessScope(GetApplicationAccessScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAccessScopeResponseUnmarshaller.Instance;

            return Invoke<GetApplicationAccessScopeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the authorized targets for an IAM Identity Center access scope for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAccessScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationAccessScope service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAccessScope">REST API Reference for GetApplicationAccessScope Operation</seealso>
        public virtual Task<GetApplicationAccessScopeResponse> GetApplicationAccessScopeAsync(GetApplicationAccessScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAccessScopeResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationAccessScopeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationAssignmentConfiguration

        internal virtual GetApplicationAssignmentConfigurationResponse GetApplicationAssignmentConfiguration(GetApplicationAssignmentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationAssignmentConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the configuration of <a>PutApplicationAssignmentConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAssignmentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationAssignmentConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAssignmentConfiguration">REST API Reference for GetApplicationAssignmentConfiguration Operation</seealso>
        public virtual Task<GetApplicationAssignmentConfigurationResponse> GetApplicationAssignmentConfigurationAsync(GetApplicationAssignmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationAssignmentConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationAuthenticationMethod

        internal virtual GetApplicationAuthenticationMethodResponse GetApplicationAuthenticationMethod(GetApplicationAuthenticationMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return Invoke<GetApplicationAuthenticationMethodResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about an authentication method used by an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAuthenticationMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationAuthenticationMethod service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAuthenticationMethod">REST API Reference for GetApplicationAuthenticationMethod Operation</seealso>
        public virtual Task<GetApplicationAuthenticationMethodResponse> GetApplicationAuthenticationMethodAsync(GetApplicationAuthenticationMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationAuthenticationMethodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationGrant

        internal virtual GetApplicationGrantResponse GetApplicationGrant(GetApplicationGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationGrantResponseUnmarshaller.Instance;

            return Invoke<GetApplicationGrantResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about an application grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationGrant service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationGrant">REST API Reference for GetApplicationGrant Operation</seealso>
        public virtual Task<GetApplicationGrantResponse> GetApplicationGrantAsync(GetApplicationGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationGrantResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInlinePolicyForPermissionSet

        internal virtual GetInlinePolicyForPermissionSetResponse GetInlinePolicyForPermissionSet(GetInlinePolicyForPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInlinePolicyForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInlinePolicyForPermissionSetResponseUnmarshaller.Instance;

            return Invoke<GetInlinePolicyForPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Obtains the inline policy assigned to the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInlinePolicyForPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInlinePolicyForPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetInlinePolicyForPermissionSet">REST API Reference for GetInlinePolicyForPermissionSet Operation</seealso>
        public virtual Task<GetInlinePolicyForPermissionSetResponse> GetInlinePolicyForPermissionSetAsync(GetInlinePolicyForPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInlinePolicyForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInlinePolicyForPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetInlinePolicyForPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPermissionsBoundaryForPermissionSet

        internal virtual GetPermissionsBoundaryForPermissionSetResponse GetPermissionsBoundaryForPermissionSet(GetPermissionsBoundaryForPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionsBoundaryForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionsBoundaryForPermissionSetResponseUnmarshaller.Instance;

            return Invoke<GetPermissionsBoundaryForPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Obtains the permissions boundary for a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionsBoundaryForPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPermissionsBoundaryForPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetPermissionsBoundaryForPermissionSet">REST API Reference for GetPermissionsBoundaryForPermissionSet Operation</seealso>
        public virtual Task<GetPermissionsBoundaryForPermissionSetResponse> GetPermissionsBoundaryForPermissionSetAsync(GetPermissionsBoundaryForPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionsBoundaryForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionsBoundaryForPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetPermissionsBoundaryForPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountAssignmentCreationStatus

        internal virtual ListAccountAssignmentCreationStatusResponse ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentCreationStatusResponse>(request, options);
        }



        /// <summary>
        /// Lists the status of the Amazon Web Services account assignment creation requests for
        /// a specified IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentCreationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAssignmentCreationStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentCreationStatus">REST API Reference for ListAccountAssignmentCreationStatus Operation</seealso>
        public virtual Task<ListAccountAssignmentCreationStatusResponse> ListAccountAssignmentCreationStatusAsync(ListAccountAssignmentCreationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountAssignmentCreationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountAssignmentDeletionStatus

        internal virtual ListAccountAssignmentDeletionStatusResponse ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentDeletionStatusResponse>(request, options);
        }



        /// <summary>
        /// Lists the status of the Amazon Web Services account assignment deletion requests for
        /// a specified IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAssignmentDeletionStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentDeletionStatus">REST API Reference for ListAccountAssignmentDeletionStatus Operation</seealso>
        public virtual Task<ListAccountAssignmentDeletionStatusResponse> ListAccountAssignmentDeletionStatusAsync(ListAccountAssignmentDeletionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountAssignmentDeletionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountAssignments

        internal virtual ListAccountAssignmentsResponse ListAccountAssignments(ListAccountAssignmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the assignee of the specified Amazon Web Services account with the specified
        /// permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAssignments service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignments">REST API Reference for ListAccountAssignments Operation</seealso>
        public virtual Task<ListAccountAssignmentsResponse> ListAccountAssignmentsAsync(ListAccountAssignmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountAssignmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountAssignmentsForPrincipal

        internal virtual ListAccountAssignmentsForPrincipalResponse ListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentsForPrincipalResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of the IAM Identity Center associated Amazon Web Services accounts
        /// that the principal has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentsForPrincipal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAssignmentsForPrincipal service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentsForPrincipal">REST API Reference for ListAccountAssignmentsForPrincipal Operation</seealso>
        public virtual Task<ListAccountAssignmentsForPrincipalResponse> ListAccountAssignmentsForPrincipalAsync(ListAccountAssignmentsForPrincipalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountAssignmentsForPrincipalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountsForProvisionedPermissionSet

        internal virtual ListAccountsForProvisionedPermissionSetResponse ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsForProvisionedPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsForProvisionedPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ListAccountsForProvisionedPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Lists all the Amazon Web Services accounts where the specified permission set is provisioned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForProvisionedPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountsForProvisionedPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountsForProvisionedPermissionSet">REST API Reference for ListAccountsForProvisionedPermissionSet Operation</seealso>
        public virtual Task<ListAccountsForProvisionedPermissionSetResponse> ListAccountsForProvisionedPermissionSetAsync(ListAccountsForProvisionedPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsForProvisionedPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsForProvisionedPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountsForProvisionedPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationAccessScopes

        internal virtual ListApplicationAccessScopesResponse ListApplicationAccessScopes(ListApplicationAccessScopesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAccessScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAccessScopesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAccessScopesResponse>(request, options);
        }



        /// <summary>
        /// Lists the access scopes and authorized targets associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAccessScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationAccessScopes service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAccessScopes">REST API Reference for ListApplicationAccessScopes Operation</seealso>
        public virtual Task<ListApplicationAccessScopesResponse> ListApplicationAccessScopesAsync(ListApplicationAccessScopesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAccessScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAccessScopesResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationAccessScopesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationAssignments

        internal virtual ListApplicationAssignmentsResponse ListApplicationAssignments(ListApplicationAssignmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAssignmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon Web Services account users that are assigned to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationAssignments service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignments">REST API Reference for ListApplicationAssignments Operation</seealso>
        public virtual Task<ListApplicationAssignmentsResponse> ListApplicationAssignmentsAsync(ListApplicationAssignmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationAssignmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationAssignmentsForPrincipal

        internal virtual ListApplicationAssignmentsForPrincipalResponse ListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAssignmentsForPrincipalResponse>(request, options);
        }



        /// <summary>
        /// Lists the applications to which a specified principal is assigned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignmentsForPrincipal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationAssignmentsForPrincipal service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignmentsForPrincipal">REST API Reference for ListApplicationAssignmentsForPrincipal Operation</seealso>
        public virtual Task<ListApplicationAssignmentsForPrincipalResponse> ListApplicationAssignmentsForPrincipalAsync(ListApplicationAssignmentsForPrincipalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationAssignmentsForPrincipalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationAuthenticationMethods

        internal virtual ListApplicationAuthenticationMethodsResponse ListApplicationAuthenticationMethods(ListApplicationAuthenticationMethodsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAuthenticationMethodsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAuthenticationMethodsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAuthenticationMethodsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the authentication methods supported by the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAuthenticationMethods service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationAuthenticationMethods service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAuthenticationMethods">REST API Reference for ListApplicationAuthenticationMethods Operation</seealso>
        public virtual Task<ListApplicationAuthenticationMethodsResponse> ListApplicationAuthenticationMethodsAsync(ListApplicationAuthenticationMethodsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAuthenticationMethodsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAuthenticationMethodsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationAuthenticationMethodsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationGrants

        internal virtual ListApplicationGrantsResponse ListApplicationGrants(ListApplicationGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationGrantsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationGrantsResponse>(request, options);
        }



        /// <summary>
        /// List the grants associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationGrants service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationGrants">REST API Reference for ListApplicationGrants Operation</seealso>
        public virtual Task<ListApplicationGrantsResponse> ListApplicationGrantsAsync(ListApplicationGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationProviders

        internal virtual ListApplicationProvidersResponse ListApplicationProviders(ListApplicationProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationProvidersResponseUnmarshaller.Instance;

            return Invoke<ListApplicationProvidersResponse>(request, options);
        }



        /// <summary>
        /// Lists the application providers configured in the IAM Identity Center identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationProviders service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationProviders">REST API Reference for ListApplicationProviders Operation</seealso>
        public virtual Task<ListApplicationProvidersResponse> ListApplicationProvidersAsync(ListApplicationProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all applications associated with the instance of IAM Identity Center. When listing
        /// applications for an instance in the management account, member accounts must use the
        /// <c>applicationAccount</c> parameter to filter the list to only applications created
        /// from that account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomerManagedPolicyReferencesInPermissionSet

        internal virtual ListCustomerManagedPolicyReferencesInPermissionSetResponse ListCustomerManagedPolicyReferencesInPermissionSet(ListCustomerManagedPolicyReferencesInPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomerManagedPolicyReferencesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomerManagedPolicyReferencesInPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ListCustomerManagedPolicyReferencesInPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Lists all customer managed policies attached to a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomerManagedPolicyReferencesInPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomerManagedPolicyReferencesInPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListCustomerManagedPolicyReferencesInPermissionSet">REST API Reference for ListCustomerManagedPolicyReferencesInPermissionSet Operation</seealso>
        public virtual Task<ListCustomerManagedPolicyReferencesInPermissionSetResponse> ListCustomerManagedPolicyReferencesInPermissionSetAsync(ListCustomerManagedPolicyReferencesInPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomerManagedPolicyReferencesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomerManagedPolicyReferencesInPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomerManagedPolicyReferencesInPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstances

        internal virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }



        /// <summary>
        /// Lists the details of the organization and account instances of IAM Identity Center
        /// that were created in or visible to the account calling this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListManagedPoliciesInPermissionSet

        internal virtual ListManagedPoliciesInPermissionSetResponse ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedPoliciesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedPoliciesInPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ListManagedPoliciesInPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon Web Services managed policy that is attached to a specified permission
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedPoliciesInPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedPoliciesInPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListManagedPoliciesInPermissionSet">REST API Reference for ListManagedPoliciesInPermissionSet Operation</seealso>
        public virtual Task<ListManagedPoliciesInPermissionSetResponse> ListManagedPoliciesInPermissionSetAsync(ListManagedPoliciesInPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedPoliciesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedPoliciesInPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedPoliciesInPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPermissionSetProvisioningStatus

        internal virtual ListPermissionSetProvisioningStatusResponse ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return Invoke<ListPermissionSetProvisioningStatusResponse>(request, options);
        }



        /// <summary>
        /// Lists the status of the permission set provisioning requests for a specified IAM Identity
        /// Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetProvisioningStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissionSetProvisioningStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetProvisioningStatus">REST API Reference for ListPermissionSetProvisioningStatus Operation</seealso>
        public virtual Task<ListPermissionSetProvisioningStatusResponse> ListPermissionSetProvisioningStatusAsync(ListPermissionSetProvisioningStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionSetProvisioningStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPermissionSets

        internal virtual ListPermissionSetsResponse ListPermissionSets(ListPermissionSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionSetsResponse>(request, options);
        }



        /// <summary>
        /// Lists the <a>PermissionSet</a>s in an IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissionSets service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSets">REST API Reference for ListPermissionSets Operation</seealso>
        public virtual Task<ListPermissionSetsResponse> ListPermissionSetsAsync(ListPermissionSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPermissionSetsProvisionedToAccount

        internal virtual ListPermissionSetsProvisionedToAccountResponse ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsProvisionedToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsProvisionedToAccountResponseUnmarshaller.Instance;

            return Invoke<ListPermissionSetsProvisionedToAccountResponse>(request, options);
        }



        /// <summary>
        /// Lists all the permission sets that are provisioned to a specified Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetsProvisionedToAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissionSetsProvisionedToAccount service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetsProvisionedToAccount">REST API Reference for ListPermissionSetsProvisionedToAccount Operation</seealso>
        public virtual Task<ListPermissionSetsProvisionedToAccountResponse> ListPermissionSetsProvisionedToAccountAsync(ListPermissionSetsProvisionedToAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsProvisionedToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsProvisionedToAccountResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionSetsProvisionedToAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags that are attached to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrustedTokenIssuers

        internal virtual ListTrustedTokenIssuersResponse ListTrustedTokenIssuers(ListTrustedTokenIssuersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustedTokenIssuersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustedTokenIssuersResponseUnmarshaller.Instance;

            return Invoke<ListTrustedTokenIssuersResponse>(request, options);
        }



        /// <summary>
        /// Lists all the trusted token issuers configured in an instance of IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustedTokenIssuers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrustedTokenIssuers service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTrustedTokenIssuers">REST API Reference for ListTrustedTokenIssuers Operation</seealso>
        public virtual Task<ListTrustedTokenIssuersResponse> ListTrustedTokenIssuersAsync(ListTrustedTokenIssuersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustedTokenIssuersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustedTokenIssuersResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrustedTokenIssuersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ProvisionPermissionSet

        internal virtual ProvisionPermissionSetResponse ProvisionPermissionSet(ProvisionPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ProvisionPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// The process by which a specified permission set is provisioned to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ProvisionPermissionSet">REST API Reference for ProvisionPermissionSet Operation</seealso>
        public virtual Task<ProvisionPermissionSetResponse> ProvisionPermissionSetAsync(ProvisionPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<ProvisionPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutApplicationAccessScope

        internal virtual PutApplicationAccessScopeResponse PutApplicationAccessScope(PutApplicationAccessScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAccessScopeResponseUnmarshaller.Instance;

            return Invoke<PutApplicationAccessScopeResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates the list of authorized targets for an IAM Identity Center access scope
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAccessScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutApplicationAccessScope service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAccessScope">REST API Reference for PutApplicationAccessScope Operation</seealso>
        public virtual Task<PutApplicationAccessScopeResponse> PutApplicationAccessScopeAsync(PutApplicationAccessScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAccessScopeResponseUnmarshaller.Instance;

            return InvokeAsync<PutApplicationAccessScopeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutApplicationAssignmentConfiguration

        internal virtual PutApplicationAssignmentConfigurationResponse PutApplicationAssignmentConfiguration(PutApplicationAssignmentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutApplicationAssignmentConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Configure how users gain access to an application. If <c>AssignmentsRequired</c> is
        /// <c>true</c> (default value), users don’t have access to the application unless an
        /// assignment is created using the <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment
        /// API</a>. If <c>false</c>, all users have access to the application. If an assignment
        /// is created using <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment</a>.,
        /// the user retains access if <c>AssignmentsRequired</c> is set to <c>true</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAssignmentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutApplicationAssignmentConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAssignmentConfiguration">REST API Reference for PutApplicationAssignmentConfiguration Operation</seealso>
        public virtual Task<PutApplicationAssignmentConfigurationResponse> PutApplicationAssignmentConfigurationAsync(PutApplicationAssignmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutApplicationAssignmentConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutApplicationAuthenticationMethod

        internal virtual PutApplicationAuthenticationMethodResponse PutApplicationAuthenticationMethod(PutApplicationAuthenticationMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return Invoke<PutApplicationAuthenticationMethodResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates an authentication method for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAuthenticationMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutApplicationAuthenticationMethod service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAuthenticationMethod">REST API Reference for PutApplicationAuthenticationMethod Operation</seealso>
        public virtual Task<PutApplicationAuthenticationMethodResponse> PutApplicationAuthenticationMethodAsync(PutApplicationAuthenticationMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return InvokeAsync<PutApplicationAuthenticationMethodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutApplicationGrant

        internal virtual PutApplicationGrantResponse PutApplicationGrant(PutApplicationGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationGrantResponseUnmarshaller.Instance;

            return Invoke<PutApplicationGrantResponse>(request, options);
        }



        /// <summary>
        /// Adds a grant to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutApplicationGrant service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationGrant">REST API Reference for PutApplicationGrant Operation</seealso>
        public virtual Task<PutApplicationGrantResponse> PutApplicationGrantAsync(PutApplicationGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationGrantResponseUnmarshaller.Instance;

            return InvokeAsync<PutApplicationGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutInlinePolicyToPermissionSet

        internal virtual PutInlinePolicyToPermissionSetResponse PutInlinePolicyToPermissionSet(PutInlinePolicyToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInlinePolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInlinePolicyToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<PutInlinePolicyToPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Attaches an inline policy to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <c> <a>ProvisionPermissionSet</a> </c> after this action to apply
        /// the corresponding IAM policy updates to all assigned accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInlinePolicyToPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInlinePolicyToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutInlinePolicyToPermissionSet">REST API Reference for PutInlinePolicyToPermissionSet Operation</seealso>
        public virtual Task<PutInlinePolicyToPermissionSetResponse> PutInlinePolicyToPermissionSetAsync(PutInlinePolicyToPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInlinePolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInlinePolicyToPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<PutInlinePolicyToPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPermissionsBoundaryToPermissionSet

        internal virtual PutPermissionsBoundaryToPermissionSetResponse PutPermissionsBoundaryToPermissionSet(PutPermissionsBoundaryToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionsBoundaryToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionsBoundaryToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<PutPermissionsBoundaryToPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Attaches an Amazon Web Services managed or customer managed policy to the specified
        /// <a>PermissionSet</a> as a permissions boundary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionsBoundaryToPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPermissionsBoundaryToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutPermissionsBoundaryToPermissionSet">REST API Reference for PutPermissionsBoundaryToPermissionSet Operation</seealso>
        public virtual Task<PutPermissionsBoundaryToPermissionSetResponse> PutPermissionsBoundaryToPermissionSetAsync(PutPermissionsBoundaryToPermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionsBoundaryToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionsBoundaryToPermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<PutPermissionsBoundaryToPermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates a set of tags with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a set of tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates application properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstance

        internal virtual UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceResponse>(request, options);
        }



        /// <summary>
        /// Update the details for the instance of IAM Identity Center that is owned by the Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstanceAccessControlAttributeConfiguration

        internal virtual UpdateInstanceAccessControlAttributeConfigurationResponse UpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the IAM Identity Center identity store attributes that you can use with the
        /// IAM Identity Center instance for attributes-based access control (ABAC). When using
        /// an external identity provider as an identity source, you can pass attributes through
        /// the SAML assertion as an alternative to configuring attributes from the IAM Identity
        /// Center identity store. If a SAML assertion passes any of these attributes, IAM Identity
        /// Center replaces the attribute value with the value from the IAM Identity Center identity
        /// store. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstanceAccessControlAttributeConfiguration">REST API Reference for UpdateInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual Task<UpdateInstanceAccessControlAttributeConfigurationResponse> UpdateInstanceAccessControlAttributeConfigurationAsync(UpdateInstanceAccessControlAttributeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceAccessControlAttributeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePermissionSet

        internal virtual UpdatePermissionSetResponse UpdatePermissionSet(UpdatePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePermissionSetResponseUnmarshaller.Instance;

            return Invoke<UpdatePermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdatePermissionSet">REST API Reference for UpdatePermissionSet Operation</seealso>
        public virtual Task<UpdatePermissionSetResponse> UpdatePermissionSetAsync(UpdatePermissionSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePermissionSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePermissionSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrustedTokenIssuer

        internal virtual UpdateTrustedTokenIssuerResponse UpdateTrustedTokenIssuer(UpdateTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustedTokenIssuerResponse>(request, options);
        }



        /// <summary>
        /// Updates the name of the trusted token issuer, or the path of a source attribute or
        /// destination attribute for a trusted token issuer configuration.
        /// 
        ///  <note> 
        /// <para>
        /// Updating this trusted token issuer configuration might cause users to lose access
        /// to any applications that are configured to use the trusted token issuer.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustedTokenIssuer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateTrustedTokenIssuer">REST API Reference for UpdateTrustedTokenIssuer Operation</seealso>
        public virtual Task<UpdateTrustedTokenIssuerResponse> UpdateTrustedTokenIssuerAsync(UpdateTrustedTokenIssuerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrustedTokenIssuerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSSOAdminEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}