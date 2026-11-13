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
using Amazon.RpcV2CBORCorpusProtocolTests.Model;
using Amazon.RpcV2CBORCorpusProtocolTests.Model.Internal.MarshallTransformations;
using Amazon.RpcV2CBORCorpusProtocolTests.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.RpcV2CBORCorpusProtocolTests
{
    /// <summary>
    /// <para>Implementation for accessing RpcV2CBORCorpusProtocolTests</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    /// </summary>
    public partial class AmazonRpcV2CBORCorpusProtocolTestsClient : AmazonServiceClient, IAmazonRpcV2CBORCorpusProtocolTests
    {
        private static IServiceMetadata serviceMetadata = new AmazonRpcV2CBORCorpusProtocolTestsMetadata();
        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with the credentials loaded from the application's
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
        public AmazonRpcV2CBORCorpusProtocolTestsClient() : base(new AmazonRpcV2CBORCorpusProtocolTestsConfig()) { }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with the credentials loaded from the application's
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
        public AmazonRpcV2CBORCorpusProtocolTestsClient(RegionEndpoint region) : base(new AmazonRpcV2CBORCorpusProtocolTestsConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRpcV2CBORCorpusProtocolTestsClient Configuration Object</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(AmazonRpcV2CBORCorpusProtocolTestsConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(AWSCredentials credentials)
            : this(credentials, new AmazonRpcV2CBORCorpusProtocolTestsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRpcV2CBORCorpusProtocolTestsConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Credentials and an
        /// AmazonRpcV2CBORCorpusProtocolTestsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRpcV2CBORCorpusProtocolTestsClient Configuration Object</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(AWSCredentials credentials, AmazonRpcV2CBORCorpusProtocolTestsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRpcV2CBORCorpusProtocolTestsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRpcV2CBORCorpusProtocolTestsConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRpcV2CBORCorpusProtocolTestsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRpcV2CBORCorpusProtocolTestsClient Configuration Object</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRpcV2CBORCorpusProtocolTestsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRpcV2CBORCorpusProtocolTestsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRpcV2CBORCorpusProtocolTestsConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2CBORCorpusProtocolTestsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRpcV2CBORCorpusProtocolTestsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRpcV2CBORCorpusProtocolTestsClient Configuration Object</param>
        public AmazonRpcV2CBORCorpusProtocolTestsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRpcV2CBORCorpusProtocolTestsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRpcV2CBORCorpusProtocolTestsAuthSchemeHandler());
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamDuplex service method.</param>
        /// <returns>The response from the EventStreamDuplex service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamDuplex">REST API Reference for EventStreamDuplex Operation</seealso>
        public virtual EventStreamDuplexResponse EventStreamDuplex(EventStreamDuplexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamDuplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamDuplexResponseUnmarshaller.Instance;

            return Invoke<EventStreamDuplexResponse>(request, options);
        }
#else
        internal virtual EventStreamDuplexResponse EventStreamDuplex(EventStreamDuplexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamDuplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamDuplexResponseUnmarshaller.Instance;

            return Invoke<EventStreamDuplexResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamDuplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamDuplex service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamDuplex">REST API Reference for EventStreamDuplex Operation</seealso>
        public virtual Task<EventStreamDuplexResponse> EventStreamDuplexAsync(EventStreamDuplexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamDuplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamDuplexResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamDuplexResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamError service method.</param>
        /// <returns>The response from the EventStreamError service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamError">REST API Reference for EventStreamError Operation</seealso>
        public virtual EventStreamErrorResponse EventStreamError(EventStreamErrorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamErrorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamErrorResponseUnmarshaller.Instance;

            return Invoke<EventStreamErrorResponse>(request, options);
        }
#else
        internal virtual EventStreamErrorResponse EventStreamError(EventStreamErrorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamErrorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamErrorResponseUnmarshaller.Instance;

            return Invoke<EventStreamErrorResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamError service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamError service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamError">REST API Reference for EventStreamError Operation</seealso>
        public virtual Task<EventStreamErrorResponse> EventStreamErrorAsync(EventStreamErrorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamErrorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamErrorResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamErrorResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialRequest service method.</param>
        /// <returns>The response from the EventStreamInitialRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialRequest">REST API Reference for EventStreamInitialRequest Operation</seealso>
        public virtual EventStreamInitialRequestResponse EventStreamInitialRequest(EventStreamInitialRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamInitialRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamInitialRequestResponseUnmarshaller.Instance;

            return Invoke<EventStreamInitialRequestResponse>(request, options);
        }
#else
        internal virtual EventStreamInitialRequestResponse EventStreamInitialRequest(EventStreamInitialRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamInitialRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamInitialRequestResponseUnmarshaller.Instance;

            return Invoke<EventStreamInitialRequestResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamInitialRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialRequest">REST API Reference for EventStreamInitialRequest Operation</seealso>
        public virtual Task<EventStreamInitialRequestResponse> EventStreamInitialRequestAsync(EventStreamInitialRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamInitialRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamInitialRequestResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamInitialRequestResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialResponse service method.</param>
        /// <returns>The response from the EventStreamInitialResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialResponse">REST API Reference for EventStreamInitialResponse Operation</seealso>
        public virtual EventStreamInitialResponseResponse EventStreamInitialResponse(EventStreamInitialResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamInitialResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamInitialResponseResponseUnmarshaller.Instance;

            return Invoke<EventStreamInitialResponseResponse>(request, options);
        }
#else
        internal virtual EventStreamInitialResponseResponse EventStreamInitialResponse(EventStreamInitialResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamInitialResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamInitialResponseResponseUnmarshaller.Instance;

            return Invoke<EventStreamInitialResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamInitialResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialResponse">REST API Reference for EventStreamInitialResponse Operation</seealso>
        public virtual Task<EventStreamInitialResponseResponse> EventStreamInitialResponseAsync(EventStreamInitialResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamInitialResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamInitialResponseResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamInitialResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamRequest service method.</param>
        /// <returns>The response from the EventStreamRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamRequest">REST API Reference for EventStreamRequest Operation</seealso>
        public virtual EventStreamRequestResponse EventStreamRequest(EventStreamRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamRequestResponseUnmarshaller.Instance;

            return Invoke<EventStreamRequestResponse>(request, options);
        }
#else
        internal virtual EventStreamRequestResponse EventStreamRequest(EventStreamRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamRequestResponseUnmarshaller.Instance;

            return Invoke<EventStreamRequestResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamRequest">REST API Reference for EventStreamRequest Operation</seealso>
        public virtual Task<EventStreamRequestResponse> EventStreamRequestAsync(EventStreamRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamRequestResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamRequestResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponse service method.</param>
        /// <returns>The response from the EventStreamResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponse">REST API Reference for EventStreamResponse Operation</seealso>
        public virtual EventStreamResponseResponse EventStreamResponse(EventStreamResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseResponse>(request, options);
        }
#else
        internal virtual EventStreamResponseResponse EventStreamResponse(EventStreamResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponse">REST API Reference for EventStreamResponse Operation</seealso>
        public virtual Task<EventStreamResponseResponse> EventStreamResponseAsync(EventStreamResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseBlobPayload service method.</param>
        /// <returns>The response from the EventStreamResponseBlobPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseBlobPayload">REST API Reference for EventStreamResponseBlobPayload Operation</seealso>
        public virtual EventStreamResponseBlobPayloadResponse EventStreamResponseBlobPayload(EventStreamResponseBlobPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseBlobPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseBlobPayloadResponse>(request, options);
        }
#else
        internal virtual EventStreamResponseBlobPayloadResponse EventStreamResponseBlobPayload(EventStreamResponseBlobPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseBlobPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseBlobPayloadResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseBlobPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseBlobPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseBlobPayload">REST API Reference for EventStreamResponseBlobPayload Operation</seealso>
        public virtual Task<EventStreamResponseBlobPayloadResponse> EventStreamResponseBlobPayloadAsync(EventStreamResponseBlobPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseBlobPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseBlobPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamResponseBlobPayloadResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseHeaders service method.</param>
        /// <returns>The response from the EventStreamResponseHeaders service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseHeaders">REST API Reference for EventStreamResponseHeaders Operation</seealso>
        public virtual EventStreamResponseHeadersResponse EventStreamResponseHeaders(EventStreamResponseHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseHeadersResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseHeadersResponse>(request, options);
        }
#else
        internal virtual EventStreamResponseHeadersResponse EventStreamResponseHeaders(EventStreamResponseHeadersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseHeadersResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseHeadersResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseHeaders service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseHeaders">REST API Reference for EventStreamResponseHeaders Operation</seealso>
        public virtual Task<EventStreamResponseHeadersResponse> EventStreamResponseHeadersAsync(EventStreamResponseHeadersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseHeadersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseHeadersResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamResponseHeadersResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseImplicitPayload service method.</param>
        /// <returns>The response from the EventStreamResponseImplicitPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseImplicitPayload">REST API Reference for EventStreamResponseImplicitPayload Operation</seealso>
        public virtual EventStreamResponseImplicitPayloadResponse EventStreamResponseImplicitPayload(EventStreamResponseImplicitPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseImplicitPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseImplicitPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseImplicitPayloadResponse>(request, options);
        }
#else
        internal virtual EventStreamResponseImplicitPayloadResponse EventStreamResponseImplicitPayload(EventStreamResponseImplicitPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseImplicitPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseImplicitPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseImplicitPayloadResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseImplicitPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseImplicitPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseImplicitPayload">REST API Reference for EventStreamResponseImplicitPayload Operation</seealso>
        public virtual Task<EventStreamResponseImplicitPayloadResponse> EventStreamResponseImplicitPayloadAsync(EventStreamResponseImplicitPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseImplicitPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseImplicitPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamResponseImplicitPayloadResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseStructPayload service method.</param>
        /// <returns>The response from the EventStreamResponseStructPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseStructPayload">REST API Reference for EventStreamResponseStructPayload Operation</seealso>
        public virtual EventStreamResponseStructPayloadResponse EventStreamResponseStructPayload(EventStreamResponseStructPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseStructPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseStructPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseStructPayloadResponse>(request, options);
        }
#else
        internal virtual EventStreamResponseStructPayloadResponse EventStreamResponseStructPayload(EventStreamResponseStructPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseStructPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseStructPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseStructPayloadResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseStructPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseStructPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseStructPayload">REST API Reference for EventStreamResponseStructPayload Operation</seealso>
        public virtual Task<EventStreamResponseStructPayloadResponse> EventStreamResponseStructPayloadAsync(EventStreamResponseStructPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseStructPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseStructPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamResponseStructPayloadResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseUnionPayload service method.</param>
        /// <returns>The response from the EventStreamResponseUnionPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseUnionPayload">REST API Reference for EventStreamResponseUnionPayload Operation</seealso>
        public virtual EventStreamResponseUnionPayloadResponse EventStreamResponseUnionPayload(EventStreamResponseUnionPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseUnionPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseUnionPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseUnionPayloadResponse>(request, options);
        }
#else
        internal virtual EventStreamResponseUnionPayloadResponse EventStreamResponseUnionPayload(EventStreamResponseUnionPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseUnionPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseUnionPayloadResponseUnmarshaller.Instance;

            return Invoke<EventStreamResponseUnionPayloadResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseUnionPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseUnionPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseUnionPayload">REST API Reference for EventStreamResponseUnionPayload Operation</seealso>
        public virtual Task<EventStreamResponseUnionPayloadResponse> EventStreamResponseUnionPayloadAsync(EventStreamResponseUnionPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EventStreamResponseUnionPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EventStreamResponseUnionPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<EventStreamResponseUnionPayloadResponse>(request, options, cancellationToken);
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
