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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Amazon.Runtime.Credentials.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SsoTokenTest
    {
        private SsoTokenTestFixture _ssoTokenTestFixture;

        [TestInitialize]
        public void TestSetup()
        {
            _ssoTokenTestFixture = new SsoTokenTestFixture();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _ssoTokenTestFixture.Dispose();
        }

        [TestMethod]
        public void IsExpired_ExpiredToken()
        {
            new DateTime[]
                {
                    // expiresAt values
                    DateTime.UtcNow.AddDays(-1),
                    DateTime.UtcNow,
                    DateTime.UtcNow.AddMinutes(1),
                    DateTime.UtcNow.AddMinutes(14),
                }.ToList()
                .ForEach(expiresAt =>
                {
                    _ssoTokenTestFixture.SampleSsoToken.ExpiresAt = expiresAt;
                    Assert.IsTrue(_ssoTokenTestFixture.SampleSsoToken.IsExpired(),
                        $"Expected token to be expired, expiresOn: {expiresAt}");
                });
        }

        [TestMethod]
        public void IsExpired_NonExpiredToken()
        {
            new DateTime[]
                {
                    // expiresAt values
                    DateTime.UtcNow.AddMinutes(16),
                    DateTime.UtcNow.AddMinutes(100),
                    DateTime.UtcNow.AddDays(1),
                }.ToList()
                .ForEach(expiresAt =>
                {
                    _ssoTokenTestFixture.SampleSsoToken.ExpiresAt = expiresAt;
                    Assert.IsFalse(_ssoTokenTestFixture.SampleSsoToken.IsExpired(),
                        $"Expected token to be non-expired, expiresOn: {expiresAt}");
                });
        }

        [TestMethod]
        public void ToJson()
        {
            Assert.AreEqual(_ssoTokenTestFixture.SampleSsoTokenJson, SsoTokenUtils.ToJson(_ssoTokenTestFixture.SampleSsoToken));
            Assert.AreEqual(_ssoTokenTestFixture.SampleSsoTokenJson, _ssoTokenTestFixture.SampleSsoToken.AsJson());
        }

        [TestMethod]
        public void FromJson()
        {
            var cache = SsoTokenUtils.FromJson(_ssoTokenTestFixture.SampleSsoTokenJson);
            Assert.AreEqual(_ssoTokenTestFixture.SampleSsoToken.AccessToken, cache.AccessToken);
            Assert.AreEqual(_ssoTokenTestFixture.SampleSsoToken.Region, cache.Region);
            Assert.AreEqual(_ssoTokenTestFixture.SampleSsoToken.ExpiresAt, cache.ExpiresAt);
            Assert.AreEqual(_ssoTokenTestFixture.SampleSsoToken.StartUrl, cache.StartUrl);
        }
    }
}
