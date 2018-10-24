﻿/*  
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime
{

    /// <summary>
    /// A factory which creates HTTP requests which uses System.Net.Http.HttpClient.
    /// </summary>
    [CLSCompliant(false)]
    public class HttpRequestMessageFactory : IHttpRequestFactory<HttpContent>
    {
        // This is the global cache of HttpClient for service clients that are using 
        static readonly ReaderWriterLockSlim _httpClientCacheRWLock = new ReaderWriterLockSlim();
        static readonly IDictionary<string, HttpClientCache> _httpClientCaches = new Dictionary<string, HttpClientCache>();


        private HttpClientCache _httpClientCache;
        private IClientConfig _clientConfig;

        /// <summary>
        /// The constructor for HttpRequestMessageFactory.
        /// </summary>
        /// <param name="clientConfig">Configuration setting for a client.</param>
        public HttpRequestMessageFactory(IClientConfig clientConfig)
        {
            _clientConfig = clientConfig;
        }

        /// <summary>
        /// Creates an HTTP request for the given URI.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>An HTTP request.</returns>
        public IHttpRequest<HttpContent> CreateHttpRequest(Uri requestUri)
        {
            HttpClient httpClient = null;
            if(_clientConfig.CacheHttpClient)
            {
                if(_httpClientCache == null)
                {
                    if (!CanClientConfigBeSerialized(_clientConfig))
                    {
                        _httpClientCacheRWLock.EnterWriteLock();
                        try
                        {
                            if (_httpClientCache == null)
                            {
                                _httpClientCache = CreateHttpClientCache(_clientConfig);
                            }
                        }
                        finally
                        {
                            _httpClientCacheRWLock.ExitWriteLock();
                        }
                    }
                    else
                    {
                        // Check to see if an HttpClient was created by another service client with the 
                        // same settings on the ClientConfig.
                        var configUniqueString = CreateConfigUniqueString(_clientConfig);
                        _httpClientCacheRWLock.EnterReadLock();
                        try
                        {
                            _httpClientCaches.TryGetValue(configUniqueString, out _httpClientCache);
                        }
                        finally
                        {
                            _httpClientCacheRWLock.ExitReadLock();
                        }

                        // If a HttpClientCache is not found in the global cache then create one
                        // for this and other service clients to use.
                        if (_httpClientCache == null)
                        {
                            _httpClientCacheRWLock.EnterWriteLock();
                            try
                            {
                                // Check if the HttpClientCache was created by some other thread 
                                // while this thread was waiting for the lock.
                                if (!_httpClientCaches.TryGetValue(configUniqueString, out _httpClientCache))
                                {
                                    _httpClientCache = CreateHttpClientCache(_clientConfig);
                                    _httpClientCaches[configUniqueString] = _httpClientCache;
                                }
                            }
                            finally
                            {
                                _httpClientCacheRWLock.ExitWriteLock();
                            }
                        }
                    }
                }

                // Now that we have a HttpClientCache from either the global cache or just created a new HttpClientCache
                // get the next HttpClient to be used for making a web request.
                httpClient = _httpClientCache.GetNextClient();
            }
            else
            {
                httpClient = CreateHttpClient(_clientConfig);
            }


            return new HttpWebRequestMessage(httpClient, requestUri, _clientConfig);
        }

        /// <summary>
        /// Disposes the HttpRequestMessageFactory.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose the factory
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
        }

        private static HttpClientCache CreateHttpClientCache(IClientConfig clientConfig)
        {
            var clients = new HttpClient[clientConfig.HttpClientCacheSize];
            for(int i = 0; i < clients.Length; i++)
            {
                clients[i] = CreateHttpClient(clientConfig);
            }
            var cache = new HttpClientCache(clients);
            return cache;
        }

        private static HttpClient CreateHttpClient(IClientConfig clientConfig)
        {
            var httpMessageHandler = new HttpClientHandler();
#if CORECLR
            if (clientConfig.MaxConnectionsPerServer.HasValue)
                httpMessageHandler.MaxConnectionsPerServer = clientConfig.MaxConnectionsPerServer.Value;
#endif

            // If HttpClientHandler.AllowAutoRedirect is set to true (default value),
            // redirects for GET requests are automatically followed and redirects for POST
            // requests are thrown back as exceptions.
            // If HttpClientHandler.AllowAutoRedirect is set to false (e.g. S3),
            // redirects are returned as responses.
            httpMessageHandler.AllowAutoRedirect = clientConfig.AllowAutoRedirect;

            // Disable automatic decompression when Content-Encoding header is present
            httpMessageHandler.AutomaticDecompression = DecompressionMethods.None;

            var proxy = clientConfig.GetWebProxy();
            if (proxy != null)
            {
                httpMessageHandler.Proxy = proxy;
            }

            if (httpMessageHandler.Proxy != null && clientConfig.ProxyCredentials != null)
            {
                httpMessageHandler.Proxy.Credentials = clientConfig.ProxyCredentials;
            }

            var httpClient = new HttpClient(httpMessageHandler);
            if (clientConfig.Timeout.HasValue)
            {
                // Timeout value is set to ClientConfig.MaxTimeout for S3 and Glacier.
                // Use default value (100 seconds) for other services.
                httpClient.Timeout = clientConfig.Timeout.Value;
            }

            return httpClient;
        }

    /// <summary>
        ///  Create a unique string used for caching the HttpClient based on the settings that are used from the ClientConfig that are set on the HttpClient.
        /// </summary>
        /// <param name="clientConfig"></param>
        /// <returns></returns>
        private static string CreateConfigUniqueString(IClientConfig clientConfig)
        {
            string uniqueString = string.Empty;
            uniqueString = string.Concat("AllowAutoRedirect:", clientConfig.AllowAutoRedirect.ToString(), "CacheSize:", clientConfig.HttpClientCacheSize);

            if (clientConfig.Timeout.HasValue)
                uniqueString = string.Concat(uniqueString, "Timeout:", clientConfig.Timeout.Value.ToString());

#if CORECLR
            if (clientConfig.MaxConnectionsPerServer.HasValue)
                uniqueString = string.Concat(uniqueString, "MaxConnectionsPerServer:", clientConfig.MaxConnectionsPerServer.Value.ToString());
#endif

            return uniqueString;
        }

        /// <summary>
        /// If proxy or proxy credentials are set this returns false because those properties can't be
        /// serialized as part of the key in the global http client cache.
        /// </summary>
        private static bool CanClientConfigBeSerialized(IClientConfig clientConfig)
        {
#if CORECLR
            return clientConfig.ProxyCredentials == null && clientConfig.GetWebProxy() == null;
#else
            return clientConfig.ProxyCredentials == null;
#endif
        }
    }

    /// <summary>
    /// A cache of HttpClient objects. The GetNextClient method does a round robin cycle through the clients
    /// to distribute the load even across.
    /// </summary>
    public class HttpClientCache
    {
        HttpClient[] _clients;

        /// <summary>
        /// Constructs a container for a cache of HttpClient objects
        /// </summary>
        /// <param name="clients">The HttpClient to cache</param>
        public HttpClientCache(HttpClient[] clients)
        {
            _clients = clients;
        }

        private int count = 0;
        /// <summary>
        /// Returns the next HttpClient using a round robin rotation. It is expected that individual clients will be used
        /// by more then one Thread.
        /// </summary>
        /// <returns></returns>
        public HttpClient GetNextClient()
        {
            if (_clients.Length == 1)
            {
                return _clients[0];
            }
            else
            {
                int next = Interlocked.Increment(ref count);
                int nextIndex = Math.Abs(next % _clients.Length);
                return _clients[nextIndex];
            }
        }
    }

    /// <summary>
    /// HTTP request wrapper for System.Net.Http.HttpRequestMessage.
    /// </summary>    
    [CLSCompliant(false)]
    public class HttpWebRequestMessage : IHttpRequest<HttpContent>
    {

        /// <summary>
        /// Set of content header names.
        /// </summary>
        private static HashSet<string> ContentHeaderNames = new HashSet<string>
        {
            HeaderKeys.ContentLengthHeader,
            HeaderKeys.ContentTypeHeader,
            HeaderKeys.ContentRangeHeader,
            HeaderKeys.ContentMD5Header,
            HeaderKeys.ContentEncodingHeader,
            HeaderKeys.ContentDispositionHeader,
            HeaderKeys.Expires
        };

        private bool _disposed;
        private HttpRequestMessage _request;
        private HttpClient _httpClient;
        private IClientConfig _clientConfig;

        /// <summary>
        /// The constructor for HttpWebRequestMessage.
        /// </summary>
        /// <param name="httpClient">The HttpClient used to make the request.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="config">The service client config.</param>
        public HttpWebRequestMessage(HttpClient httpClient, Uri requestUri, IClientConfig config)
        {
            _clientConfig = config;
            _httpClient = httpClient;

            _request = new HttpRequestMessage();
            _request.RequestUri = requestUri;
        }

        /// <summary>
        /// The underlying HttpClient
        /// </summary>
        public HttpClient HttpClient
        {
            get { return _httpClient; }
        }

        /// <summary>
        /// The underlying HTTP web request.
        /// </summary>
        public HttpRequestMessage Request
        {
            get { return _request; }
        }

        /// <summary>
        /// The HTTP method or verb.
        /// </summary>
        public string Method
        {
            get { return _request.Method.Method; }
            set { _request.Method = new HttpMethod(value); }
        }

        /// <summary>
        /// The request URI.
        /// </summary>
        public Uri RequestUri
        {
            get { return _request.RequestUri; }
        }

        /// <summary>
        /// Configures a request as per the request context.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        public void ConfigureRequest(IRequestContext requestContext)
        {
            // Configure the Expect 100-continue header
            if (requestContext != null && requestContext.OriginalRequest != null)
            {
                _request.Headers.ExpectContinue = requestContext.OriginalRequest.GetExpect100Continue();
            }
        }

        /// <summary>
        /// Sets the headers on the request.
        /// </summary>
        /// <param name="headers">A dictionary of header names and values.</param>
        public void SetRequestHeaders(IDictionary<string, string> headers)
        {
            foreach (var kvp in headers)
            {
                if (ContentHeaderNames.Contains(kvp.Key, StringComparer.OrdinalIgnoreCase))
                    continue;

                _request.Headers.TryAddWithoutValidation(kvp.Key, kvp.Value);
            }
        }

        /// <summary>
        /// Gets a handle to the request content.
        /// </summary>
        /// <returns>The request content.</returns>
        public HttpContent GetRequestContent()
        {
            try
            {
                return this.GetRequestContentAsync().Result;
            }
            catch (AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// Returns the HTTP response.
        /// </summary>
        /// <returns>The HTTP response.</returns>
        public IWebResponseData GetResponse()
        {
            try
            {
                return this.GetResponseAsync(System.Threading.CancellationToken.None).Result;
            }
            catch (AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// Aborts the HTTP request.
        /// </summary>
        public void Abort()
        {
            // NOP since HttRequestMessage does not have an Abort operation.     
        }

        /// <summary>
        /// Returns the HTTP response.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
        {
            try
            {
                var responseMessage = await _httpClient.SendAsync(_request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                bool disposeClient = !_clientConfig.CacheHttpClient;
                // If AllowAutoRedirect is set to false, HTTP 3xx responses are returned back as response.
                if (!_clientConfig.AllowAutoRedirect &&
                    responseMessage.StatusCode >= HttpStatusCode.Ambiguous &&
                    responseMessage.StatusCode < HttpStatusCode.BadRequest)
                {
                    return new HttpClientResponseData(responseMessage, _httpClient, disposeClient);
                }

                if (!responseMessage.IsSuccessStatusCode)
                {
                    // For all responses other than HTTP 2xx, return an exception.
                    throw new Amazon.Runtime.Internal.HttpErrorResponseException(
                        new HttpClientResponseData(responseMessage, _httpClient, disposeClient));
                }

                return new HttpClientResponseData(responseMessage, _httpClient, disposeClient);
            }
            catch (HttpRequestException e)
            {
                if (e.InnerException != null)
                {
                    if (e.InnerException is IOException)
                        throw e.InnerException;
#if !CORECLR
                    if (e.InnerException is WebException)
                        throw e.InnerException;
#endif
                }

                throw;
            }
        }

        /// <summary>
        /// Writes a stream to the request body.
        /// </summary>
        /// <param name="requestContent">The destination where the content stream is written.</param>
        /// <param name="contentStream">The content stream to be written.</param>
        /// <param name="contentHeaders">HTTP content headers.</param>
        /// <param name="requestContext">The request context.</param>
        public void WriteToRequestBody(HttpContent requestContent, Stream contentStream,
            IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            var wrapperStream = new Amazon.Runtime.Internal.Util.NonDisposingWrapperStream(contentStream);
            _request.Content = new StreamContent(wrapperStream, requestContext.ClientConfig.BufferSize);
            _request.Content.Headers.ContentLength = contentStream.Length;
            WriteContentHeaders(contentHeaders);
        }

        /// <summary>
        /// Writes a byte array to the request body.
        /// </summary>
        /// <param name="requestContent">The destination where the content stream is written.</param>
        /// <param name="content">The content stream to be written.</param>
        /// <param name="contentHeaders">HTTP content headers.</param>
        public void WriteToRequestBody(HttpContent requestContent,
            byte[] content, IDictionary<string, string> contentHeaders)
        {
            _request.Content = new ByteArrayContent(content);
            _request.Content.Headers.ContentLength = content.Length;
            WriteContentHeaders(contentHeaders);
        }

        /// <summary>
        /// Gets a handle to the request content.
        /// </summary>
        /// <returns></returns>
        public System.Threading.Tasks.Task<HttpContent> GetRequestContentAsync()
        {
            return System.Threading.Tasks.Task.FromResult(_request.Content);
        }


        private void WriteContentHeaders(IDictionary<string, string> contentHeaders)
        {
            _request.Content.Headers.ContentType =
                MediaTypeHeaderValue.Parse(contentHeaders[HeaderKeys.ContentTypeHeader]);

            if (contentHeaders.ContainsKey(HeaderKeys.ContentRangeHeader))
                _request.Content.Headers.TryAddWithoutValidation(HeaderKeys.ContentRangeHeader,
                    contentHeaders[HeaderKeys.ContentRangeHeader]);

            if (contentHeaders.ContainsKey(HeaderKeys.ContentMD5Header))
                _request.Content.Headers.TryAddWithoutValidation(HeaderKeys.ContentMD5Header,
                    contentHeaders[HeaderKeys.ContentMD5Header]);

            if (contentHeaders.ContainsKey(HeaderKeys.ContentEncodingHeader))
                _request.Content.Headers.TryAddWithoutValidation(HeaderKeys.ContentEncodingHeader,
                    contentHeaders[HeaderKeys.ContentEncodingHeader]);

            if (contentHeaders.ContainsKey(HeaderKeys.ContentDispositionHeader))
                _request.Content.Headers.TryAddWithoutValidation(HeaderKeys.ContentDispositionHeader,
                    contentHeaders[HeaderKeys.ContentDispositionHeader]);

            DateTime expires;
            if (contentHeaders.ContainsKey(HeaderKeys.Expires) &&
                DateTime.TryParse(contentHeaders[HeaderKeys.Expires], CultureInfo.InvariantCulture, DateTimeStyles.None, out expires))
                _request.Content.Headers.Expires = expires;
        }

        /// <summary>
        /// Disposes the HttpWebRequestMessage.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (_request != null)
                    _request.Dispose();

                _disposed = true;
            }
        }

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
            var eventStream = new EventStream(originalStream, true);
            var tracker = new StreamReadTracker(sender, callback, originalStream.Length,
                progressUpdateInterval);
            eventStream.OnRead += tracker.ReadProgress;
            return eventStream;
        }
    }
}
