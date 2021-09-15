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
        private const string s3ObjectLambdaServiceName = "s3-object-lambda";
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
                request.SignatureVersion = SignatureVersion.SigV4;
            }
            var bucketResourcePathToken = GetBucketName(request.ResourcePath);
            if (string.IsNullOrEmpty(bucketResourcePathToken))
                return;

            var s3Config = config as AmazonS3Config;
            if (s3Config == null)
                throw new AmazonClientException("Current config object is not of type AmazonS3Config");

            //If a ServiceURL is set the config ClientRegion should be null. Under this case
            //the region needs to be determined from the ServiceURL.          
            var regionEndpoint = config.RegionEndpoint;
            if (regionEndpoint == null && !string.IsNullOrEmpty(config.ServiceURL))
            {
                var regionName = AWSSDKUtils.DetermineRegion(config.ServiceURL);
                regionEndpoint = RegionEndpoint.GetBySystemName(regionName);
            }

            bool isHttp;
            bool removeBucketFromResourcePath = false;

            if (Arn.IsArn(bucketResourcePathToken))
            {
                string accessPoint;
                UriBuilder ub;
                Arn s3Arn = Arn.Parse(bucketResourcePathToken);
                if (s3Arn.IsService("s3") && s3Arn.TryParseAccessPoint(out accessPoint))
                {
                    if (s3Arn.IsMRAPArn())
                    {
                        var partitionDnsSuffix = RegionEndpoint.GetDnsSuffixForPartition(s3Arn.Partition);
                        ValidateMRAPAccessPoint(s3Arn, s3Config, accessPoint, partitionDnsSuffix);

                        request.SignatureVersion = SignatureVersion.SigV4a;
                        request.AuthenticationRegion = "*";

                        isHttp = config.UseHttp;
                        var scheme = isHttp ? "http" : "https";
                        ub = new UriBuilder($"{scheme}://{accessPoint}.accesspoint.s3-global.{partitionDnsSuffix}");
                    }
                    else // Non-MRAP access point
                    {
                        ValidateS3AccessPoint(s3Arn, s3Config, regionEndpoint);
                        if (!string.IsNullOrEmpty(config.ServiceURL))
                        {
                            ub = new UriBuilder(EndpointResolver.DetermineEndpoint(s3Config, request));
                            isHttp = string.Equals(ub.Scheme, "http", StringComparison.OrdinalIgnoreCase);
                            ub.Host = string.Concat($"{accessPoint}-{s3Arn.AccountId}.", ub.Host);
                        }
                        else
                        {
                            isHttp = config.UseHttp;
                            var scheme = isHttp ? "http" : "https";
                            var fipsSuffix = regionEndpoint?.SystemName?.ToLower().Contains("fips") == true ? "-fips" : "";
                            ub = new UriBuilder($"{scheme}://{accessPoint}-{s3Arn.AccountId}.s3-accesspoint{fipsSuffix}{(config.UseDualstackEndpoint ? ".dualstack" : "")}.{s3Arn.Region}.{config.RegionEndpoint.PartitionDnsSuffix}");
                        }
                    }
                    
                    request.Endpoint = ub.Uri;
                }
                else if (s3Arn.IsService(s3ObjectLambdaServiceName) && s3Arn.TryParseAccessPoint(out accessPoint))
                {
                    ValidateS3ObjectLambdaAccessPoint(s3Arn, s3Config, regionEndpoint);

                    if (!string.IsNullOrEmpty(config.ServiceURL))
                    {
                        ub = new UriBuilder(EndpointResolver.DetermineEndpoint(s3Config, request));
                        isHttp = string.Equals(ub.Scheme, "http", StringComparison.OrdinalIgnoreCase);
                        ub.Host = string.Concat($"{accessPoint}-{s3Arn.AccountId}.", ub.Host);
                    }
                    else
                    {
                        isHttp = s3Config.UseHttp;
                        var scheme = isHttp ? "http" : "https";
                        var fipsSuffix = regionEndpoint?.SystemName?.ToLower().Contains("fips") == true ? "-fips" : "";
                        ub = new UriBuilder($"{scheme}://{accessPoint}-{s3Arn.AccountId}.{s3ObjectLambdaServiceName}{fipsSuffix}.{s3Arn.Region}.{config.RegionEndpoint.PartitionDnsSuffix}");
                    }

                    request.Endpoint = ub.Uri;
                }
                else if (s3Arn.IsOutpostArn())
                {
                    var outpost = s3Arn.ParseOutpost();
                    ValidateOutpostAccessPoint(s3Arn, s3Config, regionEndpoint);
                    var region = s3Config.UseArnRegion ? s3Arn.Region : regionEndpoint.SystemName;
                    bucketResourcePathToken = outpost.FullAccessPointName;

                    if (!string.IsNullOrEmpty(config.ServiceURL))
                    {
                        ub = new UriBuilder(EndpointResolver.DetermineEndpoint(s3Config, request));
                        isHttp = string.Equals(ub.Scheme, "http", StringComparison.OrdinalIgnoreCase);
                        ub.Host = string.Concat($"{outpost.AccessPointName}-{s3Arn.AccountId}.{outpost.OutpostId}.", ub.Host);
                    }
                    else
                    {
                        isHttp = config.UseHttp;
                        var scheme = isHttp ? "http" : "https";
                        ub = new UriBuilder($"{scheme}://{outpost.AccessPointName}-{s3Arn.AccountId}.{outpost.OutpostId}.s3-outposts.{region}.{config.RegionEndpoint.PartitionDnsSuffix}");
                    }

                    request.Endpoint = ub.Uri;
                }
                else
                {
                    throw new AmazonClientException("Invalid ARN specified for bucket name. Only access point ARNs are allowed for the value of bucket name.");
                }
                request.OverrideSigningServiceName = s3Arn.Service;
                // The access point arn can be using a region different from the configured region for the service client.
                // If so be sure to set the authentication region so the signer will use the correct region.
                if (!s3Arn.IsMRAPArn())    // Except for MRAP where signing region and ARN region diverge
                {
                    request.AuthenticationRegion = s3Arn.Region;
                    request.SignatureVersion = SignatureVersion.SigV4;
                }

                removeBucketFromResourcePath = true;
            }
            else // not an arn
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

                if (request.OriginalRequest.GetType() == typeof(WriteGetObjectResponseRequest))
                {
                    if (!string.IsNullOrEmpty(config.ServiceURL))
                    {
                        ub = new UriBuilder(EndpointResolver.DetermineEndpoint(s3Config, request));
                        isHttp = string.Equals(ub.Scheme, "http", StringComparison.OrdinalIgnoreCase);
                    }
                    else
                    {
                        isHttp = s3Config.UseHttp;
                        var scheme = isHttp ? "http" : "https";
                        var region = regionEndpoint.SystemName == "us-east-1-regional" ? "us-east-1" : regionEndpoint.SystemName;
                        ub = new UriBuilder($"{scheme}://{request.Headers["x-amz-request-route"]}.{s3ObjectLambdaServiceName}.{region}.{config.RegionEndpoint.PartitionDnsSuffix}");
                    }

                    request.Endpoint = ub.Uri;
                    request.OverrideSigningServiceName = s3ObjectLambdaServiceName;
                    request.SignatureVersion = SignatureVersion.SigV4;
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

                        if (request.SignatureVersion == SignatureVersion.SigV4 && s3Config.RegionEndpoint != null)
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

        private static void ValidateS3AccessPoint(Arn s3Arn, AmazonS3Config s3Config, RegionEndpoint region)
        {
            if (s3Config.UseAccelerateEndpoint)
            {
                throw new AmazonClientException(
                            "The request is using an access point ARN for the bucket name and the S3 service client is configured to use accelerate endpoints which is not supported. " +
                            "To use this access point create a new S3 service client with the UseAccelerateEndpoint property set to false."
                    );
            }
            if (!s3Arn.HasValidAccountId())
            {
                throw new AmazonAccountIdException();
            }
            if (string.IsNullOrEmpty(s3Arn.AccountId))
            {
                throw new AmazonClientException("Account ID is missing in access point ARN");
            }
            if (string.IsNullOrEmpty(s3Arn.Region))
            {
                throw new AmazonClientException("AWS region is missing in access point ARN");
            }
            if (HasValidFips(s3Arn, s3Config, region)) // will throw on invalid configs
            {
                return;
            }
            if (!string.Equals(region.PartitionName, s3Arn.Partition, StringComparison.Ordinal))
            {
                throw new AmazonClientException("The access point used in the request is in a different AWS partition then the region configured for the AmazonS3Client.");
            }
            if (string.Equals(s3Arn.Region, region.SystemName, StringComparison.Ordinal))
            {
                return;
            }

            if (!s3Config.UseArnRegion)
            {
                throw new AmazonClientException(
                    $"The S3 service client is configured for region {region.SystemName} but the access point is in {s3Arn.Region}. " +
                    "By default the SDK doesn't allow cross region calls. If you want to enable cross region calls set the environment AWS_S3_USE_ARN_REGION or the AmazonS3Config.UseArnRegion property to value \"true\".");
            }
        }

        /// <summary>
        /// Validates S3ObjectLambda Access Points.
        /// </summary>
        private static void ValidateS3ObjectLambdaAccessPoint(Arn arn, AmazonS3Config s3Config, RegionEndpoint region)
        {
            var arnString = arn.ToString();

            if (!arn.HasValidAccountId())
            {
                throw new AmazonAccountIdException();
            }

            foreach (var ch in arnString)
            {
                if (!char.IsLetterOrDigit(ch) && ch != ':' && ch != '/' && ch != '-')
                    throw new AmazonClientException("Invalid Arn. S3ObjectLambda arns can only contain alphanumeric characters, :, / and -");
            }
            if (arn.Resource.Split(':').Length > 2)
                throw new AmazonClientException("Invalid ARN, Access Point ARN contains sub resources");

            if (s3Config.UseAccelerateEndpoint)
            {
                throw new AmazonClientException("Invalid configuration S3ObjectLambda access points do not support accelerate");
            }
            if (s3Config.UseDualstackEndpoint)
            {
                throw new AmazonClientException("Invalid configuration S3ObjectLambda access points do not support dualstack");
            }
            if (HasValidFips(arn, s3Config, region)) // will throw on invalid configs
            {
                return;
            }
            if (string.IsNullOrEmpty(arn.AccountId))
            {
                throw new AmazonClientException("Account ID is missing in S3ObjectLambda access point ARN");
            }
            if (string.IsNullOrEmpty(arn.Region))
            {
                throw new AmazonClientException("AWS region is missing in S3ObjectLambda access point ARN");
            }
            if (!string.Equals(region.PartitionName, arn.Partition))
            {
                throw new AmazonClientException("Invalid configuration, cross partition S3ObjectLambda access point ARN");
            }
            if (!s3Config.UseArnRegion
                && !string.Equals(arn.Region, region.SystemName, StringComparison.Ordinal))
            {
                throw new AmazonClientException("Invalid configuration, cross region S3ObjectLambda access point ARN");
            }
        }

        /// <summary>
        /// Validate Multi-Region Access Points
        /// </summary>
        private static Regex mrapAliasSegmentRegex = new Regex(@"^[a-zA-Z0-9\-]{1,63}$", RegexOptions.Compiled);
        private static void ValidateMRAPAccessPoint(Arn arn, AmazonS3Config s3Config, string mrapAlias, string partitionDnsSuffix)
        {
            if (s3Config.DisableMultiregionAccessPoints)
            {
                throw new AmazonClientException("Invalid configuration, multi-region access point ARNs are disabled.");
            }
            if (s3Config.UseAccelerateEndpoint)
            {
                throw new AmazonClientException("Invalid configuration, multi-region access points do not support accelerate");
            }
            if (s3Config.UseDualstackEndpoint)
            {
                throw new AmazonClientException("Invalid configuration, multi-region access points do not support dualstack");
            }
            if (!s3Config.UseArnRegion && s3Config.RegionEndpoint != null && s3Config.RegionEndpoint.SystemName.StartsWith("fips-"))
            {
                throw new AmazonClientException("Invalid configuration, multi-region access points do not support Fips- regions");
            }
            if (String.IsNullOrEmpty(partitionDnsSuffix))
            {
                throw new AmazonClientException($"Failed to determine a DNS suffix for partition {arn.Partition}");
            }

            foreach (var aliasSegment in mrapAlias.Split('.'))
            {
                if (!mrapAliasSegmentRegex.IsMatch(aliasSegment))
                {
                    throw new AmazonClientException($"{mrapAlias} is not a valid multi-region access point. The alias must consist of valid RFC 3986 host labels");
                }
            }
        }

        /// <summary>
        /// Validates Outposts Access points.
        /// </summary>
        private static void ValidateOutpostAccessPoint(Arn arn, AmazonS3Config s3Config, RegionEndpoint region)
        {
            if (s3Config.UseAccelerateEndpoint)
            {
                throw new AmazonClientException("Invalid configuration outpost access points do not support accelerate");
            }
            if (s3Config.UseDualstackEndpoint)
            {
                throw new AmazonClientException("Invalid configuration outpost access points do not support dualstack");
            }
            if (!arn.HasValidAccountId())
            {
                throw new AmazonAccountIdException();
            }
            if (string.IsNullOrEmpty(arn.AccountId))
            {
                throw new AmazonClientException("Account ID is missing in outpost access point ARN");
            }
            if (string.IsNullOrEmpty(arn.Region))
            {
                throw new AmazonClientException("AWS region is missing in outpost access point ARN");
            }
            if (!string.Equals(region.PartitionName, arn.Partition))
            {
                throw new AmazonClientException("Invalid configuration, cross partition outpost access point ARN");
            }
            if (region.SystemName?.StartsWith("fips-") == true ||
                s3Config.UseArnRegion && arn.Region.StartsWith("fips-"))
            {
                throw new AmazonClientException("Invalid configuration outpost access points do not support Fips- regions");
            }
            if (!s3Config.UseArnRegion
                && !string.Equals(arn.Region, region.SystemName, StringComparison.Ordinal))
            {
                throw new AmazonClientException("Invalid configuration, cross region outpost access point ARN");
            }
        }

        private static Uri GetAccelerateEndpoint(string bucketName, AmazonS3Config config)
        {
            return new Uri($"{(config.UseHttp ? "http://" : "https://")}{bucketName}.{config.AccelerateEndpoint}");
        }

        /// <summary>
        /// Checks the validity of a Fips configuration for Access Point and Object Lambda
        /// (NOT OUTPOST - fips isn't supported in outpost) 
        /// </summary>
        /// <returns>
        /// Valid Fips Config: <c>true</c>
        /// No Fips Config: <c>false</c>
        /// Invalid Fips Config: exception
        /// </returns>
        /// <exception cref="AmazonClientException">
        /// Thrown if an invalid Fips configuration is found.
        /// </exception>
        private static bool HasValidFips(Arn arn, AmazonS3Config s3Config, RegionEndpoint region)
        {
            if (arn.Region.Contains("fips"))
            {
                throw new AmazonClientException("Invalid ARN, FIPS region not allowed in ARN");
            }
            if (region.SystemName.StartsWith("fips-"))
            { 
                if (region.SystemName.Contains(arn.Region))
                {
                    return true;
                }
                else if (s3Config.UseArnRegion)
                {
                    throw new AmazonClientException("Invalid configuration, FIPS region does not match ARN region");
                }
            }

            return false;
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
            /// If the resource is an outposts resource, we want to handle getting the bucket name
            /// later and just return the trimmed path.
            if (Arn.IsArn(resourcePath))
            {
                Arn arn;
                try
                {
                    arn = Arn.Parse(resourcePath);
                }
                catch(AmazonAccountIdException)
                {
                    throw new AmazonAccountIdException(); // Throw with the default exception message.
                }

                if (arn.IsOutpostArn())
                {
                    return resourcePath;
                }
            }
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

        private static Regex bucketValidationRegex = new Regex(@"^[A-Za-z0-9._\-]+$", RegexOptions.Compiled);
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

        private static Regex dnsValidationRegex1 = new Regex(@"^[a-z0-9][a-z0-9.-]+[a-z0-9]$", RegexOptions.Compiled);
        private static Regex dnsValidationRegex2 = new Regex("(\\d+\\.){3}\\d+", RegexOptions.Compiled);
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
