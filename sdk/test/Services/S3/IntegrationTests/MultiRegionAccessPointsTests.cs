using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.S3Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class MultiRegionAccessPointsTests : TestBase<AmazonS3Client>
    {
        private static string _bucketName;
        private static string _mrapArn;

        [ClassInitialize]
        public static async Task Setup(TestContext context)
        {
            _bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            _mrapArn = await S3TestUtils.GetOrCreateTestMRAP(new AmazonS3ControlClient(RegionEndpoint.USWest2), Client);
        }

        [ClassCleanup]
        public static async Task Cleanup()
        {
            // Delete the objects in the MRAP bucket, but leave the
            // MRAP and bucket for future test runs
            await S3TestUtils.DeleteObjects(Client, _mrapArn);

            // Delete the entire bucket used for the SigV4 tests
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, _bucketName);
        }

        [TestMethod]
        public async Task PutObjectUnchunkedAndUnsigned()
        {
            await S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, "dotnet-sdk-test-unchunked-unsigned", false, true);
        }

        [TestMethod]
        public async Task PutObjectUnchunked()
        {
            await S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, "dotnet-sdk-test-unchunked", false);
        }

        [TestMethod]
        public async Task PutObjectChunked()
        {
            await S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, "dotnet-sdk-test-chunked");
        }

        [TestMethod]
        public void TestPresigingOver7DaysThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => 
                Client.GetPreSignedURL(new GetPreSignedUrlRequest
                {
                    BucketName = _mrapArn,
                    Key = "dotnet-sdk-test",
                    Verb = HttpVerb.GET,
                    Expires = DateTime.UtcNow.AddDays(8) // SigV4a limit is also 7 days
                })
            );
        }

        // Copied from KeyNameTests.AwkwardKeyNameBases, but as DataRows for separate results
        [DataRow(@"ObjectWith\InKeyname")]
        [DataRow(@"ObjectWith/InKeyname")]
        [DataRow(@"ObjectWith\InKeynÄme")]
        [DataRow(@"ObjectWith/InKeynÄme")]
        [DataRow(@"ObjectWith!InKeynÄme")]
        [DataRow(@"ObjectWith$InKeyname.Ext")]
        [DataRow(@"ObjectWith!and?\+forgood:measureThis=And&InKeynÄme")]
        [DataTestMethod]
        public async Task PutAndGetQuestionableKeys(string keyVariant)
        {
            var keyName = "dotnet-sdk-test-" + keyVariant;
            await S3TestUtils.PutAndGetObjectTestHelper(Client, _mrapArn, keyName, false);
        }
    }
}
