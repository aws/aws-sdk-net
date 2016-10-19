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
using Json.LitJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    public class AWSSDKProfileStoreTestFixture : IDisposable
    {
        private const string DisplayNameField = "DisplayName";
        private const string ProfilesFilename = "RegisteredAccounts.json";

        private string OriginalSettingsStoreFolder { get; set; }
        private HashSet<string> OriginalEncryptedKeys { get; set; }

        public string DirectoryPath { get; private set; }
        public AWSSDKProfileStore ProfileStore { get; private set; }

        public AWSSDKProfileStoreTestFixture()
            : this(null)
        {
        }

        public AWSSDKProfileStoreTestFixture(string fileContents)
        {
            PrepareTempFilePaths();
            MockSettingsStoreFolder();
            MockEncryptedKeys();

            if (fileContents != null)
            {
                File.WriteAllText(Path.Combine(DirectoryPath, ProfilesFilename), fileContents);
            }

            ProfileStore = new AWSSDKProfileStore();
        }

        public void Dispose()
        {
            // Don't clean up files if the test is being debugged.
            if (!Debugger.IsAttached)
            {
                Directory.Delete(DirectoryPath, true);
            }
            UnMockSettingsStoreFolder();
            UnMockEncryptedKeys();
        }

        public CredentialProfile TestTryGetProfile(string profileName, bool expectProfile, bool expectValidProfile)
        {
            CredentialProfile profile = null;
            Assert.IsTrue(expectProfile == ProfileStore.TryGetProfile(profileName, out profile));
            Assert.IsTrue(expectProfile == (profile != null));
            Assert.IsTrue(!expectProfile || (expectValidProfile == profile.CanCreateAWSCredentials));
            return profile;
        }

        public void AssertJsonProperty(string profileName, string propertyName, string propertyValue)
        {
            var rootJsonData = JsonMapper.ToObject(new JsonReader(File.ReadAllText(Path.Combine(DirectoryPath, ProfilesFilename))));
            var profileJsonData = GetProfileJsonData(profileName, rootJsonData);

            Assert.IsTrue(profileJsonData.IsObject);
            foreach (string profilePropertyName in profileJsonData.PropertyNames)
            {
                if (string.Equals(propertyName, profilePropertyName, StringComparison.OrdinalIgnoreCase))
                {
                    Assert.AreEqual(propertyValue, profileJsonData[profilePropertyName].ToString());
                    break;
                }
            }
        }

        private JsonData GetProfileJsonData(string displayName, JsonData rootJsonData)
        {
            foreach (string propertyName in rootJsonData.PropertyNames)
            {
                JsonData profileJsonData = rootJsonData[propertyName];
                Assert.IsTrue(profileJsonData.IsObject);
                if (string.Equals(profileJsonData[DisplayNameField].ToString(), displayName, StringComparison.OrdinalIgnoreCase))
                {
                    return profileJsonData;
                }
            }
            throw new Exception("Profile " + displayName + " not found.");
        }

        private void MockSettingsStoreFolder()
        {
            OriginalSettingsStoreFolder = (string)GetSettingsStoreFolderField().GetValue(null);
            GetSettingsStoreFolderField().SetValue(null, DirectoryPath);
        }

        private void UnMockSettingsStoreFolder()
        {
            GetSettingsStoreFolderField().SetValue(null, OriginalSettingsStoreFolder);
        }

        private FieldInfo GetSettingsStoreFolderField()
        {
            return typeof(PersistenceManager).GetField("SettingsStoreFolder", BindingFlags.NonPublic | BindingFlags.Static);
        }

        private void MockEncryptedKeys()
        {
            // mock _encryptedKeys to be empty so that we can easily look at the file for unit testing
            OriginalEncryptedKeys = (HashSet<string>)GetEncryptedKeysField().GetValue(PersistenceManager.Instance);
            GetEncryptedKeysField().SetValue(PersistenceManager.Instance, new HashSet<string>());
        }

        private void UnMockEncryptedKeys()
        {
            GetEncryptedKeysField().SetValue(PersistenceManager.Instance, OriginalEncryptedKeys);
        }

        private FieldInfo GetEncryptedKeysField()
        {
            return typeof(PersistenceManager).GetField("_encryptedKeys", BindingFlags.NonPublic | BindingFlags.Instance);
        }

        private void PrepareTempFilePaths()
        {
            DirectoryPath = Path.Combine(Path.GetTempPath(), GetType().Name, Path.GetRandomFileName());
            Directory.CreateDirectory(DirectoryPath);
        }
    }
}
