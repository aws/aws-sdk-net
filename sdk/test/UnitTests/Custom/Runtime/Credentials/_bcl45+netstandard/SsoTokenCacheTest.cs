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
using System.IO;
using Amazon.Runtime.Credentials.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SsoTokenCacheTest
    {
        private SsoTokenTestFixture _ssoTokenTestFixture;
        private SsoTokenCache _tokenCache;

        [TestInitialize]
        public void TestSetup()
        {
            _ssoTokenTestFixture = new SsoTokenTestFixture();
            _tokenCache = _ssoTokenTestFixture.GetTokenCache(_ssoTokenTestFixture.SampleSsoToken.StartUrl);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _ssoTokenTestFixture.Dispose();
        }

        [TestMethod]
        public void GetCacheFilename()
        {
            var startUrl = "https://some-example-start-url.awsapps.com/start";
            string path = SsoTokenCache.GetCacheFilename(startUrl);
            Assert.IsNotNull(path);
            Assert.IsTrue(path.EndsWith("0feed1a26da2ea2a0ae8a631756414f4b5680d9b.json"));
        }

        [TestMethod]
        public void Save()
        {
            var cachePath = Path.Combine(_ssoTokenTestFixture.ScratchDirectory,
                SsoTokenCache.GetCacheFilename(_ssoTokenTestFixture.SampleSsoToken.StartUrl));
            
            Assert.IsFalse(File.Exists(cachePath));
            Assert.IsTrue(_tokenCache.TrySave(_ssoTokenTestFixture.SampleSsoToken));
            Assert.IsTrue(File.Exists(cachePath));
        }

        [TestMethod]
        public void SaveToNestedFolder()
        {
            var nestedFolder = Path.Combine(_ssoTokenTestFixture.ScratchDirectory, "foo", "bar");
            var tokenCache = new SsoTokenCache(nestedFolder, _ssoTokenTestFixture.SampleSsoToken.StartUrl);
            var cachePath = Path.Combine(nestedFolder,
                SsoTokenCache.GetCacheFilename(_ssoTokenTestFixture.SampleSsoToken.StartUrl));
            
            Assert.IsFalse(File.Exists(cachePath));
            Assert.IsTrue(tokenCache.TrySave(_ssoTokenTestFixture.SampleSsoToken));
            Assert.IsTrue(File.Exists(cachePath));
        }

        [TestMethod]
        public void SaveToBadPath()
        {
            var cachePath = Path.Combine(_ssoTokenTestFixture.ScratchDirectory, "illegalchars:*?");
            var tokenCache = new SsoTokenCache(cachePath, _ssoTokenTestFixture.SampleSsoToken.StartUrl);
            
            Assert.IsFalse(tokenCache.TrySave(_ssoTokenTestFixture.SampleSsoToken));
        }

        [TestMethod]
        public void GetAccessToken()
        {
            _ssoTokenTestFixture.SampleSsoToken.ExpiresAt = DateTime.UtcNow.AddDays(1);
            _tokenCache.TrySave(_ssoTokenTestFixture.SampleSsoToken);

            Assert.AreEqual(_ssoTokenTestFixture.SampleSsoToken.AccessToken, _tokenCache.GetAccessToken());
        }

        [TestMethod]
        public void GetAccessTokenWhenExpired()
        {
            _ssoTokenTestFixture.SampleSsoToken.ExpiresAt = DateTime.UtcNow.AddDays(-1);
            _tokenCache.TrySave(_ssoTokenTestFixture.SampleSsoToken);

            Assert.IsNull(_tokenCache.GetAccessToken());
        }

        [TestMethod]
        public void GetAccessTokenWhenNotCached()
        {
            Assert.IsNull(_tokenCache.GetAccessToken());
        }

        [TestMethod]
        public void DisabledWhenCacheFolderIsNull()
        {
            var tokenCache = new SsoTokenCache(null, _ssoTokenTestFixture.SampleSsoToken.StartUrl);

            Assert.IsFalse(tokenCache.TrySave(_ssoTokenTestFixture.SampleSsoToken));
            Assert.IsNull(tokenCache.GetAccessToken());
        }
    }
}
