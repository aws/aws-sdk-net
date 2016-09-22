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
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// Provides access to read and write to the shared credentials INI file.
    /// The file is read, parsed, and validated at construction time.
    /// Changes can be made using the AddOrUpdateSection() and
    /// DeleteSection() methods.
    /// Those changes can be persisted to disk using the Persist() method.
    ///
    /// This class is not threadsafe.
    /// </summary>
    public class SharedCredentialsFile
    {
        public const string RoleSessionNamePrefix = "aws-dotnet-sdk-session-";
        public const string ConfigFileName = "config";
        private const string ProfileMarker = "profile";

        private const string AccessKeyPropertyName = "aws_access_key_id";
        private const string SecretKeyPropertyName = "aws_secret_access_key";
        private const string TokenPropertyName = "aws_session_token";
        private const string SourceProfilePropertyName = "source_profile";
        private const string RoleArnPropertyName = "role_arn";
        private const string MFASerialPropertyName = "mfa_serial";
        private const string ExternalIDPropertyName = "external_id";

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

        public List<string> ListProfileNames()
        {
            var names = new List<string>();
            foreach (var profileName in iniFile.ListSectionNames())
            {
                ImmutableCredentials credentials = null;
                if (TryGetCredentials(profileName, out credentials))
                {
                    names.Add(profileName);
                }
            }
            return names;
        }

        /// <summary>
        /// Get credentials for the given profile.
        /// </summary>
        /// <param name="profileName">The name of profile to find credentials for.</param>
        /// <returns>True if the profile exists and has valid credentials, false otherwise.</returns>
        public AWSCredentials GetAWSCredentials(string profileName)
        {
            return GetAWSCredentials(profileName, true);
        }

        /// <summary>
        /// Return the credentials for the profile if valid credentials can be found.
        /// </summary>
        /// <param name="profileName">The name of profile to find credentials for.</param>
        /// <param name="credentials">The credentials for the profile.</param>
        /// <returns>True if the profile was found and it contained valid credentials, false otherwise.</returns>
        public bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
        {
            credentials = GetAWSCredentials(profileName, false);
            return credentials != null;
        }

        /// <summary>
        /// Add credentials for the profile given.  If credentials for the profile already exist, update them.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="profileName">The name of profile.</param>
        /// <param name="accessKey">The access key for the credentials.</param>
        /// <param name="secretAccessKey">The secret access key for the credentials.</param>
        public void AddOrUpdateCredentials(string profileName, string accessKey, string secretAccessKey)
        {
            AddOrUpdateCredentials(profileName, accessKey, secretAccessKey, null);
        }

        /// <summary>
        /// Add credentials for the profile given.  If credentials for the profile already exist, update them.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="profileName">The name of profile.</param>
        /// <param name="accessKey">The access key for the credentials.</param>
        /// <param name="secretAccessKey">The secret access key for the credentials.</param>
        /// <param name="token">The token for the credentials.</param>
        public void AddOrUpdateCredentials(string profileName, string accessKey, string secretAccessKey, string token)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentNullException("profileName", "profileName cannot be null or empty.");
            }
            if (string.IsNullOrEmpty(accessKey))
            {
                throw new ArgumentNullException("accessKey", "accessKey cannot be null or empty.");
            }
            if (string.IsNullOrEmpty(secretAccessKey))
            {
                throw new ArgumentNullException("secretAccessKey", "secretAccessKey cannot be null or empty.");
            }
            var properties = new List<KeyValuePair<string, string>>();
            properties.Add(new KeyValuePair<string, string>(AccessKeyPropertyName, accessKey));
            properties.Add(new KeyValuePair<string, string>(SecretKeyPropertyName, secretAccessKey));
            if (!string.IsNullOrEmpty(token))
            {
                properties.Add(new KeyValuePair<string, string>(TokenPropertyName, token));
            }
            credentialsFile.EditSection(profileName, properties);
        }

        /// <summary>
        /// Deletes the section with the given ProfileName from the SharedCredentialsFile, if one exists.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="profileName">The ProfileName of the section to delete.</param>
        public void DeleteProfile(string profileName)
        {
            credentialsFile.DeleteSection(profileName);
        }

        /// <summary>
        /// Persist any changes to disk.
        /// </summary>
        public void Persist()
        {
            credentialsFile.Persist();
        }

        private AWSCredentials GetAWSCredentials(string profileName, bool throwIfInvalid)
        {
            Dictionary<string, string> properties;
            if (TryGetSection(profileName, out properties))
            {
                var detector = new ProfileTypeDetector(properties);

                switch (detector.ProfileType)
                {
                    case ProfileType.Basic:
                        return new BasicAWSCredentials(detector.AccessKey, detector.SecretKey);
                    case ProfileType.Session:
                        return new SessionAWSCredentials(detector.AccessKey, detector.SecretKey, detector.Token);
                    case ProfileType.AssumeRole:
                    case ProfileType.AssumeRoleExternal:
                    case ProfileType.AssumeRoleMFA:
                    case ProfileType.AssumeRoleExternalMFA:
                        Dictionary<string, string> sourceProperties;
                        if (TryGetSection(detector.SourceProfile, out sourceProperties))
                        {
                            var sourceDetector = new ProfileTypeDetector(sourceProperties);
                            if (sourceDetector.ProfileType == ProfileType.Basic)
                            {
                                var sourceCredentials = new BasicAWSCredentials(sourceDetector.AccessKey, sourceDetector.SecretKey);
                                var roleSessionName = RoleSessionNamePrefix + DateTime.UtcNow.Ticks;
                                var options = new AssumeRoleAWSCredentialsOptions()
                                {
                                    ExternalId = detector.ExternalID,
                                    MfaSerialNumber = detector.MfaSerial
                                };
                                return new AssumeRoleAWSCredentials(
                                    sourceCredentials, detector.RoleArn, roleSessionName, options);
                            }
                        }

                        if (throwIfInvalid)
                        {
                            throw new InvalidDataException(string.Format(CultureInfo.InvariantCulture,
                               "Credential profile [{0}] references source profile [{1}], which was not found, or is invalid.", profileName, detector.SourceProfile));
                        }
                        else
                        {
                            return null;
                        }
                    case ProfileType.Invalid:
                    default:
                        if (throwIfInvalid)
                        {
                            throw new InvalidDataException(string.Format(CultureInfo.InvariantCulture,
                                "Credential profile [{0}] was not found, or is invalid.", profileName));
                        }
                        else
                        {
                            return null;
                        }
                }
            }
            return null;
        }

        /// <summary>
        /// Try to get a profile that may be partially in the credentials file and partially in the config file.
        /// If there are any properties in both files, the properties in the credentials file take precedence.
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

        private enum ProfileType
        {
            Basic,
            Session,
            AssumeRole,
            AssumeRoleMFA,
            AssumeRoleExternal,
            AssumeRoleExternalMFA,
            Invalid
        }

        private class ProfileTypeDetector
        {
            public readonly string[] ProfileBasic = new string[] { AccessKeyPropertyName, SecretKeyPropertyName };
            public readonly string[] ProfileSession = new string[] { AccessKeyPropertyName, SecretKeyPropertyName, TokenPropertyName };
            public readonly string[] ProfileAssumeRole = new string[] { SourceProfilePropertyName, RoleArnPropertyName };
            public readonly string[] ProfileAssumeRoleMFA = new string[] { SourceProfilePropertyName, RoleArnPropertyName, MFASerialPropertyName };
            public readonly string[] ProfileAssumeRoleExternal = new string[] { SourceProfilePropertyName, RoleArnPropertyName, ExternalIDPropertyName };
            public readonly string[] ProfileAssumeRoleExternalMFA = new string[] { SourceProfilePropertyName, RoleArnPropertyName, ExternalIDPropertyName, MFASerialPropertyName };
            public readonly string[] AllKeys = new string[] { AccessKeyPropertyName, SecretKeyPropertyName, TokenPropertyName, SourceProfilePropertyName, RoleArnPropertyName, MFASerialPropertyName, ExternalIDPropertyName };

            private string accessKey = null;
            private string secretKey = null;
            private string token = null;
            private string sourceProfile = null;
            private string roleArn = null;
            private string mfaSerial = null;
            private string externalID = null;

            public string AccessKey { get { return accessKey; } }
            public string SecretKey { get { return secretKey; } }
            public string Token { get { return token; } }
            public string SourceProfile { get { return sourceProfile; } }
            public string RoleArn { get { return roleArn; } }
            public string MfaSerial { get { return mfaSerial; } }
            public string ExternalID { get { return externalID; } }

            public ProfileType ProfileType { get; private set; }

            public ProfileTypeDetector(Dictionary<string, string> properties)
            {
                properties.TryGetValue(AccessKeyPropertyName, out accessKey);
                properties.TryGetValue(SecretKeyPropertyName, out secretKey);
                properties.TryGetValue(TokenPropertyName, out token);
                properties.TryGetValue(SourceProfilePropertyName, out sourceProfile);
                properties.TryGetValue(RoleArnPropertyName, out roleArn);
                properties.TryGetValue(MFASerialPropertyName, out mfaSerial);
                properties.TryGetValue(ExternalIDPropertyName, out externalID);

                if (HasOnlyExpectedProperties(properties, ProfileBasic))
                {
                    ProfileType = ProfileType.Basic;
                }
                else if (HasOnlyExpectedProperties(properties, ProfileSession))
                {
                    ProfileType = ProfileType.Session;
                }
                else if (HasOnlyExpectedProperties(properties, ProfileAssumeRole))
                {
                    ProfileType = ProfileType.AssumeRole;
                }
                else if (HasOnlyExpectedProperties(properties, ProfileAssumeRoleMFA))
                {
                    ProfileType = ProfileType.AssumeRoleExternalMFA;
                }
                else if (HasOnlyExpectedProperties(properties, ProfileAssumeRoleExternal))
                {
                    ProfileType = ProfileType.AssumeRoleExternal;
                }
                else if (HasOnlyExpectedProperties(properties, ProfileAssumeRoleExternalMFA))
                {
                    ProfileType = ProfileType.AssumeRoleExternalMFA;
                }
                else
                {
                    ProfileType = ProfileType.Invalid;
                }
            }

            private bool HasOnlyExpectedProperties(IEnumerable<KeyValuePair<string, string>> properties, string[] expectedProperties)
            {
                // count of all properties that matter for a credentials profile
                var numRelevantProperties = properties.Count(pair => AllKeys.Contains(pair.Key) && !string.IsNullOrEmpty(pair.Value));
                // count of all expected properties
                var numExpectedProperties = properties.Count(pair => expectedProperties.Contains(pair.Key) && !string.IsNullOrEmpty(pair.Value));

                // assumes that the readonly arrays are set up correctly and that expectedProperties is a subset of AllKeys
                return numExpectedProperties == expectedProperties.Length && numRelevantProperties == numExpectedProperties;
            }
        }
    }
}