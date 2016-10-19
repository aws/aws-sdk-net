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
using Amazon.Runtime.Internal.Settings;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static Amazon.Runtime.Internal.Settings.SettingsCollection;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This class allows profiles supporting AWSCredentials to be registered with
    /// the SDK so that they can later be reference by a profile name. The credential profiles will be available
    /// for use in the AWS Toolkit for Visual Studio and the AWS Tools for Windows PowerShell.
    /// <para>
    /// The credentials are stored under the current users AppData folder encrypted using Windows Data Protection API.
    /// </para>
    public class AWSSDKProfileStore : ICredentialProfileStore
    {
        // Values kept from ProfileManager to support backward compatibility.
        public const string AWSCredentialsProfileType = "AWS";
        public const string SAMLRoleProfileType = "SAML";

        private static readonly CredentialProfilePropertyMapping PropertyMapping =
            new CredentialProfilePropertyMapping(
                new Dictionary<string, string>()
                {
                    { "AccessKey", SettingsConstants.AccessKeyField },
                    { "EndpointName", SettingsConstants.EndpointNameField },
                    { "ExternalID", SettingsConstants.ExternalIDField},
                    { "MfaSerial", SettingsConstants.MfaSerialField},
                    { "RoleArn", SettingsConstants.RoleArnField },
                    { "SecretKey", SettingsConstants.SecretKeyField },
                    { "SourceProfile", SettingsConstants.SourceProfileField },
                    { "Token", SettingsConstants.SessionTokenField },
                    { "UserIdentity", SettingsConstants.UserIdentityField },
                }
            );

        public List<string> ListProfileNames()
        {
            return ListProfiles().Select(p => p.Name).ToList();
        }

        public List<CredentialProfile> ListProfiles()
        {
            var profiles = new List<CredentialProfile>();
            foreach (var profileName in ListAllProfileNames())
            {
                CredentialProfile profile = null;
                if (TryGetProfile(profileName, out profile) && profile.CanCreateAWSCredentials)
                {
                    profiles.Add(profile);
                }
            }
            return profiles;
        }

        /// <summary>
        /// Get the profile with the name given, if it exists in this store.
        /// </summary>
        /// <param name="profileName">The name of the profile to find.</param>
        /// <param name="profile">The profile, if it was found, null otherwise</param>
        /// <returns>True if the profile was found, false otherwise.</returns>
        public bool TryGetProfile(string profileName, out CredentialProfile profile)
        {
            var settingsCollection = GetSettingsCollection();
            ObjectSettings objectSettings = null;
            if (TryGetObjectSettings(profileName, settingsCollection, out objectSettings))
            {
                try
                {
                    profile = new CredentialProfile(profileName, PropertyMapping.Convert(objectSettings), this);
                    return true;
                }
                catch (ArgumentException)
                {
                    profile = null;
                    return false;
                }
            }
            else
            {
                profile = null;
                return false;
            }
        }

        /// <summary>
        /// Add the profile to this store, if it's valid.
        /// </summary>
        /// <param name="profile">The profile to add.</param>
        public void RegisterProfile(CredentialProfile profile)
        {
            if (profile.CanCreateAWSCredentials)
            {
                var settingsCollection = GetSettingsCollection();
                ObjectSettings objectSettings = null;
                if (TryGetObjectSettings(profile.Name, settingsCollection, out objectSettings))
                {
                    // clear it out - we'll be overwriting the whole thing with the new profile
                    objectSettings.Clear();
                }
                else
                {
                    objectSettings = settingsCollection.NewObjectSettings(Guid.NewGuid().ToString());
                }

                objectSettings[SettingsConstants.DisplayNameField] = profile.Name;
                SetProfileTypeField(objectSettings, profile.ProfileType.Value);

                foreach (var pair in PropertyMapping.Convert(profile.Options))
                {
                    objectSettings[pair.Key] = pair.Value;
                }

                PersistenceManager.Instance.SaveSettings(SettingsConstants.RegisteredProfiles, settingsCollection);
            }
            else
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture,
                    "Unable to register profile {0}.  The CredentialProfile provided is not a valid profile.", profile.Name));
            }
        }

        /// <summary>
        /// If there is a profile in the store with the given name, delete it.
        /// </summary>
        /// <param name="profileName">The name of the profile to delete.</param>
        public void UnregisterProfile(string profileName)
        {
            var settingsCollection = GetSettingsCollection();
            ObjectSettings objectSettings = null;
            if (TryGetObjectSettings(profileName, settingsCollection, out objectSettings))
            {
                settingsCollection.Remove(objectSettings.UniqueKey);
                PersistenceManager.Instance.SaveSettings(SettingsConstants.RegisteredProfiles, settingsCollection);
            }
        }

        /// <summary>
        /// Get a list of all profiles regardless of whether they're valid or not.
        /// </summary>
        /// <returns></returns>
        private static List<string> ListAllProfileNames()
        {
            var settings = PersistenceManager.Instance.GetSettings(SettingsConstants.RegisteredProfiles);
            return settings.Select(os => os.GetValueOrDefault(SettingsConstants.DisplayNameField, null)).ToList();
        }

        /// <summary>
        /// Set the ProfileType field to maintain backward compatibility with ProfileManager.
        /// The value is ignored when CredentialProfileManager reads it back in.
        /// </summary>
        /// <param name="objectSettings"></param>
        /// <param name="profileType"></param>
        private static void SetProfileTypeField(ObjectSettings objectSettings, CredentialProfileType profileType)
        {
            if (profileType == CredentialProfileType.Basic)
            {
                objectSettings[SettingsConstants.ProfileTypeField] = AWSCredentialsProfileType;
            }
            else if (profileType == CredentialProfileType.SAMLRole ||
                profileType == CredentialProfileType.SAMLRoleUserIdentity)
            {
                objectSettings[SettingsConstants.ProfileTypeField] = SAMLRoleProfileType;
            }
            else
            {
                objectSettings[SettingsConstants.ProfileTypeField] = profileType.ToString();
            }
        }

        private static SettingsCollection GetSettingsCollection()
        {
            return PersistenceManager.Instance.GetSettings(SettingsConstants.RegisteredProfiles);
        }

        private static bool TryGetObjectSettings(string profileName, SettingsCollection settingsCollection, out ObjectSettings objectSettings)
        {
            objectSettings = settingsCollection.FirstOrDefault(
                x => string.Equals(x[SettingsConstants.DisplayNameField], profileName, StringComparison.OrdinalIgnoreCase));
            return objectSettings != null;
        }
    }
}