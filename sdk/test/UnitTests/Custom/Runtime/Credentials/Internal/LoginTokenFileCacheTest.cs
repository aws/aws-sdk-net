using Amazon.Runtime;
using Amazon;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LoginTokenFileCacheTest
    {
        private Mock<ICryptoUtil> _mockCrypto;
        private Mock<IFile> _mockFileRetriever;
        private Mock<IDirectory> _mockDirectoryRetriever;
        private LoginTokenFileCache _cache;

        [TestInitialize]
        public void Setup()
        {
            _mockCrypto = new Mock<ICryptoUtil>();
            _mockFileRetriever = new Mock<IFile>();
            _mockDirectoryRetriever = new Mock<IDirectory>();
            
            _mockCrypto.Setup(x => x.ComputeSHA256Hash(It.IsAny<byte[]>()))
                      .Returns(new byte[] { 0x12, 0x34, 0x56, 0x78, 0x9A, 0xBC, 0xDE, 0xF0 });
            
            _cache = new LoginTokenFileCache(_mockCrypto.Object, _mockFileRetriever.Object, _mockDirectoryRetriever.Object);
        }

        [TestMethod]
        public void TryGetLoginToken_ExistingToken_ReturnsToken()
        {
            var loginSession = "test-session";
            var tokenJson = @"{
                ""accessToken"": {
                    ""accessKeyId"": ""dummy-access-key"",
                    ""secretAccessKey"": ""dummy-secret-key"",
                    ""sessionToken"": ""dummy-session-token"",
                    ""accountId"": ""012345678901"",
                    ""expiresAt"": ""2025-09-14T04:05:45Z""
                },
                ""tokenType"": ""aws_sigv4"",
                ""refreshToken"": ""dummy-refresh-token"",
                ""idToken"": ""dummy-id-token"",
                ""clientId"": ""arn:aws:signin:::devtools/same-device"",
                ""dpopKey"": ""dummy-dpop-key""
            }";
            
            _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);
            _mockFileRetriever.Setup(x => x.ReadAllText(It.IsAny<string>())).Returns(tokenJson);

            var result = _cache.TryGetLoginToken(loginSession, null, out var token);

            Assert.IsTrue(result);
            Assert.IsNotNull(token);
        }

        [TestMethod]
        public void TryGetLoginToken_NonExistentToken_ReturnsFalse()
        {
            var loginSession = "test-session";
            
            _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(false);

            var result = _cache.TryGetLoginToken(loginSession, null, out var token);

            Assert.IsFalse(result);
            Assert.IsNull(token);
        }

        [TestMethod]
        public void SaveLoginToken_ValidToken_SavesSuccessfully()
        {
            var loginSession = "test-session";
            var token = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };

            _cache.SaveLoginToken(loginSession, token, null);

            _mockFileRetriever.Verify(x => x.WriteAllText(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void DeleteLoginToken_ExistingToken_DeletesSuccessfully()
        {
            var loginSession = "test-session";
            
            _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);

            _cache.DeleteLoginToken(loginSession, null);

            _mockFileRetriever.Verify(x => x.Delete(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void SaveLoginToken_WritesFileWhenRestrictFilePermissionsIsUnrestricted()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.UNRESTRICTED;

                var loginSession = "test-session";
                var token = new LoginToken
                {
                    AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
                };

                _cache.SaveLoginToken(loginSession, token, null);

                _mockFileRetriever.Verify(x => x.WriteAllText(It.IsAny<string>(), It.IsAny<string>()), Times.Once,
                    "File should still be written when RestrictFilePermissions is Unrestricted");
                _mockFileRetriever.Verify(x => x.SetFileOwnerReadWrite(It.IsAny<string>()), Times.Never,
                    "SetFileOwnerReadWrite should not be called when Unrestricted");
                _mockDirectoryRetriever.Verify(x => x.SetDirectoryOwnerOnly(It.IsAny<string>()), Times.Never,
                    "SetDirectoryOwnerOnly should not be called when Unrestricted");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        public async Task SaveLoginTokenAsync_WritesFileWhenRestrictFilePermissionsIsUnrestricted()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.UNRESTRICTED;

                var loginSession = "test-session";
                var token = new LoginToken
                {
                    AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
                };

                await _cache.SaveLoginTokenAsync(loginSession, token, null, CancellationToken.None);

                _mockFileRetriever.Verify(x => x.WriteAllTextAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once,
                    "File should still be written when RestrictFilePermissions is Unrestricted");
                _mockFileRetriever.Verify(x => x.SetFileOwnerReadWrite(It.IsAny<string>()), Times.Never,
                    "SetFileOwnerReadWrite should not be called when Unrestricted");
                _mockDirectoryRetriever.Verify(x => x.SetDirectoryOwnerOnly(It.IsAny<string>()), Times.Never,
                    "SetDirectoryOwnerOnly should not be called when Unrestricted");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        public void SaveLoginToken_SetsFilePermissionsWhenUserReadWrite()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;

                // File doesn't exist yet (new file)
                _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(false);
                // Directory doesn't exist yet (new directory)
                _mockDirectoryRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(false);

                var loginSession = "test-session";
                var token = new LoginToken
                {
                    AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
                };

                _cache.SaveLoginToken(loginSession, token, null);

                _mockFileRetriever.Verify(x => x.WriteAllText(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
                _mockFileRetriever.Verify(x => x.SetFileOwnerReadWrite(It.IsAny<string>()), Times.Once,
                    "SetFileOwnerReadWrite should be called for new files when UserReadWrite");
                _mockDirectoryRetriever.Verify(x => x.SetDirectoryOwnerOnly(It.IsAny<string>()), Times.Once,
                    "SetDirectoryOwnerOnly should be called for new directories when UserReadWrite");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        public async Task SaveLoginTokenAsync_SetsFilePermissionsWhenUserReadWrite()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;

                // File doesn't exist yet (new file)
                _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(false);
                // Directory doesn't exist yet (new directory)
                _mockDirectoryRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(false);

                var loginSession = "test-session";
                var token = new LoginToken
                {
                    AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
                };

                await _cache.SaveLoginTokenAsync(loginSession, token, null, CancellationToken.None);

                _mockFileRetriever.Verify(x => x.WriteAllTextAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
                _mockFileRetriever.Verify(x => x.SetFileOwnerReadWrite(It.IsAny<string>()), Times.Once,
                    "SetFileOwnerReadWrite should be called for new files when UserReadWrite");
                _mockDirectoryRetriever.Verify(x => x.SetDirectoryOwnerOnly(It.IsAny<string>()), Times.Once,
                    "SetDirectoryOwnerOnly should be called for new directories when UserReadWrite");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        public void SaveLoginToken_SkipsPermissionsForExistingFile()
        {
            var originalValue = AWSConfigs.RestrictFilePermissions;
            try
            {
                AWSConfigs.RestrictFilePermissions = FilePermission.USER_READ_WRITE;

                // File already exists (not new)
                _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);
                // Directory already exists (not new)
                _mockDirectoryRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);

                var loginSession = "test-session";
                var token = new LoginToken
                {
                    AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
                };

                _cache.SaveLoginToken(loginSession, token, null);

                _mockFileRetriever.Verify(x => x.WriteAllText(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
                _mockFileRetriever.Verify(x => x.SetFileOwnerReadWrite(It.IsAny<string>()), Times.Never,
                    "SetFileOwnerReadWrite should not be called for existing files");
                _mockDirectoryRetriever.Verify(x => x.SetDirectoryOwnerOnly(It.IsAny<string>()), Times.Never,
                    "SetDirectoryOwnerOnly should not be called for existing directories");
            }
            finally
            {
                AWSConfigs.RestrictFilePermissions = originalValue;
            }
        }

        [TestMethod]
        public async Task TryGetLoginTokenAsync_ExistingToken_ReturnsToken()
        {
            var loginSession = "test-session";
            var tokenJson = @"{
                ""accessToken"": {
                    ""accessKeyId"": ""dummy-access-key"",
                    ""secretAccessKey"": ""dummy-secret-key"",
                    ""sessionToken"": ""dummy-session-token"",
                    ""accountId"": ""012345678901"",
                    ""expiresAt"": ""2025-09-14T04:05:45Z""
                },
                ""tokenType"": ""aws_sigv4"",
                ""refreshToken"": ""dummy-refresh-token"",
                ""idToken"": ""dummy-id-token"",
                ""clientId"": ""arn:aws:signin:::devtools/same-device"",
                ""dpopKey"": ""dummy-dpop-key""
            }";
            
            _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(true);
            _mockFileRetriever.Setup(x => x.ReadAllTextAsync(It.IsAny<string>(), It.IsAny<CancellationToken>())).ReturnsAsync(tokenJson);

            var result = await _cache.TryGetLoginTokenAsync(loginSession, null, CancellationToken.None);

            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.Value);
        }
    }
}
