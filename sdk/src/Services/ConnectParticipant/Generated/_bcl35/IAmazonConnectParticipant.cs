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

using Amazon.Runtime;
using Amazon.ConnectParticipant.Model;

namespace Amazon.ConnectParticipant
{
    /// <summary>
    /// Interface for accessing ConnectParticipant
    ///
    /// Amazon Connect is a cloud-based contact center solution that makes it easy to set
    /// up and manage a customer contact center and provide reliable customer engagement at
    /// any scale.
    /// 
    ///  
    /// <para>
    /// Amazon Connect enables customer contacts through voice or chat.
    /// </para>
    ///  
    /// <para>
    /// The APIs described here are used by chat participants, such as agents and customers.
    /// </para>
    /// </summary>
    public partial interface IAmazonConnectParticipant : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectParticipantPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateParticipantConnection


        /// <summary>
        /// Creates the participant's connection. Note that ParticipantToken is used for invoking
        /// this API instead of ConnectionToken.
        /// 
        ///  
        /// <para>
        /// The participant token is valid for the lifetime of the participant – until the they
        /// are part of a contact.
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
        IAsyncResult BeginCreateParticipantConnection(CreateParticipantConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateParticipantConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateParticipantConnection.</param>
        /// 
        /// <returns>Returns a  CreateParticipantConnectionResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/CreateParticipantConnection">REST API Reference for CreateParticipantConnection Operation</seealso>
        CreateParticipantConnectionResponse EndCreateParticipantConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DisconnectParticipant


        /// <summary>
        /// Disconnects a participant. Note that ConnectionToken is used for invoking this API
        /// instead of ParticipantToken.
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
        IAsyncResult BeginDisconnectParticipant(DisconnectParticipantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectParticipant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectParticipant.</param>
        /// 
        /// <returns>Returns a  DisconnectParticipantResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        DisconnectParticipantResponse EndDisconnectParticipant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTranscript


        /// <summary>
        /// Retrieves a transcript of the session. Note that ConnectionToken is used for invoking
        /// this API instead of ParticipantToken.
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
        IAsyncResult BeginGetTranscript(GetTranscriptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTranscript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTranscript.</param>
        /// 
        /// <returns>Returns a  GetTranscriptResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/GetTranscript">REST API Reference for GetTranscript Operation</seealso>
        GetTranscriptResponse EndGetTranscript(IAsyncResult asyncResult);

        #endregion
        
        #region  SendEvent


        /// <summary>
        /// Sends an event. Note that ConnectionToken is used for invoking this API instead of
        /// ParticipantToken.
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
        IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEvent.</param>
        /// 
        /// <returns>Returns a  SendEventResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendEvent">REST API Reference for SendEvent Operation</seealso>
        SendEventResponse EndSendEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  SendMessage


        /// <summary>
        /// Sends a message. Note that ConnectionToken is used for invoking this API instead of
        /// ParticipantToken.
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
        IAsyncResult BeginSendMessage(SendMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessage.</param>
        /// 
        /// <returns>Returns a  SendMessageResult from ConnectParticipant.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectparticipant-2018-09-07/SendMessage">REST API Reference for SendMessage Operation</seealso>
        SendMessageResponse EndSendMessage(IAsyncResult asyncResult);

        #endregion
        
    }
}