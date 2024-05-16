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
using Amazon;
using Amazon.Runtime;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Amazon.Internal;
using Amazon.S3.Model;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RegionEndpointProviderTest
    {
        /// These test cases pre-dated variants being added to endpoints.json
        /// The test data was updated to use variants because hardcoded dual-stack 
        /// support was remove, but the test cases were left the same.
        [DataTestMethod]
        [DataRow("xx-northeast-1", "svc", "svc.xx-northeast-1.amazonaws.com")]
        [DataRow("xx-northeast-2", "svc", "svc.xx-northeast-2.amazonaws.com")]
        [DataRow("xx-northeast-1", "s3", "s3.xx-northeast-1.amazonaws.com")]
        [DataRow("xx-west-1", "s3", "s3.xx-west-1.amazonaws.com")]
        [DataRow("xx-east-1", "s3", "s3.xx-east-1.amazonaws.com")]
        [DataRow("xx-northeast-1", "s3-control", "s3-control.xx-northeast-1.amazonaws.com")]
        [DataRow("xx-northeast-2", "s3-control", "s3-control.xx-northeast-2.amazonaws.com")]
        public void GetEndpointForService(string region, string service, string expectedHostname)
        {
            GetEndpointForServiceHelper(service, region, expectedHostname);
        }

        [DataTestMethod]
        [DataRow("us-east-1", "US East (Virginia)")]
        [DataRow("us-east-1-regional", "US East (Virginia) regional")]
        [DataRow("us-east-2", "US East (Ohio)")]
        [DataRow("us-west-1", "US West (N. California)")]
        [DataRow("us-west-2", "US West (Oregon)")]
        [DataRow("eu-north-1", "EU North (Stockholm)")]
        [DataRow("eu-south-1", "Europe (Milan)")]
        [DataRow("ap-east-1", "Asia Pacific (Hong Kong)")]
        [DataRow("sa-east-1", "South America (Sao Paulo)")]
        [DataRow("us-gov-east-1", "US GovCloud East (Virginia)")]
        [DataRow("cn-north-1", "China (Beijing)")]
        [DataRow("ca-central-1", "Canada (Central)")]
        [DataRow("me-south-1", "Middle East (Bahrain)")]
        [DataRow("af-south-1", "Africa (Cape Town)")]
        [DataRow("xx-xxxx-9", "Unknown")]
        [DataRow("xx-xxxx-xxx-6", "Unknown")]
        [DataRow("xx-xxxx-10", "Unknown")]
        [DataRow("US-EAST-1", "US East (Virginia)")]
        [DataRow("us-west-rack2", "Unknown")]
        public void TestValidRegionFormat(string regionName, string displayName)
        {
            var regionEndpoint = RegionEndpoint.GetBySystemName(regionName);
            if(string.Equals("Unknown", displayName))
            {
                Assert.AreEqual("Unknown", regionEndpoint.DisplayName);
            }
            else
            {
                Assert.AreNotEqual("Unknown", regionEndpoint.DisplayName);
            }
        }

        private void GetEndpointForServiceHelper(string service, string region, string expectedEndpoint)
        {
            var regionEndpoint = RegionEndpoint.GetBySystemName(region);
#pragma warning disable CS0612, CS0618
            var hostname = regionEndpoint?.GetEndpointForService(service).Hostname;
#pragma warning restore CS0612, CS0618
            
            Assert.IsNotNull(regionEndpoint);
            Assert.AreEqual(expectedEndpoint, hostname);
        }
    }
}
