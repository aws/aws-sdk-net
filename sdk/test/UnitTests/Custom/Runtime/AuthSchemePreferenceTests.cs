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
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class AuthSchemePreferenceTests : RuntimePipelineTestBase
    {
        [DataTestMethod]
        [DataRow("aws.auth#sigv4,aws.auth#sigv4a", null, "sigv4")]
        [DataRow("aws.auth#sigv4,aws.auth#sigv4a", "sigv4a", "sigv4a")]
        [DataRow("aws.auth#sigv4,aws.auth#sigv4a", "sigv4a,sigv4", "sigv4a")]
        [DataRow("aws.auth#sigv4", "sigv4a", "sigv4")]
        [DataRow("aws.auth#sigv4,aws.auth#sigv4a", "sigv3", "sigv4")]
        [DataRow("aws.auth#sigv4", "noAuth", "sigv4")]
        [DataRow("aws.auth#sigv4", "  \tsigv4  \t", "sigv4")]
        public void Test_PreferenceList_RespectsOrder(string supportedOptions, string preferenceList, string resolvedScheme)
        {
            var mockConfig = new MockClientConfig
            {
                DefaultAWSCredentials = new BasicAWSCredentials("foo", "bar"),
                AuthSchemePreference = string.IsNullOrEmpty(preferenceList) ? null : preferenceList.Split(',').ToList(),
            };

            var pipeline = CreateMockPipeline(supportedOptions);
            var context = CreateTestContext(new NullSigner(), null, mockConfig);

            pipeline.InvokeSync(context);
            Assert.IsNotNull(context.RequestContext.Request.ChosenAuthScheme);
            Assert.AreEqual(resolvedScheme, context.RequestContext.Request.ChosenAuthScheme.ShortName);
        }

        [DataTestMethod]
        [DataRow("aws.auth#sigv4", "*", null)]
        [DataRow("aws.auth#sigv4a", null, null)]
        [DataRow("aws.auth#sigv4a", "*", "*")]
        [DataRow("aws.auth#sigv4a", "  \tus-west-2, us-east-1\t", "us-west-2,us-east-1")]
        public void Test_SigningRegionSet_IsOverridenForSigV4A(string supportedOptions, string manualRegionSet, string expectedRegionSet)
        {
            var mockConfig = new MockClientConfig
            {
                DefaultAWSCredentials = new BasicAWSCredentials("foo", "bar"),
                SigV4aSigningRegionSet = string.IsNullOrEmpty(manualRegionSet) ? null : manualRegionSet.Split(',').ToList(),
            };

            var pipeline = CreateMockPipeline(supportedOptions);
            var context = CreateTestContext(new NullSigner(), null, mockConfig);
            pipeline.InvokeSync(context);
            
            // The auth resolver handler will populate the authentication region property, which is one of
            // the first places the signer checks (same logic is used in the endpoint resolver).
            Assert.AreEqual(expectedRegionSet, context.RequestContext.Request.AuthenticationRegion);
        }

        [TestMethod]
        public void Test_EndpointResolver_DoesNotOverrideManualPreference()
        {
            var attributesJson = @"{
                ""authSchemes"": [
                    {
                        ""name"": ""sigv4a"",
                        ""signingName"": ""test"",
                        ""signingRegionSet"": [""*""]
                    },
                    {
                        ""name"": ""sigv4"",
                        ""signingName"": ""test"",
                        ""signingRegion"": ""us-east-1""
                    }
                ]
            }";

            var mockConfig = new MockClientConfig
            {
                DefaultAWSCredentials = new BasicAWSCredentials("foo", "bar"),
                AuthSchemePreference = new List<string> { "sigv4" },
                EndpointProvider = new MockEndpointProvider(attributesJson),
            };

            var pipeline = CreateMockPipeline("aws.auth#sigv4a,aws.auth#sigv4", includeEndpointResolver: true);
            var context = CreateTestContext(new NullSigner(), null, mockConfig);
            pipeline.InvokeSync(context);

            // The first auth scheme in the endpoint attributes is SigV4A, but the manual preference
            // should be prioritized if also supported.
            Assert.AreEqual("sigv4", context.RequestContext.Request.ChosenAuthScheme.ShortName);
            Assert.AreEqual("us-east-1", context.RequestContext.Request.AuthenticationRegion);
            Assert.AreEqual(SignatureVersion.SigV4, context.RequestContext.Request.SignatureVersion);
        }

        [TestMethod]
        public void Test_EndpointResolver_DoesNotOverrideManualRegionSet()
        {
            var attributesJson = @"{
                ""authSchemes"": [
                    {
                        ""name"": ""sigv4a"",
                        ""signingName"": ""test"",
                        ""signingRegionSet"": [""*""]
                    }
                ]
            }";

            var mockConfig = new MockClientConfig
            {
                DefaultAWSCredentials = new BasicAWSCredentials("foo", "bar"),
                SigV4aSigningRegionSet = new List<string> { "us-east-1", "us-west-2" },
                EndpointProvider = new MockEndpointProvider(attributesJson),
            };

            var pipeline = CreateMockPipeline("aws.auth#sigv4a", includeEndpointResolver: true);
            var context = CreateTestContext(new NullSigner(), null, mockConfig);
            pipeline.InvokeSync(context);

            // The value in the config should be used instead of the one in the endpoint attributes.
            Assert.AreEqual("us-east-1,us-west-2", context.RequestContext.Request.AuthenticationRegion);
        }

        [TestMethod]
        public void Test_EndpointResolver_HandlesS3ExpressSchemeName()
        {
            var attributesJson = @"{
                ""authSchemes"": [
                    {
                        ""name"": ""sigv4-s3express"",
                        ""signingName"": ""test"",
                        ""signingRegion"": ""us-east-2""
                    }
                ]
            }";

            var mockConfig = new MockClientConfig
            {
                DefaultAWSCredentials = new BasicAWSCredentials("foo", "bar"),
                EndpointProvider = new MockEndpointProvider(attributesJson),
            };

            var pipeline = CreateMockPipeline("aws.auth#sigv4", includeEndpointResolver: true);
            var context = CreateTestContext(new NullSigner(), null, mockConfig);
            pipeline.InvokeSync(context);

            // The chosen auth scheme name in the request has the "expected" ID (i.e. "sigv4"), but
            // there are some legacy rules for S3 that use "sigv4-s3express" instead.
            Assert.AreEqual("sigv4", context.RequestContext.Request.ChosenAuthScheme.ShortName);
            Assert.AreEqual("us-east-2", context.RequestContext.Request.AuthenticationRegion);
            Assert.AreEqual(SignatureVersion.SigV4, context.RequestContext.Request.SignatureVersion);
        }

        private RuntimePipeline CreateMockPipeline(string supportedOptions, bool includeEndpointResolver = false)
        {
            var pipeline = new RuntimePipeline(new MockHandler());
            if (includeEndpointResolver)
            {
                pipeline.AddHandler(new BaseEndpointResolver());
            }

            pipeline.AddHandler(new MockAuthResolverHandler(supportedOptions));
            return pipeline;
        }

        class MockAuthResolverHandler : BaseAuthResolverHandler
        {
            private readonly List<IAuthSchemeOption> _mockOptions = new List<IAuthSchemeOption>();

            /// <summary>
            /// In the actual implementation, this value would come from the service model (and
            /// endpoint rules for the few services that are allow-listed). In this test we're only
            /// interested in verifying the manual options are being considered correctly.
            /// </summary>
            public MockAuthResolverHandler(string mockOptions)
            {
                if (string.IsNullOrEmpty(mockOptions))
                {
                    throw new ArgumentNullException(nameof(mockOptions));
                }

                var values = mockOptions.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var value in values)
                {
                    _mockOptions.Add(new AuthSchemeOption { SchemeId = value });
                }
            }

            protected override ISigner GetSigner(IAuthScheme<BaseIdentity> scheme) 
                => new NullSigner();

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext) 
                => _mockOptions;
        }

        class MockEndpointProvider : IEndpointProvider
        {
            private readonly string _attributes;

            public MockEndpointProvider(string attributes) 
                => _attributes = attributes;

            public Endpoint ResolveEndpoint(EndpointParameters parameters) 
                => new Endpoint("https://example.com", attributesJson: _attributes, headersJson: null);
        }
    }
}
