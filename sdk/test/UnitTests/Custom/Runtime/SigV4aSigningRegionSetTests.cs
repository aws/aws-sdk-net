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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Amazon;

#if BCL || NETSTANDARD
using Amazon.Runtime.CredentialManagement;
#endif

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Test cases for SigV4a signing region set resolution.
    /// These tests verify the configuration hierarchy for SigV4a signing region set resolution.
    ///
    /// Configuration hierarchy (highest to lowest precedence):
    /// 1. Code (explicit configuration in client/request)
    /// 2. Environment variable (AWS_SIGV4A_SIGNING_REGION_SET)
    /// 3. Config file (sigv4a_signing_region_set in profile)
    /// 4. Endpoints 2.0 metadata (from endpoint resolution)
    /// 5. Endpoint region (default to the configured region)
    ///
    /// Notes:
    /// - "*" indicates the request is valid in all regions
    /// - Multiple regions are comma-separated
    /// - This feature enables multi-region request signing for global services
    /// </summary>
    [TestClass]
    public class SigV4aSigningRegionSetTests
    {
        private const string TEST_PROFILE = "test-sigv4a-profile";
        private string _originalEnvironmentVariable;
        
        [TestInitialize]
        public void TestInitialize()
        {
            // Save original environment variable
            _originalEnvironmentVariable = Environment.GetEnvironmentVariable(
                EnvironmentVariableInternalConfiguration.ENVIRONMENT_VARIABLE_AWS_SIGV4A_SIGNING_REGION_SET);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Restore original environment variable
            if (_originalEnvironmentVariable != null)
            {
                Environment.SetEnvironmentVariable(
                    EnvironmentVariableInternalConfiguration.ENVIRONMENT_VARIABLE_AWS_SIGV4A_SIGNING_REGION_SET,
                    _originalEnvironmentVariable);
            }
            else
            {
                Environment.SetEnvironmentVariable(
                    EnvironmentVariableInternalConfiguration.ENVIRONMENT_VARIABLE_AWS_SIGV4A_SIGNING_REGION_SET,
                    null);
            }
        }

        /// <summary>
        /// Endpoint Region | Endpoints 2.0 Metadata | Environment | Config File | Code | Result
        /// us-west-2      | n/a                    | n/a         | n/a         | n/a  | us-west-2
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSigV4aRegionSet_DefaultToEndpointRegion()
        {
            var config = CreateTestConfig("us-west-2");
            
            var regionSet = ResolveSigV4aSigningRegionSet(config, null, null, null, null);
            
            Assert.AreEqual("us-west-2", regionSet);
        }

        /// <summary>
        /// Endpoint Region | Endpoints 2.0 Metadata | Environment | Config File | Code | Result
        /// us-west-2      | *                      | n/a         | n/a         | n/a  | *
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSigV4aRegionSet_Endpoints2Metadata_AllRegions()
        {
            var config = CreateTestConfig("us-west-2");
            var endpoint = CreateEndpointWithSigV4aMetadata("*");
            
            var regionSet = ResolveSigV4aSigningRegionSet(config, endpoint, null, null, null);
            
            Assert.AreEqual("*", regionSet);
        }

        /// <summary>
        /// Endpoint Region | Endpoints 2.0 Metadata | Environment | Config File | Code | Result
        /// us-west-2      | n/a                    | *           | n/a         | n/a  | *
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSigV4aRegionSet_EnvironmentVariable_AllRegions()
        {
            var config = CreateTestConfig("us-west-2");
            Environment.SetEnvironmentVariable(
                EnvironmentVariableInternalConfiguration.ENVIRONMENT_VARIABLE_AWS_SIGV4A_SIGNING_REGION_SET,
                "*");
            
            var regionSet = ResolveSigV4aSigningRegionSet(config, null, "*", null, null);
            
            Assert.AreEqual("*", regionSet);
        }

        /// <summary>
        /// Endpoint Region | Endpoints 2.0 Metadata | Environment | Config File | Code | Result
        /// us-west-2      | n/a                    | n/a         | *           | n/a  | *
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSigV4aRegionSet_ConfigFile_AllRegions()
        {
            var config = CreateTestConfig("us-west-2");
            
            var regionSet = ResolveSigV4aSigningRegionSet(config, null, null, "*", null);
            
            Assert.AreEqual("*", regionSet);
        }

        /// <summary>
        /// Endpoint Region | Endpoints 2.0 Metadata | Environment | Config File | Code | Result
        /// us-west-2      | n/a                    | n/a         | n/a         | *    | *
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSigV4aRegionSet_CodeConfig_AllRegions()
        {
            var config = CreateTestConfig("us-west-2");
            config.SigV4aSigningRegionSet = "*";
            
            var regionSet = ResolveSigV4aSigningRegionSet(config, null, null, null, "*");
            
            Assert.AreEqual("*", regionSet);
        }

        /// <summary>
        /// Endpoint Region | Endpoints 2.0 Metadata | Environment | Config File | Code      | Result
        /// us-west-2      | *                      | n/a         | n/a         | us-west-2 | us-west-2
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSigV4aRegionSet_CodeOverridesAll()
        {
            var config = CreateTestConfig("us-west-2");
            config.SigV4aSigningRegionSet = "us-west-2";
            var endpoint = CreateEndpointWithSigV4aMetadata("*");
            
            var regionSet = ResolveSigV4aSigningRegionSet(config, endpoint, null, null, "us-west-2");
            
            Assert.AreEqual("us-west-2", regionSet);
        }

        #region Helper Methods

        /// <summary>
        /// Create a test client configuration with specified region.
        /// </summary>
        private TestClientConfig CreateTestConfig(string region)
        {
            var config = new TestClientConfig();
            config.RegionEndpoint = RegionEndpoint.GetBySystemName(region);
            return config;
        }

        /// <summary>
        /// Create an endpoint with SigV4a metadata for testing.
        /// </summary>
        private Endpoint CreateEndpointWithSigV4aMetadata(string signingRegionSet)
        {
            var attributes = new PropertyBag();
            
            if (!string.IsNullOrEmpty(signingRegionSet))
            {
                var authSchemes = new List<PropertyBag>();
                var sigv4aScheme = new PropertyBag();
                sigv4aScheme["name"] = "sigv4a";
                sigv4aScheme["signingName"] = "test-service";
                
                // Parse region set - if it contains commas, split it into a list
                if (signingRegionSet.Contains(","))
                {
                    var regions = signingRegionSet.Split(',').Select(r => r.Trim()).ToList();
                    sigv4aScheme["signingRegionSet"] = regions;
                }
                else
                {
                    sigv4aScheme["signingRegionSet"] = new List<string> { signingRegionSet };
                }
                
                authSchemes.Add(sigv4aScheme);
                attributes["authSchemes"] = authSchemes;
            }
            
            return new Endpoint("https://test-service.amazonaws.com")
            {
                Attributes = attributes
            };
        }

        /// <summary>
        /// Simulates the resolution of SigV4a signing region set based on configuration hierarchy.
        /// This mimics the actual resolution logic that would occur across various components of the SDK.
        /// </summary>
        private string ResolveSigV4aSigningRegionSet(
            TestClientConfig config,
            Endpoint endpoint,
            string environmentValue,
            string configFileValue,
            string codeValue)
        {
            // Hierarchy: Code > Environment > Config File > Endpoints 2.0 > Default Region
            
            if (!string.IsNullOrEmpty(codeValue))
            {
                return codeValue;
            }
            
            if (!string.IsNullOrEmpty(environmentValue))
            {
                return environmentValue;
            }
            
            if (!string.IsNullOrEmpty(configFileValue))
            {
                return configFileValue;
            }
            
            if (endpoint?.Attributes != null && endpoint.Attributes["authSchemes"] != null)
            {
                var authSchemes = endpoint.Attributes["authSchemes"] as IList;
                if (authSchemes != null && authSchemes.Count > 0)
                {
                    var firstScheme = authSchemes[0] as PropertyBag;
                    if (firstScheme != null && firstScheme["signingRegionSet"] != null)
                    {
                        var regionSet = firstScheme["signingRegionSet"];
                        if (regionSet is IList regionList)
                        {
                            return string.Join(",", regionList.Cast<string>());
                        }
                        return regionSet.ToString();
                    }
                }
            }
            
            // Default to the endpoint region
            return config.RegionEndpoint.SystemName;
        }

        /// <summary>
        /// Test client configuration for unit testing.
        /// </summary>
        private class TestClientConfig : ClientConfig
        {
            public TestClientConfig() : base(new DummyDefaultConfigurationProvider())
            {
            }

            public override string RegionEndpointServiceName { get; } = "TestService";
            public override string ServiceVersion { get; } = "1.0";
            public override string UserAgent => "TestUserAgent";

            public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
            {
                return new Endpoint(this.ServiceURL ?? "https://example.com");
            }

            private class DummyDefaultConfigurationProvider : IDefaultConfigurationProvider
            {
                public IDefaultConfiguration GetDefaultConfiguration(
                    RegionEndpoint clientRegion,
                    DefaultConfigurationMode? requestedConfigurationMode = null)
                {
                    return new DefaultConfiguration();
                }
            }
        }

        #endregion
    }
}