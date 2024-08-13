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
using System.Linq;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DefaultConfigurationProviderTests
    {
        // ARRANGE
        private readonly IDefaultConfiguration[] _fakeDefaultConfigurations = new[]
        {
            // use different TimeToFirstByteTimeout values to have enough fidelity
            // to distinguish between Default Configurations
            new DefaultConfiguration
            {
                Name = DefaultConfigurationMode.CrossRegion,
                TimeToFirstByteTimeout = TimeSpan.FromMilliseconds(10)
            },
            new DefaultConfiguration
            {
                Name = DefaultConfigurationMode.InRegion,
                TimeToFirstByteTimeout = TimeSpan.FromMilliseconds(200)
            },
            new DefaultConfiguration
            {
                Name = DefaultConfigurationMode.Mobile,
                TimeToFirstByteTimeout = TimeSpan.FromMilliseconds(3000)
            },
            new DefaultConfiguration
            {
                Name = DefaultConfigurationMode.Standard,
                TimeToFirstByteTimeout = TimeSpan.FromMilliseconds(40000)
            }
        };

        /// <summary>
        /// Validates that <see cref="DefaultConfigurationProvider"/> will follow
        /// the following order:
        /// 1. Client Config
        /// 2. Environment Variable
        /// 3. Shared Config/Credential File
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataTestMethod]
        // Client Config wins
        [DataRow(
            DefaultConfigurationMode.CrossRegion, DefaultConfigurationMode.InRegion, DefaultConfigurationMode.Mobile,
            DefaultConfigurationMode.CrossRegion)]
        [DataRow(
            DefaultConfigurationMode.CrossRegion, null, null, DefaultConfigurationMode.CrossRegion)]
        // Environment Variable wins
        [DataRow(
            null, DefaultConfigurationMode.InRegion, DefaultConfigurationMode.Mobile,
            DefaultConfigurationMode.InRegion)]
        [DataRow(
            null, DefaultConfigurationMode.InRegion, null, DefaultConfigurationMode.InRegion)]
        // Shared Config/Credential wins
        [DataRow(
            null, null, DefaultConfigurationMode.Mobile, DefaultConfigurationMode.Mobile)]
        // Standard (default) wins
        [DataRow(
            null, null, null, DefaultConfigurationMode.Standard)]
        public void OrderOfOperationsTest(
            DefaultConfigurationMode? clientConfigDefaultMode,
            DefaultConfigurationMode? environmentVariableDefaultMode,
            DefaultConfigurationMode? sharedConfigDefaultMode,
            DefaultConfigurationMode expectedDefaultMode)
        {
            // ARRANGE
            var mockEnvironmentVariableProvider = BuildEnvironmentVariableMock(environmentVariableDefaultMode);
            var mockAutoModeResolver = new Mock<IDefaultConfigurationAutoModeResolver>();

            var clientConfig =
                new TestClientConfig(
                    new DefaultConfigurationProvider(
                        mockEnvironmentVariableProvider.Object,
                        mockAutoModeResolver.Object,
                        _fakeDefaultConfigurations));

            if (clientConfigDefaultMode.HasValue)
                clientConfig.DefaultConfigurationMode = clientConfigDefaultMode.Value;

            var sharedConfigFile =
                "[default]\r\n" +
                $"defaults_mode={sharedConfigDefaultMode?.ToString()}";

            TimeSpan? actualTimeout;
            using (new FallbackFactoryTest.FallbackFactoryTestFixture(sharedConfigFile, "default"))
            {
                // ACT
                actualTimeout = clientConfig.Timeout;
            }

            // ASSERT
            var expectedMode = _fakeDefaultConfigurations.First(x => x.Name == expectedDefaultMode);

            Assert.AreEqual(expectedMode.TimeToFirstByteTimeout, actualTimeout);
        }

        /// <summary>
        /// Make sure wan error is thrown if SharedCredentialsFile.DefaultConfigurationModeField
        /// has an invalid DefaultConfigurationMode
        /// </summary>
        [TestMethod]
        public void UnknownDefaultConfigurationModeThrowsAnError()
        {
            // ARRANGE
            var mockEnvironmentVariableProvider = new Mock<IEnvironmentVariableRetriever>();
            var mockAutoModeResolver = new Mock<IDefaultConfigurationAutoModeResolver>();

            var clientConfig =
                new TestClientConfig(
                    new DefaultConfigurationProvider(
                        mockEnvironmentVariableProvider.Object,
                        mockAutoModeResolver.Object,
                        _fakeDefaultConfigurations));

            var sharedConfigFile =
                "[default]\r\n" +
                "defaults_mode=NON-EXISTENT-DEFAULT-CONFIG-MODE";

            Exception expectedException = null;
            TimeSpan? actualTimeout = null;
            try
            {
                using (new FallbackFactoryTest.FallbackFactoryTestFixture(sharedConfigFile, "default"))
                {
                    // ACT
                    actualTimeout = clientConfig.Timeout;
                }
            }
            catch (Exception e)
            {
                expectedException = e;
            }

            // ASSERT
            Assert.IsNotNull(expectedException);
            Assert.IsInstanceOfType(expectedException, typeof(AmazonClientException));
            Assert.IsTrue(expectedException.Message.StartsWith("Failed to find requested Default Configuration Mode"));

            Assert.IsNull(actualTimeout);
        }

        [TestMethod]
        public void DefaultConfigurationAutoModeIsCachedWhenPassedInMethodParameter()
        {
            // validate behavior by confirming IDefaultConfigurationAutoModeResolver is only called once

            // ARRANGE
            var mockEnvironmentVariableProvider = new Mock<IEnvironmentVariableRetriever>();
            var mockAutoModeResolver = new Mock<IDefaultConfigurationAutoModeResolver>();
            mockAutoModeResolver
                .Setup(x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()))
                .Returns(_fakeDefaultConfigurations[0].Name);
                
            var clientConfig =
                new TestClientConfig(
                    new DefaultConfigurationProvider(
                        mockEnvironmentVariableProvider.Object,
                        mockAutoModeResolver.Object,
                        _fakeDefaultConfigurations));

            clientConfig.DefaultConfigurationMode = DefaultConfigurationMode.Auto;

            // ACT
            // load properties - this will cause ClientConfig
            // to invoke DefaultConfigurationProvider multiple times
            var timeout = clientConfig.Timeout;
            var retryMode = clientConfig.RetryMode;
            var timeout2 = clientConfig.Timeout;

            // ASSERT
            mockAutoModeResolver
                .Verify(
                    x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()),
                    // if we're caching correctly, mockAutoModeResolver.Resolve should only be called once
                    Times.Once);
        }

        [TestMethod]
        public void DefaultConfigurationAutoModeIsCachedWhenSpecifiedInEnvironmentVariable()
        {
            // validate behavior by confirming IDefaultConfigurationAutoModeResolver is only called once

            // ARRANGE
            var mockEnvironmentVariableProvider = BuildEnvironmentVariableMock(DefaultConfigurationMode.Auto);
            var mockAutoModeResolver = new Mock<IDefaultConfigurationAutoModeResolver>();
            mockAutoModeResolver
                .Setup(x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()))
                .Returns(_fakeDefaultConfigurations[0].Name);

            var clientConfig =
                new TestClientConfig(
                    new DefaultConfigurationProvider(
                        mockEnvironmentVariableProvider.Object,
                        mockAutoModeResolver.Object,
                        _fakeDefaultConfigurations));

            // ACT
            // load properties - this will cause ClientConfig
            // to invoke DefaultConfigurationProvider multiple times
            var timeout = clientConfig.Timeout;
            var retryMode = clientConfig.RetryMode;
            var timeout2 = clientConfig.Timeout;

            // ASSERT
            mockAutoModeResolver
                .Verify(
                    x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()),
                    // if we're caching correctly, mockAutoModeResolver.Resolve should only be called once
                    Times.Once);
        }

        [TestMethod]
        public void DefaultConfigurationAutoModeIsRefreshedIfRegionChangesWhenPassedInMethodParameter()
        {
            // validate behavior by confirming IDefaultConfigurationAutoModeResolver is called once per RegionEndpoint

            // ARRANGE
            var mockEnvironmentVariableProvider = BuildEnvironmentVariableMock();
            var mockAutoModeResolver = new Mock<IDefaultConfigurationAutoModeResolver>();
            mockAutoModeResolver
                .Setup(x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()))
                .Returns(_fakeDefaultConfigurations[0].Name);

            var clientConfig =
                new TestClientConfig(
                    new DefaultConfigurationProvider(
                        mockEnvironmentVariableProvider.Object,
                        mockAutoModeResolver.Object,
                        _fakeDefaultConfigurations));

            clientConfig.DefaultConfigurationMode = DefaultConfigurationMode.Auto;

            // set initial RegionEndpoint
            clientConfig.RegionEndpoint = RegionEndpoint.APEast1;

            // ACT

            // load properties - this will cause ClientConfig
            // to invoke DefaultConfigurationProvider multiple times
            var timeout = clientConfig.Timeout;
            var retryMode = clientConfig.RetryMode;

            // change RegionEndpoint
            clientConfig.RegionEndpoint = RegionEndpoint.USWest2;
            var timeout2 = clientConfig.Timeout;
            var retryMode2 = clientConfig.RetryMode;


            // ASSERT
            mockAutoModeResolver
                .Verify(
                    x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()),
                    // if we're caching correctly, mockAutoModeResolver.Resolve should only be called once
                    // per Region Endpoint change
                    Times.Exactly(2));
        }

        [TestMethod]
        public void DefaultConfigurationAutoModeIsRefreshedIfRegionChangesWhenSpecifiedInEnvironmentVariable()
        {
            // validate behavior by confirming IDefaultConfigurationAutoModeResolver is called once per RegionEndpoint

            // ARRANGE
            var mockEnvironmentVariableProvider = BuildEnvironmentVariableMock(DefaultConfigurationMode.Auto);
            var mockAutoModeResolver = new Mock<IDefaultConfigurationAutoModeResolver>();
            mockAutoModeResolver
                .Setup(x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()))
                .Returns(_fakeDefaultConfigurations[0].Name);

            var clientConfig =
                new TestClientConfig(
                    new DefaultConfigurationProvider(
                        mockEnvironmentVariableProvider.Object,
                        mockAutoModeResolver.Object,
                        _fakeDefaultConfigurations));

            // set initial RegionEndpoint
            clientConfig.RegionEndpoint = RegionEndpoint.APEast1;

            // ACT

            // load properties - this will cause ClientConfig
            // to invoke DefaultConfigurationProvider multiple times
            var timeout = clientConfig.Timeout;
            var retryMode = clientConfig.RetryMode;
            
            // change RegionEndpoint
            clientConfig.RegionEndpoint = RegionEndpoint.USWest2;
            var timeout2 = clientConfig.Timeout;
            var retryMode2 = clientConfig.RetryMode;


            // ASSERT
            mockAutoModeResolver
                .Verify(
                    x => x.Resolve(It.IsAny<RegionEndpoint>(), It.IsAny<Func<RegionEndpoint>>()),
                    // if we're caching correctly, mockAutoModeResolver.Resolve should only be called once
                    // per Region Endpoint change
                    Times.Exactly(2));
        }

        [TestMethod]
        public void DefaultConfigurationCanBeExplicitlySetEvenIfItsAlreadyCached()
        {
            // ARRANGE
            var environmentVariableDefaultMode = _fakeDefaultConfigurations[0];
            var explicitlySetDefaultMode = _fakeDefaultConfigurations[1];
            
            var mockEnvironmentVariableProvider = BuildEnvironmentVariableMock(environmentVariableDefaultMode.Name);
            var mockAutoModeResolver = new Mock<IDefaultConfigurationAutoModeResolver>();

            var clientConfig =
                new TestClientConfig(
                    new DefaultConfigurationProvider(
                        mockEnvironmentVariableProvider.Object,
                        mockAutoModeResolver.Object,
                        _fakeDefaultConfigurations));

            // ACT

            // retrieve timeout once (this will cause default configuration mode to be cached)
            var timeoutFromEnvironmentVariableDefaultMode = clientConfig.Timeout;

            // simulate user explicitly setting DefaultConfigurationMode
            clientConfig.DefaultConfigurationMode = explicitlySetDefaultMode.Name;

            // now reload timeout, to make sure we don't use the old cached value.
            var timeoutFromExplicitlySetDefaultMode = clientConfig.Timeout;

            // ASSERT
            Assert.AreEqual(
                environmentVariableDefaultMode.TimeToFirstByteTimeout,
                timeoutFromEnvironmentVariableDefaultMode);

            Assert.AreEqual(
                explicitlySetDefaultMode.TimeToFirstByteTimeout,
                timeoutFromExplicitlySetDefaultMode);
        }

        private Mock<IEnvironmentVariableRetriever> BuildEnvironmentVariableMock(
            DefaultConfigurationMode? awsDefaultModeValue = null)
        {
            var mockEnvironmentVariableProvider = new Mock<IEnvironmentVariableRetriever>();
            mockEnvironmentVariableProvider
                .Setup(x => x.GetEnvironmentVariable(It.Is<string>(e => e == "AWS_DEFAULTS_MODE")))
                .Returns(awsDefaultModeValue?.ToString());

            return mockEnvironmentVariableProvider;
        }
    }
}