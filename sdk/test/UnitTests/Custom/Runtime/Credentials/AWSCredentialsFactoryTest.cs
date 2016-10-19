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
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        private static readonly MemoryCredentialProfileStore ProfileStore = new MemoryCredentialProfileStore();

        private static readonly CredentialProfile InvalidProfile =
            CredentialProfileTestHelper.GetCredentialProfile("invalid_profile", new CredentialProfileOptions
            {
                AccessKey = "aws_access_key_id"
            }, ProfileStore);

        private static readonly CredentialProfile BasicProfile =
            CredentialProfileTestHelper.GetCredentialProfile("basic_profile", new CredentialProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key"
            }, ProfileStore);

        private static readonly CredentialProfile SessionProfile =
            CredentialProfileTestHelper.GetCredentialProfile("session_profile", new CredentialProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                Token = "token"
            }, ProfileStore);

        private static readonly CredentialProfile AssumeRoleProfile =
            CredentialProfileTestHelper.GetCredentialProfile("assume_role_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile"
            }, ProfileStore);

        private static readonly CredentialProfile AssumeRoleExternalProfile =
            CredentialProfileTestHelper.GetCredentialProfile("assume_role_external_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                ExternalID = "external_id"
            }, ProfileStore);

        private static readonly CredentialProfile AssumeRoleMfaProfile =
            CredentialProfileTestHelper.GetCredentialProfile("assume_role_mfa_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                MfaSerial = "mfa_serial"
            }, ProfileStore);

        private static readonly CredentialProfile AssumeRoleExternalMfaProfile =
            CredentialProfileTestHelper.GetCredentialProfile("assume_role_external_mfa_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                ExternalID = "external_id",
                MfaSerial = "mfa_serial"
            }, ProfileStore);

        private static readonly CredentialProfile SAMLRoleProfile =
            CredentialProfileTestHelper.GetCredentialProfile("saml_role_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                EndpointName = "endpoint_name"
            }, ProfileStore);

        private static readonly CredentialProfile SAMLRoleUserIdentityProfile =
            CredentialProfileTestHelper.GetCredentialProfile("saml_role_user_identity_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                EndpointName = "endpoint_name",
                UserIdentity = "user_identity"
            }, ProfileStore);

        private static readonly CredentialProfile AssumeRoleProfileSourceNotBasic =
            CredentialProfileTestHelper.GetCredentialProfile("assume_role_profile_source_not_basic", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "session_profile"
            }, ProfileStore);

        private static readonly CredentialProfile AssumeRoleProfileRecursion =
            CredentialProfileTestHelper.GetCredentialProfile("assume_role_profile_source_recursion", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "assume_role_profile_source_recursion"
            }, ProfileStore);

        private static readonly CredentialProfile AssumeRoleProfileInvalidSource =
            CredentialProfileTestHelper.GetCredentialProfile("assume_role_profile_invalid_source", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "invalid_profile"
            }, ProfileStore);

        static AWSCredentialsFactoryTest()
        {
            ProfileStore.Profiles.Add(InvalidProfile.Name, InvalidProfile);
            ProfileStore.Profiles.Add(BasicProfile.Name, BasicProfile);
            ProfileStore.Profiles.Add(SessionProfile.Name, SessionProfile);
            ProfileStore.Profiles.Add(AssumeRoleProfile.Name, AssumeRoleProfile);
            ProfileStore.Profiles.Add(AssumeRoleExternalProfile.Name, AssumeRoleExternalProfile);
            ProfileStore.Profiles.Add(AssumeRoleExternalMfaProfile.Name, AssumeRoleExternalMfaProfile);
            ProfileStore.Profiles.Add(AssumeRoleMfaProfile.Name, AssumeRoleMfaProfile);
            ProfileStore.Profiles.Add(AssumeRoleProfileSourceNotBasic.Name, AssumeRoleProfileSourceNotBasic);
            ProfileStore.Profiles.Add(AssumeRoleProfileRecursion.Name, AssumeRoleProfileRecursion);
            ProfileStore.Profiles.Add(AssumeRoleProfileInvalidSource.Name, AssumeRoleProfileInvalidSource);
            ProfileStore.Profiles.Add(SAMLRoleProfile.Name, SAMLRoleProfile);
            ProfileStore.Profiles.Add(SAMLRoleUserIdentityProfile.Name, SAMLRoleUserIdentityProfile);
        }

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
        public void TryGetInvalidCredentials()
        {
            AWSCredentials credentials;
            Assert.IsFalse(AWSCredentialsFactory.TryGetAWSCredentials(InvalidProfile, out credentials));
            Assert.IsNull(credentials);
        }

        [TestMethod]
        public void TryGetBasicCredentials()
        {
            AWSCredentials credentials;
            Assert.IsTrue(AWSCredentialsFactory.TryGetAWSCredentials(BasicProfile, out credentials));
            Assert.IsNotNull(credentials);
            Assert.AreEqual(BasicCredentials, credentials);
        }

        [TestMethod]
        public void GetInvalidCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(InvalidProfile);
            }, typeof(InvalidDataException), string.Format(InvalidErrorFormat, "invalid_profile"));
        }

        [TestMethod]
        public void GetBasicCredentials()
        {
            Assert.AreEqual(BasicCredentials, AWSCredentialsFactory.GetAWSCredentials(BasicProfile));
        }

        [TestMethod]
        public void GetSessionCredentials()
        {
            Assert.AreEqual(SessionCredentials, AWSCredentialsFactory.GetAWSCredentials(SessionProfile));
        }

        [TestMethod]
        public void GetAssumeRoleCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfile));
        }

        [TestMethod]
        public void GetAssumeRoleExternalCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleExternalProfile));
        }

        [TestMethod]
        public void GetAssumeRoleMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleMfaCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleMfaProfile));
        }

        [TestMethod]
        public void GetAssumeRoleExternalMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalMfaCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleExternalMfaProfile));
        }

        [TestMethod]
        public void GetSAMLRoleCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(SAMLRoleProfile);
            }, typeof(NotImplementedException), "SAML CREDENTIALS NOT YET IMPLEMENTED");
        }

        [TestMethod]
        public void GetSAMLRoleUserIdentityCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(SAMLRoleUserIdentityProfile);
            }, typeof(NotImplementedException), "SAML CREDENTIALS NOT YET IMPLEMENTED");
        }

        [TestMethod]
        public void GetAssumeRoleProfileSourceNotBasic()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileSourceNotBasic);
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
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileRecursion);
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
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileInvalidSource);
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
