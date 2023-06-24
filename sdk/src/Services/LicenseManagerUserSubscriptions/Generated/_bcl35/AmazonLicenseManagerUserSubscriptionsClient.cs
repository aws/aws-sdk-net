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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.LicenseManagerUserSubscriptions.Model;
using Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations;
using Amazon.LicenseManagerUserSubscriptions.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LicenseManagerUserSubscriptions
{
    /// <summary>
    /// Implementation for accessing LicenseManagerUserSubscriptions
    ///
    /// With License Manager, you can create user-based subscriptions to utilize licensed
    /// software with a per user subscription fee on Amazon EC2 instances.
    /// </summary>
    public partial class AmazonLicenseManagerUserSubscriptionsClient : AmazonServiceClient, IAmazonLicenseManagerUserSubscriptions
    {
        private static IServiceMetadata serviceMetadata = new AmazonLicenseManagerUserSubscriptionsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ILicenseManagerUserSubscriptionsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILicenseManagerUserSubscriptionsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LicenseManagerUserSubscriptionsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerUserSubscriptionsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerUserSubscriptionsConfig()) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerUserSubscriptionsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerUserSubscriptionsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLicenseManagerUserSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerUserSubscriptionsClient(AmazonLicenseManagerUserSubscriptionsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLicenseManagerUserSubscriptionsClient(AWSCredentials credentials)
            : this(credentials, new AmazonLicenseManagerUserSubscriptionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerUserSubscriptionsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLicenseManagerUserSubscriptionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Credentials and an
        /// AmazonLicenseManagerUserSubscriptionsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLicenseManagerUserSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerUserSubscriptionsClient(AWSCredentials credentials, AmazonLicenseManagerUserSubscriptionsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLicenseManagerUserSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerUserSubscriptionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerUserSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerUserSubscriptionsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerUserSubscriptionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLicenseManagerUserSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerUserSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLicenseManagerUserSubscriptionsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLicenseManagerUserSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerUserSubscriptionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerUserSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerUserSubscriptionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerUserSubscriptionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerUserSubscriptionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLicenseManagerUserSubscriptionsClient Configuration Object</param>
        public AmazonLicenseManagerUserSubscriptionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLicenseManagerUserSubscriptionsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLicenseManagerUserSubscriptionsEndpointResolver());
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


        #region  AssociateUser

        /// <summary>
        /// Associates the user to an EC2 instance to utilize user-based subscriptions.
        /// 
        ///  <note> 
        /// <para>
        /// Your estimated bill for charges on the number of users and related costs will take
        /// 48 hours to appear for billing periods that haven't closed (marked as <b>Pending</b>
        /// billing status) in Amazon Web Services Billing. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/invoice.html">Viewing
        /// your monthly charges</a> in the <i>Amazon Web Services Billing User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUser service method.</param>
        /// 
        /// <returns>The response from the AssociateUser service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/AssociateUser">REST API Reference for AssociateUser Operation</seealso>
        public virtual AssociateUserResponse AssociateUser(AssociateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserResponseUnmarshaller.Instance;

            return Invoke<AssociateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateUser operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/AssociateUser">REST API Reference for AssociateUser Operation</seealso>
        public virtual IAsyncResult BeginAssociateUser(AssociateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateUser.</param>
        /// 
        /// <returns>Returns a  AssociateUserResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/AssociateUser">REST API Reference for AssociateUser Operation</seealso>
        public virtual AssociateUserResponse EndAssociateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterIdentityProvider

        /// <summary>
        /// Deregisters the identity provider from providing user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the DeregisterIdentityProvider service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DeregisterIdentityProvider">REST API Reference for DeregisterIdentityProvider Operation</seealso>
        public virtual DeregisterIdentityProviderResponse DeregisterIdentityProvider(DeregisterIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DeregisterIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterIdentityProvider operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DeregisterIdentityProvider">REST API Reference for DeregisterIdentityProvider Operation</seealso>
        public virtual IAsyncResult BeginDeregisterIdentityProvider(DeregisterIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterIdentityProvider.</param>
        /// 
        /// <returns>Returns a  DeregisterIdentityProviderResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DeregisterIdentityProvider">REST API Reference for DeregisterIdentityProvider Operation</seealso>
        public virtual DeregisterIdentityProviderResponse EndDeregisterIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateUser

        /// <summary>
        /// Disassociates the user from an EC2 instance providing user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUser service method.</param>
        /// 
        /// <returns>The response from the DisassociateUser service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DisassociateUser">REST API Reference for DisassociateUser Operation</seealso>
        public virtual DisassociateUserResponse DisassociateUser(DisassociateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserResponseUnmarshaller.Instance;

            return Invoke<DisassociateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUser operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DisassociateUser">REST API Reference for DisassociateUser Operation</seealso>
        public virtual IAsyncResult BeginDisassociateUser(DisassociateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateUser.</param>
        /// 
        /// <returns>Returns a  DisassociateUserResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/DisassociateUser">REST API Reference for DisassociateUser Operation</seealso>
        public virtual DisassociateUserResponse EndDisassociateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentityProviders

        /// <summary>
        /// Lists the identity providers for user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual IAsyncResult BeginListIdentityProviders(ListIdentityProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityProviders.</param>
        /// 
        /// <returns>Returns a  ListIdentityProvidersResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual ListIdentityProvidersResponse EndListIdentityProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentityProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstances

        /// <summary>
        /// Lists the EC2 instances providing user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListInstances">REST API Reference for ListInstances Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListInstances">REST API Reference for ListInstances Operation</seealso>
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
        /// <returns>Returns a  ListInstancesResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse EndListInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProductSubscriptions

        /// <summary>
        /// Lists the user-based subscription products available from an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListProductSubscriptions service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListProductSubscriptions">REST API Reference for ListProductSubscriptions Operation</seealso>
        public virtual ListProductSubscriptionsResponse ListProductSubscriptions(ListProductSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProductSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListProductSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProductSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProductSubscriptions operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProductSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListProductSubscriptions">REST API Reference for ListProductSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginListProductSubscriptions(ListProductSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProductSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProductSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProductSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListProductSubscriptionsResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListProductSubscriptions">REST API Reference for ListProductSubscriptions Operation</seealso>
        public virtual ListProductSubscriptionsResponse EndListProductSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProductSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserAssociations

        /// <summary>
        /// Lists user associations for an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAssociations service method.</param>
        /// 
        /// <returns>The response from the ListUserAssociations service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListUserAssociations">REST API Reference for ListUserAssociations Operation</seealso>
        public virtual ListUserAssociationsResponse ListUserAssociations(ListUserAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListUserAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserAssociations operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListUserAssociations">REST API Reference for ListUserAssociations Operation</seealso>
        public virtual IAsyncResult BeginListUserAssociations(ListUserAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserAssociations.</param>
        /// 
        /// <returns>Returns a  ListUserAssociationsResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/ListUserAssociations">REST API Reference for ListUserAssociations Operation</seealso>
        public virtual ListUserAssociationsResponse EndListUserAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterIdentityProvider

        /// <summary>
        /// Registers an identity provider for user-based subscriptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the RegisterIdentityProvider service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/RegisterIdentityProvider">REST API Reference for RegisterIdentityProvider Operation</seealso>
        public virtual RegisterIdentityProviderResponse RegisterIdentityProvider(RegisterIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<RegisterIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterIdentityProvider operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterIdentityProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/RegisterIdentityProvider">REST API Reference for RegisterIdentityProvider Operation</seealso>
        public virtual IAsyncResult BeginRegisterIdentityProvider(RegisterIdentityProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterIdentityProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterIdentityProvider.</param>
        /// 
        /// <returns>Returns a  RegisterIdentityProviderResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/RegisterIdentityProvider">REST API Reference for RegisterIdentityProvider Operation</seealso>
        public virtual RegisterIdentityProviderResponse EndRegisterIdentityProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterIdentityProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  StartProductSubscription

        /// <summary>
        /// Starts a product subscription for a user with the specified identity provider.
        /// 
        ///  <note> 
        /// <para>
        /// Your estimated bill for charges on the number of users and related costs will take
        /// 48 hours to appear for billing periods that haven't closed (marked as <b>Pending</b>
        /// billing status) in Amazon Web Services Billing. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/invoice.html">Viewing
        /// your monthly charges</a> in the <i>Amazon Web Services Billing User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProductSubscription service method.</param>
        /// 
        /// <returns>The response from the StartProductSubscription service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StartProductSubscription">REST API Reference for StartProductSubscription Operation</seealso>
        public virtual StartProductSubscriptionResponse StartProductSubscription(StartProductSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProductSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProductSubscriptionResponseUnmarshaller.Instance;

            return Invoke<StartProductSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartProductSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartProductSubscription operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartProductSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StartProductSubscription">REST API Reference for StartProductSubscription Operation</seealso>
        public virtual IAsyncResult BeginStartProductSubscription(StartProductSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProductSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProductSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartProductSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartProductSubscription.</param>
        /// 
        /// <returns>Returns a  StartProductSubscriptionResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StartProductSubscription">REST API Reference for StartProductSubscription Operation</seealso>
        public virtual StartProductSubscriptionResponse EndStartProductSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<StartProductSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopProductSubscription

        /// <summary>
        /// Stops a product subscription for a user with the specified identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProductSubscription service method.</param>
        /// 
        /// <returns>The response from the StopProductSubscription service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StopProductSubscription">REST API Reference for StopProductSubscription Operation</seealso>
        public virtual StopProductSubscriptionResponse StopProductSubscription(StopProductSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProductSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProductSubscriptionResponseUnmarshaller.Instance;

            return Invoke<StopProductSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopProductSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopProductSubscription operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopProductSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StopProductSubscription">REST API Reference for StopProductSubscription Operation</seealso>
        public virtual IAsyncResult BeginStopProductSubscription(StopProductSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProductSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProductSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopProductSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopProductSubscription.</param>
        /// 
        /// <returns>Returns a  StopProductSubscriptionResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/StopProductSubscription">REST API Reference for StopProductSubscription Operation</seealso>
        public virtual StopProductSubscriptionResponse EndStopProductSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<StopProductSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIdentityProviderSettings

        /// <summary>
        /// Updates additional product configuration settings for the registered identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityProviderSettings service method, as returned by LicenseManagerUserSubscriptions.</returns>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.LicenseManagerUserSubscriptions.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/UpdateIdentityProviderSettings">REST API Reference for UpdateIdentityProviderSettings Operation</seealso>
        public virtual UpdateIdentityProviderSettingsResponse UpdateIdentityProviderSettings(UpdateIdentityProviderSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProviderSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderSettings operation on AmazonLicenseManagerUserSubscriptionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityProviderSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/UpdateIdentityProviderSettings">REST API Reference for UpdateIdentityProviderSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateIdentityProviderSettings(UpdateIdentityProviderSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityProviderSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityProviderSettings.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityProviderSettingsResult from LicenseManagerUserSubscriptions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-user-subscriptions-2018-05-10/UpdateIdentityProviderSettings">REST API Reference for UpdateIdentityProviderSettings Operation</seealso>
        public virtual UpdateIdentityProviderSettingsResponse EndUpdateIdentityProviderSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIdentityProviderSettingsResponse>(asyncResult);
        }

        #endregion
        
    }
}