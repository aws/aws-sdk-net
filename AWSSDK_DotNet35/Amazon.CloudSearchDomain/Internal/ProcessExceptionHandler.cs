using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CloudSearchDomain.Internal
{
    public class ProcessExceptionHandler : PipelineHandler
    {
#if BCL
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

#if BCL45
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
#elif AWS_APM_API

        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            var exception = executionContext.ResponseContext.AsyncResult.Exception;
            if (executionContext.ResponseContext.AsyncResult.Exception != null)
            {
                HandleException(ExecutionContext.CreateFromAsyncContext(executionContext), exception);
            }
            // Call outer handler
            base.InvokeAsyncCallback(executionContext);
        }
#endif

#if BCL
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
