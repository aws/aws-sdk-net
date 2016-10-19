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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;

namespace AWSSDK.UnitTests
{
    public class SharedCredentialsFileTestFixture : IDisposable
    {
        private const string CredentialsFileName = "credentials";
        private const string ConfigFileName = "config";

        private string CredentialsFilePath { get; set; }
        private string ConfigFilePath { get; set; }
        private string DirectoryPath { get; set; }

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

        public void ReadAndAssertProfile(string profileName, CredentialProfileOptions expectedProfileOptions)
        {
            var expectedProfile = CredentialProfileTestHelper.GetCredentialProfile(profileName, expectedProfileOptions);
            Assert.AreEqual(expectedProfile, TestTryGetProfile(profileName, true, expectedProfile.CanCreateAWSCredentials));
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
            CredentialsFile.RegisterProfile(CredentialProfileTestHelper.GetCredentialProfile(profileName, profileOptions));
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
