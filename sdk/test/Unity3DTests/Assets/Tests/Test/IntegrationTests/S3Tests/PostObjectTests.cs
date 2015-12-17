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

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(PostObjectTests))]
    [Category("Integration")]
    class PostObjectTests : TestBase<AmazonS3Client>
    {
        private static readonly string FileNamePrefix = "UnityTestFile";
        private static readonly string FileNameFormat = FileNamePrefix + "{0}.txt";
        private static string BucketName = null;

        private static readonly string AuthenticatedUsersURI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers";
        private static readonly string AllUsersURI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers";
        private static readonly string LogDeliveryURI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers";

        [OneTimeSetUp]
        public void SetUp()
        {
            BucketName = "unity-test-bucket" + DateTime.Now.Ticks;
            MissingAPILambdaFunctions.CreateBucket(BucketName, TestRunner.RegionEndpoint);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            MissingAPILambdaFunctions.DeleteBucket(BucketName, TestRunner.RegionEndpoint);
        }

        [Test]
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

            S3TestUtils.DeleteObjectHelper(Client, BucketName, key);

            s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            Assert.AreEqual(count, s3Objects.Count);
        }

        [Test]
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

        [Test]
        public void TestCannedACL()
        {
            var key = string.Format(FileNameFormat, DateTime.Now.Ticks);

            // Authenticated Read
            S3TestUtils.PostObjectHelper(Client, BucketName, key, delegate(PostObjectRequest request) { request.CannedACL = S3CannedACL.AuthenticatedRead; });
            var grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsContain(grants, AuthenticatedUsersURI, S3Permission.READ));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersURI));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryURI));

            // No canned ACL equivalent to Provate
            S3TestUtils.PostObjectHelper(Client, BucketName, key);
            grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsDoNotContain(grants, AuthenticatedUsersURI));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersURI));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryURI));

            // Private
            S3TestUtils.PostObjectHelper(Client, BucketName, key, delegate(PostObjectRequest request) { request.CannedACL = S3CannedACL.Private; });
            grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsDoNotContain(grants, AuthenticatedUsersURI));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersURI));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryURI));
        }

        private bool GrantsContain(List<S3Grant> grants, string uri, S3Permission s3Permission)
        {
            foreach (var grant in grants)
            {
                if (grant.Permission == s3Permission && grant.Grantee.URI == uri)
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
                if (grant.Grantee.URI == uri)
                {
                    return false;
                }
            }
            return true;
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
