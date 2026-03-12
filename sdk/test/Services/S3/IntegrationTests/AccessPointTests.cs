using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class AccessPointTests : TestBase<AmazonS3Client>
    {
        static string _bucketName;
        static string _accesspointName = UtilityMethods.GenerateName("sdk-integtests-");
        static string _accesspointArn;
        static string _accountId;
        private string _testId;

        [TestInitialize]
        public void SetTestId()
        {
            _testId = Guid.NewGuid().ToString("N");
        }

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
        public async Task PutAndGetObject()
        {
            var putRequest = new PutObjectRequest
            {
                BucketName = _accesspointArn,
                Key = _testId,
                ContentBody = "access point test data"
            };

            await Client.PutObjectAsync(putRequest);

            using (var getResponse = await Client.GetObjectAsync(_accesspointArn, _testId))
            {
                var getBody = await new StreamReader(getResponse.ResponseStream).ReadToEndAsync();
                Assert.AreEqual(putRequest.ContentBody, getBody);
            }

            var listResponse = await Client.ListObjectsAsync(_accesspointArn);
            Assert.IsTrue(listResponse.S3Objects.Count > 0);
        }

        [TestMethod]
        public async Task TestMultipartUploadViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 7000000);
            var body = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(content));

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = _testId,
                InputStream = body
            };

            await transfer.UploadAsync(uploadRequest);

            using (var getResponse = await Client.GetObjectAsync(_accesspointArn, uploadRequest.Key))
            {
                var getBody = await new StreamReader(getResponse.ResponseStream).ReadToEndAsync();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        public async Task TestPresignedUrl()
        {
            var putRequest = new PutObjectRequest
            {
                BucketName = _accesspointArn,
                Key = _testId,
                ContentBody = "access point test data"
            };

            await Client.PutObjectAsync(putRequest);

            var getPresignedUrl = await Client.GetPreSignedURLAsync(new GetPreSignedUrlRequest
            {
                BucketName = _accesspointArn,
                Key = _testId,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(1)
            });

            var request = WebRequest.CreateHttp(getPresignedUrl);
            using (var response = await request.GetResponseAsync())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var content = await reader.ReadToEndAsync();
                Assert.AreEqual(putRequest.ContentBody, content);
            }
        }
    }
}
