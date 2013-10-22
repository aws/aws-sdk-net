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
using Amazon.Util;

namespace Amazon.Runtime
{
    public class AbstractWebServiceClient : IDisposable
    {
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
        protected AWSCredentials credentials;
        internal AuthenticationTypes authenticationType;

        protected bool disposed;
        internal Logger logger;

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
        ~AbstractWebServiceClient()
        {
            this.Dispose(false);
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs before a request is marshalled.
        /// </summary>
        internal event PreRequestEventHandler BeforeMarshallingEvent;

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

        #region Constructors
        internal AbstractWebServiceClient(AWSCredentials credentials, ClientConfig config, AuthenticationTypes authenticationType)
        {
            if (config.DisableLogging)
                this.logger = Logger.EmptyLogger;
            else
                this.logger = Logger.GetLogger(this.GetType());

            config.Validate();
            this.config = config;
            this.authenticationType = authenticationType;
            this.credentials = credentials;

            Initialize();
        }

        internal AbstractWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config, AuthenticationTypes authenticationType)
            : this((AWSCredentials)new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey),
                config, authenticationType)
        {
        }

        internal AbstractWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config, AuthenticationTypes authenticationType)
            : this(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, authenticationType)
        {
        }

        internal AbstractWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, AuthenticationTypes.User)
        {
        }

        internal AbstractWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
            : this(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config, AuthenticationTypes.User)
        {
        }

        protected virtual void Initialize()
        {
        }
        #endregion

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

        protected void SignRequest(IRequestData requestData)
        {
            // credentials would be null in the case of anonymous users getting public resources from S3
            if (credentials == null || credentials is AnonymousAWSCredentials)
                return;

            using (requestData.Metrics.StartEvent(RequestMetrics.Metric.RequestSigningTime))
            {
                requestData.Metrics.StartEvent(RequestMetrics.Metric.CredentialsRequestTime);
                ImmutableCredentials immutableCredentials = credentials.GetCredentials();
                // credentials would be null in the case of anonymous users getting public resources from S3
                if (immutableCredentials == null)
                    return;
                requestData.Metrics.StopEvent(RequestMetrics.Metric.CredentialsRequestTime);
                if (immutableCredentials.UseToken)
                {
                    ClientProtocol protocol = requestData.Signer.Protocol;
                    switch (protocol)
                    {
                        case ClientProtocol.QueryStringProtocol:
                            requestData.Request.Parameters["SecurityToken"] = immutableCredentials.Token;
                            break;
                        case ClientProtocol.RestProtocol:
                            requestData.Request.Headers["x-amz-security-token"] = immutableCredentials.Token;
                            break;
                        default:
                            throw new InvalidDataException("Cannot determine protocol");
                    }
                }
                requestData.Signer.Sign(requestData.Request, this.config, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
            }
        }

        protected void ConfigureRequest(IRequestData requestData)
        {
            requestData.Request.Headers["User-Agent"] = this.config.UserAgent; // +" " + (asyncResult.CompletedSynchronously ? "ClientSync" : "ClientAsync");

            var method = requestData.Request.HttpMethod.ToUpper();
            if (method != "GET" && method != "DELETE" && method != "HEAD")
            {
                if (!requestData.Request.Headers.ContainsKey(AWSSDKUtils.ContentTypeHeader))
                {
                    if (requestData.Request.UseQueryString)
                        requestData.Request.Headers[AWSSDKUtils.ContentTypeHeader] = "application/x-amz-json-1.0";
                    else
                        requestData.Request.Headers[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
                }
            }

            ProcessRequestHandlers(requestData.Request);
        }

        protected byte[] GetRequestData(IRequest request)
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

        protected static Uri ComposeUrl(IRequest iRequest, Uri endpoint)
        {
            Uri url = endpoint;
            if (!string.IsNullOrEmpty(iRequest.ResourcePath))
            {
                string resourcePath = iRequest.ResourcePath;
                if (resourcePath.StartsWith("//"))
                    resourcePath = resourcePath.Substring(2);
                else if (resourcePath.StartsWith("/"))
                    resourcePath = resourcePath.Substring(1);

                if (resourcePath.Contains("?"))
                {
                    string[] tokens = resourcePath.Split('?');
                    var newPath = AWSSDKUtils.UrlEncode(tokens[0], true) + "?" + tokens[1];
                    url = new Uri(url, newPath);
                }
                else
                    url = new Uri(url, AWSSDKUtils.UrlEncode(resourcePath, true));
            }

            if (iRequest.UseQueryString && iRequest.Parameters.Count > 0)
            {
                string queryString = AWSSDKUtils.GetParametersAsString(iRequest.Parameters);
                if (!string.IsNullOrEmpty(queryString))
                {
                    if (url.AbsoluteUri.Contains("?"))
                        url = new Uri(string.Format("{0}&{1}", url.AbsoluteUri, queryString));
                    else
                        url = new Uri(string.Format("{0}?{1}", url.AbsoluteUri, queryString));
                }
                else
                    url = new Uri(url.AbsoluteUri);
            }

            return url;
        }

        #region Process Handlers

        protected virtual void ProcessPreRequestHandlers(AmazonWebServiceRequest request)
        {
            if (request == null)
                return;
            if (BeforeMarshallingEvent == null)
                return;

            PreRequestEventArgs args = PreRequestEventArgs.Create(request);
            BeforeMarshallingEvent(this, args);
        }

        protected virtual void ProcessRequestHandlers(IRequest request)
        {
            if (request == null)
                return;

            WebServiceRequestEventArgs args = WebServiceRequestEventArgs.Create(request);

            if (request.OriginalRequest != null)
                request.OriginalRequest.FireBeforeRequestEvent(this, args);

            if (BeforeRequestEvent != null)
                BeforeRequestEvent(this, args);
        }

        protected virtual void ProcessResponseHandlers(AmazonWebServiceResponse response, IRequest request, IWebResponseData webResponseData)
        {
            if (request == null || request == null || webResponseData == null)
                return;
            if (AfterResponseEvent == null)
                return;

            WebServiceResponseEventArgs args = WebServiceResponseEventArgs.Create(response, request, webResponseData);
            AfterResponseEvent(this, args);
        }

        protected virtual void ProcessExceptionHandlers(Exception exception, IRequest request)
        {
            if (request == null)
                return;
            if (ExceptionEvent == null)
                return;

            WebServiceExceptionEventArgs args = WebServiceExceptionEventArgs.Create(exception, request);
            ExceptionEvent(this, args);
        }
        #endregion

        #region Logging Methods
        protected void LogFinalMetrics(AsyncResult asyncResult)
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

        protected void LogResponse(RequestMetrics metrics, IRequest request, HttpStatusCode statusCode)
        {
            metrics.AddProperty(RequestMetrics.Metric.StatusCode, statusCode);
        }

        protected void LogFinishedResponse(RequestMetrics metrics, UnmarshallerContext context, long contentLength)
        {
            metrics.AddProperty(RequestMetrics.Metric.BytesProcessed, contentLength);
            if (config.LogResponse || AWSConfigs.ResponseLogging == ResponseLoggingOption.Always)
            {
                this.logger.DebugFormat("Received response: [{0}]", context.ResponseBody);
            }
        }
        #endregion

        #region Error Handling Utility Methods
        protected void pauseExponentially(IRequestData requestData)
        {
            using (requestData.Metrics.StartEvent(RequestMetrics.Metric.RetryPauseTime))
            {
                pauseExponentially(requestData.RetriesAttempt);
            }
        }

        protected static bool isTemporaryRedirect(HttpStatusCode statusCode, string redirectedLocation)
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

#if !WIN_RT
            if (errorResponseException.InnerException is WebException &&
                (((WebException)(errorResponseException.InnerException)).Status == WebExceptionStatus.KeepAliveFailure))
            {
                return true;
            }
#endif

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
        /// Returns true if the request is in a state where it can be retried.
        /// False otherwise.
        /// </summary>
        /// <param name="irequest"></param>
        /// <returns></returns>
        protected static bool CanRetry(IRequestData irequest)
        {
            var request = irequest.Request;
            var stream = request.ContentStream;
            // Retries may not be possible with a stream
            if (stream != null)
            {
                // Pull out the underlying non-wrapper stream
                stream = WrapperStream.GetNonWrapperBaseStream(stream);

                // Retry is possible if stream is seekable
                return stream.CanSeek;
            }
            return true;
        }

        protected static void HandleRetry(IRequestData state)
        {
            state.Metrics.SetCounter(RequestMetrics.Metric.AttemptCount, state.RetriesAttempt);
            if (state.RetriesAttempt > 0 && state.Request.ContentStream != null && state.Request.OriginalStreamPosition >= 0)
            {
                var stream = state.Request.ContentStream;

                // If the stream is wrapped in a HashStream, reset the HashStream
                var hashStream = stream as HashStream;
                if (hashStream != null)
                {
                    hashStream.Reset();
                    stream = hashStream.GetNonWrapperBaseStream();
                }
                stream.Position = state.Request.OriginalStreamPosition;
            }
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
            AWSSDKUtils.Sleep(delay);
        }

        #endregion
    }
}
