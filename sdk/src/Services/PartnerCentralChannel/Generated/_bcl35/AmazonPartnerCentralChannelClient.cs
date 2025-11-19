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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.PartnerCentralChannel.Model;
using Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations;
using Amazon.PartnerCentralChannel.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralChannel
{
    /// <summary>
    /// <para>Implementation for accessing PartnerCentralChannel</para>
    ///
    /// AWS Partner Central Channel service for managing partner relationships, handshakes,
    /// and program management accounts.
    /// </summary>
    public partial class AmazonPartnerCentralChannelClient : AmazonServiceClient, IAmazonPartnerCentralChannel
    {
        private static IServiceMetadata serviceMetadata = new AmazonPartnerCentralChannelMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IPartnerCentralChannelPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPartnerCentralChannelPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PartnerCentralChannelPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralChannelClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPartnerCentralChannelConfig()) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralChannelClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPartnerCentralChannelConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPartnerCentralChannelClient Configuration Object</param>
        public AmazonPartnerCentralChannelClient(AmazonPartnerCentralChannelConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPartnerCentralChannelClient(AWSCredentials credentials)
            : this(credentials, new AmazonPartnerCentralChannelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralChannelClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPartnerCentralChannelConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Credentials and an
        /// AmazonPartnerCentralChannelClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPartnerCentralChannelClient Configuration Object</param>
        public AmazonPartnerCentralChannelClient(AWSCredentials credentials, AmazonPartnerCentralChannelConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPartnerCentralChannelClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralChannelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralChannelClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralChannelConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralChannelClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPartnerCentralChannelClient Configuration Object</param>
        public AmazonPartnerCentralChannelClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPartnerCentralChannelConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPartnerCentralChannelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralChannelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralChannelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralChannelConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralChannelClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralChannelClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPartnerCentralChannelClient Configuration Object</param>
        public AmazonPartnerCentralChannelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPartnerCentralChannelConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralChannelEndpointResolver());
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


        #region  AcceptChannelHandshake

        /// <summary>
        /// Accepts a pending channel handshake request from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the AcceptChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/AcceptChannelHandshake">REST API Reference for AcceptChannelHandshake Operation</seealso>
        public virtual AcceptChannelHandshakeResponse AcceptChannelHandshake(AcceptChannelHandshakeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptChannelHandshakeResponseUnmarshaller.Instance;

            return Invoke<AcceptChannelHandshakeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/AcceptChannelHandshake">REST API Reference for AcceptChannelHandshake Operation</seealso>
        public virtual IAsyncResult BeginAcceptChannelHandshake(AcceptChannelHandshakeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptChannelHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptChannelHandshake.</param>
        /// 
        /// <returns>Returns a  AcceptChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/AcceptChannelHandshake">REST API Reference for AcceptChannelHandshake Operation</seealso>
        public virtual AcceptChannelHandshakeResponse EndAcceptChannelHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptChannelHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelChannelHandshake

        /// <summary>
        /// Cancels a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the CancelChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CancelChannelHandshake">REST API Reference for CancelChannelHandshake Operation</seealso>
        public virtual CancelChannelHandshakeResponse CancelChannelHandshake(CancelChannelHandshakeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelChannelHandshakeResponseUnmarshaller.Instance;

            return Invoke<CancelChannelHandshakeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CancelChannelHandshake">REST API Reference for CancelChannelHandshake Operation</seealso>
        public virtual IAsyncResult BeginCancelChannelHandshake(CancelChannelHandshakeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelChannelHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelChannelHandshake.</param>
        /// 
        /// <returns>Returns a  CancelChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CancelChannelHandshake">REST API Reference for CancelChannelHandshake Operation</seealso>
        public virtual CancelChannelHandshakeResponse EndCancelChannelHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelChannelHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelHandshake

        /// <summary>
        /// Creates a new channel handshake request to establish a partnership with another AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the CreateChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateChannelHandshake">REST API Reference for CreateChannelHandshake Operation</seealso>
        public virtual CreateChannelHandshakeResponse CreateChannelHandshake(CreateChannelHandshakeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelHandshakeResponseUnmarshaller.Instance;

            return Invoke<CreateChannelHandshakeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateChannelHandshake">REST API Reference for CreateChannelHandshake Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelHandshake(CreateChannelHandshakeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelHandshake.</param>
        /// 
        /// <returns>Returns a  CreateChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateChannelHandshake">REST API Reference for CreateChannelHandshake Operation</seealso>
        public virtual CreateChannelHandshakeResponse EndCreateChannelHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProgramManagementAccount

        /// <summary>
        /// Creates a new program management account for managing partner relationships.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgramManagementAccount service method.</param>
        /// 
        /// <returns>The response from the CreateProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateProgramManagementAccount">REST API Reference for CreateProgramManagementAccount Operation</seealso>
        public virtual CreateProgramManagementAccountResponse CreateProgramManagementAccount(CreateProgramManagementAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProgramManagementAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgramManagementAccountResponseUnmarshaller.Instance;

            return Invoke<CreateProgramManagementAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgramManagementAccount operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProgramManagementAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateProgramManagementAccount">REST API Reference for CreateProgramManagementAccount Operation</seealso>
        public virtual IAsyncResult BeginCreateProgramManagementAccount(CreateProgramManagementAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProgramManagementAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgramManagementAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProgramManagementAccount.</param>
        /// 
        /// <returns>Returns a  CreateProgramManagementAccountResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateProgramManagementAccount">REST API Reference for CreateProgramManagementAccount Operation</seealso>
        public virtual CreateProgramManagementAccountResponse EndCreateProgramManagementAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProgramManagementAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRelationship

        /// <summary>
        /// Creates a new partner relationship between accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationship service method.</param>
        /// 
        /// <returns>The response from the CreateRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateRelationship">REST API Reference for CreateRelationship Operation</seealso>
        public virtual CreateRelationshipResponse CreateRelationship(CreateRelationshipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationshipResponseUnmarshaller.Instance;

            return Invoke<CreateRelationshipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateRelationship">REST API Reference for CreateRelationship Operation</seealso>
        public virtual IAsyncResult BeginCreateRelationship(CreateRelationshipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationshipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelationship.</param>
        /// 
        /// <returns>Returns a  CreateRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateRelationship">REST API Reference for CreateRelationship Operation</seealso>
        public virtual CreateRelationshipResponse EndCreateRelationship(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRelationshipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProgramManagementAccount

        /// <summary>
        /// Deletes a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgramManagementAccount service method.</param>
        /// 
        /// <returns>The response from the DeleteProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteProgramManagementAccount">REST API Reference for DeleteProgramManagementAccount Operation</seealso>
        public virtual DeleteProgramManagementAccountResponse DeleteProgramManagementAccount(DeleteProgramManagementAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProgramManagementAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgramManagementAccountResponseUnmarshaller.Instance;

            return Invoke<DeleteProgramManagementAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgramManagementAccount operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProgramManagementAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteProgramManagementAccount">REST API Reference for DeleteProgramManagementAccount Operation</seealso>
        public virtual IAsyncResult BeginDeleteProgramManagementAccount(DeleteProgramManagementAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProgramManagementAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgramManagementAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProgramManagementAccount.</param>
        /// 
        /// <returns>Returns a  DeleteProgramManagementAccountResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteProgramManagementAccount">REST API Reference for DeleteProgramManagementAccount Operation</seealso>
        public virtual DeleteProgramManagementAccountResponse EndDeleteProgramManagementAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProgramManagementAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRelationship

        /// <summary>
        /// Deletes a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationship service method.</param>
        /// 
        /// <returns>The response from the DeleteRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteRelationship">REST API Reference for DeleteRelationship Operation</seealso>
        public virtual DeleteRelationshipResponse DeleteRelationship(DeleteRelationshipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationshipResponseUnmarshaller.Instance;

            return Invoke<DeleteRelationshipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteRelationship">REST API Reference for DeleteRelationship Operation</seealso>
        public virtual IAsyncResult BeginDeleteRelationship(DeleteRelationshipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationshipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRelationship.</param>
        /// 
        /// <returns>Returns a  DeleteRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteRelationship">REST API Reference for DeleteRelationship Operation</seealso>
        public virtual DeleteRelationshipResponse EndDeleteRelationship(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRelationshipResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRelationship

        /// <summary>
        /// Retrieves details of a specific partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationship service method.</param>
        /// 
        /// <returns>The response from the GetRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/GetRelationship">REST API Reference for GetRelationship Operation</seealso>
        public virtual GetRelationshipResponse GetRelationship(GetRelationshipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationshipResponseUnmarshaller.Instance;

            return Invoke<GetRelationshipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/GetRelationship">REST API Reference for GetRelationship Operation</seealso>
        public virtual IAsyncResult BeginGetRelationship(GetRelationshipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationshipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationship.</param>
        /// 
        /// <returns>Returns a  GetRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/GetRelationship">REST API Reference for GetRelationship Operation</seealso>
        public virtual GetRelationshipResponse EndGetRelationship(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRelationshipResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelHandshakes

        /// <summary>
        /// Lists channel handshakes based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelHandshakes service method.</param>
        /// 
        /// <returns>The response from the ListChannelHandshakes service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListChannelHandshakes">REST API Reference for ListChannelHandshakes Operation</seealso>
        public virtual ListChannelHandshakesResponse ListChannelHandshakes(ListChannelHandshakesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelHandshakesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelHandshakesResponseUnmarshaller.Instance;

            return Invoke<ListChannelHandshakesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelHandshakes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelHandshakes operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelHandshakes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListChannelHandshakes">REST API Reference for ListChannelHandshakes Operation</seealso>
        public virtual IAsyncResult BeginListChannelHandshakes(ListChannelHandshakesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelHandshakesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelHandshakesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelHandshakes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelHandshakes.</param>
        /// 
        /// <returns>Returns a  ListChannelHandshakesResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListChannelHandshakes">REST API Reference for ListChannelHandshakes Operation</seealso>
        public virtual ListChannelHandshakesResponse EndListChannelHandshakes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelHandshakesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProgramManagementAccounts

        /// <summary>
        /// Lists program management accounts based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProgramManagementAccounts service method.</param>
        /// 
        /// <returns>The response from the ListProgramManagementAccounts service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListProgramManagementAccounts">REST API Reference for ListProgramManagementAccounts Operation</seealso>
        public virtual ListProgramManagementAccountsResponse ListProgramManagementAccounts(ListProgramManagementAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProgramManagementAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProgramManagementAccountsResponseUnmarshaller.Instance;

            return Invoke<ListProgramManagementAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProgramManagementAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProgramManagementAccounts operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProgramManagementAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListProgramManagementAccounts">REST API Reference for ListProgramManagementAccounts Operation</seealso>
        public virtual IAsyncResult BeginListProgramManagementAccounts(ListProgramManagementAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProgramManagementAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProgramManagementAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProgramManagementAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProgramManagementAccounts.</param>
        /// 
        /// <returns>Returns a  ListProgramManagementAccountsResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListProgramManagementAccounts">REST API Reference for ListProgramManagementAccounts Operation</seealso>
        public virtual ListProgramManagementAccountsResponse EndListProgramManagementAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProgramManagementAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRelationships

        /// <summary>
        /// Lists partner relationships based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelationships service method.</param>
        /// 
        /// <returns>The response from the ListRelationships service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListRelationships">REST API Reference for ListRelationships Operation</seealso>
        public virtual ListRelationshipsResponse ListRelationships(ListRelationshipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListRelationshipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRelationships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRelationships operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRelationships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListRelationships">REST API Reference for ListRelationships Operation</seealso>
        public virtual IAsyncResult BeginListRelationships(ListRelationshipsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelationshipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRelationships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRelationships.</param>
        /// 
        /// <returns>Returns a  ListRelationshipsResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListRelationships">REST API Reference for ListRelationships Operation</seealso>
        public virtual ListRelationshipsResponse EndListRelationships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRelationshipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectChannelHandshake

        /// <summary>
        /// Rejects a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectChannelHandshake service method.</param>
        /// 
        /// <returns>The response from the RejectChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/RejectChannelHandshake">REST API Reference for RejectChannelHandshake Operation</seealso>
        public virtual RejectChannelHandshakeResponse RejectChannelHandshake(RejectChannelHandshakeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectChannelHandshakeResponseUnmarshaller.Instance;

            return Invoke<RejectChannelHandshakeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectChannelHandshake operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectChannelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/RejectChannelHandshake">REST API Reference for RejectChannelHandshake Operation</seealso>
        public virtual IAsyncResult BeginRejectChannelHandshake(RejectChannelHandshakeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectChannelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectChannelHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectChannelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectChannelHandshake.</param>
        /// 
        /// <returns>Returns a  RejectChannelHandshakeResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/RejectChannelHandshake">REST API Reference for RejectChannelHandshake Operation</seealso>
        public virtual RejectChannelHandshakeResponse EndRejectChannelHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectChannelHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProgramManagementAccount

        /// <summary>
        /// Updates the properties of a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgramManagementAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateProgramManagementAccount">REST API Reference for UpdateProgramManagementAccount Operation</seealso>
        public virtual UpdateProgramManagementAccountResponse UpdateProgramManagementAccount(UpdateProgramManagementAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProgramManagementAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProgramManagementAccountResponseUnmarshaller.Instance;

            return Invoke<UpdateProgramManagementAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgramManagementAccount operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProgramManagementAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateProgramManagementAccount">REST API Reference for UpdateProgramManagementAccount Operation</seealso>
        public virtual IAsyncResult BeginUpdateProgramManagementAccount(UpdateProgramManagementAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProgramManagementAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProgramManagementAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProgramManagementAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProgramManagementAccount.</param>
        /// 
        /// <returns>Returns a  UpdateProgramManagementAccountResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateProgramManagementAccount">REST API Reference for UpdateProgramManagementAccount Operation</seealso>
        public virtual UpdateProgramManagementAccountResponse EndUpdateProgramManagementAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProgramManagementAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRelationship

        /// <summary>
        /// Updates the properties of a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationship service method.</param>
        /// 
        /// <returns>The response from the UpdateRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateRelationship">REST API Reference for UpdateRelationship Operation</seealso>
        public virtual UpdateRelationshipResponse UpdateRelationship(UpdateRelationshipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationshipResponseUnmarshaller.Instance;

            return Invoke<UpdateRelationshipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRelationship operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationship operation on AmazonPartnerCentralChannelClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRelationship
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateRelationship">REST API Reference for UpdateRelationship Operation</seealso>
        public virtual IAsyncResult BeginUpdateRelationship(UpdateRelationshipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationshipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRelationship operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRelationship.</param>
        /// 
        /// <returns>Returns a  UpdateRelationshipResult from PartnerCentralChannel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateRelationship">REST API Reference for UpdateRelationship Operation</seealso>
        public virtual UpdateRelationshipResponse EndUpdateRelationship(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRelationshipResponse>(asyncResult);
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
            var resolver = new AmazonPartnerCentralChannelEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}