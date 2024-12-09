using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for S3Express Buckets and normal bucket creation
    /// using S3Express specifications
    /// </summary>
    [TestClass]
    public class PutBucketS3ExpressTests :TestBase<AmazonS3Client>
    {
        private static List<string> bucketNames = new List<string>();
        [TestMethod]
        [TestCategory("S3")]
        [Ignore] 
        //Ignore this method because regular s3 bucket with s3express configuration isn't working
        //at the moment
        public void PutRegularBucketUsingS3ExpressConfiguration()
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks;
            var response = Client.PutBucket(new PutBucketRequest
            {
                BucketName = bucketName,
                PutBucketConfiguration = new PutBucketConfiguration
                {
                    BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                    Location = new LocationInfo { Name = "use1-az2", Type = LocationType.AvailabilityZone }
                }
            });
            Assert.IsNotNull(response);
            Assert.IsTrue(response.HttpStatusCode == HttpStatusCode.OK);
            bucketNames.Add(bucketName);
        }
        [TestMethod]
        [TestCategory("S3")]
        public void PutS3ExpressBucketUsingS3ExpressConfiguration()
        {
            string bucketName = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}--use1-az5--x-s3";
            var response = Client.PutBucket(new PutBucketRequest
            {
                BucketName = bucketName,
                PutBucketConfiguration = new PutBucketConfiguration
                {
                    BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                    Location = new LocationInfo { Name = "use1-az5", Type = LocationType.AvailabilityZone }
                }
            });
            Assert.IsNotNull(response);
            Assert.IsTrue(response.HttpStatusCode == HttpStatusCode.OK);
            bucketNames.Add(bucketName);
        }
        [TestMethod]
        [TestCategory("S3")]
        public void PutRegularBucketUsingNoConfiguration()
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks;
            var response = Client.PutBucket(new PutBucketRequest
            {
                BucketName = bucketName,
            });
            Assert.IsNotNull(response);
            Assert.IsTrue(response.HttpStatusCode == System.Net.HttpStatusCode.OK);
            bucketNames.Add(bucketName);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            foreach (var bucketName in bucketNames)
            {
                Client.DeleteBucket(bucketName);
            }
        }
        
    }
}
