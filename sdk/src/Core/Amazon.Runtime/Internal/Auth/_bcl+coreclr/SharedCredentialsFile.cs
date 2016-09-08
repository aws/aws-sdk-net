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
        private const string accessKeyPropertyName = "aws_access_key_id";
        private const string secretKeyPropertyName = "aws_secret_access_key";
        private const string tokenPropertyName = "aws_session_token";
        private const string sourceProfilePropertyName = "source_profile";
        private const string roleArnPropertyName = "role_arn";
        private const string mfaSerialPropertyName = "mfa_serial";
        private const string externalIDPropertyName = "external_id";

        private IniFile iniFile;

        /// <summary>
        /// Construct a new SharedCredentialsFile.
        /// </summary>
        /// <param name="filePath">path of the shared credentials file</param>
        public SharedCredentialsFile(string filePath)
        {
            iniFile = new IniFile(filePath);
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
        /// <param name="profileName">name of profile to find credentials for</param>
        /// <returns>true if the profile exists and has valid credentials, false otherwise</returns>
        public AWSCredentials GetAWSCredentials(string profileName)
        {
            return GetAWSCredentials(profileName, true);
        }

        /// <summary>
        /// Return the credentials for the profile if valid credentials can be found.
        /// </summary>
        /// <param name="profileName">name of profile to find credentials for</param>
        /// <param name="credentials">the credentials for the profile</param>
        /// <returns>true if the profile was found and it contained valid credentials, false otherwise</returns>
        public bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
        {
            credentials = GetAWSCredentials(profileName, false);
            return credentials != null;
        }

        /// <summary>
        /// Add credentials for the profile given.  If credentials for the profile already exist, update them.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="profileName">name of profile</param>
        /// <param name="accessKey">access key for the credentials</param>
        /// <param name="secretAccessKey">secret access key for the credentials</param>
        public void AddOrUpdateCredentials(string profileName, string accessKey, string secretAccessKey)
        {
            AddOrUpdateCredentials(profileName, accessKey, secretAccessKey, null);
        }

        /// <summary>
        /// Add credentials for the profile given.  If credentials for the profile already exist, update them.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="profileName">name of profile</param>
        /// <param name="accessKey">access key for the credentials</param>
        /// <param name="secretAccessKey">secret access key for the credentials</param>
        /// <param name="token">token for the credentials</param>
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
            properties.Add(new KeyValuePair<string, string>(accessKeyPropertyName, accessKey));
            properties.Add(new KeyValuePair<string, string>(secretKeyPropertyName, secretAccessKey));
            if (!string.IsNullOrEmpty(token))
            {
                properties.Add(new KeyValuePair<string, string>(tokenPropertyName, token));
            }
            iniFile.EditSection(profileName, properties);
        }

        /// <summary>
        /// Deletes the section with the given ProfileName from the SharedCredentialsFile, if one exists.
        /// Changes are not written to disk until the Persist() method is called.
        /// </summary>
        /// <param name="profileName">ProfileName of section to delete</param>
        public void DeleteProfile(string profileName)
        {
            iniFile.DeleteSection(profileName);
        }

        /// <summary>
        /// Persist any changes to disk.
        /// </summary>
        public void Persist()
        {
            iniFile.Persist();
        }

        private AWSCredentials GetAWSCredentials(string profileName, bool throwIfInvalid)
        {
            Dictionary<string, string> properties;
            if (iniFile.TryGetSection(profileName, out properties))
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
                        if (throwIfInvalid)
                        {
                            throw new InvalidDataException(string.Format(CultureInfo.InvariantCulture,
                                "Credential profile [{0}] uses the source_profile key, which is not yet supported by the .NET SDK.", profileName));
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
            public readonly string[] ProfileBasic = new string[] { accessKeyPropertyName, secretKeyPropertyName };
            public readonly string[] ProfileSession = new string[] { accessKeyPropertyName, secretKeyPropertyName, tokenPropertyName };
            public readonly string[] ProfileAssumeRole = new string[] { sourceProfilePropertyName, roleArnPropertyName };
            public readonly string[] ProfileAssumeRoleMFA = new string[] { sourceProfilePropertyName, roleArnPropertyName, mfaSerialPropertyName };
            public readonly string[] ProfileAssumeRoleExternal = new string[] { sourceProfilePropertyName, roleArnPropertyName, externalIDPropertyName };
            public readonly string[] ProfileAssumeRoleExternalMFA = new string[] { sourceProfilePropertyName, roleArnPropertyName, externalIDPropertyName, mfaSerialPropertyName };
            public readonly string[] AllKeys = new string[] { accessKeyPropertyName, secretKeyPropertyName, tokenPropertyName, sourceProfilePropertyName, roleArnPropertyName, mfaSerialPropertyName, externalIDPropertyName };

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
            public string MFASerial { get { return mfaSerial; } }
            public string ExternalID { get { return externalID; } }

            public ProfileType ProfileType { get; private set; }

            public ProfileTypeDetector(Dictionary<string, string> properties)
            {
                properties.TryGetValue(accessKeyPropertyName, out accessKey);
                properties.TryGetValue(secretKeyPropertyName, out secretKey);
                properties.TryGetValue(tokenPropertyName, out token);
                properties.TryGetValue(sourceProfilePropertyName, out sourceProfile);
                properties.TryGetValue(roleArnPropertyName, out roleArn);
                properties.TryGetValue(mfaSerialPropertyName, out mfaSerial);
                properties.TryGetValue(externalIDPropertyName, out externalID);

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