/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3Control.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Execute necessary logic before the marshalling stage
    /// </summary>
    public class AmazonS3ControlPreMarshallHandler : PipelineHandler
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

        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            ProcessPreRequestHandlers(executionContext);
        }

        private static void ProcessPreRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;

            // For CreateAccessPoint, the bucket needs to be extracted from the Arn before
            // it is added to the request payload. Setting outpost id so that the header isn't
            // lost in the case of an outpost request
            var createAccessPointRequest = request as CreateAccessPointRequest;
            Arn arn;
            if (createAccessPointRequest != null && createAccessPointRequest.IsSetBucket() 
                && Arn.TryParse(createAccessPointRequest.Bucket, out arn))
            {
                IS3Resource s3Resource = null;
                if (arn.IsOutpostArn())
                {
                    s3Resource = arn.ParseOutpost();
                }
                if (s3Resource != null)
                {
                    createAccessPointRequest.OutpostId = ((S3OutpostResource)s3Resource).OutpostId;
                    createAccessPointRequest.Bucket = s3Resource.Name;
                    createAccessPointRequest.AccountId = createAccessPointRequest.AccountId ?? arn.AccountId;
                }
            }

            
        }
    }
}
