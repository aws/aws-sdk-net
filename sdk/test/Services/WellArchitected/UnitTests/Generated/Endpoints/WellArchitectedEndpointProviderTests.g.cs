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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.WellArchitected.Endpoints;
using Amazon.WellArchitected.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Endpoints")]
    [TestCategory("WellArchitected")]
    public partial class WellArchitectedEndpointsTests
    {
        [TestMethod]
        [Description("For custom endpoint with region not set and fips disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For custom endpoint with fips enabled")]
        public void For_custom_endpoint_with_fips_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eusc-de-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euscdeeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "eusc-de-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.eusc-de-east-1.amazonaws.eu", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eusc-de-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euscdeeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "eusc-de-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.eusc-de-east-1.amazonaws.eu", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-isoe-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euisoewest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-isoe-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euisoewest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-isof-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisofsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-isof-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisofsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("Missing region")]
        public void Missing_region_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }

        [TestMethod]
        [Description("AGENT case: standard region, no FIPS, no DualStack -> amazonaws.com")]
        public void AGENT_case_standard_region_no_FIPS_no_DualStack_amazonawscom_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["SubServiceType"] = "AGENT";
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-agent.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("AGENT case: FIPS enabled -> amazonaws.com with -fips")]
        public void AGENT_case_FIPS_enabled_amazonawscom_with_fips_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["SubServiceType"] = "AGENT";
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-agent-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("AGENT case: DualStack enabled -> api.aws")]
        public void AGENT_case_DualStack_enabled_apiaws_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["SubServiceType"] = "AGENT";
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-agent.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("AGENT case: FIPS + DualStack -> api.aws with -fips")]
        public void AGENT_case_FIPS_DualStack_apiaws_with_fips_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["SubServiceType"] = "AGENT";
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-agent-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("AGENT case: us-west-2 standard -> amazonaws.com")]
        public void AGENT_case_uswest2_standard_amazonawscom_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["SubServiceType"] = "AGENT";
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected-agent.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("AGENT case: custom endpoint override still works")]
        public void AGENT_case_custom_endpoint_override_still_works_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["SubServiceType"] = "AGENT";
            parameters["Endpoint"] = "https://custom.endpoint.example.com";
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://custom.endpoint.example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("Non-AGENT SubServiceType falls through to the base WA endpoint")]
        public void NonAGENT_SubServiceType_falls_through_to_the_base_WA_endpoint_Test()
        {
            var parameters = new WellArchitectedEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["SubServiceType"] = "SOMETHING-ELSE";
            var endpoint = new AmazonWellArchitectedEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://wellarchitected.us-east-1.amazonaws.com", endpoint.URL);
        }
    }
}
