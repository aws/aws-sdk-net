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
        public async Task GetTokenAsync_NoToken_ThrowsNonRecoverable()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = false });

            // A missing cached Login token is non-recoverable (AmazonNonRecoverableCredentialsException derives from
            // AmazonClientException).
            await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => _tokenManager.GetTokenAsync(options));
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

        private static LoginToken CreateToken(TimeSpan expiresIn, string accessKey)
        {
            var token = CreateToken(expiresIn);
            token.AccessToken = new LoginImmutableCredentials(accessKey, "secret", "token", DateTime.UtcNow.Add(expiresIn), "123456789012");
            return token;
        }

        // A service rejected the credentials of a cached token that is outside its refresh window (for example a
        // revoked session): the token is refreshed through Sign-In instead of being returned again.
        [TestMethod]
        public async Task GetTokenAsync_RejectedAccessKey_TokenOutsideRefreshWindow_RefreshesThroughSignin()
        {
            SetupDiskToken(CreateToken(TimeSpan.FromHours(1), "rejected-key"));
            SetupRefreshWrites(CreateToken(TimeSpan.FromHours(1), "fresh-key"));
            var tokenManager = new LoginTokenManager(_ => _mockSigninClient.Object, _mockFileCache.Object);
            var options = NewOptions();
            options.RejectedAccessKeyId = "rejected-key";

            var result = await tokenManager.GetTokenAsync(options);

            Assert.AreEqual("fresh-key", result.AccessToken.AccessKey);
            _mockSigninClient.Verify(x => x.CreateOAuth2TokenAsync(It.IsAny<CoreCreateOAuth2TokenRequest>(), false, It.IsAny<CancellationToken>()), Times.Once);
        }

        // The in-memory cached token is the rejected one: it is refreshed too, not returned from the cache.
        [TestMethod]
        public async Task GetTokenAsync_RejectedAccessKey_InMemoryCachedToken_RefreshesThroughSignin()
        {
            var originalUseSdkCache = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = true; // in-memory branch is gated on this
            try
            {
                SetupDiskToken(CreateToken(TimeSpan.FromHours(1), "rejected-key"));
                SetupRefreshWrites(CreateToken(TimeSpan.FromHours(1), "fresh-key"));
                var tokenManager = new LoginTokenManager(_ => _mockSigninClient.Object, _mockFileCache.Object);
                var options = NewOptions();
                Assert.AreEqual("rejected-key", (await tokenManager.GetTokenAsync(options)).AccessToken.AccessKey, "cached in memory");

                options.RejectedAccessKeyId = "rejected-key";
                Assert.AreEqual("fresh-key", (await tokenManager.GetTokenAsync(options)).AccessToken.AccessKey);
                _mockSigninClient.Verify(x => x.CreateOAuth2TokenAsync(It.IsAny<CoreCreateOAuth2TokenRequest>(), false, It.IsAny<CancellationToken>()), Times.Once);
            }
            finally
            {
                AWSConfigs.UseSdkCache = originalUseSdkCache;
            }
        }

        // A rejection of other credentials (a token another process already replaced) does not force a refresh.
        [TestMethod]
        public async Task GetTokenAsync_RejectedAccessKeyOfAnotherToken_ReturnsCachedTokenWithoutRefresh()
        {
            var current = CreateToken(TimeSpan.FromHours(1), "current-key");
            SetupDiskToken(current);
            var tokenManager = new LoginTokenManager(_ => _mockSigninClient.Object, _mockFileCache.Object);
            var options = NewOptions();
            options.RejectedAccessKeyId = "older-key";

            Assert.AreSame(current, await tokenManager.GetTokenAsync(options));
            _mockSigninClient.Verify(x => x.CreateOAuth2TokenAsync(It.IsAny<CoreCreateOAuth2TokenRequest>(), It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Never);
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

        // A cached token that is present but has no AccessToken is non-recoverable. It is detected client-side at the
        // file-cache read site, before NeedsRefresh would dereference AccessToken.ExpiresAt.
        [TestMethod]
        public async Task GetTokenAsync_MalformedCachedToken_NullAccessToken_ThrowsNonRecoverable()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };
            var malformed = new LoginToken { AccessToken = null };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = malformed });

            await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => _tokenManager.GetTokenAsync(options));
        }

        // A cached token missing a required field (here: no expiry) is non-recoverable. ExpiresAt == null keeps
        // NeedsRefresh() false, so control reaches the read-site guard.
        [TestMethod]
        public async Task GetTokenAsync_MalformedCachedToken_MissingExpiry_ThrowsNonRecoverable()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };
            var malformed = new LoginToken
            {
                AccessToken = new LoginImmutableCredentials("key", "secret", "token", null, "123456789012")
            };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = malformed });

            await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(() => _tokenManager.GetTokenAsync(options));
        }

        // The logout path does not validate the token, so a malformed token can still be deleted.
        [TestMethod]
        public async Task LogoutAsync_MalformedToken_StillDeletes()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };
            var malformed = new LoginToken { AccessToken = null };

            _mockFileCache.Setup(x => x.TryGetLoginTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                         .ReturnsAsync(new TryResponse<LoginToken> { Success = true, Value = malformed });

            await _tokenManager.LogoutAsync(options);

            _mockFileCache.Verify(x => x.DeleteLoginToken(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        // A malformed token already held in the in-memory cache (null AccessToken) is non-recoverable. The in-memory read
        // site validates the token before NeedsRefresh() dereferences AccessToken.ExpiresAt, so the caller gets
        // AmazonNonRecoverableCredentialsException rather than a NullReferenceException. This drives the real
        // in-memory manager path (seeded cache), not EnsureUsable in isolation.
        [TestMethod]
        public async Task GetTokenAsync_MalformedInMemoryCachedToken_NullAccessToken_ThrowsNonRecoverable()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };
            var malformed = new LoginToken { AccessToken = null };

            var originalUseSdkCache = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = true; // in-memory branch is gated on this
            try
            {
                _tokenManager.SeedInMemoryCacheForTest(options.LoginSession, malformed);

                await Assert.ThrowsExactlyAsync<AmazonNonRecoverableCredentialsException>(
                    () => _tokenManager.GetTokenAsync(options));
            }
            finally
            {
                AWSConfigs.UseSdkCache = originalUseSdkCache;
            }
        }

#if NETFRAMEWORK
        // Sync counterpart of the in-memory malformed-token test above. The synchronous GetToken is compiled only into
        // the .NET Framework build of AWSSDK.Core, which the net472 test targets reference, so this test runs there.
        [TestMethod]
        public void GetToken_MalformedInMemoryCachedToken_NullAccessToken_ThrowsNonRecoverable()
        {
            var options = new LoginTokenManagerGetTokenOptions { LoginSession = "test-session" };
            var malformed = new LoginToken { AccessToken = null };

            var originalUseSdkCache = AWSConfigs.UseSdkCache;
            AWSConfigs.UseSdkCache = true; // in-memory branch is gated on this
            try
            {
                _tokenManager.SeedInMemoryCacheForTest(options.LoginSession, malformed);

                Assert.ThrowsExactly<AmazonNonRecoverableCredentialsException>(
                    () => _tokenManager.GetToken(options));
            }
            finally
            {
                AWSConfigs.UseSdkCache = originalUseSdkCache;
            }
        }
#endif
    }
}