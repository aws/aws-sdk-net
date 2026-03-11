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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.BedrockRuntime;
using Amazon.Runtime;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests that validate compliance with the Bedrock Environment Token Provider specification.    
    /// </summary>
    [TestClass]
    public class ServiceBearerTokenComplianceTests
    {
        private const string BedrockToken = "bedrock-token";
        private const string FooToken = "foo-token";


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]        
        public void ValidServiceSpecificTokenConfigured()
        {
            var originalValue = Environment.GetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK");
            try
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK", BedrockToken);
                using (var client = new AmazonBedrockRuntimeClient())
                {
                    Assert.IsTrue(client.Config.AWSTokenProvider.TryResolveToken(out var token));
                    Assert.AreEqual(BedrockToken, token.Token);
                    Assert.IsTrue(client.Config.AuthSchemePreference[0] == "httpBearerAuth");
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK", originalValue);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]        
        public void TokenConfiguredForDifferentService()
        {
            var originalValue = Environment.GetEnvironmentVariable("AWS_BEARER_TOKEN_FOO");
            try
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_FOO", FooToken);
                var config = new AmazonBedrockRuntimeConfig();
                var originalTokenProvider = config.AWSTokenProvider;
                using (var client = new AmazonBedrockRuntimeClient(config))
                {
                    Assert.IsTrue(client.Config.AWSTokenProvider == null);
                    Assert.AreSame(originalTokenProvider, client.Config.AWSTokenProvider);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_FOO", originalValue);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]        
        public void TokenConfiguredWithAuthSchemePreference()
        {
            var originalBedrock = Environment.GetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK");
            var originalAuth = Environment.GetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE");
            try
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK", BedrockToken);
                Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4,httpBearerAuth");
                using (var client = new AmazonBedrockRuntimeClient())
                {
                    Assert.IsTrue(client.Config.AWSTokenProvider.TryResolveToken(out var token));
                    Assert.IsTrue(client.Config.AuthSchemePreference[0] == "httpBearerAuth");
                    Assert.AreEqual(BedrockToken, token.Token);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK", originalBedrock);
                Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", originalAuth);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]        
        public void ExplicitServiceConfigTakesPrecedence()
        {
            var originalValue = Environment.GetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK");
            try
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK", BedrockToken);
                var explicitProvider = new StaticTokenProvider(FooToken);
                var config = new AmazonBedrockRuntimeConfig
                {
                    AWSTokenProvider = explicitProvider
                };

                using (var client = new AmazonBedrockRuntimeClient(config))
                {
                    Assert.IsTrue(client.Config.AWSTokenProvider.TryResolveToken(out var token));
                    Assert.AreEqual(FooToken, token.Token);
                    Assert.AreSame(explicitProvider, client.Config.AWSTokenProvider);
                }
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_BEARER_TOKEN_BEDROCK", originalValue);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]        
        public void NoEnvironmentVariableSet()
        {
            using (var client = new AmazonBedrockRuntimeClient())
            {
                Assert.IsTrue(client.Config.AWSTokenProvider == null);
                Assert.IsTrue(client.Config.AuthSchemePreference == null);
            }
        }
    }
}