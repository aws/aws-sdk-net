/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// A retry policy specifies all aspects of retry behavior. This includes conditions when the request should be retried,
    /// checks of retry limit, preparing the request before retry and introducing delay (backoff) before retries.
    /// </summary>
    public abstract partial class RetryPolicy
    {
        /// <summary>
        /// Checks if a retry should be performed with the given execution context and exception.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">The exception throw after issuing the request.</param>
        /// <returns>Returns true if the request should be retried, else false.</returns>
        public async Task<bool> RetryAsync(IExecutionContext executionContext, Exception exception)
        {
            bool retryFlag;
            var helperResult = RetrySync(executionContext, exception);
            if (helperResult.HasValue)
            {
                retryFlag = helperResult.Value;
            }
            else
            {
                retryFlag = await RetryForExceptionAsync(executionContext, exception).ConfigureAwait(false);
            }
            return (retryFlag && OnRetry(executionContext));
        }

        /// <summary>
        /// Return true if the request should be retried for the given exception.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public abstract Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception);

        /// <summary>
        /// Waits before retrying a request.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public abstract Task WaitBeforeRetryAsync(IExecutionContext executionContext);

    }
}
