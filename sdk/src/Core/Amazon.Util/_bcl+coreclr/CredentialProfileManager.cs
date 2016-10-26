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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Settings;
using System;
using System.Collections.Generic;
using System.IO;

#if CORECLR
using System.Runtime.InteropServices;
#endif

namespace Amazon.Util
{
    /// <summary>
    /// Manager to Register, Unregister, and retrieve CredentialProfiles
    /// from the shared credentials file and/or the .NET SDK's encrypted store.
    ///
    /// <para>
    /// The shared credentials file is an .ini file shared with the AWS CLI.
    /// By default the file is stored at .\.aws\credentials under the
    /// current user's home directory.
    /// </para>
    /// <para>
    /// The .NET SDK's encrypted store is available in Windows only and
    /// is encrypted using Windows Data Protection API.
    /// It can be found at .\Local\AWSToolkit\RegisteredAccounts.json
    /// under the current user's AppData folder.
    /// </para>
    /// </summary>
    public class CredentialProfileManager
    {
        public const string DefaultProfileName = "default";

        private static readonly string DefaultSharedCredentialsFileDirectory;
        private static readonly string DefaultSharedCredentialsFilePath;
        private ICredentialProfileStore primaryStore;
        private List<ICredentialProfileStore> profileStoreChain;

        static CredentialProfileManager()
        {
            var baseDirectory = "~";

            if (IsWindows)
            {
                baseDirectory =
                    Environment.GetEnvironmentVariable("HOME") ??
                    Environment.GetEnvironmentVariable("USERPROFILE") ??
#if CORECLR
                    Directory.GetCurrentDirectory();
#else
                    Environment.CurrentDirectory;
#endif
            }

            DefaultSharedCredentialsFileDirectory = Path.Combine(baseDirectory, ".aws");
            DefaultSharedCredentialsFilePath = Path.Combine(DefaultSharedCredentialsFileDirectory, "credentials");
        }

        /// <summary>
        /// Construct a CredentialProfileManager using the default path for the credentials file.
        /// If the encrypted store is supported on the platform being used, the CredentialProfileManager
        /// will give preference to the encrypted store when creating and retrieving CredentialProfiles.
        /// </summary>
        public CredentialProfileManager()
        {
            Setup(DefaultSharedCredentialsFilePath, false);
        }

        /// <summary>
        /// Construct a CredentialProfileManager using the given path for the credentials file.
        /// The CredentialProfileManager will give preference to the credentials file when
        /// creating and retrieving CredentialProfiles, even if the encrypted store is available.
        /// </summary>
        /// <remarks>
        /// Note: If sharedCredentialsFilePath is null or empty, the default path will be used
        /// and preference will be given to the encrypted store.
        /// </remarks>
        /// <param name="sharedCredentialsFilePath">The path to the shared credential file.</param>
        public CredentialProfileManager(string sharedCredentialsFilePath)
        {
            if (string.IsNullOrEmpty(sharedCredentialsFilePath))
            {
                Setup(DefaultSharedCredentialsFilePath, false);
            }
            else
            {
                Setup(sharedCredentialsFilePath, true);
            }
        }

        private void Setup(string sharedCredentialsFilePath, bool defaultToSharedCredentialsFile)
        {
            var credentialsFileDirectory = Path.GetDirectoryName(sharedCredentialsFilePath);
            if (!Directory.Exists(credentialsFileDirectory))
            {
                Directory.CreateDirectory(credentialsFileDirectory);
            }

            profileStoreChain = new List<ICredentialProfileStore>();
            profileStoreChain.Add(new SharedCredentialsFile(sharedCredentialsFilePath));

            var sdkStoreAvailable = UserCrypto.IsUserCryptAvailable;
            if (sdkStoreAvailable)
            {
                // add the encrypted store and make it first or second depending the default
                profileStoreChain.Insert(defaultToSharedCredentialsFile ? 1 : 0, new AWSSDKProfileStore());
            }
            primaryStore = profileStoreChain[0];
        }

        /// <summary>
        /// Get a list of the names of available, valid CredentialProfiles.
        /// </summary>
        /// <returns></returns>
        public List<string> ListProfileNames()
        {
            var names = new List<string>();
            foreach (var store in profileStoreChain)
            {
                foreach (var name in store.ListProfileNames())
                {
                    if (!names.Contains(name))
                    {
                        names.Add(name);
                    }
                }
            }
            return names;
        }

        /// <summary>
        /// Get a list of available, valid CredentialProfiles.
        /// </summary>
        /// <returns></returns>
        public List<CredentialProfile> ListProfiles()
        {
            List<CredentialProfile> profiles = new List<CredentialProfile>();
            foreach (var name in ListProfileNames())
            {
                CredentialProfile profile = null;
                if (TryGetProfile(name, out profile))
                {
                    profiles.Add(profile);
                }
            }
            return profiles;
        }

        /// <summary>
        /// Get the default profile, if one exists.
        /// </summary>
        /// <param name="profile">The default profile.</param>
        /// <returns>True if the default profile was found, false otherwise.</returns>
        public bool TryGetDefaultProfile(out CredentialProfile profile)
        {
            return TryGetProfile(DefaultProfileName, out profile);
        }

        /// <summary>
        /// Find a CredentialProfile with the given name.
        /// Searches the credentials file and the encrypted store, if available.
        /// If the CredentialProfile exists in both places, this method will give precedence
        /// based on how this CredentialProfileManager was constructed.
        /// </summary>
        /// <param name="profileName">The name of the CredentialProfile to find.</param>
        /// <param name="profile">The CredentialProfile if found, null otherwise.</param>
        /// <returns>True if the CredentialProfile was found, null otherwise.</returns>
        public bool TryGetProfile(string profileName, out CredentialProfile profile)
        {
            foreach (var store in profileStoreChain)
            {
                if (store.TryGetProfile(profileName, out profile))
                {
                    return true;
                }
            }
            profile = null;
            return false;
        }

        /// <summary>
        /// Register a default CredentialProfile, or update the existing one.
        /// The CredentialProfile will either be persisted to the credentials file or the encrypted store.
        /// The destination of the new CredentialProfile depends on the availability of the encrypted store,
        /// and how this CredentialProfileManager was constructed.
        /// </summary>
        /// <param name="profileOptions">The options to save as the default profile.</param>
        public void RegisterDefaultProfile(CredentialProfileOptions profileOptions)
        {
            RegisterProfile(DefaultProfileName, profileOptions);
        }

        /// <summary>
        /// Register a new CredentialProfile, or update an existing one with the same name.
        /// The CredentialProfile will either be persisted to the credentials file or the encrypted store.
        /// The destination of the new CredentialProfile depends on the availability of the encrypted store,
        /// and how this CredentialProfileManager was constructed.
        /// </summary>
        /// <param name="profileName">The name of the CredentialProfile.</param>
        /// <param name="profileOptions">The options to save.</param>
        public void RegisterProfile(string profileName, CredentialProfileOptions profileOptions)
        {
            var profile = new CredentialProfile(profileName, profileOptions, primaryStore);
            profile.Persist();
        }

        /// <summary>
        /// Delete the default profile.
        /// Deletes default profiles from both the credentials file and the encrypted store regardless of
        /// how this CredentialProfileManager was constructed.
        /// </summary>
        public void UnregisterDefaultProfile()
        {
            UnregisterProfile(DefaultProfileName);
        }

        /// <summary>
        /// Delete any CredentialProfiles with the name given.
        /// Deletes CredentialProfiles from both the credentials file and the encrypted store regardless of
        /// how this CredentialProfileManager was constructed.
        /// </summary>
        /// <param name="profileName">The name of the CredentialProfile to delete.</param>
        public void UnregisterProfile(string profileName)
        {
            foreach (var store in profileStoreChain)
            {
                store.UnregisterProfile(profileName);
            }
        }

        private static bool IsWindows
        {
            get
            {
#if CORECLR
                try
                {
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                        return false;

                    if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                        return false;
                }
                catch
                {
                }
#endif
                return true;
            }
        }

    }
}
