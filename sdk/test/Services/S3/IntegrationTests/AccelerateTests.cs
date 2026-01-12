using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class AccelerateTests : TestBase<AmazonS3Client>
    {
        private static readonly RegionEndpoint TestRegionEndpoint = RegionEndpoint.USEast1;
        private static readonly string AuthRegion = "us-east-1";
        private static string bucketName;
        private static readonly string testContent = "This is the content body!";
        private static IAmazonS3 s3Client = null;
        private static readonly List<string> leftoverBuckets = new List<string>();
        private readonly Random random = new Random();

        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {
            s3Client = new AmazonS3Client(TestRegionEndpoint);
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(s3Client, true);
            BucketAccelerateStatus bucketStatus = null;

            await s3Client.PutBucketAccelerateConfigurationAsync(new PutBucketAccelerateConfigurationRequest
            {
                BucketName = bucketName,
                AccelerateConfiguration = new AccelerateConfiguration
                {
                    Status = BucketAccelerateStatus.Enabled
                }
            });

            var response = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await s3Client.GetBucketAccelerateConfigurationAsync(bucketName);
                return res.Status == BucketAccelerateStatus.Enabled ? res : null;
            });

            bucketStatus = response.Status;
            Assert.AreEqual(BucketAccelerateStatus.Enabled, bucketStatus);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            if (leftoverBuckets.Any())
            {
                foreach (var bucket in leftoverBuckets)
                {
                    await AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3Client, bucket);
                }
            }

            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3Client, bucketName);
            s3Client.Dispose();
            BaseClean();
        }

        [TestMethod]
        public async Task TestAccelerateEnabledClient()
        {
            using (var client = new AmazonS3Client(
                new AmazonS3Config
                {
                    UseAccelerateEndpoint = true,
                    RegionEndpoint = TestRegionEndpoint
                }))
            {
                await TestAccelerateUnsupportedOperations(client);
                await TestControlPlaneOperations(client);
                await TestDataPlaneOperations(client);

                await Assert.ThrowsExceptionAsync<AmazonClientException>(() =>
                    client.ListObjectsAsync("accelerate.incompatible.bucket")
                );
            }

            Assert.ThrowsException<AmazonClientException>(() =>
                new AmazonS3Client(new AmazonS3Config
                {
                    ForcePathStyle = true,
                    UseAccelerateEndpoint = true,
                    RegionEndpoint = TestRegionEndpoint
                })
            );

            using (var sigV4Client = new AmazonS3Client(new AmazonS3Config
            {
                UseAccelerateEndpoint = true,
                RegionEndpoint = TestRegionEndpoint
            }))
            {
                await TestAccelerateUnsupportedOperations(sigV4Client);
                await TestControlPlaneOperations(sigV4Client);
                await TestDataPlaneOperations(sigV4Client);
            }
        }

        [TestMethod]
        public async Task TestClientWithExplicitRegionEndpointAndAccelerateEnabled()
        {
            using (var explicitAccelerateEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = TestRegionEndpoint,
                UseAccelerateEndpoint = true
            }))
            {
                await TestAccelerateUnsupportedOperations(explicitAccelerateEndpointClient);
                await TestControlPlaneOperations(explicitAccelerateEndpointClient);
                await TestDataPlaneOperations(explicitAccelerateEndpointClient);
            }

            using (var dualstackAccelerateEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = TestRegionEndpoint,
                UseAccelerateEndpoint = true,
                UseDualstackEndpoint = true
            }))
            {
                await TestAccelerateUnsupportedOperations(dualstackAccelerateEndpointClient);
                await TestControlPlaneOperations(dualstackAccelerateEndpointClient);
                await TestDataPlaneOperations(dualstackAccelerateEndpointClient);
            }
        }

        [TestMethod]
        public async Task TestClientWithExplicitAccelerateEndpoint()
        {
            Assert.ThrowsException<AmazonClientException>(() =>
                new AmazonS3Client(new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.amazonaws.com"
                })
            );

            Assert.ThrowsException<AmazonClientException>(() =>
                new AmazonS3Client(new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.dualstack.amazonaws.com"
                })
            );

            using (var explicitAccelerateEndpointAndAuthRegionClient = new AmazonS3Client(new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.amazonaws.com",
                    AuthenticationRegion = AuthRegion
                }))
            {
                await TestAccelerateUnsupportedOperations(explicitAccelerateEndpointAndAuthRegionClient);
                await TestControlPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
                await TestDataPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
            }

            using (var explicitAccelerateEndpointAndAuthRegionClient = new AmazonS3Client(new AmazonS3Config
            {
                ServiceURL = "https://s3-accelerate.dualstack.amazonaws.com",
                AuthenticationRegion = AuthRegion
            }))
            {
                await TestAccelerateUnsupportedOperations(explicitAccelerateEndpointAndAuthRegionClient);
                await TestControlPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
                await TestDataPlaneOperations(explicitAccelerateEndpointAndAuthRegionClient);
            }

            using (var explicitAccelerateEndpointAndRegionEndpoint = new AmazonS3Client(new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.amazonaws.com",
                    RegionEndpoint = TestRegionEndpoint
                }))
            {
                await TestAccelerateUnsupportedOperations(explicitAccelerateEndpointAndRegionEndpoint);
                await TestControlPlaneOperations(explicitAccelerateEndpointAndRegionEndpoint);
                await TestDataPlaneOperations(explicitAccelerateEndpointAndRegionEndpoint);
            }
        }

        async Task TestDataPlaneOperations(IAmazonS3 client)
        {
            var key = "contentBodyPut" + random.Next();
            await client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            });

            var getRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };
            using (var response = await client.GetObjectAsync(getRequest))
            using (StreamReader reader = new StreamReader(response.ResponseStream))
            {
                var responseData = await reader.ReadToEndAsync();
                Assert.AreEqual(testContent, responseData);
            }
        }

        async Task TestControlPlaneOperations(IAmazonS3 client)
        {
            // All other operations should hit accelerate endpoint
            var objects = (await client.ListObjectsAsync(bucketName)).S3Objects;

            if (objects == null)
                Assert.IsFalse(AWSConfigs.InitializeCollections);
            else
                Assert.IsNotNull(objects);
        }

        async Task TestAccelerateUnsupportedOperations(IAmazonS3 client)
        {
            // List, Put and Delete bucket should hit regional endpoint
            var buckets = (await client.ListBucketsAsync()).Buckets;
            Assert.IsNotNull(buckets);

            var newBucket = UtilityMethods.GenerateName();
            await client.PutBucketAsync(newBucket);

            await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var response = await client.ListBucketsAsync();
                var result = response.Buckets.Any(b => b.BucketName.Equals(newBucket, StringComparison.Ordinal));
                return result ? (bool?)true : null;
            });

            try
            {
                await client.DeleteBucketAsync(newBucket);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to clean up new bucket {newBucket}: {ex.Message}.");
                leftoverBuckets.Add(newBucket);
            }
        }        
    }
}