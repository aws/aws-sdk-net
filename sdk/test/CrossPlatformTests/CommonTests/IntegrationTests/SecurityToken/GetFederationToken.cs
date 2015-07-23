using System;
using System.Threading;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestFixture]
    public class GetFederationTokenTest : TestBase<AmazonSecurityTokenServiceClient>
    {

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("SecurityTokenService")]
        public void TestGetFederationToken()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };
            var gftResult = Client.GetFederationTokenAsync(gftRequest).Result;

            Assert.IsNotNull(gftResult.Credentials.AccessKeyId);
            Assert.IsNotNull(gftResult.Credentials.SecretAccessKey);
            Assert.IsNotNull(gftResult.Credentials.SessionToken);
            Assert.IsNotNull(gftResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gftResult.Credentials.Expiration;

            Assert.IsTrue(expires > expiresAfter);
            Assert.IsTrue(expires < expiresBefore);

            Assert.IsNotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.IsNotNull(gftResult.FederatedUser.Arn);

            Assert.IsTrue(gftResult.FederatedUser.FederatedUserId.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(gftResult.FederatedUser.Arn.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        [Category("SecurityTokenService")]
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
            Assert.IsNotNull(asyncResponse);

            var gftResult = asyncResponse;
            Assert.IsNotNull(gftResult);
            Assert.IsNotNull(gftResult.Credentials.AccessKeyId);
            Assert.IsNotNull(gftResult.Credentials.SecretAccessKey);
            Assert.IsNotNull(gftResult.Credentials.SessionToken);
            Assert.IsNotNull(gftResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gftResult.Credentials.Expiration;

            Assert.IsTrue(expires > expiresAfter);
            Assert.IsTrue(expires < expiresBefore);

            Assert.IsNotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.IsNotNull(gftResult.FederatedUser.Arn);

            Assert.IsTrue(gftResult.FederatedUser.FederatedUserId.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(gftResult.FederatedUser.Arn.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
