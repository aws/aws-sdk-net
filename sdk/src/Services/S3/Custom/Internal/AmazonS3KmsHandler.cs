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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Util;
using System;

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Custom pipeline handler to enable sig V4 for Get requests.
    /// </summary>
    public class AmazonS3KmsHandler : PipelineHandler
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

        /// <summary>
        /// Custom pipeline handler to enable sig V4 for Get requests.
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            EvaluateIfSigV4Required(request);
        }

        internal static void EvaluateIfSigV4Required(IRequest request)
        {
            // Skip this if the request has already been "upgraded" to SigV4a
            if (request.SignatureVersion == SignatureVersion.SigV4a)
            {
                return;
            }

            // Skip this for S3-compatible storage provider endpoints
            if (request.OriginalRequest is S3.Model.GetObjectRequest && 
                AmazonS3Uri.TryParseAmazonS3Uri(request.Endpoint, out var amazonS3Uri) && 
                amazonS3Uri.Region?.SystemName != RegionEndpoint.USEast1.SystemName)     
            {
                request.SignatureVersion = SignatureVersion.SigV4;
            }
        }
    }
}
