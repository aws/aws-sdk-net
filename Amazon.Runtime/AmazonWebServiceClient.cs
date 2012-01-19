﻿/*
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

        internal AmazonWebServiceClient(AWSCredentials credentials, ClientConfig config, bool ownCredentials, AuthenticationTypes authenticationType)
        {
            this.logger = new Logger(this.GetType());
            this.config = config;
            this.credentials = credentials;
            this.ownCredentials = ownCredentials;
            this.authenticationType = authenticationType;
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

        /// <summary>
        /// Creates the HttpWebRequest and configures the end point, content, user agent and proxy settings.
        /// </summary>
        /// <param name="wrappedRequest">The internal wrapped request.</param>
        /// <param name="requestData">The data to be sent for the request.</param>
        /// <returns>The web request that actually makes the call.</returns>
        protected virtual HttpWebRequest ConfigureWebRequest<X>(IRequest<X> wrappedRequest, byte[] requestData)
        {
            HttpWebRequest request = WebRequest.Create(wrappedRequest.Endpoint) as HttpWebRequest;
            if (request != null)
            {
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

                request.Method = "POST";
                request.ContentLength = requestData.Length;

                AddHeaders(request, wrappedRequest.Headers);

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(requestData, 0, requestData.Length);
                }
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

        private void SignRequest<X>(IRequest<X> request, AbstractAWSSigner signer) where X : AmazonWebServiceRequest
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
                            request.Parameters.Add("SecurityToken", immutableCredentials.Token);
                            break;
                        case ClientProtocol.RestProtocol:
                            request.Headers.Add("x-amz-security-token", immutableCredentials.Token);
                            break;
                        default:
                            throw new InvalidDataException("Cannot determine protocol");
                    }
                }
                signer.Sign(request, this.config, immutableCredentials.AccessKey, immutableCredentials.ClearSecretKey, immutableCredentials.SecureSecretKey);
            }
        }


        /// <summary>
        /// This method makes the actual web request and marshalls the response body or error returned from the service.
        /// For some error response a retry will be attempted after an exponential pause.
        /// </summary>
        /// <typeparam name="X">The user facing request type.</typeparam>
        /// <typeparam name="Y">The user facing response type.</typeparam>
        /// <param name="request">The wrapper around the user facing request.</param>
        /// <param name="signer">The type of signer to use for the request.</param>
        /// <param name="unmarshaller">The object used to unmarshall the response body.</param>
        /// <returns>The response object for the request</returns>
        internal Y Invoke<X, Y>(IRequest<X> request, AbstractAWSSigner signer, IResponseUnmarshaller<Y, UnmarshallerContext> unmarshaller)
            where X : AmazonWebServiceRequest
            where Y : AmazonWebServiceResponse
        {
            Type requestType = typeof(X);
            string requestName = requestType.Name;

            request.Endpoint = new Uri(this.config.ServiceURL);
            request.Headers["User-Agent"] = this.config.UserAgent;
            if (!request.Headers.ContainsKey(AWSSDKUtils.ContentTypeHeader))
            {
                request.Headers[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
            }

            ProcessRequestHandlers(request);

            this.logger.DebugFormat("Starting request {0} at {1}", requestName, this.config.ServiceURL);
            SignRequest<X>(request, signer);

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

            int retries = 0;
            while (true)
            {
                retries++;

                try
                {
                    HttpWebRequest webRequest = this.ConfigureWebRequest<X>(request, requestData);
                    try
                    {
                        Y result;
                        DateTime requestSent = DateTime.UtcNow;
                        using (HttpWebResponse httpResponse = webRequest.GetResponse() as HttpWebResponse)
                        {
                            DateTime responseReceived = DateTime.UtcNow;
                            this.logger.InfoFormat("Received response for {0} with status code {1} in {2} ms.", requestName, httpResponse.StatusCode, (responseReceived - requestSent).TotalMilliseconds);

                            XmlTextReader reader;

                            // Using NOSTREAM is the less effcient way of dealing with the response body but it is helpful 
                            // for debug purposes to see the entire xml body coming back from the server.
#if NOSTREAM
                            string responseBody = new StreamReader(httpResponse.GetResponseStream()).ReadToEnd();
                            reader = new XmlTextReader(new StringReader(responseBody));
#else
                            reader = new XmlTextReader(new StreamReader(httpResponse.GetResponseStream()));
#endif
                            UnmarshallerContext context = new UnmarshallerContext(reader);
                            result = unmarshaller.Unmarshall(context);
                        }

                        return result;
                    }
                    catch (WebException we)
                    {
                        processWebException<X, Y>(requestName, we, webRequest, unmarshaller, request, retries);
                    }
                }
                catch (IOException e)
                {
                    if (this.isInnerExceptionThreadAbort(e))
                        throw;

                    this.logger.Error(string.Format("IOException making request {0} to {1}.", requestName, request.Endpoint.ToString()), e);
                    if (retries > this.config.MaxErrorRetry)
                        throw;
                    else
                        this.logger.Error(string.Format("IOException making request {0} to {1}. Attempting retry {2}.", requestName, request.Endpoint.ToString(), retries), e);
                }
                catch (Exception e)
                {
                    this.logger.Error(string.Format("Error configuring web request {0} to {1}.", requestName, request.Endpoint.ToString()), e);
                    throw;
                }
            }
        }

        /// <summary>
        /// This method makes the actual web request and marshalls the response body or error returned from the service.
        /// For some error response a retry will be attempted after an exponential pause.
        /// </summary>
        /// <typeparam name="X">The user facing request type.</typeparam>
        /// <typeparam name="Y">The user facing response type.</typeparam>
        /// <param name="request">The wrapper around the user facing request.</param>
        /// <param name="signer">The type of signer to use for the request.</param>
        /// <param name="unmarshaller">The object used to unmarshall the response body.</param>
        /// <returns>The response object for the request</returns>
        internal Y Invoke<X, Y>(IRequest<X> request, AbstractAWSSigner signer, IResponseUnmarshaller<Y, JsonUnmarshallerContext> unmarshaller)
            where X : AmazonWebServiceRequest
            where Y : AmazonWebServiceResponse
        {
            Type requestType = typeof(X);
            string requestName = requestType.Name;

            request.Endpoint = new Uri(this.config.ServiceURL);
            request.Headers["User-Agent"] = this.config.UserAgent;
            if (!request.Headers.ContainsKey(AWSSDKUtils.ContentTypeHeader))
            {
                request.Headers[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
            }

            ProcessRequestHandlers(request);

            this.logger.DebugFormat("Starting request {0} at {1}", requestName, this.config.ServiceURL);
            SignRequest<X>(request, signer);

            byte[] requestData;
            if (request.Content == null)
            {
                string queryString = AWSSDKUtils.GetParametersAsString(request.Parameters);
                requestData = Encoding.UTF8.GetBytes(queryString);
                //this.logger.DebugFormat("Request body's content [{0}] with size {1}", queryString, requestData.Length);
            }
            else
            {
                requestData = request.Content;
                //this.logger.DebugFormat("Request content size {0}", requestData.Length);
            }

            this.logger.DebugFormat("Request body's content size {0}", requestData.Length);

            int retries = 0;
            while (true)
            {
                retries++;

                try
                {
                    HttpWebRequest webRequest = this.ConfigureWebRequest<X>(request, requestData);
                    try
                    {
                        Y result;
                        DateTime requestSent = DateTime.UtcNow;
                        using (HttpWebResponse httpResponse = webRequest.GetResponse() as HttpWebResponse)
                        {
                            DateTime responseReceived = DateTime.UtcNow;
                            this.logger.InfoFormat("Received response for {0} with status code {1} in {2} ms.", requestName, httpResponse.StatusCode, (responseReceived - requestSent).TotalMilliseconds);

                            StreamReader reader;

                            // Using NOSTREAM is the less effcient way of dealing with the response body but it is helpful 
                            // for debug purposes to see the entire xml body coming back from the server.
#if NOSTREAM
                            string responseBody = new StreamReader(httpResponse.GetResponseStream()).ReadToEnd();
                            reader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(responseBody)));
#else
                            reader = new StreamReader(httpResponse.GetResponseStream());
#endif
                            JsonUnmarshallerContext context = new JsonUnmarshallerContext(reader);
                            result = unmarshaller.Unmarshall(context);
                            result.ResponseMetadata = new ResponseMetadata();
                            result.ResponseMetadata.RequestId = httpResponse.Headers[AWSSDKUtils.RequestIdHeader];
                        }

                        return result;
                    }
                    catch (WebException we)
                    {
                        processWebException<X, Y>(requestName, we, webRequest, unmarshaller, request, retries);
                    }
                }
                catch (IOException e)
                {
                    if (this.isInnerExceptionThreadAbort(e))
                        throw;

                    this.logger.Error(string.Format("IOException making request {0} to {1}.", requestName, request.Endpoint.ToString()), e);
                    if (retries > this.config.MaxErrorRetry)
                        throw;
                    else
                        this.logger.Error(string.Format("IOException making request {0} to {1}. Attempting retry {2}.", requestName, request.Endpoint.ToString(), retries), e);
                }
                catch (Exception e)
                {
                    this.logger.Error(string.Format("Error configuring web request {0} to {1}.", requestName, request.Endpoint.ToString()), e);
                    throw;
                }
            }
        }

        private void ProcessRequestHandlers<X>(IRequest<X> request) where X : AmazonWebServiceRequest
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

        private void processWebException<X, Y>(string requestName, WebException we, HttpWebRequest webRequest, IResponseUnmarshaller<Y, UnmarshallerContext> unmarshaller, IRequest<X> request, int retries)
        {
            HttpStatusCode statusCode;
            AmazonServiceException errorResponseException = null;
            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (httpErrorResponse == null)
                {
                    // Abort the unsuccessful request
                    webRequest.Abort();

                    // If it is a keep alive error then attempt a retry
                    if (we != null && retries <= config.MaxErrorRetry && we.Status == WebExceptionStatus.KeepAliveFailure)
                    {
                        pauseExponentially(retries);
                        return;
                    }
                    throw new AmazonServiceException(we);
                }
                statusCode = httpErrorResponse.StatusCode;

                XmlTextReader errorReader;
#if NOSTREAM
                string responseBody = new StreamReader(httpErrorResponse.GetResponseStream()).ReadToEnd(); ;
                errorReader = new XmlTextReader(new StringReader(responseBody));
#else
                errorReader = new XmlTextReader(new StreamReader(httpErrorResponse.GetResponseStream()));
#endif

                UnmarshallerContext errorContext = new UnmarshallerContext(errorReader);
                errorResponseException = unmarshaller.UnmarshallException(errorContext, we, statusCode);

                httpErrorResponse.Close();
                webRequest.Abort();

                if (isTemporaryRedirect(httpErrorResponse))
                {
                    string redirectedLocation = httpErrorResponse.Headers["location"];
                    this.logger.InfoFormat("Request {0} is being redirected to {1}.", requestName, redirectedLocation);
                    request.Endpoint = new Uri(redirectedLocation);
                    return;
                }
                else if (ShouldRetry(statusCode, this.config, errorResponseException, retries))
                {
                    this.logger.InfoFormat("Retry number {0} for request {1}.", retries, requestName);
                    pauseExponentially(retries);
                    return;
                }
            }

            if (errorResponseException != null)
            {
                this.logger.Error(string.Format("Error making request {0}.", requestName), errorResponseException);
                throw errorResponseException;
            }

            AmazonServiceException excep = new AmazonServiceException("Unable to make request", we, statusCode);
            this.logger.Error(string.Format("Error making request {0}.", requestName), excep);
            throw excep;
        }

        private void processWebException<X, Y>(string requestName, WebException we, HttpWebRequest webRequest, IResponseUnmarshaller<Y, JsonUnmarshallerContext> unmarshaller, IRequest<X> request, int retries)
        {
            HttpStatusCode statusCode;
            AmazonServiceException errorResponseException = null;
            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (httpErrorResponse == null)
                {
                    // Abort the unsuccessful request
                    webRequest.Abort();

                    // If it is a keep alive error then attempt a retry
                    if (we != null && retries <= config.MaxErrorRetry && we.Status == WebExceptionStatus.KeepAliveFailure)
                    {
                        pauseExponentially(retries);
                        return;
                    }
                    throw new AmazonServiceException(we);
                }
                statusCode = httpErrorResponse.StatusCode;

                StreamReader errorReader;
#if NOSTREAM
                string responseBody = new StreamReader(httpErrorResponse.GetResponseStream()).ReadToEnd();
                errorReader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(responseBody)));
#else
                errorReader = new StreamReader(httpErrorResponse.GetResponseStream());
#endif

                JsonUnmarshallerContext errorContext = new JsonUnmarshallerContext(errorReader);
                errorResponseException = unmarshaller.UnmarshallException(errorContext, we, statusCode);

                httpErrorResponse.Close();
                webRequest.Abort();

                if (isTemporaryRedirect(httpErrorResponse))
                {
                    string redirectedLocation = httpErrorResponse.Headers["location"];
                    this.logger.InfoFormat("Request {0} is being redirected to {1}.", requestName, redirectedLocation);
                    request.Endpoint = new Uri(redirectedLocation);
                    return;
                }
                else if (ShouldRetry(statusCode, this.config, errorResponseException, retries))
                {
                    this.logger.InfoFormat("Retry number {0} for request {1}.", retries, requestName);
                    pauseExponentially(retries);
                    return;
                }
            }

            if (errorResponseException != null)
            {
                this.logger.Error(string.Format("Error making request {0}.", requestName), errorResponseException);
                throw errorResponseException;
            }

            AmazonServiceException excep = new AmazonServiceException("Unable to make request", we, statusCode);
            this.logger.Error(string.Format("Error making request {0}.", requestName), excep);
            throw excep;
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
    }
}
