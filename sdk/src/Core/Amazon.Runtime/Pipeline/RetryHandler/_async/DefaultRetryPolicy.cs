﻿/*
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

using Amazon.Util;
using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// The default implementation of the retry policy.
    /// </summary>
    public partial class DefaultRetryPolicy : RetryPolicy
    {
        /// <summary>
        /// Return true if the request should be retried.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public override async Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
        {
            return await Task.FromResult(RetryForExceptionSync(exception)).ConfigureAwait(false);
        }

        /// <summary>
        /// Waits before retrying a request.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override async Task WaitBeforeRetryAsync(IExecutionContext executionContext)
        {
            var delay = CalculateRetryDelay(executionContext.RequestContext.Retries, this.MaxBackoffInMilliseconds);
            await Task.Delay(delay).ConfigureAwait(false);
        }
    }
}