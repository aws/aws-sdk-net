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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.MigrationHubConfig.Endpoints;
using Amazon.MigrationHubConfig.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class MigrationHubConfigEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_72af044f6ae84a28a5a2e1c28704addb_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_6234b2f0033f4c29b989a3b1ae6cc979_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_ccb0606bcdc6453a94bf30824bcde5e3_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_22f98802674c4d33b8efbbc17d1ca6b5_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_8833817094304047bdd9996cd7ab2848_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_43495362f9dd465d98254160367cc866_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_ced87fbe74264f62abe7aae36f6aa691_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_ac17501e5b9d47bc97314c015659b5c7_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_e8cfc1dff2b64d368b65cdf6f9a9d812_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_87e430cef2d34b1cb9be48f2ef397065_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_476c3efe08c34643b9cf6daf0969c546_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_7e4de3ea65b64dc7933ca3f15b0718fb_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_029909ee27054de8b9491bcb1f0aa07c_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_d9bfe896684e462a84313754460f236b_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_2cf4d6583b2c44ba866159878f79683e_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_b596609bed944fe38ba2ebd7303f976f_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_ad0e2289b15f4bf5ba33aa325ebedc79_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_23a65208c43c4016a50c39efce92c0a8_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_5c46d9815f1b44c194fba64006e97685_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_dfc554a1783e4358b12c33e187214a13_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_525aff11fef34b5eb933bbf1f68a9842_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_26e37ee73eb74b558d0aaa20a017d1a1_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_c845cf5781cd4dd486724cf1e821c1da_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_871ad907d7894380b8dc53f9c03b980b_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_6b3a139f24464e2f997ecb801255711d_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_f5d78cbdbe824db39ea32b0dd5eb41f4_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_a3b5f30df03d420dac991055a933f8a9_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_4ada7c308ec346788d16ebe5143906c2_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_8ac610b37f3b426f94423f8ab043ea95_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_d9c944cadd6c4ab89c64dfec2afc5f04_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_b56284b5b52642848e89ac00e336b8f9_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_b414fecb49d7474c9445a527eb7165f9_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_546a974c77444d15935d6abd6d70165c_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_d37ba8a851ce4113ab9fa35c0833aa7c_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_c4515e7e6bb84efd87687c1f3b7b94d9_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_4b7fa03a2f2e47ffbf82a138e10d493d_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-config.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_09d85567b37644c0a519b7fea9b3c6f5_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_36c7250fe43e45c3a1cb385955b6ccfe_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubConfig")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_ca8d244229cd4d7d8798e6ca96a89e3f_Test()
        {
            var parameters = new MigrationHubConfigEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonMigrationHubConfigEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}