using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class PublicAccessBlockTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public PublicAccessBlockTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
        }
                
        private async Task<PublicAccessBlockConfiguration> CallPutPublicAccessBlock()
        {
            var configuration = new PublicAccessBlockConfiguration
            {
                BlockPublicAcls = true,
                BlockPublicPolicy = true,
                IgnorePublicAcls = true,
                RestrictPublicBuckets = true
            };

            var putResponse = await _client.PutPublicAccessBlockAsync(new PutPublicAccessBlockRequest
            {
                BucketName = _bucketName,
                PublicAccessBlockConfiguration = configuration
            });
            Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);

            return configuration;
        }

        private async Task CallGetPublicAccessBlock(PublicAccessBlockConfiguration expectedConfiguration)
        {
            var getRequest = new GetPublicAccessBlockRequest
            {
                BucketName = _bucketName
            };

            if (expectedConfiguration == null)
            {
                // If expectedConfiguration is null then we want GetPublicAccessBlock to throw an exception because the configuration was removed.
                await _client.GetPublicAccessBlockAsync(getRequest);
                Assert.Fail("An expected exception was not thrown");
            }
            
            var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetPublicAccessBlockAsync(getRequest);
                return res.HttpStatusCode == HttpStatusCode.OK
                    && expectedConfiguration.BlockPublicAcls == res.PublicAccessBlockConfiguration.BlockPublicAcls
                    && expectedConfiguration.BlockPublicPolicy == res.PublicAccessBlockConfiguration.BlockPublicPolicy
                    && expectedConfiguration.IgnorePublicAcls == res.PublicAccessBlockConfiguration.IgnorePublicAcls
                    && expectedConfiguration.RestrictPublicBuckets == res.PublicAccessBlockConfiguration.RestrictPublicBuckets ? res : null;
            });
                        
            Assert.Equal(expectedConfiguration.BlockPublicAcls, getResponse.PublicAccessBlockConfiguration.BlockPublicAcls);
            Assert.Equal(expectedConfiguration.BlockPublicPolicy, getResponse.PublicAccessBlockConfiguration.BlockPublicPolicy);
            Assert.Equal(expectedConfiguration.IgnorePublicAcls, getResponse.PublicAccessBlockConfiguration.IgnorePublicAcls);
            Assert.Equal(expectedConfiguration.RestrictPublicBuckets, getResponse.PublicAccessBlockConfiguration.RestrictPublicBuckets);
        }

        [Fact]
        public async Task TestDeletePublicAccessBlock()
        {
            var configuration = await CallPutPublicAccessBlock();
            await CallGetPublicAccessBlock(configuration);

            var deleteResponse = await _client.DeletePublicAccessBlockAsync(new DeletePublicAccessBlockRequest
            {
                BucketName = _bucketName
            });
            Assert.Equal(HttpStatusCode.NoContent, deleteResponse.HttpStatusCode);

            // Verify the configuration was deleted. This call will throw a public access block configuration was not found message.
            await Assert.ThrowsAsync<AmazonS3Exception>(() => CallGetPublicAccessBlock(null));
        }
        
        [Fact]
        public async Task TestPutPublicAccessBlock()
        {
            await CallPutPublicAccessBlock();
        }

        [Fact]
        public async Task TestGetPublicAccessBlock()
        {
            string[] testProperties =
            {
                nameof(PublicAccessBlockConfiguration.BlockPublicAcls),
                nameof(PublicAccessBlockConfiguration.BlockPublicPolicy),
                nameof(PublicAccessBlockConfiguration.IgnorePublicAcls),
                nameof(PublicAccessBlockConfiguration.RestrictPublicBuckets)
            };
            
            // Set each property in PublicAccessBlockConfiguration, do the put, then do the get to test that the value was set.
            foreach (string propertyName in testProperties)
            {
                var configuration = new PublicAccessBlockConfiguration
                {
                    BlockPublicAcls = false,
                    BlockPublicPolicy = false,
                    IgnorePublicAcls = false,
                    RestrictPublicBuckets = false
                };

                var putRequest = new PutPublicAccessBlockRequest
                {
                    BucketName = _bucketName,
                    PublicAccessBlockConfiguration = configuration
                };

                System.Reflection.PropertyInfo property = putRequest.PublicAccessBlockConfiguration.GetType().GetProperty(propertyName);
                property.SetValue(configuration, true);

                var putResponse = await _client.PutPublicAccessBlockAsync(putRequest);
                Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);
                await CallGetPublicAccessBlock(configuration);                
            }
        }
    }
}
