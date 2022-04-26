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

using Amazon.EventBridge.Model;
using Amazon.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;

#pragma warning disable 1591

namespace Amazon.EventBridge.Internal
{
    public class AmazonEventBridgePostMarshallHandler : PipelineHandler
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
            if (executionContext.RequestContext.Request.OriginalRequest.GetType() != typeof(PutEventsRequest))
            {
                return;
            }

            var request = executionContext.RequestContext.Request;
            var config = executionContext.RequestContext.ClientConfig;
            var originalRequest = request.OriginalRequest as PutEventsRequest;

            if (originalRequest.EndpointId == null)
            {
                return;
            }

            ValidateEndpointId(originalRequest.EndpointId);

            if (config.ServiceURL != null)
            {
                // Override endpoint (via ServiceURL) and EndpointId is set use case
                SetupSigV4aSigningRequest(request);
                return;
            }

            if (config.UseFIPSEndpoint)
            {
                throw new AmazonClientException("FIPS is not supported with EventBridge multi-region endpoints");
            }

            SetupSigV4aSigningRequest(request);

            var dnsSuffix = config.DetermineDnsSuffix();
            var scheme = config.UseHttp ? "http" : "https";
            var newEndpoint = new Uri($"{scheme}://{originalRequest.EndpointId}.endpoint.events.{dnsSuffix}");

            request.Endpoint = newEndpoint;
        }

        private void ValidateEndpointId(string endpointId)
        {
            if (endpointId.Length == 0)
            {
                throw new AmazonClientException("EndpointId must not be a zero length string");
            }

            if (Uri.CheckHostName(endpointId) == UriHostNameType.Unknown)
            {
                throw new AmazonClientException("EndpointId is not a valid hostname component");
            }
        }

        private void SetupSigV4aSigningRequest(IRequest request)
        {
            request.SignatureVersion = SignatureVersion.SigV4a;
            request.AuthenticationRegion = "*";
            request.Headers.Add(Util.HeaderKeys.XAmzRegionSetHeader, "*");
        }
    }
}
