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

            var bucketResourcePathToken = GetBucketName(request.ResourcePath);
            if (string.IsNullOrEmpty(bucketResourcePathToken))
                return;

            var s3Config = config as AmazonS3Config;
            if (s3Config == null)
                throw new AmazonClientException("Current config object is not of type AmazonS3Config");

            bool isHttp;
            bool removeBucketFromResourcePath = false;

            if (Arn.IsArn(bucketResourcePathToken))
            {
                string accessPoint;
                Arn accessPointArn;
                if ((accessPointArn = Arn.Parse(bucketResourcePathToken)).TryParseAccessPoint(out accessPoint))
                {
                    if (!string.IsNullOrEmpty(config.ServiceURL))
                    {
                        throw new AmazonClientException(
                                    "The request is using an access point ARN for the bucket name and the S3 service client is configured to use a specific host using the ServiceURL property. " +
                                    "Access point ARNs define the host for the request which makes it incompatible with the host being set ServiceURL. " +
                                    "When using access point arns set the region and not the ServiceURL for the S3 service client.");
                    }
                    if (s3Config.UseAccelerateEndpoint)
                    {
                        throw new AmazonClientException(
                                    "The request is using an access point ARN for the bucket name and the S3 service client is configured to use accelerate endpoints which is not supported. " +
                                    "To use this access point create a new S3 service client with the UseAccelerateEndpoint property set to false."
                            );
                    }
                    if(string.IsNullOrEmpty(accessPointArn.AccountId))
                    {
                        throw new AmazonClientException("Account ID is missing in access point ARN");
                    }
                    if (string.IsNullOrEmpty(accessPointArn.Region))
                    {
                        throw new AmazonClientException("AWS region is missing in access point ARN");
                    }


                    if (!string.Equals(config.RegionEndpoint.PartitionName, accessPointArn.Partition, StringComparison.Ordinal))
                    {
                        throw new AmazonClientException("The access point used in the request is in a different AWS partition then the region configured for the AmazonS3Client.");
                    }

                    ValidateUseArnRegion(accessPointArn, s3Config);

                    request.UseSigV4 = true;
                    isHttp = config.UseHttp;

                    removeBucketFromResourcePath = true;

                    var scheme = isHttp ? "http" : "https";

                    UriBuilder ub = new UriBuilder($"{scheme}://{accessPoint}-{accessPointArn.AccountId}.s3-accesspoint{(config.UseDualstackEndpoint ? ".dualstack" : "")}.{accessPointArn.Region}.{config.RegionEndpoint.PartitionDnsSuffix}");
                    request.Endpoint = ub.Uri;

                    // The access point arn can be using a region different from the configured region for the service client.
                    // If so be sure to set the authentication region so the signer will use the correct region.
                    request.AuthenticationRegion = accessPointArn.Region;
                }
                else
                {
                    throw new AmazonClientException("Invalid ARN specified for bucket name. Only access point ARNs are allowed for the value of bucket name.");
                }
            }
            else
            {
                // If path style is not forced and the bucket name is DNS
                // compatible modify the endpoint to use virtual host style
                // addressing
                var bucketIsDnsCompatible = IsDnsCompatibleBucketName(bucketResourcePathToken);
                var ub = new UriBuilder(EndpointResolver.DetermineEndpoint(s3Config, request));
                isHttp = string.Equals(ub.Scheme, "http", StringComparison.OrdinalIgnoreCase);

                if (!s3Config.ForcePathStyle && bucketIsDnsCompatible)
                {
                    // If using HTTPS, bucketName cannot contain a period
                    if (isHttp || bucketResourcePathToken.IndexOf('.') < 0)
                    {
                        // Add bucket to host
                        ub.Host = string.Concat(bucketResourcePathToken, ".", ub.Host);
                        request.Endpoint = ub.Uri;
                        removeBucketFromResourcePath = true;
                    }
                }

                if (s3Config.UseAccelerateEndpoint)
                {
                    // Validate if bucket name is accelerate compatible and enable acceleration by using
                    // Accelerate endpoint for this request

                    if (!bucketIsDnsCompatible || BucketNameContainsPeriod(bucketResourcePathToken))
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
                        request.Endpoint = GetAccelerateEndpoint(bucketResourcePathToken, s3Config);

                        if (request.UseSigV4 && s3Config.RegionEndpoint != null)
                        {
                            request.AlternateEndpoint = s3Config.RegionEndpoint;
                        }
                    }
                }
            }

            if (removeBucketFromResourcePath)
            {
                // Remove bucket from resource path but retain in canonical resource
                // prefix, so it gets included when we sign the request later
                var resourcePath = request.ResourcePath;
                var canonicalBucketName = string.Concat("/", bucketResourcePathToken);
                if (resourcePath.IndexOf(canonicalBucketName, StringComparison.Ordinal) == 0)
                {
                    resourcePath = resourcePath.Substring(canonicalBucketName.Length);
                }

                request.ResourcePath = resourcePath;
                request.CanonicalResourcePrefix = canonicalBucketName;
            }


            // Some parameters should not be sent over HTTP, just HTTPS
            if (isHttp)
            {
                ValidateHttpsOnlyHeaders(request);
            }
        }

        private static Uri GetAccelerateEndpoint(string bucketName, AmazonS3Config config)
        {
            var url = new Uri(string.Format(CultureInfo.InvariantCulture, "{0}{1}.{2}", 
                config.UseHttp ? "http://" : "https://", 
                bucketName,
                config.AccelerateEndpoint));
            return url;
        }

        private static void ValidateUseArnRegion(Arn arn, AmazonS3Config config)
        {
            if(string.Equals(arn.Region, config.RegionEndpoint.SystemName, StringComparison.Ordinal))
            {
                return;
            }

            if(!config.UseArnRegion)
            {
                throw new AmazonClientException(
                    $"The S3 service client is configured for region {config.RegionEndpoint.SystemName} but the access point is in {arn.Region}. " +
                    "By default the SDK doesn't allow cross region calls. If you want to enable cross region calls set the environment AWS_S3_USE_ARN_REGION or the AmazonS3Config.UseArnRegion property to value \"true\".");
            }
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
            var parts = resourcePath.Split(separators);
            var bucketName = parts[0];

            // Check to see if the bucket name is an arn using a '/' to break up the access point prefix and identifier.
            // If it is then bucketName will currently be missing the resource identifier which is the next token in the split.
            //
            // For example a resource path using an arn to get an object will look like this:
            // arn:aws:s3:us-west-2:12345689:accesspoint/mybucket/myobject.txt.
            // We need this method to return "arn:aws:s3:us-west-2:12345689:accesspoint/mybucket" but by splitting on "/"
            // only "arn:aws:s3:us-west-2:12345689:accesspoint" is captured. This if block checks to see it is the resource path has an access point arn and then
            // grab the bucket name which is the next token in the split.
            if (Arn.IsArn(bucketName) && bucketName.EndsWith(ArnExtensions.ResourceTypeAccessPoint))
            {
                bucketName += "/" + parts[1];
            }

            return bucketName;
        }

#if BCL || NETSTANDARD
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

#if BCL || NETSTANDARD
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
