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
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Provides access to read and write to the shared credentials INI file.
    /// The file is read, parsed, and validated at construction time.
    /// Changes can be made using the AddOrUpdateProfile() and
    /// DeleteProfile() methods.
    ///
    /// This class is not threadsafe.
    /// </summary>
    public class SharedCredentialsFile : ICredentialProfileStore
    {
        private const string ProfileMarker = "profile";
        private const string ConfigFileName = "config";

        /// <summary>
        /// To maintain compatibility with the CLI,
        /// SharedCredentialsFile doesn't support the Full* profileTypes.
        /// </summary>
        private HashSet<CredentialProfileType> ProfileTypeWhitelist =
            new HashSet<CredentialProfileType>()
            {
                CredentialProfileType.AssumeRole,
                CredentialProfileType.AssumeRoleExternal,
                CredentialProfileType.AssumeRoleExternalMFA,
                CredentialProfileType.AssumeRoleMFA,
                CredentialProfileType.Basic,
                CredentialProfileType.Session
            };

        private static readonly CredentialProfilePropertyMapping propertyMapping =
            new CredentialProfilePropertyMapping(
                new Dictionary<string, string>()
                {
                    { "AccessKey", "aws_access_key_id" },
                    { "ExternalID", "external_id" },
                    { "MfaSerial", "mfa_serial" },
                    { "RoleArn", "role_arn" },
                    { "SecretKey", "aws_secret_access_key" },
                    { "SourceProfile", "source_profile" },
                    { "Token", "aws_session_token" },
                }
            );

        private IniFile credentialsFile;
        private IniFile configFile;

        /// <summary>
        /// Construct a new SharedCredentialsFile.
        /// </summary>
        /// <param name="filePath">The path of the shared credentials file.</param>
        public SharedCredentialsFile(string filePath)
        {
            credentialsFile = new IniFile(filePath);

            // If a config file exists in the same location as the credentials file
            // load it for use as a read-only source of profile properties.
            var configPath = Path.Combine(Path.GetDirectoryName(filePath), ConfigFileName);
            if (File.Exists(configPath))
            {
                configFile = new IniFile(configPath);
            }
        }

        public bool TryGetProfile(string profileName, out CredentialProfile profile)
        {
            Dictionary<string, string> properties = null;
            if (TryGetSection(profileName, out properties))
            {
                var profileOptions = propertyMapping.Convert(properties);
                profile = new CredentialProfile(profileName, profileOptions);
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
        /// Add the profile given. If the profile already exists, update it.
        /// </summary>
        /// <param name="profile">The profile to be written.</param>
        public void AddOrUpdateProfile(CredentialProfile profile)
        {
            if (profile.IsValid)
            {
                if (!IsSupportedProfileType(profile.ProfileType))
                {
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                        "Unable to update profile {0}. The ProfileOptions object provided represents a " +
                        "{1} profile but {2} does not support that profile type.",
                        profile.Name, profile.ProfileType, GetType().Name ));
                }
                credentialsFile.EditSection(profile.Name, propertyMapping.Convert(profile.Options));
                credentialsFile.Persist();
            }
            else
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, 
                    "Unable to update profile {0}.  The ProfileOptions object provided does not represent a valid profile.", profile.Name));
            }
        }

        /// <summary>
        /// Deletes the section with the given ProfileName from the SharedCredentialsFile, if one exists.
        /// </summary>
        /// <param name="profileName">The ProfileName of the section to delete.</param>
        public void DeleteProfile(string profileName)
        {
            credentialsFile.DeleteSection(profileName);
            credentialsFile.Persist();
        }

        /// <summary>
        /// Try to get a profile that may be partially in the credentials file and partially in the config file.
        /// If there are identically named properties in both files, the properties in the credentials file take precedence.
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        private bool TryGetSection(string sectionName, out Dictionary<string, string> properties)
        {
            Dictionary<string, string> credentialsProperties = null;
            Dictionary<string, string> configProperties = null;

            var hasCredentialsProperties = credentialsFile.TryGetSection(sectionName, out credentialsProperties);

            // INI sections in the config file must be prefixed with "profile " to be recognized as a profile.
            var configSectionNameRegex = new Regex(ProfileMarker + "[ \t]+" + Regex.Escape(sectionName));
            var hasConfigProperties = configFile?.TryGetSection(configSectionNameRegex, out configProperties);

            if (hasConfigProperties.GetValueOrDefault())
            {
                properties = configProperties;
                if (hasCredentialsProperties)
                {
                    // Add all the properties from the credentials file.
                    // If a property exits in both, the one from the credentials
                    // file takes precedence and overwrites the one from
                    // the config file.
                    foreach (var pair in credentialsProperties)
                    {
                        properties[pair.Key] = pair.Value;
                    }
                }
                return true;
            }
            else
            {
                properties = credentialsProperties;
                return hasCredentialsProperties;
            }
        }

        private bool IsSupportedProfileType(CredentialProfileType? profileType)
        {
            return !profileType.HasValue || ProfileTypeWhitelist.Contains(profileType.Value);
        }
    }
}