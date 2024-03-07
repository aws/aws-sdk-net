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

using System;
using System.Threading.Tasks;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SSOOIDC;
using Amazon.SSOOIDC.Internal;
using Amazon.SSOOIDC.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CoreAmazonSSOOIDCTest
    {
        private CoreAmazonSSOOIDCTestFixture _testFixture;

        [TestInitialize]
        public void TestSetup()
        {
            _testFixture = new CoreAmazonSSOOIDCTestFixture();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _testFixture.Dispose();
        }

        [TestMethod]
        public void GetSsoToken()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);
            var response = CoreAmazonSSOOIDC.GetSsoToken(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);

            _testFixture.AssertRegisterClientRequest(_testFixture.RegisterClientRequest);
            _testFixture.AssertStartDeviceAuthorizationRequest(_testFixture.StartDeviceAuthorizationRequest);
            _testFixture.AssertCreateTokenRequest(_testFixture.CreateTokenRequest);
            Assert.AreEqual(1, _testFixture.SsoVerificationCallbackCount);
        }

        [TestMethod]
        public async Task GetSsoTokenAsync()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);
            var response = await CoreAmazonSSOOIDC.GetSsoTokenAsync(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);

            _testFixture.AssertRegisterClientAsyncRequest(_testFixture.RegisterClientRequest);
            _testFixture.AssertStartDeviceAuthorizationAsyncRequest(_testFixture.StartDeviceAuthorizationRequest);
            _testFixture.AssertCreateTokenAsyncRequest(_testFixture.CreateTokenRequest);
            Assert.AreEqual(1, _testFixture.SsoVerificationCallbackCount);
        }

        [TestMethod]
        public void GetSsoToken_Poll_AuthorizationPendingException()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);
            _testFixture.WithCreateTokenExceptionThenSuccess(new AuthorizationPendingException("simulation"));

            var response = CoreAmazonSSOOIDC.GetSsoToken(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);
            _testFixture.AssertCreateTokenRequest(_testFixture.CreateTokenRequest, timesCalled: 2);
            _testFixture.AssertSleepCalled(5000);
        }

        [TestMethod]
        public async Task GetSsoTokenAsync_Poll_AuthorizationPendingException()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);
            _testFixture.WithCreateTokenExceptionThenSuccess(new AuthorizationPendingException("simulation"));

            var response = await CoreAmazonSSOOIDC.GetSsoTokenAsync(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);
            _testFixture.AssertCreateTokenAsyncRequest(_testFixture.CreateTokenRequest, timesCalled: 2);
            _testFixture.AssertSleepCalled(5000);
        }

        [TestMethod]
        public void GetSsoToken_Poll_SlowDownException()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);
            _testFixture.WithCreateTokenExceptionThenSuccess(new SlowDownException("simulation"));

            var response = CoreAmazonSSOOIDC.GetSsoToken(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);
            _testFixture.AssertCreateTokenRequest(_testFixture.CreateTokenRequest, timesCalled: 2);
            _testFixture.AssertSleepCalled(10000);
        }

        [TestMethod]
        public async Task GetSsoTokenAsync_Poll_SlowDownException()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);
            _testFixture.WithCreateTokenExceptionThenSuccess(new SlowDownException("simulation"));

            var response = await CoreAmazonSSOOIDC.GetSsoTokenAsync(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);
            _testFixture.AssertCreateTokenAsyncRequest(_testFixture.CreateTokenRequest, timesCalled: 2);
            _testFixture.AssertSleepCalled(10000);
        }

        [TestMethod]
        public void GetSsoToken_Poll_TimeoutException()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);

            _testFixture.WithCreateTokenExceptionThenSuccess(new TimeoutException("simulation"));

            var response = CoreAmazonSSOOIDC.GetSsoToken(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);

            _testFixture.AssertCreateTokenRequest(_testFixture.CreateTokenRequest, timesCalled: 2);
            _testFixture.AssertSleepCalled(10000);
        }

        [TestMethod]
        public async Task GetSsoTokenAsync_Poll_TimeoutException()
        {
            var minExpectedExpiresAt = DateTime.Now.AddSeconds(_testFixture.CreateTokenResponse.ExpiresIn);

            _testFixture.WithCreateTokenExceptionThenSuccess(new TimeoutException("simulation"));

            var response = await CoreAmazonSSOOIDC.GetSsoTokenAsync(_testFixture.OidcClient.Object,
                _testFixture.GetSsoTokenRequest, _testFixture.GetSsoTokenContext.Object);

            AssertValidResponse(response, minExpectedExpiresAt);

            _testFixture.AssertCreateTokenAsyncRequest(_testFixture.CreateTokenRequest, timesCalled: 2);
            _testFixture.AssertSleepCalled(10000);
        }

        [TestMethod]
        public void GetSsoToken_Poll_ExpiredTokenException()
        {
            _testFixture.WithCreateTokenException(new ExpiredTokenException("simulation"));

            Assert.ThrowsException<AmazonSSOOIDCException>(() =>
                CoreAmazonSSOOIDC.GetSsoToken(_testFixture.OidcClient.Object, _testFixture.GetSsoTokenRequest));

            _testFixture.AssertCreateTokenRequest(_testFixture.CreateTokenRequest);
        }

        [TestMethod]
        public async Task GetSsoTokenAsync_Poll_ExpiredTokenException()
        {
            _testFixture.WithCreateTokenException(new ExpiredTokenException("simulation"));

            await Assert.ThrowsExceptionAsync<AmazonSSOOIDCException>(async () =>
                await CoreAmazonSSOOIDC.GetSsoTokenAsync(_testFixture.OidcClient.Object,
                    _testFixture.GetSsoTokenRequest));

            _testFixture.AssertCreateTokenAsyncRequest(_testFixture.CreateTokenRequest);
        }

        [TestMethod]
        public void GetSsoToken_Poll_Exception()
        {
            var exception = new Exception("unexpected exception");
            _testFixture.WithCreateTokenException(exception);

            var actualException = Assert.ThrowsException<Exception>(() =>
                CoreAmazonSSOOIDC.GetSsoToken(_testFixture.OidcClient.Object, _testFixture.GetSsoTokenRequest));

            Assert.AreSame(exception, actualException);
            _testFixture.AssertCreateTokenRequest(_testFixture.CreateTokenRequest);
        }

        [TestMethod]
        public async Task GetSsoTokenAsync_Poll_Exception()
        {
            var exception = new Exception("unexpected exception");
            _testFixture.WithCreateTokenException(exception);

            var actualException = await Assert.ThrowsExceptionAsync<Exception>(async () =>
                await CoreAmazonSSOOIDC.GetSsoTokenAsync(_testFixture.OidcClient.Object,
                    _testFixture.GetSsoTokenRequest));

            Assert.AreSame(exception, actualException);
            _testFixture.AssertCreateTokenAsyncRequest(_testFixture.CreateTokenRequest);
        }

        private void AssertValidResponse(GetSsoTokenResponse response, DateTime minExpectedExpiresAt)
        {
            Assert.IsNotNull(response);
            Assert.AreEqual(_testFixture.CreateTokenResponse.AccessToken, response.AccessToken);
            Assert.IsTrue(minExpectedExpiresAt <= response.ExpiresAt);
        }
    }
}