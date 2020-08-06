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
using Amazon.Runtime.Internal;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Settings;
using Amazon.SecurityToken.SAML;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class FederatedAWSCredentialsTest
    {
        private static readonly string ProfileName = Guid.NewGuid().ToString();
        private static readonly string RoleArn = Guid.NewGuid().ToString();
        private static readonly string AccessKeyID = Guid.NewGuid().ToString();
        private static readonly string SecretAccessKey = Guid.NewGuid().ToString();
        private static readonly string Token = Guid.NewGuid().ToString();
        private static readonly string Subject = Guid.NewGuid().ToString();
        private static readonly string EndpointName = Guid.NewGuid().ToString();
        private static readonly string UserIdentity = Guid.NewGuid().ToString() + "\\" + Guid.NewGuid().ToString();
        private static readonly SAMLEndpoint SomeSAMLEndpoint = new SAMLEndpoint(EndpointName, new Uri("https://somesamlendpoint.com"));

        private EncryptedStoreTestFixture fixture;
        private SAMLRoleSessionManager sessionManager = new SAMLRoleSessionManager();

        [TestInitialize]
        public void Initialize()
        {
            fixture = new EncryptedStoreTestFixture(SettingsConstants.RegisteredRoleSessions);
        }

        [TestCleanup]
        public void CleanUp()
        {
            fixture.Dispose();
        }

        [TestMethod]
        public void NullOptions()
        {
            AssertExtensions.ExpectException(() => {
                new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn, null);
            }, typeof(ArgumentNullException), new Regex("Parameter name: options"));
        }

        [TestMethod]
        public void NullEndpoint()
        {
            AssertExtensions.ExpectException(() => {
                new FederatedAWSCredentials(null, RoleArn);
            }, typeof(ArgumentNullException), new Regex("Parameter name: samlEndpoint"));
        }

        [TestMethod]
        public void NullArn()
        {
            AssertExtensions.ExpectException(() => {
                new FederatedAWSCredentials(SomeSAMLEndpoint, null);
            }, typeof(ArgumentException), "RoleArn must not be null or empty.");
        }

        [TestMethod]
        public void EmptyArn()
        {
            AssertExtensions.ExpectException(() => {
                new FederatedAWSCredentials(SomeSAMLEndpoint, "");
            }, typeof(ArgumentException), "RoleArn must not be null or empty.");
        }

        [TestMethod]
        public void GetCredentialsSessionCached()
        {
            var sessionName = SomeSAMLEndpoint.Name + "," + RoleArn + ",";
            var samlImmutableCredentials = new SAMLImmutableCredentials(AccessKeyID, SecretAccessKey, Token, DateTime.UtcNow.AddDays(1), Subject);
            sessionManager.RegisterRoleSession(sessionName, samlImmutableCredentials);
            var awsCredentials = new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn);
            AssertSAMLImmutableCredentials(samlImmutableCredentials, awsCredentials.GetCredentials());
        }

        [TestMethod]
        public void GetCredentialsSessionCachedProfileName()
        {
            var samlImmutableCredentials = new SAMLImmutableCredentials(AccessKeyID, SecretAccessKey, Token, DateTime.UtcNow.AddDays(1), Subject);
            sessionManager.RegisterRoleSession(ProfileName, samlImmutableCredentials);
            var awsCredentials = new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn, new FederatedAWSCredentialsOptions()
            {
                ProfileName = ProfileName
            });
            AssertSAMLImmutableCredentials(samlImmutableCredentials, awsCredentials.GetCredentials());
        }

        [TestMethod]
        public void GetCredentialsSessionCachedExpired()
        {
            var sessionName = SomeSAMLEndpoint.Name + "," + RoleArn + ",";
            var samlImmutableCredentials = new SAMLImmutableCredentials(AccessKeyID, SecretAccessKey, Token, DateTime.UtcNow.AddDays(-1), Subject);
            sessionManager.RegisterRoleSession(sessionName, samlImmutableCredentials);
            var awsCredentials = new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn);
            AssertCallSTSFails(awsCredentials);
        }

        [TestMethod]
        public void GetCredentialsSessionCachedAlmostExpired()
        {
            var sessionName = SomeSAMLEndpoint.Name + "," + RoleArn + ",";
            var samlImmutableCredentials = new SAMLImmutableCredentials(AccessKeyID, SecretAccessKey, Token, DateTime.UtcNow.AddMinutes(1), Subject);
            sessionManager.RegisterRoleSession(sessionName, samlImmutableCredentials);
            var awsCredentials = new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn);
            AssertCallSTSFails(awsCredentials);
        }

        [TestMethod]
        public void GetCredentialsUserIdentityNoCallback()
        {
            var awsCredentials = new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn, new FederatedAWSCredentialsOptions()
            {
                UserIdentity = UserIdentity
            });
            AssertCallSTSFails(awsCredentials);
        }

        [TestMethod]
        public void GetCredentialsUserIdentityAndCallback()
        {
            var awsCredentials = new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn, new FederatedAWSCredentialsOptions()
            {
                UserIdentity = UserIdentity,
                CredentialRequestCallback = (e) => { throw new Exception("BLAH"); }
            });

            AssertExtensions.ExpectException(() =>
            {
                awsCredentials.GetCredentials();
            }, typeof(Exception), "BLAH");
        }

        [TestMethod]
        public void GetCredentialsUserCancels()
        {
            var awsCredentials = new FederatedAWSCredentials(SomeSAMLEndpoint, RoleArn, new FederatedAWSCredentialsOptions()
            {
                UserIdentity = UserIdentity,
                CredentialRequestCallback = (e) => { return null; }
            });

            AssertExtensions.ExpectException(() =>
            {
                awsCredentials.GetCredentials();
            }, typeof(FederatedAuthenticationCancelledException), "User cancelled credential request.");
        }

        /// <summary>
        /// Asserts that the call to GetCredentials() on the FederatedAWSCredentials is
        /// actually attempting to call STS and failing.
        /// </summary>
        /// <param name="credentials"></param>
        private void AssertCallSTSFails(FederatedAWSCredentials credentials)
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    throw AssertExtensions.ExpectException(() =>
                    {
                        credentials.GetCredentials();
                    }, typeof(AmazonClientException)).InnerException;
                }, typeof(FederatedAuthenticationFailureException)).InnerException;
            }, typeof(AdfsAuthenticationControllerException), new Regex("(The remote name could not be resolved: \'somesamlendpoint.com\')|(The remote server returned an error: \\(502\\) Bad Gateway.)"));
        }

        private static void AssertSAMLImmutableCredentials(SAMLImmutableCredentials expected, ImmutableCredentials actual)
        {
            var actualSaml = actual as SAMLImmutableCredentials;
            Assert.IsNotNull(actualSaml);
            Assert.AreEqual(expected.AccessKey, actualSaml.AccessKey);
            AssertExtensions.AssertDateTimesAreEqualToTheSecond(expected.Expires, actualSaml.Expires);
            Assert.AreEqual(expected.SecretKey, actualSaml.SecretKey);
            Assert.AreEqual(expected.Token, actualSaml.Token);
            Assert.AreEqual(expected.Subject, actualSaml.Subject);
        }
    }
}
