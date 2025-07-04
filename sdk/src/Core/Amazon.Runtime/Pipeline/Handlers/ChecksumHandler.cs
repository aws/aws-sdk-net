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

using Amazon.Runtime.Internal.UserAgent;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler manages the calculation of the checksum of the payload request when the checksum of a request is supported.
    /// It also sets the checksum header of the request.
    /// </summary>
    public class ChecksumHandler : PipelineHandler
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
        /// Calculates the checksum of the payload of a request, and sets the checksum request header only once.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the request and response context.</param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var request = executionContext.RequestContext.Request;
            var clientConfig = executionContext.RequestContext.ClientConfig;

            // Credentials would be null in the case of anonymous users getting public resources from S3
            // https://github.com/aws/aws-sdk-net/issues/3696
            if (executionContext.RequestContext.Identity is AnonymousAWSCredentials && executionContext.RequestContext.Signer.RequiresCredentials)
            {
                return;
            }

            if (request.ChecksumData == null)
            {
                return;
            }
            
            if (request.ChecksumData.IsMD5Checksum)
            {
                ChecksumUtils.SetRequestChecksumMD5(request);
                return;
            }

            ChecksumUtils.SetRequestChecksumV2(request, clientConfig);

            switch (request.SelectedChecksum)
            {
                case CoreChecksumAlgorithm.CRC32C:
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_REQ_CRC32C);
                    break;
                case CoreChecksumAlgorithm.CRC32:
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_REQ_CRC32);
                    break;
                case CoreChecksumAlgorithm.SHA256:
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_REQ_SHA256);
                    break;
                case CoreChecksumAlgorithm.SHA1:
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_REQ_SHA1);
                    break;
                case CoreChecksumAlgorithm.CRC64NVME:
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_REQ_CRC64);
                    break;
            }

            switch (clientConfig.RequestChecksumCalculation)
            {
                case RequestChecksumCalculation.WHEN_SUPPORTED:
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_REQ_WHEN_SUPPORTED);
                    break;
                case RequestChecksumCalculation.WHEN_REQUIRED:
                    requestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.FLEXIBLE_CHECKSUMS_REQ_WHEN_REQUIRED);
                    break;
            }
        }
    }
}
