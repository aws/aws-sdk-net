using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class PutBucketS3ExpressTests : IAsyncLifetime
    {
        private readonly List<string> _bucketNames = new List<string>();
        private static readonly AmazonS3Client _usEast1Client = new AmazonS3Client(RegionEndpoint.USEast1);

        public ValueTask InitializeAsync() => default;

        public async ValueTask DisposeAsync()
        {
            foreach (var bucketName in _bucketNames)
            {
                await _usEast1Client.DeleteBucketAsync(bucketName);
            }
        }

        [Fact]
        public async Task PutS3ExpressBucketUsingS3ExpressConfiguration()
        {
            string bucketName = UtilityMethods.GenerateName(UtilityMethods.SDK_TEST_PREFIX) + "--use1-az5--x-s3";
            var response = await _usEast1Client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = bucketName,
                PutBucketConfiguration = new PutBucketConfiguration
                {
                    BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                    Location = new LocationInfo { Name = "use1-az5", Type = LocationType.AvailabilityZone }
                }
            });
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
            _bucketNames.Add(bucketName);
        }

        [Fact]
        public async Task PutRegularBucketUsingNoConfiguration()
        {
            string bucketName = UtilityMethods.GenerateName(UtilityMethods.SDK_TEST_PREFIX);
            var response = await _usEast1Client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = bucketName,
            });
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
            _bucketNames.Add(bucketName);
        }
    }
}
