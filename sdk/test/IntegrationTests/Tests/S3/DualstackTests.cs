using Amazon;
using Amazon.Internal;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Simple tests to verify that requests for dualstack endpoints cause the
    /// SDK to compute the correct endpoint fir a region and calls resolve 
    /// successfully.
    /// </summary>
    [TestClass]
    public class DualstackTests
    {
        RegionEndpoint[] testRegions = new RegionEndpoint[]
        {
            RegionEndpoint.USWest2,
            RegionEndpoint.USEast1,         // explicit test that the sdk switches to use s3.dualstack.us-east-1.amazonaws.com
            RegionEndpoint.APNortheast2,    // region that doesn't have an explicit "hostname" entry specified
        };

        /// <summary>
        /// Verifies that the SDK computes and successfully calls the correct dualstack 
        /// endpoint for a handful of regions when using S3 V2 signing protocol, using
        /// calls that result in both virtual host and path style addressing.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestSomeRegionsResolveV2Signing()
        {
            foreach (var testRegion in testRegions)
            {
                var config = new AmazonS3Config
                {
                    RegionEndpoint = testRegion,
                    UseDualstackEndpoint = true,
                    SignatureVersion = "2"
                };

                executeSomeBucketOperations(config);
            }
        }

        /// <summary>
        /// Verifies that the SDK computes and successfully calls the correct dualstack 
        /// endpoint for a handful of regions when using S3 V2 signing protocol, using
        /// calls that result in both virtual host and path style addressing.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestSomeRegionsResolveV4Signing()
        {
            foreach (var testRegion in testRegions)
            {
                var config = new AmazonS3Config
                {
                    RegionEndpoint = testRegion,
                    UseDualstackEndpoint = true,
                    SignatureVersion = "4"
                };

                executeSomeBucketOperations(config);
            }
        }

        private void executeSomeBucketOperations(AmazonS3Config s3Config)
        {
            using (var s3Client = new AmazonS3Client(s3Config))
            {
                // Call ListBuckets first to verify that AmazonS3PostMarshallHandler.ProcessRequestHandlers
                // correctly computes the endpoint when no bucket name is present.
                var listBucketsResponse = s3Client.ListBuckets();
                Assert.IsNotNull(listBucketsResponse);
                Assert.IsFalse(string.IsNullOrEmpty(listBucketsResponse.ResponseMetadata.RequestId));

                // Bonus call on ListObjects if we can find a bucket compatible with the test region (to avoid 301
                // errors due to addressing bucket on wrong endpoint). This verifies that  
                // AmazonS3PostMarshallHandler.ProcessRequestHandlers correctly computes the endpoint when 
                // a bucket name is present.
                string bucketName = null;
                foreach (var bucket in listBucketsResponse.Buckets)
                {
                    try
                    {
                        var bucketLocationResponse = s3Client.GetBucketLocation(bucket.BucketName);
                        if (string.IsNullOrEmpty(bucketLocationResponse.Location) && s3Config.RegionEndpoint == RegionEndpoint.USEast1)
                            bucketName = bucket.BucketName;
                        else if (string.Equals(s3Config.RegionEndpoint.SystemName, bucketLocationResponse.Location, StringComparison.OrdinalIgnoreCase))
                            bucketName = bucket.BucketName;

                        if (!string.IsNullOrEmpty(bucketName))
                            break;
                    }
                    catch(AmazonS3Exception e)
                    {
                        if (e.StatusCode != System.Net.HttpStatusCode.NotFound)
                            throw;
                    }
                }

                if (!string.IsNullOrEmpty(bucketName))
                {
                    var listObjectsResponse = s3Client.ListObjects(new ListObjectsRequest { BucketName = bucketName });
                    Assert.IsNotNull(listObjectsResponse);
                    Assert.IsNotNull(listObjectsResponse.ResponseMetadata);
                }
            }
        }

        /// <summary>
        /// Verifies that we can successfully compute and execute against a HTTP dualstack
        /// endpoint.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestHttpAccessOnDualstackEndpoint()
        {
            var config = new AmazonS3Config
            {
                UseDualstackEndpoint = true,
                RegionEndpoint = RegionEndpoint.USWest2,
                UseHttp = true
            };

            using (var s3Client = new AmazonS3Client(config))
            {
                var listBucketsResponse = s3Client.ListBuckets();
                Assert.IsNotNull(listBucketsResponse);
                Assert.IsFalse(string.IsNullOrEmpty(listBucketsResponse.ResponseMetadata.RequestId));
            }
        }

        /// <summary>
        /// Tests that if the user sets both UseAccelerateEndpoint and UseDualstackEndpoint, an
        /// exception is thrown as both options cannot currently be used at the same time.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonClientException), "The dualstack mode of Amazon S3 cannot be used with accelerate mode.")]
        public void TestConflictingOptionsCausesException()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseDualstackEndpoint = true,
                UseAccelerateEndpoint = true
            };

            var s3Client = new AmazonS3Client(config);
        }

        /// <summary>
        /// Tests we can invoke a dualstack endpoint using a service endpoint override.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestExplicitDualstackEndpoint()
        {
            var config = new AmazonS3Config
            {
                ServiceURL = "https://s3.dualstack.us-west-2.amazonaws.com"
            };

            using (var s3Client = new AmazonS3Client(config))
            {
                var listBucketsResponse = s3Client.ListBuckets();
                Assert.IsNotNull(listBucketsResponse);
                Assert.IsFalse(string.IsNullOrEmpty(listBucketsResponse.ResponseMetadata.RequestId));
            }
        }

        [TestMethod]
        [TestCategory("Core")]
        public void TestExplicitlyDefinedEndpoint()
        {
            string hostname = RegionEndpoint.APNortheast2.GetEndpointForService("sts", true).Hostname;
            Assert.AreEqual<string>("sts.dualstack.ap-northeast-2.amazonaws.com", hostname);

            hostname = RegionEndpoint.CNNorth1.GetEndpointForService("iam", true).Hostname;
            Assert.AreEqual<string>("iam.dualstack.cn-north-1.amazonaws.com.cn", hostname);
        }
    }
}