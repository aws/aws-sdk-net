﻿/*
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

using Amazon.Runtime.Internal.Util;
using System;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler manages the calculation of the checksum of the payload request when the checksum of a request is supported.
    /// It also sets the checksum header of the request.
    /// </summary>
    public class ChecksumHandler : PipelineHandler
    {

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// request and response context.</param>
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
        /// Calls pre invoke logic before calling the next handler in the pipeline.
        /// </summary>
        /// <param name="asyncExecutionContext">The execution context which contains both the
        /// request and response context.</param>
        /// <returns>IAsyncResult which represents an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext asyncExecutionContext)
        {
            var executionContext = ExecutionContext.CreateFromAsyncContext(asyncExecutionContext);
            PreInvoke(executionContext);
            return base.InvokeAsync(asyncExecutionContext);
        }
#endif

        /// <summary>
        /// Calculates the checksum of the payload of a request, and sets the checksum request header only once.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the request and response context.</param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var clientConfig = executionContext.RequestContext.ClientConfig;

            if (request.ChecksumData == null)
            {
                return;
            }
            
            if (request.ChecksumData.IsMD5Checksum)
            {
                ChecksumUtils.SetRequestChecksumMD5(request);
                return;
            }

            if (ShouldSkipChecksum(request, clientConfig))
            {
                return;
            }

            ChecksumUtils.SetRequestChecksumV2(request, clientConfig);
        }

        private bool ShouldSkipChecksum(IRequest request, IClientConfig clientConfig)
        {
            if (request.ChecksumData.SkipChecksum)
            {
                return true;
            }

            // Do not attempt to set checksum when using SigV2 (only applicable to S3).
            if (clientConfig.SignatureVersion == "2")
            {
                return true;
            }

            // This is a workaround for mismatches between older S3 packages and newer Core (and more specifically for S3 Express and multi-part
            // uploads). The service package would attempt to override the checksum for directory buckets, but the approach used would cause Core (which
            // is following the flexible checksum specification) to calculate a checksum for the InitiateMPU / CreateMPU operations.
            // TODO: This should be removed in V4 (the only component of this method that should remain is the signature version check)
            if (clientConfig.ServiceId.Equals("S3", StringComparison.OrdinalIgnoreCase))
            {
                var isMPURequest =
                    request.RequestName.Equals("InitiateMultipartUploadRequest", StringComparison.OrdinalIgnoreCase) ||
                    request.RequestName.Equals("CompleteMultipartUploadRequest", StringComparison.OrdinalIgnoreCase);
                var isS3ExpressRequest =
                    request.EndpointAttributes["backend"] != null && (string)request.EndpointAttributes["backend"] == "S3Express";

                if (isMPURequest && isS3ExpressRequest)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
