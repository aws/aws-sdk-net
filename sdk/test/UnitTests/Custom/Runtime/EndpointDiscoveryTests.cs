/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Moq;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExecutionContext = Amazon.Runtime.Internal.ExecutionContext;
using Amazon.Runtime.Internal.Util;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EndpointDiscoveryTests
    {
        private const string AWS_ACCESS_KEY_ID = "test";
        private const string IDENTIFIER_NAME = "name";
        private const string CACHEKEY = AWS_ACCESS_KEY_ID;
        private const string CACHEKEY_IDENTIFIERS = AWS_ACCESS_KEY_ID + ".CreateTable.test";

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ConfigTestSetValues()
        {
            var config = SetupConfig(true, 10);
            Assert.IsTrue(config.EndpointDiscoveryEnabled);
            Assert.AreEqual(10, config.EndpointDiscoveryCacheLimit);
        }

        [DataTestMethod]
        [DataRow(null, "https://test123.amazonaws.com/shared/")]
        [DataRow("http://test123.amazonaws.com/shared", "http://test123.amazonaws.com/shared/")]
        [DataRow("Http://test123.amazonaws.com/shared", "http://test123.amazonaws.com/shared/")]
        [DataRow("test123.amazonaws.com/shared", "https://test123.amazonaws.com/shared/")]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequiredNoIdentifiers(string endpoint, string expectedEndpoint)
        {
            var config = SetupConfig();
            var client = new EndpointDiscoveryTestClient(config, baseUrl: endpoint);
            var executionContext = CreateExecutionContext(client, config, true, null);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual(expectedEndpoint,
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
            var endpoints = client.WaitForCachedValue(CACHEKEY);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, expectedEndpoint));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequiredNoIdentifiersCached()
        {
            var config = SetupConfig();
            var client = new EndpointDiscoveryTestClient(config);
            var executionContext = CreateExecutionContext(client, config, true, null);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual("https://test123.amazonaws.com/shared/",
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(1, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
            var endpoints = client.WaitForCachedValue(CACHEKEY);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/"));

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual("https://test123.amazonaws.com/shared/",
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(2, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
            endpoints = client.WaitForCachedValue(CACHEKEY);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequiredNoIdentifiersEvictCache()
        {
            var config = SetupConfig();
            var client = new EndpointDiscoveryTestClient(config);
            var executionContext = CreateExecutionContext(client, config, true, null);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual("https://test123.amazonaws.com/shared/",
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(1, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
            var endpoints = client.WaitForCachedValue(CACHEKEY);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/"));

            //Eviction happens on a invalid endpoint exception. In this case the endpoint is currently set to the invalid endpoint.
            executionContext.RequestContext.Request.Endpoint = new Uri("https://test123.amazonaws.com/shared/");
            EndpointDiscoveryHandler.EvictCacheKeyForRequest(executionContext.RequestContext, null, immutableCredentials);
            Assert.IsNull(executionContext.RequestContext.Request.Endpoint);
            Assert.AreEqual(2, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(0, client.CacheCount);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual("https://test123.amazonaws.com/shared/",
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(3, client.EndpointOperationCallCount);
            Assert.AreEqual(2, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
            endpoints = client.WaitForCachedValue(CACHEKEY);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequiredWithIdentifiers()
        {
            var config = SetupConfig();
            var client = new EndpointDiscoveryTestClient(config);
            SortedDictionary<string, string> identifiers = new SortedDictionary<string, string>();
            identifiers.Add(IDENTIFIER_NAME, "test");
            var executionContext = CreateExecutionContext(client, config, true, identifiers);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual("https://test123.amazonaws.com/shared/CreateTable",
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
            var endpoints = client.WaitForCachedValue(CACHEKEY_IDENTIFIERS);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/CreateTable"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequiredWithIdentifiersCached()
        {
            var config = SetupConfig();
            var client = new EndpointDiscoveryTestClient(config);
            SortedDictionary<string, string> identifiers = new SortedDictionary<string, string>();
            identifiers.Add(IDENTIFIER_NAME, "test");
            var executionContext = CreateExecutionContext(client, config, true, identifiers);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual("https://test123.amazonaws.com/shared/CreateTable",
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(1, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
            var endpoints = client.WaitForCachedValue(CACHEKEY_IDENTIFIERS);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/CreateTable"));

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            Assert.AreEqual("https://test123.amazonaws.com/shared/CreateTable",
                executionContext.RequestContext.Request.Endpoint.ToString());
            Assert.AreEqual(2, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RequiredNoIdentifiersFailedDiscovery()
        {
            var config = SetupConfig();
            var client = new EndpointDiscoveryTestClient(config, true);
            SortedDictionary<string, string> identifiers = new SortedDictionary<string, string>();
            identifiers.Add(IDENTIFIER_NAME, "test");
            var executionContext = CreateExecutionContext(client, config, true, identifiers);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            Utils.AssertExceptionExpected(
                () => { EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials); },
                typeof(AmazonClientException));

            Assert.AreEqual(1, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(0, client.CacheCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NotRequiredNoIdentifiersFailedDiscoveryWait()
        {
            var config = SetupConfig(true);
            var client = new EndpointDiscoveryTestClient(config, true);
            var executionContext = CreateExecutionContext(client, config, false, null);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            var endpoints = client.WaitForCachedValue(CACHEKEY);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, null));

            Assert.AreEqual(1, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NotRequiredEnabledNoIdentifiersWait()
        {
            var config = SetupConfig(true);
            var client = new EndpointDiscoveryTestClient(config);
            var executionContext = CreateExecutionContext(client, config, false, null);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            var endpoints = client.WaitForCachedValue(CACHEKEY);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/"));
            Assert.AreEqual(1, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NotRequiredEnabledHasIdentifiersWait()
        {
            var config = SetupConfig(true);
            var client = new EndpointDiscoveryTestClient(config);
            SortedDictionary<string, string> identifiers = new SortedDictionary<string, string>();
            identifiers.Add(IDENTIFIER_NAME, "test");
            var executionContext = CreateExecutionContext(client, config, false, identifiers);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);
            var endpoints = client.WaitForCachedValue(CACHEKEY_IDENTIFIERS);
            Assert.IsNotNull(endpoints);
            Assert.IsTrue(HasEndpointAddress(endpoints, "https://test123.amazonaws.com/shared/CreateTable"));
            Assert.AreEqual(1, client.EndpointOperationCallCount);
            Assert.AreEqual(1, client.FetchCallCount);
            Assert.AreEqual(1, client.CacheCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NotRequiredNoIdentifiersFailedDiscoveryNoWait()
        {
            var config = SetupConfig(true);
            var client = new EndpointDiscoveryTestClient(config, true);
            var executionContext = CreateExecutionContext(client, config, false, null);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);

            //Verify the endpoint has not been touched by the endpoint discovery resolver
            Assert.IsNull(executionContext.RequestContext.Request.Endpoint);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NotRequiredEnabledNoIdentifiersNoWait()
        {
            var config = SetupConfig(true);
            var client = new EndpointDiscoveryTestClient(config);
            var executionContext = CreateExecutionContext(client, config, false, null);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);

            //Verify the endpoint has not been touched by the endpoint discovery resolver
            Assert.IsNull(executionContext.RequestContext.Request.Endpoint);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NotRequiredEnabledHasIdentifiersNoWait()
        {
            var config = SetupConfig(true);
            var client = new EndpointDiscoveryTestClient(config);
            SortedDictionary<string, string> identifiers = new SortedDictionary<string, string>();
            identifiers.Add(IDENTIFIER_NAME, "test");
            var executionContext = CreateExecutionContext(client, config, false, identifiers);
            var immutableCredentials = GetCredentialsFromContext(executionContext);

            EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);

            //Verify the endpoint has not been touched by the endpoint discovery resolver
            Assert.IsNull(executionContext.RequestContext.Request.Endpoint);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CacheEvictionTestUsingEndpointDiscoveryCallStack()
        {
            var oldUtcNowSource = GetUtcNowSource();
            var currentDateTime = new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            try
            {
                SetUtcNowSource(() => currentDateTime);

                var config = SetupConfig();
                var client = new EndpointDiscoveryTestClient(config);
                var executionContext = CreateExecutionContext(client, config, true, null);
                var immutableCredentials = GetCredentialsFromContext(executionContext);
                EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);

                Assert.AreEqual(1, client.CacheCount);

                // Jump in the future so the endpoint we just cached will be evicted the next time we do discovery
                SetUtcNowSource(() => currentDateTime.AddDays(1));
                
                var awsCredentials = new Mock<AWSCredentials>();
                awsCredentials.Setup(e => e.GetCredentials()).Returns(new ImmutableCredentials("AWS_ACCESS_KEY_ID" + "2", "test2", "test2"));
                executionContext.RequestContext.Identity = awsCredentials.Object;
                EndpointDiscoveryHandler.DiscoverEndpoints(executionContext.RequestContext, false, immutableCredentials);

                // First endpoint should be evicted, leaving us with only the second one
                Assert.AreEqual(1, client.CacheCount);
            }
            finally
            {
                SetUtcNowSource(oldUtcNowSource);
            }
        }

        private static Func<DateTime> GetUtcNowSource()
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            return (Func<DateTime>)field.GetValue(null);
        }

        private static void SetUtcNowSource(Func<DateTime> source)
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, source);
        }

        private ExecutionContext CreateExecutionContext(EndpointDiscoveryTestClient client, AmazonDynamoDBConfig config,
            bool required, SortedDictionary<string, string> identifiers)
        {
            var request = new CreateTableRequest();
            var options = new InvokeOptions();

            options.RequestMarshaller = new CreateTableRequestMarshaller();
            options.EndpointDiscoveryMarshaller = new TestEndpointDiscoveryMarshaller(required, identifiers);
            client.SetOptionsEndpointOperation(options);

            var awsCredentials = new Mock<AWSCredentials>();
            awsCredentials.Setup(e => e.GetCredentials()).Returns(new ImmutableCredentials(AWS_ACCESS_KEY_ID, "test", "test"));
            
            var executionContext = new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = config,
                    Request = options.RequestMarshaller.Marshall(request),
                    Identity = awsCredentials.Object,
                    OriginalRequest = request,
                    Options = options
                },
                new ResponseContext()
            );

            return executionContext;
        }

        private static AmazonDynamoDBConfig SetupConfig(bool? endpointDiscoveryEnabled = null, int? cacheLimit = null)
        {
            var config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };

            if (endpointDiscoveryEnabled != null)
            {
                config.EndpointDiscoveryEnabled = endpointDiscoveryEnabled.Value;
            }

            if (cacheLimit != null)
            {
                config.EndpointDiscoveryCacheLimit = cacheLimit.Value;
            }

            return config;
        }

        private bool HasEndpointAddress(IEnumerable<DiscoveryEndpointBase> endpoints, string address)
        {
            return endpoints.Any(endpoint =>
                string.Equals(endpoint?.Address, address, StringComparison.OrdinalIgnoreCase));
        }

        private ImmutableCredentials GetCredentialsFromContext(ExecutionContext executionContext)
        {
            if (executionContext.RequestContext.Identity is AWSCredentials credentials)
            {
                return credentials.GetCredentials();
            }

            return null;
        }
    }

    public class EndpointDiscoveryTestClient : AmazonDynamoDBClient
    {
        private bool _failEndpointOperation = false;
        private readonly string _baseUrl;
        public int FetchCallCount { get; set; }
        public int EndpointOperationCallCount { get; set; }


        public EndpointDiscoveryTestClient(AmazonDynamoDBConfig config, bool failEndpointOperation = false,
            string baseUrl = null) : base(config)
        {
            FetchCallCount = 0;
            _failEndpointOperation = failEndpointOperation;
            _baseUrl = baseUrl ?? "https://test123.amazonaws.com/shared";
        }

        protected override IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
        {
            EndpointOperationCallCount++;

            return EndpointDiscoveryResolver.ResolveEndpoints(context, () =>
            {
                FetchCallCount++;
                if (_failEndpointOperation)
                {
                    return null;
                }

                var endpoints = new List<DiscoveryEndpointBase>();
                endpoints.Add(
                    new DiscoveryEndpoint(string.Format("{0}/{1}", _baseUrl, context.OperationName), 5));
                return endpoints;
            });
        }

        public void SetOptionsEndpointOperation(InvokeOptions options)
        {
            options.EndpointOperation = EndpointOperation;
        }

        public int CacheCount
        {
            get { return EndpointDiscoveryResolver.CacheCount; }
        }

        public IEnumerable<DiscoveryEndpointBase> CacheValue(string key)
        {
            return EndpointDiscoveryResolver.GetDiscoveryEndpointsFromCache(key);
        }

        public IEnumerable<DiscoveryEndpointBase> WaitForCachedValue(string key)
        {
            IEnumerable<DiscoveryEndpointBase> endpoints = null;
            for (var i = 0; i < 150; i++)
            {
                if ((endpoints = CacheValue(key)) == null)
                {
                    Thread.Sleep(100);
                    continue;
                }

                break;
            }

            return endpoints;
        }
    }

    public class TestEndpointDiscoveryMarshaller : IMarshaller<EndpointDiscoveryDataBase, CreateTableRequest>,
        IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest>
    {
        private bool _required;
        private SortedDictionary<string, string> _identifiers;

        public TestEndpointDiscoveryMarshaller(bool required, SortedDictionary<string, string> identifiers) : base()
        {
            _required = required;
            _identifiers = identifiers;
        }

        public EndpointDiscoveryDataBase Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTableRequest)input);
        }

        public EndpointDiscoveryDataBase Marshall(CreateTableRequest publicRequest)
        {
            var endpointDiscoveryData = new EndpointDiscoveryData(_required);
            if (_identifiers != null)
            {
                foreach (var identifier in _identifiers)
                {
                    endpointDiscoveryData.Identifiers.Add(identifier.Key, identifier.Value);
                }
            }

            return endpointDiscoveryData;
        }
    }
}