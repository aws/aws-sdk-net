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
using Amazon.Runtime.Internal.Settings;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    public class CredentialProfileManagerTestFixture : IDisposable
    {
        public SharedCredentialsFileTestFixture SharedCredentialsFixture { get; private set; }
        public NetSDKCredentialsFileTestFixture SdkFixture { get; private set; }
        public CredentialProfileManager ProfileManager { get; private set; }

        public CredentialProfileManagerTestFixture(bool sdkStoreAvailable, bool defaultToCredentialsFile)
        {
            SharedCredentialsFixture = new SharedCredentialsFileTestFixture();
            SdkFixture = new NetSDKCredentialsFileTestFixture();
            if (!sdkStoreAvailable)
            {
                MockSdkStoreAvailable(false);
            }
            ProfileManager = new CredentialProfileManager();
            // Using a non-default shared credentials file location and defaulting to the encrypted store
            // isn't a normal operating mode.  So use reflection.
            ReflectionHelpers.Invoke(ProfileManager, "Setup", SharedCredentialsFixture.CredentialsFile.FilePath, defaultToCredentialsFile);
        }

        public void AssertProfileDoesNotExistCredentials(string profileName)
        {
            CredentialProfile profile;
            Assert.IsFalse(SharedCredentialsFixture.CredentialsFile.TryGetProfile(profileName, out profile));
            Assert.IsNull(profile);
        }

        public void AssertProfileDoesNotExistSDK(string profileName)
        {
            CredentialProfile profile;
            Assert.IsFalse(SdkFixture.ProfileStore.TryGetProfile(profileName, out profile));
            Assert.IsNull(profile);
        }

        public void AssertProfileDoesNotExist(string profileName)
        {
            AssertProfileDoesNotExistSDK(profileName);
            AssertProfileDoesNotExistCredentials(profileName);
        }

        public CredentialProfile AssertProfileExistsCredentials(string profileName)
        {
            CredentialProfile profile;
            Assert.IsTrue(SharedCredentialsFixture.CredentialsFile.TryGetProfile(profileName, out profile));
            Assert.IsNotNull(profile);
            return profile;
        }

        public CredentialProfile AssertProfileExistsSDK(string profileName)
        {
            CredentialProfile profile;
            Assert.IsTrue(SdkFixture.ProfileStore.TryGetProfile(profileName, out profile));
            Assert.IsNotNull(profile);
            return profile;
        }

        public void AssertProfileExists(string profileName)
        {
            AssertProfileDoesNotExistSDK(profileName);
            AssertProfileDoesNotExistCredentials(profileName);
        }

        public void AssertProfileStoreType(CredentialProfile profile, Type expectedType)
        {
            var property = profile.GetType().GetProperty("ProfileStore", BindingFlags.NonPublic | BindingFlags.Instance);
            var value = property.GetValue(profile);
            var actualType = value.GetType();
            Assert.AreEqual(expectedType, actualType);
        }

        private void MockSdkStoreAvailable(bool sdkStoreAvailable)
        {
            typeof(UserCrypto).GetField("_isUserCryptAvailable",
                BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, sdkStoreAvailable);
        }

        public void Dispose()
        {
            SharedCredentialsFixture.Dispose();
            SdkFixture.Dispose();
            MockSdkStoreAvailable(true);
        }
    }
}
