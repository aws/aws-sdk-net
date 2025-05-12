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
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Settings;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AWSCredentialsFactoryTest
    {

        private const string SourceNotBasicOrSessionFormat = "Source profile [{0}] is not a basic or a session profile.";
        private const string SourceNotFoundFormat = "Source profile [{0}] was not found.";

        private const string InvalidErrorFormat = "Credential profile [{0}] is not valid.  Please ensure the profile contains a valid combination of properties.";
        private const string SourceErrorFormat = "Error reading source profile [{0}] for profile [{1}].";
        private const string CyclicalSourceProfileErrorFormat = "Error reading profile [{0}]: the source profile definition is cyclical.";
        private const string MfaCallbackErrorFormat = "The profile [{0}] is an assume role profile that requires an MFA.  This type of profile is not allowed here.  " +
            "Please use an assume role profile that doesn't require an MFA, or a different type of profile.";
        private const string UserIdentityCallbackErrorFormat = "The profile [{0}] is a SAML role profile that specifies a user identity.  This type of profile is not allowed here.  " +
            "Please use a SAML role profile without an explicit user identity, or a different type of profile.";
        private const string SsoErrorFormat =
            "The profile [{0}] is an SSO profile.  This type of profile is not allowed here.  " +
            "Please use a different type of profile.";

        private const string InvalidErrorAnonymous = "The credential options provided are not valid.  Please ensure the options contain a valid combination of properties.";
        private const string SourceErrorFormatAnonymous = "Error reading source profile [{0}] for the credential options provided.";
        private const string MfaCallbackErrorAnonymous = "The credential options represent AssumeRoleAWSCredentials that require an MFA.  This is not allowed here.  " +
            "Please use credential options for AssumeRoleAWSCredentials that don't require an MFA, or a different type of credentials.";
        private const string UserIdentityCallbackErrorAnonymous = "The credential options represent FederatedAWSCredentials that specify a user identity.  This is not allowed here.  " +
            "Please use credential options for FederatedAWSCredentials without an explicit user identity, or a different type of credentials.";
        private const string SsoErrorAnonymous =
            "The credential options represent SSOAWSCredentials.  This is not allowed here.  " +
            "Please use a different type of credentials.";

        private const string CredentialSourceErrorFormat = "Error reading credential source [{0}] for profile [{1}].";
        private const string InvalidCredentialSourceErrorFormat = "Credential source [{0}] is invalid.";
        private const string IMDSNotEnabledError = "Unable to retrieve credentials.";
        private const string CredentialSourceContainerNotSetErrorFormat = "Cannot fetch credentials from container - neither AWS_CONTAINER_CREDENTIALS_RELATIVE_URI" +
                          " or AWS_CONTAINER_CREDENTIALS_FULL_URI environment variables are set.";

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

        private static readonly CredentialProfile AssumeRoleProfileBasicSource =
            new CredentialProfile("assume_role_profile_basic_source", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "basic_profile"
            });

        private static readonly CredentialProfile AssumeRoleProfileSessionSource =
            new CredentialProfile("assume_role_profile_session_source", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "session_profile"
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

        private static readonly CredentialProfile SsoProfile =
            new CredentialProfile("sso_profile", new CredentialProfileOptions
            {
                SsoAccountId = "account_id",
                SsoRegion = "region",
                SsoRoleName = "role_name",
                SsoStartUrl = "start_url",
            });

        private static readonly CredentialProfile SsoProfileMissingFields =
            new CredentialProfile("sso_profile_missing_fields", new CredentialProfileOptions
            {
                SsoStartUrl = "start_url",
            });

        private static readonly CredentialProfile SsoProfileMixedFields =
            new CredentialProfile("sso_profile_mixed_fields", new CredentialProfileOptions
            {
                AccessKey = "aws_access_key_id",
                SecretKey = "aws_secret_access_key",
                SsoAccountId = "account_id",
                SsoRegion = "region",
                SsoRoleName = "role_name",
                SsoStartUrl = "start_url",
            });

        private static readonly CredentialProfile AssumeRoleProfileSAMLRoleSource =
            new CredentialProfile("assume_role_profile_source_not_basic_or_session", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "saml_role_user_identity_profile"
            });

        private static readonly CredentialProfile AssumeRoleProfileInvalidSource =
            new CredentialProfile("assume_role_profile_invalid_source", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "invalid_profile"
            });

        private static readonly CredentialProfile AssumeRoleCredentialSourceEnvironment =
            new CredentialProfile("assume_role_credential_source_environment", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                CredentialSource = "Environment"
            });

        private static readonly CredentialProfile AssumeRoleCredentialSourceEc2InstanceMetadata =
            new CredentialProfile("assume_role_credential_source_ec2_instance_metadata", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                CredentialSource = "Ec2InstanceMetadata"
            });

        private static readonly CredentialProfile AssumeRoleCredentialSourceEcsContainer=
            new CredentialProfile("assume_role_credential_source_ecs_container", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                CredentialSource = "EcsContainer"
            });

        private static readonly CredentialProfile AssumeRoleCredentialSourceInvalid =
            new CredentialProfile("assume_role_credential_source_invalid", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                CredentialSource = "InvalidSource"
            });

        private static readonly CredentialProfile AssumeRoleChainedAssumeRoleSource =
            new CredentialProfile("assume_role_chained_assume_role_source", new CredentialProfileOptions
            {
                RoleArn = "second_role_arn",
                SourceProfile = "assume_role_profile_basic_source"
            });

        static AWSCredentialsFactoryTest()
        {
            ProfileStore.Profiles.Add(InvalidProfile.Name, InvalidProfile);
            ProfileStore.Profiles.Add(BasicProfile.Name, BasicProfile);
            ProfileStore.Profiles.Add(SessionProfile.Name, SessionProfile);
            ProfileStore.Profiles.Add(AssumeRoleProfileBasicSource.Name, AssumeRoleProfileBasicSource);
            ProfileStore.Profiles.Add(AssumeRoleProfileSessionSource.Name, AssumeRoleProfileSessionSource);
            ProfileStore.Profiles.Add(AssumeRoleExternalProfile.Name, AssumeRoleExternalProfile);
            ProfileStore.Profiles.Add(AssumeRoleExternalMfaProfile.Name, AssumeRoleExternalMfaProfile);
            ProfileStore.Profiles.Add(AssumeRoleMfaProfile.Name, AssumeRoleMfaProfile);
            ProfileStore.Profiles.Add(AssumeRoleProfileSAMLRoleSource.Name, AssumeRoleProfileSAMLRoleSource);
            ProfileStore.Profiles.Add(AssumeRoleProfileInvalidSource.Name, AssumeRoleProfileInvalidSource);
            ProfileStore.Profiles.Add(SAMLRoleProfile.Name, SAMLRoleProfile);
            ProfileStore.Profiles.Add(SAMLRoleUserIdentityProfile.Name, SAMLRoleUserIdentityProfile);
            ProfileStore.Profiles.Add(AssumeRoleCredentialSourceEnvironment.Name, AssumeRoleCredentialSourceEnvironment);
            ProfileStore.Profiles.Add(AssumeRoleCredentialSourceEc2InstanceMetadata.Name, AssumeRoleCredentialSourceEc2InstanceMetadata);
            ProfileStore.Profiles.Add(AssumeRoleCredentialSourceEcsContainer.Name, AssumeRoleCredentialSourceEcsContainer);
            ProfileStore.Profiles.Add(AssumeRoleCredentialSourceInvalid.Name, AssumeRoleCredentialSourceInvalid);
            ProfileStore.Profiles.Add(AssumeRoleChainedAssumeRoleSource.Name, AssumeRoleChainedAssumeRoleSource);
            ProfileStore.Profiles.Add(AssumeRoleLoopedAssumeRoleSource1.Name, AssumeRoleLoopedAssumeRoleSource1);
            ProfileStore.Profiles.Add(AssumeRoleLoopedAssumeRoleSource2.Name, AssumeRoleLoopedAssumeRoleSource2);
            ProfileStore.Profiles.Add(SsoProfile.Name, SsoProfile);
            ProfileStore.Profiles.Add(SsoProfileMissingFields.Name, SsoProfileMissingFields);
            ProfileStore.Profiles.Add(SsoProfileMixedFields.Name, SsoProfileMixedFields);
        }

        private static readonly BasicAWSCredentials BasicCredentials =
            new BasicAWSCredentials("aws_access_key_id", "aws_secret_access_key");

        private static readonly SessionAWSCredentials SessionCredentials =
            new SessionAWSCredentials("aws_access_key_id", "aws_secret_access_key", "token");

        private static readonly AssumeRoleAWSCredentials AssumeRoleCredentialsBasicSource =
            new AssumeRoleAWSCredentials(BasicCredentials, "role_arn", "role_session_name");

        private static readonly AssumeRoleAWSCredentials AssumeRoleCredentialsSessionSource =
            new AssumeRoleAWSCredentials(SessionCredentials, "role_arn", "role_session_name");

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

        private static readonly AssumeRoleAWSCredentials AssumeRoleChainedAssumeRoleCredentials =
            new AssumeRoleAWSCredentials(AssumeRoleCredentialsBasicSource, "second_role_arn", "role_session_name");

        private static readonly SSOAWSCredentials SsoCredentials =
            new SSOAWSCredentials(
                SsoProfile.Options.SsoAccountId,
                SsoProfile.Options.SsoRegion,
                SsoProfile.Options.SsoRoleName,
                SsoProfile.Options.SsoStartUrl,
                new SSOAWSCredentialsOptions()
                {
                });

        private static readonly SAMLEndpoint SomeSAMLEndpoint = new SAMLEndpoint("endpoint_name", new Uri("https://samlendpoint.com"));

        private static readonly FederatedAWSCredentials FederatedCredentials =
            new FederatedAWSCredentials(SomeSAMLEndpoint, "role_arn");

        private static readonly FederatedAWSCredentials FederatedUserIdentityCredentials =
            new FederatedAWSCredentials(SomeSAMLEndpoint, "role_arn", new FederatedAWSCredentialsOptions()
            {
                UserIdentity = "user_identity"
            });

        private static readonly AssumeRoleAWSCredentials AssumeRoleProfileSAMLSourceCredentials =
            new AssumeRoleAWSCredentials(FederatedUserIdentityCredentials, "role_arn", "role_session_name");

        private static readonly CredentialProfile AssumeRoleLoopedAssumeRoleSource1 =
            new CredentialProfile("assume_role_looped_assume_role_source1", new CredentialProfileOptions
            {
                RoleArn = "role_arn",
                SourceProfile = "assume_role_looped_assume_role_source2"
            });

        private static readonly CredentialProfile AssumeRoleLoopedAssumeRoleSource2 =
            new CredentialProfile("assume_role_looped_assume_role_source2", new CredentialProfileOptions
            {
                RoleArn = "second_role_arn",
                SourceProfile = "assume_role_looped_assume_role_source1"
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
        public void GetBasicCredentialsNoUserCrypto()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints, null, false))
            {
                Assert.AreEqual(BasicCredentials, AWSCredentialsFactory.GetAWSCredentials(BasicProfile, ProfileStore));
            }
        }

        [TestMethod]
        public void GetSessionCredentials()
        {
            Assert.AreEqual(SessionCredentials, AWSCredentialsFactory.GetAWSCredentials(SessionProfile, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleCredentialsBasicSource()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentialsBasicSource, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileBasicSource, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleCredentialsSessionSource()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentialsSessionSource, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileSessionSource, ProfileStore));
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
        public void GetAssumeRoleChainedAssumeRoleCredentials()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleChainedAssumeRoleCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleChainedAssumeRoleSource, ProfileStore));
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
        public void GetSAMLRoleCredentialsNoUserCrypto()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints, null, false))
            {
                AssertExtensions.ExpectException(() =>
                {
                    AWSCredentialsFactory.GetAWSCredentials(SAMLRoleProfile, ProfileStore);
                }, typeof(InvalidDataException), "Federated credentials are not available on this platform.");
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
        public void GetAssumeRoleProfileSourceNotBasicOrSession()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints))
            {
                (new SAMLEndpointManager()).RegisterEndpoint(SomeSAMLEndpoint);
                AssertAssumeRoleCredentialsAreEqual(AssumeRoleProfileSAMLSourceCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileSAMLRoleSource, ProfileStore));
            }
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
        public void GetSsoCredentialsNoCallback()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(SsoProfile, ProfileStore, true);
            }, typeof(InvalidOperationException), string.Format(SsoErrorFormat, SsoProfile.Name));
        }

        [TestMethod]
        public void GetSsoCredentials()
        {
            AssertSSOCredentialsAreEqual(
                SsoCredentials,
                AWSCredentialsFactory.GetAWSCredentials(SsoProfile, ProfileStore));
        }

        [TestMethod]
        public void GetSsoCredentialsWithMissingFields()
        {
            // can not create SSO Credentials without the Region

            AssertExtensions.ExpectException(() =>
                    AWSCredentialsFactory.GetAWSCredentials(SsoProfileMissingFields, ProfileStore),
                typeof(InvalidDataException)); 
        }

        [TestMethod]
        public void GetSsoCredentialsWithMixedFields()
        {
            AssertSSOCredentialsAreEqual(
                SsoCredentials,
                AWSCredentialsFactory.GetAWSCredentials(SsoProfileMixedFields, ProfileStore));
        }

        [TestMethod]
        public void GetAssumeRoleProfileSourceWithLoop()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    throw AssertExtensions.ExpectException(() =>
                    {
                        AWSCredentialsFactory.GetAWSCredentials(AssumeRoleLoopedAssumeRoleSource1, ProfileStore);
                    }, typeof(InvalidDataException), string.Format(SourceErrorFormat, AssumeRoleLoopedAssumeRoleSource2.Name,
                        AssumeRoleLoopedAssumeRoleSource1.Name)).InnerException;
                }, typeof(InvalidDataException), string.Format(SourceErrorFormat, AssumeRoleLoopedAssumeRoleSource1.Name,
                        AssumeRoleLoopedAssumeRoleSource2.Name)).InnerException;
            }, typeof(InvalidDataException), string.Format(CyclicalSourceProfileErrorFormat, AssumeRoleLoopedAssumeRoleSource1.Name));
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
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleCredentialsBasicSource, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileBasicSource.Options, ProfileStore));
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
        public void GetAssumeRoleChainedAssumeRoleCredentialsAnonymous()
        {
            AssertAssumeRoleCredentialsAreEqual(AssumeRoleChainedAssumeRoleCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleChainedAssumeRoleSource.Options, ProfileStore));
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
        public void GetAssumeRoleProfileSourceNotBasicOrSessionAnonymous()
        {
            using (var fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredSAMLEndpoints))
            {
                (new SAMLEndpointManager()).RegisterEndpoint(SomeSAMLEndpoint);
                AssertAssumeRoleCredentialsAreEqual(AssumeRoleProfileSAMLSourceCredentials, AWSCredentialsFactory.GetAWSCredentials(AssumeRoleProfileSAMLRoleSource.Options, ProfileStore));
            }
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

        [TestMethod]
        public void GetSsoCredentialsNoCallbackAnonymous()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(SsoProfile.Options, ProfileStore, true);
            }, typeof(InvalidOperationException), SsoErrorAnonymous);
        }

        [TestMethod]
        public void GetAssumeRoleCredentialSourceEnvironment()
        {
            using (new AWSCredentialsFactoryTestCredentialSourceFixture(AssumeRoleCredentialSourceEnvironment.Options, SessionCredentials))
            {
                AWSCredentials credentials;
                Assert.IsTrue(AWSCredentialsFactory.TryGetAWSCredentials(AssumeRoleCredentialSourceEnvironment.Options, ProfileStore, out credentials));
                Assert.IsNotNull(credentials);
                Assert.AreEqual(typeof(EnvironmentVariablesAWSCredentials), ReflectionHelpers.Invoke(credentials, "SourceCredentials").GetType());
            }
        }

        [TestMethod]
        public void GetAssumeRoleCredentialSourceEc2InstanceMetadata()
        {
            using (new AWSCredentialsFactoryTestCredentialSourceFixture(AssumeRoleCredentialSourceEc2InstanceMetadata.Options, null))
            {
                AWSCredentials credentials;
                Assert.IsTrue(AWSCredentialsFactory.TryGetAWSCredentials(AssumeRoleCredentialSourceEc2InstanceMetadata.Options, ProfileStore, out credentials));
                Assert.IsNotNull(credentials);
                Assert.AreEqual("Amazon.Runtime.DefaultInstanceProfileAWSCredentials", ReflectionHelpers.Invoke(credentials, "SourceCredentials").GetType().ToString());
            }
        }

        [TestMethod]
        public void GetAssumeRoleCredentialSourceEcContainer()
        {
            using (new AWSCredentialsFactoryTestCredentialSourceFixture(AssumeRoleCredentialSourceEcsContainer.Options, null))
            {
                AWSCredentials credentials;
                Assert.IsTrue(AWSCredentialsFactory.TryGetAWSCredentials(AssumeRoleCredentialSourceEcsContainer.Options, ProfileStore, out credentials));
                Assert.IsNotNull(credentials);
                Assert.AreEqual(typeof(GenericContainerCredentials), ReflectionHelpers.Invoke(credentials, "SourceCredentials").GetType());
            }
        }

        [TestMethod]
        public void GetAssumeRoleCredentialSourceInvalid()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleCredentialSourceInvalid, ProfileStore);

                }, typeof(InvalidDataException), string.Format(CredentialSourceErrorFormat, AssumeRoleCredentialSourceInvalid.Options.CredentialSource,
                AssumeRoleCredentialSourceInvalid.Name)).InnerException;
            }
            , typeof(InvalidDataException), string.Format(InvalidCredentialSourceErrorFormat, AssumeRoleCredentialSourceInvalid.Options.CredentialSource));
        }

        [TestMethod]
        public void GetAssumeRoleCredentialSourceIDMSNotEnabled()
        {
            AssertExtensions.ExpectException(() =>
            {
                using (new AWSCredentialsFactoryTestCredentialSourceFixture(AssumeRoleCredentialSourceEc2InstanceMetadata.Options, null, true))
                {
                    AWSCredentialsFactory.GetAWSCredentials(AssumeRoleCredentialSourceEc2InstanceMetadata, ProfileStore);
                }
            }, typeof(AmazonServiceException), IMDSNotEnabledError);
        }

        [TestMethod]
        public void GetAssumeRoleCredentialSourceEcContainerNotSet()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    using (new AWSCredentialsFactoryTestCredentialSourceFixture(AssumeRoleCredentialSourceEcsContainer.Options, null, true))
                    {
                        AWSCredentialsFactory.GetAWSCredentials(AssumeRoleCredentialSourceEcsContainer, ProfileStore);
                    }
                }, typeof(InvalidDataException), string.Format(CredentialSourceErrorFormat, AssumeRoleCredentialSourceEcsContainer.Options.CredentialSource,
                AssumeRoleCredentialSourceEcsContainer.Name)).InnerException;
            }
            , typeof(InvalidDataException), string.Format(CredentialSourceContainerNotSetErrorFormat, GenericContainerCredentials.RelativeURIEnvVariable));
        }

        private void AssertAssumeRoleCredentialsAreEqual(AssumeRoleAWSCredentials expected, AWSCredentials actualAWSCredentials)
        {
            var actual = actualAWSCredentials as AssumeRoleAWSCredentials;
            Assert.IsNotNull(actual);
            // can't do AreEqual because this contains DateTime.UtcNow.Ticks
            Assert.IsTrue(actual.RoleSessionName.StartsWith("aws-dotnet-sdk-session-"));
            Assert.AreEqual(expected.RoleArn, actual.RoleArn);
            Assert.AreEqual(expected.PreemptExpiryTime, actual.PreemptExpiryTime);
            if (expected.SourceCredentials is AssumeRoleAWSCredentials && actual.SourceCredentials is AssumeRoleAWSCredentials)
                AssertAssumeRoleCredentialsAreEqual(expected.SourceCredentials as AssumeRoleAWSCredentials, actual.SourceCredentials);
            else if (expected.SourceCredentials is FederatedAWSCredentials && actual.SourceCredentials is FederatedAWSCredentials)
                AssertFederatedCredentialsAreEqual(expected.SourceCredentials as FederatedAWSCredentials, actual.SourceCredentials);
            else
                Assert.AreEqual(expected.SourceCredentials, actual.SourceCredentials);
            Assert.AreEqual(expected.Options.DurationSeconds, actual.Options.DurationSeconds);
            Assert.AreEqual(expected.Options.ExternalId, actual.Options.ExternalId);
            Assert.AreEqual(expected.Options.MfaSerialNumber, actual.Options.MfaSerialNumber);
            Assert.AreEqual(expected.Options.MfaTokenCodeCallback, actual.Options.MfaTokenCodeCallback);
            Assert.AreEqual(expected.Options.Policy, actual.Options.Policy);
            Assert.AreEqual(expected.Options.ProxySettings, actual.Options.ProxySettings);
        }

        private void AssertSSOCredentialsAreEqual(SSOAWSCredentials expected, AWSCredentials actualAWSCredentials)
        {
            var actual = actualAWSCredentials as SSOAWSCredentials;
            Assert.IsNotNull(actual);

            Assert.AreEqual(expected.AccountId, actual.AccountId);
            Assert.AreEqual(expected.Region, actual.Region);
            Assert.AreEqual(expected.RoleName, actual.RoleName);
            Assert.AreEqual(expected.StartUrl, actual.StartUrl);
            Assert.AreEqual(expected.PreemptExpiryTime, actual.PreemptExpiryTime);
            
            Assert.AreEqual(expected.Options.ClientName, actual.Options.ClientName);
            Assert.AreEqual(expected.Options.SsoVerificationCallback, actual.Options.SsoVerificationCallback);
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

        public class AWSCredentialsFactoryTestCredentialSourceFixture : IDisposable
        {
            private const string AWS_ACCESS_KEY_ID_ENVIRONMENT_VARIABLE = "AWS_ACCESS_KEY_ID";
            private const string AWS_SECRET_ACCESS_KEY_ENVIRONMENT_VARIABLE = "AWS_SECRET_ACCESS_KEY";
            private const string AWS_SESSION_TOKEN_ENVIRONMENT_VARIABLE = "AWS_SESSION_TOKEN";
            private const string MOCK_ECSContainer_URIEnvVariableValue = "/EcContainer/v0/credentials?id=test";


            private string originalAWSAccessKeyIdValue;
            private string originalAWSSecretAccessKeyValue;
            private string originalAWSSessionTokenValue;
            private string originalAWSMetadataDisabled;
            private string originalContainerURIEnvVariableValue;
            private CredentialSourceType credentialSourceType;

            public AWSCredentialsFactoryTestCredentialSourceFixture(CredentialProfileOptions options, SessionAWSCredentials sessionCredentials, bool disable = false)
            {
                credentialSourceType = (CredentialSourceType)Enum.Parse(typeof(CredentialSourceType), options.CredentialSource, true);
                switch (credentialSourceType)
                {
                    case CredentialSourceType.Environment:
                        ImmutableCredentials credentials = sessionCredentials.GetCredentials();
                        originalAWSAccessKeyIdValue = SetEnvironmentVariable(AWS_ACCESS_KEY_ID_ENVIRONMENT_VARIABLE, credentials.AccessKey);
                        originalAWSSecretAccessKeyValue = SetEnvironmentVariable(AWS_SECRET_ACCESS_KEY_ENVIRONMENT_VARIABLE, credentials.SecretKey);
                        originalAWSSessionTokenValue = SetEnvironmentVariable(AWS_SESSION_TOKEN_ENVIRONMENT_VARIABLE, credentials.Token);
                        break;
                    case CredentialSourceType.Ec2InstanceMetadata:
                        originalAWSMetadataDisabled = SetEnvironmentVariable(EC2InstanceMetadata.AWS_EC2_METADATA_DISABLED, disable ? "true" : "false");
                        break;
                    case CredentialSourceType.EcsContainer:
                        originalContainerURIEnvVariableValue = SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, disable ? null : MOCK_ECSContainer_URIEnvVariableValue);
                        break;
                }
            }

            public void Dispose()
            {
                switch (credentialSourceType)
                {
                    case CredentialSourceType.Environment:
                        Environment.SetEnvironmentVariable(AWS_ACCESS_KEY_ID_ENVIRONMENT_VARIABLE, originalAWSAccessKeyIdValue);
                        Environment.SetEnvironmentVariable(AWS_SECRET_ACCESS_KEY_ENVIRONMENT_VARIABLE, originalAWSSecretAccessKeyValue);
                        Environment.SetEnvironmentVariable(AWS_SESSION_TOKEN_ENVIRONMENT_VARIABLE, originalAWSSessionTokenValue);
                        break;
                    case CredentialSourceType.Ec2InstanceMetadata:
                        Environment.SetEnvironmentVariable(EC2InstanceMetadata.AWS_EC2_METADATA_DISABLED, originalAWSMetadataDisabled);
                        break;
                    case CredentialSourceType.EcsContainer:
                        Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, originalContainerURIEnvVariableValue);
                        break;
                }
            }

            private string SetEnvironmentVariable(string name, string value)
            {
                string originalValue = Environment.GetEnvironmentVariable(name);
                Environment.SetEnvironmentVariable(name, value);
                return originalValue;
            }

        }
    }
}
