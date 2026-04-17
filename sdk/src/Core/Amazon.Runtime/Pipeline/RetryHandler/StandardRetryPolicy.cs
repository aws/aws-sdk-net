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

using Amazon.Util;
using AWSSDK.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// The default implementation of the standard retry policy.
    /// </summary>
    public partial class StandardRetryPolicy : RetryPolicy
    {
        private static Random _randomJitter = new Random();
                
        //The status code returned from a service request when an invalid endpoint is used.
        private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;        
        
        protected static CapacityManager CapacityManagerInstance { get; set; } = UseNewRetries2026
            ? new CapacityManager(initialRetryTokens: 500, retryCost: 14, noRetryIncrement: 1, timeoutRetryCost: 10, throttlingRetryCost: 5)
            : new CapacityManager(initialRetryTokens: 500, retryCost: 5, noRetryIncrement: 1, timeoutRetryCost: 10, throttlingRetryCost: 0);

        /// <summary>
        /// The maximum value of exponential backoff in milliseconds, which will be used to wait
        /// before retrying a request. The default is 20000 milliseconds.
        /// </summary>
        public int MaxBackoffInMilliseconds { get; set; } = 20000;


        /// <summary>
        /// Constructor for StandardRetryPolicy.
        /// </summary>
        /// <param name="maxRetries">The maximum number of retries before throwing
        /// back a exception. This does not count the initial request.</param>
        public StandardRetryPolicy(int maxRetries)
        {
            this.MaxRetries = maxRetries;
        }

        /// <summary>
        /// Constructor for StandardRetryPolicy.
        /// </summary>
        /// <param name="config">The Client config object. This is used to 
        /// retrieve the maximum number of retries  before throwing
        /// back a exception(This does not count the initial request) and
        /// the service URL for the request.</param>
        public StandardRetryPolicy(IClientConfig config)
        {
            this.MaxRetries = config.MaxErrorRetry;

            // DynamoDB and DynamoDB Streams retry count handling:
            // Previously, MaxErrorRetry was set to 10 in the generated AmazonDynamoDBConfig/AmazonDynamoDBStreamsConfig.
            // This was moved here to the retry policy so we can apply the correct default based on the
            // UseNewRetries2026 flag. When UseNewRetries2026 is enabled, DynamoDB uses 3 retries (4 attempts)
            // per SEP 2.1. When disabled, it preserves the legacy default of 10 retries.
            // TODO: After the UseNewRetries2026 flag is removed (end of 2026), update the generated
            // DynamoDB/DynamoDB Streams configs to set MaxErrorRetry to 3 directly and remove this block.
            if (!config.IsMaxErrorRetrySet && IsDynamoDBService(config))
            {
                this.MaxRetries = UseNewRetries2026 ? 3 : 10;
            }

            if (config.ThrottleRetries)
            {
                RetryCapacity = CapacityManagerInstance.GetRetryCapacity(GetRetryCapacityKey(config));
            } 
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
            return RetryForExceptionSync(exception, executionContext);
        }

        /// <summary>
        /// Virtual method that gets called when a retry request is initiated. If retry throttling is
        /// enabled, the value returned is true if the required capacity is retured, false otherwise. 
        /// If retry throttling is disabled, true is returned.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override bool OnRetry(IExecutionContext executionContext)
        {
            return OnRetry(executionContext, false, false);
        }

        /// <summary>
        /// Virtual method that gets called when a retry request is initiated. If retry throttling is
        /// enabled, the value returned is true if the required capacity is retured, false otherwise. 
        /// If retry throttling is disabled, true is returned.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="bypassAcquireCapacity">true to bypass any attempt to acquire capacity on a retry</param>
        public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
        {
            return OnRetry(executionContext, bypassAcquireCapacity, false);
        }

        /// <summary>
        /// Virtual method that gets called when a retry request is initiated. If retry throttling is
        /// enabled, the value returned is true if the required capacity is retured, false otherwise. 
        /// If retry throttling is disabled, true is returned.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="bypassAcquireCapacity">true to bypass any attempt to acquire capacity on a retry</param>
        /// <param name="isThrottlingError">true if the error that will be retried is a throtting error</param>        
        public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
        {
            if (!bypassAcquireCapacity && executionContext.RequestContext.ClientConfig.ThrottleRetries && RetryCapacity != null)
            {
                return CapacityManagerInstance.TryAcquireCapacity(RetryCapacity, executionContext.RequestContext.LastCapacityType);
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Virtual method that gets called on a success Response. If its a retry success response, the entire 
        /// retry acquired capacity is released(default is 5). If its just a success response a lesser value capacity 
        /// is released(default is 1).
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        public override void NotifySuccess(IExecutionContext executionContext)
        {
            if(executionContext.RequestContext.ClientConfig.ThrottleRetries && RetryCapacity != null)
            {
                var requestContext = executionContext.RequestContext;
                CapacityManagerInstance.ReleaseCapacity(requestContext.LastCapacityType, RetryCapacity);
            }
        }
        /// <summary>
        /// Perform the processor-bound portion of the RetryForException logic.
        /// This is shared by the sync, async, and APM versions of the RetryForException method.
        /// </summary>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        protected bool RetryForExceptionSync(Exception exception)
        {
            return RetryForExceptionSync(exception, null);
        }
        /// <summary>
        /// Perform the processor-bound portion of the RetryForException logic.
        /// This is shared by the sync, async, and APM versions of the RetryForException method.
        /// </summary>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        protected bool RetryForExceptionSync(Exception exception, IExecutionContext executionContext)
        {
            // AmazonServiceException is thrown by ErrorHandler if it is this type of exception.
            var serviceException = exception as AmazonServiceException;

            // To try and smooth out an occasional throttling error, we'll pause and 
            // retry, hoping that the pause is long enough for the request to get through
            // the next time. Only the error code should be used to determine if an 
            // error is a throttling error.
            if (IsThrottlingError(exception))
            {
                return true;
            }

            // Check for transient errors, but we need to use
            // an exponential back-off strategy so that we don't overload
            // a server with a flood of retries. If we've surpassed our
            // retry limit we handle the error response as a non-retryable
            // error and go ahead and throw it back to the user as an exception.
            if (IsTransientError(executionContext, exception) || IsServiceTimeoutError(exception))
            {
                return true;
            }
            
            //Check for Invalid Endpoint Exception indicating that the Endpoint Discovery
            //endpoint used was invalid for the request. One retry attempt is allowed for this
            //type of exception.
            if (serviceException?.StatusCode == (HttpStatusCode)INVALID_ENDPOINT_EXCEPTION_STATUSCODE)
            {
                if (executionContext.RequestContext.EndpointDiscoveryRetries < 1)
                {
                    executionContext.RequestContext.EndpointDiscoveryRetries++;
                    return true;
                }

                return false;
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
        /// Determines if the service associated with the given client config is DynamoDB or DynamoDB Streams.
        /// Used for service-specific retry behavior such as adjusted backoff timing and increased retry counts.
        /// </summary>
        internal static bool IsDynamoDBService(IClientConfig config)
        {
            var serviceId = config?.ServiceId;
            return string.Equals(serviceId, "DynamoDB", StringComparison.OrdinalIgnoreCase)
                || string.Equals(serviceId, "DynamoDB Streams", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Waits before retrying a request. The default policy implements a exponential backoff with 
        /// jitter algorithm.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        public override void WaitBeforeRetry(IExecutionContext executionContext)
        {
            AWSSDKUtils.Sleep(CalculateRetryDelay(executionContext, this.MaxBackoffInMilliseconds));
        }

        /// <summary>
        /// Calculates the retry delay in milliseconds. When UseNewRetries2026 is enabled, uses the
        /// SEP 2.1 formula with service-aware base delay, MAX_BACKOFF applied before jitter, and
        /// x-amz-retry-after header clamping. Otherwise uses the legacy 2.0 formula.
        /// </summary>
        /// <param name="executionContext">The execution context for the current request.</param>
        /// <param name="maxBackoffInMilliseconds">The maximum backoff in milliseconds.</param>
        /// <returns>The delay in milliseconds before the next retry.</returns>
        internal static int CalculateRetryDelay(IExecutionContext executionContext, int maxBackoffInMilliseconds)
        {
            var retries = executionContext.RequestContext.Retries;
            double jitter;
            lock (_randomJitter) {        
                jitter = _randomJitter.NextDouble();
            }

            if (!UseNewRetries2026)
            {
                return Convert.ToInt32(Math.Min(jitter * Math.Pow(2, retries - 1) * 1000.0, maxBackoffInMilliseconds));
            }

            // SEP 2.1: Determine the base delay multiplier (x) based on error type and service.
            //   - 1.0 (1000ms) for throttling errors
            //   - 0.05 (50ms) for non-throttling errors on most services
            //   - 0.025 (25ms) for non-throttling errors on DynamoDB/DynamoDB Streams
            var isThrottlingError = executionContext.RequestContext.LastCapacityType == CapacityManager.CapacityType.Throttling;
            double baseDelayMs;
            if (isThrottlingError)
            {
                baseDelayMs = 1000.0;
            }
            else if (IsDynamoDBService(executionContext.RequestContext.ClientConfig))
            {
                baseDelayMs = 25.0;
            }
            else
            {
                baseDelayMs = 50.0;
            }

            // SEP 2.1: MAX_BACKOFF is applied before jitter.
            // Formula: jitter * Min(x * 2^(retries-1) * 1000, MAX_BACKOFF)
            double rawDelay = baseDelayMs * Math.Pow(2, retries - 1);
            double cappedDelay = Math.Min(rawDelay, maxBackoffInMilliseconds);
            var backoffDelayMs = Convert.ToInt32(jitter * cappedDelay);

            // SEP 2.1: x-amz-retry-after header clamping.
            // The header value (ms) is clamped to [backoffDelay, 5000 + backoffDelay]. MAX_BACKOFF is NOT applied.
            if (executionContext.RequestContext.ContextAttributes.TryGetValue(RetryAfterContextKey, out var retryAfterObj)
                && retryAfterObj is int retryAfterMs)
            {
                var clampedMs = retryAfterMs;
                if (clampedMs < backoffDelayMs) clampedMs = backoffDelayMs;
                if (clampedMs > 5000 + backoffDelayMs) clampedMs = 5000 + backoffDelayMs;
                return clampedMs;
            }

            return backoffDelayMs;
        }

    }
}
