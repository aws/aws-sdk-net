/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Text;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Xml;
using System.Reflection;
using System.Threading;

using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

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


        [Flags]
        internal enum AuthenticationTypes
        {
            User = 0x0,
            Session = 0x1
        }

        internal static List<string> ErrorCodesToRetryOn = new List<string>
        {
            "Throttling",
            "ProvisionedThroughputExceededException"
        };

        protected const int MAX_BACKOFF_IN_MILLISECONDS = 30 * 1000;
        ClientConfig config;
        AWSCredentials credentials;
        bool ownCredentials;
        AuthenticationTypes authenticationType;

        bool disposed;
        Logger logger;

        #endregion


        #region Events

        internal event RequestEventHandler BeforeRequestEvent;

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
            this.logger = new Logger(this.GetType());
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
                else if (cachedRefreshingCredentials.ContainsKey(refreshCredentials.UniqueIdentifier))
                {
                    this.credentials = cachedRefreshingCredentials[refreshCredentials.UniqueIdentifier];
                }
                else
                {
                    this.credentials = refreshCredentials;
                    cachedRefreshingCredentials[refreshCredentials.UniqueIdentifier] = refreshCredentials;
                }
            }
            else
            {
                this.credentials = credentials;
            }
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, SecureString awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : this(authenticationType == AuthenticationTypes.Session ? 
                    (AWSCredentials)new RefreshingSessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey) : 
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

        #endregion


        #region Async methods

        protected void Invoke(AsyncResult asyncResult)
        {
            ConfigureRequest(asyncResult);

            InvokeConfiguredRequest(asyncResult);
        }

        private void InvokeConfiguredRequest(AsyncResult asyncResult)
        {
            logger.DebugFormat("Starting request {0} at {1}", asyncResult.RequestName, this.config.ServiceURL);

            HttpWebRequest webRequest = ConfigureWebRequest(asyncResult);
            asyncResult.RequestState = new RequestState(webRequest, asyncResult.RequestData);
            asyncResult.RequestSent = DateTime.Now;

            if (asyncResult.CompletedSynchronously)
            {
                this.getRequestStreamCallback(asyncResult);
            }
            else
            {
                IAsyncResult httpResult;
                if (asyncResult != null
                    && asyncResult.RequestState != null
                    && asyncResult.RequestState.WebRequest.Method == "POST")
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

        private void ConfigureRequest(AsyncResult asyncResult)
        {
            IRequest request = asyncResult.Request;

            request.Endpoint = new Uri(this.config.ServiceURL);
            request.Headers["User-Agent"] = this.config.UserAgent + " " + (asyncResult.CompletedSynchronously ? "ClientSync" : "ClientAsync");
            if (!request.Headers.ContainsKey(AWSSDKUtils.ContentTypeHeader))
            {
                request.Headers[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
            }

            ProcessRequestHandlers(request);

            SignRequest(request, asyncResult.Signer);

            asyncResult.RequestData = GetRequestData(request);
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

            this.logger.DebugFormat("Request body's content size {0}", requestData.Length);
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
                RequestState state = asyncResult.RequestState;

                if (asyncResult != null
                    && asyncResult.RequestState != null
                    && asyncResult.RequestState.RequestData != null
                    && asyncResult.RequestState.RequestData.Length > 0
                    && asyncResult.RequestState.WebRequest.Method == "POST")
                {
                    Stream requestStream;
                    if (asyncResult.CompletedSynchronously)
                        requestStream = state.WebRequest.GetRequestStream();
                    else
                        requestStream = state.WebRequest.EndGetRequestStream(result);

                    using (requestStream)
                    {
                        byte[] requestData = asyncResult.RequestState.RequestData;
                        requestStream.Write(requestData, 0, requestData.Length);
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
            catch (Exception e)
            {
                asyncResult.RequestState.WebRequest.Abort();
                asyncResult.Exception = e;

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

            asyncResult.RequestState.GetResponseCallbackCalled = true;
            bool shouldRetry = false;
            try
            {
                RequestState state = asyncResult.RequestState;
                HttpWebResponse httpResponse = null;
                try
                {
                    if (asyncResult.CompletedSynchronously)
                        httpResponse = state.WebRequest.GetResponse() as HttpWebResponse;
                    else
                        httpResponse = state.WebRequest.EndGetResponse(result) as HttpWebResponse;

                    asyncResult.ResponseReceived = DateTime.UtcNow;
                    this.logger.InfoFormat("Received response for {0} with status code {1} in {2} ms.",
                        asyncResult.RequestName,
                        httpResponse.StatusCode,
                        (asyncResult.ResponseReceived - asyncResult.RequestSent).TotalMilliseconds);

                    using (httpResponse)
                    {
                        var unmarshaller = asyncResult.Unmarshaller;
                        var context = unmarshaller.CreateContext(httpResponse, config.LogResponse);
                        if (config.LogResponse)
                        {
                            this.logger.InfoFormat("Received response: [{0}]", context.ResponseBody);
                        }
                        asyncResult.FinalResponse = unmarshaller.Unmarshall(context);
                    }
                }
                catch (WebException we)
                {
                    shouldRetry = handleHttpWebErrorResponse(asyncResult, we);
                }
                catch (IOException ioe)
                {
                    shouldRetry = handleIOException(asyncResult, httpResponse, ioe);
                }
                if (shouldRetry)
                {
                    asyncResult.RequestState.WebRequest.Abort();
                    asyncResult.RetriesAttempt++;
                    InvokeConfiguredRequest(asyncResult);
                }
            }
            catch (Exception e)
            {
                asyncResult.RequestState.WebRequest.Abort();
                asyncResult.Exception = e;
                shouldRetry = false;
                logger.Error(string.Format("Error configuring web request {0} to {1}.", asyncResult.RequestName, asyncResult.Request.Endpoint.ToString()), e);
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

        bool handleIOException(AsyncResult asyncResult, HttpWebResponse httpResponse, IOException e)
        {
            if (isInnerExceptionThreadAbort(e))
                throw e;

            this.logger.Error(string.Format("IOException making request {0} to {1}.", asyncResult.RequestName, asyncResult.Request.Endpoint.ToString()), e);
            if (httpResponse != null)
            {
                httpResponse.Close();
                httpResponse = null;
            }
            // Abort the unsuccessful request
            asyncResult.RequestState.WebRequest.Abort();

            if (asyncResult.RetriesAttempt <= config.MaxErrorRetry)
            {
                this.logger.Error(
                    string.Format("IOException making request {0} to {1}. Attempting retry {2}.",
                        asyncResult.RequestName,
                        asyncResult.Request.Endpoint.ToString(),
                        asyncResult.RetriesAttempt),
                    e);
                return true;
            }
            else
            {
                return false;
            }
        }

        bool handleHttpWebErrorResponse(AsyncResult asyncResult, WebException we)
        {
            HttpStatusCode statusCode;
            AmazonServiceException errorResponseException = null;
            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (httpErrorResponse == null)
                {
                    // Abort the unsuccessful request
                    asyncResult.RequestState.WebRequest.Abort();

                    // If it is a keep alive error then attempt a retry
                    if (we != null && asyncResult.RetriesAttempt <= config.MaxErrorRetry && we.Status == WebExceptionStatus.KeepAliveFailure)
                    {
                        pauseExponentially(asyncResult.RetriesAttempt);
                        return true;
                    }
                    throw new AmazonServiceException(we);
                }
                statusCode = httpErrorResponse.StatusCode;

                using (httpErrorResponse)
                {
                    var unmarshaller = asyncResult.Unmarshaller;
                    UnmarshallerContext errorContext = unmarshaller.CreateContext(httpErrorResponse, config.LogResponse);
                    if (config.LogResponse)
                    {
                        this.logger.InfoFormat("Received error response: [{0}]", errorContext.ResponseBody);
                    }
                    errorResponseException = unmarshaller.UnmarshallException(errorContext, we, statusCode);
                }
                asyncResult.RequestState.WebRequest.Abort();

                if (isTemporaryRedirect(httpErrorResponse))
                {
                    string redirectedLocation = httpErrorResponse.Headers["location"];
                    this.logger.InfoFormat("Request {0} is being redirected to {1}.", asyncResult.RequestName, redirectedLocation);
                    asyncResult.Request.Endpoint = new Uri(redirectedLocation);
                    return true;
                }
                else if (ShouldRetry(statusCode, this.config, errorResponseException, asyncResult.RetriesAttempt))
                {
                    this.logger.InfoFormat("Retry number {0} for request {1}.", asyncResult.RetriesAttempt, asyncResult.RequestName);
                    pauseExponentially(asyncResult.RetriesAttempt);
                    return true;
                }
            }

            if (errorResponseException != null)
            {
                this.logger.Error(string.Format("Error making request {0}.", asyncResult.RequestName), errorResponseException);
                throw errorResponseException;
            }

            AmazonServiceException excep = new AmazonServiceException("Unable to make request", we, statusCode);
            this.logger.Error(string.Format("Error making request {0}.", asyncResult.RequestName), excep);
            throw excep;
        }

        #endregion


        #region Private/protected methods

        /// <summary>
        /// Gets the service url endpoint used by this client.
        /// </summary>
        internal string ServiceURL
        {
            get { return this.config.ServiceURL; }
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
                url = new Uri(wrappedRequest.Endpoint, wrappedRequest.ResourcePath);

            if (wrappedRequest.HttpMethod == "GET" && wrappedRequest.Parameters.Count > 0)
            {
                string queryString = AWSSDKUtils.GetParametersAsString(wrappedRequest.Parameters);
                url = new Uri(string.Format("{0}?{1}", url.AbsoluteUri, queryString));
            }

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {
                request.ServicePoint.ConnectionLimit = this.config.ConnectionLimit;
                if (this.config.ProxyHost != null && this.config.ProxyPort != 0)
                {
                    WebProxy proxy = new WebProxy(this.config.ProxyHost, this.config.ProxyPort);
                    if (config.ProxyUsername != null)
                    {
                        proxy.Credentials = new NetworkCredential(
                            config.ProxyUsername,
                            config.ProxyPassword ?? String.Empty
                            );
                        this.logger.DebugFormat("Configured request to use proxy with host {0} and port {1} for user {2}.", config.ProxyHost, config.ProxyPort, config.ProxyUsername);
                    }
                    else
                    {
                        this.logger.DebugFormat("Configured request to use proxy with host {0} and port {1}.", config.ProxyHost, config.ProxyPort);
                    }
                    request.Proxy = proxy;
                }

                // Setting of these properties is moved to before signing
                //request.UserAgent = this.config.UserAgent;
                //request.ContentType = AWSSDKUtils.UrlEncodedContent;

                request.Method = wrappedRequest.HttpMethod;
                request.ContentLength = requestData.Length;

                AddHeaders(request, wrappedRequest.Headers);
            }

            return request;
        }

        private static System.Reflection.MethodInfo _addWithoutValidateHeadersMethod =
            typeof(WebHeaderCollection).GetMethod("AddWithoutValidate", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

        // As per MSDN documentation (http://msdn.microsoft.com/en-us/library/system.net.webheadercollection%28v=VS.80%29.aspx)
        // some headers are restricted, cannot be set through the request.Headers property and must be
        // set through properties on the HttpWebRequest
        private void AddHeaders(HttpWebRequest request, IDictionary<string, string> headersToAdd)
        {
            var headers = request.Headers;
            foreach (var kvp in headersToAdd)
            {
                if (WebHeaderCollection.IsRestricted(kvp.Key))
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

        private void ValidateAuthentication(ImmutableCredentials immutableCredentials)
        {
            if (immutableCredentials.UseToken)  // token supplied
            {
                if ((authenticationType & AuthenticationTypes.Session) != AuthenticationTypes.Session)
                    throw new AmazonServiceException("Client does not support session authentication");
            }
            else  // no token supplied
            {
                if ((authenticationType & AuthenticationTypes.User) != AuthenticationTypes.User)
                    throw new AmazonServiceException("Client does not support user authentication");
            }
        }

        private enum ClientProtocol { QueryStringProtocol, RestProtocol, Unknown }
        private static ClientProtocol DetermineProtocol(AbstractAWSSigner signer)
        {
            if (signer is AWS3Signer)
                return ClientProtocol.RestProtocol;
            if (signer is QueryStringSigner)
                return ClientProtocol.QueryStringProtocol;
            return ClientProtocol.Unknown;
        }

        private void SignRequest(IRequest request, AbstractAWSSigner signer)
        {
            using (ImmutableCredentials immutableCredentials = credentials.GetCredentials())
            {
                ValidateAuthentication(immutableCredentials);

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

        private bool isInnerExceptionThreadAbort(Exception e)
        {
            if (e.InnerException is ThreadAbortException)
                return true;
            if (e.InnerException != null)
                return isInnerExceptionThreadAbort(e.InnerException);
            return false;
        }

        private static bool isTemporaryRedirect(HttpWebResponse response)
        {
            return response.StatusCode == HttpStatusCode.TemporaryRedirect && response.Headers["location"] != null;
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
            if (retries > config.MaxErrorRetry)
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


        #region Async Classes

        protected class AsyncResult : IAsyncResult
        {
            // Private members

            private ManualResetEvent _waitHandle;
            private object _lockObj;


            // Constructor
            internal AsyncResult(IRequest request, AsyncCallback callback, object state, bool completeSynchronized, AbstractAWSSigner signer, ResponseUnmarshaller unmarshaller)
            {
                this.Request = request;
                this.Callback = callback;
                this.State = state;
                this.CompletedSynchronously = completeSynchronized;
                this.Signer = signer;
                this.Unmarshaller = unmarshaller;
                this.RequestName = request.OriginalRequest.GetType().Name;

                this._lockObj = new object();
            }


            // Properties

            internal Exception Exception { get; set; }

            internal int RetriesAttempt { get; set; }

            internal RequestState RequestState { get; set; }

            internal object FinalResponse { get; set; }

            internal byte[] RequestData { get; set; }

            internal DateTime RequestSent { get; set; }

            internal DateTime ResponseReceived { get; set; }


            // Read-only properties

            internal ResponseUnmarshaller Unmarshaller { get; private set; }

            internal IRequest Request { get; private set; }

            internal AsyncCallback Callback { get; private set; }

            internal AbstractAWSSigner Signer { get; private set; }

            internal object State { get; private set; }

            internal string RequestName { get; private set; }

            public bool CompletedSynchronously { get; private set; }

            public bool IsCompleted { get; private set; }

            public object AsyncState
            {
                get { return this.State; }
            }

            public WaitHandle AsyncWaitHandle
            {
                get
                {
                    if (this._waitHandle != null)
                    {
                        return this._waitHandle;
                    }

                    lock (this._lockObj)
                    {
                        if (this._waitHandle == null)
                        {
                            this._waitHandle = new ManualResetEvent(this.IsCompleted);
                        }
                    }

                    return this._waitHandle;
                }
            }


            // Methods
            internal void SetCompletedSynchronously(bool completedSynchronously)
            {
                this.CompletedSynchronously = completedSynchronously;
            }

            internal void SignalWaitHandle()
            {
                this.IsCompleted = true;
                if (this._waitHandle != null)
                {
                    this._waitHandle.Set();
                }
            }
        }

        internal class RequestState
        {
            public RequestState(HttpWebRequest webRequest, byte[] requestData)
            {
                this.WebRequest = webRequest;
                this.RequestData = requestData;
            }

            internal HttpWebRequest WebRequest { get; private set; }

            internal byte[] RequestData { get; private set; }


            internal bool GetRequestStreamCallbackCalled { get; set; }

            internal bool GetResponseCallbackCalled { get; set; }
        }

        #endregion
    }
}
