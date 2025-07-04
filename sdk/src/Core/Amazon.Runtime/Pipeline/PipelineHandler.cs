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

using Amazon.Runtime.Internal.Util;
using System;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// An abstract pipeline handler that has implements IPipelineHandler,
    /// and has the default implmentation. This is the base class for most of
    /// the handler implementations.
    /// </summary>    
    public abstract partial class PipelineHandler : IPipelineHandler
    {

        /// <summary>
        /// The logger used to log messages.
        /// </summary>
        public virtual ILogger Logger { get; set; }

        /// <summary>
        /// The inner handler which is called after the current 
        /// handler completes it's processing.
        /// </summary>
        public IPipelineHandler InnerHandler { get; set; }

        /// <summary>
        /// The outer handler which encapsulates the current handler.
        /// </summary>
        public IPipelineHandler OuterHandler { get; set; }

        /// <summary>
        /// Contains the processing logic for a synchronous request invocation.
        /// This method calls InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
//        [System.Diagnostics.DebuggerHidden]
        public virtual void InvokeSync(IExecutionContext executionContext)
        {
            if (this.InnerHandler != null)
            {
                InnerHandler.InvokeSync(executionContext);
                return;
            }
            throw new InvalidOperationException("Cannot invoke InnerHandler. InnerHandler is not set.");
        }

        /// <summary>
        /// Contains the processing logic for an asynchronous request invocation.
        /// This method calls InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
#if !NETSTANDARD
        [System.Diagnostics.DebuggerHidden]
#endif
        public virtual System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
            where T : AmazonWebServiceResponse, new()
        {
            if (this.InnerHandler != null)
            {
                return InnerHandler.InvokeAsync<T>(executionContext);    
            }
            throw new InvalidOperationException("Cannot invoke InnerHandler. InnerHandler is not set.");
        }

        /// <summary>
        /// Logs the metrics for the current execution context.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected void LogMetrics(IExecutionContext executionContext)
        {
            var metrics = executionContext.RequestContext.Metrics;
            if (executionContext.RequestContext.ClientConfig.LogMetrics)
            {
                string errors = metrics.GetErrors();
                if (!string.IsNullOrEmpty(errors))
                    this.Logger.InfoFormat("Request metrics errors: {0}", errors);
                this.Logger.InfoFormat("Request metrics: {0}", metrics);
            }
        }
    }
}
