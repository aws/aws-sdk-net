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

#if !NETFRAMEWORK
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Http
{
    /// <summary>
    /// Applies a first-byte timeout to each request and wraps the response body so a connection that
    /// stalls mid-transfer is aborted and retried instead of hanging until the whole-request timeout.
    /// </summary>
    internal sealed class ThroughputMonitorHandler : DelegatingHandler
    {
        private readonly long _minimumBytesPerSecond;
        private readonly TimeSpan _allowableFailureInterval;
        private readonly UploadPartTimeoutTracker _uploadTimeoutTracker;

        internal ThroughputMonitorHandler(
            HttpMessageHandler innerHandler,
            long minimumBytesPerSecond,
            TimeSpan allowableFailureInterval,
            UploadPartTimeoutTracker uploadTimeoutTracker)
            : base(innerHandler)
        {
            _minimumBytesPerSecond = minimumBytesPerSecond;
            _allowableFailureInterval = allowableFailureInterval;
            _uploadTimeoutTracker = uploadTimeoutTracker;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // The adaptive first-byte timeout only applies to uploads (PUT with a body). Applying it to
            // downloads would be counterproductive: a GET's first byte legitimately waits on the object.
            var firstByteBudget = IsUploadPart(request)
                ? _uploadTimeoutTracker?.CurrentTimeout
                : null;

            // Stopwatch rather than wall-clock: durations must be immune to clock adjustments.
            var elapsed = Stopwatch.StartNew();
            HttpResponseMessage response;

            if (firstByteBudget.HasValue)
            {
                using (var timeoutSource = new CancellationTokenSource(firstByteBudget.Value))
                using (var linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutSource.Token))
                {
                    try
                    {
                        response = await base.SendAsync(request, linked.Token).ConfigureAwait(false);
                    }
                    catch (OperationCanceledException) when (timeoutSource.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
                    {
                        _uploadTimeoutTracker.RecordTimeout();

                        // Surface as IOException so the existing retry pipeline retries this part.
                        throw new IOException(
                            $"The upload did not begin responding within {firstByteBudget.Value.TotalMilliseconds:N0} ms and was cancelled so it could be retried.");
                    }
                }

                _uploadTimeoutTracker.RecordSuccess(elapsed.Elapsed);
            }
            else
            {
                response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

                if (IsUploadPart(request))
                    _uploadTimeoutTracker?.RecordSuccess(elapsed.Elapsed);
            }

            if (_minimumBytesPerSecond > 0 && response.Content != null && HasReadableBody(response))
            {
                response.Content = new ThroughputMonitoringContent(
                    response.Content, _minimumBytesPerSecond, _allowableFailureInterval);
            }

            return response;
        }

        private static bool IsUploadPart(HttpRequestMessage request)
        {
            return request.Method == HttpMethod.Put && request.Content != null;
        }

        private static bool HasReadableBody(HttpResponseMessage response)
        {
            // Only monitor bodies large enough for throughput to be a meaningful concept. Small
            // control-plane responses complete in a single read and would only add overhead.
            return response.StatusCode == HttpStatusCode.OK
                || response.StatusCode == HttpStatusCode.PartialContent;
        }
    }

    /// <summary>
    /// Delegating <see cref="HttpContent"/> that hands out a throughput-monitored view of the body while
    /// preserving the original content headers.
    /// </summary>
    internal sealed class ThroughputMonitoringContent : HttpContent
    {
        private readonly HttpContent _inner;
        private readonly long _minimumBytesPerSecond;
        private readonly TimeSpan _allowableFailureInterval;

        internal ThroughputMonitoringContent(
            HttpContent inner,
            long minimumBytesPerSecond,
            TimeSpan allowableFailureInterval)
        {
            _inner = inner;
            _minimumBytesPerSecond = minimumBytesPerSecond;
            _allowableFailureInterval = allowableFailureInterval;

            // Content headers must be carried across or unmarshalling loses Content-Length,
            // Content-Range, checksum trailers and similar.
            foreach (var header in inner.Headers)
            {
                Headers.TryAddWithoutValidation(header.Key, header.Value);
            }
        }

        protected override async Task<Stream> CreateContentReadStreamAsync()
        {
            var stream = await _inner.ReadAsStreamAsync().ConfigureAwait(false);
            return new ThroughputMonitoringStream(stream, _minimumBytesPerSecond, _allowableFailureInterval);
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            var source = await CreateContentReadStreamAsync().ConfigureAwait(false);
            await source.CopyToAsync(stream).ConfigureAwait(false);
        }

        protected override bool TryComputeLength(out long length)
        {
            var contentLength = _inner.Headers.ContentLength;
            length = contentLength ?? -1;
            return contentLength.HasValue;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _inner.Dispose();

            base.Dispose(disposing);
        }
    }
}
#endif
