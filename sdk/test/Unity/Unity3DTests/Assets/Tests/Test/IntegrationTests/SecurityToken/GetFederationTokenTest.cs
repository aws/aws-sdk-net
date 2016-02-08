using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AWSSDK.IntegrationTests.SecurityToken
{
    [TestFixture]
    public class GetFederationTokenTest : TestBase<AmazonSecurityTokenServiceClient>
    {

        [Test]
        [Category("SecurityTokenService")]
        [Category("WWW")]
        public void TestGetFederationToken()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };

            GetFederationTokenResponse gftResult = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.GetFederationTokenAsync(gftRequest, (result) =>
            {
                gftResult = result.Response;
                ars.Set();
            }, options);

            ars.WaitOne();
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

            Utils.AssertTrue(expires > expiresAfter);
            Utils.AssertTrue(expires < expiresBefore);

            Assert.IsNotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.IsNotNull(gftResult.FederatedUser.Arn);

            Utils.AssertTrue(gftResult.FederatedUser.FederatedUserId.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
            Utils.AssertTrue(gftResult.FederatedUser.Arn.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        [Category("SecurityTokenService")]
        [Category("WWW")]
        public void TestGetFederationTokenAsync()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };

            GetFederationTokenResponse gftResult = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.GetFederationTokenAsync(gftRequest, (result) =>
            {
                gftResult = result.Response;
                ars.Set();
            }, options);

            ars.WaitOne();

            Thread.Sleep(TimeSpan.FromSeconds(5));

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

            Utils.AssertTrue(expires > expiresAfter);
            Utils.AssertTrue(expires < expiresBefore);

            Assert.IsNotNull(gftResult.FederatedUser.FederatedUserId);
            Assert.IsNotNull(gftResult.FederatedUser.Arn);

            Utils.AssertTrue(gftResult.FederatedUser.FederatedUserId.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
            Utils.AssertTrue(gftResult.FederatedUser.Arn.EndsWith(gftRequest.Name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
