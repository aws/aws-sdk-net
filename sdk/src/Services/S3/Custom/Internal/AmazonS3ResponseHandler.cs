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

using System.Linq;
using Amazon.Runtime;
using Amazon.S3.Model;
using Amazon.Runtime.Internal;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class AmazonS3ResponseHandler : PipelineHandler
    {
        /// <summary>
        /// Calls the post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            base.InvokeSync(executionContext);
            PostInvoke(executionContext);
        }

#if AWS_ASYNC_API
        /// <summary>
        /// Calls the and post invoke logic after calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var response = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            PostInvoke(executionContext);
            return response;
        }
#endif

        protected virtual void PostInvoke(IExecutionContext executionContext)
        {
            ProcessResponseHandlers(executionContext);
        }

        private static void ProcessResponseHandlers(IExecutionContext executionContext)
        {
            AmazonWebServiceResponse response = executionContext.ResponseContext.Response;
            IRequest request = executionContext.RequestContext.Request;

            if (response is DeleteObjectsResponse deleteObjectsResponse)
            {
                if (deleteObjectsResponse.DeleteErrors != null && deleteObjectsResponse.DeleteErrors.Count > 0)
                {
                    throw new DeleteObjectsException(deleteObjectsResponse);
                }
            }

            if (response is ListObjectsResponse listObjectsResponse)
            {
                if (listObjectsResponse.IsTruncated.GetValueOrDefault() &&
                    string.IsNullOrEmpty(listObjectsResponse.NextMarker) &&
                    listObjectsResponse.S3Objects?.Count > 0)
                {
                    listObjectsResponse.NextMarker = listObjectsResponse.S3Objects?.Last().Key;
                }
            }

            if (response is CopyPartResponse copyPartResponse)
            {
                copyPartResponse.PartNumber = ((CopyPartRequest)request.OriginalRequest).PartNumber;
            }

            AmazonS3Client.CleanupRequest(request.OriginalRequest);
        }
    }
}
