#if !NETFRAMEWORK
using Amazon.Runtime;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.HttpClientTests
{
    [TestClass]
    [TestCategory("Core")]
    public class ClientConfigStaticMethodTests
    {
        [TestMethod]
        public void CacheHttpClients_False_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = null;
            Assert.IsFalse(CacheHttpClients(clientConfig));
        }

        [TestMethod]
        public void CacheHttpClients_True_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = null;
            Assert.IsTrue(CacheHttpClients(clientConfig));
        }

        [TestMethod]
        public void CacheHttpClients_False_BasicFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();
            Assert.IsFalse(CacheHttpClients(clientConfig));
        }

        [TestMethod]
        public void CacheHttpClients_True_BasicFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();
            Assert.IsTrue(CacheHttpClients(clientConfig));
        }

        [TestMethod]
        public void CacheHttpClients_False_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(false, true, null);
            Assert.IsFalse(CacheHttpClients(clientConfig));
        }

        [TestMethod]
        public void CacheHttpClients_True_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, null);
            Assert.IsTrue(CacheHttpClients(clientConfig));
        }

        [TestMethod]
        public void DisposeHttpClients_False_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = null;
            Assert.IsFalse(DisposeHttpClients(clientConfig));
        }

        [TestMethod]
        public void DisposeHttpClients_True_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = null;
            Assert.IsTrue(DisposeHttpClients(clientConfig));
        }

        [TestMethod]
        public void DisposeHttpClients_False_BasicFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();
            Assert.IsFalse(DisposeHttpClients(clientConfig));
        }

        [TestMethod]
        public void DisposeHttpClients_True_BasicFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();
            Assert.IsTrue(DisposeHttpClients(clientConfig));
        }

        [TestMethod]
        public void DisposeHttpClients_False_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, null);
            Assert.IsFalse(DisposeHttpClients(clientConfig));
        }

        [TestMethod]
        public void DisposeHttpClients_True_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, true, null);
            Assert.IsTrue(DisposeHttpClients(clientConfig));
        }

        [TestMethod]
        public void CreateConfigUniqueString_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientCacheSize = 1234321;
            clientConfig.HttpClientFactory = null;
            Assert.AreEqual("AllowAutoRedirect:TrueCacheSize:1234321", CreateConfigUniqueString(clientConfig));
        }

        [TestMethod]
        public void CreateConfigUniqueString_BasicFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyBasicClientFactory();
            Assert.IsNull(CreateConfigUniqueString(clientConfig));
        }

        [TestMethod]
        public void CreateConfigUniqueString_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, true, "abcxyz");
            Assert.AreEqual("abcxyz", CreateConfigUniqueString(clientConfig));
        }

        [TestMethod]
        public void UseGlobalHttpClientCache_True_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = null;
            Assert.IsTrue(UseGlobalHttpClientCache(clientConfig));
        }

        [TestMethod]
        public void UseGlobalHttpClientCache_False_NoFactory1()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = null;
            clientConfig.ProxyCredentials = new MyCredentials();
            Assert.IsFalse(UseGlobalHttpClientCache(clientConfig));
        }

        [TestMethod]
        public void UseGlobalHttpClientCache_False_NoFactory2()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = null;
            clientConfig.SetWebProxy(new MyWebProxy());
            Assert.IsFalse(UseGlobalHttpClientCache(clientConfig));
        }

        [TestMethod]
        public void UseGlobalHttpClientCache_True_Factory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, "abcxyz");
            Assert.IsTrue(UseGlobalHttpClientCache(clientConfig));
        }

        [TestMethod]
        public void UseGlobalHttpClientCache_False_Factory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, null);
            Assert.IsFalse(UseGlobalHttpClientCache(clientConfig));
        }

        static bool CacheHttpClients(IClientConfig clientConfig)
        {
            return (bool)ReflectionHelpers.Invoke(typeof(ClientConfig), "CacheHttpClients", clientConfig);
        }

        static bool DisposeHttpClients(IClientConfig clientConfig)
        {
            return (bool)ReflectionHelpers.Invoke(typeof(ClientConfig), "DisposeHttpClients", clientConfig);
        }

        internal static string CreateConfigUniqueString(IClientConfig clientConfig)
        {
            return (string)ReflectionHelpers.Invoke(typeof(ClientConfig), "CreateConfigUniqueString", clientConfig);
        }

        internal static bool UseGlobalHttpClientCache(IClientConfig clientConfig)
        {
            return (bool)ReflectionHelpers.Invoke(typeof(ClientConfig), "UseGlobalHttpClientCache", clientConfig);
        }
    }
}
#endif
