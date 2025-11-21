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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.ARCRegionswitch.Endpoints;
using Amazon.ARCRegionswitch.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class ARCRegionswitchEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For custom endpoint with region not set and fips disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For custom endpoint with fips enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with DualStack in us-west-2 routes to us-east-1 DualStack endpoint")]
        public void Control_plane_operation_with_DualStack_in_uswest2_routes_to_useast1_DualStack_endpoint_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseControlPlaneEndpoint"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with endpoint set in us-east-1 routes to provided endpoint")]
        public void Control_plane_operation_with_endpoint_set_in_useast1_routes_to_provided_endpoint_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseControlPlaneEndpoint"] = true;
            parameters["Endpoint"] = "https://amazonaws.com";
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with endpoint set in us-west-2 routes to provided endpoint")]
        public void Control_plane_operation_with_endpoint_set_in_uswest2_routes_to_provided_endpoint_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseControlPlaneEndpoint"] = true;
            parameters["Endpoint"] = "https://amazonaws.com";
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation in us-west-2 (standard partition) routes to us-east-1")]
        public void Control_plane_operation_in_uswest2_standard_partition_routes_to_useast1_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseControlPlaneEndpoint"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation in cn-north-1 (China partition) routes to cn-north-1 with China DNS suffix")]
        public void Control_plane_operation_in_cnnorth1_China_partition_routes_to_cnnorth1_with_China_DNS_suffix_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseControlPlaneEndpoint"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation in cn-northwest-1 (China partition) routes to cn-north-1 with China DNS suffix")]
        public void Control_plane_operation_in_cnnorthwest1_China_partition_routes_to_cnnorth1_with_China_DNS_suffix_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseControlPlaneEndpoint"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation in us-gov-west-1 (GovCloud partition) routes to us-gov-west-1 with GovCloud DNS suffix")]
        public void Control_plane_operation_in_usgovwest1_GovCloud_partition_routes_to_usgovwest1_with_GovCloud_DNS_suffix_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseControlPlaneEndpoint"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation in us-gov-east-1 (GovCloud partition) routes to us-gov-west-1 with GovCloud DNS suffix")]
        public void Control_plane_operation_in_usgoveast1_GovCloud_partition_routes_to_usgovwest1_with_GovCloud_DNS_suffix_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseControlPlaneEndpoint"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with FIPS in us-west-2 routes to us-east-1 FIPS endpoint")]
        public void Control_plane_operation_with_FIPS_in_uswest2_routes_to_useast1_FIPS_endpoint_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseControlPlaneEndpoint"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with FIPS in us-east-1 routes to us-east-1 FIPS endpoint")]
        public void Control_plane_operation_with_FIPS_in_useast1_routes_to_useast1_FIPS_endpoint_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseControlPlaneEndpoint"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://arc-region-switch-control-plane-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with FIPS in CN returns an error")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS is not supported in this partition")]
        public void Control_plane_operation_with_FIPS_in_CN_returns_an_error_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseControlPlaneEndpoint"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with endpoint set using FIPS in us-east-1 errors")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void Control_plane_operation_with_endpoint_set_using_FIPS_in_useast1_errors_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseControlPlaneEndpoint"] = true;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://amazonaws.com";
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ARCRegionswitch")]
        [Description("Control plane operation with endpoint set using FIPS in us-west-2 routes to provided endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void Control_plane_operation_with_endpoint_set_using_FIPS_in_uswest2_routes_to_provided_endpoint_Test()
        {
            var parameters = new ARCRegionswitchEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseControlPlaneEndpoint"] = true;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://amazonaws.com";
            var endpoint = new AmazonARCRegionswitchEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}