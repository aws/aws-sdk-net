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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockAgentRuntime.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockAgentRuntime
{
    /// <summary>
    /// <para>Interface for accessing BedrockAgentRuntime</para>
    ///
    /// Contains APIs related to model invocation and querying of knowledge bases.
    /// </summary>
    public partial interface IAmazonBedrockAgentRuntime : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockAgentRuntimePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateInvocation


        /// <summary>
        /// Creates a new invocation within a session. An invocation groups the related invocation
        /// steps that store the content from a conversation. For more information about sessions,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// 
        ///  
        /// <para>
        /// Related APIs
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocations.html">ListInvocations</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListSessions.html">ListSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_GetSession.html">GetSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvocation service method.</param>
        /// 
        /// <returns>The response from the CreateInvocation service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/CreateInvocation">REST API Reference for CreateInvocation Operation</seealso>
        CreateInvocationResponse CreateInvocation(CreateInvocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvocation operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/CreateInvocation">REST API Reference for CreateInvocation Operation</seealso>
        IAsyncResult BeginCreateInvocation(CreateInvocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvocation.</param>
        /// 
        /// <returns>Returns a  CreateInvocationResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/CreateInvocation">REST API Reference for CreateInvocation Operation</seealso>
        CreateInvocationResponse EndCreateInvocation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSession


        /// <summary>
        /// Creates a session to temporarily store conversations for generative AI (GenAI) applications
        /// built with open-source frameworks such as LangGraph and LlamaIndex. Sessions enable
        /// you to save the state of conversations at checkpoints, with the added security and
        /// infrastructure of Amazon Web Services. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// 
        ///  
        /// <para>
        /// By default, Amazon Bedrock uses Amazon Web Services-managed keys for session encryption,
        /// including session metadata, or you can use your own KMS key. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/session-encryption.html">Amazon
        /// Bedrock session encryption</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  You use a session to store state and conversation history for generative AI applications
        /// built with open-source frameworks. For Amazon Bedrock Agents, the service automatically
        /// manages conversation context and associates them with the agent-specific sessionId
        /// you specify in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html">InvokeAgent</a>
        /// API operation. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Related APIs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListSessions.html">ListSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_GetSession.html">GetSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_EndSession.html">EndSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_DeleteSession.html">DeleteSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse CreateSession(CreateSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSession operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/CreateSession">REST API Reference for CreateSession Operation</seealso>
        IAsyncResult BeginCreateSession(CreateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSession.</param>
        /// 
        /// <returns>Returns a  CreateSessionResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse EndCreateSession(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAgentMemory


        /// <summary>
        /// Deletes memory from the specified memory identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentMemory service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentMemory service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/DeleteAgentMemory">REST API Reference for DeleteAgentMemory Operation</seealso>
        DeleteAgentMemoryResponse DeleteAgentMemory(DeleteAgentMemoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgentMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentMemory operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgentMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/DeleteAgentMemory">REST API Reference for DeleteAgentMemory Operation</seealso>
        IAsyncResult BeginDeleteAgentMemory(DeleteAgentMemoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgentMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgentMemory.</param>
        /// 
        /// <returns>Returns a  DeleteAgentMemoryResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/DeleteAgentMemory">REST API Reference for DeleteAgentMemory Operation</seealso>
        DeleteAgentMemoryResponse EndDeleteAgentMemory(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSession


        /// <summary>
        /// Deletes a session that you ended. You can't delete a session with an <c>ACTIVE</c>
        /// status. To delete an active session, you must first end it with the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_EndSession.html">EndSession</a>
        /// API operation. For more information about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession service method.</param>
        /// 
        /// <returns>The response from the DeleteSession service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        DeleteSessionResponse DeleteSession(DeleteSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        IAsyncResult BeginDeleteSession(DeleteSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSession.</param>
        /// 
        /// <returns>Returns a  DeleteSessionResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        DeleteSessionResponse EndDeleteSession(IAsyncResult asyncResult);

        #endregion
        
        #region  EndSession


        /// <summary>
        /// Ends the session. After you end a session, you can still access its content but you
        /// can’t add to it. To delete the session and it's content, you use the DeleteSession
        /// API operation. For more information about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndSession service method.</param>
        /// 
        /// <returns>The response from the EndSession service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/EndSession">REST API Reference for EndSession Operation</seealso>
        EndSessionResponse EndSession(EndSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndSession operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/EndSession">REST API Reference for EndSession Operation</seealso>
        IAsyncResult BeginEndSession(EndSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndSession.</param>
        /// 
        /// <returns>Returns a  EndSessionResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/EndSession">REST API Reference for EndSession Operation</seealso>
        EndSessionResponse EndEndSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateQuery


        /// <summary>
        /// Generates an SQL query from a natural language query. For more information, see <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-generate-query.html">Generate
        /// a query for structured data</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateQuery service method.</param>
        /// 
        /// <returns>The response from the GenerateQuery service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GenerateQuery">REST API Reference for GenerateQuery Operation</seealso>
        GenerateQueryResponse GenerateQuery(GenerateQueryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateQuery operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GenerateQuery">REST API Reference for GenerateQuery Operation</seealso>
        IAsyncResult BeginGenerateQuery(GenerateQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateQuery.</param>
        /// 
        /// <returns>Returns a  GenerateQueryResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GenerateQuery">REST API Reference for GenerateQuery Operation</seealso>
        GenerateQueryResponse EndGenerateQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAgentMemory


        /// <summary>
        /// Gets the sessions stored in the memory of the agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentMemory service method.</param>
        /// 
        /// <returns>The response from the GetAgentMemory service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetAgentMemory">REST API Reference for GetAgentMemory Operation</seealso>
        GetAgentMemoryResponse GetAgentMemory(GetAgentMemoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentMemory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentMemory operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentMemory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetAgentMemory">REST API Reference for GetAgentMemory Operation</seealso>
        IAsyncResult BeginGetAgentMemory(GetAgentMemoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentMemory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentMemory.</param>
        /// 
        /// <returns>Returns a  GetAgentMemoryResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetAgentMemory">REST API Reference for GetAgentMemory Operation</seealso>
        GetAgentMemoryResponse EndGetAgentMemory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInvocationStep


        /// <summary>
        /// Retrieves the details of a specific invocation step within an invocation in a session.
        /// For more information about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvocationStep service method.</param>
        /// 
        /// <returns>The response from the GetInvocationStep service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetInvocationStep">REST API Reference for GetInvocationStep Operation</seealso>
        GetInvocationStepResponse GetInvocationStep(GetInvocationStepRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvocationStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvocationStep operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvocationStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetInvocationStep">REST API Reference for GetInvocationStep Operation</seealso>
        IAsyncResult BeginGetInvocationStep(GetInvocationStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvocationStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvocationStep.</param>
        /// 
        /// <returns>Returns a  GetInvocationStepResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetInvocationStep">REST API Reference for GetInvocationStep Operation</seealso>
        GetInvocationStepResponse EndGetInvocationStep(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Retrieves details about a specific session. For more information about sessions, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse GetSession(GetSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetSession">REST API Reference for GetSession Operation</seealso>
        IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse EndGetSession(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeAgent


        /// <summary>
        /// <note> </note> 
        /// <para>
        /// Sends a prompt for the agent to process and respond to. Note the following fields
        /// for the request:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To continue the same conversation with an agent, use the same <c>sessionId</c> value
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To activate trace enablement, turn <c>enableTrace</c> to <c>true</c>. Trace enablement
        /// helps you follow the agent's reasoning process that led it to the information it processed,
        /// the actions it took, and the final result it yielded. For more information, see <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-events">Trace
        /// enablement</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// End a conversation by setting <c>endSession</c> to <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the <c>sessionState</c> object, you can include attributes for the session or prompt
        /// or, if you configured an action group to return control, results from invocation of
        /// the action group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The response contains both <b>chunk</b> and <b>trace</b> attributes.
        /// </para>
        ///  
        /// <para>
        /// The final response is returned in the <c>bytes</c> field of the <c>chunk</c> object.
        /// The <c>InvokeAgent</c> returns one chunk for the entire interaction.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>attribution</c> object contains citations for parts of the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set <c>enableTrace</c> to <c>true</c> in the request, you can trace the agent's
        /// steps and reasoning process that led it to the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the action predicted was configured to return control, the response returns parameters
        /// for the action, elicited from the user, in the <c>returnControl</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Errors are also surfaced in the response.
        /// </para>
        ///  </li> </ul>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgent service method.</param>
        /// 
        /// <returns>The response from the InvokeAgent service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The
        /// AWS SDK will automatically retry the operation up to 5 times. For information about
        /// configuring automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeAgent">REST API Reference for InvokeAgent Operation</seealso>
        InvokeAgentResponse InvokeAgent(InvokeAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgent operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeAgent">REST API Reference for InvokeAgent Operation</seealso>
        IAsyncResult BeginInvokeAgent(InvokeAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeAgent.</param>
        /// 
        /// <returns>Returns a  InvokeAgentResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeAgent">REST API Reference for InvokeAgent Operation</seealso>
        InvokeAgentResponse EndInvokeAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeFlow


        /// <summary>
        /// Invokes an alias of a flow to run the inputs that you specify and return the output
        /// of each node as a stream. If there's an error, the error is returned. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-test.html">Test
        /// a flow in Amazon Bedrock</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeFlow</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeFlow service method.</param>
        /// 
        /// <returns>The response from the InvokeFlow service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeFlow">REST API Reference for InvokeFlow Operation</seealso>
        InvokeFlowResponse InvokeFlow(InvokeFlowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeFlow operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeFlow">REST API Reference for InvokeFlow Operation</seealso>
        IAsyncResult BeginInvokeFlow(InvokeFlowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeFlow.</param>
        /// 
        /// <returns>Returns a  InvokeFlowResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeFlow">REST API Reference for InvokeFlow Operation</seealso>
        InvokeFlowResponse EndInvokeFlow(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeInlineAgent


        /// <summary>
        /// Invokes an inline Amazon Bedrock agent using the configurations you provide with
        /// the request. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Specify the following fields for security purposes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// (Optional) <c>customerEncryptionKeyArn</c> – The Amazon Resource Name (ARN) of a KMS
        /// key to encrypt the creation of the agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <c>idleSessionTTLinSeconds</c> – Specify the number of seconds for which
        /// the agent should maintain session information. After this time expires, the subsequent
        /// <c>InvokeInlineAgent</c> request begins a new session.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To override the default prompt behavior for agent orchestration and to use advanced
        /// prompts, include a <c>promptOverrideConfiguration</c> object. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The agent instructions will not be honored if your agent has only one knowledge base,
        /// uses default prompts, has no action group, and user input is disabled.
        /// </para>
        ///  </li> </ul> <note> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeInlineAgent service method.</param>
        /// 
        /// <returns>The response from the InvokeInlineAgent service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeInlineAgent">REST API Reference for InvokeInlineAgent Operation</seealso>
        InvokeInlineAgentResponse InvokeInlineAgent(InvokeInlineAgentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeInlineAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeInlineAgent operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeInlineAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeInlineAgent">REST API Reference for InvokeInlineAgent Operation</seealso>
        IAsyncResult BeginInvokeInlineAgent(InvokeInlineAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeInlineAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeInlineAgent.</param>
        /// 
        /// <returns>Returns a  InvokeInlineAgentResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/InvokeInlineAgent">REST API Reference for InvokeInlineAgent Operation</seealso>
        InvokeInlineAgentResponse EndInvokeInlineAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvocations


        /// <summary>
        /// Lists all invocations associated with a specific session. For more information about
        /// sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvocations service method.</param>
        /// 
        /// <returns>The response from the ListInvocations service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListInvocations">REST API Reference for ListInvocations Operation</seealso>
        ListInvocationsResponse ListInvocations(ListInvocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvocations operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListInvocations">REST API Reference for ListInvocations Operation</seealso>
        IAsyncResult BeginListInvocations(ListInvocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvocations.</param>
        /// 
        /// <returns>Returns a  ListInvocationsResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListInvocations">REST API Reference for ListInvocations Operation</seealso>
        ListInvocationsResponse EndListInvocations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvocationSteps


        /// <summary>
        /// Lists all invocation steps associated with a session and optionally, an invocation
        /// within the session. For more information about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvocationSteps service method.</param>
        /// 
        /// <returns>The response from the ListInvocationSteps service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListInvocationSteps">REST API Reference for ListInvocationSteps Operation</seealso>
        ListInvocationStepsResponse ListInvocationSteps(ListInvocationStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvocationSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvocationSteps operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvocationSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListInvocationSteps">REST API Reference for ListInvocationSteps Operation</seealso>
        IAsyncResult BeginListInvocationSteps(ListInvocationStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvocationSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvocationSteps.</param>
        /// 
        /// <returns>Returns a  ListInvocationStepsResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListInvocationSteps">REST API Reference for ListInvocationSteps Operation</seealso>
        ListInvocationStepsResponse EndListInvocationSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists all sessions in your Amazon Web Services account. For more information about
        /// sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListSessions">REST API Reference for ListSessions Operation</seealso>
        IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse EndListSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all the tags for the resource you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  OptimizePrompt


        /// <summary>
        /// Optimizes a prompt for the task that you specify. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-optimize.html">Optimize
        /// a prompt</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptimizePrompt service method.</param>
        /// 
        /// <returns>The response from the OptimizePrompt service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/OptimizePrompt">REST API Reference for OptimizePrompt Operation</seealso>
        OptimizePromptResponse OptimizePrompt(OptimizePromptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the OptimizePrompt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OptimizePrompt operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOptimizePrompt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/OptimizePrompt">REST API Reference for OptimizePrompt Operation</seealso>
        IAsyncResult BeginOptimizePrompt(OptimizePromptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OptimizePrompt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOptimizePrompt.</param>
        /// 
        /// <returns>Returns a  OptimizePromptResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/OptimizePrompt">REST API Reference for OptimizePrompt Operation</seealso>
        OptimizePromptResponse EndOptimizePrompt(IAsyncResult asyncResult);

        #endregion
        
        #region  PutInvocationStep


        /// <summary>
        /// Add an invocation step to an invocation in a session. An invocation step stores fine-grained
        /// state checkpoints, including text and images, for each interaction. For more information
        /// about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// 
        ///  
        /// <para>
        /// Related APIs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_GetInvocationStep.html">GetInvocationStep</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocationSteps.html">ListInvocationSteps</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocations.html">ListInvocations</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocations.html">ListSessions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInvocationStep service method.</param>
        /// 
        /// <returns>The response from the PutInvocationStep service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/PutInvocationStep">REST API Reference for PutInvocationStep Operation</seealso>
        PutInvocationStepResponse PutInvocationStep(PutInvocationStepRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutInvocationStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInvocationStep operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInvocationStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/PutInvocationStep">REST API Reference for PutInvocationStep Operation</seealso>
        IAsyncResult BeginPutInvocationStep(PutInvocationStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutInvocationStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInvocationStep.</param>
        /// 
        /// <returns>Returns a  PutInvocationStepResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/PutInvocationStep">REST API Reference for PutInvocationStep Operation</seealso>
        PutInvocationStepResponse EndPutInvocationStep(IAsyncResult asyncResult);

        #endregion
        
        #region  Rerank


        /// <summary>
        /// Reranks the relevance of sources based on queries. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/rerank.html">Improve
        /// the relevance of query responses with a reranker model</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Rerank service method.</param>
        /// 
        /// <returns>The response from the Rerank service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Rerank">REST API Reference for Rerank Operation</seealso>
        RerankResponse Rerank(RerankRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Rerank operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Rerank operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRerank
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Rerank">REST API Reference for Rerank Operation</seealso>
        IAsyncResult BeginRerank(RerankRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Rerank operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRerank.</param>
        /// 
        /// <returns>Returns a  RerankResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Rerank">REST API Reference for Rerank Operation</seealso>
        RerankResponse EndRerank(IAsyncResult asyncResult);

        #endregion
        
        #region  Retrieve


        /// <summary>
        /// Queries a knowledge base and retrieves information from it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Retrieve service method.</param>
        /// 
        /// <returns>The response from the Retrieve service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Retrieve">REST API Reference for Retrieve Operation</seealso>
        RetrieveResponse Retrieve(RetrieveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Retrieve operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Retrieve operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieve
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Retrieve">REST API Reference for Retrieve Operation</seealso>
        IAsyncResult BeginRetrieve(RetrieveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Retrieve operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieve.</param>
        /// 
        /// <returns>Returns a  RetrieveResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/Retrieve">REST API Reference for Retrieve Operation</seealso>
        RetrieveResponse EndRetrieve(IAsyncResult asyncResult);

        #endregion
        
        #region  RetrieveAndGenerate


        /// <summary>
        /// Queries a knowledge base and generates responses based on the retrieved results and
        /// using the specified foundation model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a>. The response only cites sources that are relevant to the query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerate service method.</param>
        /// 
        /// <returns>The response from the RetrieveAndGenerate service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerate">REST API Reference for RetrieveAndGenerate Operation</seealso>
        RetrieveAndGenerateResponse RetrieveAndGenerate(RetrieveAndGenerateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveAndGenerate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerate operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveAndGenerate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerate">REST API Reference for RetrieveAndGenerate Operation</seealso>
        IAsyncResult BeginRetrieveAndGenerate(RetrieveAndGenerateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveAndGenerate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveAndGenerate.</param>
        /// 
        /// <returns>Returns a  RetrieveAndGenerateResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerate">REST API Reference for RetrieveAndGenerate Operation</seealso>
        RetrieveAndGenerateResponse EndRetrieveAndGenerate(IAsyncResult asyncResult);

        #endregion
        
        #region  RetrieveAndGenerateStream


        /// <summary>
        /// Queries a knowledge base and generates responses based on the retrieved results, with
        /// output in streaming format.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeModelWithResponseStream</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permission for the <c> bedrock:RetrieveAndGenerate</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerateStream service method.</param>
        /// 
        /// <returns>The response from the RetrieveAndGenerateStream service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.BadGatewayException">
        /// There was an issue with a dependency due to a server issue. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.DependencyFailedException">
        /// There was an issue with a dependency. Check the resource configurations and retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerateStream">REST API Reference for RetrieveAndGenerateStream Operation</seealso>
        RetrieveAndGenerateStreamResponse RetrieveAndGenerateStream(RetrieveAndGenerateStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveAndGenerateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerateStream operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveAndGenerateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerateStream">REST API Reference for RetrieveAndGenerateStream Operation</seealso>
        IAsyncResult BeginRetrieveAndGenerateStream(RetrieveAndGenerateStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveAndGenerateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveAndGenerateStream.</param>
        /// 
        /// <returns>Returns a  RetrieveAndGenerateStreamResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/RetrieveAndGenerateStream">REST API Reference for RetrieveAndGenerateStream Operation</seealso>
        RetrieveAndGenerateStreamResponse EndRetrieveAndGenerateStream(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSession


        /// <summary>
        /// Updates the metadata or encryption settings of a session. For more information about
        /// sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
        /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
        /// 
        /// <returns>The response from the UpdateSession service method, as returned by BedrockAgentRuntime.</returns>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions. Check your permissions
        /// and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ConflictException">
        /// There was a conflict performing an operation. Resolve the conflict and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        UpdateSessionResponse UpdateSession(UpdateSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession operation on AmazonBedrockAgentRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        IAsyncResult BeginUpdateSession(UpdateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSession.</param>
        /// 
        /// <returns>Returns a  UpdateSessionResult from BedrockAgentRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agent-runtime-2023-07-26/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        UpdateSessionResponse EndUpdateSession(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}