using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.SharedInterfaces;
using Xunit;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    public class LoginTokenManagerTest
    {
        private Mock<ICoreAmazonSignin> _mockSigninClient;
        private Mock<ILoginTokenFileCache> _mockFileCache;
        private LoginTokenManager _tokenManager;

        public LoginTokenManagerTest()
        {
            _mockSigninClient = new Mock<ICoreAmazonSignin>();
            _mockFileCache = new Mock<ILoginTokenFileCache>();
            _tokenManager = new LoginTokenManager(_mockSigninClient.Object, _mockFileCache.Object);
        }

        [Fact]
        public async Task GetTokenAsync_ValidCachedToken_ReturnsToken()
        {
            var loginToken = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = loginToken });

            var result = await _tokenManager.GetTokenAsync(options);

            Assert.Equal(loginToken, result);
        }

        [Fact]
        public async Task GetTokenAsync_NoToken_ThrowsAmazonClientException()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = false });

            await Assert.ThrowsAsync<AmazonClientException>(() => _tokenManager.GetTokenAsync(options));
        }
    }
}