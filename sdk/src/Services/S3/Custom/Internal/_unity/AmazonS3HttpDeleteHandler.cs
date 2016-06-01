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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using System;

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Custom pipeline handler to add Content-Type application/x-www-form-urlencoded to http
    /// DELETE requests if using Unity Android. The underlying http handler adds this if no
    /// Content-Type is supplied, which would result in an inaccurate signature.
    /// </summary>
    public class AmazonS3HttpDeleteHandler : PipelineHandler
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
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }

        /// <summary>
        /// Custom pipeline handler to add Content-Type
        /// application/x-www-form-urlencoded to http DELETE requests if using
        /// Unity Android. The underlying http handler adds this if no
        /// Content-Type is supplied, which would result in an inaccurate
        /// signature.
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            ModifyDeleteRequest(executionContext);
        }

        internal static void ModifyDeleteRequest(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var headers = request.Headers;
            var parameters = request.Parameters;
            if (InternalSDKUtils.IsAndroid && request.HttpMethod == "DELETE")
            {
                if (!(parameters.ContainsKey("ContentType") || headers.ContainsKey(HeaderKeys.ContentTypeHeader)))
                {
                    headers.Add(HeaderKeys.ContentTypeHeader, "application/x-www-form-urlencoded");
                }
            }
        }
    }
}
