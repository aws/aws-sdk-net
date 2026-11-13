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
using Amazon.RpcV2CBORCorpusProtocolTests.Model;

#pragma warning disable CS1570

namespace Amazon.RpcV2CBORCorpusProtocolTests
{
    /// <summary>
    /// <para>Interface for accessing RpcV2CBORCorpusProtocolTests</para>
    /// </summary>
    public partial interface IAmazonRpcV2CBORCorpusProtocolTests : IAmazonService, IDisposable
    {
#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamDuplex service method.</param>
        /// <returns>The response from the EventStreamDuplex service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamDuplex">REST API Reference for EventStreamDuplex Operation</seealso>
        EventStreamDuplexResponse EventStreamDuplex(EventStreamDuplexRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamDuplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamDuplex service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamDuplex">REST API Reference for EventStreamDuplex Operation</seealso>
        Task<EventStreamDuplexResponse> EventStreamDuplexAsync(EventStreamDuplexRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamError service method.</param>
        /// <returns>The response from the EventStreamError service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamError">REST API Reference for EventStreamError Operation</seealso>
        EventStreamErrorResponse EventStreamError(EventStreamErrorRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamError service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamError service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamError">REST API Reference for EventStreamError Operation</seealso>
        Task<EventStreamErrorResponse> EventStreamErrorAsync(EventStreamErrorRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialRequest service method.</param>
        /// <returns>The response from the EventStreamInitialRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialRequest">REST API Reference for EventStreamInitialRequest Operation</seealso>
        EventStreamInitialRequestResponse EventStreamInitialRequest(EventStreamInitialRequestRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamInitialRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialRequest">REST API Reference for EventStreamInitialRequest Operation</seealso>
        Task<EventStreamInitialRequestResponse> EventStreamInitialRequestAsync(EventStreamInitialRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialResponse service method.</param>
        /// <returns>The response from the EventStreamInitialResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialResponse">REST API Reference for EventStreamInitialResponse Operation</seealso>
        EventStreamInitialResponseResponse EventStreamInitialResponse(EventStreamInitialResponseRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamInitialResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamInitialResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamInitialResponse">REST API Reference for EventStreamInitialResponse Operation</seealso>
        Task<EventStreamInitialResponseResponse> EventStreamInitialResponseAsync(EventStreamInitialResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamRequest service method.</param>
        /// <returns>The response from the EventStreamRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamRequest">REST API Reference for EventStreamRequest Operation</seealso>
        EventStreamRequestResponse EventStreamRequest(EventStreamRequestRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamRequest service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamRequest">REST API Reference for EventStreamRequest Operation</seealso>
        Task<EventStreamRequestResponse> EventStreamRequestAsync(EventStreamRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponse service method.</param>
        /// <returns>The response from the EventStreamResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponse">REST API Reference for EventStreamResponse Operation</seealso>
        EventStreamResponseResponse EventStreamResponse(EventStreamResponseRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponse service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponse">REST API Reference for EventStreamResponse Operation</seealso>
        Task<EventStreamResponseResponse> EventStreamResponseAsync(EventStreamResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseBlobPayload service method.</param>
        /// <returns>The response from the EventStreamResponseBlobPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseBlobPayload">REST API Reference for EventStreamResponseBlobPayload Operation</seealso>
        EventStreamResponseBlobPayloadResponse EventStreamResponseBlobPayload(EventStreamResponseBlobPayloadRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseBlobPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseBlobPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseBlobPayload">REST API Reference for EventStreamResponseBlobPayload Operation</seealso>
        Task<EventStreamResponseBlobPayloadResponse> EventStreamResponseBlobPayloadAsync(EventStreamResponseBlobPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseHeaders service method.</param>
        /// <returns>The response from the EventStreamResponseHeaders service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseHeaders">REST API Reference for EventStreamResponseHeaders Operation</seealso>
        EventStreamResponseHeadersResponse EventStreamResponseHeaders(EventStreamResponseHeadersRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseHeaders service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseHeaders">REST API Reference for EventStreamResponseHeaders Operation</seealso>
        Task<EventStreamResponseHeadersResponse> EventStreamResponseHeadersAsync(EventStreamResponseHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseImplicitPayload service method.</param>
        /// <returns>The response from the EventStreamResponseImplicitPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseImplicitPayload">REST API Reference for EventStreamResponseImplicitPayload Operation</seealso>
        EventStreamResponseImplicitPayloadResponse EventStreamResponseImplicitPayload(EventStreamResponseImplicitPayloadRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseImplicitPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseImplicitPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseImplicitPayload">REST API Reference for EventStreamResponseImplicitPayload Operation</seealso>
        Task<EventStreamResponseImplicitPayloadResponse> EventStreamResponseImplicitPayloadAsync(EventStreamResponseImplicitPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseStructPayload service method.</param>
        /// <returns>The response from the EventStreamResponseStructPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseStructPayload">REST API Reference for EventStreamResponseStructPayload Operation</seealso>
        EventStreamResponseStructPayloadResponse EventStreamResponseStructPayload(EventStreamResponseStructPayloadRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseStructPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseStructPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseStructPayload">REST API Reference for EventStreamResponseStructPayload Operation</seealso>
        Task<EventStreamResponseStructPayloadResponse> EventStreamResponseStructPayloadAsync(EventStreamResponseStructPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseUnionPayload service method.</param>
        /// <returns>The response from the EventStreamResponseUnionPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseUnionPayload">REST API Reference for EventStreamResponseUnionPayload Operation</seealso>
        EventStreamResponseUnionPayloadResponse EventStreamResponseUnionPayload(EventStreamResponseUnionPayloadRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EventStreamResponseUnionPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EventStreamResponseUnionPayload service method, as returned by RpcV2CBORCorpusProtocolTests.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2cborcorpusprotocoltests-2026-11-13/EventStreamResponseUnionPayload">REST API Reference for EventStreamResponseUnionPayload Operation</seealso>
        Task<EventStreamResponseUnionPayloadResponse> EventStreamResponseUnionPayloadAsync(EventStreamResponseUnionPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRpcV2CBORCorpusProtocolTestsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRpcV2CBORCorpusProtocolTestsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRpcV2CBORCorpusProtocolTestsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRpcV2CBORCorpusProtocolTestsConfig to create AmazonRpcV2CBORCorpusProtocolTestsClient");
            }

            return awsCredentials == null ?
                    new AmazonRpcV2CBORCorpusProtocolTestsClient(serviceClientConfig) :
                    new AmazonRpcV2CBORCorpusProtocolTestsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
