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
    /// IAM Identity Center is the Amazon Web Services solution for connecting your workforce
    /// users to Amazon Web Services managed applications and other Amazon Web Services resources.
    /// You can connect your existing identity provider and synchronize users and groups from
    /// your directory, or create and manage your users directly in IAM Identity Center. You
    /// can then use IAM Identity Center for either or both of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// User access to applications
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User access to Amazon Web Services accounts
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This guide provides information about single sign-on operations that you can use for
    /// access to applications and Amazon Web Services accounts. For information about IAM
    /// Identity Center features, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">IAM
    /// Identity Center User Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// IAM Identity Center uses the <c>sso</c> and <c>identitystore</c> API namespaces.
    /// </para>
    ///  </note> 
    /// <para>
    /// Many API operations for IAM Identity Center rely on identifiers for users and groups,
    /// known as principals. For more information about how to work with principals and principal
    /// IDs in IAM Identity Center, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/welcome.html">Identity
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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Attaches the specified customer managed policy to the specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachCustomerManagedPolicyReferenceToPermissionSet service method.</param>
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
        public virtual AttachCustomerManagedPolicyReferenceToPermissionSetResponse AttachCustomerManagedPolicyReferenceToPermissionSet(AttachCustomerManagedPolicyReferenceToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<AttachCustomerManagedPolicyReferenceToPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachCustomerManagedPolicyReferenceToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachCustomerManagedPolicyReferenceToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachCustomerManagedPolicyReferenceToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachCustomerManagedPolicyReferenceToPermissionSet">REST API Reference for AttachCustomerManagedPolicyReferenceToPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginAttachCustomerManagedPolicyReferenceToPermissionSet(AttachCustomerManagedPolicyReferenceToPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachCustomerManagedPolicyReferenceToPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachCustomerManagedPolicyReferenceToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachCustomerManagedPolicyReferenceToPermissionSet.</param>
        /// 
        /// <returns>Returns a  AttachCustomerManagedPolicyReferenceToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachCustomerManagedPolicyReferenceToPermissionSet">REST API Reference for AttachCustomerManagedPolicyReferenceToPermissionSet Operation</seealso>
        public virtual AttachCustomerManagedPolicyReferenceToPermissionSetResponse EndAttachCustomerManagedPolicyReferenceToPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachCustomerManagedPolicyReferenceToPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachManagedPolicyToPermissionSet

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
        public virtual AttachManagedPolicyToPermissionSetResponse AttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachManagedPolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachManagedPolicyToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<AttachManagedPolicyToPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachManagedPolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachManagedPolicyToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachManagedPolicyToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachManagedPolicyToPermissionSet">REST API Reference for AttachManagedPolicyToPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginAttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachManagedPolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachManagedPolicyToPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachManagedPolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachManagedPolicyToPermissionSet.</param>
        /// 
        /// <returns>Returns a  AttachManagedPolicyToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachManagedPolicyToPermissionSet">REST API Reference for AttachManagedPolicyToPermissionSet Operation</seealso>
        public virtual AttachManagedPolicyToPermissionSetResponse EndAttachManagedPolicyToPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachManagedPolicyToPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccountAssignment

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
        public virtual CreateAccountAssignmentResponse CreateAccountAssignment(CreateAccountAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAssignmentResponseUnmarshaller.Instance;

            return Invoke<CreateAccountAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateAccountAssignment">REST API Reference for CreateAccountAssignment Operation</seealso>
        public virtual IAsyncResult BeginCreateAccountAssignment(CreateAccountAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAssignment.</param>
        /// 
        /// <returns>Returns a  CreateAccountAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateAccountAssignment">REST API Reference for CreateAccountAssignment Operation</seealso>
        public virtual CreateAccountAssignmentResponse EndCreateAccountAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccountAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Creates an OAuth 2.0 customer managed application in IAM Identity Center for the given
        /// application provider.
        /// 
        ///  <note> 
        /// <para>
        /// This API does not support creating SAML 2.0 customer managed applications or Amazon
        /// Web Services managed applications. To learn how to create an Amazon Web Services managed
        /// application, see the application user guide. You can create a SAML 2.0 customer managed
        /// application in the Amazon Web Services Management Console only. See <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/customermanagedapps-saml2-setup.html">Setting
        /// up customer managed SAML 2.0 applications</a>. For more information on these application
        /// types, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/awsapps.html">Amazon
        /// Web Services managed applications</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
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
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplicationAssignment

        /// <summary>
        /// Grant application access to a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationAssignment service method.</param>
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
        public virtual CreateApplicationAssignmentResponse CreateApplicationAssignment(CreateApplicationAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationAssignmentResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplicationAssignment">REST API Reference for CreateApplicationAssignment Operation</seealso>
        public virtual IAsyncResult BeginCreateApplicationAssignment(CreateApplicationAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationAssignment.</param>
        /// 
        /// <returns>Returns a  CreateApplicationAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplicationAssignment">REST API Reference for CreateApplicationAssignment Operation</seealso>
        public virtual CreateApplicationAssignmentResponse EndCreateApplicationAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstance

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
        public virtual CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        public virtual CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstanceAccessControlAttributeConfiguration

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
        public virtual CreateInstanceAccessControlAttributeConfigurationResponse CreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstanceAccessControlAttributeConfiguration">REST API Reference for CreateInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstanceAccessControlAttributeConfiguration">REST API Reference for CreateInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual CreateInstanceAccessControlAttributeConfigurationResponse EndCreateInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceAccessControlAttributeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePermissionSet

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
        public virtual CreatePermissionSetResponse CreatePermissionSet(CreatePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionSetResponseUnmarshaller.Instance;

            return Invoke<CreatePermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreatePermissionSet">REST API Reference for CreatePermissionSet Operation</seealso>
        public virtual IAsyncResult BeginCreatePermissionSet(CreatePermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePermissionSet.</param>
        /// 
        /// <returns>Returns a  CreatePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreatePermissionSet">REST API Reference for CreatePermissionSet Operation</seealso>
        public virtual CreatePermissionSetResponse EndCreatePermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrustedTokenIssuer

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
        public virtual CreateTrustedTokenIssuerResponse CreateTrustedTokenIssuer(CreateTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<CreateTrustedTokenIssuerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateTrustedTokenIssuer">REST API Reference for CreateTrustedTokenIssuer Operation</seealso>
        public virtual IAsyncResult BeginCreateTrustedTokenIssuer(CreateTrustedTokenIssuerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  CreateTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateTrustedTokenIssuer">REST API Reference for CreateTrustedTokenIssuer Operation</seealso>
        public virtual CreateTrustedTokenIssuerResponse EndCreateTrustedTokenIssuer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrustedTokenIssuerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccountAssignment

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
        public virtual DeleteAccountAssignmentResponse DeleteAccountAssignment(DeleteAccountAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteAccountAssignment">REST API Reference for DeleteAccountAssignment Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccountAssignment(DeleteAccountAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteAccountAssignment">REST API Reference for DeleteAccountAssignment Operation</seealso>
        public virtual DeleteAccountAssignmentResponse EndDeleteAccountAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes the association with the application. The connected service resource still
        /// exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
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
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplicationAccessScope

        /// <summary>
        /// Deletes an IAM Identity Center access scope from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAccessScope service method.</param>
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
        public virtual DeleteApplicationAccessScopeResponse DeleteApplicationAccessScope(DeleteApplicationAccessScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAccessScopeResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationAccessScopeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAccessScope operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationAccessScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAccessScope">REST API Reference for DeleteApplicationAccessScope Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplicationAccessScope(DeleteApplicationAccessScopeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAccessScopeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationAccessScope.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationAccessScopeResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAccessScope">REST API Reference for DeleteApplicationAccessScope Operation</seealso>
        public virtual DeleteApplicationAccessScopeResponse EndDeleteApplicationAccessScope(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationAccessScopeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplicationAssignment

        /// <summary>
        /// Revoke application access to an application by deleting application assignments for
        /// a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAssignment service method.</param>
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
        public virtual DeleteApplicationAssignmentResponse DeleteApplicationAssignment(DeleteApplicationAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAssignment">REST API Reference for DeleteApplicationAssignment Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplicationAssignment(DeleteApplicationAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAssignment">REST API Reference for DeleteApplicationAssignment Operation</seealso>
        public virtual DeleteApplicationAssignmentResponse EndDeleteApplicationAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplicationAuthenticationMethod

        /// <summary>
        /// Deletes an authentication method from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAuthenticationMethod service method.</param>
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
        public virtual DeleteApplicationAuthenticationMethodResponse DeleteApplicationAuthenticationMethod(DeleteApplicationAuthenticationMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationAuthenticationMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAuthenticationMethod operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationAuthenticationMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAuthenticationMethod">REST API Reference for DeleteApplicationAuthenticationMethod Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplicationAuthenticationMethod(DeleteApplicationAuthenticationMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationAuthenticationMethod.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationAuthenticationMethodResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAuthenticationMethod">REST API Reference for DeleteApplicationAuthenticationMethod Operation</seealso>
        public virtual DeleteApplicationAuthenticationMethodResponse EndDeleteApplicationAuthenticationMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationAuthenticationMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplicationGrant

        /// <summary>
        /// Deletes a grant from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationGrant service method.</param>
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
        public virtual DeleteApplicationGrantResponse DeleteApplicationGrant(DeleteApplicationGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationGrant operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationGrant">REST API Reference for DeleteApplicationGrant Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplicationGrant(DeleteApplicationGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationGrant.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationGrantResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationGrant">REST API Reference for DeleteApplicationGrant Operation</seealso>
        public virtual DeleteApplicationGrantResponse EndDeleteApplicationGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInlinePolicyFromPermissionSet

        /// <summary>
        /// Deletes the inline policy from a specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInlinePolicyFromPermissionSet service method.</param>
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
        public virtual DeleteInlinePolicyFromPermissionSetResponse DeleteInlinePolicyFromPermissionSet(DeleteInlinePolicyFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInlinePolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInlinePolicyFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DeleteInlinePolicyFromPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInlinePolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInlinePolicyFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInlinePolicyFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInlinePolicyFromPermissionSet">REST API Reference for DeleteInlinePolicyFromPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteInlinePolicyFromPermissionSet(DeleteInlinePolicyFromPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInlinePolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInlinePolicyFromPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInlinePolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInlinePolicyFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DeleteInlinePolicyFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInlinePolicyFromPermissionSet">REST API Reference for DeleteInlinePolicyFromPermissionSet Operation</seealso>
        public virtual DeleteInlinePolicyFromPermissionSetResponse EndDeleteInlinePolicyFromPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInlinePolicyFromPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstance

        /// <summary>
        /// Deletes the instance of IAM Identity Center. Only the account that owns the instance
        /// can call this API. Neither the delegated administrator nor member account can delete
        /// the organization instance, but those roles can delete their own instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
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
        public virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstanceAccessControlAttributeConfiguration

        /// <summary>
        /// Disables the attributes-based access control (ABAC) feature for the specified IAM
        /// Identity Center instance and deletes all of the attribute mappings that have been
        /// configured. Once deleted, any attributes that are received from an identity source
        /// and any custom attributes you have previously configured will not be passed. For more
        /// information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceAccessControlAttributeConfiguration service method.</param>
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
        public virtual DeleteInstanceAccessControlAttributeConfigurationResponse DeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstanceAccessControlAttributeConfiguration">REST API Reference for DeleteInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstanceAccessControlAttributeConfiguration">REST API Reference for DeleteInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual DeleteInstanceAccessControlAttributeConfigurationResponse EndDeleteInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceAccessControlAttributeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePermissionsBoundaryFromPermissionSet

        /// <summary>
        /// Deletes the permissions boundary from a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionsBoundaryFromPermissionSet service method.</param>
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
        public virtual DeletePermissionsBoundaryFromPermissionSetResponse DeletePermissionsBoundaryFromPermissionSet(DeletePermissionsBoundaryFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionsBoundaryFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionsBoundaryFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionsBoundaryFromPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermissionsBoundaryFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionsBoundaryFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermissionsBoundaryFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionsBoundaryFromPermissionSet">REST API Reference for DeletePermissionsBoundaryFromPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginDeletePermissionsBoundaryFromPermissionSet(DeletePermissionsBoundaryFromPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionsBoundaryFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionsBoundaryFromPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermissionsBoundaryFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermissionsBoundaryFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DeletePermissionsBoundaryFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionsBoundaryFromPermissionSet">REST API Reference for DeletePermissionsBoundaryFromPermissionSet Operation</seealso>
        public virtual DeletePermissionsBoundaryFromPermissionSetResponse EndDeletePermissionsBoundaryFromPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePermissionsBoundaryFromPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePermissionSet

        /// <summary>
        /// Deletes the specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionSet service method.</param>
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
        public virtual DeletePermissionSetResponse DeletePermissionSet(DeletePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionSetResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionSet">REST API Reference for DeletePermissionSet Operation</seealso>
        public virtual IAsyncResult BeginDeletePermissionSet(DeletePermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermissionSet.</param>
        /// 
        /// <returns>Returns a  DeletePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionSet">REST API Reference for DeletePermissionSet Operation</seealso>
        public virtual DeletePermissionSetResponse EndDeletePermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrustedTokenIssuer

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
        public virtual DeleteTrustedTokenIssuerResponse DeleteTrustedTokenIssuer(DeleteTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustedTokenIssuerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteTrustedTokenIssuer">REST API Reference for DeleteTrustedTokenIssuer Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrustedTokenIssuer(DeleteTrustedTokenIssuerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustedTokenIssuerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  DeleteTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteTrustedTokenIssuer">REST API Reference for DeleteTrustedTokenIssuer Operation</seealso>
        public virtual DeleteTrustedTokenIssuerResponse EndDeleteTrustedTokenIssuer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrustedTokenIssuerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAssignmentCreationStatus

        /// <summary>
        /// Describes the status of the assignment creation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentCreationStatus service method.</param>
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
        public virtual DescribeAccountAssignmentCreationStatusResponse DescribeAccountAssignmentCreationStatus(DescribeAccountAssignmentCreationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAssignmentCreationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentCreationStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAssignmentCreationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentCreationStatus">REST API Reference for DescribeAccountAssignmentCreationStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountAssignmentCreationStatus(DescribeAccountAssignmentCreationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAssignmentCreationStatus.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAssignmentCreationStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentCreationStatus">REST API Reference for DescribeAccountAssignmentCreationStatus Operation</seealso>
        public virtual DescribeAccountAssignmentCreationStatusResponse EndDescribeAccountAssignmentCreationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAssignmentCreationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAssignmentDeletionStatus

        /// <summary>
        /// Describes the status of the assignment deletion request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentDeletionStatus service method.</param>
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
        public virtual DescribeAccountAssignmentDeletionStatusResponse DescribeAccountAssignmentDeletionStatus(DescribeAccountAssignmentDeletionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAssignmentDeletionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentDeletionStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAssignmentDeletionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentDeletionStatus">REST API Reference for DescribeAccountAssignmentDeletionStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountAssignmentDeletionStatus(DescribeAccountAssignmentDeletionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAssignmentDeletionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAssignmentDeletionStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentDeletionStatus">REST API Reference for DescribeAccountAssignmentDeletionStatus Operation</seealso>
        public virtual DescribeAccountAssignmentDeletionStatusResponse EndDescribeAccountAssignmentDeletionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAssignmentDeletionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplication

        /// <summary>
        /// Retrieves the details of an application associated with an instance of IAM Identity
        /// Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
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
        public virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicationAssignment

        /// <summary>
        /// Retrieves a direct assignment of a user or group to an application. If the user doesn’t
        /// have a direct assignment to the application, the user may still have access to the
        /// application through a group. Therefore, don’t use this API to test access to an application
        /// for a user. Instead use <a>ListApplicationAssignmentsForPrincipal</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssignment service method.</param>
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
        public virtual DescribeApplicationAssignmentResponse DescribeApplicationAssignment(DescribeApplicationAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationAssignmentResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationAssignment">REST API Reference for DescribeApplicationAssignment Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicationAssignment(DescribeApplicationAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationAssignment.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationAssignment">REST API Reference for DescribeApplicationAssignment Operation</seealso>
        public virtual DescribeApplicationAssignmentResponse EndDescribeApplicationAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicationProvider

        /// <summary>
        /// Retrieves details about a provider that can be used to connect an Amazon Web Services
        /// managed application or customer managed application to IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationProvider service method.</param>
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
        public virtual DescribeApplicationProviderResponse DescribeApplicationProvider(DescribeApplicationProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationProviderResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationProvider operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationProvider">REST API Reference for DescribeApplicationProvider Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicationProvider(DescribeApplicationProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationProvider.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationProviderResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationProvider">REST API Reference for DescribeApplicationProvider Operation</seealso>
        public virtual DescribeApplicationProviderResponse EndDescribeApplicationProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstance

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
        public virtual DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstance(DescribeInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstance.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        public virtual DescribeInstanceResponse EndDescribeInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceAccessControlAttributeConfiguration

        /// <summary>
        /// Returns the list of IAM Identity Center identity store attributes that have been configured
        /// to work with attributes-based access control (ABAC) for the specified IAM Identity
        /// Center instance. This will not return attributes configured and sent by an external
        /// identity provider. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAccessControlAttributeConfiguration service method.</param>
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
        public virtual DescribeInstanceAccessControlAttributeConfigurationResponse DescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstanceAccessControlAttributeConfiguration">REST API Reference for DescribeInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstanceAccessControlAttributeConfiguration">REST API Reference for DescribeInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual DescribeInstanceAccessControlAttributeConfigurationResponse EndDescribeInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceAccessControlAttributeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePermissionSet

        /// <summary>
        /// Gets the details of the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSet service method.</param>
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
        public virtual DescribePermissionSetResponse DescribePermissionSet(DescribePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetResponseUnmarshaller.Instance;

            return Invoke<DescribePermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSet">REST API Reference for DescribePermissionSet Operation</seealso>
        public virtual IAsyncResult BeginDescribePermissionSet(DescribePermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissionSet.</param>
        /// 
        /// <returns>Returns a  DescribePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSet">REST API Reference for DescribePermissionSet Operation</seealso>
        public virtual DescribePermissionSetResponse EndDescribePermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePermissionSetProvisioningStatus

        /// <summary>
        /// Describes the status for the given permission set provisioning request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSetProvisioningStatus service method.</param>
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
        public virtual DescribePermissionSetProvisioningStatusResponse DescribePermissionSetProvisioningStatus(DescribePermissionSetProvisioningStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return Invoke<DescribePermissionSetProvisioningStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSetProvisioningStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePermissionSetProvisioningStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSetProvisioningStatus">REST API Reference for DescribePermissionSetProvisioningStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribePermissionSetProvisioningStatus(DescribePermissionSetProvisioningStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissionSetProvisioningStatus.</param>
        /// 
        /// <returns>Returns a  DescribePermissionSetProvisioningStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSetProvisioningStatus">REST API Reference for DescribePermissionSetProvisioningStatus Operation</seealso>
        public virtual DescribePermissionSetProvisioningStatusResponse EndDescribePermissionSetProvisioningStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePermissionSetProvisioningStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTrustedTokenIssuer

        /// <summary>
        /// Retrieves details about a trusted token issuer configuration stored in an instance
        /// of IAM Identity Center. Details include the name of the trusted token issuer, the
        /// issuer URL, and the path of the source attribute and the destination attribute for
        /// a trusted token issuer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedTokenIssuer service method.</param>
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
        public virtual DescribeTrustedTokenIssuerResponse DescribeTrustedTokenIssuer(DescribeTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustedTokenIssuerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeTrustedTokenIssuer">REST API Reference for DescribeTrustedTokenIssuer Operation</seealso>
        public virtual IAsyncResult BeginDescribeTrustedTokenIssuer(DescribeTrustedTokenIssuerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustedTokenIssuerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  DescribeTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeTrustedTokenIssuer">REST API Reference for DescribeTrustedTokenIssuer Operation</seealso>
        public virtual DescribeTrustedTokenIssuerResponse EndDescribeTrustedTokenIssuer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrustedTokenIssuerResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachCustomerManagedPolicyReferenceFromPermissionSet

        /// <summary>
        /// Detaches the specified customer managed policy from the specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachCustomerManagedPolicyReferenceFromPermissionSet service method.</param>
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
        public virtual DetachCustomerManagedPolicyReferenceFromPermissionSetResponse DetachCustomerManagedPolicyReferenceFromPermissionSet(DetachCustomerManagedPolicyReferenceFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DetachCustomerManagedPolicyReferenceFromPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachCustomerManagedPolicyReferenceFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachCustomerManagedPolicyReferenceFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachCustomerManagedPolicyReferenceFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachCustomerManagedPolicyReferenceFromPermissionSet">REST API Reference for DetachCustomerManagedPolicyReferenceFromPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginDetachCustomerManagedPolicyReferenceFromPermissionSet(DetachCustomerManagedPolicyReferenceFromPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachCustomerManagedPolicyReferenceFromPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachCustomerManagedPolicyReferenceFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachCustomerManagedPolicyReferenceFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DetachCustomerManagedPolicyReferenceFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachCustomerManagedPolicyReferenceFromPermissionSet">REST API Reference for DetachCustomerManagedPolicyReferenceFromPermissionSet Operation</seealso>
        public virtual DetachCustomerManagedPolicyReferenceFromPermissionSetResponse EndDetachCustomerManagedPolicyReferenceFromPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachCustomerManagedPolicyReferenceFromPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachManagedPolicyFromPermissionSet

        /// <summary>
        /// Detaches the attached Amazon Web Services managed policy ARN from the specified permission
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachManagedPolicyFromPermissionSet service method.</param>
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
        public virtual DetachManagedPolicyFromPermissionSetResponse DetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachManagedPolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachManagedPolicyFromPermissionSetResponseUnmarshaller.Instance;

            return Invoke<DetachManagedPolicyFromPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachManagedPolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachManagedPolicyFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachManagedPolicyFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachManagedPolicyFromPermissionSet">REST API Reference for DetachManagedPolicyFromPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginDetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachManagedPolicyFromPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachManagedPolicyFromPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachManagedPolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachManagedPolicyFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DetachManagedPolicyFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachManagedPolicyFromPermissionSet">REST API Reference for DetachManagedPolicyFromPermissionSet Operation</seealso>
        public virtual DetachManagedPolicyFromPermissionSetResponse EndDetachManagedPolicyFromPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachManagedPolicyFromPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationAccessScope

        /// <summary>
        /// Retrieves the authorized targets for an IAM Identity Center access scope for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAccessScope service method.</param>
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
        public virtual GetApplicationAccessScopeResponse GetApplicationAccessScope(GetApplicationAccessScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAccessScopeResponseUnmarshaller.Instance;

            return Invoke<GetApplicationAccessScopeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAccessScope operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationAccessScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAccessScope">REST API Reference for GetApplicationAccessScope Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationAccessScope(GetApplicationAccessScopeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAccessScopeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationAccessScope.</param>
        /// 
        /// <returns>Returns a  GetApplicationAccessScopeResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAccessScope">REST API Reference for GetApplicationAccessScope Operation</seealso>
        public virtual GetApplicationAccessScopeResponse EndGetApplicationAccessScope(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationAccessScopeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationAssignmentConfiguration

        /// <summary>
        /// Retrieves the configuration of <a>PutApplicationAssignmentConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAssignmentConfiguration service method.</param>
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
        public virtual GetApplicationAssignmentConfigurationResponse GetApplicationAssignmentConfiguration(GetApplicationAssignmentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationAssignmentConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAssignmentConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationAssignmentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAssignmentConfiguration">REST API Reference for GetApplicationAssignmentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationAssignmentConfiguration(GetApplicationAssignmentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationAssignmentConfiguration.</param>
        /// 
        /// <returns>Returns a  GetApplicationAssignmentConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAssignmentConfiguration">REST API Reference for GetApplicationAssignmentConfiguration Operation</seealso>
        public virtual GetApplicationAssignmentConfigurationResponse EndGetApplicationAssignmentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationAssignmentConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationAuthenticationMethod

        /// <summary>
        /// Retrieves details about an authentication method used by an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAuthenticationMethod service method.</param>
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
        public virtual GetApplicationAuthenticationMethodResponse GetApplicationAuthenticationMethod(GetApplicationAuthenticationMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return Invoke<GetApplicationAuthenticationMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAuthenticationMethod operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationAuthenticationMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAuthenticationMethod">REST API Reference for GetApplicationAuthenticationMethod Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationAuthenticationMethod(GetApplicationAuthenticationMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationAuthenticationMethod.</param>
        /// 
        /// <returns>Returns a  GetApplicationAuthenticationMethodResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAuthenticationMethod">REST API Reference for GetApplicationAuthenticationMethod Operation</seealso>
        public virtual GetApplicationAuthenticationMethodResponse EndGetApplicationAuthenticationMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationAuthenticationMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationGrant

        /// <summary>
        /// Retrieves details about an application grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationGrant service method.</param>
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
        public virtual GetApplicationGrantResponse GetApplicationGrant(GetApplicationGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationGrantResponseUnmarshaller.Instance;

            return Invoke<GetApplicationGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationGrant operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationGrant">REST API Reference for GetApplicationGrant Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationGrant(GetApplicationGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationGrant.</param>
        /// 
        /// <returns>Returns a  GetApplicationGrantResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationGrant">REST API Reference for GetApplicationGrant Operation</seealso>
        public virtual GetApplicationGrantResponse EndGetApplicationGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationSessionConfiguration

        /// <summary>
        /// Retrieves the session configuration for an application in IAM Identity Center.
        /// 
        ///  
        /// <para>
        /// The session configuration determines how users can access an application. This includes
        /// whether user background sessions are enabled. User background sessions allow users
        /// to start a job on a supported Amazon Web Services managed application without having
        /// to remain signed in to an active session while the job runs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSessionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetApplicationSessionConfiguration service method, as returned by SSOAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationSessionConfiguration">REST API Reference for GetApplicationSessionConfiguration Operation</seealso>
        public virtual GetApplicationSessionConfigurationResponse GetApplicationSessionConfiguration(GetApplicationSessionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationSessionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSessionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationSessionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSessionConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationSessionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationSessionConfiguration">REST API Reference for GetApplicationSessionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationSessionConfiguration(GetApplicationSessionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationSessionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSessionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationSessionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetApplicationSessionConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationSessionConfiguration">REST API Reference for GetApplicationSessionConfiguration Operation</seealso>
        public virtual GetApplicationSessionConfigurationResponse EndGetApplicationSessionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationSessionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInlinePolicyForPermissionSet

        /// <summary>
        /// Obtains the inline policy assigned to the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInlinePolicyForPermissionSet service method.</param>
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
        public virtual GetInlinePolicyForPermissionSetResponse GetInlinePolicyForPermissionSet(GetInlinePolicyForPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInlinePolicyForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInlinePolicyForPermissionSetResponseUnmarshaller.Instance;

            return Invoke<GetInlinePolicyForPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInlinePolicyForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInlinePolicyForPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInlinePolicyForPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetInlinePolicyForPermissionSet">REST API Reference for GetInlinePolicyForPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginGetInlinePolicyForPermissionSet(GetInlinePolicyForPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInlinePolicyForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInlinePolicyForPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInlinePolicyForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInlinePolicyForPermissionSet.</param>
        /// 
        /// <returns>Returns a  GetInlinePolicyForPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetInlinePolicyForPermissionSet">REST API Reference for GetInlinePolicyForPermissionSet Operation</seealso>
        public virtual GetInlinePolicyForPermissionSetResponse EndGetInlinePolicyForPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInlinePolicyForPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPermissionsBoundaryForPermissionSet

        /// <summary>
        /// Obtains the permissions boundary for a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionsBoundaryForPermissionSet service method.</param>
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
        public virtual GetPermissionsBoundaryForPermissionSetResponse GetPermissionsBoundaryForPermissionSet(GetPermissionsBoundaryForPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionsBoundaryForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionsBoundaryForPermissionSetResponseUnmarshaller.Instance;

            return Invoke<GetPermissionsBoundaryForPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPermissionsBoundaryForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionsBoundaryForPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPermissionsBoundaryForPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetPermissionsBoundaryForPermissionSet">REST API Reference for GetPermissionsBoundaryForPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginGetPermissionsBoundaryForPermissionSet(GetPermissionsBoundaryForPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionsBoundaryForPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionsBoundaryForPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPermissionsBoundaryForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPermissionsBoundaryForPermissionSet.</param>
        /// 
        /// <returns>Returns a  GetPermissionsBoundaryForPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetPermissionsBoundaryForPermissionSet">REST API Reference for GetPermissionsBoundaryForPermissionSet Operation</seealso>
        public virtual GetPermissionsBoundaryForPermissionSetResponse EndGetPermissionsBoundaryForPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPermissionsBoundaryForPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountAssignmentCreationStatus

        /// <summary>
        /// Lists the status of the Amazon Web Services account assignment creation requests for
        /// a specified IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentCreationStatus service method.</param>
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
        public virtual ListAccountAssignmentCreationStatusResponse ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentCreationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentCreationStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignmentCreationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentCreationStatus">REST API Reference for ListAccountAssignmentCreationStatus Operation</seealso>
        public virtual IAsyncResult BeginListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentCreationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignmentCreationStatus.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentCreationStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentCreationStatus">REST API Reference for ListAccountAssignmentCreationStatus Operation</seealso>
        public virtual ListAccountAssignmentCreationStatusResponse EndListAccountAssignmentCreationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountAssignmentCreationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountAssignmentDeletionStatus

        /// <summary>
        /// Lists the status of the Amazon Web Services account assignment deletion requests for
        /// a specified IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentDeletionStatus service method.</param>
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
        public virtual ListAccountAssignmentDeletionStatusResponse ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentDeletionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentDeletionStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignmentDeletionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentDeletionStatus">REST API Reference for ListAccountAssignmentDeletionStatus Operation</seealso>
        public virtual IAsyncResult BeginListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentDeletionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignmentDeletionStatus.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentDeletionStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentDeletionStatus">REST API Reference for ListAccountAssignmentDeletionStatus Operation</seealso>
        public virtual ListAccountAssignmentDeletionStatusResponse EndListAccountAssignmentDeletionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountAssignmentDeletionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountAssignments

        /// <summary>
        /// Lists the assignee of the specified Amazon Web Services account with the specified
        /// permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignments service method.</param>
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
        public virtual ListAccountAssignmentsResponse ListAccountAssignments(ListAccountAssignmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignments operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignments">REST API Reference for ListAccountAssignments Operation</seealso>
        public virtual IAsyncResult BeginListAccountAssignments(ListAccountAssignmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignments.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignments">REST API Reference for ListAccountAssignments Operation</seealso>
        public virtual ListAccountAssignmentsResponse EndListAccountAssignments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountAssignmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountAssignmentsForPrincipal

        /// <summary>
        /// Retrieves a list of the IAM Identity Center associated Amazon Web Services accounts
        /// that the principal has access to. This action must be called from the management account
        /// containing your organization instance of IAM Identity Center. This action is not valid
        /// for account instances of IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentsForPrincipal service method.</param>
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
        public virtual ListAccountAssignmentsForPrincipalResponse ListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssignmentsForPrincipalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentsForPrincipal operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignmentsForPrincipal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentsForPrincipal">REST API Reference for ListAccountAssignmentsForPrincipal Operation</seealso>
        public virtual IAsyncResult BeginListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignmentsForPrincipal.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentsForPrincipalResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentsForPrincipal">REST API Reference for ListAccountAssignmentsForPrincipal Operation</seealso>
        public virtual ListAccountAssignmentsForPrincipalResponse EndListAccountAssignmentsForPrincipal(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountAssignmentsForPrincipalResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountsForProvisionedPermissionSet

        /// <summary>
        /// Lists all the Amazon Web Services accounts where the specified permission set is provisioned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForProvisionedPermissionSet service method.</param>
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
        public virtual ListAccountsForProvisionedPermissionSetResponse ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsForProvisionedPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsForProvisionedPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ListAccountsForProvisionedPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountsForProvisionedPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForProvisionedPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountsForProvisionedPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountsForProvisionedPermissionSet">REST API Reference for ListAccountsForProvisionedPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsForProvisionedPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsForProvisionedPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountsForProvisionedPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountsForProvisionedPermissionSet.</param>
        /// 
        /// <returns>Returns a  ListAccountsForProvisionedPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountsForProvisionedPermissionSet">REST API Reference for ListAccountsForProvisionedPermissionSet Operation</seealso>
        public virtual ListAccountsForProvisionedPermissionSetResponse EndListAccountsForProvisionedPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountsForProvisionedPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationAccessScopes

        /// <summary>
        /// Lists the access scopes and authorized targets associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAccessScopes service method.</param>
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
        public virtual ListApplicationAccessScopesResponse ListApplicationAccessScopes(ListApplicationAccessScopesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAccessScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAccessScopesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAccessScopesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAccessScopes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAccessScopes operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAccessScopes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAccessScopes">REST API Reference for ListApplicationAccessScopes Operation</seealso>
        public virtual IAsyncResult BeginListApplicationAccessScopes(ListApplicationAccessScopesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAccessScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAccessScopesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAccessScopes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAccessScopes.</param>
        /// 
        /// <returns>Returns a  ListApplicationAccessScopesResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAccessScopes">REST API Reference for ListApplicationAccessScopes Operation</seealso>
        public virtual ListApplicationAccessScopesResponse EndListApplicationAccessScopes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationAccessScopesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationAssignments

        /// <summary>
        /// Lists Amazon Web Services account users that are assigned to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignments service method.</param>
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
        public virtual ListApplicationAssignmentsResponse ListApplicationAssignments(ListApplicationAssignmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAssignmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAssignments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignments operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAssignments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignments">REST API Reference for ListApplicationAssignments Operation</seealso>
        public virtual IAsyncResult BeginListApplicationAssignments(ListApplicationAssignmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAssignments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAssignments.</param>
        /// 
        /// <returns>Returns a  ListApplicationAssignmentsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignments">REST API Reference for ListApplicationAssignments Operation</seealso>
        public virtual ListApplicationAssignmentsResponse EndListApplicationAssignments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationAssignmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationAssignmentsForPrincipal

        /// <summary>
        /// Lists the applications to which a specified principal is assigned. You must provide
        /// a filter when calling this action from a member account against your organization
        /// instance of IAM Identity Center. A filter is not required when called from the management
        /// account against an organization instance of IAM Identity Center, or from a member
        /// account against an account instance of IAM Identity Center in the same account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignmentsForPrincipal service method.</param>
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
        public virtual ListApplicationAssignmentsForPrincipalResponse ListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAssignmentsForPrincipalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignmentsForPrincipal operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAssignmentsForPrincipal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignmentsForPrincipal">REST API Reference for ListApplicationAssignmentsForPrincipal Operation</seealso>
        public virtual IAsyncResult BeginListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAssignmentsForPrincipalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAssignmentsForPrincipalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAssignmentsForPrincipal.</param>
        /// 
        /// <returns>Returns a  ListApplicationAssignmentsForPrincipalResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignmentsForPrincipal">REST API Reference for ListApplicationAssignmentsForPrincipal Operation</seealso>
        public virtual ListApplicationAssignmentsForPrincipalResponse EndListApplicationAssignmentsForPrincipal(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationAssignmentsForPrincipalResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationAuthenticationMethods

        /// <summary>
        /// Lists all of the authentication methods supported by the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAuthenticationMethods service method.</param>
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
        public virtual ListApplicationAuthenticationMethodsResponse ListApplicationAuthenticationMethods(ListApplicationAuthenticationMethodsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAuthenticationMethodsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAuthenticationMethodsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationAuthenticationMethodsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAuthenticationMethods operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAuthenticationMethods operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAuthenticationMethods
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAuthenticationMethods">REST API Reference for ListApplicationAuthenticationMethods Operation</seealso>
        public virtual IAsyncResult BeginListApplicationAuthenticationMethods(ListApplicationAuthenticationMethodsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationAuthenticationMethodsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationAuthenticationMethodsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAuthenticationMethods operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAuthenticationMethods.</param>
        /// 
        /// <returns>Returns a  ListApplicationAuthenticationMethodsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAuthenticationMethods">REST API Reference for ListApplicationAuthenticationMethods Operation</seealso>
        public virtual ListApplicationAuthenticationMethodsResponse EndListApplicationAuthenticationMethods(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationAuthenticationMethodsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationGrants

        /// <summary>
        /// List the grants associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationGrants service method.</param>
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
        public virtual ListApplicationGrantsResponse ListApplicationGrants(ListApplicationGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationGrantsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationGrantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationGrants operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationGrants">REST API Reference for ListApplicationGrants Operation</seealso>
        public virtual IAsyncResult BeginListApplicationGrants(ListApplicationGrantsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationGrantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationGrants.</param>
        /// 
        /// <returns>Returns a  ListApplicationGrantsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationGrants">REST API Reference for ListApplicationGrants Operation</seealso>
        public virtual ListApplicationGrantsResponse EndListApplicationGrants(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationGrantsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationProviders

        /// <summary>
        /// Lists the application providers configured in the IAM Identity Center identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationProviders service method.</param>
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
        public virtual ListApplicationProvidersResponse ListApplicationProviders(ListApplicationProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationProvidersResponseUnmarshaller.Instance;

            return Invoke<ListApplicationProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationProviders operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationProviders">REST API Reference for ListApplicationProviders Operation</seealso>
        public virtual IAsyncResult BeginListApplicationProviders(ListApplicationProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationProviders.</param>
        /// 
        /// <returns>Returns a  ListApplicationProvidersResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationProviders">REST API Reference for ListApplicationProviders Operation</seealso>
        public virtual ListApplicationProvidersResponse EndListApplicationProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists all applications associated with the instance of IAM Identity Center. When listing
        /// applications for an organization instance in the management account, member accounts
        /// must use the <c>applicationAccount</c> parameter to filter the list to only applications
        /// created from that account. When listing applications for an account instance in the
        /// same member account, a filter is not required.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
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
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomerManagedPolicyReferencesInPermissionSet

        /// <summary>
        /// Lists all customer managed policies attached to a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomerManagedPolicyReferencesInPermissionSet service method.</param>
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
        public virtual ListCustomerManagedPolicyReferencesInPermissionSetResponse ListCustomerManagedPolicyReferencesInPermissionSet(ListCustomerManagedPolicyReferencesInPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomerManagedPolicyReferencesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomerManagedPolicyReferencesInPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ListCustomerManagedPolicyReferencesInPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomerManagedPolicyReferencesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomerManagedPolicyReferencesInPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomerManagedPolicyReferencesInPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListCustomerManagedPolicyReferencesInPermissionSet">REST API Reference for ListCustomerManagedPolicyReferencesInPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginListCustomerManagedPolicyReferencesInPermissionSet(ListCustomerManagedPolicyReferencesInPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomerManagedPolicyReferencesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomerManagedPolicyReferencesInPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomerManagedPolicyReferencesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomerManagedPolicyReferencesInPermissionSet.</param>
        /// 
        /// <returns>Returns a  ListCustomerManagedPolicyReferencesInPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListCustomerManagedPolicyReferencesInPermissionSet">REST API Reference for ListCustomerManagedPolicyReferencesInPermissionSet Operation</seealso>
        public virtual ListCustomerManagedPolicyReferencesInPermissionSetResponse EndListCustomerManagedPolicyReferencesInPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomerManagedPolicyReferencesInPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// Lists the details of the organization and account instances of IAM Identity Center
        /// that were created in or visible to the account calling this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
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
        public virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedPoliciesInPermissionSet

        /// <summary>
        /// Lists the Amazon Web Services managed policy that is attached to a specified permission
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedPoliciesInPermissionSet service method.</param>
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
        public virtual ListManagedPoliciesInPermissionSetResponse ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedPoliciesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedPoliciesInPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ListManagedPoliciesInPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedPoliciesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedPoliciesInPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedPoliciesInPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListManagedPoliciesInPermissionSet">REST API Reference for ListManagedPoliciesInPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedPoliciesInPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedPoliciesInPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedPoliciesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedPoliciesInPermissionSet.</param>
        /// 
        /// <returns>Returns a  ListManagedPoliciesInPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListManagedPoliciesInPermissionSet">REST API Reference for ListManagedPoliciesInPermissionSet Operation</seealso>
        public virtual ListManagedPoliciesInPermissionSetResponse EndListManagedPoliciesInPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedPoliciesInPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPermissionSetProvisioningStatus

        /// <summary>
        /// Lists the status of the permission set provisioning requests for a specified IAM Identity
        /// Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetProvisioningStatus service method.</param>
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
        public virtual ListPermissionSetProvisioningStatusResponse ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return Invoke<ListPermissionSetProvisioningStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetProvisioningStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionSetProvisioningStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetProvisioningStatus">REST API Reference for ListPermissionSetProvisioningStatus Operation</seealso>
        public virtual IAsyncResult BeginListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetProvisioningStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetProvisioningStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionSetProvisioningStatus.</param>
        /// 
        /// <returns>Returns a  ListPermissionSetProvisioningStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetProvisioningStatus">REST API Reference for ListPermissionSetProvisioningStatus Operation</seealso>
        public virtual ListPermissionSetProvisioningStatusResponse EndListPermissionSetProvisioningStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionSetProvisioningStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPermissionSets

        /// <summary>
        /// Lists the <a>PermissionSet</a>s in an IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSets service method.</param>
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
        public virtual ListPermissionSetsResponse ListPermissionSets(ListPermissionSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSets operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSets">REST API Reference for ListPermissionSets Operation</seealso>
        public virtual IAsyncResult BeginListPermissionSets(ListPermissionSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionSets.</param>
        /// 
        /// <returns>Returns a  ListPermissionSetsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSets">REST API Reference for ListPermissionSets Operation</seealso>
        public virtual ListPermissionSetsResponse EndListPermissionSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPermissionSetsProvisionedToAccount

        /// <summary>
        /// Lists all the permission sets that are provisioned to a specified Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetsProvisionedToAccount service method.</param>
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
        public virtual ListPermissionSetsProvisionedToAccountResponse ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsProvisionedToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsProvisionedToAccountResponseUnmarshaller.Instance;

            return Invoke<ListPermissionSetsProvisionedToAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionSetsProvisionedToAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetsProvisionedToAccount operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionSetsProvisionedToAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetsProvisionedToAccount">REST API Reference for ListPermissionSetsProvisionedToAccount Operation</seealso>
        public virtual IAsyncResult BeginListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionSetsProvisionedToAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionSetsProvisionedToAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionSetsProvisionedToAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionSetsProvisionedToAccount.</param>
        /// 
        /// <returns>Returns a  ListPermissionSetsProvisionedToAccountResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetsProvisionedToAccount">REST API Reference for ListPermissionSetsProvisionedToAccount Operation</seealso>
        public virtual ListPermissionSetsProvisionedToAccountResponse EndListPermissionSetsProvisionedToAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionSetsProvisionedToAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags that are attached to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrustedTokenIssuers

        /// <summary>
        /// Lists all the trusted token issuers configured in an instance of IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustedTokenIssuers service method.</param>
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
        public virtual ListTrustedTokenIssuersResponse ListTrustedTokenIssuers(ListTrustedTokenIssuersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustedTokenIssuersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustedTokenIssuersResponseUnmarshaller.Instance;

            return Invoke<ListTrustedTokenIssuersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustedTokenIssuers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustedTokenIssuers operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustedTokenIssuers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTrustedTokenIssuers">REST API Reference for ListTrustedTokenIssuers Operation</seealso>
        public virtual IAsyncResult BeginListTrustedTokenIssuers(ListTrustedTokenIssuersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrustedTokenIssuersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustedTokenIssuersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustedTokenIssuers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustedTokenIssuers.</param>
        /// 
        /// <returns>Returns a  ListTrustedTokenIssuersResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTrustedTokenIssuers">REST API Reference for ListTrustedTokenIssuers Operation</seealso>
        public virtual ListTrustedTokenIssuersResponse EndListTrustedTokenIssuers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrustedTokenIssuersResponse>(asyncResult);
        }

        #endregion
        
        #region  ProvisionPermissionSet

        /// <summary>
        /// The process by which a specified permission set is provisioned to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionPermissionSet service method.</param>
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
        public virtual ProvisionPermissionSetResponse ProvisionPermissionSet(ProvisionPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionPermissionSetResponseUnmarshaller.Instance;

            return Invoke<ProvisionPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ProvisionPermissionSet">REST API Reference for ProvisionPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginProvisionPermissionSet(ProvisionPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionPermissionSet.</param>
        /// 
        /// <returns>Returns a  ProvisionPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ProvisionPermissionSet">REST API Reference for ProvisionPermissionSet Operation</seealso>
        public virtual ProvisionPermissionSetResponse EndProvisionPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ProvisionPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  PutApplicationAccessScope

        /// <summary>
        /// Adds or updates the list of authorized targets for an IAM Identity Center access scope
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAccessScope service method.</param>
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
        public virtual PutApplicationAccessScopeResponse PutApplicationAccessScope(PutApplicationAccessScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAccessScopeResponseUnmarshaller.Instance;

            return Invoke<PutApplicationAccessScopeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAccessScope operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationAccessScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAccessScope">REST API Reference for PutApplicationAccessScope Operation</seealso>
        public virtual IAsyncResult BeginPutApplicationAccessScope(PutApplicationAccessScopeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAccessScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAccessScopeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationAccessScope.</param>
        /// 
        /// <returns>Returns a  PutApplicationAccessScopeResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAccessScope">REST API Reference for PutApplicationAccessScope Operation</seealso>
        public virtual PutApplicationAccessScopeResponse EndPutApplicationAccessScope(IAsyncResult asyncResult)
        {
            return EndInvoke<PutApplicationAccessScopeResponse>(asyncResult);
        }

        #endregion
        
        #region  PutApplicationAssignmentConfiguration

        /// <summary>
        /// Configure how users gain access to an application. If <c>AssignmentsRequired</c> is
        /// <c>true</c> (default value), users don’t have access to the application unless an
        /// assignment is created using the <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment
        /// API</a>. If <c>false</c>, all users have access to the application. If an assignment
        /// is created using <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment</a>.,
        /// the user retains access if <c>AssignmentsRequired</c> is set to <c>true</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAssignmentConfiguration service method.</param>
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
        public virtual PutApplicationAssignmentConfigurationResponse PutApplicationAssignmentConfiguration(PutApplicationAssignmentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutApplicationAssignmentConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAssignmentConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationAssignmentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAssignmentConfiguration">REST API Reference for PutApplicationAssignmentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutApplicationAssignmentConfiguration(PutApplicationAssignmentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAssignmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAssignmentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationAssignmentConfiguration.</param>
        /// 
        /// <returns>Returns a  PutApplicationAssignmentConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAssignmentConfiguration">REST API Reference for PutApplicationAssignmentConfiguration Operation</seealso>
        public virtual PutApplicationAssignmentConfigurationResponse EndPutApplicationAssignmentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutApplicationAssignmentConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutApplicationAuthenticationMethod

        /// <summary>
        /// Adds or updates an authentication method for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAuthenticationMethod service method.</param>
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
        public virtual PutApplicationAuthenticationMethodResponse PutApplicationAuthenticationMethod(PutApplicationAuthenticationMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return Invoke<PutApplicationAuthenticationMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAuthenticationMethod operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationAuthenticationMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAuthenticationMethod">REST API Reference for PutApplicationAuthenticationMethod Operation</seealso>
        public virtual IAsyncResult BeginPutApplicationAuthenticationMethod(PutApplicationAuthenticationMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationAuthenticationMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationAuthenticationMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationAuthenticationMethod.</param>
        /// 
        /// <returns>Returns a  PutApplicationAuthenticationMethodResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAuthenticationMethod">REST API Reference for PutApplicationAuthenticationMethod Operation</seealso>
        public virtual PutApplicationAuthenticationMethodResponse EndPutApplicationAuthenticationMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<PutApplicationAuthenticationMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  PutApplicationGrant

        /// <summary>
        /// Creates a configuration for an application to use grants. Conceptually grants are
        /// authorization to request actions related to tokens. This configuration will be used
        /// when parties are requesting and receiving tokens during the trusted identity propagation
        /// process. For more information on the IAM Identity Center supported grant workflows,
        /// see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/customermanagedapps-saml2-oauth2.html">SAML
        /// 2.0 and OAuth 2.0</a>.
        /// 
        ///  
        /// <para>
        /// A grant is created between your applications and Identity Center instance which enables
        /// an application to use specified mechanisms to obtain tokens. These tokens are used
        /// by your applications to gain access to Amazon Web Services resources on behalf of
        /// users. The following elements are within these exchanges:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Requester</b> - The application requesting access to Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Subject</b> - Typically the user that is requesting access to Amazon Web Services
        /// resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Grant</b> - Conceptually, a grant is authorization to access Amazon Web Services
        /// resources. These grants authorize token generation for authenticating access to the
        /// requester and for the request to make requests on behalf of the subjects. There are
        /// four types of grants:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AuthorizationCode</b> - Allows an application to request authorization through
        /// a series of user-agent redirects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>JWT bearer </b> - Authorizes an application to exchange a JSON Web Token that
        /// came from an external identity provider. To learn more, see <a href="https://datatracker.ietf.org/doc/html/rfc6749">RFC
        /// 6479</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Refresh token</b> - Enables application to request new access tokens to replace
        /// expiring or expired access tokens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Exchange token</b> - A grant that requests tokens from the authorization server
        /// by providing a ‘subject’ token with access scope authorizing trusted identity propagation
        /// to this application. To learn more, see <a href="https://datatracker.ietf.org/doc/html/rfc8693">RFC
        /// 8693</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Authorization server</b> - IAM Identity Center requests tokens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// User credentials are never shared directly within these exchanges. Instead, applications
        /// use grants to request access tokens from IAM Identity Center. For more information,
        /// see <a href="https://datatracker.ietf.org/doc/html/rfc6749">RFC 6479</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Use cases</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Connecting to custom applications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configuring an Amazon Web Services service to make calls to another Amazon Web Services
        /// services using JWT tokens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationGrant service method.</param>
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
        public virtual PutApplicationGrantResponse PutApplicationGrant(PutApplicationGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationGrantResponseUnmarshaller.Instance;

            return Invoke<PutApplicationGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationGrant operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationGrant">REST API Reference for PutApplicationGrant Operation</seealso>
        public virtual IAsyncResult BeginPutApplicationGrant(PutApplicationGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationGrant.</param>
        /// 
        /// <returns>Returns a  PutApplicationGrantResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationGrant">REST API Reference for PutApplicationGrant Operation</seealso>
        public virtual PutApplicationGrantResponse EndPutApplicationGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<PutApplicationGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  PutApplicationSessionConfiguration

        /// <summary>
        /// Updates the session configuration for an application in IAM Identity Center.
        /// 
        ///  
        /// <para>
        /// The session configuration determines how users can access an application. This includes
        /// whether user background sessions are enabled. User background sessions allow users
        /// to start a job on a supported Amazon Web Services managed application without having
        /// to remain signed in to an active session while the job runs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationSessionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutApplicationSessionConfiguration service method, as returned by SSOAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationSessionConfiguration">REST API Reference for PutApplicationSessionConfiguration Operation</seealso>
        public virtual PutApplicationSessionConfigurationResponse PutApplicationSessionConfiguration(PutApplicationSessionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationSessionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationSessionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutApplicationSessionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationSessionConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationSessionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationSessionConfiguration">REST API Reference for PutApplicationSessionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutApplicationSessionConfiguration(PutApplicationSessionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApplicationSessionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApplicationSessionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationSessionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutApplicationSessionConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationSessionConfiguration">REST API Reference for PutApplicationSessionConfiguration Operation</seealso>
        public virtual PutApplicationSessionConfigurationResponse EndPutApplicationSessionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutApplicationSessionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutInlinePolicyToPermissionSet

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
        public virtual PutInlinePolicyToPermissionSetResponse PutInlinePolicyToPermissionSet(PutInlinePolicyToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInlinePolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInlinePolicyToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<PutInlinePolicyToPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutInlinePolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInlinePolicyToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInlinePolicyToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutInlinePolicyToPermissionSet">REST API Reference for PutInlinePolicyToPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginPutInlinePolicyToPermissionSet(PutInlinePolicyToPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInlinePolicyToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInlinePolicyToPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutInlinePolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInlinePolicyToPermissionSet.</param>
        /// 
        /// <returns>Returns a  PutInlinePolicyToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutInlinePolicyToPermissionSet">REST API Reference for PutInlinePolicyToPermissionSet Operation</seealso>
        public virtual PutInlinePolicyToPermissionSetResponse EndPutInlinePolicyToPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<PutInlinePolicyToPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPermissionsBoundaryToPermissionSet

        /// <summary>
        /// Attaches an Amazon Web Services managed or customer managed policy to the specified
        /// <a>PermissionSet</a> as a permissions boundary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionsBoundaryToPermissionSet service method.</param>
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
        public virtual PutPermissionsBoundaryToPermissionSetResponse PutPermissionsBoundaryToPermissionSet(PutPermissionsBoundaryToPermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionsBoundaryToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionsBoundaryToPermissionSetResponseUnmarshaller.Instance;

            return Invoke<PutPermissionsBoundaryToPermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermissionsBoundaryToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionsBoundaryToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPermissionsBoundaryToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutPermissionsBoundaryToPermissionSet">REST API Reference for PutPermissionsBoundaryToPermissionSet Operation</seealso>
        public virtual IAsyncResult BeginPutPermissionsBoundaryToPermissionSet(PutPermissionsBoundaryToPermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionsBoundaryToPermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionsBoundaryToPermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermissionsBoundaryToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermissionsBoundaryToPermissionSet.</param>
        /// 
        /// <returns>Returns a  PutPermissionsBoundaryToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutPermissionsBoundaryToPermissionSet">REST API Reference for PutPermissionsBoundaryToPermissionSet Operation</seealso>
        public virtual PutPermissionsBoundaryToPermissionSetResponse EndPutPermissionsBoundaryToPermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPermissionsBoundaryToPermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates a set of tags with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Disassociates a set of tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates application properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
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
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInstance

        /// <summary>
        /// Update the details for the instance of IAM Identity Center that is owned by the Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
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
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        public virtual UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInstanceAccessControlAttributeConfiguration

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
        public virtual UpdateInstanceAccessControlAttributeConfigurationResponse UpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceAccessControlAttributeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstanceAccessControlAttributeConfiguration">REST API Reference for UpdateInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceAccessControlAttributeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceAccessControlAttributeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstanceAccessControlAttributeConfiguration">REST API Reference for UpdateInstanceAccessControlAttributeConfiguration Operation</seealso>
        public virtual UpdateInstanceAccessControlAttributeConfigurationResponse EndUpdateInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInstanceAccessControlAttributeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePermissionSet

        /// <summary>
        /// Updates an existing permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissionSet service method.</param>
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
        public virtual UpdatePermissionSetResponse UpdatePermissionSet(UpdatePermissionSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePermissionSetResponseUnmarshaller.Instance;

            return Invoke<UpdatePermissionSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdatePermissionSet">REST API Reference for UpdatePermissionSet Operation</seealso>
        public virtual IAsyncResult BeginUpdatePermissionSet(UpdatePermissionSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePermissionSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePermissionSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePermissionSet.</param>
        /// 
        /// <returns>Returns a  UpdatePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdatePermissionSet">REST API Reference for UpdatePermissionSet Operation</seealso>
        public virtual UpdatePermissionSetResponse EndUpdatePermissionSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePermissionSetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrustedTokenIssuer

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
        public virtual UpdateTrustedTokenIssuerResponse UpdateTrustedTokenIssuer(UpdateTrustedTokenIssuerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustedTokenIssuerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateTrustedTokenIssuer">REST API Reference for UpdateTrustedTokenIssuer Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrustedTokenIssuer(UpdateTrustedTokenIssuerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustedTokenIssuerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustedTokenIssuerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  UpdateTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateTrustedTokenIssuer">REST API Reference for UpdateTrustedTokenIssuer Operation</seealso>
        public virtual UpdateTrustedTokenIssuerResponse EndUpdateTrustedTokenIssuer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrustedTokenIssuerResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSSOAdminEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}