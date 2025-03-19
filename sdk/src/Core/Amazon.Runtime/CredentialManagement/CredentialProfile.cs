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
using Amazon.Runtime.Internal;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.CredentialManagement
{
    /// <summary>
    /// A named group of options that are persisted and used to obtain AWSCredentials.
    /// </summary>
    public class CredentialProfile
    {
        private Dictionary<string, string> _properties;

        private Dictionary<string, Dictionary<string, string>> _nestedProperties;
        /// <summary>
        /// An optional Dictionary of Dictionaries that can contain nested properties.
        /// For example: in a configuration file like so:
        /// [profile foo]
        /// s3 = 
        ///   max_retries = 10
        ///   max_concurrent_requests = 50
        /// NestedProperties contains: {{s3:{max_retries:10},{max_concurrent_requests:50}}}
        /// </summary>
        internal Dictionary<string, Dictionary<string, string>> NestedProperties
        {
            get => _nestedProperties ?? (_nestedProperties = new Dictionary<string, Dictionary<string,string>>());
            set => _nestedProperties = value;
        }
        /// <summary>
        /// The name of the CredentialProfile
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The options to be used to create AWSCredentials.
        /// </summary>
        public CredentialProfileOptions Options { get; private set; }

        /// <summary>
        /// The region to be used with this CredentialProfile
        /// </summary>
        public RegionEndpoint Region { get; set; }

        /// <summary>
        /// The unique key for this CredentialProfile.
        /// This key is used by the Visual Studio Toolkit to associate external artifacts with this profile.
        /// </summary>
        internal Guid? UniqueKey { get; set; }

        /// <summary>
        /// The desired <see cref="DefaultConfiguration.Name"/> that
        /// <see cref="IDefaultConfigurationProvider"/> should use.
        /// <para />
        /// If this is null/empty, then the <see cref="DefaultConfigurationMode.Standard"/> Mode will be used.
        /// </summary>
        public string DefaultConfigurationModeName { get; set; }

        /// <summary>
        /// The endpoint discovery enabled value for this CredentialProfile
        /// </summary>
        public bool? EndpointDiscoveryEnabled { get; set; }

        /// <summary>
        /// If true the region identified in the S3 access point arn will be used when making requests.
        /// </summary>
        public bool? S3UseArnRegion { get; set; }

        /// <summary>
        /// Disables this client's usage of Session Auth for S3Express buckets and reverts to using conventional SigV4.
        /// </summary>
        public bool? S3DisableExpressSessionAuth { get; set; }

        /// <summary>
        /// If true, the use of multi-region access points is disabled.
        /// </summary>
        public bool? S3DisableMultiRegionAccessPoints { get; set; }

        /// <summary>
        /// The S3 Regional Endpoint Value as either legacy or regional
        /// </summary>
        public S3UsEast1RegionalEndpointValue? S3RegionalEndpoint { get; set; }

        /// <summary>
        /// The request retry mode as standard or adaptive
        /// </summary>
        public RequestRetryMode? RetryMode { get; set; }

        /// <summary>
        /// Specified how many HTTP requests an SDK should make for a single
        /// SDK operation invocation before giving up.
        /// </summary>
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// Endpoint of the EC2 Instance Metadata Service
        /// </summary>
        public string EC2MetadataServiceEndpoint { get; set; }

        /// <summary>
        /// Internet protocol version to be used for communicating with the EC2 Instance Metadata Service
        /// </summary>
        public EC2MetadataServiceEndpointMode? EC2MetadataServiceEndpointMode { get; set; }

        /// <summary>
        /// Configures the endpoint calculation to go to a dual stack (ipv6 enabled) endpoint
        /// for the configured region.
        /// </summary>
        public bool? UseDualstackEndpoint { get; set; }

        /// <summary>
        /// Configures the endpoint calculation to go to a FIPS (https://aws.amazon.com/compliance/fips/) endpoint
        /// for the configured region.
        /// </summary>
        public bool? UseFIPSEndpoint { get; set; }

        /// <summary>
        /// If this flag is set to true, the SDK will ignore the configured endpoint urls set in the
        /// configuration file.
        /// </summary>
        public bool? IgnoreConfiguredEndpointUrls { get; set; }
        /// <summary>
        /// This configures the global endpoint URL for a profile. This cannot be used in a services section 
        /// and will be ignored if set in the services section.
        /// </summary>
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Controls whether request payloads are automatically compressed for supported operations.
        /// This setting only applies to operations that support compression.
        /// The default value is "false". Set to "true" to disable compression.
        /// </summary>
        public bool? DisableRequestCompression { get; set; }

        /// <summary>
        /// Minimum size in bytes that a request body should be to trigger compression.
        /// </summary>
        public long? RequestMinCompressionSizeBytes { get; set; }

        /// <summary>
        /// Customers can opt-in to provide an app id that is intended to identify their applications
        /// in the user agent header string. The value should have a maximum length of 50.
        /// </summary>
        public string ClientAppId { get; set; }

        /// <summary>
        /// The name of the section which contains the custom endpoints for a service or services.
        /// For example: 
        /// [profile foo]
        /// services = bar
        /// [services bar]
        /// s3 = 
        ///   endpoint_url = https://custom-endpoint-s3:80
        /// ec2 = 
        ///   endpoint_url = https://custome-endpoint_ec2:80
        /// This will tell the SDK to look for custom endpoints in "bar" for the profile "foo.
        /// A single Services section can contain configurations for multiple services.
        /// </summary>
        public string Services { get; set; }
        

        /// <summary>
        /// Determines the behavior for calculating checksums for request payloads.
        /// </summary>
        public RequestChecksumCalculation? RequestChecksumCalculation { get; set; }
        
        /// <summary>
        /// Determines the behavior for validating checksums on response payloads.
        /// </summary>
        public ResponseChecksumValidation? ResponseChecksumValidation { get; set; }

        /// <summary>
        /// The Account ID endpoint mode as preferred, required, or disabled.
        /// </summary>
        public AccountIdEndpointMode? AccountIdEndpointMode { get; set; }

        /// <summary>
        /// An optional dictionary of name-value pairs stored with the CredentialProfile
        /// </summary>
        internal Dictionary<string, string> Properties
        {
            get => _properties ?? (_properties = new Dictionary<string, string>());
            set => _properties = value;
        }

        /// <summary>
        /// True if the properties of the Options object can be converted into AWSCredentials, false otherwise.
        /// See <see cref="CredentialProfileOptions"/> for more details about which options are available.
        /// </summary>
        public bool CanCreateAWSCredentials => ProfileType.HasValue;

        /// <summary>
        /// The <see cref="ICredentialProfileStore"/> that this <see cref="CredentialProfile"/> is associated with.
        /// Null if this <see cref="CredentialProfile"/> is not associated with a <see cref="ICredentialProfileStore"/>.
        /// </summary>
        public ICredentialProfileStore CredentialProfileStore
        {
            get;
            internal set;
        }

        /// <summary>
        /// If CanCreateAWSCredentials is true, returns a short description of the type of
        /// credentials that would be created.
        /// If CanCreateAWSCredentials is false, return null.
        /// </summary>
        public string CredentialDescription => CredentialProfileTypeDetector.GetUserFriendlyCredentialType(ProfileType);

        /// <summary>
        /// The CredentialProfileType of this CredentialProfile, if one applies.
        /// </summary>
        internal CredentialProfileType? ProfileType => CredentialProfileTypeDetector.DetectProfileType(Options);

        /// <summary>
        /// Determine this CredentialProfile will generate AWSCredentials that require a callback to be set on them.
        /// </summary>
        internal bool IsCallbackRequired => AWSCredentialsFactory.IsCallbackRequired(ProfileType);

        /// <summary>
        /// Construct a new CredentialProfile.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="profileOptions"></param>
        public CredentialProfile(string name, CredentialProfileOptions profileOptions)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name must not be null or empty.");
            }

            Options = profileOptions ?? throw new ArgumentNullException("profileOptions");
            Name = name;
        }

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <param name="profileSource">The profile source, for profiles that reference other profiles.</param>
        /// <returns>AWSCredentials for this profile.</returns>
        public AWSCredentials GetAWSCredentials(ICredentialProfileSource profileSource)
        {
            return GetAWSCredentials(profileSource, false);
        }

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <param name="profileSource">The profile source, for profiles that reference other profiles.</param>
        /// <param name="nonCallbackOnly">If true, throw a descriptive exception for any credentials that would not operate as-is.
        /// In other words, any credentials that require programmatic callbacks at runtime.</param>
        /// <returns>AWSCredentials for this profile.</returns>
        internal AWSCredentials GetAWSCredentials(ICredentialProfileSource profileSource, bool nonCallbackOnly)
        {
            return AWSCredentialsFactory.GetAWSCredentials(this, profileSource, nonCallbackOnly);
        }

        private string GetPropertiesString()
        {
            return "{" + string.Join(",", Properties.OrderBy(p=>p.Key).Select(p => p.Key + "=" + p.Value).ToArray()) + "}";
        }

        public override string ToString()
        {
            return "[Name=" + Name + "," +
                "Options = " + Options + "," +
                "Region = " + (Region == null ? "" : Region.SystemName) + "," +
                "Properties = " + GetPropertiesString() + "," +
                "ProfileType = " + ProfileType + "," +
                "UniqueKey = " + UniqueKey + "," +
                "CanCreateAWSCredentials = " + CanCreateAWSCredentials + "," +
                "RetryMode= " + RetryMode + "," +
                "MaxAttempts= " + MaxAttempts +
                "AccountIdEndpointMode= " + AccountIdEndpointMode +
                "]";
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            var p = obj as CredentialProfile;
            if (p == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { Name, Options, Region, ProfileType, CanCreateAWSCredentials, UniqueKey },
                new object[] { p.Name, p.Options, p.Region, p.ProfileType, p.CanCreateAWSCredentials, p.UniqueKey }) &&
                AWSSDKUtils.DictionariesAreEqual(Properties, p.Properties);
        }

        public override int GetHashCode()
        {
            return Hashing.Hash(Name, Options, Region, ProfileType, CanCreateAWSCredentials, GetPropertiesString(), UniqueKey);
        }
    }
}
