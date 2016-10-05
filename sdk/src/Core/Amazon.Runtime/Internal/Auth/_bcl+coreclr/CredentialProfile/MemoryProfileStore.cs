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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal.Auth.CredentialProfile
{
    /// <summary>
    /// An IProfileStore that holds Profiles in memory.
    /// </summary>
    public class MemoryProfileStore : IProfileStore
    {
        public Dictionary<string, Profile> Profiles { get; private set; }

        public MemoryProfileStore()
            : this(new Dictionary<string, Profile>())
        {
        }

        public MemoryProfileStore(Dictionary<string, Profile> initialProfileMap)
        {
            Profiles = initialProfileMap;
        }

        public void AddOrUpdateProfile(Profile profile)
        {
            Profiles[profile.Name] = profile;
        }

        public void DeleteProfile(string profileName)
        {
            if (Profiles.ContainsKey(profileName))
            {
                Profiles.Remove(profileName);
            }
        }

        public Profile GetProfile(string profileName)
        {
            Profile profile = null;
            Profiles.TryGetValue(profileName, out profile);
            return profile;
        }

        public bool TryGetProfile(string profileName, out Profile profile)
        {
            return Profiles.TryGetValue(profileName, out profile);
        }
    }
}
