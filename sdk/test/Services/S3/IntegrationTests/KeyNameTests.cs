using Amazon.S3;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Just a class to ensure customers who try the most awkward names for S3 objects
    /// will be fully satisifed and leave us alone :-)
    /// </summary>
    [TestClass]
    [TestCategory("S3")]
    public class KeyNameTests
    {
        private static readonly string[] AwkwardKeyNameBases =
        {
            @"ObjectWith!and?\+forgood:measureThis=And&InKeynÄme",
            @"ObjectWith\InKeyname",
            @"ObjectWith/InKeyname",
            @"ObjectWith\InKeynÄme",
            @"ObjectWith/InKeynÄme",
            @"ObjectWith$InKeynÄme",
            @"ObjectWith%2FInKeyname.Ext",
            @"!@#$%^&*()_+_+!(@#*$)_@[]\/.txt"
        };

        static string bucketName;

        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {
            IAmazonS3 s3Client = new AmazonS3Client();
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(s3Client);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            IAmazonS3 s3Client = new AmazonS3Client();
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3Client, bucketName);
        }
                
        [TestMethod]
        public async Task TestKeyNameWithAwkwardChars_AWS4Signing()
        {
            IAmazonS3 s3Client = new AmazonS3Client();

            foreach (var k in AwkwardKeyNameBases)
            {
                var keyName = k + ".SigV4.AWS2.CLRv" + Environment.Version;
                await S3TestUtils.PutAndGetObjectTestHelper(s3Client, bucketName, keyName);
            }
        }
    }
}
