using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Net;


namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Just a class to ensure customers who try the most awkward names for S3 objects
    /// will be fully satisifed and leave us alone :-)
    /// </summary>
    [TestClass]
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
        public static void Initialize(TestContext a)
        {
            IAmazonS3 s3Client = new AmazonS3Client();
            bucketName = S3TestUtils.CreateBucketWithWait(s3Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            IAmazonS3 s3Client = new AmazonS3Client();
            AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
        }
                
        [TestCategory("S3")]
        [TestMethod]
        public void TestKeyNameWithAwkwardChars_AWS4Signing()
        {
            IAmazonS3 s3Client = new AmazonS3Client();

            foreach (var k in AwkwardKeyNameBases)
            {
                var keyName = k + ".SigV4.AWS2.CLRv" + Environment.Version;
                S3TestUtils.PutAndGetObjectTestHelper(s3Client, bucketName, keyName);
            }
        }
    }
}
