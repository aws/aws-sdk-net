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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.MigrationHubStrategyRecommendations.Endpoints;
using Amazon.MigrationHubStrategyRecommendations.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class MigrationHubStrategyRecommendationsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_e0dfba35283d4a4d9487332a75cb98b8_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_814588cc09b84473b34815da56ec0add_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_528492dd2b1f470d925bb8e5545963c6_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_5b3dd8d88b164a8485dd1f2bbdc744b9_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_b2153a545e744e34951caa2f461b4b04_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_5ca014899db240068b28af596127be0d_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_f5d39750c962406897d68ee928b4bb3a_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_85966f77c79b480fb181b1335c9328ec_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_0faa1b6978b24fa1a01bda704c261746_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_7b3ec8f18157410f85c5815344807921_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_673940ad1f3846ae8a8792ed10c26b8b_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_f59ffeff262f4149b00e41a970ad5fc4_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_cb08c5f7e0364b1b90c37c052ca27a89_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_9373ed814fd040939b3126031c7d35ab_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_21521e83fdea498f9e3550ade7466df5_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_28dfa74e6d7f4448b43d2aff154afaa7_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_d6a8c51ff08948f5835dd0b70ed5c1e2_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_d49dc9d36c814691b742d7f75be80082_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_7bdee7fda3694529b4e6e1c34443e701_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_16565258e25b484cb03b5be8859127ea_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_df0ae4e465da4bcbbd63f69ae010393a_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_ca7d61456ad1489eb9000aa2731a7a79_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_16c5cbfd6d164acf8db9d31846d6397c_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_9a913ac787a94778bf29f68afe948168_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_67360690c4ee4842834bf9c4bd65213d_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_be8e196967254bfab1d7d3b3c2476a85_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_48d78126f987421ab18cd36852cbdbe5_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_02367cab37b8405bb66bcb85141250f7_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://migrationhub-strategy.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_a6e0b11c58ca450884b50920197d6c7b_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_bd7dbfbb55ca45019779c58d23be8831_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_0a5d51eefa48419bbf10327faac06909_Test()
        {
            var parameters = new MigrationHubStrategyRecommendationsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonMigrationHubStrategyRecommendationsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}