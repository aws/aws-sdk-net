using System;
using System.Threading;
using Amazon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class GetSessionToken : TestBase<AmazonSecurityTokenServiceClient>
    {

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        public void TestGetSessionToken()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            var gstResult = Client.GetSessionToken(gstRequest);

            Assert.IsNotNull(gstResult.Credentials.AccessKeyId);
            Assert.IsNotNull(gstResult.Credentials.SecretAccessKey);
            Assert.IsNotNull(gstResult.Credentials.SessionToken);
            Assert.IsNotNull(gstResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gstResult.Credentials.Expiration;

            Assert.IsTrue(expires > expiresAfter);
            Assert.IsTrue(expires < expiresBefore);
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        public void TestGetSessionTokenRegional()
        {
            var uswest2Client = new AmazonSecurityTokenServiceClient(RegionEndpoint.USWest2);
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            var gstResult = uswest2Client.GetSessionToken(gstRequest);

            Assert.IsNotNull(gstResult.Credentials.AccessKeyId);
            Assert.IsNotNull(gstResult.Credentials.SecretAccessKey);
            Assert.IsNotNull(gstResult.Credentials.SessionToken);
            Assert.IsNotNull(gstResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gstResult.Credentials.Expiration;

            Assert.IsTrue(expires > expiresAfter);
            Assert.IsTrue(expires < expiresBefore);
        }

        [TestMethod]
        [TestCategory("SecurityTokenService")]
        public void TestGetSessionTokenAsync()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            GetSessionTokenResponse asyncResponse = null;

#if ASYNC_AWAIT
            var task = Client.GetSessionTokenAsync(gstRequest);
            asyncResponse = task.Result;
#else
            var asyncResult = Client.BeginGetSessionToken(gstRequest,
                ar =>
                {
                    var client = ar.AsyncState as AmazonSecurityTokenServiceClient;
                    asyncResponse = client.EndGetSessionToken(ar);
                }
                , Client);
            asyncResult.AsyncWaitHandle.WaitOne();
#endif

            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.IsNotNull(asyncResponse);

            var gstResult = asyncResponse;
            Assert.IsNotNull(gstResult);
            Assert.IsNotNull(gstResult.Credentials.AccessKeyId);
            Assert.IsNotNull(gstResult.Credentials.SecretAccessKey);
            Assert.IsNotNull(gstResult.Credentials.SessionToken);
            Assert.IsNotNull(gstResult.Credentials.Expiration);

            var time = DateTime.Now;
            var approximateExpires = time.AddHours(1);
            var expiresAfter = approximateExpires.AddMinutes(-5);
            var expiresBefore = approximateExpires.AddMinutes(5);
            var expires = gstResult.Credentials.Expiration;

            Assert.IsTrue(expires > expiresAfter);
            Assert.IsTrue(expires < expiresBefore);
        }
    }
}