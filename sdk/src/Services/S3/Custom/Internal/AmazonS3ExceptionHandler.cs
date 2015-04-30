/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Custom pipeline handler to clean up streams in case of an exception.
    /// </summary>
    public class AmazonS3ExceptionHandler : PipelineHandler
    {
        /// <summary>
        /// Catch exceptions and clean up any open streams.
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

#if AWS_ASYNC_API
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
        /// <summary>
        /// Catch exceptions and clean up any open streams.
        /// </summary>
        /// <param name="executionContext"></param>
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
        /// <summary>
        /// Catch exceptions and clean up any open streams.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="exception"></param>
        protected virtual void HandleException(IExecutionContext executionContext, Exception exception)
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
