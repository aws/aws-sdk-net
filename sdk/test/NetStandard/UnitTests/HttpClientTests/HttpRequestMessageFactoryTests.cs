using Amazon.Runtime;
using AWSSDK_DotNet.CommonTest.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace UnitTests
{
    public class HttpRequestMessageFactoryTests
    {
        private const int DefaultHttpCacheSize = 5;

        [Fact]
        [Trait("Category", "Core")]
        public void NoFactory_NoCache()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;

            RunTest(clientConfig, 1, false, false, null, null);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void NoFactory_LocalCache()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.SetWebProxy(new MyWebProxy()); // force local cache

            RunTest(clientConfig, 1, true, false, DefaultHttpCacheSize, null);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void NoFactory_GlobalCache()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;

            RunTest(clientConfig, 1, true, true, DefaultHttpCacheSize, "AllowAutoRedirect:TrueCacheSize:" + DefaultHttpCacheSize);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void WithFactory_NoCache()
        {
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(false, true, null);

            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;

            RunTest(clientConfig, DefaultHttpCacheSize * 2, false, false, null, null);
            Assert.Equal(DefaultHttpCacheSize * 2, myClientFactory.UncachedClients.Count);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void WithFactory_SDKLocalCache()
        {
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(true, false, null);

            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;

            RunTest(clientConfig, DefaultHttpCacheSize * 2, true, false, DefaultHttpCacheSize, null);
            Assert.Equal(DefaultHttpCacheSize, myClientFactory.UncachedClients.Count);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void WithFactory_SDKGlobalCache()
        {
            var configUniqueString = Guid.NewGuid().ToString();
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(true, false, configUniqueString);

            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;

            RunTest(clientConfig, DefaultHttpCacheSize * 2, true, true, DefaultHttpCacheSize, configUniqueString);
            Assert.Equal(DefaultHttpCacheSize, myClientFactory.UncachedClients.Count);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void WithFactory_ExternalCache()
        {
            var clientConfig = new MyClientConfig();
            var myClientFactory = new MyAdvancedClientFactory(false, false, null);

            clientConfig.HttpClientCacheSize = DefaultHttpCacheSize;
            clientConfig.HttpClientFactory = myClientFactory;

            RunTest(clientConfig, 1, false, false, null, null);
            var actualCacheSize = ((HttpClient[])ReflectionHelpers.Invoke(myClientFactory.ClientCache, "_clients")).Length;
            Assert.Equal(DefaultHttpCacheSize, actualCacheSize);
        }

        private void RunTest(
            IClientConfig clientConfig,
            int numRequests,
            bool expectHttpCache,
            bool expectGlobalHttpCache,
            int? expectedCacheSize,
            string expectedGlobalCacheKey)
        {
            // Use globalHttpClientCache as read-only so tests don't affect one another.
            var globalHttpClientCache = (IDictionary<string, HttpClientCache>)ReflectionHelpers.Invoke(typeof(HttpRequestMessageFactory), "_httpClientCaches");
            var requestFactory = new HttpRequestMessageFactory(clientConfig);

            for (int i = 0; i < numRequests; i++)
            {
                var request = requestFactory.CreateHttpRequest(new Uri("https://localhost/doesnotexist"));
            }

            var httpClientCache = (HttpClientCache)ReflectionHelpers.Invoke(requestFactory, "_httpClientCache");
            Assert.Equal(expectHttpCache, httpClientCache != null);

            // Check indirectly instead of looking at the Dictionary so tests don't affect one another.
            var useGlobalHttpClientCache = (bool)ReflectionHelpers.Invoke(requestFactory, "_useGlobalHttpClientCache");
            Assert.Equal(expectGlobalHttpCache, useGlobalHttpClientCache);

            if (expectGlobalHttpCache && expectedGlobalCacheKey != null)
            {
                Assert.Contains(globalHttpClientCache.Keys, x => x == expectedGlobalCacheKey);
            }

            if (expectedCacheSize.HasValue)
            {
                Assert.NotNull(httpClientCache);
                var actualCacheSize = ((HttpClient[])ReflectionHelpers.Invoke(httpClientCache, "_clients")).Length;
                Assert.Equal(expectedCacheSize.Value, actualCacheSize);
            }
        }
    }

}
