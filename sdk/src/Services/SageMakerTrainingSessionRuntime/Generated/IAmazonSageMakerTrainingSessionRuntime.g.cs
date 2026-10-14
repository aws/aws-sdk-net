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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.SageMakerTrainingSessionRuntime.Model;

#pragma warning disable CS1570

namespace Amazon.SageMakerTrainingSessionRuntime
{
    /// <summary>
    /// <para>Interface for accessing SageMakerTrainingSessionRuntime</para>
    ///
    /// Amazon SageMaker Training Session Runtime provides APIs for executing training operations
    /// and sampling operations against a running training session. Use these APIs to submit
    /// asynchronous training steps (such as forward-backward passes, optimizer steps, and
    /// checkpoint saves) and to generate text samples from the model being trained.
    /// </summary>
    public partial interface IAmazonSageMakerTrainingSessionRuntime : IAmazonService, IDisposable
    {
#if NETFRAMEWORK
        /// <summary>
        /// Submits an asynchronous sampling operation to generate text or compute log-probabilities
        /// from the model associated with the specified training session. The session must be
        /// in <c>Running</c> or <c>Blocked</c> state. Use <c>GetSamplingOperationResult</c> to
        /// poll for the result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSamplingOperation service method.</param>
        /// <returns>The response from the ExecuteSamplingOperation service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/ExecuteSamplingOperation">REST API Reference for ExecuteSamplingOperation Operation</seealso>
        ExecuteSamplingOperationResponse ExecuteSamplingOperation(ExecuteSamplingOperationRequest request);
#endif

        /// <summary>
        /// Submits an asynchronous sampling operation to generate text or compute log-probabilities
        /// from the model associated with the specified training session. The session must be
        /// in <c>Running</c> or <c>Blocked</c> state. Use <c>GetSamplingOperationResult</c> to
        /// poll for the result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSamplingOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ExecuteSamplingOperation service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/ExecuteSamplingOperation">REST API Reference for ExecuteSamplingOperation Operation</seealso>
        Task<ExecuteSamplingOperationResponse> ExecuteSamplingOperationAsync(ExecuteSamplingOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Submits an asynchronous training operation to the specified training session. The
        /// service executes operations in sequence number order. The session must be in <c>Running</c>
        /// or <c>Blocked</c> state. Use <c>GetTrainingOperationResult</c> to poll for the result.
        /// Supported operation types: <c>forward</c>, <c>forwardBackward</c>, <c>optimizerStep</c>,
        /// <c>saveWeights</c>, <c>saveState</c>, and <c>loadState</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteTrainingOperation service method.</param>
        /// <returns>The response from the ExecuteTrainingOperation service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/ExecuteTrainingOperation">REST API Reference for ExecuteTrainingOperation Operation</seealso>
        ExecuteTrainingOperationResponse ExecuteTrainingOperation(ExecuteTrainingOperationRequest request);
#endif

        /// <summary>
        /// Submits an asynchronous training operation to the specified training session. The
        /// service executes operations in sequence number order. The session must be in <c>Running</c>
        /// or <c>Blocked</c> state. Use <c>GetTrainingOperationResult</c> to poll for the result.
        /// Supported operation types: <c>forward</c>, <c>forwardBackward</c>, <c>optimizerStep</c>,
        /// <c>saveWeights</c>, <c>saveState</c>, and <c>loadState</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteTrainingOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ExecuteTrainingOperation service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/ExecuteTrainingOperation">REST API Reference for ExecuteTrainingOperation Operation</seealso>
        Task<ExecuteTrainingOperationResponse> ExecuteTrainingOperationAsync(ExecuteTrainingOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current status and result of a previously submitted sampling operation.
        /// Poll this operation until the status reaches a terminal state (Completed or Failed).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingOperationResult service method.</param>
        /// <returns>The response from the GetSamplingOperationResult service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/GetSamplingOperationResult">REST API Reference for GetSamplingOperationResult Operation</seealso>
        GetSamplingOperationResultResponse GetSamplingOperationResult(GetSamplingOperationResultRequest request);
#endif

        /// <summary>
        /// Retrieves the current status and result of a previously submitted sampling operation.
        /// Poll this operation until the status reaches a terminal state (Completed or Failed).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingOperationResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSamplingOperationResult service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/GetSamplingOperationResult">REST API Reference for GetSamplingOperationResult Operation</seealso>
        Task<GetSamplingOperationResultResponse> GetSamplingOperationResultAsync(GetSamplingOperationResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current status and result of a previously submitted training operation.
        /// Poll this operation until the status reaches a terminal state (Completed, Failed,
        /// or Skipped).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrainingOperationResult service method.</param>
        /// <returns>The response from the GetTrainingOperationResult service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/GetTrainingOperationResult">REST API Reference for GetTrainingOperationResult Operation</seealso>
        GetTrainingOperationResultResponse GetTrainingOperationResult(GetTrainingOperationResultRequest request);
#endif

        /// <summary>
        /// Retrieves the current status and result of a previously submitted training operation.
        /// Poll this operation until the status reaches a terminal state (Completed, Failed,
        /// or Skipped).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrainingOperationResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetTrainingOperationResult service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/GetTrainingOperationResult">REST API Reference for GetTrainingOperationResult Operation</seealso>
        Task<GetTrainingOperationResultResponse> GetTrainingOperationResultAsync(GetTrainingOperationResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Sends an inference request to the model associated with the specified training session
        /// and returns the response synchronously. The service passes the request and response
        /// bodies to and from the model without modification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleTrainingSession service method.</param>
        /// <returns>The response from the SampleTrainingSession service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/SampleTrainingSession">REST API Reference for SampleTrainingSession Operation</seealso>
        SampleTrainingSessionResponse SampleTrainingSession(SampleTrainingSessionRequest request);
#endif

        /// <summary>
        /// Sends an inference request to the model associated with the specified training session
        /// and returns the response synchronously. The service passes the request and response
        /// bodies to and from the model without modification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleTrainingSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SampleTrainingSession service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/SampleTrainingSession">REST API Reference for SampleTrainingSession Operation</seealso>
        Task<SampleTrainingSessionResponse> SampleTrainingSessionAsync(SampleTrainingSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Streams inference responses from the model associated with the specified training
        /// session. Use this operation for real-time token-by-token generation. The service passes
        /// the request body to the model without modification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleTrainingSessionWithResponseStream service method.</param>
        /// <returns>The response from the SampleTrainingSessionWithResponseStream service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/SampleTrainingSessionWithResponseStream">REST API Reference for SampleTrainingSessionWithResponseStream Operation</seealso>
        SampleTrainingSessionWithResponseStreamResponse SampleTrainingSessionWithResponseStream(SampleTrainingSessionWithResponseStreamRequest request);
#endif

        /// <summary>
        /// Streams inference responses from the model associated with the specified training
        /// session. Use this operation for real-time token-by-token generation. The service passes
        /// the request body to the model without modification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleTrainingSessionWithResponseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SampleTrainingSessionWithResponseStream service method, as returned by SageMakerTrainingSessionRuntime.</returns>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ConflictException">
        /// The training session is in a state that cannot accept new operations. The session
        /// must be in <c>Running</c> or <c>Blocked</c> state to accept requests.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.InternalServerException">
        /// An internal service error occurred. Retry the request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ResourceNotFoundException">
        /// The specified training session or operation does not exist, or the operation does
        /// not belong to the specified training session.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ThrottlingException">
        /// The request was throttled. Retry the request after a brief wait using exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerTrainingSessionRuntime.Model.ValidationException">
        /// The request is not valid. Check the request syntax and parameters. Examples include
        /// invalid sequence numbers, malformed client tokens, missing required fields, or invalid
        /// operation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemakertrainingsessionruntime-2025-02-10/SampleTrainingSessionWithResponseStream">REST API Reference for SampleTrainingSessionWithResponseStream Operation</seealso>
        Task<SampleTrainingSessionWithResponseStreamResponse> SampleTrainingSessionWithResponseStreamAsync(SampleTrainingSessionWithResponseStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSageMakerTrainingSessionRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSageMakerTrainingSessionRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSageMakerTrainingSessionRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSageMakerTrainingSessionRuntimeConfig to create AmazonSageMakerTrainingSessionRuntimeClient");
            }

            return awsCredentials == null ?
                    new AmazonSageMakerTrainingSessionRuntimeClient(serviceClientConfig) :
                    new AmazonSageMakerTrainingSessionRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
