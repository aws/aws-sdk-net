using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    public class AccessPointTestsFixture : S3BucketFixture
    {
        public string AccessPointName { get; private set; }
        public string AccessPointArn { get; private set; }
        public string AccountId { get; private set; }

        private AmazonS3ControlClient _s3ControlClient;

        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();

            _s3ControlClient = new AmazonS3ControlClient();
            AccessPointName = UtilityMethods.GenerateName("sdk-integtests-");

            using (var stsClient = new AmazonSecurityTokenServiceClient())
            {
                AccountId = (await stsClient.GetCallerIdentityAsync(new GetCallerIdentityRequest())).Account;
            }

            BucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            await _s3ControlClient.CreateAccessPointAsync(new CreateAccessPointRequest
            {
                AccountId = AccountId,
                Bucket = BucketName,
                Name = AccessPointName
            });

            AccessPointArn = new Arn { AccountId = AccountId, Partition = "aws", Region = _s3ControlClient.Config.RegionEndpoint.SystemName, Service = "s3", Resource = "accesspoint:" + AccessPointName }.ToString();
        }

        public override async ValueTask DisposeAsync()
        {
            if (_s3ControlClient != null)
            {
                await _s3ControlClient.DeleteAccessPointAsync(new DeleteAccessPointRequest
                {
                    AccountId = AccountId,
                    Name = AccessPointName
                });
                _s3ControlClient.Dispose();
            }

            await base.DisposeAsync();
        }
    }

    [Trait("Category", "S3")]
    public class AccessPointTests : IClassFixture<AccessPointTestsFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _accesspointArn;
        private readonly string _testId;

        public AccessPointTests(AccessPointTestsFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
            _accesspointArn = fixture.AccessPointArn;
            _testId = Guid.NewGuid().ToString("N");
        }

        [Fact]
        public async Task PutAndGetObject()
        {
            var putRequest = new PutObjectRequest
            {
                BucketName = _accesspointArn,
                Key = _testId,
                ContentBody = "access point test data"
            };

            await _client.PutObjectAsync(putRequest);

            using (var getResponse = await _client.GetObjectAsync(_accesspointArn, _testId))
            {
                var getBody = await new StreamReader(getResponse.ResponseStream).ReadToEndAsync();
                Assert.Equal(putRequest.ContentBody, getBody);
            }

            var listResponse = await _client.ListObjectsAsync(_accesspointArn);
            Assert.True(listResponse.S3Objects.Count > 0);
        }

        [Fact]
        public async Task TestMultipartUploadViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(_client, transferConfig);
            var content = new string('a', 7000000);
            var body = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(content));

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = _testId,
                InputStream = body
            };

            await transfer.UploadAsync(uploadRequest);

            using (var getResponse = await _client.GetObjectAsync(_accesspointArn, uploadRequest.Key))
            {
                var getBody = await new StreamReader(getResponse.ResponseStream).ReadToEndAsync();
                Assert.Equal(content, getBody);
            }
        }

        [Fact]
        public async Task TestPresignedUrl()
        {
            var putRequest = new PutObjectRequest
            {
                BucketName = _accesspointArn,
                Key = _testId,
                ContentBody = "access point test data"
            };

            await _client.PutObjectAsync(putRequest);

            var getPresignedUrl = await _client.GetPreSignedURLAsync(new GetPreSignedUrlRequest
            {
                BucketName = _accesspointArn,
                Key = _testId,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(1)
            });

            using (var httpClient = new HttpClient())
            {
                var content = await httpClient.GetStringAsync(getPresignedUrl);
                Assert.Equal(putRequest.ContentBody, content);
            }
        }
    }
}
