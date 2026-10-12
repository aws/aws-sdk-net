using Amazon;
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
    public class SSOTokenManagerRefreshTests
    {
        [TestMethod]
        public async Task GetTokenAsync_RefreshFails_RetriesOncePerCooldownBeforeAndAfterExpiry()
        {
            var token = new SsoToken
            {
                AccessToken = "access-token",
                ExpiresAt = DateTime.UtcNow.AddMinutes(2),
                RefreshToken = "refresh-token",
                ClientId = "client-id",
                ClientSecret = "client-secret",
                RegistrationExpiresAt = DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                StartUrl = "https://example.awsapps.com/start",
                Session = Guid.NewGuid().ToString()
            };
            var fileCache = new Mock<ISSOTokenFileCache>();
            fileCache.Setup(x => x.TryGetSsoTokenAsync(It.IsAny<SSOTokenManagerGetTokenOptions>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                     .ReturnsAsync(new TryResponse<SsoToken> { Success = true, Value = token });
            var attempts = 0;
            var oidcClient = new Mock<ICoreAmazonSSOOIDC>();
            oidcClient.Setup(x => x.RefreshTokenAsync(It.IsAny<GetSsoTokenResponse>()))
                      .Returns(() => ++attempts < 5
                          ? throw new AmazonClientException("Refresh failed")
                          : Task.FromResult(new GetSsoTokenResponse { AccessToken = "refreshed-token", ExpiresAt = DateTime.UtcNow.AddHours(1) }));
            var tokenManager = new SSOTokenManager(oidcClient.Object, fileCache.Object);
            var options = new SSOTokenManagerGetTokenOptions
            {
                StartUrl = token.StartUrl,
                Session = token.Session,
                Region = "us-east-1",
                SupportsGettingNewToken = false
            };
            var savedClockCorrection = AWSConfigs.ManualClockCorrection;
            try
            {
                Task<SsoToken> GetTokenAt(int secondsLater)
                {
                    AWSConfigs.ManualClockCorrection = TimeSpan.FromSeconds(secondsLater);
                    return tokenManager.GetTokenAsync(options);
                }

                foreach (var (secondsLater, expectedAttempts) in new[] { (0, 1), (0, 1), (31, 2), (62, 3) })
                {
                    Assert.AreEqual(token, await GetTokenAt(secondsLater));
                    Assert.AreEqual(expectedAttempts, attempts);
                }

                foreach (var secondsLater in new[] { 150, 150 })
                {
                    await Assert.ThrowsExactlyAsync<AmazonClientException>(() => GetTokenAt(secondsLater));
                    Assert.AreEqual(4, attempts);
                }

                Assert.AreEqual("refreshed-token", (await GetTokenAt(181)).AccessToken);
                Assert.AreEqual(5, attempts);
            }
            finally
            {
                AWSConfigs.ManualClockCorrection = savedClockCorrection;
            }
        }
    }
}
