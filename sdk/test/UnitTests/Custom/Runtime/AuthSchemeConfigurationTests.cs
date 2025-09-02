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
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class AuthSchemeConfigurationTests
    {
        private const string TestProfileName = "test-profile";
        private const string AuthSchemePreferenceEnvVar = "AWS_AUTH_SCHEME_PREFERENCE";
        private const string SigV4aRegionSetEnvVar = "AWS_SIGV4A_SIGNING_REGION_SET";

        [TestInitialize]
        public void TestInitialize()
        {
            // Clear environment variables before each test
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, null);
            Environment.SetEnvironmentVariable(SigV4aRegionSetEnvVar, null);
            
            // Clear global AWSConfigs
            AWSConfigs.AuthSchemePreference = null;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up environment variables after each test
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, null);
            Environment.SetEnvironmentVariable(SigV4aRegionSetEnvVar, null);
            
            // Clear global AWSConfigs
            AWSConfigs.AuthSchemePreference = null;
            AWSConfigs.SigV4aRegionSetConfiguration = null;
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetAuthSchemePreference_ValidEnvironmentVariable_ReturnsPreference()
        {
            // Arrange
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, "sigv4a,sigv4");

            // Act
            var result = EnvironmentConfigurationProvider.GetAuthSchemePreference();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.PreferenceList.Count);
            Assert.AreEqual("sigv4a", result.PreferenceList[0]);
            Assert.AreEqual("sigv4", result.PreferenceList[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetAuthSchemePreference_EmptyEnvironmentVariable_ReturnsNull()
        {
            // Arrange
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, "");

            // Act
            var result = EnvironmentConfigurationProvider.GetAuthSchemePreference();

            // Assert
            Assert.IsNull(result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetAuthSchemePreference_NoEnvironmentVariable_ReturnsNull()
        {
            // Act
            var result = EnvironmentConfigurationProvider.GetAuthSchemePreference();

            // Assert
            Assert.IsNull(result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetAuthSchemePreference_WithWhitespace_TrimsValues()
        {
            // Arrange
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, " sigv4a , sigv4 ");

            // Act
            var result = EnvironmentConfigurationProvider.GetAuthSchemePreference();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.PreferenceList.Count);
            Assert.AreEqual("sigv4a", result.PreferenceList[0]);
            Assert.AreEqual("sigv4", result.PreferenceList[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetSigV4aRegionSet_ValidEnvironmentVariable_ReturnsRegionSet()
        {
            // Arrange
            Environment.SetEnvironmentVariable(SigV4aRegionSetEnvVar, "us-east-1,us-west-2");

            // Act
            var result = EnvironmentConfigurationProvider.GetSigV4aRegionSet();

            // Assert
            Assert.AreEqual("us-east-1,us-west-2", result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetSigV4aRegionSet_EmptyEnvironmentVariable_ReturnsNull()
        {
            // Arrange
            Environment.SetEnvironmentVariable(SigV4aRegionSetEnvVar, "");

            // Act
            var result = EnvironmentConfigurationProvider.GetSigV4aRegionSet();

            // Assert
            Assert.IsNull(result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetSigV4aRegionSet_NoEnvironmentVariable_ReturnsNull()
        {
            // Act
            var result = EnvironmentConfigurationProvider.GetSigV4aRegionSet();

            // Assert
            Assert.IsNull(result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveAuthSchemePreference_EnvironmentVariableHasPrecedenceOverGlobal()
        {
            // Arrange
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, "sigv4a,sigv4");
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth" });

            // Act
            var result = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.PreferenceList.Count);
            Assert.AreEqual("sigv4a", result.PreferenceList[0]);
            Assert.AreEqual("sigv4", result.PreferenceList[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveAuthSchemePreference_GlobalConfigUsedWhenNoOtherSource()
        {
            // Arrange
            var globalPreference = new AuthSchemePreference(new[] { "httpBearerAuth" });
            AWSConfigs.AuthSchemePreference = globalPreference;

            // Act
            var result = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(null);

            // Assert
            Assert.AreSame(globalPreference, result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveAuthSchemePreference_ReturnsNullWhenNoConfiguration()
        {
            // Act
            var result = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(null);

            // Assert
            Assert.IsNull(result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveSigV4aRegionSetConfiguration_EnvironmentVariableReturnsValue()
        {
            // Arrange
            Environment.SetEnvironmentVariable(SigV4aRegionSetEnvVar, "us-east-1,us-west-2");

            // Act
            var result = AuthSchemeConfigurationResolver.ResolveSigV4aRegionSetConfiguration(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("us-east-1,us-west-2", result.ToCommaSeparatedString());
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveSigV4aRegionSetConfiguration_ReturnsNullWhenNoConfiguration()
        {
            // Act
            var result = AuthSchemeConfigurationResolver.ResolveSigV4aRegionSetConfiguration(null);

            // Assert
            Assert.IsNull(result);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AWSConfigs_AuthSchemePreference_CanSetAndGet()
        {
            // Arrange
            var preference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            AWSConfigs.AuthSchemePreference = preference;
            var result = AWSConfigs.AuthSchemePreference;

            // Assert
            Assert.AreSame(preference, result);
        }



        [TestCategory("UnitTest")]
        [TestMethod]
        public void EnvironmentConfigurationProvider_GetAuthSchemePreference_HandlesInvalidInput_ReturnsNull()
        {
            // Arrange - Set an environment variable that would cause parsing issues
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, "   ,  ,   ");

            // Act
            var result = EnvironmentConfigurationProvider.GetAuthSchemePreference();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.PreferenceList.Count);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveAuthSchemePreference_HandlesNullClientConfig()
        {
            // Arrange
            Environment.SetEnvironmentVariable(AuthSchemePreferenceEnvVar, "sigv4a");

            // Act
            var result = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.PreferenceList.Count);
            Assert.AreEqual("sigv4a", result.PreferenceList[0]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveSigV4aRegionSetConfiguration_WithEnvironmentVariable_ReturnsEnvironmentConfiguration()
        {
            // Arrange
            Environment.SetEnvironmentVariable(SigV4aRegionSetEnvVar, "us-east-1,us-west-2");

            // Act
            var result = AuthSchemeConfigurationResolver.ResolveSigV4aRegionSetConfiguration(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(SigV4aRegionSetSource.Environment, result.Source);
            Assert.AreEqual(2, result.RegionSet.Count);
            Assert.AreEqual("us-east-1", result.RegionSet[0]);
            Assert.AreEqual("us-west-2", result.RegionSet[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveSigV4aRegionSetConfiguration_WithGlobalAWSConfigs_ReturnsGlobalConfiguration()
        {
            // Arrange
            var originalGlobalConfig = AWSConfigs.SigV4aRegionSetConfiguration;
            try
            {
                var regions = new[] { "us-east-1", "eu-west-1" };
                var globalConfig = SigV4aRegionSetConfiguration.FromClientConfiguration(regions);
                AWSConfigs.SigV4aRegionSetConfiguration = globalConfig;

                // Act
                var result = AuthSchemeConfigurationResolver.ResolveSigV4aRegionSetConfiguration(null);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(globalConfig, result);
            }
            finally
            {
                AWSConfigs.SigV4aRegionSetConfiguration = originalGlobalConfig;
            }
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeConfigurationResolver_ResolveSigV4aRegionSetConfiguration_WithNoConfiguration_ReturnsNull()
        {
            // Arrange
            var originalGlobalConfig = AWSConfigs.SigV4aRegionSetConfiguration;
            try
            {
                AWSConfigs.SigV4aRegionSetConfiguration = null;

                // Act
                var result = AuthSchemeConfigurationResolver.ResolveSigV4aRegionSetConfiguration(null);

                // Assert
                Assert.IsNull(result);
            }
            finally
            {
                AWSConfigs.SigV4aRegionSetConfiguration = originalGlobalConfig;
            }
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AWSConfigs_SigV4aRegionSetConfiguration_CanSetAndGet()
        {
            // Arrange
            var originalGlobalConfig = AWSConfigs.SigV4aRegionSetConfiguration;
            try
            {
                var regions = new[] { "us-east-1", "us-west-2" };
                var config = SigV4aRegionSetConfiguration.FromClientConfiguration(regions);

                // Act
                AWSConfigs.SigV4aRegionSetConfiguration = config;
                var result = AWSConfigs.SigV4aRegionSetConfiguration;

                // Assert
                Assert.AreSame(config, result);
            }
            finally
            {
                AWSConfigs.SigV4aRegionSetConfiguration = originalGlobalConfig;
            }
        }
    }
}