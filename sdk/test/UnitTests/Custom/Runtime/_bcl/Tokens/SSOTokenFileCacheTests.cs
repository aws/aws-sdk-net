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
using Amazon;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Amazon.Util.Internal;
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
        public void SaveSsoToken_WritesFileWhenRestrictFilePermissionsIsUnrestricted()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.UNRESTRICTED;

                var testCacheFolder = "test";
                var mockFileSystem = new MockFileSystem();

                var cachedSsoToken = new SsoToken
                {
                    Session = "opt-out-test",
                    AccessToken = "cachedToken",
                    ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
                };

                var ssoTokenFileCache =
                    new SSOTokenFileCache(
                        CryptoUtilFactory.CryptoInstance,
                        mockFileSystem,
                        mockFileSystem);

                ssoTokenFileCache.SaveSsoToken(cachedSsoToken, testCacheFolder);

                // Verify the file was still written
                Assert.AreEqual(1, mockFileSystem.Files.Count, "Token file should still be written");
                // Verify permissions were NOT set (Unrestricted mode)
                Assert.AreEqual(0, mockFileSystem.FileOwnerReadWritePaths.Count, "SetFileOwnerReadWrite should not be called when Unrestricted");
                Assert.AreEqual(0, mockFileSystem.DirectoryOwnerOnlyPaths.Count, "SetDirectoryOwnerOnly should not be called when Unrestricted");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SaveSsoTokenAsync_WritesFileWhenRestrictFilePermissionsIsUnrestricted()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.UNRESTRICTED;

                var testCacheFolder = "test";
                var mockFileSystem = new MockFileSystem();

                var cachedSsoToken = new SsoToken
                {
                    Session = "opt-out-test-async",
                    AccessToken = "cachedToken",
                    ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
                };

                var ssoTokenFileCache =
                    new SSOTokenFileCache(
                        CryptoUtilFactory.CryptoInstance,
                        mockFileSystem,
                        mockFileSystem);

                await ssoTokenFileCache.SaveSsoTokenAsync(cachedSsoToken, testCacheFolder);

                // Verify the file was still written
                Assert.AreEqual(1, mockFileSystem.Files.Count, "Token file should still be written");
                // Verify permissions were NOT set (Unrestricted mode)
                Assert.AreEqual(0, mockFileSystem.FileOwnerReadWritePaths.Count, "SetFileOwnerReadWrite should not be called when Unrestricted");
                Assert.AreEqual(0, mockFileSystem.DirectoryOwnerOnlyPaths.Count, "SetDirectoryOwnerOnly should not be called when Unrestricted");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SaveSsoToken_SetsPermissionsWhenUserReadWrite()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;

                var testCacheFolder = "test";
                var mockFileSystem = new MockFileSystem();

                var cachedSsoToken = new SsoToken
                {
                    Session = "perm-test",
                    AccessToken = "cachedToken",
                    ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
                };

                var ssoTokenFileCache =
                    new SSOTokenFileCache(
                        CryptoUtilFactory.CryptoInstance,
                        mockFileSystem,
                        mockFileSystem);

                ssoTokenFileCache.SaveSsoToken(cachedSsoToken, testCacheFolder);

                // Verify permissions were set (new file and new directory)
                Assert.AreEqual(1, mockFileSystem.FileOwnerReadWritePaths.Count, "SetFileOwnerReadWrite should be called once for new file");
                Assert.AreEqual(1, mockFileSystem.DirectoryOwnerOnlyPaths.Count, "SetDirectoryOwnerOnly should be called once for new directory");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SaveSsoTokenAsync_SetsPermissionsWhenUserReadWrite()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;

                var testCacheFolder = "test";
                var mockFileSystem = new MockFileSystem();

                var cachedSsoToken = new SsoToken
                {
                    Session = "perm-test-async",
                    AccessToken = "cachedToken",
                    ExpiresAt = DateTime.Parse("3000-12-25T21:30:00Z").ToUniversalTime()
                };

                var ssoTokenFileCache =
                    new SSOTokenFileCache(
                        CryptoUtilFactory.CryptoInstance,
                        mockFileSystem,
                        mockFileSystem);

                await ssoTokenFileCache.SaveSsoTokenAsync(cachedSsoToken, testCacheFolder);

                // Verify permissions were set (new file and new directory)
                Assert.AreEqual(1, mockFileSystem.FileOwnerReadWritePaths.Count, "SetFileOwnerReadWrite should be called once for new file");
                Assert.AreEqual(1, mockFileSystem.DirectoryOwnerOnlyPaths.Count, "SetDirectoryOwnerOnly should be called once for new directory");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SetFilePermissionsOrCleanup_SkipsWhenUnrestricted()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.UNRESTRICTED;
                var mockFileSystem = new MockFileSystem();
                mockFileSystem.Files["test.json"] = "{}";

                FilePermissionHelper.SetFilePermissionsOrCleanup(mockFileSystem, "test.json", isNewFile: true, logger: null);

                Assert.AreEqual(0, mockFileSystem.FileOwnerReadWritePaths.Count, "SetFileOwnerReadWrite should not be called when Unrestricted");
                Assert.AreEqual(1, mockFileSystem.Files.Count, "File should not be deleted when Unrestricted");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SetDirectoryPermissionsOrCleanup_SkipsWhenUnrestricted()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.UNRESTRICTED;
                var mockFileSystem = new MockFileSystem();
                mockFileSystem.Directories.Add("testdir");

                FilePermissionHelper.SetDirectoryPermissionsOrCleanup(mockFileSystem, "testdir", isNewDirectory: true, logger: null);

                Assert.AreEqual(0, mockFileSystem.DirectoryOwnerOnlyPaths.Count, "SetDirectoryOwnerOnly should not be called when Unrestricted");
                Assert.IsTrue(mockFileSystem.Directories.Contains("testdir"), "Directory should not be deleted when Unrestricted");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SetFilePermissionsOrCleanup_SkipsWhenNotNewFile()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;
                var mockFileSystem = new MockFileSystem();
                mockFileSystem.Files["test.json"] = "{}";

                FilePermissionHelper.SetFilePermissionsOrCleanup(mockFileSystem, "test.json", isNewFile: false, logger: null);

                Assert.AreEqual(0, mockFileSystem.FileOwnerReadWritePaths.Count, "SetFileOwnerReadWrite should not be called when not new");
                Assert.AreEqual(1, mockFileSystem.Files.Count, "File should not be deleted when not new");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SetDirectoryPermissionsOrCleanup_SkipsWhenNotNewDirectory()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;
                var mockFileSystem = new MockFileSystem();
                mockFileSystem.Directories.Add("testdir");

                FilePermissionHelper.SetDirectoryPermissionsOrCleanup(mockFileSystem, "testdir", isNewDirectory: false, logger: null);

                Assert.AreEqual(0, mockFileSystem.DirectoryOwnerOnlyPaths.Count, "SetDirectoryOwnerOnly should not be called when not new");
                Assert.IsTrue(mockFileSystem.Directories.Contains("testdir"), "Directory should not be deleted when not new");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SetFilePermissionsOrCleanup_CallsSetFileOwnerReadWriteWhenNewFileAndUserReadWrite()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;
                var mockFileSystem = new MockFileSystem();
                mockFileSystem.Files["test.json"] = "{}";

                FilePermissionHelper.SetFilePermissionsOrCleanup(mockFileSystem, "test.json", isNewFile: true, logger: null);

                Assert.AreEqual(1, mockFileSystem.FileOwnerReadWritePaths.Count, "SetFileOwnerReadWrite should be called once");
                Assert.AreEqual("test.json", mockFileSystem.FileOwnerReadWritePaths[0]);
                Assert.AreEqual(1, mockFileSystem.Files.Count, "File should still exist after successful permission set");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SetDirectoryPermissionsOrCleanup_CallsSetDirectoryOwnerOnlyWhenNewDirectoryAndUserReadWrite()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;
                var mockFileSystem = new MockFileSystem();
                mockFileSystem.Directories.Add("testdir");

                FilePermissionHelper.SetDirectoryPermissionsOrCleanup(mockFileSystem, "testdir", isNewDirectory: true, logger: null);

                Assert.AreEqual(1, mockFileSystem.DirectoryOwnerOnlyPaths.Count, "SetDirectoryOwnerOnly should be called once");
                Assert.AreEqual("testdir", mockFileSystem.DirectoryOwnerOnlyPaths[0]);
                Assert.IsTrue(mockFileSystem.Directories.Contains("testdir"), "Directory should still exist after successful permission set");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
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
