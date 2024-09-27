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

using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Text;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// The HTTP handler contains common logic for issuing an HTTP request that is 
    /// independent of the underlying HTTP infrastructure.
    /// </summary>
    /// <typeparam name="TRequestContent"></typeparam>
    public class HttpHandler<TRequestContent> : PipelineHandler, IDisposable
    {
        private bool _disposed;
        private IHttpRequestFactory<TRequestContent> _requestFactory;

        /// <summary>
        /// The sender parameter used in any events raised by this handler.
        /// </summary>
        public object CallbackSender { get; private set; }

        /// <summary>
        /// The constructor for HttpHandler.
        /// </summary>
        /// <param name="requestFactory">The request factory used to create HTTP Requests.</param>
        /// <param name="callbackSender">The sender parameter used in any events raised by this handler.</param>
        public HttpHandler(IHttpRequestFactory<TRequestContent> requestFactory, object callbackSender)
        {
            _requestFactory = requestFactory;
            this.CallbackSender = callbackSender;
        }

        /// <summary>
        /// Issues an HTTP request for the current request context.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            IHttpRequest<TRequestContent> httpRequest = null;
            try
            {
                SetMetrics(executionContext.RequestContext);
                IRequest wrappedRequest = executionContext.RequestContext.Request;
                httpRequest = CreateWebRequest(executionContext.RequestContext);
                httpRequest.SetRequestHeaders(wrappedRequest.Headers);

                using (executionContext.RequestContext.Metrics.StartEvent(Metric.HttpRequestTime))
                using (var traceSpan = TracingUtilities.CreateSpan(executionContext.RequestContext, TelemetryConstants.HTTPRequestSpanName))
                using (MetricsUtilities.MeasureDuration(executionContext.RequestContext, TelemetryConstants.CallAttemptDurationMetricName))
                {
                    // Send request body if present.
                    if (wrappedRequest.HasRequestBody())
                    {
                        try
                        {
                            var requestContent = httpRequest.GetRequestContent();
                            WriteContentToRequestBody(requestContent, httpRequest, executionContext.RequestContext);
                        }
                        catch (Exception ex)
                        {
                            CompleteFailedRequest(httpRequest);
                            traceSpan.CaptureException(ex);
                            throw;
                        }
                    }

                    executionContext.ResponseContext.HttpResponse = httpRequest.GetResponse();
                    RecordHttpTelemetryData(executionContext, traceSpan, wrappedRequest);
                }
            }
            finally
            {
                if (httpRequest != null)
                    httpRequest.Dispose();
            }
        }

        private static void CompleteFailedRequest(IHttpRequest<TRequestContent> httpRequest)
        {
            try
            {
                // In some cases where writing the request body fails, HttpWebRequest.Abort
                // may not dispose of the underlying Socket, so we need to retrieve and dispose
                // the web response to close the socket
                IWebResponseData response = null;
                try
                {
                    response = httpRequest.GetResponse();
                }
                catch (WebException webException)
                {
                    if (webException.Response != null)
                    {
                        webException.Response.Dispose();
                    }
                }
                catch (HttpErrorResponseException httpErrorResponse)
                {
                    if (httpErrorResponse.Response != null && httpErrorResponse.Response.ResponseBody != null)
                        httpErrorResponse.Response.ResponseBody.Dispose();
                }
                finally
                {
                    if (response != null && response.ResponseBody != null)
                        response.ResponseBody.Dispose();
                }
            }
            catch { }
        }

        private static void RecordHttpTelemetryData(IExecutionContext executionContext, TraceSpan traceSpan, IRequest request)
        {
            var response = executionContext.ResponseContext.HttpResponse;

            var metricsAttributes = new Attributes();
            metricsAttributes.Set(TelemetryConstants.ServerAddressAttributeKey, $"{request.Endpoint.Host}:{request.Endpoint.Port.ToString()}");

            traceSpan.SetAttribute(TelemetryConstants.HTTPMethodAttributeKey, request.HttpMethod);
            traceSpan.SetAttribute(TelemetryConstants.HTTPStatusCodeAttributeKey, ((int)response.StatusCode));

            var contentLengthHeader = request.GetHeaderValue(HeaderKeys.ContentLengthHeader);
            if (long.TryParse(contentLengthHeader, out var contentLength) && contentLength > 0)
            {
                traceSpan.SetAttribute(TelemetryConstants.HTTPRequestContentLengthAttributeKey, contentLength);

                MetricsUtilities.AddMonotonicCounterValue(executionContext.RequestContext,
                    TelemetryConstants.HTTPBytesSentMetricName,
                    TelemetryConstants.BytesUnitName,
                    contentLength,
                    metricsAttributes);
            }

            if (response.ContentLength > 0)
            {
                MetricsUtilities.AddMonotonicCounterValue(executionContext.RequestContext,
                    TelemetryConstants.HTTPBytesReceivedMetricName,
                    TelemetryConstants.BytesUnitName,
                    response.ContentLength,
                    metricsAttributes);
            }

            traceSpan.SetAttribute(TelemetryConstants.HTTPResponseContentLengthAttributeKey, response.ContentLength);
        }
		
#if AWS_ASYNC_API 
        /// <summary>
        /// Issues an HTTP request for the current request context.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            IHttpRequest<TRequestContent> httpRequest = null;
            try
            {
                SetMetrics(executionContext.RequestContext);
                IRequest wrappedRequest = executionContext.RequestContext.Request;
                httpRequest = CreateWebRequest(executionContext.RequestContext);
                httpRequest.SetRequestHeaders(wrappedRequest.Headers);
                
                using (executionContext.RequestContext.Metrics.StartEvent(Metric.HttpRequestTime))
                using (var traceSpan = TracingUtilities.CreateSpan(executionContext.RequestContext, TelemetryConstants.HTTPRequestSpanName))
                using (MetricsUtilities.MeasureDuration(executionContext.RequestContext, TelemetryConstants.CallAttemptDurationMetricName))
                {
                    // Send request body if present.
                    if (wrappedRequest.HasRequestBody())
                    {
                        System.Runtime.ExceptionServices.ExceptionDispatchInfo edi = null;
                        try
                        {
                            // In .NET Framework, there needs to be a cancellation token in this method since GetRequestStreamAsync
                            // does not accept a cancellation token. A workaround is used. This isn't necessary in .NET Standard
                            // where the stream is a property of the request.
#if BCL
                            var requestContent = await httpRequest.GetRequestContentAsync(executionContext.RequestContext.CancellationToken).ConfigureAwait(false);
                            await WriteContentToRequestBodyAsync(requestContent, httpRequest, executionContext.RequestContext).ConfigureAwait(false);
#else
                            var requestContent = await httpRequest.GetRequestContentAsync().ConfigureAwait(false);
                            WriteContentToRequestBody(requestContent, httpRequest, executionContext.RequestContext);
#endif
                        }
                        catch (Exception e)
                        {
                            traceSpan.CaptureException(e);
                            edi = System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(e);
                        }

                        if (edi != null)
                        {
                            await CompleteFailedRequest(executionContext, httpRequest).ConfigureAwait(false);

                            edi.Throw();
                        }
                    }
                
                    var response = await httpRequest.GetResponseAsync(executionContext.RequestContext.CancellationToken).
                        ConfigureAwait(false);
                    executionContext.ResponseContext.HttpResponse = response;
                    RecordHttpTelemetryData(executionContext, traceSpan, wrappedRequest);
                }
                // The response is not unmarshalled yet.
                return null;
            }            
            finally
            {
                if (httpRequest != null)
                    httpRequest.Dispose();
            }
        }

        private static async System.Threading.Tasks.Task CompleteFailedRequest(IExecutionContext executionContext, IHttpRequest<TRequestContent> httpRequest)
        {
            // In some cases where writing the request body fails, HttpWebRequest.Abort
            // may not dispose of the underlying Socket, so we need to retrieve and dispose
            // the web response to close the socket
            IWebResponseData iwrd = null;
            try
            {
                iwrd = await httpRequest.GetResponseAsync(executionContext.RequestContext.CancellationToken).ConfigureAwait(false);
            }
            catch { }
            finally
            {
                if (iwrd != null && iwrd.ResponseBody != null)
                    iwrd.ResponseBody.Dispose();
            }
        }
#endif

        private static void SetMetrics(IRequestContext requestContext)
        {
            requestContext.Metrics.AddProperty(Metric.ServiceName, requestContext.Request.ServiceName);
            requestContext.Metrics.AddProperty(Metric.ServiceEndpoint, requestContext.Request.Endpoint);
            requestContext.Metrics.AddProperty(Metric.MethodName, requestContext.Request.RequestName);
        }

        /// <summary>
        /// Determines the content for request body and uses the HTTP request
        /// to write the content to the HTTP request body.
        /// </summary>
        /// <param name="requestContent">Content to be written.</param>
        /// <param name="httpRequest">The HTTP request.</param>
        /// <param name="requestContext">The request context.</param>
        private void WriteContentToRequestBody(TRequestContent requestContent,
            IHttpRequest<TRequestContent> httpRequest,
            IRequestContext requestContext)
        {
            IRequest wrappedRequest = requestContext.Request;

            // This code path ends up using a ByteArrayContent for System.Net.HttpClient used by .NET Core.
            // HttpClient can't seem to handle ByteArrayContent with 0 length so in that case use
            // the StreamContent code path.
            if (wrappedRequest.Content != null && wrappedRequest.Content.Length > 0)
            {
                byte[] requestData = wrappedRequest.Content;
                requestContext.Metrics.AddProperty(Metric.RequestSize, requestData.Length);
                httpRequest.WriteToRequestBody(requestContent, requestData, requestContext.Request.Headers);
            }
            else
            {
                System.IO.Stream originalStream;
                if (wrappedRequest.ContentStream == null)
                {
                    originalStream = new System.IO.MemoryStream();
                    originalStream.Write(wrappedRequest.Content, 0, wrappedRequest.Content.Length);
                    originalStream.Position = 0;
                }
                else
                {
                    originalStream = wrappedRequest.ContentStream;
                }

                var callback = ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)wrappedRequest.OriginalRequest).StreamUploadProgressCallback;
                if (callback != null)
                    originalStream = httpRequest.SetupProgressListeners(originalStream, requestContext.ClientConfig.ProgressUpdateInterval, this.CallbackSender, callback);
                var inputStream = GetInputStream(requestContext, originalStream, wrappedRequest);
                httpRequest.WriteToRequestBody(requestContent, inputStream, 
                    requestContext.Request.Headers, requestContext);

            }
        }

#if BCL
        /// <summary>
        /// Determines the content for request body and uses the HTTP request
        /// to write the content to the HTTP request body.
        /// </summary>
        /// <param name="requestContent">Content to be written.</param>
        /// <param name="httpRequest">The HTTP request.</param>
        /// <param name="requestContext">The request context.</param>
        private async System.Threading.Tasks.Task WriteContentToRequestBodyAsync(TRequestContent requestContent,
            IHttpRequest<TRequestContent> httpRequest,
            IRequestContext requestContext)
        {
            IRequest wrappedRequest = requestContext.Request;

            // This code path ends up using a ByteArrayContent for System.Net.HttpClient used by .NET Core.
            // HttpClient can't seem to handle ByteArrayContent with 0 length so in that case use
            // the StreamContent code path.
            if (wrappedRequest.Content != null && wrappedRequest.Content.Length > 0)
            {
                byte[] requestData = wrappedRequest.Content;
                requestContext.Metrics.AddProperty(Metric.RequestSize, requestData.Length);
                await httpRequest.WriteToRequestBodyAsync(requestContent, requestData, requestContext.Request.Headers, requestContext.CancellationToken).ConfigureAwait(false);
            }
            else
            {
                System.IO.Stream originalStream;
                if (wrappedRequest.ContentStream == null)
                {
                    originalStream = new System.IO.MemoryStream();
                    await originalStream.WriteAsync(wrappedRequest.Content, 0, wrappedRequest.Content.Length, requestContext.CancellationToken).ConfigureAwait(false);
                    originalStream.Position = 0;
                }
                else
                {
                    originalStream = wrappedRequest.ContentStream;
                }

                var callback = ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)wrappedRequest.OriginalRequest).StreamUploadProgressCallback;
                if (callback != null)
                    originalStream = httpRequest.SetupProgressListeners(originalStream, requestContext.ClientConfig.ProgressUpdateInterval, this.CallbackSender, callback);
                var inputStream = GetInputStream(requestContext, originalStream, wrappedRequest);
                await httpRequest.WriteToRequestBodyAsync(requestContent, inputStream,
                    requestContext.Request.Headers, requestContext).ConfigureAwait(false);

            }
        }
#endif

        /// <summary>
        /// Creates the HttpWebRequest and configures the end point, content, user agent and proxy settings.
        /// </summary>
        /// <param name="requestContext">The async request.</param>
        /// <returns>The web request that actually makes the call.</returns>
        protected virtual IHttpRequest<TRequestContent> CreateWebRequest(IRequestContext requestContext)
        {
            IRequest request = requestContext.Request;
            Uri url = AmazonServiceClient.ComposeUrl(request);
            var httpRequest = _requestFactory.CreateHttpRequest(url);
            httpRequest.ConfigureRequest(requestContext);

            httpRequest.Method = request.HttpMethod;
            if (request.MayContainRequestBody())
            {
                var content = request.Content;
                if (request.SetContentFromParameters || (content == null && request.ContentStream == null))
                {
                    // Mapping parameters to query string or body are mutually exclusive.
                    if (!request.UseQueryString)
                    {
                        string queryString = AWSSDKUtils.GetParametersAsString(request);
                        content = Encoding.UTF8.GetBytes(queryString);
                        request.Content = content;
                        request.SetContentFromParameters = true;
                    }
                    else
                    {
                        request.Content = ArrayEx.Empty<byte>();
                    }
                }

                if (content != null)
                {
                    request.Headers[HeaderKeys.ContentLengthHeader] =
                        content.Length.ToString(CultureInfo.InvariantCulture);
                }
                else if (request.ContentStream != null && request.ContentStream.CanSeek && !request.Headers.ContainsKey(HeaderKeys.ContentLengthHeader))
                {
                    request.Headers[HeaderKeys.ContentLengthHeader] =
                        request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
                }
            }

            return httpRequest;
        }

        /// <summary>
        /// Disposes the HTTP handler.
        /// </summary>
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
                if (_requestFactory != null)
                    _requestFactory.Dispose();

                _disposed = true;
            }
        }

        private static System.IO.Stream GetInputStream(IRequestContext requestContext, System.IO.Stream originalStream, IRequest wrappedRequest)
        {
            var requestHasConfigForChunkStream = wrappedRequest.UseChunkEncoding && (wrappedRequest.AWS4SignerResult != null || wrappedRequest.AWS4aSignerResult != null);
            var hasTransferEncodingHeader = wrappedRequest.Headers.ContainsKey(HeaderKeys.TransferEncodingHeader);
            var isTransferEncodingHeaderChunked = hasTransferEncodingHeader && wrappedRequest.Headers[HeaderKeys.TransferEncodingHeader] == "chunked";
            var hasTrailingHeaders = wrappedRequest.TrailingHeaders?.Count > 0;

            // The goal of this logic is to wrap the request's ContentStream with:
            //   ChunkedUploadWrapperStream - if using chunked signing (with or without trailing checksums)
            //   TrailingHeadersWrapperStream - if using trailing checksums (without chunked signing)
            // Otherwise return the request's current stream (which could be our compression wrapper stream, or else the original stream that the user set on the request)
            //
            // The indication to use chunked signing from earlier in the SDK is if we have SigV4 or SigV4a signingResult,
            // which contains the header signature that is the input to the first chunk signature.
            if (requestHasConfigForChunkStream || isTransferEncodingHeaderChunked)
            {
                AWSSigningResultBase signingResult;
                if (wrappedRequest.AWS4aSignerResult != null)
                {
                    signingResult = wrappedRequest.AWS4aSignerResult;
                }
                else
                {
                    signingResult = wrappedRequest.AWS4SignerResult;
                }
                if (signingResult != null)
                {
                    if (hasTrailingHeaders)
                    {
                        return new ChunkedUploadWrapperStream(originalStream,
                                                     requestContext.ClientConfig.BufferSize,
                                                     signingResult,
                                                     wrappedRequest.SelectedChecksum,
                                                     wrappedRequest.TrailingHeaders);
                    }
                    else // no trailing headers
                    {
                        return new ChunkedUploadWrapperStream(originalStream,
                                                     requestContext.ClientConfig.BufferSize,
                                                     signingResult);
                    }
                }
            }
            if (hasTrailingHeaders) // and is unsigned/unchunked
            {
                if (wrappedRequest.SelectedChecksum != CoreChecksumAlgorithm.NONE)
                {
                    return new TrailingHeadersWrapperStream(originalStream, wrappedRequest.TrailingHeaders, wrappedRequest.SelectedChecksum);
                }
                else
                {
                    return new TrailingHeadersWrapperStream(originalStream, wrappedRequest.TrailingHeaders);
                }
            }
            return originalStream;
        }
    }
}
