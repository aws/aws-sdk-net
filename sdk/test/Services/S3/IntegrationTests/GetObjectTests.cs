using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class GetObjectTests
    {
        private const string content = "0123456789";

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        public GetObjectTests(SharedS3ObjectBucketFixture sharedBucket)
        {
            _client = sharedBucket.Client;
            _bucketName = sharedBucket.BucketName;
            _testId = Guid.NewGuid().ToString("N");
        }

        // "TestObject" is pre-populated by the shared bucket fixture's bucket — but since
        // the shared bucket is created fresh per assembly run we need to ensure it exists.
        // We put it lazily in each test that needs it, using a unique key per test instance.
        private async Task<string> PutTestObject()
        {
            var key = _testId + "-TestObject";
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                ContentBody = content,
                Key = key
            });
            return key;
        }

        [Fact]
        public async Task TestRangedGetWithStartAndEnd()
        {
            var key = await PutTestObject();
            var response = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                ByteRange = new ByteRange(1, 5),
                Key = key
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = await reader.ReadToEndAsync();
                    Assert.Equal("12345", text);
                }
            }
        }

        [Fact]
        public async Task TestRangedGetWithByteRange()
        {
            var key = await PutTestObject();
            var response = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                ByteRange = new ByteRange("bytes=-2"),
                Key = key
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = await reader.ReadToEndAsync();
                    Assert.Equal("89", text);
                }
            }
        }

        [Fact]
        public async Task TestObjectAttributesLastModified()
        {
            var key = await PutTestObject();
            var getObjectAttributesResponse = await _client.GetObjectAttributesAsync(new GetObjectAttributesRequest
            {
                BucketName = _bucketName,
                Key = key,
                ObjectAttributes = new List<ObjectAttributes> { ObjectAttributes.ObjectSize }
            });

            var getObjectMetadataResponse = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            Assert.NotEqual(getObjectAttributesResponse.LastModified, DateTime.MinValue);
            Assert.Equal(getObjectAttributesResponse.LastModified, getObjectMetadataResponse.LastModified);
        }

        [Fact]
        public async Task TestContentLanguageResponseHeaderOverride()
        {
            var key = _testId + "-TestContentLanguageResponseHeaderOverride";
            var originalLanguage = "fr-FR";
            var overrideLanguage = "es-ES";

            // Put object with original Content-Language
            var putRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "Test content for Content-Language override",
            };
            putRequest.Headers["Content-Language"] = originalLanguage;

            await _client.PutObjectAsync(putRequest);

            // Get object with response header override
            var response = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ResponseHeaderOverrides = new ResponseHeaderOverrides
                {
                    ContentLanguage = overrideLanguage
                }
            });

            using (response)
            {
                Assert.NotNull(response.ContentLanguage);
                Assert.Equal(overrideLanguage, response.ContentLanguage);
            }

            // Verify original value is still stored by getting without override
            var responseWithoutOverride = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            using (responseWithoutOverride)
            {
                Assert.Equal(originalLanguage, responseWithoutOverride.ContentLanguage);
            }
        }

        [Fact]
        public async Task TestContentLanguageHeadersCollection()
        {
            var key = _testId + "-TestContentLanguageHeadersCollection";
            var expectedLanguage = "de-DE";

            // Put object with Content-Language header
            var putRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "Test content for Content-Language headers collection"
            };
            putRequest.Headers["Content-Language"] = expectedLanguage;

            await _client.PutObjectAsync(putRequest);

            // Get object and verify both ContentLanguage properties are set
            var response = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            using (response)
            {
                // Verify the direct ContentLanguage property
                Assert.NotNull(response.ContentLanguage);
                Assert.Equal(expectedLanguage, response.ContentLanguage);

                // Verify the Headers.ContentLanguage property
                Assert.NotNull(response.Headers.ContentLanguage);
                Assert.Equal(expectedLanguage, response.Headers.ContentLanguage);

                // Verify both properties have the same value
                Assert.Equal(response.ContentLanguage, response.Headers.ContentLanguage);
            }
        }
    }
}
