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
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Extensions methods added to Amazon.Arn type to help parse S3 specific resources from the ARN.
    /// </summary>
    public static class ArnExtensions
    {
        internal const string ResourceTypeAccessPoint = "accesspoint";
        internal const string ResourceTypeBucket = "bucket";
        internal const string ResourceTypeOutpost = "outpost";

        /// <summary>
        /// Check if aws ARN resembles an outpost ARN
        /// </summary>
        /// <param name="arn">An AWS ARN to parse</param>
        /// <returns>True if the ARN contains an outpost resource identifier.</returns>
        public static bool IsOutpostArn(this Arn arn)
        {
            return !string.IsNullOrEmpty(arn.Resource) && 
                (S3ArnUtils.ArnSplit.Any(i => arn.Resource.StartsWith($"{ResourceTypeOutpost}{i}")) 
                || arn.Resource.Equals(ResourceTypeOutpost));
        }

        /// <summary>
        /// Parse an ARN to extract information on S3 outpost access point or bucket ARN
        /// and if it is not found or properly formatted, throw an exception
        /// </summary>
        /// <param name="arn">The ARN to be parsed into an S3 Outposts resource</param>
        /// <param name="config">Used to validate <paramref name="arn"/> </param>
        /// <returns>A <see cref="S3OutpostResource"/></returns>
        public static IS3Resource ParseOutpost(this Arn arn, AmazonS3ControlConfig config = null)
        {
            if (string.IsNullOrEmpty(arn.Resource))
            {
                throw new AmazonClientException("ARN resource can not be null");
            }
            if (!IsOutpostArn(arn))
            {
                throw new AmazonClientException("ARN resource does not resemble an outpost access point");
            }
            var parts = arn.Resource.Split(S3ArnUtils.ArnSplit, 5);
            if (parts.Length < 4 || (!string.Equals(parts[2], ResourceTypeAccessPoint) && !string.Equals(parts[2], ResourceTypeBucket)))
            {
                throw new AmazonClientException("Invalid ARN, outpost resource format is incorrect");
            }
            if (arn.Region.EndsWith("-fips", StringComparison.OrdinalIgnoreCase))
            {
                throw new AmazonClientException("Invalid ARN, FIPS region not allowed in ARN");
            }

            return new S3OutpostResource(arn)
            {
                OutpostId = parts[1],
                Type = (S3ResourceType)Enum.Parse(typeof(S3ResourceType), parts[2], true),
                Name = parts[3],
                Key = parts.Length > 4 ? parts[4] : null
            };
        }

        /// <summary>
        /// Check if the ARN has a valid service name
        /// </summary>
        /// <param name="arn">The ARN which is being validated</param>
        public static bool IsValidService(this Arn arn)
        {
            return arn.Service.Equals(S3ArnUtils.S3OutpostsService);
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
