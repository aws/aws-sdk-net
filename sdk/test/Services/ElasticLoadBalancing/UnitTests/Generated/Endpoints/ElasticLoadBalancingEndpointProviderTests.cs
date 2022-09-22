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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ElasticLoadBalancing.Endpoints;
using Amazon.ElasticLoadBalancing.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ElasticLoadBalancingEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_a22b43016eea4c3db65aed984a6e5d04_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_61dc5115854d46a3b3a91ced92654117_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_8f1f2fe5bccc4ba18d593a1f7a852281_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_83562a7a9fe34b73970c58897a7da509_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_ef7f1283d99b4bcf9d9eac33f9c16064_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_35cc353670b443ffbde3bbdb1987590c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_2787cc60fee74824940433477333f055_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_6771dda8597b498e9cc19f5dd2e0a73f_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_05fe54a138aa430fabd039f15964b9b4_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_e87d1f32c2f54855beb265267ddafeef_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_33e50cfa4c65472fa2b4bd7cb4841af9_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_daf4b555843b4632988645ecc446531c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_e158f3f50f224b6ca50041809b7f3d9d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_c32e97f19a3b40b4a15b0097a0960433_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_8357ff8584cd45f0a2c0d3b950c8b275_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_666acdbd702645848a4e10fd4c56be6d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_828b87cafe9a441a8b054c70fbd9b750_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_10c403afe2204464b66287f61dc2606c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_ce635befcd6349688110a61b4ad59bea_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_f4e0d5f6ba204e128fd2663097596427_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_40f1aaf3277b44eb9136da2cd4b24563_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_9ceaa61c6f974e0f85196849cbf93f15_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_dd5d3a42e5f447618cd5b6e8b87666a2_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_b8a6a706958d4d7a95c361adf4d9b273_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_51381939ad7a40d993bc3f8c00410104_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_e60bc9154bae45cebb1ed44a3d467e39_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_abc5c42155a84b97a0bb80d5a33c6c35_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_70a7b34121a14a1b9775ce70013754b6_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_c2d557d73e5442f2b91c6a347def749d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_3ff630378abc4095a357db6b9d0fd8fe_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_bf23efabebb04fff862615d080730838_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_c54133dd2d714f6e938b2ece4ea59c93_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_084b9e07206343f88f8b673c165516a8_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_0b78f225529a43c4a9f6d93f25682233_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_f92753c5017246168b8993cddde98679_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_a0305db774eb427f85fb0f4e038fd06e_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_42705a9209c648d5869bb836c2708677_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_934c898d39594c44908a0439f4e3c56d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_346199c64cb1497eb08fecfecc6af31b_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_37affa79116a4f9e856ab32695fdc7b0_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_0c69c85347754c538e483ab966db3d20_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_3943662ff9d9482f9bc07e231e3bba9c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_84f2bbada08341ccb13a28cc2e73adcd_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_eb209e9e42f646309635cb979c4fdf8c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_f3b3f0dec0ee48aa8a1370ad42d10ec7_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_28f40587c41d4a85874cce93372d0dbb_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_5ea44661eddc41bfa3b7743176f09a0c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_10e48b11cf934fac96e9c6c298c37c7b_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_e411eff70c1e43b98fc6d95bf7bcc61e_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_8163ef7d7d4f4f97bf670b3f5778fd72_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_7085606fbcb94a6683a51531d64322f8_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_6c55bd7f29894eb9a58f41f1d400466d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_b0d8f008d2124b50b3179af79827510c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_432e631898c441b382fbf91b4bf2cf8b_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_0e53018e38234e239d9a16ecf0960168_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_1525ba3c81324fb98938c0f1097e6351_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_d66722684c614fdd8c8f686c8e4e6efa_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_d999b0041b8e4247afdeda859a4bc273_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_285d06a9387149e8b41275591a949578_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_f39c856f78c644ce9858dfb7ffb82ac7_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_13c3b5aaccaa4160b798e406d156d86d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_8af00ad3aadb4e1eb5f0e9903f01fd9f_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_8c5fa643294940e0940b9790b8c12670_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_fc93e3d62aba4042a6fa692412914274_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_8ce736f97c544443b3c6add051dd313d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_2979b15ef36e4a40b768311791ab2ed0_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_cf121f55d9904124b7e7878a1cbaf078_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_d93973c9843d4c7dac1cc4044190dea1_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_baad5fe8202d48178c83595849eb7e6f_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_24831be0fe24430b95fa07511e7c9707_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_7249a9b301c34860927d331b2c02f9cb_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_40e05b4d2b6c4636aa0ddfe3b03e52d9_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_9a827041b64949e6b292f51d45a06977_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_cd9926e3402c40108651865c983b973f_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_acb6f04281fe4c479f28e0213ffeab2a_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_7133e08e7e994b6ea354c28236e9039d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_775471e5094d456aae95c6e597c96b05_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_9affce8786bc42df977c1d04e82eefbc_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_7168e848e13242fc8767d423f1b6dbe1_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_03160c43da9a47b2911b16b78560ad65_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_aa85f848ee034350b9453eb48c1ba438_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_ee72491b057e474296958000055174f3_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_3d23c98fdd5f483dba2191dd8e483525_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_d6fbc6b00d464451a2f1a4d97b74ef61_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_35c413dc9f81477d88ecbd6f7def7352_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_4f27d848ca104487b11bf77a03844927_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_70c2f030139f4b74b82aa941c9297d80_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_501a05a4dca54537bd00429f8d212ce6_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_7a94f407f7d641d3a3d2e36a435769c8_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_72bda344eb7d48cba3dfdc831d9519bb_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_5baa9cf6e4eb4df18df459c35662797b_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_b72295eabfef479ea316b07d7ceff289_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_84b9e320416b46e8819bf5826dabb173_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_6cdf4d5699c94855b54eaefc66f27820_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_728fa0054d164393bdc8620494e3b19f_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_1c19c9b4786e4b75869eaa46bdac7c35_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_449e6fecb3c840269c40198ecb966964_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_ba22ba1358b64d7a8c62b23c34754f86_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_56ad6251deda42c7b9f8046fb83fff52_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_2a4b3693b2f9433cb0f3aab13f7993af_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_fa4e4f48ff18403698878ed9b3506227_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_4749dfe3843347d8ba9241d1a0376bd8_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_674e9e6e8cdc4a00b5024510ae7183fc_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_7e6b9a77f96047c5a0893445d2e4ce64_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_473a6ac6e434425cb91ff36d48a1e0d2_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_2c0ff795217c426caffeef78a4554c86_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_a6acf6466bd143e19f9bd145eb3a77db_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_96b6f54729cf441fa0e86e38a7ea12be_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_94900e90ba684a84bd4fb29137c030d7_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_64b49d9a6fc840dea99693b71a446fad_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_eb1e584c3b09473594bedded8b168afc_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_670f1e2e4abe40038d06cdc8903cf604_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_b2dd7798bc7a493484cdc408e13c6204_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_ec003a918c234ca3985ad5564e65e00e_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_7cedd11dc75e40dc9bb5d741df237a05_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_7f23f23e0b494eaf834d840585062adc_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_8093ecc28bab4dfd87b66a6cb8b05ce2_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_0837b51d8925436393101378af9fb477_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_645ee23cae0041d6b6eff29f52f980f1_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_58b09dd50c74468b95fe3a753f87b356_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_2bd552e783e14525adc7e1e85ea6cbe0_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_6e93aa46115247dc8c1136baa7d070fe_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_fd9d6aa6918b4ff0816abee0e191539d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_102a5b21ebef4b55a24bb9ceb16d39b8_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_56eb7c9d62ed4cd086701454a2e3402c_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_fc269020199348fabda11dae59020382_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_4012469de9fd470798760a82733cc6e0_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_2d7ab00db74c4cfb98acd645f31d2cc3_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_e8b9baae7742471abcfc9c0a363fed8f_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_55f4137cedbc412683515c25dd691175_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_5ef6800c55f5454eb2d8bbb8f9302e18_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_a6c188a6370c48e58986674dab8376d6_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_02d5d1d5fd324af7b81ea6e97701d032_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_a7043a6d604b4b9cb811b63ef32ef91d_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_aa69abfa62034e18872c8eac7e1a29c5_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_268abab3291a43e4875ae1d6566504b8_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticloadbalancing.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_b2dcb39cff65484b938c33391ccc6740_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_a2fe45de8d5444e3bf96b8a459442398_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticLoadBalancing")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_be3147248c944479a10375444c471fc0_Test()
        {
            var parameters = new ElasticLoadBalancingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticLoadBalancingEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}