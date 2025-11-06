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
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal.UserAgent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class ServiceBearerStaticTokenProviderTests
    {
        private const string TestToken = "test-bearer-token";

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task ServiceBearerStaticTokenProvider_TryResolveTokenAsync_SetsCorrectFeatureId()
        {
            var provider = new ServiceBearerStaticTokenProvider(TestToken);

            var result = await provider.TryResolveTokenAsync();

            Assert.IsTrue(result.Success);
            Assert.AreEqual(TestToken, result.Value.Token);
            Assert.IsTrue(result.Value.FeatureIdSources.Contains(UserAgentFeatureId.BEARER_SERVICE_ENV_VARS));
        }

#if NETFRAMEWORK
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ServiceBearerStaticTokenProvider_TryResolveToken_SetsCorrectFeatureId()
        {
            var provider = new ServiceBearerStaticTokenProvider(TestToken);

            var result = provider.TryResolveToken(out var token);

            Assert.IsTrue(result);
            Assert.AreEqual(TestToken, token.Token);
            Assert.IsTrue(token.FeatureIdSources.Contains(UserAgentFeatureId.BEARER_SERVICE_ENV_VARS));
        }
#endif        
    }
}