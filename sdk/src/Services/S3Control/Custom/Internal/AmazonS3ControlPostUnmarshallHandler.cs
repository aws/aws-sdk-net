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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.S3Control.Model;
using System.IO;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal;

#pragma warning disable 1591

namespace Amazon.S3Control.Internal
{
    public class AmazonS3ControlPostUnmarshallHandler : PipelineHandler
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

        protected virtual void PostInvoke(IExecutionContext executionContext)
        {
            ProcessResponseHandlers(executionContext);
        }

        private static void ProcessResponseHandlers(IExecutionContext executionContext)
        {
            var response = executionContext.ResponseContext.Response;
            var httpResponse = executionContext.ResponseContext.HttpResponse;
            var metrics = executionContext.RequestContext.Metrics;

            if (httpResponse.IsHeaderPresent(HeaderKeys.XAmzId2Header))
            {
                string headerValue = httpResponse.GetHeaderValue(HeaderKeys.XAmzId2Header);
                
                // Make sure ResponseMetadata is set
                if (response.ResponseMetadata == null)
                {
                    response.ResponseMetadata = new ResponseMetadata();
                }

                response.ResponseMetadata.Metadata.Add(HeaderKeys.XAmzId2Header, headerValue);
                metrics.AddProperty(Metric.AmzId2, headerValue);
            }
        }
    }
}
