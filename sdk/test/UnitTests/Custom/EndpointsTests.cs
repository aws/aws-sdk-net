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
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EndpointsTests
    {
        public class TestEndpointProvider : IEndpointProvider
        {
            public Endpoint ResolveEndpoint(EndpointParameters parameters)
            {
                return new Endpoint("https://localhost:7777");
            }
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverRetainsUriPortNumberWhenHttpIsEnforced()
        {
            var config = new MockClientConfig
            {
                EndpointProvider = new TestEndpointProvider(),
                UseHttp = true
            };
            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(new MockAmazonWebServiceRequest(), "test-service")
            };
            var executionContext = new ExecutionContext(requestContext, null);
            var resolver = new BaseEndpointResolver();
            resolver.ProcessRequestHandlers(executionContext);
            var endpoint = executionContext.RequestContext.Request.Endpoint;
            Assert.AreEqual(7777, endpoint.Port);
            Assert.AreEqual("http", endpoint.Scheme);
        }

        /// <summary>
        /// Asserts that UseHTTP=true does not manipulate 
        /// an explicit ServiceURL using HTTPS
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverHttpsServiceURLVsUseHttp()
        {
            var serviceURL = "https://service.amazonaws.com";

            var config = new MockClientConfig
            {
                EndpointProvider = new TestEndpointProvider(),
                ServiceURL = serviceURL,
                UseHttp = true
            };
            var originalRequest = new MockAmazonWebServiceRequest();
            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(originalRequest, "test-service"),
                OriginalRequest = originalRequest,
            };

            var executionContext = new ExecutionContext(requestContext, null);
            var resolver = new BaseEndpointResolver();
            resolver.ProcessRequestHandlers(executionContext);
            var endpoint = executionContext.RequestContext.Request.Endpoint;

            Assert.AreEqual("https", endpoint.Scheme);
        }

        /// <summary>
        /// Asserts that ClientConfig can override AuthenticationRegion
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void ClientConfigOverridesAuthenticationRegion()
        {
            var config = new MockClientConfig
            {
                EndpointProvider = new TestEndpointProvider(),
                AuthenticationRegion = "authentication-region"
            };

            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(new MockAmazonWebServiceRequest(), "test-service")
            };

            var executionContext = new ExecutionContext(requestContext, null);
            var resolver = new BaseEndpointResolver();
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual("authentication-region", executionContext.RequestContext.Request.AuthenticationRegion);
        }

        /// <summary>
        /// Counts how often the ruleset is evaluated and lets a test change the parameters between calls.
        /// </summary>
        private class CountingEndpointProvider : IEndpointProvider
        {
            public int Calls;

            public Endpoint ResolveEndpoint(EndpointParameters parameters)
            {
                Calls++;
                return new Endpoint("https://" + parameters["Region"] + ".localhost:7777", "{\"authSchemes\":[{\"name\":\"sigv4\"}]}", null);
            }
        }

        private class ParameterizedEndpointResolver : BaseEndpointResolver
        {
            public string Region = "us-east-1";

            protected override EndpointParameters MapEndpointsParameters(Amazon.Runtime.IRequestContext requestContext)
            {
                var parameters = new EndpointParameters();
                parameters["Region"] = Region;
                return parameters;
            }
        }

        private static ExecutionContext CreateExecutionContext(IEndpointProvider provider)
        {
            var config = new MockClientConfig { EndpointProvider = provider };
            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(new MockAmazonWebServiceRequest(), "test-service")
            };
            return new ExecutionContext(requestContext, null);
        }

        /// <summary>
        /// Resolving the endpoint twice for the same request (as the auth resolver and the endpoint resolver do for S3)
        /// evaluates the ruleset once and yields the same endpoint.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverReusesEndpointForUnchangedParameters()
        {
            var provider = new CountingEndpointProvider();
            var executionContext = CreateExecutionContext(provider);
            var resolver = new ParameterizedEndpointResolver();

            var first = resolver.GetEndpoint(executionContext);
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual(1, provider.Calls);
            Assert.AreSame(first.Attributes, executionContext.RequestContext.Request.EndpointAttributes);
            Assert.AreEqual("https://us-east-1.localhost:7777/", executionContext.RequestContext.Request.Endpoint.ToString());
        }

        /// <summary>
        /// Changed parameters on the same request context resolve again.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverResolvesAgainWhenParametersChange()
        {
            var provider = new CountingEndpointProvider();
            var executionContext = CreateExecutionContext(provider);
            var resolver = new ParameterizedEndpointResolver();

            resolver.GetEndpoint(executionContext);
            resolver.Region = "eu-west-1";
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual(2, provider.Calls);
            Assert.AreEqual("https://eu-west-1.localhost:7777/", executionContext.RequestContext.Request.Endpoint.ToString());
        }

        /// <summary>
        /// Resolvers that do not map parameters (the base implementation returns null) resolve on every call without failing.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverHandlesNullParameters()
        {
            var provider = new TestEndpointProvider();
            var executionContext = CreateExecutionContext(provider);
            var resolver = new BaseEndpointResolver();

            resolver.GetEndpoint(executionContext);
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual("https://localhost:7777/", executionContext.RequestContext.Request.Endpoint.ToString());
        }

        /// <summary>
        /// The auth resolver resolves the endpoint before the identity exists (S3 and others); a parameter
        /// that comes from the identity must make the endpoint resolver evaluate the ruleset again.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverDoesNotReuseEndpointResolvedBeforeIdentity()
        {
            var request = new Amazon.DynamoDBv2.Model.GetItemRequest();
            var executionContext = new ExecutionContext(new RequestContext(false, new NullSigner())
            {
                ClientConfig = new AmazonDynamoDBConfig { RegionEndpoint = RegionEndpoint.USEast1, AccountIdEndpointMode = AccountIdEndpointMode.PREFERRED },
                OriginalRequest = request,
                Request = new DefaultRequest(request, "DynamoDB"),
            }, null);

            // Auth resolver: identity not resolved yet
            var resolver = new AmazonDynamoDBEndpointResolver();
            var before = resolver.GetEndpoint(executionContext);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com/", before.URL);

            // Endpoint resolver: identity resolved in between
            executionContext.RequestContext.Identity = new BasicAWSCredentials("foo", "bar", "123456789012");
            resolver.ProcessRequestHandlers(executionContext);
            Assert.AreEqual("https://123456789012.ddb.us-east-1.amazonaws.com/", executionContext.RequestContext.Request.Endpoint.ToString());
        }

        /// <summary>
        /// Generated endpoint parameters keep their values in typed properties rather than the property bag, so
        /// the cache comparison must see those properties: equal values allow reuse, a changed value does not.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void TypedEndpointParametersCompareByPropertyValues()
        {
            var first = new Amazon.DynamoDBv2.Endpoints.DynamoDBEndpointParameters { Region = "us-east-1", AccountIdEndpointMode = "preferred" };
            var second = new Amazon.DynamoDBv2.Endpoints.DynamoDBEndpointParameters { Region = "us-east-1", AccountIdEndpointMode = "preferred" };
            Assert.IsTrue(first.ParametersEqual(second));

            second.AccountId = "123456789012";
            Assert.IsFalse(first.ParametersEqual(second));

            // A key set only through the indexer lives in the property bag and still participates.
            var third = new Amazon.DynamoDBv2.Endpoints.DynamoDBEndpointParameters { Region = "us-east-1", AccountIdEndpointMode = "preferred" };
            third["NotAModelParameter"] = "value";
            Assert.IsFalse(first.ParametersEqual(third));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void PropertyBagCreatesItsDictionaryOnTheFirstWrite()
        {
            var first = new EndpointParameters();
            var second = new EndpointParameters();
            Assert.IsNull(first["Region"]);
            Assert.IsTrue(first.ParametersEqual(second));

            first["Region"] = "us-east-1";
            Assert.AreEqual("us-east-1", first["Region"]);
            Assert.IsFalse(first.ParametersEqual(second));
            Assert.IsFalse(second.ParametersEqual(first));

            second["Region"] = "us-east-1";
            Assert.IsTrue(first.ParametersEqual(second));

            // A stored null is still a key, so it differs from a bag without that key.
            first["Endpoint"] = null;
            Assert.IsFalse(first.ParametersEqual(second));

            var partition = Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn.Partition("us-east-1");
            partition["custom"] = "value";
            var otherPartition = Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn.Partition("us-east-1");
            Assert.IsNull(otherPartition["custom"]);
            Assert.AreEqual(partition.dnsSuffix, otherPartition.dnsSuffix);
        }

        private const string AuthUrl = "https://example.amazonaws.com";

        private sealed class AuthResolverProbe : BaseAuthResolverHandler
        {
            public static List<IAuthSchemeOption> Retrieve(Endpoint endpoint) => RetrieveSchemesFromEndpoint(endpoint);

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext) => null;
        }

        // A BDD provider's shape: typed auth schemes, no attributes bag.
        private static Endpoint TypedEndpoint(params AuthScheme[] schemes) => new Endpoint(AuthUrl) { AuthSchemes = schemes };

        // The tree provider's shape: attributesJson parsed by PropertyBag.FromJsonElement.
        private static Endpoint BagEndpoint(string authSchemesJson) => new Endpoint(AuthUrl, "{\"authSchemes\":" + authSchemesJson + "}", null);

        private static DefaultRequest ApplyAuth(Endpoint endpoint, bool useDoubleEncodingBefore = true)
        {
            var request = new DefaultRequest(new GetObjectRequest(), "S3");
            request.UseDoubleEncoding = useDoubleEncodingBefore;
            BaseEndpointResolver.SetAuthenticationAndHeaders(request, endpoint);
            return request;
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void AttributesSynthesizeTreeShapedAuthSchemesFromTypedSchemes()
        {
            var endpoint = TypedEndpoint(
                new AuthScheme("sigv4a", "svc", null, new List<string> { "*" }, true),
                new AuthScheme("sigv4", null, null, null, null));

            ApplyAuth(endpoint);
            Assert.IsNull(endpoint.RawAttributesOrNull);

            var schemes = ((List<object>)endpoint.Attributes["authSchemes"]).Cast<PropertyBag>().ToList();
            Assert.AreSame(endpoint.Attributes, endpoint.RawAttributesOrNull);
            Assert.AreEqual("sigv4a", schemes[0]["name"]);
            Assert.AreEqual("svc", schemes[0]["signingName"]);
            Assert.IsNull(schemes[0]["signingRegion"]);
            CollectionAssert.AreEqual(new List<object> { "*" }, (List<object>)schemes[0]["signingRegionSet"]);
            Assert.AreEqual(true, schemes[0]["disableDoubleEncoding"]);
            Assert.IsNull(schemes[1]["disableDoubleEncoding"]);

            var withOtherAttribute = new Endpoint(AuthUrl, "{\"backend\":\"S3Express\"}", null)
            {
                AuthSchemes = new[] { new AuthScheme("sigv4-s3express", "s3express", "us-west-2", null, true) }
            };
            Assert.AreEqual("S3Express", withOtherAttribute.Attributes["backend"]);
            Assert.IsNotNull(withOtherAttribute.Attributes["authSchemes"]);

            var withAuthSchemes = BagEndpoint("[{\"name\":\"sigv4\",\"signingName\":\"original\"}]");
            withAuthSchemes.AuthSchemes = new[] { new AuthScheme("sigv4", "typed", null, null, null) };
            var provided = (PropertyBag)((List<object>)withAuthSchemes.Attributes["authSchemes"]).Single();
            Assert.AreEqual("original", provided["signingName"]);

            var reset = TypedEndpoint(new AuthScheme("sigv4", "first", null, null, null));
            Assert.IsNotNull(reset.Attributes);
            reset.Attributes = null;
            reset.AuthSchemes = new[] { new AuthScheme("sigv4", "second", null, null, null) };
            var rebuilt = (PropertyBag)((List<object>)reset.Attributes["authSchemes"]).Single();
            Assert.AreEqual("second", rebuilt["signingName"]);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void ConcurrentAttributesReadersShareOneSynthesizedBag()
        {
            // Cached endpoints are shared across threads: every reader must see one synthesized bag.
            const int Readers = 8;
            for (var iteration = 0; iteration < 500; iteration++)
            {
                var endpoint = TypedEndpoint(new AuthScheme("sigv4", "svc", "us-west-2", null, null));
                var bags = new IPropertyBag[Readers];
                var lists = new object[Readers];
                using (var start = new System.Threading.Barrier(Readers))
                {
                    var threads = Enumerable.Range(0, Readers).Select(i => new System.Threading.Thread(() =>
                    {
                        start.SignalAndWait();
                        bags[i] = endpoint.Attributes;
                        lists[i] = bags[i]["authSchemes"];
                    })).ToList();
                    threads.ForEach(t => t.Start());
                    threads.ForEach(t => t.Join());
                }

                Assert.IsTrue(bags.All(b => ReferenceEquals(b, bags[0])), $"Readers saw different bags (iteration {iteration}).");
                Assert.IsTrue(lists.All(l => ReferenceEquals(l, lists[0])), $"Readers saw different authSchemes lists (iteration {iteration}).");
                Assert.AreEqual(1, ((List<object>)lists[0]).Count);
            }
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void TypedAndBagAuthSchemesBehaveIdentically()
        {
            var cases = new (AuthScheme Typed, string Json)[]
            {
                (new AuthScheme("sigv4", "svc", "us-west-2", null, null),
                    "{\"name\":\"sigv4\",\"signingName\":\"svc\",\"signingRegion\":\"us-west-2\"}"),
                (new AuthScheme("sigv4a", "svc", null, new List<string> { "us-west-2", "us-east-1" }, null),
                    "{\"name\":\"sigv4a\",\"signingName\":\"svc\",\"signingRegionSet\":[\"us-west-2\",\"us-east-1\"]}"),
                (new AuthScheme("sigv4-s3express", "s3express", "us-west-2", null, true),
                    "{\"name\":\"sigv4-s3express\",\"signingName\":\"s3express\",\"signingRegion\":\"us-west-2\",\"disableDoubleEncoding\":true}"),
                (new AuthScheme("sigv4", null, null, null, false), "{\"name\":\"sigv4\",\"disableDoubleEncoding\":false}"),
            };

            foreach (var (typed, json) in cases)
            {
                // Both starting values, so "unset leaves it alone" differs from "explicit false sets it to true".
                foreach (var doubleEncodingBefore in new[] { true, false })
                {
                    var fromTyped = ApplyAuth(TypedEndpoint(typed), doubleEncodingBefore);
                    var fromBag = ApplyAuth(BagEndpoint("[" + json + "]"), doubleEncodingBefore);

                    var description = $"{typed.Name}, double encoding before: {doubleEncodingBefore}";
                    Assert.AreEqual(fromBag.SignatureVersion, fromTyped.SignatureVersion, description);
                    Assert.AreEqual(fromBag.AuthenticationRegion, fromTyped.AuthenticationRegion, description);
                    Assert.AreEqual(fromBag.OverrideSigningServiceName, fromTyped.OverrideSigningServiceName, description);
                    Assert.AreEqual(fromBag.UseDoubleEncoding, fromTyped.UseDoubleEncoding, description);
                }
            }

            Assert.ThrowsExactly<AmazonClientException>(() => ApplyAuth(TypedEndpoint(new AuthScheme("bearer", null, null, null, null))));
            Assert.ThrowsExactly<AmazonClientException>(() => ApplyAuth(BagEndpoint("[{\"name\":\"bearer\"}]")));
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void AuthResolverReadsTypedSchemesWithoutSynthesizingAttributes()
        {
            var typedEndpoint = TypedEndpoint(
                new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null),
                new AuthScheme("sigv4", null, null, null, null));
            var bagEndpoint = BagEndpoint("[{\"name\":\"sigv4a\",\"signingRegionSet\":[\"*\"]},{\"name\":\"sigv4\"}]");

            var typed = AuthResolverProbe.Retrieve(typedEndpoint);
            var bag = AuthResolverProbe.Retrieve(bagEndpoint);

            CollectionAssert.AreEqual(bag.Select(o => o.SchemeId).ToList(), typed.Select(o => o.SchemeId).ToList());
            Assert.IsNull(typedEndpoint.RawAttributesOrNull);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void UseS3ExpressSessionAuthReadsTypedSchemesThenFallsBackToTheBag()
        {
            var typedExpress = new DefaultRequest(new GetObjectRequest(), "S3");
            typedExpress.EndpointAuthSchemes = new List<AuthScheme> { new AuthScheme("sigv4-s3express", "s3", "us-east-1", null, null) };
            Assert.IsNull(typedExpress.EndpointAttributes);
            Assert.IsTrue(typedExpress.UseS3ExpressSessionAuth());

            var typedPlain = new DefaultRequest(new GetObjectRequest(), "S3");
            typedPlain.EndpointAuthSchemes = new List<AuthScheme> { new AuthScheme("sigv4", "s3", "us-east-1", null, null) };
            Assert.IsFalse(typedPlain.UseS3ExpressSessionAuth());

            var scheme = new PropertyBag();
            scheme["name"] = "sigv4-s3express";
            var attributes = new PropertyBag();
            attributes["authSchemes"] = new List<object> { scheme };
            var fromBag = new DefaultRequest(new GetObjectRequest(), "S3");
            fromBag.EndpointAttributes = attributes;
            Assert.IsNull(fromBag.EndpointAuthSchemes);
            Assert.IsTrue(fromBag.UseS3ExpressSessionAuth());

            Assert.IsFalse(new DefaultRequest(new GetObjectRequest(), "S3").UseS3ExpressSessionAuth());
        }
    }
}