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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ApplicationDiscoveryService.Endpoints;
using Amazon.ApplicationDiscoveryService.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ApplicationDiscoveryServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_1322da41651c4befab15e01502831331_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_deab3d98de664a9cb4f0647ebe80c8d6_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_e14fa1a1d0a448e5a37af80d4473ae7f_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_ffc6e86b4291439091b1d3feb6da0341_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_fca95cd200c6446198d06d118bd41156_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_90dc4b4f62894b6fba97514e8c9c4d4c_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_0b71e33dde9147889e797e252fdcc32f_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_33bd1a2e36bd485bae619d1daf6a6d3c_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_3d990027459a4d919bbd3fadc5bb2775_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_ae30d1ca16f846ebaf7c150ffc46639c_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_c8ad5877914f4b458b7c3594dab41249_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_50a9a6eb6951489abf7361467dc08b6f_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_3799708ab518433e9cb890c3372c2b6a_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_a46c77f2804849a88e4b98187f112d5a_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_614127f9b8894c16bd40ab63f0a20a9a_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_0d87ceb3bd0d47e79e88fcbef855d82d_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_bdd7206d36bc4cb3b260ebbf065848ac_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_9c23cbc4a7644aee89cc923f2c0fce82_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_6e0b835b60be473b87e090f754c62459_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_d12e7168e70d42d7a0ea7853abb20581_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_f89f4a8cc3004b979d3f2b72f2658566_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_cc5b5c86cf03419e967e38604a39e803_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_95a0a341668440e7b316cd8818a3dd2b_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_fe6bf397f6c943f086e6ded80749ddec_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_ece64b96adbf4901bf6fb5b4833a7309_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_b8ebe72c513e490db82402cbb5fa9a69_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_7de27ea11c874af4bbd1c82cd3340b9a_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_e07dff7dd60d46dc9229ecf59be67f6c_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://discovery.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_6234cd15d42e44e685cf922ea823a87e_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_a5b2a4b528ed4ed8b8c5b9e57e69708f_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationDiscoveryService")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_87623d98f7354dd88506a60ad0ac5b07_Test()
        {
            var parameters = new ApplicationDiscoveryServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationDiscoveryServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}