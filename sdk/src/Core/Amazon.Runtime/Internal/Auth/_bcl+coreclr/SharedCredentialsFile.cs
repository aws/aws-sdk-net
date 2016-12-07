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
        public ImmutableCredentials GetCredentials(string profileName)
        {
            return GetCredentials(profileName, true);
        }

        /// <summary>
        /// Return the credentials for the profile if valid credentials can be found.
        /// </summary>
        /// <param name="profileName">name of profile to find credentials for</param>
        /// <param name="credentials">the credentials for the profile</param>
        /// <returns>true if the profile was found and it contained valid credentials, false otherwise</returns>
        public bool TryGetCredentials(string profileName, out ImmutableCredentials credentials)
        {
            credentials = GetCredentials(profileName, false);
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

        private ImmutableCredentials GetCredentials(string profileName, bool throwIfInvalid)
        {
            Dictionary<string, string> properties;
            if (iniFile.TryGetSection(profileName, out properties))
            {
                string accessKey = null;
                string secretKey = null;
                string token = null;
                properties.TryGetValue(accessKeyPropertyName, out accessKey);
                properties.TryGetValue(secretKeyPropertyName, out secretKey);
                properties.TryGetValue(tokenPropertyName, out token);

                if (string.IsNullOrEmpty(accessKey) || string.IsNullOrEmpty(secretKey))
                {
                    if (throwIfInvalid)
                    {
                        throw new InvalidDataException(string.Format(CultureInfo.InvariantCulture,
                                                                    "Credential profile [{0}] does not contain valid access and/or secret key materials.", 
                                                                    profileName));
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return new ImmutableCredentials(accessKey, secretKey, token);
                }
            }
            else
            {
                return null;
            }
        }

    }
}