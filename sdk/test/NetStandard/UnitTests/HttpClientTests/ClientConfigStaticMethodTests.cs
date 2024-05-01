using Amazon.Runtime;
using AWSSDK_DotNet.CommonTest.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace UnitTests
{
    public class ClientConfigStaticMethodTests
    {
        [Fact]
        [Trait("Category", "Core")]
        public void CacheHttpClients_False_NoFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = null;

            Assert.False(CacheHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CacheHttpClients_True_NoFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = null;

            Assert.True(CacheHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CacheHttpClients_False_BasicFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();

            Assert.False(CacheHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CacheHttpClients_True_BasicFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();

            Assert.True(CacheHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CacheHttpClients_False_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = true; // make sure this is ignored
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(false, true, null);

            Assert.False(CacheHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CacheHttpClients_True_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = false; // make sure this is ignored
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, null);

            Assert.True(CacheHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void DisposeHttpClients_False_NoFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = null;

            Assert.False(DisposeHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void DisposeHttpClients_True_NoFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = null;

            Assert.True(DisposeHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void DisposeHttpClients_False_BasicFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = true;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();

            Assert.False(DisposeHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void DisposeHttpClients_True_BasicFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = false;
            clientConfig.HttpClientFactory = new MyBasicClientFactory();

            Assert.True(DisposeHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void DisposeHttpClients_False_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = false; // make sure this is ignored
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, null);

            Assert.False(DisposeHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void DisposeHttpClients_True_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();

            clientConfig.CacheHttpClient = true; // make sure this is ignored
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, true, null);

            Assert.True(DisposeHttpClients(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CreateConfigUniqueString_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientCacheSize = 1234321;
            clientConfig.HttpClientFactory = null;

            Assert.Equal("AllowAutoRedirect:TrueCacheSize:1234321", CreateConfigUniqueString(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CreateConfigUniqueString_BasicFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyBasicClientFactory();

            Assert.Null(CreateConfigUniqueString(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void CreateConfigUniqueString_AdvancedFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, true, "abcxyz");

            Assert.Equal("abcxyz", CreateConfigUniqueString(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void UseGlobalHttpClientCache_True_NoFactory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = null;

            Assert.True(UseGlobalHttpClientCache(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void UseGlobalHttpClientCache_False_NoFactory1()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = null;
            clientConfig.ProxyCredentials = new MyCredentials();

            Assert.False(UseGlobalHttpClientCache(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void UseGlobalHttpClientCache_False_NoFactory2()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = null;
            clientConfig.SetWebProxy(new MyWebProxy());

            Assert.False(UseGlobalHttpClientCache(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void UseGlobalHttpClientCache_True_Factory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, "abcxyz");

            Assert.True(UseGlobalHttpClientCache(clientConfig));
        }

        [Fact]
        [Trait("Category", "Core")]
        public void UseGlobalHttpClientCache_False_Factory()
        {
            var clientConfig = new MyClientConfig();
            clientConfig.HttpClientFactory = new MyAdvancedClientFactory(true, false, null);

            Assert.False(UseGlobalHttpClientCache(clientConfig));
        }

        //
        // Helpers to call internal methods on ClientConfig
        //

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
