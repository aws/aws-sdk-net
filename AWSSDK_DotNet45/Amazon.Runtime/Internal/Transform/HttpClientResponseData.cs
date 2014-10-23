/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        HttpClient _httpClient;
        HttpResponseMessage _response;
        string[] _headerNames;
        HashSet<string> _headerNamesSet;

        internal HttpClientResponseData(HttpResponseMessage response)
            : this(response, null)
        {            
        }

        internal HttpClientResponseData(HttpResponseMessage response, HttpClient httpClient)
        {
            _httpClient = httpClient;
            this._response = response;

            this.StatusCode = _response.StatusCode;
            this.IsSuccessStatusCode = _response.IsSuccessStatusCode;
            this.ContentLength = _response.Content.Headers.ContentLength ?? 0;

            if (_response.Content.Headers.ContentType != null)
            {
                this.ContentType = _response.Content.Headers.ContentType.MediaType;
            }
        }

        public HttpStatusCode StatusCode { get; private set; }

        public bool IsSuccessStatusCode { get; private set; }

        public string ContentType { get; private set; }        

        public long ContentLength { get; private set; }

        public string GetHeaderValue(string headerName)
        {
            IEnumerable<string> headerValues;

            if(this._response.Content != null && this._response.Content.Headers.TryGetValues(headerName, out headerValues))
                return headerValues.FirstOrDefault();
            if(this._response.Headers.TryGetValues(headerName, out headerValues))
                return headerValues.FirstOrDefault();

            return null;
        }

        public bool IsHeaderPresent(string headerName)
        {
            if (_headerNamesSet == null)
                SetHeaderNames();
            return _headerNamesSet.Contains(headerName);
        }

        public string[] GetHeaderNames()
        {
            if (_headerNames == null)
            {
                SetHeaderNames();
            }
            return _headerNames;
        }

        private void SetHeaderNames()
        {
            List<string> headerNames = new List<string>();
            foreach (KeyValuePair<string,IEnumerable<string>> kvp in this._response.Headers)
            {
                headerNames.Add(kvp.Key);
            }
            if (this._response.Content != null)
            {
                foreach (var kvp in this._response.Content.Headers)
                {
                    if(!headerNames.Contains(kvp.Key))
                        headerNames.Add(kvp.Key);
                }
            }
            _headerNames = headerNames.ToArray();
            _headerNamesSet = new HashSet<string>(_headerNames, StringComparer.OrdinalIgnoreCase);
        }

        public IHttpResponseBody ResponseBody
        {
            get { return new HttpResponseMessageBody(_response, _httpClient); }
        }
    }

    public class HttpResponseMessageBody : IHttpResponseBody
    {
        HttpClient _httpClient;
        HttpResponseMessage _response;
        bool _disposed = false;

        public HttpResponseMessageBody(HttpResponseMessage response, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _response = response;
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

                if (_httpClient != null)
                    _httpClient.Dispose();

                _disposed = true;
            }
        }

        
    }
}
