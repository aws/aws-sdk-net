using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class ObjectTaggingTest : IClassFixture<S3BucketFixture>
    {
        private const char iUmlautChar = (char)0x00EF;
        private const string TestObjectContent = "content";

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        public ObjectTaggingTest(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
            _testId = Guid.NewGuid().ToString("N");
        }

        [Fact]
        public async Task TagBucket()
        {
            await _client.PutBucketTaggingAsync(new PutBucketTaggingRequest
            {
                BucketName = _bucketName,
                TagSet = new List<Tag>
                {
                    new Tag
                    {
                        Key = "TagBucketKey",
                        Value = "TagBucketValue"
                    }
                }
            });
                        
            var tags = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketTaggingAsync(new GetBucketTaggingRequest { BucketName = _bucketName });
                return res.TagSet?.FirstOrDefault(x => string.Equals(x.Key, "TagBucketKey")) != null ? res.TagSet : null;
            });

            var tag = tags.FirstOrDefault(x => string.Equals(x.Key, "TagBucketKey"));
            Assert.NotNull(tag);
            Assert.Equal("TagBucketValue", tag.Value);
        }

        [Fact]
        public async Task TagWithUnicodeKey()
        {
            var testObjectKey = _testId + "-testObjectKey";
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = testObjectKey,
                ContentBody = TestObjectContent,
                TagSet = new List<Tag> { new Tag { Key = "key" + iUmlautChar, Value = "value" } }
            });

            var response = await _client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = testObjectKey
            });

            Assert.Equal("key" + iUmlautChar, response.Tagging[0].Key);
            Assert.Equal("value", response.Tagging[0].Value);
        }

        [Fact]
        public async Task TagWithUnicodeValue()
        {
            var testObjectKey = _testId + "-testObjectKey";
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = testObjectKey,
                ContentBody = TestObjectContent,
                TagSet = new List<Tag> { new Tag { Key = "key", Value = "value" + iUmlautChar } }
            });

            var response = await _client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = testObjectKey
            });

            Assert.Equal("key", response.Tagging[0].Key);
            Assert.Equal("value" + iUmlautChar, response.Tagging[0].Value);
        }

        [Fact]
        public async Task GetObjectTaggingWithVersionTest()
        {
            string key = _testId + "-getobjectWithVersions";
            await EnableBucketVersioning();
            
            var putResponseV = await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "hello",
                TagSet = new List<Tag>
                {
                    new Tag { Key = "k", Value = "v" }
                }
            });
            var metadataResponse = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });
            Assert.Equal(putResponseV.VersionId, metadataResponse.VersionId);

            var putResponseV2 = await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "hello2",
                TagSet = new List<Tag>
                {
                    new Tag { Key = "k", Value = "v2" }
                }
            });
            var metadataResponse2 = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });
            Assert.Equal(putResponseV2.VersionId, metadataResponse2.VersionId);

            var taggingResponse = await _client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = key,
                VersionId = metadataResponse.VersionId
            });
            Assert.Equal("v", taggingResponse.Tagging[0].Value);

            taggingResponse = await _client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = key
            });
            Assert.Equal("v2", taggingResponse.Tagging[0].Value);
        }

        [Fact]
        public async Task PutObjectTaggingWithVersionTest()
        {
            string key = _testId + "-putobjectWithVersions";
            await EnableBucketVersioning();

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "hello"
            });
            var metadataResponse = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "hello2"
            });
            var metadataResponse2 = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            await _client.PutObjectTaggingAsync(new PutObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = key,
                Tagging = new Tagging
                {
                    TagSet = new List<Tag>
                    {
                        new Tag { Key = "key", Value = "Value" }
                    }
                },
                VersionId = metadataResponse.VersionId
            });

            await _client.PutObjectTaggingAsync(new PutObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = key,
                Tagging = new Tagging
                {
                    TagSet = new List<Tag>
                    {
                        new Tag { Key = "key", Value = "Value2" }
                    },
                }
            });

            var taggingResponse = await _client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = key,
                VersionId = metadataResponse.VersionId
            });
            Assert.Equal("Value", taggingResponse.Tagging[0].Value);

            taggingResponse = await _client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = key,
                VersionId = metadataResponse2.VersionId
            });
            Assert.Equal("Value2", taggingResponse.Tagging[0].Value);
        }

        [Fact]
        public async Task MultipartObjectTaggingTest()
        {
            var transferClient = new TransferUtility(_client, new TransferUtilityConfig { MinSizeBeforePartUpload = 5_000_000 });
            var objectKey = _testId + $"-multipart-tagging";
            var tempFilePath = Path.GetTempFileName();
            UtilityMethods.GenerateFile(tempFilePath, 1024 * 1024 * 6);

            await transferClient.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = objectKey,
                FilePath = tempFilePath,
                TagSet = new List<Tag>
                {
                    new Tag { Key = "hello", Value = "world" }
                }
            });

            var response = await _client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _bucketName,
                Key = objectKey
            });
            Assert.Equal(1, response.Tagging.Count);
            Assert.Equal("hello", response.Tagging[0].Key);
            Assert.Equal("world", response.Tagging[0].Value);
        }

        private async Task EnableBucketVersioning()
        {
            await _client.PutBucketVersioningAsync(new PutBucketVersioningRequest
            {
                BucketName = _bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

            // Wait for versioning to be set on the bucket or multiple PutObject with the same key may not add a new version
            await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketVersioningAsync(new GetBucketVersioningRequest
                {
                    BucketName = _bucketName
                });
                return res.VersioningConfig?.Status == VersionStatus.Enabled ? res : null;
            });
        }
    }
}
