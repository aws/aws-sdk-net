using System;


namespace Amazon.S3
{
    /// <summary>
    /// Extensions methods added to Amazon.Arn type to help parse S3 specific resources from the ARN.
    /// </summary>
    public static class ArnExtensions
    {
        internal const string ResourceTypeAccessPoint = "accesspoint";
        internal const string ResourceTypeBucketName = "bucket_name";

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

    }
}