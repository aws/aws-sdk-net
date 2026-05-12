using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class MultiRegionAccessPointsTests
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _mrapArn;

        public MultiRegionAccessPointsTests(ChecksumMrapFixture mrapFixture)
        {
            _client = mrapFixture.Client;
            _bucketName = mrapFixture.BucketName;
            _mrapArn = mrapFixture.MrapArn;
        }

        [Fact]
        public async Task PutObjectUnchunkedAndUnsigned()
        {
            await S3TestUtils.PutAndGetObjectTestHelper(_client, _mrapArn, "dotnet-sdk-test-unchunked-unsigned", false, true);
        }

        [Fact]
        public async Task PutObjectUnchunked()
        {
            await S3TestUtils.PutAndGetObjectTestHelper(_client, _mrapArn, "dotnet-sdk-test-unchunked", false);
        }

        [Fact]
        public async Task PutObjectChunked()
        {
            await S3TestUtils.PutAndGetObjectTestHelper(_client, _mrapArn, "dotnet-sdk-test-chunked");
        }

        [Fact]
        public void TestPresigingOver7DaysThrowsException()
        {
            Assert.Throws<ArgumentException>(() => 
                _client.GetPreSignedURL(new GetPreSignedUrlRequest
                {
                    BucketName = _mrapArn,
                    Key = "dotnet-sdk-test",
                    Verb = HttpVerb.GET,
                    Expires = DateTime.UtcNow.AddDays(8)
                })
            );
        }

        [Theory]
        [InlineData(@"ObjectWith\InKeyname")]
        [InlineData(@"ObjectWith/InKeyname")]
        [InlineData(@"ObjectWith\InKeynÄme")]
        [InlineData(@"ObjectWith/InKeynÄme")]
        [InlineData(@"ObjectWith!InKeynÄme")]
        [InlineData(@"ObjectWith$InKeyname.Ext")]
        [InlineData(@"ObjectWith!and?\+forgood:measureThis=And&InKeynÄme")]
        public async Task PutAndGetQuestionableKeys(string keyVariant)
        {
            var keyName = "dotnet-sdk-test-" + keyVariant;
            await S3TestUtils.PutAndGetObjectTestHelper(_client, _mrapArn, keyName, false);
        }
    }
}
