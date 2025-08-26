using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.Util;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class MultipartUploadTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;
        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client, true);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        /// <summary>
        /// Test so that no regression happens like the one reported below.
        /// https://github.com/aws/aws-sdk-net/issues/3971 
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestInitiateMultipartUploadWithNoACL()
        {
            var initMpuResponse = Client.InitiateMultipartUpload(new InitiateMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = "test-mpu",
                StorageClass = S3StorageClass.Standard,
                CannedACL = S3CannedACL.NoACL
            });
            Assert.AreEqual<HttpStatusCode>(initMpuResponse.HttpStatusCode, HttpStatusCode.OK);
            if (initMpuResponse.UploadId != null)
            {
                Client.AbortMultipartUpload(new AbortMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = "test-mpu",
                    UploadId = initMpuResponse.UploadId
                });
            }

        }
    }
}
