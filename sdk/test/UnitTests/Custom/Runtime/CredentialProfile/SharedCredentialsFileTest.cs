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
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Auth.CredentialProfile;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SharedCredentialsFileTest
    {
        private static readonly string SessionProfileText = new StringBuilder()
            .AppendLine("[session_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("aws_session_token=session_aws_session_token")
            .ToString();

        private static readonly ProfileOptions SessionProfileOptions = new ProfileOptions()
            {
                AccessKey = "session_aws_access_key_id",
                SecretKey = "session_aws_secret_access_key",
                Token = "session_aws_session_token"
            };

        private static readonly string SessionProfileTextUpdated = new StringBuilder()
            .AppendLine("[session_profile]")
            .AppendLine("aws_access_key_id=session_aws_access_key_id")
            .AppendLine("aws_secret_access_key=session_aws_secret_access_key")
            .Append("aws_session_token=session_aws_session_token_UPDATED")
            .ToString();

        private static readonly ProfileOptions SessionProfileOptionsUpdated = new ProfileOptions()
            {
                AccessKey = "session_aws_access_key_id",
                SecretKey = "session_aws_secret_access_key",
                Token = "session_aws_session_token_UPDATED"
        };

        private static readonly string AssumeRoleMfaProfileText = new StringBuilder()
            .AppendLine("[assume_role_mfa_profile]")
            .AppendLine("mfa_serial=mfa_serial_number")
            .AppendLine("role_arn=assume_role_arn")
            .Append("source_profile=basic_profile")
            .ToString();

        private static readonly ProfileOptions AssumeRoleMfaProfileOptions = new ProfileOptions()
            {
                SourceProfile = "basic_profile",
                RoleArn = "assume_role_arn",
                MfaSerial = "mfa_serial_number"
            };

        private static readonly string BasicProfileConfigText = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string BasicProfileCredentialsText =
            BasicProfileConfigText.Replace("[profile ", "[");

        private static readonly string BasicProfileTextConfigPartial = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly string BasicProfileTextCredentialsPartial = new StringBuilder()
            .AppendLine("[basic_profile]")
            .Append("aws_access_key_id=basic_aws_access_key_id")
            .ToString();

        private static readonly ProfileOptions BasicProfileOptions = new ProfileOptions()
        {
            AccessKey = "basic_aws_access_key_id",
            SecretKey = "basic_aws_secret_access_key"
        };

        private static readonly string BasicProfileTextCredentialsPrecedence = new StringBuilder()
            .AppendLine("[basic_profile]")
            .Append("aws_access_key_id=basic_aws_access_key_id_CREDENTIALS_FILE")
            .ToString();

        private static readonly string BasicProfileTextConfigPrecedence = new StringBuilder()
            .AppendLine("[profile basic_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id_CONFIG_FILE")
            .Append("aws_secret_access_key=basic_aws_secret_access_key")
            .ToString();

        private static readonly ProfileOptions BasicProfilePrecedenceOptions = new ProfileOptions()
            {
                AccessKey = "basic_aws_access_key_id_CREDENTIALS_FILE",
                SecretKey = "basic_aws_secret_access_key"
            };

        private static readonly string InvalidProfileText = new StringBuilder()
            .AppendLine("[invalid_profile]")
            .AppendLine("invalid_key=invalid_value")
            .ToString();

        private static readonly ProfileOptions InvalidProfileOptions = new ProfileOptions();

        private static readonly string FullAssumeRoleProfileText = new StringBuilder()
            .AppendLine("[full_assume_role_profile]")
            .AppendLine("aws_access_key_id=basic_aws_access_key_id")
            .AppendLine("aws_secret_access_key=basic_aws_secret_access_key")
            .Append("role_arn=assume_role_arn")
            .ToString();

        private static readonly ProfileOptions FullAssumeRoleProfileOptions = new ProfileOptions()
        {
            AccessKey = "basic_aws_access_key_id",
            SecretKey = "basic_aws_secret_access_key",
            RoleArn = "assume_role_arn"
        };

        [TestMethod]
        public void ReadBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTester(BasicProfileCredentialsText))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
            }
        }

        [TestMethod]
        public void WriteBasicProfile()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.AssertWriteProfile("basic_profile", BasicProfileOptions, BasicProfileCredentialsText);
            }
        }

        [TestMethod]
        public void ReadSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText))
            {
                tester.ReadAndAssertProfile("session_profile", SessionProfileOptions);
            }
        }

        [TestMethod]
        public void WriteSessionProfile()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.AssertWriteProfile("session_profile", SessionProfileOptions, SessionProfileText);
            }
        }

        [TestMethod]
        public void ReadAssumeRoleMfaProfile()
        {
            using (var tester = new SharedCredentialsFileTester(AssumeRoleMfaProfileText))
            {
                tester.ReadAndAssertProfile("assume_role_mfa_profile", AssumeRoleMfaProfileOptions);
            }
        }

        [TestMethod]
        public void WriteAssumeRoleMfaProfile()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.AssertWriteProfile("assume_role_mfa_profile", AssumeRoleMfaProfileOptions, AssumeRoleMfaProfileText);
            }
        }

        [TestMethod]
        public void ReadInvalidProfile()
        {
            using (var tester = new SharedCredentialsFileTester(InvalidProfileText))
            {
                tester.TestTryGetProfile("invalid_profile", true, false);
            }
        }

        [TestMethod]
        public void WriteInvalidProfile()
        {
            using (var tester = new SharedCredentialsFileTester(InvalidProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertWriteProfile("invalid_profile", InvalidProfileOptions, InvalidProfileText);
                }, typeof(ArgumentException), new Regex("The ProfileOptions object provided does not represent a valid profile."));
            }
        }

        [TestMethod]
        public void ReadProfileDoesNotExist()
        {
            using (var tester = new SharedCredentialsFileTester())
            {
                tester.TestTryGetProfile("profile_does_not_exist", false, false);
            }
        }

        [TestMethod]
        public void UpdateProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText))
            {
                tester.ReadAndAssertProfile("session_profile", SessionProfileOptions);
                tester.AssertWriteProfile("session_profile", SessionProfileOptionsUpdated, SessionProfileTextUpdated);
            }
        }

        [TestMethod]
        public void DeleteProfile()
        {
            using (var tester = new SharedCredentialsFileTester(SessionProfileText + Environment.NewLine + BasicProfileCredentialsText))
            {
                tester.CredentialsFile.DeleteProfile("session_profile");
                tester.AssertCredentialsFileContents(BasicProfileCredentialsText);
            }
        }

        [TestMethod]
        public void ReadBasicProfileConfig()
        {
            using (var tester = new SharedCredentialsFileTester(null, BasicProfileConfigText))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
            }
        }

        [TestMethod]
        public void ReadBasicProfileAllConfigExtraSpacesAndTabInName()
        {
            var basicProfileInConfigWithWhitespace = BasicProfileConfigText.Replace("profile basic_profile", "profile \t basic_profile");
            using (var tester = new SharedCredentialsFileTester(null, basicProfileInConfigWithWhitespace))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
            }
        }

        [TestMethod]
        public void ReadBasicProfileAllConfigForgotProfileKeyword()
        {
            using (var tester = new SharedCredentialsFileTester(null, BasicProfileCredentialsText))
            {
                Profile profile = null;
                Assert.IsFalse(tester.CredentialsFile.TryGetProfile("basic_profile", out profile));
                Assert.IsNull(profile);
            }
        }

        [TestMethod]
        public void ReadBasicProfileSplit()
        {
            using (var tester = new SharedCredentialsFileTester(
                BasicProfileTextCredentialsPartial, BasicProfileTextConfigPartial))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfileOptions);
            }
        }

        [TestMethod]
        public void ReadBasicProfileCredentialsTakesPrecedence()
        {
            using (var tester = new SharedCredentialsFileTester(
                BasicProfileTextCredentialsPrecedence, BasicProfileTextConfigPrecedence))
            {
                tester.ReadAndAssertProfile("basic_profile", BasicProfilePrecedenceOptions);
            }
        }

        [TestMethod]
        public void ReadUnsupportedProfileType()
        {
            using (var tester = new SharedCredentialsFileTester(FullAssumeRoleProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.TestTryGetProfile("full_assume_role_profile", false, false);
                }, typeof(InvalidDataException), new Regex("does not support the (.*) profile type."));
            }
        }

        [TestMethod]
        public void WriteUnsupportedProfileType()
        {
            using (var tester = new SharedCredentialsFileTester(FullAssumeRoleProfileText))
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.AssertWriteProfile("full_assume_role_profile", FullAssumeRoleProfileOptions, FullAssumeRoleProfileText);
                }, typeof(ArgumentException), new Regex("The ProfileOptions object provided represents"));
            }
        }

        private class SharedCredentialsFileTester : IDisposable
        {
            private const string CredentialsFileName = "credentials";
            private const string ConfigFileName = "config";

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

            public void ReadAndAssertProfile(string profileName, ProfileOptions expectedProfileOptions)
            {
                var expectedProfile = new Profile(profileName, expectedProfileOptions);
                Assert.AreEqual(expectedProfile, TestTryGetProfile(profileName, true, expectedProfile.IsValid));
            }

            public Profile TestTryGetProfile(string profileName, bool expectProfile, bool expectValidProfile)
            {
                Profile profile = null;
                Assert.IsTrue(expectProfile == CredentialsFile.TryGetProfile(profileName, out profile));
                Assert.IsTrue(expectProfile == (profile != null));
                Assert.IsTrue(!expectProfile || (expectValidProfile == profile.IsValid));
                return profile;
            }

            public void AssertWriteProfile(string profileName, ProfileOptions profileOptions, string expectedFileContents)
            {
                CredentialsFile.AddOrUpdateProfile(new Profile(profileName, profileOptions));
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
                ConfigFilePath = Path.Combine(DirectoryPath, ConfigFileName);
            }
        }
    }
}
