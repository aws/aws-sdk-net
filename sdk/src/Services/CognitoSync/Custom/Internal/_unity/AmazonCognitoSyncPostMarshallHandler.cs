using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Amazon.CognitoSync.Internal
{
    /// <summary>
    /// Cognito Sync post marshall handler to handle XHttpMethodOverrideHeader
    /// </summary>
    public class AmazonCognitoSyncPostMarshallHandler : PipelineHandler
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
        
        private void PreInvoke(IExecutionContext executionContext)
        {
            ProcessRequestHandlers(executionContext);
        }

        private void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;

            // If the request method/verb is anything other than GET or POST then, 
            // update the method to POST and add the X Http Method Overide header

            string method = request.HttpMethod.ToUpper();
            if (!(method.Equals("GET", StringComparison.InvariantCultureIgnoreCase)
                || method.Equals("POST", StringComparison.InvariantCultureIgnoreCase)))
            {
                request.Headers.Add(HeaderKeys.XHttpMethodOverrideHeader, request.HttpMethod);
                // some http methods may not have a post body so we add a empty string with a space as the postbody
                if (request.Content == null || request.Content.Length == 0)
                {
                    string emptyString = "{}";
                    request.Content = Encoding.UTF8.GetBytes(emptyString);
                    request.ContentStream = new MemoryStream(Encoding.UTF8.GetBytes(emptyString));
                }
            }
        }
    }
}
