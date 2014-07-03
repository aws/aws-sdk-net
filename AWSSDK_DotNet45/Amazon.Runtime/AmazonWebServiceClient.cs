﻿/*
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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Globalization;

namespace Amazon.Runtime
{
    public class AmazonWebServiceClient : AbstractWebServiceClient
    {
        readonly object SERVICE_POINT_LOCK = new object();
        HttpClient httpClient;

#if !(WIN_RT || WINDOWS_PHONE)
        bool configuredServicePoint;
#endif

        #region Constructors

        internal AmazonWebServiceClient(AWSCredentials credentials, ClientConfig config, AuthenticationTypes authenticationType)
            : base(credentials, config, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : base((AWSCredentials)new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey),
                config, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config, AuthenticationTypes authenticationType)
            : base(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, authenticationType)
        {
        }


        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
            : base(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, AuthenticationTypes.User)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
            : base(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, AuthenticationTypes.User)
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.httpClient = ConfigureHttpClient();
        }

        #endregion


        protected Task<Res> Invoke<T, Req, Res>(Req request, IMarshaller<T, Req> marshaller, ResponseUnmarshaller unmarshaller, AbstractAWSSigner signer, CancellationToken cancellationToken = default(CancellationToken))
            where T : IRequest
            where Req : AmazonWebServiceRequest
            where Res : AmazonWebServiceResponse
        {
            ProcessPreRequestHandlers(request);

            IRequest irequest = marshaller.Marshall(request);

            WebRequestState state = new WebRequestState(irequest, unmarshaller, signer);
            state.Metrics.StartEvent(Metric.ClientExecuteTime);

            irequest.Endpoint = DetermineEndpoint(irequest);
            if (Config.LogMetrics)
            {
                state.Metrics.IsEnabled = true;
                state.Metrics.AddProperty(Metric.ServiceName, irequest.ServiceName);
                state.Metrics.AddProperty(Metric.ServiceEndpoint, irequest.Endpoint);
                state.Metrics.AddProperty(Metric.MethodName, irequest.RequestName);
            }
            ConfigureRequest(state);
            return InvokeHelper<Res>(state, cancellationToken);
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

        private Task<T> InvokeHelper<T>(WebRequestState state, CancellationToken cancellationToken) where T : AmazonWebServiceResponse
        {
            if (state.RetriesAttempt == 0 || Config.ResignRetries)
            {
                SignRequest(state);
            }
            if (state.RetriesAttempt > 0)
                HandleRetry(state);

            return InvokeConfiguredRequest<T>(state, cancellationToken);
        }

        private async Task<T> InvokeConfiguredRequest<T>(WebRequestState state, CancellationToken cancellationToken) where T : AmazonWebServiceResponse
        {
            int currentRetries = state.RetriesAttempt;
            T response = null;
            bool shouldRetry = false;
            bool responseReceived = false;
            HttpResponseMessage responseMessage = null;
            HttpClientResponseData responseData = null;
            var requestMessage = ConfigureRequestMessage(state);
            try
            {
                try
                {
                    SetContent(requestMessage, state);

                    using (state.Metrics.StartEvent(Metric.HttpRequestTime))
                    {
                        responseMessage = await httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                            .ConfigureAwait(continueOnCapturedContext: false);
                        responseReceived = true;
                    }

                    responseData = new HttpClientResponseData(responseMessage);
                    if (!IsErrorResponse(responseMessage) ||
                        responseMessage.StatusCode == HttpStatusCode.NotFound && state.Request.Suppress404Exceptions)
                    {
                        using (state.Metrics.StartEvent(Metric.ResponseProcessingTime))
                        {
                            response = (T)await HandleHttpContentAsync(state, responseMessage, responseData)
                                .ConfigureAwait(continueOnCapturedContext: false);
                        }
                    }
                    else
                    {
                        bool retry = await HandleHttpErrorResponseAsync(state, responseMessage, responseData, cancellationToken)
                            .ConfigureAwait(continueOnCapturedContext: false);
                        if (retry)
                        {
                            shouldRetry = true;
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    var we = e.InnerException as WebException;

                    if (we != null)
                    {
                        if (WebExceptionStatusesToThrowOn.Contains(we.Status))
                        {
                            throw new AmazonServiceException("Encountered a non retryable WebException : " + we.Status, we);
                        }

                        // The WinRT framework doesn't break down errors, not all status values are available for WinRT.                
                        if (
#if WIN_RT                    
                    (we.Status == WebExceptionStatus.UnknownError || WebExceptionStatusesToRetryOn.Contains(we.Status))
#else
WebExceptionStatusesToRetryOn.Contains(we.Status)
#endif
)
                        {
                            shouldRetry = RetryOrThrow(state, e);
                        }
                    }

                    var ioe = e.InnerException as IOException;
                    if (ioe != null)
                    {
#if !WIN_RT
                        if (IsInnerExceptionThreadAbort(ioe))
                        { throw new AmazonServiceException(e); }
#endif
                        shouldRetry = RetryOrThrow(state, e);
                    }

                    // Check if response is null at the end as
                    // it can be null for both WebException and IOException.
                    if (!shouldRetry && response == null)
                    {
                        shouldRetry = RetryOrThrow(state, e);
                    }

                    // If shouldRetry is not set by any of the above checks,
                    // re-throw the exception.
                    if (!shouldRetry)
                    {
                        throw new AmazonServiceException(e);
                    }
                }
                catch (TaskCanceledException taskCancelledException)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        throw;
                    }
                    else
                    {
                        // It's a timeout exception.
                        throw new AmazonServiceException(taskCancelledException);
                    }
                }
                catch (OperationCanceledException operationCancelledException)
                {                    
                    if (cancellationToken.IsCancellationRequested)
                    {
                        // Throw an exception with the original cancellation token.
                        throw new OperationCanceledException(operationCancelledException.Message, cancellationToken);
                    }
                    else
                    {
                        // It's a timeout exception.
                        throw new AmazonServiceException(operationCancelledException);
                    }
                }
                finally
                {
                    if (responseMessage != null && !state.Unmarshaller.HasStreamingProperty)
                    {
                        responseMessage.Dispose();
                        responseMessage = null;
                    }
                }

                if (shouldRetry)
                {
                    pauseExponentially(state);
                    cancellationToken.ThrowIfCancellationRequested();
                    state.RetriesAttempt++;
                    var retryResponse = await InvokeHelper<T>(state, cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);
                    return (T)retryResponse;
                }
                else
                {
                    LogFinalMetrics(state.Metrics);
                }
            }
            catch (Exception e)
            {
                // On errors that are passed to the client, invoke exception handlers
                if (!shouldRetry)
                {
                    ProcessExceptionHandlers(e, state.Request);
                }
                throw;
            }
            finally
            {
                // ProcessResponseHandlers is called only if a response was received from the server (success or error).
                // It's not called in case of client errors like timeout or proxy error.
                if (!shouldRetry && responseReceived)
                {
                    ProcessResponseHandlers(response, state.Request, responseData);
                }
            }

            return response;
        }

        protected virtual bool IsErrorResponse(HttpResponseMessage responseMessage)
        {
            return !responseMessage.IsSuccessStatusCode;
        }

        void SetContent(HttpRequestMessage requestMessage, IRequestData state)
        {
            var request = state.Request;
            if (requestMessage.Method == HttpMethod.Get || 
                requestMessage.Method == HttpMethod.Delete || 
                requestMessage.Method == HttpMethod.Head)
            {
                return;
            }

            byte[] requestData;
            if (request.UseQueryString)
            {
                requestMessage.Content = new ByteArrayContent(new Byte[0]);
            }
            else if (request.ContentStream != null)
            {
                var eventStream = new EventStream(request.ContentStream, true);
                var tracker = new StreamReadTracker(this, request.OriginalRequest.StreamUploadProgressCallback, request.ContentStream.Length);
                eventStream.OnRead += tracker.ReadProgress;

                Stream finalStream;
                StreamContent content;
                if (state.Request.UseChunkEncoding && state.Request.AWS4SignerResult != null)
                {
                    finalStream = new ChunkedUploadWrapperStream(eventStream, Config.BufferSize, state.Request.AWS4SignerResult);
                }
                else
                {
                    finalStream = eventStream;
                }

                content = new StreamContent(finalStream, this.Config.BufferSize);
                requestMessage.Content = content;
                requestMessage.Content.Headers.ContentLength = finalStream.Length;
            }
            else if ((requestData = GetRequestData(request)) != null)
            {
                state.Metrics.AddProperty(Metric.RequestSize, requestData.Length);
                requestMessage.Content = new ByteArrayContent(requestData);
            }
            else
            {
                requestMessage.Content = new ByteArrayContent(new Byte[0]);
            }

            requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse(request.Headers["Content-Type"]);

            if (requestMessage.Content != null)
            {
                if(request.Headers.ContainsKey("Content-Range"))
                    requestMessage.Content.Headers.Add("Content-Range", request.Headers["Content-Range"]);

                if (request.Headers.ContainsKey("Content-MD5"))
                    requestMessage.Content.Headers.TryAddWithoutValidation("Content-MD5", request.Headers["Content-MD5"]);

                if (request.Headers.ContainsKey("Content-Encoding"))
                    requestMessage.Content.Headers.TryAddWithoutValidation("Content-Encoding", request.Headers["Content-Encoding"]);

                if (request.Headers.ContainsKey("Content-Disposition"))
                    requestMessage.Content.Headers.TryAddWithoutValidation("Content-Disposition", request.Headers["Content-Disposition"]);

                DateTime expires;
                if (request.Headers.ContainsKey("Expires") &&
                    DateTime.TryParse(request.Headers["Expires"], CultureInfo.InvariantCulture, DateTimeStyles.None, out expires))
                    requestMessage.Content.Headers.Expires = expires;
            }
        }

        private async Task<AmazonWebServiceResponse> HandleHttpContentAsync(WebRequestState state, HttpResponseMessage httpResponse, HttpClientResponseData responseData)
        {
            LogResponse(state.Metrics, state.Request, httpResponse.StatusCode);
            AmazonWebServiceResponse response = null;
            UnmarshallerContext context = null;
            try
            {
                var responseStream = await responseData.OpenResponseAsync()
                    .ConfigureAwait(continueOnCapturedContext: false);
                context = state.Unmarshaller.CreateContext(responseData,
                    this.SupportResponseLogging &&
                    (Config.LogResponse || Config.ReadEntireResponse || AWSConfigs.LoggingConfig.LogResponses != ResponseLoggingOption.Never),
                    responseStream,
                    state.Metrics);

                using (state.Metrics.StartEvent(Metric.ResponseUnmarshallTime))
                {
                    response = state.Unmarshaller.Unmarshall(context);
                }
                context.ValidateCRC32IfAvailable();

                var contentHeaders = httpResponse.Content.Headers as HttpContentHeaders;
                if (contentHeaders != null)
                {
                    response.ContentLength = contentHeaders.ContentLength.GetValueOrDefault();
                    response.HttpStatusCode = httpResponse.StatusCode;
                }

                if (response.ResponseMetadata != null)
                {
                    state.Metrics.AddProperty(Metric.AWSRequestID, response.ResponseMetadata.RequestId);
                }
                LogFinishedResponse(state.Metrics, context, response.ContentLength);

                return response;
            }
            finally
            {
                if (!state.Unmarshaller.HasStreamingProperty)
                    httpResponse.Dispose();
            }
        }

        private async Task<bool> HandleHttpErrorResponseAsync(WebRequestState state, HttpResponseMessage httpErrorResponse, HttpClientResponseData responseData, CancellationToken cancellationToken)
        {
            HttpStatusCode statusCode;
            AmazonServiceException errorResponseException = null;

            UnmarshallerContext errorContext = null;

                statusCode = httpErrorResponse.StatusCode;
                state.Metrics.AddProperty(Metric.StatusCode, statusCode);
                string redirectedLocation = responseData.GetHeaderValue("location");
                state.Metrics.AddProperty(Metric.RedirectLocation, redirectedLocation);

                var responseStream = await responseData.OpenResponseAsync()
                    .ConfigureAwait(continueOnCapturedContext: false);
                errorContext = state.Unmarshaller.CreateContext(responseData,
                    Config.LogResponse || Config.ReadEntireResponse || AWSConfigs.LoggingConfig.LogResponses != ResponseLoggingOption.Never,
                    responseStream,
                    state.Metrics);
                errorResponseException = state.Unmarshaller.UnmarshallException(errorContext, null, statusCode);
                if (Config.LogResponse || AWSConfigs.LoggingConfig.LogResponses != ResponseLoggingOption.Never)
                {
                    this.logger.Error(errorResponseException, "Received error response: [{0}]", errorContext.ResponseBody);
                }
                state.Metrics.AddProperty(Metric.AWSRequestID, errorResponseException.RequestId);
                state.Metrics.AddProperty(Metric.AWSErrorCode, errorResponseException.ErrorCode);

                if (CanRetry(state))
                {
                    if (isTemporaryRedirect(statusCode, redirectedLocation))
                    {
                        this.logger.DebugFormat("Request {0} is being redirected to {1}.", state.Request.RequestName, redirectedLocation);
                        state.Request.Endpoint = new Uri(redirectedLocation);
                        return true;
                    }
                    else if (ShouldRetry(statusCode, this.Config, errorResponseException, state.RetriesAttempt))
                    {
                        this.logger.DebugFormat("Retry number {0} for request {1}.", state.RetriesAttempt, state.Request.RequestName);
                        pauseExponentially(state);
                        cancellationToken.ThrowIfCancellationRequested();
                        return true;
                    }
                }

                if (errorResponseException != null)
                {
                    this.logger.Error(errorResponseException, "Error making request {0}.", state.Request.RequestName);
                    state.Metrics.AddProperty(Metric.Exception, errorResponseException);
                    throw errorResponseException;
                }


            AmazonServiceException excep = new AmazonServiceException("Unable to make request", null, statusCode);
            this.logger.Error(excep, "Error making request {0}.", state.Request.RequestName);
            state.Metrics.AddProperty(Metric.Exception, excep);
            throw excep;
        }

        protected HttpClient ConfigureHttpClient()
        {
#if BCL45
            var httpMessageHandler = new WebRequestHandler();
            if (this.Config.ReadWriteTimeout.HasValue)
            {
                // ReadWriteTimeout value is set to ClientConfig.MaxTimeout for S3 and Glacier.
                // Use default value (300 seconds) for other services.
                httpMessageHandler.ReadWriteTimeout = (int)this.Config.ReadWriteTimeout.Value.TotalMilliseconds;
            }            
#else
            var httpMessageHandler = new HttpClientHandler();
#endif

#if BCL
            
            // Make one time configuration changes to the service point
            if (!configuredServicePoint)
            {
                lock (SERVICE_POINT_LOCK)
                {
                    var point = ServicePointManager.FindServicePoint(this.Config.DetermineServiceURL(), httpMessageHandler.Proxy);
                    if (point != null)
                    {
                        point.ConnectionLimit = this.Config.ConnectionLimit;
                        point.UseNagleAlgorithm = this.Config.UseNagleAlgorithm;
                        point.MaxIdleTime = this.Config.MaxIdleTime;
                    }

                    configuredServicePoint = true;
                }
            }

            if (this.Config.ProxyHost != null && this.Config.ProxyPort != 0)
            {
                WebProxy proxy = new WebProxy(this.Config.ProxyHost, this.Config.ProxyPort);   
                httpMessageHandler.Proxy = proxy;
            }
#endif
            if (httpMessageHandler.Proxy != null && Config.ProxyCredentials != null)
            {
                httpMessageHandler.Proxy.Credentials = Config.ProxyCredentials;
            }

            var httpClient = new HttpClient(httpMessageHandler);            
            if (this.Config.Timeout.HasValue)
            {
                // Timeout value is set to ClientConfig.MaxTimeout for S3 and Glacier.
                // Use default value (100 seconds) for other services.
                httpClient.Timeout = this.Config.Timeout.Value;
            }
            // Disable the Expect 100-continue header
            httpClient.DefaultRequestHeaders.ExpectContinue = false;            
            return httpClient;
        }

        protected virtual HttpRequestMessage ConfigureRequestMessage(IRequestData state)
        {
            IRequest wrappedRequest = state.Request;
            bool acceptJson = state.Unmarshaller is JsonResponseUnmarshaller;

            Uri url = ComposeUrl(wrappedRequest, wrappedRequest.Endpoint);
            var request = new HttpRequestMessage();
            request.RequestUri = url;

            HttpMethod method;
            switch (wrappedRequest.HttpMethod.ToUpperInvariant())
            {
                case "GET":
                    method = HttpMethod.Get;
                    break;
                case "HEAD":
                    method = HttpMethod.Head;
                    break;
                case "PUT":
                    method = HttpMethod.Put;
                    break;
                case "POST":
                    method = HttpMethod.Post;
                    break;
                case "DELETE":
                    method = HttpMethod.Delete;
                    break;
                default:
                    throw new AmazonClientException("Invalid HttpMethod " + wrappedRequest.HttpMethod);
            }

            request.Method = method;
            if (!wrappedRequest.UseQueryString && (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put))
            {
                if (wrappedRequest.ContentStream != null)
                {
                    if (wrappedRequest.OriginalRequest.IncludeSHA256Header 
                        && !wrappedRequest.Headers.ContainsKey(AWS4Signer.XAmzContentSha256))
                    {
                        request.Headers.TryAddWithoutValidation(AWS4Signer.XAmzContentSha256, wrappedRequest.ComputeContentStreamHash());
                    }
                    request.Headers.TryAddWithoutValidation("content-length", wrappedRequest.ContentStream.Length.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    byte[] requestData = GetRequestData(wrappedRequest);
                    request.Headers.TryAddWithoutValidation("content-length", requestData.Length.ToString(CultureInfo.InvariantCulture));
                }
            }
            else
            {
                string headerValue;
                if (wrappedRequest.Headers.TryGetValue("x-amz-content-length", out headerValue) && headerValue != null)
                {
                    request.Headers.Add("content-length", headerValue);
                }
            }

            foreach (var kvp in wrappedRequest.Headers)
            {
                if (!string.Equals(kvp.Key, "Content-MD5", StringComparison.OrdinalIgnoreCase))
                {
                    request.Headers.TryAddWithoutValidation(kvp.Key, kvp.Value);
                }
                
            }

            if (acceptJson)
            {
                request.Headers.Accept.ParseAdd("application/json");
            }


            return request;
        }



        protected static void LogResponse(RequestMetrics metrics, IRequest request, HttpStatusCode statusCode)
        {
            metrics.AddProperty(Metric.StatusCode, statusCode);
        }


        private bool RetryOrThrow(WebRequestState state, Exception exception)
        {
            if (CanRetry(state) && state.RetriesAttempt < Config.MaxErrorRetry)
            {
                this.logger.DebugFormat("Retry number {0} for request {1}.", state.RetriesAttempt, state.Request.RequestName);
                return true;
            }
            else
            {
                var webException = exception.InnerException as WebException;
                if (webException!=null)
                {
                    var errorMessage = string.Format(CultureInfo.InvariantCulture,
                        "Encountered a WebException ({0}), the request cannot be retried. Either the maximum number of retries has been exceeded ({1}/{2}) or the request is using a non-seekable stream.",
                        webException.Status, state.RetriesAttempt, Config.MaxErrorRetry);
                    throw new AmazonServiceException(errorMessage, exception);
                }
                throw new AmazonServiceException(exception);
            }
        }
    }
}
