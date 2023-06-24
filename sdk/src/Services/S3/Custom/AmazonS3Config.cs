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
using System.Globalization;
using Amazon.Internal;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;

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
        private const string DisableMRAPEnvName = "AWS_S3_DISABLE_MULTIREGION_ACCESS_POINTS";

        private bool forcePathStyle = false;
        private bool useAccelerateEndpoint = false;
        private S3UsEast1RegionalEndpointValue? s3UsEast1RegionalEndpointValue;
        private readonly string legacyUSEast1GlobalRegionSystemName = RegionEndpoint.USEast1.SystemName;

        private static CredentialProfileStoreChain credentialProfileChain = new CredentialProfileStoreChain();

        // we cache this per execution process to avoid excessive file I/O
        private static CredentialProfile _profile;
        private static object _triedToResolveProfileLock = new object();
        private static bool _triedToResolveProfile = false;

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
        private object _useArnRegionLock = new object();

        /// <summary>
        /// If set to true and the service package supports it the region identified in the arn for a resource
        /// will be used when making the service request.
        /// </summary>
        public bool UseArnRegion
        {
            get 
            {
                if (_useArnRegion.HasValue)
                {
                    return _useArnRegion.GetValueOrDefault();
                }

                if (!_triedToResolveProfile)
                {
                    lock (_triedToResolveProfileLock)
                    {
                        if (!_triedToResolveProfile)
                        {
                            var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
                            credentialProfileChain.TryGetProfile(profileName, out _profile);
                            _triedToResolveProfile = true;
                        }
                    }
                }

                lock (_useArnRegionLock)
                {
                    if (_useArnRegion.HasValue)
                    {
                        return _useArnRegion.Value;
                    }

                    _useArnRegion = _profile?.S3UseArnRegion;

                    if (!_useArnRegion.HasValue && !string.IsNullOrEmpty(Environment.GetEnvironmentVariable(UseArnRegionEnvName)))
                    {
                        if (bool.TryParse(Environment.GetEnvironmentVariable(UseArnRegionEnvName), out var value))
                        {
                            _useArnRegion = value;
                        }
                    }

                    if (!_useArnRegion.HasValue)
                    {
                        // To maintain consistency with buckets default UseArnRegion to true when client configured for us-east-1.
                        _useArnRegion = RegionEndpoint?.SystemName == RegionEndpoint.USEast1.SystemName;
                    }

                    return _useArnRegion.Value;
                }
            }

            set 
            {
                lock (_useArnRegionLock)
                {
                    _useArnRegion = value;
                }
            }
        }

        bool? _disableMultiregionAccessPoints;
        /// <summary>
        /// If set to true, prevents calls to multi-region access points.
        /// If not explicitly set here it will fallback first to the value of 
        /// AWS_S3_DISABLE_MULTIREGION_ACCESS_POINTS environment variable, then to 
        /// s3_disable_multiregion_access_points in the shared configuration file.
        /// Once a valid value is found in the environment variable or configuration file 
        /// it will be cached for this AmazonS3Config instance.
        /// </summary>
        public bool DisableMultiregionAccessPoints
        {
            get
            {
                if (_disableMultiregionAccessPoints == null)
                {
                    _disableMultiregionAccessPoints = CheckDisableMRAPEnvironmentVariable() ?? CheckDisableMRAPCredentialsFile();
                }
                return _disableMultiregionAccessPoints.GetValueOrDefault();
            }

            set { _disableMultiregionAccessPoints = value; }
        }

        /// <summary>
        /// USEast1RegionalEndpointValue determines whether or not
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
                    s3UsEast1RegionalEndpointValue =
                        CheckS3EnvironmentVariable() ??
                        CheckCredentialsFile() ??
                        DefaultConfiguration.S3UsEast1RegionalEndpoint;
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
#endif
        }

        /// <summary>
        /// Given this client configuration, returns the service url
        /// </summary>
        /// <returns>The service url in the form of a string</returns>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public override string DetermineServiceURL()
        {
            if (this.ServiceURL != null)
            {
                return this.ServiceURL;
            }

            var actual = this.RegionEndpoint;
            if (actual?.SystemName == legacyUSEast1GlobalRegionSystemName && !UseAccelerateEndpoint && !UseDualstackEndpoint
                && USEast1RegionalEndpointValue == S3UsEast1RegionalEndpointValue.Regional)
            {
                actual = RegionEndpoint.GetBySystemName("us-east-1-regional");
            }

            return GetUrl(this, actual);
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

        internal static string GetUrl(IClientConfig config, RegionEndpoint regionEndpoint)
        {
            var endpoint = regionEndpoint.GetEndpointForService(config);

            string url = new Uri(string.Format(CultureInfo.InvariantCulture, "{0}{1}", config.UseHttp ? "http://" : "https://", endpoint.Hostname)).AbsoluteUri;
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
            return null;
        }

        /// <summary>
        /// Checks the credential file for the presence of the s3 regional flag
        /// </summary>
        /// <returns>A nullable of S3UsEast1RegionalEndpointValue</returns>
        private static S3UsEast1RegionalEndpointValue? CheckCredentialsFile()
        {
            if (_triedToResolveProfile)
            {
                return _profile?.S3RegionalEndpoint;
            }
            lock (_triedToResolveProfileLock)
            {
                if (!_triedToResolveProfile)
                {
                    var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
                    credentialProfileChain.TryGetProfile(profileName, out _profile);
                    _triedToResolveProfile = true;
                }
            }
            return _profile?.S3RegionalEndpoint;
        }

        /// <summary>
        /// Validates and returns the value of AWS_S3_DISABLE_MULTIREGION_ACCESS_POINTS
        /// </summary>
        /// <returns>Value of AWS_S3_DISABLE_MULTIREGION_ACCESS_POINTS if it is set and valid, else null</returns>
        private static bool? CheckDisableMRAPEnvironmentVariable()
        {
            bool? disableMultiregionAccessPoints = null;
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(DisableMRAPEnvName)))
            {
                if (bool.TryParse(Environment.GetEnvironmentVariable(DisableMRAPEnvName), out var value))
                {
                    disableMultiregionAccessPoints = value;
                }
                else
                {
                    throw new InvalidOperationException($"Invalid value for {DisableMRAPEnvName} environment variable. true/false is expected.");
                }
            }
            return disableMultiregionAccessPoints;
        }

        /// <summary>
        /// Returns the value of s3_disable_multiregion_access_points for the current profile
        /// </summary>
        /// <returns>Value of s3_disable_multiregion_access_points if it is set, else null</returns>
        private static bool? CheckDisableMRAPCredentialsFile()
        {
            if (_triedToResolveProfile)
            {
                return _profile?.S3DisableMultiRegionAccessPoints;
            }
            lock (_triedToResolveProfileLock)
            {
                if (!_triedToResolveProfile)
                {
                    var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
                    credentialProfileChain.TryGetProfile(profileName, out _profile);
                    _triedToResolveProfile = true;
                }
            }
            return _profile?.S3DisableMultiRegionAccessPoints;
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

    
