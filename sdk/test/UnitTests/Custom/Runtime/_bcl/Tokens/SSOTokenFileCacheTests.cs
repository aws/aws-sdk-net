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
using System.Linq;
using System.Threading.Tasks;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests <see cref="SSOTokenFileCache"/>
    /// </summary>
    [TestClass]
    public class SSOTokenFileCacheTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        // "Basic name"
        [DataRow(
            "admin",
            "d033e22ae348aeb5660fc2140aec35850c4da997.json")]
        // "Name with dash"
        [DataRow(
            "dev-scopes",
            "75e4d41276d8bd17f85986fc6cccef29fd725ce3.json")]
        public void ValidateTokenCacheLocation(string sessionName, string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new SsoToken
            {
                Session = sessionName,
                AccessToken = "cachedToken",
                ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
            };

            var getTokenOptions = new SSOTokenManagerGetTokenOptions
            {
                Session = sessionName
            };

            var ssoTokenFileCache =
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem);

            ssoTokenFileCache.SaveSsoToken(cachedSsoToken, testCacheFolder);

            var success = ssoTokenFileCache.TryGetSsoToken(getTokenOptions, testCacheFolder, out var token);

            Assert.IsTrue(success);
            Assert.AreEqual(cachedSsoToken.AccessToken, token.AccessToken);

            // assert file was written to the correct location
            Assert.AreEqual(Path.Combine(testCacheFolder, expectedCacheFile), mockFileSystem.Files.First().Key);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        // "Basic name"
        [DataRow(
            "admin",
            "d033e22ae348aeb5660fc2140aec35850c4da997.json")]
        // "Name with dash"
        [DataRow(
            "dev-scopes",
            "75e4d41276d8bd17f85986fc6cccef29fd725ce3.json")]
        public async Task ValidateTokenCacheLocationAsync(string sessionName, string expectedCacheFile)
        {
            var testCacheFolder = "test";

            var mockFileSystem = new MockFileSystem();

            var cachedSsoToken = new SsoToken
            {
                Session = sessionName,
                AccessToken = "cachedToken",
                ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
            };

            var getTokenOptions = new SSOTokenManagerGetTokenOptions
            {
                Session = sessionName
            };

            var ssoTokenFileCache =
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    mockFileSystem,
                    mockFileSystem);

            await ssoTokenFileCache.SaveSsoTokenAsync(cachedSsoToken, testCacheFolder);

            var result = await ssoTokenFileCache.TryGetSsoTokenAsync(getTokenOptions, testCacheFolder);

            Assert.IsTrue(result.Success);
            Assert.AreEqual(cachedSsoToken.AccessToken, result.Value.AccessToken);

            // assert file was written to the correct location
            Assert.AreEqual(Path.Combine(testCacheFolder, expectedCacheFile), mockFileSystem.Files.First().Key);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task ValidateTokenCacheScanAndDeleteAsync()
        {
            int sampleCacheFileCount = 5;
            int expectedFileCount = 3; // first.json has AccessToken removed and fifth.txt is invalid file
            int invalidFileCount = sampleCacheFileCount - expectedFileCount;
            var testCacheFolder = "test";

            var mockFileSystem = new MockFileSystem();
            var ssoTokenFileCache =
                   new SSOTokenFileCache(
                       CryptoUtilFactory.CryptoInstance,
                       mockFileSystem,
                       mockFileSystem);
            // setup mock filesystem for all but one file
            for (int i = 0; i < sampleCacheFileCount - 1; i++)
            {
                var sessionName = Guid.NewGuid().ToString();
                var cachedSsoToken = new SsoToken
                {
                    Session = sessionName,
                    AccessToken = "cachedToken",
                    ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
                };

                var getTokenOptions = new SSOTokenManagerGetTokenOptions
                {
                    Session = sessionName
                };

                await ssoTokenFileCache.SaveSsoTokenAsync(cachedSsoToken, testCacheFolder);
                if (i == 0)
                {
                    var dkey = mockFileSystem.Files.First().Key;
                    var dvalue = mockFileSystem.Files.First().Value.Replace("accessToken", "noToken");
                    mockFileSystem.Files = new System.Collections.Generic.Dictionary<string, string> { { dkey, dvalue } };
                }
            }

            mockFileSystem.Files.Add($@"{testCacheFolder}\fifth.txt", mockFileSystem.Files.Last().Value);

            var result = await ssoTokenFileCache.ScanSsoTokensAsync(testCacheFolder);

            Assert.AreEqual(result.Count, expectedFileCount);
            foreach (var file in result)
            {
                ssoTokenFileCache.DeleteSsoToken(file.SsoTokenFilePath);
            }
            // assert that after files are deleted, only the invalid files remain
            Assert.AreEqual(mockFileSystem.Files.Count, invalidFileCount);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ValidateTokenCacheScanAndDelete()
        {
            int sampleCacheFileCount = 5;
            int expectedFileCount = 3; // first.json has AccessToken removed and fifth.txt is invalid file
            int invalidFileCount = sampleCacheFileCount - expectedFileCount;
            var testCacheFolder = "test";

            var mockFileSystem = new MockFileSystem();
            var ssoTokenFileCache =
                   new SSOTokenFileCache(
                       CryptoUtilFactory.CryptoInstance,
                       mockFileSystem,
                       mockFileSystem);
            // setup mock filesystem for all but one file
            for (int i = 0; i < sampleCacheFileCount - 1; i++)
            {
                var sessionName = Guid.NewGuid().ToString();
                var cachedSsoToken = new SsoToken
                {
                    Session = sessionName,
                    AccessToken = "cachedToken",
                    ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
                };

                var getTokenOptions = new SSOTokenManagerGetTokenOptions
                {
                    Session = sessionName
                };

                ssoTokenFileCache.SaveSsoToken(cachedSsoToken, testCacheFolder);
                if (i == 0)
                {
                    var dkey = mockFileSystem.Files.First().Key;
                    var dvalue = mockFileSystem.Files.First().Value.Replace("accessToken", "noToken");
                    mockFileSystem.Files = new System.Collections.Generic.Dictionary<string, string> { { dkey, dvalue } };
                }
            }

            mockFileSystem.Files.Add($@"{testCacheFolder}\fifth.txt", mockFileSystem.Files.Last().Value);

            var result = ssoTokenFileCache.ScanSsoTokens(testCacheFolder);

            Assert.AreEqual(result.Count, expectedFileCount);
            foreach (var file in result)
            {
                ssoTokenFileCache.DeleteSsoToken(file.SsoTokenFilePath);
            }
            // assert that after files are deleted, only the invalid files remain
            Assert.AreEqual(mockFileSystem.Files.Count, invalidFileCount);
        }
    }
}