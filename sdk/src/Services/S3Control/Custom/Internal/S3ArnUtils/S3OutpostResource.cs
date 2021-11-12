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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// A resource in an S3 Outpost
    /// </summary>
    public class S3OutpostResource : IS3Resource
    {
        private Arn _arn;
        /// <summary>
        /// Create a new S3OutpostResource object
        /// </summary>
        /// <param name="arn">An ARN for the S3 Outpost resource</param>
        public S3OutpostResource(Arn arn)
        {
            _arn = arn;
        }

        /// <summary>
        /// Type of the S3 Resource. 
        /// </summary>
        public S3ResourceType Type { get; set; }

        private string _name;

        /// <summary>
        /// Name of the access point or bucket
        /// </summary>
        public string Name { 
            get { return this._name; }
            set
            {
                var accessPointOrBucketString = GetTypeString(true, true);
                if (string.IsNullOrEmpty(value))
                {
                    throw new AmazonClientException($"{accessPointOrBucketString} can not be null");
                }
                var invalidCharacter = value.FirstOrDefault(x => !char.IsLetterOrDigit(x) && x != '-');
                if (!invalidCharacter.Equals(default))
                {
                    throw new AmazonClientException($"Invalid ARN, {accessPointOrBucketString} Name contains invalid character, {invalidCharacter}");
                }
                this._name = value;
            }
        }

        /// <summary>
        /// Key for object in bucket
        /// </summary>
        public string Key { get; set; }

        private string _outpostId;

        /// <summary>
        /// ID of the S3 Outpost
        /// </summary>
        public string OutpostId
        {
            get { return this._outpostId; }
            set
            {
                if (!S3ArnUtils.IsValidOutpostId(value))
                {
                    throw new AmazonClientException($"Invalid outpost ID: {value}. ID must contain only alphanumeric characters and dashes");
                }
                this._outpostId = value;
            }
        }

        /// <summary>
        /// The full name of the S3 Outpost Resource (without the key)
        /// </summary>
        public string FullResourceName => $"arn:{_arn.Partition}:{_arn.Service}:{_arn.Region}:" +
                $"{_arn.AccountId}:outpost:{OutpostId}:" +
                $"{GetTypeString(false, false)}:{Name}";

        /// <summary>
        /// Validate the outpost ARN
        /// </summary>
        /// <param name="config">A client config to validate with</param>
        /// <param name="region">The region to use for cross region checks</param>
        public void ValidateArnWithClientConfig(IClientConfig config, RegionEndpoint region)
        {
            var s3Config = config as AmazonS3ControlConfig;
            var accessPointOrBucketString = GetTypeString(false, true);
            var capitalizedAccessPointOrBucketString = GetTypeString(true, true);
            if (!_arn.Service.Equals(S3ArnUtils.S3OutpostsService))
            {
                throw new AmazonClientException("Invalid ARN, not S3 Outposts ARN");
            }
            if (s3Config.UseDualstackEndpoint)
            {
                throw new AmazonClientException($"Invalid configuration Outpost {capitalizedAccessPointOrBucketString}s do not support dualstack");
            }
            if (string.IsNullOrEmpty(_arn.AccountId))
            {
                throw new AmazonClientException($"Account ID is missing in {capitalizedAccessPointOrBucketString} ARN");
            }
            if (string.IsNullOrEmpty(_arn.Region))
            {
                throw new AmazonClientException($"AWS region is missing in {capitalizedAccessPointOrBucketString} ARN");
            }
            if (s3Config.RegionEndpoint != null && !string.Equals(region.PartitionName, _arn.Partition))
            {
                throw new AmazonClientException($"Invalid configuration, cross partition Outpost {capitalizedAccessPointOrBucketString} ARN");
            }
            if (!s3Config.UseArnRegion
                && !string.Equals(_arn.Region, region.SystemName, StringComparison.Ordinal)
                && !string.Equals($"{_arn.Region}-fips", region.SystemName, StringComparison.Ordinal))
            {
                throw new AmazonClientException($"Invalid configuration, cross region Outpost {capitalizedAccessPointOrBucketString} ARN");
            }
        }

        /// <summary>
        /// Get the endpoint for the outpost request
        /// </summary>
        /// <param name="config">the client config from the customer</param>
        /// <returns></returns>
        public Uri GetEndpoint(IClientConfig config)
        {
            var s3Config = config as AmazonS3ControlConfig;
            var region = s3Config.UseArnRegion ? _arn.Region : config.RegionEndpoint?.SystemName;
            var scheme = config.UseHttp ? "http" : "https";
            var fips = config.UseFIPSEndpoint ? "-fips" : "";
            UriBuilder ub = new UriBuilder($"{scheme}://s3-outposts{fips}.{region}.{config.RegionEndpoint?.PartitionDnsSuffix}");
            return ub.Uri;
        }

        internal string GetTypeString(bool inCaps, bool hasSpaces)
        {
            switch(Type)
            {
                case S3ResourceType.AccessPoint:
                    if (hasSpaces)
                    {
                        return inCaps ? "Access Point" : "access point";
                    }
                    else
                    {
                        return inCaps ? "AccessPoint" : "accesspoint";
                    }
                case S3ResourceType.Bucket:
                    return inCaps ? "Bucket" : "bucket";
                default:
                    return "";
            }
        }
    }
}
