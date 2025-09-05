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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class AuthSchemeIntegrationSimpleTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Clear environment variables and global config before each test
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", null);
            AWSConfigs.AuthSchemePreference = null;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up environment variables and global config after each test
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", null);
            AWSConfigs.AuthSchemePreference = null;
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeOption_DefaultCollections_AreCorrect()
        {
            // Test that the default collections are properly defined
            Assert.AreEqual(1, AuthSchemeOption.DEFAULT_SIGV4.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, AuthSchemeOption.DEFAULT_SIGV4[0].SchemeId);

            Assert.AreEqual(1, AuthSchemeOption.DEFAULT_SIGV4A.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, AuthSchemeOption.DEFAULT_SIGV4A[0].SchemeId);

            Assert.AreEqual(1, AuthSchemeOption.DEFAULT_BEARER.Count);
            Assert.AreEqual(AuthSchemeOption.Bearer, AuthSchemeOption.DEFAULT_BEARER[0].SchemeId);

            Assert.AreEqual(1, AuthSchemeOption.DEFAULT_NOAUTH.Count);
            Assert.AreEqual(AuthSchemeOption.NoAuth, AuthSchemeOption.DEFAULT_NOAUTH[0].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeOption_SchemeIdConstants_AreCorrect()
        {
            // Test that the scheme ID constants are correct
            Assert.AreEqual("aws.auth#sigv4", AuthSchemeOption.SigV4);
            Assert.AreEqual("aws.auth#sigv4a", AuthSchemeOption.SigV4A);
            Assert.AreEqual("smithy.api#httpBearerAuth", AuthSchemeOption.Bearer);
            Assert.AreEqual("smithy.api#noAuth", AuthSchemeOption.NoAuth);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeOption_CanCreateInstance()
        {
            // Test that we can create AuthSchemeOption instances
            var option = new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 };
            Assert.AreEqual(AuthSchemeOption.SigV4, option.SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeResolver_CanResolveSchemes()
        {
            // Test that the DefaultAuthSchemeResolver can resolve schemes
            var resolver = new DefaultAuthSchemeResolver();
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            
            var result = resolver.ResolveAuthSchemes(null, supportedSchemes);
            
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4, result[0]);
            Assert.AreEqual(AuthScheme.SigV4a, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_CanResolvePreference()
        {
            // Test that the configuration resolver can resolve preferences
            var preference = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(null);
            Assert.IsNull(preference); // Should be null when no configuration is set
        }
    }
}