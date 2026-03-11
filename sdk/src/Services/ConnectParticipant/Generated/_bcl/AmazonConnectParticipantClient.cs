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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectParticipant.Model;
using Amazon.ConnectParticipant.Model.Internal.MarshallTransformations;
using Amazon.ConnectParticipant.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ConnectParticipant
{
    /// <summary>
    /// <para>Implementation for accessing ConnectParticipant</para>
    ///
    /// <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_Connect_Participant_Service.html">Participant
    /// Service actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_Connect_Participant_Service.html">Participant
    /// Service data types</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Connect is an easy-to-use omnichannel cloud contact center service that enables
    /// companies of any size to deliver superior customer service at a lower cost. Amazon
    /// Connect communications capabilities make it easy for companies to deliver personalized
    /// interactions across communication channels, including chat. 
    /// </para>
    ///  
    /// <para>
    /// Use the Amazon Connect Participant Service to manage participants (for example, agents,
    /// customers, and managers listening in), and to send messages and events within a chat
    /// contact. The APIs in the service enable the following: sending chat messages, attachment
    /// sharing, managing a participant's connection state and message events, and retrieving
    /// chat transcripts.
    /// </para>
    /// </summary>
    public partial class AmazonConnectParticipantClient : AmazonServiceClient, IAmazonConnectParticipant
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectParticipantMetadata();
        private IConnectParticipantPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IConnectParticipantPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ConnectParticipantPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with the credentials loaded from the application's
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
        public AmazonConnectParticipantClient()
            : base(new AmazonConnectParticipantConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with the credentials loaded from the application's
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
        public AmazonConnectParticipantClient(RegionEndpoint region)
            : base(new AmazonConnectParticipantConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(AmazonConnectParticipantConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectParticipantClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectParticipantConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectParticipantClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectParticipantConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Credentials and an
        /// AmazonConnectParticipantClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(AWSCredentials credentials, AmazonConnectParticipantConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectParticipantConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectParticipantConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectParticipantClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectParticipantConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectParticipantConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectParticipantConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectParticipantClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectParticipantClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectParticipantClient Configuration Object</param>
        public AmazonConnectParticipantClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectParticipantConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectParticipantEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectParticipantAuthSchemeHandler());
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


        #region  CancelParticipantAuthentication


        /// <summary>
        /// Cancels the authentication session. The opted out branch of the Authenticate Customer
        /// flow block will be taken.
        /// 
        ///  <note> 
        /// <para>
        /// The current supported channel is chat. This API is not supported for Apple Messages
        /// for Business, WhatsApp, or SMS chats.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelParticipantAuthentication service method.</param>
        /// 
        /// <returns>The response from the CancelParticipantAuthentication service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CancelParticipantAuthentication">REST API Reference for CancelParticipantAuthentication Operation</seealso>
        public virtual CancelParticipantAuthenticationResponse CancelParticipantAuthentication(CancelParticipantAuthenticationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelParticipantAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelParticipantAuthenticationResponseUnmarshaller.Instance;

            return Invoke<CancelParticipantAuthenticationResponse>(request, options);
        }


        /// <summary>
        /// Cancels the authentication session. The opted out branch of the Authenticate Customer
        /// flow block will be taken.
        /// 
        ///  <note> 
        /// <para>
        /// The current supported channel is chat. This API is not supported for Apple Messages
        /// for Business, WhatsApp, or SMS chats.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelParticipantAuthentication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelParticipantAuthentication service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CancelParticipantAuthentication">REST API Reference for CancelParticipantAuthentication Operation</seealso>
        public virtual Task<CancelParticipantAuthenticationResponse> CancelParticipantAuthenticationAsync(CancelParticipantAuthenticationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelParticipantAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelParticipantAuthenticationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelParticipantAuthenticationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteAttachmentUpload


        /// <summary>
        /// Allows you to confirm that the attachment has been uploaded using the pre-signed URL
        /// provided in StartAttachmentUpload API. A conflict exception is thrown when an attachment
        /// with that identifier is already being uploaded.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteAttachmentUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteAttachmentUpload service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ConflictException">
        /// The requested operation conflicts with the current state of a service resource associated
        /// with the request.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ServiceQuotaExceededException">
        /// The number of attachments per contact exceeds the quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CompleteAttachmentUpload">REST API Reference for CompleteAttachmentUpload Operation</seealso>
        public virtual CompleteAttachmentUploadResponse CompleteAttachmentUpload(CompleteAttachmentUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteAttachmentUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteAttachmentUploadResponse>(request, options);
        }


        /// <summary>
        /// Allows you to confirm that the attachment has been uploaded using the pre-signed URL
        /// provided in StartAttachmentUpload API. A conflict exception is thrown when an attachment
        /// with that identifier is already being uploaded.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteAttachmentUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteAttachmentUpload service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ConflictException">
        /// The requested operation conflicts with the current state of a service resource associated
        /// with the request.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ServiceQuotaExceededException">
        /// The number of attachments per contact exceeds the quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CompleteAttachmentUpload">REST API Reference for CompleteAttachmentUpload Operation</seealso>
        public virtual Task<CompleteAttachmentUploadResponse> CompleteAttachmentUploadAsync(CompleteAttachmentUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteAttachmentUploadResponseUnmarshaller.Instance;
            
            return InvokeAsync<CompleteAttachmentUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateParticipantConnection


        /// <summary>
        /// Creates the participant's connection. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  
        /// <para>
        /// For WebRTC security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-webrtc-security">Amazon
        /// Connect WebRTC security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ParticipantToken</c> is used for invoking this API instead of <c>ConnectionToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The participant token is valid for the lifetime of the participant – until they are
        /// part of a contact. For WebRTC participants, if they leave or are disconnected for
        /// 60 seconds, a new participant needs to be created using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateParticipant.html">CreateParticipant</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        ///  <b>For <c>WEBSOCKET</c> Type</b>: 
        /// </para>
        ///  
        /// <para>
        /// The response URL for has a connect expiry timeout of 100s. Clients must manually connect
        /// to the returned websocket URL and subscribe to the desired topic. 
        /// </para>
        ///  
        /// <para>
        /// For chat, you need to publish the following on the established websocket connection:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"topic":"aws/subscribe","content":{"topics":["aws/chat"]}}</c> 
        /// </para>
        ///  
        /// <para>
        /// Upon websocket URL expiry, as specified in the response ConnectionExpiry parameter,
        /// clients need to call this API again to obtain a new websocket URL and perform the
        /// same steps as before.
        /// </para>
        ///  
        /// <para>
        /// The expiry time for the connection token is different than the <c>ChatDurationInMinutes</c>.
        /// Expiry time for the connection token is 1 day.
        /// </para>
        ///  
        /// <para>
        ///  <b>For <c>WEBRTC_CONNECTION</c> Type</b>: 
        /// </para>
        ///  
        /// <para>
        /// The response includes connection data required for the client application to join
        /// the call using the Amazon Chime SDK client libraries. The WebRTCConnection response
        /// contains Meeting and Attendee information needed to establish the media connection.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The attendee join token in WebRTCConnection response is valid for the lifetime of
        /// the participant in the call. If a participant leaves or is disconnected for 60 seconds,
        /// their participant credentials will no longer be valid, and a new participant will
        /// need to be created to rejoin the call. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Message streaming support</b>: This API can also be used together with the <a
        /// href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartContactStreaming.html">StartContactStreaming</a>
        /// API to create a participant connection for chat contacts that are not using a websocket.
        /// For more information about message streaming, <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-message-streaming.html">Enable
        /// real-time chat message streaming</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Multi-user web, in-app, video calling support</b>: 
        /// </para>
        ///  
        /// <para>
        /// For WebRTC calls, this API is used in conjunction with the CreateParticipant API to
        /// enable multi-party calling. The StartWebRTCContact API creates the initial contact
        /// and routes it to an agent, while CreateParticipant adds additional participants to
        /// the ongoing call. For more information about multi-party WebRTC calls, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-multiuser-inapp.html">Enable
        /// multi-user web, in-app, and video calling</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Feature specifications</b>: For information about feature specifications, such
        /// as the allowed number of open websocket connections per participant or maximum number
        /// of WebRTC participants, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#feature-limits">Feature
        /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantConnection service method.</param>
        /// 
        /// <returns>The response from the CreateParticipantConnection service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CreateParticipantConnection">REST API Reference for CreateParticipantConnection Operation</seealso>
        public virtual CreateParticipantConnectionResponse CreateParticipantConnection(CreateParticipantConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateParticipantConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateParticipantConnectionResponse>(request, options);
        }


        /// <summary>
        /// Creates the participant's connection. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  
        /// <para>
        /// For WebRTC security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-webrtc-security">Amazon
        /// Connect WebRTC security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ParticipantToken</c> is used for invoking this API instead of <c>ConnectionToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The participant token is valid for the lifetime of the participant – until they are
        /// part of a contact. For WebRTC participants, if they leave or are disconnected for
        /// 60 seconds, a new participant needs to be created using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateParticipant.html">CreateParticipant</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        ///  <b>For <c>WEBSOCKET</c> Type</b>: 
        /// </para>
        ///  
        /// <para>
        /// The response URL for has a connect expiry timeout of 100s. Clients must manually connect
        /// to the returned websocket URL and subscribe to the desired topic. 
        /// </para>
        ///  
        /// <para>
        /// For chat, you need to publish the following on the established websocket connection:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"topic":"aws/subscribe","content":{"topics":["aws/chat"]}}</c> 
        /// </para>
        ///  
        /// <para>
        /// Upon websocket URL expiry, as specified in the response ConnectionExpiry parameter,
        /// clients need to call this API again to obtain a new websocket URL and perform the
        /// same steps as before.
        /// </para>
        ///  
        /// <para>
        /// The expiry time for the connection token is different than the <c>ChatDurationInMinutes</c>.
        /// Expiry time for the connection token is 1 day.
        /// </para>
        ///  
        /// <para>
        ///  <b>For <c>WEBRTC_CONNECTION</c> Type</b>: 
        /// </para>
        ///  
        /// <para>
        /// The response includes connection data required for the client application to join
        /// the call using the Amazon Chime SDK client libraries. The WebRTCConnection response
        /// contains Meeting and Attendee information needed to establish the media connection.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The attendee join token in WebRTCConnection response is valid for the lifetime of
        /// the participant in the call. If a participant leaves or is disconnected for 60 seconds,
        /// their participant credentials will no longer be valid, and a new participant will
        /// need to be created to rejoin the call. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Message streaming support</b>: This API can also be used together with the <a
        /// href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartContactStreaming.html">StartContactStreaming</a>
        /// API to create a participant connection for chat contacts that are not using a websocket.
        /// For more information about message streaming, <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-message-streaming.html">Enable
        /// real-time chat message streaming</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Multi-user web, in-app, video calling support</b>: 
        /// </para>
        ///  
        /// <para>
        /// For WebRTC calls, this API is used in conjunction with the CreateParticipant API to
        /// enable multi-party calling. The StartWebRTCContact API creates the initial contact
        /// and routes it to an agent, while CreateParticipant adds additional participants to
        /// the ongoing call. For more information about multi-party WebRTC calls, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-multiuser-inapp.html">Enable
        /// multi-user web, in-app, and video calling</a> in the <i>Amazon Connect Administrator
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Feature specifications</b>: For information about feature specifications, such
        /// as the allowed number of open websocket connections per participant or maximum number
        /// of WebRTC participants, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#feature-limits">Feature
        /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateParticipantConnection service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CreateParticipantConnection">REST API Reference for CreateParticipantConnection Operation</seealso>
        public virtual Task<CreateParticipantConnectionResponse> CreateParticipantConnectionAsync(CreateParticipantConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateParticipantConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateParticipantConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeView


        /// <summary>
        /// Retrieves the view for the specified view token.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeView service method.</param>
        /// 
        /// <returns>The response from the DescribeView service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DescribeView">REST API Reference for DescribeView Operation</seealso>
        public virtual DescribeViewResponse DescribeView(DescribeViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeViewResponseUnmarshaller.Instance;

            return Invoke<DescribeViewResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the view for the specified view token.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeView service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DescribeView">REST API Reference for DescribeView Operation</seealso>
        public virtual Task<DescribeViewResponse> DescribeViewAsync(DescribeViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeViewResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectParticipant


        /// <summary>
        /// Disconnects a participant. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant service method.</param>
        /// 
        /// <returns>The response from the DisconnectParticipant service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual DisconnectParticipantResponse DisconnectParticipant(DisconnectParticipantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return Invoke<DisconnectParticipantResponse>(request, options);
        }


        /// <summary>
        /// Disconnects a participant. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectParticipant service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual Task<DisconnectParticipantResponse> DisconnectParticipantAsync(DisconnectParticipantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisconnectParticipantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAttachment


        /// <summary>
        /// Provides a pre-signed URL for download of a completed attachment. This is an asynchronous
        /// API for use with active contacts.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// The participant role <c>CUSTOM_BOT</c> is not permitted to access attachments customers
        /// may upload. An <c>AccessDeniedException</c> can indicate that the participant may
        /// be a CUSTOM_BOT, and it doesn't have access to attachments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttachment service method.</param>
        /// 
        /// <returns>The response from the GetAttachment service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetAttachment">REST API Reference for GetAttachment Operation</seealso>
        public virtual GetAttachmentResponse GetAttachment(GetAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetAttachmentResponse>(request, options);
        }


        /// <summary>
        /// Provides a pre-signed URL for download of a completed attachment. This is an asynchronous
        /// API for use with active contacts.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// The participant role <c>CUSTOM_BOT</c> is not permitted to access attachments customers
        /// may upload. An <c>AccessDeniedException</c> can indicate that the participant may
        /// be a CUSTOM_BOT, and it doesn't have access to attachments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAttachment service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetAttachment">REST API Reference for GetAttachment Operation</seealso>
        public virtual Task<GetAttachmentResponse> GetAttachmentAsync(GetAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttachmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthenticationUrl


        /// <summary>
        /// Retrieves the AuthenticationUrl for the current authentication session for the AuthenticateCustomer
        /// flow block. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API can only be called within one minute of receiving the authenticationInitiated
        /// event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The current supported channel is chat. This API is not supported for Apple Messages
        /// for Business, WhatsApp, or SMS chats.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthenticationUrl service method.</param>
        /// 
        /// <returns>The response from the GetAuthenticationUrl service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetAuthenticationUrl">REST API Reference for GetAuthenticationUrl Operation</seealso>
        public virtual GetAuthenticationUrlResponse GetAuthenticationUrl(GetAuthenticationUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthenticationUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthenticationUrlResponseUnmarshaller.Instance;

            return Invoke<GetAuthenticationUrlResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the AuthenticationUrl for the current authentication session for the AuthenticateCustomer
        /// flow block. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API can only be called within one minute of receiving the authenticationInitiated
        /// event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The current supported channel is chat. This API is not supported for Apple Messages
        /// for Business, WhatsApp, or SMS chats.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthenticationUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAuthenticationUrl service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetAuthenticationUrl">REST API Reference for GetAuthenticationUrl Operation</seealso>
        public virtual Task<GetAuthenticationUrlResponse> GetAuthenticationUrlAsync(GetAuthenticationUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthenticationUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthenticationUrlResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAuthenticationUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTranscript


        /// <summary>
        /// Retrieves a transcript of the session, including details about any attachments. For
        /// information about accessing past chat contact transcripts for a persistent chat, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
        /// persistent chat</a>. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you have a process that consumes events in the transcript of an chat that has ended,
        /// note that chat transcripts contain the following event content types if the event
        /// has occurred during the chat session:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.participant.invited</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.participant.joined</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.participant.left</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.chat.ended</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.transfer.succeeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.transfer.failed</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscript service method.</param>
        /// 
        /// <returns>The response from the GetTranscript service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetTranscript">REST API Reference for GetTranscript Operation</seealso>
        public virtual GetTranscriptResponse GetTranscript(GetTranscriptRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTranscriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a transcript of the session, including details about any attachments. For
        /// information about accessing past chat contact transcripts for a persistent chat, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
        /// persistent chat</a>. 
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you have a process that consumes events in the transcript of an chat that has ended,
        /// note that chat transcripts contain the following event content types if the event
        /// has occurred during the chat session:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.participant.invited</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.participant.joined</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.participant.left</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.chat.ended</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.transfer.succeeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.event.transfer.failed</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTranscript service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetTranscript">REST API Reference for GetTranscript Operation</seealso>
        public virtual Task<GetTranscriptResponse> GetTranscriptAsync(GetTranscriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTranscriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTranscriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendEvent


        /// <summary>
        /// <note> 
        /// <para>
        /// The <c>application/vnd.amazonaws.connect.event.connection.acknowledged</c> ContentType
        /// is no longer maintained since December 31, 2024. This event has been migrated to the
        /// <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// API using the <c>ConnectParticipant</c> field.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sends an event. Message receipts are not supported when there are more than two active
        /// participants in the chat. Using the SendEvent API for message receipts when a supervisor
        /// is barged-in will result in a conflict exception.
        /// </para>
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ConflictException">
        /// The requested operation conflicts with the current state of a service resource associated
        /// with the request.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual SendEventResponse SendEvent(SendEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return Invoke<SendEventResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// The <c>application/vnd.amazonaws.connect.event.connection.acknowledged</c> ContentType
        /// is no longer maintained since December 31, 2024. This event has been migrated to the
        /// <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
        /// API using the <c>ConnectParticipant</c> field.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sends an event. Message receipts are not supported when there are more than two active
        /// participants in the chat. Using the SendEvent API for message receipts when a supervisor
        /// is barged-in will result in a conflict exception.
        /// </para>
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ConflictException">
        /// The requested operation conflicts with the current state of a service resource associated
        /// with the request.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual Task<SendEventResponse> SendEventAsync(SendEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendMessage


        /// <summary>
        /// Sends a message.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageResponse>(request, options);
        }


        /// <summary>
        /// Sends a message.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAttachmentUpload


        /// <summary>
        /// Provides a pre-signed Amazon S3 URL in response for uploading the file directly to
        /// S3.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAttachmentUpload service method.</param>
        /// 
        /// <returns>The response from the StartAttachmentUpload service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ServiceQuotaExceededException">
        /// The number of attachments per contact exceeds the quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/StartAttachmentUpload">REST API Reference for StartAttachmentUpload Operation</seealso>
        public virtual StartAttachmentUploadResponse StartAttachmentUpload(StartAttachmentUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAttachmentUploadResponseUnmarshaller.Instance;

            return Invoke<StartAttachmentUploadResponse>(request, options);
        }


        /// <summary>
        /// Provides a pre-signed Amazon S3 URL in response for uploading the file directly to
        /// S3.
        /// 
        ///  
        /// <para>
        /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
        /// Connect Chat security best practices</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ConnectionToken</c> is used for invoking this API instead of <c>ParticipantToken</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 authentication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAttachmentUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAttachmentUpload service method, as returned by ConnectParticipant.</returns>
        /// <exception cref="Amazon.ConnectParticipant.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon Connect service.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ServiceQuotaExceededException">
        /// The number of attachments per contact exceeds the quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectParticipant.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Amazon Connect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/StartAttachmentUpload">REST API Reference for StartAttachmentUpload Operation</seealso>
        public virtual Task<StartAttachmentUploadResponse> StartAttachmentUploadAsync(StartAttachmentUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAttachmentUploadResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartAttachmentUploadResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}