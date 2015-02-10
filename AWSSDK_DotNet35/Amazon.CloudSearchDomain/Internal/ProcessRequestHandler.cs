using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CloudSearchDomain.Internal
{
    public class ProcessRequestHandler : PipelineHandler
    {
#if BCL
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
#endif

#if BCL45

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

#if BCL
        protected void PreInvoke(IExecutionContext executionContext)
        {
            var uploadDocumentsRequest = executionContext.RequestContext.OriginalRequest as UploadDocumentsRequest;
            if (uploadDocumentsRequest != null)
            {
                if (uploadDocumentsRequest.Documents == null && string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a Documents or a FilePath to be uploaded.");

                if (uploadDocumentsRequest.Documents != null && !string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a Documents or a FilePath to be uploaded.");

                if (!string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                {
                    uploadDocumentsRequest.SetupForFilePath();
                }
            }
        }
#endif
    }
}
