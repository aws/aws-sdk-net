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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.Utils
{
    /// <summary>
    /// IHttpRequest that records everything the SDK pipeline sends and returns a canned
    /// <see cref="MockHttpResponse"/> instead of performing network I/O.
    /// TRequestContent is Stream on .NET Framework and HttpContent everywhere else.
    /// </summary>
    internal class MockHttpRequest<TRequestContent> : IHttpRequest<TRequestContent>
    {
        private readonly Func<MockHttpRequest<TRequestContent>, MockHttpResponse> _responseCreator;
        private MemoryStream _requestContent;

        public MockHttpRequest(Uri requestUri, Func<MockHttpRequest<TRequestContent>, MockHttpResponse> responseCreator)
        {
            RequestUri = requestUri;
            _responseCreator = responseCreator;
        }

        public string Method { get; set; }

        public Uri RequestUri { get; }

        public Version HttpProtocolVersion { get; set; }

        /// <summary>
        /// Request and content headers sent by the SDK. Case insensitive.
        /// </summary>
        public Dictionary<string, string> Headers { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// The request body written by the SDK, or null if no body was written.
        /// </summary>
        public byte[] Body { get; private set; }

        /// <summary>
        /// Signed event stream frames written by the SDK for input/duplex event stream operations.
        /// </summary>
        public ConcurrentQueue<byte[]> InputFrames { get; } = new ConcurrentQueue<byte[]>();

        /// <summary>
        /// Completes once the SDK's request stream publisher signals the end of the input stream.
        /// Completed immediately for requests that don't stream input.
        /// </summary>
        public Task InputStreamCompleted { get; private set; } = Task.CompletedTask;

        public bool IsAborted { get; private set; }

        public void ConfigureRequest(IRequestContext requestContext)
        {
        }

        public void SetRequestHeaders(IDictionary<string, string> headers)
        {
            MergeHeaders(headers);
        }

        public TRequestContent GetRequestContent()
        {
            // The .NET Framework HttpHandler writes to the returned Stream, while the
            // HttpContent-based handler only passes it back into WriteToRequestBody.
            if (typeof(TRequestContent) == typeof(Stream))
            {
                _requestContent = new MemoryStream();
                return (TRequestContent)(object)_requestContent;
            }
            return default(TRequestContent);
        }

        public Task<TRequestContent> GetRequestContentAsync()
        {
            return Task.FromResult(GetRequestContent());
        }

#if BCL
        public Task<TRequestContent> GetRequestContentAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(GetRequestContent());
        }
#endif

        public void WriteToRequestBody(TRequestContent requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            using (var buffer = new MemoryStream())
            {
                contentStream.CopyTo(buffer);
                Body = buffer.ToArray();
            }
            MergeHeaders(contentHeaders);
        }

        public void WriteToRequestBody(TRequestContent requestContent, byte[] content, IDictionary<string, string> contentHeaders)
        {
            Body = (byte[])content.Clone();
            MergeHeaders(contentHeaders);
        }

#if !NETFRAMEWORK
        public void WriteToRequestBody(TRequestContent requestContent, ReadOnlyMemory<byte> content, IDictionary<string, string> contentHeaders)
        {
            // Copy now: the SDK returns pooled buffers to the pool after the request is sent.
            Body = content.ToArray();
            MergeHeaders(contentHeaders);
        }
#endif

#if BCL
        public Task WriteToRequestBodyAsync(TRequestContent requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            WriteToRequestBody(requestContent, contentStream, contentHeaders, requestContext);
            return Task.CompletedTask;
        }

        public Task WriteToRequestBodyAsync(TRequestContent requestContent, byte[] requestData, IDictionary<string, string> headers, CancellationToken cancellationToken)
        {
            WriteToRequestBody(requestContent, requestData, headers);
            return Task.CompletedTask;
        }
#endif

        public IHttpRequestStreamHandle SetupHttpRequestStreamPublisher(IDictionary<string, string> contentHeaders, IHttpRequestStreamPublisher publisher)
        {
#if NET8_0_OR_GREATER
            MergeHeaders(contentHeaders);
            var handle = new MockHttpRequestStreamHandle();
            // Run the pump in the background like HttpClient does, so the response is
            // returned to the pipeline while the input stream is still open.
            InputStreamCompleted = Task.Run(async () =>
            {
                byte[] bytes;
                while (!handle.IsDisposed && (bytes = await publisher.NextBytesAsync().ConfigureAwait(false)) != null)
                {
                    InputFrames.Enqueue(bytes);
                }
            });
            return handle;
#else
            // Matches Core: request stream publishing is only supported on .NET 8+.
            throw new NotImplementedException();
#endif
        }

        public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
        {
            return originalStream;
        }

        public IWebResponseData GetResponse()
        {
            CaptureRequestContent();

            var responseData = new MockWebResponseData(_responseCreator(this));
            // Mirror the real HTTP layer, which surfaces non-2xx responses as HttpErrorResponseException
            // so that the ErrorHandler unmarshalls them into the modeled service exception.
            if (!responseData.IsSuccessStatusCode)
                throw new HttpErrorResponseException(responseData);

            return responseData;
        }

        public Task<IWebResponseData> GetResponseAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(GetResponse());
        }

        public void Abort()
        {
            IsAborted = true;
        }

        public void Dispose()
        {
            // Intentionally does not stop the input stream pump. HttpHandler disposes the request
            // after sending unless a request stream publisher is set, matching real HTTP behavior.
        }

        private void CaptureRequestContent()
        {
            // On .NET Framework the SDK writes the body into the Stream from GetRequestContent().
            if (_requestContent != null && _requestContent.Length > 0 && Body == null)
                Body = _requestContent.ToArray();
        }

        private void MergeHeaders(IDictionary<string, string> headers)
        {
            if (headers == null)
                return;

            foreach (var header in headers)
            {
                Headers[header.Key] = header.Value;
            }
        }
    }

    /// <summary>
    /// Handle returned for input/duplex event streams. Disposing it stops the input stream pump.
    /// </summary>
    internal class MockHttpRequestStreamHandle : IHttpRequestStreamHandle
    {
        public bool IsDisposed { get; private set; }

        public void Dispose()
        {
            IsDisposed = true;
        }
    }
}
