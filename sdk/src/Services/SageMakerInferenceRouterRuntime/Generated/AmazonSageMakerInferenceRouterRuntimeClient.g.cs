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
using Amazon.SageMakerInferenceRouterRuntime.Model;
using Amazon.SageMakerInferenceRouterRuntime.Model.Internal.MarshallTransformations;
using Amazon.SageMakerInferenceRouterRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.SageMakerInferenceRouterRuntime
{
    /// <summary>
    /// <para>Implementation for accessing SageMakerInferenceRouterRuntime</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
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
    public partial class AmazonSageMakerInferenceRouterRuntimeClient : AmazonServiceClient, IAmazonSageMakerInferenceRouterRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerInferenceRouterRuntimeMetadata();
        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with the credentials loaded from the application's
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
        public AmazonSageMakerInferenceRouterRuntimeClient() : base(new AmazonSageMakerInferenceRouterRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with the credentials loaded from the application's
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
        public AmazonSageMakerInferenceRouterRuntimeClient(RegionEndpoint region) : base(new AmazonSageMakerInferenceRouterRuntimeConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerInferenceRouterRuntimeClient Configuration Object</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(AmazonSageMakerInferenceRouterRuntimeConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerInferenceRouterRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerInferenceRouterRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Credentials and an
        /// AmazonSageMakerInferenceRouterRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerInferenceRouterRuntimeClient Configuration Object</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(AWSCredentials credentials, AmazonSageMakerInferenceRouterRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerInferenceRouterRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerInferenceRouterRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerInferenceRouterRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerInferenceRouterRuntimeClient Configuration Object</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerInferenceRouterRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerInferenceRouterRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerInferenceRouterRuntimeConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerInferenceRouterRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerInferenceRouterRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerInferenceRouterRuntimeClient Configuration Object</param>
        public AmazonSageMakerInferenceRouterRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerInferenceRouterRuntimeConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerInferenceRouterRuntimeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerInferenceRouterRuntimeAuthSchemeHandler());
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
        public virtual InvokeInferenceRouterResponse InvokeInferenceRouter(InvokeInferenceRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeInferenceRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInferenceRouterResponseUnmarshaller.Instance;

            return Invoke<InvokeInferenceRouterResponse>(request, options);
        }
#else
        internal virtual InvokeInferenceRouterResponse InvokeInferenceRouter(InvokeInferenceRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeInferenceRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInferenceRouterResponseUnmarshaller.Instance;

            return Invoke<InvokeInferenceRouterResponse>(request, options);
        }
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
        public virtual Task<InvokeInferenceRouterResponse> InvokeInferenceRouterAsync(InvokeInferenceRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeInferenceRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInferenceRouterResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeInferenceRouterResponse>(request, options, cancellationToken);
        }

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
        public virtual InvokeInferenceRouterAsyncResponse InvokeInferenceRouterAsync(InvokeInferenceRouterAsyncRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeInferenceRouterAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInferenceRouterAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeInferenceRouterAsyncResponse>(request, options);
        }
#else
        internal virtual InvokeInferenceRouterAsyncResponse InvokeInferenceRouterAsync(InvokeInferenceRouterAsyncRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeInferenceRouterAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInferenceRouterAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeInferenceRouterAsyncResponse>(request, options);
        }
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
        public virtual Task<InvokeInferenceRouterAsyncResponse> InvokeInferenceRouterAsyncAsync(InvokeInferenceRouterAsyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeInferenceRouterAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeInferenceRouterAsyncResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeInferenceRouterAsyncResponse>(request, options, cancellationToken);
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
