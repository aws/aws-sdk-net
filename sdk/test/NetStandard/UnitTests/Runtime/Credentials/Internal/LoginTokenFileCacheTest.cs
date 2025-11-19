using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Amazon.Util.Internal;
using Xunit;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    public class LoginTokenFileCacheTest
    {
        private Mock<ICryptoUtil> _mockCrypto;
        private Mock<IFile> _mockFileRetriever;
        private Mock<IDirectory> _mockDirectoryRetriever;
        private LoginTokenFileCache _cache;

        public LoginTokenFileCacheTest()
        {
            _mockCrypto = new Mock<ICryptoUtil>();
            _mockFileRetriever = new Mock<IFile>();
            _mockDirectoryRetriever = new Mock<IDirectory>();
            
            _mockCrypto.Setup(x => x.ComputeSHA256Hash(It.IsAny<byte[]>()))
                      .Returns(new byte[] { 0x12, 0x34, 0x56, 0x78, 0x9A, 0xBC, 0xDE, 0xF0 });
            
            _cache = new LoginTokenFileCache(_mockCrypto.Object, _mockFileRetriever.Object, _mockDirectoryRetriever.Object);
        }

        [Fact]
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

            Assert.True(result);
            Assert.NotNull(token);
        }

        [Fact]
        public void TryGetLoginToken_NonExistentToken_ReturnsFalse()
        {
            var loginSession = "test-session";
            
            _mockFileRetriever.Setup(x => x.Exists(It.IsAny<string>())).Returns(false);

            var result = _cache.TryGetLoginToken(loginSession, null, out var token);

            Assert.False(result);
            Assert.Null(token);
        }

        [Fact]
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

        [Fact]
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

            Assert.True(result.Success);
            Assert.NotNull(result.Value);
        }
    }
}