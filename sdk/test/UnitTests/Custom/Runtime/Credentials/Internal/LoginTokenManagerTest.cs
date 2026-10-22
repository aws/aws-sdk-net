using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.SharedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LoginTokenManagerTest
    {
        private Mock<ICoreAmazonSignin> _mockSigninClient;
        private Mock<ILoginTokenFileCache> _mockFileCache;
        private LoginTokenManager _tokenManager;
        private LoginToken _diskToken;

        [TestInitialize]
        public void Setup()
        {
            _mockSigninClient = new Mock<ICoreAmazonSignin>();
            _mockFileCache = new Mock<ILoginTokenFileCache>();
            _tokenManager = new LoginTokenManager(_mockSigninClient.Object, _mockFileCache.Object);
        }

        [TestMethod]
        public async Task GetTokenAsync_ValidCachedToken_ReturnsTokenWithoutCreatingSigninClient()
        {
            var cachedToken = CreateToken(TimeSpan.FromHours(1));
            SetupDiskToken(cachedToken);
            var factoryCalls = 0;
            var tokenManager = new LoginTokenManager(_ => { factoryCalls++; return _mockSigninClient.Object; }, _mockFileCache.Object);

            var result = await tokenManager.GetTokenAsync(NewOptions());

            Assert.AreEqual(cachedToken, result);
            Assert.AreEqual(0, factoryCalls);
        }

        [TestMethod]
        public async Task GetTokenAsync_NoToken_ThrowsAmazonClientException()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = false });

            await Assert.ThrowsExactlyAsync<AmazonClientException>(() => _tokenManager.GetTokenAsync(options));
        }

        [TestMethod]
        public async Task LogoutAsync_ExistingToken_DeletesToken()
        {
            var loginToken = new LoginToken();
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = loginToken });

            await _tokenManager.LogoutAsync(options);

            _mockFileCache.Verify(x => x.DeleteLoginToken(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public async Task GetTokenAsync_ExpiringToken_RechecksCacheAndRefreshes()
        {
            var refreshedToken = CreateToken(TimeSpan.FromHours(1));
            SetupDiskToken(CreateToken(TimeSpan.FromMinutes(1)));
            SetupRefreshWrites(refreshedToken);
            var tokenManager = new LoginTokenManager(_ => _mockSigninClient.Object, _mockFileCache.Object);

            var result = await tokenManager.GetTokenAsync(NewOptions());

            Assert.AreEqual(refreshedToken, result);
            _mockFileCache.Verify(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(3));
            _mockSigninClient.Verify(x => x.CreateOAuth2TokenAsync(
                It.Is<CoreCreateOAuth2TokenRequest>(r => r.TokenInput.ClientId == "client-id"
                    && r.TokenInput.GrantType == "refresh_token"
                    && r.TokenInput.RefreshToken == "refresh-token"),
                false, It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task GetTokenAsync_RefreshFailsBeforeExpiry_KeepsTokenAndRetriesAfterCooldown()
        {
            var expiringToken = CreateToken(TimeSpan.FromMinutes(2));
            var refreshedToken = CreateToken(TimeSpan.FromHours(1));
            SetupDiskToken(expiringToken);
            SetupRefreshWrites(refreshedToken);
            var factoryCalls = 0;
            var tokenManager = new LoginTokenManager(
                _ => ++factoryCalls == 1 ? throw new AmazonClientException("No region") : _mockSigninClient.Object,
                _mockFileCache.Object);
            var options = NewOptions();
            var savedClockCorrection = AWSConfigs.ManualClockCorrection;
            try
            {
                Assert.AreEqual(expiringToken, await tokenManager.GetTokenAsync(options));
                Assert.AreEqual(expiringToken, await tokenManager.GetTokenAsync(options));
                Assert.AreEqual(1, factoryCalls);

                AWSConfigs.ManualClockCorrection = TimeSpan.FromSeconds(31);
                Assert.AreEqual(refreshedToken, await tokenManager.GetTokenAsync(options));
                Assert.AreEqual(2, factoryCalls);
            }
            finally
            {
                AWSConfigs.ManualClockCorrection = savedClockCorrection;
            }
        }

        [TestMethod]
        public async Task GetTokenAsync_RefreshFailsAfterExpiry_ThrowsWithCause()
        {
            SetupDiskToken(CreateToken(TimeSpan.FromMinutes(-1)));
            var refreshError = new AmazonClientException("No region");
            var tokenManager = new LoginTokenManager(_ => throw refreshError, _mockFileCache.Object);

            var exception = await Assert.ThrowsExactlyAsync<AmazonClientException>(() => tokenManager.GetTokenAsync(NewOptions()));

            Assert.AreSame(refreshError, exception.InnerException);
            StringAssert.Contains(exception.Message, refreshError.Message);
        }

        [TestMethod]
        public async Task GetTokenAsync_TokenWithSignInRegion_RefreshesInSignInRegion()
        {
            var expiringToken = CreateToken(TimeSpan.FromMinutes(1));
            expiringToken.SignInRegion = "us-east-1";
            SetupDiskToken(expiringToken);
            SetupRefreshWrites(CreateToken(TimeSpan.FromHours(1)));
            var clientRegions = new List<string>();
            var tokenManager = new LoginTokenManager(region => { clientRegions.Add(region); return _mockSigninClient.Object; }, _mockFileCache.Object);
            var options = NewOptions();
            options.Region = "us-west-2";

            await tokenManager.GetTokenAsync(options);

            CollectionAssert.AreEqual(new[] { "us-east-1" }, clientRegions);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public async Task GetTokenAsync_TokenWithoutSignInRegion_RefreshesInFallbackRegion(string signInRegion)
        {
            var expiringToken = CreateToken(TimeSpan.FromMinutes(1));
            expiringToken.SignInRegion = signInRegion;
            SetupDiskToken(expiringToken);
            SetupRefreshWrites(CreateToken(TimeSpan.FromHours(1)));
            var clientRegions = new List<string>();
            var tokenManager = new LoginTokenManager(region => { clientRegions.Add(region); return _mockSigninClient.Object; }, _mockFileCache.Object);
            var options = NewOptions();
            options.Region = "us-west-2";

            await tokenManager.GetTokenAsync(options);

            CollectionAssert.AreEqual(new[] { "us-west-2" }, clientRegions);
        }

        [TestMethod]
        public async Task GetTokenAsync_RefreshesInDifferentRegions_CreatesOneClientPerRegion()
        {
            var clientRegions = new List<string>();
            var tokenManager = new LoginTokenManager(region => { clientRegions.Add(region); return _mockSigninClient.Object; }, _mockFileCache.Object);

            foreach (var signInRegion in new[] { "us-east-1", "eu-west-1", "us-east-1" })
            {
                var expiringToken = CreateToken(TimeSpan.FromMinutes(1));
                expiringToken.SignInRegion = signInRegion;
                SetupDiskToken(expiringToken);
                SetupRefreshWrites(CreateToken(TimeSpan.FromHours(1)));

                await tokenManager.GetTokenAsync(NewOptions());
            }

            CollectionAssert.AreEqual(new[] { "us-east-1", "eu-west-1" }, clientRegions);
            _mockSigninClient.Verify(x => x.CreateOAuth2TokenAsync(It.IsAny<CoreCreateOAuth2TokenRequest>(), false, It.IsAny<CancellationToken>()), Times.Exactly(3));
        }

#if NETFRAMEWORK
        [TestMethod]
        public void GetToken_TokenWithSignInRegion_RefreshesInSignInRegion()
        {
            var expiringToken = CreateToken(TimeSpan.FromMinutes(1));
            expiringToken.SignInRegion = "us-east-1";
            _mockFileCache.Setup(x => x.TryGetLoginToken(It.IsAny<string>(), It.IsAny<string>(), out expiringToken)).Returns(true);
            var clientRegions = new List<string>();
            var tokenManager = new LoginTokenManager(region => { clientRegions.Add(region); return _mockSigninClient.Object; }, _mockFileCache.Object);
            var options = NewOptions();
            options.Region = "us-west-2";

            tokenManager.GetToken(options);

            CollectionAssert.AreEqual(new[] { "us-east-1" }, clientRegions);
            _mockSigninClient.Verify(x => x.CreateOAuth2Token(It.IsAny<CoreCreateOAuth2TokenRequest>(), false), Times.Once);
        }
#endif

        private static LoginTokenManagerGetTokenOptions NewOptions()
        {
            return new LoginTokenManagerGetTokenOptions { LoginSession = Guid.NewGuid().ToString() };
        }

        private static LoginToken CreateToken(TimeSpan expiresIn)
        {
            return new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", DateTime.UtcNow.Add(expiresIn), "123456789012"),
                RefreshToken = "refresh-token",
                ClientId = "client-id",
                DPoPKey = "dpop-key"
            };
        }

        private void SetupDiskToken(LoginToken token)
        {
            _diskToken = token;
            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                          .ReturnsAsync(() => new TryResponse<LoginToken> { Success = true, Value = _diskToken });
        }

        // A successful refresh is saved to the file cache by the Signin client pipeline.
        private void SetupRefreshWrites(LoginToken refreshedToken)
        {
            _mockSigninClient.Setup(x => x.CreateOAuth2TokenAsync(It.IsAny<CoreCreateOAuth2TokenRequest>(), false, It.IsAny<CancellationToken>()))
                             .Callback(() => _diskToken = refreshedToken)
                             .ReturnsAsync(new CoreCreateOAuth2TokenResponse());
        }
    }
}