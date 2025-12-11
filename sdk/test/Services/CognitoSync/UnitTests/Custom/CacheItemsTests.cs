using Amazon.CognitoSync;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Reflection;

namespace AWSSDK.UnitTests.CognitoSync
{
    [TestClass]
    public class CacheItemsTests
    {
        [TestMethod]
        [TestCategory("CognitoSync")]
        public void CacheTest()
        {
            var syncRequestType = typeof(AmazonCognitoSyncRequest);
            var syncClientType = typeof(AmazonCognitoSyncClient);

            var allTypes = syncClientType.Assembly.GetTypes();
            var syncRequestTypes = allTypes.Where(t => t != syncRequestType && syncRequestType.IsAssignableFrom(t)).ToList();

            var cacheType = syncClientType.Assembly.GetType("Amazon.CognitoSync.Internal.CognitoCredentialsRetriever+CSRequestCache");
            var dictionary = cacheType.GetField("requestCache", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null) as System.Collections.IDictionary;

            Assert.AreEqual(syncRequestTypes.Count, dictionary.Count);
            foreach (var syncRequest in syncRequestTypes)
            {
                Assert.IsTrue(dictionary.Contains(syncRequest), "Method cache does not contain EC2 request type {0}", syncRequest.Name);
            }
        }
    }
}
