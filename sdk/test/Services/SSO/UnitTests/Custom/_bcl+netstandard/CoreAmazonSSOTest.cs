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

using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.SSO.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CoreAmazonSSOTest
    {
        private CoreAmazonSSOTestFixture _testFixture;

        [TestInitialize]
        public void TestSetup()
        {
            _testFixture = new CoreAmazonSSOTestFixture();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _testFixture.Dispose();
        }

#if BCL
        [TestMethod]
        public void CredentialsFromSsoAccessToken()
        {
            var credentials = CoreAmazonSSO.CredentialsFromSsoAccessToken(
                _testFixture.SsoClient.Object,
                _testFixture.GetRoleCredentialsRequest.AccountId,
                _testFixture.GetRoleCredentialsRequest.RoleName,
                _testFixture.GetRoleCredentialsRequest.AccessToken,
                null);

            Assert.IsNotNull(credentials);

            var immutableCredentials = credentials as SSOImmutableCredentials;
            Assert.IsNotNull(immutableCredentials);
            Assert.AreEqual(_testFixture.GetRoleCredentialsResponse.RoleCredentials.AccessKeyId, immutableCredentials.AccessKey);
            Assert.AreEqual(_testFixture.GetRoleCredentialsResponse.RoleCredentials.SecretAccessKey, immutableCredentials.SecretKey);
            Assert.AreEqual(_testFixture.GetRoleCredentialsResponse.RoleCredentials.SessionToken, immutableCredentials.Token);
            Assert.AreEqual(CoreAmazonSSOTestFixture.SampleExpiration, immutableCredentials.Expiration);

            _testFixture.AssertGetRoleCredentialsRequest(_testFixture.GetRoleCredentialsRequest);
        }
#endif

#if ASYNC_AWAIT
        [TestMethod]
        public async Task CredentialsFromSsoAccessTokenAsync()
        {
            var credentials = await CoreAmazonSSO.CredentialsFromSsoAccessTokenAsync(
                _testFixture.SsoClient.Object,
                _testFixture.GetRoleCredentialsRequest.AccountId,
                _testFixture.GetRoleCredentialsRequest.RoleName,
                _testFixture.GetRoleCredentialsRequest.AccessToken,
                null);

            Assert.IsNotNull(credentials);

            var immutableCredentials = credentials as SSOImmutableCredentials;
            Assert.IsNotNull(immutableCredentials);
            Assert.AreEqual(_testFixture.GetRoleCredentialsResponse.RoleCredentials.AccessKeyId, immutableCredentials.AccessKey);
            Assert.AreEqual(_testFixture.GetRoleCredentialsResponse.RoleCredentials.SecretAccessKey, immutableCredentials.SecretKey);
            Assert.AreEqual(_testFixture.GetRoleCredentialsResponse.RoleCredentials.SessionToken, immutableCredentials.Token);
            Assert.AreEqual(CoreAmazonSSOTestFixture.SampleExpiration, immutableCredentials.Expiration);

            _testFixture.AssertGetRoleCredentialsAsyncRequest(_testFixture.GetRoleCredentialsRequest);
        }
#endif
    }
}