using System;
using System.Threading;
using Amazon;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    
    public class GetSessionToken : TestBase<AmazonSecurityTokenServiceClient>
    {   
        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public void TestGetSessionToken()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            var gstResult = Client.GetSessionTokenAsync(gstRequest).Result;

            Assert.NotNull(gstResult.Credentials.AccessKeyId);
            Assert.NotNull(gstResult.Credentials.SecretAccessKey);
            Assert.NotNull(gstResult.Credentials.SessionToken);
            Assert.NotNull(gstResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gstResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);
        }

        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public void TestGetSessionTokenRegional()
        {
            using (var uswest2Client = TestBase.CreateClient<AmazonSecurityTokenServiceClient>(endpoint: RegionEndpoint.USWest2))
            {
                var gstRequest = new GetSessionTokenRequest()
                {
                    DurationSeconds = 3600
                };

                var gstResult = uswest2Client.GetSessionTokenAsync(gstRequest).Result;

                Assert.NotNull(gstResult.Credentials.AccessKeyId);
                Assert.NotNull(gstResult.Credentials.SecretAccessKey);
                Assert.NotNull(gstResult.Credentials.SessionToken);
                Assert.NotNull(gstResult.Credentials.Expiration);

                var time = DateTime.Now;
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
        public void TestGetSessionTokenAsync()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            GetSessionTokenResponse asyncResponse = null;

            var task = Client.GetSessionTokenAsync(gstRequest);
            asyncResponse = task.Result;

            UtilityMethods.Sleep(TimeSpan.FromSeconds(5));
            Assert.NotNull(asyncResponse);

            var gstResult = asyncResponse;
            Assert.NotNull(gstResult);
            Assert.NotNull(gstResult.Credentials.AccessKeyId);
            Assert.NotNull(gstResult.Credentials.SecretAccessKey);
            Assert.NotNull(gstResult.Credentials.SessionToken);
            Assert.NotNull(gstResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gstResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);
        }
    }
}