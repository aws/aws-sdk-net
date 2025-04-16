/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util;
using System;
using System.Net;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Class to manage and cache the correct region for buckets accessed without an explicit region.
    /// </summary>
    public static partial class BucketRegionDetector
    {
        /// <summary>
        /// Detects if the signature is malformed, and the requested bucket is in a Region
        /// different from the Region of the request.
        /// </summary>
        /// <param name="requestedBucketUri"></param>
        /// <param name="serviceException"></param>
        /// <param name="requestContext"></param>
        /// <returns>the correct region if a mismatch was detected, null otherwise</returns>
        internal static string DetectMismatchWithHeadBucketFallback(AmazonS3Uri requestedBucketUri, AmazonServiceException serviceException, IRequestContext requestContext)
        {
            return GetCorrectRegion(requestedBucketUri, serviceException) ??
                CheckRegionAndUpdateCache(requestedBucketUri, GetBucketRegionNoPipeline(requestedBucketUri.Bucket, requestContext));
        }

        /// <summary>
        /// Use a HEAD bucket request to get the region for the given bucket.
        ///
        /// This method creates an AmazonS3Client from the credentials passed in requestContext.
        /// It's critical that the AmazonS3Client is not used to make any requests that will
        /// be routed through the pipeline.
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="requestContext"></param>
        /// <returns>the value of the x-amz-bucket-region header from the response</returns>
        private static string GetBucketRegionNoPipeline(string bucketName, IRequestContext requestContext)
        {
            var headBucketPreSignedUrl = GetHeadBucketPreSignedUrl(bucketName, requestContext);
            using (var s3Client = GetUsEast1ClientFromCredentials(requestContext.ClientConfig.DefaultAWSCredentials))
            {
                var response = AmazonS3HttpUtil.GetHead(s3Client, s3Client.Config, headBucketPreSignedUrl, HeaderKeys.XAmzBucketRegion);
                return response.HeaderValue;
            }
        }
        
    }
}
