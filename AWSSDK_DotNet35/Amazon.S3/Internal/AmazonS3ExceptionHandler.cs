using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;

namespace Amazon.S3.Internal
{
    public class AmazonS3ExceptionHandler : GenericExceptionHandler
    {
        protected override void HandleException(IExecutionContext executionContext, Exception exception)
        {

            var putObjectRequest = executionContext.RequestContext.OriginalRequest as PutObjectRequest;
            if (putObjectRequest != null)
            {
                // If InputStream was a HashStream, compare calculated hash to returned etag
                HashStream hashStream = putObjectRequest.InputStream as HashStream;
                if (hashStream != null)
                {
                    // Set InputStream to its original value
                    putObjectRequest.InputStream = hashStream.GetNonWrapperBaseStream();
                }
            }

            var uploadPartRequest = executionContext.RequestContext.OriginalRequest as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                // If InputStream was a HashStream, compare calculated hash to returned etag
                HashStream hashStream = uploadPartRequest.InputStream as HashStream;
                if (hashStream != null)
                {
                    // Set InputStream to its original value
                    uploadPartRequest.InputStream = hashStream.GetNonWrapperBaseStream();
                }
            }

            if (executionContext.RequestContext.Request != null)
                AmazonS3Client.CleanupRequest(executionContext.RequestContext.Request);
        }
    }
}
