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
using AWSSDK_DotNet35.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RegionEndpointProviderV3Test
    {
        /// These test cases pre-dated variants being added to endpoints.json
        /// The test data was updated to use variants because hardcoded dual-stack 
        /// support was remove, but the test cases were left the same.
        [DataTestMethod]
        [DataRow("xx-northeast-1", "svc", false, "svc.xx-northeast-1.amazonaws.com")]
        [DataRow("xx-northeast-1", "svc", true, "svc.xx-northeast-1.api.aws")]
        [DataRow("xx-east-1-fips", "svc", false, "svc-fips.xx-east-1.amazonaws.com")]
        [DataRow("xx-east-1-fips", "svc", true, "svc.xx-east-1-fips.api.aws")]
        [DataRow("xx-northeast-1", "s3", false, "s3.xx-northeast-1.amazonaws.com")]
        [DataRow("xx-northeast-1", "s3", true, "s3.dualstack.xx-northeast-1.amazonaws.com")]
        [DataRow("xx-west-1", "s3", false, "s3-xx-west-1.amazonaws.com")]
        [DataRow("xx-west-1", "s3", true, "s3.dualstack.xx-west-1.amazonaws.com")]
        [DataRow("xx-east-1", "s3", false, "s3.xx-east-1.amazonaws.com")]
        [DataRow("xx-east-1", "s3", true, "s3.dualstack.xx-east-1.amazonaws.com")]
        [DataRow("us-east-1", "s3", false, "s3.amazonaws.com")]
        [DataRow("us-east-1", "s3", true, "s3.dualstack.us-east-1.amazonaws.com")]
        [DataRow("xx-east-1-fips", "s3", false, "s3-fips.xx-east-1.amazonaws.com")]
        [DataRow("xx-east-1-fips", "s3", true, "s3.dualstack.xx-east-1-fips.amazonaws.com")]
        [DataRow("xx-northeast-1", "s3-control", false, "s3-control.xx-northeast-1.amazonaws.com")]
        [DataRow("xx-northeast-1", "s3-control", true, "s3-control.xx-northeast-1.api.aws")]
        [DataRow("xx-east-1-fips", "s3-control", false, "s3-control-fips.xx-east-1.amazonaws.com")]
        [DataRow("xx-east-1-fips", "s3-control", true, "s3-control.xx-east-1-fips.api.aws")]
        public void GetEndpointForService(string region, string service, bool useDualStack, string expectedHostname)
        {
            GetEndpointForServiceHelper("testEndpoints.json", service, useDualStack, region, expectedHostname);
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

        [DataTestMethod]
        [DataRow("www.amazon.com")]
        [DataRow("Invalid Region")]
        [DataRow("US East 1")]
        [DataRow("us-east-")]
        [DataRow(".")]
        [DataRow("%/.asdf/")]
        public void TestInvalidRegionFormat(string regionName)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                RegionEndpoint.GetBySystemName(regionName);
            });
        }

        [TestMethod]
        [DataRow("default-pattern-service", "us-west-2", false, "default-pattern-service.us-west-2.amazonaws.com")]
        [DataRow("default-pattern-service", "af-south-1", false, "default-pattern-service.af-south-1.amazonaws.com")]
        [DataRow("global-service", "aws-global", false, "global-service.amazonaws.com")]
        [DataRow("global-service", "foo", false, "global-service.amazonaws.com")]
        [DataRow("override-variant-service", "us-west-2", false, "override-variant-service.us-west-2.amazonaws.com")]
        [DataRow("override-variant-service", "af-south-1", false, "override-variant-service.af-south-1.amazonaws.com")]
        [DataRow("override-variant-dns-suffix-service", "us-west-2", false, "override-variant-dns-suffix-service.us-west-2.amazonaws.com")]
        [DataRow("override-variant-dns-suffix-service", "af-south-1", false, "override-variant-dns-suffix-service.af-south-1.amazonaws.com")]
        [DataRow("override-variant-hostname-service", "us-west-2", false, "override-variant-hostname-service.us-west-2.amazonaws.com")]
        [DataRow("override-variant-hostname-service", "af-south-1", false, "override-variant-hostname-service.af-south-1.amazonaws.com")]
        [DataRow("override-endpoint-variant-service", "us-west-2", false, "override-endpoint-variant-service.us-west-2.amazonaws.com")]
        [DataRow("override-endpoint-variant-service", "af-south-1", false, "override-endpoint-variant-service.af-south-1.amazonaws.com")]
        [DataRow("default-pattern-service", "us-west-2", true, "default-pattern-service.us-west-2.api.aws")]
        [DataRow("default-pattern-service", "af-south-1", true, "default-pattern-service.af-south-1.api.aws")]
        [DataRow("global-service", "aws-global", true, "global-service.api.aws")]
        [DataRow("global-service", "foo", true, "global-service.api.aws")]
        [DataRow("override-variant-service", "us-west-2", true, "override-variant-service.dualstack.us-west-2.new.dns.suffix")]
        [DataRow("override-variant-service", "af-south-1", true, "override-variant-service.dualstack.af-south-1.new.dns.suffix")]
        [DataRow("override-variant-dns-suffix-service", "us-west-2", true, "override-variant-dns-suffix-service.us-west-2.new.dns.suffix")]
        [DataRow("override-variant-dns-suffix-service", "af-south-1", true, "override-variant-dns-suffix-service.af-south-1.new.dns.suffix")]
        [DataRow("override-variant-hostname-service", "us-west-2", true, "override-variant-hostname-service.dualstack.us-west-2.api.aws")]
        [DataRow("override-variant-hostname-service", "af-south-1", true, "override-variant-hostname-service.dualstack.af-south-1.api.aws")]
        [DataRow("override-endpoint-variant-service", "us-west-2", true, "override-endpoint-variant-service.dualstack.us-west-2.amazonaws.com")]
        [DataRow("override-endpoint-variant-service", "af-south-1", true, "override-endpoint-variant-service.af-south-1.api.aws")]
        [DataRow("multi-variant-service", "us-west-2", false, "multi-variant-service.us-west-2.amazonaws.com")]
        [DataRow("multi-variant-service", "us-west-2", true, "multi-variant-service.dualstack.us-west-2.api.aws")]
        [DataRow("multi-variant-service", "af-south-1", false, "multi-variant-service.af-south-1.amazonaws.com")]
        [DataRow("multi-variant-service", "af-south-1", true, "multi-variant-service.dualstack.af-south-1.api.aws")]
        public void VariantTests(string service, string region, bool useDualstack, string expectedHostname)
        {
            GetEndpointForServiceHelper("testEndpointsWithVariants.json", service, useDualstack, region, expectedHostname);
        }

        [DataTestMethod]
        [DataRow("some-service", true, "us-iso-east-1", "Requested endpoint for some-service with variants [dualstack] could not be found.")]
        public void GetEndpointForServiceException(string service, bool useDualStackEndpoint, string region, string expectedExceptionMessage)
        {
            Exception exception = null;

            try
            {
                GetEndpointForServiceHelper("testEndpointsWithVariants.json", service, useDualStackEndpoint, region, "");
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        private void GetEndpointForServiceHelper(string endpointsFile, string service, bool useDualStackEndpoint,string region, string expectedEndpoint)
        {
            try
            {
                RegionEndpoint.Reload(Utils.GetResourceStream(endpointsFile));
                var regionEndpoint = RegionEndpoint.GetBySystemName(region);

                Assert.IsNotNull(regionEndpoint);
                Assert.AreEqual(expectedEndpoint, regionEndpoint.GetEndpointForService(service, useDualStackEndpoint).Hostname);
            }
            finally
            {
                RegionEndpoint.Reload(null);
            }
        }
    }
}
