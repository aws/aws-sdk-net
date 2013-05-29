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
using System.Net;
using System.Security;
using System.Text;
using System.Threading;

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.SecurityToken;
using Amazon.Util;



namespace Amazon.Runtime
{
    /// <summary>
    /// A base class for service clients that handles making the actual requests
    /// and possibly retries if needed.
    /// </summary>
    public abstract class AmazonWebServiceClient : IDisposable
    {
        #region Private members

        static IDictionary<string, RefreshingSessionAWSCredentials> cachedRefreshingCredentials = new Dictionary<string, RefreshingSessionAWSCredentials>();
        static object cachedRefreshingCredentialsLock = new object();

        [Flags]
        internal enum AuthenticationTypes
        {
            User = 0x1,
            Session = 0x2
        }

        internal static List<string> ErrorCodesToRetryOn = new List<string>
        {
            "Throttling",
            "ProvisionedThroughputExceededException"
        };

        protected const int MAX_BACKOFF_IN_MILLISECONDS = 30 * 1000;
        protected ClientConfig config;
        AWSCredentials credentials;
        bool ownCredentials;
        AuthenticationTypes authenticationType;

        bool disposed;
        Logger logger;

        #endregion


        #region Events

        /// <summary>
        /// Occurs before a request is issued against the service.
        /// </summary>
        public event RequestEventHandler BeforeRequestEvent;

        /// <summary>
        /// Occurs after a response is received from the service.
        /// </summary>
        public event ResponseEventHandler AfterResponseEvent;

        /// <summary>
        /// Occurs after an exception is encountered.
        /// </summary>
        public event ExceptionEventHandler ExceptionEvent;

        #endregion


        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonWebServiceClient
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing && credentials != null)
                {
                    if (ownCredentials)
                    {
                        credentials.Dispose();
                    }
                    credentials = null;
                }
                if (disposing && logger != null)
                {
                    logger.Flush();
                    logger = null;
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~AmazonWebServiceClient()
        {
            this.Dispose(false);
        }

        #endregion


        #region Constructors

        internal AmazonWebServiceClient(AWSCredentials credentials, ClientConfig config, bool ownCredentials, AuthenticationTypes authenticationType)
        {
            if (config.DisableLogging)
                this.logger = Logger.EmptyLogger;
            else
                this.logger = Logger.GetLogger(this.GetType());

            this.config = config;
            this.ownCredentials = ownCredentials;
            this.authenticationType = authenticationType;

            // Lookup cached version of refreshing credentials to reduce calls to STS.
            if (credentials is RefreshingSessionAWSCredentials)
            {
                RefreshingSessionAWSCredentials refreshCredentials = credentials as RefreshingSessionAWSCredentials;

                if (string.IsNullOrEmpty(refreshCredentials.UniqueIdentifier))
                {
                    this.credentials = credentials;
                }
                else
                {
                    this.ownCredentials = false;
                    lock (cachedRefreshingCredentialsLock)
                    {
                        if (cachedRefreshingCredentials.ContainsKey(refreshCredentials.UniqueIdentifier))
                        {
                            this.credentials = cachedRefreshingCredentials[refreshCredentials.UniqueIdentifier];
                        }
                        else
                        {
                            this.credentials = refreshCredentials;
                            cachedRefreshingCredentials[refreshCredentials.UniqueIdentifier] = refreshCredentials;
                        }
                    }
                }
            }
            else
            {
                this.credentials = credentials;
            }

            Initialize();
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, SecureString awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : this(authenticationType == AuthenticationTypes.Session ?
                    (AWSCredentials)new RefreshingSessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig() { UseSecureStringForAwsSecretKey = config.UseSecureStringForAwsSecretKey }) : 
                    (AWSCredentials)new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey, config.UseSecureStringForAwsSecretKey), 
                config, true, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config, AuthenticationTypes authenticationType)
            : this(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, config.UseSecureStringForAwsSecretKey), config, true, authenticationType)
        {
        }


        internal AmazonWebServiceClient(string awsAccessKeyId, SecureString awsSecretAccessKey, ClientConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true, AuthenticationTypes.User)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey, config.UseSecureStringForAwsSecretKey), config, true, AuthenticationTypes.User)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
            : this(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, config.UseSecureStringForAwsSecretKey), config, true, AuthenticationTypes.User)
        {
        }

        protected virtual void Initialize()
        {
        }

        #endregion


        #region Async methods

        protected void Invoke(AsyncResult asyncResult)
        {
            asyncResult.Metrics.StartEvent(RequestMetrics.Metric.ClientExecuteTime);
            asyncResult.Request.Endpoint = new Uri(this.config.DetermineServiceURL());
            if (config.LogMetrics)
            {
                asyncResult.Metrics.IsEnabled = true;
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.ServiceName, asyncResult.Request.ServiceName);
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.ServiceEndpoint, asyncResult.Request.Endpoint);
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.MethodName, asyncResult.RequestName);
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.AsyncCall, !asyncResult.CompletedSynchronously);
            }
            InvokeHelper(asyncResult);
        }

        private void InvokeHelper(AsyncResult asyncResult)
        {
            if (asyncResult.RetriesAttempt == 0 || config.ResignRetries)
            {
                ConfigureRequest(asyncResult);
            }
            if (asyncResult.RetriesAttempt > 0)
                asyncResult.Metrics.SetCounter(RequestMetrics.Metric.AttemptCount, asyncResult.RetriesAttempt);
            InvokeConfiguredRequest(asyncResult);
        }

        private void ConfigureRequest(AsyncResult asyncResult)
        {
            IRequest request = asyncResult.Request;

            request.Headers["User-Agent"] = this.config.UserAgent + " " + (asyncResult.CompletedSynchronously ? "ClientSync" : "ClientAsync");
            if (!request.Headers.ContainsKey(AWSSDKUtils.ContentTypeHeader))
            {
                if (request.UseQueryString)
                    request.Headers[AWSSDKUtils.ContentTypeHeader] = "application/x-amz-json-1.0";
                else
                    request.Headers[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
            }

            ProcessRequestHandlers(request);

            using (asyncResult.Metrics.StartEvent(RequestMetrics.Metric.RequestSigningTime))
            {
                SignRequest(request, asyncResult.Signer, asyncResult.Metrics);
            }

            if (request.ContentStream == null)
            {
                asyncResult.RequestData = GetRequestData(request);
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.RequestSize, asyncResult.RequestData.Length);
            }
            else
                asyncResult.RequestStream = request.ContentStream;
        }

        private void InvokeConfiguredRequest(AsyncResult asyncResult)
        {
            if (asyncResult.RetriesAttempt > 0 && asyncResult.RequestStream != null)
            {
                asyncResult.RequestStream.Position = 0;
            }

            HttpWebRequest webRequest = ConfigureWebRequest(asyncResult);
            asyncResult.RequestState = new AsyncResult.AsyncRequestState(webRequest, asyncResult.RequestData, asyncResult.RequestStream);
            asyncResult.Metrics.StartEvent(RequestMetrics.Metric.HttpRequestTime);

            if (asyncResult.CompletedSynchronously)
            {
                this.getRequestStreamCallback(asyncResult);
            }
            else
            {
                IAsyncResult httpResult;
                if (asyncResult != null
                    && asyncResult.RequestState != null
                    && (asyncResult.RequestState.WebRequest.Method == "POST" || asyncResult.RequestState.WebRequest.Method == "PUT"))
                {
                    httpResult = webRequest.BeginGetRequestStream(new AsyncCallback(this.getRequestStreamCallback), asyncResult);
                }
                else
                {
                    httpResult = webRequest.BeginGetResponse(new AsyncCallback(this.getResponseCallback), asyncResult);
                }

                if (httpResult.CompletedSynchronously)
                {
                    if (!asyncResult.RequestState.GetRequestStreamCallbackCalled)
                    {
                        getRequestStreamCallback(httpResult);
                    }
                    asyncResult.SetCompletedSynchronously(true);
                }
            }
        }


        private byte[] GetRequestData(IRequest request)
        {
            byte[] requestData;
            if (request.Content == null)
            {
                string queryString = AWSSDKUtils.GetParametersAsString(request.Parameters);
                requestData = Encoding.UTF8.GetBytes(queryString);
            }
            else
            {
                requestData = request.Content;
            }

            return requestData;
        }

        internal T endOperation<T>(IAsyncResult result)
            where T : AmazonWebServiceResponse, new()
        {
            AsyncResult asyncResult = result as AsyncResult;
            if (asyncResult == null)
                return default(T);


            if (!asyncResult.IsCompleted)
            {
                asyncResult.AsyncWaitHandle.WaitOne();
            }

            if (asyncResult.Exception != null)
            {
                AWSSDKUtils.PreserveStackTrace(asyncResult.Exception);
                throw asyncResult.Exception;
            }

            return asyncResult.FinalResponse as T;
        }

        void getRequestStreamCallback(IAsyncResult result)
        {
            AsyncResult asyncResult;
            if (result is AsyncResult)
                asyncResult = result as AsyncResult;
            else
                asyncResult = result.AsyncState as AsyncResult;

            asyncResult.RequestState.GetRequestStreamCallbackCalled = true;
            try
            {
                AsyncResult.AsyncRequestState state = asyncResult.RequestState;
                if (asyncResult != null
                    && asyncResult.RequestState != null
                    && ((asyncResult.RequestState.RequestData != null && asyncResult.RequestState.RequestData.Length > 0) || asyncResult.RequestState.RequestStream != null)
                    && (!asyncResult.Request.UseQueryString && (asyncResult.RequestState.WebRequest.Method == "POST" || asyncResult.RequestState.WebRequest.Method == "PUT")))
                {
                    Stream requestStream;
                    if (asyncResult.CompletedSynchronously)
                        requestStream = state.WebRequest.GetRequestStream();
                    else
                        requestStream = state.WebRequest.EndGetRequestStream(result);

                    using (requestStream)
                    {
                        if (asyncResult.RequestState.RequestStream == null)
                        {
                            byte[] requestData = asyncResult.RequestState.RequestData;
                            requestStream.Write(requestData, 0, requestData.Length);
                        }
                        else
                        {
                            var callback = asyncResult.Request.OriginalRequest.StreamUploadProgressCallback;
                            byte[] buffer = new byte[this.config.BufferSize];
                            int bytesRead = 0;
                            long totalBytesWritten = 0;
                            Stream inputStream = asyncResult.RequestState.RequestStream;
                            while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                requestStream.Write(buffer, 0, bytesRead);
                                totalBytesWritten += bytesRead;

                                if (callback != null)
                                {
                                    AWSSDKUtils.InvokeInBackground(
                                        callback,
                                        new StreamTransferProgressArgs(bytesRead, totalBytesWritten, inputStream.Length),
                                        this);
                                }
                            }

                        }
                    }
                }

                if (asyncResult.CompletedSynchronously)
                {
                    this.getResponseCallback(asyncResult);
                }
                else
                {
                    IAsyncResult httpResult = state.WebRequest.BeginGetResponse(new AsyncCallback(this.getResponseCallback), asyncResult);
                    if (httpResult.CompletedSynchronously)
                    {
                        if (!asyncResult.RequestState.GetResponseCallbackCalled)
                        {
                            getResponseCallback(httpResult);
                        }
                        asyncResult.SetCompletedSynchronously(true);
                    }
                }
            }
            catch (WebException e)
            {
                asyncResult.RequestState.WebRequest.Abort();
                if (handleHttpWebErrorResponse(asyncResult, e))
                {
                    asyncResult.RetriesAttempt++;
                    InvokeHelper(asyncResult);
                }
                else
                {
                    asyncResult.Exception = e;

                    asyncResult.SignalWaitHandle();
                    if (asyncResult.Callback != null)
                        asyncResult.Callback(asyncResult);
                }
            }
            catch (Exception e)
            {
                asyncResult.RequestState.WebRequest.Abort();
                asyncResult.Exception = e;
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.Exception, e);

                asyncResult.SignalWaitHandle();
                if (asyncResult.Callback != null)
                    asyncResult.Callback(asyncResult);
            }
        }

        void getResponseCallback(IAsyncResult result)
        {
            AsyncResult asyncResult;
            if (result is AsyncResult)
                asyncResult = result as AsyncResult;
            else
                asyncResult = result.AsyncState as AsyncResult;

            UnmarshallerContext context = null;
            asyncResult.RequestState.GetResponseCallbackCalled = true;
            bool shouldRetry = false;
            try
            {
                AsyncResult.AsyncRequestState state = asyncResult.RequestState;
                HttpWebResponse httpResponse = null;
                try
                {
                    if (asyncResult.CompletedSynchronously)
                        httpResponse = state.WebRequest.GetResponse() as HttpWebResponse;
                    else
                        httpResponse = state.WebRequest.EndGetResponse(result) as HttpWebResponse;

                    using (asyncResult.Metrics.StartEvent(RequestMetrics.Metric.ResponseProcessingTime))
                    {
                        var unmarshaller = asyncResult.Unmarshaller;
                        asyncResult.Metrics.AddProperty(RequestMetrics.Metric.StatusCode, httpResponse.StatusCode);
                        LogResponse(asyncResult, httpResponse.StatusCode);
                        try
                        {
                            context = unmarshaller.CreateContext(httpResponse, config.LogResponse || config.ReadEntireResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never, asyncResult);

                            AmazonWebServiceResponse response;
                            using (asyncResult.Metrics.StartEvent(RequestMetrics.Metric.ResponseUnmarshallTime))
                            {
                                response = unmarshaller.Unmarshall(context);
                            }
                            context.ValidateCRC32IfAvailable();

                            response.ContentLength = httpResponse.ContentLength;
                            asyncResult.FinalResponse = response;
                            asyncResult.Metrics.AddProperty(RequestMetrics.Metric.AWSRequestID, response.ResponseMetadata.RequestId);

                            LogFinishedResponse(asyncResult, context, httpResponse.ContentLength);
                            ProcessResponseHandlers(response, asyncResult.Request);
                        }
                        finally
                        {
                            if (!unmarshaller.HasStreamingProperty)
                                httpResponse.Close();
                        }
                    }
                }
                catch (WebException we)
                {
                    HttpWebResponse exceptionHttpResponse = we.Response as HttpWebResponse;
                    if (exceptionHttpResponse != null)
                    {
                        LogResponse(asyncResult, exceptionHttpResponse.StatusCode);
                    }
                    else
                    {
                        asyncResult.Metrics.StopEvent(RequestMetrics.Metric.HttpRequestTime);
                    }
                    shouldRetry = handleHttpWebErrorResponse(asyncResult, we);
                }
                catch (IOException ioe)
                {
                    LogResponse(asyncResult, HttpStatusCode.Unused);
                    shouldRetry = handleIOException(asyncResult, httpResponse, ioe);
                }

                if (shouldRetry)
                {
                    asyncResult.RequestState.WebRequest.Abort();
                    asyncResult.RetriesAttempt++;
                    InvokeHelper(asyncResult);
                }
                else
                {
                    LogFinalMetrics(asyncResult);
                }
            }
            catch (Exception e)
            {
                if (context != null && AWSConfigs.ResponseLogging == ResponseLoggingOption.OnError)
                    logger.Error(e, "Received response: [{0}]", context.ResponseBody);

                asyncResult.RequestState.WebRequest.Abort();
                asyncResult.Exception = e;
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.Exception, e);
                asyncResult.Metrics.StopEvent(RequestMetrics.Metric.ClientExecuteTime);
                shouldRetry = false;
                if (config.LogMetrics)
                    logger.InfoFormat("Request metrics: {0}", asyncResult.Metrics);

                ProcessExceptionHandlers(e, asyncResult.Request);
                logger.Error(e, "Error configuring web request {0} to {1}.", asyncResult.RequestName, asyncResult.Request.Endpoint.ToString());
            }
            finally
            {
                if (!shouldRetry)
                {
                    asyncResult.SignalWaitHandle();
                    if (asyncResult.Callback != null)
                        asyncResult.Callback(asyncResult);
                }
            }

        }

        private void LogFinalMetrics(AsyncResult asyncResult)
        {
            asyncResult.Metrics.StopEvent(RequestMetrics.Metric.ClientExecuteTime);
            if (config.LogMetrics)
            {
                string errors = asyncResult.Metrics.GetErrors();
                if (!string.IsNullOrEmpty(errors))
                    logger.InfoFormat("Request metrics errors: {0}", errors);
                logger.InfoFormat("Request metrics: {0}", asyncResult.Metrics);
            }
        }

        private void LogResponse(AsyncResult asyncResult, HttpStatusCode statusCode)
        {
            RequestMetrics.Timing timing = asyncResult.Metrics.StopEvent(RequestMetrics.Metric.HttpRequestTime);
            asyncResult.Metrics.AddProperty(RequestMetrics.Metric.StatusCode, statusCode);
        }

        private void LogFinishedResponse(AsyncResult asyncResult, UnmarshallerContext context, long contentLength)
        {
            asyncResult.Metrics.AddProperty(RequestMetrics.Metric.BytesProcessed, contentLength);
            if (config.LogResponse || AWSConfigs.ResponseLogging == ResponseLoggingOption.Always)
            {
                logger.DebugFormat("Received response: [{0}]", context.ResponseBody);
            }
        }

        bool handleIOException(AsyncResult asyncResult, HttpWebResponse httpResponse, IOException e)
        {
            asyncResult.Metrics.AddProperty(RequestMetrics.Metric.Exception, e);

            if (isInnerExceptionThreadAbort(e))
                throw e;

            logger.Error(e, "IOException making request {0} to {1}.", asyncResult.RequestName, asyncResult.Request.Endpoint.ToString());
            if (httpResponse != null)
            {
                httpResponse.Close();
                httpResponse = null;
            }
            // Abort the unsuccessful request
            asyncResult.RequestState.WebRequest.Abort();

            if (asyncResult.RetriesAttempt < config.MaxErrorRetry)
            {
                logger.Error(e, "IOException making request {0} to {1}. Attempting retry {2}.",
                        asyncResult.RequestName,
                        asyncResult.Request.Endpoint.ToString(),
                        asyncResult.RetriesAttempt);
                return true;
            }
            else
            {
                return false;
            }
        }

        bool handleHttpWebErrorResponse(AsyncResult asyncResult, WebException we)
        {
            asyncResult.Metrics.AddProperty(RequestMetrics.Metric.Exception, we);

            HttpStatusCode statusCode;
            AmazonServiceException errorResponseException = null;
            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (httpErrorResponse == null)
                {
                    // Abort the unsuccessful request
                    asyncResult.RequestState.WebRequest.Abort();

                    // If it is a keep alive error or name resolution error then attempt a retry
                    if (we != null && asyncResult.RetriesAttempt < config.MaxErrorRetry && (we.Status == WebExceptionStatus.KeepAliveFailure || we.Status == WebExceptionStatus.NameResolutionFailure))
                    {
                        pauseExponentially(asyncResult);
                        return true;
                    }
                    throw new AmazonServiceException(we);
                }
                statusCode = httpErrorResponse.StatusCode;
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.StatusCode, statusCode);
                string redirectedLocation = httpErrorResponse.Headers["location"];
                asyncResult.Metrics.AddProperty(RequestMetrics.Metric.RedirectLocation, redirectedLocation);

                using (httpErrorResponse)
                {
                    var unmarshaller = asyncResult.Unmarshaller;
                    UnmarshallerContext errorContext = unmarshaller.CreateContext(httpErrorResponse, config.LogResponse || config.ReadEntireResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never, asyncResult);
                    errorResponseException = unmarshaller.UnmarshallException(errorContext, we, statusCode);
                    if (config.LogResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never)
                    {
                        logger.Error(errorResponseException, "Received error response: [{0}]", errorContext.ResponseBody);
                    }
                    asyncResult.Metrics.AddProperty(RequestMetrics.Metric.AWSRequestID, errorResponseException.RequestId);
                    asyncResult.Metrics.AddProperty(RequestMetrics.Metric.AWSErrorCode, errorResponseException.ErrorCode);
                }
                asyncResult.RequestState.WebRequest.Abort();

                if (isTemporaryRedirect(statusCode, redirectedLocation))
                {
                    asyncResult.Request.Endpoint = new Uri(redirectedLocation);
                    return true;
                }
                else if (ShouldRetry(statusCode, this.config, errorResponseException, asyncResult.RetriesAttempt))
                {
                    pauseExponentially(asyncResult);
                    return true;
                }
            }

            if (errorResponseException != null)
            {
                logger.Error(errorResponseException, "Error making request {0}.", asyncResult.RequestName);
                throw errorResponseException;
            }

            AmazonServiceException excep = new AmazonServiceException("Unable to make request", we, statusCode);
            logger.Error(excep, "Error making request {0}.", asyncResult.RequestName);
            asyncResult.Metrics.AddProperty(RequestMetrics.Metric.Exception, excep);
            throw excep;
        }

        private void pauseExponentially(AsyncResult asyncResult)
        {
            using (asyncResult.Metrics.StartEvent(RequestMetrics.Metric.RetryPauseTime))
            {
                pauseExponentially(asyncResult.RetriesAttempt);
            }
        }

        #endregion


        #region Private/protected methods

        /// <summary>
        /// Gets the service url endpoint used by this client.
        /// </summary>
        internal string ServiceURL
        {
            get { return this.config.DetermineServiceURL(); }
        }

        /// <summary>
        /// Gets the AWSCredentials object used for signing requests.
        /// </summary>
        internal AWSCredentials Credentials
        {
            get { return this.credentials; }
        }

        /// <summary>
        /// Creates the HttpWebRequest and configures the end point, content, user agent and proxy settings.
        /// </summary>
        /// <param name="asyncResult">The async request.</param>
        /// <returns>The web request that actually makes the call.</returns>
        protected virtual HttpWebRequest ConfigureWebRequest(AsyncResult asyncResult)//IRequest wrappedRequest, byte[] requestData)
        {
            IRequest wrappedRequest = asyncResult.Request;
            byte[] requestData = asyncResult.RequestData;

            Uri url = wrappedRequest.Endpoint;
            if (!string.IsNullOrEmpty(wrappedRequest.ResourcePath))
            {
                string resourcePath = wrappedRequest.ResourcePath;
                if (resourcePath.StartsWith("//"))
                    resourcePath = resourcePath.Substring(2);
                else if (resourcePath.StartsWith("/"))
                    resourcePath = resourcePath.Substring(1);

                url = new Uri(wrappedRequest.Endpoint, resourcePath);
            }

            if (wrappedRequest.UseQueryString && wrappedRequest.Parameters.Count > 0)
            {
                string queryString = AWSSDKUtils.GetParametersAsString(wrappedRequest.Parameters);
                url = new Uri(string.Format("{0}?{1}", url.AbsoluteUri, queryString));
            }

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {
                if (asyncResult.RequestStream != null)
                {
                    request.Timeout = int.MaxValue;
                    request.ReadWriteTimeout = int.MaxValue;
                    request.AllowWriteStreamBuffering = false;
                }

                request.ServicePoint.ConnectionLimit = this.config.ConnectionLimit;
                request.ServicePoint.UseNagleAlgorithm = this.config.UseNagleAlgorithm;
                if (this.config.ProxyHost != null && this.config.ProxyPort != 0)
                {
                    WebProxy proxy = new WebProxy(this.config.ProxyHost, this.config.ProxyPort);
                    asyncResult.Metrics.AddProperty(RequestMetrics.Metric.ProxyHost, this.config.ProxyHost);
                    request.Proxy = proxy;
                }
                if (request.Proxy != null && config.ProxyCredentials != null)
                {
                    request.Proxy.Credentials = config.ProxyCredentials;
                }

                // Setting of these properties is moved to before signing
                //request.UserAgent = this.config.UserAgent;
                //request.ContentType = AWSSDKUtils.UrlEncodedContent;

                request.Method = wrappedRequest.HttpMethod;
                if (!wrappedRequest.UseQueryString && (request.Method == "POST" || request.Method == "PUT"))
                {
                    if (wrappedRequest.ContentStream != null)
                    {
                        request.Headers["x-amz-content-sha256"] = wrappedRequest.ContentStreamHash;
                        request.ContentLength = wrappedRequest.ContentStream.Length;
                    }
                    else
                    {
                        request.ContentLength = requestData.Length;
                    }
                }
                else
                {
                    string headerValue;
                    if (wrappedRequest.Headers.TryGetValue("x-amz-content-length", out headerValue) && headerValue != null)
                    {
                        request.ContentLength = long.Parse(headerValue);
                    }
                }

                AddHeaders(request, wrappedRequest.Headers);

                if (asyncResult.Unmarshaller is JsonResponseUnmarshaller)
                {
                    request.Accept = "application/json";
                }
            }

            return request;
        }

        private static System.Reflection.MethodInfo _addWithoutValidateHeadersMethod =
            typeof(WebHeaderCollection).GetMethod("AddWithoutValidate", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

        // As per MSDN documentation (http://msdn.microsoft.com/en-us/library/system.net.webheadercollection%28v=VS.80%29.aspx)
        // some headers are restricted, cannot be set through the request.Headers property and must be
        // set through properties on the HttpWebRequest
        internal static void AddHeaders(HttpWebRequest request, IDictionary<string, string> headersToAdd)
        {
            var headers = request.Headers;
            foreach (var kvp in headersToAdd)
            {
                if (WebHeaderCollection.IsRestricted(kvp.Key) || string.Equals(kvp.Key, "Range", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.Equals(kvp.Key, "Accept", StringComparison.OrdinalIgnoreCase))
                        request.Accept = kvp.Value;
                    else if (string.Equals(kvp.Key, "Connection", StringComparison.OrdinalIgnoreCase))
                        request.Connection = kvp.Value;
                    else if (string.Equals(kvp.Key, "Content-Type", StringComparison.OrdinalIgnoreCase))
                        request.ContentType = kvp.Value;
                    else if (string.Equals(kvp.Key, "Expect", StringComparison.OrdinalIgnoreCase))
                        request.Expect = kvp.Value;
                    else if (string.Equals(kvp.Key, "User-Agent", StringComparison.OrdinalIgnoreCase))
                        request.UserAgent = kvp.Value;
                    // Date accessor is only present in .NET 4.0, so using reflection
                    else if (string.Equals(kvp.Key, "Date", StringComparison.OrdinalIgnoreCase))
                        _addWithoutValidateHeadersMethod.Invoke(request.Headers, new[] { "Date", kvp.Value });
                    // Host accessor is only present in .NET 4.0, so using reflection
                    else if (string.Equals(kvp.Key, "Host", StringComparison.OrdinalIgnoreCase))
                        _addWithoutValidateHeadersMethod.Invoke(request.Headers, new[] { "Host", kvp.Value });
                    else if (string.Equals(kvp.Key, "Range", StringComparison.OrdinalIgnoreCase))
                        _addWithoutValidateHeadersMethod.Invoke(request.Headers, new[] { "Range", kvp.Value });
                    else
                        throw new NotSupportedException("Header with name " + kvp.Key + " is not suppored");

                    /*
                    // Content-Length is not supported because it is one of the headers known AFTER signing
                    else if (string.Equals(kvp.Key, "Content-Length", StringComparison.OrdinalIgnoreCase))
                        throw new NotSupportedException();
                    // If-Modified-Since is not supported because the required parsing methods are internal
                    else if (string.Equals(kvp.Key, "If-Modified-Since", StringComparison.OrdinalIgnoreCase))
                        throw new NotSupportedException();
                    // Range is not supported for SDK requests
                    else if (string.Equals(kvp.Key, "Range", StringComparison.OrdinalIgnoreCase))
                        throw new NotSupportedException();
                    // Referer is not supported for SDK requests
                    else if (string.Equals(kvp.Key, "Referer", StringComparison.OrdinalIgnoreCase))
                        throw new NotSupportedException();
                    // Transfer-Encoding is not supported for SDK requests
                    else if (string.Equals(kvp.Key, "Transfer-Encoding", StringComparison.OrdinalIgnoreCase))
                        throw new NotSupportedException();
                    // Proxy-Connection is not supported, proxy must be set using config object
                    else if (string.Equals(kvp.Key, "Proxy-Connection", StringComparison.OrdinalIgnoreCase))
                        throw new NotSupportedException();
                     */
                }
                else
                {
                    headers[kvp.Key] = kvp.Value;
                }
            }
        }

        private enum ClientProtocol { QueryStringProtocol, RestProtocol, Unknown }
        private static ClientProtocol DetermineProtocol(AbstractAWSSigner signer)
        {
            if (signer is AWS3Signer || signer is AWS4Signer || signer is CloudFrontSigner)
                return ClientProtocol.RestProtocol;
            if (signer is QueryStringSigner)
                return ClientProtocol.QueryStringProtocol;
            return ClientProtocol.Unknown;
        }

        private void SignRequest(IRequest request, AbstractAWSSigner signer, RequestMetrics metrics)
        {
            // Check if request should be signed
            if (credentials is AnonymousAWSCredentials)
                return;

            metrics.StartEvent(RequestMetrics.Metric.CredentialsRequestTime);
            using (ImmutableCredentials immutableCredentials = credentials.GetCredentials())
            {
                metrics.StopEvent(RequestMetrics.Metric.CredentialsRequestTime);
                if (immutableCredentials.UseToken)
                {
                    ClientProtocol protocol = DetermineProtocol(signer);
                    switch (protocol)
                    {
                        case ClientProtocol.QueryStringProtocol:
                            request.Parameters["SecurityToken"] = immutableCredentials.Token;
                            break;
                        case ClientProtocol.RestProtocol:
                            request.Headers["x-amz-security-token"] = immutableCredentials.Token;
                            break;
                        default:
                            throw new InvalidDataException("Cannot determine protocol");
                    }
                }
                signer.Sign(request, this.config, immutableCredentials.AccessKey, immutableCredentials.ClearSecretKey, immutableCredentials.SecureSecretKey);
            }
        }

        protected virtual void ProcessRequestHandlers(IRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");

            WebServiceRequestEventArgs args = WebServiceRequestEventArgs.Create(request);

            if (request.OriginalRequest != null)
                request.OriginalRequest.FireBeforeRequestEvent(this, args);

            if (BeforeRequestEvent != null)
                BeforeRequestEvent(this, args);
        }

        protected virtual void ProcessResponseHandlers(AmazonWebServiceResponse response, IRequest request)
        {
            if (response == null) throw new ArgumentNullException("response");

            WebServiceResponseEventArgs args = WebServiceResponseEventArgs.Create(response, request);

            if (AfterResponseEvent != null)
                AfterResponseEvent(this, args);
        }

        protected virtual void ProcessExceptionHandlers(Exception exception, IRequest request)
        {
            if (exception == null) throw new ArgumentNullException("exception");

            WebServiceExceptionEventArgs args = WebServiceExceptionEventArgs.Create(exception, request);

            if (ExceptionEvent != null)
                ExceptionEvent(this, args);
        }

        private bool isInnerExceptionThreadAbort(Exception e)
        {
            if (e.InnerException is ThreadAbortException)
                return true;
            if (e.InnerException != null)
                return isInnerExceptionThreadAbort(e.InnerException);
            return false;
        }

        private static bool isTemporaryRedirect(HttpStatusCode statusCode, string redirectedLocation)
        {
            return statusCode == HttpStatusCode.TemporaryRedirect && redirectedLocation != null;
        }

        /// <summary>
        /// Returns true if a failed request should be retried.
        /// </summary>
        /// <param name="statusCode">The HTTP status code from the failed request</param>
        /// <param name="config">The client config</param>
        /// <param name="errorResponseException">The exception from the failed request</param>
        /// <param name="retries">The number of times the current request has been attempted</param>
        /// <returns>True if the failed request should be retried.</returns>
        public static bool ShouldRetry(HttpStatusCode statusCode, ClientConfig config, AmazonServiceException errorResponseException, int retries)
        {
            if (retries >= config.MaxErrorRetry)
            {
                return false;
            }

            /*
             * For 500 internal server errors and 503 service
             * unavailable errors, we want to retry, but we need to use
             * an exponential back-off strategy so that we don't overload
             * a server with a flood of retries. If we've surpassed our
             * retry limit we handle the error response as a non-retryable
             * error and go ahead and throw it back to the user as an exception.
             */
            if (statusCode == HttpStatusCode.InternalServerError ||
                statusCode == HttpStatusCode.ServiceUnavailable)
            {
                return true;
            }

            if (errorResponseException.InnerException is WebException &&
                (((WebException)(errorResponseException.InnerException)).Status == WebExceptionStatus.KeepAliveFailure))
            {
                return true;
            }

            /*
             * Throttling is reported as a 400 or 503 error from services. To try and
             * smooth out an occasional throttling error, we'll pause and retry,
             * hoping that the pause is long enough for the request to get through
             * the next time.
             */
            if ((statusCode == HttpStatusCode.BadRequest || statusCode == HttpStatusCode.ServiceUnavailable) &&
                errorResponseException != null)
            {
                string errorCode = errorResponseException.ErrorCode;
                if (ErrorCodesToRetryOn.Contains(errorCode))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary> 
        /// Exponential sleep on failed request to avoid flooding a service with
        /// retries.
        /// </summary>
        /// <param name="retries">Current retry count.</param>
        protected virtual void pauseExponentially(int retries)
        {
            int delay = (int)(Math.Pow(4, retries) * 100);
            delay = Math.Min(delay, MAX_BACKOFF_IN_MILLISECONDS);
            Thread.Sleep(delay);
        }

        #endregion

    }
}
