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
using Amazon.Runtime.CredentialManagement.Internal;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AppConfigAWSCredentialsTest
    {
        private const string AccessKey = "AWSAccessKey";
        private const string SecretKey = "AWSSecretKey";
        private const string AccessKeyValue = "access_key";
        private const string SecretKeyValue = "secret_key";

        private const string TokenValue = "token";
        private const string RoleArnValue = "role_arn";
        private const string MfaSerialValue = "mfa_serial";
        private const string EndpointNameValue = "endpoint_name";
        private const string UserIdentityValue = "user_identity";

        private string originalAccessKey;
        private string originalSecretKey;
        private string originalProfileName;
        private string originalProfilesLocation;

        private const string BasicProfileName = "basic_profile";
        private static readonly CredentialProfileOptions BasicProfileOptions = new CredentialProfileOptions()
        {
            AccessKey = AccessKeyValue,
            SecretKey = SecretKeyValue
        };

        private const string SessionProfileName = "session_profile";
        private static readonly CredentialProfileOptions SessionProfileOptions = new CredentialProfileOptions()
        {
            AccessKey = AccessKeyValue,
            SecretKey = SecretKeyValue,
            Token = TokenValue
        };

        private const string AssumeRoleMfaProfileName = "assume_role_mfa_profile";
        private static readonly CredentialProfileOptions AssumeRoleMfaProfileOptions = new CredentialProfileOptions()
        {
            RoleArn = RoleArnValue,
            SourceProfile = BasicProfileName,
            MfaSerial = MfaSerialValue
        };

        private const string SAMLRoleUserIdentityProfileName = "saml_user_identity_profile_name";
        private static readonly CredentialProfileOptions SAMLRoleUserIdentityProfileOptions = new CredentialProfileOptions()
        {
            RoleArn = RoleArnValue,
            EndpointName = EndpointNameValue,
            UserIdentity = UserIdentityValue
        };

        [TestInitialize]
        public void Initialize()
        {
            NameValueCollection appConfig = ConfigurationManager.AppSettings;
            originalAccessKey = appConfig.Get(AccessKey);
            originalSecretKey = appConfig.Get(SecretKey);

            originalProfileName = AWSConfigs.AWSProfileName;
            originalProfilesLocation = AWSConfigs.AWSProfilesLocation;
        }

        [TestCleanup]
        public void Cleanup()
        {
            SetConfigValues(originalAccessKey, originalSecretKey, originalProfileName, originalProfilesLocation);
        }

        private void SetConfigValues(string accessKey, string secretKey, string profileName, string profilesLocation)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(AccessKey);
            config.AppSettings.Settings.Remove(SecretKey);

            if (accessKey != null)
            {
                config.AppSettings.Settings.Add(AccessKey, accessKey);
            }
            if (secretKey != null)
            {
                config.AppSettings.Settings.Add(SecretKey, secretKey);
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            AWSConfigs.AWSProfileName = profileName;
            AWSConfigs.AWSProfilesLocation = profilesLocation;
        }

        [TestMethod]
        public void NoneConfigured()
        {
            AssertExtensions.ExpectException(() =>
            {
                new AppConfigAWSCredentials();
            }, typeof(InvalidOperationException), new Regex("did not contain credential information"));
        }

        [TestMethod]
        public void AccessKeyIdNoSecretKey()
        {
            SetConfigValues(AccessKeyValue, null, null, null);
            AssertExtensions.ExpectException(() =>
            {
                new AppConfigAWSCredentials();
            }, typeof(InvalidOperationException), new Regex("did not contain credential information"));
        }

        [TestMethod]
        public void SecretKeyNoAccessKeyId()
        {
            SetConfigValues(null, SecretKeyValue, null, null);
            AssertExtensions.ExpectException(() =>
            {
                new AppConfigAWSCredentials();
            }, typeof(InvalidOperationException), new Regex("did not contain credential information"));
        }

        [TestMethod]
        public void CredentialsSet()
        {
            SetConfigValues(AccessKeyValue, SecretKeyValue, null, null);
            var credentials = new AppConfigAWSCredentials().GetCredentials();
            Assert.AreEqual(typeof(ImmutableCredentials), credentials.GetType());
            Assert.AreEqual(AccessKeyValue, credentials.AccessKey);
            Assert.AreEqual(SecretKeyValue, credentials.SecretKey);
            Assert.AreEqual(String.Empty, credentials.Token);
        }

        [TestMethod]
        public void NameSetSessionProfile()
        {
            using (var fixture = new SharedCredentialsFileTestFixture())
            {
                var profile = new CredentialProfile(SessionProfileName, SessionProfileOptions);
                fixture.CredentialsFile.RegisterProfile(profile);
                SetConfigValues(null, null, SessionProfileName, fixture.CredentialsFile.FilePath);
                var credentials = new AppConfigAWSCredentials().GetCredentials();
                Assert.AreEqual(typeof(ImmutableCredentials), credentials.GetType());
                Assert.AreEqual(AccessKeyValue, credentials.AccessKey);
                Assert.AreEqual(SecretKeyValue, credentials.SecretKey);
                Assert.AreEqual(TokenValue, credentials.Token);
            }
        }

        [TestMethod]
        public void NameSetAssumeRoleMFAProfile()
        {
            using (var fixture = new SharedCredentialsFileTestFixture())
            {
                var basicProfile = new CredentialProfile(BasicProfileName, BasicProfileOptions);
                fixture.CredentialsFile.RegisterProfile(basicProfile);
                var assumeRoleProfile = new CredentialProfile(AssumeRoleMfaProfileName, AssumeRoleMfaProfileOptions);
                fixture.CredentialsFile.RegisterProfile(assumeRoleProfile);
                SetConfigValues(null, null, AssumeRoleMfaProfileName, fixture.CredentialsFile.FilePath);
                AssertExtensions.ExpectException(() =>
                {
                    new AppConfigAWSCredentials().GetCredentials();
                }, typeof(InvalidOperationException), new Regex("is an assume role profile that requires an MFA"));
            }
        }

        [TestMethod]
        public void NameSetSAMLRoleUserIdentityProfile()
        {
            using (var fixture = new NetSDKCredentialsFileTestFixture())
            {
                var profile = new CredentialProfile(SAMLRoleUserIdentityProfileName, SAMLRoleUserIdentityProfileOptions);
                CredentialProfileUtils.SetUniqueKey(profile, Guid.NewGuid());
                fixture.ProfileStore.RegisterProfile(profile);
                SetConfigValues(null, null, SAMLRoleUserIdentityProfileName, null);
                AssertExtensions.ExpectException(() =>
                {
                    new AppConfigAWSCredentials().GetCredentials();
                }, typeof(InvalidOperationException), new Regex("is a SAML role profile that specifies a user identity"));

            }
        }
    }
}
