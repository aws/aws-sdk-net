using System;
using System.Threading;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    
    public class GetFederationTokenTest : TestBase<AmazonSecurityTokenServiceClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public void TestGetFederationToken()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };
            var gftResult = Client.GetFederationTokenAsync(gftRequest).Result;

            Assert.NotNull(gftResult.Credentials.AccessKeyId);
            Assert.NotNull(gftResult.Credentials.SecretAccessKey);
            Assert.NotNull(gftResult.Credentials.SessionToken);
            Assert.NotNull(gftResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gftResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);

            Assert.NotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.NotNull(gftResult.FederatedUser.Arn);

            Assert.True(gftResult.FederatedUser.FederatedUserId.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
            Assert.True(gftResult.FederatedUser.Arn.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        [Trait(CategoryAttribute,"SecurityTokenService")]
        public void TestGetFederationTokenAsync()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };

            GetFederationTokenResponse asyncResponse = null;

            var task = Client.GetFederationTokenAsync(gftRequest);
            asyncResponse = task.Result;

            UtilityMethods.Sleep(TimeSpan.FromSeconds(5));
            Assert.NotNull(asyncResponse);

            var gftResult = asyncResponse;
            Assert.NotNull(gftResult);
            Assert.NotNull(gftResult.Credentials.AccessKeyId);
            Assert.NotNull(gftResult.Credentials.SecretAccessKey);
            Assert.NotNull(gftResult.Credentials.SessionToken);
            Assert.NotNull(gftResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gftResult.Credentials.Expiration;

            Assert.True(expires > expiresAfter);
            Assert.True(expires < expiresBefore);

            Assert.NotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.NotNull(gftResult.FederatedUser.Arn);

            Assert.True(gftResult.FederatedUser.FederatedUserId.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
            Assert.True(gftResult.FederatedUser.Arn.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
