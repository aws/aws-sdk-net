using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    public class CopyObjectTestsFixture : IAsyncLifetime
    {
        public const string TestContent = "This is the content body!";
        public const string TestKey = "testKey.txt";
        public const string TestKeyWithSlash = "/sourceTestKey.txt";

        public AmazonS3Client UsEast1Client { get; private set; }
        public AmazonS3Client UsWest1Client { get; private set; }
        public string UsEast1BucketName { get; private set; }
        public string UsWest1BucketName { get; private set; }

        public async ValueTask InitializeAsync()
        {
            UsEast1Client = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            UsEast1BucketName = await S3TestUtils.CreateBucketWithWaitAsync(UsEast1Client);
            await UsEast1Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = UsEast1BucketName,
                Key = TestKey,
                ContentBody = TestContent
            });
            await UsEast1Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = UsEast1BucketName,
                Key = TestKeyWithSlash,
                ContentBody = TestContent
            });

            UsWest1Client = new AmazonS3Client(RegionEndpoint.USWest1);
            UsWest1BucketName = await S3TestUtils.CreateBucketWithWaitAsync(UsWest1Client);
        }

        public async ValueTask DisposeAsync()
        {
            if (UsEast1Client != null)
            {
                if (UsEast1BucketName != null)
                {
                    await AmazonS3Util.DeleteS3BucketWithObjectsAsync(UsEast1Client, UsEast1BucketName);
                }

                UsEast1Client.Dispose();
            }

            if (UsWest1Client != null)
            {
                if (UsWest1BucketName != null)
                {
                    await AmazonS3Util.DeleteS3BucketWithObjectsAsync(UsWest1Client, UsWest1BucketName);
                }

                UsWest1Client.Dispose();
            }
        }
    }

    [Trait("Category", "S3")]
    public class CopyObjectTests : IClassFixture<CopyObjectTestsFixture>
    {
        private const string testKeyWithTag = "testKeyWithTag.txt";

        private const string testContent = CopyObjectTestsFixture.TestContent;
        private const string testKey = CopyObjectTestsFixture.TestKey;
        private const string testKeyWithSlash = CopyObjectTestsFixture.TestKeyWithSlash;

        private readonly string _eastBucketName;
        private readonly string _westBucketName;

        private readonly AmazonS3Client _usEastClient;
        private readonly AmazonS3Client _usWestClient;

        public CopyObjectTests(CopyObjectTestsFixture fixture)
        {
            _usEastClient = fixture.UsEast1Client;
            _usWestClient = fixture.UsWest1Client;
            _eastBucketName = fixture.UsEast1BucketName;
            _westBucketName = fixture.UsWest1BucketName;
        }

        [Theory]
        [InlineData(testKey, testKey)]
        [InlineData("ObjectWithAllSpecialCharacters/'()!*$+,;=&", "DestinationObjectWithAllSpecialCharacters/'()!*$+,;=&")]
        public async Task TestCopyObject(string sourceKey, string destinationKey)
        {
            await _usEastClient.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _eastBucketName,
                Key = sourceKey,
                ContentBody = testContent
            });

            var response = await _usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = _eastBucketName,
                SourceKey = sourceKey,
                DestinationBucket = _westBucketName,
                DestinationKey = destinationKey
            });
            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);

            var getObjectResponse = await _usWestClient.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _westBucketName,
                Key = destinationKey
            });

            using (getObjectResponse.ResponseStream)
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var actualText = await reader.ReadToEndAsync();
                Assert.Equal(testContent, actualText);
            }
        }

        [Fact]
        public async Task TestCopyObjectWithTags()
        {
            await _usEastClient.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _eastBucketName,
                Key = testKeyWithTag,
                ContentBody = testContent,
                TagSet = new List<Tag>
                {
                    new Tag {Key = "foo", Value = "bar" },
                    new Tag { Key = "baz", Value = "qux" }
                }
            });
            
            await _usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = _eastBucketName,
                SourceKey = testKeyWithTag,
                DestinationBucket = _westBucketName,
                DestinationKey = testKeyWithTag,
            });

            var taggingMetadata = await _usWestClient.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _westBucketName,
                Key = testKeyWithTag
            });
            Assert.True(taggingMetadata.Tagging.Count == 2);
            Assert.True(taggingMetadata.Tagging.Any(tag => tag.Key == "foo" && tag.Value == "bar"));
            Assert.True(taggingMetadata.Tagging.Any(tag => tag.Key == "baz" && tag.Value == "qux"));
        }

        [Fact]
        public async Task TestCopyObjectWithTagsReplace()
        {
            await _usEastClient.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _eastBucketName,
                Key = testKeyWithTag,
                ContentBody = testContent,
                TagSet = new List<Tag>
                {
                    new Tag { Key = "foo", Value = "bar" },
                    new Tag { Key = "baz", Value = "qux" }
                }
            });

            await _usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = _eastBucketName,
                SourceKey = testKeyWithTag,
                DestinationBucket = _westBucketName,
                DestinationKey = testKeyWithTag,
                TaggingDirective = TaggingDirective.REPLACE,
                TagSet = new List<Tag>
                {
                    new Tag { Key = "newtag1", Value = "1" },
                }
            });

            var taggingMetadata = await _usWestClient.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = _westBucketName,
                Key = testKeyWithTag
            });
            Assert.True(taggingMetadata.Tagging.Count == 1);
            Assert.False(taggingMetadata.Tagging.Any(tag => tag.Key == "foo" && tag.Value == "bar"));
            Assert.False(taggingMetadata.Tagging.Any(tag => tag.Key == "baz" && tag.Value == "qux"));
            Assert.True(taggingMetadata.Tagging.Any(tag => tag.Key == "newtag1" && tag.Value == "1"));
        }

        [Theory]
        [InlineData(testKey, "destinationTestKey1.txt", "destinationTestKey1.txt")]
        [InlineData(testKeyWithSlash, "/destinationTestKey2.txt", "/destinationTestKey2.txt")]
        [InlineData(testKeyWithSlash, "/", "/")]
        public async Task TestCopyObjectWithLeadingSlash(string sourceKey, string destinationKey, string expectedKey)
        {
            var copyObjectResponse = await _usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = _eastBucketName,
                SourceKey = sourceKey,
                DestinationBucket = _westBucketName,
                DestinationKey = destinationKey,
            });
            Assert.Equal(HttpStatusCode.OK, copyObjectResponse.HttpStatusCode);

            var getObjectResponse = await _usWestClient.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _westBucketName,
                Key = expectedKey
            });

            using (getObjectResponse.ResponseStream)
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var actualText = await reader.ReadToEndAsync();
                Assert.Equal(testContent, actualText);
            }
        }

        [Theory]
        [InlineData(testKey, true, "/destinationTestKey1.txt", true, null)]
        [InlineData(null, true, "/destinationTestKey1.txt", true, "CopyObjectRequest.SourceKey")]
        [InlineData(testKey, false, "/destinationTestKey1.txt", true, "CopyObjectRequest.SourceBucket")]
        [InlineData(testKey, true, null, true, "CopyObjectRequest.DestinationKey")]
        [InlineData(testKey, true, "/destinationTestKey1.txt", false, "CopyObjectRequest.DestinationBucket")]
        public async Task TestCopyObjectWithMissingParameters(string sourceKey, bool includeSourceBucket, string destinationKey, bool includeDestinationBucket, string expectedMissingParameter)
        {
            string missingParameter = null;
            try
            {
                await _usEastClient.CopyObjectAsync(new CopyObjectRequest
                {
                    SourceKey = sourceKey,
                    SourceBucket = includeSourceBucket ? _eastBucketName : null,
                    DestinationKey = destinationKey,
                    DestinationBucket = includeDestinationBucket ? _eastBucketName : null,
                });
            }
            catch (ArgumentException ex)
            {
                missingParameter = ex.ParamName;
            }
            Assert.Equal(missingParameter, expectedMissingParameter);
        }
    }
}
