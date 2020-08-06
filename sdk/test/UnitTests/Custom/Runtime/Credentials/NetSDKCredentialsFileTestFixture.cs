/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    public class NetSDKCredentialsFileTestFixture : EncryptedStoreTestFixture
    {
        private const string ProfilesFilename = SettingsConstants.RegisteredProfiles + ".json";

        public NetSDKCredentialsFile ProfileStore { get; private set; }

        public NetSDKCredentialsFileTestFixture()
            : this(null)
        {
        }

        public NetSDKCredentialsFileTestFixture(string fileContents)
            : base(ProfilesFilename, fileContents)
        {
            ProfileStore = new NetSDKCredentialsFile();
        }

        public CredentialProfile TestTryGetProfile(string profileName, bool expectProfile, bool expectValidProfile)
        {
            CredentialProfile profile = null;
            Assert.IsTrue(expectProfile == ProfileStore.TryGetProfile(profileName, out profile));
            Assert.IsTrue(expectProfile == (profile != null));
            Assert.IsTrue(!expectProfile || (expectValidProfile == profile.CanCreateAWSCredentials));
            return profile;
        }
    }
}
