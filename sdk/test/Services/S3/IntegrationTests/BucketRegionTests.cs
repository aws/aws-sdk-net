using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class BucketRegionTests
    {
        [TestMethod]
        public async Task HappyCaseSigV4()
        {
            // make sure the cache works when it gets the region from the response body
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        public async Task HappyCaseGetObjectMetedata()
        {
            // make sure the cache works when it gets the region from a HEAD bucket request
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    // ensure the object exists then clear the cache
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    BucketRegionDetector.BucketRegionCache.Clear();

                    await runner.USEast1Client.GetObjectMetadataAsync(runner.GetObjectMetadataRequest);
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        public async Task HappyCaseDoesS3BucketExist()
        {
            // make sure the cache works when it gets the region from the x-amz-bucket-region header
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    Assert.IsTrue(await AmazonS3Util.DoesS3BucketExistV2Async(runner.USEast1Client, runner.BucketName));
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        public async Task BucketRecreatedInDifferentRegion()
        {
            // make sure the cache gets refreshed when it should
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    BucketRegionDetector.BucketRegionCache.AddOrUpdate(runner.BucketName, RegionEndpoint.APNortheast2);
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out RegionEndpoint cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        public async Task GetPreSignedUrlUSEast1SigV2()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USEast1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequestExtendedExpiration);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                }
            }
        }

        [TestMethod]
        public async Task GetPreSignedUrlUSWest1SigV2()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USWest1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequestExtendedExpiration);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                }
            }
        }

        [TestMethod]
        public async Task GetPreSignedUrlSigV4USWest1ClientUSWest2BucketOk()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USWest1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequest);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                }
            }
        }

        [TestMethod]
        public async Task GetPreSignedUrlSigV4USEast1ClientUSWest2BucketFail()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                if (runner.TestBucketIsReady)
                {
                    var url = await runner.USEast1Client.GetPreSignedURLAsync(runner.PreSignedUrlRequest);
                    var statusCode = await GetHttpStatusCode(url);
                    Assert.AreEqual(HttpStatusCode.BadRequest, statusCode);
                }
            }
        }

        [TestMethod]
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

        [TestMethod]
        public async Task GetBucketLocation()
        {
            using (var runner = await BucketRegionTestRunner.CreateAsync())
            {
                var nonUsEast1Bucket = await S3TestUtils.CreateBucketWithWaitAsync(runner.USWest1Client);
                try
                {
                    var nonNullocationResponse = await runner.USWest1Client.GetBucketLocationAsync(nonUsEast1Bucket);
                    Assert.IsNotNull(nonNullocationResponse.Location);
                    Assert.AreEqual(RegionEndpoint.USWest1.SystemName, nonNullocationResponse.Location.ToString());
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
                    Assert.IsTrue(string.IsNullOrEmpty(nullLocationResponse.Location));
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

        private async Task<HttpStatusCode> GetHttpStatusCode(string url)
        {
            var httpRequest = WebRequest.Create(url) as HttpWebRequest;
            try
            {
                using (var httpResponse = await httpRequest.GetResponseAsync() as HttpWebResponse)
                {
                    return httpResponse.StatusCode;
                }
            }
            catch (WebException we)
            {
                using (var errorResponse = we.Response as HttpWebResponse)
                {
                    return errorResponse.StatusCode;
                }
            }
        }
    }
}
