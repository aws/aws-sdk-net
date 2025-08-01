using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.SQS.Model;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Internal
{
    /// <summary>
    /// Custom pipeline handler
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
        /// Customize the QueueUrl
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            if (request.Parameters.ContainsKey("QueueUrl"))
            {
                string queueUrl = request.Parameters["QueueUrl"];
                Uri uri = new Uri(queueUrl);
                request.Parameters.Remove("QueueUrl");
                request.ResourcePath = uri.AbsolutePath;
            }
        }
    }
}
