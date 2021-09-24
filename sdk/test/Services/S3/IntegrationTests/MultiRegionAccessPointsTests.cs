using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class MultiRegionAccessPointsTests : TestBase<AmazonS3Client>
    {
        private static string _accountId;
        private static string _bucketName;
        private static string _mrapName;
        private static string _mrapArn;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _bucketName = S3TestUtils.CreateBucketWithWait(Client);
            _mrapName = UtilityMethods.SDK_TEST_PREFIX + DateTime.Now.Ticks;

            // Look up the account ID for the credentials being used to run the tests
            _accountId = new AmazonSecurityTokenServiceClient().GetCallerIdentity(new GetCallerIdentityRequest()).Account;

            var request = new CreateMultiRegionAccessPointRequest
            {
                AccountId = _accountId,
                Details = new CreateMultiRegionAccessPointInput
                {
                    Name = _mrapName,
                    Regions = new List<Region>
                    {
                        new Region
                        {
                            Bucket = _bucketName
                        }
                    }
                }
            };

            // All MRAP control plane requests must go to us-west-2 per
            // https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html
            var mrapAlias = S3TestUtils.CreateMRAPWithWait(new AmazonS3ControlClient(RegionEndpoint.USWest2), request);
            _mrapArn = $"arn:aws:s3::{_accountId}:accesspoint/{mrapAlias}";
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            var deleteRequest = new DeleteMultiRegionAccessPointRequest
            { 
                AccountId = _accountId,
                Details = new DeleteMultiRegionAccessPointInput { Name = _mrapName }
            };

            S3TestUtils.DeleteMRAPWithWait(new AmazonS3ControlClient(RegionEndpoint.USWest2), deleteRequest);
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
