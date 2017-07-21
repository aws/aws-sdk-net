/*
 * Copyright 2016-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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

        private const string ToolkitArtifactGuidField = "toolkit_artifact_guid";
        private const string RegionField = "region";
        private const string ConfigFileName = "config";
        private const string DefaultDirectoryName = ".aws";
        private const string DefaultFileName = "credentials";

        private readonly Logger logger = Logger.GetLogger(typeof(SharedCredentialsFile));

        private static readonly HashSet<string> ReservedPropertyNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ToolkitArtifactGuidField,
            RegionField
        };

        /// <summary>
        /// To maintain compatibility with the CLI,
        /// SharedCredentialsFile doesn't support the SAML profileTypes.
        /// </summary>
        private static readonly HashSet<CredentialProfileType> ProfileTypeWhitelist =
            new HashSet<CredentialProfileType>()
            {
                CredentialProfileType.AssumeRole,
                CredentialProfileType.AssumeRoleExternal,
                CredentialProfileType.AssumeRoleExternalMFA,
                CredentialProfileType.AssumeRoleMFA,
                CredentialProfileType.Basic,
                CredentialProfileType.Session
            };

        private static readonly CredentialProfilePropertyMapping PropertyMapping =
            new CredentialProfilePropertyMapping(
                new Dictionary<string, string>()
                {
                    { "AccessKey", "aws_access_key_id" },
#if BCL
                    { "EndpointName", null },
#endif
                    { "ExternalID", "external_id" },
                    { "MfaSerial", "mfa_serial" },
                    { "RoleArn", "role_arn" },
                    { "SecretKey", "aws_secret_access_key" },
                    { "SourceProfile", "source_profile" },
                    { "Token", "aws_session_token" },
#if BCL
                    { "UserIdentity", null },
#endif
                }
            );

        public static readonly string DefaultDirectory;
        public static readonly string DefaultFilePath;

        static SharedCredentialsFile()
        {
            var baseDirectory = Environment.GetEnvironmentVariable("HOME");

            if (string.IsNullOrEmpty(baseDirectory))
                baseDirectory = Environment.GetEnvironmentVariable("USERPROFILE");

            if (string.IsNullOrEmpty(baseDirectory))
#if CORECLR
                baseDirectory = Directory.GetCurrentDirectory();
#else
                baseDirectory = Environment.CurrentDirectory;
#endif
            DefaultDirectory = Path.Combine(baseDirectory, DefaultDirectoryName);
            DefaultFilePath = Path.Combine(DefaultDirectory, DefaultFileName);
        }

        private ProfileIniFile credentialsFile;
        private ProfileIniFile configFile;

        public string FilePath { get; private set; }

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

        private void SetUpFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                if (string.IsNullOrEmpty(AWSConfigs.AWSProfilesLocation))
                    FilePath = DefaultFilePath;
                else
                    FilePath = AWSConfigs.AWSProfilesLocation;
            }
            else
            {
                FilePath = filePath;
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
                if (TryGetProfile(profileName, false, out profile) && profile.CanCreateAWSCredentials)
                {
                    profiles.Add(profile);
                }
            }
            return profiles;
        }

        public bool TryGetProfile(string profileName, out CredentialProfile profile)
        {
            return TryGetProfile(profileName, true, out profile);
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
        private void RegisterProfileInternal(CredentialProfile profile)
        {
            var reservedProperties = new Dictionary<string, string>();

            if (profile.UniqueKey != null)
                reservedProperties[ToolkitArtifactGuidField] = profile.UniqueKey.Value.ToString("D");

            if (profile.Region != null)
                reservedProperties[RegionField] = profile.Region.SystemName;

            var profileDictionary = PropertyMapping.CombineProfileParts(
                profile.Options, ReservedPropertyNames, reservedProperties, profile.Properties);

            credentialsFile.EditSection(profile.Name, new SortedDictionary<string, string>(profileDictionary));
            credentialsFile.Persist();
            profile.CredentialProfileStore = this;
        }

        /// <summary>
        /// Deletes the section with the given ProfileName from the SharedCredentialsFile, if one exists.
        /// </summary>
        /// <param name="profileName">The ProfileName of the section to delete.</param>
        public void UnregisterProfile(string profileName)
        {
            Refresh();
            credentialsFile.DeleteSection(profileName);
            credentialsFile.Persist();
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
            credentialsFile.RenameSection(oldProfileName, newProfileName, force);
            credentialsFile.Persist();
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
            credentialsFile.CopySection(fromProfileName, toProfileName,
                new Dictionary<string, string> { {ToolkitArtifactGuidField, Guid.NewGuid().ToString()} }, force);
            credentialsFile.Persist();
        }

        private void Refresh()
        {
            credentialsFile = new ProfileIniFile(FilePath,false);

            // If a config file exists in the same location as the credentials file
            // load it for use as a read-only source of profile properties.
            var configPath = Path.Combine(Path.GetDirectoryName(FilePath), ConfigFileName);
            if (File.Exists(configPath))
            {
                configFile = new ProfileIniFile(configPath,true);
            }
        }

        private HashSet<string> ListAllProfileNames()
        {
            var profileNames = credentialsFile.ListSectionNames();
            
            if (configFile != null)
            {
                profileNames.UnionWith(configFile.ListSectionNames());
            }
            return profileNames;
        }

        private bool TryGetProfile(string profileName, bool doRefresh, out CredentialProfile profile)
        {
            if (doRefresh)
            {
                Refresh();
            }

            Dictionary<string, string> profileDictionary = null;
            if (TryGetSection(profileName, out profileDictionary))
            {
                CredentialProfileOptions profileOptions;
                Dictionary<string, string> reservedProperties;
                Dictionary<string, string> userProperties;
                PropertyMapping.ExtractProfileParts(profileDictionary, ReservedPropertyNames,
                    out profileOptions, out reservedProperties, out userProperties);

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

                string regionString;
                RegionEndpoint region = null;
                if (reservedProperties.TryGetValue(RegionField, out regionString))
                {
                    region = RegionEndpoint.GetBySystemName(regionString);
                }

                profile = new CredentialProfile(profileName, profileOptions)
                {
                    UniqueKey = toolkitArtifactGuid,
                    Properties = userProperties,
                    Region = region,
                    CredentialProfileStore = this
                };

                if (!IsSupportedProfileType(profile.ProfileType))
                {
                    logger.InfoFormat("The profile type {0} is not supported by SharedCredentialsFile.", profile.ProfileType);
                    profile = null;
                    return false;
                }

                return true;
            }
            else
            {
                profile = null;
                return false;
            }
        }

        /// <summary>
        /// Try to get a profile that may be partially in the credentials file and partially in the config file.
        /// If there are identically named properties in both files, the properties in the credentials file take precedence.
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="iniProperties"></param>
        /// <returns></returns>
        private bool TryGetSection(string sectionName, out Dictionary<string, string> iniProperties)
        {
            Dictionary<string, string> credentialsProperties = null;
            Dictionary<string, string> configProperties = null;
            bool hasCredentialsProperties = false;
            hasCredentialsProperties = credentialsFile.TryGetSection(sectionName, out credentialsProperties);
           
            bool hasConfigProperties = false;
            if (configFile != null)
            {
                hasConfigProperties = configFile.TryGetSection(sectionName, out configProperties);
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
            else
            {
                iniProperties = credentialsProperties;
                return hasCredentialsProperties;
            }
        }

        private static bool IsSupportedProfileType(CredentialProfileType? profileType)
        {
            return !profileType.HasValue || ProfileTypeWhitelist.Contains(profileType.Value);
        }
    }
}