﻿/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// The web request factory for Unity.
    /// </summary>
    public sealed class UnityWebRequestFactory : IHttpRequestFactory<string>
    {
        private UnityRequest _unityRequest;

        /// <summary>
        /// Creates an HTTP request for the given URI.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>An HTTP request.</returns>
        public IHttpRequest<string> CreateHttpRequest(Uri requestUri)
        {
            _unityRequest = new UnityRequest(requestUri);
            return _unityRequest;
        }

        public void Dispose()
        {
            if (_unityRequest != null)
                _unityRequest.Dispose();
        }
    }

    /// <summary>
    /// An IHttpRequest implementation for Unity's WWW API.
    /// </summary>
    public sealed class UnityRequest : IHttpRequest<string>, IUnityHttpRequest
    {
        /// <summary>
        /// The request URI.
        /// </summary>
        public Uri RequestUri { get; private set; }

        /// <summary>
        /// The WWW instance for this web request.
        /// </summary>
        public IDisposable WwwRequest { get; set; }

        /// <summary>
        /// The content to be sent in the request body.
        /// </summary>
        public byte[] RequestContent { get; private set; }

        /// <summary>
        /// The headers to be sent for this request.
        /// </summary>
        public Dictionary<string, string> Headers { get; private set; }

        /// <summary>
        /// The callback to be invoked after BeginGetResponse completes.
        /// </summary>
        public AsyncCallback Callback { get; private set; }

        /// <summary>
        /// The IAsyncResult for the BeginGetResponse method.
        /// This stores the async state to be passed to the callback after this request
        /// is procesed by the UnityMainThreadDispatcher.
        /// </summary>
        public IAsyncResult AsyncResult { get; private set; }

        /// <summary>
        /// A wait handle that is used to implement the synchronous
        /// GetResponse method.
        /// </summary>
        public ManualResetEvent WaitHandle { get; private set; }

        /// <summary>
        /// A flag to indicate if this request is being invoked
        /// synchronously.
        /// </summary>
        public bool IsSync { get; set; }

        /// <summary>
        /// The response for this web request.
        /// </summary>
        public IWebResponseData Response { get; set; }

        /// <summary>
        /// Any exceptions resulting from this web request
        /// are set on this property.
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// The HTTP method or verb.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// The contructor for UnityWebRequest.
        /// </summary>
        /// <param name="requestUri">Uri for the request.</param>
        public UnityRequest(Uri requestUri)
        {
            this.RequestUri = requestUri;
            this.Headers = new Dictionary<string, string>();
        }

        /// <summary>
        /// Configures a request as per the request context.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        public void ConfigureRequest(IRequestContext requestContext)
        {
            // Advanced configurations (like timeout) are not supported
            // in the WWW API.
        }

        /// <summary>
        /// Sets the headers on the request.
        /// </summary>
        /// <param name="headers">A dictionary of header names and values.</param>
        public void SetRequestHeaders(IDictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                //unity web request doesnt allow us to add the Host, User-Agent and Content-Length headers
                if (header.Key.Equals(HeaderKeys.HostHeader, StringComparison.InvariantCultureIgnoreCase)
                        || header.Key.Equals(HeaderKeys.ContentLengthHeader, StringComparison.InvariantCultureIgnoreCase)
                        || header.Key.Equals(HeaderKeys.UserAgentHeader, StringComparison.InvariantCultureIgnoreCase))
                    continue;

                this.Headers.Add(header);
            }
        }

        /// <summary>
        /// Gets a handle to the request content.
        /// </summary>
        /// <returns>The request content.</returns>
        public string GetRequestContent()
        {
            return string.Empty;
        }

        /// <summary>
        /// Returns the HTTP response.
        /// </summary>
        /// <returns>The HTTP response.</returns>
        public IWebResponseData GetResponse()
        {
            if (UnityInitializer.IsMainThread())
                throw new Exception("Cannot execute synchronous calls on game thread");

            this.IsSync = true;
            this.WaitHandle = new ManualResetEvent(false);
            try
            {
                UnityRequestQueue.Instance.EnqueueRequest(this);
                this.WaitHandle.WaitOne();

                if (this.Exception != null)
                    throw this.Exception;

                //timeout scenario
                if (this.Exception == null && this.Response == null)
                    throw new WebException("Request timed out", WebExceptionStatus.Timeout);

                return this.Response;
            }
            finally
            {
                this.WaitHandle.Close();
            }
        }

        /// <summary>
        /// Writes a stream to the request body.
        /// </summary>
        /// <param name="requestContent">The destination where the content stream is written.</param>
        /// <param name="contentStream">The content stream to be written.</param>
        /// <param name="contentHeaders">HTTP content headers.</param>
        /// <param name="requestContext">The request context.</param>
        public void WriteToRequestBody(string requestContent, Stream contentStream,
            IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            var buffer = new byte[AWSSDKUtils.DefaultBufferSize];
            using (MemoryStream memoryStream = new MemoryStream())
            {
                int read;
                while ((read = contentStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, read);
                }
                this.RequestContent = memoryStream.ToArray();
            }
        }

        /// <summary>
        /// Writes a byte array to the request body.
        /// </summary>
        /// <param name="requestContent">The destination where the content is written.</param>
        /// <param name="content">The content to be written.</param>
        /// <param name="contentHeaders">HTTP content headers.</param>
        public void WriteToRequestBody(string requestContent, byte[] content,
            IDictionary<string, string> contentHeaders)
        {
            this.RequestContent = content;
        }

        /// <summary>
        /// Aborts the HTTP request.
        /// </summary>
        public void Abort()
        {
            // Not supported by the WWW API. 
        }

        /// <summary>
        /// Initiates the operation to gets a handle to the request content.
        /// </summary>
        /// <param name="callback">The async callback invoked when the operation completes.</param>
        /// <param name="state">The state object to be passed to the async callback.</param>
        /// <returns>IAsyncResult that represents an async operation.</returns>
        public IAsyncResult BeginGetRequestContent(AsyncCallback callback, object state)
        {
            // The WWW API only allows representing the request body as a string,
            // it does not have a method which returns the request stream.
            // Invoke the callback synchronously to indicate that this method has completed execution.
            var result = new SimpleAsyncResult(state);

            //Invoke the callback synchronously
            callback(result);
            return result;
        }

        /// <summary>
        /// Ends the operation to gets a handle to the request content.
        /// </summary>
        /// <param name="asyncResult">IAsyncResult that represents an async operation.</param>
        /// <returns>The request content.</returns>
        public string EndGetRequestContent(IAsyncResult asyncResult)
        {
            return string.Empty;
        }

        /// <summary>
        /// Initiates the operation to returns the HTTP response.
        /// </summary>
        /// <param name="callback">The async callback invoked when the operation completes.</param>
        /// <param name="state">The state object to be passed to the async callback.</param>
        /// <returns>IAsyncResult that represents an async operation.</returns>
        public IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
            this.Callback = callback;
            this.AsyncResult = new SimpleAsyncResult(state);
            UnityRequestQueue.Instance.EnqueueRequest(this);
            return this.AsyncResult;
        }

        /// <summary>
        /// Ends the operation to Returns the HTTP response.
        /// </summary>
        /// <param name="asyncResult">IAsyncResult that represents an async operation.</param>
        /// <returns>The HTTP response.</returns>
        public IWebResponseData EndGetResponse(IAsyncResult asyncResult)
        {
            if (this.Exception != null)
            {
                throw this.Exception;
            }

            return this.Response;
        }

        public void Dispose()
        {
            Dispose(true);
        }
        

        private bool _disposed;

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                {
                    //has issues with ios, commenting it for now
                    //WwwRequest.Dispose();
                    _disposed = true;
                });
            }
        }

        private StreamReadTracker Tracker { get; set; }

        /// <summary>
        /// Sets up the progress listeners
        /// </summary>
        /// <param name="originalStream">The content stream</param>
        /// <param name="progressUpdateInterval">The interval at which progress needs to be published</param>
        /// <param name="sender">The objects which is trigerring the progress changes</param>
        /// <param name="callback">The callback which will be invoked when the progress changed event is trigerred</param>
        /// <returns>an <see cref="EventStream"/> object, incase the progress is setup, else returns the original stream</returns>
        public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
        {
            this.Tracker = new StreamReadTracker(sender, callback, originalStream.Length,
                progressUpdateInterval);

            return originalStream;
        }

        /// <summary>
        /// Track upload progress changes
        /// </summary>
        /// <param name="progress"></param>
        public void OnUploadProgressChanged(float progress)
        {
            if (this.Tracker != null)
            {
                this.Tracker.UpdateProgress(progress);
            }
        }
    }
}
