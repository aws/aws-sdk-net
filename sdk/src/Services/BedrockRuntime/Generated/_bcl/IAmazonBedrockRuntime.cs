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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockRuntime.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockRuntime
{
    /// <summary>
    /// <para>Interface for accessing BedrockRuntime</para>
    ///
    /// Describes the API operations for running inference using Amazon Bedrock models.
    /// </summary>
    public partial interface IAmazonBedrockRuntime : IAmazonService, IDisposable
    {


        
        #region  InvokeModel


        /// <summary>
        /// Invokes the specified Amazon Bedrock model to run inference using the prompt and inference
        /// parameters provided in the request body. You use model inference to generate text,
        /// images, and embeddings.
        /// 
        ///  
        /// <para>
        /// For example code, see <i>Invoke model code examples</i> in the <i>Amazon Bedrock User
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModel</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModel service method.</param>
        /// 
        /// <returns>The response from the InvokeModel service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModel">REST API Reference for InvokeModel Operation</seealso>
        InvokeModelResponse InvokeModel(InvokeModelRequest request);



        /// <summary>
        /// Invokes the specified Amazon Bedrock model to run inference using the prompt and inference
        /// parameters provided in the request body. You use model inference to generate text,
        /// images, and embeddings.
        /// 
        ///  
        /// <para>
        /// For example code, see <i>Invoke model code examples</i> in the <i>Amazon Bedrock User
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModel</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeModel service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModel">REST API Reference for InvokeModel Operation</seealso>
        Task<InvokeModelResponse> InvokeModelAsync(InvokeModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InvokeModelWithResponseStream


        /// <summary>
        /// Invoke the specified Amazon Bedrock model to run inference using the prompt and inference
        /// parameters provided in the request body. The response is returned in a stream.
        /// 
        ///  
        /// <para>
        /// To see if a model supports streaming, call <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetFoundationModel.html">GetFoundationModel</a>
        /// and check the <c>responseStreamingSupported</c> field in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// The CLI doesn't support <c>InvokeModelWithResponseStream</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For example code, see <i>Invoke model with streaming code example</i> in the <i>Amazon
        /// Bedrock User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>bedrock:InvokeModelWithResponseStream</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModelWithResponseStream service method.</param>
        /// 
        /// <returns>The response from the InvokeModelWithResponseStream service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelStreamErrorException">
        /// An error occurred while streaming the response. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModelWithResponseStream">REST API Reference for InvokeModelWithResponseStream Operation</seealso>
        InvokeModelWithResponseStreamResponse InvokeModelWithResponseStream(InvokeModelWithResponseStreamRequest request);



        /// <summary>
        /// Invoke the specified Amazon Bedrock model to run inference using the prompt and inference
        /// parameters provided in the request body. The response is returned in a stream.
        /// 
        ///  
        /// <para>
        /// To see if a model supports streaming, call <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetFoundationModel.html">GetFoundationModel</a>
        /// and check the <c>responseStreamingSupported</c> field in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// The CLI doesn't support <c>InvokeModelWithResponseStream</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For example code, see <i>Invoke model with streaming code example</i> in the <i>Amazon
        /// Bedrock User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>bedrock:InvokeModelWithResponseStream</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModelWithResponseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeModelWithResponseStream service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelStreamErrorException">
        /// An error occurred while streaming the response. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModelWithResponseStream">REST API Reference for InvokeModelWithResponseStream Operation</seealso>
        Task<InvokeModelWithResponseStreamResponse> InvokeModelWithResponseStreamAsync(InvokeModelWithResponseStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

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