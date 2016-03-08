using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using UnityEngine;
using AWSSDK.Tests.Framework;

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(MetadataTests))]
    [Category("Integration")]
    public class MetadataTests : TestBase<AmazonS3Client>
    {
        private static readonly Dictionary<string, string> Metadata = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "date", DateTime.Now.ToFileTime().ToString() } ,
            { "test", "true" }
        };

        private static string BucketName = null;

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
        [Category("WWW")]
        public void TestSingleUploads()
        {
            // Test simple PostObject upload
            var objectKey = "contentbodyput" + DateTime.Now.Ticks;
            S3TestUtils.PostObjectHelper(Client, BucketName, objectKey, SetMetadata);
            var response = S3TestUtils.GetObjectHelper(Client, BucketName, objectKey);

            S3TestUtils.DeleteObjectHelper(Client, BucketName, objectKey);

            var prefixLen = "x-amz-meta-".Length;

            foreach (var fullKey in response.Metadata.Keys)
            {
                // remove x-amz-meta-, ignoring case
                var shortKey = fullKey.StartsWith("x-amz-meta-", StringComparison.OrdinalIgnoreCase) ? fullKey.Substring(prefixLen, fullKey.Length - prefixLen) : fullKey;
                var actualValue = response.Metadata[fullKey];
                var expectedValue = Metadata[shortKey];
                Assert.AreEqual(expectedValue, actualValue);
            }
        }

        private static void SetMetadata(PostObjectRequest request)
        {
            request.Metadata = Metadata;
        }
    }
}
