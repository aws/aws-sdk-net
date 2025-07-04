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

        /// <summary>
        /// Custom pipeline handler
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            if (request.ResourcePath != null)
            {
                var segments = request.ResourcePath.Split(new char[] { '/' }, 3, StringSplitOptions.None);
                if(segments.Length >= 2 && segments[0].Length == 0 && request.PathResources[segments[1]]?.Length == 0)
                {
                    //Example: /{accountid}/stuff when {accountid} is blank changes to //stuff when it must be /-/stuff
                    request.PathResources[segments[1]] = "-";
                }                                
            }
            request.Headers["x-amz-glacier-version"] = "2012-06-01";
        }
    }
}
