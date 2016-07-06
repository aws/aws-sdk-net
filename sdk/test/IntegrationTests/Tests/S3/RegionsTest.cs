using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.Util;
using System.Globalization;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class RegionsTest
    {
        [TestMethod]
        [TestCategory("S3")]
        public void TestLocation()
        {
            foreach (var location in new S3Region[] { S3Region.USW1, S3Region.EUC1 })
            {
                string bucketName = null;
                var region = RegionEndpoint.GetBySystemName(location.Value);

                using (var client = new AmazonS3Client(region))
                {
                    try
                    {
                        bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;

                        client.PutBucket(new PutBucketRequest
                        {
                            BucketName = bucketName,
                            BucketRegion = location
                        });

                        var returnedLocation = client.GetBucketLocation(new GetBucketLocationRequest
                        {
                            BucketName = bucketName
                        }).Location;

                        Assert.AreEqual(location, returnedLocation);
                    }
                    finally
                    {
                        if (bucketName != null)
                            AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestPostUpload()
        {
            var region = RegionEndpoint.USWest1;

            using (var client = new AmazonS3Client(region))
            {
                var bucketName = S3TestUtils.CreateBucket(client);
                client.PutACL(new PutACLRequest
                {
                    BucketName = bucketName,
                    CannedACL = S3CannedACL.BucketOwnerFullControl
                });

                var credentials = GetCredentials(client);
                try
                {
                    var response = testPost("foo/bar/content.txt", bucketName, testContentStream("Line one\nLine two\nLine three\n"), "", credentials, region);
                    Assert.IsNotNull(response.RequestId);
                    Assert.IsNotNull(response.HostId);
                    Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
                }
                finally
                {
                    AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
                }
            }
        }

        /// <summary>
        /// Tests that, prior to DNS propagation, the SDK correctly follows a
        /// 307 temporary redirect response to a bucket located in a region
        /// requiring AWS4 signing when using a client initially configured
        /// to us-east-1.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestAWS2ToAWS4RedirectBeforeDNSPropagation()
        {
            var useast1Client = new AmazonS3Client(RegionEndpoint.USEast1);
            var eucentral1Client = new AmazonS3Client(RegionEndpoint.EUCentral1);

            var bucketName = S3TestUtils.CreateBucket(eucentral1Client);
            try
            {
                var response = useast1Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "test.txt",
                    ContentBody = "some stuff"
                });

                Assert.IsNotNull(response);
                Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(eucentral1Client, bucketName);
            }
        }

        /// <summary>
        /// Tests that the SDK handling for 400/307 responses when trying to access
        /// buckets in AWS4 regions does not affect the exception thrown when a 301
        /// is issued. This can happen if you use a non-US East 1-client to access
        /// a bucket in a region such as us-west-2. 
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonS3Exception), 
            "The bucket you are attempting to access must be addressed using the specified endpoint. Please send all future requests to this endpoint.")]
        public void Test301RedirectTriggersException()
        {
            var uswest2Client = new AmazonS3Client(RegionEndpoint.USWest2);
            var eucentral1Client = new AmazonS3Client(RegionEndpoint.EUCentral1);

            // there is no distinction given for buckets that have not had DNS
            // propagated yet so a new bucket will suffice
            var bucketName = S3TestUtils.CreateBucket(eucentral1Client);
            try
            {
                var response = uswest2Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "test.txt",
                    ContentBody = "some stuff"
                });
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(eucentral1Client, bucketName);
            }
        }

        private static AWSCredentials GetCredentials(AmazonServiceClient client)
        {
            var type = client.GetType();
            var property = type.GetProperty("Credentials", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var credentials = property.GetValue(client, null) as AWSCredentials;
            return credentials;
        }
        static string policy_tmpl = @"{ ""expiration"": ""EXPIRATIONDATE"",  ""conditions"": [{ ""bucket"": ""BUCKETNAME"" }, { ""acl"": ""public-read"" }, [""eq"", ""$Content-Type"", ""text/plain""], [""starts-with"", ""$key"", ""foo/bar/""]MOARCONDITIONS]}";
        private S3PostUploadResponse testPost(string key, string bucketName, Stream contentStream, string extraConditions, AWSCredentials credentials, RegionEndpoint region)
        {
            var expDate = DateTime.UtcNow.AddMinutes(5).ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);

            var policy = policy_tmpl.Replace("EXPIRATIONDATE", expDate)
                                    .Replace("BUCKETNAME", bucketName)
                                    .Replace("MOARCONDITIONS", extraConditions);

            var signedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policy, credentials);

            var req = new S3PostUploadRequest
            {
                Key = key,
                Bucket = bucketName,
                CannedACL = S3CannedACL.PublicRead,
                InputStream = contentStream,
                SignedPolicy = signedPolicy,
                Region = region
            };

            return AmazonS3Util.PostUpload(req);
        }
        private Stream testContentStream(string content)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(content), false);
        }
    }
}
