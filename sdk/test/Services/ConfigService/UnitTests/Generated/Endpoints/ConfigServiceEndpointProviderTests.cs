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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ConfigService.Endpoints;
using Amazon.ConfigService.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ConfigServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_8a48ba070f8e48feb4607fd2215f3aec_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_f9779d19ebcc4c1ea4c1a3d8539cd4c0_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_02d209a7adad4e359c192c492c3cb9b8_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_65886ca1f62b4a6e8b723184217f1f16_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_b00e4ed903e5459c8595bc2625cfb2e5_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_ad9051b2747d4907ab86b29f5bf7b0e6_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_d8e7c6e482ce41e9813e7c151bd08c82_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_6fb46fcdd20541b5893223485e934fef_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_309229de6d2642f7b016825ef00d8800_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_21c39b68d94e4ff98f34d1d480c7d0ac_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_132282aff81f497797cc2b3fb60c2bcd_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_8c415e209b174173ba46f17a40e9cecc_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_9ff78fdb36ff4333bf1d711bae3c3055_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_e05fbf11e2564bbf9fcf1da2a71b4be3_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_6bea1b4d4d264b6d95e193a6fb02a0be_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_b246a4bca1434bee9d49910f7f4d019b_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_9ae690cbf9994d72b5ca0647f259bce4_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_2009939c2e1b45489fe323d97ca3f900_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_4c0a50201334451c874ff1a865ac9a5c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_3ad37b2ffc5b4097b0c4bcaa14ecbde0_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_26b6511e0a3342148329eae9b4b2204f_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_00b8af9aed0c47028c0df30907480ef5_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_c1a6a8377b5a4b3f9b2ccbdbc02e53b5_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_73c2ac00e95844d3a4f6e2d49cc18f02_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_b70af38dff914d32bceb7fb15b742c65_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_52ddcefe16c8448992a1bb9efbeff370_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_49af14a27cd641fa84684411a5dc5691_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_8c976ae200eb4f9687de8bb3b2729f93_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_233d61b6665547e5b1bdc4e4db528ab2_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_31531dfa527148559bd798f4b92bfa0c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_037196e20d624572a71bb8ae13061439_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_d4f25c819976485c943b7b4848741fdf_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_281da92355774311a17e026c49179400_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_3907d2ec0fac446883abc37642746971_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_6f9ca98640864c2ea6af5760966c6805_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_3615e4721b0f41009a7c6171a8ddf791_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_711c1fe6af1048eea423022e2b438cad_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_57e3e45167d449b8a120a2803d9f8374_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_15aaa155f4ac46fa98372d1e521205dc_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_42d25655bf124dd78d6054a79b274f2f_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_a2044f690c5844c8806bab4f5399d878_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_9ba706c7bded454d82e3d19e74d4eb6d_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_8cd27b32f6904dc49eee2b2519ebcd41_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_6f38cbe6d6f4492397a2a2cd2dd37a8e_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_c7747e6a62174df2a79bb5f08512ad70_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_7743ea5fac60428b9393de1b6b63a95d_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_3b378bf0d39a4df0832baaa2fb704830_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_33e4146167ed45cfa1953752c2bb6513_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_ece4bae47a8d451fb39dc2fbc0025c03_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_4e40f6ee39344b3abd30ac2f1140425c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_eae2ab9c6f46462db8bf49f80b9d8b94_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_07ef1b2e69a141eb8e26bea7af06af73_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_6a4158966df4464ca5e3cd71460c8b44_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_76bcdae95a074574b5f0df86a9564162_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_44df2ca3a913468cb4001413d76a878d_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_39c81fb9da2c43238e30330ae87e47ca_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_89d2ae1134924e09bac87f1f1cc06f74_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_d4a2a3bceefc44d48bd2c9c1ebb98b50_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_6b427e230eb947f5a2843240e79fadb8_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_66160abfa8bf4a659df79fa5a180b2dd_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_b9993a80f92b42a3a67a0b034da9f88c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_528f33a0255b4bcf8bb3f64e9751dd82_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_37ff4329153e415a96d3eff55e1ba9d5_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_047a71ac9eee4f8182854694517e7123_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_4c55624362104f33aead066ada27652e_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_8461b9bd07e34d3188afc066263727d5_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_355324f62c9c480387b262e2ddd9002a_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_064031bccb344ce5bf527ba99e8f1b7b_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_3c7e93a72e4a45458a45850dc2cb62f0_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_16d78beaa1444b6bbdf43a37ec5d7984_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_c7ca1e6c6a444db69d1fdf05bb06894e_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_ce0dddbf9f3840a79a8d6a30cbfae2ca_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_85416b9522d4440191379bea40f1a717_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_d5492a0ca82b44799869210f937f6eae_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_7309bff9d7ae4bbfa820b72a85129619_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_5650817a39604f0090e267de27927327_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_e5724ecbc9e04820b4cbb3a2810a64c7_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_89cea6e987e24049b21567f7dbfce2c7_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_f1c05cc6483b4da591e49e39f95c77c9_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_73346f95bc4b4e30a6c23f9d5ca86d5f_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_a05cd7d327b8450daaffdee1021af884_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_b6f0142d380f44d58c1ea752a6f7547e_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_e3127e617bcd4f518c62aa53bb37e4a8_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_da1fb1874ff5400ba29b8178e89ee253_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_1a723673ce054a36825ab52257910b3a_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_11093f36b8da4a7988fa5a12aa2dea3c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_32bf250a64c640dab3e35fc941692cda_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_c619119ba8bf4322b0354529b2e806ae_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_f7bd98f325774edab09b1ab90be16578_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_2f693d8ac5c543158bff7b9fd9da63ba_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_319aa675081f4b658c4ba50d735b5f3c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_4136d70a059d4658b8951879b38aac68_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_2cfb11f89cb24002ab6552138241db6c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_c54552be20b0457d8a4d227751dfa257_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_7750b50e41554defa50d4652d135b9b6_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_0a8496d4308c4c88aedc0d29c4481499_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_76ed78caf4734cf68f7d3073dd81b9a6_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_1c6514bfee9d49c19e0c76d6dc28c382_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_3fdd0a2bb52b497ca6378ade349434cb_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_218f6a27246248f79f891e61f9422254_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_2b67b793a923489f9732be0936132815_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_bbcf4dfbcd2f4ee0b914009fce5a9788_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_850e29d146424a4f86d4140ff2ad0203_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_e98eb1c989294429b6cea16278b828b0_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_468ca04d1133465f837015fedbf41dfb_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_c710a90d4d9f439bb137873e7e2ea012_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_beaff29e5fcd48688d8e9c93a6e5648c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_4130d5cc4ad344a7a714c3d7d365ebed_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_7ae29011cf8740dc8d6390ff06524870_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_14f727e798dc40efbdddc6b3115c7b04_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_7aa5c62e79464a65a600381171e0a0d2_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_3b43cce8acf740e18fd27c7a59a5939a_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_49591a0a873a4536a1e125f3e2458983_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_1d0a595a279c4e3f90848430f38ee25e_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_61a59870daf54e1ab112f2876e8700ed_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_4ff345e77d9043dfbe4882b537525a37_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_6cb002236855447d9cd06f1fbe71033e_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_56e8ed1358b042de88e71d554bac28d5_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_713ff2ddd4bc43719419de8b3841d764_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_999d6ba240b54f5b9eb35887a4d2f12c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_3f4ce90ae3dd4ffba77917028fcb3156_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_98750ae558eb48cd897af8f4e15769c9_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_39111f5631724765933398a174621e42_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_34c7a2df088549b6bbe1941d86b16d86_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_ab8440d8cd2845a0819bfcf13d029533_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_e418b5aac81b4e779c395163c038a385_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_0cccac8ab75f4acf845eebc317e078f1_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_38da0279b69c45dfb1f4a43e08de59ed_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_811a5c6931524c64a833d7a5c9ac5aff_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_25b63e9e16354dc5a43a5cbbd34bee0b_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_3cd14e27dc7a43b68ba4a01ec743b42c_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_9d654369e5fb40ca91777a7d5ebeb828_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://config.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_3d3b11cbf70e402d876cf4f892e0467b_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_eb49b672591347099fb22e5ab314c489_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ConfigService")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_adf9f4b8a1db468498602af07295e6bb_Test()
        {
            var parameters = new ConfigServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonConfigServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}