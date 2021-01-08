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

namespace Amazon.SSOAdmin
{
    /// <summary>
    /// Implementation for accessing SSOAdmin
    ///
    /// 
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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


        #region  AttachManagedPolicyToPermissionSet

        internal virtual AttachManagedPolicyToPermissionSetResponse AttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachManagedPolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachManagedPolicyToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<AttachManagedPolicyToPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Attaches an IAM managed policy ARN to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <code> <a>ProvisionPermissionSet</a> </code> after this action to
        /// apply the corresponding IAM policy updates to all assigned accounts.
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
        /// Assigns access to a principal for a specified AWS account using a specified permission
        /// set.
        /// 
        ///  <note> 
        /// <para>
        /// The term <i>principal</i> here refers to a user or group that is defined in AWS SSO.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// As part of a successful <code>CreateAccountAssignment</code> call, the specified permission
        /// set will automatically be provisioned to the account in the form of an IAM policy
        /// attached to the SSO-created IAM role. If the permission set is subsequently updated,
        /// the corresponding IAM policies attached to roles in your accounts will not be updated
        /// automatically. In this case, you will need to call <code> <a>ProvisionPermissionSet</a>
        /// </code> to make these updates.
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
        
        #region  CreateInstanceAccessControlAttributeConfiguration

        internal virtual CreateInstanceAccessControlAttributeConfigurationResponse CreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Enables the attributes-based access control (ABAC) feature for the specified AWS SSO
        /// instance. You can also specify new attributes to add to your ABAC configuration during
        /// the enabling process. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        /// Creates a permission set within a specified SSO instance.
        /// 
        ///  <note> 
        /// <para>
        /// To grant users and groups access to AWS account resources, use <code> <a>CreateAccountAssignment</a>
        /// </code>.
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
        
        #region  DeleteAccountAssignment

        internal virtual DeleteAccountAssignmentResponse DeleteAccountAssignment(DeleteAccountAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a principal's access from a specified AWS account using a specified permission
        /// set.
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
        
        #region  DeleteInstanceAccessControlAttributeConfiguration

        internal virtual DeleteInstanceAccessControlAttributeConfigurationResponse DeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Disables the attributes-based access control (ABAC) feature for the specified AWS
        /// SSO instance and deletes all of the attribute mappings that have been configured.
        /// Once deleted, any attributes that are received from an identity source and any custom
        /// attributes you have previously configured will not be passed. For more information
        /// about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        
        #region  DescribeInstanceAccessControlAttributeConfiguration

        internal virtual DescribeInstanceAccessControlAttributeConfigurationResponse DescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of AWS SSO identity store attributes that have been configured to
        /// work with attributes-based access control (ABAC) for the specified AWS SSO instance.
        /// This will not return attributes configured and sent by an external identity provider.
        /// For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        
        #region  DetachManagedPolicyFromPermissionSet

        internal virtual DetachManagedPolicyFromPermissionSetResponse DetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachManagedPolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachManagedPolicyFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DetachManagedPolicyFromPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Detaches the attached IAM managed policy ARN from the specified permission set.
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
        
        #region  ListAccountAssignmentCreationStatus

        internal virtual ListAccountAssignmentCreationStatusResponse ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentCreationStatusResponse>(request, options);
        }



        /// <summary>
        /// Lists the status of the AWS account assignment creation requests for a specified SSO
        /// instance.
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
        /// Lists the status of the AWS account assignment deletion requests for a specified SSO
        /// instance.
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
        /// Lists the assignee of the specified AWS account with the specified permission set.
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
        
        #region  ListAccountsForProvisionedPermissionSet

        internal virtual ListAccountsForProvisionedPermissionSetResponse ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsForProvisionedPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsForProvisionedPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ListAccountsForProvisionedPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Lists all the AWS accounts where the specified permission set is provisioned.
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
        
        #region  ListInstances

        internal virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }



        /// <summary>
        /// Lists the SSO instances that the caller has access to.
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
        /// Lists the IAM managed policy that is attached to a specified permission set.
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
        /// Lists the status of the permission set provisioning requests for a specified SSO instance.
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
        /// Lists the <a>PermissionSet</a>s in an SSO instance.
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
        /// Lists all the permission sets that are provisioned to a specified AWS account.
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
        
        #region  PutInlinePolicyToPermissionSet

        internal virtual PutInlinePolicyToPermissionSetResponse PutInlinePolicyToPermissionSet(PutInlinePolicyToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInlinePolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInlinePolicyToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<PutInlinePolicyToPermissionSetResponse>(request, options);
        }



        /// <summary>
        /// Attaches an IAM inline policy to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <code> <a>ProvisionPermissionSet</a> </code> after this action to
        /// apply the corresponding IAM policy updates to all assigned accounts.
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
        
        #region  UpdateInstanceAccessControlAttributeConfiguration

        internal virtual UpdateInstanceAccessControlAttributeConfigurationResponse UpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the AWS SSO identity store attributes to use with the AWS SSO instance for
        /// attributes-based access control (ABAC). When using an external identity provider as
        /// an identity source, you can pass attributes through the SAML assertion as an alternative
        /// to configuring attributes from the AWS SSO identity store. If a SAML assertion passes
        /// any of these attributes, AWS SSO will replace the attribute value with the value from
        /// the AWS SSO identity store. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        
    }
}