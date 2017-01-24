/*
 * Copyright 2016-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AWSCredentialsFactoryTest
    {

        private const string SourceNotBasicFormat = "Source profile [{0}] is not a basic profile.";
        private const string SourceNotFoundFormat = "Source profile [{0}] was not found.";

        private const string InvalidErrorFormat = "Credential profile [{0}] is not valid.  Please ensure the profile contains a valid combination of properties.";
        private const string SourceErrorFormat = "Error reading source profile [{0}] for profile [{1}].";
        private const string MfaCallbackErrorFormat = "The profile [{0}] is an assume role profile that requires an MFA.  This type of profile is not allowed here.  " +
            "Please use an assume role profile that doesn't require an MFA, or a different type of profile.";
        private const string UserIdentityCallbackErrorFormat = "The profile [{0}] is a SAML role profile that specifies a user identity.  This type of profile is not allowed here.  " +
            "Please use a SAML role profile without an explicit user identity, or a different type of profile.";

        private const string InvalidErrorAnonymous = "The credential options provided are not valid.  Please ensure the options contain a valid combination of properties.";
        private const string SourceErrorFormatAnonymous = "Error reading source profile [{0}] for the credential options provided.";
        private const string MfaCallbackErrorAnonymous = "The credential options represent AssumeRoleAWSCredentials that require an MFA.  This is not allowed here.  " +
            "Please use credential options for AssumeRoleAWSCredentials that don't require an MFA, or a different type of credentials.";
        private const string UserIdentityCallbackErrorAnonymous = "The credential options represent FederatedAWSCredentials that specify a user identity.  This is not allowed here.  " +
            "Please use credential options for FederatedAWSCredentials without an explicit user identity, or a different type of credentials.";

        private static readonly MemoryCredentialProfileSource ProfileStore = new MemoryCredentialProfileSource();

        private static readonly CredentialProfile InvalidProfile =
            new CredentialProfile("invalid_profile", new CredentialProfileOptions
            {
                AccessKey = "aws_access_key_id"
            });

        private static readonly CredentialProfile BasicProfile =
            new CredentialProfile("basic_profile", new CredentialProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key"
            });

        private static readonly CredentialProfile SessionProfile =
            new CredentialProfile("session_profile", new CredentialProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                Token = "token"
            });

        private static readonly CredentialProfile AssumeRoleProfile =
            new CredentialProfile("assume_role_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile"
            });

        private static readonly CredentialProfile AssumeRoleExternalProfile =
            new CredentialProfile("assume_role_external_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                ExternalID = "external_id"
            });

        private static readonly CredentialProfile AssumeRoleMfaProfile =
            new CredentialProfile("assume_role_mfa_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                MfaSerial = "mfa_serial"
            });

        private static readonly CredentialProfile AssumeRoleExternalMfaProfile =
            new CredentialProfile("assume_role_external_mfa_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile",
                ExternalID = "external_id",
                MfaSerial = "mfa_serial"
            });

        private static readonly CredentialProfile SAMLRoleProfile =
            new CredentialProfile("saml_role_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                EndpointName = "endpoint_name"
            });

        private static readonly CredentialProfile SAMLRoleUserIdentityProfile =
            new CredentialProfile("saml_role_user_identity_profile", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                EndpointName = "endpoint_name",
                UserIdentity = "user_identity"
            });

        private static readonly CredentialProfile AssumeRoleProfileSourceNotBasic =
            new CredentialProfile("assume_role_profile_source_not_basic", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "session_profile"
            });

        private static readonly CredentialProfile AssumeRoleProfileInvalidSource =
            new CredentialProfile("assume_role_profile_invalid_source", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "invalid_profile"
            });

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

        private static readonly SAMLEndpoint SomeSAMLEndpoint = new SAMLEndpoint("endpoint_name", new Uri("https://samlendpoint.com"));

        private static readonly FederatedAWSCredentials FederatedCredentials =
            new FederatedAWSCredentials(SomeSAMLEndpoint, "role_arn");

        private static readonly FederatedAWSCredentials FederatedUserIdentityCredentials =
            new FederatedAWSCredentials(SomeSAMLEndpoint, "role_arn", new FederatedAWSCredentialsOptions()
            {
                UserIdentity = "user_identity"
            });

        [TestMethod]
        public void TryGetInvalidCredentials()
        {
            AWSCredentials credentials;
            Assert.IsFalse(AWSCredentialsFactory.TryGetAWSCredentials(InvalidProfile, ProfileStore, out credentials));
            Assert.IsNull(credentials);
        }

        [TestMethod]
        public void TryGetBasicCredentials()
        {
            AWSCredentials credentials;
            Assert.IsTrue(AWSCredentialsFactory.TryGetAWSCredentials(BasicProfile, ProfileStore, out credentials));
            Assert.IsNotNull(credentials);
            Assert.AreEqual(BasicCredentials, credentials);
        }

        [TestMethod]
        public void GetInvalidCredentials()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(InvalidProfile, ProfileStore);
            }, typeof(InvalidDataException), string.Format(InvalidErrorFormat, InvalidProfile.Name));
        }

        [TestMethod]
        public void GetBasicCredentials()
        {
            Assert.AreEqual(BasicCredentials, AWSCredentialsFactory.GetAWSCredentials(BasicProfile, ProfileStore));
        }

        [TestMethod]
        public void GetSessionCredentials()
        {
            Assert.AreEqual(SessionCredentials, AWSCredentialsFactory.GetAWSCredentials(SessionProfile, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfile, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleExternalCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleExternalProfile, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleMfaCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleMfaProfile, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleExternalMfaCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalMfaCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleExternalMfaProfile, ProfileStore));
        }

        [TestMethod]
        public void GetSAMLRoleCredentials()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints))
            {
                (new SAMLEndpointManager()).RegisterEndpoint(SomeSAMLEndpoint);
                AssertFederatedCredentialsAreEqual(FederatedCredentials, AWSCredentialsFactory.GetAWSCredentials(SAMLRoleProfile, ProfileStore));
            }
        }

        [TestMethod]
        public void GetSAMLRoleUserIdentityCredentials()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints))
            {
                (new SAMLEndpointManager()).RegisterEndpoint(SomeSAMLEndpoint);
                AssertFederatedCredentialsAreEqual(FederatedUserIdentityCredentials, AWSCredentialsFactory.GetAWSCredentials(SAMLRoleUserIdentityProfile, ProfileStore));
            }
        }

        [TestMethod]
        public void GetAssumeRoleProfileSourceNotBasic()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileSourceNotBasic, ProfileStore);
                }, typeof(InvalidDataException), string.Format(SourceErrorFormat, SessionProfile.Name,
                "assume_role_profile_source_not_basic")).InnerException;
            }, typeof(InvalidDataException), string.Format(SourceNotBasicFormat, SessionProfile.Name));
        }

        [TestMethod]
        public void GetAssumeRoleProfileInvalidSource()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileInvalidSource, ProfileStore);
                }, typeof(InvalidDataException), string.Format(SourceErrorFormat, InvalidProfile.Name,
                "assume_role_profile_invalid_source")).InnerException;
            }
            , typeof(InvalidDataException), string.Format(InvalidErrorFormat, InvalidProfile.Name));
        }

        [TestMethod]
        public void GetAssumeRoleMfaCredentialsNoCallback()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(AssumeRoleMfaProfile, ProfileStore, true);
            }, typeof(InvalidOperationException), string.Format(MfaCallbackErrorFormat, AssumeRoleMfaProfile.Name));
        }

        [TestMethod]
        public void GetSAMLAssumeRoleUserIdentityCredentialsNoCallback()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(SAMLRoleUserIdentityProfile, ProfileStore, true);
            }, typeof(InvalidOperationException), string.Format(UserIdentityCallbackErrorFormat, SAMLRoleUserIdentityProfile.Name));
        }

        [TestMethod]
        public void TryGetInvalidCredentialsAnonymous()
        {
            AWSCredentials credentials;
            Assert.IsFalse(AWSCredentialsFactory.TryGetAWSCredentials(InvalidProfile.Options, ProfileStore, out credentials));
            Assert.IsNull(credentials);
        }

        [TestMethod]
        public void TryGetBasicCredentialsAnonymous()
        {
            AWSCredentials credentials;
            Assert.IsTrue(AWSCredentialsFactory.TryGetAWSCredentials(BasicProfile.Options, ProfileStore, out credentials));
            Assert.IsNotNull(credentials);
            Assert.AreEqual(BasicCredentials, credentials);
        }

        [TestMethod]
        public void GetInvalidCredentialsAnonymous()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(InvalidProfile.Options, ProfileStore);
            }, typeof(InvalidDataException), InvalidErrorAnonymous);
        }

        [TestMethod]
        public void GetBasicCredentialsAnonymous()
        {
            Assert.AreEqual(BasicCredentials, AWSCredentialsFactory.GetAWSCredentials(BasicProfile.Options, ProfileStore));
        }

        [TestMethod]
        public void GetSessionCredentialsAnonymous()
        {
            Assert.AreEqual(SessionCredentials, AWSCredentialsFactory.GetAWSCredentials(SessionProfile.Options, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleCredentialsAnonymous()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfile.Options, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleExternalCredentialsAnonymous()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleExternalProfile.Options, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleMfaCredentialsAnonymous()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleMfaCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleMfaProfile.Options, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleExternalMfaCredentialsAnonymous()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleExternalMfaCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleExternalMfaProfile.Options, ProfileStore));
        }

        [TestMethod]
        public void GetSAMLRoleCredentialsAnonymous()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints))
            {
                (new SAMLEndpointManager()).RegisterEndpoint(SomeSAMLEndpoint);
                AssertFederatedCredentialsAreEqual(FederatedCredentials, AWSCredentialsFactory.GetAWSCredentials(SAMLRoleProfile.Options, ProfileStore));
            }
        }

        [TestMethod]
        public void GetSAMLRoleUserIdentityCredentialsAnonymous()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints))
            {
                (new SAMLEndpointManager()).RegisterEndpoint(SomeSAMLEndpoint);
                AssertFederatedCredentialsAreEqual(FederatedUserIdentityCredentials, AWSCredentialsFactory.GetAWSCredentials(SAMLRoleUserIdentityProfile.Options, ProfileStore));
            }
        }

        [TestMethod]
        public void GetAssumeRoleProfileSourceNotBasicAnonymous()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileSourceNotBasic.Options, ProfileStore);
                }, typeof(InvalidDataException), string.Format(SourceErrorFormatAnonymous, SessionProfile.Name)).InnerException;
            }, typeof(InvalidDataException), string.Format(SourceNotBasicFormat, SessionProfile.Name));
        }

        [TestMethod]
        public void GetAssumeRoleProfileInvalidSourceAnonymous()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileInvalidSource.Options, ProfileStore);
                }, typeof(InvalidDataException), string.Format(SourceErrorFormatAnonymous, InvalidProfile.Name)).InnerException;
            }
            , typeof(InvalidDataException), string.Format(InvalidErrorFormat, InvalidProfile.Name));
        }

        [TestMethod]
        public void GetAssumeRoleMfaCredentialsNoCallbackAnonymous()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(AssumeRoleMfaProfile.Options, ProfileStore, true);
            }, typeof(InvalidOperationException), MfaCallbackErrorAnonymous);
        }

        [TestMethod]
        public void GetSAMLAssumeRoleUserIdentityCredentialsNoCallbackAnonymous()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(SAMLRoleUserIdentityProfile.Options, ProfileStore, true);
            }, typeof(InvalidOperationException), UserIdentityCallbackErrorAnonymous);
        }

        private void AssertAssumeRoleCredentialsAreEqual(AssumeRoleAWSCredentials expected, AWSCredentials actualAWSCredentials)
        {
            var actual = actualAWSCredentials as AssumeRoleAWSCredentials;
            Assert.IsNotNull(actual);
            // can't do AreEqual because this contains DateTime.UtcNow.Ticks
            Assert.IsTrue(actual.RoleSessionName.StartsWith("aws-dotnet-sdk-session-"));
            Assert.AreEqual(expected.RoleArn, actual.RoleArn);
            Assert.AreEqual(expected.PreemptExpiryTime, actual.PreemptExpiryTime);
            Assert.AreEqual(expected.SourceCredentials, actual.SourceCredentials);
            Assert.AreEqual(expected.Options.DurationSeconds, actual.Options.DurationSeconds);
            Assert.AreEqual(expected.Options.ExternalId, actual.Options.ExternalId);
            Assert.AreEqual(expected.Options.MfaSerialNumber, actual.Options.MfaSerialNumber);
            Assert.AreEqual(expected.Options.MfaTokenCodeCallback, actual.Options.MfaTokenCodeCallback);
            Assert.AreEqual(expected.Options.Policy, actual.Options.Policy);
            Assert.AreEqual(expected.Options.ProxySettings, actual.Options.ProxySettings);
        }

        private void AssertFederatedCredentialsAreEqual(FederatedAWSCredentials expected, AWSCredentials actualAWSCredentials)
        {
            var actual = actualAWSCredentials as FederatedAWSCredentials;
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.SAMLEndpoint.Name, actual.SAMLEndpoint.Name);
            Assert.AreEqual(expected.RoleArn, actual.RoleArn);
            Assert.AreEqual(expected.Options.UserIdentity, actual.Options.UserIdentity);
        }

        private class MemoryCredentialProfileSource : ICredentialProfileSource
        {
            public Dictionary<string, CredentialProfile> Profiles { get; private set; }

            public MemoryCredentialProfileSource()
            {
                Profiles = new Dictionary<string, CredentialProfile>();
            }

            public bool TryGetProfile(string profileName, out CredentialProfile profile)
            {
                return Profiles.TryGetValue(profileName, out profile);
            }
        }
    }
}
