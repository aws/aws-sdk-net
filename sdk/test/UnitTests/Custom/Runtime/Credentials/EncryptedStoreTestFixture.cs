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
using Amazon.Runtime.Internal.Settings;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ThirdParty.Json.LitJson;

namespace AWSSDK.UnitTests
{
    public class EncryptedStoreTestFixture : IDisposable
    {
        private const string DisplayNameField = "DisplayName";

        private string OriginalSettingsStoreFolder { get; set; }
        private bool OriginalUserCryptAvailable { get; set; }
        private HashSet<string> OriginalEncryptedKeys { get; set; }

        public string DirectoryPath { get; private set; }
        public string MainFilename { get; private set; }

        public EncryptedStoreTestFixture(string filename)
            : this(filename, null)
        {
        }

        public EncryptedStoreTestFixture(string filename, string fileContents)
            : this(filename, fileContents, true)
        {
        }

        public EncryptedStoreTestFixture(string filename, string fileContents, bool userCryptAvailable)
        {
            MainFilename = filename;
            PrepareTempFilePaths();
            MockSettingsStoreFolder();
            MockEncryptedKeys();
            MockUserCryptAvailable(userCryptAvailable);

            SetFileContents(fileContents);
        }

        public void SetFileContents(string fileContents)
        {
            SetFileContents(MainFilename, fileContents);
        }

        public void SetFileContents(string filename, string fileContents)
        {
            if (fileContents != null)
            {
                File.WriteAllText(Path.Combine(DirectoryPath, filename), fileContents);
            }
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
            UnMockUserCryptAvailable();
        }

        public void AssertFileExists(bool fileExists)
        {
            AssertFileExists(MainFilename, fileExists);
        }

        public void AssertFileExists(string filename, bool fileExists)
        {
            Assert.AreEqual(fileExists, File.Exists(Path.Combine(DirectoryPath, filename)));
        }

        public void AssertFileContents(string fileContents)
        {
            AssertFileContents(MainFilename, fileContents);
        }

        public void AssertFileContents(string filename, string fileContents)
        {
            Assert.AreEqual(fileContents.Trim(), File.ReadAllText(Path.Combine(DirectoryPath, filename)).Trim());
        }

        public void AssertObjectCount(int expectedCount)
        {
            AssertObjectCount(MainFilename, expectedCount);
        }
        public void AssertObjectCount(string filename, int expectedCount)
        {
            Assert.AreEqual(expectedCount, GetObjectCount(filename));
        }

        public int GetObjectCount()
        {
            return GetObjectCount(MainFilename);
        }

        public int GetObjectCount(string filename)
        {
            var rootJsonData = JsonMapper.ToObject(new JsonReader(File.ReadAllText(Path.Combine(DirectoryPath, filename))));
            return rootJsonData.PropertyNames.Count();
        }

        public void AssertJsonProperty(string displayName, string propertyName, string propertyValue)
        {
            AssertJsonProperty(MainFilename, displayName, propertyName, propertyValue);
        }

        public void AssertJsonProperty(string filename, string displayName, string propertyName, string propertyValue)
        {
            var rootJsonData = JsonMapper.ToObject(new JsonReader(File.ReadAllText(Path.Combine(DirectoryPath, filename))));
            var profileJsonData = GetObjectJsonData(displayName, rootJsonData);

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

        public JsonData GetObjectJsonData(string displayName, JsonData rootJsonData)
        {
            foreach (string propertyName in rootJsonData.PropertyNames)
            {
                JsonData profileJsonData = rootJsonData[propertyName];
                Assert.IsTrue(profileJsonData.IsObject);
                if (string.Equals(propertyName, displayName, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(profileJsonData[DisplayNameField].ToString(), displayName, StringComparison.OrdinalIgnoreCase))
                {
                    return profileJsonData;
                }
            }
            throw new Exception("Profile " + displayName + " not found.");
        }

        private void MockSettingsStoreFolder()
        {
            OriginalSettingsStoreFolder = (string)ReflectionHelpers.Invoke(typeof(PersistenceManager), "SettingsStoreFolder");
            ReflectionHelpers.Invoke(typeof(PersistenceManager), "SettingsStoreFolder", DirectoryPath);
        }

        private void UnMockSettingsStoreFolder()
        {
            ReflectionHelpers.Invoke(typeof(PersistenceManager), "SettingsStoreFolder", OriginalSettingsStoreFolder);
        }

        private void MockEncryptedKeys()
        {
            // mock _encryptedKeys to be empty so that we can easily look at the file for unit testing
            OriginalEncryptedKeys = (HashSet<string>)ReflectionHelpers.Invoke(PersistenceManager.Instance, "_encryptedKeys");
            ReflectionHelpers.Invoke(PersistenceManager.Instance, "_encryptedKeys", new HashSet<string>());
        }

        private void UnMockEncryptedKeys()
        {
            ReflectionHelpers.Invoke(PersistenceManager.Instance, "_encryptedKeys", OriginalEncryptedKeys);
        }


        private void MockUserCryptAvailable(bool userCryptAvailable)
        {
            OriginalUserCryptAvailable = UserCrypto.IsUserCryptAvailable;
            ReflectionHelpers.Invoke(typeof(UserCrypto), "_isUserCryptAvailable", userCryptAvailable);
        }

        private void UnMockUserCryptAvailable()
        {
            ReflectionHelpers.Invoke(typeof(UserCrypto), "_isUserCryptAvailable", OriginalUserCryptAvailable);
        }

        private void PrepareTempFilePaths()
        {
            DirectoryPath = Path.Combine(Path.Combine(Path.GetTempPath(), GetType().Name), Path.GetRandomFileName());
            Directory.CreateDirectory(DirectoryPath);
        }
    }
}
