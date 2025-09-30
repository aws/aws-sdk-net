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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMakerRuntime.Model;
using Amazon.SageMakerRuntime.Model.Internal.MarshallTransformations;
using Amazon.SageMakerRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SageMakerRuntime
{
    /// <summary>
    /// <para>Implementation for accessing SageMakerRuntime</para>
    ///
    /// The Amazon SageMaker runtime API.
    /// </summary>
    public partial class AmazonSageMakerRuntimeClient : AmazonServiceClient, IAmazonSageMakerRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerRuntimeMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with the credentials loaded from the application's
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
        public AmazonSageMakerRuntimeClient()
            : base(new AmazonSageMakerRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with the credentials loaded from the application's
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
        public AmazonSageMakerRuntimeClient(RegionEndpoint region)
            : base(new AmazonSageMakerRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerRuntimeClient Configuration Object</param>
        public AmazonSageMakerRuntimeClient(AmazonSageMakerRuntimeConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Credentials and an
        /// AmazonSageMakerRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeClient Configuration Object</param>
        public AmazonSageMakerRuntimeClient(AWSCredentials credentials, AmazonSageMakerRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeClient Configuration Object</param>
        public AmazonSageMakerRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeClient Configuration Object</param>
        public AmazonSageMakerRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerRuntimeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerRuntimeAuthSchemeHandler());
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

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  InvokeEndpoint


        /// <summary>
        /// After you deploy a model into production using Amazon SageMaker hosting services,
        /// your client applications use this API to get inferences from the model hosted at the
        /// specified endpoint. 
        /// 
        ///  
        /// <para>
        /// For an overview of Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
        /// SageMaker might add additional headers. You should not rely on the behavior of headers
        /// outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpoint</c> are authenticated by using Amazon Web Services Signature
        /// Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// A customer's model containers must respond to requests within 60 seconds. The model
        /// itself can have a maximum processing time of 60 seconds before responding to invocations.
        /// If your model is going to take 50-60 seconds of processing time, the SDK socket timeout
        /// should be set to be 70 seconds.
        /// </para>
        ///  <note> 
        /// <para>
        /// Endpoints are scoped to an individual account, and are not public. The URL does not
        /// contain the account ID, but Amazon SageMaker determines the account ID from the authentication
        /// token that is supplied by the caller.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpoint service method.</param>
        /// 
        /// <returns>The response from the InvokeEndpoint service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalDependencyException">
        /// Your request caused an exception with an internal dependency. Contact customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelErrorException">
        /// Model (owned by the customer in the container) returned 4xx or 5xx error code.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelNotReadyException">
        /// Either a serverless endpoint variant's resources are still being provisioned, or a
        /// multi-model endpoint is still downloading or loading the target model. Wait and try
        /// your request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpoint">REST API Reference for InvokeEndpoint Operation</seealso>
        public virtual InvokeEndpointResponse InvokeEndpoint(InvokeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointResponseUnmarshaller.Instance;

            return Invoke<InvokeEndpointResponse>(request, options);
        }


        /// <summary>
        /// After you deploy a model into production using Amazon SageMaker hosting services,
        /// your client applications use this API to get inferences from the model hosted at the
        /// specified endpoint. 
        /// 
        ///  
        /// <para>
        /// For an overview of Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
        /// SageMaker might add additional headers. You should not rely on the behavior of headers
        /// outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpoint</c> are authenticated by using Amazon Web Services Signature
        /// Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// A customer's model containers must respond to requests within 60 seconds. The model
        /// itself can have a maximum processing time of 60 seconds before responding to invocations.
        /// If your model is going to take 50-60 seconds of processing time, the SDK socket timeout
        /// should be set to be 70 seconds.
        /// </para>
        ///  <note> 
        /// <para>
        /// Endpoints are scoped to an individual account, and are not public. The URL does not
        /// contain the account ID, but Amazon SageMaker determines the account ID from the authentication
        /// token that is supplied by the caller.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeEndpoint service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalDependencyException">
        /// Your request caused an exception with an internal dependency. Contact customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelErrorException">
        /// Model (owned by the customer in the container) returned 4xx or 5xx error code.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelNotReadyException">
        /// Either a serverless endpoint variant's resources are still being provisioned, or a
        /// multi-model endpoint is still downloading or loading the target model. Wait and try
        /// your request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpoint">REST API Reference for InvokeEndpoint Operation</seealso>
        public virtual Task<InvokeEndpointResponse> InvokeEndpointAsync(InvokeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<InvokeEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeEndpointAsync


        /// <summary>
        /// After you deploy a model into production using Amazon SageMaker hosting services,
        /// your client applications use this API to get inferences from the model hosted at the
        /// specified endpoint in an asynchronous manner.
        /// 
        ///  
        /// <para>
        /// Inference requests sent to this API are enqueued for asynchronous processing. The
        /// processing of the inference request may or may not complete before you receive a response
        /// from this API. The response from this API will not contain the result of the inference
        /// request but contain information about where you can locate it.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
        /// SageMaker might add additional headers. You should not rely on the behavior of headers
        /// outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpointAsync</c> are authenticated by using Amazon Web Services
        /// Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeEndpointAsync service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpointAsync">REST API Reference for InvokeEndpointAsync Operation</seealso>
        public virtual InvokeEndpointAsyncResponse InvokeEndpointAsync(InvokeEndpointAsyncRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeEndpointAsyncResponse>(request, options);
        }


        /// <summary>
        /// After you deploy a model into production using Amazon SageMaker hosting services,
        /// your client applications use this API to get inferences from the model hosted at the
        /// specified endpoint in an asynchronous manner.
        /// 
        ///  
        /// <para>
        /// Inference requests sent to this API are enqueued for asynchronous processing. The
        /// processing of the inference request may or may not complete before you receive a response
        /// from this API. The response from this API will not contain the result of the inference
        /// request but contain information about where you can locate it.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
        /// SageMaker might add additional headers. You should not rely on the behavior of headers
        /// outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpointAsync</c> are authenticated by using Amazon Web Services
        /// Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointAsync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeEndpointAsync service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpointAsync">REST API Reference for InvokeEndpointAsync Operation</seealso>
        public virtual Task<InvokeEndpointAsyncResponse> InvokeEndpointAsyncAsync(InvokeEndpointAsyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointAsyncResponseUnmarshaller.Instance;
            
            return InvokeAsync<InvokeEndpointAsyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeEndpointWithResponseStream


        /// <summary>
        /// Invokes a model at the specified endpoint to return the inference response as a stream.
        /// The inference stream provides the response payload incrementally as a series of parts.
        /// Before you can get an inference stream, you must have access to a model that's deployed
        /// using Amazon SageMaker hosting services, and the container for that model must support
        /// inference streaming.
        /// 
        ///  
        /// <para>
        /// For more information that can help you use this API, see the following sections in
        /// the <i>Amazon SageMaker Developer Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For information about how to add streaming support to a model, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-code-how-containe-serves-requests">How
        /// Containers Serve Requests</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to process the streaming response, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/realtime-endpoints-test-endpoints.html">Invoke
        /// real-time endpoints</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you can use this operation, your IAM permissions must allow the <c>sagemaker:InvokeEndpoint</c>
        /// action. For more information about Amazon SageMaker actions for IAM policies, see
        /// <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonsagemaker.html">Actions,
        /// resources, and condition keys for Amazon SageMaker</a> in the <i>IAM Service Authorization
        /// Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
        /// SageMaker might add additional headers. You should not rely on the behavior of headers
        /// outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpointWithResponseStream</c> are authenticated by using Amazon
        /// Web Services Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointWithResponseStream service method.</param>
        /// 
        /// <returns>The response from the InvokeEndpointWithResponseStream service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalStreamFailureException">
        /// The stream processing failed because of an unknown error, exception or failure. Try
        /// your request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelErrorException">
        /// Model (owned by the customer in the container) returned 4xx or 5xx error code.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelStreamErrorException">
        /// An error occurred while streaming the response body. This error can have the following
        /// error codes:
        /// 
        ///  <dl> <dt>ModelInvocationTimeExceeded</dt> <dd> 
        /// <para>
        /// The model failed to finish sending the response within the timeout period allowed
        /// by Amazon SageMaker.
        /// </para>
        ///  </dd> <dt>StreamBroken</dt> <dd> 
        /// <para>
        /// The Transmission Control Protocol (TCP) connection between the client and the model
        /// was reset or closed.
        /// </para>
        ///  </dd> </dl>
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpointWithResponseStream">REST API Reference for InvokeEndpointWithResponseStream Operation</seealso>
        public virtual InvokeEndpointWithResponseStreamResponse InvokeEndpointWithResponseStream(InvokeEndpointWithResponseStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointWithResponseStreamResponseUnmarshaller.Instance;

            return Invoke<InvokeEndpointWithResponseStreamResponse>(request, options);
        }


        /// <summary>
        /// Invokes a model at the specified endpoint to return the inference response as a stream.
        /// The inference stream provides the response payload incrementally as a series of parts.
        /// Before you can get an inference stream, you must have access to a model that's deployed
        /// using Amazon SageMaker hosting services, and the container for that model must support
        /// inference streaming.
        /// 
        ///  
        /// <para>
        /// For more information that can help you use this API, see the following sections in
        /// the <i>Amazon SageMaker Developer Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For information about how to add streaming support to a model, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-code-how-containe-serves-requests">How
        /// Containers Serve Requests</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to process the streaming response, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/realtime-endpoints-test-endpoints.html">Invoke
        /// real-time endpoints</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you can use this operation, your IAM permissions must allow the <c>sagemaker:InvokeEndpoint</c>
        /// action. For more information about Amazon SageMaker actions for IAM policies, see
        /// <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonsagemaker.html">Actions,
        /// resources, and condition keys for Amazon SageMaker</a> in the <i>IAM Service Authorization
        /// Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
        /// SageMaker might add additional headers. You should not rely on the behavior of headers
        /// outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpointWithResponseStream</c> are authenticated by using Amazon
        /// Web Services Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointWithResponseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeEndpointWithResponseStream service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalStreamFailureException">
        /// The stream processing failed because of an unknown error, exception or failure. Try
        /// your request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelErrorException">
        /// Model (owned by the customer in the container) returned 4xx or 5xx error code.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelStreamErrorException">
        /// An error occurred while streaming the response body. This error can have the following
        /// error codes:
        /// 
        ///  <dl> <dt>ModelInvocationTimeExceeded</dt> <dd> 
        /// <para>
        /// The model failed to finish sending the response within the timeout period allowed
        /// by Amazon SageMaker.
        /// </para>
        ///  </dd> <dt>StreamBroken</dt> <dd> 
        /// <para>
        /// The Transmission Control Protocol (TCP) connection between the client and the model
        /// was reset or closed.
        /// </para>
        ///  </dd> </dl>
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpointWithResponseStream">REST API Reference for InvokeEndpointWithResponseStream Operation</seealso>
        public virtual Task<InvokeEndpointWithResponseStreamResponse> InvokeEndpointWithResponseStreamAsync(InvokeEndpointWithResponseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointWithResponseStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<InvokeEndpointWithResponseStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

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

        #endregion

    }
}