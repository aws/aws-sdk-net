using Amazon.Runtime;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Amazon.S3
{
    /// <summary>
    /// Extensions methods added to Amazon.Arn type to help parse S3 specific resources from the ARN.
    /// </summary>
    public static class ArnExtensions
    {
        internal const string ResourceTypeAccessPoint = "accesspoint";
        internal const string ResourceTypeBucketName = "bucket_name";
        internal const string ResourceTypeOutpostAccessPoint = "outpost";

        /// <summary>
        /// Attempt to parse the resource component of the ARN into access point resource name.
        /// </summary>
        /// <param name="arn">An AWS ARN to parse</param>
        /// <param name="accessPoint">The access point resouce identifier found in the ARN.</param>
        /// <returns>True if the ARN contains an access point resource identifier.</returns>
        public static bool TryParseAccessPoint(this Arn arn, out string accessPoint)
        {
            accessPoint = null;

            if (string.IsNullOrEmpty(arn.Resource))
            {
                return false;
            }

            if (arn.Resource.StartsWith(ResourceTypeAccessPoint + ":", StringComparison.Ordinal) ||
                arn.Resource.StartsWith(ResourceTypeAccessPoint + "/", StringComparison.Ordinal))
            {
                accessPoint = arn.Resource.Substring(ResourceTypeAccessPoint.Length + 1);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempt to parse the resource component of the ARN into bucket name.
        /// </summary>
        /// <param name="arn">An AWS ARN to parse</param>
        /// <param name="bucketName">The bucket name found in the ARN.</param>
        /// <returns>True if the ARN contains a bucket name.</returns>
        public static bool TryParseBucket(this Arn arn, out string bucketName)
        {
            bucketName = null;

            if (string.IsNullOrEmpty(arn.Resource))
            {
                return false;
            }

            if (arn.Resource.StartsWith(ResourceTypeBucketName + ":", StringComparison.Ordinal) ||
                arn.Resource.StartsWith(ResourceTypeBucketName + "/", StringComparison.Ordinal))
            {
                bucketName = arn.Resource.Substring(ResourceTypeBucketName.Length + 1);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempt to parse the resource component of the ARN into outpost resource with outpost id and access point name.
        /// </summary>
        /// <param name="arn">An AWS ARN to parse</param>
        /// <returns>True if the ARN contains an outpost access point resource identifier.</returns>
        public static bool IsOutpostArn(this Arn arn)
        {
            if (string.IsNullOrEmpty(arn.Resource))
            {
                return false;
            }
            return arn.Resource.StartsWith(ResourceTypeOutpostAccessPoint, StringComparison.Ordinal);
        }

        /// <summary>
        /// Checks whether an ARN belongs to a particular service
        /// </summary>
        /// <returns>True if a match is found</returns>
        public static bool IsService(this Arn arn, string serviceName)
        {
            return arn.Service.Equals(serviceName, StringComparison.Ordinal);
        }

        /// <summary>
        /// Determines whether an ARN is for a multi-region access point 
        /// </summary>
        /// <param name="arn">An AWS ARN to parse</param>
        /// <returns>True if the ARN is for a multi-region access point</returns>
        public static bool IsMRAPArn(this Arn arn)
        {
            if (string.IsNullOrEmpty(arn.Resource))
            {
                return false;
            }
            
            // The resource of MRAP ARNs must begin with a resource-type of `accesspoint`
            if (!(arn.Resource.StartsWith(ResourceTypeAccessPoint + ":", StringComparison.Ordinal) || 
                  arn.Resource.StartsWith(ResourceTypeAccessPoint + "/", StringComparison.Ordinal)))
            {
                return false;
            }

            return string.IsNullOrEmpty(arn.Region);
        }

        /// <summary>
        /// Parse an Arn to extract information on S3 outpost access point
        /// and if it is not found or properly formatted, throw an exception
        /// </summary>
        /// <param name="arn"></param>
        /// <returns></returns>
        public static S3OutpostResource ParseOutpost(this Arn arn)
        {
            if (string.IsNullOrEmpty(arn.Resource))
            {
                throw new AmazonClientException("Arn Resource can not be null");
            }
            if (!IsOutpostArn(arn))
            {
                throw new AmazonClientException($"Arn Resource: {arn.Resource} does not resemble an outpost access point");
            }
            var outpostAccessPointString = arn.Resource;
            var separators = new char[] { '/', ':' };
            var parts = outpostAccessPointString.Split(separators, 5);
            if (parts.Length < 4 || !String.Equals(parts[2], "accesspoint"))
            {
                throw new AmazonClientException($"Invalid ARN: {arn.ToString()}, outpost resource format is incorrect");
            }
            var outpost = new S3OutpostResource(arn);
            outpost.OutpostId = parts[1];
            outpost.AccessPointName = parts[3];
            if (parts.Length > 4)
            {
                outpost.Key = parts[4];
            }
            return new S3OutpostResource(arn)
            {
                OutpostId = parts[1],
                AccessPointName = parts[3],
                Key = parts.Length > 4 ? parts[4] : null
            };
        }

        /// <summary>
        /// Check if the ARN has a valid Account ID
        /// </summary>
        /// <param name="arn">The ARN which is being validated</param>
        public static bool HasValidAccountId(this Arn arn)
        {
            return string.IsNullOrEmpty(arn.AccountId) || (arn.AccountId.Length == 12 && arn.AccountId.ToCharArray().All(x => char.IsDigit(x)));
        }
    }
}