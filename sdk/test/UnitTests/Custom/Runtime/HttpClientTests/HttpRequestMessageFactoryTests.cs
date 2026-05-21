#if !NETFRAMEWORK
using Amazon.Runtime;
using AWSSDK_DotNet.CommonTest.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.HttpClientTests
{
    [TestClass]
    [TestCategory("Core")]
    public class HttpRequestMessageFactoryTests
    {
        private const int DefaultHttpCacheSize = 5;

        [TestMethod]
        public void NoFactory_NoCache()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;
            RunTest(clientConfig, 1, false, false, null, null);
        }

        [TestMethod]
        public void NoFactory_LocalCache()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.SetWebProxy(new MyWebProxy());
            RunTest(clientConfig, 1, true, false, DefaultHttpCacheSize, null);
        }

        [TestMethod]
        public void NoFactory_GlobalCache()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            RunTest(clientConfig, 1, true, true, DefaultHttpCacheSize, "AllowAutoRedirect:TrueCacheSize:" + DefaultHttpCacheSize);
        }

        [TestMethod]
        public void WithFactory_NoCache()
        {
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(false, true, null);
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;
            RunTest(clientConfig, DefaultHttpCacheSize * 2, false, false, null, null);
            Assert.AreEqual(DefaultHttpCacheSize * 2, myClientFactory.UncachedClients.Count);
        }

        [TestMethod]
        public void WithFactory_SDKLocalCache()
        {
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(true, false, null);
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;
            RunTest(clientConfig, DefaultHttpCacheSize * 2, true, false, DefaultHttpCacheSize, null);
            Assert.AreEqual(DefaultHttpCacheSize, myClientFactory.UncachedClients.Count);
        }

        [TestMethod]
        public void WithFactory_SDKGlobalCache()
        {
            var configUniqueString = Guid.NewGuid().ToString();
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(true, false, configUniqueString);
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;
            RunTest(clientConfig, DefaultHttpCacheSize * 2, true, true, DefaultHttpCacheSize, configUniqueString);
            Assert.AreEqual(DefaultHttpCacheSize, myClientFactory.UncachedClients.Count);
        }

        [TestMethod]
        public void WithFactory_ExternalCache()
        {
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(false, false, null);
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;
            RunTest(clientConfig, 1, false, false, null, null);
            var actualCacheSize = ((HttpClient[])ReflectionHelpers.Invoke(myClientFactory.ClientCache, "_clients")).Length;
            Assert.AreEqual(DefaultHttpCacheSize, actualCacheSize);
        }

        private void RunTest(
            IClientConfig clientConfig,
            int numRequests,
            bool expectHttpCache,
            bool expectGlobalHttpCache,
            int? expectedCacheSize,
            string expectedGlobalCacheKey)
        {
            var globalHttpClientCache = (IDictionary<string, HttpClientCache>)ReflectionHelpers.Invoke(typeof(HttpRequestMessageFactory), "_httpClientCaches");
            var requestFactory = new HttpRequestMessageFactory(clientConfig);

            for (int i = 0; i < numRequests; i++)
            {
                var request = requestFactory.CreateHttpRequest(new Uri("https://localhost/doesnotexist"));
            }

            var httpClientCache = (HttpClientCache)ReflectionHelpers.Invoke(requestFactory, "_httpClientCache");
            Assert.AreEqual(expectHttpCache, httpClientCache != null);

            var useGlobalHttpClientCache = (bool)ReflectionHelpers.Invoke(requestFactory, "_useGlobalHttpClientCache");
            Assert.AreEqual(expectGlobalHttpCache, useGlobalHttpClientCache);

            if (expectGlobalHttpCache && expectedGlobalCacheKey != null)
            {
                Assert.IsTrue(globalHttpClientCache.ContainsKey(expectedGlobalCacheKey));
            }

            if (expectedCacheSize.HasValue)
            {
                Assert.IsNotNull(httpClientCache);
                var actualCacheSize = ((HttpClient[])ReflectionHelpers.Invoke(httpClientCache, "_clients")).Length;
                Assert.AreEqual(expectedCacheSize.Value, actualCacheSize);
            }
        }
    }
}
#endif
