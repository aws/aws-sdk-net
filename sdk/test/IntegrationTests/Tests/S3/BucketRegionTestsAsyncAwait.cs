#if ASYNC_AWAIT
using Amazon;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class BucketRegionTestsAsyncAwait
    {
        [TestMethod]
        [TestCategory("S3")]
        public async Task HappyCaseSigV2()
        {
            // make sure we're not using the cache with SigV2 requests
            using (var runner = new BucketRegionTestRunner(false))
            {
                if (runner.TestBucketIsReady)
                {
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsFalse(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(null, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task HappyCaseSigV4()
        {
            // make sure the cache works when it gets the region from the response body
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task HappyCaseGetObjectMetedata()
        {
            // make sure the cache works when it gets the region from a HEAD bucket request
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    // ensure the object exists then clear the cache
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    BucketRegionDetector.BucketRegionCache.Clear();
                    await runner.USEast1Client.GetObjectMetadataAsync(runner.GetObjectMetadataRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task BucketRecreatedInDifferentRegion()
        {
            // make sure the cache gets refreshed when it should
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    BucketRegionDetector.BucketRegionCache.AddOrUpdate(runner.BucketName, RegionEndpoint.APNortheast2);
                    await runner.USEast1Client.PutObjectAsync(runner.PutObjectRequest);
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }
    }
}

#endif