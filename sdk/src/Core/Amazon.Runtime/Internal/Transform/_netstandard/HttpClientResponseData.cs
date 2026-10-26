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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Transform
{
    public class HttpClientResponseData : IWebResponseData
    {
        HttpResponseMessageBody _response;
        string[] _headerNames;
        Dictionary<string, string> _headers;
        private Dictionary<string, IEventStreamHeader> _eventHeaders;

        internal HttpClientResponseData(Dictionary<string, IEventStreamHeader> eventHeaders)
        {
            _response = null;
            _eventHeaders = eventHeaders;
            _headers = new Dictionary<string,string>();
        }
        internal HttpClientResponseData(HttpResponseMessage response)
            : this(response, null, false)
        {
        }

        internal HttpClientResponseData(HttpResponseMessage response, HttpClient httpClient, bool disposeClient)
        {
            _response = new HttpResponseMessageBody(response, httpClient, disposeClient);

            this.StatusCode = response.StatusCode;
            this.IsSuccessStatusCode = response.IsSuccessStatusCode;
            this.ContentLength = response.Content.Headers.ContentLength ?? 0;

            if (response.Content.Headers.ContentType != null)
            {
                this.ContentType = response.Content.Headers.ContentType.MediaType;
            }
            CopyHeaderValues(response);
        }

        public HttpStatusCode StatusCode { get; private set; }

        public bool IsSuccessStatusCode { get; private set; }

        public string ContentType { get; private set; }

        public long ContentLength { get; private set; }

        public string GetHeaderValue(string headerName)
        {
            string headerValue;
            if(_headers.TryGetValue(headerName, out headerValue))
                return headerValue;

            return string.Empty;
        }

        public bool IsHeaderPresent(string headerName)
        {
            // _headers is keyed case-insensitively, so it doubles as the name set.
            return _headers.ContainsKey(headerName);
        }

        public string[] GetHeaderNames()
        {
            return _headerNames;
        }

        private void CopyHeaderValues(HttpResponseMessage response)
        {
            List<string> headerNames = new List<string>();
            _headers = new Dictionary<string, string>(10, StringComparer.OrdinalIgnoreCase);

            foreach (KeyValuePair<string, IEnumerable<string>> kvp in response.Headers)
            {
                headerNames.Add(kvp.Key);
                _headers.Add(kvp.Key, kvp.Value.FirstOrDefault() ?? string.Empty);
            }

            if (response.Content != null)
            {
                foreach (var kvp in response.Content.Headers)
                {
                    if (!_headers.ContainsKey(kvp.Key))
                    {
                        headerNames.Add(kvp.Key);
                        _headers.Add(kvp.Key, kvp.Value.FirstOrDefault() ?? string.Empty);
                    }
                }
            }
            _headerNames = headerNames.ToArray();
        }

        public IEventStreamHeader GetEventStreamHeader(string headerName)
        {
            if (_eventHeaders.ContainsKey(headerName))
                return _eventHeaders[headerName];
            return null;
        }

        public bool IsEventHeaderPresent(string headerName)
        {
            return _eventHeaders.ContainsKey(headerName);
        }

        public IHttpResponseBody ResponseBody
        {
            get { return _response; }
        }
    }

    public class HttpResponseMessageBody : IHttpResponseBody
    {
        HttpClient _httpClient;
        HttpResponseMessage _response;
        bool _disposeClient = false;
        bool _disposed = false;

        public HttpResponseMessageBody(HttpResponseMessage response, HttpClient httpClient, bool disposeClient)
        {
            _httpClient = httpClient;
            _response = response;
            _disposeClient = disposeClient;
        }

        public Stream OpenResponse()
        {
            if (_disposed)
                throw new ObjectDisposedException("HttpWebResponseBody");

            return _response.Content.ReadAsStreamAsync().Result;
        }

        public Task<Stream> OpenResponseAsync()
        {
            if (_disposed)
                throw new ObjectDisposedException("HttpWebResponseBody");

            return _response.Content.ReadAsStreamAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (_response != null)
                    _response.Dispose();

                if (_httpClient != null && _disposeClient)
                    _httpClient.Dispose();

                _disposed = true;
            }
        }

        
    }
}
