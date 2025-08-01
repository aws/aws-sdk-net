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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Util;
using System.Threading.Tasks;

namespace Amazon.S3.Internal.S3Express
{
    /// <summary>
    /// This handler pre signs the requests that uses S3Express authentication.
    /// </summary>
    public class S3ExpressPreSigner : PipelineHandler
    {
        private const string S3ExpressSessionHeader = "x-amz-s3session-token";

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
        /// Signs the request before invoking the next handler.
        /// </summary>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        protected static void PreInvoke(IExecutionContext executionContext)
        {
            var config = (AmazonS3Config)executionContext.RequestContext.ClientConfig;
            if (ShouldSign(executionContext.RequestContext, config))
            {
                PreSignRequest(executionContext.RequestContext, config);
            }
        }

        /// <summary>
        /// Determines if the request should be signed via S3Express session credentials.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <param name="config">S3 Configuration Object</param>
        /// <returns>A boolean value that indicates if the request should be signed.</returns>
        private static bool ShouldSign(IRequestContext requestContext, AmazonS3Config config)
        {
            return requestContext.Request.UseS3ExpressSessionAuth() &&
                !config.DisableS3ExpressSessionAuth;
        }

        /// <summary>
        /// Add S3Express session token to the request headers and override the request context credentials.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <param name="config">S3 Configuration Object</param>
        private static void PreSignRequest(IRequestContext requestContext, AmazonS3Config config)
        {
            var sessionCredentials = config.S3ExpressCredentialProvider.ResolveSessionCredentials(GetRequestBucketName(requestContext.Request));
            if (sessionCredentials == null) 
            {
                // Couldn't resolve session credentials, fallback to regular authentication
                return;
            }

            requestContext.Request.Headers[S3ExpressSessionHeader] = sessionCredentials.SessionToken;
            requestContext.Identity = new BasicAWSCredentials(sessionCredentials.AccessKeyId, sessionCredentials.SecretAccessKey);
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            await PreInvokeAsync(executionContext).ConfigureAwait(false);
            return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        }
        
        /// <summary>
        /// Signs the request before invoking the next handler.
        /// </summary>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        protected static async System.Threading.Tasks.Task PreInvokeAsync(IExecutionContext executionContext)
        {
            var config = (AmazonS3Config)executionContext.RequestContext.ClientConfig;
            if (ShouldSign(executionContext.RequestContext, config))
            {
                await PreSignRequestAsync(executionContext.RequestContext, config).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Add S3Express session token to the request headers and override the request context credentials.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <param name="config">S3 Configuration Object</param>
        private static async Task PreSignRequestAsync(IRequestContext requestContext, AmazonS3Config config)
        {
            var sessionCredentials = await config.S3ExpressCredentialProvider
                    .ResolveSessionCredentialsAsync(GetRequestBucketName(requestContext.Request))
                    .ConfigureAwait(false);
            if (sessionCredentials == null)
            {
                // Couldn't resolve session credentials, fallback to regular authentication
                return;
            }

            requestContext.Request.Headers[S3ExpressSessionHeader] = sessionCredentials.SessionToken;
            requestContext.Identity = new BasicAWSCredentials(sessionCredentials.AccessKeyId, sessionCredentials.SecretAccessKey);
        }

        private static string GetRequestBucketName(IRequest request)
        {
            var s3Uri = new AmazonS3Uri(request.Endpoint);
            return s3Uri.Bucket;
        }
    }
}
