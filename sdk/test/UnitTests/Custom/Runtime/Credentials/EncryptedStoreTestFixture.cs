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
using Json.LitJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    public class EncryptedStoreTestFixture : IDisposable
    {
        private const string DisplayNameField = "DisplayName";

        private string OriginalSettingsStoreFolder { get; set; }
        private HashSet<string> OriginalEncryptedKeys { get; set; }

        public string DirectoryPath { get; private set; }
        public string Filename { get; private set; }
        public string FullPath
        {
            get
            {
                return Path.Combine(DirectoryPath, Filename);
            }
        }

        public EncryptedStoreTestFixture(string filename)
            : this(filename, null)
        {
        }

        public EncryptedStoreTestFixture(string filename, string fileContents)
        {
            Filename = filename;
            PrepareTempFilePaths();
            MockSettingsStoreFolder();
            MockEncryptedKeys();

            SetFileContents(fileContents);
        }

        public void SetFileContents(string fileContents)
        {
            if (fileContents != null)
            {
                File.WriteAllText(Path.Combine(DirectoryPath, Filename), fileContents);
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
        }

        public void AssertFileExists(bool fileExists)
        {
            Assert.AreEqual(fileExists, File.Exists(FullPath));
        }

        public void AssertJsonProperty(string displayName, string propertyName, string propertyValue)
        {
            var rootJsonData = JsonMapper.ToObject(new JsonReader(File.ReadAllText(FullPath)));
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


        public void AssertObjectCount(int expectedCount)
        {
            Assert.AreEqual(expectedCount, GetObjectCount());
        }

        public int GetObjectCount()
        {
            var rootJsonData = JsonMapper.ToObject(new JsonReader(File.ReadAllText(Path.Combine(DirectoryPath, Filename))));
            return rootJsonData.PropertyNames.Count();
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

        private void PrepareTempFilePaths()
        {
            DirectoryPath = Path.Combine(Path.GetTempPath(), GetType().Name, Path.GetRandomFileName());
            Directory.CreateDirectory(DirectoryPath);
        }
    }
}
