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
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// An IProfileStore that holds Profiles in memory.
    /// </summary>
    public class MemoryCredentialProfileStore : ICredentialProfileStore
    {
        public Dictionary<string, CredentialProfile> Profiles { get; private set; }

        public MemoryCredentialProfileStore()
            : this(new Dictionary<string, CredentialProfile>())
        {
        }

        public MemoryCredentialProfileStore(Dictionary<string, CredentialProfile> initialProfileMap)
        {
            Profiles = initialProfileMap;
        }

        public void RegisterProfile(CredentialProfile profile)
        {
            profile.ProfileStore = this;
            Profiles[profile.Name] = profile;
        }

        public void UnregisterProfile(string profileName)
        {
            if (Profiles.ContainsKey(profileName))
            {
                Profiles.Remove(profileName);
            }
        }

        public CredentialProfile GetProfile(string profileName)
        {
            CredentialProfile profile = null;
            Profiles.TryGetValue(profileName, out profile);
            return profile;
        }

        public bool TryGetProfile(string profileName, out CredentialProfile profile)
        {
            return Profiles.TryGetValue(profileName, out profile);
        }

        public List<string> ListProfileNames()
        {
            return new List<string>(Profiles.Keys);
        }

        public List<CredentialProfile> ListProfiles()
        {
            return new List<CredentialProfile>(Profiles.Values);
        }
    }
}
