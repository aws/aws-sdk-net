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
using Amazon.SageMakerInferenceRouterRuntime.Model;

#pragma warning disable CS1570

namespace Amazon.SageMakerInferenceRouterRuntime
{
    /// <summary>
    /// <para>Interface for accessing SageMakerInferenceRouterRuntime</para>
    ///
    /// Amazon SageMaker Inference Router Runtime is the runtime API for Amazon SageMaker
    /// AI inference routers. An inference router sends each request that you make to one
    /// of the destinations of a routing target. A destination is a SageMaker AI endpoint
    /// or inference component, in your account or in another account, in the router's Amazon
    /// Web Services Region or in another Region in the same Amazon Web Services partition.
    /// The router chooses a healthy destination with capacity, and prefers destinations in
    /// its own Region.
    /// 
    ///  
    /// <para>
    /// Use <c>InvokeInferenceRouter</c> to get an inference in real time. Use <c>InvokeInferenceRouterAsync</c>
    /// to submit a request whose input and response are stored in Amazon S3.
    /// </para>
    ///  
    /// <para>
    /// The inference router runtime endpoint supports HTTP/1.1 only. HTTP/2 isn't supported.
    /// If you use the Amazon Web Services SDKs or the Amazon Web Services CLI, you don't
    /// need to change anything.
    /// </para>
    /// </summary>
    public partial interface IAmazonSageMakerInferenceRouterRuntime : IAmazonService, IDisposable
    {
#if NETFRAMEWORK
        /// <summary>
        /// Sends a real-time inference request to an inference router. In the request, you name
        /// the routing target, and the router sends the request to one of the routing target's
        /// destinations. The response includes the destination that served the request and the
        /// reason that the router chose it.
        /// 
        ///  
        /// <para>
        /// The following limits apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The maximum request payload is 6 MB. A request with a larger body fails with HTTP
        /// status code 413.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your model has up to 60 seconds for each attempt, the same limit as <c>InvokeEndpoint</c>.
        /// If your account has a higher model execution timeout for <c>InvokeEndpoint</c>, it
        /// doesn't apply through an inference router. For models that take longer, use <c>InvokeInferenceRouterAsync</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a destination returns an error that the router can retry, such as a throttling
        /// error, before your model produces a response, the router retries the request once
        /// on another destination. A request that times out on a destination isn't retried. Because
        /// a request can make two attempts, set your client read timeout to at least 170 seconds.
        /// </para>
        ///  
        /// <para>
        /// The caller needs permission to invoke the inference router and every destination of
        /// the routing target. For information about permissions, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router.html">Route
        /// requests across Regions with inference routers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeInferenceRouter service method.</param>
        /// <returns>The response from the InvokeInferenceRouter service method, as returned by SageMakerInferenceRouterRuntime.</returns>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.AccessDeniedException">
        /// You don't have permission to perform this action. Check that the caller is allowed
        /// to invoke the inference router and every destination of the routing target.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.InternalDependencyException">
        /// The request failed because of an error in an internal dependency. Retry the request
        /// with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.InternalFailureException">
        /// An internal error occurred. Retry the request with exponential backoff. The Amazon
        /// Web Services SDKs and the Amazon Web Services CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ModelErrorException">
        /// The model in the destination that served the request returned an error. Check <c>OriginalStatusCode</c>,
        /// <c>OriginalMessage</c>, and the destination's logs in Amazon CloudWatch.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ModelNotReadyException">
        /// The destination isn't ready to serve the model, for example because an inference component
        /// has no copies. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.RequestTimeoutException">
        /// The inference router didn't receive the complete request within 300 seconds of accepting
        /// it, for example because of a very slow upload. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. For example, no destination of the routing
        /// target could serve the request, or a destination didn't respond. Retry the request
        /// with exponential backoff. The Amazon Web Services SDKs and the Amazon Web Services
        /// CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ThrottlingException">
        /// The request was denied because you exceeded the request rate for the inference router,
        /// or because a destination throttled the request. Retry the request with exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ValidationException">
        /// The request isn't valid. Check the inference router name, the routing target name,
        /// and the request parameters, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-inference-router-runtime-2026-01-01/InvokeInferenceRouter">REST API Reference for InvokeInferenceRouter Operation</seealso>
        InvokeInferenceRouterResponse InvokeInferenceRouter(InvokeInferenceRouterRequest request);
#endif

        /// <summary>
        /// Sends a real-time inference request to an inference router. In the request, you name
        /// the routing target, and the router sends the request to one of the routing target's
        /// destinations. The response includes the destination that served the request and the
        /// reason that the router chose it.
        /// 
        ///  
        /// <para>
        /// The following limits apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The maximum request payload is 6 MB. A request with a larger body fails with HTTP
        /// status code 413.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your model has up to 60 seconds for each attempt, the same limit as <c>InvokeEndpoint</c>.
        /// If your account has a higher model execution timeout for <c>InvokeEndpoint</c>, it
        /// doesn't apply through an inference router. For models that take longer, use <c>InvokeInferenceRouterAsync</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a destination returns an error that the router can retry, such as a throttling
        /// error, before your model produces a response, the router retries the request once
        /// on another destination. A request that times out on a destination isn't retried. Because
        /// a request can make two attempts, set your client read timeout to at least 170 seconds.
        /// </para>
        ///  
        /// <para>
        /// The caller needs permission to invoke the inference router and every destination of
        /// the routing target. For information about permissions, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router.html">Route
        /// requests across Regions with inference routers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeInferenceRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InvokeInferenceRouter service method, as returned by SageMakerInferenceRouterRuntime.</returns>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.AccessDeniedException">
        /// You don't have permission to perform this action. Check that the caller is allowed
        /// to invoke the inference router and every destination of the routing target.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.InternalDependencyException">
        /// The request failed because of an error in an internal dependency. Retry the request
        /// with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.InternalFailureException">
        /// An internal error occurred. Retry the request with exponential backoff. The Amazon
        /// Web Services SDKs and the Amazon Web Services CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ModelErrorException">
        /// The model in the destination that served the request returned an error. Check <c>OriginalStatusCode</c>,
        /// <c>OriginalMessage</c>, and the destination's logs in Amazon CloudWatch.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ModelNotReadyException">
        /// The destination isn't ready to serve the model, for example because an inference component
        /// has no copies. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.RequestTimeoutException">
        /// The inference router didn't receive the complete request within 300 seconds of accepting
        /// it, for example because of a very slow upload. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. For example, no destination of the routing
        /// target could serve the request, or a destination didn't respond. Retry the request
        /// with exponential backoff. The Amazon Web Services SDKs and the Amazon Web Services
        /// CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ThrottlingException">
        /// The request was denied because you exceeded the request rate for the inference router,
        /// or because a destination throttled the request. Retry the request with exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ValidationException">
        /// The request isn't valid. Check the inference router name, the routing target name,
        /// and the request parameters, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-inference-router-runtime-2026-01-01/InvokeInferenceRouter">REST API Reference for InvokeInferenceRouter Operation</seealso>
        Task<InvokeInferenceRouterResponse> InvokeInferenceRouterAsync(InvokeInferenceRouterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Submits an asynchronous inference request to an inference router. Before you call
        /// this operation, upload the input data to Amazon S3 in the router's Amazon Web Services
        /// Region. The router returns as soon as it accepts the request, and sends the request
        /// to one of the destinations of the routing target. The destination reads the input
        /// from Amazon S3, and the inference response is written to the Amazon S3 output path
        /// that the routing target specifies.
        /// 
        ///  
        /// <para>
        /// If a destination doesn't start the request within the routing target's <c>MaxTimeInBacklogSeconds</c>,
        /// the router moves the request to another destination. After your model starts processing
        /// the request, the request doesn't move. If no destination can take the request before
        /// <c>RequestTTLSeconds</c> runs out, or every destination has been tried, the router
        /// writes a failure object to the <c>FailureLocation</c> and publishes a notification
        /// to the routing target's error topic, if one is configured.
        /// </para>
        ///  
        /// <para>
        /// For information about the permissions that the caller and each destination need, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router-async.html">Send
        /// asynchronous requests through an inference router</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeInferenceRouterAsync service method.</param>
        /// <returns>The response from the InvokeInferenceRouterAsync service method, as returned by SageMakerInferenceRouterRuntime.</returns>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.AccessDeniedException">
        /// You don't have permission to perform this action. Check that the caller is allowed
        /// to invoke the inference router and every destination of the routing target.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.InternalFailureException">
        /// An internal error occurred. Retry the request with exponential backoff. The Amazon
        /// Web Services SDKs and the Amazon Web Services CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.RequestTimeoutException">
        /// The inference router didn't receive the complete request within 300 seconds of accepting
        /// it, for example because of a very slow upload. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. For example, no destination of the routing
        /// target could serve the request, or a destination didn't respond. Retry the request
        /// with exponential backoff. The Amazon Web Services SDKs and the Amazon Web Services
        /// CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ThrottlingException">
        /// The request was denied because you exceeded the request rate for the inference router,
        /// or because a destination throttled the request. Retry the request with exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ValidationException">
        /// The request isn't valid. Check the inference router name, the routing target name,
        /// and the request parameters, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-inference-router-runtime-2026-01-01/InvokeInferenceRouterAsync">REST API Reference for InvokeInferenceRouterAsync Operation</seealso>
        InvokeInferenceRouterAsyncResponse InvokeInferenceRouterAsync(InvokeInferenceRouterAsyncRequest request);
#endif

        /// <summary>
        /// Submits an asynchronous inference request to an inference router. Before you call
        /// this operation, upload the input data to Amazon S3 in the router's Amazon Web Services
        /// Region. The router returns as soon as it accepts the request, and sends the request
        /// to one of the destinations of the routing target. The destination reads the input
        /// from Amazon S3, and the inference response is written to the Amazon S3 output path
        /// that the routing target specifies.
        /// 
        ///  
        /// <para>
        /// If a destination doesn't start the request within the routing target's <c>MaxTimeInBacklogSeconds</c>,
        /// the router moves the request to another destination. After your model starts processing
        /// the request, the request doesn't move. If no destination can take the request before
        /// <c>RequestTTLSeconds</c> runs out, or every destination has been tried, the router
        /// writes a failure object to the <c>FailureLocation</c> and publishes a notification
        /// to the routing target's error topic, if one is configured.
        /// </para>
        ///  
        /// <para>
        /// For information about the permissions that the caller and each destination need, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router-async.html">Send
        /// asynchronous requests through an inference router</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeInferenceRouterAsync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InvokeInferenceRouterAsync service method, as returned by SageMakerInferenceRouterRuntime.</returns>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.AccessDeniedException">
        /// You don't have permission to perform this action. Check that the caller is allowed
        /// to invoke the inference router and every destination of the routing target.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.InternalFailureException">
        /// An internal error occurred. Retry the request with exponential backoff. The Amazon
        /// Web Services SDKs and the Amazon Web Services CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.RequestTimeoutException">
        /// The inference router didn't receive the complete request within 300 seconds of accepting
        /// it, for example because of a very slow upload. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. For example, no destination of the routing
        /// target could serve the request, or a destination didn't respond. Retry the request
        /// with exponential backoff. The Amazon Web Services SDKs and the Amazon Web Services
        /// CLI do this by default.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ThrottlingException">
        /// The request was denied because you exceeded the request rate for the inference router,
        /// or because a destination throttled the request. Retry the request with exponential
        /// backoff.
        /// </exception>
        /// <exception cref="Amazon.SageMakerInferenceRouterRuntime.Model.ValidationException">
        /// The request isn't valid. Check the inference router name, the routing target name,
        /// and the request parameters, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-inference-router-runtime-2026-01-01/InvokeInferenceRouterAsync">REST API Reference for InvokeInferenceRouterAsync Operation</seealso>
        Task<InvokeInferenceRouterAsyncResponse> InvokeInferenceRouterAsyncAsync(InvokeInferenceRouterAsyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSageMakerInferenceRouterRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSageMakerInferenceRouterRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSageMakerInferenceRouterRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSageMakerInferenceRouterRuntimeConfig to create AmazonSageMakerInferenceRouterRuntimeClient");
            }

            return awsCredentials == null ?
                    new AmazonSageMakerInferenceRouterRuntimeClient(serviceClientConfig) :
                    new AmazonSageMakerInferenceRouterRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
