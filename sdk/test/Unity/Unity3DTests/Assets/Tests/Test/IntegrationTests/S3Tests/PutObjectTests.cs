using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(PutObjectTests))]
    [Category("Integration")]
    public class PutObjectTests : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private Random random = new Random();
        private static string bucketName;
        private const string testContent = "This is the content body!";
        private static string relativeFilePath;

        [OneTimeSetUp]
        public void Initialize()
        {
            relativeFilePath = S3TestUtils.GetFileHelper("PutObjectFile.txt");
            
            using (StreamWriter writer = File.CreateText(relativeFilePath))
            {
                writer.Write("This is some sample text.!!");
                writer.Close();
            }
            bucketName = "unity-test-bucket" + DateTime.Now.Ticks;

            AutoResetEvent ars = new AutoResetEvent(false);
            Exception exception = null;
            Client.PutBucketAsync(bucketName, (result) =>
            {
                if (result.Exception != null)
                    exception = result.Exception;

                ars.Set();
            });

            ars.WaitOne();
            if (exception != null)
                throw exception;

        }

        [OneTimeTearDown]
        public void ClassCleanup()
        {
            S3TestUtils.DeleteBucketWithObjects(Client, bucketName);
        }

        [Test]
        [Category("S3")]
        public void SimplePutTest()
        {
            GetBucketVersioningResponse versioning = null;
            Exception exception = null;
            var mre = new AutoResetEvent(false);

            Client.GetBucketVersioningAsync(bucketName, (result) =>
            {
                versioning = result.Response;
                exception = result.Exception;
                mre.Set();
            }, options);
            mre.WaitOne();
            Assert.IsNull(exception);

            var status = versioning.VersioningConfig.Status;
            Assert.AreEqual(VersionStatus.Off, status);

            ListObjectsResponse response = null;
            Client.ListObjectsAsync(bucketName, (result) =>
            {
                exception = result.Exception;
                response = result.Response;
                mre.Set();
            }, options);
            mre.WaitOne();
            Assert.IsNull(exception);

            var objects = response.S3Objects;
            Assert.IsNotNull(objects);
            var count = objects.Count;

            var key = "test.txt";
            var contents = "Sample content";
            PutObjectResponse putResult = null;
            Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = contents
            }, (result) =>
            {
                exception = result.Exception;
                putResult = result.Response;
                mre.Set();
            }, options);
            mre.WaitOne();
            Assert.IsNull(exception);

            var etag = putResult.ETag;
            Assert.IsNotNull(etag);

            Client.ListObjectsAsync(bucketName, (result) =>
            {
                exception = result.Exception;
                response = result.Response;
                mre.Set();
            }, options);

            mre.WaitOne();
            Assert.IsNull(exception);

            objects = response.S3Objects;
            Assert.IsNotNull(objects);
            Assert.AreEqual(count + 1, objects.Count);

            GetObjectMetadataResponse metadataResult = null;
            Client.GetObjectMetadataAsync(bucketName, key, (result) =>
            {
                metadataResult = result.Response;
                exception = result.Exception;
                mre.Set();

            }, options);

            mre.WaitOne();
            Assert.IsNull(exception);

            Assert.AreEqual(etag, metadataResult.ETag);


            Client.DeleteObjectAsync(bucketName, key, (result) =>
            {
                exception = result.Exception;
                mre.Set();

            }, options);
            mre.WaitOne();
            Assert.IsNull(exception);

            Client.ListObjectsAsync(bucketName, (result) =>
            {
                exception = result.Exception;
                objects = result.Response.S3Objects;
                mre.Set();
            }, options);

            mre.WaitOne();
            Assert.IsNull(exception);

            Assert.IsNotNull(objects);
            Assert.AreEqual(count, objects.Count);

        }

        [Test]
        [Category("S3")]
        public void TestHttpErrorResponseUnmarshalling()
        {
            var exception = new AmazonServiceException();
            var mre = new AutoResetEvent(false);

            Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = UtilityMethods.GenerateName("NonExistentBucket"),
                Key = "1",
                ContentBody = "TestContent"
            }, (result) =>
            {
                exception = result.Exception as AmazonServiceException;
                mre.Set();
            }, new AsyncOptions() { ExecuteCallbackOnMainThread = false });
            mre.WaitOne();
            Assert.IsNotNull(exception);
            Assert.IsTrue(exception.Message.Contains("The specified bucket does not exist"));
            Assert.AreEqual("NoSuchBucket", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        [Category("S3")]
        public void SimplePutObjectTest()
        {
            var exception = new AmazonServiceException();
            var mre = new AutoResetEvent(false);
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            PutObjectResponse response = null;
            Client.PutObjectAsync(request, (result) =>
            {
                exception = result.Exception as AmazonServiceException;
                response = result.Response;
                mre.Set();
            }, options);
            mre.WaitOne();
            
            Assert.IsTrue(response.ETag.Length > 0);
        }

        [Test]
        [Category("S3")]
        public void SimplePathPutObjectTest()
        {
            var exception = new AmazonServiceException();
            var mre = new AutoResetEvent(false);
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                FilePath = relativeFilePath,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            PutObjectResponse response = null;
            Client.PutObjectAsync(request, (result) =>
            {   
                exception = result.Exception as AmazonServiceException;
                response = result.Response;
                mre.Set();
            }, options);
            mre.WaitOne();
            Assert.IsNull(exception);
            Assert.IsTrue(response.ETag.Length > 0);
        }

    }
}
