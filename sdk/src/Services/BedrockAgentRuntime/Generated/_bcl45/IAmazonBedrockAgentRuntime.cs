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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockAgentRuntime.Model;

namespace Amazon.BedrockAgentRuntime
{
    /// <summary>
    /// <para>Interface for accessing BedrockAgentRuntime</para>
    ///
    /// Contains APIs related to model invocation and querying of knowledge bases.
    /// </summary>
    public partial interface IAmazonBedrockAgentRuntime : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockAgentRuntimePaginatorFactory Paginators { get; }

        
        #region  InvokeAgent


        /// <summary>
        /// Sends a prompt for the agent to process and respond to.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support <c>InvokeAgent</c>.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// Include attributes for the session or prompt in the <c>sessionState</c> object.
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
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        /// Sends a prompt for the agent to process and respond to.
        /// 
        ///  <note> 
        /// <para>
        /// The CLI doesn't support <c>InvokeAgent</c>.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// Include attributes for the session or prompt in the <c>sessionState</c> object.
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
        /// Errors are also surfaced in the response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.BedrockAgentRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        Task<InvokeAgentResponse> InvokeAgentAsync(InvokeAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        /// Queries a knowledge base and retrieves information from it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Retrieve service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        Task<RetrieveResponse> RetrieveAsync(RetrieveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetrieveAndGenerate


        /// <summary>
        /// Queries a knowledge base and generates responses based on the retrieved results. The
        /// response cites up to five sources but only selects the ones that are relevant to the
        /// query.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>numberOfResults</c> field is currently unsupported for <c>RetrieveAndGenerate</c>.
        /// Don't include it in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_KnowledgeBaseVectorSearchConfiguration.html">vectorSearchConfiguration</a>
        /// object.
        /// </para>
        ///  </note>
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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        /// Queries a knowledge base and generates responses based on the retrieved results. The
        /// response cites up to five sources but only selects the ones that are relevant to the
        /// query.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>numberOfResults</c> field is currently unsupported for <c>RetrieveAndGenerate</c>.
        /// Don't include it in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_KnowledgeBaseVectorSearchConfiguration.html">vectorSearchConfiguration</a>
        /// object.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveAndGenerate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The specified resource ARN was not found. Check the ARN and try your request again.
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
        Task<RetrieveAndGenerateResponse> RetrieveAndGenerateAsync(RetrieveAndGenerateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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