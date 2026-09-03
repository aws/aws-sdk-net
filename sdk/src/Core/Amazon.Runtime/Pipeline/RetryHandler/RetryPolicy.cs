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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Authentication;
using System.Threading;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using AWSSDK.Runtime.Internal.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// A retry policy specifies all aspects of retry behavior. This includes conditions when the request should be retried,
    /// checks of retry limit, preparing the request before retry and introducing delay (backoff) before retries.
    /// </summary>
    public abstract partial class RetryPolicy
    {
        /// <summary>
        /// Temporary feature flag for updated retry behavior improvements including
        /// revised backoff timing, updated retry quota costs, and other enhancements.
        /// Enabled by setting the AWS_NEW_RETRIES_2026 environment variable to "true".
        /// Defaults to false. This flag will be removed at end of 2026 when the new
        /// behavior becomes the default.
        /// </summary>
        internal static bool UseNewRetries2026 { get; set; } =
            string.Equals(Environment.GetEnvironmentVariable("AWS_NEW_RETRIES_2026"), "true", StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Maximum number of retries to be performed.
        /// This does not count the initial request.
        /// </summary>
        public int MaxRetries { get; protected set; }
                
        /// <summary>
        /// The logger used to log messages.
        /// </summary>
        public ILogger Logger { get; set; }

        /// <summary>
        /// The standard set of throttling error codes
        /// </summary>
        public virtual ICollection<string> ThrottlingErrorCodes { get; protected set; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Throttling",
            "ThrottlingException",
            "ThrottledException",
            "RequestThrottledException",
            "TooManyRequestsException",
            "ProvisionedThroughputExceededException",
            "TransactionInProgressException",
            "RequestLimitExceeded",
            "BandwidthLimitExceeded",
            "LimitExceededException",
            "RequestThrottled",
            "SlowDown",
            "PriorRequestNotComplete"
        };

        /// <summary>
        /// The standard set of timeout error codes to retry on.
        /// </summary>
        public ICollection<string> TimeoutErrorCodesToRetryOn { get; protected set; } = new HashSet<string>()
        {
            "RequestTimeout",
            "RequestTimeoutException"
        };

        /// <summary>
        /// List of AWS specific error codes which are returned as part of the error response.
        /// These error codes will be retried.
        /// </summary>
        public ICollection<string> ErrorCodesToRetryOn { get; protected set; } = new HashSet<string>();

        #region Transient errors

        /// <summary>
        /// The standard set of transient error, HTTP status codes to retry on.
        /// 502 and 504 are returned by proxies. These can also be returned for 
        /// S3 accelerate requests which are served by CloudFront.
        /// </summary>
        public ICollection<HttpStatusCode> HttpStatusCodesToRetryOn { get; protected set; } = new HashSet<HttpStatusCode>
        {
            HttpStatusCode.InternalServerError,
            HttpStatusCode.ServiceUnavailable,
            HttpStatusCode.BadGateway,
            HttpStatusCode.GatewayTimeout
        };

        /// <summary>
        /// Set of web exception status codes to retry on.
        /// </summary>
        public ICollection<WebExceptionStatus> WebExceptionStatusesToRetryOn { get; protected set; } = new HashSet<WebExceptionStatus>
        {
            WebExceptionStatus.ConnectFailure,
            WebExceptionStatus.ConnectionClosed,
            WebExceptionStatus.KeepAliveFailure,
            WebExceptionStatus.NameResolutionFailure,
            WebExceptionStatus.ReceiveFailure,
            WebExceptionStatus.SendFailure,
            WebExceptionStatus.Timeout,
        };

        #endregion

        /// <summary>
        /// This parameter serves as the value to the CapacityManager.Container datastructure.
        /// Its properties include the available capacity left for making a retry request and the maximum
        /// capacity size.
        /// </summary>
        protected RetryCapacity RetryCapacity { get; set; }

        /// <summary>
        /// Checks if a retry should be performed with the given execution context and exception.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">The exception thrown after issuing the request.</param>
        /// <returns>Returns true if the request should be retried, else false. The exception is retried if it matches with clockskew error codes.</returns>
        public bool Retry(IExecutionContext executionContext, Exception exception)
        {
            // Boolean that denotes retries have not exceeded maxretries and request is rewindable
            bool canRetry = !RetryLimitReached(executionContext) && CanRetry(executionContext);
            // If canRetry is false, we still want to evaluate the exception if its retryable or not,
            // is CSM is enabled. This is necessary to set the IsLastExceptionRetryable property on 
            // CSM Call Attempt. For S3, with the BucketRegion mismatch exception, an overhead of 100-
            // 115 ms was added(because of GetPreSignedUrl and Http HEAD requests).
            if (canRetry || executionContext.RequestContext.CSMEnabled)
            {
                var isClockSkewError = IsClockskew(executionContext, exception);
                if (isClockSkewError || RetryForException(executionContext, exception))
                {
                    executionContext.RequestContext.IsLastExceptionRetryable = true;
                    // If CSM is enabled but canRetry was false, we should not retry the request.
                    // Return false after successfully evaluating the last exception for retryable.
                    if (!canRetry)
                    {
                        return false;
                    }

                    if (UseNewRetries2026)
                    {
                        executionContext.RequestContext.LastCapacityType = IsThrottlingError(exception) ?
                            CapacityManager.CapacityType.Throttling : CapacityManager.CapacityType.Retry;
                        StoreRetryAfterHeader(executionContext, exception);
                    }
                    else
                    {
                        executionContext.RequestContext.LastCapacityType = IsServiceTimeoutError(exception) ?
                            CapacityManager.CapacityType.Timeout : CapacityManager.CapacityType.Retry;
                    }
                    // Clock Skew Correction specification: skew retries consume retry quota
                    // (RETRY_COST) and count toward MAX_ATTEMPTS. There is never a reason to set
                    // bypassAcquireCapacity. 
                    return OnRetry(executionContext, false, IsThrottlingError(exception));
                }
            }
            return false;
        }

        /// <summary>
        /// Returns true if the request is in a state where it can be retried, else false.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>Returns true if the request is in a state where it can be retried, else false.</returns>
        public abstract bool CanRetry(IExecutionContext executionContext);

        /// <summary>
        /// Return true if the request should be retried for the given exception.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public abstract bool RetryForException(IExecutionContext executionContext, Exception exception);

        /// <summary>
        /// Checks if the retry limit is reached.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>Return false if the request can be retried, based on number of retries.</returns>
        public abstract bool RetryLimitReached(IExecutionContext executionContext);

        /// <summary>
        /// Waits before retrying a request.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public abstract void WaitBeforeRetry(IExecutionContext executionContext);

        /// <summary>
        /// Virtual method that gets called on a successful request response.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public virtual void NotifySuccess(IExecutionContext executionContext)
        {    
        }

        /// <summary>
        /// Virtual method that gets called when a request results in an error.
        /// This is called for every error, regardless of whether the request will be retried.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">The exception from the failed request.</param>
        public virtual void NotifyError(IExecutionContext executionContext, Exception exception)
        {
        }
        
        /// <summary>
         /// Virtual method that gets called before a retry request is initiated. The value 
         /// returned is True by default(retry throttling feature is disabled).
         /// </summary>
         /// <param name="executionContext">The execution context which contains both the
         /// requests and response context.</param>
         public virtual bool OnRetry(IExecutionContext executionContext)
         {
             return true;
         }
         
        /// <summary>
        /// Virtual method that gets called before a retry request is initiated. The value 
        /// returned is True by default(retry throttling feature is disabled).
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="bypassAcquireCapacity">true to bypass any attempt to acquire capacity on a retry</param>
        public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
        {
            return true;
        }

        /// <summary>
        /// Virtual method that gets called before a retry request is initiated. The value 
        /// returned is True by default(retry throttling feature is disabled).
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="bypassAcquireCapacity">true to bypass any attempt to acquire capacity on a retry</param>
        /// <param name="isThrottlingError">true if the error that will be retried is a throttling error</param>
        public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
        {
            return OnRetry(executionContext, bypassAcquireCapacity);
        }


        /// <summary>
        /// This method uses a token bucket to enforce the maximum sending rate.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">If the prior request failed, this exception is expected to be 
        /// the exception that occurred during the prior request failure.</param>
        public virtual void ObtainSendToken(IExecutionContext executionContext, Exception exception)
        {
        }

        /// <summary>
        /// Determines if an AmazonServiceException is a throttling error
        /// </summary>
        /// <param name="exception">The current exception to check.</param>
        /// <returns>true if it is a throttling error else false.</returns>
        public virtual bool IsThrottlingError(Exception exception)
        {
            var serviceException = exception as AmazonServiceException;

            return serviceException?.Retryable?.Throttling == true ||
                ThrottlingErrorCodes.Contains(serviceException?.ErrorCode);
        }

        /// <summary>
        /// Determines if an exception indicates a stale pooled connection.
        /// These errors occur when an HTTP connection from the pool has been 
        /// closed by the server but the client hasn't detected this yet.
        /// </summary>
        /// <param name="exception">The exception to check.</param>
        /// <returns>true if the exception indicates a stale connection error, else false.</returns>
        public virtual bool IsStaleConnectionError(Exception exception)
        {
            // Walk the exception chain looking for SocketException with known stale connection error codes
            var currentException = exception;
            while (currentException != null)
            {
                if (currentException is System.Net.Sockets.SocketException socketException)
                {
                    // SocketError.Shutdown (32) = Broken pipe on Unix/Linux
                    // SocketError.ConnectionReset (10054) = Connection reset by peer
                    // SocketError.ConnectionAborted (10053) = Connection aborted
                    if (socketException.SocketErrorCode == System.Net.Sockets.SocketError.Shutdown ||
                        socketException.SocketErrorCode == System.Net.Sockets.SocketError.ConnectionReset ||
                        socketException.SocketErrorCode == System.Net.Sockets.SocketError.ConnectionAborted)
                    {
                        return true;
                    }
                }

#if NETSTANDARD
                // .NET 8+ fallback: HttpClient may throw HttpIOException when the response
                // ends prematurely due to stale connections. HttpIOException is .NET 8+ - we check by
                // type name to avoid compilation issues on older targets that support NetStandard.
                if (currentException.GetType().Name == "HttpIOException")
                {
                    var message = currentException.Message;
                    if (message != null && message.Contains("The response ended prematurely"))
                    {
                        return true;
                    }
                }
#else
                // .NET Framework fallback: HttpWebRequest wraps stale connection errors as IOException
                // without exposing the underlying SocketException. Check for known message patterns.
                if (currentException is IOException ioException)
                {
                    var message = ioException.Message;
                    if (message != null && message.Contains("The connection was closed"))
                    {
                        return true;
                    }
                }
#endif

                currentException = currentException.InnerException;
            }

            return false;
        }

        /// <summary>
        /// Determines if an AmazonServiceException is a transient error that
        /// should be retried.
        /// </summary>
        /// <param name="executionContext">The current execution context</param>
        /// <param name="exception">The current exception to check.</param>
        /// <returns>true if the exception is a transient error else false.</returns>
        public virtual bool IsTransientError(IExecutionContext executionContext, Exception exception)
        {
            // An IOException was thrown by the underlying http client.
            // FileNotFoundException is not considered a transient error because
            // we don't consider local .NET assembly file changes to be happening.
            // If a FileNotFoundException happens there is most likey a bad install
            // of the SDK or .NET assembly binding issue.
            if (exception is IOException && exception is not FileNotFoundException)
            {

#if !NETSTANDARD  // ThreadAbortException is not NetStandard

                // Don't retry IOExceptions that are caused by a ThreadAbortException
                if (ExceptionUtils.IsInnerException<ThreadAbortException>(exception))
                    return false;

#endif
                // Retry all other IOExceptions
                return true;
            }
            else if (ExceptionUtils.IsInnerException<IOException>(exception))
            {
                return true;
            }            

            //Check for AmazonServiceExceptions specifically
            var serviceException = exception as AmazonServiceException;
            if(serviceException != null)
            {
                //Check if the exception is marked retryable.
                if (serviceException.Retryable != null)
                {
                    return true;
                }

                //Check for specific HTTP status codes that are associated with transient
                //service errors as long as they are not throttling errors.
                if (HttpStatusCodesToRetryOn.Contains(serviceException.StatusCode) &&
                    !IsThrottlingError(exception))
                {
                    return true;
                }

                //Check for successful responses that couldn't be unmarshalled. These should be considered
                //transient errors because the payload could have been corrupted after OK was sent in the
                //header.
                if(serviceException.StatusCode == HttpStatusCode.OK && serviceException is AmazonUnmarshallingException)
                {
                    return true;
                }
            }

            //Check for WebExceptions that are considered transient
            WebException webException;
            if (ExceptionUtils.IsInnerException(exception, out webException))
            {
                if (WebExceptionStatusesToRetryOn.Contains(webException.Status))
                {
                    return true;
                }
            }

            if (IsTransientSslError(exception))
            {
                return true;
            }

#if NETSTANDARD
            // Version 7.35 libcurl which is the default version installed with Ubuntu 14.04 
            // has issues under high concurrency causing response streams being disposed
            // during unmarshalling. To work around this issue will add the ObjectDisposedException
            // to the list of exceptions to retry.
            if (ExceptionUtils.IsInnerException<ObjectDisposedException>(exception))
                return true;

            //If it isn't a serviceException that we already processed for StatusCode and it
            //is a HttpRequestException, then it is a network type error that did not reach the
            //service and it should be retried.            
            if (serviceException == null && exception is System.Net.Http.HttpRequestException)
            {
                return true;
            }

            if (exception is OperationCanceledException)
            {
                if (!executionContext.RequestContext.CancellationToken.IsCancellationRequested)
                {
                    //OperationCanceledException thrown by HttpClient not the CancellationToken supplied by the user.
                    //This exception can wrap at least IOExceptions, ObjectDisposedExceptions and should be retried
                    return true;
                }
            }

            // .NET 5 introduced changes to HttpClient for timed out requests by returning a wrapped TimeoutException.
            if (exception is TimeoutException)
                return true;
#endif
            return false;
        }

        private const string sslErrorZeroReturn = "SSL_ERROR_ZERO_RETURN";
        public static bool IsTransientSslError(Exception exception)
        {
            var isAuthenticationException = false;
            // Scan down the exceptions chain for a sslErrorZeroReturn keyword in the Message,
            // given that the one of the parent exceptions is AuthenticationException.
            // Based on https://github.com/aws/aws-sdk-net/issues/1556
            while (exception != null)
            {
                if (exception is AuthenticationException)
                {
                    isAuthenticationException = true;
                }
                if (isAuthenticationException && exception.Message.Contains(sslErrorZeroReturn))
                {
                    return true;
                }
                exception = exception.InnerException;
            }
            return false;
        }

        /// <summary>
        /// Determines if the exception is a known timeout error code that
        /// should be retried under the timeout error category.
        /// </summary>
        /// <param name="exception">The current exception to check.</param>
        /// <returns>true if the exception is considered a timeout else false</returns>
        public virtual bool IsServiceTimeoutError(Exception exception)
        {
            var serviceException = exception as AmazonServiceException;
            return TimeoutErrorCodesToRetryOn.Contains(serviceException?.ErrorCode);
        }


        #region Clock skew correction

        private const string clockSkewUpdatedFormat = "Setting clock skew correction: new clock skew correction = {0}, service endpoint = {1}.";

        /// <summary>
        /// Canonical set of clock skew error codes. Each is retried only when the computed
        /// skew exceeds the 4-minute detection threshold. RequestExpired / RequestInTheFuture
        /// are retained for backward compatibility.
        /// </summary>
        private static HashSet<string> clockSkewErrorCodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "InvalidSignatureException",
            "SignatureDoesNotMatch",
            "AuthFailure",
            "RequestTimeTooSkewed",
            "AccessDeniedException",
            // Retained for backward compatibility (not in the specification list):
            "RequestExpired",
            "RequestInTheFuture",
        };

        private bool IsClockskew(IExecutionContext executionContext, Exception exception)
        {
            // Recording of ClientSkew happens unconditionally in the HttpHandler; here we only
            // decide whether to retry this error as a clock skew error: the error code must be a
            // known clock skew code (or a HEAD request with no code) AND the skew computed from
            // this response must exceed the 4-minute detection threshold. On a positive decision
            // the request is marked unsigned so the retry re-signs with the corrected timestamp.
            if (!ClockSkewPipelineHelper.IsCorrectionEnabled(executionContext.RequestContext.ClientConfig))
                return false;

            var ase = exception as AmazonServiceException;
            if (ase == null)
                return false;

            var isHead =
                executionContext.RequestContext.Request != null &&
                string.Equals(executionContext.RequestContext.Request.HttpMethod, "HEAD", StringComparison.Ordinal);

            // ase.ErrorCode == null on a HEAD request models the S3 generic-403 case with
            // no error code; otherwise the code must be in the canonical set.
            bool isSkewErrorCode =
                (ase.ErrorCode == null && isHead) ||
                (ase.ErrorCode != null && clockSkewErrorCodes.Contains(ase.ErrorCode));
            if (!isSkewErrorCode)
                return false;

            // Retry only when the measured skew is large enough to plausibly be the cause.
            if (!ClockSkewPipelineHelper.AttemptSkewExceedsThreshold(executionContext))
                return false;

            Logger.InfoFormat(clockSkewUpdatedFormat,
                CorrectClockSkew.GetClockCorrectionForEndpoint(executionContext.RequestContext.Request.Endpoint.ToString()),
                executionContext.RequestContext.Request.Endpoint.ToString());
            executionContext.RequestContext.IsSigned = false;
            return true;
        }

        #endregion

        /// <summary>
        /// Context attribute key for storing the x-amz-retry-after header value (in milliseconds).
        /// </summary>
        protected const string RetryAfterContextKey = "RetryAfterMs";

        /// <summary>
        /// Extracts the x-amz-retry-after header from the error response and stores it in ContextAttributes.
        /// The header value is an integer representing milliseconds.
        /// </summary>
        private void StoreRetryAfterHeader(IExecutionContext executionContext, Exception exception)
        {
            // Remove any previously stored value
            executionContext.RequestContext.ContextAttributes.Remove(RetryAfterContextKey);

            var serviceException = exception as AmazonServiceException;
            var webData = GetWebData(serviceException);
            if (webData == null)
                return;

            var retryAfterValue = webData.GetHeaderValue("x-amz-retry-after");
            if (string.IsNullOrEmpty(retryAfterValue))
                return;

            if (int.TryParse(retryAfterValue, out var retryAfterMs) && retryAfterMs >= 0)
            {
                executionContext.RequestContext.ContextAttributes[RetryAfterContextKey] = retryAfterMs;
            }
            else
            {
                Logger?.DebugFormat("Invalid x-amz-retry-after header value '{0}', falling back to exponential backoff.", retryAfterValue);
            }
        }

        private static IWebResponseData GetWebData(AmazonServiceException ase)
        {
            if (ase != null)
            {
                Exception e = ase;
                do
                {
                    var here = e as HttpErrorResponseException;
                    if (here != null)
                        return here.Response;
                    e = e.InnerException;
                } while (e != null);
            }

            return null;
        }

        protected static bool ContainErrorMessage(Exception exception, HashSet<string> errorMessages)
        {
            if (exception == null)
                return false;

            if (errorMessages.Contains(exception.Message))
                return true;
            return ContainErrorMessage(exception.InnerException, errorMessages);
        }

        /// <summary>
        /// Creates a key for storing retry capacity data.
        /// Key is based on service's url (we store retry capacity per service's url variant).
        /// If ClientConfig's ServiceURL override is set we use it as a key,
        /// otherwise we construct key based on ClientConfig's schema, region, service, fips, dualstack parameters.
        /// This value is unique key per real service's url variant.
        /// </summary>
        protected static string GetRetryCapacityKey(IClientConfig config)
        {
            return config.ServiceURL != null ? config.ServiceURL :
                $"http:{config.UseHttp}//region:{config.RegionEndpoint?.SystemName}.service:{config.RegionEndpointServiceName}.fips:{config.UseFIPSEndpoint}.ipv6:{config.UseDualstackEndpoint}";
        }

    }
}
