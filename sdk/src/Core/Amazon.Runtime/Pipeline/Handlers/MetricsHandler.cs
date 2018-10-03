/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using System.Globalization;
using System;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler manages the metrics used to time the complete call and
    /// logs the final metrics.
    /// </summary>
    public class MetricsHandler : PipelineHandler
    {
        /// <summary>
        /// Captures the overall execution time and logs final metrics.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            executionContext.RequestContext.Metrics.AddProperty(Metric.AsyncCall, false);
            try
            {
                executionContext.RequestContext.Metrics.StartEvent(Metric.ClientExecuteTime);
                base.InvokeSync(executionContext);
            }
            finally
            {
                var latency = AWSSDKUtils.ConvertTimeSpanToMilliseconds(executionContext.RequestContext.Metrics
                    .StopEvent(Metric.ClientExecuteTime)
                    .ElapsedTime);

#if BCL || CORECLR
                // capture the latency for the entire SDK call if CSM is enabled
                if (DeterminedCSMConfiguration.Instance.CSMConfiguration.Enabled)
                {
                    executionContext.RequestContext.CSMCallEvent.Latency = latency;
                    CSMUtilities.SerializetoJsonAndPostOverUDP(executionContext.RequestContext.CSMCallEvent);
                }
#endif
                this.LogMetrics(executionContext);
            }
        }

#if AWS_ASYNC_API 

        /// <summary>
        /// Captures the overall execution time and logs final metrics.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            executionContext.RequestContext.Metrics.AddProperty(Metric.AsyncCall, true);
            try
            {
                executionContext.RequestContext.Metrics.StartEvent(Metric.ClientExecuteTime);
                var response = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);    
                return response;                              
            }
            finally
            {
                var latency = AWSSDKUtils.ConvertTimeSpanToMilliseconds(executionContext.RequestContext.Metrics
                    .StopEvent(Metric.ClientExecuteTime)
                    .ElapsedTime);

#if BCL || CORECLR
                // capture the latency for the entire SDK call if CSM is enabled
                if (DeterminedCSMConfiguration.Instance.CSMConfiguration.Enabled)
                {
                    executionContext.RequestContext.CSMCallEvent.Latency = latency;
                    CSMUtilities.SerializetoJsonAndPostOverUDPAsync(executionContext.RequestContext.CSMCallEvent).ConfigureAwait(false);
                }
#endif
                this.LogMetrics(executionContext);
            }
        }

#elif AWS_APM_API

        /// <summary>
        /// Captures the overall execution time.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            executionContext.RequestContext.Metrics.AddProperty(Metric.AsyncCall, true);
            executionContext.RequestContext.Metrics.StartEvent(Metric.ClientExecuteTime);
            return base.InvokeAsync(executionContext);
        }

        /// <summary>
        /// Captures the overall execution time and logs final metrics.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            var latency = AWSSDKUtils.ConvertTimeSpanToMilliseconds(executionContext.RequestContext.Metrics
                    .StopEvent(Metric.ClientExecuteTime)
                    .ElapsedTime);
#if BCL
            // capture the latency for the entire SDK call if CSM is enabled
            if (DeterminedCSMConfiguration.Instance.CSMConfiguration.Enabled)
            {
                executionContext.RequestContext.CSMCallEvent.Latency = latency;
                CSMUtilities.BeginSerializetoJsonAndPostOverUDP(executionContext.RequestContext.CSMCallEvent);
            }
#endif
            this.LogMetrics(ExecutionContext.CreateFromAsyncContext(executionContext));
            base.InvokeAsyncCallback(executionContext);
        }
#endif

    }
}
