using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [Trait(CategoryAttribute, "RequiresIAMUser")]
    public class GetFederationTokenTest : TestBase<AmazonSecurityTokenServiceClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public async Task TestGetFederationToken()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };
            var gftResult = await Client.GetFederationTokenAsync(gftRequest);

            Assert.NotNull(gftResult.Credentials.AccessKeyId);
            Assert.NotNull(gftResult.Credentials.SecretAccessKey);
            Assert.NotNull(gftResult.Credentials.SessionToken);
            Assert.NotEqual(DateTime.MinValue, gftResult.Credentials.Expiration);

            var time = DateTime.UtcNow;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gftResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);

            Assert.NotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.NotNull(gftResult.FederatedUser.Arn);

            Assert.EndsWith(gftRequest.Name, gftResult.FederatedUser.FederatedUserId, StringComparison.OrdinalIgnoreCase);
            Assert.EndsWith(gftRequest.Name, gftResult.FederatedUser.Arn, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public async Task TestGetFederationTokenAsync()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };

            GetFederationTokenResponse asyncResponse = null;

            asyncResponse = await Client.GetFederationTokenAsync(gftRequest);

            UtilityMethods.Sleep(TimeSpan.FromSeconds(5));
            Assert.NotNull(asyncResponse);

            var gftResult = asyncResponse;
            Assert.NotNull(gftResult);
            Assert.NotNull(gftResult.Credentials.AccessKeyId);
            Assert.NotNull(gftResult.Credentials.SecretAccessKey);
            Assert.NotNull(gftResult.Credentials.SessionToken);
            Assert.NotEqual(DateTime.MinValue, gftResult.Credentials.Expiration);

            var time = DateTime.UtcNow;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gftResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);

            Assert.NotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.NotNull(gftResult.FederatedUser.Arn);

            Assert.EndsWith(gftRequest.Name, gftResult.FederatedUser.FederatedUserId, StringComparison.OrdinalIgnoreCase);
            Assert.EndsWith(gftRequest.Name, gftResult.FederatedUser.Arn, StringComparison.OrdinalIgnoreCase);
        }
    }
}
