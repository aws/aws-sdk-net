using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.SharedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LoginTokenManagerConcurrencyTest
    {
        private Mock<ICoreAmazonSignin> _mockSigninClient;
        private Mock<ILoginTokenFileCache> _mockFileCache;
        private LoginTokenManager _tokenManager;

        [TestInitialize]
        public void Setup()
        {
            _mockSigninClient = new Mock<ICoreAmazonSignin>();
            _mockFileCache = new Mock<ILoginTokenFileCache>();
            _tokenManager = new LoginTokenManager(_mockSigninClient.Object, _mockFileCache.Object);
        }

        [TestMethod]
        public async Task GetTokenAsync_ConcurrentRequests_SameSession_UsesLock()
        {
            var loginToken = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.AddHours(1), "123456789012")
            };
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = loginToken });

            var task1 = _tokenManager.GetTokenAsync(options);
            var task2 = _tokenManager.GetTokenAsync(options);

            var results = await Task.WhenAll(task1, task2);

            Assert.AreEqual(loginToken, results[0]);
            Assert.AreEqual(loginToken, results[1]);
        }

        [TestMethod]
        public async Task GetTokenAsync_ConcurrentRequests_DifferentSessions_NoLockContention()
        {
            var loginToken1 = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key1", "secret1", "token1", DateTime.UtcNow.AddHours(1), "123456789012")
            };
            var loginToken2 = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key2", "secret2", "token2", DateTime.UtcNow.AddHours(1), "123456789012")
            };

            var options1 = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session-1" };
            var options2 = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session-2" };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync("test-session-1", It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = loginToken1 });
            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync("test-session-2", It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = loginToken2 });

            var task1 = _tokenManager.GetTokenAsync(options1);
            var task2 = _tokenManager.GetTokenAsync(options2);

            var results = await Task.WhenAll(task1, task2);

            Assert.AreEqual(loginToken1, results[0]);
            Assert.AreEqual(loginToken2, results[1]);
        }
    }
}