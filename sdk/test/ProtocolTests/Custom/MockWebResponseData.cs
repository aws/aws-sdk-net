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

using Amazon.Runtime.EventStreams;
using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.Utils
{
    /// <summary>
    /// The canned HTTP response a <see cref="MockHttpRequest{T}"/> returns to the SDK pipeline.
    /// </summary>
    internal class MockHttpResponse
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public byte[] Body { get; set; } = Array.Empty<byte>();

        public string ContentType { get; set; }
    }

    /// <summary>
    /// IWebResponseData backed by a <see cref="MockHttpResponse"/>. Unlike TestTools.WebResponseData,
    /// this exposes the response body through ResponseBody so the real unmarshaller pipeline can read it.
    /// </summary>
    internal class MockWebResponseData : IWebResponseData
    {
        private readonly Dictionary<string, string> _headers;
        private readonly byte[] _body;

        public MockWebResponseData(MockHttpResponse response)
        {
            // RFC 9110 states headers must be case insensitive
            _headers = new Dictionary<string, string>(response.Headers, StringComparer.OrdinalIgnoreCase);
            _body = response.Body ?? Array.Empty<byte>();

            StatusCode = response.StatusCode;
            IsSuccessStatusCode = (int)response.StatusCode >= 200 && (int)response.StatusCode <= 299;
            ContentLength = _body.Length;
            ContentType = response.ContentType;
            if (ContentType == null && _headers.TryGetValue("Content-Type", out var contentType))
                ContentType = contentType;
            if (ContentType != null && !_headers.ContainsKey("Content-Type"))
                _headers["Content-Type"] = ContentType;
            if (!_headers.ContainsKey("Content-Length"))
                _headers["Content-Length"] = _body.Length.ToString();

            ResponseBody = new MockHttpResponseBody(_body);
        }

        public long ContentLength { get; }

        public string ContentType { get; }

        public HttpStatusCode StatusCode { get; }

        public bool IsSuccessStatusCode { get; }

        public IHttpResponseBody ResponseBody { get; }

        public string[] GetHeaderNames() => _headers.Keys.ToArray();

        public bool IsHeaderPresent(string headerName) => _headers.ContainsKey(headerName);

        public string GetHeaderValue(string headerName) => _headers.TryGetValue(headerName, out var value) ? value : null;

        public IEventStreamHeader GetEventStreamHeader(string headerName) => null;

        public bool IsEventHeaderPresent(string headerName) => false;
    }

    /// <summary>
    /// Response body that serves the canned bytes for both the sync and async unmarshalling paths.
    /// </summary>
    internal class MockHttpResponseBody : IHttpResponseBody
    {
        private readonly byte[] _body;
        private MemoryStream _stream;

        public MockHttpResponseBody(byte[] body)
        {
            _body = body;
        }

        public Stream OpenResponse()
        {
            _stream = new MemoryStream(_body, writable: false);
            return _stream;
        }

        public Task<Stream> OpenResponseAsync() => Task.FromResult(OpenResponse());

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}
