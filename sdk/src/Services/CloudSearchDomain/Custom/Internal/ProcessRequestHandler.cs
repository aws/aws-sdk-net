using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CloudSearchDomain.Internal
{
    /// <summary>
    /// Custom pipeline handler.
    /// </summary>
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

#if BCL

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
#endif

#if BCL
        /// <summary>
        /// Custom pipeline handler.
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
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
