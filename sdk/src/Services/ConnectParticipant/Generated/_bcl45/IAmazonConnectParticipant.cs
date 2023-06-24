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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectParticipant.Model;

namespace Amazon.ConnectParticipant
{
    /// <summary>
    /// Interface for accessing ConnectParticipant
    ///
    /// Amazon Connect is an easy-to-use omnichannel cloud contact center service that enables
    /// companies of any size to deliver superior customer service at a lower cost. Amazon
    /// Connect communications capabilities make it easy for companies to deliver personalized
    /// interactions across communication channels, including chat. 
    /// 
    ///  
    /// <para>
    /// Use the Amazon Connect Participant Service to manage participants (for example, agents,
    /// customers, and managers listening in), and to send messages and events within a chat
    /// contact. The APIs in the service enable the following: sending chat messages, attachment
    /// sharing, managing a participant's connection state and message events, and retrieving
    /// chat transcripts.
    /// </para>
    /// </summary>
    public partial interface IAmazonConnectParticipant : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectParticipantPaginatorFactory Paginators { get; }

        
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
        CompleteAttachmentUploadResponse CompleteAttachmentUpload(CompleteAttachmentUploadRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CompleteAttachmentUploadResponse> CompleteAttachmentUploadAsync(CompleteAttachmentUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateParticipantConnectionResponse CreateParticipantConnection(CreateParticipantConnectionRequest request);



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
        Task<CreateParticipantConnectionResponse> CreateParticipantConnectionAsync(CreateParticipantConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisconnectParticipantResponse DisconnectParticipant(DisconnectParticipantRequest request);



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
        Task<DisconnectParticipantResponse> DisconnectParticipantAsync(DisconnectParticipantRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetAttachmentResponse GetAttachment(GetAttachmentRequest request);



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
        Task<GetAttachmentResponse> GetAttachmentAsync(GetAttachmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetTranscriptResponse GetTranscript(GetTranscriptRequest request);



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
        Task<GetTranscriptResponse> GetTranscriptAsync(GetTranscriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SendEventResponse SendEvent(SendEventRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SendEventResponse> SendEventAsync(SendEventRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SendMessageResponse SendMessage(SendMessageRequest request);



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
        Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartAttachmentUploadResponse StartAttachmentUpload(StartAttachmentUploadRequest request);



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
        Task<StartAttachmentUploadResponse> StartAttachmentUploadAsync(StartAttachmentUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}