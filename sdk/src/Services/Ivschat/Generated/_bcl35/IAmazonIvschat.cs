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
    ///  </li> </ul> <pre><code> &lt;p&gt; &lt;b&gt;Resources&lt;/b&gt; &lt;/p&gt; &lt;p&gt;The
    /// following resource is part of Amazon IVS Chat:&lt;/p&gt; &lt;ul&gt; &lt;li&gt; &lt;p&gt;
    /// &lt;b&gt;Room&lt;/b&gt; — The central Amazon IVS Chat resource through which clients
    /// connect to and exchange chat messages. See the Room endpoints for more information.&lt;/p&gt;
    /// &lt;/li&gt; &lt;/ul&gt; &lt;p&gt; &lt;b&gt;API Access Security&lt;/b&gt; &lt;/p&gt;
    /// &lt;p&gt;Your Amazon IVS Chat applications (service applications and clients) must
    /// be authenticated and authorized to access Amazon IVS Chat resources. Note the differences
    /// between these concepts:&lt;/p&gt; &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;i&gt;Authentication&lt;/i&gt;
    /// is about verifying identity. Requests to the Amazon IVS Chat API must be signed to
    /// verify your identity.&lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;i&gt;Authorization&lt;/i&gt;
    /// is about granting permissions. Your IAM roles need to have permissions for Amazon
    /// IVS Chat API requests.&lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;p&gt;Users (viewers)
    /// connect to a room using secure access tokens that you create using the &lt;a&gt;CreateChatToken&lt;/a&gt;
    /// endpoint through the AWS SDK. You call CreateChatToken for every user’s chat session,
    /// passing identity and authorization information about the user.&lt;/p&gt; &lt;p&gt;
    /// &lt;b&gt;Signing API Requests&lt;/b&gt; &lt;/p&gt; &lt;p&gt;HTTP API requests must
    /// be signed with an AWS SigV4 signature using your AWS security credentials. The AWS
    /// Command Line Interface (CLI) and the AWS SDKs take care of signing the underlying
    /// API calls for you. However, if your application calls the Amazon IVS Chat HTTP API
    /// directly, it’s your responsibility to sign the requests.&lt;/p&gt; &lt;p&gt;You generate
    /// a signature using valid AWS credentials for an IAM role that has permission to perform
    /// the requested action. For example, DeleteMessage requests must be made using an IAM
    /// role that has the &lt;code&gt;ivschat:DeleteMessage&lt;/code&gt; permission.&lt;/p&gt;
    /// &lt;p&gt;For more information:&lt;/p&gt; &lt;ul&gt; &lt;li&gt; &lt;p&gt;Authentication
    /// and generating signatures — See &lt;a href=&quot;https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html&quot;&gt;Authenticating
    /// Requests (Amazon Web Services Signature Version 4)&lt;/a&gt; in the &lt;i&gt;Amazon
    /// Web Services General Reference&lt;/i&gt;.&lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt;Managing
    /// Amazon IVS permissions — See &lt;a href=&quot;https://docs.aws.amazon.com/ivs/latest/userguide/security-iam.html&quot;&gt;Identity
    /// and Access Management&lt;/a&gt; on the Security page of the &lt;i&gt;Amazon IVS User
    /// Guide&lt;/i&gt;.&lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;p&gt; &lt;b&gt;Messaging Endpoints&lt;/b&gt;
    /// &lt;/p&gt; &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;DeleteMessage&lt;/a&gt; — Sends
    /// an event to a specific room which directs clients to delete a specific message; that
    /// is, unrender it from view and delete it from the client’s chat history. This event’s
    /// &lt;code&gt;EventName&lt;/code&gt; is &lt;code&gt;aws:DELETE_MESSAGE&lt;/code&gt;.
    /// This replicates the &lt;a href=&quot;https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-deletemessage-publish.html&quot;&gt;
    /// DeleteMessage&lt;/a&gt; WebSocket operation in the Amazon IVS Chat Messaging API.&lt;/p&gt;
    /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;DisconnectUser&lt;/a&gt; — Disconnects all
    /// connections using a specified user ID from a room. This replicates the &lt;a href=&quot;https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-disconnectuser-publish.html&quot;&gt;
    /// DisconnectUser&lt;/a&gt; WebSocket operation in the Amazon IVS Chat Messaging API.&lt;/p&gt;
    /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;SendEvent&lt;/a&gt; — Sends an event to
    /// a room. Use this within your application’s business logic to send events to clients
    /// of a room; e.g., to notify clients to change the way the chat UI is rendered.&lt;/p&gt;
    /// &lt;/li&gt; &lt;/ul&gt; &lt;p&gt; &lt;b&gt;Chat Token Endpoint&lt;/b&gt; &lt;/p&gt;
    /// &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;CreateChatToken&lt;/a&gt; — Creates an encrypted
    /// token that is used to establish an individual WebSocket connection to a room. The
    /// token is valid for one minute, and a connection (session) established with the token
    /// is valid for the specified duration.&lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;p&gt; &lt;b&gt;Room
    /// Endpoints&lt;/b&gt; &lt;/p&gt; &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;CreateRoom&lt;/a&gt;
    /// — Creates a room that allows clients to connect and pass messages.&lt;/p&gt; &lt;/li&gt;
    /// &lt;li&gt; &lt;p&gt; &lt;a&gt;DeleteRoom&lt;/a&gt; — Deletes the specified room.&lt;/p&gt;
    /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;GetRoom&lt;/a&gt; — Gets the specified room.&lt;/p&gt;
    /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;ListRooms&lt;/a&gt; — Gets summary information
    /// about all your rooms in the AWS region where the API request is processed. &lt;/p&gt;
    /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;UpdateRoom&lt;/a&gt; — Updates a room’s
    /// configuration.&lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;p&gt; &lt;b&gt;Tags Endpoints&lt;/b&gt;
    /// &lt;/p&gt; &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;ListTagsForResource&lt;/a&gt;
    /// — Gets information about AWS tags for the specified ARN.&lt;/p&gt; &lt;/li&gt; &lt;li&gt;
    /// &lt;p&gt; &lt;a&gt;TagResource&lt;/a&gt; — Adds or updates tags for the AWS resource
    /// with the specified ARN.&lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a&gt;UntagResource&lt;/a&gt;
    /// — Removes tags from the resource with the specified ARN.&lt;/p&gt; &lt;/li&gt; &lt;/ul&gt;
    /// &lt;p&gt;All the above are HTTP operations. There is a separate &lt;i&gt;messaging&lt;/i&gt;
    /// API for managing Chat resources; see the &lt;a href=&quot;https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/chat-messaging-api.html&quot;&gt;
    /// Amazon IVS Chat Messaging API Reference&lt;/a&gt;.&lt;/p&gt; </code></pre>
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
        /// Creates an encrypted token that is used to establish an individual WebSocket connection
        /// to a room. The token is valid for one minute, and a connection (session) established
        /// with the token is valid for the specified duration.
        /// 
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