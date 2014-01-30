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
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;



namespace Amazon.Runtime
{
    /// <summary>
    /// A base class for service clients that handles making the actual requests
    /// and possibly retries if needed.
    /// </summary>
    public abstract class AmazonWebServiceClient : AbstractWebServiceClient
    {
        #region Constructors

        internal AmazonWebServiceClient(AWSCredentials credentials, ClientConfig config, AuthenticationTypes authenticationType)
            : base(credentials, config, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : this((AWSCredentials)new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey),
                config, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config, AuthenticationTypes authenticationType)
            : this(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, AuthenticationTypes.User)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
            : this(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, AuthenticationTypes.User)
        {
        }

        #endregion

        protected IAsyncResult Invoke<T, R>(R request, AsyncCallback callback, object state, bool synchronized, IMarshaller<T, R> marshaller, ResponseUnmarshaller unmarshaller, AbstractAWSSigner signer)
            where T : IRequest
            where R : AmazonWebServiceRequest
        {
            ProcessPreRequestHandlers(request);

            IRequest irequest = marshaller.Marshall(request);
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        protected void Invoke(AsyncResult asyncResult)
        {
            asyncResult.Metrics.StartEvent(Metric.ClientExecuteTime);
            asyncResult.Request.Endpoint = DetermineEndpoint(asyncResult.Request);
            if (Config.LogMetrics)
            {
                asyncResult.Metrics.IsEnabled = true;
                asyncResult.Metrics.AddProperty(Metric.ServiceName, asyncResult.Request.ServiceName);
                asyncResult.Metrics.AddProperty(Metric.ServiceEndpoint, asyncResult.Request.Endpoint);
                asyncResult.Metrics.AddProperty(Metric.MethodName, asyncResult.RequestName);
                asyncResult.Metrics.AddProperty(Metric.AsyncCall, !asyncResult.CompletedSynchronously);
            }
            ConfigureRequest(asyncResult);
            InvokeHelper(asyncResult);
        }

        protected Uri DetermineEndpoint(IRequest request)
        {
            Uri endpoint;
            if (request.AlternateEndpoint != null)
                endpoint = new Uri(ClientConfig.GetUrl(request.AlternateEndpoint, Config.RegionEndpointServiceName, Config.UseHttp));
            else
                endpoint = new Uri(this.Config.DetermineServiceURL());
            return endpoint;
        }

        private void InvokeHelper(AsyncResult asyncResult)
        {
            if (asyncResult.RetriesAttempt == 0 || Config.ResignRetries)
            {
                SignRequest(asyncResult);
            }
            if (asyncResult.RetriesAttempt > 0)
                HandleRetry(asyncResult);
            InvokeConfiguredRequest(asyncResult);
        }

        private void InvokeConfiguredRequest(AsyncResult asyncResult)
        {
            HttpWebRequest webRequest = ConfigureWebRequest(asyncResult);
            asyncResult.RequestState = new AsyncResult.AsyncRequestState(webRequest, GetRequestData(asyncResult.Request), asyncResult.Request.ContentStream);
            asyncResult.Metrics.StartEvent(Metric.HttpRequestTime);

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

        void getRequestStreamCallback(IAsyncResult result)
        {
            AsyncResult asyncResult = result as AsyncResult;
            if (asyncResult == null)
                asyncResult = result.AsyncState as AsyncResult;

            asyncResult.RequestState.GetRequestStreamCallbackCalled = true;

            try
            {
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
                                asyncResult.Metrics.AddProperty(Metric.RequestSize, requestData.Length);
                                requestStream.Write(requestData, 0, requestData.Length);
                            }
                            else
                            {
                                var callback = asyncResult.Request.OriginalRequest.StreamUploadProgressCallback;
                                byte[] buffer = new byte[this.Config.BufferSize];
                                int bytesRead = 0;
                                long totalBytesWritten = 0;
                                Stream inputStream = asyncResult.RequestState.RequestStream;
                                int bytesToRead = buffer.Length;

                                while ((bytesRead = inputStream.Read(buffer, 0, bytesToRead)) > 0)
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
                    HandleHttpWebErrorResponse(asyncResult, e);

                    asyncResult.RetriesAttempt++;
                    InvokeHelper(asyncResult);
                }
                catch (IOException ioe)
                {
                    if (HandleIOException(asyncResult, null, ioe))
                    {
                        asyncResult.RetriesAttempt++;
                        InvokeHelper(asyncResult);
                    }
                    else { throw; }
                }
                catch (Exception e)
                {
                    asyncResult.RequestState.WebRequest.Abort();                    
                    asyncResult.Metrics.AddProperty(Metric.Exception, e);

                    asyncResult.HandleException(e);
                }
            }
            catch (Exception exception)
            {
                ProcessExceptionHandlers(exception, asyncResult.Request);
                // Handle WebException/IOExceptionexceptions/AmazonServiceException
                // thrown after retry limit is reached.
                asyncResult.HandleException(exception);                
            }
        }

        void getResponseCallback(IAsyncResult result)
        {
            AsyncResult asyncResult = result as AsyncResult;
            if (asyncResult == null)
                asyncResult = result.AsyncState as AsyncResult;

            UnmarshallerContext context = null;
            asyncResult.RequestState.GetResponseCallbackCalled = true;
            bool shouldRetry = false;
            AmazonWebServiceResponse response = null;
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

                    using (asyncResult.Metrics.StartEvent(Metric.ResponseProcessingTime))
                    {
                        var unmarshaller = asyncResult.Unmarshaller;
                        LogResponse(asyncResult.Metrics, asyncResult.Request, httpResponse.StatusCode);

                        try
                        {
                            context = unmarshaller.CreateContext(new HttpWebRequestResponseData(httpResponse), this.SupportResponseLogging && (Config.LogResponse || Config.ReadEntireResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never), asyncResult.Metrics);
                            
                            using (asyncResult.Metrics.StartEvent(Metric.ResponseUnmarshallTime))
                            {
                                response = unmarshaller.Unmarshall(context);
                            }
                            context.ValidateCRC32IfAvailable();

                            response.ContentLength = httpResponse.ContentLength;
                            response.HttpStatusCode = httpResponse.StatusCode;
                            asyncResult.FinalResponse = response;
                            if (response.ResponseMetadata != null)
                            {
                                asyncResult.Metrics.AddProperty(Metric.AWSRequestID, response.ResponseMetadata.RequestId);
                            }

                            LogFinishedResponse(asyncResult.Metrics, context, httpResponse.ContentLength);
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

                    // If the error is a 404 and the request is configured to supress it. Then unmarshall as much as we can.
                    if (exceptionHttpResponse != null &&
                        exceptionHttpResponse.StatusCode == HttpStatusCode.NotFound &&
                        asyncResult.Request.Suppress404Exceptions)
                    {
                        var unmarshaller = asyncResult.Unmarshaller;
                        context = unmarshaller.CreateContext(new HttpWebRequestResponseData(exceptionHttpResponse), Config.LogResponse || Config.ReadEntireResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never, asyncResult.Metrics);

                        try
                        {
                            response = unmarshaller.Unmarshall(context);
                            response.ContentLength = exceptionHttpResponse.ContentLength;
                            response.HttpStatusCode = exceptionHttpResponse.StatusCode;
                        }
                        catch (Exception e)
                        {
                            logger.Debug(e, "Failed to unmarshall 404 response when it was being supressed");
                        }

                        asyncResult.FinalResponse = response;
                    }
                    else
                    {
                        if (exceptionHttpResponse != null)
                        {
                            LogResponse(asyncResult.Metrics, asyncResult.Request, exceptionHttpResponse.StatusCode);
                        }
                        else
                        {
                            asyncResult.Metrics.StopEvent(Metric.HttpRequestTime);
                        }
                        shouldRetry = HandleHttpWebErrorResponse(asyncResult, we);
                    }
                }
                catch (IOException ioe)
                {
                    LogResponse(asyncResult.Metrics, asyncResult.Request, HttpStatusCode.Unused);
                    shouldRetry = HandleIOException(asyncResult, httpResponse, ioe);
                    if (!shouldRetry)
                        asyncResult.Exception = ioe;
                }

                if (shouldRetry)
                {
                    asyncResult.RequestState.WebRequest.Abort();
                    asyncResult.RetriesAttempt++;
                    InvokeHelper(asyncResult);
                }
                else
                {
                    LogFinalMetrics(asyncResult.Metrics);
                }
            }
            catch (Exception e)
            {
                if (context != null && AWSConfigs.ResponseLogging == ResponseLoggingOption.OnError)
                    this.logger.Error(e, "Received response: [{0}]", context.ResponseBody);

                asyncResult.RequestState.WebRequest.Abort();
                asyncResult.Exception = e;
                asyncResult.Metrics.AddProperty(Metric.Exception, e);
                asyncResult.Metrics.StopEvent(Metric.ClientExecuteTime);
                shouldRetry = false;
                if (Config.LogMetrics)
                    logger.InfoFormat("Request metrics: {0}", asyncResult.Metrics);

                ProcessExceptionHandlers(e, asyncResult.Request);
                logger.Error(e, "Error configuring web request {0} to {1}.", asyncResult.RequestName, asyncResult.Request.Endpoint.ToString());
            }
            finally
            {
                if (!shouldRetry)
                {
                    var responseData = context == null ? null : context.ResponseData;
                    ProcessResponseHandlers(response, asyncResult.Request, responseData);
                    asyncResult.InvokeCallback();                   
                }
            }
        }

        internal static T endOperation<T>(IAsyncResult result)
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


        private bool HandleIOException(AsyncResult asyncResult, HttpWebResponse httpResponse, IOException e)
        {
            asyncResult.Metrics.AddProperty(Metric.Exception, e);

            if (IsInnerExceptionThreadAbort(e))
                throw e;

            this.logger.Error(e, "IOException making request {0} to {1}.", asyncResult.RequestName, asyncResult.Request.Endpoint.ToString());
            if (httpResponse != null)
            {
                httpResponse.Close();
                httpResponse = null;
            }
            // Abort the unsuccessful request
            asyncResult.RequestState.WebRequest.Abort();

            if (CanRetry(asyncResult) && asyncResult.RetriesAttempt < Config.MaxErrorRetry)
            {
                this.logger.Error(e, "IOException making request {0} to {1}. Attempting retry {2}.",
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

        private bool HandleHttpWebErrorResponse(AsyncResult asyncResult, WebException we)
        {
            asyncResult.Metrics.AddProperty(Metric.Exception, we);

            HttpStatusCode statusCode;
            AmazonServiceException errorResponseException = null;
            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (we != null && WebExceptionStatusesToThrowOn.Contains(we.Status))
                {
                    throw new AmazonServiceException(we);
                }

                if (httpErrorResponse == null ||
                        (we != null && WebExceptionStatusesToRetryOn.Contains(we.Status)))
                {
                    // Abort the unsuccessful request
                    asyncResult.RequestState.WebRequest.Abort();

                    if (CanRetry(asyncResult) && asyncResult.RetriesAttempt < Config.MaxErrorRetry)
                    {                        
                        pauseExponentially(asyncResult);
                        return true;
                    }
                    throw new AmazonServiceException(we);
                }

                statusCode = httpErrorResponse.StatusCode;
                asyncResult.Metrics.AddProperty(Metric.StatusCode, statusCode);
                string redirectedLocation = httpErrorResponse.Headers["location"];
                asyncResult.Metrics.AddProperty(Metric.RedirectLocation, redirectedLocation);

                using (httpErrorResponse)
                {
                    var unmarshaller = asyncResult.Unmarshaller;
                    UnmarshallerContext errorContext = unmarshaller.CreateContext(new HttpWebRequestResponseData(httpErrorResponse), Config.LogResponse || Config.ReadEntireResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never, asyncResult.Metrics);
                    errorResponseException = unmarshaller.UnmarshallException(errorContext, we, statusCode);
                    if (Config.LogResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never)
                    {
                        this.logger.Error(errorResponseException, "Received error response: [{0}]", errorContext.ResponseBody);
                    }
                    asyncResult.Metrics.AddProperty(Metric.AWSRequestID, errorResponseException.RequestId);
                    asyncResult.Metrics.AddProperty(Metric.AWSErrorCode, errorResponseException.ErrorCode);
                }
                asyncResult.RequestState.WebRequest.Abort();

                if (CanRetry(asyncResult))
                {
                    if (isTemporaryRedirect(statusCode, redirectedLocation))
                    {
                        this.logger.DebugFormat("Request {0} is being redirected to {1}.", asyncResult.RequestName, redirectedLocation);
                        asyncResult.Request.Endpoint = new Uri(redirectedLocation);
                        return true;
                    }
                    else if (ShouldRetry(statusCode, this.Config, errorResponseException, asyncResult.RetriesAttempt))
                    {
                        this.logger.DebugFormat("Retry number {0} for request {1}.", asyncResult.RetriesAttempt, asyncResult.RequestName);
                        pauseExponentially(asyncResult);
                        return true;
                    }
                }
            }

            if (errorResponseException != null)
            {
                this.logger.Error(errorResponseException, "Error making request {0}.", asyncResult.RequestName);
                throw errorResponseException;
            }

            AmazonServiceException excep = new AmazonServiceException("Unable to make request", we, statusCode);
            this.logger.Error(excep, "Error making request {0}.", asyncResult.RequestName);
            asyncResult.Metrics.AddProperty(Metric.Exception, excep);
            throw excep;
        }
 
        /// <summary>
        /// Creates the HttpWebRequest and configures the end point, content, user agent and proxy settings.
        /// </summary>
        /// <param name="asyncResult">The async request.</param>
        /// <returns>The web request that actually makes the call.</returns>
        protected virtual HttpWebRequest ConfigureWebRequest(AsyncResult asyncResult)//IRequest wrappedRequest, byte[] requestData)
        {            
            IRequest wrappedRequest = asyncResult.Request;
            byte[] requestData = GetRequestData(asyncResult.Request);

            Uri url = ComposeUrl(wrappedRequest, wrappedRequest.Endpoint);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {   
                if (asyncResult.Request.ContentStream != null)
                {
                    request.Timeout = int.MaxValue;
                    request.ReadWriteTimeout = int.MaxValue;
                    request.AllowWriteStreamBuffering = false;
                }

                // Override the Timeout and ReadWriteTimeout values if set at the request or config level.
                // Public Timeout and ReadWriteTimeout properties are present on request and client config objects for S3 and Glacier.
                var timeout = ClientConfig.GetTimeoutValue(this.Config.TimeoutInternal, wrappedRequest.OriginalRequest.TimeoutInternal);
                var readWriteTimeout = ClientConfig.GetTimeoutValue(this.Config.ReadWriteTimeoutInternal, wrappedRequest.OriginalRequest.ReadWriteTimeoutInternal);
                if (timeout != null)
                {
                    request.Timeout = (int)timeout.Value.TotalMilliseconds;
                }
                if (readWriteTimeout != null)
                {
                    request.ReadWriteTimeout = (int)readWriteTimeout.Value.TotalMilliseconds;
                }

                request.ServicePoint.ConnectionLimit = this.Config.ConnectionLimit;
                request.ServicePoint.UseNagleAlgorithm = this.Config.UseNagleAlgorithm;
                request.ServicePoint.MaxIdleTime = this.Config.MaxIdleTime;
                if (this.Config.ProxyHost != null && this.Config.ProxyPort != 0)
                {
                    WebProxy proxy = new WebProxy(this.Config.ProxyHost, this.Config.ProxyPort);
                    asyncResult.Metrics.AddProperty(Metric.ProxyHost, this.Config.ProxyHost);
                    request.Proxy = proxy;
                }
                if (request.Proxy != null && Config.ProxyCredentials != null)
                {
                    request.Proxy.Credentials = Config.ProxyCredentials;
                }

                // Setting of these properties is moved to before signing
                //request.UserAgent = this.config.UserAgent;
                //request.ContentType = AWSSDKUtils.UrlEncodedContent;

                request.Method = wrappedRequest.HttpMethod;
                if (!wrappedRequest.UseQueryString && (request.Method == "POST" || request.Method == "PUT"))
                {
                    if (wrappedRequest.ContentStream != null)
                    {
                        if (wrappedRequest.OriginalRequest.IncludeSHA256Header 
                            && !wrappedRequest.Headers.ContainsKey(AWS4Signer.XAmzContentSha256))
                        {
                            request.Headers[AWS4Signer.XAmzContentSha256] = wrappedRequest.ComputeContentStreamHash();
                        }
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
                        request.ContentLength = long.Parse(headerValue, CultureInfo.InvariantCulture);
                    }
                }

                AddHeaders(request, wrappedRequest.Headers);

                if (asyncResult.Unmarshaller is JsonResponseUnmarshaller)
                {
                    request.Accept = "application/json";
                }

                request.ServicePoint.Expect100Continue = wrappedRequest.OriginalRequest.Expect100Continue;
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
                    else if (string.Equals(kvp.Key, "Content-Length", StringComparison.OrdinalIgnoreCase))
                        request.ContentLength = long.Parse(kvp.Value, CultureInfo.InvariantCulture);
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
                    else if (string.Equals(kvp.Key, "If-Modified-Since", StringComparison.OrdinalIgnoreCase))
                        _addWithoutValidateHeadersMethod.Invoke(request.Headers, new[] { kvp.Key, kvp.Value });
                    else
                        throw new NotSupportedException("Header with name " + kvp.Key + " is not suppored");
                }
                else
                {
                    headers[kvp.Key] = kvp.Value;
                }
            }
        }

        protected static void LogResponse(RequestMetrics metrics, IRequest request, HttpStatusCode statusCode)
        {
            Timing timing = metrics.StopEvent(Metric.HttpRequestTime);
            metrics.AddProperty(Metric.StatusCode, statusCode);
        }
    }
}
