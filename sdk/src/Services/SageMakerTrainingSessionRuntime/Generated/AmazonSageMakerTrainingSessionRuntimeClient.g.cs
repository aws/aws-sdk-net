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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.SageMakerTrainingSessionRuntime.Model;
using Amazon.SageMakerTrainingSessionRuntime.Model.Internal.MarshallTransformations;
using Amazon.SageMakerTrainingSessionRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.SageMakerTrainingSessionRuntime
{
    /// <summary>
    /// <para>Implementation for accessing SageMakerTrainingSessionRuntime</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Amazon SageMaker Training Session Runtime provides APIs for executing training operations
    /// and sampling operations against a running training session. Use these APIs to submit
    /// asynchronous training steps (such as forward-backward passes, optimizer steps, and
    /// checkpoint saves) and to generate text samples from the model being trained.
    /// </summary>
    public partial class AmazonSageMakerTrainingSessionRuntimeClient : AmazonServiceClient, IAmazonSageMakerTrainingSessionRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerTrainingSessionRuntimeMetadata();
        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        public AmazonSageMakerTrainingSessionRuntimeClient() : base(new AmazonSageMakerTrainingSessionRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(RegionEndpoint region) : base(new AmazonSageMakerTrainingSessionRuntimeConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="config">The AmazonSageMakerTrainingSessionRuntimeClient Configuration Object</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(AmazonSageMakerTrainingSessionRuntimeConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerTrainingSessionRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerTrainingSessionRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Credentials and an
        /// AmazonSageMakerTrainingSessionRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerTrainingSessionRuntimeClient Configuration Object</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(AWSCredentials credentials, AmazonSageMakerTrainingSessionRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerTrainingSessionRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerTrainingSessionRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerTrainingSessionRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerTrainingSessionRuntimeClient Configuration Object</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerTrainingSessionRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerTrainingSessionRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerTrainingSessionRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerTrainingSessionRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerTrainingSessionRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerTrainingSessionRuntimeClient Configuration Object</param>
        public AmazonSageMakerTrainingSessionRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerTrainingSessionRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerTrainingSessionRuntimeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerTrainingSessionRuntimeAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

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
        public virtual ExecuteSamplingOperationResponse ExecuteSamplingOperation(ExecuteSamplingOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteSamplingOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteSamplingOperationResponseUnmarshaller.Instance;

            return Invoke<ExecuteSamplingOperationResponse>(request, options);
        }
#else
        internal virtual ExecuteSamplingOperationResponse ExecuteSamplingOperation(ExecuteSamplingOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteSamplingOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteSamplingOperationResponseUnmarshaller.Instance;

            return Invoke<ExecuteSamplingOperationResponse>(request, options);
        }
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
        public virtual Task<ExecuteSamplingOperationResponse> ExecuteSamplingOperationAsync(ExecuteSamplingOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteSamplingOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteSamplingOperationResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteSamplingOperationResponse>(request, options, cancellationToken);
        }

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
        public virtual ExecuteTrainingOperationResponse ExecuteTrainingOperation(ExecuteTrainingOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteTrainingOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteTrainingOperationResponseUnmarshaller.Instance;

            return Invoke<ExecuteTrainingOperationResponse>(request, options);
        }
#else
        internal virtual ExecuteTrainingOperationResponse ExecuteTrainingOperation(ExecuteTrainingOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteTrainingOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteTrainingOperationResponseUnmarshaller.Instance;

            return Invoke<ExecuteTrainingOperationResponse>(request, options);
        }
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
        public virtual Task<ExecuteTrainingOperationResponse> ExecuteTrainingOperationAsync(ExecuteTrainingOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteTrainingOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteTrainingOperationResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteTrainingOperationResponse>(request, options, cancellationToken);
        }

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
        public virtual GetSamplingOperationResultResponse GetSamplingOperationResult(GetSamplingOperationResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingOperationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingOperationResultResponseUnmarshaller.Instance;

            return Invoke<GetSamplingOperationResultResponse>(request, options);
        }
#else
        internal virtual GetSamplingOperationResultResponse GetSamplingOperationResult(GetSamplingOperationResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingOperationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingOperationResultResponseUnmarshaller.Instance;

            return Invoke<GetSamplingOperationResultResponse>(request, options);
        }
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
        public virtual Task<GetSamplingOperationResultResponse> GetSamplingOperationResultAsync(GetSamplingOperationResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingOperationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingOperationResultResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingOperationResultResponse>(request, options, cancellationToken);
        }

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
        public virtual GetTrainingOperationResultResponse GetTrainingOperationResult(GetTrainingOperationResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainingOperationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainingOperationResultResponseUnmarshaller.Instance;

            return Invoke<GetTrainingOperationResultResponse>(request, options);
        }
#else
        internal virtual GetTrainingOperationResultResponse GetTrainingOperationResult(GetTrainingOperationResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainingOperationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainingOperationResultResponseUnmarshaller.Instance;

            return Invoke<GetTrainingOperationResultResponse>(request, options);
        }
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
        public virtual Task<GetTrainingOperationResultResponse> GetTrainingOperationResultAsync(GetTrainingOperationResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrainingOperationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainingOperationResultResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrainingOperationResultResponse>(request, options, cancellationToken);
        }

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
        public virtual SampleTrainingSessionResponse SampleTrainingSession(SampleTrainingSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleTrainingSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleTrainingSessionResponseUnmarshaller.Instance;

            return Invoke<SampleTrainingSessionResponse>(request, options);
        }
#else
        internal virtual SampleTrainingSessionResponse SampleTrainingSession(SampleTrainingSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleTrainingSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleTrainingSessionResponseUnmarshaller.Instance;

            return Invoke<SampleTrainingSessionResponse>(request, options);
        }
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
        public virtual Task<SampleTrainingSessionResponse> SampleTrainingSessionAsync(SampleTrainingSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleTrainingSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleTrainingSessionResponseUnmarshaller.Instance;

            return InvokeAsync<SampleTrainingSessionResponse>(request, options, cancellationToken);
        }

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
        public virtual SampleTrainingSessionWithResponseStreamResponse SampleTrainingSessionWithResponseStream(SampleTrainingSessionWithResponseStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleTrainingSessionWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleTrainingSessionWithResponseStreamResponseUnmarshaller.Instance;

            return Invoke<SampleTrainingSessionWithResponseStreamResponse>(request, options);
        }
#else
        internal virtual SampleTrainingSessionWithResponseStreamResponse SampleTrainingSessionWithResponseStream(SampleTrainingSessionWithResponseStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleTrainingSessionWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleTrainingSessionWithResponseStreamResponseUnmarshaller.Instance;

            return Invoke<SampleTrainingSessionWithResponseStreamResponse>(request, options);
        }
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
        public virtual Task<SampleTrainingSessionWithResponseStreamResponse> SampleTrainingSessionWithResponseStreamAsync(SampleTrainingSessionWithResponseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleTrainingSessionWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleTrainingSessionWithResponseStreamResponseUnmarshaller.Instance;

            return InvokeAsync<SampleTrainingSessionWithResponseStreamResponse>(request, options, cancellationToken);
        }

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }
    }
}
