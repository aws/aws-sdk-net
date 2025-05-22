using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.Runtime.SharedInterfaces;



namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class S3ExtensionsTests : TestBase<AmazonS3Client>
    {
        static string _bucketName;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Amazon.S3.Util.AmazonS3Util.DeleteS3BucketWithObjects(Client, _bucketName);
        }


        [TestMethod]
        public void EnsureBucketExists()
        {
            IAmazonS3 s3Client = Client;
            s3Client.EnsureBucketExists(_bucketName);
        }
    }
}