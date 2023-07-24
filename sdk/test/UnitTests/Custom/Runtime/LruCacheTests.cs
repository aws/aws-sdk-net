using Amazon;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class LruCacheTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestLruCacheTryGetValue()
        {
            RegionEndpoint regionEndpoint;
            var lru = new LruCache<string, RegionEndpoint>(5);

            lru.AddOrUpdate("my-bucket-us-east-1", RegionEndpoint.USEast1);
            lru.AddOrUpdate("my-bucket-us-west-2", RegionEndpoint.USWest2);
            lru.AddOrUpdate("my-bucket-ap-northeast-2", RegionEndpoint.APNortheast2);
            lru.AddOrUpdate("my-bucket-sa-east-1", RegionEndpoint.SAEast1);

            lru.TryGetValue("my-bucket-us-west-2", out regionEndpoint);
            Assert.AreEqual(RegionEndpoint.USWest2, regionEndpoint);

            lru.TryGetValue("my-bucket-ap-northeast-2", out regionEndpoint);
            Assert.AreEqual(RegionEndpoint.APNortheast2, regionEndpoint);
        }
    }
}
