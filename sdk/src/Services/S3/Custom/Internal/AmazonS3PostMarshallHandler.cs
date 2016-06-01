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
using Amazon.S3;
using System.Text.RegularExpressions;
using Amazon.Util;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class AmazonS3PostMarshallHandler : PipelineHandler
    {
        private static HashSet<Type> UnsupportedAccelerateRequestTypes = new HashSet<Type>
        {
           typeof(ListBucketsRequest),
           typeof(PutBucketRequest),
           typeof(DeleteBucketRequest),
           typeof(CopyObjectRequest),
           typeof(CopyPartRequest)
        };

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
            ProcessRequestHandlers(executionContext);
        }

        public static void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var config = executionContext.RequestContext.ClientConfig;

            // If the marshalled request has the SSE header and it is set to KMS,
            // force SigV4 for this request.
            // Current operations that may set this header:
            //  CopyObject, CopyPart, InitiateMultipart, PutObject
            string sseHeaderValue;
            if (request.Headers.TryGetValue(HeaderKeys.XAmzServerSideEncryptionHeader, out sseHeaderValue) &&
                string.Equals(sseHeaderValue, ServerSideEncryptionMethod.AWSKMS.Value, StringComparison.Ordinal))
            {
                    request.UseSigV4 = true;
            }

            var bucketName = GetBucketName(request.ResourcePath);
            if (string.IsNullOrEmpty(bucketName))
                return;

            var s3Config = config as AmazonS3Config;
            if (s3Config == null)
                throw new AmazonClientException("Current config object is not of type AmazonS3Config");

            // If path style is not forced and the bucket name is DNS
            // compatible modify the endpoint to use virtual host style
            // addressing
            var bucketIsDnsCompatible = IsDnsCompatibleBucketName(bucketName);
            var ub = new UriBuilder(EndpointResolver.DetermineEndpoint(s3Config, request));
            var isHttp = string.Equals(ub.Scheme, "http", StringComparison.OrdinalIgnoreCase);

            if (!s3Config.ForcePathStyle && bucketIsDnsCompatible)
            {
                // If using HTTPS, bucketName cannot contain a period
                if (isHttp || bucketName.IndexOf('.') < 0)
                {
                    // Add bucket to host
                    ub.Host = string.Concat(bucketName, ".", ub.Host);
                    request.Endpoint = ub.Uri;

                    // Remove bucket from resource path but retain in canonical resource
                    // prefix, so it gets included when we sign the request later
                    var resourcePath = request.ResourcePath;
                    var canonicalBucketName = string.Concat("/", bucketName);
                    if (resourcePath.IndexOf(canonicalBucketName, StringComparison.Ordinal) == 0)
                        resourcePath = resourcePath.Substring(canonicalBucketName.Length);
                    request.ResourcePath = resourcePath;

                    request.CanonicalResourcePrefix = canonicalBucketName;
                }
            }
                        
            if (s3Config.UseAccelerateEndpoint)
            {
                // Validate if bucket name is accelerate compatible and enable acceleration by using
                // Accelerate endpoint for this request

                if (!bucketIsDnsCompatible || BucketNameContainsPeriod(bucketName))
                {
                    throw new AmazonClientException(
                        @"S3 accelerate is enabled for this request but the bucket name is not accelerate compatible." +
                          " The bucket name must be DNS compatible (http://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html)" +
                          " and must not contain any period (.) characters to be accelerate compatible.");
                }

                var originalRequest = request.OriginalRequest;
                bool accelerateSupportedApi = !UnsupportedAccelerateRequestTypes.Contains(originalRequest.GetType());

                // Skip requests which are not supported                 
                if (accelerateSupportedApi)
                {
                    request.Endpoint = GetAccelerateEndpoint(bucketName, config.UseHttp);

                    if (request.UseSigV4 && s3Config.RegionEndpoint != null)
                    {
                        request.AlternateEndpoint = s3Config.RegionEndpoint;
                    }                    
                }
            }

            // Some parameters should not be sent over HTTP, just HTTPS
            if (isHttp)
            {
                ValidateHttpsOnlyHeaders(request);
            }
        }

        private static Uri GetAccelerateEndpoint(string bucketName, bool useHttp)
        {
            var url = new Uri(string.Format(CultureInfo.InvariantCulture, "{0}{1}.{2}", 
                useHttp ? "http://" : "https://", 
                bucketName,
                AmazonS3Config.AccelerateEndpoint));
            return url;
        }

        private static void ValidateHttpsOnlyHeaders(IRequest request)
        {
            ValidateSseKeyHeaders(request);
            ValidateSseHeaderValue(request);
        }
        private static void ValidateSseHeaderValue(IRequest request)
        {
            string sseHeaderValue;
            if (request.Headers.TryGetValue(HeaderKeys.XAmzServerSideEncryptionHeader, out sseHeaderValue) &&
                string.Equals(sseHeaderValue, ServerSideEncryptionMethod.AWSKMS))
            {
                throw new AmazonClientException("Request specifying Server Side Encryption with AWS KMS managed keys can only be transmitted over HTTPS");
            }
        }
        private static void ValidateSseKeyHeaders(IRequest request)
        {
            var foundHttpsOnlyHeaders = request.Headers
                .Where(kvp => !string.IsNullOrEmpty(kvp.Value) && sseKeyHeaders.Contains(kvp.Key))
                .Select(kvp => kvp.Key)
                .ToArray();
            if (foundHttpsOnlyHeaders.Length > 0)
            {
                string message = string.Format(CultureInfo.InvariantCulture,
                    "Request contains headers which can only be transmitted over HTTPS: {0}",
                    string.Join(", ", foundHttpsOnlyHeaders));
                throw new AmazonClientException(message);
            }
        }

        private static HashSet<string> sseKeyHeaders = new HashSet<string>
        {
            HeaderKeys.XAmzSSECustomerKeyHeader,
            HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader
        };

        private static char[] separators = new char[] { '/', '?' };
        // Gets the bucket name from resource path
        internal static string GetBucketName(string resourcePath)
        {
            resourcePath = resourcePath.Trim().Trim(separators);
            var parts = resourcePath.Split(separators, 2);
            var bucketName = parts[0];
            return bucketName;
        }

#if BCL
        private static Regex bucketValidationRegex = new Regex(@"^[A-Za-z0-9._\-]+$", RegexOptions.Compiled);
#else
        private static Regex bucketValidationRegex = new Regex(@"^[A-Za-z0-9._\-]+$");
#endif
        // Returns true if the bucket name is valid
        public static bool IsValidBucketName(string bucketName)
        {
            // Check if bucket is null/empty string
            if (string.IsNullOrEmpty(bucketName))
                return false;

            // Check if the bucket name is between 3 and 255 characters
            if (bucketName.Length < 3 || bucketName.Length > 255)
                return false;

            // Check if the bucket contains a newline character
            if (bucketName.IndexOf('\n') >= 0)
                return false;

            // Check if bucket only contains:
            //  uppercase letters, lowercase letters, numbers
            //  periods (.), underscores (_), dashes (-)
            if (!bucketValidationRegex.IsMatch(bucketName))
                return false;

            return true;
        }

#if BCL
        private static Regex dnsValidationRegex1 = new Regex(@"^[a-z0-9][a-z0-9.-]+[a-z0-9]$", RegexOptions.Compiled);
        private static Regex dnsValidationRegex2 = new Regex("(\\d+\\.){3}\\d+", RegexOptions.Compiled);
#else
        private static Regex dnsValidationRegex1 = new Regex(@"^[a-z0-9][a-z0-9.-]+[a-z0-9]$");
        private static Regex dnsValidationRegex2 = new Regex("(\\d+\\.){3}\\d+");
#endif
        private static string[] invalidPatterns = new string[] { "..", "-.", ".-" };
        // Returns true if the given bucket name is DNS compatible
        // DNS compatible bucket names may be accessed like:
        //     http://dns.compat.bucket.name.s3.amazonaws.com/
        // Whereas non-dns compatible bucket names must place the bucket name in the url path, like:
        //     http://s3.amazonaws.com/dns_incompat_bucket_name/
        public static bool IsDnsCompatibleBucketName(string bucketName)
        {
            // Check basic validation
            if (!IsValidBucketName(bucketName))
                return false;

            // Bucket names should between 3 and 63 characters
            if (bucketName.Length > 63)
                return false;

            // Bucket names must only contain lowercase letters, numbers, dots, and dashes
            // and must start and end with a lowercase letter or a number
            if (!dnsValidationRegex1.IsMatch(bucketName))
                return false;

            // Bucket names should not be formatted like an IP address (e.g., 192.168.5.4)
            if (dnsValidationRegex2.IsMatch(bucketName))
                return false;

            // Bucket names cannot contain two adjacent periods or dashes next to periods
            if (StringContainsAny(bucketName, invalidPatterns, StringComparison.Ordinal))
                return false;

            return true;
        }

        
        public static bool BucketNameContainsPeriod(string bucketName)
        {
            return bucketName.IndexOf(".", StringComparison.Ordinal) >= 0;
        }

        // Returns true if string toCheck contains any of strings in values
        private static bool StringContainsAny(string toCheck, string[] values, StringComparison stringComparison)
        {
            foreach (var value in values)
            {
                if (toCheck.IndexOf(value, stringComparison) >= 0)
                    return true;
            }
            return false;
        }
    }
}
