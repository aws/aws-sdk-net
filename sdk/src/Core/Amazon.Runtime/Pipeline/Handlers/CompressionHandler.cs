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
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Compression;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Internal.UserAgent;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler manages the compression of the payload request when compression is supported
    /// by its service operation.
    /// </summary>
    public class CompressionHandler : PipelineHandler
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
        /// Handles the logic of compressing the payload of a request.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// request and response context.</param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var clientConfig = executionContext.RequestContext.ClientConfig;
            var minCompressionSize = clientConfig.RequestMinCompressionSizeBytes;
            var disableRequestCompression = clientConfig.DisableRequestCompression;
            var request = executionContext.RequestContext.Request;

            if (disableRequestCompression || request.CompressionAlgorithm == CompressionEncodingAlgorithm.NONE)
            {
                return;
            }

            switch (request.CompressionAlgorithm)
            {
                case CompressionEncodingAlgorithm.gzip:
                    executionContext.RequestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.GZIP_REQUEST_COMPRESSION);
                    break;
                default:
                    break;
            }

            var compressionAlgorithm = CompressionFactory.GetCompressionAlgorithm(request.CompressionAlgorithm);
            if (request.ContentStream != null)
            {
                request.ContentStream = new CompressionWrapperStream(request.ContentStream, compressionAlgorithm);
                CompressionAlgorithmUtils.SetRequestHeader(request, compressionAlgorithm.AlgorithmId);
                // Compressing a stream should always be done in chunks, and the request must not contain a header for ContentLengthHeader
                request.Headers[HeaderKeys.TransferEncodingHeader] = "chunked";
                request.Headers.Remove(HeaderKeys.ContentLengthHeader);
            }
            else
            {
                var input = AWSSDKUtils.GetRequestPayloadBytes(request);
                if (input.Length >= minCompressionSize)
                {
                    executionContext.RequestContext.Metrics.AddProperty(Metric.UncompressedRequestSize, input.Length);
                    using (TracingUtilities.CreateSpan(executionContext.RequestContext, TelemetryConstants.RequestCompressionSpanName))
                    using (executionContext.RequestContext.Metrics.StartEvent(Metric.RequestCompressionTime))
                    {
                        request.Content = compressionAlgorithm.Compress(input);
                    }
                    CompressionAlgorithmUtils.SetRequestHeader(request, compressionAlgorithm.AlgorithmId);
                }
            }
        }
    }
}