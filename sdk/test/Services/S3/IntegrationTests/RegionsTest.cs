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
using System.Threading;
using System.Collections.Generic;
using Amazon.Runtime.Credentials.Internal;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class RegionsTest
    {
        [TestMethod]
        [TestCategory("S3")]
        
        public void TestPostUpload()
        {
            var region = RegionEndpoint.USWest1;

            using (var client = new AmazonS3Client(region))
            {
                var bucketName = S3TestUtils.CreateBucketWithWait(client, true);

                client.PutBucketAcl(new PutBucketAclRequest
                {
                    BucketName = bucketName,
                    ACL = S3CannedACL.BucketOwnerFullControl
                });

                var credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
                try
                {
                    var response = TestPost("foo/bar/content.txt", bucketName, TestContentStream("Line one\nLine two\nLine three\n"), "", credentials, region);
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
            var useast1Client = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            var eucentral1Client = new AmazonS3Client(RegionEndpoint.EUCentral1);

            var bucketName = S3TestUtils.CreateBucketWithWait(eucentral1Client);
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
            var bucketName = S3TestUtils.CreateBucketWithWait(eucentral1Client);
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

        static string policy_tmpl = @"{ ""expiration"": ""EXPIRATIONDATE"",  ""conditions"": [{ ""bucket"": ""BUCKETNAME"" }, { ""acl"": ""public-read"" }, [""eq"", ""$Content-Type"", ""text/plain""], [""starts-with"", ""$key"", ""foo/bar/""]MOARCONDITIONS]}";

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
        private Stream TestContentStream(string content)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(content), false);
        }
    }
}
