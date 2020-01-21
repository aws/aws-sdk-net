/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;

#if BCL || NETSTANDARD
using Amazon.Runtime.CredentialManagement;
#endif

namespace Amazon.S3
{

    /// <summary>
    /// Configuration for accessing AmazonS3 service
    /// </summary>
    public partial class AmazonS3Config : ClientConfig
    {
        private const string UseArnRegionEnvName = "AWS_S3_USE_ARN_REGION";
        private const string AccelerateEndpointSuffix = "s3-accelerate.amazonaws.com";
        private const string AccelerateDualstackEndpointSuffix = "s3-accelerate.dualstack.amazonaws.com";
        private const string AwsProfileEnvironmentVariable = "AWS_PROFILE";
        private const string DefaultProfileName = "default";
        private const string AwsS3UsEast1RegionalEndpointsEnvironmentVariable = "AWS_S3_US_EAST_1_REGIONAL_ENDPOINT";

        private bool forcePathStyle = false;
        private bool useAccelerateEndpoint = false;
        private S3UsEast1RegionalEndpointValue? s3UsEast1RegionalEndpointValue;
        private readonly RegionEndpoint legacyUSEast1GlobalRegion = RegionEndpoint.USEast1;

#if BCL || NETSTANDARD
        private static CredentialProfileStoreChain credentialProfileChain = new CredentialProfileStoreChain();
#endif
         
        /// <summary>
        /// When true, requests will always use path style addressing.
        /// </summary>
        public bool ForcePathStyle
        {
            get { return forcePathStyle; }
            set { forcePathStyle = value; }
        }

        /// <summary>
        /// Enables S3 accelerate by sending requests to the accelerate endpoint instead of the regular region endpoint. 
        /// To use this feature, the bucket name should be DNS compliant names and should not contain periods (.). 
        /// The following APIs are not supported and are sent to the regular region endpoint, even if this option is enabled:
        /// <ol> 
        /// <li>PutBucket</li>
        /// <li>ListBuckets</li>
        /// <li>DeleteBucket</li>
        /// </ol>
        /// </summary>
        /// <remarks>
        /// This option cannot be used at the same time as UseDualstackEndpoint.
        /// </remarks>
        public bool UseAccelerateEndpoint
        {
            get { return useAccelerateEndpoint; }
            set { useAccelerateEndpoint = value; }
        }

        bool? _useArnRegion;
        /// <summary>
        /// If set to true and the service package supports it the region identified in the arn for a resource
        /// will be used when making the service request.
        /// </summary>
        public bool UseArnRegion
        {
            get 
            {
                if (!this._useArnRegion.HasValue)
                {
#if BCL || NETSTANDARD
                    var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
                    if (credentialProfileChain.TryGetProfile(profileName, out var profile))
                    {
                        this._useArnRegion = profile.S3UseArnRegion;
                    }

                    if (!this._useArnRegion.HasValue && !string.IsNullOrEmpty(Environment.GetEnvironmentVariable(UseArnRegionEnvName)))
                    {
                        if (bool.TryParse(Environment.GetEnvironmentVariable(UseArnRegionEnvName), out var value))
                        {
                            this._useArnRegion = value;
                        }
                    }
#endif

                    if (!this._useArnRegion.HasValue)
                    {
                        // To maintain consistency with buckets default UseArnRegion to true when client configured for us-east-1.
                        this._useArnRegion = this.RegionEndpoint == RegionEndpoint.USEast1;
                    }
                }

                return this._useArnRegion.GetValueOrDefault(); 
            }

            set { this._useArnRegion = value; }
        }

        /// <summary>
        /// USEast1RegionalEndpointValue determines wheter or not
        /// to send the us-east-1 s3 requests to the regional endpoint or to
        /// the legacy global endpoint.
        /// This flags takes precedence over the AWS_S3_US_EAST_1_REGIONAL_ENDPOINT
        /// environment variable and the credential file.
        /// </summary>
        public S3UsEast1RegionalEndpointValue? USEast1RegionalEndpointValue
        {
            get
            {
                if (s3UsEast1RegionalEndpointValue == null)
                {
                    s3UsEast1RegionalEndpointValue = CheckS3EnvironmentVariable() ?? CheckCredentialsFile() ?? S3UsEast1RegionalEndpointValue.Legacy;
                }
                return s3UsEast1RegionalEndpointValue;
            }
            set { s3UsEast1RegionalEndpointValue = value; }
        }

        /// <summary>
        /// This method contains custom initializations for the config object.
        /// </summary>
        protected override void Initialize()
        {
            this.AllowAutoRedirect = false;
#if BCL45 || NETSTANDARD
            // Set Timeout and ReadWriteTimeout for S3 to max timeout as per-request
            // timeouts are not supported.
            this.Timeout = ClientConfig.MaxTimeout;
            this.ReadWriteTimeout = ClientConfig.MaxTimeout;
#elif PCL
            // Only Timeout property is supported for WinRT and Windows Phone.
            // Set Timeout for S3 to max timeout as per-request
            // timeouts are not supported.
            this.Timeout = ClientConfig.MaxTimeout;
#endif
        }

        /// <summary>
        /// Given this client configuration, returns the service url
        /// </summary>
        /// <returns>The service url in the form of a string</returns>
        public override string DetermineServiceURL()
        {
            if (this.ServiceURL != null)
            {
                return this.ServiceURL;
            }

            var actual = this.RegionEndpoint;
            if (actual == legacyUSEast1GlobalRegion && !UseAccelerateEndpoint && !UseDualstackEndpoint
                && USEast1RegionalEndpointValue == S3UsEast1RegionalEndpointValue.Regional)
            {
                actual = RegionEndpoint.GetBySystemName("us-east-1-regional");
            }

            return GetUrl(actual, this.RegionEndpointServiceName, this.UseHttp, this.UseDualstackEndpoint);
        }

        /// <summary>
        /// If the client is configured to hit us-east-1 with the S3UsEast1RegionalEndpointValue flag not set, 
        /// this method checks whether the environment variable is present or the credential file contains a valid value
        /// </summary>
        /// <returns>A Nullable of S3UsEast1RegionalEndpointValue representing the client configuration for the regional us-east-1 endpoint</returns>
        private S3UsEast1RegionalEndpointValue? GetEndpointFlagValueForUsEast1Regional()
        {
            if (this.USEast1RegionalEndpointValue.HasValue)
            {
                return this.USEast1RegionalEndpointValue;
            }
            else
            {
                // Environment variable takes precedence over the credential file
                return CheckS3EnvironmentVariable() ?? CheckCredentialsFile();
            }
        }

        internal static string GetUrl(RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
        {
            var endpoint = regionEndpoint.GetEndpointForService(regionEndpointServiceName, useDualStack);
            string url = new Uri(string.Format(CultureInfo.InvariantCulture, "{0}{1}", useHttp ? "http://" : "https://", endpoint.Hostname)).AbsoluteUri;
            return url;
        }
        
        /// <summary>
        /// Validate that the config object is properly configured.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (this.ForcePathStyle && this.UseAccelerateEndpoint)
            {
                throw new AmazonClientException(
                        @"S3 accelerate is not compatible with Path style requests. Disable Path style requests" +
                         " using AmazonS3Config.ForcePathStyle property to use S3 accelerate.");
            }

            var isExplicitAccelerateEndpoint = !string.IsNullOrEmpty(this.ServiceURL) &&
                                               (this.ServiceURL.IndexOf(AccelerateEndpointSuffix, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                this.ServiceURL.IndexOf(AccelerateDualstackEndpointSuffix, StringComparison.OrdinalIgnoreCase) >= 0);

            if (isExplicitAccelerateEndpoint)
            {

                if (this.RegionEndpoint == null && string.IsNullOrEmpty(this.AuthenticationRegion))
                {
                    throw new AmazonClientException(
                            @"Specify a region using AmazonS3Config.RegionEndpoint or AmazonS3Config.AuthenticationRegion" +
                            " to use S3 accelerate.");
                }
                else
                {
                    if (this.RegionEndpoint == null && !string.IsNullOrEmpty(this.AuthenticationRegion))
                    {
                        this.RegionEndpoint = RegionEndpoint.GetBySystemName(this.AuthenticationRegion);
                    }

                    this.UseAccelerateEndpoint = true;
                }
            }
        }

        /// <summary>
        /// Checks the AWS_S3_US_EAST_1_REGIONAL_ENDPOINT environment variable for the presence of the s3 regional flag
        /// </summary>
        /// <returns>A nullable of S3UsEast1RegionalEndpointValue</returns>
        private static S3UsEast1RegionalEndpointValue? CheckS3EnvironmentVariable()
        {
#if BCL || NETSTANDARD
            string s3RegionalFlag = Environment.GetEnvironmentVariable(AwsS3UsEast1RegionalEndpointsEnvironmentVariable);
            if (!string.IsNullOrEmpty(s3RegionalFlag))
            {
#if BCL35
                 S3UsEast1RegionalEndpointValue? s3RegionalFlagValue = null;
                 try
                 {
                     s3RegionalFlagValue = (S3UsEast1RegionalEndpointValue)Enum.Parse(typeof(S3UsEast1RegionalEndpointValue), s3RegionalFlag, true);
                 }
                 catch (Exception)
                 {
                     throw new InvalidOperationException("Invalid value for AWS_S3_US_EAST_1_REGIONAL_ENDPOINT environment variable. A string regional/legacy is expected.");
                 }
#else
                if (!Enum.TryParse<S3UsEast1RegionalEndpointValue>(s3RegionalFlag, true, out var s3RegionalFlagValue))
                {
                    throw new InvalidOperationException("Invalid value for AWS_S3_US_EAST_1_REGIONAL_ENDPOINT variable. A string regional/legacy is expected.");
                }
#endif
                return s3RegionalFlagValue;
            }
#endif
            return null;
        }

        /// <summary>
        /// Checks the credential file for the presence of the s3 regional flag
        /// </summary>
        /// <returns>A nullable of S3UsEast1RegionalEndpointValue</returns>
        private static S3UsEast1RegionalEndpointValue? CheckCredentialsFile()
        {
#if BCL || NETSTANDARD
            CredentialProfile profile;
            var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
            credentialProfileChain.TryGetProfile(profileName, out profile);
            return profile?.S3RegionalEndpoint;
#else
             return null;
#endif

        }

        internal string AccelerateEndpoint
        {
            get
            {
                return this.UseDualstackEndpoint ? AccelerateDualstackEndpointSuffix : AccelerateEndpointSuffix;
            }
        }
    }
}

    
