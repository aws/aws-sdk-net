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
    /// Interface to define the necessary operations for a CredentialProfile storage mechanism.
    /// </summary>
    public interface ICredentialProfileStore : ICredentialProfileSource
    {
        /// <summary>
        /// Add the given profile to the store, or update it if one with the same name already exists.
        /// </summary>
        /// <param name="profile"></param>
        void RegisterProfile(CredentialProfile profile);

        /// <summary>
        /// Delete the profile with profileName if it exists.
        /// </summary>
        /// <param name="profileName">The name of the profile to delete.</param>
        void UnregisterProfile(string profileName);

        /// <summary>
        /// Get a list of valid profile names from this store.
        /// Invalid profiles are ignored.
        /// See <see cref="CredentialProfileOptions"/> for more information
        /// about valid profiles.
        /// </summary>
        /// <returns></returns>
        List<string> ListProfileNames();

        /// <summary>
        /// Get a list of valid profiles from this store.
        /// Invalid profiles are ignored.
        /// See <see cref="CredentialProfileOptions"/> for more information
        /// about valid profiles.
        /// </summary>
        /// <returns></returns>
        List<CredentialProfile> ListProfiles();
    }
}
