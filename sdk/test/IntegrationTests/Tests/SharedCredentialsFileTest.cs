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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class SharedCredentialsFileTest
    {
        private const string CredentialErrorMessage = "Error calling AssumeRole for role ";
        private const string NotFoundErrorFormat = "Credential profile [{0}] was not found, or is invalid.";
        private const string BadSourceErrorFormat = "Credential profile [{0}] references source profile [{1}], which was not found, or is invalid.";
        private const string TemporaryErrorFormat = "Credential profile [{0}] uses the mfa_serial key, which is not yet supported by the AWS .NET SDK.";
        private const string TestUserName = "shared-credentials-file-user";
        private const string TestRoleName = "shared-credentials-file-role";

        private static readonly string ExternalId = Guid.NewGuid().ToString();

        private static readonly string BasicProfileText = new StringBuilder()
            .AppendLine("[basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string SessionProfileText = new StringBuilder()
            .AppendLine("[session_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("aws_session_token=session_aws_session_token")
            .ToString();

        private static readonly string BasicProfileTextCredentialsPartial = new StringBuilder()
            .AppendLine("[basic_profile]")
            .Append("aws_access_key_id=basic_aws_access_key_id")
            .ToString();

        private static readonly string BasicProfileTextCredentialsPrecedence = new StringBuilder()
            .AppendLine("[basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id_CREDENTIALS")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string BasicProfileTextConfigPartial = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string BasicProfileTextConfigPrecedence = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id_CONFIG")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string AssumeRoleProfileTextInvalidSource = new StringBuilder()
            .AppendLine("[assume_role_profile]")
            .AppendLine("source_profile=basic_profile")
            .Append("role_arn=assume_role_role_arn")
            .ToString();

        private static readonly string AssumeRoleMFAProfileText = new StringBuilder()
            .AppendLine("[assume_role_mfa_profile]")
            .AppendLine("source_profile=basic_profile")
            .AppendLine("role_arn=assume_role_role_arn")
            .Append("mfa_serial=assume_role_mfa_serial")
            .ToString();

        private static readonly string LiveAssumeRoleProfileTextFormat = new StringBuilder()
            .AppendLine("[" + TestUserName + "-profile]")
            .AppendLine("aws_access_key_id = {0}")
            .AppendLine("aws_secret_access_key = {1}")
            .AppendLine("[" + TestRoleName + "-profile]")
            .AppendLine("source_profile = " + TestUserName + "-profile")
            .Append("role_arn = {2}")
            .ToString();

        private static readonly string LiveAssumeRoleExternalIdProfileTextFormat = new StringBuilder()
            .AppendLine("[" + TestUserName + "-profile]")
            .AppendLine("aws_access_key_id = {0}")
            .AppendLine("aws_secret_access_key = {1}")
            .AppendLine("[" + TestRoleName + "-profile]")
            .AppendLine("source_profile = " + TestUserName + "-profile")
            .AppendLine("role_arn = {2}")
            .Append("external_id = ").Append(ExternalId)
            .ToString();

        private static readonly string InvalidNoAccessKeyProfileText = new StringBuilder()
            .AppendLine("[invalid_profile]")
            .AppendLine("aws_secret_access_key=aws_secret_access_key")
            .ToString();

        private static readonly string InvalidNoSecretAccessKeyProfileText = new StringBuilder()
            .AppendLine("[invalid_profile]")
            .AppendLine("aws_access_key_id=aws_access_key_id")
            .ToString();

        private static readonly BasicAWSCredentials BasicCredentials =
            new BasicAWSCredentials("basic_aws_access_key_id", "basic_aws_secret_access_key");

        private static readonly BasicAWSCredentials BasicCredentialsPrecedence =
            new BasicAWSCredentials("basic_aws_access_key_id_CREDENTIALS", "basic_aws_secret_access_key");

        private static readonly SessionAWSCredentials SessionCredentials =
            new SessionAWSCredentials("session_aws_access_key_id", "session_aws_secret_access_key", "session_aws_session_token");

        [TestMethod]
        [TestCategory("General")]
        public void ReadBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTester(BasicProfileText))
            {
                tester.AssertReadProfile("basic_profile", BasicCredentials);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void WriteBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.AssertWriteProfile("basic_profile", BasicCredentials, BasicProfileText);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText))
            {
                tester.AssertReadProfile("session_profile", SessionCredentials);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void WriteSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.AssertWriteProfile("session_profile", SessionCredentials, SessionProfileText);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadInvalidNoAccessKeyProfile()
        {
            using (var tester = new SharedCredentialsFileTester(InvalidNoAccessKeyProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertReadProfile("invalid_profile", null);
                }, typeof(InvalidDataException), string.Format(NotFoundErrorFormat, "invalid_profile"));
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadInvalidNoSecretAccessKeyProfile()
        {
            using (var tester = new SharedCredentialsFileTester(InvalidNoSecretAccessKeyProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertReadProfile("invalid_profile", null);
                }, typeof(InvalidDataException), string.Format(NotFoundErrorFormat, "invalid_profile"));
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadAssumeRoleMFAProfile()
        {
            using (var tester = new SharedCredentialsFileTester(AssumeRoleMFAProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertReadProfile("assume_role_mfa_profile", null);
                }, typeof(InvalidDataException), string.Format(TemporaryErrorFormat, "assume_role_mfa_profile"));
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void UpdateProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText))
            {
                var newToken = Guid.NewGuid().ToString();
                SessionAWSCredentials updatedCredentials = new SessionAWSCredentials(
                    SessionCredentials.GetCredentials().AccessKey, SessionCredentials.GetCredentials().SecretKey, newToken);
                tester.AssertWriteProfile("session_profile", updatedCredentials,
                    SessionProfileText.Replace("session_aws_session_token", newToken));
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void DeleteProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText + Environment.NewLine + BasicProfileText))
            {
                tester.CredentialsFile.DeleteProfile("session_profile");
                tester.CredentialsFile.Persist();
                tester.AssertCredentialsFileContents(BasicProfileText);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadBasicProfileAllConfig()
        {
            var basicProfileInConfig = BasicProfileText.Replace("basic_profile", "profile basic_profile");
            using (var tester = new SharedCredentialsFileTester(null, basicProfileInConfig))
            {
                tester.AssertReadProfile("basic_profile", BasicCredentials);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadBasicProfileAllConfigExtraSpacesAndTabInName()
        {
            var basicProfileInConfig = BasicProfileText.Replace("basic_profile", "profile \t basic_profile");
            using (var tester = new SharedCredentialsFileTester(null, basicProfileInConfig))
            {
                tester.AssertReadProfile("basic_profile", BasicCredentials);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadBasicProfileAllConfigForgotProfileKeyword()
        {
            using (var tester = new SharedCredentialsFileTester(null, BasicProfileText))
            {
                Assert.IsNull(tester.CredentialsFile.GetAWSCredentials("basic_profile"));
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadBasicProfileSplit()
        {
            using (var tester = new SharedCredentialsFileTester(
                BasicProfileTextCredentialsPartial, BasicProfileTextConfigPartial))
            {
                tester.AssertReadProfile("basic_profile", BasicCredentials);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadBasicProfileCredentialsTakesPrecedence()
        {
            using (var tester = new SharedCredentialsFileTester(
                BasicProfileTextCredentialsPrecedence, BasicProfileTextConfigPrecedence))
            {
                tester.AssertReadProfile("basic_profile", BasicCredentialsPrecedence);
            }
        }

        [TestMethod]
        [TestCategory("General")]
        public void ReadAssumeRoleProfileInvalidSource()
        {
            using (var tester = new SharedCredentialsFileTester(AssumeRoleProfileTextInvalidSource))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertReadProfile("assume_role_profile", null);
                }, typeof(InvalidDataException), string.Format(BadSourceErrorFormat, "assume_role_profile", "basic_profile"));
            }
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        [TestCategory("IdentityManagement")]
        public void ReadAssumeRoleProfileNoExternalId()
        {
            ReadAssumeRoleProfile(null, null);
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        [TestCategory("IdentityManagement")]
        public void ReadAssumeRoleProfileWithExternalId()
        {
            ReadAssumeRoleProfile(ExternalId, ExternalId);
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        [TestCategory("IdentityManagement")]
        public void ReadAssumeRoleProfileNoExternalIdButExpected()
        {
            ReadAssumeRoleProfile(null, ExternalId);
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        [TestCategory("IdentityManagement")]
        public void ReadAssumeRoleProfileWithExternalIdButNotExpected()
        {
            ReadAssumeRoleProfile(ExternalId, null);
        }

        private void ReadAssumeRoleProfile(string credentialsFileExternalId, string roleExternalId)
        {
            try
            {
                // clean up at start in case a test dies in the middle of clean up and is restarted
                IAMTestUtil.CleanupTestRoleAndUser(TestRoleName, TestUserName);

                var roleArn = "arn:aws:iam::" + UtilityMethods.AccountId + ":role/" + TestRoleName;
                var sourceCredentials = IAMTestUtil.CreateTestRoleAndUser(TestRoleName, TestUserName, roleExternalId);
                var credentialsFileFormat = credentialsFileExternalId == null ? LiveAssumeRoleProfileTextFormat : LiveAssumeRoleExternalIdProfileTextFormat;

                using (var tester = new SharedCredentialsFileTester(string.Format(credentialsFileFormat,
                    sourceCredentials.GetCredentials().AccessKey, sourceCredentials.GetCredentials().SecretKey, roleArn)))
                {
                    var assumeRoleCredentials = tester.GetAndAssertAssumeRoleProfile(TestRoleName + "-profile",
                        sourceCredentials, roleArn, credentialsFileExternalId, TimeSpan.Zero, null, null);

                    AssertCredentials(assumeRoleCredentials, !string.Equals(credentialsFileExternalId, roleExternalId, StringComparison.Ordinal));
                }
            }
            finally
            {
                IAMTestUtil.CleanupTestRoleAndUser(TestRoleName, TestUserName);
            }
        }

        private static void AssertCredentials(AssumeRoleAWSCredentials assumeRoleCredentials, bool expectAuthenticationFailure)
        {
            ListBucketsResponse response = null;
            using (var client = new AmazonS3Client(assumeRoleCredentials))
            {
                // user/role setup may not be complete
                // so retry for a bit before giving up
                var stopTime = DateTime.Now.AddSeconds(15);
                while (response == null && DateTime.Now < stopTime)
                {
                    var doSleep = true;
                    try
                    {
                        response = client.ListBuckets();
                        Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                        doSleep = false;
                    }
                    catch (AmazonClientException e)
                    {
                        if (expectAuthenticationFailure && e.Message.StartsWith(CredentialErrorMessage, StringComparison.Ordinal))
                        {
                            return;
                        }
                    }
                    catch (AmazonServiceException)
                    {
                    }

                    if (doSleep)
                    {
                        Thread.Sleep(1000);
                    }
                }
            }

            if (expectAuthenticationFailure)
            {
                Assert.Fail("The test did not receive the expected authentication failure.");
            }
            else
            {
                Assert.IsNotNull(response, "Unable to use AssumeRoleCredentials to successfully complete a request.");
            }
        }

        private class SharedCredentialsFileTester : IDisposable
        {
            private const string CredentialsFileName = "credentials";

            private string CredentialsFilePath { get; set; }
            private string ConfigFilePath { get; set; }
            private string DirectoryPath { get; set; }

            public SharedCredentialsFile CredentialsFile { get; private set; }

            public SharedCredentialsFileTester(string credentialsFileContents, string configFileContents = null,
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

            public SharedCredentialsFileTester(bool createEmptyFile = false)
                : this(null, null, createEmptyFile)
            {
            }

            public AssumeRoleAWSCredentials GetAndAssertAssumeRoleProfile(string profileName, BasicAWSCredentials expectedSourceCredentials,
                string expectedRoleArn, string expectedExternalId, TimeSpan expectedPreemptExpiryTime,
                string expectedMFASerialNumber, string expectedMFATokenCode)
            {
                var actualCredentials = AssertReadProfile(profileName) as AssumeRoleAWSCredentials;

                Assert.IsNotNull(actualCredentials);
                Assert.AreEqual(expectedSourceCredentials.GetCredentials(), actualCredentials.SourceCredentials.GetCredentials());
                Assert.AreEqual(expectedRoleArn, actualCredentials.RoleArn);
                Assert.AreEqual(expectedExternalId, actualCredentials.Options.ExternalId);
                Assert.AreEqual(expectedPreemptExpiryTime, actualCredentials.PreemptExpiryTime);
                Assert.AreEqual(expectedMFASerialNumber, actualCredentials.Options.MfaSerialNumber);
                Assert.AreEqual(expectedMFATokenCode, actualCredentials.Options.MfaTokenCode);

                //role session name is not an exact match since DateTime.Now.Ticks is part of it
                Assert.IsTrue(actualCredentials.RoleSessionName.StartsWith(SharedCredentialsFile.RoleSessionNamePrefix));

                return actualCredentials;
            }

            public void AssertReadProfile(string profileName, AWSCredentials expectedCredentials)
            {
                Assert.AreEqual(expectedCredentials?.GetCredentials(), AssertReadProfile(profileName).GetCredentials());
            }

            public void AssertWriteProfile(string profileName, SessionAWSCredentials credentials, string expectedFileContents)
            {
                CredentialsFile.AddOrUpdateCredentials(profileName, credentials.GetCredentials().AccessKey,
                    credentials.GetCredentials().SecretKey, credentials.GetCredentials().Token);
                CredentialsFile.Persist();
                AssertCredentialsFileContents(expectedFileContents);
            }

            public void AssertWriteProfile(string profileName, BasicAWSCredentials credentials, string expectedFileContents)
            {
                CredentialsFile.AddOrUpdateCredentials(profileName, credentials.GetCredentials().AccessKey,
                    credentials.GetCredentials().SecretKey);
                CredentialsFile.Persist();
                AssertCredentialsFileContents(expectedFileContents);
            }

            public void AssertCredentialsFileContents(string expectedContents)
            {
                Assert.AreEqual(expectedContents, File.ReadAllText(CredentialsFilePath));
            }

            public void Dispose()
            {
                File.Delete(CredentialsFilePath);
                File.Delete(ConfigFilePath);
                Directory.Delete(DirectoryPath);
            }

            private void PrepareTempFilePaths()
            {
                DirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                Directory.CreateDirectory(DirectoryPath);

                CredentialsFilePath = Path.Combine(DirectoryPath, CredentialsFileName);
                ConfigFilePath = Path.Combine(DirectoryPath, SharedCredentialsFile.ConfigFileName);
            }

            private AWSCredentials AssertReadProfile(string profileName)
            {
                Assert.IsNotNull(CredentialsFile.GetAWSCredentials(profileName));
                AWSCredentials credentials;
                Assert.IsTrue(CredentialsFile.TryGetAWSCredentials(profileName, out credentials));
                return credentials;
            }

        }
    }
}
