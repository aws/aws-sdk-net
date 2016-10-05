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
using Amazon.Runtime.Internal.Auth.CredentialProfile;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AWSCredentialsFactoryTest
    {
        private const string InvalidErrorFormat = "Credential profile [{0}] is not valid.  Please ensure the profile contains a valid combination of properties.";
        private const string NotFoundErrorFormat = "Credential profile [{0}] was not found.";
        private const string SourceErrorFormat = "Error reading source profile [{0}] for profile [{1}].";
        private const string SourceNotBasicFormat = "Source profile [{0}] is not a basic profile.";

        private static readonly Profile InvalidProfile =
            new Profile("invalid_profile", new ProfileOptions
            {
                AccessKey = "aws_access_key_id"
            });

        private static readonly Profile BasicProfile =
            new Profile("basic_profile", new ProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key"
            });

        private static readonly Profile SessionProfile =
            new Profile("session_profile", new ProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                Token = "token"
            });

        private static readonly Profile AssumeRoleProfile =
            new Profile("assume_role_profile", new ProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile"
            });

        private static readonly Profile AssumeRoleExternalProfile =
            new Profile("assume_role_external_profile", new ProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                ExternalID = "external_id"
            });

        private static readonly Profile AssumeRoleMfaProfile =
            new Profile("assume_role_mfa_profile", new ProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                MfaSerial = "mfa_serial"
            });

        private static readonly Profile AssumeRoleExternalMfaProfile =
            new Profile("assume_role_external_mfa_profile", new ProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                ExternalID = "external_id",
                MfaSerial = "mfa_serial"
            });

        private static readonly Profile FullAssumeRoleProfile =
            new Profile("full_assume_role_profile", new ProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                RoleArn = "role_arn",
            });

        private static readonly Profile FullAssumeRoleExternalProfile =
            new Profile("full_assume_role_external_profile", new ProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                RoleArn = "role_arn",
                ExternalID = "external_id"
            });

        private static readonly Profile FullAssumeRoleMfaProfile =
            new Profile("full_assume_role_mfa_profile", new ProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                RoleArn = "role_arn",
                MfaSerial = "mfa_serial"
            });

        private static readonly Profile FullAssumeRoleExternalMfaProfile =
            new Profile("full_assume_role_external_mfa_profile", new ProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                RoleArn = "role_arn",
                ExternalID = "external_id",
                MfaSerial = "mfa_serial"
            });

        private static readonly Profile AssumeRoleProfileSourceNotBasic =
            new Profile("assume_role_profile_source_not_basic", new ProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "session_profile"
            });

        private static readonly Profile AssumeRoleProfileRecursion =
            new Profile("assume_role_profile_source_recursion", new ProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "assume_role_profile_source_recursion"
            });

        private static readonly Profile AssumeRoleProfileInvalidSource =
            new Profile("assume_role_profile_invalid_source", new ProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "invalid_profile"
            });

        private static readonly MemoryProfileStore ProfileStore =
            new MemoryProfileStore(new Dictionary<string, Profile>()
            {
                { InvalidProfile.Name, InvalidProfile },
                { BasicProfile.Name, BasicProfile },
                { SessionProfile.Name, SessionProfile },
                { AssumeRoleProfile.Name, AssumeRoleProfile },
                { AssumeRoleExternalProfile.Name, AssumeRoleExternalProfile },
                { AssumeRoleMfaProfile.Name, AssumeRoleMfaProfile },
                { AssumeRoleExternalMfaProfile.Name, FullAssumeRoleExternalMfaProfile },
                { FullAssumeRoleProfile.Name, FullAssumeRoleProfile },
                { FullAssumeRoleExternalProfile.Name, FullAssumeRoleExternalProfile },
                { FullAssumeRoleMfaProfile.Name, FullAssumeRoleMfaProfile },
                { FullAssumeRoleExternalMfaProfile.Name, FullAssumeRoleExternalMfaProfile },
                { AssumeRoleProfileSourceNotBasic.Name, AssumeRoleProfileSourceNotBasic },
                { AssumeRoleProfileRecursion.Name, AssumeRoleProfileRecursion },
                { AssumeRoleProfileInvalidSource.Name, AssumeRoleProfileInvalidSource },
            });

        private static readonly AWSCredentialsFactory Factory =
            new AWSCredentialsFactory(ProfileStore);

        private static readonly BasicAWSCredentials BasicCredentials =
            new BasicAWSCredentials("aws_access_key_id", "aws_secret_access_key");

        private static readonly SessionAWSCredentials SessionCredentials =
            new SessionAWSCredentials("aws_access_key_id", "aws_secret_access_key", "token");

        private static readonly AssumeRoleAWSCredentials AssumeRoleCredentials =
            new AssumeRoleAWSCredentials(BasicCredentials, "role_arn", "role_session_name");

        private static readonly AssumeRoleAWSCredentials AssumeRoleExternalCredentials =
            new AssumeRoleAWSCredentials(BasicCredentials, "role_arn", "role_session_name", new AssumeRoleAWSCredentialsOptions()
            {
                ExternalId = "external_id"
            });

        private static readonly AssumeRoleAWSCredentials AssumeRoleMfaCredentials =
            new AssumeRoleAWSCredentials(BasicCredentials, "role_arn", "role_session_name", new AssumeRoleAWSCredentialsOptions()
            {
                MfaSerialNumber = "mfa_serial"
            });

        private static readonly AssumeRoleAWSCredentials AssumeRoleExternalMfaCredentials =
            new AssumeRoleAWSCredentials(BasicCredentials, "role_arn", "role_session_name", new AssumeRoleAWSCredentialsOptions()
            {
                ExternalId = "external_id",
                MfaSerialNumber = "mfa_serial"
            });

        [TestMethod]
        public void TryGetCredentials_NotFound()
        {
            AWSCredentials credentials = null;
            Assert.IsFalse(Factory.TryGetAWSCredentials("does_not_exist_profile", out credentials));
            Assert.IsNull(credentials);
        }

        [TestMethod]
        public void TryGetInvalidCredentials()
        {
            AWSCredentials credentials = null;
            Assert.IsFalse(Factory.TryGetAWSCredentials("invalid_profile", out credentials));
            Assert.IsNull(credentials);
        }

        [TestMethod]
        public void TryGetBasicCredentials()
        {
            AWSCredentials credentials = null;
            Assert.IsTrue(Factory.TryGetAWSCredentials("basic_profile", out credentials));
            Assert.IsNotNull(credentials);
            Assert.AreEqual(BasicCredentials, credentials);
        }

        [TestMethod]
        public void GetCredentials_NotFound()
        {
            AssertExtensions.ExpectException(() =>
            {
                Factory.GetAWSCredentials("does_not_exist_profile");
            }, typeof(InvalidDataException), string.Format(NotFoundErrorFormat, "does_not_exist_profile"));
        }

        [TestMethod]
        public void GetInvalidCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                Factory.GetAWSCredentials("invalid_profile");
            }, typeof(InvalidDataException), string.Format(InvalidErrorFormat, "invalid_profile"));
        }

        [TestMethod]
        public void GetBasicCredentials()
        {
            Assert.AreEqual(BasicCredentials, Factory.GetAWSCredentials("basic_profile"));
        }

        [TestMethod]
        public void GetSessionCredentials()
        {
            Assert.AreEqual(SessionCredentials, Factory.GetAWSCredentials("session_profile"));
        }

        [TestMethod]
        public void GetAssumeRoleCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentials, Factory.GetAWSCredentials("assume_role_profile"));
        }

        [TestMethod]
        public void GetAssumeRoleExternalCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalCredentials, Factory.GetAWSCredentials("assume_role_external_profile"));
        }

        [TestMethod]
        public void GetAssumeRoleMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleMfaCredentials, Factory.GetAWSCredentials("assume_role_mfa_profile"));
        }

        [TestMethod]
        public void GetAssumeRoleExternalMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalMfaCredentials, Factory.GetAWSCredentials("assume_role_external_mfa_profile"));
        }

        [TestMethod]
        public void GetFullAssumeRoleCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentials, Factory.GetAWSCredentials("full_assume_role_profile"));
        }

        [TestMethod]
        public void GetFullAssumeRoleExternalCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalCredentials, Factory.GetAWSCredentials("full_assume_role_external_profile"));
        }

        [TestMethod]
        public void GetFullAssumeRoleMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleMfaCredentials, Factory.GetAWSCredentials("full_assume_role_mfa_profile"));
        }

        [TestMethod]
        public void GetFullAssumeRoleExternalMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalMfaCredentials, Factory.GetAWSCredentials("full_assume_role_external_mfa_profile"));
        }

        [TestMethod]
        public void GetAssumeRoleProfileSourceNotBasic()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    Factory.GetAWSCredentials("assume_role_profile_source_not_basic");
                }, typeof(InvalidDataException), string.Format(SourceErrorFormat, "session_profile",
                "assume_role_profile_source_not_basic")).InnerException;
            }, typeof(InvalidDataException), string.Format(SourceNotBasicFormat, "session_profile"));
        }

        [TestMethod]
        public void GetAssumeRoleProfileRecursion()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    Factory.GetAWSCredentials("assume_role_profile_source_recursion");
                }, typeof(InvalidDataException), string.Format(SourceErrorFormat, "assume_role_profile_source_recursion",
                "assume_role_profile_source_recursion")).InnerException;
            }, typeof(InvalidDataException), string.Format(SourceNotBasicFormat, "assume_role_profile_source_recursion"));
        }

        [TestMethod]
        public void GetAssumeRoleProfileInvalidSource()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    Factory.GetAWSCredentials("assume_role_profile_invalid_source");
                }, typeof(InvalidDataException), string.Format(SourceErrorFormat, "invalid_profile",
                "assume_role_profile_invalid_source")).InnerException;
            }
            , typeof(InvalidDataException), string.Format(InvalidErrorFormat, "invalid_profile"));
        }

        private void AssertAssumeRoleCredentialsAreEqual(AssumeRoleAWSCredentials expected, AWSCredentials actualAWSCredentials)
        {
            AssumeRoleAWSCredentials actual = actualAWSCredentials as AssumeRoleAWSCredentials;
            Assert.IsNotNull(actual);
            // can't do AreEqual because this contains DateTime.UtcNow.Ticks
            Assert.IsTrue(actual.RoleSessionName.StartsWith("aws-dotnet-sdk-session-"));
            Assert.AreEqual(expected.RoleArn, actual.RoleArn);
            Assert.AreEqual(expected.PreemptExpiryTime, actual.PreemptExpiryTime);
            Assert.AreEqual(expected.SourceCredentials, actual.SourceCredentials);
            Assert.AreEqual(expected.Options?.DurationSeconds, actual.Options?.DurationSeconds);
            Assert.AreEqual(expected.Options?.ExternalId, actual.Options?.ExternalId);
            Assert.AreEqual(expected.Options?.MfaSerialNumber, actual.Options?.MfaSerialNumber);
            Assert.AreEqual(expected.Options?.MfaTokenCodeCallback, actual.Options?.MfaTokenCodeCallback);
            Assert.AreEqual(expected.Options?.Policy, actual.Options?.Policy);
            Assert.AreEqual(expected.Options?.ProxySettings, actual.Options?.ProxySettings);
        }
    }
}
