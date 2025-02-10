using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [Trait(CategoryAttribute, "RequiresIAMUser")]
    public class GetSessionToken : TestBase<AmazonSecurityTokenServiceClient>
    {   
        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public async Task TestGetSessionToken()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            var gstResult = await Client.GetSessionTokenAsync(gstRequest);

            Assert.NotNull(gstResult.Credentials.AccessKeyId);
            Assert.NotNull(gstResult.Credentials.SecretAccessKey);
            Assert.NotNull(gstResult.Credentials.SessionToken);
            Assert.NotEqual(DateTime.MinValue, gstResult.Credentials.Expiration);

            var time = DateTime.UtcNow;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gstResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);
        }

        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public async Task TestGetSessionTokenRegional()
        {
            using (var uswest2Client = TestBase.CreateClient<AmazonSecurityTokenServiceClient>(endpoint: RegionEndpoint.USWest2))
            {
                var gstRequest = new GetSessionTokenRequest()
                {
                    DurationSeconds = 3600
                };

                var gstResult = await uswest2Client.GetSessionTokenAsync(gstRequest);

                Assert.NotNull(gstResult.Credentials.AccessKeyId);
                Assert.NotNull(gstResult.Credentials.SecretAccessKey);
                Assert.NotNull(gstResult.Credentials.SessionToken);
                Assert.NotEqual(DateTime.MinValue, gstResult.Credentials.Expiration);

                var time = DateTime.UtcNow;
                var approximateExpires = time.AddHours(1);
                var expiresAfter = approximateExpires.AddMinutes(-5);
                var expiresBefore = approximateExpires.AddMinutes(5);
                var expires = gstResult.Credentials.Expiration;

                Assert.True(expires > expiresAfter);
                Assert.True(expires < expiresBefore);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public async Task TestGetSessionTokenAsync()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            GetSessionTokenResponse asyncResponse = null;

            asyncResponse = await Client.GetSessionTokenAsync(gstRequest);

            UtilityMethods.Sleep(TimeSpan.FromSeconds(5));
            Assert.NotNull(asyncResponse);

            var gstResult = asyncResponse;
            Assert.NotNull(gstResult);
            Assert.NotNull(gstResult.Credentials.AccessKeyId);
            Assert.NotNull(gstResult.Credentials.SecretAccessKey);
            Assert.NotNull(gstResult.Credentials.SessionToken);
            Assert.NotEqual(DateTime.MinValue, gstResult.Credentials.Expiration);

            var time = DateTime.UtcNow;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gstResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);
        }
    }
}