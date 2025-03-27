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
    /// Grabs a hold of the stream opened by the HttpClient for sending requests and makes the stream
    /// available for writing by higher level points of the SDK via the IHttpRequestStreamWriter interface.
    /// </summary>
    public class HttpContentRequestStreamWriter : HttpContent, IHttpRequestStreamWriter
    {
        private Logger _logger = Logger.GetLogger(typeof(HttpContentRequestStreamWriter));
        private HttpRequestMessage _httpRequest;
        private Stream _stream;
        private bool _disposed;
        private TaskCompletionSource _tcs = new TaskCompletionSource();

        public HttpContentRequestStreamWriter(HttpRequestMessage httpRequest)
        {
            _httpRequest = httpRequest;
            _httpRequest.Content = this;
        }

        protected override Task SerializeToStreamAsync( Stream stream, TransportContext context)
        {
            // Hold on to the stream opened by the HttpClient for talking to the service.
            _stream = stream;

            // TaskCompletionSource held by _tcs keeps the Task running for SerializeToStreamAsync active till
            // this instance is disposed. That way the HttpClient believes SerializeToStreamAsync is contining 
            // to send data through the stream till instance is disposed.
            return _tcs.Task;
        }

        protected override bool TryComputeLength(out long length)
        {
            length = -1; // Unknown length
            return false;
        }

        public void Complete()
        {
            if (_tcs != null)
            {
                _logger.DebugFormat("Completed writing to request stream");
                _tcs.SetResult();
                _tcs = null;
            }
        }

        public async Task WriteAsync(byte[] bytes, CancellationToken token = default)
        {
#pragma warning disable CA1031 // Do not catch general exception types
            try
            {
                await _stream.WriteAsync(bytes, 0, bytes.Length, token).ConfigureAwait(false);
                await _stream.FlushAsync(token).ConfigureAwait(false);
            }
            catch(Exception ex)
            {
                if (!token.IsCancellationRequested)
                {
                    _logger.Error(ex, "Exception writing {0} bytes to request stream.", bytes?.Length);
                    _tcs.SetException(ex);
                }
            }
#pragma warning restore CA1031 // Do not catch general exception types
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
                Complete();
            }

            _disposed = true;
            base.Dispose(disposing);

            if (_httpRequest != null)
            {
                _httpRequest.Dispose();
                _httpRequest = null;
            }
        }
    }
#endif
}
