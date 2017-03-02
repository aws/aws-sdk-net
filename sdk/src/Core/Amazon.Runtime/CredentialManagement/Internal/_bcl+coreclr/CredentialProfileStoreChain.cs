/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Collections.Generic;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Settings;
using System.Linq;

namespace Amazon.Runtime.CredentialManagement.Internal
{
    /// <summary>
    /// Class to abstract the combined use of NetSDKCredentialsFile and SharedCredentialsFile where possible.
    /// </summary>
    /// <returns></returns>
    public class CredentialProfileStoreChain : ICredentialProfileSource
    {
        /// <summary>
        /// The location of the shared credentials file, or null to use the default location.
        /// </summary>
        public string ProfilesLocation { get; private set; }

        /// <summary>
        /// Construct a CredentialProfileChain.
        /// </summary>
        public CredentialProfileStoreChain()
            : this(null)
        {
        }

        /// <summary>
        /// Construct a CredentialProfileChain.
        /// </summary>
        /// <param name="profilesLocation">The path to the aws credentials file to look at.</param>
        public CredentialProfileStoreChain(string profilesLocation)
        {
            ProfilesLocation = profilesLocation;
        }

        /// <summary>
        /// Tries to get a profile based on these rules:
        /// <list type="table">
        /// <listheader>
        /// <term>ProfilesLocation</term>
        /// <term>Platform Supports .NET SDK Credentials File</term>
        /// <term>Action</term>
        /// </listheader>
        /// <item>
        /// <term>null or empty</term>
        /// <term>yes</term>
        /// <term>search sdk credentials file then shared credentials file in default location</term>
        /// </item>
        /// <item>
        /// <term>null or empty</term>
        /// <term>no</term>
        /// <term>search shared credentials file in the default location</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>yes</term>
        /// <term>search shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>no</term>
        /// <term>search shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName">The name of the profile to get.</param>
        /// <param name="profile">The profile, if found</param>
        /// <returns>True if the profile was found, false otherwise.</returns>
        /// <returns></returns>
        public bool TryGetProfile(string profileName, out CredentialProfile profile)
        {
            PersistedCredentialProfile persistedProfile;
            if (TryGetPersistedProfile(profileName, out persistedProfile))
            {
                profile = persistedProfile.Profile;
                return true;
            }
            else
            {
                profile = null;
                return false;
            }
        }

        /// <summary>
        /// Tries to get a persisted profile based on these rules:
        /// <list type="table">
        /// <listheader>
        /// <term>ProfilesLocation</term>
        /// <term>Platform Supports .NET SDK Credentials File</term>
        /// <term>Action</term>
        /// </listheader>
        /// <item>
        /// <term>null or empty</term>
        /// <term>yes</term>
        /// <term>search sdk credentials file then shared credentials file in default location</term>
        /// </item>
        /// <item>
        /// <term>null or empty</term>
        /// <term>no</term>
        /// <term>search shared credentials file in the default location</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>yes</term>
        /// <term>search shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>no</term>
        /// <term>search shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName">The name of the profile to get.</param>
        /// <param name="persistedProfile">The persisted profile, if found</param>
        /// <returns>True if the profile was found, false otherwise.</returns>
        public bool TryGetPersistedProfile(string profileName, out PersistedCredentialProfile persistedProfile)
        {
            if (string.IsNullOrEmpty(ProfilesLocation) && UserCrypto.IsUserCryptAvailable)
            {
                var netCredentialsFile = new NetSDKCredentialsFile();
                CredentialProfile netProfile;
                if (netCredentialsFile.TryGetProfile(profileName, out netProfile))
                {
                    persistedProfile = new PersistedCredentialProfile(netProfile, netCredentialsFile);
                    return true;
                }
            }

            var sharedCredentialsFile = new SharedCredentialsFile(ProfilesLocation);
            CredentialProfile sharedProfile;
            if (sharedCredentialsFile.TryGetProfile(profileName, out sharedProfile))
            {
                persistedProfile = new PersistedCredentialProfile(sharedProfile, sharedCredentialsFile);
                return true;
            }

            persistedProfile = null;
            return false;
        }

        /// <summary>
        /// List profiles based on these rules:
        /// <list type="table">
        /// <listheader>
        /// <term>ProfilesLocation</term>
        /// <term>Platform Supports .NET SDK Credentials File</term>
        /// <term>Action</term>
        /// </listheader>
        /// <item>
        /// <term>null or empty</term>
        /// <term>yes</term>
        /// <term>include profiles from sdk credentials file and shared credentials file in default location</term>
        /// </item>
        /// <item>
        /// <term>null or empty</term>
        /// <term>no</term>
        /// <term>include profiles from shared credentials file in the default location</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>yes</term>
        /// <term>include profiles from shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>no</term>
        /// <term>include profiles from shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// </list>
        /// </summary>
        /// <returns>A list of persisted profiles.</returns>
        public List<PersistedCredentialProfile> ListPersistedProfiles()
        {
            var profiles = new List<PersistedCredentialProfile>();

            if (string.IsNullOrEmpty(ProfilesLocation) && UserCrypto.IsUserCryptAvailable)
            {
                var netSdkFile = new NetSDKCredentialsFile();
                profiles.AddRange(netSdkFile.ListProfiles().Select(p => new PersistedCredentialProfile(p, netSdkFile)));
            }
            var sharedFile = new SharedCredentialsFile(ProfilesLocation);
            profiles.AddRange(sharedFile.ListProfiles().Select(p => new PersistedCredentialProfile(p, sharedFile)));

            return profiles;
        }

        /// <summary>
        /// Register a profile based on these rules:
        /// <list type="table">
        /// <listheader>
        /// <term>ProfilesLocation</term>
        /// <term>Platform Supports .NET SDK Credentials File</term>
        /// <term>Action</term>
        /// </listheader>
        /// <item>
        /// <term>null or empty</term>
        /// <term>yes</term>
        /// <term>register in sdk credentials file</term>
        /// </item>
        /// <item>
        /// <term>null or empty</term>
        /// <term>no</term>
        /// <term>register in shared credentials file in the default location</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>yes</term>
        /// <term>register in shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>no</term>
        /// <term>register in shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profile">The profile to register.</param>
        public void RegisterProfile(CredentialProfile profile)
        {
            if (string.IsNullOrEmpty(ProfilesLocation) && UserCrypto.IsUserCryptAvailable)
            {
                new NetSDKCredentialsFile().RegisterProfile(profile);
            }
            else
            {
                new SharedCredentialsFile(ProfilesLocation).RegisterProfile(profile);
            }
        }

        /// <summary>
        /// Unregister a profile based on these rules:
        /// <list type="table">
        /// <listheader>
        /// <term>ProfilesLocation</term>
        /// <term>Platform Supports .NET SDK Credentials File</term>
        /// <term>Action</term>
        /// </listheader>
        /// <item>
        /// <term>null or empty</term>
        /// <term>yes</term>
        /// <term>unregister from sdk credentials file, if not there unregister from shared credentials file in default location</term>
        /// </item>
        /// <item>
        /// <term>null or empty</term>
        /// <term>no</term>
        /// <term>unregister from shared credentials file in the default location</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>yes</term>
        /// <term>unregister from shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// <item>
        /// <term>non-null and non-empty</term>
        /// <term>no</term>
        /// <term>unregister from shared credentials file at disk path: profilesLocation</term>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="profileName">The name of the profile to unregister.</param>
        public void UnregisterProfile(string profileName)
        {
            PersistedCredentialProfile persistedProfile;
            if (TryGetPersistedProfile(profileName, out persistedProfile))
            {
                persistedProfile.Store.UnregisterProfile(profileName);
            }
        }
    }
}
