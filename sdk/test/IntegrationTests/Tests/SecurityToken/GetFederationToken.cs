using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class GetFederationTokenTest : TestBase<AmazonSecurityTokenServiceClient>
    {

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        public void TestGetFederationToken()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };
            var gftResult = Client.GetFederationToken(gftRequest);

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

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        public void TestGetFederationTokenAsync()
        {
            var gftRequest = new GetFederationTokenRequest
            {
                Policy = @"{""Statement"":[{""Effect"":""Allow"",""Action"":""*"",""Resource"":""*""}]}",
                Name = "BillyBob",
                DurationSeconds = 3600
            };

            GetFederationTokenResponse asyncResponse = null;

#if ASYNC_AWAIT
            var task = Client.GetFederationTokenAsync(gftRequest);
            asyncResponse = task.Result;
#else
            var asyncResult = Client.BeginGetFederationToken(gftRequest,
                ar =>
                {
                    var client = ar.AsyncState as AmazonSecurityTokenServiceClient;
                    asyncResponse = client.EndGetFederationToken(ar);
                }
                , Client);
            asyncResult.AsyncWaitHandle.WaitOne();
#endif

            Thread.Sleep(TimeSpan.FromSeconds(5));
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
