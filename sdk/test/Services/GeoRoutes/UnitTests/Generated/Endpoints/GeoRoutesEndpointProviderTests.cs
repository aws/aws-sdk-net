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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.GeoRoutes.Endpoints;
using Amazon.GeoRoutes.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class GeoRoutesEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For custom endpoint with region not set and fips disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For custom endpoint with fips enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo-fips.us-east-1.api.aws/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo-fips.us-east-1.amazonaws.com/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo.us-east-1.api.aws/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo.us-east-1.amazonaws.com/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo-fips.us-gov-west-1.us-gov.api.aws/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo-fips.us-gov-west-1.us-gov.amazonaws.com/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo.us-gov-west-1.us-gov.api.aws/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://routes.geo.us-gov-west-1.us-gov.amazonaws.com/v2", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region eu-isoe-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_euisoewest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region eu-isoe-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euisoewest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes-fips.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region eu-isoe-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_euisoewest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region eu-isoe-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euisoewest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isof-south-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisofsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isof-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisofsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes-fips.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isof-south-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisofsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("For region us-isof-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisofsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://geo-routes.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("GeoRoutes")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new GeoRoutesEndpointParameters();
            var endpoint = new AmazonGeoRoutesEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}