using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    [Collection("Serial")]
    public class BucketRegionTests
    {
        [Fact]
        public async Task HappyCaseSigV4()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    Assert.True(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.Equal(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [Fact]
        public async Task HappyCaseGetObjectMetedata()
        {
            // Make sure the cache works when it gets the region from a HEAD bucket request
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    // Ensure the object exists then clear the cache
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    BucketRegionDetector.BucketRegionCache.Clear();

                    await runner.USEast1Client.GetObjectMetadataAsync(runner.GetObjectMetadataRequest);
                    Assert.True(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.Equal(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [Fact]
        public async Task HappyCaseDoesS3BucketExist()
        {
            // Make sure the cache works when it gets the region from the x-amz-bucket-region header
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.True(await AmazonS3Util.DoesS3BucketExistV2Async(runner.USEast1Client, runner.BucketName));
                    Assert.True(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.Equal(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [Fact]
        public async Task BucketRecreatedInDifferentRegion()
        {
            // Make sure the cache gets refreshed when it should
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    BucketRegionDetector.BucketRegionCache.AddOrUpdate(runner.BucketName, RegionEndpoint.APNortheast2);
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    Assert.True(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.Equal(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [Fact]
        public async Task GetPreSignedUrlUSEast1SigV2()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USEast1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequestExtendedExpiration);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.Equal(HttpStatusCode.OK, statusCode);
                }
            }
        }

        [Fact]
        public async Task GetPreSignedUrlUSWest1SigV2()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USWest1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequestExtendedExpiration);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.Equal(HttpStatusCode.OK, statusCode);
                }
            }
        }

        [Fact]
        public async Task GetPreSignedUrlSigV4USWest1ClientUSWest2BucketOk()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USWest1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequest);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.Equal(HttpStatusCode.OK, statusCode);
                }
            }
        }

        [Fact]
        public async Task GetPreSignedUrlSigV4USEast1ClientUSWest2BucketFail()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USEast1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequest);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.Equal(HttpStatusCode.BadRequest, statusCode);
                }
            }
        }

        [Fact]
        public async Task DeleteBucketUsingS3RegionUSEast1Enum()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                var bucketName = await S3TestUtils.CreateBucketWithWaitAsync(runner.USEast1Client);
                await runner.USWest1Client.DeleteBucketAsync(new DeleteBucketRequest
                {
                    BucketName = bucketName,
                    BucketRegion = S3Region.USEast1
                });
            }
        }

        [Fact]
        public async Task GetBucketLocation()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                var nonUsEast1Bucket = await S3TestUtils.CreateBucketWithWaitAsync(runner.USWest1Client);
                try
                {
                    var nonNullocationResponse = await runner.USWest1Client.GetBucketLocationAsync(nonUsEast1Bucket);
                    Assert.NotNull(nonNullocationResponse.Location);
                    Assert.Equal(RegionEndpoint.USWest1.SystemName, nonNullocationResponse.Location.ToString());
                }
                finally
                {
                    await runner.USWest1Client.DeleteBucketAsync(new DeleteBucketRequest
                    {
                        BucketName = nonUsEast1Bucket
                    });
                }

                // Buckets in us-east-1 have a LocationConstraint of null.
                var usEast1Bucket = await S3TestUtils.CreateBucketWithWaitAsync(runner.USEast1Client);
                try
                {
                    var nullLocationResponse = await runner.USEast1Client.GetBucketLocationAsync(usEast1Bucket);
                    Assert.True(string.IsNullOrEmpty(nullLocationResponse.Location));
                }
                finally
                {
                    await runner.USEast1Client.DeleteBucketAsync(new DeleteBucketRequest
                    {
                        BucketName = usEast1Bucket
                    });
                }
            }
        }

        private static readonly HttpClient _httpClient = new HttpClient(
            new HttpClientHandler { AllowAutoRedirect = false });

        private async Task<HttpStatusCode> GetHttpStatusCode(string url)
        {
            using (var response = await _httpClient.GetAsync(url))
            {
                return response.StatusCode;
            }
        }
    }
}
