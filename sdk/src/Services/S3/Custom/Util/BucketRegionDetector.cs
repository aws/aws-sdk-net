/*******************************************************************************
 *  Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
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
        private const int BucketRegionCacheMaxEntries = 300;
        private const string AuthorizationHeaderMalformedErrorCode = "AuthorizationHeaderMalformed";

        /// <summary>
        /// A cache of BucketName -> RegionEndpoint pairs.
        /// The cache is used to make sure that bucket requests are signed for the correct region,
        /// even when requesting them without an explicit region.
        /// </summary>
        public static LruCache<string, RegionEndpoint> BucketRegionCache { get; private set; }

        static BucketRegionDetector()
        {
            BucketRegionCache = new LruCache<string, RegionEndpoint>(BucketRegionCacheMaxEntries);
        }

        /// <summary>
        /// Detect a bucket region mismatch based on the x-amz-bucket-region header, and the status code provided.
        /// </summary>
        /// <param name="requestedBucketUri"></param>
        /// <param name="headBucketStatusCode"></param>
        /// <param name="xAmzBucketRegionHeaderValue"></param>
        /// <returns></returns>
        internal static string GetCorrectRegion(AmazonS3Uri requestedBucketUri, HttpStatusCode headBucketStatusCode, string xAmzBucketRegionHeaderValue)
        {
            if (xAmzBucketRegionHeaderValue != null && headBucketStatusCode == HttpStatusCode.BadRequest)
            {
                return CheckRegionAndUpdateCache(requestedBucketUri, xAmzBucketRegionHeaderValue);
            }
            return null;
        }

        /// <summary>
        /// Detects if the signature is malformed, and the requested bucket is in a Region
        /// different from the Region of the request.
        /// </summary>
        /// <param name="requestedBucketUri"></param>
        /// <param name="serviceException"></param>
        /// <returns>the correct region if a mismatch was detected, null otherwise</returns>
        private static string GetCorrectRegion(AmazonS3Uri requestedBucketUri, AmazonServiceException serviceException)
        {
            string regionFromExceptionBody = null;
            string regionFromExceptionHeader = null;
            var s3Exception = serviceException as AmazonS3Exception;
            if (s3Exception != null)
            {
                if (string.Equals(s3Exception.ErrorCode, AuthorizationHeaderMalformedErrorCode, StringComparison.Ordinal))
                {
                    regionFromExceptionBody = CheckRegionAndUpdateCache(requestedBucketUri, s3Exception.Region);
                }

                if (regionFromExceptionBody == null)
                {
                    var innerException = s3Exception.InnerException as HttpErrorResponseException;
                    if (innerException != null && innerException.Response != null && innerException.Response.IsHeaderPresent(HeaderKeys.XAmzBucketRegion))
                    {
                        regionFromExceptionHeader = CheckRegionAndUpdateCache(requestedBucketUri, innerException.Response.GetHeaderValue(HeaderKeys.XAmzBucketRegion));
                    }
                }
            }
            return regionFromExceptionBody ?? regionFromExceptionHeader;
        }

        private static string CheckRegionAndUpdateCache(AmazonS3Uri requestedBucketUri, string actualRegion)
        {
            var requestedRegion = requestedBucketUri.Region == null ? null : requestedBucketUri.Region.SystemName;

            if (actualRegion != null && !string.Equals(requestedRegion, actualRegion, StringComparison.Ordinal))
            {
                BucketRegionCache.AddOrUpdate(requestedBucketUri.Bucket, RegionEndpoint.GetBySystemName(actualRegion));
                return actualRegion;
            }
            return null;
        }

        private static string GetHeadBucketPreSignedUrl(string bucketName, ImmutableCredentials credentials)
        {
            // all buckets accessible via USEast1
            using (var s3Client = GetUsEast1ClientFromCredentials(credentials))
            {
                // IMPORTANT:
                // This method is called as part of the request pipeline.
                // If the pipeline were to be invoked here it would cause
                // unwanted recursion.
                // As such, the only reason it's OK to use an S3Client here
                // is because this code is using a method that doesn't go
                // through the request pipeline: GetPreSignedURLInternal
                var request = new GetPreSignedUrlRequest
                {
                    BucketName = bucketName,
                    Expires = s3Client.Config.CorrectedUtcNow.ToLocalTime().AddDays(1),
                    Verb = HttpVerb.HEAD,
                    Protocol = Protocol.HTTP
                };

                return s3Client.GetPreSignedURLInternal(request, false);
            }
        }

        private static AmazonS3Client GetUsEast1ClientFromCredentials(ImmutableCredentials credentials)
        {
            if (credentials.UseToken)
            {
                return new AmazonS3Client(credentials.AccessKey, credentials.SecretKey, credentials.Token, RegionEndpoint.USEast1);
            }
            else
            {
                return new AmazonS3Client(credentials.AccessKey, credentials.SecretKey, RegionEndpoint.USEast1);
            }
        }
    }
}
