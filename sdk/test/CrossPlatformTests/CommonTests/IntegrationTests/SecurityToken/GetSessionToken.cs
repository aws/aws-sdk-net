using System;
using System.Threading;
using Amazon;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestFixture]
    public class GetSessionToken : TestBase<AmazonSecurityTokenServiceClient>
    {

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("SecurityTokenService")]
        public void TestGetSessionToken()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            var gstResult = Client.GetSessionTokenAsync(gstRequest).Result;

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

        [Test]
        [Category("SecurityTokenService")]
        public void TestGetSessionTokenRegional()
        {
            using (var uswest2Client = TestBase.CreateClient<AmazonSecurityTokenServiceClient>(endpoint: RegionEndpoint.USWest2))
            {
                var gstRequest = new GetSessionTokenRequest()
                {
                    DurationSeconds = 3600
                };

                var gstResult = uswest2Client.GetSessionTokenAsync(gstRequest).Result;

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

        [Test]
        [Category("SecurityTokenService")]
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