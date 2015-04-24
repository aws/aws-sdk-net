using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Glacier.Internal
{
    /// <summary>
    /// Custom pipeline handler to add default account if not specified in the request object.
    /// </summary>
    public class ProcessRequestHandler : PipelineHandler
    {
        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }
#if AWS_ASYNC_API 

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);                        
        }

#elif AWS_APM_API

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }
#endif
        /// <summary>
        /// Custom pipeline handler
        /// </summary>
        /// <param name="executionContext"></param>
        protected void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            if (request.ResourcePath != null)
            {
                if (request.ResourcePath.StartsWith("//", StringComparison.Ordinal))
                {
                    request.ResourcePath = "/-" + request.ResourcePath.Substring(1);
                }
            }
            request.Headers["x-amz-glacier-version"] = "2012-06-01";
        }
    }
}
