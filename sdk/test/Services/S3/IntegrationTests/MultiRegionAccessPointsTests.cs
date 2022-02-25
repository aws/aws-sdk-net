using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.S3Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class MultiRegionAccessPointsTests : TestBase<AmazonS3Client>
    {
        private static string _bucketName;
        private static string _mrapArn;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _bucketName = S3TestUtils.CreateBucketWithWait(Client);
            _mrapArn = S3TestUtils.GetOrCreateTestMRAP(new AmazonS3ControlClient(RegionEndpoint.USWest2), Client);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            // Delete the objects in the MRAP bucket, but leave the
            // MRAP and bucket for future test runs
            S3TestUtils.DeleteObjects(Client, _mrapArn);

            // Delete the entire bucket used for the SigV4 tests
            AmazonS3Util.DeleteS3BucketWithObjects(Client, _bucketName);
        }

        [TestMethod]
        public void PutObjectUnchunkedAndUnsigned()
        {
            S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, "dotnet-sdk-test-unchunked-unsigned", false, true);
        }

        [TestMethod]
        public void PutObjectUnchunked()
        {
            S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, "dotnet-sdk-test-unchunked", false);
        }

        [TestMethod]
        public void PutObjectChunked()
        {
            S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, "dotnet-sdk-test-chunked");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPresigingOver7DaysThrowsException()
        {
            _ = Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = _mrapArn,
                Key = "dotnet-sdk-test",
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
            S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, keyName, false);
        }
    }
}
