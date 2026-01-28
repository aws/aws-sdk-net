using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class RegionsTest
    {
        /// <summary>
        /// Tests that, prior to DNS propagation, the SDK correctly follows a
        /// 307 temporary redirect response to a bucket located in a region
        /// requiring AWS4 signing when using a client initially configured
        /// to us-east-1.
        /// </summary>
        [TestMethod]
        public async Task TestAWS2ToAWS4RedirectBeforeDNSPropagation()
        {
            var useast1Client = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            var eucentral1Client = new AmazonS3Client(RegionEndpoint.EUCentral1);
            var bucketName = await S3TestUtils.CreateBucketWithWaitAsync(eucentral1Client);
            try
            {
                var response = await useast1Client.PutObjectAsync(new PutObjectRequest
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
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(eucentral1Client, bucketName);
            }
        }

        /// <summary>
        /// Tests that the SDK handling for 400/307 responses when trying to access
        /// buckets in AWS4 regions does not affect the exception thrown when a 301
        /// is issued. This can happen if you use a non-US East 1-client to access
        /// a bucket in a region such as us-west-2. 
        /// </summary>
        [TestMethod]
        public async Task Test301RedirectTriggersException()
        {
            var uswest2Client = new AmazonS3Client(RegionEndpoint.USWest2);
            var eucentral1Client = new AmazonS3Client(RegionEndpoint.EUCentral1);

            // there is no distinction given for buckets that have not had DNS
            // propagated yet so a new bucket will suffice
            var bucketName = await S3TestUtils.CreateBucketWithWaitAsync(eucentral1Client);
            try
            {
                var actual = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() =>
                    uswest2Client.PutObjectAsync(new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = "test.txt",
                        ContentBody = "some stuff"
                    })
                );

                Assert.AreEqual("The bucket you are attempting to access must be addressed using the specified endpoint. Please send all future requests to this endpoint.", actual.Message);
            }
            finally
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(eucentral1Client, bucketName);
            }
        }

#if NETFRAMEWORK
        /// <remarks>
        /// <see cref="AmazonS3Util.PostUpload"/> is only available on .NET Framework.
        /// </remarks>
        [TestMethod]
        public async Task TestPostUpload()
        {
            var region = RegionEndpoint.USWest1;

            using (var client = new AmazonS3Client(region))
            {
                var bucketName = await S3TestUtils.CreateBucketWithWaitAsync(client, true);
                await client.PutBucketAclAsync(new PutBucketAclRequest
                {
                    BucketName = bucketName,
                    ACL = S3CannedACL.BucketOwnerFullControl
                });

                var credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
                try
                {
                    var contentStream = new MemoryStream(Encoding.UTF8.GetBytes("Line one\nLine two\nLine three\n"), false);
                    var response = TestPost("foo/bar/content.txt", bucketName, contentStream, "", credentials, region);
                    Assert.IsNotNull(response.RequestId);
                    Assert.IsNotNull(response.HostId);
                    Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
                }
                finally
                {
                    await AmazonS3Util.DeleteS3BucketWithObjectsAsync(client, bucketName);
                }
            }
        }

        private static string policy_tmpl = @"{ ""expiration"": ""EXPIRATIONDATE"",  ""conditions"": [{ ""bucket"": ""BUCKETNAME"" }, { ""acl"": ""public-read"" }, [""eq"", ""$Content-Type"", ""text/plain""], [""starts-with"", ""$key"", ""foo/bar/""]MOARCONDITIONS]}";

        private S3PostUploadResponse TestPost(string key, string bucketName, Stream contentStream, string extraConditions, AWSCredentials credentials, RegionEndpoint region)
        {
            var expDate = DateTime.UtcNow.AddMinutes(5).ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
            var policy = policy_tmpl.Replace("EXPIRATIONDATE", expDate)
                                    .Replace("BUCKETNAME", bucketName)
                                    .Replace("MOARCONDITIONS", extraConditions);

            var signedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policy, credentials, region.SystemName);
            var req = new S3PostUploadRequest
            {
                Key = key,
                Bucket = bucketName,
                ContentType = "text/plain",
                CannedACL = S3CannedACL.PublicRead,
                InputStream = contentStream,
                SignedPolicy = signedPolicy,
                Region = region
            };

            return AmazonS3Util.PostUpload(req);
        }
#endif
    }
}
