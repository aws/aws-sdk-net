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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace Amazon.Runtime.Pipeline.HttpHandler
{
#if NET8_0_OR_GREATER
    /// <summary>
    /// This class is set as the Content for the HttpRequestMessage when a request is going
    /// to use a IHttpRequestStreamPublisher to stream data to the service.
    /// 
    /// This is typically done for bi-directional event streaming operations that 
    /// need to stream events from the consumer code to the service.
    /// </summary>
    public class HttpContentRequestStreamHandle : HttpContent, IHttpRequestStreamHandle
    {
        private Logger _logger = Logger.GetLogger(typeof(HttpContentRequestStreamHandle));
        private HttpRequestMessage _httpRequest;
        private bool _disposed;
        private TaskCompletionSource _tcs = new TaskCompletionSource();
        private IHttpRequestStreamPublisher _publisher;

        public HttpContentRequestStreamHandle(HttpRequestMessage httpRequest, IHttpRequestStreamPublisher publisher)
        {
            _httpRequest = httpRequest;
            _httpRequest.Content = this;

            _publisher = publisher;
        }

        protected override async Task SerializeToStreamAsync( Stream stream, TransportContext context)
        {
            if(_publisher != null)
            {
                Byte[] bytes;
                while((bytes = await _publisher.NextBytesAsync().ConfigureAwait(false)) != null)
                {
                    await stream.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
                    await stream.FlushAsync().ConfigureAwait(false);
                }
            }

            // Capture the _tcs as local variable before awaiting to avoid the member variable
            // being set to null between the null check and the await.
            var tcs = _tcs; 
            if (tcs != null)
            {
                // Even if the user has ended input streaming via returning null from the publisher
                // we need to block the return here till the full operation is complete. Otherwise
                // HttpClient will end the streaming session before the response has been completed streaming.
                // This can cause trigger an error with the service. The TaskCompletionSource, _tcs, 
                // is completed as part of disposing this class.
                await tcs.Task.ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Since the length is unknown based on the user continually streaming data return back false and -1 for length.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        protected override bool TryComputeLength(out long length)
        {
            length = -1; // Unknown length
            return false;
        }

        protected override void Dispose(bool disposing)
        {
            _logger.DebugFormat("Disposing the request stream");
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                if (_tcs != null)
                {
                    _logger.DebugFormat("Completed writing to request stream");
                    _tcs.SetResult();
                    _tcs = null;
                }
                if (_httpRequest != null)
                {
                    _httpRequest.Dispose();
                    _httpRequest = null;
                }
            }

            _disposed = true;
            base.Dispose(disposing);
        }
    }
#endif
}
