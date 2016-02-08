using Amazon;
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
    public class GetSessionToken : TestBase<AmazonSecurityTokenServiceClient>
    {
        [Test]
        [Category("SecurityTokenService")]
        [Category("WWW")]
        public void TestGetSessionToken()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };

            GetSessionTokenResponse gstResult = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.GetSessionTokenAsync(gstRequest, (result) =>
            {
                gstResult = result.Response;
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();

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

            Utils.AssertTrue(expires > expiresAfter);
            Utils.AssertTrue(expires < expiresBefore);
        }

        [Test]
        [Category("SecurityTokenService")]
        [Category("WWW")]
        public void TestGetSessionTokenRegional()
        {
            using (var uswest2Client = TestBase.CreateClient<AmazonSecurityTokenServiceClient>(endpoint: RegionEndpoint.USWest2))
            {
                var gstRequest = new GetSessionTokenRequest()
                {
                    DurationSeconds = 3600
                };

                GetSessionTokenResponse gstResult = null;
                AutoResetEvent ars = new AutoResetEvent(false);
                uswest2Client.GetSessionTokenAsync(gstRequest, (result) =>
                {
                    gstResult = result.Response;
                    ars.Set();
                }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

                ars.WaitOne();

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

                Utils.AssertTrue(expires > expiresAfter);
                Utils.AssertTrue(expires < expiresBefore);
            }
        }

        [Test]
        [Category("SecurityTokenService")]
        [Category("WWW")]
        public void TestGetSessionTokenAsync()
        {
            var gstRequest = new GetSessionTokenRequest()
            {
                DurationSeconds = 3600
            };


            GetSessionTokenResponse gstResult = null;
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.GetSessionTokenAsync(gstRequest, (result) =>
            {
                gstResult = result.Response;
                ars.Set();
            }, new Amazon.Runtime.AsyncOptions() { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();

            Thread.Sleep(TimeSpan.FromSeconds(5));
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

            Utils.AssertTrue(expires > expiresAfter);
            Utils.AssertTrue(expires < expiresBefore);
        }
    }
}