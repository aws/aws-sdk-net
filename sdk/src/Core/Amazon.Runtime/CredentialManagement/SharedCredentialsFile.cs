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
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime.CredentialManagement
{
    /// <summary>
    /// Provides access to read and write to the shared credentials INI file.
    /// The file is read, parsed, and validated at construction time.
    /// Changes can be made using the RegisterProfile() and
    /// UnregisterProfile() methods.
    ///
    /// This class is not threadsafe.
    /// </summary>
    public class SharedCredentialsFile : ICredentialProfileStore
    {
        public const string DefaultProfileName = "default";
        public const string SharedCredentialsFileEnvVar = "AWS_SHARED_CREDENTIALS_FILE";
        public const string SharedConfigFileEnvVar = "AWS_CONFIG_FILE";
        private const string ToolkitArtifactGuidField = "toolkit_artifact_guid";
        private const string RegionField = "region";
        private const string EndpointDiscoveryEnabledField = "endpoint_discovery_enabled";
        private const string ConfigFileName = "config";
        private const string DefaultDirectoryName = ".aws";
        private const string DefaultFileName = "credentials";
        private const string DefaultConfigurationModeField = "defaults_mode";
        private const string CredentialProcess = "credential_process";
        private const string S3UseArnRegionField = "s3_use_arn_region";
        private const string S3DisableExpressSessionAuthField = "s3_disable_express_session_auth";
        private const string S3RegionalEndpointField = "s3_us_east_1_regional_endpoint";
        private const string S3DisableMultiRegionAccessPointsField = "s3_disable_multiregion_access_points";
        private const string RetryModeField = "retry_mode";
        private const string MaxAttemptsField = "max_attempts";
        private const string SsoAccountId = "sso_account_id";
        private const string SsoRegion = "sso_region";
        private const string SsoRegistrationScopes = "sso_registration_scopes";
        private const string SsoRoleName = "sso_role_name";
        private const string SsoStartUrl = "sso_start_url";
        private const string SsoSession = "sso_session";
        private const string EC2MetadataServiceEndpointField = "ec2_metadata_service_endpoint";
        private const string EC2MetadataServiceEndpointModeField = "ec2_metadata_service_endpoint_mode";
        private const string UseDualstackEndpointField = "use_dualstack_endpoint";
        private const string UseFIPSEndpointField = "use_fips_endpoint";
        private const string EndpointUrlField = "endpoint_url";
        private const string ServicesField = "services";
        private const string IgnoreConfiguredEndpointUrlsField = "ignore_configured_endpoint_urls";
        private const string DisableRequestCompressionField = "disable_request_compression";
        private const string RequestMinCompressionSizeBytesField = "request_min_compression_size_bytes";
        private const string ClientAppIdField = "sdk_ua_app_id";
        private const string AccountIdEndpointModeField = "account_id_endpoint_mode";
        private const string RequestChecksumCalculationField = "request_checksum_calculation";
        private const string ResponseChecksumValidationField = "response_checksum_validation";
        private const string AwsAccountIdField = "aws_account_id";
        private readonly Logger _logger = Logger.GetLogger(typeof(SharedCredentialsFile));

        private static readonly HashSet<string> ReservedPropertyNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ToolkitArtifactGuidField,
            RegionField,
            EndpointDiscoveryEnabledField,
            CredentialProcess,
            S3UseArnRegionField,
            S3DisableExpressSessionAuthField,
            S3RegionalEndpointField,
            S3DisableMultiRegionAccessPointsField,
            RetryModeField,
            MaxAttemptsField,
            SsoAccountId,
            SsoRegion,
            SsoRegistrationScopes,
            SsoRoleName,
            SsoStartUrl,
            SsoSession,
            EC2MetadataServiceEndpointField,
            EC2MetadataServiceEndpointModeField,
            UseDualstackEndpointField,
            UseFIPSEndpointField,
            DefaultConfigurationModeField,
            EndpointUrlField,
            ServicesField,
            IgnoreConfiguredEndpointUrlsField,
            DisableRequestCompressionField,
            RequestMinCompressionSizeBytesField,
            ClientAppIdField,
            AccountIdEndpointModeField,
            RequestChecksumCalculationField,
            ResponseChecksumValidationField,
            AwsAccountIdField,
        };

        /// <summary>
        /// To maintain compatibility with the CLI,
        /// SharedCredentialsFile doesn't support the SAML profileTypes.
        /// </summary>
        private static readonly HashSet<CredentialProfileType> ProfileTypeWhitelist =
            new HashSet<CredentialProfileType>()
            {
                CredentialProfileType.AssumeRole,
                CredentialProfileType.AssumeRoleCredentialSource,
                CredentialProfileType.AssumeRoleExternal,
                CredentialProfileType.AssumeRoleExternalMFA,
                CredentialProfileType.AssumeRoleMFA,
                CredentialProfileType.AssumeRoleWithWebIdentity,
                CredentialProfileType.AssumeRoleWithWebIdentitySessionName,
                CredentialProfileType.Basic,
                CredentialProfileType.Session,
                CredentialProfileType.CredentialProcess,
                CredentialProfileType.AssumeRoleSessionName,
                CredentialProfileType.AssumeRoleCredentialSourceSessionName,
                CredentialProfileType.AssumeRoleExternalSessionName,
                CredentialProfileType.AssumeRoleExternalMFASessionName,
                CredentialProfileType.AssumeRoleMFASessionName,
                CredentialProfileType.SSO,
            };

        private static readonly CredentialProfilePropertyMapping PropertyMapping =
            new CredentialProfilePropertyMapping(
                new Dictionary<string, string>()
                {
                    { "AccessKey", "aws_access_key_id" },
                    { "CredentialSource", "credential_source" },
                    { "EndpointName", null },
                    { "ExternalID", "external_id" },
                    { "MfaSerial", "mfa_serial" },
                    { "RoleArn", "role_arn" },
                    { "RoleSessionName", "role_session_name" },
                    { "SecretKey", "aws_secret_access_key" },
                    { "SourceProfile", "source_profile" },
                    { "Token", "aws_session_token" },
                    { "UserIdentity", null },
                    { "CredentialProcess" , "credential_process" },
                    { "WebIdentityTokenFile", "web_identity_token_file" },
                    { "AwsAccountId", "aws_account_id" },
                    { nameof(CredentialProfileOptions.SsoAccountId), SsoAccountId },
                    { nameof(CredentialProfileOptions.SsoRegion), SsoRegion },
                    { nameof(CredentialProfileOptions.SsoRegistrationScopes), SsoRegistrationScopes },
                    { nameof(CredentialProfileOptions.SsoRoleName), SsoRoleName },
                    { nameof(CredentialProfileOptions.SsoSession), SsoSession },
                    { nameof(CredentialProfileOptions.SsoStartUrl), SsoStartUrl },
                }
            );
        /// <summary>
        /// The default directory for the credentials file. By default it searches in ~/.aws. This behavior can be overridden.
        /// </summary>
        public static readonly string DefaultDirectory;
        /// <summary>
        /// The default file path for the credentials file. By default it searches for ~/.aws/credentials. This behavior can be overriden.
        /// </summary>
        public static string DefaultFilePath { get; private set; }
        /// <summary>
        /// The default directory for the config file. By default it searches in ~/.aws This behavior can be overriden.
        /// </summary>
        public static readonly string DefaultConfigDirectory;
        /// <summary>
        /// The default file path for the config file. By default it searches in ~/.aws/config
        /// </summary>
        public static string DefaultConfigFilePath { get; private set; }
        static SharedCredentialsFile()
        {
            var awsCredentialsEnvironmentPath = Environment.GetEnvironmentVariable(SharedCredentialsFileEnvVar);
            var awsConfigEnvironmentPath = Environment.GetEnvironmentVariable(SharedConfigFileEnvVar);
            if (!string.IsNullOrEmpty(awsConfigEnvironmentPath))
            {
                if (File.Exists(awsConfigEnvironmentPath))
                {
                    DefaultConfigDirectory = Directory.GetParent(awsConfigEnvironmentPath).FullName;
                    DefaultConfigFilePath = awsConfigEnvironmentPath;
                }
            }
            if (!string.IsNullOrEmpty(awsCredentialsEnvironmentPath))
            {
                if (File.Exists(awsCredentialsEnvironmentPath))
                {
                    DefaultDirectory = Directory.GetParent(awsCredentialsEnvironmentPath).FullName;
                    DefaultFilePath = awsCredentialsEnvironmentPath;
                }
            }
            if (DefaultFilePath == null || DefaultConfigFilePath == null)
            {
                var baseDirectory = Environment.GetEnvironmentVariable("HOME");

                if (string.IsNullOrEmpty(baseDirectory))
                    baseDirectory = Environment.GetEnvironmentVariable("USERPROFILE");

                if (string.IsNullOrEmpty(baseDirectory))
#if NETSTANDARD
                    baseDirectory = Directory.GetCurrentDirectory();
#else
                baseDirectory = Environment.CurrentDirectory;
#endif
                if (DefaultFilePath == null)
                {
                    DefaultDirectory = Path.Combine(baseDirectory, DefaultDirectoryName);
                    DefaultFilePath = Path.Combine(DefaultDirectory, DefaultFileName);
                }
                if (DefaultConfigFilePath == null)
                {
                    DefaultConfigDirectory = Path.Combine(baseDirectory, DefaultDirectoryName);
                    DefaultConfigFilePath = Path.Combine(DefaultConfigDirectory, ConfigFileName);
                }
            }
        }

        private ProfileIniFile _credentialsFile;
        private ProfileIniFile _configFile;
        /// <summary>
        /// The path to the credentials file
        /// </summary>
        public string FilePath { get; private set; }
        /// <summary>
        /// The path to the config file
        /// </summary>
        public string ConfigFilePath { get; private set; }
        /// <summary>
        /// Construct a new SharedCredentialsFile in the default location.
        /// </summary>
        public SharedCredentialsFile()
        {
            SetUpFilePath(null);
            Refresh();
        }

        /// <summary>
        /// Construct a new SharedCredentialsFile.
        /// </summary>
        /// <param name="filePath">The path of the shared credentials file.</param>
        public SharedCredentialsFile(string filePath)
        {
            SetUpFilePath(filePath);
            Refresh();
        }
        /// <summary>
        /// SetUpFilePath sets FilePath and ConfigFilePath using the DefaultFilePath and DefaultConfigFilePath set in
        /// the static constructor. If AWSConfigs.AWSProfilesLocation is provided, FilePath supercedes DefaultFilePath
        /// </summary>
        /// <param name="filePath"></param>
        private void SetUpFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                if (string.IsNullOrEmpty(AWSConfigs.AWSProfilesLocation))
                {
                    FilePath = DefaultFilePath;
                    ConfigFilePath = DefaultConfigFilePath;
                }

                else
                {
                    FilePath = AWSConfigs.AWSProfilesLocation;
                    ConfigFilePath = DefaultConfigFilePath;
                }
            }
            else
            {
                FilePath = filePath;
                ConfigFilePath = DefaultConfigFilePath;
            }
        }

        public List<string> ListProfileNames()
        {
            Refresh();
            return ListProfiles().Select(p => p.Name).ToList();
        }

        public List<CredentialProfile> ListProfiles()
        {
            Refresh();
            var profiles = new List<CredentialProfile>();
            foreach (var profileName in ListAllProfileNames())
            {
                CredentialProfile profile = null;
                if (TryGetProfile(profileName, doRefresh: false, isSsoSession: false,isServicesSection: false, out profile) && profile.CanCreateAWSCredentials)
                {
                    profiles.Add(profile);
                }
            }
            return profiles;
        }

        public bool TryGetProfile(string profileName, out CredentialProfile profile)
        {
            return TryGetProfile(profileName, doRefresh: true, isSsoSession: false, isServicesSection: false, out profile);
        }

        /// <summary>
        /// Add the profile given. If the profile already exists, update it.
        /// </summary>
        /// <param name="profile">The profile to be written.</param>
        public void RegisterProfile(CredentialProfile profile)
        {
            Refresh();
            if (profile.CanCreateAWSCredentials || profile.Options.IsEmpty)
            {
                if (!IsSupportedProfileType(profile.ProfileType))
                {
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                        "Unable to update profile {0}. The CredentialProfile object provided represents a " +
                        "{1} profile but {2} does not support the {1} profile type.",
                        profile.Name, profile.ProfileType, GetType().Name));
                }

                RegisterProfileInternal(profile);
            }
            else
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture,
                    "Unable to update profile {0}.  The CredentialProfile provided is not a valid profile.", profile.Name));
            }
        }

        /// <summary>
        /// Update the profile on disk regardless of the profile type.
        /// </summary>
        /// <param name="profile"></param>
        [SuppressMessage("Microsoft.Globalization", "CA1308", Justification = "Value is not surfaced to user. Booleans have been lowercased by SDK precedent.")]
        private void RegisterProfileInternal(CredentialProfile profile)
        {
            var reservedProperties = new Dictionary<string, string>();

            if (profile.UniqueKey != null)
                reservedProperties[ToolkitArtifactGuidField] = profile.UniqueKey.Value.ToString("D");

            if (profile.Region != null)
                reservedProperties[RegionField] = profile.Region.SystemName;

            if (profile.EndpointDiscoveryEnabled != null)
                reservedProperties[EndpointDiscoveryEnabledField] = profile.EndpointDiscoveryEnabled.Value.ToString().ToLowerInvariant();

            if (profile.S3UseArnRegion != null)
                reservedProperties[S3UseArnRegionField] = profile.S3UseArnRegion.Value.ToString().ToLowerInvariant();

            if (profile.S3DisableExpressSessionAuth != null)
                reservedProperties[S3DisableExpressSessionAuthField] = profile.S3DisableExpressSessionAuth.Value.ToString().ToLowerInvariant();

            if (profile.S3RegionalEndpoint != null)
                reservedProperties[S3RegionalEndpointField] = profile.S3RegionalEndpoint.ToString().ToLowerInvariant();

            if (profile.S3DisableMultiRegionAccessPoints != null)
                reservedProperties[S3DisableMultiRegionAccessPointsField] = profile.S3DisableMultiRegionAccessPoints.ToString().ToLowerInvariant();

            if (profile.RetryMode != null)
                reservedProperties[RetryModeField] = profile.RetryMode.ToString().ToLowerInvariant();

            if (profile.MaxAttempts != null)
                reservedProperties[MaxAttemptsField] = profile.MaxAttempts.ToString().ToLowerInvariant();

            if (profile.EC2MetadataServiceEndpoint != null)
                reservedProperties[EC2MetadataServiceEndpointField] = profile.EC2MetadataServiceEndpoint.ToString().ToLowerInvariant();

            if (profile.EC2MetadataServiceEndpointMode != null)
                reservedProperties[EC2MetadataServiceEndpointModeField] = profile.EC2MetadataServiceEndpointMode.ToString().ToLowerInvariant();

            if (profile.UseDualstackEndpoint != null)
                reservedProperties[UseDualstackEndpointField] = profile.UseDualstackEndpoint.ToString().ToLowerInvariant();

            if (profile.UseFIPSEndpoint != null)
                reservedProperties[UseFIPSEndpointField] = profile.UseFIPSEndpoint.ToString().ToLowerInvariant();

            if(profile.IgnoreConfiguredEndpointUrls != null)
                reservedProperties[IgnoreConfiguredEndpointUrlsField] = profile.IgnoreConfiguredEndpointUrls.ToString().ToLowerInvariant();
                
            if(profile.EndpointUrl != null)
                reservedProperties[EndpointUrlField] = profile.EndpointUrl.ToString().ToLowerInvariant();

            if (profile.DisableRequestCompression != null)
                reservedProperties[DisableRequestCompressionField] = profile.DisableRequestCompression.ToString().ToLowerInvariant();

            if (profile.RequestMinCompressionSizeBytes != null)
                reservedProperties[RequestMinCompressionSizeBytesField] = profile.RequestMinCompressionSizeBytes.ToString().ToLowerInvariant();

            if (profile.RequestChecksumCalculation != null)
                reservedProperties[RequestChecksumCalculationField] = profile.RequestChecksumCalculation.ToString().ToLowerInvariant();

            if (profile.ResponseChecksumValidation != null)
                reservedProperties[ResponseChecksumValidationField] = profile.ResponseChecksumValidation.ToString().ToLowerInvariant();

            if (profile.ClientAppId != null)
                reservedProperties[ClientAppIdField] = profile.ClientAppId;

            if (profile.AccountIdEndpointMode != null)
                reservedProperties[AccountIdEndpointModeField] = profile.AccountIdEndpointMode.ToString().ToLowerInvariant();

            if (profile.Services != null)
                reservedProperties[ServicesField] = profile.Services.ToString().ToLowerInvariant();

            var profileDictionary = PropertyMapping.CombineProfileParts(
                profile.Options, ReservedPropertyNames, reservedProperties, profile.Properties);

            // The config file might contain parts of the profile
            // These parts are updated at the config file and removed from profileDictionary to avoid duplication
            UpdateConfigSectionsFromProfile(profile, profileDictionary);

            _credentialsFile.EditSection(profile.Name, new SortedDictionary<string, string>(profileDictionary));
            _credentialsFile.Persist();
            profile.CredentialProfileStore = this;
        }

        private void UpdateConfigSectionsFromProfile(CredentialProfile profile, Dictionary<string, string> profileDictionary)
        {
            if (_configFile == null || !_configFile.TryGetSection(profile.Name, false, false, out var configProperties, out _))
                return;

            var configPropertiesNames = configProperties.Keys.ToArray();
            foreach (var propertyName in configPropertiesNames)
            {
                if (profileDictionary.ContainsKey(propertyName))
                {
                    configProperties[propertyName] = profileDictionary[propertyName];
                    profileDictionary.Remove(propertyName); // Remove the property from profileDictionary as we updated it in the config
                }
                else
                {
                    configProperties[propertyName] = null;
                }
            }

            _configFile.EditSection(profile.Name, new SortedDictionary<string, string>(configProperties));
            _configFile.Persist();


            if (configProperties.TryGetValue(SsoSession, out var session)
                && _configFile.TryGetSection(session, true, false, out var ssoSessionProperties, out _))
            {
                // Skip SsoSession properties as it might be used by other profiles
                var ssoSessionPropertiesNames = ssoSessionProperties.Keys.ToArray();
                foreach (var propertyName in ssoSessionPropertiesNames)
                {
                    profileDictionary.Remove(propertyName);
                }
            }
        }

        /// <summary>
        /// Deletes the section with the given ProfileName from the SharedCredentialsFile, if one exists.
        /// </summary>
        /// <param name="profileName">The ProfileName of the section to delete.</param>
        public void UnregisterProfile(string profileName)
        {
            Refresh();
            _credentialsFile.DeleteSection(profileName);
            _credentialsFile.Persist();
        }

        /// <summary>
        /// Rename the profile with oldProfileName to newProfileName.
        /// </summary>
        /// <param name="oldProfileName">The profile to rename.</param>
        /// <param name="newProfileName">The new name for the profile.</param>
        public void RenameProfile(string oldProfileName, string newProfileName)
        {
            RenameProfile(oldProfileName, newProfileName, false);
        }

        /// <summary>
        /// Rename the profile with oldProfileName to newProfileName.
        /// </summary>
        /// <param name="oldProfileName">The profile to rename.</param>
        /// <param name="newProfileName">The new name for the profile.</param>
        /// <param name="force">If true and the destination profile exists it will be overwritten.</param>
        public void RenameProfile(string oldProfileName, string newProfileName, bool force)
        {
            Refresh();
            _credentialsFile.RenameSection(oldProfileName, newProfileName, force);
            _credentialsFile.Persist();
        }

        /// <summary>
        /// Make a copy of the profile with fromProfileName called toProfileName.
        /// </summary>
        /// <param name="fromProfileName">The name of the profile to copy from.</param>
        /// <param name="toProfileName">The name of the new profile.</param>
        public void CopyProfile(string fromProfileName, string toProfileName)
        {
            CopyProfile(fromProfileName, toProfileName, false);
        }

        /// <summary>
        /// Make a copy of the profile with fromProfileName called toProfileName.
        /// </summary>
        /// <param name="fromProfileName">The name of the profile to copy from.</param>
        /// <param name="toProfileName">The name of the new profile.</param>
        /// <param name="force">If true and the destination profile exists it will be overwritten.</param>
        public void CopyProfile(string fromProfileName, string toProfileName, bool force)
        {
            Refresh();
            // Do the copy but make sure to replace the toolkitArtifactGuid with a new one, if it's there.
            _credentialsFile.CopySection(fromProfileName, toProfileName,
                new Dictionary<string, string> { { ToolkitArtifactGuidField, Guid.NewGuid().ToString() } }, force);
            _credentialsFile.Persist();
        }

        private void Refresh()
        {
            _credentialsFile = new ProfileIniFile(FilePath, false);
            //Re-check if they set an explicit config file path, use that if it's set
            var awsConfigEnvironmentPath = Environment.GetEnvironmentVariable(SharedConfigFileEnvVar);
            if (!string.IsNullOrEmpty(awsConfigEnvironmentPath))
            {
                _configFile = new ProfileIniFile(ConfigFilePath, true);
            }

            // If a config file exists in the same location as the credentials file and no env vars are set
            // load it for use as a read-only source of profile properties.
            else
            {
                var configPath = Path.Combine(Path.GetDirectoryName(FilePath), ConfigFileName);
                if (File.Exists(configPath))
                {
                    _configFile = new ProfileIniFile(configPath, true);
                }
            }
        }

        private HashSet<string> ListAllProfileNames()
        {
            var profileNames = _credentialsFile.ListSectionNames();

            if (_configFile != null)
            {
                profileNames.UnionWith(_configFile.ListSectionNames());
            }
            return profileNames;
        }

        private bool TryGetProfile(string profileName, bool doRefresh, bool isSsoSession, bool isServicesSection, out CredentialProfile profile)
        {
            if (doRefresh)
            {
                Refresh();
            }
            Dictionary<string, Dictionary<string, string>> nestedProperties = null;
            Dictionary<string, string> profileDictionary = null;
            if (TryGetSection(profileName, isSsoSession, isServicesSection, out profileDictionary, out nestedProperties))
            {
                CredentialProfileOptions profileOptions;
                Dictionary<string, string> reservedProperties;
                Dictionary<string, string> userProperties;
                PropertyMapping.ExtractProfileParts(
                    profileDictionary,
                    ReservedPropertyNames,
                    out profileOptions,
                    out reservedProperties,
                    out userProperties);

                string toolkitArtifactGuidStr;
                Guid? toolkitArtifactGuid = null;
                if (reservedProperties.TryGetValue(ToolkitArtifactGuidField, out toolkitArtifactGuidStr))
                {
                    if (!GuidUtils.TryParseNullableGuid(toolkitArtifactGuidStr, out toolkitArtifactGuid))
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. GUID expected.", toolkitArtifactGuidStr, ToolkitArtifactGuidField, profileName);
                        profile = null;
                        return false;
                    }
                }
                string ignoreConfiguredEndpointUrlsString;
                bool? ignoreConfiguredEndpointUrls = false;
                if(reservedProperties.TryGetValue(IgnoreConfiguredEndpointUrlsField, out ignoreConfiguredEndpointUrlsString))
                {
                    bool ignoreConfiguredEndpointUrlsOut;
                    if(!bool.TryParse(ignoreConfiguredEndpointUrlsString, out ignoreConfiguredEndpointUrlsOut))
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A boolean true/false is expected", ignoreConfiguredEndpointUrlsString, IgnoreConfiguredEndpointUrlsField, profileName);
                        profile = null;
                        return false;
                    }
                    else
                    {
                        ignoreConfiguredEndpointUrls = ignoreConfiguredEndpointUrlsOut;
                    }
                }
                string endpointUrlString = null;
                if (ignoreConfiguredEndpointUrls == false)
                {
                    string services;


                    if (profileDictionary.TryGetValue(ServicesField, out services))
                    {
                        _configFile.TryGetSection(services, isSsoSession: false, isServicesSection: true, out userProperties, out nestedProperties);
                        

                    }
                    else
                    {
                        string endpointUrlTemp;
                        if (profileDictionary.TryGetValue(EndpointUrlField, out endpointUrlTemp))
                            endpointUrlString = endpointUrlTemp;
                            
                    }
                }
                string regionString;
                RegionEndpoint region = null;
                if (reservedProperties.TryGetValue(RegionField, out regionString))
                {
                    region = RegionEndpoint.GetBySystemName(regionString);
                }

                string endpointDiscoveryEnabledString;
                bool? endpointDiscoveryEnabled = null;
                if (reservedProperties.TryGetValue(EndpointDiscoveryEnabledField, out endpointDiscoveryEnabledString))
                {
                    bool endpointDiscoveryEnabledOut;
                    if (!bool.TryParse(endpointDiscoveryEnabledString, out endpointDiscoveryEnabledOut))
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A boolean true/false is expected.", endpointDiscoveryEnabledString, EndpointDiscoveryEnabledField, profileName);
                        profile = null;
                        return false;
                    }

                    endpointDiscoveryEnabled = endpointDiscoveryEnabledOut;
                }

                string s3UseArnRegionString;
                bool? s3UseArnRegion = null;
                if (reservedProperties.TryGetValue(S3UseArnRegionField, out s3UseArnRegionString))
                {
                    bool s3UseArnRegionOut;
                    if (!bool.TryParse(s3UseArnRegionString, out s3UseArnRegionOut))
                    {
                        profile = null;
                        return false;
                    }
                    s3UseArnRegion = s3UseArnRegionOut;
                }

                string s3DisableExpressSessionAuthString;
                bool? s3DisableExpressSessionAuth = null;
                if (reservedProperties.TryGetValue(S3DisableExpressSessionAuthField, out s3DisableExpressSessionAuthString))
                {
                    bool s3DisableExpressSessionAuthOut;
                    if (!bool.TryParse(s3DisableExpressSessionAuthString, out s3DisableExpressSessionAuthOut))
                    {
                        profile = null;
                        return false;
                    }
                    s3DisableExpressSessionAuth = s3DisableExpressSessionAuthOut;
                }

                S3UsEast1RegionalEndpointValue? s3RegionalEndpoint = null;
                if (reservedProperties.TryGetValue(S3RegionalEndpointField, out var s3RegionalEndpointString))
                {
                    if (!Enum.TryParse<S3UsEast1RegionalEndpointValue>(s3RegionalEndpointString, true, out var s3RegionalEndpointTemp))
                    {
                        _logger.InfoFormat("Invalid value {0} for {1} in profile {2}. A string regional/legacy is expected.", s3RegionalEndpointString, S3RegionalEndpointField, profileName);
                        profile = null;
                        return false;
                    }
                    s3RegionalEndpoint = s3RegionalEndpointTemp;
                }

                string s3DisableMultiRegionAccessPointsString;
                bool? s3DisableMultiRegionAccessPoints = null;
                if (reservedProperties.TryGetValue(S3DisableMultiRegionAccessPointsField, out s3DisableMultiRegionAccessPointsString))
                {
                    bool s3DisableMultiRegionAccessPointsOut;
                    if (!bool.TryParse(s3DisableMultiRegionAccessPointsString, out s3DisableMultiRegionAccessPointsOut))
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A boolean true/false is expected.", s3DisableMultiRegionAccessPointsString, S3DisableMultiRegionAccessPointsField, profileName);
                        profile = null;
                        return false;
                    }
                    s3DisableMultiRegionAccessPoints = s3DisableMultiRegionAccessPointsOut;
                }


                RequestRetryMode? requestRetryMode = null;
                if (reservedProperties.TryGetValue(RetryModeField, out var retryModeString))
                {
                    if (!Enum.TryParse<RequestRetryMode>(retryModeString, true, out var retryModeTemp))
                    {
                        _logger.InfoFormat("Invalid value {0} for {1} in profile {2}. A string standard/adaptive is expected.", retryModeString, RetryModeField, profileName);
                        profile = null;
                        return false;
                    }
                    requestRetryMode = retryModeTemp;
                }

                int? maxAttempts = null;
                if (reservedProperties.TryGetValue(MaxAttemptsField, out var maxAttemptsString))
                {
                    if (!int.TryParse(maxAttemptsString, out var maxAttemptsTemp) || maxAttemptsTemp <= 0)
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A positive integer is expected.", maxAttemptsString, MaxAttemptsField, profileName);
                        profile = null;
                        return false;
                    }

                    maxAttempts = maxAttemptsTemp;
                }

                string defaultConfigurationModeName;
                reservedProperties.TryGetValue(DefaultConfigurationModeField, out defaultConfigurationModeName);

                string ec2MetadataServiceEndpoint;
                if (reservedProperties.TryGetValue(EC2MetadataServiceEndpointField, out ec2MetadataServiceEndpoint))
                {
                    if (!Uri.IsWellFormedUriString(ec2MetadataServiceEndpoint, UriKind.Absolute))
                    {
                        throw new AmazonClientException($"Invalid value {ec2MetadataServiceEndpoint} for {EC2MetadataServiceEndpointField} in profile {profileName}. A well-formed Uri is expected.");
                    }
                }

                EC2MetadataServiceEndpointMode? ec2MetadataServiceEndpointMode = null;
                if (reservedProperties.TryGetValue(EC2MetadataServiceEndpointModeField, out var ec2MetadataServiceEndpointModeString))
                {
                    if (!Enum.TryParse<EC2MetadataServiceEndpointMode>(ec2MetadataServiceEndpointModeString, true, out var ec2MetadataServiceEndpointModeTemp))
                    {
                        _logger.InfoFormat("Invalid value {0} for {1} in profile {2}. A string IPv4 or IPV6 is expected.", ec2MetadataServiceEndpointModeString, EC2MetadataServiceEndpointModeField, profileName);
                        profile = null;
                        return false;
                    }
                    ec2MetadataServiceEndpointMode = ec2MetadataServiceEndpointModeTemp;
                }

                if (profileDictionary.TryGetValue(SsoSession, out var session))
                {
                    profileOptions.SsoSession = session;

                    if (TryGetProfile(session, doRefresh: false, isSsoSession: true, isServicesSection:false, out var sessionProfile))
                    {
                        profileOptions.SsoRegion = sessionProfile.Options.SsoRegion;
                        profileOptions.SsoRegistrationScopes = sessionProfile.Options.SsoRegistrationScopes;
                        profileOptions.SsoStartUrl = sessionProfile.Options.SsoStartUrl;
                    }
                    else
                    {
                        _logger.InfoFormat($"Failed to find {SsoSession} [{session}]");
                        throw new AmazonClientException($"Invalid Configuration.  Failed to find {SsoSession} [{session}]");
                    }
                }

                string useDualstackEndpointString;
                bool? useDualstackEndpoint = null;
                if (reservedProperties.TryGetValue(UseDualstackEndpointField, out useDualstackEndpointString))
                {
                    bool useDualstackEndpointOut;
                    if (!bool.TryParse(useDualstackEndpointString, out useDualstackEndpointOut))
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A boolean true/false is expected.", useDualstackEndpointString, UseDualstackEndpointField, profileName);
                        profile = null;
                        return false;
                    }
                    useDualstackEndpoint = useDualstackEndpointOut;
                }

                string useFIPSEndpointString;
                bool? useFIPSEndpoint = null;
                if (reservedProperties.TryGetValue(UseFIPSEndpointField, out useFIPSEndpointString))
                {
                    bool useFIPSEndpointOut;
                    if (!bool.TryParse(useFIPSEndpointString, out useFIPSEndpointOut))
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A boolean true/false is expected.", useFIPSEndpointString, UseFIPSEndpointField, profileName);
                        profile = null;
                        return false;
                    }
                    useFIPSEndpoint = useFIPSEndpointOut;
                }

                string disableRequestCompressionString;
                bool? disableRequestCompression = null;
                if (reservedProperties.TryGetValue(DisableRequestCompressionField, out disableRequestCompressionString))
                {
                    bool disableRequestCompressionOut;
                    if (!bool.TryParse(disableRequestCompressionString, out disableRequestCompressionOut))
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A boolean true/false is expected.", disableRequestCompressionString, DisableRequestCompressionField, profileName);
                        profile = null;
                        return false;
                    }
                    disableRequestCompression = disableRequestCompressionOut;
                }

                string requestMinCompressionSizeBytesString;
                long? requestMinCompressionSizeBytes = null;
                if (reservedProperties.TryGetValue(RequestMinCompressionSizeBytesField, out requestMinCompressionSizeBytesString))
                {
                    long requestMinCompressionSizeBytesOut;
                    if (!long.TryParse(requestMinCompressionSizeBytesString, out requestMinCompressionSizeBytesOut)
                        || requestMinCompressionSizeBytesOut < 0 || requestMinCompressionSizeBytesOut > ClientConfig.UpperLimitCompressionSizeBytes)
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Invalid value {0} for {1} in profile {2}. A long value between 0 and {3} bytes inclusive is expected.",
                            requestMinCompressionSizeBytesString, RequestMinCompressionSizeBytesField, profileName, ClientConfig.UpperLimitCompressionSizeBytes);
                        profile = null;
                        return false;
                    }
                    requestMinCompressionSizeBytes = requestMinCompressionSizeBytesOut;
                }

                string clientAppId = null;
                if (reservedProperties.TryGetValue(ClientAppIdField, out clientAppId))
                {
                    if (clientAppId != null && clientAppId.Length > EnvironmentVariableInternalConfiguration.AWS_SDK_UA_APP_ID_MAX_LENGTH)
                    {
                        Logger.GetLogger(GetType()).InfoFormat("Warning: Client app id in profile {0} exceeds recommended maximum length of {1} characters: \"{2}\"",
                            profileName, EnvironmentVariableInternalConfiguration.AWS_SDK_UA_APP_ID_MAX_LENGTH, clientAppId);
                    }
                }

                string servicesSection = null;
                reservedProperties.TryGetValue(ServicesField, out servicesSection);


                AccountIdEndpointMode? accountIdEndpointMode = null;
                if (reservedProperties.TryGetValue(AccountIdEndpointModeField, out var accountIdEndpointModeString))
                {
                    if (!Enum.TryParse<AccountIdEndpointMode>(accountIdEndpointModeString, true, out var accountIdEndpointModeTemp))
                    {
                        _logger.InfoFormat("Invalid value {0} for {1} in profile {2}. A string  preferred/disabled/required is expected.", accountIdEndpointModeString, AccountIdEndpointModeField, profileName);
                        profile = null;
                        return false;
                    }
                    accountIdEndpointMode = accountIdEndpointModeTemp;
                }

                RequestChecksumCalculation? requestChecksumCalculation = null;
                if (reservedProperties.TryGetValue(RequestChecksumCalculationField, out var requestChecksumCalculationString))
                {
                    if (!Enum.TryParse<RequestChecksumCalculation>(requestChecksumCalculationString, true, out var requestChecksumCalculationTemp))
                    {
                        _logger.InfoFormat("Invalid value {0} for {1} in profile {2}. A string WHEN_SUPPORTED or WHEN_REQUIRED is expected.", requestChecksumCalculationString, RequestChecksumCalculationField, profileName);
                        profile = null;
                        return false;
                    }
                    requestChecksumCalculation = requestChecksumCalculationTemp;
                }

                ResponseChecksumValidation? responseChecksumValidation = null;
                if (reservedProperties.TryGetValue(ResponseChecksumValidationField, out var responseChecksumValidationString))
                {
                    if (!Enum.TryParse<ResponseChecksumValidation>(responseChecksumValidationString, true, out var responseChecksumValidationTemp))
                    {
                        _logger.InfoFormat("Invalid value {0} for {1} in profile {2}. A string WHEN_SUPPORTED or WHEN_REQUIRED is expected.", responseChecksumValidationString, ResponseChecksumValidationField, profileName);
                        profile = null;
                        return false;
                    }
                    responseChecksumValidation = responseChecksumValidationTemp;
                }
                    profile = new CredentialProfile(profileName, profileOptions)
                {
                    UniqueKey = toolkitArtifactGuid,
                    Properties = userProperties,
                    Region = region,
                    CredentialProfileStore = this,
                    DefaultConfigurationModeName = defaultConfigurationModeName,
                    EndpointDiscoveryEnabled = endpointDiscoveryEnabled,
                    S3UseArnRegion = s3UseArnRegion,
                    S3DisableExpressSessionAuth = s3DisableExpressSessionAuth,
                    S3RegionalEndpoint = s3RegionalEndpoint,
                    S3DisableMultiRegionAccessPoints = s3DisableMultiRegionAccessPoints,
                    RetryMode = requestRetryMode,
                    MaxAttempts = maxAttempts,
                    EC2MetadataServiceEndpoint = ec2MetadataServiceEndpoint,
                    EC2MetadataServiceEndpointMode = ec2MetadataServiceEndpointMode,
                    UseDualstackEndpoint = useDualstackEndpoint,
                    UseFIPSEndpoint = useFIPSEndpoint,
                    NestedProperties = nestedProperties,
                    IgnoreConfiguredEndpointUrls = ignoreConfiguredEndpointUrls,
                    EndpointUrl = endpointUrlString,
                    DisableRequestCompression = disableRequestCompression,
                    RequestMinCompressionSizeBytes = requestMinCompressionSizeBytes,
                    ClientAppId = clientAppId,
                    AccountIdEndpointMode = accountIdEndpointMode,
                    RequestChecksumCalculation = requestChecksumCalculation,
                    ResponseChecksumValidation = responseChecksumValidation,
                    Services = servicesSection
                    };

                if (!IsSupportedProfileType(profile.ProfileType))
                {
                    _logger.InfoFormat("The profile type {0} is not supported by SharedCredentialsFile.", profile.ProfileType);
                    profile = null;
                    return false;
                }

                return true;

            }

            profile = null;
            return false;
        }

        /// <summary>
        /// Try to get a profile that may be partially in the credentials file and partially in the config file.
        /// If there are identically named properties in both files, the properties in the credentials file take precedence.
        /// </summary>
        private bool TryGetSection(string sectionName, bool isSsoSession, bool isServicesSection, out Dictionary<string, string> iniProperties, out Dictionary<string,Dictionary<string,string>> nestedProperties)
        {
            Dictionary<string, string> credentialsProperties = null;
            Dictionary<string, string> configProperties = null;
            nestedProperties = null;
            var hasCredentialsProperties = _credentialsFile.TryGetSection(sectionName, isSsoSession, isServicesSection, out credentialsProperties, out nestedProperties);

            var hasConfigProperties = false;
            if (_configFile != null)
            {
                _configFile.ProfileMarkerRequired = sectionName != DefaultProfileName;
                hasConfigProperties = _configFile.TryGetSection(sectionName, isSsoSession, isServicesSection, out configProperties, out nestedProperties);
            }

            if (hasConfigProperties)
            {
                iniProperties = configProperties;
                if (hasCredentialsProperties)
                {
                    // Add all the properties from the credentials file.
                    // If a property exits in both, the one from the credentials
                    // file takes precedence and overwrites the one from
                    // the config file.
                    foreach (var pair in credentialsProperties)
                    {
                        iniProperties[pair.Key] = pair.Value;
                    }
                }
                return true;
            }

            iniProperties = credentialsProperties;
            return hasCredentialsProperties;
        }

        private static bool IsSupportedProfileType(CredentialProfileType? profileType)
        {
            return !profileType.HasValue || ProfileTypeWhitelist.Contains(profileType.Value);
        }
    }
}