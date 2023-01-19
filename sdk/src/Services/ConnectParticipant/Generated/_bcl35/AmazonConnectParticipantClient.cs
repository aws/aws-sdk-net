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
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectParticipant.Model;
using Amazon.ConnectParticipant.Model.Internal.MarshallTransformations;
using Amazon.ConnectParticipant.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ConnectParticipant
{
    /// <summary>
    /// Implementation for accessing ConnectParticipant
    ///
    /// Amazon Connect is a cloud-based contact center solution that makes it easy to set
    /// up and manage a customer contact center. Amazon Connect enables customer contacts
    /// through voice or chat. Use the Amazon Connect Participant Service to manage chat participants,
    /// such as agents and customers.
    /// </summary>
    public partial class AmazonConnectParticipantClient : AmazonServiceClient, IAmazonConnectParticipant
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectParticipantMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectParticipantConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectParticipantConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectParticipantEndpointResolver());
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


        #region  CompleteAttachmentUpload

        /// <summary>
        /// Allows you to confirm that the attachment has been uploaded using the pre-signed URL
        /// provided in StartAttachmentUpload API. 
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
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
        /// An attachment with that identifier is already being uploaded.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteAttachmentUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteAttachmentUploadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteAttachmentUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteAttachmentUpload operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteAttachmentUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CompleteAttachmentUpload">REST API Reference for CompleteAttachmentUpload Operation</seealso>
        public virtual IAsyncResult BeginCompleteAttachmentUpload(CompleteAttachmentUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteAttachmentUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteAttachmentUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteAttachmentUpload.</param>
        /// 
        /// <returns>Returns a  CompleteAttachmentUploadResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CompleteAttachmentUpload">REST API Reference for CompleteAttachmentUpload Operation</seealso>
        public virtual CompleteAttachmentUploadResponse EndCompleteAttachmentUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<CompleteAttachmentUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateParticipantConnection

        /// <summary>
        /// Creates the participant's connection. 
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ParticipantToken</code> is used for invoking this API instead of <code>ConnectionToken</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The participant token is valid for the lifetime of the participant – until they are
        /// part of a contact.
        /// </para>
        ///  
        /// <para>
        /// The response URL for <code>WEBSOCKET</code> Type has a connect expiry timeout of 100s.
        /// Clients must manually connect to the returned websocket URL and subscribe to the desired
        /// topic. 
        /// </para>
        ///  
        /// <para>
        /// For chat, you need to publish the following on the established websocket connection:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"topic":"aws/subscribe","content":{"topics":["aws/chat"]}}</code> 
        /// </para>
        ///  
        /// <para>
        /// Upon websocket URL expiry, as specified in the response ConnectionExpiry parameter,
        /// clients need to call this API again to obtain a new websocket URL and perform the
        /// same steps as before.
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
        ///  <b>Feature specifications</b>: For information about feature specifications, such
        /// as the allowed number of open websocket connections per participant, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#feature-limits">Feature
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateParticipantConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateParticipantConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantConnection operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateParticipantConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CreateParticipantConnection">REST API Reference for CreateParticipantConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateParticipantConnection(CreateParticipantConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateParticipantConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateParticipantConnection.</param>
        /// 
        /// <returns>Returns a  CreateParticipantConnectionResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CreateParticipantConnection">REST API Reference for CreateParticipantConnection Operation</seealso>
        public virtual CreateParticipantConnectionResponse EndCreateParticipantConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateParticipantConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DisconnectParticipant

        /// <summary>
        /// Disconnects a participant. 
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return Invoke<DisconnectParticipantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectParticipant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectParticipant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual IAsyncResult BeginDisconnectParticipant(DisconnectParticipantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectParticipant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectParticipant.</param>
        /// 
        /// <returns>Returns a  DisconnectParticipantResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual DisconnectParticipantResponse EndDisconnectParticipant(IAsyncResult asyncResult)
        {
            return EndInvoke<DisconnectParticipantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAttachment

        /// <summary>
        /// Provides a pre-signed URL for download of a completed attachment. This is an asynchronous
        /// API for use with active contacts.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
        /// </para>
        ///  </note> 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttachment operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetAttachment">REST API Reference for GetAttachment Operation</seealso>
        public virtual IAsyncResult BeginGetAttachment(GetAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttachment.</param>
        /// 
        /// <returns>Returns a  GetAttachmentResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetAttachment">REST API Reference for GetAttachment Operation</seealso>
        public virtual GetAttachmentResponse EndGetAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTranscript

        /// <summary>
        /// Retrieves a transcript of the session, including details about any attachments. For
        /// information about accessing past chat contact transcripts for a persistent chat, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
        /// persistent chat</a>. 
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptResponseUnmarshaller.Instance;

            return Invoke<GetTranscriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTranscript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTranscript operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTranscript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetTranscript">REST API Reference for GetTranscript Operation</seealso>
        public virtual IAsyncResult BeginGetTranscript(GetTranscriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTranscriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTranscriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTranscript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTranscript.</param>
        /// 
        /// <returns>Returns a  GetTranscriptResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetTranscript">REST API Reference for GetTranscript Operation</seealso>
        public virtual GetTranscriptResponse EndGetTranscript(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTranscriptResponse>(asyncResult);
        }

        #endregion
        
        #region  SendEvent

        /// <summary>
        /// Sends an event. 
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return Invoke<SendEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEvent operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEvent.</param>
        /// 
        /// <returns>Returns a  SendEventResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendEvent">REST API Reference for SendEvent Operation</seealso>
        public virtual SendEventResponse EndSendEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<SendEventResponse>(asyncResult);
        }

        #endregion
        
        #region  SendMessage

        /// <summary>
        /// Sends a message.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessage operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual IAsyncResult BeginSendMessage(SendMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessage.</param>
        /// 
        /// <returns>Returns a  SendMessageResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual SendMessageResponse EndSendMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<SendMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAttachmentUpload

        /// <summary>
        /// Provides a pre-signed Amazon S3 URL in response for uploading the file directly to
        /// S3.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAttachmentUploadResponseUnmarshaller.Instance;

            return Invoke<StartAttachmentUploadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAttachmentUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAttachmentUpload operation on AmazonConnectParticipantClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAttachmentUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/StartAttachmentUpload">REST API Reference for StartAttachmentUpload Operation</seealso>
        public virtual IAsyncResult BeginStartAttachmentUpload(StartAttachmentUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAttachmentUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAttachmentUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAttachmentUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAttachmentUpload.</param>
        /// 
        /// <returns>Returns a  StartAttachmentUploadResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/StartAttachmentUpload">REST API Reference for StartAttachmentUpload Operation</seealso>
        public virtual StartAttachmentUploadResponse EndStartAttachmentUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAttachmentUploadResponse>(asyncResult);
        }

        #endregion
        
    }
}