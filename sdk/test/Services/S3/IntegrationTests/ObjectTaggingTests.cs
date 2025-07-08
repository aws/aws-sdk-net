using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Amazon.S3.Transfer;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class ObjecTaggingTest : TestBase<AmazonS3Client>
    {
        private const char iUmlautChar = (char)0x00EF;
        private const string TestObjectKey = "testObjectKey";
        private const string TestObjectContent = "content";

        private static string bucketName;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TagBucket()
        {
            var request = new PutBucketTaggingRequest
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
            };

            Client.PutBucketTagging(request);
                        
            var tags = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketTagging(new GetBucketTaggingRequest { BucketName = bucketName });
                return res.TagSet?.FirstOrDefault(x => string.Equals(x.Key, "TagBucketKey")) != null ? res.TagSet : null;
            });

            var tag = tags.FirstOrDefault(x => string.Equals(x.Key, "TagBucketKey"));
            Assert.IsNotNull(tag);
            Assert.AreEqual("TagBucketValue", tag.Value);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TagWithUnicodeKey()
        {
            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey,
                ContentBody = TestObjectContent,
                TagSet = new List<Tag> { new Tag { Key = "key" + iUmlautChar, Value = "value" } }
            });

            var response = Client.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey
            });

            Assert.AreEqual(response.Tagging[0].Key, "key" + iUmlautChar);
            Assert.AreEqual(response.Tagging[0].Value, "value");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TagWithUnicodeValue()
        {
            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey,
                ContentBody = TestObjectContent,
                TagSet = new List<Tag> { new Tag { Key = "key", Value = "value" + iUmlautChar } }
            });

            var response = Client.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = TestObjectKey
            });

            Assert.AreEqual(response.Tagging[0].Key, "key");
            Assert.AreEqual(response.Tagging[0].Value, "value" + iUmlautChar);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectTaggingWithVersionTest()
        {
            string key = "getobjectWithVersions";

            //
            // Set up the test by uploading mulitple versions of an object
            //
            EnableBucketVersioning();
            
            var putResponseV = Client.PutObject(new PutObjectRequest{
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello",
                TagSet = new List<Tag>{
                    new Tag {Key = "k", Value="v"}
                }
            });

            var metadataResponse = Client.GetObjectMetadata(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });

            Assert.AreEqual(putResponseV.VersionId, metadataResponse.VersionId);

            var putResponseV2 = Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello2",
                TagSet = new List<Tag>
                {
                    new Tag{Key="k", Value="v2"}
                }
            });

            var metadataResponse2 = Client.GetObjectMetadata(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });

            Assert.AreEqual(putResponseV2.VersionId, metadataResponse2.VersionId);

            //
            // Verify that object tagging are correctly associated with the version
            //

            var taggingResponse = Client.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                VersionId = metadataResponse.VersionId
            });

            Assert.AreEqual("v", taggingResponse.Tagging[0].Value);

            taggingResponse = Client.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key
            });

            Assert.AreEqual("v2", taggingResponse.Tagging[0].Value);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectTaggingWithVersionTest()
        {
            string key = "putobjectWithVersions";

            //
            // Set up the test by uploading mulitple versions of an object
            //

            EnableBucketVersioning();

            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello"
            });

            var metadataResponse = Client.GetObjectMetadata(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });

            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "hello2"
            });
            
            var metadataResponse2 = Client.GetObjectMetadata(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });


            //
            // Put tagging for each version of the object
            //

            Client.PutObjectTagging(new PutObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                Tagging = new Tagging
                {
                    TagSet = new List<Tag>{
                        new Tag{ Key = "key", Value = "Value"}
                    }
                },
                VersionId = metadataResponse.VersionId
            });

            Client.PutObjectTagging(new PutObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                Tagging = new Tagging
                {
                    TagSet = new List<Tag>{
                        new Tag{ Key = "key", Value = "Value2"}
                    },
                }
            });


            //
            // Verify that object tagging are correctly associated with the version
            //

            var taggingResponse = Client.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                VersionId = metadataResponse.VersionId
            });

            Assert.AreEqual("Value", taggingResponse.Tagging[0].Value);

            taggingResponse = Client.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = key,
                VersionId = metadataResponse2.VersionId
            });

            Assert.AreEqual("Value2", taggingResponse.Tagging[0].Value);
        }

        private void EnableBucketVersioning()
        {
            Client.PutBucketVersioning(new PutBucketVersioningRequest
            {
                BucketName = bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

            //Wait for versioning to be set on the bucket or multiple PutObject with the same key may not add a new version
            S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketVersioning(new GetBucketVersioningRequest
                {
                    BucketName = bucketName
                });
                return res.VersioningConfig?.Status == VersionStatus.Enabled ? res : null;
            });
        }
    }

    [TestClass]
    public class MultipartTaggingTest : TestBase<AmazonS3Client>
    {
        private string tempFilePath;
        private string bucketName;
        private string objectKey = "helloworld";

        private TransferUtility transferClient;

        [TestInitialize]
        public void TestInitialize()
        {
            transferClient = new TransferUtility(Client);

            tempFilePath = System.IO.Path.GetTempFileName();
            bucketName = S3TestUtils.CreateBucketWithWait(Client);

            UtilityMethods.GenerateFile(tempFilePath, 1024 * 1024 * 20);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            try
            {
                if (File.Exists(tempFilePath)) File.Delete(tempFilePath);
            }
            finally{};

            try
            {
                AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            }
            finally{};
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MultipartObjectTaggingTest()
        {

            transferClient.Upload(new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                FilePath = tempFilePath,
                TagSet = new List<Tag>
                {
                    new Tag{Key = "hello", Value="world"}
                }
            });

            var response = Client.GetObjectTagging(new GetObjectTaggingRequest
            {
                BucketName = bucketName,
                Key = objectKey
            });

            Assert.AreEqual(response.Tagging.Count, 1);
            Assert.AreEqual(response.Tagging[0].Key, "hello");
            Assert.AreEqual(response.Tagging[0].Value, "world");
        }
    }
}