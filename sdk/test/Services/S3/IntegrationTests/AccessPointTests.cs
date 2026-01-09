using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class AccessPointTests : TestBase<AmazonS3Client>
    {
        static string _bucketName;
        static string _accesspointName = "sdk-integtests-" + DateTime.UtcNow.Ticks;
        static string _accesspointArn;
        static string _accountId;

        [ClassInitialize]
        public static async Task Setup(TestContext context)
        {
            using (var stsClient = new AmazonSecurityTokenServiceClient())
            using (var s3ControlClient = new AmazonS3ControlClient())
            {
                _accountId = (await stsClient.GetCallerIdentityAsync(new GetCallerIdentityRequest())).Account;
                _bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
                
                var response = await s3ControlClient.CreateAccessPointAsync(new CreateAccessPointRequest
                {
                    AccountId = _accountId,
                    Bucket = _bucketName,
                    Name = _accesspointName
                });

                _accesspointArn = new Arn { AccountId = _accountId, Partition = "aws", Region = s3ControlClient.Config.RegionEndpoint.SystemName, Service = "s3", Resource = "accesspoint:" + _accesspointName }.ToString();
            }
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            using (var s3ControlClient = new AmazonS3ControlClient())
            {
                await s3ControlClient.DeleteAccessPointAsync(new DeleteAccessPointRequest
                {
                    AccountId = _accountId,
                    Name = _accesspointName
                });

                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, _bucketName);
            }
        }

        [TestMethod]
        public void PutAndGetObject()
        {
            var objectKey = Guid.NewGuid().ToString();
            var putRequest = new PutObjectRequest
            {
                BucketName = _accesspointArn,
                Key = objectKey,
                ContentBody = "access point test data"
            };

            Client.PutObject(putRequest);

            using (var getResponse = Client.GetObject(_accesspointArn, objectKey))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(putRequest.ContentBody, getBody);
            }

            var listResponse = Client.ListObjects(_accesspointArn);
            Assert.IsTrue(listResponse.S3Objects.Count > 0);
        }

        [TestMethod]
        public void TestMultipartUploadViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 7000000);
            var body = new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(content));

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = "a-lot-of-as.txt",
                InputStream = body
            };

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(_accesspointArn, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        public void TestPresignedUrl()
        {
            var objectKey = Guid.NewGuid().ToString();
            var putRequest = new PutObjectRequest
            {
                BucketName = _accesspointArn,
                Key = objectKey,
                ContentBody = "access point test data"
            };

            Client.PutObject(putRequest);

            var getPresignedUrl = Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = _accesspointArn,
                Key = objectKey,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(1)
            });

            var request = WebRequest.CreateHttp(getPresignedUrl) as HttpWebRequest;
            using (var response = request.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var content = reader.ReadToEnd();
                Assert.AreEqual(putRequest.ContentBody, content);
            }
        }
    }
}
