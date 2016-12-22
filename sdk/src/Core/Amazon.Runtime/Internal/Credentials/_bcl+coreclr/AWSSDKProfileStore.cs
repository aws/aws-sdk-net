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
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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
        private const string AWSCredentialsProfileType = "AWS";
        private const string SAMLRoleProfileType = "SAML";

        private static readonly HashSet<string> ReservedPropertyNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            SettingsConstants.DisplayNameField,
            SettingsConstants.ProfileTypeField
        };

        private static readonly CredentialProfilePropertyMapping PropertyMapping =
            new CredentialProfilePropertyMapping(
                new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "AccessKey", SettingsConstants.AccessKeyField },
#if BCL
                    { "EndpointName", SettingsConstants.EndpointNameField },
#endif
                    { "ExternalID", SettingsConstants.ExternalIDField},
                    { "MfaSerial", SettingsConstants.MfaSerialField},
                    { "RoleArn", SettingsConstants.RoleArnField },
                    { "SecretKey", SettingsConstants.SecretKeyField },
                    { "SourceProfile", SettingsConstants.SourceProfileField },
                    { "Token", SettingsConstants.SessionTokenField },
#if BCL
                    { "UserIdentity", SettingsConstants.UserIdentityField },
#endif
                }
            );

        private EncryptedStoreObjectManager objectManager;

        public AWSSDKProfileStore()
        {
            objectManager = new EncryptedStoreObjectManager(SettingsConstants.RegisteredProfiles);
        }

        public List<string> ListProfileNames()
        {
            return ListProfiles().Select(p => p.Name).ToList();
        }

        public List<CredentialProfile> ListProfiles()
        {
            var profiles = new List<CredentialProfile>();
            foreach (var profileName in objectManager.ListObjectNames())
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
            Dictionary<string, string> properties;
            string uniqueKey;
            if (objectManager.TryGetObject(profileName, out uniqueKey, out properties))
            {
                try
                {
                    CredentialProfileOptions profileOptions;
                    Dictionary<string, string> userProperties;
                    PropertyMapping.ExtractProfileParts(properties, ReservedPropertyNames, out profileOptions, out userProperties);

                    profile = new CredentialProfile(uniqueKey, profileName, profileOptions, userProperties, this);
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
                var reservedProperties = new Dictionary<string, string>();
                // set profile type field for backward compatibility
                SetProfileTypeField(reservedProperties, profile.ProfileType.Value);
                var profileDictionary = PropertyMapping.CombineProfileParts(
                    profile.Options, ReservedPropertyNames, reservedProperties, profile.Properties);

                profile.UniqueKey = objectManager.RegisterObject(profile.Name, profileDictionary);
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
            objectManager.UnregisterObject(profileName);
        }

        /// <summary>
        /// Set the ProfileType field to maintain backward compatibility with ProfileManager.
        /// The value is ignored when CredentialProfileManager reads it back in.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="profileType"></param>
        private static void SetProfileTypeField(Dictionary<string, string> properties, CredentialProfileType profileType)
        {
            if (profileType == CredentialProfileType.Basic)
            {
                properties[SettingsConstants.ProfileTypeField] = AWSCredentialsProfileType;
            }
#if BCL
            else if (profileType == CredentialProfileType.SAMLRole ||
                profileType == CredentialProfileType.SAMLRoleUserIdentity)
            {
                properties[SettingsConstants.ProfileTypeField] = SAMLRoleProfileType;
            }
#endif
            else
            {
                properties[SettingsConstants.ProfileTypeField] = profileType.ToString();
            }
        }
    }
}