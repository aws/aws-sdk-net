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
using System.Collections;
using Amazon.Runtime.Internal;
using Amazon.Util;

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(GetPreSignedURLTests))]
    [Category("Integration")]
    class GetPreSignedURLTests : TestBase<AmazonS3Client, AmazonS3Config>
    {
        private static string BucketName = null;
        private static readonly string FileName = "UnityTestFile.txt";

        [OneTimeSetUp]
        public void SetUp()
        {
            BucketName = "unity-test-bucket" + DateTime.Now.Ticks;
            MissingAPILambdaFunctions.CreateBucket(BucketName, TestRunner.RegionEndpoint);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            S3TestUtils.CleanBucket(Client, BucketName);
            MissingAPILambdaFunctions.DeleteBucket(BucketName, TestRunner.RegionEndpoint);
        }

        [Test]
        [Category("WWW")]
        public void uploadFileTest()
        {
            UploadObjectTestTestInner(GetPreSignedURLTestInner(HttpVerb.PUT, true));
            DownloadObjectTestInner(GetPreSignedURLTestInner(HttpVerb.GET, true));
        }

        private IEnumerator UploadObjectTestTestInner(string url)
        {
            using (UnityWebRequestWrapper request = new UnityWebRequestWrapper(url, "PUT"))
            {
                yield return request.Send();

                // verify the file is successfully put to the bucket
                if (request.IsError)
                {
                    Assert.Fail();
                }
            }
        }

        private IEnumerator DownloadObjectTestInner(string url)
        {
            using (UnityWebRequestWrapper request = new UnityWebRequestWrapper(url, "GET")) {
                yield return request.Send();

                if (request.IsError)
                {
                    Assert.Fail();
                } else
                {
                    // verify the file get from the url is the one upload
                    byte[] dataGet = request.DownloadHandler.Data;
                    Assert.Equals(dataGet, System.IO.File.ReadAllBytes(FileName));
                }
            }
        }

        private string GetPreSignedURLTestInner(HttpVerb verb, bool isCallbackOnMainThread)
        {
            string presignedURL = "";
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            Client.GetPreSignedURLAsync(new GetPreSignedUrlRequest()
            {
                BucketName = BucketName,
                Key = FileName,
                Verb = verb,
                Expires = DateTime.Now.AddMinutes(5)
            }, (response) =>
            {
                responseException = response.Exception;
                presignedURL = response.Response.Url;

                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = isCallbackOnMainThread });

            ars.WaitOne();
            Assert.IsNull(responseException);

            return presignedURL;
        }
    }
}