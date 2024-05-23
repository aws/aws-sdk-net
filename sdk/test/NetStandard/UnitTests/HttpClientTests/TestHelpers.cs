using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Amazon;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;

namespace UnitTests
{
    public class MyClientConfig : ClientConfig
    {
        public override string ServiceVersion => throw new NotImplementedException();

        public override string UserAgent => throw new NotImplementedException();

        public override string RegionEndpointServiceName => "";

        public MyClientConfig() 
            : base(new DummyDefaultConfigurationProvider())
        {
        }

        private class DummyDefaultConfigurationProvider : IDefaultConfigurationProvider
        {
            public IDefaultConfiguration GetDefaultConfiguration(
                RegionEndpoint clientRegion,
                DefaultConfigurationMode? requestedConfigurationMode = null)
            {
                return new DefaultConfiguration();
            }
        }

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="parameters">A Container class for parameters used for endpoint resolution.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            // If the current service doesn't have an endpoint rule set (which is the case for configs
            // that are used for testing), we'll return a placeholder endpoint so that unit tests pass.
            return new Endpoint(this.ServiceURL ?? "https://example.com");
        }
    }

    public class MyHttpClient : HttpClient
    {
        public int InstanceNumber { get; private set; }

        public MyHttpClient(int instanceNumber)
        {
            InstanceNumber = instanceNumber;
        }
    }

    public class MyBasicClientFactory : HttpClientFactory
    {
        private int _clientCount;

        public override HttpClient CreateHttpClient(IClientConfig clientConfig)
        {
            return new MyHttpClient(_clientCount++);
        }
    }

    public class MyAdvancedClientFactory : HttpClientFactory
    {
        private readonly object _cacheLock = new object();

        private bool _useSDKHttpClientCaching;
        private bool _disposeHttpClientsAfterUse;
        private string _configUniqueString;

        public HttpClientCache ClientCache { get; private set; }

        public List<MyHttpClient> UncachedClients { get; private set; }

        public MyAdvancedClientFactory(bool useSDKHttpClientCaching, bool disposeHttpClientsAfterUse, string configUniqueString)
        {
            _useSDKHttpClientCaching = useSDKHttpClientCaching;
            _disposeHttpClientsAfterUse = disposeHttpClientsAfterUse;
            _configUniqueString = configUniqueString;
            UncachedClients = new List<MyHttpClient>();
        }

        public override HttpClient CreateHttpClient(IClientConfig clientConfig)
        {
            if (!_useSDKHttpClientCaching && !_disposeHttpClientsAfterUse)
            {
                // assume we're doing the caching
                lock (_cacheLock)
                {
                    if (ClientCache == null)
                    {
                        var clients = new HttpClient[clientConfig.HttpClientCacheSize];
                        for (int i = 0; i < clientConfig.HttpClientCacheSize; i++)
                        {
                            clients[i] = new MyHttpClient(i);
                        }
                        ClientCache = new HttpClientCache(clients);
                    }
                }
                return ClientCache.GetNextClient();
            }
            else
            {
                // there is no caching or at least we're not doing it here
                UncachedClients.Add(new MyHttpClient(UncachedClients.Count));
                return UncachedClients[UncachedClients.Count - 1];
            }
        }

        public override bool UseSDKHttpClientCaching(IClientConfig clientConfig)
        {
            return _useSDKHttpClientCaching;
        }

        public override bool DisposeHttpClientsAfterUse(IClientConfig clientConfig)
        {
            return _disposeHttpClientsAfterUse;
        }

        public override string GetConfigUniqueString(IClientConfig clientConfig)
        {
            return _configUniqueString;
        }
    }

    public class MyCredentials : ICredentials
    {
        public NetworkCredential GetCredential(Uri uri, string authType)
        {
            throw new NotImplementedException();
        }
    }

    public class MyWebProxy : IWebProxy
    {
        public ICredentials Credentials { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Uri GetProxy(Uri destination)
        {
            throw new NotImplementedException();
        }

        public bool IsBypassed(Uri host)
        {
            throw new NotImplementedException();
        }
    }
}
