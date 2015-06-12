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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.S3.Model;
using System.IO;

using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class AmazonS3PreMarshallHandler : PipelineHandler
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
            ProcessPreRequestHandlers(executionContext);
        }

        private static void ProcessPreRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var config = executionContext.RequestContext.ClientConfig;


            var putObjectRequest = request as PutObjectRequest;
            if (putObjectRequest != null)
            {
                if (putObjectRequest.InputStream != null && !string.IsNullOrEmpty(putObjectRequest.FilePath))
                    throw new ArgumentException("Please specify one of either an InputStream or a FilePath to be PUT as an S3 object.");
                if (!string.IsNullOrEmpty(putObjectRequest.ContentBody) && !string.IsNullOrEmpty(putObjectRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a FilePath or the ContentBody to be PUT as an S3 object.");
                if (putObjectRequest.InputStream != null && !string.IsNullOrEmpty(putObjectRequest.ContentBody))
                    throw new ArgumentException("Please specify one of either an InputStream or the ContentBody to be PUT as an S3 object.");

                if (!putObjectRequest.Headers.IsSetContentType())
                {
                    // Get the extension of the file from the path.
                    // Try the key as well.
                    string ext = null;
                    if (!string.IsNullOrEmpty(putObjectRequest.FilePath))
                        ext = AWSSDKUtils.GetExtension(putObjectRequest.FilePath);
                    if (String.IsNullOrEmpty(ext) && putObjectRequest.IsSetKey())
                    {
                        ext = AWSSDKUtils.GetExtension(putObjectRequest.Key);
                    }
                    if (!String.IsNullOrEmpty(ext))
                    // Use the extension to get the mime-type
                    {
                        putObjectRequest.Headers.ContentType = AmazonS3Util.MimeTypeFromExtension(ext);
                    }
                }

                if (putObjectRequest.InputStream != null)
                {
                    if (putObjectRequest.AutoResetStreamPosition && putObjectRequest.InputStream.CanSeek)
                    {
                        putObjectRequest.InputStream.Seek(0, SeekOrigin.Begin);
                    }
                }

                if (!string.IsNullOrEmpty(putObjectRequest.FilePath))
                {
                    putObjectRequest.SetupForFilePath();
                }
                else if (null == putObjectRequest.InputStream)
                {
                    if (string.IsNullOrEmpty(putObjectRequest.Headers.ContentType))
                        putObjectRequest.Headers.ContentType = "text/plain";

                    var payload = Encoding.UTF8.GetBytes(putObjectRequest.ContentBody ?? "");
                    //putObjectRequest.Headers[AWS4Signer.XAmzContentSha256] 
                    //        = AWSSDKUtils.ToHex(AWS4Signer.ComputeHash(payload), true);
                    putObjectRequest.InputStream = new MemoryStream(payload);
                }
            }

            var putBucketRequest = request as PutBucketRequest;
            if (putBucketRequest != null)
            {
                // UseClientRegion only applies if neither BucketRegionName and BucketRegion are set.
                if (putBucketRequest.UseClientRegion &&
                    !(putBucketRequest.IsSetBucketRegionName() || putBucketRequest.IsSetBucketRegion()))
                {
                    var regionCode = DetermineBucketRegionCode(config);
                    if (regionCode == S3Constants.REGION_US_EAST_1)
                        regionCode = null;
                    else if (regionCode == S3Constants.REGION_EU_WEST_1)
                        regionCode = "EU";

                    putBucketRequest.BucketRegion = regionCode;
                }
            }

            var deleteBucketRequest = request as DeleteBucketRequest;
            if (deleteBucketRequest != null)
            {
                if (deleteBucketRequest.UseClientRegion && !deleteBucketRequest.IsSetBucketRegion())
                {
                    var regionCode = DetermineBucketRegionCode(config);
                    if (regionCode == S3Constants.REGION_US_EAST_1)
                        regionCode = null;
                    //else if (regionCode == S3Constants.REGION_EU_WEST_1)
                    //    regionCode = "EU";

                    if (regionCode != null)
                        deleteBucketRequest.BucketRegion = regionCode;
                }
            }

            var uploadPartRequest = request as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                if (uploadPartRequest.InputStream != null && !string.IsNullOrEmpty(uploadPartRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a InputStream or a FilePath to be PUT as an S3 object.");

                if (uploadPartRequest.IsSetFilePath())
                {
                    uploadPartRequest.SetupForFilePath();
                }
            }

            var initMultipartRequest = request as InitiateMultipartUploadRequest;
            if (initMultipartRequest != null)
            {
                if (!initMultipartRequest.Headers.IsSetContentType())
                {
                    // Get the extension of the object key.
                    string ext = AWSSDKUtils.GetExtension(initMultipartRequest.Key);

                    // Use the extension to get the mime-type
                    if (!String.IsNullOrEmpty(ext))
                    {
                        initMultipartRequest.Headers.ContentType = AmazonS3Util.MimeTypeFromExtension(ext);
                    }
                }
            }
        }

        static string DetermineBucketRegionCode(ClientConfig config)
        {
            if (config.RegionEndpoint != null && string.IsNullOrEmpty(config.ServiceURL))
                return config.RegionEndpoint.SystemName;

            return AWSSDKUtils.DetermineRegion(config.DetermineServiceURL());
        }
    }
}
