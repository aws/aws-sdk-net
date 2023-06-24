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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Ivschat.Model;

namespace Amazon.Ivschat
{
    /// <summary>
    /// Interface for accessing Ivschat
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon IVS Chat control-plane API enables you to create and manage Amazon IVS
    /// Chat resources. You also need to integrate with the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/chat-messaging-api.html">
    /// Amazon IVS Chat Messaging API</a>, to enable users to interact with chat rooms in
    /// real time.
    /// </para>
    ///  
    /// <para>
    /// The API is an AWS regional service. For a list of supported regions and Amazon IVS
    /// Chat HTTPS service endpoints, see the Amazon IVS Chat information on the <a href="https://docs.aws.amazon.com/general/latest/gr/ivs.html">Amazon
    /// IVS page</a> in the <i>AWS General Reference</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Notes on terminology:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You create service applications using the Amazon IVS Chat API. We refer to these as
    /// <i>applications</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You create front-end client applications (browser and Android/iOS apps) using the
    /// Amazon IVS Chat Messaging API. We refer to these as <i>clients</i>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resources are part of Amazon IVS Chat:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>LoggingConfiguration</b> — A configuration that allows customers to store and
    /// record sent messages in a chat room. See the Logging Configuration endpoints for more
    /// information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Room</b> — The central Amazon IVS Chat resource through which clients connect
    /// to and exchange chat messages. See the Room endpoints for more information.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an AWS resource. A tag comprises
    /// a <i>key</i> and a <i>value</i>, both set by you. For example, you might set a tag
    /// as <code>topic:nature</code> to label a particular video category. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// AWS Resources</a> for more information, including restrictions that apply to tags
    /// and "Tag naming limits and requirements"; Amazon IVS Chat has no service-specific
    /// constraints beyond what is documented there.
    /// </para>
    ///  
    /// <para>
    /// Tags can help you identify and organize your AWS resources. For example, you can use
    /// the same tag for different resources to indicate that they are related. You can also
    /// use tags to manage access (see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Access
    /// Tags</a>).
    /// </para>
    ///  
    /// <para>
    /// The Amazon IVS Chat API has these tag-related endpoints: <a>TagResource</a>, <a>UntagResource</a>,
    /// and <a>ListTagsForResource</a>. The following resource supports tagging: Room.
    /// </para>
    ///  
    /// <para>
    /// At most 50 tags can be applied to a resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Access Security</b> 
    /// </para>
    ///  
    /// <para>
    /// Your Amazon IVS Chat applications (service applications and clients) must be authenticated
    /// and authorized to access Amazon IVS Chat resources. Note the differences between these
    /// concepts:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Authentication</i> is about verifying identity. Requests to the Amazon IVS Chat
    /// API must be signed to verify your identity.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Authorization</i> is about granting permissions. Your IAM roles need to have permissions
    /// for Amazon IVS Chat API requests.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users (viewers) connect to a room using secure access tokens that you create using
    /// the <a>CreateChatToken</a> endpoint through the AWS SDK. You call CreateChatToken
    /// for every user’s chat session, passing identity and authorization information about
    /// the user.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// HTTP API requests must be signed with an AWS SigV4 signature using your AWS security
    /// credentials. The AWS Command Line Interface (CLI) and the AWS SDKs take care of signing
    /// the underlying API calls for you. However, if your application calls the Amazon IVS
    /// Chat HTTP API directly, it’s your responsibility to sign the requests.
    /// </para>
    ///  
    /// <para>
    /// You generate a signature using valid AWS credentials for an IAM role that has permission
    /// to perform the requested action. For example, DeleteMessage requests must be made
    /// using an IAM role that has the <code>ivschat:DeleteMessage</code> permission.
    /// </para>
    ///  
    /// <para>
    /// For more information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Authentication and generating signatures — See <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon Web Services
    /// General Reference</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Managing Amazon IVS permissions — See <a href="https://docs.aws.amazon.com/ivs/latest/userguide/security-iam.html">Identity
    /// and Access Management</a> on the Security page of the <i>Amazon IVS User Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon Resource Names (ARNs)</b> 
    /// </para>
    ///  
    /// <para>
    /// ARNs uniquely identify AWS resources. An ARN is required when you need to specify
    /// a resource unambiguously across all of AWS, such as in IAM policies and API calls.
    /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
    /// Resource Names</a> in the <i>AWS General Reference</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Messaging Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteMessage</a> — Sends an event to a specific room which directs clients to
    /// delete a specific message; that is, unrender it from view and delete it from the client’s
    /// chat history. This event’s <code>EventName</code> is <code>aws:DELETE_MESSAGE</code>.
    /// This replicates the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-deletemessage-publish.html">
    /// DeleteMessage</a> WebSocket operation in the Amazon IVS Chat Messaging API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisconnectUser</a> — Disconnects all connections using a specified user ID from
    /// a room. This replicates the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-disconnectuser-publish.html">
    /// DisconnectUser</a> WebSocket operation in the Amazon IVS Chat Messaging API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>SendEvent</a> — Sends an event to a room. Use this within your application’s business
    /// logic to send events to clients of a room; e.g., to notify clients to change the way
    /// the chat UI is rendered.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Chat Token Endpoint</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateChatToken</a> — Creates an encrypted token that is used by a chat participant
    /// to establish an individual WebSocket chat connection to a room. When the token is
    /// used to connect to chat, the connection is valid for the session duration specified
    /// in the request. The token becomes invalid at the token-expiration timestamp included
    /// in the response.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Room Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateRoom</a> — Creates a room that allows clients to connect and pass messages.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteRoom</a> — Deletes the specified room.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetRoom</a> — Gets the specified room.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRooms</a> — Gets summary information about all your rooms in the AWS region
    /// where the API request is processed. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRoom</a> — Updates a room’s configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Logging Configuration Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateLoggingConfiguration</a> — Creates a logging configuration that allows clients
    /// to store and record sent messages.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteLoggingConfiguration</a> — Deletes the specified logging configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetLoggingConfiguration</a> — Gets the specified logging configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListLoggingConfigurations</a> — Gets summary information about all your logging
    /// configurations in the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateLoggingConfiguration</a> — Updates a specified logging configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tags Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> — Gets information about AWS tags for the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a> — Adds or updates tags for the AWS resource with the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> — Removes tags from the resource with the specified ARN.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All the above are HTTP operations. There is a separate <i>messaging</i> API for managing
    /// Chat resources; see the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/chat-messaging-api.html">
    /// Amazon IVS Chat Messaging API Reference</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIvschat : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIvschatPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateChatToken


        /// <summary>
        /// Creates an encrypted token that is used by a chat participant to establish an individual
        /// WebSocket chat connection to a room. When the token is used to connect to chat, the
        /// connection is valid for the session duration specified in the request. The token becomes
        /// invalid at the token-expiration timestamp included in the response.
        /// 
        ///  
        /// <para>
        /// Use the <code>capabilities</code> field to permit an end user to send messages or
        /// moderate a room.
        /// </para>
        ///  
        /// <para>
        /// The <code>attributes</code> field securely attaches structured data to the chat session;
        /// the data is included within each message sent by the end user and received by other
        /// participants in the room. Common use cases for attributes include passing end-user
        /// profile data like an icon, display name, colors, badges, and other display features.
        /// </para>
        ///  
        /// <para>
        /// Encryption keys are owned by Amazon IVS Chat and never used directly by your application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChatToken service method.</param>
        /// 
        /// <returns>The response from the CreateChatToken service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateChatToken">REST API Reference for CreateChatToken Operation</seealso>
        CreateChatTokenResponse CreateChatToken(CreateChatTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChatToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChatToken operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChatToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateChatToken">REST API Reference for CreateChatToken Operation</seealso>
        IAsyncResult BeginCreateChatToken(CreateChatTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChatToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChatToken.</param>
        /// 
        /// <returns>Returns a  CreateChatTokenResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateChatToken">REST API Reference for CreateChatToken Operation</seealso>
        CreateChatTokenResponse EndCreateChatToken(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoggingConfiguration


        /// <summary>
        /// Creates a logging configuration that allows clients to store and record sent messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLoggingConfiguration service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateLoggingConfiguration">REST API Reference for CreateLoggingConfiguration Operation</seealso>
        CreateLoggingConfigurationResponse CreateLoggingConfiguration(CreateLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggingConfiguration operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateLoggingConfiguration">REST API Reference for CreateLoggingConfiguration Operation</seealso>
        IAsyncResult BeginCreateLoggingConfiguration(CreateLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateLoggingConfigurationResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateLoggingConfiguration">REST API Reference for CreateLoggingConfiguration Operation</seealso>
        CreateLoggingConfigurationResponse EndCreateLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoom


        /// <summary>
        /// Creates a room that allows clients to connect and pass messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        CreateRoomResponse CreateRoom(CreateRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        IAsyncResult BeginCreateRoom(CreateRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoom.</param>
        /// 
        /// <returns>Returns a  CreateRoomResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        CreateRoomResponse EndCreateRoom(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoggingConfiguration


        /// <summary>
        /// Deletes the specified logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        IAsyncResult BeginDeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLoggingConfigurationResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        DeleteLoggingConfigurationResponse EndDeleteLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMessage


        /// <summary>
        /// Sends an event to a specific room which directs clients to delete a specific message;
        /// that is, unrender it from view and delete it from the client’s chat history. This
        /// event’s <code>EventName</code> is <code>aws:DELETE_MESSAGE</code>. This replicates
        /// the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-deletemessage-publish.html">
        /// DeleteMessage</a> WebSocket operation in the Amazon IVS Chat Messaging API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage service method.</param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        DeleteMessageResponse DeleteMessage(DeleteMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        IAsyncResult BeginDeleteMessage(DeleteMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessage.</param>
        /// 
        /// <returns>Returns a  DeleteMessageResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        DeleteMessageResponse EndDeleteMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoom


        /// <summary>
        /// Deletes the specified room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        DeleteRoomResponse DeleteRoom(DeleteRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        IAsyncResult BeginDeleteRoom(DeleteRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoom.</param>
        /// 
        /// <returns>Returns a  DeleteRoomResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        DeleteRoomResponse EndDeleteRoom(IAsyncResult asyncResult);

        #endregion
        
        #region  DisconnectUser


        /// <summary>
        /// Disconnects all connections using a specified user ID from a room. This replicates
        /// the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-disconnectuser-publish.html">
        /// DisconnectUser</a> WebSocket operation in the Amazon IVS Chat Messaging API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectUser service method.</param>
        /// 
        /// <returns>The response from the DisconnectUser service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DisconnectUser">REST API Reference for DisconnectUser Operation</seealso>
        DisconnectUserResponse DisconnectUser(DisconnectUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectUser operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DisconnectUser">REST API Reference for DisconnectUser Operation</seealso>
        IAsyncResult BeginDisconnectUser(DisconnectUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectUser.</param>
        /// 
        /// <returns>Returns a  DisconnectUserResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/DisconnectUser">REST API Reference for DisconnectUser Operation</seealso>
        DisconnectUserResponse EndDisconnectUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLoggingConfiguration


        /// <summary>
        /// Gets the specified logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        IAsyncResult BeginGetLoggingConfiguration(GetLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLoggingConfigurationResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        GetLoggingConfigurationResponse EndGetLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRoom


        /// <summary>
        /// Gets the specified room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetRoom">REST API Reference for GetRoom Operation</seealso>
        GetRoomResponse GetRoom(GetRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoom operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetRoom">REST API Reference for GetRoom Operation</seealso>
        IAsyncResult BeginGetRoom(GetRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoom.</param>
        /// 
        /// <returns>Returns a  GetRoomResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/GetRoom">REST API Reference for GetRoom Operation</seealso>
        GetRoomResponse EndGetRoom(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLoggingConfigurations


        /// <summary>
        /// Gets summary information about all your logging configurations in the AWS region where
        /// the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLoggingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoggingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        IAsyncResult BeginListLoggingConfigurations(ListLoggingConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoggingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoggingConfigurations.</param>
        /// 
        /// <returns>Returns a  ListLoggingConfigurationsResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        ListLoggingConfigurationsResponse EndListLoggingConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRooms


        /// <summary>
        /// Gets summary information about all your rooms in the AWS region where the API request
        /// is processed. Results are sorted in descending order of <code>updateTime</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRooms service method.</param>
        /// 
        /// <returns>The response from the ListRooms service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListRooms">REST API Reference for ListRooms Operation</seealso>
        ListRoomsResponse ListRooms(ListRoomsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRooms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRooms operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRooms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListRooms">REST API Reference for ListRooms Operation</seealso>
        IAsyncResult BeginListRooms(ListRoomsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRooms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRooms.</param>
        /// 
        /// <returns>Returns a  ListRoomsResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListRooms">REST API Reference for ListRooms Operation</seealso>
        ListRoomsResponse EndListRooms(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets information about AWS tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  SendEvent


        /// <summary>
        /// Sends an event to a room. Use this within your application’s business logic to send
        /// events to clients of a room; e.g., to notify clients to change the way the chat UI
        /// is rendered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/SendEvent">REST API Reference for SendEvent Operation</seealso>
        SendEventResponse SendEvent(SendEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEvent operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/SendEvent">REST API Reference for SendEvent Operation</seealso>
        IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEvent.</param>
        /// 
        /// <returns>Returns a  SendEventResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/SendEvent">REST API Reference for SendEvent Operation</seealso>
        SendEventResponse EndSendEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for the AWS resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLoggingConfiguration


        /// <summary>
        /// Updates a specified logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLoggingConfiguration service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        UpdateLoggingConfigurationResponse UpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        IAsyncResult BeginUpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLoggingConfigurationResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        UpdateLoggingConfigurationResponse EndUpdateLoggingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoom


        /// <summary>
        /// Updates a room’s configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by Ivschat.</returns>
        /// <exception cref="Amazon.Ivschat.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Ivschat.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        UpdateRoomResponse UpdateRoom(UpdateRoomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom operation on AmazonIvschatClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        IAsyncResult BeginUpdateRoom(UpdateRoomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoom.</param>
        /// 
        /// <returns>Returns a  UpdateRoomResult from Ivschat.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivschat-2020-07-14/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        UpdateRoomResponse EndUpdateRoom(IAsyncResult asyncResult);

        #endregion
        
    }
}