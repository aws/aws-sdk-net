/*
* Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using UnityEngine;
using Amazon.Runtime.Internal.Util;
using Logger = Amazon.Runtime.Internal.Util.Logger;
using ILogger = Amazon.Runtime.Internal.Util.ILogger;
using UnityEngine.Experimental.Networking;
using System.Text;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Implementation of response interface for WWW/UnityWebRequest API.
    /// </summary>
    public sealed class UnityWebResponseData : IWebResponseData, IHttpResponseBody
    {
        private Dictionary<string, string> _headers;
        private string[] _headerNames;
        private HashSet<string> _headerNamesSet;
        private Stream _responseStream;
        private byte[] _responseBody;
        private ILogger _logger;

        public UnityWebResponseData(UnityWebRequestWrapper unityWebRequest)
        {
            CopyHeaderValues(unityWebRequest.ResponseHeaders);
            if (!unityWebRequest.IsError)
            {
                _responseBody = unityWebRequest.DownloadHandler.Data;

                if (_responseBody == null)
                {
                    _responseBody = new byte[0];
                }

                _responseStream = new MemoryStream(_responseBody);

                this.ContentLength = _responseBody.LongLength;

                string contentType = null;

                this._headers.TryGetValue(HeaderKeys.ContentTypeHeader, out contentType);

                this.ContentType = contentType;

                if (unityWebRequest.StatusCode.HasValue)
                    this.StatusCode = unityWebRequest.StatusCode.Value;

                this.IsSuccessStatusCode = this.StatusCode >= HttpStatusCode.OK && this.StatusCode <= (HttpStatusCode)299;
            }
            else
            {
                this.IsSuccessStatusCode = false;
                this._responseBody = UTF8Encoding.UTF8.GetBytes(unityWebRequest.Error);
                _responseStream = new MemoryStream(_responseBody);
                
                if (unityWebRequest.DownloadedBytes > 0)
                {
                    this.ContentLength = (long)unityWebRequest.DownloadedBytes;
                }
                else
                {
                    string contentLength = null;
                    if (this._headers.TryGetValue(HeaderKeys.ContentLengthHeader, out contentLength))
                    {
                        long cl;
                        if(long.TryParse(contentLength,out cl))
                            this.ContentLength = cl;
                        else
                            this.ContentLength = 0;
                    }
                    else
                    {
                        this.ContentLength = this._responseBody.Length;
                    }
                }

                if (unityWebRequest.StatusCode.HasValue)
                {
                    this.StatusCode = unityWebRequest.StatusCode.Value;
                }
                else
                {
                    string statusCode = null;
                    if (this._headers.TryGetValue(HeaderKeys.StatusHeader, out statusCode))
                    {
                        this.StatusCode = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), statusCode);
                    }
                    else
                    {
                        this.StatusCode = 0;
                    }
                }
            }
        }

        /// <summary>
        /// The constructor for UnityWebResponseData.
        /// </summary>
        /// <param name="wwwRequest">
        /// An instance of WWW after the web request has 
        /// completed and response fields are set
        /// </param>
        public UnityWebResponseData(WWW wwwRequest)
        {
            _logger = Logger.GetLogger(this.GetType());
            CopyHeaderValues(wwwRequest.responseHeaders);

            try
            {
                _responseBody = wwwRequest.bytes;
            }
            catch (Exception)
            {
                _responseBody = null;
            }

            if ((_responseBody != null && _responseBody.Length > 0) || (_responseBody.Length == 0 && wwwRequest.error == null))
            {
                _responseStream = new MemoryStream(_responseBody);
            }

            this.ContentLength = wwwRequest.bytesDownloaded;

            string contentType = null;
            this._headers.TryGetValue(
                HeaderKeys.ContentTypeHeader, out contentType);
            this.ContentType = contentType;
            try
            {
                if (string.IsNullOrEmpty(wwwRequest.error))
                {
                    string statusHeader = string.Empty;
                    if (this._headers.TryGetValue(HeaderKeys.StatusHeader, out statusHeader))
                    {
                        this.StatusCode = (HttpStatusCode)Enum.Parse(
                        typeof(HttpStatusCode),
                        statusHeader.Substring(9, 3).Trim());
                    }
                    else
                    {
                        this.StatusCode = 0;
                    }
                }
                else
                {
                    int statusCode;
                    if (Int32.TryParse(wwwRequest.error.Substring(0, 3), out statusCode))
                        this.StatusCode = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode),
                                            wwwRequest.error.Substring(3).Replace(" ", "").Replace(":", "").Trim(), true);//ignored case
                    else
                        this.StatusCode = 0;
                }
            }
            catch
            {
                this.StatusCode = 0;
            }
            this.IsSuccessStatusCode = wwwRequest.error == null ? true : false;
        }

        /// <summary>
        /// Content length on the response.
        /// </summary>
        public long ContentLength { get; private set; }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        public string ContentType { get; private set; }

        /// <summary>
        /// The HTTP status code for the response.
        /// </summary>
        public HttpStatusCode StatusCode { get; private set; }

        /// <summary>
        /// Returns a boolean value indicating if the status code 
        /// indicated a success.
        /// </summary>
        public bool IsSuccessStatusCode { get; private set; }


        public bool IsHeaderPresent(string headerName)
        {
            return _headerNamesSet.Contains(headerName);
        }

        public string[] GetHeaderNames()
        {
            return _headerNames;
        }

        public string GetHeaderValue(string name)
        {
            string headerValue;
            if (_headers.TryGetValue(name, out headerValue))
                return headerValue;

            return string.Empty;
        }

        private void CopyHeaderValues(Dictionary<string, string> headers)
        {
            _headers = new Dictionary<string, string>(headers, StringComparer.OrdinalIgnoreCase);
            _headerNames = headers.Keys.ToArray<string>();
            _headerNamesSet = new HashSet<string>(_headerNames, StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Instance of IHttpResponseBody.
        /// </summary>
        public IHttpResponseBody ResponseBody
        {
            get { return this; }
        }

        /// <summary>
        /// Bool value which is returned if there is response body present
        /// </summary>
        public bool IsResponseBodyPresent
        {
            get
            {
                return _responseBody != null && _responseBody.Length > 0;
            }
        }

        #region IHttpResponseBody implementation

        /// <summary>
        /// Returns a stream that allows reading the response body.
        /// </summary>
        /// <returns>A stream representing the response body.</returns>
        public Stream OpenResponse()
        {
            return _responseStream;
        }

        /// <summary>
        /// Disposes the response stream.
        /// </summary>
        public void Dispose()
        {
            if (_responseStream != null)
            {
                _responseStream.Dispose();
                _responseStream = null;
            }
        }

        #endregion
    }
}