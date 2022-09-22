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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ElasticLoadBalancingV2.Endpoints;
using Amazon.ElasticLoadBalancingV2.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ElasticLoadBalancingV2EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_9c82a7ac533e4b4da928c9fcfc92d9e1_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_43bd3e49333d4b1c8a945f0795629f58_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_f58d949b78534c7cb190e7ae4d92ff55_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_1a6dc33d93b14cbdbfad3a0db738496e_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_fbb7fa09c60f4c90bebc762cc4eeb03b_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_07e99700d112416aa9468ca0cf574b68_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_7415f20f35d84d47af8a6ac3033d6a91_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_7446645cab9d477e99cd850902118f21_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_41ef9a97ead44185b401826b65b3ab22_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_3edf17c143584918b755be6cf85d4b2d_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_cdff8446c4a54bbd9f0eeb7b10770969_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_be2b5f8bbe0e48b1955c247259303268_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_f394b90a3cc24a60a2b8777cad41f378_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_5bb49aa6506345e791e295bc10b4a4f7_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_368821c85c9e417ab0d6819422042001_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_5d88306f03d14623a22a73c263ad2e8f_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_ed372708666c4baca2c28f45cc16a908_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_f65f54437fb4415589721171b7531592_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_91a9bbee1562489ba98d6b65046b1451_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_f2948b5f4b03460c94bf0f11e176911a_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_548b825c9f294413930b0f0301266871_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_720f6067c3564ad7a93623573f949003_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_46456ca59f9f49b2a4788b32d6eee166_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_2a6361fcd4ee414ead9d64daf87b41d6_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_8ab1a823ba2541b1bc56425810b34ab2_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_64bf1f3c510a42c08392e0cf0b04de14_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_aebc16a80d044bbfb6f490d757f11e93_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_c1109327eb1747ddb7d97d82878432a8_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_a8a1a9b720034105bdb240c4e700b211_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_003b68a11c6a470e8c6badd51fecf7b5_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_367e2515c68b49e08480d9efb4a2a1c4_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_df6794d26a2a42b89d53df1ff3a96b38_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_3b7d6709a4984b6594f0226ff604c0a9_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_08321cbe93a94edf95ba39109cff9adf_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_6069084d212b440e9cdfa17309797f10_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_01d6dd3cb12a42f8b551fed502071d71_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_ae9df66a669b463190bc1d8fb687deff_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_2a2fe353708e4499afd1d32f0e2f2109_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_ae2a332145044cdc9ad3e4cd4e96dbb0_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_8f16e9b4392b48a897c7be0a13b93055_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_4f7b7fe97c7341de8df0610b873a7b70_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_0417d62a04ac43a3ab2a43819dc3b8db_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_bf6e74e0abe442e58bb60611e00bd62b_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_3659056c7e1f4162969ceef6d2b5ac46_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_951b58d349af4526b1f92ab4d9b7d722_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_b0a605d7f307456da0a6912ceda62a61_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_bdd286eeb5754c53af086a1cd3265bb7_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_ec1bd6ebc4d74dc2a9e6d03fe8125a0a_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_4a2b872fd9b1463191f531a4c0c94bf5_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_fc7629c433574d11942d0864b15d1f66_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_380dc95953a746279aeedbcfb9d224bd_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_2493c06202984380a9a261c7c9229e9a_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_3c336132921f4476a7d0331176d615fd_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_bcf2e25e9fa949faa25e8938170f01ad_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_1d5b6fb3eed2447d8e5fa1e8f467dc8f_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_4515963ad3e84a2485f0fe74abe97ef4_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_73d4f0a4a7434ad7936b9021a9d28abf_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_b6731e96f26c430c8d7cc325ddbca6f9_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_f766db5665ee45fcaac59d4d8aa707f9_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_bb0674d68eec4606a880bcf7d02a166f_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_326ce58975a2462ab1a9a0ff0cd5ef3f_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_629c25b205c14284b077d2f34de33351_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_0836d7f3985845ad8832bf331dc48f54_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_4904575ef95541db8d3188f1f3c0cbeb_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_b403964e17464ab2949a84b5e67c486f_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_73e935ff1f1c4adcb2e9f4afa7344f55_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_f9dd115517334c6c83cf27660e96fff8_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_1804abbfecb0446885fe05970422760e_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_e0112b1719bf4696a099f349da743acf_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_984b9d649a8740028b1468df5f3fdffb_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_36f24ca0fcf94e918c8f7c6c3eef39ca_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_89fd22bf15114d60a720470f0706d587_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_26984132874e49858666310acb58f46a_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_ed36aabac3a04247a46a51303753a498_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_a671e45b5ba642e3b14a425d064c2c81_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_36e3c46358864d3bb9b3a283a2ffcdfa_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_8632bf589ba5492b97ad6479edf4f87f_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_7a82a1b5ec8f446ba82f3c191390197b_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_95ccdca66d494bf596ec3ff0e8b9eb7a_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_e7330314d1d2492aaba3200981ec6faf_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_394388cd24f3442897bf6bd7b810ee15_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_c18bcc304d894bc99c7770e243886b82_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_f66ddbacc925465ab8ae290294b598c8_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_a2f08f4bf6424b47900db567cafb9537_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_e8f261aecfb649f29745407de275d31b_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_2444c063d58e4743a15d6d5ce9ec3f14_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_269d11f2440646d0948b3580f58194de_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_427e217f7a1f4693ac67afd750019845_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_ad883ceea21e4a1faadc8baae2f94fcc_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_f8c74f091e2a4877a6e1936fe60aaca7_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_cf098b45bce241a2b0d47dd34eabfba6_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_57f1cf548c2340d49eccb92a8ac8ab1e_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_0fb9e45610b54402b622b8764353b57c_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_e3a02dbcb90d4a518c93d1a860e6c609_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_a8fc21a7cea04112acf28bf6ba0976ce_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_fa58b346185a420991274b89ac22e59c_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_28ddc4f79f1946f497a88c2f644f3261_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_8153e7a0aaa546ba9f335fc1999e96a4_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_4362f501b2c94232ae47e5a6163fecdd_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_e0a5f4a7b7ae4fbfbc5009fcf71d1a10_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_335122730594462c860a9677d6f1617a_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_1117869a72b44b6781bf286ebf1fb597_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_a92698a3d50b4e789c1742e10862dfd1_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_4677b62cac684c1ba5eac66819302bf1_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_ad76728136c54cf0a796355c303eed0e_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_c9ded6f28abc41bbb431d604b9bed92e_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_5db48fd9195440cabba1e8269abca7cd_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_10ea146bf2b1439a804d3155f4501046_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_c25c1b3a9a624fc3bed2f72ed4309a71_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_6375595f488b43f991f855963a03e6b5_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_d9d8e3b7c9de4d939017cb16086f8cca_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_a6579fe304864fc28835769977871599_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_41c7118b8361469aa1ed69b26d825f1f_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_b8af3a4b640b477187ccd3ab9f54b086_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_deb686deae924b5e9c9eefd06f643fe4_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_5319642ae6004360852ba82599b45a00_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_b852fc86098a4756b146d9820b12072d_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_10528ee328454cf7bb15a1805facaef8_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_f845d6dd052944879475c403a661ae00_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_6a8f56c6727e4281b837694085a1cb8d_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_3e64b0e0fb3f442c80ba66f4ad47b972_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_0203817fa4bd4db4b9c15bcbe35afd8e_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_dab31a65d75040c9a46759640bc1724d_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_e2e82043100247f0b16230ccb2496105_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_f75bde20c94f4fac86e5d5aa5be892e4_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_86f2a3f838f34069aa019ac2091903fc_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_9c665de90c2f4883952b616e374d89fa_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_463ee76f330143faaa7aa2f1a79ff119_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_c3352537b2de499ebb1b37d328c7a5c7_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_bad32ad904884981a0f8dd4f39b8ea93_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_7efc8becf30546e68e4e92b3a81519e7_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_2a805409a0144dadbb9f695484396da0_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_9080d0f83a6d46de9845852feacbc369_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_1533f3379a574a0abc8456d6d06382e0_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_a979a360c7e34fbfbaf71a734da8f1a5_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_ac7eac91325a42e98676224242ad3eea_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_012218fddead4358906b3f160f47c212_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_cbf7245bb5974dd2ac3df448b7dbdb52_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancingV2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_45b78c4e01a6441aa35fcca6ffc60df1_Test()
        {
            var parameters = new ElasticLoadBalancingV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticLoadBalancingV2EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}