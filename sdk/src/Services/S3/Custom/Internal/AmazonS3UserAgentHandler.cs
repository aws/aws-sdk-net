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
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Adds information on which checksum was used for the request made to S3.
    /// </summary>
    /// <remarks>
    /// This handler is a temporary solution until the SDK implements tracking feature IDs centrally.
    /// </remarks>
    public class AmazonS3UserAgentHandler : PipelineHandler
    {
        #region Feature ID constants

        /// <summary>
        /// Operation included a CRC-32 checksum for request payload
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_REQ_CRC32 = "U";

        /// <summary>
        /// Operation included a CRC-32C checksum for request payload
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_REQ_CRC32C = "V";

        /// <summary>
        /// Operation included a CRC-64 checksum for request payload
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_REQ_CRC64 = "W";

        /// <summary>
        /// Operation included a SHA-1 checksum for request payload
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_REQ_SHA1 = "X";

        /// <summary>
        /// Operation included a SHA-256 checksum for request payload
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_REQ_SHA256 = "Y";

        /// <summary>
        /// SDK resolved configuration <c>RequestChecksumCalculation</c> == <c>WHEN_SUPPORTED</c>
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_REQ_WHEN_SUPPORTED = "Z";

        /// <summary>
        /// SDK resolved configuration <c>RequestChecksumCalculation</c> == <c>WHEN_REQUIRED</c>
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_REQ_WHEN_REQUIRED = "a";

        /// <summary>
        /// SDK resolved configuration <c>ResponseChecksumValidation</c> == <c>WHEN_SUPPORTED</c>
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_RES_WHEN_SUPPORTED = "b";

        /// <summary>
        /// SDK resolved configuration <c>ResponseChecksumValidation</c> == <c>WHEN_REQUIRED</c>
        /// </summary>
        private const string FLEXIBLE_CHECKSUMS_RES_WHEN_REQUIRED = "c";

        #endregion

        public override void InvokeSync(IExecutionContext executionContext)
        {
            InternalInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

#if AWS_ASYNC_API

        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            InternalInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);
        }

#elif AWS_APM_API
        
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            InternalInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }

#endif

        private void InternalInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var config = executionContext.RequestContext.ClientConfig;
            var features = new List<string>();

            switch (request.SelectedChecksum)
            {
                case CoreChecksumAlgorithm.CRC32C:
                    features.Add(FLEXIBLE_CHECKSUMS_REQ_CRC32C);
                    break;
                case CoreChecksumAlgorithm.CRC32:
                    features.Add(FLEXIBLE_CHECKSUMS_REQ_CRC32);
                    break;
                case CoreChecksumAlgorithm.CRC64NVME:
                    features.Add(FLEXIBLE_CHECKSUMS_REQ_CRC64);
                    break;
                case CoreChecksumAlgorithm.SHA256:
                    features.Add(FLEXIBLE_CHECKSUMS_REQ_SHA256);
                    break;
                case CoreChecksumAlgorithm.SHA1:
                    features.Add(FLEXIBLE_CHECKSUMS_REQ_SHA1);
                    break;
                case CoreChecksumAlgorithm.NONE:
                default:
                    break;
            }

            switch (config.RequestChecksumCalculation)
            {
                case RequestChecksumCalculation.WHEN_SUPPORTED:
                    features.Add(FLEXIBLE_CHECKSUMS_REQ_WHEN_SUPPORTED);
                    break;
                case RequestChecksumCalculation.WHEN_REQUIRED:
                    features.Add(FLEXIBLE_CHECKSUMS_REQ_WHEN_REQUIRED);
                    break;
            }

            switch (config.ResponseChecksumValidation)
            {
                case ResponseChecksumValidation.WHEN_SUPPORTED:
                    features.Add(FLEXIBLE_CHECKSUMS_RES_WHEN_SUPPORTED);
                    break;
                case ResponseChecksumValidation.WHEN_REQUIRED:
                    features.Add(FLEXIBLE_CHECKSUMS_RES_WHEN_REQUIRED);
                    break;
            }

            var userAgentAddition = new StringBuilder(" m/").Append(string.Join(",", features.ToArray()));
            var currentUserAgent = request.Headers[AWSSDKUtils.UserAgentHeader];
            request.Headers[AWSSDKUtils.UserAgentHeader] = currentUserAgent + userAgentAddition.ToString();
        }
    }
}
