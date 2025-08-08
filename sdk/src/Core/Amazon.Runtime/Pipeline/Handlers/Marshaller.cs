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
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Metrics.NoOp;
using Amazon.Runtime.Telemetry.Tracing.NoOp;
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
        /// Marshalls the request before calling invoking the next handler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected static void PreInvoke(IExecutionContext executionContext)
        {
            using (MetricsUtilities.MeasureDuration(executionContext.RequestContext, TelemetryConstants.SerializationDurationMetricName))
            {
                var requestContext = executionContext.RequestContext;

                if (requestContext.OriginalRequest.CoreChecksumMode != CoreChecksumResponseBehavior.ENABLED
                        && requestContext.ClientConfig.ResponseChecksumValidation == ResponseChecksumValidation.WHEN_SUPPORTED)
                {
                    // Set CoreChecksumMode to enabled to validate the integrity of this request's response if it is supported.
                    requestContext.OriginalRequest.CoreChecksumMode = CoreChecksumResponseBehavior.ENABLED;
                }

                switch (requestContext.ClientConfig.ResponseChecksumValidation)
                {
                    case ResponseChecksumValidation.WHEN_SUPPORTED:
                        requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_RES_WHEN_SUPPORTED);
                        break;
                    case ResponseChecksumValidation.WHEN_REQUIRED:
                        requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_RES_WHEN_REQUIRED);
                        break;
                }

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
                UpdateUserAgentDetails(requestContext);
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

        private static void UpdateUserAgentDetails(IRequestContext requestContext)
        {
            if (requestContext.Request.Headers.TryGetValue("smithy-protocol", out var smithyProtocol)
                && smithyProtocol == "rpc-v2-cbor")
            {
                requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.PROTOCOL_RPC_V2_CBOR);
            }

            var accountIdMode = requestContext.ClientConfig.AccountIdEndpointMode;
            if (accountIdMode == AccountIdEndpointMode.DISABLED)
                requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.ACCOUNT_ID_MODE_DISABLED);
            else if (accountIdMode == AccountIdEndpointMode.PREFERRED)
                requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.ACCOUNT_ID_MODE_PREFERRED);
            else if (accountIdMode == AccountIdEndpointMode.REQUIRED)
                requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.ACCOUNT_ID_MODE_REQUIRED);

            requestContext.UserAgentDetails.AddUserAgentComponent(InternalSDKUtils.ReplaceInvalidUserAgentCharacters(requestContext.ClientConfig.UserAgent));

            var clientAppId = requestContext.ClientConfig.ClientAppId;
            if (!string.IsNullOrEmpty(clientAppId))
                requestContext.UserAgentDetails.AddUserAgentComponent($"app/{InternalSDKUtils.ReplaceInvalidUserAgentCharacters(clientAppId)}");

            requestContext.UserAgentDetails.AddUserAgentComponent($"md/{(requestContext.IsAsync ? "ClientAsync" : "ClientSync")}");

            requestContext.UserAgentDetails.AddUserAgentComponent($"cfg/init-coll#{(AWSConfigs.InitializeCollections ? '1' : '0')}");

            SetObservabilityFeatureIds(requestContext);
        }

        private static void SetObservabilityFeatureIds(IRequestContext requestContext)
        {
            var config = requestContext.ClientConfig;

            if (!(config.TelemetryProvider.TracerProvider is NoOpTracerProvider))
            {
                requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.OBSERVABILITY_TRACING);

                var tracerType = config.TelemetryProvider.TracerProvider.GetType();
                if (tracerType.Namespace.StartsWith("OpenTelemetry.Instrumentation.AWS"))
                {
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.OBSERVABILITY_OTEL_TRACING);
                }
            }

            if (!(config.TelemetryProvider.MeterProvider is NoOpMeterProvider))
            {
                requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.OBSERVABILITY_METRICS);

                var meterType = config.TelemetryProvider.MeterProvider.GetType();
                if (meterType.Namespace.StartsWith("OpenTelemetry.Instrumentation.AWS"))
                {
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.OBSERVABILITY_OTEL_METRICS);
                }
            }
        }
    }
}
