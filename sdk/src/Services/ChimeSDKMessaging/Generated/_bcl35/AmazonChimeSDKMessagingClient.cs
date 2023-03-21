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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKMessaging.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ChimeSDKMessaging
{
    /// <summary>
    /// Implementation for accessing ChimeSDKMessaging
    ///
    /// The Amazon Chime SDK Messaging APIs in this section allow software developers to send
    /// and receive messages in custom messaging applications. These APIs depend on the frameworks
    /// provided by the Amazon Chime SDK Identity APIs. For more information about the messaging
    /// APIs, see <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_Operations_Amazon_Chime_SDK_Messaging.html">Amazon
    /// Chime SDK messaging</a>.
    /// </summary>
    public partial class AmazonChimeSDKMessagingClient : AmazonServiceClient, IAmazonChimeSDKMessaging
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKMessagingMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IChimeSDKMessagingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChimeSDKMessagingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChimeSDKMessagingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with the credentials loaded from the application's
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
        public AmazonChimeSDKMessagingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMessagingConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with the credentials loaded from the application's
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
        public AmazonChimeSDKMessagingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMessagingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(AmazonChimeSDKMessagingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeSDKMessagingClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeSDKMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMessagingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeSDKMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Credentials and an
        /// AmazonChimeSDKMessagingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(AWSCredentials credentials, AmazonChimeSDKMessagingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMessagingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeSDKMessagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeSDKMessagingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonChimeSDKMessagingEndpointResolver());
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


        #region  AssociateChannelFlow

        /// <summary>
        /// Associates a channel flow with a channel. Once associated, all messages to that channel
        /// go through channel flow processors. To stop processing, use the <code>DisassociateChannelFlow</code>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        /// Only administrators or channel moderators can associate a channel flow. The <code>x-amz-chime-bearer</code>
        /// request header is mandatory. Use the <code>AppInstanceUserArn</code> of the user that
        /// makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannelFlow service method.</param>
        /// 
        /// <returns>The response from the AssociateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/AssociateChannelFlow">REST API Reference for AssociateChannelFlow Operation</seealso>
        public virtual AssociateChannelFlowResponse AssociateChannelFlow(AssociateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<AssociateChannelFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannelFlow operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateChannelFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/AssociateChannelFlow">REST API Reference for AssociateChannelFlow Operation</seealso>
        public virtual IAsyncResult BeginAssociateChannelFlow(AssociateChannelFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateChannelFlow.</param>
        /// 
        /// <returns>Returns a  AssociateChannelFlowResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/AssociateChannelFlow">REST API Reference for AssociateChannelFlow Operation</seealso>
        public virtual AssociateChannelFlowResponse EndAssociateChannelFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateChannelFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateChannelMembership

        /// <summary>
        /// Adds a specified number of users to a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateChannelMembership service method.</param>
        /// 
        /// <returns>The response from the BatchCreateChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/BatchCreateChannelMembership">REST API Reference for BatchCreateChannelMembership Operation</seealso>
        public virtual BatchCreateChannelMembershipResponse BatchCreateChannelMembership(BatchCreateChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<BatchCreateChannelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateChannelMembership operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/BatchCreateChannelMembership">REST API Reference for BatchCreateChannelMembership Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateChannelMembership(BatchCreateChannelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateChannelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateChannelMembership.</param>
        /// 
        /// <returns>Returns a  BatchCreateChannelMembershipResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/BatchCreateChannelMembership">REST API Reference for BatchCreateChannelMembership Operation</seealso>
        public virtual BatchCreateChannelMembershipResponse EndBatchCreateChannelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateChannelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  ChannelFlowCallback

        /// <summary>
        /// Calls back Chime SDK Messaging with a processing response message. This should be
        /// invoked from the processor Lambda. This is a developer API.
        /// 
        ///  
        /// <para>
        /// You can return one of the following processing responses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Update message content or metadata
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deny a message
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Make no changes to the message
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChannelFlowCallback service method.</param>
        /// 
        /// <returns>The response from the ChannelFlowCallback service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ChannelFlowCallback">REST API Reference for ChannelFlowCallback Operation</seealso>
        public virtual ChannelFlowCallbackResponse ChannelFlowCallback(ChannelFlowCallbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChannelFlowCallbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChannelFlowCallbackResponseUnmarshaller.Instance;

            return Invoke<ChannelFlowCallbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChannelFlowCallback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChannelFlowCallback operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChannelFlowCallback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ChannelFlowCallback">REST API Reference for ChannelFlowCallback Operation</seealso>
        public virtual IAsyncResult BeginChannelFlowCallback(ChannelFlowCallbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChannelFlowCallbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChannelFlowCallbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChannelFlowCallback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChannelFlowCallback.</param>
        /// 
        /// <returns>Returns a  ChannelFlowCallbackResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ChannelFlowCallback">REST API Reference for ChannelFlowCallback Operation</seealso>
        public virtual ChannelFlowCallbackResponse EndChannelFlowCallback(IAsyncResult asyncResult)
        {
            return EndInvoke<ChannelFlowCallbackResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannel

        /// <summary>
        /// Creates a channel to which you can add users and send messages.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelBan

        /// <summary>
        /// Permanently bans a member from a channel. Moderators can't add banned members to a
        /// channel. To undo a ban, you first have to <code>DeleteChannelBan</code>, and then
        /// <code>CreateChannelMembership</code>. Bans are cleaned up when you delete users or
        /// channels.
        /// 
        ///  
        /// <para>
        /// If you ban a user who is already part of a channel, that user is automatically kicked
        /// from the channel.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelBan service method.</param>
        /// 
        /// <returns>The response from the CreateChannelBan service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        public virtual CreateChannelBanResponse CreateChannelBan(CreateChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelBanResponseUnmarshaller.Instance;

            return Invoke<CreateChannelBanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelBan operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelBan(CreateChannelBanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelBanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelBan.</param>
        /// 
        /// <returns>Returns a  CreateChannelBanResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        public virtual CreateChannelBanResponse EndCreateChannelBan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelBanResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelFlow

        /// <summary>
        /// Creates a channel flow, a container for processors. Processors are AWS Lambda functions
        /// that perform actions on chat messages, such as stripping out profanity. You can associate
        /// channel flows with channels, and the processors in the channel flow then take action
        /// on all messages sent to that channel. This is a developer API.
        /// 
        ///  
        /// <para>
        /// Channel flows process the following items:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// New and updated messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Persistent and non-persistent messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Standard message type
        /// </para>
        ///  </li> </ol> <note> 
        /// <para>
        /// Channel flows don't process Control or System messages. For more information about
        /// the message types provided by Chime SDK Messaging, refer to <a href="https://docs.aws.amazon.com/chime/latest/dg/using-the-messaging-sdk.html#msg-types">Message
        /// types</a> in the <i>Amazon Chime developer guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelFlow service method.</param>
        /// 
        /// <returns>The response from the CreateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelFlow">REST API Reference for CreateChannelFlow Operation</seealso>
        public virtual CreateChannelFlowResponse CreateChannelFlow(CreateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<CreateChannelFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelFlow operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelFlow">REST API Reference for CreateChannelFlow Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelFlow(CreateChannelFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelFlow.</param>
        /// 
        /// <returns>Returns a  CreateChannelFlowResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelFlow">REST API Reference for CreateChannelFlow Operation</seealso>
        public virtual CreateChannelFlowResponse EndCreateChannelFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelMembership

        /// <summary>
        /// Adds a user to a channel. The <code>InvitedBy</code> field in <code>ChannelMembership</code>
        /// is derived from the request header. A channel member can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// List messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Send messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Receive messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Edit their own messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leave the channel
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Privacy settings impact this action as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Public Channels: You do not need to be a member to list messages, but you must be
        /// a member to send messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Private Channels: You must be a member to list or send messages.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelMembership service method.</param>
        /// 
        /// <returns>The response from the CreateChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        public virtual CreateChannelMembershipResponse CreateChannelMembership(CreateChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateChannelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelMembership operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelMembership(CreateChannelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelMembership.</param>
        /// 
        /// <returns>Returns a  CreateChannelMembershipResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        public virtual CreateChannelMembershipResponse EndCreateChannelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelModerator

        /// <summary>
        /// Creates a new <code>ChannelModerator</code>. A channel moderator can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add and remove other members of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove other moderators of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove user bans for the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redact messages in the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// List messages in the channel.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelModerator service method.</param>
        /// 
        /// <returns>The response from the CreateChannelModerator service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        public virtual CreateChannelModeratorResponse CreateChannelModerator(CreateChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<CreateChannelModeratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelModerator operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelModerator(CreateChannelModeratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelModeratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelModerator.</param>
        /// 
        /// <returns>Returns a  CreateChannelModeratorResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        public virtual CreateChannelModeratorResponse EndCreateChannelModerator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelModeratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannel

        /// <summary>
        /// Immediately makes a channel and its memberships inaccessible and marks them for deletion.
        /// This is an irreversible process.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelBan

        /// <summary>
        /// Removes a user from a channel's ban list.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelBan service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelBan service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        public virtual DeleteChannelBanResponse DeleteChannelBan(DeleteChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelBanResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelBanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelBan operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelBan(DeleteChannelBanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelBanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelBan.</param>
        /// 
        /// <returns>Returns a  DeleteChannelBanResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        public virtual DeleteChannelBanResponse EndDeleteChannelBan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelBanResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelFlow

        /// <summary>
        /// Deletes a channel flow, an irreversible process. This is a developer API.
        /// 
        ///  <note> 
        /// <para>
        ///  This API works only when the channel flow is not associated with any channel. To
        /// get a list of all channels that a channel flow is associated with, use the <code>ListChannelsAssociatedWithChannelFlow</code>
        /// API. Use the <code>DisassociateChannelFlow</code> API to disassociate a channel flow
        /// from all channels. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelFlow service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelFlow">REST API Reference for DeleteChannelFlow Operation</seealso>
        public virtual DeleteChannelFlowResponse DeleteChannelFlow(DeleteChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelFlow operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelFlow">REST API Reference for DeleteChannelFlow Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelFlow(DeleteChannelFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelFlow.</param>
        /// 
        /// <returns>Returns a  DeleteChannelFlowResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelFlow">REST API Reference for DeleteChannelFlow Operation</seealso>
        public virtual DeleteChannelFlowResponse EndDeleteChannelFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelMembership

        /// <summary>
        /// Removes a member from a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        public virtual DeleteChannelMembershipResponse DeleteChannelMembership(DeleteChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMembership operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelMembership(DeleteChannelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelMembership.</param>
        /// 
        /// <returns>Returns a  DeleteChannelMembershipResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        public virtual DeleteChannelMembershipResponse EndDeleteChannelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelMessage

        /// <summary>
        /// Deletes a channel message. Only admins can perform this action. Deletion makes messages
        /// inaccessible immediately. A background process deletes any revisions created by <code>UpdateChannelMessage</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMessage service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        public virtual DeleteChannelMessageResponse DeleteChannelMessage(DeleteChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMessageResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMessage operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelMessage(DeleteChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelMessage.</param>
        /// 
        /// <returns>Returns a  DeleteChannelMessageResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        public virtual DeleteChannelMessageResponse EndDeleteChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelModerator

        /// <summary>
        /// Deletes a channel moderator.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelModerator service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelModerator service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        public virtual DeleteChannelModeratorResponse DeleteChannelModerator(DeleteChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelModeratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelModerator operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelModerator(DeleteChannelModeratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelModeratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelModerator.</param>
        /// 
        /// <returns>Returns a  DeleteChannelModeratorResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        public virtual DeleteChannelModeratorResponse EndDeleteChannelModerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelModeratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMessagingStreamingConfigurations

        /// <summary>
        /// Deletes the streaming configurations for an <code>AppInstance</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/streaming-export.html">Streaming
        /// messaging data</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessagingStreamingConfigurations service method.</param>
        /// 
        /// <returns>The response from the DeleteMessagingStreamingConfigurations service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteMessagingStreamingConfigurations">REST API Reference for DeleteMessagingStreamingConfigurations Operation</seealso>
        public virtual DeleteMessagingStreamingConfigurationsResponse DeleteMessagingStreamingConfigurations(DeleteMessagingStreamingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessagingStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessagingStreamingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DeleteMessagingStreamingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessagingStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessagingStreamingConfigurations operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMessagingStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteMessagingStreamingConfigurations">REST API Reference for DeleteMessagingStreamingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDeleteMessagingStreamingConfigurations(DeleteMessagingStreamingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessagingStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessagingStreamingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMessagingStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessagingStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  DeleteMessagingStreamingConfigurationsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteMessagingStreamingConfigurations">REST API Reference for DeleteMessagingStreamingConfigurations Operation</seealso>
        public virtual DeleteMessagingStreamingConfigurationsResponse EndDeleteMessagingStreamingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMessagingStreamingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannel

        /// <summary>
        /// Returns the full details of a channel in an Amazon Chime <code>AppInstance</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelBan

        /// <summary>
        /// Returns the full details of a channel ban.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelBan service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelBan service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        public virtual DescribeChannelBanResponse DescribeChannelBan(DescribeChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelBanResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelBanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelBan operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelBan(DescribeChannelBanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelBanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelBan.</param>
        /// 
        /// <returns>Returns a  DescribeChannelBanResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        public virtual DescribeChannelBanResponse EndDescribeChannelBan(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelBanResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelFlow

        /// <summary>
        /// Returns the full details of a channel flow in an Amazon Chime <code>AppInstance</code>.
        /// This is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelFlow service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelFlow">REST API Reference for DescribeChannelFlow Operation</seealso>
        public virtual DescribeChannelFlowResponse DescribeChannelFlow(DescribeChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelFlow operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelFlow">REST API Reference for DescribeChannelFlow Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelFlow(DescribeChannelFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelFlow.</param>
        /// 
        /// <returns>Returns a  DescribeChannelFlowResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelFlow">REST API Reference for DescribeChannelFlow Operation</seealso>
        public virtual DescribeChannelFlowResponse EndDescribeChannelFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelMembership

        /// <summary>
        /// Returns the full details of a user's channel membership.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembership service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        public virtual DescribeChannelMembershipResponse DescribeChannelMembership(DescribeChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembership operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelMembership(DescribeChannelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelMembership.</param>
        /// 
        /// <returns>Returns a  DescribeChannelMembershipResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        public virtual DescribeChannelMembershipResponse EndDescribeChannelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelMembershipForAppInstanceUser

        /// <summary>
        /// Returns the details of a channel based on the membership of the specified <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembershipForAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelMembershipForAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        public virtual DescribeChannelMembershipForAppInstanceUserResponse DescribeChannelMembershipForAppInstanceUser(DescribeChannelMembershipForAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipForAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelMembershipForAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelMembershipForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembershipForAppInstanceUser operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelMembershipForAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelMembershipForAppInstanceUser(DescribeChannelMembershipForAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipForAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelMembershipForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelMembershipForAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeChannelMembershipForAppInstanceUserResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        public virtual DescribeChannelMembershipForAppInstanceUserResponse EndDescribeChannelMembershipForAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelMembershipForAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelModeratedByAppInstanceUser

        /// <summary>
        /// Returns the full details of a channel moderated by the specified <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModeratedByAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelModeratedByAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        public virtual DescribeChannelModeratedByAppInstanceUserResponse DescribeChannelModeratedByAppInstanceUser(DescribeChannelModeratedByAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelModeratedByAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModeratedByAppInstanceUser operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelModeratedByAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelModeratedByAppInstanceUser(DescribeChannelModeratedByAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelModeratedByAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeChannelModeratedByAppInstanceUserResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        public virtual DescribeChannelModeratedByAppInstanceUserResponse EndDescribeChannelModeratedByAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelModeratedByAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelModerator

        /// <summary>
        /// Returns the full details of a single ChannelModerator.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModerator service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelModerator service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        public virtual DescribeChannelModeratorResponse DescribeChannelModerator(DescribeChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelModeratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModerator operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelModerator(DescribeChannelModeratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelModerator.</param>
        /// 
        /// <returns>Returns a  DescribeChannelModeratorResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        public virtual DescribeChannelModeratorResponse EndDescribeChannelModerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelModeratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateChannelFlow

        /// <summary>
        /// Disassociates a channel flow from all its channels. Once disassociated, all messages
        /// to that channel stop going through the channel flow processor.
        /// 
        ///  <note> 
        /// <para>
        /// Only administrators or channel moderators can disassociate a channel flow. The <code>x-amz-chime-bearer</code>
        /// request header is mandatory. Use the <code>AppInstanceUserArn</code> of the user that
        /// makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannelFlow service method.</param>
        /// 
        /// <returns>The response from the DisassociateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DisassociateChannelFlow">REST API Reference for DisassociateChannelFlow Operation</seealso>
        public virtual DisassociateChannelFlowResponse DisassociateChannelFlow(DisassociateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<DisassociateChannelFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannelFlow operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateChannelFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DisassociateChannelFlow">REST API Reference for DisassociateChannelFlow Operation</seealso>
        public virtual IAsyncResult BeginDisassociateChannelFlow(DisassociateChannelFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateChannelFlow.</param>
        /// 
        /// <returns>Returns a  DisassociateChannelFlowResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DisassociateChannelFlow">REST API Reference for DisassociateChannelFlow Operation</seealso>
        public virtual DisassociateChannelFlowResponse EndDisassociateChannelFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateChannelFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannelMembershipPreferences

        /// <summary>
        /// Gets the membership preferences of an <code>AppInstanceUser</code> for the specified
        /// channel. The <code>AppInstanceUser</code> must be a member of the channel. Only the
        /// <code>AppInstanceUser</code> who owns the membership can retrieve preferences. Users
        /// in the <code>AppInstanceAdmin</code> and channel moderator roles can't retrieve preferences
        /// for other users. Banned users can't retrieve membership preferences for the channel
        /// from which they are banned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMembershipPreferences service method.</param>
        /// 
        /// <returns>The response from the GetChannelMembershipPreferences service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMembershipPreferences">REST API Reference for GetChannelMembershipPreferences Operation</seealso>
        public virtual GetChannelMembershipPreferencesResponse GetChannelMembershipPreferences(GetChannelMembershipPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMembershipPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMembershipPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetChannelMembershipPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelMembershipPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMembershipPreferences operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelMembershipPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMembershipPreferences">REST API Reference for GetChannelMembershipPreferences Operation</seealso>
        public virtual IAsyncResult BeginGetChannelMembershipPreferences(GetChannelMembershipPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMembershipPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMembershipPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelMembershipPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelMembershipPreferences.</param>
        /// 
        /// <returns>Returns a  GetChannelMembershipPreferencesResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMembershipPreferences">REST API Reference for GetChannelMembershipPreferences Operation</seealso>
        public virtual GetChannelMembershipPreferencesResponse EndGetChannelMembershipPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelMembershipPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannelMessage

        /// <summary>
        /// Gets the full details of a channel message.
        /// 
        ///  <note> 
        /// <para>
        /// The x-amz-chime-bearer request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessage service method.</param>
        /// 
        /// <returns>The response from the GetChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        public virtual GetChannelMessageResponse GetChannelMessage(GetChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageResponseUnmarshaller.Instance;

            return Invoke<GetChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessage operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginGetChannelMessage(GetChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelMessage.</param>
        /// 
        /// <returns>Returns a  GetChannelMessageResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        public virtual GetChannelMessageResponse EndGetChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannelMessageStatus

        /// <summary>
        /// Gets message status for a specified <code>messageId</code>. Use this API to determine
        /// the intermediate status of messages going through channel flow processing. The API
        /// provides an alternative to retrieving message status if the event was not received
        /// because a client wasn't connected to a websocket. 
        /// 
        ///  
        /// <para>
        /// Messages can have any one of these statuses.
        /// </para>
        ///  <dl> <dt>SENT</dt> <dd> 
        /// <para>
        /// Message processed successfully
        /// </para>
        ///  </dd> <dt>PENDING</dt> <dd> 
        /// <para>
        /// Ongoing processing
        /// </para>
        ///  </dd> <dt>FAILED</dt> <dd> 
        /// <para>
        /// Processing failed
        /// </para>
        ///  </dd> <dt>DENIED</dt> <dd> 
        /// <para>
        /// Messasge denied by the processor
        /// </para>
        ///  </dd> </dl> <note> <ul> <li> 
        /// <para>
        /// This API does not return statuses for denied messages, because we don't store them
        /// once the processor denies them. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only the message sender can invoke this API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessageStatus service method.</param>
        /// 
        /// <returns>The response from the GetChannelMessageStatus service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessageStatus">REST API Reference for GetChannelMessageStatus Operation</seealso>
        public virtual GetChannelMessageStatusResponse GetChannelMessageStatus(GetChannelMessageStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageStatusResponseUnmarshaller.Instance;

            return Invoke<GetChannelMessageStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelMessageStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessageStatus operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelMessageStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessageStatus">REST API Reference for GetChannelMessageStatus Operation</seealso>
        public virtual IAsyncResult BeginGetChannelMessageStatus(GetChannelMessageStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelMessageStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelMessageStatus.</param>
        /// 
        /// <returns>Returns a  GetChannelMessageStatusResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessageStatus">REST API Reference for GetChannelMessageStatus Operation</seealso>
        public virtual GetChannelMessageStatusResponse EndGetChannelMessageStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelMessageStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMessagingSessionEndpoint

        /// <summary>
        /// The details of the endpoint for the messaging session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingSessionEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetMessagingSessionEndpoint service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        public virtual GetMessagingSessionEndpointResponse GetMessagingSessionEndpoint(GetMessagingSessionEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingSessionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingSessionEndpointResponseUnmarshaller.Instance;

            return Invoke<GetMessagingSessionEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMessagingSessionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingSessionEndpoint operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMessagingSessionEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetMessagingSessionEndpoint(GetMessagingSessionEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingSessionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingSessionEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMessagingSessionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMessagingSessionEndpoint.</param>
        /// 
        /// <returns>Returns a  GetMessagingSessionEndpointResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        public virtual GetMessagingSessionEndpointResponse EndGetMessagingSessionEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMessagingSessionEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMessagingStreamingConfigurations

        /// <summary>
        /// Retrieves the data streaming configuration for an <code>AppInstance</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/streaming-export.html">Streaming
        /// messaging data</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingStreamingConfigurations service method.</param>
        /// 
        /// <returns>The response from the GetMessagingStreamingConfigurations service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetMessagingStreamingConfigurations">REST API Reference for GetMessagingStreamingConfigurations Operation</seealso>
        public virtual GetMessagingStreamingConfigurationsResponse GetMessagingStreamingConfigurations(GetMessagingStreamingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingStreamingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<GetMessagingStreamingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMessagingStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingStreamingConfigurations operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMessagingStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetMessagingStreamingConfigurations">REST API Reference for GetMessagingStreamingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginGetMessagingStreamingConfigurations(GetMessagingStreamingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingStreamingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMessagingStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMessagingStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  GetMessagingStreamingConfigurationsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetMessagingStreamingConfigurations">REST API Reference for GetMessagingStreamingConfigurations Operation</seealso>
        public virtual GetMessagingStreamingConfigurationsResponse EndGetMessagingStreamingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMessagingStreamingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelBans

        /// <summary>
        /// Lists all the users banned from a particular channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelBans service method.</param>
        /// 
        /// <returns>The response from the ListChannelBans service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        public virtual ListChannelBansResponse ListChannelBans(ListChannelBansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelBansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelBansResponseUnmarshaller.Instance;

            return Invoke<ListChannelBansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelBans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelBans operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelBans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        public virtual IAsyncResult BeginListChannelBans(ListChannelBansRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelBansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelBansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelBans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelBans.</param>
        /// 
        /// <returns>Returns a  ListChannelBansResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        public virtual ListChannelBansResponse EndListChannelBans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelBansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelFlows

        /// <summary>
        /// Returns a paginated lists of all the channel flows created under a single Chime. This
        /// is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelFlows service method.</param>
        /// 
        /// <returns>The response from the ListChannelFlows service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelFlows">REST API Reference for ListChannelFlows Operation</seealso>
        public virtual ListChannelFlowsResponse ListChannelFlows(ListChannelFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelFlowsResponseUnmarshaller.Instance;

            return Invoke<ListChannelFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelFlows operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelFlows">REST API Reference for ListChannelFlows Operation</seealso>
        public virtual IAsyncResult BeginListChannelFlows(ListChannelFlowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelFlowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelFlows.</param>
        /// 
        /// <returns>Returns a  ListChannelFlowsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelFlows">REST API Reference for ListChannelFlows Operation</seealso>
        public virtual ListChannelFlowsResponse EndListChannelFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelMemberships

        /// <summary>
        /// Lists all channel memberships in a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want to list the channels to which a specific app instance user belongs, see
        /// the <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_messaging-chime_ListChannelMembershipsForAppInstanceUser.html">ListChannelMembershipsForAppInstanceUser</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMemberships service method.</param>
        /// 
        /// <returns>The response from the ListChannelMemberships service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        public virtual ListChannelMembershipsResponse ListChannelMemberships(ListChannelMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListChannelMembershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMemberships operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        public virtual IAsyncResult BeginListChannelMemberships(ListChannelMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMemberships.</param>
        /// 
        /// <returns>Returns a  ListChannelMembershipsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        public virtual ListChannelMembershipsResponse EndListChannelMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelMembershipsForAppInstanceUser

        /// <summary>
        /// Lists all channels that a particular <code>AppInstanceUser</code> is a part of. Only
        /// an <code>AppInstanceAdmin</code> can call the API with a user ARN that is not their
        /// own. 
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMembershipsForAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the ListChannelMembershipsForAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        public virtual ListChannelMembershipsForAppInstanceUserResponse ListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsForAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<ListChannelMembershipsForAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMembershipsForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMembershipsForAppInstanceUser operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMembershipsForAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsForAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMembershipsForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMembershipsForAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  ListChannelMembershipsForAppInstanceUserResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        public virtual ListChannelMembershipsForAppInstanceUserResponse EndListChannelMembershipsForAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelMembershipsForAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelMessages

        /// <summary>
        /// List all the messages in a channel. Returns a paginated list of <code>ChannelMessages</code>.
        /// By default, sorted by creation timestamp in descending order.
        /// 
        ///  <note> 
        /// <para>
        /// Redacted messages appear in the results as empty, since they are only redacted, not
        /// deleted. Deleted messages do not appear in the results. This action always returns
        /// the latest version of an edited message.
        /// </para>
        ///  
        /// <para>
        /// Also, the x-amz-chime-bearer request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMessages service method.</param>
        /// 
        /// <returns>The response from the ListChannelMessages service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        public virtual ListChannelMessagesResponse ListChannelMessages(ListChannelMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMessagesResponseUnmarshaller.Instance;

            return Invoke<ListChannelMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMessages operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        public virtual IAsyncResult BeginListChannelMessages(ListChannelMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMessages.</param>
        /// 
        /// <returns>Returns a  ListChannelMessagesResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        public virtual ListChannelMessagesResponse EndListChannelMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelModerators

        /// <summary>
        /// Lists all the moderators for a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelModerators service method.</param>
        /// 
        /// <returns>The response from the ListChannelModerators service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        public virtual ListChannelModeratorsResponse ListChannelModerators(ListChannelModeratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelModeratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelModeratorsResponseUnmarshaller.Instance;

            return Invoke<ListChannelModeratorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelModerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelModerators operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelModerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        public virtual IAsyncResult BeginListChannelModerators(ListChannelModeratorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelModeratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelModeratorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelModerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelModerators.</param>
        /// 
        /// <returns>Returns a  ListChannelModeratorsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        public virtual ListChannelModeratorsResponse EndListChannelModerators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelModeratorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannels

        /// <summary>
        /// Lists all Channels created under a single Chime App as a paginated list. You can specify
        /// filters to narrow results.
        /// 
        ///  <p class="title"> <b>Functionality &amp; restrictions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use privacy = <code>PUBLIC</code> to retrieve all public channels in the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only an <code>AppInstanceAdmin</code> can set privacy = <code>PRIVATE</code> to list
        /// the private channels in an account.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelsAssociatedWithChannelFlow

        /// <summary>
        /// Lists all channels associated with a specified channel flow. You can associate a channel
        /// flow with multiple channels, but you can only associate a channel with one channel
        /// flow. This is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsAssociatedWithChannelFlow service method.</param>
        /// 
        /// <returns>The response from the ListChannelsAssociatedWithChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsAssociatedWithChannelFlow">REST API Reference for ListChannelsAssociatedWithChannelFlow Operation</seealso>
        public virtual ListChannelsAssociatedWithChannelFlowResponse ListChannelsAssociatedWithChannelFlow(ListChannelsAssociatedWithChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsAssociatedWithChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsAssociatedWithChannelFlowResponseUnmarshaller.Instance;

            return Invoke<ListChannelsAssociatedWithChannelFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelsAssociatedWithChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsAssociatedWithChannelFlow operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelsAssociatedWithChannelFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsAssociatedWithChannelFlow">REST API Reference for ListChannelsAssociatedWithChannelFlow Operation</seealso>
        public virtual IAsyncResult BeginListChannelsAssociatedWithChannelFlow(ListChannelsAssociatedWithChannelFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsAssociatedWithChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsAssociatedWithChannelFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelsAssociatedWithChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelsAssociatedWithChannelFlow.</param>
        /// 
        /// <returns>Returns a  ListChannelsAssociatedWithChannelFlowResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsAssociatedWithChannelFlow">REST API Reference for ListChannelsAssociatedWithChannelFlow Operation</seealso>
        public virtual ListChannelsAssociatedWithChannelFlowResponse EndListChannelsAssociatedWithChannelFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsAssociatedWithChannelFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelsModeratedByAppInstanceUser

        /// <summary>
        /// A list of the channels moderated by an <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsModeratedByAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the ListChannelsModeratedByAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        public virtual ListChannelsModeratedByAppInstanceUserResponse ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<ListChannelsModeratedByAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelsModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsModeratedByAppInstanceUser operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelsModeratedByAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelsModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelsModeratedByAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  ListChannelsModeratedByAppInstanceUserResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        public virtual ListChannelsModeratedByAppInstanceUserResponse EndListChannelsModeratedByAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsModeratedByAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubChannels

        /// <summary>
        /// Lists all the SubChannels in an elastic channel when given a channel ID. Available
        /// only to the app instance admins and channel moderators of elastic channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubChannels service method.</param>
        /// 
        /// <returns>The response from the ListSubChannels service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListSubChannels">REST API Reference for ListSubChannels Operation</seealso>
        public virtual ListSubChannelsResponse ListSubChannels(ListSubChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubChannelsResponseUnmarshaller.Instance;

            return Invoke<ListSubChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubChannels operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListSubChannels">REST API Reference for ListSubChannels Operation</seealso>
        public virtual IAsyncResult BeginListSubChannels(ListSubChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubChannels.</param>
        /// 
        /// <returns>Returns a  ListSubChannelsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListSubChannels">REST API Reference for ListSubChannels Operation</seealso>
        public virtual ListSubChannelsResponse EndListSubChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK messaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutChannelMembershipPreferences

        /// <summary>
        /// Sets the membership preferences of an <code>AppInstanceUser</code> for the specified
        /// channel. The <code>AppInstanceUser</code> must be a member of the channel. Only the
        /// <code>AppInstanceUser</code> who owns the membership can set preferences. Users in
        /// the <code>AppInstanceAdmin</code> and channel moderator roles can't set preferences
        /// for other users. Banned users can't set membership preferences for the channel from
        /// which they are banned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelMembershipPreferences service method.</param>
        /// 
        /// <returns>The response from the PutChannelMembershipPreferences service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/PutChannelMembershipPreferences">REST API Reference for PutChannelMembershipPreferences Operation</seealso>
        public virtual PutChannelMembershipPreferencesResponse PutChannelMembershipPreferences(PutChannelMembershipPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChannelMembershipPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelMembershipPreferencesResponseUnmarshaller.Instance;

            return Invoke<PutChannelMembershipPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutChannelMembershipPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutChannelMembershipPreferences operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutChannelMembershipPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/PutChannelMembershipPreferences">REST API Reference for PutChannelMembershipPreferences Operation</seealso>
        public virtual IAsyncResult BeginPutChannelMembershipPreferences(PutChannelMembershipPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChannelMembershipPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelMembershipPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutChannelMembershipPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutChannelMembershipPreferences.</param>
        /// 
        /// <returns>Returns a  PutChannelMembershipPreferencesResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/PutChannelMembershipPreferences">REST API Reference for PutChannelMembershipPreferences Operation</seealso>
        public virtual PutChannelMembershipPreferencesResponse EndPutChannelMembershipPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<PutChannelMembershipPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMessagingStreamingConfigurations

        /// <summary>
        /// Sets the data streaming configuration for an <code>AppInstance</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/streaming-export.html">Streaming
        /// messaging data</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMessagingStreamingConfigurations service method.</param>
        /// 
        /// <returns>The response from the PutMessagingStreamingConfigurations service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/PutMessagingStreamingConfigurations">REST API Reference for PutMessagingStreamingConfigurations Operation</seealso>
        public virtual PutMessagingStreamingConfigurationsResponse PutMessagingStreamingConfigurations(PutMessagingStreamingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMessagingStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMessagingStreamingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<PutMessagingStreamingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMessagingStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMessagingStreamingConfigurations operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMessagingStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/PutMessagingStreamingConfigurations">REST API Reference for PutMessagingStreamingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginPutMessagingStreamingConfigurations(PutMessagingStreamingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMessagingStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMessagingStreamingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMessagingStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMessagingStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  PutMessagingStreamingConfigurationsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/PutMessagingStreamingConfigurations">REST API Reference for PutMessagingStreamingConfigurations Operation</seealso>
        public virtual PutMessagingStreamingConfigurationsResponse EndPutMessagingStreamingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMessagingStreamingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  RedactChannelMessage

        /// <summary>
        /// Redacts message content, but not metadata. The message exists in the back end, but
        /// the action returns null content, and the state shows as redacted.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactChannelMessage service method.</param>
        /// 
        /// <returns>The response from the RedactChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        public virtual RedactChannelMessageResponse RedactChannelMessage(RedactChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactChannelMessageResponseUnmarshaller.Instance;

            return Invoke<RedactChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RedactChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RedactChannelMessage operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRedactChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginRedactChannelMessage(RedactChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RedactChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRedactChannelMessage.</param>
        /// 
        /// <returns>Returns a  RedactChannelMessageResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        public virtual RedactChannelMessageResponse EndRedactChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<RedactChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchChannels

        /// <summary>
        /// Allows <code>ChimeBearer</code> to search channels by channel members. AppInstanceUsers
        /// can search across the channels that they belong to. AppInstanceAdmins can search across
        /// all channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchChannels service method.</param>
        /// 
        /// <returns>The response from the SearchChannels service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/SearchChannels">REST API Reference for SearchChannels Operation</seealso>
        public virtual SearchChannelsResponse SearchChannels(SearchChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchChannelsResponseUnmarshaller.Instance;

            return Invoke<SearchChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchChannels operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/SearchChannels">REST API Reference for SearchChannels Operation</seealso>
        public virtual IAsyncResult BeginSearchChannels(SearchChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchChannels.</param>
        /// 
        /// <returns>Returns a  SearchChannelsResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/SearchChannels">REST API Reference for SearchChannels Operation</seealso>
        public virtual SearchChannelsResponse EndSearchChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  SendChannelMessage

        /// <summary>
        /// Sends a message to a particular channel that the member is a part of.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  
        /// <para>
        /// Also, <code>STANDARD</code> messages can contain 4KB of data and the 1KB of metadata.
        /// <code>CONTROL</code> messages can contain 30 bytes of data and no metadata.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendChannelMessage service method.</param>
        /// 
        /// <returns>The response from the SendChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        public virtual SendChannelMessageResponse SendChannelMessage(SendChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendChannelMessageResponseUnmarshaller.Instance;

            return Invoke<SendChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendChannelMessage operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginSendChannelMessage(SendChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendChannelMessage.</param>
        /// 
        /// <returns>Returns a  SendChannelMessageResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        public virtual SendChannelMessageResponse EndSendChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<SendChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK messaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the specified tags from the specified Amazon Chime SDK messaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Update a channel's attributes.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannelFlow

        /// <summary>
        /// Updates channel flow attributes. This is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelFlow">REST API Reference for UpdateChannelFlow Operation</seealso>
        public virtual UpdateChannelFlowResponse UpdateChannelFlow(UpdateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelFlow operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelFlow">REST API Reference for UpdateChannelFlow Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannelFlow(UpdateChannelFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelFlow.</param>
        /// 
        /// <returns>Returns a  UpdateChannelFlowResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelFlow">REST API Reference for UpdateChannelFlow Operation</seealso>
        public virtual UpdateChannelFlowResponse EndUpdateChannelFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannelMessage

        /// <summary>
        /// Updates the content of a message.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelMessage service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        public virtual UpdateChannelMessageResponse UpdateChannelMessage(UpdateChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelMessageResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelMessage operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannelMessage(UpdateChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelMessage.</param>
        /// 
        /// <returns>Returns a  UpdateChannelMessageResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        public virtual UpdateChannelMessageResponse EndUpdateChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannelReadMarker

        /// <summary>
        /// The details of the time when a user last read messages in a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelReadMarker service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelReadMarker service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        public virtual UpdateChannelReadMarkerResponse UpdateChannelReadMarker(UpdateChannelReadMarkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelReadMarkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelReadMarkerResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelReadMarkerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelReadMarker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelReadMarker operation on AmazonChimeSDKMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelReadMarker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannelReadMarker(UpdateChannelReadMarkerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelReadMarkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelReadMarkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelReadMarker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelReadMarker.</param>
        /// 
        /// <returns>Returns a  UpdateChannelReadMarkerResult from ChimeSDKMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        public virtual UpdateChannelReadMarkerResponse EndUpdateChannelReadMarker(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelReadMarkerResponse>(asyncResult);
        }

        #endregion
        
    }
}