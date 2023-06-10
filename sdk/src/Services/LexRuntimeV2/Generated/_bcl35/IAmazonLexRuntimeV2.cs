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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LexRuntimeV2.Model;

namespace Amazon.LexRuntimeV2
{
    /// <summary>
    /// Interface for accessing LexRuntimeV2
    ///
    /// This section contains documentation for the Amazon Lex V2 Runtime V2 API operations.
    /// </summary>
    public partial interface IAmazonLexRuntimeV2 : IAmazonService, IDisposable
    {




        
        #region  DeleteSession


        /// <summary>
        /// Removes session information for a specified bot, alias, and user ID. 
        /// 
        ///  
        /// <para>
        /// You can use this operation to restart a conversation with a bot. When you remove a
        /// session, the entire history of the session is removed so that you can start again.
        /// </para>
        ///  
        /// <para>
        /// You don't need to delete a session. Sessions have a time limit and will expire. Set
        /// the session time limit when you create the bot. The default is 5 minutes, but you
        /// can specify anything between 1 minute and 24 hours.
        /// </para>
        ///  
        /// <para>
        /// If you specify a bot or alias ID that doesn't exist, you receive a <code>BadRequestException.</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the locale doesn't exist in the bot, or if the locale hasn't been enables for the
        /// alias, you receive a <code>BadRequestException</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession service method.</param>
        /// 
        /// <returns>The response from the DeleteSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        DeleteSessionResponse DeleteSession(DeleteSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession operation on AmazonLexRuntimeV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        IAsyncResult BeginDeleteSession(DeleteSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSession.</param>
        /// 
        /// <returns>Returns a  DeleteSessionResult from LexRuntimeV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        DeleteSessionResponse EndDeleteSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Returns session information for a specified bot, alias, and user.
        /// 
        ///  
        /// <para>
        /// For example, you can use this operation to retrieve session information for a user
        /// that has left a long-running session in use.
        /// </para>
        ///  
        /// <para>
        /// If the bot, alias, or session identifier doesn't exist, Amazon Lex V2 returns a <code>BadRequestException</code>.
        /// If the locale doesn't exist or is not enabled for the alias, you receive a <code>BadRequestException</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse GetSession(GetSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonLexRuntimeV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/GetSession">REST API Reference for GetSession Operation</seealso>
        IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from LexRuntimeV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse EndGetSession(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSession


        /// <summary>
        /// Creates a new session or modifies an existing session with an Amazon Lex V2 bot. Use
        /// this operation to enable your application to set the state of the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSession service method.</param>
        /// 
        /// <returns>The response from the PutSession service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/PutSession">REST API Reference for PutSession Operation</seealso>
        PutSessionResponse PutSession(PutSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSession operation on AmazonLexRuntimeV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/PutSession">REST API Reference for PutSession Operation</seealso>
        IAsyncResult BeginPutSession(PutSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSession.</param>
        /// 
        /// <returns>Returns a  PutSessionResult from LexRuntimeV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/PutSession">REST API Reference for PutSession Operation</seealso>
        PutSessionResponse EndPutSession(IAsyncResult asyncResult);

        #endregion
        
        #region  RecognizeText


        /// <summary>
        /// Sends user input to Amazon Lex V2. Client applications use this API to send requests
        /// to Amazon Lex V2 at runtime. Amazon Lex V2 then interprets the user input using the
        /// machine learning model that it build for the bot.
        /// 
        ///  
        /// <para>
        /// In response, Amazon Lex V2 returns the next message to convey to the user and an optional
        /// response card to display.
        /// </para>
        ///  
        /// <para>
        /// If the optional post-fulfillment response is specified, the messages are returned
        /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
        /// the intent state is fulfilled or ready fulfillment if the message is present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
        /// an exception or if the Lambda function returns a failed intent state without a message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
        /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
        /// If you configure a timeout, the timeout message is returned when the period times
        /// out. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
        /// message</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeText service method.</param>
        /// 
        /// <returns>The response from the RecognizeText service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeText">REST API Reference for RecognizeText Operation</seealso>
        RecognizeTextResponse RecognizeText(RecognizeTextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RecognizeText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecognizeText operation on AmazonLexRuntimeV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecognizeText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeText">REST API Reference for RecognizeText Operation</seealso>
        IAsyncResult BeginRecognizeText(RecognizeTextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RecognizeText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecognizeText.</param>
        /// 
        /// <returns>Returns a  RecognizeTextResult from LexRuntimeV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeText">REST API Reference for RecognizeText Operation</seealso>
        RecognizeTextResponse EndRecognizeText(IAsyncResult asyncResult);

        #endregion
        
        #region  RecognizeUtterance


        /// <summary>
        /// Sends user input to Amazon Lex V2. You can send text or speech. Clients use this API
        /// to send text and audio requests to Amazon Lex V2 at runtime. Amazon Lex V2 interprets
        /// the user input using the machine learning model built for the bot.
        /// 
        ///  
        /// <para>
        /// The following request fields must be compressed with gzip and then base64 encoded
        /// before you send them to Amazon Lex V2. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// requestAttributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// sessionState
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following response fields are compressed using gzip and then base64 encoded by
        /// Amazon Lex V2. Before you can use these fields, you must decode and decompress them.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// inputTranscript
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// interpretations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// requestAttributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// sessionState
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The example contains a Java application that compresses and encodes a Java object
        /// to send to Amazon Lex V2, and a second that decodes and decompresses a response from
        /// Amazon Lex V2.
        /// </para>
        ///  
        /// <para>
        /// If the optional post-fulfillment response is specified, the messages are returned
        /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
        /// the intent state is fulfilled or ready fulfillment if the message is present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
        /// an exception or if the Lambda function returns a failed intent state without a message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
        /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
        /// If you configure a timeout, the timeout message is returned when the period times
        /// out. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
        /// message</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeUtterance service method.</param>
        /// 
        /// <returns>The response from the RecognizeUtterance service method, as returned by LexRuntimeV2.</returns>
        /// <exception cref="Amazon.LexRuntimeV2.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.BadGatewayException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.DependencyFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexRuntimeV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeUtterance">REST API Reference for RecognizeUtterance Operation</seealso>
        RecognizeUtteranceResponse RecognizeUtterance(RecognizeUtteranceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RecognizeUtterance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecognizeUtterance operation on AmazonLexRuntimeV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecognizeUtterance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeUtterance">REST API Reference for RecognizeUtterance Operation</seealso>
        IAsyncResult BeginRecognizeUtterance(RecognizeUtteranceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RecognizeUtterance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecognizeUtterance.</param>
        /// 
        /// <returns>Returns a  RecognizeUtteranceResult from LexRuntimeV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.lex.v2-2020-08-07/RecognizeUtterance">REST API Reference for RecognizeUtterance Operation</seealso>
        RecognizeUtteranceResponse EndRecognizeUtterance(IAsyncResult asyncResult);

        #endregion
        
    }
}