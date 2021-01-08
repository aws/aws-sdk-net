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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AWSSDK.UnitTests
{
    public class SharedCredentialsFileTestFixture : IDisposable
    {
        private const string CredentialsFileName = "credentials";
        private const string ConfigFileName = "config";

        public string CredentialsFilePath { get; set; }
        public string ConfigFilePath { get; set; }
        public string DirectoryPath { get; set; }

        public SharedCredentialsFile CredentialsFile { get; private set; }

        public SharedCredentialsFileTestFixture(string credentialsFileContents, string configFileContents = null,
            bool createEmptyFile = false)
        {
            PrepareTempFilePaths();

            if (credentialsFileContents == null)
            {
                if (createEmptyFile)
                {
                    File.WriteAllText(CredentialsFilePath, "");
                }
            }
            else
            {
                File.WriteAllText(CredentialsFilePath, credentialsFileContents);
            }

            if (configFileContents != null)
            {
                File.WriteAllText(ConfigFilePath, configFileContents);
            }

            CredentialsFile = new SharedCredentialsFile(CredentialsFilePath);
        }

        public SharedCredentialsFileTestFixture(bool createEmptyFile = false)
            : this(null, null, createEmptyFile)
        {
        }

        public CredentialProfile ReadAndAssertProfile(string profileName, CredentialProfileOptions expectedProfileOptions,
            RegionEndpoint expectedRegion, Guid? expectedUniqueKey)
        {
            return ReadAndAssertProfile(profileName, expectedProfileOptions, null, expectedRegion, expectedUniqueKey);
        }

        public CredentialProfile ReadAndAssertProfile(string profileName, CredentialProfileOptions expectedProfileOptions,
            Dictionary<string, string> expectedProperties)
        {
            return ReadAndAssertProfile(profileName, expectedProfileOptions, expectedProperties, null, null);
        }

        public CredentialProfile ReadAndAssertProfile(string profileName, CredentialProfileOptions expectedProfileOptions)
        {
            return ReadAndAssertProfile(profileName, expectedProfileOptions, null, null);
        }

        public CredentialProfile ReadAndAssertProfile(string profileName, CredentialProfileOptions expectedProfileOptions,
            Dictionary<string, string> expectedProperties, RegionEndpoint expectedRegion, Guid? expectedUniqueKey)
        {
            var expectedProfile = CredentialProfileTestHelper.GetCredentialProfile(expectedUniqueKey, profileName, expectedProfileOptions,
                expectedProperties, expectedRegion, null, null, null);
            var actualProfile = TestTryGetProfile(profileName, true, expectedProfile.CanCreateAWSCredentials);
            Assert.AreEqual(expectedProfile, actualProfile);
            return actualProfile;
        }

        public CredentialProfile TestTryGetProfile(string profileName, bool expectProfile, bool expectValidProfile)
        {
            CredentialProfile profile = null;
            Assert.IsTrue(expectProfile == CredentialsFile.TryGetProfile(profileName, out profile));
            Assert.IsTrue(expectProfile == (profile != null));
            Assert.IsTrue(!expectProfile || (expectValidProfile == profile.CanCreateAWSCredentials));
            return profile;
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions, string expectedFileContents)
        {
            AssertWriteProfile(profileName, profileOptions, null, (RegionEndpoint)null, expectedFileContents);
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions, RegionEndpoint region, string expectedFileContents)
        {
            AssertWriteProfile(profileName, profileOptions, null, (RegionEndpoint)null, null, expectedFileContents);
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions, RegionEndpoint region, Guid? uniqueKey, string expectedFileContents)
        {
            AssertWriteProfile(profileName, profileOptions, null, region, uniqueKey, expectedFileContents);
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions, Dictionary<string, string> properties, string expectedFileContents)
        {
            AssertWriteProfile(profileName, profileOptions, properties, null, expectedFileContents);
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions, bool endpointDiscoveryEnabled, string expectedFileContents)
        {
            AssertWriteProfile(profileName, profileOptions, null, null, null, endpointDiscoveryEnabled, null, null, expectedFileContents);
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions,
            Dictionary<string, string> properties, RegionEndpoint region, string expectedFileContents)
        { 
            CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(null, profileName, profileOptions, properties, region, null, null, null));
            AssertWriteProfile(profileName, profileOptions, properties, null, null, expectedFileContents);
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions,
            Dictionary<string, string> properties, RegionEndpoint region, Guid? uniqueKey, string expectedFileContents)
        {
            CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(uniqueKey, profileName, profileOptions, properties, region, null, null, null));
            AssertCredentialsFileContents(expectedFileContents);
        }

        public void AssertWriteProfile(string profileName, CredentialProfileOptions profileOptions,
            Dictionary<string, string> properties, RegionEndpoint region, Guid? uniqueKey, bool? endpointDiscoveryEnabled, RequestRetryMode? retryMode, int? maxAttempts, string expectedFileContents)
        {
            CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(uniqueKey, profileName, profileOptions, properties, region, endpointDiscoveryEnabled, retryMode, maxAttempts));
            AssertCredentialsFileContents(expectedFileContents);
        }

        public void AssertWriteProfileRetryMode(string profileName, CredentialProfileOptions profileOptions, RequestRetryMode retryMode, string expectedFileContents)
        {
            CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(null, profileName, profileOptions, null, null, null, retryMode, null));
            AssertCredentialsFileContents(expectedFileContents);
        }

        public void AssertWriteProfileMaxAttempts(string profileName, CredentialProfileOptions profileOptions, int maxAttempts, string expectedFileContents)
        {
            CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(null, profileName, profileOptions, null, null, null, null, maxAttempts));
            AssertCredentialsFileContents(expectedFileContents);
        }

        public void AssertCredentialsFileContents(string expectedContents)
        {
            Assert.AreEqual(expectedContents, File.ReadAllText(CredentialsFilePath));
        }

        public void Dispose()
        {
            // Don't clean up files if the test is being debugged.
            if (!Debugger.IsAttached)
            {
                Directory.Delete(DirectoryPath, true);
            }
        }

        private void PrepareTempFilePaths()
        {
            DirectoryPath = Path.Combine(Path.GetTempPath(), GetType().Name, Path.GetRandomFileName());
            Directory.CreateDirectory(DirectoryPath);

            CredentialsFilePath = Path.Combine(DirectoryPath, CredentialsFileName);
            ConfigFilePath = Path.Combine(DirectoryPath, ConfigFileName);
        }
    }
}
