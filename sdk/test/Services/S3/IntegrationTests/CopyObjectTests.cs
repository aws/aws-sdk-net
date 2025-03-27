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

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
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
        public void Initialize()
        {
            usEastClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            eastBucketName = S3TestUtils.CreateBucketWithWait(usEastClient);

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
            westBucketName = S3TestUtils.CreateBucketWithWait(usWestClient);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (usEastClient != null)
            {
                AmazonS3Util.DeleteS3BucketWithObjects(usEastClient, eastBucketName);
                usEastClient.Dispose();
            }

            if (usWestClient != null)
            {
                AmazonS3Util.DeleteS3BucketWithObjects(usWestClient, westBucketName);
                usWestClient.Dispose();
            }
            
            BaseClean();
        }
        [DataTestMethod]
        [DataRow(testKey, testKey)]
        [DataRow("ObjectWithAllSpecialCharacters/'()!*$+,;=&", "DestinationObjectWithAllSpecialCharacters/'()!*$+,;=&")]
        [TestCategory("S3")]
        public void TestCopyObject(string sourceKey, string destinationKey)
        {
            var putObjectResponse = usEastClient.PutObject(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = sourceKey,
                ContentBody = testContent
            });
            var response = usEastClient.CopyObject(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = sourceKey,
                DestinationBucket = westBucketName,
                DestinationKey = destinationKey
            });

            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);

            var getObjectResponse = usWestClient.GetObject(new GetObjectRequest
            {
                BucketName = westBucketName,
                Key = destinationKey
            });

            using (getObjectResponse.ResponseStream)
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var actualText = reader.ReadToEnd();
                Assert.AreEqual(testContent, actualText);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestCopyObjectWithTags()
        {
            usEastClient.PutObject(new PutObjectRequest
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
            var response = usEastClient.CopyObject(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = testKeyWithTag,
                DestinationBucket = westBucketName,
                DestinationKey = testKeyWithTag,
            });
            var taggingMetadata = usWestClient.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = westBucketName,
                Key = testKeyWithTag
            });
            Assert.IsTrue(taggingMetadata.Tagging.Count == 2);
            Assert.IsTrue(taggingMetadata.Tagging.Any(tag => tag.Key == "foo" && tag.Value == "bar"));
            Assert.IsTrue(taggingMetadata.Tagging.Any(tag => tag.Key == "baz" && tag.Value == "qux"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestCopyObjectWithTagsReplace()
        {
            usEastClient.PutObject(new PutObjectRequest
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
            var response = usEastClient.CopyObject(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = testKeyWithTag,
                DestinationBucket = westBucketName,
                DestinationKey = testKeyWithTag,
                TaggingDirective = TaggingDirective.REPLACE,
                TagSet = new List<Tag>
                {
                    new Tag {Key = "newtag1", Value = "1" },
                }

            });
            var taggingMetadata = usWestClient.GetObjectTagging(new GetObjectTaggingRequest
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
        [TestCategory("S3")]
        public void TestCopyObjectWithLeadingSlash(string sourceKey, string destinationKey, string expectedKey)
        {
            var copyObjectResponse = usEastClient.CopyObject(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = sourceKey,

                DestinationBucket = westBucketName,
                DestinationKey = destinationKey,

            });
            Assert.AreEqual(HttpStatusCode.OK, copyObjectResponse.HttpStatusCode);

            var getObjectResponse = usWestClient.GetObject(new GetObjectRequest
            {
                BucketName = westBucketName,
                Key = expectedKey
            });

            using (getObjectResponse.ResponseStream)
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var actualText = reader.ReadToEnd();
                Assert.AreEqual(testContent, actualText);
            }
        }

        [DataRow(testKey, true, "/destinationTestKey1.txt", true, null)]
        [DataRow(null, true, "/destinationTestKey1.txt", true, "CopyObjectRequest.SourceKey")]
        [DataRow(testKey, false, "/destinationTestKey1.txt", true, "CopyObjectRequest.SourceBucket")]
        [DataRow(testKey, true, null, true, "CopyObjectRequest.DestinationKey")]
        [DataRow(testKey, true, "/destinationTestKey1.txt", false, "CopyObjectRequest.DestinationBucket")]
        [DataTestMethod]
        [TestCategory("S3")]
        public void TestCopyObjectWithMissingParameters(string sourceKey, bool includeSourceBucket, string destinationKey, bool includeDestinationBucket, string expectedMissingParameter)
        {
            string missingParameter = null;
            try
            {
                var copyObjectResponse = usEastClient.CopyObject(new CopyObjectRequest
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
