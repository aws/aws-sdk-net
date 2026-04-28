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
 * Do not modify this file. This file is generated from the sagemaker-runtime-http2-2025-10-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMakerRuntimeHTTP2.Model;
using Amazon.SageMakerRuntimeHTTP2.Model.Internal.MarshallTransformations;
using Amazon.SageMakerRuntimeHTTP2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SageMakerRuntimeHTTP2
{
    /// <summary>
    /// <para>Implementation for accessing SageMakerRuntimeHTTP2</para>
    ///
    /// The Amazon SageMaker AI runtime HTTP/2 API.
    /// </summary>
    public partial class AmazonSageMakerRuntimeHTTP2Client : AmazonServiceClient, IAmazonSageMakerRuntimeHTTP2
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerRuntimeHTTP2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with the credentials loaded from the application's
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
        public AmazonSageMakerRuntimeHTTP2Client()
            : base(new AmazonSageMakerRuntimeHTTP2Config()) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with the credentials loaded from the application's
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
        public AmazonSageMakerRuntimeHTTP2Client(RegionEndpoint region)
            : base(new AmazonSageMakerRuntimeHTTP2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(AmazonSageMakerRuntimeHTTP2Config config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerRuntimeHTTP2Client(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerRuntimeHTTP2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeHTTP2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerRuntimeHTTP2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Credentials and an
        /// AmazonSageMakerRuntimeHTTP2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(AWSCredentials credentials, AmazonSageMakerRuntimeHTTP2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerRuntimeHTTP2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerRuntimeHTTP2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerRuntimeHTTP2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerRuntimeHTTP2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerRuntimeHTTP2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerRuntimeHTTP2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerRuntimeHTTP2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerRuntimeHTTP2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerRuntimeHTTP2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerRuntimeHTTP2AuthSchemeHandler());
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


        #region  InvokeEndpointWithBidirectionalStream

#if NET8_0_OR_GREATER
        internal virtual InvokeEndpointWithBidirectionalStreamResponse InvokeEndpointWithBidirectionalStream(InvokeEndpointWithBidirectionalStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointWithBidirectionalStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointWithBidirectionalStreamResponseUnmarshaller.Instance;

            return Invoke<InvokeEndpointWithBidirectionalStreamResponse>(request, options);
        }



        /// <summary>
        /// Invokes a model endpoint with bidirectional streaming capabilities. This operation
        /// establishes a persistent connection that allows you to send multiple requests and
        /// receive streaming responses from the model in real-time.
        /// 
        ///  
        /// <para>
        /// Bidirectional streaming is useful for interactive applications such as chatbots, real-time
        /// translation, or any scenario where you need to maintain a conversation-like interaction
        /// with the model. The connection remains open, allowing you to send additional input
        /// and receive responses without establishing a new connection for each request.
        /// </para>
        ///  
        /// <para>
        /// For an overview of Amazon SageMaker AI, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker AI strips all POST headers except those supported by the API. Amazon
        /// SageMaker AI might add additional headers. You should not rely on the behavior of
        /// headers outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <c>InvokeEndpointWithBidirectionalStream</c> are authenticated by using Amazon
        /// Web Services Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// The bidirectional stream maintains the connection until either the client closes it
        /// or the model indicates completion. Each request and response in the stream is sent
        /// as an event with optional headers for data type and completion state.
        /// </para>
        ///  <note> 
        /// <para>
        /// Endpoints are scoped to an individual account, and are not public. The URL does not
        /// contain the account ID, but Amazon SageMaker AI determines the account ID from the
        /// authentication token that is supplied by the caller.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointWithBidirectionalStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeEndpointWithBidirectionalStream service method, as returned by SageMakerRuntimeHTTP2.</returns>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.InputValidationErrorException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.InternalStreamFailureException">
        /// Internal stream failure that occurs during streaming.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.ModelErrorException">
        /// An error occurred while processing the model.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.ModelStreamErrorException">
        /// Model stream error that occurs during streaming.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntimeHTTP2.Model.ServiceUnavailableErrorException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-runtime-http2-2025-10-01/InvokeEndpointWithBidirectionalStream">REST API Reference for InvokeEndpointWithBidirectionalStream Operation</seealso>
        public virtual Task<InvokeEndpointWithBidirectionalStreamResponse> InvokeEndpointWithBidirectionalStreamAsync(InvokeEndpointWithBidirectionalStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeEndpointWithBidirectionalStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeEndpointWithBidirectionalStreamResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeEndpointWithBidirectionalStreamResponse>(request, options, cancellationToken);
        }
#endif
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