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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests for <see cref="AWSTokenProviderChain"/>
    /// </summary>
    [TestClass]
    public class AWSTokenProviderChainTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task ChainProcessMultipleProvidersCorrectly()
        {
            var fakeToken1 = new AWSToken { Token = "1" };
            var fakeToken2 = new AWSToken { Token = "2" };
            var fakeToken3 = new AWSToken { Token = "3" };

            var mockProvider1 = new Mock<IAWSTokenProvider>();
            mockProvider1
                .Setup(x => x.TryResolveTokenAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(new TryResponse<AWSToken> { Success = false, Value = fakeToken1 });

            var mockProvider2 = new Mock<IAWSTokenProvider>();
            mockProvider2
                .Setup(x => x.TryResolveTokenAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(new TryResponse<AWSToken> { Success = true, Value = fakeToken2 });

            var mockProvider3 = new Mock<IAWSTokenProvider>();
            mockProvider3
                .Setup(x => x.TryResolveTokenAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(new TryResponse<AWSToken> { Success = true, Value = fakeToken3 });

            var chain =
                new AWSTokenProviderChain(
                    mockProvider1.Object,
                    mockProvider2.Object,
                    mockProvider3.Object);

            var result = await chain.TryResolveTokenAsync();

            Assert.IsTrue(result.Success);
            Assert.AreEqual(result.Value.Token, fakeToken2.Token);
        }
    }
}