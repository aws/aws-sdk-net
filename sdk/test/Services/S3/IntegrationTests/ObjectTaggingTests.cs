using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class ObjectTaggingTest : TestBase<AmazonS3Client>
    {
        private const char iUmlautChar = (char)0x00EF;
        private const string TestObjectKey = "testObjectKey";
        private const string TestObjectContent = "content";
        private static string bucketName;
        private static string tempFilePath;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext a)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            
            tempFilePath = Path.GetTempFileName();
            UtilityMethods.GenerateFile(tempFilePath, 1024 * 1024 * 20);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            if (File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }

            BaseClean();
        }

        [TestMethod]
        public async Task TagBucket()
        {
            await Client.PutBucketTaggingAsync(new PutBucketTaggingRequest
            {
                BucketName = bucketName,
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
                var res = await Client.GetBucketTaggingAsync(new GetBucketTaggingRequest { BucketName = bucketName });
                return res.TagSet?.FirstOrDefault(x => string.Equals(x.Key, "TagBucketKey")) != null ? res.TagSet : null;
            });

            var tag = tags.FirstOrDefault(x => string.Equals(x.Key, "TagBucketKey"));
            Assert.IsNotNull(tag);
            Assert.AreEqual("TagBucketValue", tag.Value);
        }

        [TestMethod]
        public async Task TagWithUnicodeKey()
        {
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey,
                ContentBody = TestObjectContent,
                TagSet = new List<Tag> { new Tag { Key = "key" + iUmlautChar, Value = "value" } }
            });

            var response = await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey
            });

            Assert.AreEqual(response.Tagging[0].Key, "key" + iUmlautChar);
            Assert.AreEqual(response.Tagging[0].Value, "value");
        }

        [TestMethod]
        public async Task TagWithUnicodeValue()
        {
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey,
                ContentBody = TestObjectContent,
                TagSet = new List<Tag> { new Tag { Key = "key", Value = "value" + iUmlautChar } }
            });

            var response = await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey
            });

            Assert.AreEqual(response.Tagging[0].Key, "key");
            Assert.AreEqual(response.Tagging[0].Value, "value" + iUmlautChar);
        }

        [TestMethod]
        public async Task GetObjectTaggingWithVersionTest()
        {
            string key = "getobjectWithVersions";
            await EnableBucketVersioning();
            
            var putResponseV = await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello",
                TagSet = new List<Tag>
                {
                    new Tag { Key = "k", Value = "v" }
                }
            });
            var metadataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });
            Assert.AreEqual(putResponseV.VersionId, metadataResponse.VersionId);

            var putResponseV2 = await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello2",
                TagSet = new List<Tag>
                {
                    new Tag { Key = "k", Value = "v2" }
                }
            });
            var metadataResponse2 = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });
            Assert.AreEqual(putResponseV2.VersionId, metadataResponse2.VersionId);

            var taggingResponse = await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                VersionId = metadataResponse.VersionId
            });
            Assert.AreEqual("v", taggingResponse.Tagging[0].Value);

            taggingResponse = await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key
            });
            Assert.AreEqual("v2", taggingResponse.Tagging[0].Value);
        }

        [TestMethod]
        public async Task PutObjectTaggingWithVersionTest()
        {
            string key = "putobjectWithVersions";
            await EnableBucketVersioning();

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello"
            });
            var metadataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello2"
            });
            var metadataResponse2 = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });

            await Client.PutObjectTaggingAsync(new PutObjectTaggingRequest
            {
                BucketName = bucketName,
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

            await Client.PutObjectTaggingAsync(new PutObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                Tagging = new Tagging
                {
                    TagSet = new List<Tag>
                    {
                        new Tag { Key = "key", Value = "Value2" }
                    },
                }
            });

            var taggingResponse = await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                VersionId = metadataResponse.VersionId
            });
            Assert.AreEqual("Value", taggingResponse.Tagging[0].Value);

            taggingResponse = await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                VersionId = metadataResponse2.VersionId
            });
            Assert.AreEqual("Value2", taggingResponse.Tagging[0].Value);
        }

        [TestMethod]
        public async Task MultipartObjectTaggingTest()
        {
            var transferClient = new TransferUtility(Client);
            var objectKey = $"multipart-tagging-{Guid.NewGuid()}";

            await transferClient.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = tempFilePath,
                TagSet = new List<Tag>
                {
                    new Tag { Key = "hello", Value = "world" }
                }
            });

            var response = await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = objectKey
            });
            Assert.AreEqual(response.Tagging.Count, 1);
            Assert.AreEqual(response.Tagging[0].Key, "hello");
            Assert.AreEqual(response.Tagging[0].Value, "world");
        }

        private async Task EnableBucketVersioning()
        {
            await Client.PutBucketVersioningAsync(new PutBucketVersioningRequest
            {
                BucketName = bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

            // Wait for versioning to be set on the bucket or multiple PutObject with the same key may not add a new version
            await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketVersioningAsync(new GetBucketVersioningRequest
                {
                    BucketName = bucketName
                });
                return res.VersioningConfig?.Status == VersionStatus.Enabled ? res : null;
            });
        }
    }
}