using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using AWSSDK.Tests.Framework;
using System.IO;

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(PostObjectTests))]
    [Category("Integration")]
    class PostObjectTests : TestBase<AmazonS3Client>
    {
        private static readonly string FileNamePrefix = "UnityTestFile";
        private static readonly string FileNameFormat = FileNamePrefix + "{0}.txt";
        // TODO: get from settings
        private static readonly string BucketName = "jonahoff-sample-bucket";

       // [Test]
        public void SimpleTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            VersionStatus status = null;
            Client.GetBucketVersioningAsync(new GetBucketVersioningRequest()
            {
                BucketName = BucketName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    status = response.Response.VersioningConfig.Status;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(VersionStatus.Off, status);
            List<S3Object> s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            var count = s3Objects.Count;

            var key = string.Format(FileNameFormat, DateTime.Now.Ticks);
            S3TestUtils.PostObjectHelper(Client, BucketName, key);

            s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            Assert.AreEqual(count + 1, s3Objects.Count);

            Client.DeleteObjectsAsync(new DeleteObjectsRequest()
            {
                BucketName = BucketName,
                Objects = new List<KeyVersion> { new KeyVersion() { Key = key } }
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            Assert.AreEqual(count, s3Objects.Count);
        }

        //[Test]
        // TODO: fix null reference for status code.
        public void TestHttpErrorResponseUnmarshalling()
        {
            try
            {
                S3TestUtils.PostObjectHelper(Client, "NonExistentBucket" + DateTime.Now.Ticks, "key");
            }
            catch (Amazon.Runtime.Internal.HttpErrorResponseException exception)
            {
                Assert.AreEqual(HttpStatusCode.Forbidden, exception.Response.StatusCode);
                return;
            };
            Assert.Fail();
        }

        //[Test]
        // TODO: Get Post object with path working
        public void SimplePathPostObjectTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string fileName = string.Format(FileNameFormat, "");
            S3TestUtils.GetFileHelper(fileName);
            Client.PostObjectAsync(new PostObjectRequest()
            {
                Bucket = BucketName,
                Path = fileName,
                CannedACL = S3CannedACL.Private
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });

            ars.WaitOne();
            Assert.IsNull(responseException);
        }

    }
}
