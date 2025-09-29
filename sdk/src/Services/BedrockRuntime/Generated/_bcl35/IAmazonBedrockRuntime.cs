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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        ApplyGuardrailResponse ApplyGuardrail(ApplyGuardrailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyGuardrail operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ApplyGuardrail">REST API Reference for ApplyGuardrail Operation</seealso>
        IAsyncResult BeginApplyGuardrail(ApplyGuardrailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ApplyGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplyGuardrail.</param>
        /// 
        /// <returns>Returns a  ApplyGuardrailResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ApplyGuardrail">REST API Reference for ApplyGuardrail Operation</seealso>
        ApplyGuardrailResponse EndApplyGuardrail(IAsyncResult asyncResult);

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
        ConverseResponse Converse(ConverseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Converse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Converse operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConverse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/Converse">REST API Reference for Converse Operation</seealso>
        IAsyncResult BeginConverse(ConverseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Converse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConverse.</param>
        /// 
        /// <returns>Returns a  ConverseResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/Converse">REST API Reference for Converse Operation</seealso>
        ConverseResponse EndConverse(IAsyncResult asyncResult);

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
        ConverseStreamResponse ConverseStream(ConverseStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConverseStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConverseStream operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConverseStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ConverseStream">REST API Reference for ConverseStream Operation</seealso>
        IAsyncResult BeginConverseStream(ConverseStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConverseStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConverseStream.</param>
        /// 
        /// <returns>Returns a  ConverseStreamResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ConverseStream">REST API Reference for ConverseStream Operation</seealso>
        ConverseStreamResponse EndConverseStream(IAsyncResult asyncResult);

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
        CountTokensResponse CountTokens(CountTokensRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CountTokens operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountTokens operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountTokens
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/CountTokens">REST API Reference for CountTokens Operation</seealso>
        IAsyncResult BeginCountTokens(CountTokensRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CountTokens operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountTokens.</param>
        /// 
        /// <returns>Returns a  CountTokensResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/CountTokens">REST API Reference for CountTokens Operation</seealso>
        CountTokensResponse EndCountTokens(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAsyncInvoke


        /// <summary>
        /// Retrieve information about an asynchronous invocation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsyncInvoke service method.</param>
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
        GetAsyncInvokeResponse GetAsyncInvoke(GetAsyncInvokeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAsyncInvoke operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAsyncInvoke operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAsyncInvoke
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/GetAsyncInvoke">REST API Reference for GetAsyncInvoke Operation</seealso>
        IAsyncResult BeginGetAsyncInvoke(GetAsyncInvokeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAsyncInvoke operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAsyncInvoke.</param>
        /// 
        /// <returns>Returns a  GetAsyncInvokeResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/GetAsyncInvoke">REST API Reference for GetAsyncInvoke Operation</seealso>
        GetAsyncInvokeResponse EndGetAsyncInvoke(IAsyncResult asyncResult);

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
        InvokeModelResponse InvokeModel(InvokeModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeModel operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModel">REST API Reference for InvokeModel Operation</seealso>
        IAsyncResult BeginInvokeModel(InvokeModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeModel.</param>
        /// 
        /// <returns>Returns a  InvokeModelResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModel">REST API Reference for InvokeModel Operation</seealso>
        InvokeModelResponse EndInvokeModel(IAsyncResult asyncResult);

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
        InvokeModelWithResponseStreamResponse InvokeModelWithResponseStream(InvokeModelWithResponseStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeModelWithResponseStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeModelWithResponseStream operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeModelWithResponseStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModelWithResponseStream">REST API Reference for InvokeModelWithResponseStream Operation</seealso>
        IAsyncResult BeginInvokeModelWithResponseStream(InvokeModelWithResponseStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeModelWithResponseStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeModelWithResponseStream.</param>
        /// 
        /// <returns>Returns a  InvokeModelWithResponseStreamResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModelWithResponseStream">REST API Reference for InvokeModelWithResponseStream Operation</seealso>
        InvokeModelWithResponseStreamResponse EndInvokeModelWithResponseStream(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAsyncInvokes


        /// <summary>
        /// Lists asynchronous invocations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAsyncInvokes service method.</param>
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
        ListAsyncInvokesResponse ListAsyncInvokes(ListAsyncInvokesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAsyncInvokes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAsyncInvokes operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAsyncInvokes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ListAsyncInvokes">REST API Reference for ListAsyncInvokes Operation</seealso>
        IAsyncResult BeginListAsyncInvokes(ListAsyncInvokesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAsyncInvokes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAsyncInvokes.</param>
        /// 
        /// <returns>Returns a  ListAsyncInvokesResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ListAsyncInvokes">REST API Reference for ListAsyncInvokes Operation</seealso>
        ListAsyncInvokesResponse EndListAsyncInvokes(IAsyncResult asyncResult);

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
        StartAsyncInvokeResponse StartAsyncInvoke(StartAsyncInvokeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAsyncInvoke operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAsyncInvoke operation on AmazonBedrockRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAsyncInvoke
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/StartAsyncInvoke">REST API Reference for StartAsyncInvoke Operation</seealso>
        IAsyncResult BeginStartAsyncInvoke(StartAsyncInvokeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAsyncInvoke operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAsyncInvoke.</param>
        /// 
        /// <returns>Returns a  StartAsyncInvokeResult from BedrockRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/StartAsyncInvoke">REST API Reference for StartAsyncInvoke Operation</seealso>
        StartAsyncInvokeResponse EndStartAsyncInvoke(IAsyncResult asyncResult);

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