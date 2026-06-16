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
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AWSCredentialsFactorySSOTest
    {
        private const string SsoErrorFormat =
            "The profile [{0}] is an SSO profile.  This type of profile is not allowed here.  " +
            "Please use a different type of profile.";

        private const string SsoErrorAnonymous =
            "The credential options represent SSOAWSCredentials.  This is not allowed here.  " +
            "Please use a different type of credentials.";

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

        private static readonly SSOAWSCredentials SsoCredentials =
            new SSOAWSCredentials(
                SsoProfile.Options.SsoAccountId,
                SsoProfile.Options.SsoRegion,
                SsoProfile.Options.SsoRoleName,
                SsoProfile.Options.SsoStartUrl,
                new SSOAWSCredentialsOptions()
                {
                });

        private static readonly MemoryCredentialProfileSource ProfileStore = new MemoryCredentialProfileSource();

        static AWSCredentialsFactorySSOTest()
        {
            ProfileStore.Profiles.Add(SsoProfile.Name, SsoProfile);
            ProfileStore.Profiles.Add(SsoProfileMissingFields.Name, SsoProfileMissingFields);
            ProfileStore.Profiles.Add(SsoProfileMixedFields.Name, SsoProfileMixedFields);
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
        public void GetSsoCredentialsNoCallbackAnonymous()
        {
            AssertExtensions.ExpectException(() =>
            {
                AWSCredentialsFactory.GetAWSCredentials(SsoProfile.Options, ProfileStore, true);
            }, typeof(InvalidOperationException), SsoErrorAnonymous);
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

        private class MemoryCredentialProfileSource : ICredentialProfileSource
        {
            public System.Collections.Generic.Dictionary<string, CredentialProfile> Profiles { get; private set; }

            public MemoryCredentialProfileSource()
            {
                Profiles = new System.Collections.Generic.Dictionary<string, CredentialProfile>();
            }

            public bool TryGetProfile(string profileName, out CredentialProfile profile)
            {
                return Profiles.TryGetValue(profileName, out profile);
            }
        }
    }
}
