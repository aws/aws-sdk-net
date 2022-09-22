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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ElastiCache.Endpoints;
using Amazon.ElastiCache.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ElastiCacheEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_b720a883ab294a518a87160d78513068_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_1aead46a7412467c895a6f85783dd740_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_7e5232bb8e924d04a67e5d93476eaabb_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_34a3a4cb67aa4d8db73993459ead4358_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_2f3d45339802421bbc3383dc83a170de_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_0a36a5b7bc5743299aade4961bf199bd_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_fdff8bc9cb9345a7919a2bfad678f689_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_d2383e63444d469dbcdfcddb70a943b8_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_5eedb4e86b6042f08fdd9dea14f1e04c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_112bd23e5a8447f9a10e0f0481ce4059_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_efa82319bc3f4a24accdddb8559e858d_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_48dc9a6ca46740ee862f899755c84b6f_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_7d32daa163514826b4a8e4ae8543b165_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_e6da403f9db140228a9f3ac582d8957c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_2637ea65ca1245e0acd235d00945d9ce_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_1bf07111ca0c4a5e9280cd32641fac69_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_8f24a18d92e548d48970c2322a9a5ef8_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_bdd69b2422bb4e839ecd060d7d5b2d09_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_124b453ec6a64872b616a58c2bd38a19_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_aee44e0f2a754c12aecd91558e76eab5_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_cd62b8b586dc425dbde2d83f802144dd_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_f734d75829c545f493e7b9aaac280480_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_54af7c332e9f47a49f4911935b6bca05_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_c4b0387d5cf2482ca4da4815af578f97_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_e186500a1c1246c7b39b1bd202186210_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_b7bb86563c13411280832006041fe4c8_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_cd06a0099f914e348cb36d382cb355e7_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_a72514e0eef54845b8e4b7b4e2d63b14_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_97483c0763b54c0eab25416b9b11d188_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_eb879c0df53f470684518d793833aa73_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_9536b715e5f74dd8885ed2943d43492f_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_8ce1db0461604d80be671a1cb0238ecc_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_a0b3ad4e297045d0a43ab671b6f66a7a_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_17d17e01fd2044efa551d319f15f2fb4_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_21bb36d95920487a971dd43f1115e1bb_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_41646614b9194826b8df7e81d03ba8de_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_12a3ce2e029c465e96526b646493760b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_d67922c9e6eb49e18cf86a12fba9e8b7_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_e3044774b8a94e4e8530a1ed9e73c613_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_7aaf9aa71a3a429a96c1b65a898ced83_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_df3d57fd3287414c82800a598e881ead_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_07224c11105546119dffb7b76b9a37fb_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_a81167db31e94fe29fa067158239272e_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_560e0d40c91e4e83a47fe1c107736a49_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_527279cd6abe45608e9c425aa6abffe2_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_0b98e69ab70d43db8c2b20dba541d866_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_fc46aa51eaf84ef39a12509c401d403a_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_44cc4cc70c494e04af87dc563411246f_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_419c47f135324e4c87f1b71f41f705bf_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_13f0db2cc01f4813bb06e6b1f818e3f2_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_610bb6c7d4ce42c7afa1f369fa9bb976_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_cd3d0c69d5fd4be885224102c6896eb3_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_a588f72b93b240d5b7b44810f68e9eba_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_3e11f65e561a4b4f81a4be5d324cabcd_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_f3a73088a2c54438aed5b70e67fe71d7_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_bb71e6800f204a869f4a3b131ccfc9d4_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_9a8acf1bcd5d4c9d9f8d62d2b448fd85_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_79e52f48e4d74dc2913e6ccd9b8de07e_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_a02f7caed7df4ea3820b645b1cf23b6b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_518afa5a24ab4a6b9c0e768cae3337c3_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a3cc144b6d8749cdbafce0c03919454b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_7bd6aafe7f3548ff9e0fee6809574296_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_e33fa3a6f417456e8f98b98ed63f8fc8_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_0841edc07ad64e3280d7cf6723bbe02c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_c1a8daf6ee3c47ca848a2b15c216137b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_8eaf852319094c76b5e3ef7b8bcf8a4d_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_1792a438330640e8a30a5cd875c0ad8d_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_9d44a73a5b2745ef8d3af5b49cd49bf6_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_a1e880054de14e7c89b30cda980f676f_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_2c948bcac7d7475b91d728a689bc1178_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_4f378999ad0049ad9c45cb347a22af71_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_3081d4dabda742c8935291d35a756c84_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_242b2462710342e3987a493a25ff31a1_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_94803154753e4742ba742a597000c1cc_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_21e661fddc504979a67bf7ae4c6776d5_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_947ed740889545f5b7e99691851a3e2a_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_47cde8c29d104fec928fd2181c96485d_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_283b73fff80342eba821bf8c4f2e98cb_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_798a61fd3afb4e94b887d9a6ff646967_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_906ef3c086af4709a68b4d0a5564f89d_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_e06f608a06234d1d8adb67c5e947da3c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_71777e3a04f44a9d84181016d3876140_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_4f347846624840998e2e242d7598b12e_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_cd066011c0654511ac416941a416acbf_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_10f87d48e58748e2b447d06a7910876c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_9975587c180f495a96bfe9e65fd1352c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_caedffd1705145dfa098ae32884ebbd6_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_0a51d2a7f07e4bf7bb18fc364095c64f_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_2d30e5a2de4a49f48b4a655271e5d748_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_a09a260c8da04d8080a204fd459cc1a4_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_02ba2c1f0437496d811db18ce0f349e1_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_5b5322285f22425ea95202f678781090_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_347f7ba9628e41cd9ada46c44c02f07b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_d2cc1fc9c86f480dacf977a0f2c3f3ca_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_9ed3ce12a345432bb1f48c4eb3e83f76_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_d43d984c8ce048febc61edb528e82740_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_da67dbc569ca4955815f72a603b40504_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_fdd1f0665b2c423c91e1385e1355074c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_170a14aef69b4871be71e004cc0d2c4e_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_cdefdb29961a4e1ebd0ae539184d607b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_29cac544eb3b40f582ac9bb4561bf5ec_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_c9db2a3632ea49a4b4651505ca4d39cf_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_e057d043761049af8c4a365e0ec6b28c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_724c7486afd04fad844aa903098849e0_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_8399a5daed0846dba550b491306e0b8f_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_5e9ffcc3b43a480e9d300afede64ae4b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_ff3394a3bb574a339b17704dd9b6e213_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_38868d4e68b945d19537bb723a886b36_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_24d09822fd3647eab691eaf5fac83ac9_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_dac1f70b2e074a1081f101a774411fef_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_2983c1f66d4a4dafa1c8d1cb89519432_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_ff26ffcc2bdf45f184f333db8e780c7a_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_7cded773418d4ef5a91282f0845f4bb5_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_c54bbb14933f4ee3a13b9f4fb8234fa2_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_1fcb08a14973472dac51eb37d71c3f93_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_cad5c17f2e834fc081f1b45764c31268_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_010be2b36822406fab1c98d13809a6ba_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_1129f8f16ddf4760bec5d26545dfb541_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_7e80bf3badd544f4944d9ff736be0b87_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_60a94aa4bc0e498dbe98a789d6725bdd_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_8f75c32ce51544eabaebaa897539e411_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_ad17155978ea4708930e8a8ac8df686a_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_deefb17a9c974e1b8b66fb5215ea8481_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_0c901ffbd7844776a4b05fe594189b53_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_7c1d352cde7443c8bf0d6c791519a9c6_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_d54fe10c6b2e4b1b86c985aa9e498cd4_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_a18da936afeb4a07bb92095edfa2e37c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_be11e9b068364bc8b66971ee8fa0695c_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_60b0f7efccdd4b61bd0274895ad0c63a_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_e4526b0e06c343f6859336f8df9ef1a3_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_097628b8377a462584b935a83470e09b_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_d874ff09f1f04ccebc2c1ef3693d04ec_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_77d7c372e44a49beae34e6c583726e28_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_d9076e6353e54cf58d9d9883d52da9a4_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_cbf711c248334895b91aeccd680c8619_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_7e847fb452494150ac2232cc5531f111_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticache.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_b6a3368bbe354ea3a163bb8ee259c5a4_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_b4daac498d0e4e9881bf245f15e11276_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElastiCache")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_12ce47a8749f4a879485f8daf427d3ec_Test()
        {
            var parameters = new ElastiCacheEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElastiCacheEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}