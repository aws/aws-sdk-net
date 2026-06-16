using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    public class AccelerateTestsFixture : S3BucketFixture
    {
        public static readonly RegionEndpoint TestRegionEndpoint = RegionEndpoint.USEast1;

        public override async ValueTask InitializeAsync()
        {
            Client = new AmazonS3Client(TestRegionEndpoint);
            BucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, setPublicACLs: true);

            await Client.PutBucketAccelerateConfigurationAsync(new PutBucketAccelerateConfigurationRequest
            {
                BucketName = BucketName,
                AccelerateConfiguration = new AccelerateConfiguration
                {
                    Status = BucketAccelerateStatus.Enabled
                }
            });

            await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketAccelerateConfigurationAsync(BucketName);
                return res.Status == BucketAccelerateStatus.Enabled ? res : null;
            });
        }
    }

    [Trait("Category", "S3")]
    public class AccelerateTests : IClassFixture<AccelerateTestsFixture>
    {
        private static readonly string AuthRegion = "us-east-1";
        private static readonly string testContent = "This is the content body!";
        
        private readonly string _bucketName;
        private readonly string _testId;

        public AccelerateTests(AccelerateTestsFixture fixture)
        {
            _bucketName = fixture.BucketName;
            _testId = Guid.NewGuid().ToString("N");
        }

        [Fact]
        public async Task TestAccelerateEnabledClient()
        {
            using (var client = new AmazonS3Client(
                new AmazonS3Config
                {
                    UseAccelerateEndpoint = true,
                    RegionEndpoint = AccelerateTestsFixture.TestRegionEndpoint
                }))
            {
                await TestAccelerateUnsupportedOperations(client);
                await TestControlPlaneOperations(client);
                await TestDataPlaneOperations(client);

                await Assert.ThrowsAsync<AmazonClientException>(() =>
                    client.ListObjectsAsync("accelerate.incompatible.bucket")
                );
            }

            Assert.Throws<AmazonClientException>(() =>
                new AmazonS3Client(new AmazonS3Config
                {
                    ForcePathStyle = true,
                    UseAccelerateEndpoint = true,
                    RegionEndpoint = AccelerateTestsFixture.TestRegionEndpoint
                })
            );

            using (var sigV4Client = new AmazonS3Client(new AmazonS3Config
            {
                UseAccelerateEndpoint = true,
                RegionEndpoint = AccelerateTestsFixture.TestRegionEndpoint
            }))
            {
                await TestAccelerateUnsupportedOperations(sigV4Client);
                await TestControlPlaneOperations(sigV4Client);
                await TestDataPlaneOperations(sigV4Client);
            }
        }

        [Fact]
        public async Task TestClientWithExplicitRegionEndpointAndAccelerateEnabled()
        {
            using (var explicitAccelerateEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = AccelerateTestsFixture.TestRegionEndpoint,
                UseAccelerateEndpoint = true
            }))
            {
                await TestAccelerateUnsupportedOperations(explicitAccelerateEndpointClient);
                await TestControlPlaneOperations(explicitAccelerateEndpointClient);
                await TestDataPlaneOperations(explicitAccelerateEndpointClient);
            }

            using (var dualstackAccelerateEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = AccelerateTestsFixture.TestRegionEndpoint,
                UseAccelerateEndpoint = true,
                UseDualstackEndpoint = true
            }))
            {
                await TestAccelerateUnsupportedOperations(dualstackAccelerateEndpointClient);
                await TestControlPlaneOperations(dualstackAccelerateEndpointClient);
                await TestDataPlaneOperations(dualstackAccelerateEndpointClient);
            }
        }

        [Fact]
        public async Task TestClientWithExplicitAccelerateEndpoint()
        {
            Assert.Throws<AmazonClientException>(() =>
                new AmazonS3Client(new AmazonS3Config
                {
                    ServiceURL = "https://s3-accelerate.amazonaws.com"
                })
            );

            Assert.Throws<AmazonClientException>(() =>
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
                    RegionEndpoint = AccelerateTestsFixture.TestRegionEndpoint
                }))
            {
                await TestAccelerateUnsupportedOperations(explicitAccelerateEndpointAndRegionEndpoint);
                await TestControlPlaneOperations(explicitAccelerateEndpointAndRegionEndpoint);
                await TestDataPlaneOperations(explicitAccelerateEndpointAndRegionEndpoint);
            }
        }

        async Task TestDataPlaneOperations(IAmazonS3 client)
        {
            var key = _testId + "-contentBodyPut";
            await client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            });

            var getRequest = new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            };
            using (var response = await client.GetObjectAsync(getRequest))
            using (StreamReader reader = new StreamReader(response.ResponseStream))
            {
                var responseData = await reader.ReadToEndAsync();
                Assert.Equal(testContent, responseData);
            }
        }

        async Task TestControlPlaneOperations(IAmazonS3 client)
        {
            // All other operations should hit accelerate endpoint
            var objects = (await client.ListObjectsAsync(_bucketName)).S3Objects;

            if (objects == null)
                Assert.False(AWSConfigs.InitializeCollections);
            else
                Assert.NotNull(objects);
        }

        async Task TestAccelerateUnsupportedOperations(IAmazonS3 client)
        {
            // List, Put and Delete bucket should hit regional endpoint
            var buckets = (await client.ListBucketsAsync()).Buckets;
            Assert.NotNull(buckets);

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
                // Bucket will be deleted by the build system's cleanup process.
                Console.WriteLine($"Failed to clean up new bucket {newBucket}: {ex.Message}.");
            }
        }
    }
}
