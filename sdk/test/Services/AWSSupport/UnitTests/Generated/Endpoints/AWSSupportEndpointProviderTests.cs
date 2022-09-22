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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.AWSSupport.Endpoints;
using Amazon.AWSSupport.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class AWSSupportEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region aws-cn-global with FIPS disabled and DualStack disabled")]
        public void For_region_awscnglobal_with_FIPS_disabled_and_DualStack_disabled_3c25c1dbc77b434cbf4da59993d959dc_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "aws-cn-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region aws-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsglobal_with_FIPS_disabled_and_DualStack_disabled_c54390e89d3b4b329020f843cf1e4220_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region aws-iso-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsisoglobal_with_FIPS_disabled_and_DualStack_disabled_c3fa33c4f8f845e1b3e2dd17a1a55d7a_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "aws-iso-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_bdbbf672fe93483092fda6afc3d447b6_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_925c81cce76543e6a82bdb084ff01e79_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_b7d7ba26bb9b4d86bcb547fda80801ec_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_1141c5c141294ade88fa4a7f90330e70_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region aws-iso-b-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsisobglobal_with_FIPS_disabled_and_DualStack_disabled_a7516501f18b43cb83b30adba53bdf72_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "aws-iso-b-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For region aws-us-gov-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsusgovglobal_with_FIPS_disabled_and_DualStack_disabled_aa441715a22d443b8a11e006d27a6ea0_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "aws-us-gov-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://support.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_3bf294c301d14134bd9c2fdafda269ef_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_91b1b5ac4c884dbdbfefd3f2612fefd5_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSSupport")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_50d6b798411b4d8491df5d8a7a198e22_Test()
        {
            var parameters = new AWSSupportEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSSupportEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}