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
using Amazon.Runtime.Internal.Auth;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SharedCredentialsFileTest
    {
        private const string ErrorFormat = "Credential profile [{0}] was not found, or is invalid.";
        private const string TemporaryErrorFormat = "Credential profile [{0}] uses the source_profile key, which is not yet supported by the .NET SDK.";

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

        private static readonly string AssumeRoleProfileText = new StringBuilder()
            .AppendLine("[assume_role_profile]")
            .AppendLine("source_profile=assume_role_other_profile")
            .Append("role_arn=assume_role_role_arn")
            .ToString();

        private static readonly string InvalidNoAccessKeyProfileText = new StringBuilder()
            .AppendLine("[invalid_profile]")
            .AppendLine("aws_secret_access_key=aws_secret_access_key")
            .ToString();

        private static readonly string InvalidNoSecretAccessKeyProfileText = new StringBuilder()
            .AppendLine("[invalid_profile]")
            .AppendLine("aws_access_key_id=aws_access_key_id")
            .ToString();

        private static readonly ImmutableCredentials BasicCredentials =
            new ImmutableCredentials("basic_aws_access_key_id", "basic_aws_secret_access_key", null);

        private static readonly ImmutableCredentials SessionCredentials =
            new ImmutableCredentials("session_aws_access_key_id", "session_aws_secret_access_key", "session_aws_session_token");

        [TestMethod]
        public void ReadBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTester(BasicProfileText))
            {
                tester.AssertReadProfile("basic_profile", BasicCredentials);
            }
        }

        [TestMethod]
        public void WriteBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.AssertWriteProfile("basic_profile", BasicCredentials, BasicProfileText);
            }
        }

        [TestMethod]
        public void ReadSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText))
            {
                tester.AssertReadProfile("session_profile", SessionCredentials);
            }
        }

        [TestMethod]
        public void WriteSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.AssertWriteProfile("session_profile", SessionCredentials, SessionProfileText);
            }
        }

        [TestMethod]
        public void ReadInvalidNoAccessKeyProfile()
        {
            using (var tester = new SharedCredentialsFileTester(InvalidNoAccessKeyProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertReadProfile("invalid_profile", null);
                }, typeof(InvalidDataException), string.Format(ErrorFormat, "invalid_profile"));
            }
        }

        [TestMethod]
        public void ReadInvalidNoSecretAccessKeyProfile()
        {
            using (var tester = new SharedCredentialsFileTester(InvalidNoSecretAccessKeyProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertReadProfile("invalid_profile", null);
                }, typeof(InvalidDataException), string.Format(ErrorFormat, "invalid_profile"));
            }
        }

        [TestMethod]
        public void ReadInvalidAssumeRoleProfile()
        {
            using (var tester = new SharedCredentialsFileTester(AssumeRoleProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertReadProfile("assume_role_profile", null);
                }, typeof(InvalidDataException), string.Format(TemporaryErrorFormat, "assume_role_profile"));
            }
        }

        [TestMethod]
        public void UpdateProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText))
            {
                var newToken = Guid.NewGuid().ToString();
                ImmutableCredentials updatedCredentials = new ImmutableCredentials(
                    SessionCredentials.AccessKey, SessionCredentials.SecretKey, newToken);
                tester.AssertWriteProfile("session_profile", updatedCredentials,
                    SessionProfileText.Replace("session_aws_session_token", newToken));
            }
        }

        [TestMethod]
        public void DeleteProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText + Environment.NewLine + BasicProfileText))
            {
                tester.CredentialsFile.DeleteProfile("session_profile");
                tester.CredentialsFile.Persist();
                tester.AssertFileContents(BasicProfileText);
            }
        }

        private class SharedCredentialsFileTester : IDisposable
        {
            private string FilePath { get; set; }
            public SharedCredentialsFile CredentialsFile { get; private set; }

            public SharedCredentialsFileTester(string fileContents)
            {
                FilePath = Path.GetTempFileName();
                File.WriteAllText(FilePath, fileContents);
                CredentialsFile = new SharedCredentialsFile(FilePath);
            }

            public SharedCredentialsFileTester(bool createFile = false)
            {
                if (createFile)
                {
                    FilePath = Path.GetTempFileName();
                }
                else
                {
                    FilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                }
                CredentialsFile = new SharedCredentialsFile(FilePath);
            }

            public void AssertReadProfile(string profileName, ImmutableCredentials expectedCredentials)
            {
                Assert.IsNotNull(CredentialsFile.GetAWSCredentials(profileName));
                AWSCredentials credentials;
                Assert.IsTrue(CredentialsFile.TryGetAWSCredentials(profileName, out credentials));
                Assert.AreEqual(expectedCredentials, credentials.GetCredentials());
            }

            public void AssertWriteProfile(string profileName, ImmutableCredentials credentials, string expectedFileContents)
            {
                if (credentials.UseToken)
                {
                    CredentialsFile.AddOrUpdateCredentials(profileName, credentials.AccessKey, credentials.SecretKey, credentials.Token);
                }
                else
                {
                    CredentialsFile.AddOrUpdateCredentials(profileName, credentials.AccessKey, credentials.SecretKey);
                }
                CredentialsFile.Persist();
                AssertFileContents(expectedFileContents);
            }

            public void AssertFileContents(string expectedContents)
            {
                Assert.AreEqual(expectedContents, File.ReadAllText(FilePath));
            }

            public void Dispose()
            {
                File.Delete(FilePath);
            }

        }
    }
}
