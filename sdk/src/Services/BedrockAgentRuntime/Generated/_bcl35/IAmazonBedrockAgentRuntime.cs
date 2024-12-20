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
        
        #region  InvokeAgent


        /// <summary>
        /// <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeAgent</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sends a prompt for the agent to process and respond to. Note the following fields
        /// for the request:
        /// </para>
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
        /// To stream agent responses, make sure that only orchestration prompt is enabled. Agent
        /// streaming is not supported for the following steps: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Pre-processing</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Post-processing</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agent with 1 Knowledge base and <c>User Input</c> not enabled
        /// </para>
        ///  </li> </ul> </li> <li> 
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
        /// The response is returned in the <c>bytes</c> field of the <c>chunk</c> object.
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
        ///  </li> </ul> <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeInlineAgent</c>.
        /// </para>
        ///  </note>
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