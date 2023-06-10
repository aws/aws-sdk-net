using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class GetObjectTests : TestBase<AmazonS3Client>
    {
        private const string content = "0123456789";
        private static string bucketName;

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);

            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = content,
                Key = "TestObject"
            });
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }


        [TestMethod]
        [TestCategory("S3")]
        public void TestRangedGetWithStartAndEnd()
        {
            var response = Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                ByteRange = new ByteRange(1, 5),
                Key = "TestObject"
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = reader.ReadToEnd();
                    Assert.AreEqual("12345", text);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRangedGetWithByteRange()
        {
            var response = Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                ByteRange = new ByteRange("bytes=-2"),
                Key = "TestObject"
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = reader.ReadToEnd();
                    Assert.AreEqual("89", text);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestObjectAttributesLastModified()
        {
            var getObjectAttributesResponse = Client.GetObjectAttributes(new GetObjectAttributesRequest
            {
                BucketName = bucketName,
                Key = "TestObject",
                ObjectAttributes = new List<ObjectAttributes> { ObjectAttributes.ObjectSize }
            });

            var getObjectMetadataResponse = Client.GetObjectMetadata(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = "TestObject"
            });

            Assert.AreNotEqual(getObjectAttributesResponse.LastModified, DateTime.MinValue);
            Assert.AreEqual(getObjectAttributesResponse.LastModified, getObjectMetadataResponse.LastModified);
        }
    }
}