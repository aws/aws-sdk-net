using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for S3Express Buckets and normal bucket creation
    /// using S3Express specifications
    /// </summary>
    [TestClass]
    [TestCategory("S3")]
    public class PutBucketS3ExpressTests : TestBase<AmazonS3Client>
    {
        private static readonly List<string> bucketNames = new List<string>();
        private static readonly AmazonS3Client _usEast1Client = new AmazonS3Client(RegionEndpoint.USEast1);

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            foreach (var bucketName in bucketNames)
            {
                await _usEast1Client.DeleteBucketAsync(bucketName);
            }
        }

        [TestMethod]
        public async Task PutS3ExpressBucketUsingS3ExpressConfiguration()
        {
            string bucketName = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}--use1-az5--x-s3";
            var response = await _usEast1Client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = bucketName,
                PutBucketConfiguration = new PutBucketConfiguration
                {
                    BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                    Location = new LocationInfo { Name = "use1-az5", Type = LocationType.AvailabilityZone }
                }
            });
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
            bucketNames.Add(bucketName);
        }

        [TestMethod]
        public async Task PutRegularBucketUsingNoConfiguration()
        {
            string bucketName = UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks;
            var response = await _usEast1Client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = bucketName,
            });
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
            bucketNames.Add(bucketName);
        }
    }
}
