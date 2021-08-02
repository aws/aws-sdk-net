using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Ignore]    // Intended for local testing against a manually prepared multi-region access point
    [TestClass]
    public class MultiRegionAccessPointsTests
    {
        private static AmazonS3Client _s3Client;
        private const string _mrapArn = "<provide MRAP Arn>";
        private const string _objectKey = "dotnet-sdk-test";
        private const string _objectContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            var options = new AmazonS3Config { UseArnRegion = true };

            _s3Client = new AmazonS3Client(options);
        }

        [TestMethod]
        public void ListBuckets()
        {
            var request = new ListBucketsRequest();

            var response = _s3Client.ListBuckets(request);

            Assert.AreNotEqual(0, response.Buckets.Count);
        }

        [TestMethod]
        public void ListObjects()
        {
            var request = new ListObjectsRequest()
            {
                BucketName = _mrapArn
            };

            var response = _s3Client.ListObjects(request);

            Assert.AreNotEqual(0, response.S3Objects.Count);
        }

        [TestMethod]
        public void PutObjectUnchunkedAndUnsigned()
        {
            var request = new PutObjectRequest()
            {
                BucketName = _mrapArn,
                Key = _objectKey,
                ContentBody = _objectContent,
                UseChunkEncoding = false,
                DisablePayloadSigning = true
            };

            var response = _s3Client.PutObject(request);
        }

        [TestMethod]
        public void PutObjectUnchunked()
        {
            var request = new PutObjectRequest()
            {
                BucketName = _mrapArn,
                Key = _objectKey,
                ContentBody = _objectContent,
                UseChunkEncoding = false
            };

            var response = _s3Client.PutObject(request);
        }

        [TestMethod]
        public void PutObjectChunked()
        {
            var request = new PutObjectRequest()
            {
                BucketName = _mrapArn,
                Key = _objectKey,
                ContentBody = _objectContent,
                UseChunkEncoding = true
            };

            var response = _s3Client.PutObject(request);
        }

        [TestMethod]
        public void GetObject()
        {
            var request = new GetObjectRequest()
            {
                BucketName = _mrapArn,
                Key = _objectKey
            };

            var response = _s3Client.GetObject(request);

            StreamReader reader = new StreamReader(response.ResponseStream);
            Assert.AreEqual(_objectContent, reader.ReadToEnd());
        }

        [TestMethod]
        public void TestPresignedUrl()
        {
            var getPresignedUrl = _s3Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = _mrapArn,
                Key = _objectKey,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(5)
            });

            var request = WebRequest.CreateHttp(getPresignedUrl);
            using (var response = request.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var content = reader.ReadToEnd();
                Assert.AreEqual(_objectContent, content);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPresigingOver7DaysThrowsException()
        {
            var getPresignedUrl = _s3Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = _mrapArn,
                Key = _objectKey,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(8)    // SigV4a limit is also 7 days
            });
        }

        // Copied from KeyNameTests.AwkwardKeyNameBases, but as DataRows for separate results
        [DataRow(@"ObjectWith\InKeyname")]
        [DataRow(@"ObjectWith/InKeyname")]
        [DataRow(@"ObjectWith\InKeynÄme")]
        [DataRow(@"ObjectWith/InKeynÄme")]
        [DataRow(@"ObjectWith!InKeynÄme")]
        [DataRow(@"ObjectWith$InKeyname.Ext")]
        [DataRow(@"ObjectWith!and?\+forgood:measureThis=And&InKeynÄme")]
        [TestMethod]
        public void PutAndGetQuestionableKeys(string keyVariant)
        {
            var keyName = "dotnet-sdk-test-" + keyVariant;
            KeyNameTests.PutAndGetObjectWithQuestionableKey(_s3Client, _mrapArn, keyName, false);
        }
    }
}
