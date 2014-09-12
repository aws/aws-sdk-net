using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CloudSearchDomain.Internal
{
    public class ProcessRequestHandler : GenericHandler
    {

#if BCL
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var uploadDocumentsRequest = executionContext.RequestContext.Request as UploadDocumentsRequest;
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
