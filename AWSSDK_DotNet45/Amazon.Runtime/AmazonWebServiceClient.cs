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

        internal AmazonWebServiceClient(AWSCredentials credentials, ClientConfig config, bool ownCredentials, AuthenticationTypes authenticationType)
            : base(credentials, config, ownCredentials, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : base((AWSCredentials)new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey),
                config, true, authenticationType)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config, AuthenticationTypes authenticationType)
            : base(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, true, authenticationType)
        {
        }


        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
            : base(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true, AuthenticationTypes.User)
        {
        }

        internal AmazonWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
            : base(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, true, AuthenticationTypes.User)
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.httpClient = ConfigureHttpClient();
        }

        #endregion


        protected async Task<Res> Invoke<T, Req, Res>(Req request, IMarshaller<T, Req> marshaller, ResponseUnmarshaller unmarshaller, AbstractAWSSigner signer, CancellationToken cancellationToken = default(CancellationToken))
            where T : IRequest
            where Req : AmazonWebServiceRequest
            where Res : AmazonWebServiceResponse
        {
            ProcessPreRequestHandlers(request);

            IRequest irequest = marshaller.Marshall(request);

            WebRequestState state = new WebRequestState(irequest, unmarshaller, signer);
            state.Metrics.StartEvent(RequestMetrics.Metric.ClientExecuteTime);

            irequest.Endpoint = DetermineEndpoint(irequest);
            if (config.LogMetrics)
            {
                state.Metrics.IsEnabled = true;
                state.Metrics.AddProperty(RequestMetrics.Metric.ServiceName, irequest.ServiceName);
                state.Metrics.AddProperty(RequestMetrics.Metric.ServiceEndpoint, irequest.Endpoint);
                state.Metrics.AddProperty(RequestMetrics.Metric.MethodName, irequest.RequestName);
            }
            ConfigureRequest(state);
            Res response = await InvokeHelper<Res>(state, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }

        protected Uri DetermineEndpoint(IRequest request)
        {
            Uri endpoint;
            if (request.AlternateEndpoint != null)
                endpoint = new Uri(ClientConfig.GetUrl(request.AlternateEndpoint, config.RegionEndpointServiceName, config.UseHttp));
            else
                endpoint = new Uri(this.config.DetermineServiceURL());
            return endpoint;
        }

        private async Task<T> InvokeHelper<T>(WebRequestState state, CancellationToken cancellationToken) where T : AmazonWebServiceResponse
        {
            if (state.RetriesAttempt == 0 || config.ResignRetries)
            {
                SignRequest(state);
            }
            if (state.RetriesAttempt > 0)
                HandleRetry(state);

            T response = await InvokeConfiguredRequest<T>(state, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }

        private async Task<T> InvokeConfiguredRequest<T>(WebRequestState state, CancellationToken cancellationToken) where T : AmazonWebServiceResponse
        {
            logger.DebugFormat("Starting request {0} at {1}", state.Request.RequestName, this.config.ServiceURL);

            T response = null;
            bool shouldRetry = false;
            HttpResponseMessage responseMessage = null;
            var requestMessage = ConfigureRequestMessage(state.Request, state.Unmarshaller is JsonResponseUnmarshaller);
            try
            {
                SetContent(requestMessage, state.Request);

                responseMessage = await httpClient.SendAsync(requestMessage, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                if (!IsErrorResponse(responseMessage) ||
                    responseMessage.StatusCode == HttpStatusCode.NotFound && state.Request.Suppress404Exceptions)
                {
                    response = (T)HandleHttpContent(state, responseMessage, cancellationToken);
                }
                else
                {
                    bool retry = HandleHttpErrorResponse(state, responseMessage, cancellationToken);
                    if (retry)
                    {
                        shouldRetry = true;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                var we = e.InnerException as WebException;
                
                if (CanRetry(state) &&
                    we != null && state.RetriesAttempt < config.MaxErrorRetry && 
#if WIN_RT
                    // The WinRT framework doesn't break down errors
                    (we.Status == WebExceptionStatus.UnknownError))
#else
                    // If it is a keep alive error or name resolution error then attempt a retry
                    (we.Status == WebExceptionStatus.KeepAliveFailure || we.Status == WebExceptionStatus.NameResolutionFailure))
#endif
                {
                    pauseExponentially(state);
                    cancellationToken.ThrowIfCancellationRequested();
                    shouldRetry = true;
                }
                else
                {
                    throw new AmazonServiceException(e);
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
                cancellationToken.ThrowIfCancellationRequested();
                state.RetriesAttempt++;
                var retryResponse = await InvokeHelper<T>(state, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
                return (T)retryResponse;
            }

            return response;
        }

        protected virtual bool IsErrorResponse(HttpResponseMessage responseMessage)
        {
            return !responseMessage.IsSuccessStatusCode;
        }

        void SetContent(HttpRequestMessage requestMessage, IRequest request)
        {
            if (requestMessage.Method == HttpMethod.Get || requestMessage.Method == HttpMethod.Delete || requestMessage.Method == HttpMethod.Head)
            {
                return;
            }

            byte[] requestData;
            if (request.ContentStream != null)
            {
                var eventStream = new EventStream(request.ContentStream, true);
                var tracker = new StreamReadTracker(this, request.OriginalRequest.StreamUploadProgressCallback, request.ContentStream.Length);
                eventStream.OnRead += tracker.ReadProgress;
                requestMessage.Content = new StreamContent(eventStream);
                requestMessage.Content.Headers.ContentLength = request.ContentStream.Length;
            }
            else if ((requestData = GetRequestData(request)) != null)
            {
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

            }
        }

        AmazonWebServiceResponse HandleHttpContent(WebRequestState state, HttpResponseMessage httpResponse, CancellationToken cancellationToken)
        {
            LogResponse(state.Metrics, state.Request, httpResponse.StatusCode);
            AmazonWebServiceResponse response = null;
            IWebResponseData responseData = new HttpClientResponseData(httpResponse);
            try
            {
                var context = state.Unmarshaller.CreateContext(responseData, config.LogResponse || config.ReadEntireResponse, state.Metrics);

                response = state.Unmarshaller.Unmarshall(context);
                context.ValidateCRC32IfAvailable();

                var contentHeaders = httpResponse.Content.Headers as HttpContentHeaders;
                if (contentHeaders != null)
                {
                    response.ContentLength = contentHeaders.ContentLength.GetValueOrDefault();
                    response.HttpStatusCode = httpResponse.StatusCode;
                }

                LogFinishedResponse(state.Metrics, context, response.ContentLength);

                return response;
            }
            finally
            {
                if (!state.Unmarshaller.HasStreamingProperty)
                    httpResponse.Dispose();

                ProcessResponseHandlers(response, state.Request, responseData);
            }
        }

        private bool HandleHttpErrorResponse(WebRequestState state, HttpResponseMessage httpErrorResponse, CancellationToken cancellationToken)
        {
            HttpStatusCode statusCode;
            AmazonServiceException errorResponseException = null;

            IWebResponseData responseData = new HttpClientResponseData(httpErrorResponse);

            statusCode = httpErrorResponse.StatusCode;
            state.Metrics.AddProperty(RequestMetrics.Metric.StatusCode, statusCode);
            string redirectedLocation = responseData.GetHeaderValue("location");
            state.Metrics.AddProperty(RequestMetrics.Metric.RedirectLocation, redirectedLocation);

            UnmarshallerContext errorContext = state.Unmarshaller.CreateContext(responseData, config.LogResponse || config.ReadEntireResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never, state.Metrics);
            errorResponseException = state.Unmarshaller.UnmarshallException(errorContext, null, statusCode);
            if (config.LogResponse || AWSConfigs.ResponseLogging != ResponseLoggingOption.Never)
            {
                this.logger.Error(errorResponseException, "Received error response: [{0}]", errorContext.ResponseBody);
            }
            state.Metrics.AddProperty(RequestMetrics.Metric.AWSRequestID, errorResponseException.RequestId);
            state.Metrics.AddProperty(RequestMetrics.Metric.AWSErrorCode, errorResponseException.ErrorCode);

            if (CanRetry(state))
            {
                if (isTemporaryRedirect(statusCode, redirectedLocation))
                {
                    this.logger.DebugFormat("Request {0} is being redirected to {1}.", state.Request.RequestName, redirectedLocation);
                    state.Request.Endpoint = new Uri(redirectedLocation);
                    return true;
                }
                else if (ShouldRetry(statusCode, this.config, errorResponseException, state.RetriesAttempt))
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
                throw errorResponseException;
            }

            AmazonServiceException excep = new AmazonServiceException("Unable to make request", null, statusCode);
            this.logger.Error(excep, "Error making request {0}.", state.Request.RequestName);
            state.Metrics.AddProperty(RequestMetrics.Metric.Exception, excep);
            ProcessResponseHandlers(null, state.Request, responseData);

            throw excep;
        }

        protected HttpClient ConfigureHttpClient()
        {
            var httpMessageHandler = new HttpClientHandler();


#if BCL
            
            // Make one time configuration changes to the service point
            if (!configuredServicePoint)
            {
                lock (SERVICE_POINT_LOCK)
                {
                    var point = ServicePointManager.FindServicePoint(this.config.DetermineServiceURL(), httpMessageHandler.Proxy);
                    if (point != null)
                    {
                        point.ConnectionLimit = this.config.ConnectionLimit;
                        point.UseNagleAlgorithm = this.config.UseNagleAlgorithm;
                    }

                    configuredServicePoint = true;
                }
            }

            if (this.config.ProxyHost != null && this.config.ProxyPort != 0)
            {
                WebProxy proxy = new WebProxy(this.config.ProxyHost, this.config.ProxyPort);   
                httpMessageHandler.Proxy = proxy;
            }
#endif
            if (httpMessageHandler.Proxy != null && config.ProxyCredentials != null)
            {
                httpMessageHandler.Proxy.Credentials = config.ProxyCredentials;
            }


            var httpClient = new HttpClient(httpMessageHandler);
            httpClient.Timeout = TimeSpan.FromMilliseconds(int.MaxValue);
            
            return httpClient;
        }

        protected virtual HttpRequestMessage ConfigureRequestMessage(IRequest wrappedRequest, bool acceptJson)
        {
            Uri url = ComposeUrl(wrappedRequest, wrappedRequest.Endpoint);
            var request = new HttpRequestMessage();
            request.RequestUri = url;

            HttpMethod method;
            switch (wrappedRequest.HttpMethod.ToUpper())
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
                    if (wrappedRequest.OriginalRequest.IncludeSHA256Header)
                    {
                        request.Headers.TryAddWithoutValidation("x-amz-content-sha256", wrappedRequest.ContentStreamHash);
                    }
                    request.Headers.TryAddWithoutValidation("content-length", wrappedRequest.ContentStream.Length.ToString());
                }
                else
                {
                    byte[] requestData = GetRequestData(wrappedRequest);
                    request.Headers.TryAddWithoutValidation("content-length", requestData.Length.ToString());
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

        internal class StreamReadTracker
        {
            AmazonWebServiceClient client;
            EventHandler<StreamTransferProgressArgs> callback;
            long contentLength;
            long totalBytesRead;

            internal StreamReadTracker(AmazonWebServiceClient client, EventHandler<StreamTransferProgressArgs> callback, long contentLength)
            {
                this.client = client;
                this.callback = callback;
                this.contentLength = contentLength;
            }

            public void ReadProgress(int bytesRead)
            {
                if (callback == null)
                    return;

                totalBytesRead += bytesRead;
                AWSSDKUtils.InvokeInBackground(
                                    callback,
                                    new StreamTransferProgressArgs(bytesRead, totalBytesRead, contentLength),
                                    client);
            }
        }
    }
}
