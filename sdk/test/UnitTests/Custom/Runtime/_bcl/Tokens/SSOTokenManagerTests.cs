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
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests for <see cref="SSOTokenManager"/>
    /// </summary>
    [TestClass]
    public class SSOTokenManagerTests
    {
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        // "Realistic start URL example"
        [DataRow(
            "https://d-abc123.awsapps.com/start",
            "40a89917e3175433e361b710a9d43528d7f1890a.json")]
        // "Start URL without a path"
        [DataRow(
            "https://d-abc123.awsapps.com",
            "ab6e8a5ac0e97bd6867ae3eacd5fd7dc0cd4de86.json")]
        // "An arbitrary more vanity domain"
        [DataRow(
            "https://vanity.example.com",
            "7ed69759fe20aa3027c01db4b744e1437b0c8f4f.json")]
        public void ValidateTokenCacheLocation(string startUrl, string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>();
            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new
            {
                accessToken = "cachedToken",
                expiresAt = "3000-12-25T21:30:00Z",
            };
            mockFileSystem.WriteAllText(
                Path.Combine(testCacheFolder, expectedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            var ssoTokenManager = new SSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));

            var token = ssoTokenManager.GetToken(new SSOTokenManagerGetTokenOptions
            {
                StartUrl = startUrl,
                CacheFolderLocation = testCacheFolder
            });

            // Assert sso token was saved to cache
            Assert.AreEqual(cachedSsoToken.accessToken, token.AccessToken);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        // "Realistic start URL example"
        [DataRow(
            "https://d-abc123.awsapps.com/start",
            "40a89917e3175433e361b710a9d43528d7f1890a.json")]
        // "Start URL without a path"
        [DataRow(
            "https://d-abc123.awsapps.com",
            "ab6e8a5ac0e97bd6867ae3eacd5fd7dc0cd4de86.json")]
        // "An arbitrary more vanity domain"
        [DataRow(
            "https://vanity.example.com",
            "7ed69759fe20aa3027c01db4b744e1437b0c8f4f.json")]
        public async Task ValidateTokenCacheLocationAsync(string startUrl, string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>();
            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new
            {
                accessToken = "cachedToken",
                expiresAt = "3000-12-25T21:30:00Z",
            };

            mockFileSystem.WriteAllText(
                Path.Combine(testCacheFolder, expectedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            var ssoTokenManager = new SSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));

            var token = await ssoTokenManager.GetTokenAsync(new SSOTokenManagerGetTokenOptions
            {
                StartUrl = startUrl,
                CacheFolderLocation = testCacheFolder
            });

            // Assert sso token was saved to cache
            Assert.AreEqual(cachedSsoToken.accessToken, token.AccessToken);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        [DataRow(
    "7ed69759fe20aa3027c01db4b744e1437b0c8f4f.json")]
        public async Task ValidateLogoutAllAsync(string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>();
            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new
            {
                accessToken = "cachedToken",
                expiresAt = "3000-12-25T21:30:00Z",
            };

            await mockFileSystem.WriteAllTextAsync(
                Path.Combine(testCacheFolder, expectedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            var ssoTokenManager = new MoqSSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));

            await ssoTokenManager.LogoutAsync(testCacheFolder);
            // Assert sso token was deleted from cache
            Assert.AreEqual(mockFileSystem.Files.Count, 0);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        [DataRow(
    "7ed69759fe20aa3027c01db4b744e1437b0c8f4f.json")]
        public void ValidateLogoutAll(string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>();
            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new
            {
                accessToken = "cachedToken",
                expiresAt = "3000-12-25T21:30:00Z",
            };

            mockFileSystem.WriteAllText(
                Path.Combine(testCacheFolder, expectedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            var ssoTokenManager = new MoqSSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));

            ssoTokenManager.Logout(testCacheFolder);
            // Assert sso token was deleted from cache
            Assert.AreEqual(mockFileSystem.Files.Count, 0);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        // "Realistic start URL example"
        [DataRow(
    "https://d-abc123.awsapps.com/start",
    "40a89917e3175433e361b710a9d43528d7f1890a.json")]
        // "Start URL without a path"
        [DataRow(
    "https://d-abc123.awsapps.com",
    "ab6e8a5ac0e97bd6867ae3eacd5fd7dc0cd4de86.json")]
        // "An arbitrary more vanity domain"
        [DataRow(
    "https://vanity.example.com",
    "7ed69759fe20aa3027c01db4b744e1437b0c8f4f.json")]
        public void ValidateLogout(string startUrl, string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>();
            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new
            {
                accessToken = "cachedToken",
                expiresAt = "3000-12-25T21:30:00Z",
                startUrl
            };
            var result2 = JsonSerializer.Serialize(cachedSsoToken);

            mockFileSystem.WriteAllText(
                Path.Combine(testCacheFolder, expectedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            var unrelatedCacheFile = Guid.NewGuid().ToString() + ".json";

            mockFileSystem.WriteAllText(
                Path.Combine(testCacheFolder, unrelatedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            Assert.AreEqual(mockFileSystem.Files.Count, 2);

            var ssoTokenManager = new MoqSSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));
            var options = new SSOTokenManagerGetTokenOptions
            {
                StartUrl = startUrl,
                CacheFolderLocation = testCacheFolder
            };
            ssoTokenManager.Logout(options);

            // After logout with options is executed, expected file count should be 1
            Assert.AreEqual(mockFileSystem.Files.Count, 1);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        // "Realistic start URL example"
        [DataRow(
            "https://d-abc123.awsapps.com/start",
            "40a89917e3175433e361b710a9d43528d7f1890a.json")]
        // "Start URL without a path"
        [DataRow(
            "https://d-abc123.awsapps.com",
            "ab6e8a5ac0e97bd6867ae3eacd5fd7dc0cd4de86.json")]
        // "An arbitrary more vanity domain"
        [DataRow(
            "https://vanity.example.com",
            "7ed69759fe20aa3027c01db4b744e1437b0c8f4f.json")]
        public async Task ValidateLogoutAsync(string startUrl, string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockSSOOIDCClient = new Mock<ICoreAmazonSSOOIDC>();
            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new
            {
                accessToken = "cachedToken",
                expiresAt = "3000-12-25T21:30:00Z",
                startUrl
            };

            await mockFileSystem.WriteAllTextAsync(
                Path.Combine(testCacheFolder, expectedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            var unrelatedCacheFile = Guid.NewGuid().ToString() + ".json";

            await mockFileSystem.WriteAllTextAsync(
                Path.Combine(testCacheFolder, unrelatedCacheFile),
                JsonSerializer.Serialize(cachedSsoToken));

            Assert.AreEqual(mockFileSystem.Files.Count, 2);

            var ssoTokenManager = new MoqSSOTokenManager(
                mockSSOOIDCClient.Object,
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem));
            var options = new SSOTokenManagerGetTokenOptions
            {
                StartUrl = startUrl,
                CacheFolderLocation = testCacheFolder
            };
            await ssoTokenManager.LogoutAsync(options);

            // After logout with options is executed, expected file count should be 1
            Assert.AreEqual(mockFileSystem.Files.Count, 1);
        }
    }

    public class MoqSSOTokenManager : SSOTokenManager
    {
        public MoqSSOTokenManager(ICoreAmazonSSOOIDC ssooidcClient, ISSOTokenFileCache ssoTokenFileCache) : base(ssooidcClient, ssoTokenFileCache) { }
        protected override ICoreAmazonSSO_Logout CreateSSOLogoutClient(string region, WebProxy proxySettings = null)
        {
            return new Mock<ICoreAmazonSSO_Logout>().Object;
        }
    }
}