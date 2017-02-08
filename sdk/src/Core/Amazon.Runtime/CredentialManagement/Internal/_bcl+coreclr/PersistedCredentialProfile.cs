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
    /// Represents a <see cref="CredentialProfile"/> that's been persisted to an <see cref="ICredentialProfileStore"/>
    /// </summary>
    public class PersistedCredentialProfile
    {
        /// <summary>
        /// The <see cref="CredentialProfile"/> represented by this instance.
        /// </summary>
        public CredentialProfile Profile { get; private set; }

        /// <summary>
        /// The <see cref="ICredentialProfileStore"/> where Profile is persisted.
        /// </summary>
        public ICredentialProfileStore Store { get; private set; }

        internal PersistedCredentialProfile(CredentialProfile profile, ICredentialProfileStore store)
        {
            Profile = profile;
            Store = store;
        }

        public bool TryGetAWSCredentials(out AWSCredentials awsCredentials)
        {
            return AWSCredentialsFactory.TryGetAWSCredentials(Profile, Store, out awsCredentials);
        }
    }
}
