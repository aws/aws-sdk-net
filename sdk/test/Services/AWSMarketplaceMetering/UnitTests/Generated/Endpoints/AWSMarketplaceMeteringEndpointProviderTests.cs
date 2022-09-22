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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.AWSMarketplaceMetering.Endpoints;
using Amazon.AWSMarketplaceMetering.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class AWSMarketplaceMeteringEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_e5743e0c1f8e4128b132bec649341fb5_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_fe9e6d61feaa48b4b9365496ca47cdb6_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_356e2fedc64c438f878bab3cdab8b644_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_d1435d0861684c2a83473665ec20aa62_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_244ed1e014594d7ba6633508d3e64876_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_2c6e008ba61342baa2831acfdc96ae81_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_b1f08cbef64143d3acb41845acbe519c_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_8d9512376a004a3e82520a9fa69996d0_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_6bbf656583f3438a8a6d0250f98c8d56_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_32aae99d7ed4418f9b0b396309c87e75_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_3e81425b64b2404b8c3af95d7f20d982_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_60276042ab184f13b56ea9689caf27f6_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_cffb9be877784a69954a15ed9cbe03ec_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_c049a49019074932b4df09dc3cd441cd_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_ce830a51546d411698838016dddc57c5_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_1be9cae41e78479db15c7217e7c8a7b3_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_553b62cc8c444e75afeb0de1818002fb_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_15288c9e781b4877acd695da7c08de04_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_e2a28d9aaa7a4ce7b1912850a215239a_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_35e9a5527df344f5b4be26c70167fa70_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_919fa1f6e8974ca1aa2d4ff45b504ac5_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_3a91f6de9a8e40b7af70b7046350b314_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_c4eef79ab5e3453aac9e4df5d72a8c63_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_cd230e16ddcd4fd599a11bf50342374c_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_2a05e943f582444aba553baf1bdfdf04_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_3c834b1394a7449ba231f3b252280202_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_d744c82f1ee54adc8aacdd3fcfa99b43_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_60f6d7cb5c164f82a058c2e31cf73b2f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_980215b3e7494ab687ad9ae504efccf6_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_9ba0828e6ca547ca8c266c88d6fe3f4b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_c346f51374b54b89a1a92ab7cb52e299_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_740a130d716844af971693cb3547710a_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_d4a7c2b93fc04c29a25eaf91cfa8d775_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_0cad45636ba04106a226eba16498f71b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_cb0fb89628ca44f1ba250c9ee5f192e4_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_81ea4bc68b7a43b086de20b26e4cad28_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_71d9ac98fdd44fbeb26f9ae0dad9e055_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_08dfa1f8b93d4491909fea174e0c2443_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_6ed8b6cc48db4186980ea82de88ddd0a_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_d5c0b36597824c74bfe6b66b981ea9b6_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_e87a92f3729241f782e9b6cfc7e3a17e_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_b1ac382634c24541bf0e3cc07e98b1cd_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_3e26f082b5eb461fb89cf64267148236_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_6941d02582b34b7bb1016a272b73aae1_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_3af4441113c64d82bb1bb34bbb9af0d8_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_d117cb94ee234cb58357c7e966f283f9_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_ba73877b092a40c390ea6a501daad70f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_f34b7ebc8efa44b78bf10e82e6cc7cae_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_d1c0a511bcf54e4a9cf3c7ef72b5c14f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_2e9a2ab49c6d44a9898a4300a5c71b5f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_d9f276b0f3134d3e9f994ddf5432ed41_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_f317c600760441f69d7b6b2e6d60fd2a_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_fdd27c3c49f24a01a45c677434cee287_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_704f9b8dd92148c2ac887fde93b53fd5_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_7e9d41d1be544b2ca055ba2369751767_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_79f1d9a934bf43a3bb45300e3d9aaa6e_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_4587a186055b44fe85edfee148ba96b5_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_c296606151f64b05a8b3d178de091e1e_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_36302eb29d884246af6b284d207ee809_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_f665a741133e46cfae19d58961fd1c75_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_38e30c74656e45c18ac17faed22a6772_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_dbf07769038c4370a7ae261f5e4354d4_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_372c04af39c24a2b9feb64cf95f1e34b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_64f61deb83c545ad8b7a61110dd1421e_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_bfa1d7cd43114f40822e750ef50362a3_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_20dea536775249ff8baf32345d52d202_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_09c35b10d4464f70a375845e9e8ec462_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_8a9adf8762ea4e94bc60cdf723ae3df6_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_3b3fe0509d0645138dab5a10ca1d6c33_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_ec9dfe844fce4b95bf01bea88f51486e_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_963968f969074fe5a4ffe85939938753_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_86b54ce3965d461181c803d691b780a6_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_5985d10d0f4945ff8b24a17e46d2ba25_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_e7b882849b7842bca3f37fc52117d4ab_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_449604b50663410ea219b2cc17f78797_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_b8b6035326204155bf450dd86ffb5cf1_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_c89041b9587c4fb9b0a0dcd57fc3ce49_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_168301843fed4da6b10396ae2da801b7_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_6bed5969123b4846981ca458b3ff94cd_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_b8883c237c6c4db68efe635657469ef7_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_3300f8d3e30f4bad8188b3caa0d2d586_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_4f9d49be45fe40858cb1c0cab76c8277_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_8c51822b390a488e97851a455e197500_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_1f77e5ab5133424abb175d3237fabe7c_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_6d540d3f666f48f7be9337e16dd4c87e_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_9547af2503e641789ff330211be1377f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_c69eacfb082c46ef91e7406cec31860b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_42d9757568374ebcb4dd340ef1b4a3a3_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_d3e06d1133ff4d269924c241a87cfebc_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_7e529888b41d4a3db1c0e2e1c496a23f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_49aaf4a6afad4eb28cfd4077f404b682_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_a8e6a49102c140fcbadcdb5b4aae5c28_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_4346900237944cc7af5ec22618d06008_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_da516d44383e43cfb30f45b4c0682e1b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_f48d49e92c724a559c8267f3276c2411_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_4cde1da0c0604ef79792e2078f26edc4_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_793e46c0222a4fc6aeee9e5d1cec47fc_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_69e8f3e4ab6b4d4d9d40fb66f70aeb59_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_83a17dd5d4fd47ce8580b64396eba2b2_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_499e3e08bfeb45c38e720aea0ca84d71_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_88b6648e37154a15a648c1505a4d007f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_ac026ed94f654236aa1d160f24ff3306_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_734eb36789664e8e920e153815487bb0_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_12211db8c0624c6a888da260897d86d0_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_f63c41b12599442fb0e8daf6dfc8fdce_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_d6c64c156d7b4ed2a9629eac37651d2d_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_3b5d2e17eec2473ea1a92ac91fd6f39b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_7f1a6fe8fff043cdb8c8e51d02734ad4_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_d4897c9e3f7e4b73b8f6c34e555a5632_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_9b9b76acb9ec4b3dbc09bdb215a57d39_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_d7059177426540b080e6ff7a29b71061_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_669465760c1645449d3d15c5c10732d7_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_bbb6d05571b244058b80f630d5ad588f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_0a98d29699c342d8ad05c4cd8589868b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_0c8865f080b644a985bada6d85821e77_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_607943b1386b4cfda44c30f8be69d650_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_ca940a63c6504b7991a311addc7a07f4_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_babdfa6ef50f47ba9c8bc98a3ec78bbe_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_875074a2105446ec8448c6c8e24888ef_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_71ea5182b7c6469f92028dbf3e1cfb8b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_a473270624a04bd38582d1781d9f8232_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_c79dee6603b04cb4a04211f0046aa7b2_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_dad95d49c6c64b86aff1822587b1e2c4_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_b972ff33af4d4e05b7bc254e48a8275b_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://metering.marketplace.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_4f5d22ef65424201865494a3a7ab9c8f_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_dc084ce7337a4ee88dfb99488bb64295_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AWSMarketplaceMetering")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_4e5f5144c3314ee4b0e5e8dd12110208_Test()
        {
            var parameters = new AWSMarketplaceMeteringEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAWSMarketplaceMeteringEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}