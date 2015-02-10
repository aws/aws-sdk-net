using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.Runtime;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class General
    {
        [TestMethod]
        public void TestClientDispose()
        {
            IAmazonS3 client;
            using(client = new AmazonS3Client())
            {
                var response = client.ListBuckets();
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseMetadata);
                Assert.IsNotNull(response.ResponseMetadata.RequestId);
                Assert.IsFalse(string.IsNullOrEmpty(response.ResponseMetadata.RequestId));
            }

            AssertExtensions.ExpectException(() => client.ListBuckets(), typeof(ObjectDisposedException));
        }

        [TestMethod]
        public void TestExpiringCredentials()
        {
            // test that non-expired credentials work
            TestExpireOffset(returnExpiredCredentials: false);

            // test that expired credentials do not work
            TestExpireOffset(returnExpiredCredentials: true);


            // test that various dates work
            TestExpire(DateTime.Now, expectFailure: true);
            TestExpire(DateTime.UtcNow, expectFailure: true);

            // 1 minute offset
            var epsilon = TimeSpan.FromMinutes(1);
            
            TestExpire(DateTime.Now + epsilon, expectFailure: false);
            TestExpire(DateTime.UtcNow + epsilon, expectFailure: false);
            TestExpire(DateTime.Now - epsilon, expectFailure: true);
            TestExpire(DateTime.UtcNow - epsilon, expectFailure: true);
        }

        private static void TestExpireOffset(bool returnExpiredCredentials)
        {
            TimeSpan expireOffset;
            if (returnExpiredCredentials)
                expireOffset = TimeSpan.FromHours(-1);
            else
                expireOffset = TimeSpan.FromHours(6);

            var creds = new ProxyRefreshingAWSCredentials(expireOffset);
            TestCredentials(creds, returnExpiredCredentials);
        }
        private static void TestExpire(DateTime expire, bool expectFailure)
        {
            var creds = new ProxyRefreshingAWSCredentials(expire);
            TestCredentials(creds, expectFailure);
        }


        private static void TestCredentials(ProxyRefreshingAWSCredentials creds, bool expectFailure)
        {
            using (var client = new AmazonS3Client(creds))
            {
                try
                {
                    client.ListBuckets();
                    Assert.IsFalse(expectFailure);
                }
                catch (AmazonClientException ace)
                {
                    Assert.IsTrue(expectFailure);
                    Assert.IsNotNull(ace);
                    Assert.IsNotNull(ace.Message);
                    Assert.IsTrue(ace.Message.IndexOf("already") >= 0);
                }
            }
        }

        private class ProxyRefreshingAWSCredentials : RefreshingAWSCredentials
        {
            private TimeSpan expireOffset;
            private DateTime? expireValue = null;

            public ProxyRefreshingAWSCredentials()
                : this(TimeSpan.FromHours(6))
            { }
            public ProxyRefreshingAWSCredentials(TimeSpan expireOffset)
            {
                this.expireOffset = expireOffset;
            }
            public ProxyRefreshingAWSCredentials(DateTime expireValue)
            {
                this.expireValue = expireValue;
            }

            protected override CredentialsRefreshState GenerateNewCredentials()
            {
                var credentials = UtilityMethods.CreateTemporaryCredentials();
                var ic = credentials.GetCredentials();

                DateTime expiration;
                if (expireValue.HasValue)
                {
                    expiration = expireValue.Value;
                }
                else
                {
                    var now = DateTime.Now;
                    expiration = now + expireOffset;
                }

                return new CredentialsRefreshState(ic, expiration);
            }
        }
    }
}
