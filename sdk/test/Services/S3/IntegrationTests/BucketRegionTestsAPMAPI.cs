#if AWS_APM_API
using Amazon;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{

    [TestClass]
    public class BucketRegionTestsAPMAPI
    {
        private readonly Guid testState = Guid.NewGuid();

        [TestMethod]
        [TestCategory("S3")]
        public void HappyCaseSigV2()
        {
            // make sure we're not using the cache with SigV2 requests
            using (var runner = new BucketRegionTestRunner(false))
            {
                if (runner.TestBucketIsReady)
                {
                    var result = BeginPutObject(runner);
                    result.AsyncWaitHandle.WaitOne();
                    RegionEndpoint cachedRegion;
                    Assert.IsFalse(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(null, cachedRegion);
                    // throw in an assertion to make sure the state makes the round trip correctly
                    Assert.AreEqual(testState, result.AsyncState);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void HappyCaseSigV4()
        {
            // make sure the cache works when it gets the region from the response body
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    BeginPutObject(runner).AsyncWaitHandle.WaitOne();
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void HappyCaseGetObjectMetedata()
        {
            // make sure the cache works when it gets the region from a HEAD bucket request
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    // ensure the object exists then clear the cache
                    BeginPutObject(runner).AsyncWaitHandle.WaitOne();
                    BucketRegionDetector.BucketRegionCache.Clear();
                    BeginGetObjectMetadata(runner).AsyncWaitHandle.WaitOne();
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BucketRecreatedInDifferentRegion()
        {
            // make sure the cache gets refreshed when it should
            using (var runner = new BucketRegionTestRunner(true))
            {
                if (runner.TestBucketIsReady)
                {
                    BucketRegionDetector.BucketRegionCache.AddOrUpdate(runner.BucketName, RegionEndpoint.APNortheast2);
                    BeginPutObject(runner).AsyncWaitHandle.WaitOne();
                    RegionEndpoint cachedRegion;
                    Assert.IsTrue(BucketRegionDetector.BucketRegionCache.TryGetValue(runner.BucketName, out cachedRegion));
                    Assert.AreEqual(RegionEndpoint.USWest1, cachedRegion);
                }
            }
        }

        private IAsyncResult BeginGetObjectMetadata(BucketRegionTestRunner runner)
        {
            return runner.USEast1Client.BeginGetObjectMetadata(runner.GetObjectMetadataRequest,
                new AsyncCallback(asyncResult => runner.USEast1Client.EndGetObjectMetadata(asyncResult)), testState);
        }

        private IAsyncResult BeginPutObject(BucketRegionTestRunner runner)
        {
            return runner.USEast1Client.BeginPutObject(runner.PutObjectRequest,
                new AsyncCallback(asyncResult => runner.USEast1Client.EndPutObject(asyncResult)), testState);
        }
    }
}
#endif
