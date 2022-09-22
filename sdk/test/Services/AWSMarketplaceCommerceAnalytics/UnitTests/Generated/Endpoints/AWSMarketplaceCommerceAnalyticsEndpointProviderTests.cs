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

/*
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.AWSMarketplaceCommerceAnalytics.Endpoints;
using Amazon.AWSMarketplaceCommerceAnalytics.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class AWSMarketplaceCommerceAnalyticsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_67532d1126c947cdb1d0e2988674f928_Test()
        {
            var parameters = new AWSMarketplaceCommerceAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceCommerceAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://marketplacecommerceanalytics-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_3e48d7eb38a94e1cad0029488da0506a_Test()
        {
            var parameters = new AWSMarketplaceCommerceAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceCommerceAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://marketplacecommerceanalytics-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_13d721cfa95847c0871c45cb4be709cb_Test()
        {
            var parameters = new AWSMarketplaceCommerceAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceCommerceAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://marketplacecommerceanalytics.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_97fa10f7dd0042bdae8b6fc25daaff4f_Test()
        {
            var parameters = new AWSMarketplaceCommerceAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceCommerceAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://marketplacecommerceanalytics.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_1efa30fde331447794217fce670c45a8_Test()
        {
            var parameters = new AWSMarketplaceCommerceAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSMarketplaceCommerceAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_96965fe73c5d4b079da6997c278b389d_Test()
        {
            var parameters = new AWSMarketplaceCommerceAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSMarketplaceCommerceAnalyticsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_234cf1abf0494e5696ab07cbad5b4934_Test()
        {
            var parameters = new AWSMarketplaceCommerceAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSMarketplaceCommerceAnalyticsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}