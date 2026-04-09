using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class ListObjectsTests : IClassFixture<S3BucketFixture>, IAsyncLifetime
    {
        private const string content = "Test content";

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        private static readonly List<string> keys = new List<string>
        {
            //"a/",
            //"a/b/",
            "a/b/c",
            "a/b/d",
            "a/e",
            "a/f",
            "a/g\rh",
            "a/g\ni",
            "a/g&j",
        };

        public ListObjectsTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
        }

        public async ValueTask InitializeAsync()
        {
            // Pre-populate the bucket with test objects (duplicate puts are idempotent).
            foreach (var key in keys)
            {
                if (key.EndsWith("/"))
                    continue;

                await _client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    ContentBody = content
                });
            }
        }

        public ValueTask DisposeAsync() => new ValueTask();

        [Fact]
        public async Task TestS3ObjectsContainBucketName()
        {
            var response = await _client.ListObjectsAsync(new ListObjectsRequest
            {
                BucketName = _bucketName
            });

            foreach (var s3Object in response.S3Objects)
            {
                Assert.Equal(s3Object.BucketName, _bucketName);
            }
        }

        [Fact]
        public async Task TestListV2()
        {
            var response = await _client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = _bucketName,
                StartAfter = keys[0],
                FetchOwner = true
            });
            Assert.False(response.IsTruncated.Value);
            Assert.Equal(keys.Count - 1, response.KeyCount);
            Assert.Equal(keys.Count - 1, response.S3Objects.Count);
            Assert.Null(response.ContinuationToken);
            Assert.NotNull(response.S3Objects[0].Owner);
            Assert.True(response.S3Objects.Any(o => o.Key.Contains("\r")));
            Assert.True(response.S3Objects.Any(o => o.Key.Contains("\n")));
            Assert.True(response.S3Objects.Any(o => o.Key.Contains("&")));

            response = await _client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = _bucketName,
                MaxKeys = 1,
                StartAfter = keys[0],
                FetchOwner = true
            });
            Assert.True(response.IsTruncated.Value);
            Assert.Equal(1, response.KeyCount);
            Assert.Equal(1, response.MaxKeys);
            Assert.Equal(1, response.S3Objects.Count);
            Assert.Null(response.ContinuationToken);
            Assert.NotNull(response.NextContinuationToken);
            Assert.NotNull(response.S3Objects[0].Owner);
            Assert.Equal(response.S3Objects[0].BucketName, _bucketName);

            response = await _client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = _bucketName,
                MaxKeys = 1,
                FetchOwner = true,
                ContinuationToken = response.NextContinuationToken
            });
            Assert.True(response.IsTruncated.Value);
            Assert.Equal(1, response.KeyCount);
            Assert.Equal(1, response.MaxKeys);
            Assert.NotNull(response.ContinuationToken);
            Assert.NotNull(response.NextContinuationToken);
            Assert.Equal(1, response.S3Objects.Count);
            Assert.NotNull(response.S3Objects[0].Owner);
            Assert.Equal(response.S3Objects[0].BucketName, _bucketName);

            response = await _client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = _bucketName,
                MaxKeys = 1,
            });
            Assert.True(response.IsTruncated.Value);
            Assert.Equal(1, response.KeyCount);
            Assert.Equal(1, response.MaxKeys);
            Assert.Equal(1, response.S3Objects.Count);
            Assert.Null(response.ContinuationToken);
            Assert.NotNull(response.NextContinuationToken);
            Assert.Null(response.S3Objects[0].Owner);
            Assert.Equal(response.S3Objects[0].BucketName, _bucketName);

            response = await _client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = _bucketName,
                MaxKeys = 1,
                ContinuationToken = response.NextContinuationToken
            });
            Assert.True(response.IsTruncated.Value);
            Assert.Equal(1, response.KeyCount);
            Assert.Equal(1, response.MaxKeys);
            Assert.NotNull(response.ContinuationToken);
            Assert.NotNull(response.NextContinuationToken);
            Assert.Equal(1, response.S3Objects.Count);
            Assert.Null(response.S3Objects[0].Owner);
            Assert.Equal(response.S3Objects[0].BucketName, _bucketName);
        }
    }
}
