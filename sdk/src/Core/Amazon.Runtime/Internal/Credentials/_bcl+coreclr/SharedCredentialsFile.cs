/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal
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
        private const string ProfileMarker = "profile";
        private const string ConfigFileName = "config";

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
                    { "EndpointName", null },
                    { "ExternalID", "external_id" },
                    { "MfaSerial", "mfa_serial" },
                    { "RoleArn", "role_arn" },
                    { "SecretKey", "aws_secret_access_key" },
                    { "SourceProfile", "source_profile" },
                    { "Token", "aws_session_token" },
                    { "UserIdentity", null },
                }
            );

        private IniFile credentialsFile;
        private IniFile configFile;

        public string FilePath { get; private set; }

        /// <summary>
        /// Construct a new SharedCredentialsFile.
        /// </summary>
        /// <param name="filePath">The path of the shared credentials file.</param>
        public SharedCredentialsFile(string filePath)
        {
            FilePath = filePath;
            Refresh();
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
            if (profile.CanCreateAWSCredentials)
            {
                if (!IsSupportedProfileType(profile.ProfileType))
                {
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                        "Unable to update profile {0}. The CredentialProfile object provided represents a " +
                        "{1} profile but {2} does not support the {1} profile type.",
                        profile.Name, profile.ProfileType, GetType().Name));
                }

                // make sure the property keys aren't reserved for profile options
                PropertyMapping.ValidateNoProfileOptionsProperties(profile.Properties);

                var flattenedDictionary = PropertyMapping.Convert(profile.Options);

                if (profile.Properties != null)
                    flattenedDictionary.AddRange(profile.Properties);

                credentialsFile.EditSection(profile.Name, flattenedDictionary);
                credentialsFile.Persist();
            }
            else
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture,
                    "Unable to update profile {0}.  The CredentialProfile provided is not a valid profile.", profile.Name));
            }
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

        private void Refresh()
        {
            credentialsFile = new IniFile(FilePath);

            // If a config file exists in the same location as the credentials file
            // load it for use as a read-only source of profile properties.
            var configPath = Path.Combine(Path.GetDirectoryName(FilePath), ConfigFileName);
            if (File.Exists(configPath))
            {
                configFile = new IniFile(configPath);
            }
        }

        private HashSet<string> ListAllProfileNames()
        {
            var profileNames = credentialsFile.ListSectionNames();

            if (configFile != null)
            {
                foreach (var sectionName in configFile.ListSectionNames())
                {
                    if (sectionName.StartsWith(ProfileMarker, StringComparison.Ordinal))
                    {
                        var profileName = Regex.Replace(sectionName, ProfileMarker + "[ \t]+", "");
                        if (!profileNames.Contains(profileName))
                        {
                            profileNames.Add(profileName);
                        }
                    }
                }
            }
            return profileNames;
        }

        private bool TryGetProfile(string profileName, bool doRefresh, out CredentialProfile profile)
        {
            if (doRefresh)
            {
                Refresh();
            }

            Dictionary<string, string> properties = null;
            if (TryGetSection(profileName, out properties))
            {
                var profileOptions = PropertyMapping.ExtractCredentialProfileOptions(properties);
                // properties now contains "leftover properties" that aren't part of profileOptions

                profile = new CredentialProfile(profileName, profileOptions, properties, this);
                if (!IsSupportedProfileType(profile.ProfileType))
                {
                    throw new InvalidDataException(string.Format(CultureInfo.InvariantCulture,
                        "Unable to read profile {0}. {1} does not support the {2} profile type.",
                        profileName, GetType().Name, profile.ProfileType));
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

            var hasCredentialsProperties = credentialsFile.TryGetSection(sectionName, out credentialsProperties);

            // INI sections in the config file must be prefixed with "profile " to be recognized as a profile.
            var configSectionNameRegex = new Regex(ProfileMarker + "[ \t]+" + Regex.Escape(sectionName));
            var hasConfigProperties = configFile?.TryGetSection(configSectionNameRegex, out configProperties);

            if (hasConfigProperties.GetValueOrDefault())
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