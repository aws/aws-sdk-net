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
using Amazon.Runtime.Internal.Settings;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Amazon.Runtime.CredentialManagement
{
    /// <summary>
    /// This class allows profiles supporting AWSCredentials to be registered with
    /// the SDK so that they can later be reference by a profile name. The credential profiles will be available
    /// for use in the AWS Toolkit for Visual Studio and the AWS Tools for Windows PowerShell.
    /// <para>
    /// The credentials are stored under the current users AppData folder encrypted using Windows Data Protection API.
    /// </para>
    /// <para>
    /// This class is not threadsafe.
    /// </para>
    /// </summary>
    public class NetSDKCredentialsFile : ICredentialProfileStore
    {
        public const string DefaultProfileName = "Default";

        // Values kept from ProfileManager to support backward compatibility.
        private const string AWSCredentialsProfileType = "AWS";
        private const string SAMLRoleProfileType = "SAML";

        private const string RegionField = "Region";

        private static readonly HashSet<string> ReservedPropertyNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            SettingsConstants.DisplayNameField,
            SettingsConstants.ProfileTypeField,
            RegionField
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

        private NamedSettingsManager settingsManager;

        public NetSDKCredentialsFile()
        {
            settingsManager = new NamedSettingsManager(SettingsConstants.RegisteredProfiles);
        }

        public List<string> ListProfileNames()
        {
            return ListProfiles().Select(p => p.Name).ToList();
        }

        public List<CredentialProfile> ListProfiles()
        {
            var profiles = new List<CredentialProfile>();
            foreach (var profileName in settingsManager.ListObjectNames())
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
            string uniqueKeyStr;
            if (settingsManager.TryGetObject(profileName, out uniqueKeyStr, out properties))
            {
                try
                {
                    CredentialProfileOptions profileOptions;
                    Dictionary<string, string> userProperties;
                    Dictionary<string, string> reservedProperties;
                    PropertyMapping.ExtractProfileParts(properties, ReservedPropertyNames,out profileOptions, out reservedProperties, out userProperties);

                    string regionString;
                    RegionEndpoint region = null;
                    if (reservedProperties.TryGetValue(RegionField, out regionString))
                    {
                        region = RegionEndpoint.GetBySystemName(regionString);
                    }

                    Guid? uniqueKey = null;
                    if (!GuidUtils.TryParseNullableGuid(uniqueKeyStr, out uniqueKey))
                    {
                        profile = null;
                        return false;
                    }

                    profile = new CredentialProfile(profileName, profileOptions)
                    {
                        UniqueKey = uniqueKey,
                        Properties = userProperties,
                        Region = region,
                        CredentialProfileStore = this
                    };
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
            if (profile.CanCreateAWSCredentials || profile.Options.IsEmpty)
            {
                var reservedProperties = new Dictionary<string, string>();
                if (profile.CanCreateAWSCredentials)
                {
                    // set profile type field for backward compatibility
                    SetProfileTypeField(reservedProperties, profile.ProfileType.Value);
                }

                if (profile.Region != null)
                    reservedProperties[RegionField] = profile.Region.SystemName;

                var profileDictionary = PropertyMapping.CombineProfileParts(
                    profile.Options, ReservedPropertyNames, reservedProperties, profile.Properties);

                // Set the UniqueKey.  It might change if the unique key is set by the objectManger,
                // or if this is an update to an existing profile.
                string newUniqueKeyStr = settingsManager.RegisterObject(profile.Name, profileDictionary);
                Guid? newUniqueKey;
                if (GuidUtils.TryParseNullableGuid(newUniqueKeyStr, out newUniqueKey))
                    profile.UniqueKey = newUniqueKey;
                profile.CredentialProfileStore = this;
            }
            else
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture,
                    "Unable to register profile {0}.  The CredentialProfileOptions provided is not valid.", profile.Name));
            }
        }

        /// <summary>
        /// If there is a profile in the store with the given name, delete it.
        /// </summary>
        /// <param name="profileName">The name of the profile to delete.</param>
        public void UnregisterProfile(string profileName)
        {
            settingsManager.UnregisterObject(profileName);
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
            settingsManager.RenameObject(oldProfileName, newProfileName, force);
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
            settingsManager.CopyObject(fromProfileName, toProfileName, force);
        }

        /// <summary>
        /// Set the ProfileType field to maintain backward compatibility with ProfileManager.
        /// The value is ignored when it's read back in.
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