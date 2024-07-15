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
using System.Globalization;
using System.Text;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler marshalls the request before calling invoking the next handler.
    /// </summary>
    public class Marshaller : PipelineHandler
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

        /// <summary>
        /// Marshalls the request before calling invoking the next handler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected static void PreInvoke(IExecutionContext executionContext)
        {
            using (MetricsUtilities.MeasureDuration(executionContext.RequestContext, TelemetryConstants.SerializationDurationMetricName))
            {
                var requestContext = executionContext.RequestContext;
                requestContext.Request = requestContext.Marshaller.Marshall(requestContext.OriginalRequest);
                requestContext.Request.AuthenticationRegion = requestContext.ClientConfig.AuthenticationRegion;

                // If the request has a body and its request-specific marshaller didn't already
                // set Content-Type, follow our existing fallback logic
                if (requestContext.Request.HasRequestBody() &&
                !requestContext.Request.Headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                {
                    if (requestContext.Request.UseQueryString)
                        requestContext.Request.Headers[HeaderKeys.ContentTypeHeader] = "application/x-amz-json-1.0";
                    else
                        requestContext.Request.Headers[HeaderKeys.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
                }

                SetRecursionDetectionHeader(requestContext.Request.Headers);
                SetUserAgentHeader(requestContext);
            }
        }

        /// <summary>
        /// Sets the X-Amzn-Trace-Id header for recursion detection within Lambda workloads.
        /// </summary>
        /// <param name="headers">Current request headers before marshalling.</param>
        private static void SetRecursionDetectionHeader(IDictionary<string, string> headers)
        {
            if (!headers.ContainsKey(HeaderKeys.XAmznTraceIdHeader))
            {
                var lambdaFunctionName = Environment.GetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_FUNCTION_NAME);
                var amznTraceId = Environment.GetEnvironmentVariable(EnvironmentVariables._X_AMZN_TRACE_ID);

                if (!string.IsNullOrEmpty(lambdaFunctionName) && !string.IsNullOrEmpty(amznTraceId))
                {
                    headers[HeaderKeys.XAmznTraceIdHeader] = AWSSDKUtils.EncodeTraceIdHeaderValue(amznTraceId);
                }
            }
        }

        private static void SetUserAgentHeader(IRequestContext requestContext)
        {
            var sb = new StringBuilder(requestContext.ClientConfig.UserAgent);

            var clientAppId = requestContext.ClientConfig.ClientAppId;
            if (!string.IsNullOrEmpty(clientAppId))
                sb.AppendFormat(" app/{0}", clientAppId);

            var retryMode = requestContext.ClientConfig.RetryMode.ToString().ToLower();
            sb.AppendFormat(" cfg/retry-mode#{0}", retryMode);

            sb.AppendFormat(" md/{0}", requestContext.IsAsync ? "ClientAsync" : "ClientSync");

            sb.AppendFormat(" cfg/init-coll#{0}", AWSConfigs.InitializeCollections ? "1" : "0");

            var userAgentAddition = requestContext.OriginalRequest.UserAgentAddition;
            if (!string.IsNullOrEmpty(userAgentAddition))
            {
                sb.AppendFormat(" {0}", userAgentAddition);
            }

            var userAgent = sb.ToString();

            userAgent = InternalSDKUtils.ReplaceInvalidUserAgentCharacters(userAgent);

            if (requestContext.ClientConfig.UseAlternateUserAgentHeader)
            {
                requestContext.Request.Headers[HeaderKeys.XAmzUserAgentHeader] = userAgent;
            }
            else
            {
                requestContext.Request.Headers[HeaderKeys.UserAgentHeader] = userAgent;
            }
        }
    }
}
