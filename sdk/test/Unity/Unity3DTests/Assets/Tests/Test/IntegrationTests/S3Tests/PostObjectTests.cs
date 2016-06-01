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
using UnityEngine;
using Amazon.Runtime.Internal;
using Amazon.Util;

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(PostObjectTests))]
    [Category("Integration")]
    class PostObjectTests : TestBase<AmazonS3Client>
    {
        private static readonly string FileNamePrefix = "UnityTestFile";
        private static readonly string FileNameFormat = FileNamePrefix + "{0}.txt";
        private static readonly string GzipFileNameFormat = FileNamePrefix + "{0}.gz";
        private static string BucketName = null;
        private static string VersionedBucketName = null;

        private static readonly string AuthenticatedUsersUriSubstring = "acs.amazonaws.com/groups/global/AuthenticatedUsers";
        private static readonly string AllUsersUriSubstring = "acs.amazonaws.com/groups/global/AuthenticatedUsers";
        private static readonly string LogDeliveryUriSubstring = "acs.amazonaws.com/groups/global/AuthenticatedUsers";

        [OneTimeSetUp]
        public void SetUp()
        {
            BucketName = "unity-test-bucket" + DateTime.Now.Ticks;
            VersionedBucketName = "unity-test-bucket-versioned" + DateTime.Now.Ticks;
            MissingAPILambdaFunctions.CreateBucket(BucketName, TestRunner.RegionEndpoint);
            MissingAPILambdaFunctions.CreateBucket(VersionedBucketName, TestRunner.RegionEndpoint);
            MissingAPILambdaFunctions.EnableBucketVersioning(VersionedBucketName, TestRunner.RegionEndpoint);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            S3TestUtils.CleanBucket(Client, BucketName);
            MissingAPILambdaFunctions.DeleteBucket(BucketName, TestRunner.RegionEndpoint);
            S3TestUtils.CleanBucket(Client, VersionedBucketName);
            MissingAPILambdaFunctions.DeleteBucket(VersionedBucketName, TestRunner.RegionEndpoint);
        }

        [Test]
        [Category("WWW")]
        public void SimplePostTest()
        {
            string originalSigV = Client.Config.SignatureVersion;
            try
            {
                Client.Config.SignatureVersion = "4";
                SimplePostTestInner();
                Client.Config.SignatureVersion = "2";
                SimplePostTestInner();
            }
            finally
            {
                Client.Config.SignatureVersion = originalSigV;
            }
        }

        private void SimplePostTestInner()
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

            S3TestUtils.DeleteObjectHelper(Client, BucketName, key);

            s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            Assert.AreEqual(count, s3Objects.Count);
        }

        [Test]
        [Category("WWW")]
        public void HeadersPostTest()
        {
            string originalSigV = Client.Config.SignatureVersion;
            try
            {
                Client.Config.SignatureVersion = "4";
                HeadersPostTestInner();
                Client.Config.SignatureVersion = "2";
                HeadersPostTestInner();
            }
            finally
            {
                Client.Config.SignatureVersion = originalSigV;
            }
        }

        private void HeadersPostTestInner()
        {
            var contentType = "image/jpeg";
            var cacheControl = "private";
            var contentEncoding = "deflate";
            var contentDisposition = "attachment; filename=f.gz";
            var key = string.Format(FileNameFormat, DateTime.Now.Ticks);
            var expires = DateTime.Now.AddDays(1);

            S3TestUtils.PostObjectHelper(Client, BucketName, key, delegate (PostObjectRequest request)
            {
                request.Headers.ContentType = contentType;
                request.Headers.CacheControl = cacheControl;
                request.Headers.ContentEncoding = contentEncoding;
                request.Headers.ContentDisposition = contentDisposition;
                request.Headers.Expires = expires;
            });
            var gotten = S3TestUtils.GetObjectHelper(Client, BucketName, key);
            Utils.AssertTrue(string.Compare(gotten.Headers.ContentType, contentType, true) == 0);
            Utils.AssertTrue(string.Compare(gotten.Headers.CacheControl, cacheControl, true) == 0);
            Utils.AssertTrue(string.Compare(gotten.Headers.ContentDisposition, contentDisposition, true) == 0);
            Utils.AssertTrue(string.Compare(gotten.Headers.ContentEncoding, contentEncoding, true) == 0);
            // strip precision before comparing dates
            Utils.AssertTrue(gotten.Expires.ToString(Amazon.Util.AWSSDKUtils.ISO8601BasicDateTimeFormat) == expires.ToString(Amazon.Util.AWSSDKUtils.ISO8601BasicDateTimeFormat));
        }

        [Test]
        [Category("WWW")]
        public void GzipPostTest()
        {
            string originalSigV = Client.Config.SignatureVersion;
            try
            {
                Client.Config.SignatureVersion = "4";
                GzipPostTestInner();
                Client.Config.SignatureVersion = "2";
                GzipPostTestInner();
            }
            finally
            {
                Client.Config.SignatureVersion = originalSigV;
            }
        }

        private void GzipPostTestInner()
        {
            var contentType = "application/x-gzip";
            var contentEncoding = "gzip";
            var key = string.Format(GzipFileNameFormat, DateTime.Now.Ticks);

            AutoResetEvent ars = new AutoResetEvent(false);

            Exception responseException = new Exception();
            string fileName = string.Format(GzipFileNameFormat, DateTime.Now.Ticks);
            TextAsset gzippedFile = null;
            byte[] buffer = null;
            UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                gzippedFile = Resources.Load("gzipFile") as TextAsset;
                buffer = gzippedFile.bytes;
                ars.Set();
            });

            ars.WaitOne();

            var memoryStream = new MemoryStream(buffer);

            var request = new PostObjectRequest()
            {
                Key = fileName,
                Bucket = BucketName,
                InputStream = memoryStream,
                CannedACL = S3CannedACL.Private
            };
            request.Headers.ContentEncoding = contentEncoding;
            request.Headers.ContentType = contentType;

            Client.PostObjectAsync(request, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = true });

            ars.WaitOne();
            Assert.IsNull(responseException);

            var gotten = S3TestUtils.GetObjectHelper(Client, BucketName, fileName);
            Utils.AssertTrue(string.Compare(gotten.Headers.ContentType, contentType, true) == 0, string.Format("content types: {0} != {1}", gotten.Headers.ContentType, contentType));
            // Unity removes the Content-Encoding header after unzipping :(.
            //Utils.AssertTrue(string.Compare(gotten.Headers.ContentEncoding, contentEncoding, true) == 0);
        }

        [Test]
        [Category("WWW")]
        public void TestHttpErrorPostResponseUnmarshalling()
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

        [Test]
        [Category("WWW")]
        public void TestPostObjectVersioning()
        {
            var key = "Key";
            var response = S3TestUtils.PostObjectHelper(Client, VersionedBucketName, key);
            var version1 = response.VersionId;
            Utils.AssertFalse(string.IsNullOrEmpty(version1));
            response = S3TestUtils.PostObjectHelper(Client, VersionedBucketName, key);
            var version2 = response.VersionId;
            Utils.AssertFalse(string.IsNullOrEmpty(version2));
            Utils.AssertTrue(version1 != version2);
            response = S3TestUtils.PostObjectHelper(Client, VersionedBucketName, key);
            var version3 = response.VersionId;
            Utils.AssertFalse(string.IsNullOrEmpty(version3));
            Utils.AssertTrue(version1 != version3);
            Utils.AssertTrue(version2 != version3);

        }

        [Test]
        [Category("WWW")]
        public void TestPostCannedACL()
        {
            string originalSigV = Client.Config.SignatureVersion;
            try
            {
                Client.Config.SignatureVersion = "4";
                TestPostCannedACLInner();
                Client.Config.SignatureVersion = "2";
                TestPostCannedACLInner();
            }
            finally
            {
                Client.Config.SignatureVersion = originalSigV;
            }
        }

        public void TestPostCannedACLInner()
        {
            var key = string.Format(FileNameFormat, DateTime.Now.Ticks);

            // Authenticated Read
            S3TestUtils.PostObjectHelper(Client, BucketName, key, delegate (PostObjectRequest request) { request.CannedACL = S3CannedACL.AuthenticatedRead; });
            var grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsContain(grants, AuthenticatedUsersUriSubstring, S3Permission.READ));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryUriSubstring));

            // No canned ACL equivalent to Private
            S3TestUtils.PostObjectHelper(Client, BucketName, key);
            grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsDoNotContain(grants, AuthenticatedUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryUriSubstring));

            // Private
            S3TestUtils.PostObjectHelper(Client, BucketName, key, delegate (PostObjectRequest request) { request.CannedACL = S3CannedACL.Private; });
            grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsDoNotContain(grants, AuthenticatedUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryUriSubstring));

            S3TestUtils.DeleteObjectHelper(Client, BucketName, key);
        }

        private bool GrantsContain(List<S3Grant> grants, string uriSubstring, S3Permission s3Permission)
        {
            foreach (var grant in grants)
            {
                if (grant.Permission == s3Permission && grant.Grantee.URI != null && grant.Grantee.URI.Contains(uriSubstring))
                {
                    return true;
                }
            }
            return false;
        }

        private bool GrantsDoNotContain(List<S3Grant> grants, string uri)
        {
            foreach (var grant in grants)
            {
                if (grant.Grantee.URI == uri && grant.Grantee.URI != null && grant.Grantee.URI.Contains(uri))
                {
                    return false;
                }
            }
            return true;
        }

        [Test]
        [Category("WWW")]
        public void SimplePathPostObjectTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string fileName = string.Format(FileNameFormat, DateTime.Now.Ticks);
            string filePath = S3TestUtils.GetFileHelper(fileName);
            Client.PostObjectAsync(new PostObjectRequest()
            {
                Key = fileName,
                Bucket = BucketName,
                Path = filePath,
                CannedACL = S3CannedACL.Private
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = true });

            ars.WaitOne();
            Assert.IsNull(responseException);
        }




        [Test]
        [Category("WWW")]
        public void PostObjectKMSTest()
        {

            string originalSigV = Client.Config.SignatureVersion;
            try
            {
                // KMS only allowed for sigv4
                Client.Config.SignatureVersion = "4";

                var key = string.Format(FileNameFormat, DateTime.Now.Ticks);
                S3TestUtils.PostObjectHelper(Client, BucketName, key, (request) =>
                {
                    request.Headers[HeaderKeys.XAmzServerSideEncryptionHeader] = ServerSideEncryptionMethod.AWSKMS;
                });

                AutoResetEvent ars = new AutoResetEvent(false);
                Exception responseException = new Exception();
                string objectContent = null;
                Client.GetObjectAsync(BucketName, key, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        using (var reader = new StreamReader(response.Response.ResponseStream))
                        {
                            objectContent = reader.ReadToEnd();
                        }
                    }
                    ars.Set();
                });

                ars.WaitOne();
                Assert.IsNull(responseException);
                Utils.AssertTrue(S3TestUtils.TestContent == objectContent, string.Format("{0} != {1}", S3TestUtils.TestContent, objectContent));
            }
            finally
            {
                Client.Config.SignatureVersion = originalSigV;
            }

        }

        [Test]
        [Category("WWW")]
        public void LargeFilePostObjectTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);

            Exception responseException = new Exception();
            string fileName = string.Format(FileNameFormat, DateTime.Now.Ticks);
            TextAsset largeFile = null;
            byte[] buffer = null;
            UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
            {
                largeFile = Resources.Load("20MBFile") as TextAsset;
                buffer = largeFile.bytes;
                ars.Set();
            });

            ars.WaitOne();

            var memoryStream = new MemoryStream(buffer);

            var request = new PostObjectRequest()
            {
                Key = fileName,
                Bucket = BucketName,
                InputStream = memoryStream,
                CannedACL = S3CannedACL.Private
            };

            request.StreamTransferProgress = (object sender, StreamTransferProgressArgs args) =>
            {
                Assert.LessOrEqual(args.PercentDone, 100);
            };

            Client.PostObjectAsync(request, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = true });

            ars.WaitOne();
            Assert.IsNull(responseException);
        }
    }
}
