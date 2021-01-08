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
using Amazon.Runtime.Internal;
using Amazon.S3Control;
using System.Text.RegularExpressions;
using Amazon.Util;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3Control.Internal
{
    public class AmazonS3ControlPostMarshallHandler : PipelineHandler
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
            ProcessRequestHandlers(executionContext);
        }

        public static void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var config = executionContext.RequestContext.ClientConfig;
            string nonArnOutpostId;
            Arn s3Arn;
            if (S3ArnUtils.RequestContainsArn(request, out s3Arn))
            {
                IS3Resource s3Resource = null;
                if (s3Arn.IsOutpostArn())
                {
                    if (!s3Arn.IsValidService())
                    {
                        throw new AmazonClientException($"Invalid ARN: {s3Arn.ToString()}, not S3 Outposts ARN");
                    }
                    s3Resource = s3Arn.ParseOutpost();
                    request.Headers[HeaderKeys.XAmzOutpostId] = ((S3OutpostResource) s3Resource).OutpostId;
                }
                if (s3Resource != null)
                {
                    s3Resource.ValidateArnWithClientConfig(config);
                    request.Endpoint = s3Resource.GetEndpoint(config);
                    request.UseSigV4 = true;
                    request.CanonicalResourcePrefix = string.Concat("/", s3Resource.FullResourceName);
                    request.OverrideSigningServiceName = s3Arn.Service;
                    // The access point arn can be using a region different from the configured region for the service client.
                    // If so be sure to set the authentication region so the signer will use the correct region.
                    request.AuthenticationRegion = s3Arn.Region;
                    request.Headers[HeaderKeys.XAmzAccountId] = s3Arn.AccountId;
                    // replace the ARNs in the resource path or query params with the extracted name of the resource
                    // These methods assume that there is max 1 Arn in the PathResources or Parameters
                    S3ArnUtils.ReplacePathResourceArns(request.PathResources, s3Resource.Name);
                    S3ArnUtils.ReplacePathResourceArns(request.Parameters, s3Resource.Name);
                }
            } 
            else if (S3ArnUtils.DoesRequestHaveOutpostId(request.OriginalRequest, out nonArnOutpostId))
            {
                if (!S3ArnUtils.IsValidOutpostId(nonArnOutpostId))
                {
                    throw new AmazonClientException($"Invalid outpost ID. ID must contain only alphanumeric characters and dashes");
                }
                request.OverrideSigningServiceName = S3ArnUtils.S3OutpostsService;
                request.Endpoint = S3ArnUtils.GetNonStandardOutpostIdEndpoint(config);
                request.Headers[HeaderKeys.XAmzOutpostId] = nonArnOutpostId;
            }
        }
    }
}
