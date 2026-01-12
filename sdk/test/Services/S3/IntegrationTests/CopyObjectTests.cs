using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class CopyObjectTests : TestBase<AmazonS3Client>
    {
        private const string testContent = "This is the content body!";
        private const string testKey = "testKey.txt";
        private const string testKeyWithTag = "testKeyWithTag.txt";
        private const string testKeyWithSlash = "/sourceTestKey.txt";

        private string eastBucketName;
        private string westBucketName;

        private AmazonS3Client usEastClient;
        private AmazonS3Client usWestClient;

        [TestInitialize]
        public async Task Initialize()
        {
            usEastClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            eastBucketName = await S3TestUtils.CreateBucketWithWaitAsync(usEastClient);

            usEastClient.PutObject(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = testKey,
                ContentBody = testContent
            });

            usEastClient.PutObject(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = testKeyWithSlash,
                ContentBody = testContent
            });

            usWestClient = new AmazonS3Client(RegionEndpoint.USWest1);
            westBucketName = await S3TestUtils.CreateBucketWithWaitAsync(usWestClient);
        }

        [TestCleanup]
        public async Task TestCleanup()
        {
            if (usEastClient != null)
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(usEastClient, eastBucketName);
                usEastClient.Dispose();
            }

            if (usWestClient != null)
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(usWestClient, westBucketName);
                usWestClient.Dispose();
            }
            
            BaseClean();
        }

        [DataTestMethod]
        [DataRow(testKey, testKey)]
        [DataRow("ObjectWithAllSpecialCharacters/'()!*$+,;=&", "DestinationObjectWithAllSpecialCharacters/'()!*$+,;=&")]
        public async Task TestCopyObject(string sourceKey, string destinationKey)
        {
            await usEastClient.PutObjectAsync(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = sourceKey,
                ContentBody = testContent
            });

            var response = await usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = sourceKey,
                DestinationBucket = westBucketName,
                DestinationKey = destinationKey
            });
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);

            var getObjectResponse = await usWestClient.GetObjectAsync(new GetObjectRequest
            {
                BucketName = westBucketName,
                Key = destinationKey
            });

            using (getObjectResponse.ResponseStream)
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var actualText = await reader.ReadToEndAsync();
                Assert.AreEqual(testContent, actualText);
            }
        }

        [TestMethod]
        public async Task TestCopyObjectWithTags()
        {
            await usEastClient.PutObjectAsync(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = testKeyWithTag,
                ContentBody = testContent,
                TagSet = new List<Tag>
                {
                    new Tag {Key = "foo", Value = "bar" },
                    new Tag { Key = "baz", Value = "qux" }
                }
            });
            
            await usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = testKeyWithTag,
                DestinationBucket = westBucketName,
                DestinationKey = testKeyWithTag,
            });

            var taggingMetadata = await usWestClient.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = westBucketName,
                Key = testKeyWithTag
            });
            Assert.IsTrue(taggingMetadata.Tagging.Count == 2);
            Assert.IsTrue(taggingMetadata.Tagging.Any(tag => tag.Key == "foo" && tag.Value == "bar"));
            Assert.IsTrue(taggingMetadata.Tagging.Any(tag => tag.Key == "baz" && tag.Value == "qux"));
        }

        [TestMethod]
        public async Task TestCopyObjectWithTagsReplace()
        {
            await usEastClient.PutObjectAsync(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = testKeyWithTag,
                ContentBody = testContent,
                TagSet = new List<Tag>
                {
                    new Tag { Key = "foo", Value = "bar" },
                    new Tag { Key = "baz", Value = "qux" }
                }
            });

            await usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = testKeyWithTag,
                DestinationBucket = westBucketName,
                DestinationKey = testKeyWithTag,
                TaggingDirective = TaggingDirective.REPLACE,
                TagSet = new List<Tag>
                {
                    new Tag { Key = "newtag1", Value = "1" },
                }

            });

            var taggingMetadata = await usWestClient.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = westBucketName,
                Key = testKeyWithTag
            });
            Assert.IsTrue(taggingMetadata.Tagging.Count == 1);
            Assert.IsFalse(taggingMetadata.Tagging.Any(tag => tag.Key == "foo" && tag.Value == "bar"));
            Assert.IsFalse(taggingMetadata.Tagging.Any(tag => tag.Key == "baz" && tag.Value == "qux"));
            Assert.IsTrue(taggingMetadata.Tagging.Any(tag => tag.Key == "newtag1" && tag.Value == "1"));
        }

        [DataRow(testKey, "destinationTestKey1.txt", "destinationTestKey1.txt")]
        [DataRow(testKeyWithSlash, "/destinationTestKey2.txt", "/destinationTestKey2.txt")]
        [DataRow(testKeyWithSlash, "/", "/")]
        [DataTestMethod]
        public async Task TestCopyObjectWithLeadingSlash(string sourceKey, string destinationKey, string expectedKey)
        {
            var copyObjectResponse = await usEastClient.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = sourceKey,
                DestinationBucket = westBucketName,
                DestinationKey = destinationKey,

            });
            Assert.AreEqual(HttpStatusCode.OK, copyObjectResponse.HttpStatusCode);

            var getObjectResponse = await usWestClient.GetObjectAsync(new GetObjectRequest
            {
                BucketName = westBucketName,
                Key = expectedKey
            });

            using (getObjectResponse.ResponseStream)
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var actualText = await reader.ReadToEndAsync();
                Assert.AreEqual(testContent, actualText);
            }
        }

        [DataRow(testKey, true, "/destinationTestKey1.txt", true, null)]
        [DataRow(null, true, "/destinationTestKey1.txt", true, "CopyObjectRequest.SourceKey")]
        [DataRow(testKey, false, "/destinationTestKey1.txt", true, "CopyObjectRequest.SourceBucket")]
        [DataRow(testKey, true, null, true, "CopyObjectRequest.DestinationKey")]
        [DataRow(testKey, true, "/destinationTestKey1.txt", false, "CopyObjectRequest.DestinationBucket")]
        [DataTestMethod]
        public async Task TestCopyObjectWithMissingParameters(string sourceKey, bool includeSourceBucket, string destinationKey, bool includeDestinationBucket, string expectedMissingParameter)
        {
            string missingParameter = null;
            try
            {
                await usEastClient.CopyObjectAsync(new CopyObjectRequest
                {
                    SourceKey = sourceKey,
                    SourceBucket = includeSourceBucket ? eastBucketName : null,
                    DestinationKey = destinationKey,
                    DestinationBucket = includeDestinationBucket ? eastBucketName : null,
                });
            }
            catch (ArgumentException ex)
            {
                missingParameter = ex.ParamName;
            }
            Assert.AreEqual(missingParameter, expectedMissingParameter);
        }
    }
}
