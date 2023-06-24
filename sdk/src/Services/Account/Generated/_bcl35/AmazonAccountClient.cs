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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Account.Model;
using Amazon.Account.Model.Internal.MarshallTransformations;
using Amazon.Account.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Account
{
    /// <summary>
    /// Implementation for accessing Account
    ///
    /// Operations for Amazon Web Services Account Management
    /// </summary>
    public partial class AmazonAccountClient : AmazonServiceClient, IAmazonAccount
    {
        private static IServiceMetadata serviceMetadata = new AmazonAccountMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IAccountPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAccountPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AccountPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        public AmazonAccountClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAccountConfig()) { }

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        public AmazonAccountClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAccountConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(AmazonAccountConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAccountClient(AWSCredentials credentials)
            : this(credentials, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials and an
        /// AmazonAccountClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(AWSCredentials credentials, AmazonAccountConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAccountConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAccountConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccountEndpointResolver());
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


        #region  DeleteAlternateContact

        /// <summary>
        /// Deletes the specified alternate contact from an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlternateContact service method.</param>
        /// 
        /// <returns>The response from the DeleteAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        public virtual DeleteAlternateContactResponse DeleteAlternateContact(DeleteAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlternateContactResponseUnmarshaller.Instance;

            return Invoke<DeleteAlternateContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlternateContact operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlternateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlternateContact(DeleteAlternateContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlternateContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlternateContact.</param>
        /// 
        /// <returns>Returns a  DeleteAlternateContactResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        public virtual DeleteAlternateContactResponse EndDeleteAlternateContact(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAlternateContactResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableRegion

        /// <summary>
        /// Disables (opts-out) a particular Region for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRegion service method.</param>
        /// 
        /// <returns>The response from the DisableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        public virtual DisableRegionResponse DisableRegion(DisableRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRegionResponseUnmarshaller.Instance;

            return Invoke<DisableRegionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRegion operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        public virtual IAsyncResult BeginDisableRegion(DisableRegionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRegionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRegion.</param>
        /// 
        /// <returns>Returns a  DisableRegionResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DisableRegion">REST API Reference for DisableRegion Operation</seealso>
        public virtual DisableRegionResponse EndDisableRegion(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableRegionResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableRegion

        /// <summary>
        /// Enables (opts-in) a particular Region for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRegion service method.</param>
        /// 
        /// <returns>The response from the EnableRegion service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ConflictException">
        /// The request could not be processed because of a conflict in the current status of
        /// the resource. For example, this happens if you try to enable a Region that is currently
        /// being disabled (in a status of DISABLING).
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        public virtual EnableRegionResponse EnableRegion(EnableRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRegionResponseUnmarshaller.Instance;

            return Invoke<EnableRegionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRegion operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        public virtual IAsyncResult BeginEnableRegion(EnableRegionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRegionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRegion.</param>
        /// 
        /// <returns>Returns a  EnableRegionResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/EnableRegion">REST API Reference for EnableRegion Operation</seealso>
        public virtual EnableRegionResponse EndEnableRegion(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableRegionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAlternateContact

        /// <summary>
        /// Retrieves the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlternateContact service method.</param>
        /// 
        /// <returns>The response from the GetAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        public virtual GetAlternateContactResponse GetAlternateContact(GetAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlternateContactResponseUnmarshaller.Instance;

            return Invoke<GetAlternateContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAlternateContact operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAlternateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        public virtual IAsyncResult BeginGetAlternateContact(GetAlternateContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlternateContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAlternateContact.</param>
        /// 
        /// <returns>Returns a  GetAlternateContactResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        public virtual GetAlternateContactResponse EndGetAlternateContact(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAlternateContactResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContactInformation

        /// <summary>
        /// Retrieves the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactInformation service method.</param>
        /// 
        /// <returns>The response from the GetContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        public virtual GetContactInformationResponse GetContactInformation(GetContactInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactInformationResponseUnmarshaller.Instance;

            return Invoke<GetContactInformationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactInformation operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        public virtual IAsyncResult BeginGetContactInformation(GetContactInformationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactInformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactInformation.</param>
        /// 
        /// <returns>Returns a  GetContactInformationResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetContactInformation">REST API Reference for GetContactInformation Operation</seealso>
        public virtual GetContactInformationResponse EndGetContactInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContactInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRegionOptStatus

        /// <summary>
        /// Retrieves the opt-in status of a particular Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegionOptStatus service method.</param>
        /// 
        /// <returns>The response from the GetRegionOptStatus service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        public virtual GetRegionOptStatusResponse GetRegionOptStatus(GetRegionOptStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionOptStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionOptStatusResponseUnmarshaller.Instance;

            return Invoke<GetRegionOptStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegionOptStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegionOptStatus operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegionOptStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        public virtual IAsyncResult BeginGetRegionOptStatus(GetRegionOptStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionOptStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionOptStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegionOptStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegionOptStatus.</param>
        /// 
        /// <returns>Returns a  GetRegionOptStatusResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetRegionOptStatus">REST API Reference for GetRegionOptStatus Operation</seealso>
        public virtual GetRegionOptStatusResponse EndGetRegionOptStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRegionOptStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRegions

        /// <summary>
        /// Lists all the Regions for a given account and their respective opt-in statuses. Optionally,
        /// this list can be filtered by the <code>region-opt-status-contains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionsResponseUnmarshaller.Instance;

            return Invoke<ListRegionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegions operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual IAsyncResult BeginListRegions(ListRegionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegions.</param>
        /// 
        /// <returns>Returns a  ListRegionsResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual ListRegionsResponse EndListRegions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRegionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAlternateContact

        /// <summary>
        /// Modifies the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can update the alternate contact information for an Amazon Web Services
        /// account that is managed by Organizations, you must first enable integration between
        /// Amazon Web Services Account Management and Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/accounts/latest/reference/using-orgs-trusted-access.html">Enabling
        /// trusted access for Amazon Web Services Account Management</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlternateContact service method.</param>
        /// 
        /// <returns>The response from the PutAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        public virtual PutAlternateContactResponse PutAlternateContact(PutAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlternateContactResponseUnmarshaller.Instance;

            return Invoke<PutAlternateContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAlternateContact operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAlternateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        public virtual IAsyncResult BeginPutAlternateContact(PutAlternateContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlternateContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAlternateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAlternateContact.</param>
        /// 
        /// <returns>Returns a  PutAlternateContactResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        public virtual PutAlternateContactResponse EndPutAlternateContact(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAlternateContactResponse>(asyncResult);
        }

        #endregion
        
        #region  PutContactInformation

        /// <summary>
        /// Updates the primary contact information of an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the primary contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Update
        /// the primary and alternate contact information</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContactInformation service method.</param>
        /// 
        /// <returns>The response from the PutContactInformation service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        public virtual PutContactInformationResponse PutContactInformation(PutContactInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContactInformationResponseUnmarshaller.Instance;

            return Invoke<PutContactInformationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutContactInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContactInformation operation on AmazonAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutContactInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        public virtual IAsyncResult BeginPutContactInformation(PutContactInformationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutContactInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutContactInformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutContactInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutContactInformation.</param>
        /// 
        /// <returns>Returns a  PutContactInformationResult from Account.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutContactInformation">REST API Reference for PutContactInformation Operation</seealso>
        public virtual PutContactInformationResponse EndPutContactInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<PutContactInformationResponse>(asyncResult);
        }

        #endregion
        
    }
}