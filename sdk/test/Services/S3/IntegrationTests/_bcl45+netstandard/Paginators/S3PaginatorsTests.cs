using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class S3PaginatorsTests : TestBase<AmazonS3Client>
    {
        public const string BasePath = @"c:\temp\test\paginators\";

        private static string _bucketName;
        private static string _fullPath;
        private static Random _random = new Random();
        private static int _num = _random.Next(2, 1000);
        private const string _testContent = "This is the content body!";
        private const string _testFile = "testFile";
        

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _bucketName = S3TestUtils.CreateBucketWithWait(Client);
            _fullPath = Path.GetFullPath(_testFile);
            File.WriteAllText(_fullPath, _testContent);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, _bucketName);
            BaseClean();
            if (Directory.Exists(BasePath))
            {
                Directory.Delete(BasePath, true);
            }
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(1000)]
        public void ListMultipartUploadsTest(int maxUploads)
        {
            try
            {
                // hacky way to get the test to accept a random int as a parameter
                if (maxUploads != 1)
                {
                    maxUploads = _num;
                }
                AmazonS3Util.DeleteS3BucketWithObjects(Client, _bucketName);
                _bucketName = S3TestUtils.CreateBucketWithWait(Client);
                var count = 0;
                for (var x = 0; x < 50; x++)
                {
                    CreateMultipartUpload(x);
                }
                var request = new ListMultipartUploadsRequest
                {
                    BucketName = _bucketName,
                    MaxUploads = maxUploads
                };
                var paginator = Client.Paginators.ListMultipartUploads(request);
                foreach (var upload in paginator.Uploads)
                {
                    // uploads are listed in alphabetical order
                    // with 10 before 2 so not validating
                    // exact name of file
                    ValidateMultipartUpload(upload);
                    count++;
                }
                Assert.AreEqual(50, count);
            }
            catch
            {
                Assert.Fail();
            }
            
        }

        internal void CreateMultipartUpload(int num)
        {
            var client = Client;
            var request = new InitiateMultipartUploadRequest
            {
                BucketName = _bucketName,
                Key = $"{_testFile}{num}"
            };
            client.InitiateMultipartUpload(request);
        }

        internal void ValidateMultipartUpload(MultipartUpload upload)
        {
            Assert.AreEqual($"testFile", upload.Key.Substring(0, 8));
            Assert.IsTrue(int.Parse(upload.Key.Substring(8)) < 50);
        }

    }
}
