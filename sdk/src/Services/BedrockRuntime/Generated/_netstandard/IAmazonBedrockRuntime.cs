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
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockRuntimePaginatorFactory Paginators { get; }
#endif
                
        #region  ApplyGuardrail



        /// <summary>
        /// The action to apply a guardrail.
        /// 
        ///  
        /// <para>
        /// For troubleshooting some of the common errors you might encounter when using the <c>ApplyGuardrail</c>
        /// API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
        /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyGuardrail service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ApplyGuardrail">REST API Reference for ApplyGuardrail Operation</seealso>
        Task<ApplyGuardrailResponse> ApplyGuardrailAsync(ApplyGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Converse



        /// <summary>
        /// Sends messages to the specified Amazon Bedrock model. <c>Converse</c> provides a consistent
        /// interface that works with all models that support messages. This allows you to write
        /// code once and use it with different models. If a model has unique inference parameters,
        /// you can also pass those unique parameters to the model.
        /// 
        ///  
        /// <para>
        /// Amazon Bedrock doesn't store any text, images, or documents that you provide as content.
        /// The data is only used to generate the response.
        /// </para>
        ///  
        /// <para>
        /// You can submit a prompt by including it in the <c>messages</c> field, specifying the
        /// <c>modelId</c> of a foundation model or inference profile to run inference on it,
        /// and including any other fields that are relevant to your use case.
        /// </para>
        ///  
        /// <para>
        /// You can also submit a prompt from Prompt management by specifying the ARN of the prompt
        /// version and including a map of variables to values in the <c>promptVariables</c> field.
        /// You can append more messages to the prompt by using the <c>messages</c> field. If
        /// you use a prompt from Prompt management, you can't include the following fields in
        /// the request: <c>additionalModelRequestFields</c>, <c>inferenceConfig</c>, <c>system</c>,
        /// or <c>toolConfig</c>. Instead, these fields must be defined through Prompt management.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-use.html">Use
        /// a prompt from Prompt management</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the Converse API, see <i>Use the Converse API</i> in the <i>Amazon
        /// Bedrock User Guide</i>. To use a guardrail, see <i>Use a guardrail with the Converse
        /// API</i> in the <i>Amazon Bedrock User Guide</i>. To use a tool with a model, see <i>Tool
        /// use (Function calling)</i> in the <i>Amazon Bedrock User Guide</i> 
        /// </para>
        ///  
        /// <para>
        /// For example code, see <i>Converse API examples</i> in the <i>Amazon Bedrock User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModel</c> action. 
        /// </para>
        ///  <important> 
        /// <para>
        /// To deny all inference access to resources that you specify in the modelId field, you
        /// need to deny access to the <c>bedrock:InvokeModel</c> and <c>bedrock:InvokeModelWithResponseStream</c>
        /// actions. Doing this also denies access to the resource through the base inference
        /// actions (<a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_InvokeModel.html">InvokeModel</a>
        /// and <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_InvokeModelWithResponseStream.html">InvokeModelWithResponseStream</a>).
        /// For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-deny-inference">Deny
        /// access for inference on specific models</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For troubleshooting some of the common errors you might encounter when using the <c>Converse</c>
        /// API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
        /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Converse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Converse service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/Converse">REST API Reference for Converse Operation</seealso>
        Task<ConverseResponse> ConverseAsync(ConverseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConverseStream



        /// <summary>
        /// Sends messages to the specified Amazon Bedrock model and returns the response in a
        /// stream. <c>ConverseStream</c> provides a consistent API that works with all Amazon
        /// Bedrock models that support messages. This allows you to write code once and use it
        /// with different models. Should a model have unique inference parameters, you can also
        /// pass those unique parameters to the model. 
        /// 
        ///  
        /// <para>
        /// To find out if a model supports streaming, call <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetFoundationModel.html">GetFoundationModel</a>
        /// and check the <c>responseStreamingSupported</c> field in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>ConverseStream</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Amazon Bedrock doesn't store any text, images, or documents that you provide as content.
        /// The data is only used to generate the response.
        /// </para>
        ///  
        /// <para>
        /// You can submit a prompt by including it in the <c>messages</c> field, specifying the
        /// <c>modelId</c> of a foundation model or inference profile to run inference on it,
        /// and including any other fields that are relevant to your use case.
        /// </para>
        ///  
        /// <para>
        /// You can also submit a prompt from Prompt management by specifying the ARN of the prompt
        /// version and including a map of variables to values in the <c>promptVariables</c> field.
        /// You can append more messages to the prompt by using the <c>messages</c> field. If
        /// you use a prompt from Prompt management, you can't include the following fields in
        /// the request: <c>additionalModelRequestFields</c>, <c>inferenceConfig</c>, <c>system</c>,
        /// or <c>toolConfig</c>. Instead, these fields must be defined through Prompt management.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-use.html">Use
        /// a prompt from Prompt management</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the Converse API, see <i>Use the Converse API</i> in the <i>Amazon
        /// Bedrock User Guide</i>. To use a guardrail, see <i>Use a guardrail with the Converse
        /// API</i> in the <i>Amazon Bedrock User Guide</i>. To use a tool with a model, see <i>Tool
        /// use (Function calling)</i> in the <i>Amazon Bedrock User Guide</i> 
        /// </para>
        ///  
        /// <para>
        /// For example code, see <i>Conversation streaming example</i> in the <i>Amazon Bedrock
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModelWithResponseStream</c>
        /// action.
        /// </para>
        ///  <important> 
        /// <para>
        /// To deny all inference access to resources that you specify in the modelId field, you
        /// need to deny access to the <c>bedrock:InvokeModel</c> and <c>bedrock:InvokeModelWithResponseStream</c>
        /// actions. Doing this also denies access to the resource through the base inference
        /// actions (<a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_InvokeModel.html">InvokeModel</a>
        /// and <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_InvokeModelWithResponseStream.html">InvokeModelWithResponseStream</a>).
        /// For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-deny-inference">Deny
        /// access for inference on specific models</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For troubleshooting some of the common errors you might encounter when using the <c>ConverseStream</c>
        /// API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
        /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConverseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConverseStream service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ConverseStream">REST API Reference for ConverseStream Operation</seealso>
        Task<ConverseStreamResponse> ConverseStreamAsync(ConverseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CountTokens



        /// <summary>
        /// Returns the token count for a given inference request. This operation helps you estimate
        /// token usage before sending requests to foundation models by returning the token count
        /// that would be used if the same input were sent to the model in an inference request.
        /// 
        ///  
        /// <para>
        /// Token counting is model-specific because different models use different tokenization
        /// strategies. The token count returned by this operation will match the token count
        /// that would be charged if the same input were sent to the model in an <c>InvokeModel</c>
        /// or <c>Converse</c> request.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Estimate costs before sending inference requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optimize prompts to fit within token limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Plan for token usage in your applications.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation accepts the same input formats as <c>InvokeModel</c> and <c>Converse</c>,
        /// allowing you to count tokens for both raw text inputs and structured conversation
        /// formats.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>CountTokens</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/API/API_runtime_InvokeModel.html">InvokeModel</a>
        /// - Sends inference requests to foundation models
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/API/API_runtime_Converse.html">Converse</a>
        /// - Sends conversation-based inference requests to foundation models
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CountTokens service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/CountTokens">REST API Reference for CountTokens Operation</seealso>
        Task<CountTokensResponse> CountTokensAsync(CountTokensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAsyncInvoke



        /// <summary>
        /// Retrieve information about an asynchronous invocation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsyncInvoke service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAsyncInvoke service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/GetAsyncInvoke">REST API Reference for GetAsyncInvoke Operation</seealso>
        Task<GetAsyncInvokeResponse> GetAsyncInvokeAsync(GetAsyncInvokeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
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
        ///  <important> 
        /// <para>
        /// To deny all inference access to resources that you specify in the modelId field, you
        /// need to deny access to the <c>bedrock:InvokeModel</c> and <c>bedrock:InvokeModelWithResponseStream</c>
        /// actions. Doing this also denies access to the resource through the Converse API actions
        /// (<a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
        /// and <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>).
        /// For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-deny-inference">Deny
        /// access for inference on specific models</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For troubleshooting some of the common errors you might encounter when using the <c>InvokeModel</c>
        /// API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
        /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeModel service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModel">REST API Reference for InvokeModel Operation</seealso>
        Task<InvokeModelResponse> InvokeModelAsync(InvokeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InvokeModelWithBidirectionalStream

#if NET8_0_OR_GREATER


        /// <summary>
        /// Invoke the specified Amazon Bedrock model to run inference using the bidirectional
        /// stream. The response is returned in a stream that remains open for 8 minutes. A single
        /// session can contain multiple prompts and responses from the model. The prompts to
        /// the model are provided as audio files and the model's responses are spoken back to
        /// the user and transcribed.
        /// 
        ///  
        /// <para>
        /// It is possible for users to interrupt the model's response with a new prompt, which
        /// will halt the response speech. The model will retain contextual awareness of the conversation
        /// while pivoting to respond to the new prompt.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModelWithBidirectionalStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeModelWithBidirectionalStream service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelStreamErrorException">
        /// An error occurred while streaming the response. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModelWithBidirectionalStream">REST API Reference for InvokeModelWithBidirectionalStream Operation</seealso>
        Task<InvokeModelWithBidirectionalStreamResponse> InvokeModelWithBidirectionalStreamAsync(InvokeModelWithBidirectionalStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

#endif
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
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeModelWithResponseStream</c>.
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
        ///  <important> 
        /// <para>
        /// To deny all inference access to resources that you specify in the modelId field, you
        /// need to deny access to the <c>bedrock:InvokeModel</c> and <c>bedrock:InvokeModelWithResponseStream</c>
        /// actions. Doing this also denies access to the resource through the Converse API actions
        /// (<a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
        /// and <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>).
        /// For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-deny-inference">Deny
        /// access for inference on specific models</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For troubleshooting some of the common errors you might encounter when using the <c>InvokeModelWithResponseStream</c>
        /// API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
        /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModelWithResponseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeModelWithResponseStream service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelStreamErrorException">
        /// An error occurred while streaming the response. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModelWithResponseStream">REST API Reference for InvokeModelWithResponseStream Operation</seealso>
        Task<InvokeModelWithResponseStreamResponse> InvokeModelWithResponseStreamAsync(InvokeModelWithResponseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAsyncInvokes



        /// <summary>
        /// Lists asynchronous invocations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAsyncInvokes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAsyncInvokes service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ListAsyncInvokes">REST API Reference for ListAsyncInvokes Operation</seealso>
        Task<ListAsyncInvokesResponse> ListAsyncInvokesAsync(ListAsyncInvokesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartAsyncInvoke



        /// <summary>
        /// Starts an asynchronous invocation.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModel</c> action.
        /// </para>
        ///  <important> 
        /// <para>
        /// To deny all inference access to resources that you specify in the modelId field, you
        /// need to deny access to the <c>bedrock:InvokeModel</c> and <c>bedrock:InvokeModelWithResponseStream</c>
        /// actions. Doing this also denies access to the resource through the Converse API actions
        /// (<a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
        /// and <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>).
        /// For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-deny-inference">Deny
        /// access for inference on specific models</a>. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAsyncInvoke service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAsyncInvoke service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because you do not have sufficient permissions to perform the
        /// requested action. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-access-denied">AccessDeniedException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-internal-failure">InternalFailure</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-resource-not-found">ResourceNotFound</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-service-unavailable">ServiceUnavailable</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was denied due to exceeding the account quotas for <i>Amazon Bedrock</i>.
        /// For troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-throttling-exception">ThrottlingException</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by <i>Amazon Bedrock</i>. For
        /// troubleshooting this error, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html#ts-validation-error">ValidationError</a>
        /// in the Amazon Bedrock User Guide
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/StartAsyncInvoke">REST API Reference for StartAsyncInvoke Operation</seealso>
        Task<StartAsyncInvokeResponse> StartAsyncInvokeAsync(StartAsyncInvokeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonBedrockRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonBedrockRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonBedrockRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonBedrockRuntimeConfig to create AmazonBedrockRuntimeClient");
            }

            return awsCredentials == null ? 
                    new AmazonBedrockRuntimeClient(serviceClientConfig) :
                    new AmazonBedrockRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}