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
    /// Custom pipeline handler to make sure streams are closed in case of exceptions.
    /// </summary>
    public class ProcessExceptionHandler : PipelineHandler
    {
#if BCL
        /// <summary>
        /// Override to do extra exception handling if thrown in the pipeline.
        /// </summary>
        /// <param name="executionContext"></param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            try
            {
                base.InvokeSync(executionContext);
            }
            catch (Exception exception)
            {
                HandleException(executionContext, exception);
                throw;
            }
        }
#endif

#if BCL
        /// <summary>
        /// Override to do extra exception handling if thrown in the pipeline.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            try
            {
                return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            }
            catch(Exception exception)
            {
                HandleException(executionContext, exception);
                throw;
            }
        }
#endif

#if BCL

        /// <summary>
        /// Make sure stream is closed in case of exceptions in the pipeline.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="exception"></param>
        protected virtual void HandleException(IExecutionContext executionContext, Exception exception)
        {
            var uploadDocumentsRequest = executionContext.RequestContext.OriginalRequest as UploadDocumentsRequest;

            if (uploadDocumentsRequest != null)
            {
                // If Documents property is set as the underlying stream for FilePath, dispose it.
                if (uploadDocumentsRequest.Documents != null && !string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                {
                    uploadDocumentsRequest.Documents.Dispose();
                    uploadDocumentsRequest.Documents = null;
                }
            }
        }
#endif
    }
}
