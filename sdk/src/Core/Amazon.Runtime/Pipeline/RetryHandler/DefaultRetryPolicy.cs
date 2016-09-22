/*
* Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// The default implementation of the retry policy.
    /// </summary>
    public partial class DefaultRetryPolicy : RetryPolicy
    {
        private int _maxBackoffInMilliseconds = (int)TimeSpan.FromSeconds(30).TotalMilliseconds;

        // Set of HTTP status codes to retry on.
        private ICollection<HttpStatusCode> _httpStatusCodesToRetryOn = new HashSet<HttpStatusCode>
        {
            HttpStatusCode.InternalServerError,
            HttpStatusCode.ServiceUnavailable,
            HttpStatusCode.BadGateway,
            HttpStatusCode.GatewayTimeout
        };

        // Set of web exception status codes to retry on.
        private ICollection<WebExceptionStatus> _webExceptionStatusesToRetryOn = new HashSet<WebExceptionStatus>
        {
            WebExceptionStatus.ConnectFailure,

#if !PCL // These statuses are not available on WinRT
            WebExceptionStatus.ConnectionClosed,
            WebExceptionStatus.KeepAliveFailure,
            WebExceptionStatus.NameResolutionFailure,
            WebExceptionStatus.ReceiveFailure,
#else // WinRT does not expose the status as public enums so we hard code the status numbers.
            (WebExceptionStatus)8,
            (WebExceptionStatus)12,
            (WebExceptionStatus)1,
            (WebExceptionStatus)3,
#endif
        };

        private static readonly HashSet<string> _coreCLRRetryErrorMessages = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "The server returned an invalid or unrecognized response",
            "The connection with the server was terminated abnormally"
        };

        // Set of AWS error codes to retry on.
        private ICollection<string> _errorCodesToRetryOn = new HashSet<string>
        {
            "Throttling",
            "ThrottlingException",
            "ProvisionedThroughputExceededException",
            "RequestTimeout"
        };

        /// <summary>
        /// The maximum value of exponential backoff in milliseconds, which will be used to wait
        /// before retrying a request.
        /// </summary>
        public int MaxBackoffInMilliseconds
        {
            get { return _maxBackoffInMilliseconds; }
            set { _maxBackoffInMilliseconds = value; }
        }

        /// <summary>
        /// List of HTTP Status codes codes which are returned as part of the error response.
        /// These status codes will be retried.
        /// </summary>
        public ICollection<HttpStatusCode> HttpStatusCodesToRetryOn
        {
            get { return _httpStatusCodesToRetryOn; }
        }

        /// <summary>
        /// List of AWS specific error codes which are returned as part of the error response.
        /// These error codes will be retried.
        /// </summary>
        public ICollection<string> ErrorCodesToRetryOn
        {
            get { return _errorCodesToRetryOn; }
        }

        /// <summary>
        /// List of WebExceptionStatus for a WebException which will be retried.
        /// </summary>
        public ICollection<WebExceptionStatus> WebExceptionStatusesToRetryOn
        {
            get { return _webExceptionStatusesToRetryOn; }
        }

        /// <summary>
        /// Constructor for DefaultRetryPolicy.
        /// </summary>
        /// <param name="maxRetries">The maximum number of retries before throwing
        /// back a exception. This does not count the initial request.</param>
        public DefaultRetryPolicy(int maxRetries)
        {
            this.MaxRetries = maxRetries;
        }

        /// <summary>
        /// Returns true if the request is in a state where it can be retried, else false.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <returns>Returns true if the request is in a state where it can be retried, else false.</returns>
        public override bool CanRetry(IExecutionContext executionContext)
        {
            return executionContext.RequestContext.Request.IsRequestStreamRewindable();
        }

        /// <summary>
        /// Return true if the request should be retried.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public override bool RetryForException(IExecutionContext executionContext, Exception exception)
        {
            return RetryForExceptionSync(exception);
        }

        /// <summary>
        /// Perform the processor-bound portion of the RetryForException logic.
        /// This is shared by the sync, async, and APM versions of the RetryForException method.
        /// </summary>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        private bool RetryForExceptionSync(Exception exception)
        {
            // An IOException was thrown by the underlying http client.
            if (exception is IOException)
            {

#if !PCL && !CORECLR  // ThreadAbortException is not PCL and CoreCLR

                // Don't retry IOExceptions that are caused by a ThreadAbortException
                if (IsInnerException<ThreadAbortException>(exception))
                    return false;

#endif
                // Retry all other IOExceptions
                return true;
            }

#if CORECLR
            // Version 7.35 libcurl which is the default version installed with Ubuntu 14.04 
            // has issues under high concurrency causing response streams being disposed
            // during unmarshalling. To work around this issue will add the ObjectDisposedException
            // to the list of exceptions to retry.
            if (IsInnerException<ObjectDisposedException>(exception))
                return true;

            if (exception is System.Net.Http.HttpRequestException)
            {
                if (ContainErrorMessage(exception))
                    return true;
            }
#endif

            // A AmazonServiceException was thrown by ErrorHandler
            var serviceException = exception as AmazonServiceException;
            if (serviceException != null)
            {

                // For 500 internal server errors and 503 service
                // unavailable errors, we want to retry, but we need to use
                // an exponential back-off strategy so that we don't overload
                // a server with a flood of retries. If we've surpassed our
                // retry limit we handle the error response as a non-retryable
                // error and go ahead and throw it back to the user as an exception.
                //
                // 502 and 504 are returned by proxies. These can also be returned for 
                // S3 accelerate requests which are served by CloudFront.
                if (this.HttpStatusCodesToRetryOn.Contains(serviceException.StatusCode))
                {
                    return true;
                }

                // Throttling is reported as a 400 or 503 error from services. To try and
                // smooth out an occasional throttling error, we'll pause and retry,
                // hoping that the pause is long enough for the request to get through
                // the next time.                
                if ((serviceException.StatusCode == HttpStatusCode.BadRequest ||
                    serviceException.StatusCode == HttpStatusCode.ServiceUnavailable))
                {
                    string errorCode = serviceException.ErrorCode;
                    if (this.ErrorCodesToRetryOn.Contains(errorCode))
                    {
                        return true;
                    }
                }

                WebException webException;
                if (IsInnerException<WebException>(exception, out webException))
                {
                    if (this.WebExceptionStatusesToRetryOn.Contains(webException.Status))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the retry limit is reached.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <returns>Return false if the request can be retried, based on number of retries.</returns>
        public override bool RetryLimitReached(IExecutionContext executionContext)
        {
            return executionContext.RequestContext.Retries >= this.MaxRetries;
        }

        /// <summary>
        /// Waits before retrying a request. The default policy implements a exponential backoff.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        public override void WaitBeforeRetry(IExecutionContext executionContext)
        {
            DefaultRetryPolicy.WaitBeforeRetry(executionContext.RequestContext.Retries, this.MaxBackoffInMilliseconds);
        }

        public static void WaitBeforeRetry(int retries, int maxBackoffInMilliseconds)
        {
            AWSSDKUtils.Sleep(CalculateRetryDelay(retries, maxBackoffInMilliseconds));
        }

        private static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
        {
            int delay = (int)(Math.Pow(4, retries) * 100);
            if (retries > 0 && (delay > maxBackoffInMilliseconds || delay <= 0))
                delay = maxBackoffInMilliseconds;
            return delay;
        }

        protected static bool ContainErrorMessage(Exception exception)
        {
            if (exception == null)
                return false;

            if (_coreCLRRetryErrorMessages.Contains(exception.Message))
                return true;
            return ContainErrorMessage(exception.InnerException);
        }

        protected static bool IsInnerException<T>(Exception exception)
            where T : Exception
        {
            T innerException;
            return IsInnerException<T>(exception, out innerException);
        }

        protected static bool IsInnerException<T>(Exception exception, out T inner)
            where T : Exception
        {
            inner = null;
            var innerExceptionType = typeof(T);
            var currentException = exception;
            while (currentException.InnerException != null)
            {
                inner = currentException.InnerException as T;
                if (inner != null)
                {
                    return true;
                }
                currentException = currentException.InnerException;
            }
            return false;
        }
    }
}
