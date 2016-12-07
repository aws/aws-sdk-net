using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class ObjecTaggingTest : TestBase<AmazonS3Client>
    {
        private static string bucketName;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucket(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectTaggingWithVersionTest()
        {
            string key = "getobjectWithVersions";

            //
            // Set up the test by uploading mulitple versions of an object
            //

            Client.PutBucketVersioning(new PutBucketVersioningRequest{
                BucketName = bucketName,
                VersioningConfig = new S3BucketVersioningConfig{
                    Status = VersionStatus.Enabled
                }
            });

            Client.PutObject(new PutObjectRequest{
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

            Client.PutObject(new PutObjectRequest
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

            //
            // Verify that object tagging are correctly associated with the version
            //

            var taggingResponse = Client.GetObjectTagging(new GetObjectTaggingRequest{
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

            Client.PutBucketVersioning(new PutBucketVersioningRequest
            {
                BucketName = bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

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

            Client.PutObjectTagging(new PutObjectTaggingRequest{
                BucketName = bucketName,
                Key = key,
                Tagging = {
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
                Tagging = {
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
    }
}