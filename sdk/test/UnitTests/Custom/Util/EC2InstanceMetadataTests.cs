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
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EC2InstanceMetadataTests
    {
        private const string AWS_EC2_METADATA_SERVICE_ENDPOINT_ENVIRONMENT_VARIABLE = "AWS_EC2_METADATA_SERVICE_ENDPOINT";
        private const string AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE_ENVIRONMENT_VARIABLE = "AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE";

        private static readonly string ProfileText = @"[default]
                                                       region=us-west-2
                                                       aws_access_key_id=default_aws_access_key_id
                                                       aws_secret_access_key=default_aws_secret_access_key
                                                       [imds-ipv6]
                                                       ec2_metadata_service_endpoint_mode=IPv6
                                                       [imds-ipv4]
                                                       ec2_metadata_service_endpoint_mode=IPv4
                                                       [imds-custom-endpoint]
                                                       ec2_metadata_service_endpoint=http://[fd00:ec2::200]
                                                       [imds-bad-endpoint]
                                                       ec2_metadata_service_endpoint=notAnUri";

        [DataTestMethod]
        [DataRow(EC2MetadataServiceEndpointMode.IPv6, "imds-ipv4", EC2MetadataServiceEndpointMode.IPv6)]  // env var should supersede conflicting profile value
        [DataRow(EC2MetadataServiceEndpointMode.IPv4, "imds-ipv6", EC2MetadataServiceEndpointMode.IPv4)]
        [DataRow(null, "imds-ipv6", EC2MetadataServiceEndpointMode.IPv6)]   // profile should drive value
        [DataRow(null, "imds-ipv4", EC2MetadataServiceEndpointMode.IPv4)]
        [DataRow(null, "default", EC2MetadataServiceEndpointMode.IPv4)]     // should default to IPv4 when no config values specified
        public void TestIMDSDualstackModeHierarchy(EC2MetadataServiceEndpointMode? envVarValue, string profileName, EC2MetadataServiceEndpointMode? expectedMode)
        {
            var envVariables = new Dictionary<string, string>();
            if (envVarValue.HasValue)
            {
                envVariables.Add(AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE_ENVIRONMENT_VARIABLE, envVarValue.Value.ToString());
            }

            using (new FallbackFactoryTest.FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedMode, FallbackInternalConfigurationFactory.EC2MetadataServiceEndpointMode.GetValueOrDefault());
            }
        }

        [DataTestMethod]
        [DataRow("", "", "http://169.254.169.254")]     // should default to existing IPv4 endpoint
        [DataRow("", "imds-ipv4", "http://169.254.169.254")]
        [DataRow("", "imds-ipv6", "http://[fd00:ec2::254]")]
        [DataRow("http://169.254.169.200", "imds-ipv4", "http://169.254.169.200")]  // custom enpoint via env var
        [DataRow("", "imds-custom-endpoint", "http://[fd00:ec2::200]")]             // custom endpoint via profile
        public void TestIMDSEndpointHierarchy(string envVarEndpoint, string profileName, string expectedEndpoint)
        {
            var envVariables = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(envVarEndpoint))
            {
                envVariables.Add(AWS_EC2_METADATA_SERVICE_ENDPOINT_ENVIRONMENT_VARIABLE, envVarEndpoint);
            }

            using (new FallbackFactoryTest.FallbackFactoryTestFixture(ProfileText, profileName, envVariables))
            {
                Assert.AreEqual(expectedEndpoint, EC2InstanceMetadata.ServiceEndpoint);
            }
        }

        [DataTestMethod]
        [DataRow("notAnUri")]
        [DataRow("[fd00:ec2::200]")]
        public void TestIMDSInvalidEndpointViaEnvVar(string envVarEndpoint)
        {
            var envVariables = new Dictionary<string, string>
            {
                {AWS_EC2_METADATA_SERVICE_ENDPOINT_ENVIRONMENT_VARIABLE, envVarEndpoint }
            };

            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                using (new FallbackFactoryTest.FallbackFactoryTestFixture(ProfileText, "default", envVariables)) { }
            });

            Assert.AreEqual($"The environment variable {AWS_EC2_METADATA_SERVICE_ENDPOINT_ENVIRONMENT_VARIABLE} was set with value " +
                $"{envVarEndpoint}, but it could not be parsed as a well-formed Uri.", exception.Message);
       }

        [TestMethod]
        public void TestIMDSInvalidEndpointViaProfile()
        {
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                using (new FallbackFactoryTest.FallbackFactoryTestFixture(ProfileText, "imds-bad-endpoint", null)) { }
            });

            Assert.AreEqual("Invalid value notAnUri for ec2_metadata_service_endpoint in profile imds-bad-endpoint. A well-formed Uri is expected." , exception.Message);
        }
    }
}
