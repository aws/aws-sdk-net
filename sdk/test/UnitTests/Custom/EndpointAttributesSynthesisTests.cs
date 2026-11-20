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
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EndpointAttributesSynthesisTests
    {
        private const string Url = "https://example.amazonaws.com";

        private sealed class AuthResolverProbe : BaseAuthResolverHandler
        {
            public static List<IAuthSchemeOption> Retrieve(Endpoint endpoint) => RetrieveSchemesFromEndpoint(endpoint);

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext) => null;
        }

        private static Endpoint TypedEndpoint(params AuthScheme[] schemes)
        {
            return new Endpoint(Url) { AuthSchemes = schemes };
        }

        // The tree provider's shape: attributesJson parsed by PropertyBag.FromJsonElement.
        private static Endpoint BagEndpoint(string authSchemesJson)
        {
            return new Endpoint(Url, "{\"authSchemes\":" + authSchemesJson + "}", null);
        }

        private static DefaultRequest Apply(Endpoint endpoint, bool useDoubleEncodingBefore = true)
        {
            var request = new DefaultRequest(new GetObjectRequest(), "S3");
            request.UseDoubleEncoding = useDoubleEncodingBefore;
            BaseEndpointResolver.SetAuthenticationAndHeaders(request, endpoint);
            return request;
        }

        private static void AssertSameAuth(DefaultRequest typed, DefaultRequest bag)
        {
            Assert.AreEqual(bag.SignatureVersion, typed.SignatureVersion);
            Assert.AreEqual(bag.AuthenticationRegion, typed.AuthenticationRegion);
            Assert.AreEqual(bag.OverrideSigningServiceName, typed.OverrideSigningServiceName);
            Assert.AreEqual(bag.UseDoubleEncoding, typed.UseDoubleEncoding);
        }

        [TestMethod]
        public void AuthOnlyEndpointNeverAllocatesRawAttributes()
        {
            var endpoint = TypedEndpoint(new AuthScheme("sigv4", "svc", "us-west-2", null, null));

            Apply(endpoint);

            Assert.IsNull(endpoint.RawAttributesOrNull);
        }

        [TestMethod]
        public void AttributesSynthesizesTreeShapedAuthSchemes()
        {
            var endpoint = TypedEndpoint(new AuthScheme("sigv4a", "svc", null, new List<string> { "*" }, true));

            var authSchemes = endpoint.Attributes["authSchemes"] as List<object>;

            Assert.IsNotNull(authSchemes);
            var scheme = (PropertyBag)authSchemes.Single();
            Assert.AreEqual("sigv4a", scheme["name"]);
            Assert.AreEqual("svc", scheme["signingName"]);
            Assert.IsNull(scheme["signingRegion"]);
            CollectionAssert.AreEqual(new List<object> { "*" }, (List<object>)scheme["signingRegionSet"]);
            Assert.AreEqual(true, scheme["disableDoubleEncoding"]);
            Assert.AreSame(endpoint.Attributes, endpoint.RawAttributesOrNull);
        }

        [TestMethod]
        public void AttributesOmitsUnsetDisableDoubleEncoding()
        {
            var endpoint = TypedEndpoint(new AuthScheme("sigv4", null, null, null, null));

            var scheme = (PropertyBag)((List<object>)endpoint.Attributes["authSchemes"]).Single();

            Assert.IsNull(scheme["disableDoubleEncoding"]);
        }

        [TestMethod]
        public void AttributesMergesIntoExistingBag()
        {
            var endpoint = new Endpoint(Url, "{\"backend\":\"S3Express\"}", null)
            {
                AuthSchemes = new[] { new AuthScheme("sigv4-s3express", "s3express", "us-west-2", null, true) }
            };

            Assert.AreEqual("S3Express", endpoint.Attributes["backend"]);
            Assert.IsNotNull(endpoint.Attributes["authSchemes"]);
        }

        [TestMethod]
        public void AttributesKeepsProviderSuppliedAuthSchemes()
        {
            var endpoint = BagEndpoint("[{\"name\":\"sigv4\",\"signingName\":\"original\"}]");
            endpoint.AuthSchemes = new[] { new AuthScheme("sigv4", "typed", null, null, null) };

            var scheme = (PropertyBag)((List<object>)endpoint.Attributes["authSchemes"]).Single();

            Assert.AreEqual("original", scheme["signingName"]);
        }

        [TestMethod]
        public void ResettingAuthSchemesRebuildsSynthesizedBag()
        {
            var endpoint = new Endpoint(Url);
            endpoint.AuthSchemes = new[] { new AuthScheme("sigv4", "first", null, null, null) };
            Assert.IsNotNull(endpoint.Attributes);

            endpoint.Attributes = null;
            endpoint.AuthSchemes = new[] { new AuthScheme("sigv4", "second", null, null, null) };

            var scheme = (PropertyBag)((List<object>)endpoint.Attributes["authSchemes"]).Single();
            Assert.AreEqual("second", scheme["signingName"]);
        }

        [TestMethod]
        public void TypedAndBagSigV4Match()
        {
            AssertSameAuth(
                Apply(TypedEndpoint(new AuthScheme("sigv4", "svc", "us-west-2", null, null))),
                Apply(BagEndpoint("[{\"name\":\"sigv4\",\"signingName\":\"svc\",\"signingRegion\":\"us-west-2\"}]")));
        }

        [TestMethod]
        public void TypedAndBagSigV4aMatch()
        {
            AssertSameAuth(
                Apply(TypedEndpoint(new AuthScheme("sigv4a", "svc", null, new List<string> { "us-west-2", "us-east-1" }, null))),
                Apply(BagEndpoint("[{\"name\":\"sigv4a\",\"signingName\":\"svc\",\"signingRegionSet\":[\"us-west-2\",\"us-east-1\"]}]")));
        }

        [TestMethod]
        public void TypedAndBagS3ExpressMatch()
        {
            AssertSameAuth(
                Apply(TypedEndpoint(new AuthScheme("sigv4-s3express", "s3express", "us-west-2", null, true))),
                Apply(BagEndpoint("[{\"name\":\"sigv4-s3express\",\"signingName\":\"s3express\",\"signingRegion\":\"us-west-2\",\"disableDoubleEncoding\":true}]")));
        }

        [TestMethod]
        public void TypedAndBagDisableDoubleEncodingStatesMatch()
        {
            // Start from false so "unset leaves it alone" is distinguishable from "explicit false sets true".
            foreach (var (typedValue, json) in new (bool?, string)[]
            {
                (null, ""),
                (false, ",\"disableDoubleEncoding\":false"),
                (true, ",\"disableDoubleEncoding\":true"),
            })
            {
                var typed = Apply(TypedEndpoint(new AuthScheme("sigv4", null, null, null, typedValue)), useDoubleEncodingBefore: false);
                var bag = Apply(BagEndpoint("[{\"name\":\"sigv4\"" + json + "}]"), useDoubleEncodingBefore: false);

                Assert.AreEqual(bag.UseDoubleEncoding, typed.UseDoubleEncoding, $"disableDoubleEncoding={typedValue}");
            }
        }

        [TestMethod]
        public void TypedUnsupportedSchemeThrowsLikeBag()
        {
            Assert.ThrowsExactly<AmazonClientException>(() => Apply(TypedEndpoint(new AuthScheme("bearer", null, null, null, null))));
            Assert.ThrowsExactly<AmazonClientException>(() => Apply(BagEndpoint("[{\"name\":\"bearer\"}]")));
        }

        [TestMethod]
        public void RetrieveSchemesFromEndpointTypedMatchesBag()
        {
            var typed = AuthResolverProbe.Retrieve(TypedEndpoint(
                new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null),
                new AuthScheme("sigv4", null, null, null, null)));
            var bag = AuthResolverProbe.Retrieve(BagEndpoint("[{\"name\":\"sigv4a\",\"signingRegionSet\":[\"*\"]},{\"name\":\"sigv4\"}]"));

            CollectionAssert.AreEqual(bag.Select(o => o.SchemeId).ToList(), typed.Select(o => o.SchemeId).ToList());
        }

        [TestMethod]
        public void RetrieveSchemesFromEndpointDoesNotSynthesize()
        {
            var endpoint = TypedEndpoint(new AuthScheme("sigv4", null, null, null, null));

            Assert.IsNotNull(AuthResolverProbe.Retrieve(endpoint));
            Assert.IsNull(endpoint.RawAttributesOrNull);
        }
    }
}
